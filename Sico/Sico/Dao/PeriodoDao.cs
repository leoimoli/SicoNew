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
        public static bool GuardarPeriodo(string cuit, string nombre)
        {
            bool exito = false;
            List<Entidades.Cliente> id = new List<Entidades.Cliente>();
            id = ClienteDao.BuscarClientePorCuit(cuit);
            int idCliente = id[0].IdCliente;
            bool YaExiste = ValidadPeriodoExistente(nombre, idCliente);
            if (YaExiste == false)
            {
                connection.Close();
                connection.Open();
                string proceso = "GuardarPeriodo";
                MySqlCommand cmd = new MySqlCommand(proceso, connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("idCliente_in", idCliente);
                cmd.Parameters.AddWithValue("Nombre_in", nombre);
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
        private static bool ValidadPeriodoExistente(string nombre, int idCliente)
        {
            connection.Close();
            bool Existe = false;
            connection.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = connection;
            DataTable Tabla = new DataTable();
            MySqlParameter[] oParam = {
                                      new MySqlParameter("Nombre_in", nombre),
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

        public static List<string> CargarComboPeriodo(string cuit)
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
            string proceso = "ListarPeriodo";
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
