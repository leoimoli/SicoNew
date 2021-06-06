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
    public class HonorariosDao
    {
        private static MySql.Data.MySqlClient.MySqlConnection connection = new MySqlConnection(Properties.Settings.Default.db);
        public static bool EditarPlan(PlanHonorarios plan)
        {
            bool exito = false;
            connection.Close();
            connection.Open();
            string Actualizar = "EditarPlan";
            MySqlCommand cmd = new MySqlCommand(Actualizar, connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("idPlan_in", plan.idPlan);
            cmd.Parameters.AddWithValue("Descripcion_in", plan.Descripcion);
            cmd.Parameters.AddWithValue("FechaDesde_in", plan.FechaDesde);
            cmd.Parameters.AddWithValue("FechaHasta_in", plan.FechaHasta);
            cmd.Parameters.AddWithValue("MontoMensual_in", plan.MontoMensual);
            cmd.Parameters.AddWithValue("MontoTotal_in", plan.MontoTotal);
            cmd.Parameters.AddWithValue("Observaciones_in", plan.Observaciones);
            cmd.Parameters.AddWithValue("estado_in", plan.Estado);
            cmd.Parameters.AddWithValue("idCliente_in", plan.idCliente);
            cmd.Parameters.AddWithValue("idUsuario_in", Sesion.UsuarioLogueado.IdUsuario);
            cmd.ExecuteNonQuery();
            exito = true;
            connection.Close();
            return exito;
        }
        public static bool GurdarPlan(PlanHonorarios plan)
        {
            bool exito = false;
            connection.Close();
            connection.Open();
            string proceso = "AltaPlan";
            MySqlCommand cmd = new MySqlCommand(proceso, connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("Descripcion_in", plan.Descripcion);
            cmd.Parameters.AddWithValue("FechaDesde_in", plan.FechaDesde);
            cmd.Parameters.AddWithValue("FechaHasta_in", plan.FechaHasta);
            cmd.Parameters.AddWithValue("MontoMensual_in", plan.MontoMensual);
            cmd.Parameters.AddWithValue("MontoTotal_in", plan.MontoTotal);
            cmd.Parameters.AddWithValue("Observaciones_in", plan.Observaciones);
            cmd.Parameters.AddWithValue("Estado_in", plan.Estado);
            cmd.Parameters.AddWithValue("idCliente_in", plan.idCliente);
            cmd.Parameters.AddWithValue("idUsuario_in", Sesion.UsuarioLogueado.IdUsuario);
            cmd.ExecuteNonQuery();
            exito = true;
            connection.Close();
            return exito;
        }
        public static List<PlanHonorarios> BuscarDetalleMensualDePagosHonorarios(int anio, string mes)
        {
            string mesObtenido = ValidarMes(mes);
            String Año = Convert.ToString(anio);
            String Mes = mesObtenido;
            connection.Close();
            connection.Open();
            List<PlanHonorarios> _lista = new List<PlanHonorarios>();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = connection;
            DataTable Tabla = new DataTable();
            MySqlParameter[] oParam = { new MySqlParameter("Anio_in", Año),
            new MySqlParameter("Mes_in", Mes) };
            string proceso = "BuscarDetalleMensualDePagosHonorarios";
            MySqlDataAdapter dt = new MySqlDataAdapter(proceso, connection);
            dt.SelectCommand.CommandType = CommandType.StoredProcedure;
            dt.SelectCommand.Parameters.AddRange(oParam);
            dt.Fill(Tabla);
            if (Tabla.Rows.Count > 0)
            {
                foreach (DataRow item in Tabla.Rows)
                {
                    Entidades.PlanHonorarios listaPlanes = new Entidades.PlanHonorarios();
                    listaPlanes.NombreEmpresa = item["Empresa"].ToString();
                    listaPlanes.MontoTotal = Convert.ToDouble(item["Monto"].ToString());
                    listaPlanes.FechaPago = Convert.ToDateTime(item["Fecha"].ToString());
                    listaPlanes.Observaciones = item["Observaciones"].ToString();
                    _lista.Add(listaPlanes);
                }
            }
            connection.Close();
            return _lista;
        }

        private static string ValidarMes(string mes)
        {
            string mesDevuelto = "";
            if (mes == "Enero")
            {
                mesDevuelto = "1";
            }
            if (mes == "Febrero")
            {
                mesDevuelto = "2";
            }
            if (mes == "Marzo")
            {
                mesDevuelto = "3";
            }
            if (mes == "Abril")
            {
                mesDevuelto = "4";
            }
            if (mes == "Mayo")
            {
                mesDevuelto = "5";
            }
            if (mes == "Junio")
            {
                mesDevuelto = "6";
            }
            if (mes == "julio")
            {
                mesDevuelto = "7";
            }
            if (mes == "Agosto")
            {
                mesDevuelto = "8";
            }
            if (mes == "Septiembre")
            {
                mesDevuelto = "9";
            }
            if (mes == "Octubre")
            {
                mesDevuelto = "10";
            }
            if (mes == "Noviembre")
            {
                mesDevuelto = "11";
            }
            if (mes == "Diciembre")
            {
                mesDevuelto = "12";
            }
            return mesDevuelto;
        }

        public static List<PlanHonorarios> BuscarHistoricoDePagos(int idPlan)
        {
            connection.Close();
            connection.Open();
            List<Entidades.PlanHonorarios> lista = new List<Entidades.PlanHonorarios>();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = connection;
            DataTable Tabla = new DataTable();
            MySqlParameter[] oParam = { new MySqlParameter("idPlan_in", idPlan) };
            string proceso = "BuscarHistoricoDePagos";
            MySqlDataAdapter dt = new MySqlDataAdapter(proceso, connection);
            dt.SelectCommand.CommandType = CommandType.StoredProcedure;
            dt.SelectCommand.Parameters.AddRange(oParam);
            dt.Fill(Tabla);
            if (Tabla.Rows.Count > 0)
            {
                foreach (DataRow item in Tabla.Rows)
                {
                    PlanHonorarios listaPlan = new PlanHonorarios();
                    listaPlan.FechaDesde = Convert.ToDateTime(item["Fecha"].ToString());
                    listaPlan.MontoPago = Convert.ToDouble(item["Monto"].ToString());
                    listaPlan.Observaciones = item["Observaciones"].ToString();
                    lista.Add(listaPlan);
                }
            }
            connection.Close();
            return lista;
        }
        public static List<PlanHonorarios> ListarPagosDelPlan(int idPlan)
        {
            connection.Close();
            connection.Open();
            List<Entidades.PlanHonorarios> lista = new List<Entidades.PlanHonorarios>();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = connection;
            DataTable Tabla = new DataTable();
            MySqlParameter[] oParam = { new MySqlParameter("idPlan_in", idPlan), };
            string proceso = "ListarPagosDelPlan";
            MySqlDataAdapter dt = new MySqlDataAdapter(proceso, connection);
            dt.SelectCommand.CommandType = CommandType.StoredProcedure;
            dt.SelectCommand.Parameters.AddRange(oParam);
            dt.Fill(Tabla);
            if (Tabla.Rows.Count > 0)
            {
                foreach (DataRow item in Tabla.Rows)
                {
                    PlanHonorarios listaPlan = new PlanHonorarios();
                    listaPlan.MontoPago = Convert.ToDouble(item["Monto"].ToString());
                    lista.Add(listaPlan);
                }
            }
            connection.Close();
            return lista;
        }
        public static bool CierroEstadoPlan(int idPlan)
        {
            bool exito = false;
            connection.Close();
            connection.Open();
            string Actualizar = "CierroEstadoPlan";
            MySqlCommand cmd = new MySqlCommand(Actualizar, connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("idPlan_in", idPlan);
            string Estado = "Cerrado";
            cmd.Parameters.AddWithValue("Estado_in", Estado);
            cmd.ExecuteNonQuery();
            exito = true;
            connection.Close();
            return exito;
        }
        public static bool RegistrarPago(PlanHonorarios plan)
        {
            bool exito = false;
            connection.Close();
            connection.Open();
            string proceso = "RegistrarPago";
            MySqlCommand cmd = new MySqlCommand(proceso, connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("FechaPago_in", plan.FechaPago);
            cmd.Parameters.AddWithValue("MontoPago_in", plan.MontoPago);
            cmd.Parameters.AddWithValue("Observaciones_in", plan.Observaciones);
            cmd.Parameters.AddWithValue("idPlan_in", plan.idPlan);
            cmd.Parameters.AddWithValue("idUsuario_in", Sesion.UsuarioLogueado.IdUsuario);
            cmd.ExecuteNonQuery();
            exito = true;
            connection.Close();
            return exito;
        }
        public static List<PlanHonorarios> ListarTodosPlanesParaCliente(int idEmpresaSeleccionado)
        {
            connection.Close();
            connection.Open();
            List<Entidades.PlanHonorarios> lista = new List<Entidades.PlanHonorarios>();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = connection;
            DataTable Tabla = new DataTable();
            MySqlParameter[] oParam = { new MySqlParameter("idCliente_in", idEmpresaSeleccionado) };
            string proceso = "ListarTodosPlanesParaCliente";
            MySqlDataAdapter dt = new MySqlDataAdapter(proceso, connection);
            dt.SelectCommand.CommandType = CommandType.StoredProcedure;
            dt.SelectCommand.Parameters.AddRange(oParam);
            dt.Fill(Tabla);
            if (Tabla.Rows.Count > 0)
            {
                foreach (DataRow item in Tabla.Rows)
                {
                    PlanHonorarios listaPlan = new PlanHonorarios();
                    listaPlan.idPlan = Convert.ToInt32(item["idPlan"].ToString());
                    listaPlan.Descripcion = item["Descripcion"].ToString();
                    listaPlan.FechaDesde = Convert.ToDateTime(item["FechaDesde"].ToString());
                    listaPlan.FechaHasta = Convert.ToDateTime(item["FechaHasta"].ToString());
                    listaPlan.MontoMensual = Convert.ToDouble(item["MontoMensual"].ToString());
                    listaPlan.MontoTotal = Convert.ToDouble(item["MontoTotal"].ToString());
                    listaPlan.Observaciones = item["Observaciones"].ToString();
                    listaPlan.Estado = item["Estado"].ToString();
                    lista.Add(listaPlan);
                }
            }
            connection.Close();
            return lista;
        }
    }
}
