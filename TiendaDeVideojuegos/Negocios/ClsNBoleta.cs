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
    class ClsNBoleta
    {
        public Boolean MtdAgregarBoleta(ClsEBoleta objCar)
        {
            try
            {
                ClsConexion Objconexion = new ClsConexion();
                MySqlCommand Objcomando = new MySqlCommand();
                Objcomando.Connection = Objconexion.conectar();
                Objcomando.CommandText = "usp_A_IngresarBoleta";
                Objcomando.CommandType = CommandType.StoredProcedure;
                Objcomando.Parameters.Add(new MySqlParameter("Aserie", MySqlDbType.VarChar));
                Objcomando.Parameters.Add(new MySqlParameter("Anum", MySqlDbType.VarChar));
                Objcomando.Parameters.Add(new MySqlParameter("Aruc", MySqlDbType.VarChar));
                Objcomando.Parameters.Add(new MySqlParameter("Acodemp", MySqlDbType.VarChar));
                Objcomando.Parameters.Add(new MySqlParameter("Acli", MySqlDbType.VarChar));
                Objcomando.Parameters.Add(new MySqlParameter("Afecha", MySqlDbType.VarChar));
                Objcomando.Parameters.Add(new MySqlParameter("Asub", MySqlDbType.Double));
                Objcomando.Parameters.Add(new MySqlParameter("Aigv", MySqlDbType.Double));
                Objcomando.Parameters.Add(new MySqlParameter("Atotal", MySqlDbType.Double));
                Objcomando.Parameters["Aserie"].Value = objCar.serie;
                Objcomando.Parameters["Anum"].Value = objCar.numero;
                Objcomando.Parameters["Aruc"].Value = objCar.rucprov;
                Objcomando.Parameters["Acodemp"].Value = objCar.codemp;
                Objcomando.Parameters["Acli"].Value = objCar.cliente;
                Objcomando.Parameters["Afecha"].Value = objCar.fecha;
                Objcomando.Parameters["Asub"].Value = objCar.subtotal;
                Objcomando.Parameters["Aigv"].Value = objCar.igv;
                Objcomando.Parameters["Atotal"].Value = objCar.total;
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

        public DataTable MtdListarBoleta()
        {
            ClsConexion conn = new ClsConexion();
            DataTable result = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand();
            command.Connection = conn.conectar();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "usp_V_ListarBoleta";
            command.ExecuteNonQuery();
            adapter.SelectCommand = command;
            adapter.Fill(result);
            return result;
        }

        public Boolean MtdActualizarBoleta(ClsEBoleta objCar)
        {
            try
            {
                ClsConexion Objconexion = new ClsConexion();
                MySqlCommand ObjCommand = new MySqlCommand();
                ObjCommand.Connection = Objconexion.conectar();
                ObjCommand.CommandText = "usp_E_ModificarBoleta";
                ObjCommand.CommandType = CommandType.StoredProcedure;
                ObjCommand.Parameters.Add(new MySqlParameter("Aserie", MySqlDbType.VarChar));
                ObjCommand.Parameters.Add(new MySqlParameter("Anum", MySqlDbType.VarChar));
                ObjCommand.Parameters.Add(new MySqlParameter("Asub", MySqlDbType.Double));
                ObjCommand.Parameters.Add(new MySqlParameter("Aigv", MySqlDbType.Double));
                ObjCommand.Parameters.Add(new MySqlParameter("Atotal", MySqlDbType.Double));
                ObjCommand.Parameters["Aserie"].Value = objCar.serie;
                ObjCommand.Parameters["Anum"].Value = objCar.numero;
                ObjCommand.Parameters["Asub"].Value = objCar.total;
                ObjCommand.Parameters["Aigv"].Value = objCar.total;
                ObjCommand.Parameters["Atotal"].Value = objCar.total;
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
    }
}
