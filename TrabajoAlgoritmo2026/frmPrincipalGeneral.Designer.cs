namespace TrabajoAlgoritmo2026
{
    partial class frmPrincipalGeneral
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
            this.lblOpcion = new System.Windows.Forms.Label();
            this.btnCerrarsesion = new System.Windows.Forms.Button();
            this.btnNotificaciones = new System.Windows.Forms.Button();
            this.btnTrabajosolicitado = new System.Windows.Forms.Button();
            this.btnPropuestasdisponibles = new System.Windows.Forms.Button();
            this.lblBienvenidos = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblOpcion
            // 
            this.lblOpcion.AutoSize = true;
            this.lblOpcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOpcion.Location = new System.Drawing.Point(97, 58);
            this.lblOpcion.Name = "lblOpcion";
            this.lblOpcion.Size = new System.Drawing.Size(124, 20);
            this.lblOpcion.TabIndex = 11;
            this.lblOpcion.Text = "Elija una opcion:";
            // 
            // btnCerrarsesion
            // 
            this.btnCerrarsesion.Location = new System.Drawing.Point(101, 238);
            this.btnCerrarsesion.Name = "btnCerrarsesion";
            this.btnCerrarsesion.Size = new System.Drawing.Size(191, 36);
            this.btnCerrarsesion.TabIndex = 10;
            this.btnCerrarsesion.Text = "Cerrar Sesion ";
            this.btnCerrarsesion.UseVisualStyleBackColor = true;
            this.btnCerrarsesion.Click += new System.EventHandler(this.btnCerrarsesion_Click);
            // 
            // btnNotificaciones
            // 
            this.btnNotificaciones.Location = new System.Drawing.Point(101, 185);
            this.btnNotificaciones.Name = "btnNotificaciones";
            this.btnNotificaciones.Size = new System.Drawing.Size(191, 36);
            this.btnNotificaciones.TabIndex = 9;
            this.btnNotificaciones.Text = "Editar perfil";
            this.btnNotificaciones.UseVisualStyleBackColor = true;
            // 
            // btnTrabajosolicitado
            // 
            this.btnTrabajosolicitado.Location = new System.Drawing.Point(102, 132);
            this.btnTrabajosolicitado.Name = "btnTrabajosolicitado";
            this.btnTrabajosolicitado.Size = new System.Drawing.Size(191, 36);
            this.btnTrabajosolicitado.TabIndex = 8;
            this.btnTrabajosolicitado.Text = "Postulaciones";
            this.btnTrabajosolicitado.UseVisualStyleBackColor = true;
            // 
            // btnPropuestasdisponibles
            // 
            this.btnPropuestasdisponibles.Location = new System.Drawing.Point(101, 81);
            this.btnPropuestasdisponibles.Name = "btnPropuestasdisponibles";
            this.btnPropuestasdisponibles.Size = new System.Drawing.Size(191, 36);
            this.btnPropuestasdisponibles.TabIndex = 7;
            this.btnPropuestasdisponibles.Text = "Buscar empleo";
            this.btnPropuestasdisponibles.UseVisualStyleBackColor = true;
            // 
            // lblBienvenidos
            // 
            this.lblBienvenidos.AutoSize = true;
            this.lblBienvenidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBienvenidos.Location = new System.Drawing.Point(192, 9);
            this.lblBienvenidos.Name = "lblBienvenidos";
            this.lblBienvenidos.Size = new System.Drawing.Size(119, 25);
            this.lblBienvenidos.TabIndex = 6;
            this.lblBienvenidos.Text = "Bienvenido";
            // 
            // frmPrincipalGeneral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblOpcion);
            this.Controls.Add(this.btnCerrarsesion);
            this.Controls.Add(this.btnNotificaciones);
            this.Controls.Add(this.btnTrabajosolicitado);
            this.Controls.Add(this.btnPropuestasdisponibles);
            this.Controls.Add(this.lblBienvenidos);
            this.Name = "frmPrincipalGeneral";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPrincipalGeneral";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOpcion;
        private System.Windows.Forms.Button btnCerrarsesion;
        private System.Windows.Forms.Button btnNotificaciones;
        private System.Windows.Forms.Button btnTrabajosolicitado;
        private System.Windows.Forms.Button btnPropuestasdisponibles;
        private System.Windows.Forms.Label lblBienvenidos;
    }
}