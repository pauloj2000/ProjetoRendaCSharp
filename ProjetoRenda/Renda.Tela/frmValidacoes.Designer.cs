namespace Renda.Tela
{
    partial class frmValidacoes
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
            this.listBoxInconsistencias = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // listBoxInconsistencias
            // 
            this.listBoxInconsistencias.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.listBoxInconsistencias.FormattingEnabled = true;
            this.listBoxInconsistencias.Location = new System.Drawing.Point(1, 0);
            this.listBoxInconsistencias.Name = "listBoxInconsistencias";
            this.listBoxInconsistencias.Size = new System.Drawing.Size(302, 225);
            this.listBoxInconsistencias.TabIndex = 0;
            // 
            // frmValidacoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(304, 225);
            this.Controls.Add(this.listBoxInconsistencias);
            this.Name = "frmValidacoes";
            this.Text = "Inconsistências";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxInconsistencias;
    }
}