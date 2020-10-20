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
    class ClsNEmpleados
    {
        public DataTable MtdListarEmpleados()
        {
            ClsConexion conn = new ClsConexion();
            DataTable result = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand();
            command.Connection = conn.conectar();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "usp_V_ListarEmpleados";
            command.ExecuteNonQuery();
            adapter.SelectCommand = command;
            adapter.Fill(result);
            return result;
        }

        public Boolean MtdAgregarEmpleados(ClsEEmpleados objCar)
        {
            try
            {
                ClsConexion Objconexion = new ClsConexion();
                MySqlCommand Objcomando = new MySqlCommand();
                Objcomando.Connection = Objconexion.conectar();
                Objcomando.CommandText = "usp_A_IngresarEmpleado";
                Objcomando.CommandType = CommandType.StoredProcedure;
                Objcomando.Parameters.Add(new MySqlParameter("Acod", MySqlDbType.VarChar));
                Objcomando.Parameters.Add(new MySqlParameter("Anom", MySqlDbType.VarChar));
                Objcomando.Parameters.Add(new MySqlParameter("Aape", MySqlDbType.VarChar));
                Objcomando.Parameters.Add(new MySqlParameter("Acla", MySqlDbType.VarChar));
                Objcomando.Parameters.Add(new MySqlParameter("Adir", MySqlDbType.VarChar));
                Objcomando.Parameters.Add(new MySqlParameter("Aest", MySqlDbType.VarChar));
                Objcomando.Parameters["Acod"].Value = objCar.codemp;
                Objcomando.Parameters["Anom"].Value = objCar.nomemp;
                Objcomando.Parameters["Aape"].Value = objCar.apeemp;
                Objcomando.Parameters["Acla"].Value = objCar.claemp;
                Objcomando.Parameters["Adir"].Value = objCar.diremp;
                Objcomando.Parameters["Aest"].Value = objCar.estado;
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

        public Boolean MtdActualizarEmpleados(ClsEEmpleados objCar)
        {
            try
            {
                ClsConexion Objconexion = new ClsConexion();
                MySqlCommand ObjCommand = new MySqlCommand();
                ObjCommand.Connection = Objconexion.conectar();
                ObjCommand.CommandText = "usp_E_ModificarEmpleados";
                ObjCommand.CommandType = CommandType.StoredProcedure;
                ObjCommand.Parameters.Add(new MySqlParameter("Acod", MySqlDbType.VarChar));
                ObjCommand.Parameters.Add(new MySqlParameter("Anom", MySqlDbType.VarChar));
                ObjCommand.Parameters.Add(new MySqlParameter("Aape", MySqlDbType.VarChar));
                ObjCommand.Parameters.Add(new MySqlParameter("Acla", MySqlDbType.VarChar));
                ObjCommand.Parameters.Add(new MySqlParameter("Adir", MySqlDbType.VarChar));
                ObjCommand.Parameters.Add(new MySqlParameter("Aest", MySqlDbType.VarChar));
                ObjCommand.Parameters["Acod"].Value = objCar.codemp;
                ObjCommand.Parameters["Anom"].Value = objCar.nomemp;
                ObjCommand.Parameters["Aape"].Value = objCar.apeemp;
                ObjCommand.Parameters["Acla"].Value = objCar.claemp;
                ObjCommand.Parameters["Adir"].Value = objCar.diremp;
                ObjCommand.Parameters["Aest"].Value = objCar.estado;
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
