namespace Renda.Tela
{
    partial class frmRendaMensal
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
            this.groupBoxRenda = new System.Windows.Forms.GroupBox();
            this.groupBoxAcoes = new System.Windows.Forms.GroupBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.botaoDesfazer = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBoxRenda.SuspendLayout();
            this.groupBoxAcoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxRenda
            // 
            this.groupBoxRenda.Controls.Add(this.label3);
            this.groupBoxRenda.Controls.Add(this.textBox3);
            this.groupBoxRenda.Controls.Add(this.label2);
            this.groupBoxRenda.Controls.Add(this.textBox2);
            this.groupBoxRenda.Location = new System.Drawing.Point(5, 0);
            this.groupBoxRenda.Name = "groupBoxRenda";
            this.groupBoxRenda.Size = new System.Drawing.Size(211, 81);
            this.groupBoxRenda.TabIndex = 0;
            this.groupBoxRenda.TabStop = false;
            // 
            // groupBoxAcoes
            // 
            this.groupBoxAcoes.Controls.Add(this.botaoDesfazer);
            this.groupBoxAcoes.Controls.Add(this.btnSalvar);
            this.groupBoxAcoes.Location = new System.Drawing.Point(223, 0);
            this.groupBoxAcoes.Name = "groupBoxAcoes";
            this.groupBoxAcoes.Size = new System.Drawing.Size(111, 81);
            this.groupBoxAcoes.TabIndex = 1;
            this.groupBoxAcoes.TabStop = false;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(7, 15);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(98, 23);
            this.btnSalvar.TabIndex = 0;
            this.btnSalvar.Text = "Salvar...";
            this.btnSalvar.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(92, 13);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(113, 20);
            this.textBox2.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mês referência";
            // 
            // botaoDesfazer
            // 
            this.botaoDesfazer.Location = new System.Drawing.Point(6, 45);
            this.botaoDesfazer.Name = "botaoDesfazer";
            this.botaoDesfazer.Size = new System.Drawing.Size(98, 23);
            this.botaoDesfazer.TabIndex = 1;
            this.botaoDesfazer.Text = "Desfazer...";
            this.botaoDesfazer.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(92, 43);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(113, 20);
            this.textBox3.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Salário líquido";
            // 
            // frmRendaMensal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 87);
            this.Controls.Add(this.groupBoxAcoes);
            this.Controls.Add(this.groupBoxRenda);
            this.Name = "frmRendaMensal";
            this.Text = "Renda mensal";
            this.groupBoxRenda.ResumeLayout(false);
            this.groupBoxRenda.PerformLayout();
            this.groupBoxAcoes.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxRenda;
        private System.Windows.Forms.GroupBox groupBoxAcoes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button botaoDesfazer;
        private System.Windows.Forms.Button btnSalvar;
    }
}