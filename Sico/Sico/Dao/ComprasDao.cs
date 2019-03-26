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

        public static bool GuardarFacturaCompra(FacturaCompra _factura)
        {
            bool exito = false;
            int idNotaCredito = 0;
            int idUltimaFacturaCompra = 0;
            connection.Close();
            connection.Open();
            string proceso = "GuardarFacturaCompra";
            MySqlCommand cmd = new MySqlCommand(proceso, connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("NroFactura_in", _factura.NroFactura);
            cmd.Parameters.AddWithValue("Fecha_in", _factura.Fecha);
            cmd.Parameters.AddWithValue("Monto_in", _factura.Monto);
            cmd.Parameters.AddWithValue("idCliente_in", _factura.idCliente);
            cmd.Parameters.AddWithValue("idProveedor_in", _factura.idProveedor);
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
            cmd.Parameters.AddWithValue("Total3_in", _factura.Neto1);
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
