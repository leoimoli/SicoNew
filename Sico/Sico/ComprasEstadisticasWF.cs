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
                else
                {
                     chart1.Series[nombreNuevaSerie].Points.AddXY(item.NombreProveedor, item.TotalDeCompras);
                    chart1.Series[nombreNuevaSerie].Points[ValorSeleccionado].Label = Convert.ToString(item.TotalDeCompras);
                    int nuevoValor = ValorSeleccionado - 1;
                    chart1.Series[nombreNuevaSerie].Points[ValorSeleccionado].Color = color[nuevoValor];
                }
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
