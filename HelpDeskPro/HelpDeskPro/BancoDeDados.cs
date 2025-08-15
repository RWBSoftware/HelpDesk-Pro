using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
//using Microsoft.SqlServer.Server;
using System.Data.SQLite;
using Microsoft.Data.Sqlite;

namespace HelpDeskPro
{
    public class DashboardChamados
    {
        public string Periodo { get; set; }
        public int Total { get; set; }
        public int Resolvidos { get; set; }
        public int EmAberto { get; set; }
        public int EmAndamento { get; set; }
    }


    public class BancoDeDados
    {
        public SqlConnection conexaoa = new SqlConnection(
    @"Data Source=(LocalDB)\MSSQLLocalDB;
      AttachDbFilename=|DataDirectory|\HelpDeskProBD.mdf;
      Integrated Security=True;
      Connect Timeout=30");
        public SqliteConnection conexao = new SqliteConnection("Data Source=C:\\Users\\kauac\\OneDrive\\Documentos\\Projetos\\HelpDeskPro\\HelpDeskPro\\Data\\BancoDeDados");
        public SqliteCommand cmd = new SqliteCommand();
        public SqliteDataReader dr;

        public bool Login(string usuario, string senha)
        {
            try
            {
                conexao.Open();
                cmd.Connection = conexao;
                cmd.CommandText = "SELECT * FROM Usuarios WHERE Usuario = @usuario AND Senha = @senha";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@usuario", usuario);
                cmd.Parameters.AddWithValue("@senha", senha);
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                    return true;
                else
                    return false;
            }
            catch(Exception erro) { MessageBox.Show("Erro ao conectar ao banco de dados!" + erro.Message); return false; }
            finally { conexao.Close(); }
        }

        public bool Cadastro(string usuario, string senha)
        {
            try
            {
                conexao.Open();
                cmd.Connection = conexao;
                cmd.CommandText = "INSERT INTO Usuarios (Usuario, Senha) VALUES (@usuario, @senha)";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@usuario", usuario);
                cmd.Parameters.AddWithValue("@senha", senha);
                int linhasAfetadas = cmd.ExecuteNonQuery();
                if(linhasAfetadas >= 1)
                    return true;
                else
                    return false;
            }
            catch (Exception ex) { return false; }
            finally { conexao.Close(); }
        }

        public bool CriarChamado(string titulo, string descricao, string status, string responsavel)
        {
            try
            {
                conexao.Open();
                cmd.Connection = conexao;
                cmd.Parameters.Clear();
                cmd.CommandText = @"INSERT INTO Chamados (Titulo, Descricao, Status, Responsavel) VALUES (@titulo, @descricao, @status, @responsavel)";
                cmd.Parameters.AddWithValue("@titulo", titulo);
                cmd.Parameters.AddWithValue("@descricao", descricao);
                cmd.Parameters.AddWithValue("@status", status);
                cmd.Parameters.AddWithValue("@responsavel", string.IsNullOrEmpty(responsavel) ? DBNull.Value : (object)responsavel);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex) { return false; }
            finally { conexao.Close(); }
        }

        public List<DashboardChamados> ObterDashboardChamados(string tipoAgrupamento)
        {
            List<DashboardChamados> lista = new List<DashboardChamados>();

            try
            {
                conexao.Open();
                cmd.Connection = conexao;
                cmd.Parameters.Clear();

                cmd.CommandText = @"
            SELECT 
                CASE 
                    WHEN @TipoAgrupamento = 'diario' THEN CONVERT(VARCHAR, DataCriacao, 23)
                    WHEN @TipoAgrupamento = 'semanal' THEN CONCAT(DATEPART(YEAR, DataCriacao), '-W', DATEPART(WEEK, DataCriacao))
                    WHEN @TipoAgrupamento = 'mensal' THEN CONCAT(DATEPART(YEAR, DataCriacao), '-', FORMAT(DataCriacao, 'MM'))
                END AS Periodo,

                COUNT(*) AS Total,
                SUM(CASE WHEN Status = 'Resolvido'    THEN 1 ELSE 0 END) AS Resolvidos,
                SUM(CASE WHEN Status = 'Aberto'    THEN 1 ELSE 0 END) AS EmAberto,
                SUM(CASE WHEN Status = 'Em Andamento' THEN 1 ELSE 0 END) AS EmAndamento

            FROM Chamados
            GROUP BY 
                CASE 
                    WHEN @TipoAgrupamento = 'diario' THEN CONVERT(VARCHAR, DataCriacao, 23)
                    WHEN @TipoAgrupamento = 'semanal' THEN CONCAT(DATEPART(YEAR, DataCriacao), '-W', DATEPART(WEEK, DataCriacao))
                    WHEN @TipoAgrupamento = 'mensal' THEN CONCAT(DATEPART(YEAR, DataCriacao), '-', FORMAT(DataCriacao, 'MM'))
                END
            ORDER BY Periodo DESC;";

                cmd.Parameters.AddWithValue("@TipoAgrupamento", tipoAgrupamento);

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        lista.Add(new DashboardChamados
                        {
                            Periodo = reader["Periodo"].ToString(),
                            Total = Convert.ToInt32(reader["Total"]),
                            Resolvidos = Convert.ToInt32(reader["Resolvidos"]),
                            EmAberto = Convert.ToInt32(reader["EmAberto"]),
                            EmAndamento = Convert.ToInt32(reader["EmAndamento"])
                        });
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show("Erro ao obter dados do dashboard: " + ex.Message); }
            finally { conexao.Close(); }
            return lista;
        }

        public DataTable ExibirChamados()
        {
            try
            {
                conexao.Open();
                cmd.Connection = conexao;
                cmd.CommandText = "SELECT * FROM Chamados";
                cmd.Parameters.Clear();
                DataTable dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                return dt;
            }
            catch { return null; }
            finally{ conexao.Close(); }
        }

        public void ExcluirChamado(int Id)
        {
            try
            {
                conexao.Open();
                cmd.Connection = conexao;
                cmd.CommandText = "DELETE FROM Chamados WHERE ID = @id";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", Id);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Chamado excluído com sucesso!");
            }
            catch { MessageBox.Show("Erro ao excluir o chamado!"); }
            finally { conexao.Close(); }
        }

        public bool AlterarChamado(int id, string titulo, string descricao, string status, string responsavel)
        {
            try
            {
                conexao.Open();
                cmd.Connection = conexao;
                cmd.Parameters.Clear();

                cmd.CommandText = @"UPDATE Chamados SET Titulo = @titulo, Descricao = @descricao, Status = @status, Responsavel = @responsavel WHERE ID = @id";
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@titulo", titulo);
                cmd.Parameters.AddWithValue("@descricao", descricao);
                cmd.Parameters.AddWithValue("@status", status);
                cmd.Parameters.AddWithValue("@responsavel", string.IsNullOrEmpty(responsavel) ? DBNull.Value : (object)responsavel);

                int linhasAfetadas = cmd.ExecuteNonQuery();

                if (linhasAfetadas > 0)
                {
                    MessageBox.Show("Chamado alterado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
                else
                {
                    MessageBox.Show("Nenhum chamado encontrado para alteração.");
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao alterar chamado: " + ex.Message);
                return false;
            }
            finally { conexao.Close(); }
        }

    }
}
