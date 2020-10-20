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
    public partial class FrmProductosRegistro : Form
    {
        public FrmProductosRegistro()
        {
            InitializeComponent();
        }

        private void FrmProductosRegistro_Load(object sender, EventArgs e)
        {
            ClsNProductos Nobj = new ClsNProductos();
            DgvProductos.DataSource = Nobj.MtdListarProductos();

            ClsNPlataforma NNObj = new ClsNPlataforma();
            CmbPlataforma.DataSource = NNObj.MtdListarCodigoPlataforma();
            CmbPlataforma.DisplayMember = "CodigoPlat";
            CmbNombrePlataforma.Enabled = false;
            CmbPlataforma.Text = "";
            CmbNombrePlataforma.Text = "";
            

            ClsNGenero NNNObj = new ClsNGenero();
            CmbGenero.DataSource = NNNObj.MtdListarCodigoGenero();
            CmbGenero.DisplayMember = "CodigoGen";
            CmbNombreGenero.Enabled = false;
            CmbGenero.Text = "";
            CmbNombreGenero.Text = "";

        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            if (TxtCodigo.Text != "" && TxtNombre.Text != "" && TxtCantidad.Text != "" && TxtPrecio.Text != "" && CmbPlataforma.Text != "" && CmbGenero.Text != "")
            {
                ClsEProductos Eobj = new ClsEProductos();
                ClsNProductos Nobj = new ClsNProductos();
                Eobj.codprod = TxtCodigo.Text;
                Eobj.nomprod = TxtNombre.Text;
                Eobj.cantprod = Convert.ToInt32(TxtCantidad.Text);
                Eobj.preprod = Convert.ToInt32(TxtPrecio.Text);
                Eobj.codplat = CmbPlataforma.Text;
                Eobj.codgen = CmbGenero.Text;
                Nobj.MtdAgregarProductos(Eobj);
                DgvProductos.DataSource = Nobj.MtdListarProductos();
            }
            else
            {
                MessageBox.Show("Por favor llene todos los campos", "Mensaje");
            }
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            if (TxtCodigo.Text != "" && TxtNombre.Text != "" && TxtCantidad.Text != "" && TxtPrecio.Text != "" && CmbPlataforma.Text != "" && CmbGenero.Text != "")
            {
                ClsEProductos Eobj = new ClsEProductos();
                ClsNProductos Nobj = new ClsNProductos();
                Eobj.codprod = TxtCodigo.Text;
                Eobj.nomprod = TxtNombre.Text;
                Eobj.cantprod = Convert.ToInt32(TxtCantidad.Text);
                Eobj.preprod = Convert.ToInt32(TxtPrecio.Text);
                Eobj.codplat = CmbPlataforma.Text;
                Eobj.codgen = CmbGenero.Text;
                Nobj.MtdActualizarProductos(Eobj);
                DgvProductos.DataSource = Nobj.MtdListarProductos();

                TxtCodigo.Enabled = true;
                TxtCodigo.Clear();
                TxtNombre.Clear();
                TxtCantidad.Clear();
                TxtPrecio.Clear();
                CmbPlataforma.Text = "";
                CmbGenero.Text = "";
                CmbNombreGenero.Text = "";
                CmbNombrePlataforma.Text = "";
            }
            else
            {
                MessageBox.Show("Por favor llene todos los campos", "Mensaje");
            }

        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            TxtCodigo.Enabled = true;
            TxtCantidad.Enabled = true;
            TxtCodigo.Clear();
            TxtNombre.Clear();
            TxtCantidad.Clear();
            TxtPrecio.Clear();
            CmbPlataforma.Text = "";
            CmbGenero.Text = "";
            CmbNombreGenero.Text = "";
            CmbNombrePlataforma.Text = "";
        }

        private void BtnVolver_Click(object sender, EventArgs e)
        {
            FrmProductos frm = new FrmProductos();
            frm.Show();
            this.Hide();
        }

        private void DgvProductos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            TxtCodigo.Enabled = false;
            TxtCantidad.Enabled = false;
            var row = (sender as DataGridView).CurrentRow;
            TxtCodigo.Text = row.Cells[0].Value.ToString();
            TxtNombre.Text = row.Cells[1].Value.ToString();
            TxtCantidad.Text = row.Cells[2].Value.ToString();
            TxtPrecio.Text = row.Cells[3].Value.ToString();
            CmbPlataforma.Text = row.Cells[4].Value.ToString();
            CmbGenero.Text = row.Cells[5].Value.ToString();
        }

        private void CmbPlataforma_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClsEPlataforma Eobj = new ClsEPlataforma();
            ClsNPlataforma Nobj = new ClsNPlataforma();
            CmbNombrePlataforma.DataSource = Nobj.MtdBuscarPlataforma(CmbPlataforma.Text);
            CmbNombrePlataforma.DisplayMember = "NombrePlat";
        }

        private void CmbGenero_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClsEGenero Eobj = new ClsEGenero();
            ClsNGenero Nobj = new ClsNGenero();
            CmbNombreGenero.DataSource = Nobj.MtdBuscarGenero(CmbGenero.Text);
            CmbNombreGenero.DisplayMember = "NombreGen";
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

        private void TxtCantidad_KeyPress(object sender, KeyPressEventArgs e)
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

        private void TxtPrecio_KeyPress(object sender, KeyPressEventArgs e)
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
