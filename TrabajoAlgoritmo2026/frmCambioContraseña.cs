using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabajoAlgoritmo2026
{
    public partial class frmCambioContraseña : Form
    {
        public frmCambioContraseña()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {   // ingrese la nueva contraseña
            if (txtNuevacontraseña.Text.Trim() == "")
            {
                MessageBox.Show("Ingrese la nueva contraseña.");
                txtNuevacontraseña.Focus();
                return;
            }
            // confirma la contraseña
            if (txtConfirmarcontraseña.Text.Trim() == "")
            {
                MessageBox.Show("Confirme la contraseña.");
                txtConfirmarcontraseña.Focus();
                return;
            } 
            // contraseña no coinciden
            if (txtNuevacontraseña.Text != txtConfirmarcontraseña.Text)
            {
                MessageBox.Show("Las contraseñas no coinciden.");
                txtConfirmarcontraseña.Clear();
                txtConfirmarcontraseña.Focus();
                return;
            }
            // La nueva contraseña debe tener al menos 8 caracteres
            if (txtNuevacontraseña.Text.Length < 8)
            {
                MessageBox.Show("La nueva contraseña debe tener al menos 8 caracteres.");
                txtNuevacontraseña.Focus();
                return;
            }
            // la confirmacion no es igual a la nueva contraseña 
            if (txtConfirmarcontraseña.Text != txtNuevacontraseña.Text)
            {
                MessageBox.Show("La confirmación de la contraseña no coincide con la nueva contraseña.");
                txtConfirmarcontraseña.Clear();
                txtConfirmarcontraseña.Focus();
                return;
            }
            MessageBox.Show("La contraseña se ha cambiado correctamente.");
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
