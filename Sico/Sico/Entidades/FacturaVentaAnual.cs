using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sico.Entidades
{
    public class FacturaVentaAnual
    {
        public string Periodo { get; set; }
        public decimal Monto { get; set; }
        public decimal Total1 { get; set; }
        public decimal Total2 { get; set; }
        public decimal Total3 { get; set; }
        public decimal Neto1 { get; set; }
        public decimal Neto2 { get; set; }
        public decimal Neto3 { get; set; }
        public decimal Iva1 { get; set; }
        public decimal Iva2 { get; set; }
        public decimal Iva3 { get; set; }
        public int idCliente { get; set; }
        public decimal ExentoIva { get; set; }
    }
}
