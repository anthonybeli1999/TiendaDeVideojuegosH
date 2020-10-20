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
    public partial class FrmProveedores : Form
    {
        public FrmProveedores()
        {
            InitializeComponent();
        }

        private void FrmProveedores_Load(object sender, EventArgs e)
        {
            ClsNProveedores Nobj = new ClsNProveedores();
            DgvProveedores.DataSource = Nobj.MtdListarProveedor();
        }


        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            if (TxtRUC.Text != "" && TxtNombre.Text != "")
            {
                ClsEProveedores Eobj = new ClsEProveedores();
                ClsNProveedores Nobj = new ClsNProveedores();
                Eobj.rucprov =TxtRUC.Text;
                Eobj.nomprov = TxtNombre.Text;
                Nobj.MtdAgregarProveedor(Eobj);
                DgvProveedores.DataSource = Nobj.MtdListarProveedor();
            }
            else
            {
                MessageBox.Show("Por favor llene todos los campos", "Mensaje");
            }
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            if (TxtRUC.Text != "" && TxtNombre.Text != "")
            {
                ClsEProveedores Eobj = new ClsEProveedores();
                ClsNProveedores Nobj = new ClsNProveedores();
                Eobj.rucprov = TxtRUC.Text;
                Eobj.nomprov = TxtNombre.Text;
                Nobj.MtdActualizarProveedor(Eobj);
                DgvProveedores.DataSource = Nobj.MtdListarProveedor();

                TxtRUC.Enabled = true;
                TxtRUC.Clear();
                TxtNombre.Clear();
            }
            else
            {
                MessageBox.Show("Por favor llene todos los campos", "Mensaje");
            }

        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            TxtRUC.Enabled = true;
            TxtRUC.Clear();
            TxtNombre.Clear();
        }

        private void BtnVolver_Click(object sender, EventArgs e)
        {
            FrmMenuPrincipal frm = new FrmMenuPrincipal();
            frm.Show();
            this.Hide();
        }

        private void DgvProveedores_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            TxtRUC.Enabled = false;
            var row = (sender as DataGridView).CurrentRow;
            TxtRUC.Text = row.Cells[0].Value.ToString();
            TxtNombre.Text = row.Cells[1].Value.ToString();
        }

        private void TxtRUC_KeyPress(object sender, KeyPressEventArgs e)
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
