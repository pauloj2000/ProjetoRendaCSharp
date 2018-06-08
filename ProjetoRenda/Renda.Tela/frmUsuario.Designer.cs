namespace Renda.Tela
{
    partial class frmUsuario
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
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblSenha = new System.Windows.Forms.Label();
            this.lblMesAtual = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.t = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.btnAlterarSenha = new System.Windows.Forms.Button();
            this.btnAlterarMes = new System.Windows.Forms.Button();
            this.groupBoxAcoes = new System.Windows.Forms.GroupBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnDesfazer = new System.Windows.Forms.Button();
            this.t.SuspendLayout();
            this.groupBoxAcoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(10, 20);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(43, 13);
            this.lblUsuario.TabIndex = 0;
            this.lblUsuario.Text = "Usuário";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(10, 73);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(35, 13);
            this.lblNome.TabIndex = 1;
            this.lblNome.Text = "Nome";
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Location = new System.Drawing.Point(10, 99);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(38, 13);
            this.lblSenha.TabIndex = 2;
            this.lblSenha.Text = "Senha";
            // 
            // lblMesAtual
            // 
            this.lblMesAtual.AutoSize = true;
            this.lblMesAtual.Location = new System.Drawing.Point(10, 125);
            this.lblMesAtual.Name = "lblMesAtual";
            this.lblMesAtual.Size = new System.Drawing.Size(53, 13);
            this.lblMesAtual.TabIndex = 3;
            this.lblMesAtual.Text = "Mês atual";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(10, 44);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(35, 13);
            this.lblEmail.TabIndex = 4;
            this.lblEmail.Text = "E-mail";
            // 
            // t
            // 
            this.t.Controls.Add(this.btnAlterarMes);
            this.t.Controls.Add(this.btnAlterarSenha);
            this.t.Controls.Add(this.textBox5);
            this.t.Controls.Add(this.lblMesAtual);
            this.t.Controls.Add(this.lblEmail);
            this.t.Controls.Add(this.lblNome);
            this.t.Controls.Add(this.textBox4);
            this.t.Controls.Add(this.lblUsuario);
            this.t.Controls.Add(this.textBox3);
            this.t.Controls.Add(this.lblSenha);
            this.t.Controls.Add(this.textBox2);
            this.t.Controls.Add(this.textBox1);
            this.t.Location = new System.Drawing.Point(5, -1);
            this.t.Name = "t";
            this.t.Size = new System.Drawing.Size(238, 153);
            this.t.TabIndex = 5;
            this.t.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(92, 13);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(132, 20);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(92, 41);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(132, 20);
            this.textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(92, 96);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(71, 20);
            this.textBox3.TabIndex = 2;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(92, 70);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(132, 20);
            this.textBox4.TabIndex = 3;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(92, 122);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(71, 20);
            this.textBox5.TabIndex = 5;
            // 
            // btnAlterarSenha
            // 
            this.btnAlterarSenha.Location = new System.Drawing.Point(171, 94);
            this.btnAlterarSenha.Name = "btnAlterarSenha";
            this.btnAlterarSenha.Size = new System.Drawing.Size(53, 23);
            this.btnAlterarSenha.TabIndex = 6;
            this.btnAlterarSenha.Text = "Alterar";
            this.btnAlterarSenha.UseVisualStyleBackColor = true;
            // 
            // btnAlterarMes
            // 
            this.btnAlterarMes.Location = new System.Drawing.Point(171, 120);
            this.btnAlterarMes.Name = "btnAlterarMes";
            this.btnAlterarMes.Size = new System.Drawing.Size(53, 23);
            this.btnAlterarMes.TabIndex = 7;
            this.btnAlterarMes.Text = "Alterar";
            this.btnAlterarMes.UseVisualStyleBackColor = true;
            // 
            // groupBoxAcoes
            // 
            this.groupBoxAcoes.Controls.Add(this.btnDesfazer);
            this.groupBoxAcoes.Controls.Add(this.btnSalvar);
            this.groupBoxAcoes.Location = new System.Drawing.Point(249, -1);
            this.groupBoxAcoes.Name = "groupBoxAcoes";
            this.groupBoxAcoes.Size = new System.Drawing.Size(95, 153);
            this.groupBoxAcoes.TabIndex = 6;
            this.groupBoxAcoes.TabStop = false;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(6, 15);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(84, 23);
            this.btnSalvar.TabIndex = 0;
            this.btnSalvar.Text = "Salvar...";
            this.btnSalvar.UseVisualStyleBackColor = true;
            // 
            // btnDesfazer
            // 
            this.btnDesfazer.Location = new System.Drawing.Point(5, 44);
            this.btnDesfazer.Name = "btnDesfazer";
            this.btnDesfazer.Size = new System.Drawing.Size(84, 23);
            this.btnDesfazer.TabIndex = 1;
            this.btnDesfazer.Text = "Desfazer...";
            this.btnDesfazer.UseVisualStyleBackColor = true;
            // 
            // frmUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 156);
            this.Controls.Add(this.groupBoxAcoes);
            this.Controls.Add(this.t);
            this.Name = "frmUsuario";
            this.Text = "Usuário";
            this.t.ResumeLayout(false);
            this.t.PerformLayout();
            this.groupBoxAcoes.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.Label lblMesAtual;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.GroupBox t;
        private System.Windows.Forms.Button btnAlterarMes;
        private System.Windows.Forms.Button btnAlterarSenha;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        public System.Windows.Forms.GroupBox groupBoxAcoes;
        private System.Windows.Forms.Button btnDesfazer;
        private System.Windows.Forms.Button btnSalvar;
    }
}