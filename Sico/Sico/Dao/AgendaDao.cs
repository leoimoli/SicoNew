using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sico.Entidades;
using Sico.Clases_Maestras;
using System.Windows.Forms;

namespace Sico.Dao
{
    public class AgendaDao
    {
        private static MySql.Data.MySqlClient.MySqlConnection connection = new MySqlConnection(Properties.Settings.Default.db);
        public static bool GuardarRecordatorio(Agenda agenda)
        {
            bool exito = false;
            connection.Close();
            connection.Open();
            string proceso = "AltaRecordatorio";
            MySqlCommand cmd = new MySqlCommand(proceso, connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("idUsuario_in", agenda.idUsuario);
            cmd.Parameters.AddWithValue("UsuariosSistema_in", agenda.UsuariosSistema);
            cmd.Parameters.AddWithValue("Fecha_in", agenda.Fecha);
            cmd.Parameters.AddWithValue("Descripcion_in", agenda.Descripcion);
            cmd.Parameters.AddWithValue("Email_in", agenda.Email);
            cmd.Parameters.AddWithValue("FechaDelRegistro_in", agenda.FechaDelRegistro);
            cmd.Parameters.AddWithValue("Estado_in", agenda.Estado);
            cmd.ExecuteNonQuery();
            exito = true;
            connection.Close();
            return exito;
        }
        public static bool EditarRecordatorio(Agenda agenda, int idAgendaSeleccionada)
        {
            bool exito = false;
            connection.Close();
            connection.Open();
            string Actualizar = "EditarRecordatorio";
            MySqlCommand cmd = new MySqlCommand(Actualizar, connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("idAgendaSeleccionada_in", idAgendaSeleccionada);
            cmd.Parameters.AddWithValue("Fecha_in", agenda.Fecha);
            cmd.Parameters.AddWithValue("Descripcion_in", agenda.Descripcion);
            cmd.ExecuteNonQuery();
            exito = true;
            connection.Close();
            return exito;
        }
        public static List<Agenda> ListarRecordatoriosUsuario(int idUsuario)
        {
            List<Agenda> lista = new List<Agenda>();
            connection.Close();
            connection.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = connection;
            DataTable Tabla = new DataTable();
            MySqlParameter[] oParam = {
                                      new MySqlParameter("idUsuario_in", idUsuario)};
            string proceso = "ListarRecordatoriosUsuario";
            MySqlDataAdapter dt = new MySqlDataAdapter(proceso, connection);
            dt.SelectCommand.CommandType = CommandType.StoredProcedure;
            dt.SelectCommand.Parameters.AddRange(oParam);
            dt.Fill(Tabla);
            if (Tabla.Rows.Count > 0)
            {
                foreach (DataRow item in Tabla.Rows)
                {
                    Agenda listaAgenda = new Agenda();
                    listaAgenda.idAgenda = Convert.ToInt32(item["idAgenda"].ToString());                   
                    string fecha = Convert.ToDateTime(item["Fecha"].ToString()).ToShortDateString();
                    listaAgenda.Fecha = Convert.ToDateTime(fecha);
                    listaAgenda.Descripcion = item["Recordatorio"].ToString();
                    lista.Add(listaAgenda);
                }
            }
            connection.Close();
            return lista;
        }

        public static List<Agenda> BuscarRecordatorio(int idAgendaSeleccionado)
        {
            List<Agenda> lista = new List<Agenda>();
            connection.Close();
            connection.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = connection;
            DataTable Tabla = new DataTable();
            MySqlParameter[] oParam = {
                                      new MySqlParameter("idAgendaSeleccionado_in", idAgendaSeleccionado)};
            string proceso = "BuscarRecordatorio";
            MySqlDataAdapter dt = new MySqlDataAdapter(proceso, connection);
            dt.SelectCommand.CommandType = CommandType.StoredProcedure;
            dt.SelectCommand.Parameters.AddRange(oParam);
            dt.Fill(Tabla);
            if (Tabla.Rows.Count > 0)
            {
                foreach (DataRow item in Tabla.Rows)
                {
                    Agenda listaAgenda = new Agenda();
                    listaAgenda.idAgenda = Convert.ToInt32(item["idAgenda"].ToString());
                    string fecha = Convert.ToDateTime(item["Fecha"].ToString()).ToShortDateString();
                    listaAgenda.Fecha = Convert.ToDateTime(fecha);
                    listaAgenda.Descripcion = item["Recordatorio"].ToString();
                    listaAgenda.UsuariosSistema = Convert.ToInt32(item["UsuarioSistema"].ToString());
                    listaAgenda.idUsuario = Convert.ToInt32(item["idUsuario"].ToString());
                    listaAgenda.Email = Convert.ToInt32(item["EnviarEmail"].ToString());
                    lista.Add(listaAgenda);
                }
            }
            connection.Close();
            return lista;
        }
        public static bool AnularRecordatorio(int idRecordatorio)
        {
            bool exito = false;
            connection.Close();
            connection.Open();
            string Actualizar = "AnularRecordatorio";
            MySqlCommand cmd = new MySqlCommand(Actualizar, connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("idRecordatorio_in", idRecordatorio);
            cmd.Parameters.AddWithValue("idUsuario_in", Sesion.UsuarioLogueado.IdUsuario);
            cmd.Parameters.AddWithValue("FechaCierre_in", DateTime.Now);
            cmd.ExecuteNonQuery();
            exito = true;
            connection.Close();
            return exito;
        }
    }
}
