namespace TrabajoAlgoritmo2026
{
    partial class frmRecuperoContraseña
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
            this.lblIngresarmail = new System.Windows.Forms.Label();
            this.chbRecordarcorreo = new System.Windows.Forms.CheckBox();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.lblUltimacontraseña = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmar.Location = new System.Drawing.Point(246, 254);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(110, 32);
            this.btnConfirmar.TabIndex = 0;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblIngresarmail
            // 
            this.lblIngresarmail.AutoSize = true;
            this.lblIngresarmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngresarmail.Location = new System.Drawing.Point(64, 21);
            this.lblIngresarmail.Name = "lblIngresarmail";
            this.lblIngresarmail.Size = new System.Drawing.Size(137, 24);
            this.lblIngresarmail.TabIndex = 1;
            this.lblIngresarmail.Text = "Ingrese su Mail";
            // 
            // chbRecordarcorreo
            // 
            this.chbRecordarcorreo.AutoSize = true;
            this.chbRecordarcorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbRecordarcorreo.Location = new System.Drawing.Point(68, 109);
            this.chbRecordarcorreo.Name = "chbRecordarcorreo";
            this.chbRecordarcorreo.Size = new System.Drawing.Size(146, 24);
            this.chbRecordarcorreo.TabIndex = 2;
            this.chbRecordarcorreo.Text = "Recordar Correo";
            this.chbRecordarcorreo.UseVisualStyleBackColor = true;
            // 
            // txtMail
            // 
            this.txtMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMail.Location = new System.Drawing.Point(68, 58);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(218, 29);
            this.txtMail.TabIndex = 3;
            // 
            // lblUltimacontraseña
            // 
            this.lblUltimacontraseña.AutoSize = true;
            this.lblUltimacontraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUltimacontraseña.Location = new System.Drawing.Point(64, 143);
            this.lblUltimacontraseña.Name = "lblUltimacontraseña";
            this.lblUltimacontraseña.Size = new System.Drawing.Size(250, 24);
            this.lblUltimacontraseña.TabIndex = 5;
            this.lblUltimacontraseña.Text = "Ingrese su ultima contraseña";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(68, 189);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(246, 29);
            this.textBox1.TabIndex = 6;
            // 
            // frmRecuperoContraseña
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblUltimacontraseña);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.chbRecordarcorreo);
            this.Controls.Add(this.lblIngresarmail);
            this.Controls.Add(this.btnConfirmar);
            this.Name = "frmRecuperoContraseña";
            this.Text = "frmRecupero";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Label lblIngresarmail;
        private System.Windows.Forms.CheckBox chbRecordarcorreo;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.Label lblUltimacontraseña;
        private System.Windows.Forms.TextBox textBox1;
    }
}