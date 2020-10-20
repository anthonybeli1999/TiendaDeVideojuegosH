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
    class ClsNGenero
    {
        public DataTable MtdListarGenero()
        {
            ClsConexion conn = new ClsConexion();
            DataTable result = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand();
            command.Connection = conn.conectar();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "usp_V_ListarGenero";
            command.ExecuteNonQuery();
            adapter.SelectCommand = command;
            adapter.Fill(result);
            return result;
        }

        public DataTable MtdListarCodigoGenero()
        {
            ClsConexion conn = new ClsConexion();
            DataTable result = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand();
            command.Connection = conn.conectar();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "usp_V_ListarCodigoGenero";
            command.ExecuteNonQuery();
            adapter.SelectCommand = command;
            adapter.Fill(result);
            return result;
        }

        public Boolean MtdAgregarGenero(ClsEGenero objCar)
        {
            try
            {
                ClsConexion Objconexion = new ClsConexion();
                MySqlCommand Objcomando = new MySqlCommand();
                Objcomando.Connection = Objconexion.conectar();
                Objcomando.CommandText = "usp_A_IngresarGenero";
                Objcomando.CommandType = CommandType.StoredProcedure;
                Objcomando.Parameters.Add(new MySqlParameter("Acod", MySqlDbType.VarChar));
                Objcomando.Parameters.Add(new MySqlParameter("Anom", MySqlDbType.VarChar));
                Objcomando.Parameters["Acod"].Value = objCar.codgen;
                Objcomando.Parameters["Anom"].Value = objCar.nomgen;
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

        public Boolean MtdActualizarGenero(ClsEGenero objCar)
        {
            try
            {
                ClsConexion Objconexion = new ClsConexion();
                MySqlCommand ObjCommand = new MySqlCommand();
                ObjCommand.Connection = Objconexion.conectar();
                ObjCommand.CommandText = "usp_E_ModificarGenero";
                ObjCommand.CommandType = CommandType.StoredProcedure;
                ObjCommand.Parameters.Add(new MySqlParameter("Acod", MySqlDbType.VarChar));
                ObjCommand.Parameters.Add(new MySqlParameter("Anom", MySqlDbType.VarChar));
                ObjCommand.Parameters["Acod"].Value = objCar.codgen;
                ObjCommand.Parameters["Anom"].Value = objCar.nomgen;
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

        public DataTable MtdBuscarGenero(string codigobuscar)
        {
            ClsConexion conn = new ClsConexion();
            DataTable result = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand Objcomando = new MySqlCommand();
            Objcomando.Connection = conn.conectar();
            Objcomando.Parameters.Add(new MySqlParameter("Ayucod", MySqlDbType.VarChar));
            Objcomando.Parameters["Ayucod"].Value = codigobuscar;
            Objcomando.CommandType = CommandType.StoredProcedure;
            Objcomando.CommandText = "usp_S_BuscarNombreGenero";
            Objcomando.ExecuteNonQuery();
            adapter.SelectCommand = Objcomando;
            adapter.Fill(result);
            return result;
        }
    }
}
