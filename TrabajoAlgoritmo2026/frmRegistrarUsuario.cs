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
    public partial class frmRegistrarUsuario : Form
    {
        public frmRegistrarUsuario()
        {
            InitializeComponent();
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmRegistrarUsuario_Load(object sender, EventArgs e)
        {
            //tipos de usuarios
            string[] Usuarios = {"Seleccione Usuario","Admin"
                    ,"Normal","Empresa" };
            cmbTipoUsuario.DataSource = Usuarios;
            //provincias
            string[] Provincias = { "Seleccionar Provincia" };
            cmbProvincias.DataSource = Provincias;
            //paises
            string[] Nacionalidad = {"Seleccionar Nacionalidad","Argentina","Uruguay"
            ,"Brazil", "Bolivia"};
            cmbNacionalidad.DataSource = Nacionalidad;
            //generos
            string[] Genero = {"Seleccionar Genero","Hombre",
                "Mujer","No Binario" };
            cmbGenero.DataSource = Genero;
            //partidos
            string[] Partidos = { "Seleccionar Partido" };
               
            cmbPartidos.DataSource = Partidos;
            //localidad
            string[] Localidad = { "Seleccionar Localidad" };
            cmbLocalidad.DataSource = Localidad;

        }

        private void cmbNacionalidad_SelectionChangeCommitted(object sender, EventArgs e)
        {

            string[] Arg = { "Seleccione Provincia","Buenos Aires","Cordoba", };
            string[] Urg = { "Seleccione Provincia", "MonteVideo","Canelones" };
            string[] Brz = { "Seleccione Provinvia", "Sao Paulo","Rio de Janeiro" };
            string[] Blv = { "Seleccione Provincia", "La Paz", "Santa Cruz" };

            switch(cmbNacionalidad.SelectedIndex)
            {
                case -1:
                case 0:
                    cmbProvincias.DataSource = null;
                    cmbProvincias.Items.Add("Debe seleccionar Pais");
                    break;
                case 1:
                    cmbProvincias.DataSource = null;
                    cmbProvincias.DataSource = Arg;
                    break;
                case 2:
                    cmbProvincias.DataSource = null;
                    cmbProvincias.DataSource = Urg;
                    break;
                case 3:
                    cmbProvincias.DataSource = null;
                    cmbProvincias.DataSource = Brz;
                    break;
                case 4:
                    cmbProvincias.DataSource = null;
                    cmbProvincias.DataSource = Blv;
                    break;

                default:
                    break;
            }

        }
        private void cmbProvincias_SelectionChangeCommitted(object sender, EventArgs e)
        {
            //Argentina
            string[] LocBsas = {"Seleccionar","Lomas de Zamora","Lanus" };
            string[] Crdb = { "Seleccionar", "Villa Carlos Paz", "Villa General Belgrano" };
            //Uruguay
            string[] Mntv = { "Seleccionar", "Santiago Vazquez","Pajas Blancas" };
            string[] Cnln = { "Seleccionar", "Ciudad de la Costa","Las Piedras" };
            //Brazil
            string[] Spb = { "Seleccionar", "Campinas","Santos" };
            string[] RdJ = { "Seleccionar", "Buzios","Petropolis" };
            //Bolivia
            string[] Lpz = { "Seleccionar", "Copacabana","Coroico" };
            string[] Stc = { "Seleccionar", "Samaipata","Montero" };

            switch(cmbProvincias.SelectedItem.ToString())
            {
                case "":
                case "Selecciones Provincia":
                    cmbPartidos.DataSource = null;
                    cmbPartidos.Items.Add("Debe seleccionar Provincia");
                    break;
                case "Buenos Aires":
                    cmbPartidos.DataSource = null;
                    cmbPartidos.DataSource = LocBsas;
                    break;
                case "Cordoba":
                    cmbPartidos.DataSource = null;
                    cmbPartidos.DataSource = Crdb;
                    break;
                case "MonteVideo":
                    cmbPartidos.DataSource = null;
                    cmbPartidos.DataSource = Mntv;

                    break;
                case "Canelones":
                    cmbPartidos.DataSource = null;
                    cmbPartidos.DataSource = Cnln;
                    break;
                case "Sao Paulo":
                    cmbPartidos.DataSource = null;
                    cmbPartidos.DataSource = Spb;

                    break;
                case "Rio de Janeiro":
                    cmbPartidos.DataSource = null;
                    cmbPartidos.DataSource = RdJ;

                    break;
                case "La Paz":
                    cmbPartidos.DataSource = null;
                    cmbPartidos.DataSource = Lpz;

                    break;
                case "Santa Cruz":
                    cmbPartidos.DataSource = null;
                    cmbPartidos.DataSource = Stc;

                    break;

                default:
                    break;
            }

        }

        private void cmbPartidos_SelectionChangeCommitted(object sender, EventArgs e)
        {
            //buenos aires
            string[] Lomas = { "Seleccionar", "Banfield", "Temperley" };
            string[] Lanus = { "Seleccionar", "Lanús Este", "Remedios de Escalada" };
            //cordoba
            string[] locVillaCarlosPaz = { "Seleccionar", "Sol y Río", "Villa del Lago" };
            string[] locVillaGeneralBelgrano = { "Seleccionar", "Los Reartes", "Villa Berna" };
            //uruguay
            //santiago vazquez
            string[] locSantiagoVazquez = { "Seleccionar", "La Barra de Santa Lucía", "Pueblo Victoria" };
            string[] locPajasBlancas = { "Seleccionar", "Santa Catalina", "Cerro" };
            //canelones
            string[] locCiudadCosta = { "Seleccionar", "El Pinar", "Solymar" };
            string[] locLasPiedras = { "Seleccionar", "Progreso", "La Paz" };
            //brazil
            //sao pablo
            string[] locCampinas = { "Seleccionar", "Barao Geraldo", "Sousas" };
            string[] locSantos = { "Seleccionar", "Gonzaga", "Ponta da Praia" };
            //rio de janeiro
            string[] locBuzios = { "Seleccionar", "João Fernandes", "Geribá" };
            string[] locPetropolis = { "Seleccionar", "Itaipava", "Corrêas" };
            //bolivia
            //la paz
            string[] locCopacabana = { "Seleccionar", "Yampupata", "Kasani" };
            string[] locCoroico = { "Seleccionar", "Yolosa", "Santa Bárbara" };
            //santa cruz
            string[] locSamaipata = { "Seleccionar", "Cuevas", "Mairana" };
            string[] locMontero = { "Seleccionar", "Villa Busch", "Guabirá" };

            switch (cmbPartidos.SelectedItem.ToString())
            {

                //Argentina
                case "Lomas de Zamora":
                    cmbLocalidad.DataSource = null;
                    cmbLocalidad.DataSource = Lomas;
                    break;
                case "Lanus":
                    cmbLocalidad.DataSource = null;
                    cmbLocalidad.DataSource = Lanus;
                    break;
                    //cordoba
                case "Villa Carlos Paz":
                    cmbLocalidad.DataSource = null;
                    cmbLocalidad.DataSource = locVillaCarlosPaz;
                    break;
                case "Villa General Belgrano":
                    cmbLocalidad.DataSource = null;
                    cmbLocalidad.DataSource = locVillaGeneralBelgrano;
                    break;
                    //Uruguay
                    //
                case "Santiago Vazquez":
                    cmbLocalidad.DataSource = null;
                    cmbLocalidad.DataSource = locSantiagoVazquez;
                    break;
                case "Pajas Blancas":
                    cmbLocalidad.DataSource = null;
                    cmbLocalidad.DataSource = locPajasBlancas;
                    break;
                case "Ciudad de la Costa":
                    cmbLocalidad.DataSource = null;
                    cmbLocalidad.DataSource = locCiudadCosta;
                    break;
                case "Las Piedras":
                    cmbLocalidad.DataSource = null;
                    cmbLocalidad.DataSource =locLasPiedras ;
                    break;
                    //Brazil
                case "Campinas":
                    cmbLocalidad.DataSource = null;
                    cmbLocalidad.DataSource = locCampinas;
                    break;
                case "Santos":
                    cmbLocalidad.DataSource = null;
                    cmbLocalidad.DataSource = locSantos;
                    break;
                case "Buzios":
                    cmbLocalidad.DataSource = null;
                    cmbLocalidad.DataSource = locBuzios;
                    break;
                case "Petropolis":
                    cmbLocalidad.DataSource = null;
                    cmbLocalidad.DataSource = locPetropolis;
                    break;
                    //Bolivia
                case "Copacabana":
                    cmbLocalidad.DataSource = null;
                    cmbLocalidad.DataSource = locCopacabana;
                    break;
                case "Coroico":
                    cmbLocalidad.DataSource = null;
                    cmbLocalidad.DataSource = locCoroico;
                    break;
                case "Samaipata":
                    cmbLocalidad.DataSource = null;
                    cmbLocalidad.DataSource = locSamaipata;
                    break;
                case "Montero":
                    cmbLocalidad.DataSource = null;
                    cmbLocalidad.DataSource = locMontero;
                    break;
                default:
                    break;
            }   


        }
        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void fin(object sender, FormClosingEventArgs e)
        {

        }

        private void fin(object sender, FormClosedEventArgs e)
        {
            
        }

        private void cmbNacionalidad_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            //validacion de nombre 
            //nombre en blanco
            if(txtNombre.Text.Trim()=="")
            {
                MessageBox.Show("Debe ingresar un Nombre");
                txtNombre.Focus();
                return;
            }
            //nombre con numeros
            foreach (char letra in txtNombre.Text)
            {
                if (!char.IsLetter(letra) && letra != ' ')
                {
                    MessageBox.Show("El nombre solo puede contener letras.");
                    txtNombre.Focus();
                    return;
                }
            }
            //nombre con menos de 3 digitos o mas de 14 
            if (txtNombre.Text.Trim().Length < 3 || txtNombre.Text.Trim().Length > 14)
            {
                MessageBox.Show("El nombre debe tener entre 3 y 14 caracteres.");
                txtNombre.Focus();
                return;
            }

            //apellido
            //apellid en blanco
            if (txtApellido.Text.Trim()=="")
            {
                MessageBox.Show("Debe ingresar un Apellido");
                txtApellido.Focus();
                return;
            }
            //apellido con numeros
            foreach (char letra in txtApellido.Text)
            {
                if (!char.IsLetter(letra) && letra != ' ')
                {
                    MessageBox.Show("El nombre solo puede contener letras.");
                    txtApellido.Focus();
                    return;
                }
            }
            //apelliod menor a 3 caracteres o mayor a 13
            if (txtApellido.Text.Trim().Length < 3 || txtApellido.Text.Trim().Length > 14)
            {
                MessageBox.Show("El Apellido debe tener entre 3 y 14 caracteres.");
                txtApellido.Focus();
                return;
            }


            //validacion DNI
            //DNI en blanco
            if (txtDNI.Text.Trim() == "")
            {
                MessageBox.Show("Debe ingresar un DNI");
                txtDNI.Focus();
                return;
            }
            //solo numeros
            int dni;

            if (!int.TryParse(txtDNI.Text, out dni))
            {
                MessageBox.Show("El DNI solo puede contener números");
                txtDNI.Focus();
                return;
            }
            //debe tener 8 digitos
            if (txtDNI.Text.Length != 8)
            {
                MessageBox.Show("El DNI debe tener 8 dígitos.");
                txtDNI.Focus();
                return;
            }
            if (cmbGenero.Text.Trim() == "")
            {
                MessageBox.Show("Debe ingresar un Genero");
                cmbGenero.Focus();
                return;
            }
            //validacion telefono
            long telefono;

            if (txtTelefono.Text.Trim() == "")
            {
                MessageBox.Show("Debe ingresar un teléfono.");
                txtTelefono.Focus();
                return;
            }

            if (!long.TryParse(txtTelefono.Text, out telefono))
            {
                MessageBox.Show("El teléfono debe contener solo números.");
                txtTelefono.Focus();
                return;
            }

            if (txtTelefono.Text.Length != 10)
            {
                MessageBox.Show("El teléfono debe tener 10 dígitos.");
                txtTelefono.Focus();
                return;
            }
            //validacion gmail
            if (txtEmail.Text.Trim() == "")
            {
                MessageBox.Show("Debe ingresar un correo electrónico.");
                txtEmail.Focus();
                return;
            }

            if (!txtEmail.Text.Contains("@") || !txtEmail.Text.Contains("."))
            {
                MessageBox.Show("Debe ingresar un correo válido.");
                txtEmail.Focus();
                return;
            }

            if (txtEmail.Text.StartsWith("@"))
            {
                MessageBox.Show("El correo no puede comenzar con @.");
                txtEmail.Focus();
                return;
            }

            //validacion registrar genero 

            if (cmbGenero.SelectedIndex == 0)
            {
                MessageBox.Show("Debe seleccionar un género.");
                cmbGenero.Focus();
                return;
            }

            // Validación del tipo de usuario
            if (cmbTipoUsuario.SelectedIndex == 0)
            {
                MessageBox.Show("Debe seleccionar un tipo de usuario.");
                cmbTipoUsuario.Focus();
                return;
            }

            //fecha nacimiento 
            DateTime fechaNacimiento = dtpFechaNacimiento.Value;
            DateTime hoy = DateTime.Today;

            dtpFechaNacimiento.MaxDate = DateTime.Today;
            dtpFechaNacimiento.Value = DateTime.Today;

            int edad = hoy.Year - fechaNacimiento.Year;

            if (fechaNacimiento > hoy.AddYears(-edad))
            {
                edad--;
            }

            if (edad < 18)
            {
                MessageBox.Show("El usuario debe ser mayor de 18 años.");
                dtpFechaNacimiento.Focus();
                return;
            }

            // validacion codigo postal 
            int codigoPostal;

            if (txtCodPostal.Text.Trim() == "")
            {
                MessageBox.Show("Debe ingresar un código postal.");
                txtCodPostal.Focus();
                return;
            }

            //solo numeros 
            if (!int.TryParse(txtCodPostal.Text, out codigoPostal))
            {
                MessageBox.Show("El código postal debe contener solo números.");
                txtCodPostal.Focus();
                return;
            }
            // 4 dig 
            if (txtCodPostal.Text.Length != 4)
            {
                MessageBox.Show("El código postal debe tener 4 dígitos.");
                txtCodPostal.Focus();
                return;
            }
            //calles este full ia ayuda 
            if (txtCalle.Text.Trim() == "")
            {
                MessageBox.Show("Debe ingresar una calle.");
                txtCalle.Focus();
                return;
            }

            if (txtCalle.Text.Trim().Length < 3 || txtCalle.Text.Trim().Length > 40)
            {
                MessageBox.Show("La calle debe tener entre 3 y 40 caracteres.");
                txtCalle.Focus();
                return;
            }
            //validacion pero no es obligatorio 
            if (txtPiso.Text.Trim() != "")
            {
                int piso;

                if (!int.TryParse(txtPiso.Text, out piso))
                {
                    MessageBox.Show("El piso debe contener solo números.");
                    txtPiso.Focus();
                    return;
                }
            }
            //validacion departamento   
            if (txtDep.Text.Trim() == "")
            {
                MessageBox.Show("Debe ingresar el departamento.");
                txtDep.Focus();
                return;
            }
           

            MessageBox.Show("Usuario registrado correctamente.");

        }
    }
}
