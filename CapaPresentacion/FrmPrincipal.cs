using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void jefeAlmacenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Llamar a JefeAlmacen
            FrmJefeAlmacen frmJefeAlmacen = new FrmJefeAlmacen();
            frmJefeAlmacen.Show();
        }

        private void distribuidorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDistribuidor frmDistribuidor = new FrmDistribuidor();
            frmDistribuidor.Show();
        }

        private void compradoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCompradores frmCompradores = new FrmCompradores();
            frmCompradores.Show();
        }

        private void vendedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmVendedores frmVendedores = new FrmVendedores();
            frmVendedores.Show();
        }

        private void supervisorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSupervisor frmSupervisor = new FrmSupervisor();
            frmSupervisor.Show();
        }

        private void organizadorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmOrganizador frmOrganizador = new FrmOrganizador();
            frmOrganizador.Show();
        }

        private void productoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmProducto frmProducto = new FrmProducto();
            frmProducto.Show();
        }
    }
}
