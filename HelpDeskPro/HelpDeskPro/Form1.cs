namespace HelpDeskPro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            frmLogin frmlogin = new frmLogin();
            frmlogin.Show();
            this.Hide();    
        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            frmCadastro frmCadastro = new frmCadastro();
            frmCadastro.Show();
            this.Hide();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }
    }
}
