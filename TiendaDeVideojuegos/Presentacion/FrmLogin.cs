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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }
        public static string CodigoEmpleado = "";
        public static string NombreEmpleado = "";

        OpenFileDialog buscarHuella1 = new OpenFileDialog();
        OpenFileDialog buscarHuella2 = new OpenFileDialog();

        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            //if(TxtCodigo.Text !="" && TxtClave.Text != "")
            //{
            //    ClsELogin Eobj = new ClsELogin();
            //    ClsNLogin Nobj = new ClsNLogin();
            //    Eobj.codigo = TxtCodigo.Text;
            //    Eobj.clave = TxtClave.Text;
            //    Nobj.MtdLogin();
            //    int ayu = 0;
            //    int i = 0;

            //    foreach (DataRow row in Nobj.MtdLogin().Rows)
            //    {
            //        if(Eobj.codigo == (row[i]).ToString() && Eobj.clave == row[i + 3].ToString())
            //        {
            //            ayu = 1;
            //            if (row[5].ToString() == "Activo")
            //            {
            //                MessageBox.Show("Logueado con exito", "Mensaje");
            //                FrmMenuPrincipal frm = new FrmMenuPrincipal();
            //                frm.Show();
            //                this.Hide();
            //                CodigoEmpleado = row[0].ToString();
            //                NombreEmpleado = row[1] + " " + row[2];
            //            }
            //            else
            //            {
            //                MessageBox.Show("El empleado no se encuentra activo", "Mensaje");
            //            }

            //        }
            //    }
            //    if (ayu == 0)
            //    {
            //        MessageBox.Show("Datos Erroneos", "Mensaje");
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("Por favor llene los campos", "Mensaje");
            //}

            if(TxtCodigo.Text !="" && TxtClave.Text != "")
            {
                bool result = AbuEhabHelper.ImagesArea.CompareIamges(imgHuella1, imgHuella2);
                
                if (TxtCodigo.Text == "20170578" && TxtClave.Text == "1234")
                {
                    if (result == true)
                    {
                        MessageBox.Show("Huella validada correctamente", "Mensaje");
                        FrmMenuPrincipal frm = new FrmMenuPrincipal();
                        frm.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("La huella no es correcta", "Mensaje");
                    }

                }
                else
                {
                    MessageBox.Show("Datos Erroneos", "Mensaje");
                }

            }
            else
            {
                MessageBox.Show("Llene los campos", "Mensaje");
            }
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

        private void imgHuella1_DoubleClick(object sender, EventArgs e)
        {
            buscarHuella1.ShowDialog();
            imgHuella1.Image = Image.FromFile(buscarHuella1.FileName);
        }

        private void imgHuella2_DoubleClick(object sender, EventArgs e)
        {
            buscarHuella2.ShowDialog();
            imgHuella2.Image = Image.FromFile(buscarHuella2.FileName);
        }
    }
}
