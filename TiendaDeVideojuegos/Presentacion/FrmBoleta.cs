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
using TiendaDeVideojuegos.Presentacion;

namespace TiendaDeVideojuegos.Presentacion
{
    public partial class FrmBoleta : Form
    {
        public FrmBoleta()
        {
            InitializeComponent();
        }
        public static double TotalPagar = 0;
        public static int subtotal = 0;
        public static double igv = 0;
        public static int importe = 0;
        public static string serie="";
        public static string numero = "";
        public static int codigoproducto = 0;
        public static int cantidad = 0;

        private void FrmBoleta_Load(object sender, EventArgs e)
        {
            TxtSubTotal.Text = 0.ToString();
            TxtTotalPagar.Text = 0.ToString();
            GbProveedor.Enabled = false;
            GbEmpleado.Enabled = false;
            GbProducto.Enabled = false;
            GbCliente.Enabled = false;
            TxtSerie.Enabled = false;
            TxtNumero.Enabled = false;
            ClsEDetalleBoleta Eobj = new ClsEDetalleBoleta();
            ClsNDetalleBoleta Nobj = new ClsNDetalleBoleta();
            Nobj.MtdBuscarDetalleBoleta(Eobj);
            //DgvDetalleBoleta.DataSource = Nobj.MtdListarDetalleBoleta();
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            TxtSerie.Enabled = true;
            TxtNumero.Enabled = true;

            //*********PROVEEDOR************
            GbProveedor.Enabled = true;
            TxtRUCProveedor.Clear();
            TxtNombreProveedor.Clear();
            TxtNombreProveedor.Enabled = false;

            //*********EMPLEADO*************
            GbEmpleado.Enabled = true;
            TxtNombreEmpleado.Text = FrmLogin.NombreEmpleado;
            TxtCodigoEmpleado.Text = FrmLogin.CodigoEmpleado;
            TxtNombreEmpleado.Enabled = false;
            TxtCodigoEmpleado.Enabled = false;

            //**********CLIENTE*************
            GbCliente.Enabled = true;
            TxtNombreCliente.Clear();

            //**********PRODUCTO************
            GbProducto.Enabled = true;
            TxtCantidadProducto.Clear();
            TxtCantidadProducto.Clear();
            TxtCodigoProducto.Clear();
            TxtPrecioProducto.Clear();
            TxtNombreProducto.Clear();
            TxtCantidadCompra.Clear();
            TxtImporteCompra.Clear();
            TxtCantidadProducto.Enabled = false;
            TxtPrecioProducto.Enabled = false;
            TxtNombreProducto.Enabled = false;
            TxtImporteCompra.Enabled = false;

            //**********PRODUCTO************
            TxtSubTotal.Enabled = false;
            TxtIGV.Enabled = false;
            TxtTotalPagar.Enabled = false;
            BtnAgregar.Enabled = false;

        }

        private void BtnVolver_Click(object sender, EventArgs e)
        {
            FrmMenuPrincipal frm = new FrmMenuPrincipal();
            frm.Show();
            this.Hide();
        }

        private void TxtRUC_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnNuevoProveedor_Click(object sender, EventArgs e)
        {
            FrmProveedores frm = new FrmProveedores();
            frm.Show();
            this.Hide();
        }

        private void TxtCodigoProducto_TextChanged(object sender, EventArgs e)
        {
            ClsEProductos Eobj = new ClsEProductos();
            ClsNProductos Nobj = new ClsNProductos();

            foreach (DataRow row in Nobj.MtdListarProductos().Rows)
            {
                if (TxtCodigoProducto.Text == row[0].ToString())
                {
                    TxtNombreProducto.Text = row[1].ToString();
                    TxtCantidadProducto.Text = row[2].ToString();
                    TxtPrecioProducto.Text = row[3].ToString();
                }

            }
        }

