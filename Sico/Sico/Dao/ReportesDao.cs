using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sico.Entidades;
using MySql.Data.MySqlClient;
using System.Data;

namespace Sico.Dao
{
    public class ReportesDao
    {
        private static MySql.Data.MySqlClient.MySqlConnection connection = new MySqlConnection(Properties.Settings.Default.db);
        public static List<Reporte_Pagos> ListarPagosRecibidos()
        {
            connection.Close();
            connection.Open();
            List<Reporte_Pagos> _listapagos = new List<Reporte_Pagos>();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = connection;
            DataTable Tabla = new DataTable();
            MySqlParameter[] oParam = { };
            string proceso = "ListarPagosRecibidos";
            MySqlDataAdapter dt = new MySqlDataAdapter(proceso, connection);
            dt.SelectCommand.CommandType = CommandType.StoredProcedure;
            dt.SelectCommand.Parameters.AddRange(oParam);
            dt.Fill(Tabla);
            if (Tabla.Rows.Count > 0)
            {
                foreach (DataRow item in Tabla.Rows)
                {
                    Entidades.Reporte_Pagos listaVentas = new Entidades.Reporte_Pagos();
                    listaVentas.anno = item["anno"].ToString();
                    listaVentas.mes = item["mes"].ToString();
                    listaVentas.MontoTotal = Convert.ToInt32(item["Monto"].ToString());
                    _listapagos.Add(listaVentas);
                }
            }
            connection.Close();
            return _listapagos;
        }
        public static List<PlanHonorarios> ListarPlanes()
        {
            connection.Close();
            connection.Open();
            List<PlanHonorarios> _listapagos = new List<PlanHonorarios>();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = connection;
            DataTable Tabla = new DataTable();
            MySqlParameter[] oParam = { };
            string proceso = "ListarPlanes";
            MySqlDataAdapter dt = new MySqlDataAdapter(proceso, connection);
            dt.SelectCommand.CommandType = CommandType.StoredProcedure;
            dt.SelectCommand.Parameters.AddRange(oParam);
            dt.Fill(Tabla);
            if (Tabla.Rows.Count > 0)
            {
                foreach (DataRow item in Tabla.Rows)
                {
                    Entidades.PlanHonorarios listaVentas = new Entidades.PlanHonorarios();
                    listaVentas.NombreEmpresa = item["Empresa"].ToString();
                    listaVentas.Descripcion = item["Descripcion"].ToString();
                    listaVentas.FechaHasta = Convert.ToDateTime(item["FechaHasta"].ToString());
                    _listapagos.Add(listaVentas);
                }
            }
            connection.Close();
            return _listapagos;
        }
        public static List<Reporte_Pagos> PlanesAbiertos()
        {
            String Año = DateTime.Now.Year.ToString();
            string FechaArmadaDesde = "01/01/" + Año;
            DateTime FechaDesde = Convert.ToDateTime(FechaArmadaDesde);
            string FechaArmadaHasta = "31/12/" + Año;
            DateTime FechaHasta = Convert.ToDateTime(FechaArmadaHasta);
            connection.Close();
            connection.Open();
            List<Reporte_Pagos> _lista = new List<Reporte_Pagos>();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = connection;
            DataTable Tabla = new DataTable();
            MySqlParameter[] oParam = { new MySqlParameter("FechaDesde_in", FechaDesde),
            new MySqlParameter("FechaHasta_in", FechaHasta) };
            string proceso = "TotalPlanesAbiertos";
            MySqlDataAdapter dt = new MySqlDataAdapter(proceso, connection);
            dt.SelectCommand.CommandType = CommandType.StoredProcedure;
            dt.SelectCommand.Parameters.AddRange(oParam);
            dt.Fill(Tabla);
            if (Tabla.Rows.Count > 0)
            {
                foreach (DataRow item in Tabla.Rows)
                {
                    Entidades.Reporte_Pagos listaPlanes = new Entidades.Reporte_Pagos();
                    listaPlanes.TotalPlanesAbiertos = Convert.ToInt32(item["Total"].ToString());
                    _lista.Add(listaPlanes);
                }
            }
            connection.Close();
            return _lista;
        }
        public static List<Reporte_Pagos> PlanesCerrados()
        {
            String Año = DateTime.Now.Year.ToString();
            string FechaArmadaDesde = "01/01/" + Año;
            DateTime FechaDesde = Convert.ToDateTime(FechaArmadaDesde);
            string FechaArmadaHasta = "31/12/" + Año;
            DateTime FechaHasta = Convert.ToDateTime(FechaArmadaHasta);
            connection.Close();
            connection.Open();
            List<Reporte_Pagos> _lista = new List<Reporte_Pagos>();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = connection;
            DataTable Tabla = new DataTable();
            MySqlParameter[] oParam = { new MySqlParameter("FechaDesde_in", FechaDesde),
            new MySqlParameter("FechaHasta_in", FechaHasta) };
            string proceso = "TotalPlanesCerrados";
            MySqlDataAdapter dt = new MySqlDataAdapter(proceso, connection);
            dt.SelectCommand.CommandType = CommandType.StoredProcedure;
            dt.SelectCommand.Parameters.AddRange(oParam);
            dt.Fill(Tabla);
            if (Tabla.Rows.Count > 0)
            {
                foreach (DataRow item in Tabla.Rows)
                {
                    Entidades.Reporte_Pagos listaPlanes = new Entidades.Reporte_Pagos();
                    listaPlanes.TotalPlanesCerrados = Convert.ToInt32(item["Total"].ToString());
                    _lista.Add(listaPlanes);
                }
            }
            connection.Close();
            return _lista;
        }
        public static List<Reporte_Pagos> CobroHonorarios()
        {
            String Año = DateTime.Now.Year.ToString();
            string FechaArmadaDesde = "01/01/" + Año;
            DateTime FechaDesde = Convert.ToDateTime(FechaArmadaDesde);
            string FechaArmadaHasta = "31/12/" + Año;
            DateTime FechaHasta = Convert.ToDateTime(FechaArmadaHasta);
            connection.Close();
            connection.Open();
            List<Reporte_Pagos> _lista = new List<Reporte_Pagos>();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = connection;
            DataTable Tabla = new DataTable();
            MySqlParameter[] oParam = { new MySqlParameter("FechaDesde_in", FechaDesde),
            new MySqlParameter("FechaHasta_in", FechaHasta) };
            string proceso = "TotalHonorariosCobrados";
            MySqlDataAdapter dt = new MySqlDataAdapter(proceso, connection);
            dt.SelectCommand.CommandType = CommandType.StoredProcedure;
            dt.SelectCommand.Parameters.AddRange(oParam);
            dt.Fill(Tabla);
            if (Tabla.Rows.Count > 0)
            {
                foreach (DataRow item in Tabla.Rows)
                {
                    Entidades.Reporte_Pagos listaPlanes = new Entidades.Reporte_Pagos();
                    listaPlanes.CobroHonorarios = Convert.ToDouble(item["MontoTotal"].ToString());
                    _lista.Add(listaPlanes);
                }
            }
            connection.Close();
            return _lista;
        }
        public static List<Reporte_Pagos> PlanesGenerados()
        {
            String Año = DateTime.Now.Year.ToString();
            string FechaArmadaDesde = "01/01/" + Año;
            DateTime FechaDesde = Convert.ToDateTime(FechaArmadaDesde);
            string FechaArmadaHasta = "31/12/" + Año;
            DateTime FechaHasta = Convert.ToDateTime(FechaArmadaHasta);
            connection.Close();
            connection.Open();
            List<Reporte_Pagos> _lista = new List<Reporte_Pagos>();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = connection;
            DataTable Tabla = new DataTable();
            MySqlParameter[] oParam = { new MySqlParameter("FechaDesde_in", FechaDesde),
            new MySqlParameter("FechaHasta_in", FechaHasta) };
            string proceso = "TotalPlanesGenerados";
            MySqlDataAdapter dt = new MySqlDataAdapter(proceso, connection);
            dt.SelectCommand.CommandType = CommandType.StoredProcedure;
            dt.SelectCommand.Parameters.AddRange(oParam);
            dt.Fill(Tabla);
            if (Tabla.Rows.Count > 0)
            {
                foreach (DataRow item in Tabla.Rows)
                {
                    Entidades.Reporte_Pagos listaPlanes = new Entidades.Reporte_Pagos();
                    listaPlanes.TotalPlanes = Convert.ToInt32(item["Total"].ToString());
                    _lista.Add(listaPlanes);
                }
            }
            connection.Close();
            return _lista;
        }

    }
}
