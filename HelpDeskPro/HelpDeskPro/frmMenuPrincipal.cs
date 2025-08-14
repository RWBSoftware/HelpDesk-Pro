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
    public partial class frmMenuPrincipal : Form
    {
        public frmMenuPrincipal()
        {
            InitializeComponent();
            Data();
            DistribuirValor();
        }

        public void Data()
        {
            var data = DateTime.Now;
            lblData.Text = data.ToString("dd/MM/yyyy HH:mm");
        }

        public void DistribuirValor()
        {
            cBoxFiltro.SelectedIndex = 0;
        }


        private void btnCriar_Click(object sender, EventArgs e)
        {
            frmCriar frmCriar = new frmCriar();
            frmCriar.Show();
            this.Close();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnConfig_Click(object sender, EventArgs e)
        {
            frmConfig frmConfig = new frmConfig();
            frmConfig.Show();
            this.Close();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }
    }
}
