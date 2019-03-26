using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sico.Dao
{
    public class ComprasDao
    {
        private static MySql.Data.MySqlClient.MySqlConnection connection = new MySqlConnection(Properties.Settings.Default.db);
        public static List<string> CargarComboTipoComprobante()
        {
            connection.Close();
            connection.Open();
            List<string> _listaProvincia = new List<string>();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = connection;
            DataTable Tabla = new DataTable();
            MySqlParameter[] oParam = { };
            string proceso = "ListarTipoComprobantes";
            MySqlDataAdapter dt = new MySqlDataAdapter(proceso, connection);
            dt.SelectCommand.CommandType = CommandType.StoredProcedure;
            dt.SelectCommand.Parameters.AddRange(oParam);
            dt.Fill(Tabla);
            if (Tabla.Rows.Count > 0)
            {
                foreach (DataRow item in Tabla.Rows)
                {
                    _listaProvincia.Add(item["Codigo"].ToString() + " "+ "-" + " "+ item["Descripcion"].ToString());
                }
            }
            connection.Close();
            return _listaProvincia;
        }
        public static List<string> CargarComboTipoMoneda()
        {
            connection.Close();
            connection.Open();
            List<string> _TipoMoneda = new List<string>();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = connection;
            DataTable Tabla = new DataTable();
            MySqlParameter[] oParam = { };
            string proceso = "ListarTipoMoneda";
            MySqlDataAdapter dt = new MySqlDataAdapter(proceso, connection);
            dt.SelectCommand.CommandType = CommandType.StoredProcedure;
            dt.SelectCommand.Parameters.AddRange(oParam);
            dt.Fill(Tabla);
            if (Tabla.Rows.Count > 0)
            {
                foreach (DataRow item in Tabla.Rows)
                {
                    _TipoMoneda.Add(item["CodigoSiap"].ToString() + " " + "-" + " " + item["Descripcion"].ToString());
                }
            }
            connection.Close();
            return _TipoMoneda;
        }
        public static List<string> CargarComboCodigoOperacion()
        {
            connection.Close();
            connection.Open();
            List<string> _CodigoOperacion = new List<string>();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = connection;
            DataTable Tabla = new DataTable();
            MySqlParameter[] oParam = { };
            string proceso = "ListarCodigoOperacion";
            MySqlDataAdapter dt = new MySqlDataAdapter(proceso, connection);
            dt.SelectCommand.CommandType = CommandType.StoredProcedure;
            dt.SelectCommand.Parameters.AddRange(oParam);
            dt.Fill(Tabla);
            if (Tabla.Rows.Count > 0)
            {
                foreach (DataRow item in Tabla.Rows)
                {
                    _CodigoOperacion.Add(item["Codigo"].ToString() + " " + "-" + " " + item["Descripcion"].ToString());
                }
            }
            connection.Close();
            return _CodigoOperacion;
        }
    }
}
