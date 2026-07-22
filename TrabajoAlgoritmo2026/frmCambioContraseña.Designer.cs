namespace TrabajoAlgoritmo2026
{
    partial class frmCambioContraseña
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
            this.lblCambiocontraseña = new System.Windows.Forms.Label();
            this.lblContractual = new System.Windows.Forms.Label();
            this.lblContraseñanueva = new System.Windows.Forms.Label();
            this.lblConfirmarcontraseña = new System.Windows.Forms.Label();
            this.btnCanselar = new System.Windows.Forms.Button();
            this.btnGuardarcambios = new System.Windows.Forms.Button();
            this.txtContraseñaacutal = new System.Windows.Forms.TextBox();
            this.txtNuevacontraseña = new System.Windows.Forms.TextBox();
            this.txtConfirmarcontraseña = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblCambiocontraseña
            // 
            this.lblCambiocontraseña.AutoSize = true;
            this.lblCambiocontraseña.Location = new System.Drawing.Point(252, 41);
            this.lblCambiocontraseña.Name = "lblCambiocontraseña";
            this.lblCambiocontraseña.Size = new System.Drawing.Size(143, 13);
            this.lblCambiocontraseña.TabIndex = 0;
            this.lblCambiocontraseña.Text = "CAMBIO DE CONTRASEÑA";
            this.lblCambiocontraseña.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblContractual
            // 
            this.lblContractual.AutoSize = true;
            this.lblContractual.Location = new System.Drawing.Point(252, 73);
            this.lblContractual.Name = "lblContractual";
            this.lblContractual.Size = new System.Drawing.Size(93, 13);
            this.lblContractual.TabIndex = 1;
            this.lblContractual.Text = "Contraseña actual";
            this.lblContractual.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblContraseñanueva
            // 
            this.lblContraseñanueva.AutoSize = true;
            this.lblContraseñanueva.Location = new System.Drawing.Point(252, 122);
            this.lblContraseñanueva.Name = "lblContraseñanueva";
            this.lblContraseñanueva.Size = new System.Drawing.Size(95, 13);
            this.lblContraseñanueva.TabIndex = 2;
            this.lblContraseñanueva.Text = "Nueva contraseña";
            this.lblContraseñanueva.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblConfirmarcontraseña
            // 
            this.lblConfirmarcontraseña.AutoSize = true;
            this.lblConfirmarcontraseña.Location = new System.Drawing.Point(252, 170);
            this.lblConfirmarcontraseña.Name = "lblConfirmarcontraseña";
            this.lblConfirmarcontraseña.Size = new System.Drawing.Size(107, 13);
            this.lblConfirmarcontraseña.TabIndex = 3;
            this.lblConfirmarcontraseña.Text = "Confirmar contraseña";
            this.lblConfirmarcontraseña.Click += new System.EventHandler(this.label4_Click);
            // 
            // btnCanselar
            // 
            this.btnCanselar.Location = new System.Drawing.Point(392, 212);
            this.btnCanselar.Name = "btnCanselar";
            this.btnCanselar.Size = new System.Drawing.Size(93, 44);
            this.btnCanselar.TabIndex = 50;
            this.btnCanselar.Text = "Canselar";
            this.btnCanselar.UseVisualStyleBackColor = true;
            this.btnCanselar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnGuardarcambios
            // 
            this.btnGuardarcambios.Location = new System.Drawing.Point(255, 212);
            this.btnGuardarcambios.Name = "btnGuardarcambios";
            this.btnGuardarcambios.Size = new System.Drawing.Size(131, 44);
            this.btnGuardarcambios.TabIndex = 40;
            this.btnGuardarcambios.Text = "Guardad Cambios";
            this.btnGuardarcambios.UseVisualStyleBackColor = true;
            this.btnGuardarcambios.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtContraseñaacutal
            // 
            this.txtContraseñaacutal.Location = new System.Drawing.Point(255, 89);
            this.txtContraseñaacutal.Name = "txtContraseñaacutal";
            this.txtContraseñaacutal.Size = new System.Drawing.Size(230, 20);
            this.txtContraseñaacutal.TabIndex = 10;
            this.txtContraseñaacutal.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtNuevacontraseña
            // 
            this.txtNuevacontraseña.Location = new System.Drawing.Point(255, 138);
            this.txtNuevacontraseña.Name = "txtNuevacontraseña";
            this.txtNuevacontraseña.Size = new System.Drawing.Size(230, 20);
            this.txtNuevacontraseña.TabIndex = 20;
            this.txtNuevacontraseña.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtConfirmarcontraseña
            // 
            this.txtConfirmarcontraseña.Location = new System.Drawing.Point(255, 186);
            this.txtConfirmarcontraseña.Name = "txtConfirmarcontraseña";
            this.txtConfirmarcontraseña.Size = new System.Drawing.Size(230, 20);
            this.txtConfirmarcontraseña.TabIndex = 30;
            this.txtConfirmarcontraseña.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // frmCambioContraseña
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtConfirmarcontraseña);
            this.Controls.Add(this.txtNuevacontraseña);
            this.Controls.Add(this.txtContraseñaacutal);
            this.Controls.Add(this.btnGuardarcambios);
            this.Controls.Add(this.btnCanselar);
            this.Controls.Add(this.lblConfirmarcontraseña);
            this.Controls.Add(this.lblContraseñanueva);
            this.Controls.Add(this.lblContractual);
            this.Controls.Add(this.lblCambiocontraseña);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCambioContraseña";
            this.Text = "Cambio de Contraseña";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCambiocontraseña;
        private System.Windows.Forms.Label lblContractual;
        private System.Windows.Forms.Label lblContraseñanueva;
        private System.Windows.Forms.Label lblConfirmarcontraseña;
        private System.Windows.Forms.Button btnCanselar;
        private System.Windows.Forms.Button btnGuardarcambios;
        private System.Windows.Forms.TextBox txtContraseñaacutal;
        private System.Windows.Forms.TextBox txtNuevacontraseña;
        private System.Windows.Forms.TextBox txtConfirmarcontraseña;
    }
}