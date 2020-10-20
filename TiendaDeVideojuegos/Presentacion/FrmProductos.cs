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
    public partial class FrmProductos : Form
    {
        public FrmProductos()
        {
            InitializeComponent();
        }

        private void BtnVolver_Click(object sender, EventArgs e)
        {
            FrmMenuPrincipal frm = new FrmMenuPrincipal();
            frm.Show();
            this.Hide();
        }

        private void BtnPlataforma_Click(object sender, EventArgs e)
        {
            FrmProductosPlataforma frm = new FrmProductosPlataforma();
            frm.Show();
            this.Hide();

        }

        private void BtnGenero_Click(object sender, EventArgs e)
        {
            FrmProductosGenero frm = new FrmProductosGenero();
            frm.Show();
            this.Hide();
        }

        private void BtnProducto_Click(object sender, EventArgs e)
        {
            FrmProductosRegistro frm = new FrmProductosRegistro();
            frm.Show();
            this.Hide();
        }

        private void BtnStock_Click(object sender, EventArgs e)
        {
            FrmProductosStock frm = new FrmProductosStock();
            frm.Show();
            this.Hide();
        }
    }
}
