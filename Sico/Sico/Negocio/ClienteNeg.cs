﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sico.Entidades;
using System.Windows.Forms;
using Sico.Dao;

namespace Sico.Negocio
{
    public class ClienteNeg
    {
        public static List<string> CargarComboProvincia()
        {
            List<string> lista = new List<string>();
            lista = Dao.ClienteDao.CargarComboProvincia();
            return lista;
        }
        public static List<string> CargarComboLocalidades()
        {
            List<string> lista = new List<string>();
            lista = Dao.ClienteDao.CargarComboLocalidades();
            return lista;
        }
        public static bool GuardarNuevoSubCliente(SubCliente _subCliente, string cuit)
        {
            bool exito = false;
            try
            {
                ValidarDatosSubCliente(_subCliente);
                exito = ClienteDao.GuardarNuevoSubCliente(_subCliente, cuit);
            }
            catch (Exception ex)
            {

            }
            return exito;
        }

        public static bool GuardarVencimiento(string año, int idTipoVencimiento, string diaVencimiento)
        {
            bool exito = false;
            try
            {
                ValidarDatosTipoVencimiento(diaVencimiento);
                bool YaExiste = ClienteDao.ValidarVencimientoExistente(año, idTipoVencimiento);
                if (YaExiste == true)
                {
                    const string message = "Ya existe un Vencimiento Para el año y Tipo de vencimiento seleccionado.";
                    const string caption = "Error";
                    var result = MessageBox.Show(message, caption,
                                                 MessageBoxButtons.OK,
                                               MessageBoxIcon.Exclamation);
                    throw new Exception();
                }
                else
                {
                    exito = ClienteDao.GuardarVencimiento(año, idTipoVencimiento, diaVencimiento);
                }
            }
            catch (Exception ex)
            {

            }
            return exito;
        }
        private static void ValidarDatosTipoVencimiento(string diaVencimiento)
        {
            int ValorCargado = Convert.ToInt32(diaVencimiento);
            if (ValorCargado <= 0 || ValorCargado > 31)
            {
                const string message = "El campo Dia de vencimiento debe ser mayor a 0 y Menor a 31";
                const string caption = "Error";
                var result = MessageBox.Show(message, caption,
                                             MessageBoxButtons.OK,
                                           MessageBoxIcon.Exclamation);
                throw new Exception();
            }
        }
        public static List<string> CargarComboTipoVencimientos()
        {
            List<string> lista = new List<string>();
            lista = Dao.ClienteDao.CargarComboTipoVencimientos();
            return lista;
        }

        public static string BuscarNroFactura(string cuit)
        {
            int idCliente = ClienteDao.BuscarIdClientePorCuit(cuit);
            string NroFactura = ClienteDao.BuscarNroFactura(idCliente);
            return NroFactura;
        }