        private void TxtRUCProveedor_TextChanged(object sender, EventArgs e)
        {
            ClsEProveedores Eobj = new ClsEProveedores();
            ClsNProveedores Nobj = new ClsNProveedores();

            foreach (DataRow row in Nobj.MtdListarProveedor().Rows)
            {
                if (TxtRUCProveedor.Text == row[0].ToString())
                {
                    TxtNombreProveedor.Text = row[1].ToString();
                }

            }
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            BtnSUBTOTAL.Enabled = true;
            BtnAgregar.Enabled = false;
            TotalPagar = Convert.ToInt32(TxtSubTotal.Text) + Convert.ToDouble(TxtIGV.Text);
            subtotal = subtotal + Convert.ToInt32(TxtSubTotal.Text);
            igv= igv + Convert.ToDouble(TxtIGV.Text);
            TxtTotalPagar.Text = (Convert.ToDouble(TxtTotalPagar.Text) + TotalPagar).ToString();

            if (TxtSerie.Text != "" && TxtNumero.Text != "" && TxtRUCProveedor.Text != "" && TxtCodigoEmpleado.Text != "" && TxtNombreCliente.Text != "" && TxtSubTotal.Text != "" && TxtIGV.Text != "" && TxtTotalPagar.Text != "")
            {
                ClsEBoleta Eobj1 = new ClsEBoleta();
                ClsNBoleta Nobj1 = new ClsNBoleta();

                Eobj1.serie = TxtSerie.Text;
                Eobj1.numero = TxtNumero.Text;
                Eobj1.rucprov = TxtRUCProveedor.Text;
                Eobj1.codemp = TxtCodigoEmpleado.Text;
                Eobj1.cliente = TxtNombreCliente.Text;
                Eobj1.fecha = DtpFecha.Text;
                Eobj1.subtotal = Convert.ToDouble(TxtSubTotal.Text);
                Eobj1.igv = Convert.ToDouble(TxtIGV.Text);
                Eobj1.total = Convert.ToDouble(TxtTotalPagar.Text);
                Nobj1.MtdAgregarBoleta(Eobj1);


                int ayuda = 0;
                int cantidad = 0;
                ClsEDetalleBoleta Eobj = new ClsEDetalleBoleta();
                ClsNDetalleBoleta Nobj = new ClsNDetalleBoleta();
                ClsEProductos Eobj2 = new ClsEProductos();
                ClsNProductos Nobj2 = new ClsNProductos();


                Eobj.serie = TxtSerie.Text;
                Eobj.numero = TxtNumero.Text;

                Eobj.codigoproducto = TxtCodigoProducto.Text;
                Eobj2.codprod= TxtCodigoProducto.Text;

                Eobj.nombreproducto = TxtNombreProducto.Text;
                Eobj.cantidad = Convert.ToInt32(TxtCantidadCompra.Text);
                Eobj2.cantprod = Convert.ToInt32(TxtCantidadCompra.Text);

                Eobj.subtotal = Convert.ToDouble(TxtImporteCompra.Text);

                foreach (DataRow row in Nobj.MtdListarDetalleBoleta().Rows)
                {
                    if(Eobj.serie == (row[0]).ToString() && Eobj.numero == (row[1]).ToString() && Eobj.codigoproducto == (row[2]).ToString())
                    {
                        cantidad = Convert.ToInt32(row[4]);
                        ayuda++;
                    }
                }

                if (ayuda == 0)
                {        
                    Eobj.subtotal = Convert.ToInt32(TxtSubTotal.Text);
                    Nobj.MtdAgregarDetalleBoleta(Eobj);
                    Nobj2.MtdCompraProductos(Eobj2);
                    DgvDetalleBoleta.DataSource = Nobj.MtdListarDetalleBoleta();
                    Eobj.serie = TxtSerie.Text;
                    Eobj.numero = TxtNumero.Text;
                    TxtCantidadProducto.Text = (Convert.ToInt32(TxtCantidadProducto.Text) - Convert.ToInt32(TxtCantidadCompra.Text)).ToString();
                }

                else if(ayuda == 1)
                {
                    Eobj.cantidad = Convert.ToInt32(TxtCantidadCompra.Text);
                    Eobj.subtotal = Convert.ToInt32(TxtSubTotal.Text);
                    Eobj2.cantprod = Convert.ToInt32(TxtCantidadCompra.Text);
                    Nobj.MtdActualizarDetalleBoleta(Eobj);
                    Nobj2.MtdCompraProductos(Eobj2);
                    DgvDetalleBoleta.DataSource = Nobj.MtdListarDetalleBoleta();
                    Eobj.serie = TxtSerie.Text;
                    Eobj.numero = TxtNumero.Text;
                    TxtCantidadProducto.Text = (Convert.ToInt32(TxtCantidadProducto.Text) - Convert.ToInt32(TxtCantidadCompra.Text)).ToString();
                }
                DgvDetalleBoleta.DataSource = Nobj.MtdBuscarDetalleBoleta(Eobj);
            }
            else
            {
                MessageBox.Show("Por favor llene todos los campos", "Mensaje");
            }
        }


