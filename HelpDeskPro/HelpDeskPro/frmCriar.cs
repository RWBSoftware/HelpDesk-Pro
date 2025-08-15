using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelpDeskPro
{
    public partial class frmCriar : Form
    {
        int id = 0;
        public frmCriar(int i = 0, string titulo = "", string descricao = "", string status = "")
        {
            InitializeComponent();
            id = i;
            if(i != 0) { ModoEdicao(titulo, descricao, status); }
            else { cmbStatus.SelectedIndex = 0; }
        }

        public void ModoEdicao(string titulo, string descricao, string status)
        {
            txtTitulo.Text = titulo;
            txtDescricao.Text = descricao;
            switch (status)
            {
                case "Aberto":
                    cmbStatus.SelectedIndex = 0;
                    break;
                case "Em Andamento":
                    cmbStatus.SelectedIndex = 1;
                    break;
                case "Resolvido":
                    cmbStatus.SelectedIndex = 2;
                    break;
            }
        }

        private void frmCriar_Load(object sender, EventArgs e) { }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if(txtTitulo.Text.Length < 4)
            {
                MessageBox.Show("O título deve ter pelo menos 4 caracteres.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtDescricao.Text.Length < 10)
            {
                MessageBox.Show("A descrição deve ter pelo menos 10 caracteres.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                BancoDeDados bancoDeDados = new BancoDeDados();
                if(id != 0)
                    bancoDeDados.AlterarChamado(id, txtTitulo.Text, txtDescricao.Text, cmbStatus.Text, "Nulo");
                else
                {
                    if (bancoDeDados.CriarChamado(txtTitulo.Text, txtDescricao.Text, cmbStatus.Text, "Nulo"))
                    {
                        MessageBox.Show("Chamado criado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        frmMenuPrincipal frmMenu = new frmMenuPrincipal();
                        frmMenu.Show();
                        this.Close();
                    }
                    else { MessageBox.Show("Erro ao criar chamado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                }
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtTitulo.Clear();
            txtDescricao.Clear();
            txtTitulo.Focus();
            cmbStatus.SelectedIndex = 0;
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            if (id != 0)
            {
                frmEditar frmEditar = new frmEditar();
                frmEditar.Show();
                this.Close();
            }
            else
            {
                frmMenuPrincipal frmMenu = new frmMenuPrincipal();
                frmMenu.Show();
                this.Close();
            }
        }
    }
}
