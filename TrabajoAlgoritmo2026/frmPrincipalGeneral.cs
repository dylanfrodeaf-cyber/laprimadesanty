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
    public partial class frmPrincipalGeneral : Form
    {
        public frmPrincipalGeneral()
        {
            InitializeComponent();
        }

        private void btnCerrarsesion_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show(
       "¿Está seguro que desea cerrar sesión?",
       "Confirmación",
       MessageBoxButtons.YesNo,
       MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
