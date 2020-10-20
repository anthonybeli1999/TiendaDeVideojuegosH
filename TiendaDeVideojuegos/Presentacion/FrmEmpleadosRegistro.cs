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
    public partial class FrmEmpleadosRegistro : Form
    {
        public FrmEmpleadosRegistro()
        {
            InitializeComponent();
        }

        private void BtnVolver_Click(object sender, EventArgs e)
        {
            FrmMenuPrincipal frm = new FrmMenuPrincipal();
            frm.Show();
            this.Hide();
        }

        private void FrmEmpleadosRegistro_Load(object sender, EventArgs e)
        {
            ClsNEmpleados Nobj = new ClsNEmpleados();
            DgvEmpleados.DataSource = Nobj.MtdListarEmpleados();
            CmbEstado.Text = "Activo";
            CmbEstado.Items.Add("Activo");
            CmbEstado.Items.Add("Inactivo");
            CmbEstado.Enabled = false;
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            if (TxtCodigo.Text != "" && TxtNombre.Text != "" && TxtApellido.Text != "" && TxtClave.Text != "" && TxtDireccion.Text != "" && CmbEstado.Text != "")
            {
                ClsEEmpleados Eobj = new ClsEEmpleados();
                ClsNEmpleados Nobj = new ClsNEmpleados();
                Eobj.codemp = TxtCodigo.Text;
                Eobj.nomemp = TxtNombre.Text;
                Eobj.apeemp = TxtApellido.Text;
                Eobj.claemp = TxtClave.Text;
                Eobj.diremp = TxtDireccion.Text;
                Eobj.estado = CmbEstado.Text;
                Nobj.MtdAgregarEmpleados(Eobj);
                DgvEmpleados.DataSource = Nobj.MtdListarEmpleados();
            }
            else
            {
                MessageBox.Show("Por favor llene todos los campos", "Mensaje");
            }
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            if (TxtCodigo.Text != "" && TxtNombre.Text != "" && TxtApellido.Text != "" && TxtClave.Text != "" && TxtDireccion.Text != "" && CmbEstado.Text != "")
            {
                ClsEEmpleados Eobj = new ClsEEmpleados();
                ClsNEmpleados Nobj = new ClsNEmpleados();
                Eobj.codemp = TxtCodigo.Text;
                Eobj.nomemp = TxtNombre.Text;
                Eobj.apeemp = TxtApellido.Text;
                Eobj.claemp = TxtClave.Text;
                Eobj.diremp = TxtDireccion.Text;
                Eobj.estado = CmbEstado.Text;
                Nobj.MtdActualizarEmpleados(Eobj);
                DgvEmpleados.DataSource = Nobj.MtdListarEmpleados();

                CmbEstado.Enabled = false;
                TxtCodigo.Enabled = true;
                TxtCodigo.Clear();
                TxtNombre.Clear();
                TxtApellido.Clear();
                TxtClave.Clear();
                TxtDireccion.Clear();
                CmbEstado.Text = "Activo";
            }
            else
            {
                MessageBox.Show("Por favor llene todos los campos", "Mensaje");
            }

        }

        private void DgvEmpleados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            TxtCodigo.Enabled = false;
            CmbEstado.Enabled = true;
            var row = (sender as DataGridView).CurrentRow;
            TxtCodigo.Text = row.Cells[0].Value.ToString();
            TxtNombre.Text = row.Cells[1].Value.ToString();
            TxtApellido.Text = row.Cells[2].Value.ToString();
            TxtClave.Text = row.Cells[3].Value.ToString();
            TxtDireccion.Text = row.Cells[4].Value.ToString();
            CmbEstado.Text = row.Cells[5].Value.ToString();
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            CmbEstado.Enabled = false;
            TxtCodigo.Enabled = true;
            TxtCodigo.Clear();
            TxtNombre.Clear();
            TxtApellido.Clear();
            TxtClave.Clear();
            TxtDireccion.Clear();
            CmbEstado.Text = "Activo";
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
                e.Handled = true;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (e.KeyChar == Convert.ToChar("'"))
            {
                TxtNombre.Enabled = true;
            }
            else if (e.KeyChar == Convert.ToChar("@"))
            {
                TxtNombre.Enabled = true;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void TxtApellido_KeyPress(object sender, KeyPressEventArgs e)
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
                e.Handled = true;
            }
            else if (e.KeyChar == Convert.ToChar("'"))
            {
                TxtNombre.Enabled = true;
            }
            else if (e.KeyChar == Convert.ToChar("@"))
            {
                TxtNombre.Enabled = true;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void TxtClave_KeyPress(object sender, KeyPressEventArgs e)
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

        private void TxtDireccion_KeyPress(object sender, KeyPressEventArgs e)
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
