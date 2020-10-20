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

namespace TiendaDeVideojuegos.Presentacion
{
    public partial class FrmProductosStock : Form
    {
        public FrmProductosStock()
        {
            InitializeComponent();
        }

        private void FrmProductosStock_Load(object sender, EventArgs e)
        {
            ClsEProductos Eobj = new ClsEProductos();
            ClsNProductos Nobj = new ClsNProductos();
            DgvProductos.DataSource = Nobj.MtdListarProductos();

            ClsNProveedores NObj = new ClsNProveedores();
            CmbProveedor.DataSource = NObj.MtdListarRUCProveedor();
            CmbProveedor.DisplayMember = "RUCProv";
            CmbNombreProveedor.Enabled = false;
            CmbProveedor.Text = "";
            CmbNombreProveedor.Text = "";

            TxtCodigo.Enabled = false;
            TxtCantidad.Enabled = false;
            TxtNombre.Enabled = false;

        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            if (TxtBuscar.Text != "")
            {
            ClsEProductos Eobj = new ClsEProductos();
            ClsNProductos Nobj = new ClsNProductos();
            Eobj.codprod = TxtBuscar.Text;
            DgvProductos.DataSource = Nobj.MtdBuscarProducto(Eobj);
            TxtBuscar.Clear();
            }
            else
            {
                MessageBox.Show("Por favor llene todos los campos", "Mensaje");
            }
            
        }

        private void DgvProductos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            TxtCodigo.Enabled = false;
            TxtCantidad.Enabled = false;
            TxtNombre.Enabled = false;
            var row = (sender as DataGridView).CurrentRow;
            TxtCodigo.Text = row.Cells[0].Value.ToString();
            TxtNombre.Text = row.Cells[1].Value.ToString();
            TxtCantidad.Text = row.Cells[2].Value.ToString();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            int suma = 0;
            if (CmbProveedor.Text != "" && CmbNombreProveedor.Text != "" && TxtCodigo.Text != "" && TxtNombre.Text != "" && TxtCantidad.Text != "" && TxtStock.Text != "")
            {
                ClsEProductos Eobj = new ClsEProductos();
                ClsNProductos Nobj = new ClsNProductos();
                Eobj.codprod = TxtCodigo.Text;
                suma = Convert.ToInt32(TxtCantidad.Text) + Convert.ToInt32(TxtStock.Text);
                if (suma > 99999)
                {
                    MessageBox.Show("La suma supera el stock maximo", "Mensaje");
                }
                else
                {
                    Eobj.cantprod = suma;
                    Nobj.MtdActualizarStockProductos(Eobj);
                    DgvProductos.DataSource = Nobj.MtdListarProductos();

                    TxtCodigo.Clear();
                    TxtNombre.Clear();
                    TxtCantidad.Clear();
                    TxtStock.Clear();
                    TxtBuscar.Clear();
                    CmbNombreProveedor.Text = "";
                    CmbProveedor.Text = "";
                }               

            }
            else
            {
                MessageBox.Show("Por favor llene todos los campos", "Mensaje");
            }
        }

        private void BtnVolver_Click(object sender, EventArgs e)
        {
            FrmProductos frm = new FrmProductos();
            frm.Show();
            this.Hide();
        }

        private void CmbProveedor_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClsEProveedores EObj = new ClsEProveedores();
            ClsNProveedores NObj = new ClsNProveedores();
            CmbNombreProveedor.DataSource = NObj.MtdBuscarProveedor(CmbProveedor.Text);
            CmbNombreProveedor.DisplayMember = "NombreProv";

        }

        private void TxtStock_KeyPress(object sender, KeyPressEventArgs e)
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

        private void TxtBuscar_KeyPress(object sender, KeyPressEventArgs e)
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
    }
}
