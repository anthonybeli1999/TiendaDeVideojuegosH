using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;


namespace TiendaDeVideojuegos.Negocios
{
    class ClsConexion
    {
        private MySqlConnection conn = null;

        static String user = "root";
        static String password = "";
        static String servidor = "localhost"; //127.0.0.1
        static String basedatos = "bd_tiendavideojuegos";

        public MySqlConnection conectar()
        {
            try
            {
                conn = new MySqlConnection();
                conn.ConnectionString = "server= " + servidor + "; database= " + basedatos + "; uid= " + user + "; pwd= " + password + ";";
                conn.Open();
            }
            catch (MySqlException ex)
            {
                throw ex;
            }
            return conn;
        }

        public MySqlConnection cerrar()
        {
            try
            {
                conn = new MySqlConnection();
                conn.Close();
            }
            catch (MySqlException ex)
            {
                throw ex;
            }
            return conn;
        }
    }
}
