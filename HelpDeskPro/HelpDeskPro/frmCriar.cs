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
