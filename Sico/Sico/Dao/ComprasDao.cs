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
        public static bool GuardarEdicionFacturaCompras(FacturaCompra _factura, int idEmpresa, string idFactura)
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
                string proceso = "BuscarFacturacionTotalCompras";
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
                if (item.NroFacturaNotaDeCredtio != null)
                {
                    var = item.NroFacturaNotaDeCredtio;
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

        ///////// Consultas Para Ventas
        public static List<FacturaVentaAnual> FacturacionAnualVentasPorPeriodos(string cuit, string Periodo)
        {
            /////Facturas
            decimal ListaMontoTotal = 0;
            decimal ListaTotal1 = 0;
            decimal ListaTotal2 = 0;
            decimal ListaTotal3 = 0;
            decimal ListaNeto1 = 0;
            decimal ListaNeto2 = 0;
            decimal ListaNeto3 = 0;
            decimal ListaIva1 = 0;
            decimal ListaIva2 = 0;
            decimal ListaIva3 = 0;
            /////Notas 
            decimal NotasMontoTotal = 0;
            decimal NotasTotal1 = 0;
            decimal NotasTotal2 = 0;
            decimal NotasTotal3 = 0;
            decimal NotasNeto1 = 0;
            decimal NotasNeto2 = 0;
            decimal NotasNeto3 = 0;
            decimal NotasIva1 = 0;
            decimal NotasIva2 = 0;
            decimal NotasIva3 = 0;
            List<FacturaVentaAnual> listaFinal = new List<FacturaVentaAnual>();
            List<FacturaVentaAnual> Notaslista = new List<FacturaVentaAnual>();
            List<FacturaVentaAnual> lista = new List<FacturaVentaAnual>();
            List<Entidades.Cliente> id = new List<Cliente>();
            string PeriodoMostrar = "";
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
                        FacturaVentaAnual Facturacion = new FacturaVentaAnual();
                        PeriodoMostrar = item["Periodo"].ToString();
                        Facturacion.Monto = Convert.ToDecimal(item["MontoTotal"].ToString());
                        Facturacion.Total1 = Convert.ToDecimal(item["Total1"].ToString());
                        Facturacion.Total2 = Convert.ToDecimal(item["Total2"].ToString());
                        Facturacion.Total3 = Convert.ToDecimal(item["Total3"].ToString());
                        Facturacion.Neto1 = Convert.ToDecimal(item["Neto1"].ToString());
                        Facturacion.Neto2 = Convert.ToDecimal(item["Neto2"].ToString());
                        Facturacion.Neto3 = Convert.ToDecimal(item["Neto3"].ToString());
                        Facturacion.Iva1 = Convert.ToDecimal(item["Iva1"].ToString());
                        Facturacion.Iva2 = Convert.ToDecimal(item["Iva2"].ToString());
                        Facturacion.Iva3 = Convert.ToDecimal(item["Iva3"].ToString());
                        lista.Add(Facturacion);
                    }
                    if (lista.Count > 0)
                    {
                        var LisFacturas = lista.First();
                        ListaMontoTotal = LisFacturas.Monto;
                        ListaTotal1 = LisFacturas.Total1;
                        ListaTotal2 = LisFacturas.Total2;
                        ListaTotal3 = LisFacturas.Total3;
                        ListaNeto1 = LisFacturas.Neto1;
                        ListaNeto2 = LisFacturas.Neto2;
                        ListaNeto3 = LisFacturas.Neto3;
                        ListaIva1 = LisFacturas.Iva1;
                        ListaIva2 = LisFacturas.Iva2;
                        ListaIva3 = LisFacturas.Iva3;
                    }
                }
                connection.Close();
                connection.Open();
                MySqlCommand cmd2 = new MySqlCommand();
                cmd2.Connection = connection;
                DataTable Tabla2 = new DataTable();
                MySqlParameter[] oParam2 = {
                            new MySqlParameter("Periodo_in", Periodo),
                                      new MySqlParameter("idCliente_in", IdCliente)};
                string proceso2 = "FacturacionAnualVentasNotasDeCreditoPorPeriodos";
                MySqlDataAdapter dt2 = new MySqlDataAdapter(proceso2, connection);
                dt2.SelectCommand.CommandType = CommandType.StoredProcedure;
                dt2.SelectCommand.Parameters.AddRange(oParam2);
                dt2.Fill(Tabla2);
                if (Tabla2.Rows.Count > 0)
                {
                    foreach (DataRow item in Tabla2.Rows)
                    {
                        FacturaVentaAnual NotaslistaFacturacion = new FacturaVentaAnual();
                        NotaslistaFacturacion.Periodo = item["Periodo"].ToString();
                        NotaslistaFacturacion.Monto = Convert.ToDecimal(item["MontoTotal"].ToString());
                        NotaslistaFacturacion.Total1 = Convert.ToDecimal(item["Total1"].ToString());
                        NotaslistaFacturacion.Total2 = Convert.ToDecimal(item["Total2"].ToString());
                        NotaslistaFacturacion.Total3 = Convert.ToDecimal(item["Total3"].ToString());
                        NotaslistaFacturacion.Neto1 = Convert.ToDecimal(item["Neto1"].ToString());
                        NotaslistaFacturacion.Neto2 = Convert.ToDecimal(item["Neto2"].ToString());
                        NotaslistaFacturacion.Neto3 = Convert.ToDecimal(item["Neto3"].ToString());
                        NotaslistaFacturacion.Iva1 = Convert.ToDecimal(item["Iva1"].ToString());
                        NotaslistaFacturacion.Iva2 = Convert.ToDecimal(item["Iva2"].ToString());
                        NotaslistaFacturacion.Iva3 = Convert.ToDecimal(item["Iva3"].ToString());
                        Notaslista.Add(NotaslistaFacturacion);
                    }
                    if (Notaslista.Count > 0)
                    {
                        var LisNotas = Notaslista.First();
                        NotasMontoTotal = LisNotas.Monto;
                        NotasTotal1 = LisNotas.Total1;
                        NotasTotal2 = LisNotas.Total2;
                        NotasTotal3 = LisNotas.Total3;
                        NotasNeto1 = LisNotas.Neto1;
                        NotasNeto2 = LisNotas.Neto2;
                        NotasNeto3 = LisNotas.Neto3;
                        NotasIva1 = LisNotas.Iva1;
                        NotasIva2 = LisNotas.Iva2;
                        NotasIva3 = LisNotas.Iva3;
                    }
                }
                decimal FinalMonto = ListaMontoTotal - NotasMontoTotal;
                decimal FinalTotal1 = ListaTotal1 - NotasTotal1;
                decimal FinalTotal2 = ListaTotal2 - NotasTotal2;
                decimal FinalTotal3 = ListaTotal3 - NotasTotal3;
                decimal FinalNeto1 = ListaNeto1 - NotasNeto1;
                decimal FinalNeto2 = ListaNeto2 - NotasNeto2;
                decimal FinalNeto3 = ListaNeto3 - NotasNeto3;
                decimal FinalIva1 = ListaIva1 - NotasIva1;
                decimal FinalIva2 = ListaIva2 - NotasIva2;
                decimal FinalIva3 = ListaIva3 - NotasIva3;
                FacturaVentaAnual listaFacturacion = new FacturaVentaAnual();
                listaFacturacion.Periodo = PeriodoMostrar;
                listaFacturacion.Monto = Convert.ToDecimal(FinalMonto);
                listaFacturacion.Total1 = Convert.ToDecimal(FinalTotal1);
                listaFacturacion.Total2 = Convert.ToDecimal(FinalTotal2);
                listaFacturacion.Total3 = Convert.ToDecimal(FinalTotal3);
                listaFacturacion.Neto1 = Convert.ToDecimal(FinalNeto1);
                listaFacturacion.Neto2 = Convert.ToDecimal(FinalNeto2);
                listaFacturacion.Neto3 = Convert.ToDecimal(FinalNeto3);
                listaFacturacion.Iva1 = Convert.ToDecimal(FinalIva1);
                listaFacturacion.Iva2 = Convert.ToDecimal(FinalIva2);
                listaFacturacion.Iva3 = Convert.ToDecimal(FinalIva3);
                listaFinal.Add(listaFacturacion);
            }
            connection.Close();
            return listaFinal;
        }
        public static List<FacturaVentaAnual> FacturacionAnualVentasPorAño(string cuit, string año)
        {
            List<FacturaVentaAnual> Notaslista = new List<FacturaVentaAnual>();
            string PeriodoMostrar = "";
            List<string> listaPeriodos = new List<string>();
            List<FacturaVentaAnual> lista = new List<FacturaVentaAnual>();
            List<FacturaVentaAnual> listaFinal = new List<FacturaVentaAnual>();
            List<Entidades.Cliente> id = new List<Cliente>();
            id = ClienteDao.BuscarClientePorCuit(cuit);
            int IdCliente = id[0].IdCliente;
            if (IdCliente > 0)
            {
                listaPeriodos = BuscarPeriodosPorAñoIdCliente(IdCliente, año);
                foreach (var item in listaPeriodos)
                {
                    /////Facturas
                    decimal ListaMontoTotal = 0;
                    decimal ListaTotal1 = 0;
                    decimal ListaTotal2 = 0;
                    decimal ListaTotal3 = 0;
                    decimal ListaNeto1 = 0;
                    decimal ListaNeto2 = 0;
                    decimal ListaNeto3 = 0;
                    decimal ListaIva1 = 0;
                    decimal ListaIva2 = 0;
                    decimal ListaIva3 = 0;
                    /////Notas 
                    decimal NotasMontoTotal = 0;
                    decimal NotasTotal1 = 0;
                    decimal NotasTotal2 = 0;
                    decimal NotasTotal3 = 0;
                    decimal NotasNeto1 = 0;
                    decimal NotasNeto2 = 0;
                    decimal NotasNeto3 = 0;
                    decimal NotasIva1 = 0;
                    decimal NotasIva2 = 0;
                    decimal NotasIva3 = 0;
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
                            FacturaVentaAnual Facturacion = new FacturaVentaAnual();
                            PeriodoMostrar = item2["Periodo"].ToString();
                            Facturacion.Monto = Convert.ToDecimal(item2["MontoTotal"].ToString());
                            Facturacion.Total1 = Convert.ToDecimal(item2["Total1"].ToString());
                            Facturacion.Total2 = Convert.ToDecimal(item2["Total2"].ToString());
                            Facturacion.Total3 = Convert.ToDecimal(item2["Total3"].ToString());
                            Facturacion.Neto1 = Convert.ToDecimal(item2["Neto1"].ToString());
                            Facturacion.Neto2 = Convert.ToDecimal(item2["Neto2"].ToString());
                            Facturacion.Neto3 = Convert.ToDecimal(item2["Neto3"].ToString());
                            Facturacion.Iva1 = Convert.ToDecimal(item2["Iva1"].ToString());
                            Facturacion.Iva2 = Convert.ToDecimal(item2["Iva2"].ToString());
                            Facturacion.Iva3 = Convert.ToDecimal(item2["Iva3"].ToString());
                            lista.Clear();
                            lista.Add(Facturacion);
                        }
                        if (lista.Count > 0)
                        {
                            var LisFacturas = lista.First();
                            ListaMontoTotal = LisFacturas.Monto;
                            ListaTotal1 = LisFacturas.Total1;
                            ListaTotal2 = LisFacturas.Total2;
                            ListaTotal3 = LisFacturas.Total3;
                            ListaNeto1 = LisFacturas.Neto1;
                            ListaNeto2 = LisFacturas.Neto2;
                            ListaNeto3 = LisFacturas.Neto3;
                            ListaIva1 = LisFacturas.Iva1;
                            ListaIva2 = LisFacturas.Iva2;
                            ListaIva3 = LisFacturas.Iva3;
                        }
                    }
                    connection.Close();
                    connection.Open();
                    MySqlCommand cmd2 = new MySqlCommand();
                    cmd2.Connection = connection;
                    DataTable Tabla2 = new DataTable();
                    MySqlParameter[] oParam2 = {
                            new MySqlParameter("Periodo_in", Periodo),
                                      new MySqlParameter("idCliente_in", IdCliente)};
                    string proceso2 = "FacturacionAnualVentasNotasDeCreditoPorPeriodos";
                    MySqlDataAdapter dt2 = new MySqlDataAdapter(proceso2, connection);
                    dt2.SelectCommand.CommandType = CommandType.StoredProcedure;
                    dt2.SelectCommand.Parameters.AddRange(oParam2);
                    dt2.Fill(Tabla2);
                    if (Tabla2.Rows.Count > 0)
                    {
                        foreach (DataRow item2 in Tabla2.Rows)
                        {
                            FacturaVentaAnual NotaslistaFacturacion = new FacturaVentaAnual();
                            NotaslistaFacturacion.Periodo = item2["Periodo"].ToString();
                            NotaslistaFacturacion.Monto = Convert.ToDecimal(item2["MontoTotal"].ToString());
                            NotaslistaFacturacion.Total1 = Convert.ToDecimal(item2["Total1"].ToString());
                            NotaslistaFacturacion.Total2 = Convert.ToDecimal(item2["Total2"].ToString());
                            NotaslistaFacturacion.Total3 = Convert.ToDecimal(item2["Total3"].ToString());
                            NotaslistaFacturacion.Neto1 = Convert.ToDecimal(item2["Neto1"].ToString());
                            NotaslistaFacturacion.Neto2 = Convert.ToDecimal(item2["Neto2"].ToString());
                            NotaslistaFacturacion.Neto3 = Convert.ToDecimal(item2["Neto3"].ToString());
                            NotaslistaFacturacion.Iva1 = Convert.ToDecimal(item2["Iva1"].ToString());
                            NotaslistaFacturacion.Iva2 = Convert.ToDecimal(item2["Iva2"].ToString());
                            NotaslistaFacturacion.Iva3 = Convert.ToDecimal(item2["Iva3"].ToString());
                            Notaslista.Clear();
                            Notaslista.Add(NotaslistaFacturacion);
                        }
                        if (Notaslista.Count > 0)
                        {
                            var LisNotas = Notaslista.First();
                            NotasMontoTotal = LisNotas.Monto;
                            NotasTotal1 = LisNotas.Total1;
                            NotasTotal2 = LisNotas.Total2;
                            NotasTotal3 = LisNotas.Total3;
                            NotasNeto1 = LisNotas.Neto1;
                            NotasNeto2 = LisNotas.Neto2;
                            NotasNeto3 = LisNotas.Neto3;
                            NotasIva1 = LisNotas.Iva1;
                            NotasIva2 = LisNotas.Iva2;
                            NotasIva3 = LisNotas.Iva3;
                        }
                    }
                    decimal FinalMonto = ListaMontoTotal - NotasMontoTotal;
                    decimal FinalTotal1 = ListaTotal1 - NotasTotal1;
                    decimal FinalTotal2 = ListaTotal2 - NotasTotal2;
                    decimal FinalTotal3 = ListaTotal3 - NotasTotal3;
                    decimal FinalNeto1 = ListaNeto1 - NotasNeto1;
                    decimal FinalNeto2 = ListaNeto2 - NotasNeto2;
                    decimal FinalNeto3 = ListaNeto3 - NotasNeto3;
                    decimal FinalIva1 = ListaIva1 - NotasIva1;
                    decimal FinalIva2 = ListaIva2 - NotasIva2;
                    decimal FinalIva3 = ListaIva3 - NotasIva3;
                    FacturaVentaAnual listaFacturacion = new FacturaVentaAnual();
                    listaFacturacion.Periodo = PeriodoMostrar;
                    listaFacturacion.Monto = Convert.ToDecimal(FinalMonto);
                    listaFacturacion.Total1 = Convert.ToDecimal(FinalTotal1);
                    listaFacturacion.Total2 = Convert.ToDecimal(FinalTotal2);
                    listaFacturacion.Total3 = Convert.ToDecimal(FinalTotal3);
                    listaFacturacion.Neto1 = Convert.ToDecimal(FinalNeto1);
                    listaFacturacion.Neto2 = Convert.ToDecimal(FinalNeto2);
                    listaFacturacion.Neto3 = Convert.ToDecimal(FinalNeto3);
                    listaFacturacion.Iva1 = Convert.ToDecimal(FinalIva1);
                    listaFacturacion.Iva2 = Convert.ToDecimal(FinalIva2);
                    listaFacturacion.Iva3 = Convert.ToDecimal(FinalIva3);
                    listaFinal.Add(listaFacturacion);

                }
            }
            connection.Close();
            return listaFinal;
        }
        ///////// Consultas Para Compras
        public static List<FacturaCompraAnual> FacturacionAnualPorAño(string cuit, string año)
        {
            List<string> listaPeriodos = new List<string>();
            List<FacturaCompraAnual> lista = new List<FacturaCompraAnual>();
            List<FacturaCompraAnual> listaNotas = new List<FacturaCompraAnual>();
            List<FacturaCompraAnual> listaFinal = new List<FacturaCompraAnual>();
            string PeriodoMostrar = "";
            List<Entidades.Cliente> id = new List<Cliente>();
            id = ClienteDao.BuscarClientePorCuit(cuit);
            int IdCliente = id[0].IdCliente;
            if (IdCliente > 0)
            {
                listaPeriodos = BuscarPeriodosComprasPorAñoIdCliente(IdCliente, año);
                foreach (var item in listaPeriodos)
                {
                    ///// Facturas
                    decimal ListaMontoTotal = 0;
                    decimal ListaTotal1 = 0;
                    decimal ListaTotal2 = 0;
                    decimal ListaTotal3 = 0;
                    decimal ListaNeto1 = 0;
                    decimal ListaNeto2 = 0;
                    decimal ListaNeto3 = 0;
                    decimal ListaIva1 = 0;
                    decimal ListaIva2 = 0;
                    decimal ListaIva3 = 0;
                    decimal ListaPerIva = 0;
                    decimal ListaPerIng = 0;
                    decimal ListaNoGrav = 0;
                    decimal NotasMontoTotal = 0;
                    ///// Notas de credito
                    decimal NotasTotal1 = 0;
                    decimal NotasTotal2 = 0;
                    decimal NotasTotal3 = 0;
                    decimal NotasNeto1 = 0;
                    decimal NotasNeto2 = 0;
                    decimal NotasNeto3 = 0;
                    decimal NotasIva1 = 0;
                    decimal NotasIva2 = 0;
                    decimal NotasIva3 = 0;
                    decimal NotasPerIva = 0;
                    decimal NotasPerIng = 0;
                    decimal NotasNoGrav = 0;
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
                            FacturaCompraAnual Facturacion = new FacturaCompraAnual();
                            PeriodoMostrar = item2["Periodo"].ToString();
                            Facturacion.Periodo = item2["Periodo"].ToString();
                            Facturacion.Monto = Convert.ToDecimal(item2["MontoTotal"].ToString());
                            Facturacion.Total1 = Convert.ToDecimal(item2["Total1"].ToString());
                            Facturacion.Total2 = Convert.ToDecimal(item2["Total2"].ToString());
                            Facturacion.Total3 = Convert.ToDecimal(item2["Total3"].ToString());
                            Facturacion.Neto1 = Convert.ToDecimal(item2["Neto1"].ToString());
                            Facturacion.Neto2 = Convert.ToDecimal(item2["Neto2"].ToString());
                            Facturacion.Neto3 = Convert.ToDecimal(item2["Neto3"].ToString());
                            Facturacion.Iva1 = Convert.ToDecimal(item2["Iva1"].ToString());
                            Facturacion.Iva2 = Convert.ToDecimal(item2["Iva2"].ToString());
                            Facturacion.Iva3 = Convert.ToDecimal(item2["Iva3"].ToString());
                            Facturacion.PercepIva = Convert.ToDecimal(item2["PercepcionIva"].ToString());
                            Facturacion.PercepIngBrutos = Convert.ToDecimal(item2["PercepcionIngresosBrutos"].ToString());
                            Facturacion.NoGravado = Convert.ToDecimal(item2["NoGravado"].ToString());
                            lista.Clear();
                            lista.Add(Facturacion);
                        }
                        if (lista.Count > 0)
                        {
                            var FacLista = lista.First();
                            ListaMontoTotal = FacLista.Monto;
                            ListaTotal1 = FacLista.Total1;
                            ListaTotal2 = FacLista.Total2;
                            ListaTotal3 = FacLista.Total3;
                            ListaNeto1 = FacLista.Neto1;
                            ListaNeto2 = FacLista.Neto2;
                            ListaNeto3 = FacLista.Neto3;
                            ListaIva1 = FacLista.Iva1;
                            ListaIva2 = FacLista.Iva2;
                            ListaIva3 = FacLista.Iva3;
                            ListaPerIva = FacLista.PercepIva;
                            ListaPerIng = FacLista.PercepIngBrutos;
                            ListaNoGrav = FacLista.NoGravado;
                        }
                    }
                    connection.Close();
                    connection.Open();
                    MySqlCommand cmd2 = new MySqlCommand();
                    cmd2.Connection = connection;
                    DataTable Tabla2 = new DataTable();
                    MySqlParameter[] oParam2 = {
                            new MySqlParameter("Periodo_in", Periodo),
                                      new MySqlParameter("idCliente_in", IdCliente)};
                    string proceso2 = "FacturacionAnualNotasDeCreditoPorPeriodos";
                    MySqlDataAdapter dt2 = new MySqlDataAdapter(proceso2, connection);
                    dt2.SelectCommand.CommandType = CommandType.StoredProcedure;
                    dt2.SelectCommand.Parameters.AddRange(oParam2);
                    dt2.Fill(Tabla2);
                    if (Tabla2.Rows.Count > 0)
                    {
                        foreach (DataRow item2 in Tabla2.Rows)
                        {
                            FacturaCompraAnual listaFacturacionNotaDeCredito = new FacturaCompraAnual();
                            listaFacturacionNotaDeCredito.Periodo = item2["Periodo"].ToString();
                            listaFacturacionNotaDeCredito.Monto = Convert.ToDecimal(item2["MontoTotal"].ToString());
                            listaFacturacionNotaDeCredito.Total1 = Convert.ToDecimal(item2["Total1"].ToString());
                            listaFacturacionNotaDeCredito.Total2 = Convert.ToDecimal(item2["Total2"].ToString());
                            listaFacturacionNotaDeCredito.Total3 = Convert.ToDecimal(item2["Total3"].ToString());
                            listaFacturacionNotaDeCredito.Neto1 = Convert.ToDecimal(item2["Neto1"].ToString());
                            listaFacturacionNotaDeCredito.Neto2 = Convert.ToDecimal(item2["Neto2"].ToString());
                            listaFacturacionNotaDeCredito.Neto3 = Convert.ToDecimal(item2["Neto3"].ToString());
                            listaFacturacionNotaDeCredito.Iva1 = Convert.ToDecimal(item2["Iva1"].ToString());
                            listaFacturacionNotaDeCredito.Iva2 = Convert.ToDecimal(item2["Iva2"].ToString());
                            listaFacturacionNotaDeCredito.Iva3 = Convert.ToDecimal(item2["Iva3"].ToString());
                            listaFacturacionNotaDeCredito.PercepIva = Convert.ToDecimal(item2["PercepcionIva"].ToString());
                            listaFacturacionNotaDeCredito.PercepIngBrutos = Convert.ToDecimal(item2["PercepcionIngresosBrutos"].ToString());
                            listaFacturacionNotaDeCredito.NoGravado = Convert.ToDecimal(item2["NoGravado"].ToString());
                            listaNotas.Clear();
                            listaNotas.Add(listaFacturacionNotaDeCredito);
                        }
                        if (listaNotas.Count > 0)
                        {
                            var NotasList = listaNotas.First();
                            NotasMontoTotal = NotasList.Monto;
                            NotasTotal1 = NotasList.Total1;
                            NotasTotal2 = NotasList.Total2;
                            NotasTotal3 = NotasList.Total3;
                            NotasNeto1 = NotasList.Neto1;
                            NotasNeto2 = NotasList.Neto2;
                            NotasNeto3 = NotasList.Neto3;
                            NotasIva1 = NotasList.Iva1;
                            NotasIva2 = NotasList.Iva2;
                            NotasIva3 = NotasList.Iva3;
                            NotasPerIva = NotasList.PercepIva;
                            NotasPerIng = NotasList.PercepIngBrutos;
                            NotasNoGrav = NotasList.NoGravado;
                        }
                    }
                    decimal FinalMonto = ListaMontoTotal - NotasMontoTotal;
                    decimal FinalTotal1 = ListaTotal1 - NotasTotal1;
                    decimal FinalTotal2 = ListaTotal2 - NotasTotal2;
                    decimal FinalTotal3 = ListaTotal3 - NotasTotal3;
                    decimal FinalNeto1 = ListaNeto1 - NotasNeto1;
                    decimal FinalNeto2 = ListaNeto2 - NotasNeto2;
                    decimal FinalNeto3 = ListaNeto3 - NotasNeto3;
                    decimal FinalIva1 = ListaIva1 - NotasIva1;
                    decimal FinalIva2 = ListaIva2 - NotasIva2;
                    decimal FinalIva3 = ListaIva3 - NotasIva3;
                    decimal FinalPerIva = ListaPerIva - NotasPerIva;
                    decimal FinalPerIng = ListaPerIng - NotasPerIng;
                    decimal FinalNoGrav = ListaNoGrav - NotasNoGrav;
                    FacturaCompraAnual listaFacturacion = new FacturaCompraAnual();
                    listaFacturacion.Periodo = PeriodoMostrar;
                    listaFacturacion.Monto = Convert.ToDecimal(FinalMonto);
                    listaFacturacion.Total1 = Convert.ToDecimal(FinalTotal1);
                    listaFacturacion.Total2 = Convert.ToDecimal(FinalTotal2);
                    listaFacturacion.Total3 = Convert.ToDecimal(FinalTotal3);
                    listaFacturacion.Neto1 = Convert.ToDecimal(FinalNeto1);
                    listaFacturacion.Neto2 = Convert.ToDecimal(FinalNeto2);
                    listaFacturacion.Neto3 = Convert.ToDecimal(FinalNeto3);
                    listaFacturacion.Iva1 = Convert.ToDecimal(FinalIva1);
                    listaFacturacion.Iva2 = Convert.ToDecimal(FinalIva2);
                    listaFacturacion.Iva3 = Convert.ToDecimal(FinalIva3);
                    listaFacturacion.PercepIva = Convert.ToDecimal(FinalPerIva);
                    listaFacturacion.PercepIngBrutos = Convert.ToDecimal(FinalPerIng);
                    listaFacturacion.NoGravado = Convert.ToDecimal(FinalNoGrav);
                    listaFinal.Add(listaFacturacion);
                }
            }
            connection.Close();
            return listaFinal;
        }
        public static List<FacturaCompraAnual> FacturacionAnualPorPeriodos(string cuit, string periodo)
        {
            ///// Facturas
            decimal ListaMontoTotal = 0;
            decimal ListaTotal1 = 0;
            decimal ListaTotal2 = 0;
            decimal ListaTotal3 = 0;
            decimal ListaNeto1 = 0;
            decimal ListaNeto2 = 0;
            decimal ListaNeto3 = 0;
            decimal ListaIva1 = 0;
            decimal ListaIva2 = 0;
            decimal ListaIva3 = 0;
            decimal ListaPerIva = 0;
            decimal ListaPerIng = 0;
            decimal ListaNoGrav = 0;
            ///// Notas de Credito
            decimal NotasMontoTotal = 0;
            decimal NotasTotal1 = 0;
            decimal NotasTotal2 = 0;
            decimal NotasTotal3 = 0;
            decimal NotasNeto1 = 0;
            decimal NotasNeto2 = 0;
            decimal NotasNeto3 = 0;
            decimal NotasIva1 = 0;
            decimal NotasIva2 = 0;
            decimal NotasIva3 = 0;
            decimal NotasPerIva = 0;
            decimal NotasPerIng = 0;
            decimal NotasNoGrav = 0;
            List<FacturaCompraAnual> listaNotas = new List<FacturaCompraAnual>();
            string PeriodoMostrar = "";
            List<FacturaCompraAnual> lista = new List<FacturaCompraAnual>();
            List<FacturaCompraAnual> listaFinal = new List<FacturaCompraAnual>();
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
                        FacturaCompraAnual Facturacion = new FacturaCompraAnual();
                        Facturacion.Periodo = item["Periodo"].ToString();
                        Facturacion.Monto = Convert.ToDecimal(item["MontoTotal"].ToString());
                        Facturacion.Total1 = Convert.ToDecimal(item["Total1"].ToString());
                        Facturacion.Total2 = Convert.ToDecimal(item["Total2"].ToString());
                        Facturacion.Total3 = Convert.ToDecimal(item["Total3"].ToString());
                        Facturacion.Neto1 = Convert.ToDecimal(item["Neto1"].ToString());
                        Facturacion.Neto2 = Convert.ToDecimal(item["Neto2"].ToString());
                        Facturacion.Neto3 = Convert.ToDecimal(item["Neto3"].ToString());
                        Facturacion.Iva1 = Convert.ToDecimal(item["Iva1"].ToString());
                        Facturacion.Iva2 = Convert.ToDecimal(item["Iva2"].ToString());
                        Facturacion.Iva3 = Convert.ToDecimal(item["Iva3"].ToString());
                        Facturacion.PercepIngBrutos = Convert.ToDecimal(item["PercepcionIngresosBrutos"].ToString());
                        Facturacion.PercepIva = Convert.ToDecimal(item["PercepcionIva"].ToString());
                        Facturacion.NoGravado = Convert.ToDecimal(item["NoGravado"].ToString());
                        lista.Clear();
                        lista.Add(Facturacion);
                    }
                    if (lista.Count > 0)
                    {
                        var FacLista = lista.First();
                        ListaMontoTotal = FacLista.Monto;
                        ListaTotal1 = FacLista.Total1;
                        ListaTotal2 = FacLista.Total2;
                        ListaTotal3 = FacLista.Total3;
                        ListaNeto1 = FacLista.Neto1;
                        ListaNeto2 = FacLista.Neto2;
                        ListaNeto3 = FacLista.Neto3;
                        ListaIva1 = FacLista.Iva1;
                        ListaIva2 = FacLista.Iva2;
                        ListaIva3 = FacLista.Iva3;
                        ListaPerIva = FacLista.PercepIva;
                        ListaPerIng = FacLista.PercepIngBrutos;
                        ListaNoGrav = FacLista.NoGravado;
                    }
                }
                connection.Close();
                connection.Open();
                MySqlCommand cmd2 = new MySqlCommand();
                cmd.Connection = connection;
                DataTable Tabla2 = new DataTable();
                MySqlParameter[] oParam2 = {
                            new MySqlParameter("Periodo_in", periodo),
                                      new MySqlParameter("idCliente_in", IdCliente)};
                string proceso2 = "FacturacionAnualNotasDeCreditoPorPeriodos";
                MySqlDataAdapter dt2 = new MySqlDataAdapter(proceso2, connection);
                dt2.SelectCommand.CommandType = CommandType.StoredProcedure;
                dt2.SelectCommand.Parameters.AddRange(oParam2);
                dt2.Fill(Tabla2);
                if (Tabla2.Rows.Count > 0)
                {
                    foreach (DataRow item2 in Tabla2.Rows)
                    {
                        FacturaCompraAnual listaFacturacionNotaDeCredito = new FacturaCompraAnual();
                        listaFacturacionNotaDeCredito.Periodo = item2["Periodo"].ToString();
                        listaFacturacionNotaDeCredito.Monto = Convert.ToDecimal(item2["MontoTotal"].ToString());
                        listaFacturacionNotaDeCredito.Total1 = Convert.ToDecimal(item2["Total1"].ToString());
                        listaFacturacionNotaDeCredito.Total2 = Convert.ToDecimal(item2["Total2"].ToString());
                        listaFacturacionNotaDeCredito.Total3 = Convert.ToDecimal(item2["Total3"].ToString());
                        listaFacturacionNotaDeCredito.Neto1 = Convert.ToDecimal(item2["Neto1"].ToString());
                        listaFacturacionNotaDeCredito.Neto2 = Convert.ToDecimal(item2["Neto2"].ToString());
                        listaFacturacionNotaDeCredito.Neto3 = Convert.ToDecimal(item2["Neto3"].ToString());
                        listaFacturacionNotaDeCredito.Iva1 = Convert.ToDecimal(item2["Iva1"].ToString());
                        listaFacturacionNotaDeCredito.Iva2 = Convert.ToDecimal(item2["Iva2"].ToString());
                        listaFacturacionNotaDeCredito.Iva3 = Convert.ToDecimal(item2["Iva3"].ToString());
                        listaFacturacionNotaDeCredito.PercepIva = Convert.ToDecimal(item2["PercepcionIva"].ToString());
                        listaFacturacionNotaDeCredito.PercepIngBrutos = Convert.ToDecimal(item2["PercepcionIngresosBrutos"].ToString());
                        listaFacturacionNotaDeCredito.NoGravado = Convert.ToDecimal(item2["NoGravado"].ToString());
                        listaNotas.Clear();
                        listaNotas.Add(listaFacturacionNotaDeCredito);
                    }
                    if (listaNotas.Count > 0)
                    {
                        var NotaLista = listaNotas.First();
                        NotasMontoTotal = NotaLista.Monto;
                        NotasTotal1 = NotaLista.Total1;
                        NotasTotal2 = NotaLista.Total2;
                        NotasTotal3 = NotaLista.Total3;
                        NotasNeto1 = NotaLista.Neto1;
                        NotasNeto2 = NotaLista.Neto2;
                        NotasNeto3 = NotaLista.Neto3;
                        NotasIva1 = NotaLista.Iva1;
                        NotasIva2 = NotaLista.Iva2;
                        NotasIva3 = NotaLista.Iva3;
                        NotasPerIva = NotaLista.PercepIva;
                        NotasPerIng = NotaLista.PercepIngBrutos;
                        NotasNoGrav = NotaLista.NoGravado;
                    }
                }
                decimal FinalMonto = ListaMontoTotal - NotasMontoTotal;
                decimal FinalTotal1 = ListaTotal1 - NotasTotal1;
                decimal FinalTotal2 = ListaTotal2 - NotasTotal2;
                decimal FinalTotal3 = ListaTotal3 - NotasTotal3;
                decimal FinalNeto1 = ListaNeto1 - NotasNeto1;
                decimal FinalNeto2 = ListaNeto2 - NotasNeto2;
                decimal FinalNeto3 = ListaNeto3 - NotasNeto3;
                decimal FinalIva1 = ListaIva1 - NotasIva1;
                decimal FinalIva2 = ListaIva2 - NotasIva2;
                decimal FinalIva3 = ListaIva3 - NotasIva3;
                decimal FinalPerIva = ListaPerIva - NotasPerIva;
                decimal FinalPerIng = ListaPerIng - NotasPerIng;
                decimal FinalNoGrav = ListaNoGrav - NotasNoGrav;
                FacturaCompraAnual listaFacturacion = new FacturaCompraAnual();
                listaFacturacion.Periodo = PeriodoMostrar;
                listaFacturacion.Monto = Convert.ToDecimal(FinalMonto);
                listaFacturacion.Total1 = Convert.ToDecimal(FinalTotal1);
                listaFacturacion.Total2 = Convert.ToDecimal(FinalTotal2);
                listaFacturacion.Total3 = Convert.ToDecimal(FinalTotal3);
                listaFacturacion.Neto1 = Convert.ToDecimal(FinalNeto1);
                listaFacturacion.Neto2 = Convert.ToDecimal(FinalNeto2);
                listaFacturacion.Neto3 = Convert.ToDecimal(FinalNeto3);
                listaFacturacion.Iva1 = Convert.ToDecimal(FinalIva1);
                listaFacturacion.Iva2 = Convert.ToDecimal(FinalIva2);
                listaFacturacion.Iva3 = Convert.ToDecimal(FinalIva3);
                listaFacturacion.PercepIva = Convert.ToDecimal(FinalPerIva);
                listaFacturacion.PercepIngBrutos = Convert.ToDecimal(FinalPerIng);
                listaFacturacion.NoGravado = Convert.ToDecimal(FinalNoGrav);
                listaFinal.Add(listaFacturacion);
            }
            connection.Close();
            return listaFinal;
        }
    }
}