        private void TxtRUCProveedor_KeyPress(object sender, KeyPressEventArgs e)
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

        private void TxtCodigoProducto_KeyPress(object sender, KeyPressEventArgs e)
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

        private void TxtCantidadCompra_KeyPress(object sender, KeyPressEventArgs e)
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

        private void TxtNumero_KeyPress(object sender, KeyPressEventArgs e)
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

        private void TxtCantidadCompra_TextChanged(object sender, EventArgs e)
        {
            
            if (TxtPrecioProducto.Text != "")
            {
                if (TxtCantidadCompra.Text != "")
                {
                    TxtImporteCompra.Text = (Convert.ToInt32(TxtPrecioProducto.Text) * Convert.ToInt32(TxtCantidadCompra.Text)).ToString();
                }
            }
        }

        private void BtnSUBTOTAL_Click(object sender, EventArgs e)
        {
            BtnAgregar.Enabled = true;
            if (TxtCantidadCompra.Text == "" || (Convert.ToInt32(TxtCantidadCompra.Text) > Convert.ToInt32(TxtCantidadProducto.Text)))
            {
                MessageBox.Show("Datos Invalidos");
            }
            else
            {
                TxtSubTotal.Text = (Convert.ToInt32(TxtImporteCompra.Text) + Convert.ToInt32(TxtSubTotal.Text)).ToString();
                TxtIGV.Text = (Convert.ToInt32(TxtSubTotal.Text) * 0.18).ToString();               
            }
            BtnSUBTOTAL.Enabled = false;
            
        }

        private void DgvDetalleBoleta_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = (sender as DataGridView).CurrentRow;
            serie = row.Cells[0].Value.ToString();
            numero = row.Cells[1].Value.ToString();
            codigoproducto = Convert.ToInt32(row.Cells[2].Value);
            cantidad = Convert.ToInt32(row.Cells[4].Value);
        }

        private void BtnQuitar_Click(object sender, EventArgs e)
        {
            ClsNDetalleBoleta Nobj = new ClsNDetalleBoleta();
            ClsEDetalleBoleta Eobj = new ClsEDetalleBoleta();

            ClsEProductos Eobj2 = new ClsEProductos();
            ClsNProductos Nobj2 = new ClsNProductos();

            Eobj.serie = serie;
            Eobj.numero = numero;
            Eobj.codigoproducto = codigoproducto.ToString();
            Eobj2.codprod = codigoproducto.ToString();
            Eobj2.cantprod = cantidad;

            foreach (DataRow row in Nobj.MtdListarDetalleBoleta().Rows)
            {
                if (Eobj.serie == row[0].ToString() && Eobj.numero == row[1].ToString() && Eobj.codigoproducto == (row[2]).ToString())
                {
                    TxtTotalPagar.Text = (Convert.ToDouble(TxtTotalPagar.Text)- Convert.ToInt32(row[5])).ToString();
                    Nobj.MtdEliminarDetalleBoleta(Eobj);
                    Nobj2.MtdDevolverProductos(Eobj2);
                    DgvDetalleBoleta.DataSource = Nobj.MtdListarDetalleBoleta();
                }
            }

            //Nobj.MtdEliminarDetalleBoleta(Eobj);
            //Nobj2.MtdDevolverProductos(Eobj2);
            //DgvDetalleBoleta.DataSource = Nobj.MtdListarDetalleBoleta();
        }

