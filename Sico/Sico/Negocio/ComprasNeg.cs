using Sico.Dao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sico.Entidades;

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

        public static List<FacturaCompra> BuscarDatosProveedor()
        {
            throw new NotImplementedException();
        }
    }
}
