using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// Capanegocio
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class FrmSupervisor : Form
    {
        public FrmSupervisor()
        {
            InitializeComponent();
        }

        Supervisor supervisor = new Supervisor();

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
            supervisor.Nombres = nombres;
            supervisor.Apellidos = apellidos;
            supervisor.Dni = dni;
            supervisor.NumeroTelefonico = numeroTelefonico;
            supervisor.ExpLaboral = expLaboral;
            supervisor.Correo = correo;
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
            string nombres = supervisor.Nombres;
            string apellidos = supervisor.Apellidos;
            string dni = supervisor.Dni;
            string numeroTelefonico = supervisor.NumeroTelefonico;
            string expLaboral = supervisor.ExpLaboral;
            string correo = supervisor.Correo;
            MessageBox.Show("Datos del supervisor" + "\n" + "Nombres: " + nombres + "\n" + "Apellidos: " + apellidos + "\n" +
                            "Dni: " + dni + "\n" + "Número telefónico: " + numeroTelefonico + "\n" + "Experiencia laboral: "
                            + expLaboral + "\n" + "Correo: " + correo);
        }

        private void btnOrganizar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(supervisor.Organizar());
        }

        private void btnSupervisar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(supervisor.Supervisar());
        }

        private void btnDirigir_Click(object sender, EventArgs e)
        {
            MessageBox.Show(supervisor.Dirigir());
        }

        private void btnEvaluar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(supervisor.Evaluar());
        }

        private void btnMediar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(supervisor.Mediar());
        }
    }
}
