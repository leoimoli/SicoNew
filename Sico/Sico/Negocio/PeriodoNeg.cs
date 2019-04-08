using Sico.Dao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sico.Negocio
{
    public class PeriodoNeg
    {
        public static bool GuardarPeriodo(string cuit, string nombre)
        {
            bool exito = false;
            try
            {
                ValidarDatos(nombre);
                exito = PeriodoDao.GuardarPeriodo(cuit, nombre);
            }
            catch (Exception ex)
            {

            }
            return exito;
        }

        private static void ValidarDatos(string nombre)
        {
            if (String.IsNullOrEmpty(nombre))
            {
                const string message = "El campo Nombre período es obligatorio.";
                const string caption = "Error";
                var result = MessageBox.Show(message, caption,
                                             MessageBoxButtons.OK,
                                           MessageBoxIcon.Exclamation);
                throw new Exception();
            }
        }

        public static List<string> CargarComboPeriodo(string cuit)
        {
            List<string> lista = new List<string>();
            lista = PeriodoDao.CargarComboPeriodo(cuit);
            return lista;
        }
    }
}
