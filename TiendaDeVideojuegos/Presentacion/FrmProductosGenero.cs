using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TiendaDeVideojuegos.Entidad;
using TiendaDeVideojuegos.Negocios;

namespace TiendaDeVideojuegos
{
    public partial class FrmProductosGenero : Form
    {
        public FrmProductosGenero()
        {
            InitializeComponent();
        }

        private void FrmProductosGenero_Load(object sender, EventArgs e)
        {
            ClsNGenero Nobj = new ClsNGenero();
            DgvGenero.DataSource = Nobj.MtdListarGenero();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            if (TxtCodigo.Text != "" && TxtNombre.Text != "")
            {
                ClsEGenero Eobj = new ClsEGenero();
                ClsNGenero Nobj = new ClsNGenero();
                Eobj.codgen = TxtCodigo.Text;
                Eobj.nomgen = TxtNombre.Text;
                Nobj.MtdAgregarGenero(Eobj);
                DgvGenero.DataSource = Nobj.MtdListarGenero();
            }
            else
            {
                MessageBox.Show("Por favor llene todos los campos", "Mensaje");
            }
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            if (TxtCodigo.Text != "" && TxtNombre.Text != "")
            {
                ClsEGenero Eobj = new ClsEGenero();
                ClsNGenero Nobj = new ClsNGenero();
                Eobj.codgen = TxtCodigo.Text;
                Eobj.nomgen = TxtNombre.Text;
                Nobj.MtdActualizarGenero(Eobj);
                DgvGenero.DataSource = Nobj.MtdListarGenero();

                TxtCodigo.Enabled = true;
                TxtCodigo.Clear();
                TxtNombre.Clear();
            }
            else
            {
                MessageBox.Show("Por favor llene todos los campos", "Mensaje");
            }

        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            TxtCodigo.Enabled = true;
            TxtCodigo.Clear();
            TxtNombre.Clear();
        }

        private void BtnVolver_Click(object sender, EventArgs e)
        {
            FrmProductos frm = new FrmProductos();
            frm.Show();
            this.Hide();
        }

        private void DgvGenero_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            TxtCodigo.Enabled = false;
            var row = (sender as DataGridView).CurrentRow;
            TxtCodigo.Text = row.Cells[0].Value.ToString();
            TxtNombre.Text = row.Cells[1].Value.ToString();
        }

        private void TxtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void TxtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = true;
            }
        }
    }
}
