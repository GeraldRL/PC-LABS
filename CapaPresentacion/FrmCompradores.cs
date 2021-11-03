using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// Lammar negocio
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class FrmCompradores : Form
    {
        public FrmCompradores()
        {
            InitializeComponent();
        }
        // Declarar el objeto de la clase
        Compradores compradores = new Compradores();

        private void btnEscribir_Click(object sender, EventArgs e)
        {
            // Leer datos

            string nombres = txtNombres.Text.Trim();
            string apellidos = txtApellidos.Text.Trim();
            string dni = txtDni.Text.Trim();
            string ubicacion = txtUbicacion.Text.Trim();
            string numeroTelefonico = txtNumeroTelefonico.Text.Trim();
            string correo = txtCorreo.Text.Trim();
            string antecedentes = txtAntecedentes.Text.Trim();
            // Escribir los datos del distribuidor en el objeto
            compradores.Nombres = nombres;
            compradores.Apellidos = apellidos;
            compradores.Dni = dni;
            compradores.Ubicacion = ubicacion;
            compradores.NumeroTelefonico = numeroTelefonico;
            compradores.Correo = correo;
            compradores.Antecedentes = antecedentes;
            // Confirmar que se ha escrito en el objeto
            MessageBox.Show("Se ha escrito correctamente en el objeto");
            // Limpiar las cajas
            txtNombres.Clear();
            txtApellidos.Clear();
            txtDni.Clear();
            txtUbicacion.Clear();
            txtNumeroTelefonico.Clear();
            txtCorreo.Clear();
            txtAntecedentes.Clear();
            // Hacer que el mouse este en nombres
            txtNombres.Focus();
        }

        private void btnLeer_Click(object sender, EventArgs e)
        {
            // Leer propiedades
            string nombres = compradores.Nombres;
            string apellidos = compradores.Apellidos;
            string dni = compradores.Dni;
            string ubicacion = compradores.Ubicacion;
            string numeroTelefonico = compradores.NumeroTelefonico;
            string correo = compradores.Correo;
            string antecedentes = compradores.Antecedentes;
            MessageBox.Show("Datos del comprador" + "\n" + "Nombres: " + nombres + "\n" + "Apellidos: " + apellidos +
                            "\n" + "Dni: " + dni + "\n" + "Ubicacion: " + ubicacion + "\n" + "Número telefónico: " +
                            numeroTelefonico + "\n" + "Correo: " + correo + "\n" + "Antecedentes: " + antecedentes);
        }

        private void btnOrganizar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(compradores.Organizar());
        }

        private void btnRevenderProducto_Click(object sender, EventArgs e)
        {
            MessageBox.Show(compradores.RevenderProductos());
        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(compradores.Ordenar());
        }

        private void btnPromocionar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(compradores.Promocionar());
        }

        private void btnOfrecerProducto_Click(object sender, EventArgs e)
        {
            MessageBox.Show(compradores.OfrecerProducto());
        }
    }
}
