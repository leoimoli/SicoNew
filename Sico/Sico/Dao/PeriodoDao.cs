﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sico.Dao
{
    public class PeriodoDao
    {
        private static MySql.Data.MySqlClient.MySqlConnection connection = new MySqlConnection(Properties.Settings.Default.db);
        public static bool GuardarPeriodo(string cuit, string nombre, string Año, DateTime fechaDesde, DateTime fechaHasta)
        {
            bool exito = false;
            int inCliente = Sesion.UsuarioLogueado.idEmpresaSeleccionado;
            bool YaExiste = ValidadPeriodoExistente(nombre, inCliente, Año);
            string NombrePeriodo = nombre + Año;
            if (YaExiste == false)
            {
                connection.Close();
                connection.Open();
                string proceso = "GuardarPeriodo";
                MySqlCommand cmd = new MySqlCommand(proceso, connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("idCliente_in", inCliente);
                cmd.Parameters.AddWithValue("Ano_in", Año);
                cmd.Parameters.AddWithValue("Nombre_in", NombrePeriodo);
                cmd.Parameters.AddWithValue("FechaDesde_in", fechaDesde);
                cmd.Parameters.AddWithValue("FechaHasta_in", fechaHasta);
                cmd.ExecuteNonQuery();
                exito = true;
                connection.Close();
                return exito;
            }
            else
            {
                const string message = "Ya existe un Periodo con el mismo nombre para el cliente seleccionado.";
                const string caption = "Error";
                var result = MessageBox.Show(message, caption,
                                             MessageBoxButtons.OK,
                                           MessageBoxIcon.Exclamation);
                throw new Exception();
                exito = false;
                return exito;
            }
        }

        public static List<string> CargarComboPeriodoVenta(int idEmpresa)
        {
            List<Entidades.Cliente> id = new List<Entidades.Cliente>();
            connection.Close();
            connection.Open();
            List<string> _TipoMoneda = new List<string>();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = connection;
            DataTable Tabla = new DataTable();
            MySqlParameter[] oParam = { new MySqlParameter("idCliente_in", idEmpresa) };
            string proceso = "ListarPeriodoVenta";
            MySqlDataAdapter dt = new MySqlDataAdapter(proceso, connection);
            dt.SelectCommand.CommandType = CommandType.StoredProcedure;
            dt.SelectCommand.Parameters.AddRange(oParam);
            dt.Fill(Tabla);
            if (Tabla.Rows.Count > 0)
            {
                foreach (DataRow item in Tabla.Rows)
                {
                    _TipoMoneda.Add(item["Nombre"].ToString());
                }
            }
            connection.Close();
            return _TipoMoneda;
        }
        public static List<string> CargarComboPeriodoCompras(string cuit)
        {
            List<Entidades.Cliente> id = new List<Entidades.Cliente>();
            id = ClienteDao.BuscarClientePorCuit(cuit);
            int idCliente = id[0].IdCliente;
            connection.Close();
            connection.Open();
            List<string> _TipoMoneda = new List<string>();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = connection;
            DataTable Tabla = new DataTable();
            MySqlParameter[] oParam = { new MySqlParameter("idCliente_in", idCliente) };
            string proceso = "ListarPeriodoCompras";
            MySqlDataAdapter dt = new MySqlDataAdapter(proceso, connection);
            dt.SelectCommand.CommandType = CommandType.StoredProcedure;
            dt.SelectCommand.Parameters.AddRange(oParam);
            dt.Fill(Tabla);
            if (Tabla.Rows.Count > 0)
            {
                foreach (DataRow item in Tabla.Rows)
                {
                    _TipoMoneda.Add(item["Nombre"].ToString());
                }
            }
            connection.Close();
            return _TipoMoneda;
        }
        public static bool GuardarPeriodoVenta(int idEmpresa, string nombre, string Año, DateTime fechaDesde, DateTime fechaHasta)
        {
            bool exito = false;
            List<Entidades.Cliente> id = new List<Entidades.Cliente>();
            bool YaExiste = ValidadPeriodoVentaExistente(nombre, idEmpresa, Año);
            string NombrePeriodo = nombre + Año;
            if (YaExiste == false)
            {
                connection.Close();
                connection.Open();
                string proceso = "GuardarPeriodoVenta";
                MySqlCommand cmd = new MySqlCommand(proceso, connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("idCliente_in", idEmpresa);
                cmd.Parameters.AddWithValue("Ano_in", Año);
                cmd.Parameters.AddWithValue("Nombre_in", NombrePeriodo);
                cmd.Parameters.AddWithValue("FechaDesde_in", fechaDesde);
                cmd.Parameters.AddWithValue("FechaHasta_in", fechaHasta);
                cmd.ExecuteNonQuery();
                exito = true;
                connection.Close();
                return exito;
            }
            else
            {
                const string message = "Ya existe un Periodo de Venta con el mismo nombre para el cliente seleccionado.";
                const string caption = "Error";
                var result = MessageBox.Show(message, caption,
                                             MessageBoxButtons.OK,
                                           MessageBoxIcon.Exclamation);
                throw new Exception();
                exito = false;
                return exito;
            }
        }
        private static bool ValidadPeriodoVentaExistente(string nombre, int idCliente, string Año)
        {
            connection.Close();
            bool Existe = false;
            connection.Open();
            string NombrePeriodo = nombre + Año;
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = connection;
            DataTable Tabla = new DataTable();
            MySqlParameter[] oParam = {
                                      new MySqlParameter("Nombre_in", NombrePeriodo),
                                      new MySqlParameter("Ano_in", Año),
            new MySqlParameter("idCliente_in", idCliente)};
            string proceso = "ValidadPeriodoVentaExistente";
            MySqlDataAdapter dt = new MySqlDataAdapter(proceso, connection);
            dt.SelectCommand.CommandType = CommandType.StoredProcedure;
            dt.SelectCommand.Parameters.AddRange(oParam);
            dt.Fill(Tabla);
            DataSet ds = new DataSet();
            dt.Fill(ds, "tPeriodosVentas");
            if (Tabla.Rows.Count > 0)
            {
                Existe = true;
            }
            connection.Close();
            return Existe;
        }

        private static bool ValidadPeriodoExistente(string nombre, int idCliente, string Año)
        {
            connection.Close();
            bool Existe = false;
            connection.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = connection;
            DataTable Tabla = new DataTable();
            MySqlParameter[] oParam = {
                                      new MySqlParameter("Nombre_in", nombre),
                                      new MySqlParameter("Ano_in", Año),
            new MySqlParameter("idCliente_in", idCliente)};
            string proceso = "ValidadPeriodoExistente";
            MySqlDataAdapter dt = new MySqlDataAdapter(proceso, connection);
            dt.SelectCommand.CommandType = CommandType.StoredProcedure;
            dt.SelectCommand.Parameters.AddRange(oParam);
            dt.Fill(Tabla);
            DataSet ds = new DataSet();
            dt.Fill(ds, "tPeriodosCompras");
            if (Tabla.Rows.Count > 0)
            {
                Existe = true;
            }
            connection.Close();
            return Existe;
        }

        public static List<string> CargarComboPeriodo(int idEmpresa)
        {
            List<Entidades.Cliente> id = new List<Entidades.Cliente>();           
            connection.Close();
            connection.Open();
            List<string> _TipoMoneda = new List<string>();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = connection;
            DataTable Tabla = new DataTable();
            MySqlParameter[] oParam = { new MySqlParameter("idCliente_in", idEmpresa) };
            string proceso = "ListarPeriodoCompras";
            MySqlDataAdapter dt = new MySqlDataAdapter(proceso, connection);
            dt.SelectCommand.CommandType = CommandType.StoredProcedure;
            dt.SelectCommand.Parameters.AddRange(oParam);
            dt.Fill(Tabla);
            if (Tabla.Rows.Count > 0)
            {
                foreach (DataRow item in Tabla.Rows)
                {
                    _TipoMoneda.Add(item["Nombre"].ToString());
                }
            }
            connection.Close();
            return _TipoMoneda;
        }
    }
}
