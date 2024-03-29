﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sico.Entidades
{
    public class SubCliente
    {
        public int idSubCliente { get; set; }
        public string NroFactura { get; set; }
        public string Fecha { get; set; }
        public string ApellidoNombre { get; set; }
        public string Dni { get; set; }
        public string Direccion { get; set; }
        public Decimal Monto { get; set; }
        public int idCliente { get; set; }
        public string  NombreCliente { get; set; }
        public decimal Total1 { get; set; }
        public decimal Total2 { get; set; }
        public decimal Total3 { get; set; }
        public decimal Neto1 { get; set; }
        public decimal Neto2 { get; set; }
        public decimal Neto3 { get; set; }
        public string Alicuota1 { get; set; }
        public string Alicuota2 { get; set; }
        public string Alicuota3 { get; set; }
        public decimal Iva1 { get; set; }
        public decimal Iva2 { get; set; }
        public decimal Iva3 { get; set; }
        public string Observacion { get; set; }
        public string NroFacturaNotaDeCredtio { get; set; }
        public string Adjunto { get; set; }
        public string TipoComprobante { get; set; }
        public string CodigoMoneda { get; set; }
        public string CodigoTipoOperacion { get; set; }
        public string TipoDeCambio { get; set; }
        public string Periodo { get; set; }
        public string TipoDNI { get; set; }
        public decimal ExentoIva { get; set; }
    }
}
