using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sico
{
    public partial class ConsultarVencimientosWF : Form
    {
        public ConsultarVencimientosWF()
        {
            InitializeComponent();
        }
        private void ConsultarVencimientosWF_Load(object sender, EventArgs e)
        {
            String DiaDeLaSemana = DateTime.Now.DayOfWeek.ToString();
            String FechaDia = DateTime.Now.Day.ToString();
            String Month = DateTime.Now.Month.ToString();
            string Mes = ValidarMes(Month);
            String Year = DateTime.Now.Year.ToString();
            int month = Convert.ToInt32(Month);
            int year = Convert.ToInt32(Year);
            label1.Text = Mes + " " + Year;
            DateTime firstDayOfMonth = new DateTime(year, month, 1);
            DateTime lastDayOfMonth = new DateTime(year, month, 1).AddMonths(1).AddDays(-1);

            string DiaInicialMes = Convert.ToString(firstDayOfMonth.DayOfWeek);
            string DiaFinalDelMes = Convert.ToString(lastDayOfMonth.DayOfWeek);
            int CatidadDiasPorMes = BuscarCantidadDeDiasPorMes(Month);
            ArmoCalendario(DiaInicialMes, DiaFinalDelMes, CatidadDiasPorMes);

            //GetWeekRows(year, month);
        }
        private int BuscarCantidadDeDiasPorMes(string Month)
        {
            int TotalDias = 0;
            if (Month == "1")
            {
                TotalDias = 31;
            }
            if (Month == "2")
            {
                TotalDias = 28;
            }
            if (Month == "3")
            {
                TotalDias = 31;
            }
            if (Month == "4")
            {
                TotalDias = 30;
            }
            if (Month == "5")
            {
                TotalDias = 31;
            }
            if (Month == "6")
            {
                TotalDias = 30;
            }
            if (Month == "7")
            {
                TotalDias = 31;
            }
            if (Month == "8")
            {
                TotalDias = 31;
            }
            if (Month == "9")
            {
                TotalDias = 30;
            }
            if (Month == "10")
            {
                TotalDias = 31;
            }
            if (Month == "11")
            {
                TotalDias = 30;
            }
            if (Month == "12")
            {
                TotalDias = 31;
            }
            return TotalDias;
        }
        private void ArmoCalendario(string diaInicialMes, string diaFinalDelMes, int CatidadDiasPorMes)
        {
            if (diaInicialMes == "Sunday")
            {
                for (int i = 1; i < CatidadDiasPorMes; i++)
                {
                    int LabelInicial = 1;

                }
            }
        }

        //public int GetWeekRows(int year, int month)
        //{
        //    DateTime firstDayOfMonth = new DateTime(year, month, 1);
        //    DateTime lastDayOfMonth = new DateTime(year, month, 1).AddMonths(1).AddDays(-1);
        //    System.Globalization.Calendar calendar = System.Threading.Thread.CurrentThread.CurrentCulture.Calendar;
        //    int lastWeek = calendar.GetWeekOfYear(lastDayOfMonth, System.Globalization.CalendarWeekRule.FirstFourDayWeek, DayOfWeek.Monday);
        //    int firstWeek = calendar.GetWeekOfYear(firstDayOfMonth, System.Globalization.CalendarWeekRule.FirstFourDayWeek, DayOfWeek.Monday);
        //    return lastWeek - firstWeek + 1;
        //}
        private string ValidarMes(string Month)
        {
            string Mes = "";
            if (Month == "1")
            {
                Mes = "Enero";
            }
            if (Month == "2")
            {
                Mes = "Febrero";
            }
            if (Month == "3")
            {
                Mes = "Marzo";
            }
            if (Month == "4")
            {
                Mes = "Abril";
            }
            if (Month == "5")
            {
                Mes = "Mayo";
            }
            if (Month == "6")
            {
                Mes = "Junio";
            }
            if (Month == "7")
            {
                Mes = "Julio";
            }
            if (Month == "8")
            {
                Mes = "Agosto";
            }
            if (Month == "9")
            {
                Mes = "Septiembre";
            }
            if (Month == "10")
            {
                Mes = "Octubre";
            }
            if (Month == "11")
            {
                Mes = "Noviembre";
            }
            if (Month == "12")
            {
                Mes = "Diciembre";
            }
            return Mes;
        }
    }
}
