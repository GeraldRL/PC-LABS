using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// Llamar a negocio
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class FrmProducto : Form
    {
        public FrmProducto()
        {
            InitializeComponent();
        }

        Producto producto = new Producto();

        private void btnEscribir_Click(object sender, EventArgs e)
        {
            // Leer datos
            string nombre = txtNombre.Text.Trim();
            string logotipo = txtLogotipo.Text.Trim();
            string empresaFabricante = txtEmpresaFabricante.Text.Trim();
            string pais = txtPais.Text.Trim();
            string etiqueta = txtEtiqueta.Text.Trim();
            // Escribir los datos en el objeto
            producto.Nombre = nombre;
            producto.Logotipo = logotipo;
            producto.EmpresaFabricante = empresaFabricante;
            producto.Pais = pais;
            producto.Etiqueta = etiqueta;
            // Confirmar
            MessageBox.Show("Se ha escrito correctamente en el objeto");
            // Limpiar
            txtNombre.Clear();
            txtLogotipo.Clear();
            txtEmpresaFabricante.Clear();
            txtPais.Clear();
            txtEtiqueta.Clear();
            //Focus
            txtNombre.Focus();
        }

        private void btnLeer_Click(object sender, EventArgs e)
        {
            // Leer las propiedades del objeto
            string nombre = producto.Nombre;
            string logotipo = producto.Logotipo;
            string empresaFabricante = producto.EmpresaFabricante;
            string pais = producto.Pais;
            string etiqueta = producto.Etiqueta;
            MessageBox.Show("Datos del producto" + "\n" + "Nombre: " + nombre + "\n" + "Logotipo: " + logotipo + "\n" +
                            "Empresa fabricante: " + empresaFabricante + "\n" + "País: " + pais + "\n" + "Etiqueta:  "
                            + etiqueta);
        }

        private void btnFuncionar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(producto.Funcionar());
        }

        private void btnGarantizar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(producto.Garantizar());
        }

        private void btnBeneficiar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(producto.Beneficiar());
        }
    }
}
