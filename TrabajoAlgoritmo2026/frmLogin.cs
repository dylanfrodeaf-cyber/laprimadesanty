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
    public partial class fmrLogin : Form
    {
        public fmrLogin()
        {
            InitializeComponent();
        }

        private void nombre_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void frmAceptar_Load(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            //  Validar que el usuario no esté vacío
            if (txtUsuario.Text == "")
            {
                MessageBox.Show("Debe ingresar un usuario.");
                txtUsuario.Focus();
                return;
            }
            if (txtUsuario.Text.ToLower() == "admin")
            {
                MessageBox.Show("No se permite ingresar con el usuario 'admin'. Ingrese un usuario común.");
                txtUsuario.Clear();
                txtUsuario.Focus();
                return;
            }

            //  Validar que la contraseña no esté vacía
            if (txtContraseña.Text == "")
            {
                MessageBox.Show("Debe ingresar una contraseña.");
                txtContraseña.Focus();
                return;
            }

            //  Validar que el usuario tenga al menos 8 caracteres
            if (txtUsuario.Text.Length < 8)
            {
                MessageBox.Show("El usuario debe tener al menos 8 caracteres.");
                txtUsuario.Focus();
                return;
            }

            //  Validar que la contraseña tenga al menos 8 caracteres
            if (txtContraseña.Text.Length < 8)
            {
                MessageBox.Show("La contraseña debe tener al menos 8 caracteres.");
                txtContraseña.Focus();
                return;
            }

            if (!txtContraseña.Text.Any(char.IsUpper))
            {
                MessageBox.Show("La contraseña debe tener una mayúscula.");
                txtContraseña.Focus();
                return;
            }

            if (!txtContraseña.Text.Any(char.IsLower))
            {
                MessageBox.Show("La contraseña debe tener una minúscula.");
                txtContraseña.Focus();
                return;
            }

            if (!txtContraseña.Text.Any(char.IsDigit))
            {
                MessageBox.Show("La contraseña debe tener un número.");
                txtContraseña.Focus();
                return;
            }

            if (!txtContraseña.Text.Any(c => "!@#$%^&*()-_=+".Contains(c)))
            {
                MessageBox.Show("La contraseña debe tener un símbolo.");
                txtContraseña.Focus();
                return;
            }

            // LOGIN 

            if (txtUsuario.Text == "admin" && txtContraseña.Text == "Admin123!")
            {
                MessageBox.Show("Bienvenido.");
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos.");
            }
            //  Validar que el usuario no tenga espacios
            if (txtUsuario.Text.Contains(" "))
            {
                MessageBox.Show("El usuario no puede contener espacios.");
                txtUsuario.Focus();
                return;
            }

            //  Validar usuario y contraseña
            if (txtUsuario.Text == "Leo1234_" && txtContraseña.Text == "Leo1234_")
            {
                if (chkRecordarContra.Checked)
                {
                    MessageBox.Show("Bienvenido. Se recordará la contraseña.");
                }
                else
                {
                    MessageBox.Show("Bienvenido.");
                }
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos.");
            }
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
      
        }

        private void txtContraseña_TextChanged(object sender, EventArgs e)
        {
      
        }
    }
}
