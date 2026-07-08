namespace TrabajoAlgoritmo2026
{
    partial class fmrLogin
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.nombre = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblContraseña = new System.Windows.Forms.Label();
            this.chkRecordarContra = new System.Windows.Forms.CheckBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.lnkRecuperoContraseña = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // nombre
            // 
            this.nombre.AutoSize = true;
            this.nombre.Location = new System.Drawing.Point(218, 96);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(41, 13);
            this.nombre.TabIndex = 0;
            this.nombre.Text = "usuario";
            this.nombre.Click += new System.EventHandler(this.nombre_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(221, 112);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(283, 20);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(221, 196);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(283, 20);
            this.textBox2.TabIndex = 3;
            // 
            // lblContraseña
            // 
            this.lblContraseña.AutoSize = true;
            this.lblContraseña.Location = new System.Drawing.Point(218, 180);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(60, 13);
            this.lblContraseña.TabIndex = 2;
            this.lblContraseña.Text = "contraseña";
            // 
            // chkRecordarContra
            // 
            this.chkRecordarContra.AutoSize = true;
            this.chkRecordarContra.Location = new System.Drawing.Point(221, 240);
            this.chkRecordarContra.Name = "chkRecordarContra";
            this.chkRecordarContra.Size = new System.Drawing.Size(124, 17);
            this.chkRecordarContra.TabIndex = 4;
            this.chkRecordarContra.Text = "recordad contraseña";
            this.chkRecordarContra.UseVisualStyleBackColor = true;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(242, 300);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(248, 46);
            this.btnAceptar.TabIndex = 5;
            this.btnAceptar.Text = "aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // lnkRecuperoContraseña
            // 
            this.lnkRecuperoContraseña.AutoSize = true;
            this.lnkRecuperoContraseña.Location = new System.Drawing.Point(230, 273);
            this.lnkRecuperoContraseña.Name = "lnkRecuperoContraseña";
            this.lnkRecuperoContraseña.Size = new System.Drawing.Size(104, 13);
            this.lnkRecuperoContraseña.TabIndex = 6;
            this.lnkRecuperoContraseña.TabStop = true;
            this.lnkRecuperoContraseña.Text = "olvide mi contraseña";
            // 
            // fmrLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lnkRecuperoContraseña);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.chkRecordarContra);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.lblContraseña);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.nombre);
            this.Name = "fmrLogin";
            this.Text = "login";
            this.Load += new System.EventHandler(this.frmAceptar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nombre;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblContraseña;
        private System.Windows.Forms.CheckBox chkRecordarContra;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.LinkLabel lnkRecuperoContraseña;
    }
}

