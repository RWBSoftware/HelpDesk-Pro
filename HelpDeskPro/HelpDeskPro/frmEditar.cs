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
    public partial class frmEditar : Form
    {
        public frmEditar()
        {
            InitializeComponent();
            PopularDGV();
        }

        public void PopularDGV()
        {
            BancoDeDados bancoDeDados = new BancoDeDados();
            dgv.DataSource = bancoDeDados.ExibirChamados();
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.MultiSelect = false;
        }

        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            if (dgv.SelectedRows.Count > 0)
            {
                frmCriar frmCriar = new frmCriar(
                    Convert.ToInt32(dgv.SelectedRows[0].Cells["ID"].Value),
                    dgv.SelectedRows[0].Cells["Titulo"].Value.ToString(),
                    dgv.SelectedRows[0].Cells["Descricao"].Value.ToString(),
                    dgv.SelectedRows[0].Cells["Status"].Value.ToString()
                    );
                frmCriar.Show();
                this.Close();
            }
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            if (dgv.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dgv.SelectedRows[0].Cells["ID"].Value);
                var confirm = MessageBox.Show("Deseja realmente excluir o chamado?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirm == DialogResult.Yes)
                {
                    BancoDeDados bancoDeDados = new BancoDeDados();
                    bancoDeDados.ExcluirChamado(id);
                }
            } 
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmMenuPrincipal frmMenuPrincipal = new frmMenuPrincipal();
            frmMenuPrincipal.Show();
            this.Close();
        }
    }
}
