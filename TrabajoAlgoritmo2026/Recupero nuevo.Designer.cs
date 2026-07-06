namespace TrabajoAlgoritmo2026
{
    partial class Recupero_nuevo
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
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.lblNuevacontraseña = new System.Windows.Forms.Label();
            this.lblRepetircontraseña = new System.Windows.Forms.Label();
            this.txtNuevacontra = new System.Windows.Forms.TextBox();
            this.txtRepetirontra = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnConfirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmar.Location = new System.Drawing.Point(217, 228);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(125, 27);
            this.btnConfirmar.TabIndex = 0;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = false;
            // 
            // lblNuevacontraseña
            // 
            this.lblNuevacontraseña.AutoSize = true;
            this.lblNuevacontraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNuevacontraseña.Location = new System.Drawing.Point(168, 26);
            this.lblNuevacontraseña.Name = "lblNuevacontraseña";
            this.lblNuevacontraseña.Size = new System.Drawing.Size(215, 20);
            this.lblNuevacontraseña.TabIndex = 1;
            this.lblNuevacontraseña.Text = "Ingrese su nueva contraseña";
            // 
            // lblRepetircontraseña
            // 
            this.lblRepetircontraseña.AutoSize = true;
            this.lblRepetircontraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRepetircontraseña.Location = new System.Drawing.Point(168, 107);
            this.lblRepetircontraseña.Name = "lblRepetircontraseña";
            this.lblRepetircontraseña.Size = new System.Drawing.Size(156, 20);
            this.lblRepetircontraseña.TabIndex = 2;
            this.lblRepetircontraseña.Text = "Repita la contraseña";
            // 
            // txtNuevacontra
            // 
            this.txtNuevacontra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNuevacontra.Location = new System.Drawing.Point(172, 59);
            this.txtNuevacontra.Name = "txtNuevacontra";
            this.txtNuevacontra.Size = new System.Drawing.Size(211, 26);
            this.txtNuevacontra.TabIndex = 3;
            // 
            // txtRepetirontra
            // 
            this.txtRepetirontra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRepetirontra.Location = new System.Drawing.Point(172, 155);
            this.txtRepetirontra.Name = "txtRepetirontra";
            this.txtRepetirontra.Size = new System.Drawing.Size(211, 26);
            this.txtRepetirontra.TabIndex = 4;
            // 
            // Recupero_nuevo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtRepetirontra);
            this.Controls.Add(this.txtNuevacontra);
            this.Controls.Add(this.lblRepetircontraseña);
            this.Controls.Add(this.lblNuevacontraseña);
            this.Controls.Add(this.btnConfirmar);
            this.Name = "Recupero_nuevo";
            this.Text = "Recupero_nuevo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Label lblNuevacontraseña;
        private System.Windows.Forms.Label lblRepetircontraseña;
        private System.Windows.Forms.TextBox txtNuevacontra;
        private System.Windows.Forms.TextBox txtRepetirontra;
    }
}