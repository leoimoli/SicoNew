using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sico.Entidades
{
  public  class Vencimientos
    {
        public int idVencimiento { get; set; }
        public string ano { get; set; }
        public string idTipoDeVencimento { get; set; }
        public string DiaDeVencimiento{ get; set; }
        public string NombreRazonSocial { get; set; }
        public string NombreTipoDeVencimiento { get; set; }
        public DateTime Fecha { get; set; } ///// Hasta aca 6 elementos
     }
}
