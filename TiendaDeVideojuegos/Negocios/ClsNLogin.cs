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
    class ClsNLogin
    {
        public DataTable MtdLogin()
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
    }
}
