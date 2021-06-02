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
            lblCuitEdit.Text = cuit;
            lblNombreEdit.Text = razonSocial;
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
            Series serie = new Series()
            {
                Name = lista2[0].NombreProveedor,
                ChartType = SeriesChartType.Pie
            };
            chart2.Series.Add(serie);
            int TotalLista = lista2.Count;
            //Random rnd = new Random(DateTime.Now.Millisecond);
            for (int i = 0; i < lista2.Count; i++)
            {
                int valor = Convert.ToInt32(lista2[i].Monto);
                int rndVal = valor;
                DataPoint p = new DataPoint(0, rndVal);
                p.AxisLabel = rndVal.ToString();
                p.LegendText = lista2[i].NombreProveedor + "  " + "(" + "$" + lista2[i].Monto + ")";
                serie.Points.Add(p);
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
            int ValorSeleccionado = 0;
            chart1.Series.Clear();
            foreach (var item in lista)
            {
                Series serie = new Series()
                {
                    Name = lista[ValorSeleccionado].NombreProveedor + "(" + lista[ValorSeleccionado].TotalDeCompras + "Compras" + ")",
                    ChartType = SeriesChartType.Column
                };
                chart1.Series.Add(serie);
                for (int i = 0; i < ValorSeleccionado || i == 0; i++)
                {
                    int valor = Convert.ToInt32(lista[i].TotalDeCompras);
                    int rndVal = valor;
                    DataPoint p = new DataPoint(0, rndVal);
                    p.AxisLabel = rndVal.ToString();
                    string nombreNuevaSerie = serie.Name.ToString();
                    chart1.Series[nombreNuevaSerie].Points.AddXY(item.NombreProveedor, item.TotalDeCompras);
                    ValorSeleccionado = ValorSeleccionado + 1;
                    i = ValorSeleccionado;
                }
            }

        }
        private void CargarComboPeriodos()
        {
            //List<string> Periodo = new List<string>();
            //Periodo = PeriodoNeg.CargarComboPeriodo(cuit);
            //cmbPeriodo.Items.Clear();
            //foreach (string item in Periodo)
            //{
            //    cmbPeriodo.Items.Add(item);
            //}
            //cmbPeriodo.SelectedIndex = 0;

            //List<string> PeriodoTorta = new List<string>();
            ////PeriodoTorta = PeriodoNeg.CargarComboPeriodo(cuit);
            //cmbPeriodoTorta.Items.Clear();
            //foreach (string item in PeriodoTorta)
            //{
            //    cmbPeriodoTorta.Items.Add(item);
            //}
            //cmbPeriodoTorta.SelectedIndex = 0;
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

        private void btnVolver_Click(object sender, EventArgs e)
        {
            ComprasWF _tarea = new ComprasWF(razonSocial, cuit);
            _tarea.Show();
            Hide();
        }

        private void cmbPeriodoTorta_SelectedIndexChanged(object sender, EventArgs e)
        {
            chart2.Series.Clear();
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
    }
}
