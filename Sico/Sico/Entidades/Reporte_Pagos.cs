using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sico.Entidades
{
   public class Reporte_Pagos
    {
        public string anno { get; set; }
        public string mes { get; set; }
        public int TotalVentasPorMes { get; set; }
        public int TotalDeVentasGenerales { get; set; }
        public decimal CajaDeVentas { get; set; }
        public string DescripcionProducto { get; set; }
        public int ProductoMasVendido { get; set; }
        public DateTime Fecha { get; set; }
        public decimal MontoTotal { get; set; }
        public int TotalPlanes { get; set; }
        public int TotalPlanesAbiertos { get; set; }
        public int TotalPlanesCerrados { get; set; }
        public double CobroHonorarios { get; set; }
    }
}
