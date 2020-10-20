using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using TiendaDeVideojuegos.Entidad;
using TiendaDeVideojuegos.Presentacion;

namespace TiendaDeVideojuegos.Negocios
{
    class ClsNProductos
    {
        public DataTable MtdListarProductos()
        {
            ClsConexion conn = new ClsConexion();
            DataTable result = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand();
            command.Connection = conn.conectar();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "usp_V_ListarProductos";
            command.ExecuteNonQuery();
            adapter.SelectCommand = command;
            adapter.Fill(result);
            return result;
        }

        public Boolean MtdAgregarProductos(ClsEProductos objCar)
        {
            try
            {
                ClsConexion Objconexion = new ClsConexion();
                MySqlCommand Objcomando = new MySqlCommand();
                Objcomando.Connection = Objconexion.conectar();
                Objcomando.CommandText = "usp_A_IngresarProducto";
                Objcomando.CommandType = CommandType.StoredProcedure;
                Objcomando.Parameters.Add(new MySqlParameter("Acod", MySqlDbType.VarChar));
                Objcomando.Parameters.Add(new MySqlParameter("Anom", MySqlDbType.VarChar));
                Objcomando.Parameters.Add(new MySqlParameter("Acant", MySqlDbType.Int32));
                Objcomando.Parameters.Add(new MySqlParameter("Apre", MySqlDbType.Double));
                Objcomando.Parameters.Add(new MySqlParameter("Acodplat", MySqlDbType.VarChar));
                Objcomando.Parameters.Add(new MySqlParameter("Acodgen", MySqlDbType.VarChar));
                Objcomando.Parameters["Acod"].Value = objCar.codprod;
                Objcomando.Parameters["Anom"].Value = objCar.nomprod;
                Objcomando.Parameters["Acant"].Value = objCar.cantprod;
                Objcomando.Parameters["Apre"].Value = objCar.preprod;
                Objcomando.Parameters["Acodplat"].Value = objCar.codplat;
                Objcomando.Parameters["Acodgen"].Value = objCar.codgen;
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

        public Boolean MtdActualizarStockProductos(ClsEProductos objCar)
        {
            try
            {
                ClsConexion Objconexion = new ClsConexion();
                MySqlCommand ObjCommand = new MySqlCommand();
                ObjCommand.Connection = Objconexion.conectar();
                ObjCommand.CommandText = "usp_E_ModificarStock";
                ObjCommand.CommandType = CommandType.StoredProcedure;
                ObjCommand.Parameters.Add(new MySqlParameter("Acod", MySqlDbType.VarChar));
                ObjCommand.Parameters.Add(new MySqlParameter("Acant", MySqlDbType.Int32));
                ObjCommand.Parameters["Acod"].Value = objCar.codprod;
                ObjCommand.Parameters["Acant"].Value = objCar.cantprod;
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

        public Boolean MtdActualizarProductos(ClsEProductos objCar)
        {
            try
            {
                ClsConexion Objconexion = new ClsConexion();
                MySqlCommand ObjCommand = new MySqlCommand();
                ObjCommand.Connection = Objconexion.conectar();
                ObjCommand.CommandText = "usp_E_ModificarProducto";
                ObjCommand.CommandType = CommandType.StoredProcedure;
                ObjCommand.Parameters.Add(new MySqlParameter("Acod", MySqlDbType.VarChar));
                ObjCommand.Parameters.Add(new MySqlParameter("Anom", MySqlDbType.VarChar));
                ObjCommand.Parameters.Add(new MySqlParameter("Acant", MySqlDbType.Int32));
                ObjCommand.Parameters.Add(new MySqlParameter("Apre", MySqlDbType.Double));
                ObjCommand.Parameters.Add(new MySqlParameter("Acodplat", MySqlDbType.VarChar));
                ObjCommand.Parameters.Add(new MySqlParameter("Acodgen", MySqlDbType.VarChar));
                ObjCommand.Parameters["Acod"].Value = objCar.codprod;
                ObjCommand.Parameters["Anom"].Value = objCar.nomprod;
                ObjCommand.Parameters["Acant"].Value = objCar.cantprod;
                ObjCommand.Parameters["Apre"].Value = objCar.preprod;
                ObjCommand.Parameters["Acodplat"].Value = objCar.codplat;
                ObjCommand.Parameters["Acodgen"].Value = objCar.codgen;
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

        public Boolean MtdCompraProductos(ClsEProductos objCar)
        {
            try
            {
                ClsConexion Objconexion = new ClsConexion();
                MySqlCommand ObjCommand = new MySqlCommand();
                ObjCommand.Connection = Objconexion.conectar();
                ObjCommand.CommandText = "usp_U_CompraProducto";
                ObjCommand.CommandType = CommandType.StoredProcedure;
                ObjCommand.Parameters.Add(new MySqlParameter("Acod", MySqlDbType.VarChar));
                ObjCommand.Parameters.Add(new MySqlParameter("Acant", MySqlDbType.Int32));
                ObjCommand.Parameters["Acod"].Value = objCar.codprod;
                ObjCommand.Parameters["Acant"].Value = objCar.cantprod;
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

        public Boolean MtdDevolverProductos(ClsEProductos objCar)
        {
            try
            {
                ClsConexion Objconexion = new ClsConexion();
                MySqlCommand ObjCommand = new MySqlCommand();
                ObjCommand.Connection = Objconexion.conectar();
                ObjCommand.CommandText = "usp_U_DevolverProducto";
                ObjCommand.CommandType = CommandType.StoredProcedure;
                ObjCommand.Parameters.Add(new MySqlParameter("Acod", MySqlDbType.VarChar));
                ObjCommand.Parameters.Add(new MySqlParameter("Acant", MySqlDbType.Int32));
                ObjCommand.Parameters["Acod"].Value = objCar.codprod;
                ObjCommand.Parameters["Acant"].Value = objCar.cantprod;
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

        public DataTable MtdBuscarProducto(ClsEProductos objCar)
        {
            ClsConexion conn = new ClsConexion();
            DataTable result = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand Objcomando = new MySqlCommand();
            Objcomando.Connection = conn.conectar();
            Objcomando.Parameters.Add(new MySqlParameter("Ayucod", MySqlDbType.VarChar));
            Objcomando.Parameters["Ayucod"].Value = objCar.codprod;
            Objcomando.CommandType = CommandType.StoredProcedure;
            Objcomando.CommandText = "usp_S_BuscarProducto";
            Objcomando.ExecuteNonQuery();
            adapter.SelectCommand = Objcomando;
            adapter.Fill(result);
            return result;
        }
    }
}
