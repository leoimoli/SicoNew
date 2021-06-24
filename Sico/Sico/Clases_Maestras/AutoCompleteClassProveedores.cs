using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sico.Clases_Maestras
{
   public class AutoCompleteClassProveedores
    {
        public static DataTable Datos(int idEmpresa)
        {
            DataTable dt = new DataTable();
            MySqlConnection conexion = new MySqlConnection(Properties.Settings.Default.db);
            conexion.Open();
            string consulta = "Select NombreRazonSocial from tproveedores where idCliente = '" + idEmpresa + "'";
            MySqlCommand cmd = new MySqlCommand(consulta, conexion);
            MySqlDataAdapter adap = new MySqlDataAdapter(cmd);
            adap.Fill(dt);
            conexion.Close();
            return dt;
        }

        public static AutoCompleteStringCollection Autocomplete(int idEmpresa)
        {
            DataTable DT = Datos(idEmpresa);
            AutoCompleteStringCollection coleccion = new AutoCompleteStringCollection();
            foreach (DataRow row in DT.Rows)
            {
                coleccion.Add(Convert.ToString(row["NombreRazonSocial"]));
            }
            return coleccion;
        }
    }
}
