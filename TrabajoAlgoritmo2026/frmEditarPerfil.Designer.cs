namespace TrabajoAlgoritmo2026
{
    partial class frmEditarPerfil
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
            this.lblEditPerfil = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblEditPerfil
            // 
            this.lblEditPerfil.AutoSize = true;
            this.lblEditPerfil.Location = new System.Drawing.Point(132, 60);
            this.lblEditPerfil.Name = "lblEditPerfil";
            this.lblEditPerfil.Size = new System.Drawing.Size(35, 13);
            this.lblEditPerfil.TabIndex = 0;
            this.lblEditPerfil.Text = "label1";
            // 
            // frmEditarPerfil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblEditPerfil);
            this.Name = "frmEditarPerfil";
            this.Text = "frmEditarPerfil";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEditPerfil;
    }
}