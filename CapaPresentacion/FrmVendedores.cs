using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Capa negocio
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class FrmVendedores : Form
    {
        public FrmVendedores()
        {
            InitializeComponent();
        }

        Vendedores vendedores = new Vendedores();

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
            vendedores.Nombres = nombres;
            vendedores.Apellidos = apellidos;
            vendedores.Dni = dni;
            vendedores.NumeroTelefonico = numeroTelefonico;
            vendedores.ExpLaboral = expLaboral;
            vendedores.Correo = correo;
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
            string nombres = vendedores.Nombres;
            string apellidos = vendedores.Apellidos;
            string dni = vendedores.Dni;
            string numeroTelefonico = vendedores.NumeroTelefonico;
            string expLaboral = vendedores.ExpLaboral;
            string correo = vendedores.Correo;
            MessageBox.Show("Datos del vendedor" + "\n" + "Nombres: " + nombres + "\n" + "Apellidos: " + apellidos + "\n" +
                            "Dni: " + dni + "\n" + "Número telefónico: " + numeroTelefonico + "\n" + "Experiencia laboral: "
                            + expLaboral + "\n" + "Correo: " + correo);
        }

        private void btnGestionar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(vendedores.Gestionar());
        }

        private void btnAutorizar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(vendedores.Autorizar());
        }

        private void btnCaptarAtencion_Click(object sender, EventArgs e)
        {
            MessageBox.Show(vendedores.CaptarAtencion());
        }

        private void btnDeterminar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(vendedores.Determinar());
        }

        private void btnTrabajarEquipo_Click(object sender, EventArgs e)
        {
            MessageBox.Show(vendedores.TrabajarEquipo());
        }
    }
}
