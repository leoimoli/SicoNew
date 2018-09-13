using System;
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
    }
}
