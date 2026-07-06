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
    public partial class PrincipalForm : Form
    {
        public PrincipalForm()
        {
            InitializeComponent();
        }

        private void cmbConsultas_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbConsultas.Items.Add("Propuestas disponibles");
            cmbConsultas.Items.Add("Trabajos solicitados");
            cmbConsultas.Items.Add("Notificaciones");
            cmbConsultas.Items.Add("Mi perfil");
        }

        private void PrincipalForm_Load(object sender, EventArgs e)
        {

        }
    }
}
