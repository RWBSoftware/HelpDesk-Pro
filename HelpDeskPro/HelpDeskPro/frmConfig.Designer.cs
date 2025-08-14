namespace HelpDeskPro
{
    partial class frmConfig
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConfig));
            btnVoltar = new Button();
            btnTrocarConta = new Button();
            label1 = new Label();
            btnMudarSenha = new Button();
            btnAvaliacao = new Button();
            SuspendLayout();
            // 
            // btnVoltar
            // 
            btnVoltar.BackColor = Color.FromArgb(244, 67, 54);
            btnVoltar.FlatAppearance.BorderSize = 0;
            btnVoltar.FlatStyle = FlatStyle.Flat;
            btnVoltar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVoltar.Location = new Point(92, 235);
            btnVoltar.Margin = new Padding(3, 4, 3, 4);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(165, 49);
            btnVoltar.TabIndex = 10;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = false;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // btnTrocarConta
            // 
            btnTrocarConta.BackColor = Color.FromArgb(0, 119, 204);
            btnTrocarConta.FlatAppearance.BorderSize = 0;
            btnTrocarConta.FlatStyle = FlatStyle.Flat;
            btnTrocarConta.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTrocarConta.Location = new Point(92, 121);
            btnTrocarConta.Margin = new Padding(3, 4, 3, 4);
            btnTrocarConta.Name = "btnTrocarConta";
            btnTrocarConta.Size = new Size(165, 49);
            btnTrocarConta.TabIndex = 9;
            btnTrocarConta.Text = "Trocar Conta";
            btnTrocarConta.UseVisualStyleBackColor = false;
            btnTrocarConta.Click += btnTrocarConta_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(52, 9);
            label1.Name = "label1";
            label1.Size = new Size(246, 31);
            label1.TabIndex = 11;
            label1.Text = "Selecione Uma Opção";
            // 
            // btnMudarSenha
            // 
            btnMudarSenha.BackColor = Color.FromArgb(0, 119, 204);
            btnMudarSenha.FlatAppearance.BorderSize = 0;
            btnMudarSenha.FlatStyle = FlatStyle.Flat;
            btnMudarSenha.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMudarSenha.Location = new Point(92, 64);
            btnMudarSenha.Margin = new Padding(3, 4, 3, 4);
            btnMudarSenha.Name = "btnMudarSenha";
            btnMudarSenha.Size = new Size(165, 49);
            btnMudarSenha.TabIndex = 12;
            btnMudarSenha.Text = "Mudar Senha";
            btnMudarSenha.UseVisualStyleBackColor = false;
            btnMudarSenha.Click += btnMudarSenha_Click;
            // 
            // btnAvaliacao
            // 
            btnAvaliacao.BackColor = Color.FromArgb(0, 119, 204);
            btnAvaliacao.FlatAppearance.BorderSize = 0;
            btnAvaliacao.FlatStyle = FlatStyle.Flat;
            btnAvaliacao.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAvaliacao.Location = new Point(92, 178);
            btnAvaliacao.Margin = new Padding(3, 4, 3, 4);
            btnAvaliacao.Name = "btnAvaliacao";
            btnAvaliacao.Size = new Size(165, 49);
            btnAvaliacao.TabIndex = 13;
            btnAvaliacao.Text = "Avaliação";
            btnAvaliacao.UseVisualStyleBackColor = false;
            btnAvaliacao.Click += btnAvaliacao_Click;
            // 
            // frmConfig
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 246, 247);
            ClientSize = new Size(350, 303);
            Controls.Add(btnAvaliacao);
            Controls.Add(btnMudarSenha);
            Controls.Add(label1);
            Controls.Add(btnVoltar);
            Controls.Add(btnTrocarConta);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "frmConfig";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "HelpDesk Pro";
            Load += frmConfig_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnVoltar;
        private Button btnTrocarConta;
        private Label label1;
        private Button btnMudarSenha;
        private Button btnAvaliacao;
    }
}