        private void TxtSerie_KeyPress(object sender, KeyPressEventArgs e)
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

        private void TxtNombreCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (e.KeyChar == Convert.ToChar("'"))
            {
                TxtNombreCliente.Enabled = true;
            }
            else if (e.KeyChar == Convert.ToChar("@"))
            {
                TxtNombreCliente.Enabled = true;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void BtnLimpiarCompra_Click(object sender, EventArgs e)
        {
            TxtSubTotal.Text=0.ToString();
            TxtIGV.Text = 0.ToString();
            BtnSUBTOTAL.Enabled = true;
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (TxtSerie.Text != "" && TxtNumero.Text != "" && TxtRUCProveedor.Text != "" && TxtCodigoEmpleado.Text != "" && TxtNombreCliente.Text != "" && TxtSubTotal.Text != "" && TxtIGV.Text != "" && TxtTotalPagar.Text != "")
            {
                if (MessageBox.Show("Enserio quieres imprimir la boleta", "Mensaje", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    MessageBox.Show("Boleta Impresa", "Mensaje");

                    ClsEBoleta Eobj1 = new ClsEBoleta();
                    ClsNBoleta Nobj1 = new ClsNBoleta();
                    Eobj1.serie = TxtSerie.Text;
                    Eobj1.numero = TxtNumero.Text;
                    Eobj1.subtotal = subtotal;
                    Eobj1.igv = igv;
                    Eobj1.total = Convert.ToDouble(TxtTotalPagar.Text);
                    Nobj1.MtdActualizarBoleta(Eobj1);

                    TxtSerie.Enabled = true;
                    TxtNumero.Enabled = true;

                    TxtSerie.Clear();
                    TxtNumero.Clear();

                    //*********PROVEEDOR************
                    GbProveedor.Enabled = true;
                    TxtRUCProveedor.Clear();
                    TxtNombreProveedor.Clear();
                    TxtNombreProveedor.Enabled = false;

                    //*********EMPLEADO*************
                    GbEmpleado.Enabled = true;
                    TxtNombreEmpleado.Text = FrmLogin.NombreEmpleado;
                    TxtCodigoEmpleado.Text = FrmLogin.CodigoEmpleado;
                    TxtNombreEmpleado.Enabled = false;
                    TxtCodigoEmpleado.Enabled = false;

                    //**********CLIENTE*************
                    GbCliente.Enabled = true;
                    TxtNombreCliente.Clear();

                    //**********PRODUCTO************
                    GbProducto.Enabled = true;
                    TxtCantidadProducto.Clear();
                    TxtCantidadProducto.Clear();
                    TxtCodigoProducto.Clear();
                    TxtPrecioProducto.Clear();
                    TxtNombreProducto.Clear();
                    TxtCantidadCompra.Clear();
                    TxtImporteCompra.Clear();
                    TxtCantidadProducto.Enabled = false;
                    TxtPrecioProducto.Enabled = false;
                    TxtNombreProducto.Enabled = false;
                    TxtImporteCompra.Enabled = false;

                    //**********PRODUCTO************
                    TxtSubTotal.Enabled = false;
                    TxtIGV.Enabled = false;
                    TxtTotalPagar.Enabled = false;
                    BtnAgregar.Enabled = false;

                    TxtSubTotal.Text = 0.ToString();
                    TxtIGV.Text = 0.ToString();
                    TxtTotalPagar.Text = 0.ToString();

                    ClsEDetalleBoleta Eobj = new ClsEDetalleBoleta();
                    ClsNDetalleBoleta Nobj = new ClsNDetalleBoleta();
                    Eobj.serie = "";
                    Eobj.numero = "";
                    DgvDetalleBoleta.DataSource = Nobj.MtdBuscarDetalleBoleta(Eobj);
                }
            }
            else
            {
                MessageBox.Show("Boleta Vacia", "Mensaje");
            }
        }
    }
}
