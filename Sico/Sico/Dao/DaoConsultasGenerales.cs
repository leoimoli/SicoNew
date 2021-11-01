using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sico.Dao
{
    public class DaoConsultasGenerales
    {
        private static MySql.Data.MySqlClient.MySqlConnection connection = new MySqlConnection(Properties.Settings.Default.db);
        public static int ContadorClientes()
        {
            connection.Close();
            connection.Open();
            int total = 0;
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = connection;
            DataTable Tabla = new DataTable();
            MySqlParameter[] oParam = { };
            string proceso = "ContadorClientes";
            MySqlDataAdapter dt = new MySqlDataAdapter(proceso, connection);
            dt.SelectCommand.CommandType = CommandType.StoredProcedure;
            dt.SelectCommand.Parameters.AddRange(oParam);
            dt.Fill(Tabla);
            if (Tabla.Rows.Count > 0)
            {
                foreach (DataRow item in Tabla.Rows)
                {
                    total = Convert.ToInt32(item["Total"].ToString());
                }
            }
            connection.Close();
            return total;
        }
        public static int ContadorTareas()
        {
            connection.Close();
            connection.Open();
            int total = 0;
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = connection;
            DataTable Tabla = new DataTable();
            MySqlParameter[] oParam = { };
            string proceso = "ContadorTareas";
            MySqlDataAdapter dt = new MySqlDataAdapter(proceso, connection);
            dt.SelectCommand.CommandType = CommandType.StoredProcedure;
            dt.SelectCommand.Parameters.AddRange(oParam);
            dt.Fill(Tabla);
            if (Tabla.Rows.Count > 0)
            {
                foreach (DataRow item in Tabla.Rows)
                {
                    total = Convert.ToInt32(item["Total"].ToString());
                }
            }
            connection.Close();
            return total;
        }
        public static int ContadorPendientes()
        {
            connection.Close();
            connection.Open();
            int total = 0;
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = connection;
            DataTable Tabla = new DataTable();
            MySqlParameter[] oParam = { new MySqlParameter("idUsuario_in", Sesion.UsuarioLogueado.IdUsuario) };
            string proceso = "ContadorPendientes";
            MySqlDataAdapter dt = new MySqlDataAdapter(proceso, connection);
            dt.SelectCommand.CommandType = CommandType.StoredProcedure;
            dt.SelectCommand.Parameters.AddRange(oParam);
            dt.Fill(Tabla);
            if (Tabla.Rows.Count > 0)
            {
                foreach (DataRow item in Tabla.Rows)
                {
                    total = Convert.ToInt32(item["Total"].ToString());
                }
            }
            connection.Close();
            return total;
        }
        public static int ContadorUsuarios()
        {
            connection.Close();
            connection.Open();
            int total = 0;
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = connection;
            DataTable Tabla = new DataTable();
            MySqlParameter[] oParam = { };
            string proceso = "ContadorUsuarios";
            MySqlDataAdapter dt = new MySqlDataAdapter(proceso, connection);
            dt.SelectCommand.CommandType = CommandType.StoredProcedure;
            dt.SelectCommand.Parameters.AddRange(oParam);
            dt.Fill(Tabla);
            if (Tabla.Rows.Count > 0)
            {
                foreach (DataRow item in Tabla.Rows)
                {
                    total = Convert.ToInt32(item["Total"].ToString());
                }
            }
            connection.Close();
            return total;
        }
    }
}
