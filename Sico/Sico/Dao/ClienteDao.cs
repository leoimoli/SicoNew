using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sico.Entidades;

namespace Sico.Dao
{
    public class ClienteDao
    {
        private static MySql.Data.MySqlClient.MySqlConnection connection = new MySqlConnection(Properties.Settings.Default.db);
        public static List<string> CargarComboProvincia()
        {
            connection.Close();
            connection.Open();
            List<string> _listaProvincia = new List<string>();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = connection;
            DataTable Tabla = new DataTable();
            MySqlParameter[] oParam = { };
            string proceso = "ListarProvincias";
            MySqlDataAdapter dt = new MySqlDataAdapter(proceso, connection);
            dt.SelectCommand.CommandType = CommandType.StoredProcedure;
            dt.SelectCommand.Parameters.AddRange(oParam);
            dt.Fill(Tabla);
            if (Tabla.Rows.Count > 0)
            {
                foreach (DataRow item in Tabla.Rows)
                {
                    _listaProvincia.Add(item["idProvincia"].ToString() + "," + item["txNombre"].ToString());
                }
            }
            connection.Close();
            return _listaProvincia;
        }

        public static List<string> CargarComboLocalidadesPorIdProvincia(int idProvinciaSeleccionada)
        {
            connection.Close();
            connection.Open();
            List<string> _listaProvincia = new List<string>();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = connection;
            DataTable Tabla = new DataTable();
            MySqlParameter[] oParam = { new MySqlParameter("idProvincia_in", idProvinciaSeleccionada) };
            string proceso = "ListarLocalidadesPorIdProvincia";
            MySqlDataAdapter dt = new MySqlDataAdapter(proceso, connection);
            dt.SelectCommand.CommandType = CommandType.StoredProcedure;
            dt.SelectCommand.Parameters.AddRange(oParam);
            dt.Fill(Tabla);
            if (Tabla.Rows.Count > 0)
            {
                foreach (DataRow item in Tabla.Rows)
                {
                    _listaProvincia.Add(item["txNombre"].ToString());
                }
            }
            connection.Close();
            return _listaProvincia;
        }

        public static bool ValidarClienteExistente(string nombreRazonSocial, string cuit)
        {
            connection.Close();
            bool Existe = false;
            connection.Open();
            List<Usuario> lista = new List<Usuario>();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = connection;
            DataTable Tabla = new DataTable();
            MySqlParameter[] oParam = {
                                      new MySqlParameter("NombreRazonSocial_in", nombreRazonSocial),
            new MySqlParameter("Cuit_in", cuit)};
            string proceso = "ValidarClienteExistente";
            MySqlDataAdapter dt = new MySqlDataAdapter(proceso, connection);
            dt.SelectCommand.CommandType = CommandType.StoredProcedure;
            dt.SelectCommand.Parameters.AddRange(oParam);
            dt.Fill(Tabla);
            DataSet ds = new DataSet();
            dt.Fill(ds, "tclientes");
            if (Tabla.Rows.Count > 0)
            {
                Existe = true;
            }
            connection.Close();
            return Existe;
        }

