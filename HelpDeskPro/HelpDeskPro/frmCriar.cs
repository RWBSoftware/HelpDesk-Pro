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
        public frmCriar()
        {
            InitializeComponent();
        }

        private void frmCriar_Load(object sender, EventArgs e)
        {

        }

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
                if (bancoDeDados.CriarChamado(txtTitulo.Text, txtDescricao.Text, "Aberto", "Nulo"))
                {
                    MessageBox.Show("Chamado criado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmMenuPrincipal frmMenu = new frmMenuPrincipal();
                    frmMenu.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Erro ao criar chamado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtTitulo.Clear();
            txtDescricao.Clear();
            txtTitulo.Focus();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmMenuPrincipal frmMenu = new frmMenuPrincipal();
            frmMenu.Show();
            this.Close();
        }
    }
}
