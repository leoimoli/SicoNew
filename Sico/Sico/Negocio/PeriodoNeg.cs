﻿using Sico.Dao;
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
        public static bool GuardarPeriodo(string cuit, string nombre, string Año)
        {
            bool exito = false;
            try
            {
                ValidarDatos(nombre);
                exito = PeriodoDao.GuardarPeriodo(cuit, nombre, Año);
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
        internal static List<string> CargarComboPeriodoCompras(string cuit)
        {
            List<string> lista = new List<string>();
            lista = PeriodoDao.CargarComboPeriodoCompras(cuit);
            return lista;
        }
        public static bool GuardarPeriodoVenta(string cuit, string nombre, string año)
        {
            bool exito = false;
            try
            {
                ValidarDatos(nombre);
                exito = PeriodoDao.GuardarPeriodoVenta(cuit, nombre, año);
            }
            catch (Exception ex)
            {

            }
            return exito;
        }

        public static List<string> CargarComboPeriodo(string cuit)
        {
            List<string> lista = new List<string>();
            lista = PeriodoDao.CargarComboPeriodo(cuit);
            return lista;
        }

        public static List<string> CargarComboPeriodoVenta(string cuit)
        {
            List<string> lista = new List<string>();
            lista = PeriodoDao.CargarComboPeriodoVenta(cuit);
            return lista;
        }
    }
}
