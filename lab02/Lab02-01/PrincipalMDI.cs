using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab02_01
{
    public partial class PrincipalMDI : Form
    {
        public PrincipalMDI()
        {
            InitializeComponent();
        }

        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            manUsuario frm = new manUsuario();
            frm.Show();
        }

        private void PrincipalMDI_Load(object sender, EventArgs e)
        {

        }

        private void salirDelSistemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mnuManProductos_Click(object sender, EventArgs e)
        {
            manProductos mProductos = new manProductos();
            mProductos.Show();
        }

        private void mnuManCategorias_Click(object sender, EventArgs e)
        {
            manCategorias mCategorias = new manCategorias();
            mCategorias.Show();
        }

        private void mnuManProveedores_Click(object sender, EventArgs e)
        {
            manProveedores mProveedores = new manProveedores();
            mProveedores.Show();
        }

        private void mnuManClientes_Click(object sender, EventArgs e)
        {
            manClientes mClientes = new manClientes();
            mClientes.Show();
        }

        private void registrarVentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            regVentas rVentas = new regVentas();
            rVentas.Show();
        }
    }
}
