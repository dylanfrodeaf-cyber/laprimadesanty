using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace TrabajoAlgoritmo2026
{
    public partial class frmRecuperoContraseña : Form
    {
        public frmRecuperoContraseña()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCorreo.Text))
            {
                MessageBox.Show("Ingrese un correo electrónico.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCorreo.Focus();
                return;
            }
            string patron = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";

            if (!Regex.IsMatch(txtCorreo.Text.Trim(), patron))
            {
                MessageBox.Show("Ingrese un correo válido.",
                    "Correo incorrecto",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtCorreo.Focus();
                txtCorreo.SelectAll();
                return;
            }
            MessageBox.Show("Correo válido.",
        "Correcto",
        MessageBoxButtons.OK,
        MessageBoxIcon.Information);
        }

        private void txtCorreo_TextChanged(object sender, EventArgs e)
        {

        }
        private void txtCorreo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
