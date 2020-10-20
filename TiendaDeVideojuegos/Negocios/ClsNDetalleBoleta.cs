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
    class ClsNDetalleBoleta
    {
        public Boolean MtdAgregarDetalleBoleta(ClsEDetalleBoleta objCar)
        {
            try
            {
                ClsConexion Objconexion = new ClsConexion();
                MySqlCommand Objcomando = new MySqlCommand();
                Objcomando.Connection = Objconexion.conectar();
                Objcomando.CommandText = "usp_A_IngresarDetalleBoleta";
                Objcomando.CommandType = CommandType.StoredProcedure;
                Objcomando.Parameters.Add(new MySqlParameter("Aserie", MySqlDbType.VarChar));
                Objcomando.Parameters.Add(new MySqlParameter("Anum", MySqlDbType.VarChar));
                Objcomando.Parameters.Add(new MySqlParameter("Acodprod", MySqlDbType.VarChar));
                Objcomando.Parameters.Add(new MySqlParameter("Anomprod", MySqlDbType.VarChar));
                Objcomando.Parameters.Add(new MySqlParameter("Acant", MySqlDbType.Int32));
                Objcomando.Parameters.Add(new MySqlParameter("Asub", MySqlDbType.Double));
                Objcomando.Parameters["Aserie"].Value = objCar.serie;
                Objcomando.Parameters["Anum"].Value = objCar.numero;
                Objcomando.Parameters["Acodprod"].Value = objCar.codigoproducto;
                Objcomando.Parameters["Anomprod"].Value = objCar.nombreproducto;
                Objcomando.Parameters["Acant"].Value = objCar.cantidad;
                Objcomando.Parameters["Asub"].Value = objCar.subtotal;
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

        public DataTable MtdListarDetalleBoleta()
        {
            ClsConexion conn = new ClsConexion();
            DataTable result = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand();
            command.Connection = conn.conectar();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "usp_V_ListarDetalleBoleta";
            command.ExecuteNonQuery();
            adapter.SelectCommand = command;
            adapter.Fill(result);
            return result;
        }

        public Boolean MtdActualizarDetalleBoleta(ClsEDetalleBoleta objCar)
        {
            try
            {
                ClsConexion Objconexion = new ClsConexion();
                MySqlCommand Objcomando = new MySqlCommand();
                Objcomando.Connection = Objconexion.conectar();
                Objcomando.CommandText = "usp_E_ModificarDetalleBoleta";
                Objcomando.CommandType = CommandType.StoredProcedure;
                Objcomando.Parameters.Add(new MySqlParameter("Acod", MySqlDbType.VarChar));
                Objcomando.Parameters.Add(new MySqlParameter("Acant", MySqlDbType.Int32));
                Objcomando.Parameters.Add(new MySqlParameter("Asub", MySqlDbType.Double));
                Objcomando.Parameters["Acod"].Value = objCar.codigoproducto;
                Objcomando.Parameters["Acant"].Value = objCar.cantidad;
                Objcomando.Parameters["Asub"].Value = objCar.subtotal;
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

        public Boolean MtdEliminarDetalleBoleta(ClsEDetalleBoleta objCar)
        {
            try
            {
                ClsConexion Objconexion = new ClsConexion();
                MySqlCommand Objcomando = new MySqlCommand();
                Objcomando.Connection = Objconexion.conectar();
                Objcomando.CommandText = "usp_D_EliminarDetalleBoleta";
                Objcomando.CommandType = CommandType.StoredProcedure;
                Objcomando.Parameters.Add(new MySqlParameter("Aserie", MySqlDbType.VarChar));
                Objcomando.Parameters.Add(new MySqlParameter("Anum", MySqlDbType.VarChar));
                Objcomando.Parameters.Add(new MySqlParameter("Acod", MySqlDbType.VarChar));
                Objcomando.Parameters["Aserie"].Value = objCar.serie;
                Objcomando.Parameters["Anum"].Value = objCar.numero;
                Objcomando.Parameters["Acod"].Value = objCar.codigoproducto;
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

        public DataTable MtdBuscarDetalleBoleta(ClsEDetalleBoleta objCar)
        {
            ClsConexion conn = new ClsConexion();
            DataTable result = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand Objcomando = new MySqlCommand();
            Objcomando.Connection = conn.conectar();
            Objcomando.Parameters.Add(new MySqlParameter("Aserie", MySqlDbType.VarChar));
            Objcomando.Parameters.Add(new MySqlParameter("Anum", MySqlDbType.VarChar));
            Objcomando.Parameters["Aserie"].Value = objCar.serie;
            Objcomando.Parameters["Anum"].Value = objCar.numero;
            Objcomando.CommandType = CommandType.StoredProcedure;
            Objcomando.CommandText = "usp_S_BuscarDetalleBoleta";
            Objcomando.ExecuteNonQuery();
            adapter.SelectCommand = Objcomando;
            adapter.Fill(result);
            return result;
        }
    }
}
