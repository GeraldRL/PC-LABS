using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// Lamar capa negocio
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class FrmDistribuidor : Form
    {
        public FrmDistribuidor()
        {
            InitializeComponent();
        }
        // Declara un objeto a partir de la clase
        Distribuidor distribuidor = new Distribuidor();

        private void btnEscribir_Click(object sender, EventArgs e)
        {
            // Leer datos
            string nombres = txtNombres.Text.Trim();
            string apellidos = txtApellidos.Text.Trim();
            string dni = txtDni.Text.Trim();
            string numeroTelefonico = txtNumeroTelefonico.Text.Trim();
            string expLaboral = txtExpLaboral.Text.Trim();
            string horasTrabajadas = txtHorasTrabajadas.Text.Trim();
            string correo = txtCorreo.Text.Trim();
            // Escribir los datos del distribuidor en el objeto
            distribuidor.Nombres = nombres;
            distribuidor.Apellidos = apellidos;
            distribuidor.Dni = dni;
            distribuidor.NumeroTelefonico = numeroTelefonico;
            distribuidor.ExpLaboral = expLaboral;
            distribuidor.HorasTrabajadas = horasTrabajadas;
            distribuidor.Correo = correo;
            // Confirmar que se ha escrito en el objeto
            MessageBox.Show("Se ha escrito correctamente en el objeto");
            // Limpiar las cajas
            txtNombres.Clear();
            txtApellidos.Clear();
            txtDni.Clear();
            txtNumeroTelefonico.Clear();
            txtExpLaboral.Clear();
            txtHorasTrabajadas.Clear();
            txtCorreo.Clear();
            // Hacer que el mouse este en nombres
            txtNombres.Focus();
        }

        private void btnLeer_Click(object sender, EventArgs e)
        {
            // Leer propiedades del objeto
            string nombres = distribuidor.Nombres;
            string apellidos = distribuidor.Apellidos;
            string dni = distribuidor.Dni;
            string numeroTelefonico = distribuidor.NumeroTelefonico;
            string expLaboral = distribuidor.ExpLaboral;
            string horasTrabajadas = distribuidor.HorasTrabajadas;
            string correo = distribuidor.Correo;
            MessageBox.Show("Datos del distribuidor" + "\n" + "Nombres: " + nombres + "\n" + "Apellidos: " + apellidos +
                            "\n" + "Dni: " + dni + "\n" + "Número telefónico: " + numeroTelefonico + "\n" + "Experiencia Laboral: "
                            + expLaboral + "\n" + "Horas trabajadas: " + horasTrabajadas + "\n" + "Correo: " + correo);
        }

        private void btnDistribuir_Click(object sender, EventArgs e)
        {
            MessageBox.Show(distribuidor.Distribuir());
        }

        private void btnRepresentar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(distribuidor.Representar());
        }

        private void btnComercializar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(distribuidor.Comercializar());
        }

        private void btnGanarExperiencia_Click(object sender, EventArgs e)
        {
            MessageBox.Show(distribuidor.GanarExperiencia());
        }

        private void btnCoordinar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(distribuidor.Coordinar());
        }

        private void txtApellidos_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDni_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNumeroTelefonico_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtExpLaboral_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtHorasTrabajadas_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCorreo_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmDistribuidor_Load(object sender, EventArgs e)
        {

        }

        private void txtNombres_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