        public static List<SubCliente> BuscarDetalleFacturaSubCliente(string idsubCliente)
        {
            List<SubCliente> _listaSubClientes = new List<SubCliente>();
            try
            {
                _listaSubClientes = ClienteDao.BuscarDetalleFacturaSubCliente(idsubCliente);
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
            return _listaSubClientes;
        }

        public static bool GuardarNotaDeCredito(SubCliente _subCliente, string cuit)
        {
            bool exito = false;
            try
            {
                ValidarDatosFactura(_subCliente);
                exito = ClienteDao.GuardarNotaDeCredito(_subCliente, cuit);
            }
            catch (Exception ex)
            {

            }
            return exito;
        }
        public static bool EditarSubCliente(SubCliente _subCliente, string cuit)
        {
            bool exito = false;
            try
            {
                ValidarDatosSubCliente(_subCliente);
                exito = ClienteDao.EditarSubCliente(_subCliente, cuit);
            }
            catch (Exception ex)
            {

            }
            return exito;
        }

        private static void ValidarDatosSubCliente(SubCliente _subCliente)
        {
            if (String.IsNullOrEmpty(_subCliente.Dni))
            {
                const string message = "El campo Dni es obligatorio.";
                const string caption = "Error";
                var result = MessageBox.Show(message, caption,
                                             MessageBoxButtons.OK,
                                           MessageBoxIcon.Exclamation);
                throw new Exception();
            }
            if (String.IsNullOrEmpty(_subCliente.ApellidoNombre))
            {
                const string message = "El campo Persona es obligatorio.";
                const string caption = "Error";
                var result = MessageBox.Show(message, caption,
                                             MessageBoxButtons.OK,
                                           MessageBoxIcon.Exclamation);
                throw new Exception();
            }

            if (String.IsNullOrEmpty(_subCliente.Direccion))
            {
                const string message = "El campo dirección es obligatorio.";
                const string caption = "Error";
                var result = MessageBox.Show(message, caption,
                                             MessageBoxButtons.OK,
                                           MessageBoxIcon.Exclamation);
                throw new Exception();
            }
        }

        public static List<SubCliente> BuscarFacturacionTotalVentas(string cuit, string Periodo)
        {
            List<SubCliente> _listaFacturasSubCliente = new List<SubCliente>();
            try
            {
                _listaFacturasSubCliente = ClienteDao.BuscarFacturacionTotalVentas(cuit, Periodo);
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

        public static List<string> CargarComboLocalidadesPorIdProvincia(int idProvinciaSeleccionada)
        {
            List<string> lista = new List<string>();
            lista = Dao.ClienteDao.CargarComboLocalidadesPorIdProvincia(idProvinciaSeleccionada);
            return lista;
        }

        public static List<SubCliente> BuscarTodasFacturasSubCliente(string cuit)
        {
            List<SubCliente> _listaFacturasSubCliente = new List<SubCliente>();
            try
            {
                _listaFacturasSubCliente = ClienteDao.BuscarTodasFacturasSubCliente(cuit);
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

        public static string BuscarNuevoNroFacturaNotaDeCredito(string cuit)
        {
            string Factura;
            int idCliente = ClienteDao.BuscarIdClientePorCuit(cuit);
            Factura = Dao.ClienteDao.BuscarNuevoNroFacturaNotaDeCredito(idCliente);
            if (Factura == "0" || Factura == "")
            {
                Factura = "0003-00000001";
            }
            return Factura;
        }
        public static string BuscarNuevoNroFactura(string persona)
        {
            string Factura;
            Factura = Dao.ClienteDao.BuscarNuevoNroFactura(persona);
            return Factura;
        }

        public static List<string> CargarComboPersonas(string cuit)
        {
            List<string> lista = new List<string>();
            lista = Dao.ClienteDao.CargarComboPersonas(cuit);
            return lista;
        }

        public static bool GurdarCliente(Cliente _cliente)
        {
            bool exito = false;
            try
            {
                ValidarDatos(_cliente);
                bool UsuarioExistente = ValidarUsuarioExistente(_cliente.NombreRazonSocial, _cliente.Cuit);
                if (UsuarioExistente == true)
                {
                    const string message = "Ya existe un cliente registrado con el Nombre/Razón Social y Cuit ingresado.";
                    const string caption = "Error";
                    var result = MessageBox.Show(message, caption,
                                                 MessageBoxButtons.OK,
                                               MessageBoxIcon.Exclamation);
                    throw new Exception();
                }
                else
                {
                    exito = ClienteDao.InsertCliente(_cliente);
                }
            }
            catch (Exception ex)
            {

            }
            return exito;
        }
        private static bool ValidarUsuarioExistente(string nombreRazonSocial, string cuit)
        {
            bool existe = ClienteDao.ValidarClienteExistente(nombreRazonSocial, cuit);
            return existe;
        }
        private static void ValidarDatos(Cliente _cliente)
        {
            if (String.IsNullOrEmpty(_cliente.NombreRazonSocial))
            {
                const string message = "El campo Nombre/Razón Social es obligatorio.";
                const string caption = "Error";
                var result = MessageBox.Show(message, caption,
                                             MessageBoxButtons.OK,
                                           MessageBoxIcon.Exclamation);
                throw new Exception();
            }
            if (String.IsNullOrEmpty(_cliente.Cuit))
            {
                const string message = "El campo Cuit es obligatorio.";
                const string caption = "Error";
                var result = MessageBox.Show(message, caption,
                                             MessageBoxButtons.OK,
                                           MessageBoxIcon.Exclamation);
                throw new Exception();
            }
            if (String.IsNullOrEmpty(_cliente.Actividad))
            {
                const string message = "El campo Actividad es obligatorio.";
                const string caption = "Error";
                var result = MessageBox.Show(message, caption,
                                             MessageBoxButtons.OK,
                                           MessageBoxIcon.Exclamation);
                throw new Exception();
            }
            string fecha = Convert.ToString(_cliente.FechaDeInscripcion);
            if (String.IsNullOrEmpty(fecha))
            {
                const string message = "El campo fecha es obligatorio.";
                const string caption = "Error";
                var result = MessageBox.Show(message, caption,
                                             MessageBoxButtons.OK,
                                           MessageBoxIcon.Exclamation);
                throw new Exception();
            }
            if (String.IsNullOrEmpty(_cliente.CondicionAntiAfip))
            {
                const string message = "El campo condición AntiAfip es obligatorio.";
                const string caption = "Error";
                var result = MessageBox.Show(message, caption,
                                             MessageBoxButtons.OK,
                                           MessageBoxIcon.Exclamation);
                throw new Exception();
            }
        }

        public static List<SubCliente> BuscarDatosSubClientePorApellidoNombre(string apellidoNombre, string cuit)
        {
            List<SubCliente> _listaSubClientes = new List<SubCliente>();
            try
            {
                _listaSubClientes = ClienteDao.BuscarDatosSubClientePorApellidoNombre(apellidoNombre, cuit);
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
            return _listaSubClientes;
        }

        public static bool EditarCliente(Cliente _cliente)
        {
            bool exito = false;
            try
            {
                ValidarDatos(_cliente);
                exito = ClienteDao.EditarCliente(_cliente);
            }
            catch (Exception ex)
            {

            }
            return exito;
        }
        public static List<Cliente> BuscarClientePorCuit(string cuit)
        {
            List<Cliente> _listaClientes = new List<Cliente>();
            try
            {
                _listaClientes = ClienteDao.BuscarClientePorCuit(cuit);
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
            return _listaClientes;
        }
        public static List<SubCliente> BuscarSubClientePorApellidoNombre(string apellidoNombre, string cuit)
        {
            List<SubCliente> _listaSubClientes = new List<SubCliente>();
            try
            {
                _listaSubClientes = ClienteDao.BuscarSubClientePorApellidoNombreCuit(apellidoNombre, cuit);
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
            return _listaSubClientes;
        }

        public static bool GuardarFacturaSubCliente(SubCliente _subCliente, string cuit)
        {
            bool exito = false;
            try
            {
                ValidarDatosFactura(_subCliente);
                //bool FacturaExistente = ClienteDao.ValidarFacturaExistente(_subCliente.NroFactura);
                //if (FacturaExistente == true)
                //{
                //    const string message = "El Nro.Factura ingresado ya existe en la base de datos.";
                //    const string caption = "Error";
                //    var result = MessageBox.Show(message, caption,
                //                                 MessageBoxButtons.OK,
                //                               MessageBoxIcon.Exclamation);
                //    throw new Exception();
                //}
                //else
                //{
                exito = ClienteDao.GuardarFacturaSubCliente(_subCliente, cuit);
                //}
            }
            catch (Exception ex)
            {

            }
            return exito;
        }

        public static int GuardarCargaMasivaVentas(List<SubCliente> listaPrecargada, string cuit, string periodo)
        {
            int exito = 0;
            try
            {
                exito = ClienteDao.GuardarCargaMasivaVentas(listaPrecargada, cuit, periodo);
            }
            catch (Exception ex)
            {

            }
            return exito;
        }

        public static bool GuardarEdicionFacturaSubCliente(SubCliente _subCliente, string cuit, string id)
        {
            bool exito = false;
            try
            {
                ValidarDatosFactura(_subCliente);
                exito = ClienteDao.GuardarEdicionFacturaSubCliente(_subCliente, cuit, id);
            }
            catch (Exception ex)
            {

            }
            return exito;
        }
        private static void ValidarDatosFactura(SubCliente _subCliente)
        {
            if (String.IsNullOrEmpty(_subCliente.ApellidoNombre) || _subCliente.ApellidoNombre == "Seleccione")
            {
                const string message = "El campo Persona es obligatorio.";
                const string caption = "Error";
                var result = MessageBox.Show(message, caption,
                                             MessageBoxButtons.OK,
                                           MessageBoxIcon.Exclamation);
                throw new Exception();
            }
            if (String.IsNullOrEmpty(_subCliente.Periodo) || _subCliente.Periodo == "Seleccione")
            {
                const string message = "El campo Periodo es obligatorio.";
                const string caption = "Error";
                var result = MessageBox.Show(message, caption,
                                             MessageBoxButtons.OK,
                                           MessageBoxIcon.Exclamation);
                throw new Exception();
            }
        }

        public static List<Cliente> BuscarClientePorNombreRazonSocial(string nombreRazonSocial)
        {
            List<Cliente> _listaClientes = new List<Cliente>();
            try
            {
                _listaClientes = ClienteDao.BuscarClientePorNombreRazonSocial(nombreRazonSocial);
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
            return _listaClientes;
        }

        public static List<Cliente> ListarTodosLosClientes()
        {
            List<Cliente> _listaClientes = new List<Cliente>();
            try
            {
                _listaClientes = ClienteDao.ListarTodosLosClientes();
            }
            catch (Exception ex)
            {

            }
            return _listaClientes;
        }
    }
}
