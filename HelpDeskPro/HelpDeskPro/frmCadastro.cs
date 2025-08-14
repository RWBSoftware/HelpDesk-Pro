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
    public partial class frmCadastro : Form
    {
        public frmCadastro()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }

        private void cBoxMostrarSenha_CheckedChanged(object sender, EventArgs e)
        {
            txtBoxSenha.UseSystemPasswordChar = !cBoxMostrarSenha.Checked;
            txtBoxSenhaNovamente.UseSystemPasswordChar = !cBoxMostrarSenha.Checked;
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if(txtBoxUsuario.Text.Length < 4)
            {
                MessageBox.Show("O nome de usuário deve ter pelo menos 4 caracteres.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtBoxSenha.Text.Length < 6)
            {
                MessageBox.Show("A senha deve ter pelo menos 6 caracteres.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtBoxSenha.Text != txtBoxSenhaNovamente.Text)
            {
                MessageBox.Show("As senhas não coincidem.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                BancoDeDados bancoDeDados = new BancoDeDados();
                HashSenha hash = new HashSenha(); 
                if (bancoDeDados.Cadastro(txtBoxUsuario.Text, hash.GerarHash(txtBoxSenha.Text)))
                {
                    frmMenuPrincipal frmMenuPrincipal = new frmMenuPrincipal();
                    frmMenuPrincipal.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Erro ao cadastrar usuário.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }                
        }
    }
}
