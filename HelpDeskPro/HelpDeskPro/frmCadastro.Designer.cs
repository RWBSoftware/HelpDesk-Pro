namespace HelpDeskPro
{
    partial class frmCadastro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastro));
            btnVoltar = new Button();
            btnEntrar = new Button();
            cBoxMostrarSenha = new CheckBox();
            txtBoxSenha = new TextBox();
            txtBoxUsuario = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtBoxSenhaNovamente = new TextBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // btnVoltar
            // 
            btnVoltar.BackColor = Color.FromArgb(244, 67, 54);
            btnVoltar.FlatAppearance.BorderSize = 0;
            btnVoltar.FlatStyle = FlatStyle.Flat;
            btnVoltar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVoltar.Location = new Point(102, 343);
            btnVoltar.Margin = new Padding(3, 4, 3, 4);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(145, 49);
            btnVoltar.TabIndex = 17;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = false;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // btnEntrar
            // 
            btnEntrar.BackColor = Color.FromArgb(0, 119, 204);
            btnEntrar.FlatAppearance.BorderSize = 0;
            btnEntrar.FlatStyle = FlatStyle.Flat;
            btnEntrar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEntrar.Location = new Point(102, 286);
            btnEntrar.Margin = new Padding(3, 4, 3, 4);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(145, 49);
            btnEntrar.TabIndex = 16;
            btnEntrar.Text = "Entrar";
            btnEntrar.UseVisualStyleBackColor = false;
            btnEntrar.Click += btnEntrar_Click;
            // 
            // cBoxMostrarSenha
            // 
            cBoxMostrarSenha.AutoSize = true;
            cBoxMostrarSenha.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cBoxMostrarSenha.Location = new Point(109, 255);
            cBoxMostrarSenha.Name = "cBoxMostrarSenha";
            cBoxMostrarSenha.Size = new Size(131, 24);
            cBoxMostrarSenha.TabIndex = 14;
            cBoxMostrarSenha.Text = "Mostrar Senha";
            cBoxMostrarSenha.UseVisualStyleBackColor = true;
            cBoxMostrarSenha.CheckedChanged += cBoxMostrarSenha_CheckedChanged;
            // 
            // txtBoxSenha
            // 
            txtBoxSenha.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBoxSenha.Location = new Point(78, 147);
            txtBoxSenha.MaxLength = 60;
            txtBoxSenha.Name = "txtBoxSenha";
            txtBoxSenha.Size = new Size(193, 32);
            txtBoxSenha.TabIndex = 13;
            txtBoxSenha.UseSystemPasswordChar = true;
            // 
            // txtBoxUsuario
            // 
            txtBoxUsuario.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBoxUsuario.Location = new Point(78, 80);
            txtBoxUsuario.MaxLength = 60;
            txtBoxUsuario.Name = "txtBoxUsuario";
            txtBoxUsuario.Size = new Size(193, 32);
            txtBoxUsuario.TabIndex = 12;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(78, 119);
            label3.Name = "label3";
            label3.Size = new Size(66, 25);
            label3.TabIndex = 11;
            label3.Text = "Senha:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(78, 52);
            label2.Name = "label2";
            label2.Size = new Size(80, 25);
            label2.TabIndex = 10;
            label2.Text = "Usuário:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(61, 9);
            label1.Name = "label1";
            label1.Size = new Size(227, 31);
            label1.TabIndex = 9;
            label1.Text = "Efetue Seu Cadastro";
            // 
            // txtBoxSenhaNovamente
            // 
            txtBoxSenhaNovamente.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBoxSenhaNovamente.Location = new Point(78, 217);
            txtBoxSenhaNovamente.MaxLength = 60;
            txtBoxSenhaNovamente.Name = "txtBoxSenhaNovamente";
            txtBoxSenhaNovamente.Size = new Size(193, 32);
            txtBoxSenhaNovamente.TabIndex = 19;
            txtBoxSenhaNovamente.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(78, 189);
            label4.Name = "label4";
            label4.Size = new Size(173, 25);
            label4.TabIndex = 18;
            label4.Text = "Senha Novamente: ";
            // 
            // frmCadastro
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 246, 247);
            ClientSize = new Size(350, 425);
            Controls.Add(txtBoxSenhaNovamente);
            Controls.Add(label4);
            Controls.Add(btnVoltar);
            Controls.Add(btnEntrar);
            Controls.Add(cBoxMostrarSenha);
            Controls.Add(txtBoxSenha);
            Controls.Add(txtBoxUsuario);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "frmCadastro";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "HelpDesk Pro";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnVoltar;
        private Button btnEntrar;
        private CheckBox cBoxMostrarSenha;
        private TextBox txtBoxSenha;
        private TextBox txtBoxUsuario;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtBoxSenhaNovamente;
        private Label label4;
    }
}