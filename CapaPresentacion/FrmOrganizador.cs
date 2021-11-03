using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// Llamar capa negocio
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class FrmOrganizador : Form
    {
        public FrmOrganizador()
        {
            InitializeComponent();
        }

        Organizador organizador = new Organizador();

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
            organizador.Nombres = nombres;
            organizador.Apellidos = apellidos;
            organizador.Dni = dni;
            organizador.NumeroTelefonico = numeroTelefonico;
            organizador.ExpLaboral = expLaboral;
            organizador.Correo = correo;
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
            string nombres = organizador.Nombres;
            string apellidos = organizador.Apellidos;
            string dni = organizador.Dni;
            string numeroTelefonico = organizador.NumeroTelefonico;
            string expLaboral = organizador.ExpLaboral;
            string correo = organizador.Correo;
            MessageBox.Show("Datos del organizador" + "\n" + "Nombres: " + nombres + "\n" + "Apellidos: " + apellidos + "\n" +
                            "Dni: " + dni + "\n" + "Número telefónico: " + numeroTelefonico + "\n" + "Experiencia laboral: "
                            + expLaboral + "\n" + "Correo: " + correo);
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(organizador.Cargar());
        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(organizador.Ordenar());
        }

        private void btnContarProductos_Click(object sender, EventArgs e)
        {
            MessageBox.Show(organizador.ContarProductos());
        }

        private void btnTrabajar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(organizador.Trabajar());
        }

        private void btnOrganizar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(organizador.Organizar());
        }

        private void btnGestionar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(organizador.Gestionar());
        }
    }
}
