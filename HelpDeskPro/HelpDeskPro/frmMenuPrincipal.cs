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
            cBoxFiltro.SelectedIndex = 0;
        }

        public void Data()
        {
            var data = DateTime.Now;
            lblData.Text = data.ToString("dd/MM/yyyy HH:mm");
        }

        public void DistribuirValor()
        {
            BancoDeDados bancoDeDados = new BancoDeDados();
            var tipo = cBoxFiltro.Text;
            var dashboardChamados = bancoDeDados.ObterDashboardChamados(tipo.ToLower());
            foreach (var itens in dashboardChamados)
            {
                lblTotal.Text = itens.Total.ToString();
                lblResolvidos.Text = itens.Resolvidos.ToString();
                lblAberto.Text = itens.EmAberto.ToString();
                lblAndamento.Text = itens.EmAndamento.ToString();
            }
        }

        private void btnCriar_Click(object sender, EventArgs e)
        {
            frmCriar frmCriar = new frmCriar();
            frmCriar.Show();
            this.Close();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            frmEditar frmEditar = new frmEditar();
            frmEditar.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Em Breve", "Proxima Atualização", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private void cBoxFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {
            DistribuirValor();
        }
    }
}
