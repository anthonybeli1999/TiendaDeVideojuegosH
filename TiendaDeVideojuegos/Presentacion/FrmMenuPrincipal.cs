using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TiendaDeVideojuegos.Presentacion;

namespace TiendaDeVideojuegos
{
    public partial class FrmMenuPrincipal : Form
    {
        public FrmMenuPrincipal()
        {
            InitializeComponent();
        }

        private void BtnEmpleados_Click(object sender, EventArgs e)
        {
            FrmEmpleadosRegistro frm = new FrmEmpleadosRegistro();
            frm.Show();
            this.Hide();
        }

        private void BtnProveedores_Click(object sender, EventArgs e)
        {
            FrmProveedores frm = new FrmProveedores();
            frm.Show();
            this.Hide();
        }

        private void BtnProductos_Click(object sender, EventArgs e)
        {
            FrmProductos frm = new FrmProductos();
            frm.Show();
            this.Hide();
        }

        private void BtnBoleta_Click(object sender, EventArgs e)
        {
            FrmBoleta frm = new FrmBoleta();
            frm.Show();
            this.Hide();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            FrmLogin frm = new FrmLogin();
            frm.Show();
            this.Hide();
        }
    }
}
