namespace HelpDeskPro
{
    partial class frmMenuPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenuPrincipal));
            panel1 = new Panel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            btnCriar = new Button();
            btnEditar = new Button();
            button1 = new Button();
            btnConfig = new Button();
            btnSair = new Button();
            lblData = new Label();
            panel2 = new Panel();
            lblTotal = new Label();
            label1 = new Label();
            panel3 = new Panel();
            lblAberto = new Label();
            label8 = new Label();
            lblResolvidos = new Label();
            label4 = new Label();
            panel4 = new Panel();
            lblAndamento = new Label();
            label6 = new Label();
            panel5 = new Panel();
            cBoxFiltro = new ComboBox();
            panel6 = new Panel();
            lblCancelada = new Label();
            label10 = new Label();
            panel7 = new Panel();
            lblNaoResolvidos = new Label();
            label12 = new Label();
            panel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            panel7.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(51, 51, 51);
            panel1.Controls.Add(flowLayoutPanel1);
            panel1.Controls.Add(lblData);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(224, 450);
            panel1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(btnCriar);
            flowLayoutPanel1.Controls.Add(btnEditar);
            flowLayoutPanel1.Controls.Add(button1);
            flowLayoutPanel1.Controls.Add(btnConfig);
            flowLayoutPanel1.Controls.Add(btnSair);
            flowLayoutPanel1.Location = new Point(0, 57);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(221, 393);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // btnCriar
            // 
            btnCriar.BackColor = Color.FromArgb(0, 119, 204);
            btnCriar.FlatAppearance.BorderSize = 0;
            btnCriar.FlatStyle = FlatStyle.Flat;
            btnCriar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCriar.Location = new Point(3, 4);
            btnCriar.Margin = new Padding(3, 4, 3, 4);
            btnCriar.Name = "btnCriar";
            btnCriar.Size = new Size(218, 49);
            btnCriar.TabIndex = 9;
            btnCriar.Text = "Criar";
            btnCriar.UseVisualStyleBackColor = false;
            btnCriar.Click += btnCriar_Click;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.FromArgb(0, 119, 204);
            btnEditar.FlatAppearance.BorderSize = 0;
            btnEditar.FlatStyle = FlatStyle.Flat;
            btnEditar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEditar.Location = new Point(3, 61);
            btnEditar.Margin = new Padding(3, 4, 3, 4);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(218, 49);
            btnEditar.TabIndex = 10;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += btnEditar_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(0, 119, 204);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(3, 118);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(218, 49);
            button1.TabIndex = 11;
            button1.Text = "Relatorio";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btnConfig
            // 
            btnConfig.BackColor = Color.FromArgb(0, 119, 204);
            btnConfig.FlatAppearance.BorderSize = 0;
            btnConfig.FlatStyle = FlatStyle.Flat;
            btnConfig.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConfig.Location = new Point(3, 175);
            btnConfig.Margin = new Padding(3, 4, 3, 4);
            btnConfig.Name = "btnConfig";
            btnConfig.Size = new Size(218, 49);
            btnConfig.TabIndex = 12;
            btnConfig.Text = "Configuração";
            btnConfig.UseVisualStyleBackColor = false;
            btnConfig.Click += btnConfig_Click;
            // 
            // btnSair
            // 
            btnSair.BackColor = Color.FromArgb(244, 67, 54);
            btnSair.FlatAppearance.BorderSize = 0;
            btnSair.FlatStyle = FlatStyle.Flat;
            btnSair.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSair.Location = new Point(3, 232);
            btnSair.Margin = new Padding(3, 4, 3, 4);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(218, 49);
            btnSair.TabIndex = 13;
            btnSair.Text = "Sair";
            btnSair.UseVisualStyleBackColor = false;
            btnSair.Click += btnSair_Click;
            // 
            // lblData
            // 
            lblData.AutoSize = true;
            lblData.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblData.ForeColor = Color.FromArgb(204, 204, 204);
            lblData.Location = new Point(12, 9);
            lblData.Name = "lblData";
            lblData.Size = new Size(162, 28);
            lblData.TabIndex = 0;
            lblData.Text = "01/01/2000 10:00";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(31, 31, 31);
            panel2.Controls.Add(lblTotal);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(272, 57);
            panel2.Name = "panel2";
            panel2.Size = new Size(230, 100);
            panel2.TabIndex = 11;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold);
            lblTotal.ForeColor = Color.White;
            lblTotal.Location = new Point(98, 49);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(33, 38);
            lblTotal.TabIndex = 13;
            lblTotal.Text = "0";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(76, 11);
            label1.Name = "label1";
            label1.Size = new Size(78, 38);
            label1.TabIndex = 12;
            label1.Text = "Total";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(31, 31, 31);
            panel3.Controls.Add(lblAberto);
            panel3.Controls.Add(label8);
            panel3.Location = new Point(523, 57);
            panel3.Name = "panel3";
            panel3.Size = new Size(230, 100);
            panel3.TabIndex = 12;
            // 
            // lblAberto
            // 
            lblAberto.AutoSize = true;
            lblAberto.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold);
            lblAberto.ForeColor = Color.FromArgb(255, 152, 0);
            lblAberto.Location = new Point(98, 49);
            lblAberto.Name = "lblAberto";
            lblAberto.Size = new Size(33, 38);
            lblAberto.TabIndex = 13;
            lblAberto.Text = "0";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold);
            label8.ForeColor = Color.FromArgb(255, 152, 0);
            label8.Location = new Point(62, 11);
            label8.Name = "label8";
            label8.Size = new Size(106, 38);
            label8.TabIndex = 12;
            label8.Text = "Aberto";
            // 
            // lblResolvidos
            // 
            lblResolvidos.AutoSize = true;
            lblResolvidos.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold);
            lblResolvidos.ForeColor = Color.FromArgb(76, 175, 80);
            lblResolvidos.Location = new Point(98, 58);
            lblResolvidos.Name = "lblResolvidos";
            lblResolvidos.Size = new Size(33, 38);
            lblResolvidos.TabIndex = 13;
            lblResolvidos.Text = "0";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold);
            label4.ForeColor = Color.FromArgb(76, 175, 80);
            label4.Location = new Point(39, 16);
            label4.Name = "label4";
            label4.Size = new Size(151, 38);
            label4.TabIndex = 12;
            label4.Text = "Resolvidos";
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(31, 31, 31);
            panel4.Controls.Add(lblAndamento);
            panel4.Controls.Add(label6);
            panel4.Location = new Point(272, 180);
            panel4.Name = "panel4";
            panel4.Size = new Size(230, 100);
            panel4.TabIndex = 13;
            // 
            // lblAndamento
            // 
            lblAndamento.AutoSize = true;
            lblAndamento.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold);
            lblAndamento.ForeColor = Color.FromArgb(33, 150, 243);
            lblAndamento.Location = new Point(98, 54);
            lblAndamento.Name = "lblAndamento";
            lblAndamento.Size = new Size(33, 38);
            lblAndamento.TabIndex = 13;
            lblAndamento.Text = "0";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold);
            label6.ForeColor = Color.FromArgb(33, 150, 243);
            label6.Location = new Point(7, 16);
            label6.Name = "label6";
            label6.Size = new Size(215, 38);
            label6.TabIndex = 12;
            label6.Text = "Em Andamento";
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(31, 31, 31);
            panel5.Controls.Add(lblResolvidos);
            panel5.Controls.Add(label4);
            panel5.Location = new Point(523, 180);
            panel5.Name = "panel5";
            panel5.Size = new Size(230, 100);
            panel5.TabIndex = 14;
            // 
            // cBoxFiltro
            // 
            cBoxFiltro.DropDownStyle = ComboBoxStyle.DropDownList;
            cBoxFiltro.FlatStyle = FlatStyle.Flat;
            cBoxFiltro.FormattingEnabled = true;
            cBoxFiltro.Items.AddRange(new object[] { "Diário", "Semanal", "Mensal" });
            cBoxFiltro.Location = new Point(237, 13);
            cBoxFiltro.Name = "cBoxFiltro";
            cBoxFiltro.Size = new Size(130, 28);
            cBoxFiltro.TabIndex = 15;
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(31, 31, 31);
            panel6.Controls.Add(lblCancelada);
            panel6.Controls.Add(label10);
            panel6.Location = new Point(523, 303);
            panel6.Name = "panel6";
            panel6.Size = new Size(230, 100);
            panel6.TabIndex = 17;
            // 
            // lblCancelada
            // 
            lblCancelada.AutoSize = true;
            lblCancelada.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold);
            lblCancelada.ForeColor = Color.FromArgb(244, 67, 54);
            lblCancelada.Location = new Point(98, 54);
            lblCancelada.Name = "lblCancelada";
            lblCancelada.Size = new Size(33, 38);
            lblCancelada.TabIndex = 13;
            lblCancelada.Text = "0";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold);
            label10.ForeColor = Color.FromArgb(244, 67, 54);
            label10.Location = new Point(41, 16);
            label10.Name = "label10";
            label10.Size = new Size(147, 38);
            label10.TabIndex = 12;
            label10.Text = "Cancelada";
            // 
            // panel7
            // 
            panel7.BackColor = Color.FromArgb(31, 31, 31);
            panel7.Controls.Add(lblNaoResolvidos);
            panel7.Controls.Add(label12);
            panel7.Location = new Point(272, 303);
            panel7.Name = "panel7";
            panel7.Size = new Size(230, 100);
            panel7.TabIndex = 16;
            // 
            // lblNaoResolvidos
            // 
            lblNaoResolvidos.AutoSize = true;
            lblNaoResolvidos.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold);
            lblNaoResolvidos.ForeColor = Color.FromArgb(244, 67, 54);
            lblNaoResolvidos.Location = new Point(98, 54);
            lblNaoResolvidos.Name = "lblNaoResolvidos";
            lblNaoResolvidos.Size = new Size(33, 38);
            lblNaoResolvidos.TabIndex = 13;
            lblNaoResolvidos.Text = "0";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold);
            label12.ForeColor = Color.FromArgb(244, 67, 54);
            label12.Location = new Point(9, 16);
            label12.Name = "label12";
            label12.Size = new Size(212, 38);
            label12.TabIndex = 12;
            label12.Text = "Não Resolvidos";
            // 
            // frmMenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 246, 247);
            ClientSize = new Size(800, 450);
            Controls.Add(panel6);
            Controls.Add(panel7);
            Controls.Add(cBoxFiltro);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "frmMenuPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "HelpDesk Pro";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lblData;
        private Button btnCriar;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel2;
        private Label label1;
        private Label lblTotal;
        private Panel panel3;
        private Label lblResolvidos;
        private Label label4;
        private Panel panel4;
        private Label lblAndamento;
        private Label label6;
        private Panel panel5;
        private Label lblAberto;
        private Label label8;
        private ComboBox cBoxFiltro;
        private Panel panel6;
        private Label lblCancelada;
        private Label label10;
        private Panel panel7;
        private Label lblNaoResolvidos;
        private Label label12;
        private Button btnEditar;
        private Button button1;
        private Button btnConfig;
        private Button btnSair;
    }
}