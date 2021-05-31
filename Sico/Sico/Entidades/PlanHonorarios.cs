using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sico.Entidades
{
   public class PlanHonorarios
    {
        public int idPlan { get; set; }
        public string Descripcion { get; set; }      
        public DateTime FechaDesde { get; set; }
        public DateTime FechaHasta { get; set; }
        public double MontoMensual { get; set; }
        public double MontoTotal { get; set; }
        public string Observaciones { get; set; }
        public string Estado { get; set; }
        public int idCliente { get; set; }
        public double MontoPago { get; set; }
        public DateTime FechaPago { get; set; }
    }
}
