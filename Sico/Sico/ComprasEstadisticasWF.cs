using Sico.Entidades;
using Sico.Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Sico
{
    public partial class ComprasEstadisticasWF : MasterWF
    {
        private string cuit;
        private string razonSocial;

        public ComprasEstadisticasWF(string razonSocial, string cuit)
        {
            InitializeComponent();
            this.razonSocial = razonSocial;
            this.cuit = cuit;
        }

        private void ComprasEstadisticasWF_Load(object sender, EventArgs e)
        {
            CargarComboPeriodos();
            chart1.Series.Clear();
            List<EstadisticaCompra> Lista = new List<EstadisticaCompra>();
            string periodo = cmbPeriodo.Text;
            Lista = ComprasNeg.BuscarComprasEstadisticasPorProveedor(cuit, periodo);
            if (Lista.Count > 0)
            {
                string[] series1 = { "Compras" };
                fillChart(series1, Lista);
            }
            else { chart1.Series.Clear(); }
            ///// Armo Torta
            List<EstadisticaCompraTorta> Lista2 = new List<EstadisticaCompraTorta>();
            string periodoTorta = cmbPeriodo.Text;
            Lista2 = ComprasNeg.BuscarFacturacionTorta(cuit, periodoTorta);
            if (Lista2.Count > 0)
            {
                string[] series1 = { "FacturacionCompras" };
                fillChart2(series1, Lista2);
            }
            else { chart2.Series.Clear(); }
        }
        private void fillChart2(string[] series1, List<EstadisticaCompraTorta> lista2)
        {
            chart2.Series.Clear();
            //string nombreNuevaSerie = series1[0].ToString();
            //chart2.Series.Add(nombreNuevaSerie);
            int ValorSeleccionado = 0;
            List<Color> color = new List<Color>();
            color.Add(Color.Red);
            color.Add(Color.Green);
            color.Add(Color.Black);
            color.Add(Color.Orange);
            color.Add(Color.Coral);
            color.Add(Color.Brown);
            color.Add(Color.Blue);
            color.Add(Color.Gray);
            color.Add(Color.Violet);
            color.Add(Color.Red);
            color.Add(Color.Green);
            color.Add(Color.Black);
            color.Add(Color.Orange);
            color.Add(Color.Coral);
            color.Add(Color.Brown);
            color.Add(Color.Blue);
            color.Add(Color.Gray);
            color.Add(Color.Violet);
            //chart1.ChartAreas[nombreNuevaSerie].AxisX.LabelStyle.Interval = 1;
            foreach (var item in lista2)
            {
                int CantColor = color.Count;
                int TotalLista = lista2.Count;
                if (TotalLista >= ValorSeleccionado & CantColor > ValorSeleccionado)
                {
                    string seriesname = item.NombreProveedor;
                    chart2.Series.Add(seriesname);
                    chart2.Series[seriesname].ChartType = SeriesChartType.Pie;
                    int ValorMonto = Convert.ToInt32(item.Monto);
                    chart2.Series[seriesname].Points.AddXY(item.NombreProveedor, ValorMonto);
                    chart2.Series[seriesname].Points.AddXY(item.NombreProveedor, ValorMonto);
                    chart2.Series[seriesname].Points.AddXY(item.NombreProveedor, ValorMonto);
                    //chart2.Series[seriesname].Points[ValorSeleccionado].Color = color[ValorSeleccionado];
                    ValorSeleccionado = ValorSeleccionado + 1;
                }
              
                //    chart1.Series[nombreNuevaSerie].Points.AddXY(item.NombreProveedor, item.TotalDeCompras);
                // chart2.Series[seriesname].Points[ValorSeleccionado].Label = Convert.ToString(item.TotalDeCompras);
                //chart2.DataSource = lista2;
                //chart2.Legends[0].BorderColor = Color.Black;
                //string seriesname = item.NombreProveedor;
                //chart2.Series.Add(seriesname);
                //chart2.Series[seriesname].ChartType = SeriesChartType.Pie;
                //int ValorMonto = Convert.ToInt32(item.Monto);
                //chart2.Series[seriesname].Points.AddXY(item.NombreProveedor, ValorMonto);
                //chart2.Series[seriesname].Points.AddXY(item.NombreProveedor, ValorMonto);
                //chart2.Series[seriesname].Points.AddXY(item.NombreProveedor, ValorMonto);
                //chart2.Series["seriesname"].IsValueShownAsLabel = true;
            }
        }
        private double CalcularTotalMonto(List<FacturaCompra> value)
        {
            decimal totalMonto = 0;
            decimal MontoNegativo = 0;
            foreach (var item in value)
            {
                if (item.NroFacturaNotaDeCredtio != "" & item.NroFacturaNotaDeCredtio != null)
                {
                    MontoNegativo += item.Monto;
                }
                else { totalMonto += item.Monto; }

            }
            double valor = Convert.ToDouble(totalMonto - MontoNegativo);
            return valor;
        }
        private void fillChart(string[] series1, List<EstadisticaCompra> lista)
        {
            chart1.Series.Clear();
            string nombreNuevaSerie = series1[0].ToString();
            chart1.Series.Add(nombreNuevaSerie);
            int ValorSeleccionado = 0;
            List<Color> color = new List<Color>();
            color.Add(Color.Red);
            color.Add(Color.Green);
            color.Add(Color.Black);
            color.Add(Color.Orange);
            color.Add(Color.Coral);
            color.Add(Color.Brown);
            color.Add(Color.Blue);
            color.Add(Color.Gray);
            color.Add(Color.Violet);
            color.Add(Color.Red);
            color.Add(Color.Green);
            color.Add(Color.Black);
            color.Add(Color.Orange);
            color.Add(Color.Coral);
            color.Add(Color.Brown);
            color.Add(Color.Blue);
            color.Add(Color.Gray);
            color.Add(Color.Violet);
            //chart1.ChartAreas[nombreNuevaSerie].AxisX.LabelStyle.Interval = 1;
            foreach (var item in lista)
            {
                int CantColor = color.Count;
                int TotalLista = lista.Count;
                if (TotalLista >= ValorSeleccionado & CantColor > ValorSeleccionado)
                {
                    chart1.Series[nombreNuevaSerie].Points.AddXY(item.NombreProveedor, item.TotalDeCompras);
                    chart1.Series[nombreNuevaSerie].Points[ValorSeleccionado].Label = Convert.ToString(item.TotalDeCompras);
                    chart1.Series[nombreNuevaSerie].Points[ValorSeleccionado].Color = color[ValorSeleccionado];
                    ValorSeleccionado = ValorSeleccionado + 1;
                }
                //else
                //{
                //    chart1.Series[nombreNuevaSerie].Points.AddXY(item.NombreProveedor, item.TotalDeCompras);
                //    chart1.Series[nombreNuevaSerie].Points[ValorSeleccionado].Label = Convert.ToString(item.TotalDeCompras);
                //    int nuevoValor = ValorSeleccionado - 1;
                //    chart1.Series[nombreNuevaSerie].Points[ValorSeleccionado].Color = color[nuevoValor];
                //}
            }
        }
        private void CargarComboPeriodos()
        {
            List<string> Periodo = new List<string>();
            Periodo = PeriodoNeg.CargarComboPeriodo(cuit);
            cmbPeriodo.Items.Clear();
            foreach (string item in Periodo)
            {
                cmbPeriodo.Items.Add(item);
            }
            cmbPeriodo.SelectedIndex = 0;

            List<string> PeriodoTorta = new List<string>();
            PeriodoTorta = PeriodoNeg.CargarComboPeriodo(cuit);
            cmbPeriodoTorta.Items.Clear();
            foreach (string item in PeriodoTorta)
            {
                cmbPeriodoTorta.Items.Add(item);
            }
            cmbPeriodoTorta.SelectedIndex = 0;
        }
        private void cmbPeriodo_SelectedIndexChanged(object sender, EventArgs e)
        {
            chart1.Series.Clear();
            List<EstadisticaCompra> Lista = new List<EstadisticaCompra>();
            string periodo = cmbPeriodo.Text;
            Lista = ComprasNeg.BuscarComprasEstadisticasPorProveedor(cuit, periodo);
            if (Lista.Count > 0)
            {
                string[] series1 = { "Compras" };
                fillChart(series1, Lista);
            }
            else { chart1.Series.Clear(); }
        }
    }
}
