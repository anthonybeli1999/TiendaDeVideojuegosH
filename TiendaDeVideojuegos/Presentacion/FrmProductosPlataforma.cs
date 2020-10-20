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
    public partial class FrmProductosPlataforma : Form
    {
        public FrmProductosPlataforma()
        {
            InitializeComponent();
        }

        private void FrmProductosPlataforma_Load(object sender, EventArgs e)
        {
            ClsNPlataforma Nobj = new ClsNPlataforma();
            DgvPlataforma.DataSource = Nobj.MtdListarPlataforma();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            if (TxtCodigo.Text != "" && TxtNombre.Text != "")
            {
                ClsEPlataforma Eobj = new ClsEPlataforma();
                ClsNPlataforma Nobj = new ClsNPlataforma();
                Eobj.codplat = TxtCodigo.Text;
                Eobj.nomplat = TxtNombre.Text;
                Nobj.MtdAgregarPlataforma(Eobj);
                DgvPlataforma.DataSource = Nobj.MtdListarPlataforma();
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
                ClsEPlataforma Eobj = new ClsEPlataforma();
                ClsNPlataforma Nobj = new ClsNPlataforma();
                Eobj.codplat = TxtCodigo.Text;
                Eobj.nomplat = TxtNombre.Text;
                Nobj.MtdActualizarPlataforma(Eobj);
                DgvPlataforma.DataSource = Nobj.MtdListarPlataforma();

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

        private void DgvPlataforma_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
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
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
    }
}
