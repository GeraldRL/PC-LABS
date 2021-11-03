using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// Llamar a la CapaNegocio
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class FrmJefeAlmacen : Form
    {
        public FrmJefeAlmacen()
        {
            InitializeComponent();
        }
        // Declara un objeto a partir de la clase
        JefeAlmacen jefeAlmacen = new JefeAlmacen();
        private void btnEscribir_Click(object sender, EventArgs e)
        {
            // Leer datos
            string nombres = txtNombres.Text.Trim();
            string apellidos = txtApellidos.Text.Trim();
            string dni = txtDni.Text.Trim();
            string numeroTelefonico = txtNumeroTelefonico.Text.Trim();
            string expLaboral = txtExpLaboral.Text.Trim();
            string correo = txtCorreo.Text.Trim();
            // Escribir los datos del jefe de almacén en el objeto
            jefeAlmacen.Nombres = nombres;
            jefeAlmacen.Apellidos = apellidos;
            jefeAlmacen.Dni = dni;
            jefeAlmacen.NumeroTelefonico = numeroTelefonico;
            jefeAlmacen.ExpLaboral = expLaboral;
            jefeAlmacen.Correo = correo;
            // Confirmar que se ha escrito correctamente el objeto
            MessageBox.Show("Se ha escrito correctamente en el objeto");
            // Limpiar las cajas de texto
            txtNombres.Clear();
            txtApellidos.Clear();
            txtDni.Clear();
            txtNumeroTelefonico.Clear();
            txtExpLaboral.Clear();
            txtCorreo.Clear();
            // Hacer que el mouse esté en nombres
            txtNombres.Focus();
        }

        private void btnLeer_Click(object sender, EventArgs e)
        {
            // Leer las propiedades del objeto
            string nombres = jefeAlmacen.Nombres;
            string apellidos = jefeAlmacen.Apellidos;
            string dni = jefeAlmacen.Dni;
            string numeroTelefonico = jefeAlmacen.NumeroTelefonico;
            string expLaboral = jefeAlmacen.ExpLaboral;
            string correo = jefeAlmacen.Correo;
            MessageBox.Show("Datos del alumno" + "\n" + "Nombres: " + nombres + "\n" + "Apellidos: " + apellidos + "\n" +
                            "Dni: " + dni + "\n" + "Número telefónico: " + numeroTelefonico + "\n" + "Experiencia laboral: "
                            + expLaboral + "\n" + "Correo: " + correo);
        }

        private void btnDirigir_Click(object sender, EventArgs e)
        {
            // Llamar al método
            MessageBox.Show(jefeAlmacen.Dirigir());
        }

        private void btnOrganizar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(jefeAlmacen.Organizar());
        }

        private void btnGestionar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(jefeAlmacen.Gestionar());
        }

        private void btnComunicar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(jefeAlmacen.Comunicar());
        }

        private void btnSupervisar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(jefeAlmacen.Supervisar());
        }

        private void btnPlanificar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(jefeAlmacen.Planificar());
        }

        private void btnCoordinar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(jefeAlmacen.Coordinar());
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(jefeAlmacen.Verificar());
        }
    }
}
