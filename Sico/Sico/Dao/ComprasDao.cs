﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sico.Entidades;

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
                    _listaProvincia.Add(item["Codigo"].ToString() + " " + "-" + " " + item["Descripcion"].ToString());
                }
            }
            connection.Close();
            return _listaProvincia;
        }
        public static List<EstadisticaCompra> BuscarComprasEstadisticasPorProveedor(string cuit, string periodo)
        {
            List<EstadisticaCompra> lista = new List<EstadisticaCompra>();
            List<Cliente> id = new List<Cliente>();
            id = ClienteDao.BuscarClientePorCuit(cuit);
            int idCliente = id[0].IdCliente;
            if (idCliente > 0)
            {
                connection.Close();
                connection.Open();

                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = connection;
                DataTable Tabla = new DataTable();
                MySqlParameter[] oParam = {
                    new MySqlParameter("Periodo_in", periodo),
                                      new MySqlParameter("idCliente_in", idCliente)};
                string proceso = "BuscarComprasEstadisticasPorProveedor";
                MySqlDataAdapter dt = new MySqlDataAdapter(proceso, connection);
                dt.SelectCommand.CommandType = CommandType.StoredProcedure;
                dt.SelectCommand.Parameters.AddRange(oParam);
                dt.Fill(Tabla);
                if (Tabla.Rows.Count > 0)
                {
                    foreach (DataRow item in Tabla.Rows)
                    {
                        EstadisticaCompra listaFacturasCompras = new EstadisticaCompra();
                        listaFacturasCompras.idProveedor = Convert.ToInt32(item["idProveedor"].ToString());
                        listaFacturasCompras.NombreProveedor = item["NombreRazonSocial"].ToString();
                        listaFacturasCompras.Cuit = item["Cuit"].ToString();
                        listaFacturasCompras.TotalDeCompras = Convert.ToInt32(item["Compras"].ToString());
                        lista.Add(listaFacturasCompras);
                    }
                }
                connection.Close();
            }
            return lista;
        }
        public static List<FacturaVentaAnual> FacturacionAnualVentasPorPeriodos(string cuit, string Periodo)
        {
            List<FacturaVentaAnual> lista = new List<FacturaVentaAnual>();
            List<Entidades.Cliente> id = new List<Cliente>();
            id = ClienteDao.BuscarClientePorCuit(cuit);
            int IdCliente = id[0].IdCliente;
            if (IdCliente > 0)
            {
                connection.Close();
                connection.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = connection;
                DataTable Tabla = new DataTable();
                MySqlParameter[] oParam = {
                            new MySqlParameter("Periodo_in", Periodo),
                                      new MySqlParameter("idCliente_in", IdCliente)};
                string proceso = "FacturacionAnualVentasPorPeriodos";
                MySqlDataAdapter dt = new MySqlDataAdapter(proceso, connection);
                dt.SelectCommand.CommandType = CommandType.StoredProcedure;
                dt.SelectCommand.Parameters.AddRange(oParam);
                dt.Fill(Tabla);
                if (Tabla.Rows.Count > 0)
                {
                    foreach (DataRow item in Tabla.Rows)
                    {
                        FacturaVentaAnual listaFacturacion = new FacturaVentaAnual();
                        listaFacturacion.Periodo = item["Periodo"].ToString();
                        listaFacturacion.Monto = Convert.ToDecimal(item["MontoTotal"].ToString());
                        listaFacturacion.Total1 = Convert.ToDecimal(item["Total1"].ToString());
                        listaFacturacion.Total2 = Convert.ToDecimal(item["Total2"].ToString());
                        listaFacturacion.Total3 = Convert.ToDecimal(item["Total3"].ToString());
                        listaFacturacion.Neto1 = Convert.ToDecimal(item["Neto1"].ToString());
                        listaFacturacion.Neto2 = Convert.ToDecimal(item["Neto2"].ToString());
                        listaFacturacion.Neto3 = Convert.ToDecimal(item["Neto3"].ToString());
                        listaFacturacion.Iva1 = Convert.ToDecimal(item["Iva1"].ToString());
                        listaFacturacion.Iva2 = Convert.ToDecimal(item["Iva2"].ToString());
                        listaFacturacion.Iva3 = Convert.ToDecimal(item["Iva3"].ToString());
                        lista.Add(listaFacturacion);
                    }
                }
            }
            connection.Close();
            return lista;
        }
        public static List<FacturaCompraAnual> FacturacionAnualPorPeriodos(string cuit, string periodo)
        {
            List<FacturaCompraAnual> lista = new List<FacturaCompraAnual>();
            List<Entidades.Cliente> id = new List<Cliente>();
            id = ClienteDao.BuscarClientePorCuit(cuit);
            int IdCliente = id[0].IdCliente;
            if (IdCliente > 0)
            {
                connection.Close();
                connection.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = connection;
                DataTable Tabla = new DataTable();
                MySqlParameter[] oParam = {
                            new MySqlParameter("Periodo_in", periodo),
                                      new MySqlParameter("idCliente_in", IdCliente)};
                string proceso = "FacturacionAnualPorPeriodos";
                MySqlDataAdapter dt = new MySqlDataAdapter(proceso, connection);
                dt.SelectCommand.CommandType = CommandType.StoredProcedure;
                dt.SelectCommand.Parameters.AddRange(oParam);
                dt.Fill(Tabla);
                if (Tabla.Rows.Count > 0)
                {
                    foreach (DataRow item in Tabla.Rows)
                    {
                        FacturaCompraAnual listaFacturacion = new FacturaCompraAnual();
                        listaFacturacion.Periodo = item["Periodo"].ToString();
                        listaFacturacion.Monto = Convert.ToDecimal(item["MontoTotal"].ToString());
                        listaFacturacion.Total1 = Convert.ToDecimal(item["Total1"].ToString());
                        listaFacturacion.Total2 = Convert.ToDecimal(item["Total2"].ToString());
                        listaFacturacion.Total3 = Convert.ToDecimal(item["Total3"].ToString());
                        listaFacturacion.Neto1 = Convert.ToDecimal(item["Neto1"].ToString());
                        listaFacturacion.Neto2 = Convert.ToDecimal(item["Neto2"].ToString());
                        listaFacturacion.Neto3 = Convert.ToDecimal(item["Neto3"].ToString());
                        listaFacturacion.Iva1 = Convert.ToDecimal(item["Iva1"].ToString());
                        listaFacturacion.Iva2 = Convert.ToDecimal(item["Iva2"].ToString());
                        listaFacturacion.Iva3 = Convert.ToDecimal(item["Iva3"].ToString());
                        listaFacturacion.PercepIngBrutos = Convert.ToDecimal(item["PercepcionIngresosBrutos"].ToString());
                        listaFacturacion.PercepIva = Convert.ToDecimal(item["PercepcionIva"].ToString());
                        listaFacturacion.NoGravado = Convert.ToDecimal(item["NoGravado"].ToString());
                        lista.Add(listaFacturacion);
                    }
                }
            }
            connection.Close();
            return lista;
        }

        public static List<EstadisticaCompraTorta> BuscarFacturacionTorta(string cuit, string periodoTorta)
        {
            List<EstadisticaCompraTorta> lista = new List<EstadisticaCompraTorta>();
            List<Entidades.Cliente> id = new List<Cliente>();
            id = ClienteDao.BuscarClientePorCuit(cuit);
            int IdCliente = id[0].IdCliente;
            if (IdCliente > 0)
            {
                connection.Close();
                connection.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = connection;
                DataTable Tabla = new DataTable();
                MySqlParameter[] oParam = {
                                       new MySqlParameter("idCliente_in", IdCliente),
                                       new MySqlParameter("periodo_in", periodoTorta)};
                string proceso = "FacturacionProveedorPorPeriodo";
                MySqlDataAdapter dt = new MySqlDataAdapter(proceso, connection);
                dt.SelectCommand.CommandType = CommandType.StoredProcedure;
                dt.SelectCommand.Parameters.AddRange(oParam);
                dt.Fill(Tabla);
                if (Tabla.Rows.Count > 0)
                {
                    foreach (DataRow item in Tabla.Rows)
                    {
                        EstadisticaCompraTorta listaFacturaCompra = new EstadisticaCompraTorta();
                        listaFacturaCompra.NombreProveedor = item["NombreRazonSocial"].ToString();
                        listaFacturaCompra.Monto = Convert.ToDecimal(item["total"].ToString());
                        lista.Add(listaFacturaCompra);
                    }
                }
            }
            connection.Close();
            return lista;
        }

        public static List<FacturaCompra> BuscarTodasFacturasDeComprasDelCliente(string cuit)
        {
            List<FacturaCompra> lista = new List<FacturaCompra>();
            List<Cliente> id = new List<Cliente>();
            id = ClienteDao.BuscarClientePorCuit(cuit);
            int idCliente = id[0].IdCliente;
            if (idCliente > 0)
            {
                connection.Close();
                connection.Open();

                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = connection;
                DataTable Tabla = new DataTable();
                MySqlParameter[] oParam = {
                                      new MySqlParameter("idCliente_in", idCliente)};
                string proceso = "BuscarTodasFacturasDeComprasDelCliente";
                MySqlDataAdapter dt = new MySqlDataAdapter(proceso, connection);
                dt.SelectCommand.CommandType = CommandType.StoredProcedure;
                dt.SelectCommand.Parameters.AddRange(oParam);
                dt.Fill(Tabla);
                if (Tabla.Rows.Count > 0)
                {
                    foreach (DataRow item in Tabla.Rows)
                    {
                        FacturaCompra listaFacturasCompras = new FacturaCompra();
                        listaFacturasCompras.idFactura = Convert.ToInt32(item["idFactura"].ToString());
                        listaFacturasCompras.NroFactura = item["NroFactura"].ToString();
                        listaFacturasCompras.Fecha = item["Fecha"].ToString();
                        listaFacturasCompras.Monto = Convert.ToDecimal(item["MontoTotal"].ToString());
                        listaFacturasCompras.NombreProveedor = item["NombreRazonSocial"].ToString();

                        //// Detalle de la factura
                        listaFacturasCompras.TipoComprobante = item["TipoComprobante"].ToString();
                        listaFacturasCompras.Total1 = Convert.ToDecimal(item["Total1"].ToString());
                        listaFacturasCompras.Total2 = Convert.ToDecimal(item["Total2"].ToString());
                        listaFacturasCompras.Total3 = Convert.ToDecimal(item["Total3"].ToString());
                        listaFacturasCompras.Neto1 = Convert.ToDecimal(item["Neto1"].ToString());
                        listaFacturasCompras.Neto2 = Convert.ToDecimal(item["Neto2"].ToString());
                        listaFacturasCompras.Neto3 = Convert.ToDecimal(item["Neto3"].ToString());
                        listaFacturasCompras.Alicuota1 = item["Alicuota1"].ToString();
                        listaFacturasCompras.Alicuota2 = item["Alicuota2"].ToString();
                        listaFacturasCompras.Alicuota3 = item["Alicuota3"].ToString();
                        listaFacturasCompras.Iva1 = Convert.ToDecimal(item["Iva1"].ToString());
                        listaFacturasCompras.Iva2 = Convert.ToDecimal(item["Iva2"].ToString());
                        listaFacturasCompras.Iva3 = Convert.ToDecimal(item["Iva3"].ToString());
                        listaFacturasCompras.PercepIngBrutos = Convert.ToDecimal(item["PercepcionIngresosBrutos"].ToString());
                        listaFacturasCompras.PercepIva = Convert.ToDecimal(item["PercepcionIva"].ToString());
                        listaFacturasCompras.NoGravado = Convert.ToDecimal(item["NoGravado"].ToString());
                        listaFacturasCompras.CodigoMoneda = item["CodigoMoneda"].ToString();
                        listaFacturasCompras.TipoDeCambio = item["TipoDeCambio"].ToString();
                        listaFacturasCompras.CodigoTipoOperacion = item["CodigoOperacion"].ToString();
                        lista.Add(listaFacturasCompras);
                    }
                }
                connection.Close();
            }
            return lista;
        }
        public static List<FacturaCompraAnual> FacturacionAnualPorAño(string cuit, string año)
        {
            List<string> listaPeriodos = new List<string>();
            List<FacturaCompraAnual> lista = new List<FacturaCompraAnual>();
            List<Entidades.Cliente> id = new List<Cliente>();
            id = ClienteDao.BuscarClientePorCuit(cuit);
            int IdCliente = id[0].IdCliente;
            if (IdCliente > 0)
            {
                listaPeriodos = BuscarPeriodosComprasPorAñoIdCliente(IdCliente, año);
                foreach (var item in listaPeriodos)
                {
                    string Periodo = item;
                    connection.Close();
                    connection.Open();
                    MySqlCommand cmd = new MySqlCommand();
                    cmd.Connection = connection;
                    DataTable Tabla = new DataTable();
                    MySqlParameter[] oParam = {
                            new MySqlParameter("Periodo_in", Periodo),
                                      new MySqlParameter("idCliente_in", IdCliente)};
                    string proceso = "FacturacionAnualPorPeriodos";
                    MySqlDataAdapter dt = new MySqlDataAdapter(proceso, connection);
                    dt.SelectCommand.CommandType = CommandType.StoredProcedure;
                    dt.SelectCommand.Parameters.AddRange(oParam);
                    dt.Fill(Tabla);
                    if (Tabla.Rows.Count > 0)
                    {
                        foreach (DataRow item2 in Tabla.Rows)
                        {
                            FacturaCompraAnual listaFacturacion = new FacturaCompraAnual();
                            listaFacturacion.Periodo = item2["Periodo"].ToString();
                            listaFacturacion.Monto = Convert.ToDecimal(item2["MontoTotal"].ToString());
                            listaFacturacion.Total1 = Convert.ToDecimal(item2["Total1"].ToString());
                            listaFacturacion.Total2 = Convert.ToDecimal(item2["Total2"].ToString());
                            listaFacturacion.Total3 = Convert.ToDecimal(item2["Total3"].ToString());
                            listaFacturacion.Neto1 = Convert.ToDecimal(item2["Neto1"].ToString());
                            listaFacturacion.Neto2 = Convert.ToDecimal(item2["Neto2"].ToString());
                            listaFacturacion.Neto3 = Convert.ToDecimal(item2["Neto3"].ToString());
                            listaFacturacion.Iva1 = Convert.ToDecimal(item2["Iva1"].ToString());
                            listaFacturacion.Iva2 = Convert.ToDecimal(item2["Iva2"].ToString());
                            listaFacturacion.Iva3 = Convert.ToDecimal(item2["Iva3"].ToString());
                            lista.Add(listaFacturacion);
                        }
                    }
                }
            }
            connection.Close();
            return lista;
        }
        private static List<string> BuscarPeriodosComprasPorAñoIdCliente(int idCliente, string año)
        {
            List<string> listaPeriodos = new List<string>();
            connection.Close();
            connection.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = connection;
            DataTable Tabla = new DataTable();
            MySqlParameter[] oParam = {
                            new MySqlParameter("Ano_in", año),
                                      new MySqlParameter("idCliente_in", idCliente)};
            string proceso = "BuscarPeriodosComprasPorAñoIdCliente";
            MySqlDataAdapter dt = new MySqlDataAdapter(proceso, connection);
            dt.SelectCommand.CommandType = CommandType.StoredProcedure;
            dt.SelectCommand.Parameters.AddRange(oParam);
            dt.Fill(Tabla);
            if (Tabla.Rows.Count > 0)
            {
                foreach (DataRow item in Tabla.Rows)
                {
                    listaPeriodos.Add(item["Nombre"].ToString());
                }
            }
            connection.Close();
            return listaPeriodos;
        }
        public static List<FacturaVentaAnual> FacturacionAnualVentasPorAño(string cuit, string año)
        {
            List<string> listaPeriodos = new List<string>();
            List<FacturaVentaAnual> lista = new List<FacturaVentaAnual>();
            List<Entidades.Cliente> id = new List<Cliente>();
            id = ClienteDao.BuscarClientePorCuit(cuit);
            int IdCliente = id[0].IdCliente;
            if (IdCliente > 0)
            {
                listaPeriodos = BuscarPeriodosPorAñoIdCliente(IdCliente, año);
                foreach (var item in listaPeriodos)
                {
                    string Periodo = item;
                    connection.Close();
                    connection.Open();
                    MySqlCommand cmd = new MySqlCommand();
                    cmd.Connection = connection;
                    DataTable Tabla = new DataTable();
                    MySqlParameter[] oParam = {
                            new MySqlParameter("Periodo_in", Periodo),
                                      new MySqlParameter("idCliente_in", IdCliente)};
                    string proceso = "FacturacionAnualVentasDetallePorPeriodo";
                    MySqlDataAdapter dt = new MySqlDataAdapter(proceso, connection);
                    dt.SelectCommand.CommandType = CommandType.StoredProcedure;
                    dt.SelectCommand.Parameters.AddRange(oParam);
                    dt.Fill(Tabla);
                    if (Tabla.Rows.Count > 0)
                    {
                        foreach (DataRow item2 in Tabla.Rows)
                        {
                            FacturaVentaAnual listaFacturacion = new FacturaVentaAnual();
                            listaFacturacion.Periodo = item2["Periodo"].ToString();
                            listaFacturacion.Monto = Convert.ToDecimal(item2["MontoTotal"].ToString());
                            listaFacturacion.Total1 = Convert.ToDecimal(item2["Total1"].ToString());
                            listaFacturacion.Total2 = Convert.ToDecimal(item2["Total2"].ToString());
                            listaFacturacion.Total3 = Convert.ToDecimal(item2["Total3"].ToString());
                            listaFacturacion.Neto1 = Convert.ToDecimal(item2["Neto1"].ToString());
                            listaFacturacion.Neto2 = Convert.ToDecimal(item2["Neto2"].ToString());
                            listaFacturacion.Neto3 = Convert.ToDecimal(item2["Neto3"].ToString());
                            listaFacturacion.Iva1 = Convert.ToDecimal(item2["Iva1"].ToString());
                            listaFacturacion.Iva2 = Convert.ToDecimal(item2["Iva2"].ToString());
                            listaFacturacion.Iva3 = Convert.ToDecimal(item2["Iva3"].ToString());
                            lista.Add(listaFacturacion);
                        }
                    }
                }
            }
            connection.Close();
            return lista;
        }
        private static List<string> BuscarPeriodosPorAñoIdCliente(int id, string año)
        {
            List<string> listaPeriodos = new List<string>();
            connection.Close();
            connection.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = connection;
            DataTable Tabla = new DataTable();
            MySqlParameter[] oParam = {
                            new MySqlParameter("Ano_in", año),
                                      new MySqlParameter("idCliente_in", id)};
            string proceso = "BuscarPeriodosPorAñoIdCliente";
            MySqlDataAdapter dt = new MySqlDataAdapter(proceso, connection);
            dt.SelectCommand.CommandType = CommandType.StoredProcedure;
            dt.SelectCommand.Parameters.AddRange(oParam);
            dt.Fill(Tabla);
            if (Tabla.Rows.Count > 0)
            {
                foreach (DataRow item in Tabla.Rows)
                {
                    listaPeriodos.Add(item["Nombre"].ToString());
                }
            }
            connection.Close();
            return listaPeriodos;
        }
        public static List<FacturaCompra> BuscarDetalleFacturaFacturaCompra(string idFactura)
        {
            List<FacturaCompra> lista = new List<FacturaCompra>();

            int idsub = Convert.ToInt32(idFactura);
            connection.Close();
            connection.Open();

            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = connection;
            DataTable Tabla = new DataTable();
            MySqlParameter[] oParam = {
                                      new MySqlParameter("idFactura_in", idFactura)};
            string proceso = "BuscarDetalleFacturaFacturaCompra";
            MySqlDataAdapter dt = new MySqlDataAdapter(proceso, connection);
            dt.SelectCommand.CommandType = CommandType.StoredProcedure;
            dt.SelectCommand.Parameters.AddRange(oParam);
            dt.Fill(Tabla);
            if (Tabla.Rows.Count > 0)
            {
                foreach (DataRow item in Tabla.Rows)
                {
                    FacturaCompra listaFacturaCompra = new FacturaCompra();
                    listaFacturaCompra.idProveedor = Convert.ToInt32(item["idProveedor"].ToString());
                    listaFacturaCompra.NroFactura = item["NroFactura"].ToString();
                    listaFacturaCompra.Fecha = item["Fecha"].ToString();
                    listaFacturaCompra.ApellidoNombre = item["NombreRazonSocial"].ToString();
                    listaFacturaCompra.Monto = Convert.ToDecimal(item["MontoTotal"].ToString());
                    listaFacturaCompra.Cuit = item["Cuit"].ToString();
                    listaFacturaCompra.Periodo = item["Periodo"].ToString();

                    //// Detalle de la factura
                    listaFacturaCompra.TipoComprobante = item["TipoComprobante"].ToString();
                    listaFacturaCompra.Total1 = Convert.ToDecimal(item["Total1"].ToString());
                    listaFacturaCompra.Total2 = Convert.ToDecimal(item["Total2"].ToString());
                    listaFacturaCompra.Total3 = Convert.ToDecimal(item["Total3"].ToString());
                    listaFacturaCompra.Neto1 = Convert.ToDecimal(item["Neto1"].ToString());
                    listaFacturaCompra.Neto2 = Convert.ToDecimal(item["Neto2"].ToString());
                    listaFacturaCompra.Neto3 = Convert.ToDecimal(item["Neto3"].ToString());
                    listaFacturaCompra.Alicuota1 = item["Alicuota1"].ToString();
                    listaFacturaCompra.Alicuota2 = item["Alicuota2"].ToString();
                    listaFacturaCompra.Alicuota3 = item["Alicuota3"].ToString();
                    listaFacturaCompra.Iva1 = Convert.ToDecimal(item["Iva1"].ToString());
                    listaFacturaCompra.Iva2 = Convert.ToDecimal(item["Iva2"].ToString());
                    listaFacturaCompra.Iva3 = Convert.ToDecimal(item["Iva3"].ToString());

                    listaFacturaCompra.PercepIngBrutos = Convert.ToDecimal(item["PercepcionIngresosBrutos"].ToString());
                    listaFacturaCompra.PercepIva = Convert.ToDecimal(item["PercepcionIva"].ToString());
                    listaFacturaCompra.NoGravado = Convert.ToDecimal(item["NoGravado"].ToString());

                    listaFacturaCompra.CodigoMoneda = item["CodigoMoneda"].ToString();
                    listaFacturaCompra.TipoDeCambio = item["TipoDeCambio"].ToString();
                    listaFacturaCompra.CodigoTipoOperacion = item["CodigoOperacion"].ToString();
                    lista.Add(listaFacturaCompra);
                }
            }
            connection.Close();
            //}
            return lista;
        }
        public static bool ValidarFacturaProveedorYaExistente(FacturaCompra _factura)
        {
            connection.Close();
            bool Existe = false;
            connection.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = connection;
            DataTable Tabla = new DataTable();
            MySqlParameter[] oParam = {
                                                 new MySqlParameter("NroFactura_in", _factura.NroFactura),
              new MySqlParameter("idProveedor_in", _factura.idProveedor)};
            string proceso = "ValidarFacturaProveedorYaExistente";
            MySqlDataAdapter dt = new MySqlDataAdapter(proceso, connection);
            dt.SelectCommand.CommandType = CommandType.StoredProcedure;
            dt.SelectCommand.Parameters.AddRange(oParam);
            dt.Fill(Tabla);
            DataSet ds = new DataSet();
            dt.Fill(ds, "tComprasFacturas");
            if (Tabla.Rows.Count > 0)
            {
                Existe = true;
            }
            connection.Close();
            return Existe;
        }
        public static bool GuardarEdicionFacturaCompras(FacturaCompra _factura, string cuit, string idFactura)
        {
            int Idsub = Convert.ToInt32(idFactura);
            bool exito = false;
            connection.Close();
            connection.Open();
            string Actualizar = "GuardarEdicionFacturaCompras";
            MySqlCommand cmd = new MySqlCommand(Actualizar, connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("Fecha_in", _factura.Fecha);
            cmd.Parameters.AddWithValue("Monto_in", _factura.Monto);
            cmd.Parameters.AddWithValue("Idsub_in", Idsub);
            cmd.Parameters.AddWithValue("Periodo_in", _factura.Periodo);
            cmd.ExecuteNonQuery();
            exito = EditarDetalleFacturaCompra(_factura, Idsub);

            exito = true;
            connection.Close();
            return exito;
        }
        private static bool EditarDetalleFacturaCompra(FacturaCompra _factura, int idsub)
        {
            bool exito = false;
            connection.Close();
            connection.Open();
            string Actualizar = "EditarDetalleFacturaCompra";
            MySqlCommand cmd = new MySqlCommand(Actualizar, connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("TipoComprobante_in", _factura.TipoComprobante);
            cmd.Parameters.AddWithValue("Total1_in", _factura.Total1);
            cmd.Parameters.AddWithValue("Total2_in", _factura.Total2);
            cmd.Parameters.AddWithValue("Total3_in", _factura.Total3);
            cmd.Parameters.AddWithValue("Neto1_in", _factura.Neto1);
            cmd.Parameters.AddWithValue("Neto2_in", _factura.Neto2);
            cmd.Parameters.AddWithValue("Neto3_in", _factura.Neto3);
            cmd.Parameters.AddWithValue("Alicuota1_in", _factura.Alicuota1);
            cmd.Parameters.AddWithValue("Alicuota2_in", _factura.Alicuota2);
            cmd.Parameters.AddWithValue("Alicuota3_in", _factura.Alicuota3);
            cmd.Parameters.AddWithValue("Iva1_in", _factura.Iva1);
            cmd.Parameters.AddWithValue("Iva2_in", _factura.Iva2);
            cmd.Parameters.AddWithValue("Iva3_in", _factura.Iva3);
            cmd.Parameters.AddWithValue("PercepIngBrutos_in", _factura.PercepIngBrutos);
            cmd.Parameters.AddWithValue("PercepIva_in", _factura.PercepIva);
            cmd.Parameters.AddWithValue("NoGravado_in", _factura.NoGravado);
            cmd.Parameters.AddWithValue("CodigoMoneda_in", _factura.CodigoMoneda);
            cmd.Parameters.AddWithValue("TipoDeCambio_in", _factura.TipoDeCambio);
            cmd.Parameters.AddWithValue("CodigoTipoOperacion_in", _factura.CodigoTipoOperacion);
            cmd.Parameters.AddWithValue("idFactura_in", idsub);
            cmd.ExecuteNonQuery();
            exito = true;
            connection.Close();
            return exito;
        }
        public static List<FacturaCompra> BuscarCompraPorProveedor(string RazonSocial)
        {
            List<FacturaCompra> lista = new List<FacturaCompra>();
            List<Proveedor> id = new List<Proveedor>();
            id = BuscarProveedorPorRazonSocial(RazonSocial);
            int idProveedor = id[0].IdProveedor;
            if (idProveedor > 0)
            {
                connection.Close();
                connection.Open();

                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = connection;
                DataTable Tabla = new DataTable();
                MySqlParameter[] oParam = {
                                            new MySqlParameter("Proveedor_in", idProveedor)};
                string proceso = "BuscarCompraPorProveedor";
                MySqlDataAdapter dt = new MySqlDataAdapter(proceso, connection);
                dt.SelectCommand.CommandType = CommandType.StoredProcedure;
                dt.SelectCommand.Parameters.AddRange(oParam);
                dt.Fill(Tabla);
                if (Tabla.Rows.Count > 0)
                {
                    foreach (DataRow item in Tabla.Rows)
                    {
                        FacturaCompra listaFacturasCompras = new FacturaCompra();
                        listaFacturasCompras.idFactura = Convert.ToInt32(item["idFactura"].ToString());
                        listaFacturasCompras.NroFactura = item["NroFactura"].ToString();
                        listaFacturasCompras.Fecha = item["Fecha"].ToString();
                        listaFacturasCompras.Monto = Convert.ToDecimal(item["MontoTotal"].ToString());
                        listaFacturasCompras.NombreProveedor = item["NombreRazonSocial"].ToString();
                        //// Detalle de la factura
                        listaFacturasCompras.TipoComprobante = item["TipoComprobante"].ToString();
                        listaFacturasCompras.Total1 = Convert.ToDecimal(item["Total1"].ToString());
                        listaFacturasCompras.Total2 = Convert.ToDecimal(item["Total2"].ToString());
                        listaFacturasCompras.Total3 = Convert.ToDecimal(item["Total3"].ToString());
                        listaFacturasCompras.Neto1 = Convert.ToDecimal(item["Neto1"].ToString());
                        listaFacturasCompras.Neto2 = Convert.ToDecimal(item["Neto2"].ToString());
                        listaFacturasCompras.Neto3 = Convert.ToDecimal(item["Neto3"].ToString());
                        listaFacturasCompras.Alicuota1 = item["Alicuota1"].ToString();
                        listaFacturasCompras.Alicuota2 = item["Alicuota2"].ToString();
                        listaFacturasCompras.Alicuota3 = item["Alicuota3"].ToString();
                        listaFacturasCompras.Iva1 = Convert.ToDecimal(item["Iva1"].ToString());
                        listaFacturasCompras.Iva2 = Convert.ToDecimal(item["Iva2"].ToString());
                        listaFacturasCompras.Iva3 = Convert.ToDecimal(item["Iva3"].ToString());
                        listaFacturasCompras.PercepIngBrutos = Convert.ToDecimal(item["PercepcionIngresosBrutos"].ToString());
                        listaFacturasCompras.PercepIva = Convert.ToDecimal(item["PercepcionIva"].ToString());
                        listaFacturasCompras.NoGravado = Convert.ToDecimal(item["NoGravado"].ToString());
                        listaFacturasCompras.CodigoMoneda = item["CodigoMoneda"].ToString();
                        listaFacturasCompras.TipoDeCambio = item["TipoDeCambio"].ToString();
                        listaFacturasCompras.CodigoTipoOperacion = item["CodigoOperacion"].ToString();
                        lista.Add(listaFacturasCompras);
                    }
                }
                connection.Close();
            }
            return lista;
        }
        public static List<FacturaCompra> BuscarFacturacionTotalCompras(string cuit, string Periodo)
        {
            List<FacturaCompra> lista = new List<FacturaCompra>();
            List<Entidades.Cliente> id = new List<Cliente>();
            id = ClienteDao.BuscarClientePorCuit(cuit);
            int IdCliente = id[0].IdCliente;
            if (IdCliente > 0)
            {
                connection.Close();
                connection.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = connection;
                DataTable Tabla = new DataTable();
                MySqlParameter[] oParam = {
                            new MySqlParameter("Periodo_in", Periodo),
                                      new MySqlParameter("IdCliente_in", IdCliente)};
                string proceso = "BuscarFacturacionTotalComprasPorPeriodo";
                MySqlDataAdapter dt = new MySqlDataAdapter(proceso, connection);
                dt.SelectCommand.CommandType = CommandType.StoredProcedure;
                dt.SelectCommand.Parameters.AddRange(oParam);
                dt.Fill(Tabla);
                if (Tabla.Rows.Count > 0)
                {
                    foreach (DataRow item in Tabla.Rows)
                    {
                        FacturaCompra listaFacturaCompra = new FacturaCompra();
                        listaFacturaCompra.idProveedor = Convert.ToInt32(item["idProveedor"].ToString());
                        listaFacturaCompra.NroFactura = item["NroFactura"].ToString();
                        listaFacturaCompra.Fecha = item["Fecha"].ToString();
                        listaFacturaCompra.ApellidoNombre = item["NombreRazonSocial"].ToString();
                        listaFacturaCompra.Monto = Convert.ToDecimal(item["MontoTotal"].ToString());
                        listaFacturaCompra.Cuit = item["Cuit"].ToString();
                        // Detalle de la factura
                        listaFacturaCompra.TipoComprobante = item["TipoComprobante"].ToString();
                        listaFacturaCompra.Total1 = Convert.ToDecimal(item["Total1"].ToString());
                        listaFacturaCompra.Total2 = Convert.ToDecimal(item["Total2"].ToString());
                        listaFacturaCompra.Total3 = Convert.ToDecimal(item["Total3"].ToString());
                        listaFacturaCompra.Neto1 = Convert.ToDecimal(item["Neto1"].ToString());
                        listaFacturaCompra.Neto2 = Convert.ToDecimal(item["Neto2"].ToString());
                        listaFacturaCompra.Neto3 = Convert.ToDecimal(item["Neto3"].ToString());
                        listaFacturaCompra.Alicuota1 = item["Alicuota1"].ToString();
                        listaFacturaCompra.Alicuota2 = item["Alicuota2"].ToString();
                        listaFacturaCompra.Alicuota3 = item["Alicuota3"].ToString();
                        listaFacturaCompra.Iva1 = Convert.ToDecimal(item["Iva1"].ToString());
                        listaFacturaCompra.Iva2 = Convert.ToDecimal(item["Iva2"].ToString());
                        listaFacturaCompra.Iva3 = Convert.ToDecimal(item["Iva3"].ToString());

                        listaFacturaCompra.PercepIngBrutos = Convert.ToDecimal(item["PercepcionIngresosBrutos"].ToString());
                        listaFacturaCompra.PercepIva = Convert.ToDecimal(item["PercepcionIva"].ToString());
                        listaFacturaCompra.NoGravado = Convert.ToDecimal(item["NoGravado"].ToString());

                        listaFacturaCompra.CodigoMoneda = item["CodigoMoneda"].ToString();
                        listaFacturaCompra.TipoDeCambio = item["TipoDeCambio"].ToString();
                        listaFacturaCompra.CodigoTipoOperacion = item["CodigoOperacion"].ToString();
                        lista.Add(listaFacturaCompra);
                    }
                }
            }
            connection.Close();
            return lista;
        }
        public static List<Proveedor> BuscarProveedorPorRazonSocial(string RazonSocial)
        {
            connection.Close();
            connection.Open();
            List<Proveedor> lista = new List<Proveedor>();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = connection;
            DataTable Tabla = new DataTable();
            MySqlParameter[] oParam = {
                                      new MySqlParameter("NombreRazonSocial_in", RazonSocial)};
            string proceso = "BuscarProveedorPorNombreRazonSocial";
            MySqlDataAdapter dt = new MySqlDataAdapter(proceso, connection);
            dt.SelectCommand.CommandType = CommandType.StoredProcedure;
            dt.SelectCommand.Parameters.AddRange(oParam);
            dt.Fill(Tabla);
            if (Tabla.Rows.Count > 0)
            {
                foreach (DataRow item in Tabla.Rows)
                {
                    Proveedor listaProveedor = new Proveedor();
                    listaProveedor.IdProveedor = Convert.ToInt32(item["idProveedor"].ToString());
                    listaProveedor.NombreRazonSocial = item["NombreRazonSocial"].ToString();
                    listaProveedor.Cuit = item["Cuit"].ToString();
                    listaProveedor.Factura = item["TipoFactura"].ToString();
                    listaProveedor.CondicionAntiAfip = item["CondicionAntiAfip"].ToString();
                    listaProveedor.Telefono = item["Telefono"].ToString();
                    listaProveedor.Email = item["Email"].ToString();
                    listaProveedor.Provincia = item["Provincia"].ToString();
                    listaProveedor.Localidad = item["Localidad"].ToString();
                    listaProveedor.Calle = item["Calle"].ToString();
                    listaProveedor.Altura = item["Altura"].ToString();
                    listaProveedor.CodigoPostal = item["CodigoPostal"].ToString();
                    lista.Add(listaProveedor);
                }
            }
            connection.Close();
            return lista;
        }
        public static int GuardarCargaMasivaCompras(List<FacturaCompra> listaStatic, string cuit, string periodo)
        {
            int CodigoRespuesta = 0;
            bool exito = false;
            int idNotaCredito = 0;
            int idUltimaFacturaCompra = 0;
            List<Entidades.Cliente> id = new List<Entidades.Cliente>();
            id = ClienteDao.BuscarClientePorCuit(cuit);
            int idCliente = id[0].IdCliente;
            foreach (var item in listaStatic)
            {
                item.idProveedor = BuscarProveedor(item.NombreProveedor);
                if (item.idProveedor == 0)
                {
                    item.idProveedor = ProveedorDao.GuardarProveedorMasivos(item.NombreProveedor, item.Cuit, item.TipoComprobante);
                }
                string var = "";
                if (item.NroFactura != null)
                {
                    var = item.NroFactura;
                    var split1 = var.Split('|')[0];
                    split1 = split1.Trim();
                    string PuntoDeVenta = split1;
                    if (PuntoDeVenta.Length < 5)
                    {
                        PuntoDeVenta = PuntoDeVenta.PadLeft(5, '0');
                    }
                    var FacturaSegundaParte = var.Split('|')[1];
                    FacturaSegundaParte = FacturaSegundaParte.Trim();
                    if (FacturaSegundaParte.Length < 8)
                    {
                        FacturaSegundaParte = FacturaSegundaParte.PadLeft(8, '0');
                    }

                    item.NroFactura = PuntoDeVenta + "-" + FacturaSegundaParte;
                }
                    connection.Close();
                connection.Open();
                string proceso = "GuardarFacturaCompra";
                MySqlCommand cmd = new MySqlCommand(proceso, connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("NroFactura_in", item.NroFactura);
                cmd.Parameters.AddWithValue("Fecha_in", item.Fecha);
                cmd.Parameters.AddWithValue("Monto_in", item.Monto);
                cmd.Parameters.AddWithValue("idCliente_in", idCliente);
                cmd.Parameters.AddWithValue("idProveedor_in", item.idProveedor);
                cmd.Parameters.AddWithValue("Periodo_in", periodo);
                MySqlDataReader r = cmd.ExecuteReader();
                while (r.Read())
                {
                    idUltimaFacturaCompra = Convert.ToInt32(r["ID"].ToString());
                }
                if (idUltimaFacturaCompra > 0)
                {
                    exito = RegistrarDetalleFacturaCompraMasiva(item, idUltimaFacturaCompra);
                }
                if (exito == true)
                {
                    CodigoRespuesta = CodigoRespuesta + 1;
                }
            }
            connection.Close();
            return CodigoRespuesta;
        }

        private static bool RegistrarDetalleFacturaCompraMasiva(FacturaCompra item, int idUltimaFacturaCompra)
        {
            bool exito = false;
            connection.Close();
            connection.Open();
            string proceso = "RegistrarDetalleFacturaCompra";
            MySqlCommand cmd = new MySqlCommand(proceso, connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("TipoComprobante_in", item.TipoComprobante);
            cmd.Parameters.AddWithValue("Total1_in", item.Total1);
            cmd.Parameters.AddWithValue("Total2_in", item.Total2);
            cmd.Parameters.AddWithValue("Total3_in", item.Total3);
            cmd.Parameters.AddWithValue("Neto1_in", item.Neto1);
            cmd.Parameters.AddWithValue("Neto2_in", item.Neto2);
            cmd.Parameters.AddWithValue("Neto3_in", item.Neto3);
            cmd.Parameters.AddWithValue("Alicuota1_in", item.Alicuota1);
            cmd.Parameters.AddWithValue("Alicuota2_in", item.Alicuota2);
            cmd.Parameters.AddWithValue("Alicuota3_in", item.Alicuota3);
            cmd.Parameters.AddWithValue("Iva1_in", item.Iva1);
            cmd.Parameters.AddWithValue("Iva2_in", item.Iva2);
            cmd.Parameters.AddWithValue("Iva3_in", item.Iva3);
            cmd.Parameters.AddWithValue("PercepIngBrutos_in", item.PercepIngBrutos);
            cmd.Parameters.AddWithValue("PercepIva_in", item.PercepIva);
            cmd.Parameters.AddWithValue("NoGravado_in", item.NoGravado);
            cmd.Parameters.AddWithValue("CodigoMoneda_in", item.CodigoMoneda);
            cmd.Parameters.AddWithValue("TipoDeCambio_in", item.TipoDeCambio);
            item.CodigoTipoOperacion = "0 - NO CORRESPONDE";
            cmd.Parameters.AddWithValue("CodigoTipoOperacion_in", item.CodigoTipoOperacion);
            cmd.Parameters.AddWithValue("idUltimaFacturaCompra_in", idUltimaFacturaCompra);
            cmd.ExecuteNonQuery();
            exito = true;
            connection.Close();
            return exito;
        }

        private static int BuscarProveedor(string nombreProveedor)
        {
            connection.Open();
            int idProveedor = 0;
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = connection;
            DataTable Tabla = new DataTable();
            MySqlParameter[] oParam = {
                                      new MySqlParameter("NombreRazonSocial_in", nombreProveedor)};
            string proceso = "BuscarProveedorPorNombreRazonSocial";
            MySqlDataAdapter dt = new MySqlDataAdapter(proceso, connection);
            dt.SelectCommand.CommandType = CommandType.StoredProcedure;
            dt.SelectCommand.Parameters.AddRange(oParam);
            dt.Fill(Tabla);
            if (Tabla.Rows.Count > 0)
            {
                foreach (DataRow item in Tabla.Rows)
                {
                    Proveedor listaProveedor = new Proveedor();
                    idProveedor = Convert.ToInt32(item["idProveedor"].ToString());
                }
            }
            connection.Close();
            return idProveedor;
        }
        public static bool GuardarFacturaCompra(FacturaCompra _factura, string cuitCliente)
        {
            bool exito = false;
            int idNotaCredito = 0;
            int idUltimaFacturaCompra = 0;

            List<Entidades.Cliente> id = new List<Entidades.Cliente>();
            id = ClienteDao.BuscarClientePorCuit(cuitCliente);
            int idCliente = id[0].IdCliente;

            connection.Close();
            connection.Open();
            string proceso = "GuardarFacturaCompra";
            MySqlCommand cmd = new MySqlCommand(proceso, connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("NroFactura_in", _factura.NroFactura);
            cmd.Parameters.AddWithValue("Fecha_in", _factura.Fecha);
            cmd.Parameters.AddWithValue("Monto_in", _factura.Monto);
            cmd.Parameters.AddWithValue("idCliente_in", idCliente);
            cmd.Parameters.AddWithValue("idProveedor_in", _factura.idProveedor);
            cmd.Parameters.AddWithValue("Periodo_in", _factura.Periodo);
            MySqlDataReader r = cmd.ExecuteReader();
            while (r.Read())
            {
                idUltimaFacturaCompra = Convert.ToInt32(r["ID"].ToString());
            }
            if (idUltimaFacturaCompra > 0)
            {
                exito = RegistrarDetalleFacturaCompra(_factura, idUltimaFacturaCompra);
            }
            connection.Close();
            return exito;
        }
        private static bool RegistrarDetalleFacturaCompra(FacturaCompra _factura, int idUltimaFacturaCompra)
        {
            bool exito = false;
            connection.Close();
            connection.Open();
            string proceso = "RegistrarDetalleFacturaCompra";
            MySqlCommand cmd = new MySqlCommand(proceso, connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("TipoComprobante_in", _factura.TipoComprobante);
            cmd.Parameters.AddWithValue("Total1_in", _factura.Total1);
            cmd.Parameters.AddWithValue("Total2_in", _factura.Total2);
            cmd.Parameters.AddWithValue("Total3_in", _factura.Total3);
            cmd.Parameters.AddWithValue("Neto1_in", _factura.Neto1);
            cmd.Parameters.AddWithValue("Neto2_in", _factura.Neto2);
            cmd.Parameters.AddWithValue("Neto3_in", _factura.Neto3);
            cmd.Parameters.AddWithValue("Alicuota1_in", _factura.Alicuota1);
            cmd.Parameters.AddWithValue("Alicuota2_in", _factura.Alicuota2);
            cmd.Parameters.AddWithValue("Alicuota3_in", _factura.Alicuota3);
            cmd.Parameters.AddWithValue("Iva1_in", _factura.Iva1);
            cmd.Parameters.AddWithValue("Iva2_in", _factura.Iva2);
            cmd.Parameters.AddWithValue("Iva3_in", _factura.Iva3);
            cmd.Parameters.AddWithValue("PercepIngBrutos_in", _factura.PercepIngBrutos);
            cmd.Parameters.AddWithValue("PercepIva_in", _factura.PercepIva);
            cmd.Parameters.AddWithValue("NoGravado_in", _factura.NoGravado);
            cmd.Parameters.AddWithValue("CodigoMoneda_in", _factura.CodigoMoneda);
            cmd.Parameters.AddWithValue("TipoDeCambio_in", _factura.TipoDeCambio);
            cmd.Parameters.AddWithValue("CodigoTipoOperacion_in", _factura.CodigoTipoOperacion);
            cmd.Parameters.AddWithValue("idUltimaFacturaCompra_in", idUltimaFacturaCompra);
            cmd.ExecuteNonQuery();
            exito = true;
            connection.Close();
            return exito;
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
