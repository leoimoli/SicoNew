using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sico.Clases_Maestras
{
    public class ValoresConstantes
    {
        public static string[] Perfiles
        {
            get
            {
                return new string[] { "ADMINISTRADOR", "OPERADOR" };
            }
        }
        public static string[] Sexo
        {
            get
            {
                return new string[] { "MASCULINO", "FEMENINO" };
            }
        }

        public static string[] TipoDePago
        {
            get
            {
                return new string[] { "SELECCIONE", "EFECTIVO", "CHEQUE" };
            }
        }
        public static string[] CondicionAntiAfip
        {
            get
            {
                return new string[] { "Seleccione", "Monotributo", "Responsable inscripto", "Exento", "Consumidor final" };
            }
        }

        public static string[] Meses
        {
            get
            {
                return new string[] { "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre","Noviembre", "Diciembre" };
            }
        }

        public static string[] Años
        {
            get
            {
                return new string[] { "2010", "2011", "2012", "2013", "2014", "2015", "2016", "2017", "2018", "2019", "2020", "2021" };
            }
        }

    }
}
