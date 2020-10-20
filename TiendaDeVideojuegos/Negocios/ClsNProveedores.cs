using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using TiendaDeVideojuegos.Entidad;

namespace TiendaDeVideojuegos.Negocios
{
    class ClsNProveedores
    {
        public DataTable MtdListarProveedor()
        {
            ClsConexion conn = new ClsConexion();
            DataTable result = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand();
            command.Connection = conn.conectar();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "usp_V_ListarProveedor";
            command.ExecuteNonQuery();
            adapter.SelectCommand = command;
            adapter.Fill(result);
            return result;
        }

        public DataTable MtdListarRUCProveedor()
        {
            ClsConexion conn = new ClsConexion();
            DataTable result = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand();
            command.Connection = conn.conectar();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "usp_V_ListarCodigoProveedor";
            command.ExecuteNonQuery();
            adapter.SelectCommand = command;
            adapter.Fill(result);
            return result;
        }

        public Boolean MtdAgregarProveedor(ClsEProveedores objCar)
        {
            try
            {
                ClsConexion Objconexion = new ClsConexion();
                MySqlCommand Objcomando = new MySqlCommand();
                Objcomando.Connection = Objconexion.conectar();
                Objcomando.CommandText = "usp_A_IngresarProveedor";
                Objcomando.CommandType = CommandType.StoredProcedure;
                Objcomando.Parameters.Add(new MySqlParameter("Acod", MySqlDbType.VarChar));
                Objcomando.Parameters.Add(new MySqlParameter("Anom", MySqlDbType.VarChar));
                Objcomando.Parameters["Acod"].Value = objCar.rucprov;
                Objcomando.Parameters["Anom"].Value = objCar.nomprov;
                Objcomando.Connection = Objconexion.conectar();
                Objcomando.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                return false;
                throw ex;
            }
        }

        public Boolean MtdActualizarProveedor(ClsEProveedores objCar)
        {
            try
            {
                ClsConexion Objconexion = new ClsConexion();
                MySqlCommand ObjCommand = new MySqlCommand();
                ObjCommand.Connection = Objconexion.conectar();
                ObjCommand.CommandText = "usp_E_ModificarProveedor";
                ObjCommand.CommandType = CommandType.StoredProcedure;
                ObjCommand.Parameters.Add(new MySqlParameter("Acod", MySqlDbType.VarChar));
                ObjCommand.Parameters.Add(new MySqlParameter("Anom", MySqlDbType.VarChar));
                ObjCommand.Parameters["Acod"].Value = objCar.rucprov;
                ObjCommand.Parameters["Anom"].Value = objCar.nomprov;
                ObjCommand.Connection = Objconexion.conectar();
                ObjCommand.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                return false;
                throw ex;
            }
        }

        public DataTable MtdBuscarProveedor(string codigobuscar)
        {
            ClsConexion conn = new ClsConexion();
            DataTable result = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand Objcomando = new MySqlCommand();
            Objcomando.Connection = conn.conectar();
            Objcomando.Parameters.Add(new MySqlParameter("Ayucod", MySqlDbType.VarChar));
            Objcomando.Parameters["Ayucod"].Value = codigobuscar;
            Objcomando.CommandType = CommandType.StoredProcedure;
            Objcomando.CommandText = "usp_S_BuscarNombreProveedor";
            Objcomando.ExecuteNonQuery();
            adapter.SelectCommand = Objcomando;
            adapter.Fill(result);
            return result;
        }
    }
}
