﻿using Sico.Dao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sico.Entidades;
using System.Windows.Forms;

namespace Sico.Negocio
{
    public class ComprasNeg
    {
        public static List<string> CargarComboTipoComprobante()
        {
            List<string> lista = new List<string>();
            lista = ComprasDao.CargarComboTipoComprobante();
            return lista;
        }

        public static List<string> CargarComboCodigoOperacion()
        {
            List<string> lista = new List<string>();
            lista = ComprasDao.CargarComboCodigoOperacion();
            return lista;
        }

        public static List<string> CargarComboTipoMoneda()
        {
            List<string> lista = new List<string>();
            lista = ComprasDao.CargarComboTipoMoneda();
            return lista;
        }

        public static List<FacturaCompra> BuscarTodasFacturasDeComprasDelCliente(string cuit)
        {
            List<FacturaCompra> _listaFacturasCompras = new List<FacturaCompra>();
            try
            {
                _listaFacturasCompras = ComprasDao.BuscarTodasFacturasDeComprasDelCliente(cuit);
            }
            catch (Exception ex)
            {
                const string message = "Error en el sistema. Intente nuevamente o comuniquese con el administrador.";
                const string caption = "Atención";
                var result = MessageBox.Show(message, caption,
                                             MessageBoxButtons.OK,
                                           MessageBoxIcon.Warning);
                throw new Exception();
            }
            return _listaFacturasCompras;
        }

        public static List<FacturaCompra> BuscarDetalleFacturaFacturaCompra(string idFactura)
        {
            List<FacturaCompra> _listaFacturasCompras = new List<FacturaCompra>();
            try
            {
                _listaFacturasCompras = ComprasDao.BuscarDetalleFacturaFacturaCompra(idFactura);
            }
            catch (Exception ex)
            {
                const string message = "Error en el sistema. Intente nuevamente o comuniquese con el administrador.";
                const string caption = "Atención";
                var result = MessageBox.Show(message, caption,
                                             MessageBoxButtons.OK,
                                           MessageBoxIcon.Warning);
                throw new Exception();
            }
            return _listaFacturasCompras;
        }

        public static List<FacturaCompra> BuscarDatosProveedor()
        {
            throw new NotImplementedException();
        }

        public static bool GuardarFacturaCompra(FacturaCompra _factura, string cuitCliente)
        {
            bool exito = false;
            try
            {
                ValidarDatosFactura(_factura);
                exito = ComprasDao.GuardarFacturaCompra(_factura, cuitCliente);
            }
            catch (Exception ex)
            {

            }
            return exito;
        }

        private static void ValidarDatosFactura(FacturaCompra _factura)
        {

        }

        public static List<FacturaCompra> BuscarCompraPorProveedor(string apellidoNombre)
        {
            List<FacturaCompra> _listaCompras = new List<FacturaCompra>();
            try
            {
                _listaCompras = ComprasDao.BuscarCompraPorProveedor(apellidoNombre);
            }
            catch (Exception ex)
            {
                const string message = "Error en el sistema. Intente nuevamente o comuniquese con el administrador.";
                const string caption = "Atención";
                var result = MessageBox.Show(message, caption,
                                             MessageBoxButtons.OK,
                                           MessageBoxIcon.Warning);
                throw new Exception();
            }
            return _listaCompras;
        }

        public static List<FacturaCompra> BuscarFacturacionTotal(string cuit, int mes, string año)
        {
            List<FacturaCompra> _listaFacturasSubCliente = new List<FacturaCompra>();
            try
            {
                _listaFacturasSubCliente = ComprasDao.BuscarFacturacionTotal(cuit, mes, año);
            }
            catch (Exception ex)
            {
                const string message = "Error en el sistema. Intente nuevamente o comuniquese con el administrador.";
                const string caption = "Atención";
                var result = MessageBox.Show(message, caption,
                                             MessageBoxButtons.OK,
                                           MessageBoxIcon.Warning);
                throw new Exception();
            }
            return _listaFacturasSubCliente;
        }

        public static bool GuardarEdicionFacturaCompras(FacturaCompra _factura, string cuit, string idFactura)
        {
            bool exito = false;
            try
            {
                //ValidarDatosFactura(_subCliente);
                exito = ComprasDao.GuardarEdicionFacturaCompras(_factura, cuit, idFactura);
            }
            catch (Exception ex)
            {

            }
            return exito;
        }
    }
}