        public static bool InsertCliente(Cliente _cliente)
        {
            bool exito = false;
            connection.Close();
            connection.Open();
            string proceso = "AltaCliente";
            MySqlCommand cmd = new MySqlCommand(proceso, connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("NombreRazonSocial_in", _cliente.NombreRazonSocial);
            cmd.Parameters.AddWithValue("Cuit_in", _cliente.Cuit);
            cmd.Parameters.AddWithValue("Actividad_in", _cliente.Actividad);
            cmd.Parameters.AddWithValue("FechaDeInscripcion_in", _cliente.FechaDeInscripcion);
            cmd.Parameters.AddWithValue("CondicionAntiAfip_in", _cliente.CondicionAntiAfip);
            cmd.Parameters.AddWithValue("Telefono_in", _cliente.Telefono);
            cmd.Parameters.AddWithValue("Email_in", _cliente.Email);
            cmd.Parameters.AddWithValue("Provincia_in", _cliente.Provincia);
            cmd.Parameters.AddWithValue("Localidad_in", _cliente.Localidad);
            cmd.Parameters.AddWithValue("Calle_in", _cliente.Calle);
            cmd.Parameters.AddWithValue("Altura_in", _cliente.Altura);
            cmd.Parameters.AddWithValue("CodigoPostal_in", _cliente.CodigoPostal);
            cmd.Parameters.AddWithValue("idUsuario_in", _cliente.idUsuario);
            cmd.ExecuteNonQuery();
            exito = true;
            connection.Close();
            return exito;
        }

        public static bool EditarCliente(Cliente _cliente)
        {
            bool exito = false;
            connection.Close();
            connection.Open();
            string Actualizar = "EditarCliente";
            MySqlCommand cmd = new MySqlCommand(Actualizar, connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("NombreRazonSocial_in", _cliente.NombreRazonSocial);
            cmd.Parameters.AddWithValue("Cuit_in", _cliente.Cuit);
            cmd.Parameters.AddWithValue("Actividad_in", _cliente.Actividad);
            cmd.Parameters.AddWithValue("FechaDeInscripcion_in", _cliente.FechaDeInscripcion);
            cmd.Parameters.AddWithValue("CondicionAntiAfip_in", _cliente.CondicionAntiAfip);
            cmd.Parameters.AddWithValue("Telefono_in", _cliente.Telefono);
            cmd.Parameters.AddWithValue("Email_in", _cliente.Email);
            cmd.Parameters.AddWithValue("Provincia_in", _cliente.Provincia);
            cmd.Parameters.AddWithValue("Localidad_in", _cliente.Localidad);
            cmd.Parameters.AddWithValue("Calle_in", _cliente.Calle);
            cmd.Parameters.AddWithValue("Altura_in", _cliente.Altura);
            cmd.Parameters.AddWithValue("CodigoPostal_in", _cliente.CodigoPostal);
            cmd.Parameters.AddWithValue("idUsuario_in", _cliente.idUsuario);
            cmd.ExecuteNonQuery();
            exito = true;
            connection.Close();
            return exito;
        }
        public static List<Cliente> BuscarClientePorCuit(string cuit)
        {
            connection.Close();
            connection.Open();
            List<Entidades.Cliente> lista = new List<Entidades.Cliente>();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = connection;
            DataTable Tabla = new DataTable();
            MySqlParameter[] oParam = {
                                      new MySqlParameter("Cuit_in", cuit)};
            string proceso = "BuscarClientePorCuit";
            MySqlDataAdapter dt = new MySqlDataAdapter(proceso, connection);
            dt.SelectCommand.CommandType = CommandType.StoredProcedure;
            dt.SelectCommand.Parameters.AddRange(oParam);
            dt.Fill(Tabla);
            if (Tabla.Rows.Count > 0)
            {
                foreach (DataRow item in Tabla.Rows)
                {
                    Cliente listaCliente = new Cliente();
                    listaCliente.IdCliente = Convert.ToInt32(item["IdCliente"].ToString());
                    listaCliente.NombreRazonSocial = item["NombreRazonSocial"].ToString();
                    listaCliente.Cuit = item["Cuit"].ToString();
                    listaCliente.Actividad = item["Actividad"].ToString();
                    listaCliente.FechaDeInscripcion = Convert.ToDateTime(item["FechaInscripcion"].ToString());
                    listaCliente.CondicionAntiAfip = item["CondicionAntiAfip"].ToString();
                    listaCliente.Telefono = item["Telefono"].ToString();
                    listaCliente.Email = item["Email"].ToString();
                    listaCliente.Provincia = item["Provincia"].ToString();
                    listaCliente.Localidad = item["Localidad"].ToString();
                    listaCliente.Calle = item["Calle"].ToString();
                    listaCliente.Altura = item["Altura"].ToString();
                    listaCliente.CodigoPostal = item["CodigoPostal"].ToString();
                    lista.Add(listaCliente);
                }
            }
            connection.Close();
            return lista;
        }
        public static List<Cliente> BuscarClientePorNombreRazonSocial(string nombreRazonSocial)
        {
            connection.Close();
            connection.Open();
            List<Entidades.Cliente> lista = new List<Entidades.Cliente>();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = connection;
            DataTable Tabla = new DataTable();
            MySqlParameter[] oParam = {
                                      new MySqlParameter("NombreRazonSocial_in", nombreRazonSocial)};
            string proceso = "BuscarClientePorNombreRazonSocial";
            MySqlDataAdapter dt = new MySqlDataAdapter(proceso, connection);
            dt.SelectCommand.CommandType = CommandType.StoredProcedure;
            dt.SelectCommand.Parameters.AddRange(oParam);
            dt.Fill(Tabla);
            if (Tabla.Rows.Count > 0)
            {
                foreach (DataRow item in Tabla.Rows)
                {
                    Cliente listaCliente = new Cliente();
                    listaCliente.IdCliente = Convert.ToInt32(item["IdCliente"].ToString());
                    listaCliente.NombreRazonSocial = item["NombreRazonSocial"].ToString();
                    listaCliente.Cuit = item["Cuit"].ToString();
                    listaCliente.Actividad = item["Actividad"].ToString();
                    listaCliente.FechaDeInscripcion = Convert.ToDateTime(item["FechaInscripcion"].ToString());
                    listaCliente.CondicionAntiAfip = item["CondicionAntiAfip"].ToString();
                    listaCliente.Telefono = item["Telefono"].ToString();
                    listaCliente.Email = item["Email"].ToString();
                    listaCliente.Provincia = item["Provincia"].ToString();
                    listaCliente.Localidad = item["Localidad"].ToString();
                    listaCliente.Calle = item["Calle"].ToString();
                    listaCliente.Altura = item["Altura"].ToString();
                    listaCliente.CodigoPostal = item["CodigoPostal"].ToString();
                    lista.Add(listaCliente);
                }
            }
            connection.Close();
            return lista;
        }
        public static List<string> CargarComboLocalidades()
        {
            connection.Close();
            connection.Open();
            List<string> _listaProvincia = new List<string>();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = connection;
            DataTable Tabla = new DataTable();
            MySqlParameter[] oParam = { };
            string proceso = "ListarLocalidades";
            MySqlDataAdapter dt = new MySqlDataAdapter(proceso, connection);
            dt.SelectCommand.CommandType = CommandType.StoredProcedure;
            dt.SelectCommand.Parameters.AddRange(oParam);
            dt.Fill(Tabla);
            if (Tabla.Rows.Count > 0)
            {
                foreach (DataRow item in Tabla.Rows)
                {
                    _listaProvincia.Add(item["idLocalidad"].ToString() + "," + item["txNombre"].ToString());
                }
            }
            connection.Close();
            return _listaProvincia;
        }
    }
}
