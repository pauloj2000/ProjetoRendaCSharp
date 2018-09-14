namespace Renda.Tela
{
    partial class frmLogin
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
            this.groupBoxLogin = new System.Windows.Forms.GroupBox();
            this.lblEsqueci = new System.Windows.Forms.Label();
            this.lblCadastrar = new System.Windows.Forms.Label();
            this.btnLogar = new System.Windows.Forms.Button();
            this.lblSenha = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.txbSenha = new System.Windows.Forms.TextBox();
            this.txbUsuario = new System.Windows.Forms.TextBox();
            this.groupBoxLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxLogin
            // 
            this.groupBoxLogin.Controls.Add(this.lblEsqueci);
            this.groupBoxLogin.Controls.Add(this.lblCadastrar);
            this.groupBoxLogin.Controls.Add(this.btnLogar);
            this.groupBoxLogin.Controls.Add(this.lblSenha);
            this.groupBoxLogin.Controls.Add(this.lblUsuario);
            this.groupBoxLogin.Controls.Add(this.txbSenha);
            this.groupBoxLogin.Controls.Add(this.txbUsuario);
            this.groupBoxLogin.Location = new System.Drawing.Point(5, 0);
            this.groupBoxLogin.Name = "groupBoxLogin";
            this.groupBoxLogin.Size = new System.Drawing.Size(196, 182);
            this.groupBoxLogin.TabIndex = 0;
            this.groupBoxLogin.TabStop = false;
            // 
            // lblEsqueci
            // 
            this.lblEsqueci.AutoSize = true;
            this.lblEsqueci.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblEsqueci.Location = new System.Drawing.Point(36, 156);
            this.lblEsqueci.Name = "lblEsqueci";
            this.lblEsqueci.Size = new System.Drawing.Size(117, 13);
            this.lblEsqueci.TabIndex = 7;
            this.lblEsqueci.Text = "Esqueci minha senha...";
            // 
            // lblCadastrar
            // 
            this.lblCadastrar.AutoSize = true;
            this.lblCadastrar.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblCadastrar.Location = new System.Drawing.Point(25, 133);
            this.lblCadastrar.Name = "lblCadastrar";
            this.lblCadastrar.Size = new System.Drawing.Size(145, 13);
            this.lblCadastrar.TabIndex = 6;
            this.lblCadastrar.Text = "Ainda não possuo cadastro...";
            // 
            // btnLogar
            // 
            this.btnLogar.Location = new System.Drawing.Point(57, 97);
            this.btnLogar.Name = "btnLogar";
            this.btnLogar.Size = new System.Drawing.Size(83, 23);
            this.btnLogar.TabIndex = 5;
            this.btnLogar.Text = "Realizar login";
            this.btnLogar.UseVisualStyleBackColor = true;
            this.btnLogar.Click += new System.EventHandler(this.btnLogar_Click);
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Location = new System.Drawing.Point(79, 55);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(38, 13);
            this.lblSenha.TabIndex = 4;
            this.lblSenha.Text = "Senha";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(64, 16);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(76, 13);
            this.lblUsuario.TabIndex = 3;
            this.lblUsuario.Text = "Usuário/E-mail";
            // 
            // txbSenha
            // 
            this.txbSenha.Location = new System.Drawing.Point(57, 71);
            this.txbSenha.Name = "txbSenha";
            this.txbSenha.Size = new System.Drawing.Size(83, 20);
            this.txbSenha.TabIndex = 2;
            // 
            // txbUsuario
            // 
            this.txbUsuario.Location = new System.Drawing.Point(28, 32);
            this.txbUsuario.Name = "txbUsuario";
            this.txbUsuario.Size = new System.Drawing.Size(142, 20);
            this.txbUsuario.TabIndex = 1;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(207, 187);
            this.Controls.Add(this.groupBoxLogin);
            this.Name = "frmLogin";
            this.Text = "Login";
            this.groupBoxLogin.ResumeLayout(false);
            this.groupBoxLogin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxLogin;
        private System.Windows.Forms.TextBox txbSenha;
        private System.Windows.Forms.TextBox txbUsuario;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblEsqueci;
        private System.Windows.Forms.Label lblCadastrar;
        private System.Windows.Forms.Button btnLogar;
    }
}