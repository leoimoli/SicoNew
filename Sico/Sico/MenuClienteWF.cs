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
//using System.Web.UI.DataVisualization.Charting;
using System.Windows.Forms.DataVisualization.Charting;

namespace Sico
{
    public partial class MenuClienteWF : MasterWF
    {
        private string cuit;
        private string razonSocial;
        private bool EsEditar;
        public MenuClienteWF(string razonSocial, string cuit)
        {
            InitializeComponent();
            this.razonSocial = razonSocial;
            this.cuit = cuit;
        }
        private void MenuClienteWF_Load(object sender, EventArgs e)
        {
            lblNombreEdit.Text = razonSocial;
            lblCuitEdit.Text = cuit;
            RazonSocial = razonSocial;
            Cuit = cuit;
            CargarCombo();
            ///// Hago una busqueda Inicial De Ventas.
            string Año = "2020";
            ListaTotalFacturacionVentas = ComprasNeg.FacturacionAnualVentasPorAño(cuit, Año);
            //ListaTotalFacturacion = ComprasNeg.FacturacionAnualPorAño(cuit, Año);
        }
        private void CargarCombo()
        {
            string[] Años = Clases_Maestras.ValoresConstantes.AñosHistoricos;
            cmbAño.Items.Add("Seleccione");
            cmbAño.Items.Clear();
            foreach (string item in Años)
            {
                cmbAño.Text = "Seleccione";
                cmbAño.Items.Add(item);
            }
            cmbAñoVentas.Items.Add("Seleccione");
            cmbAñoVentas.Items.Clear();
            foreach (string item in Años)
            {
                cmbAñoVentas.Text = "Seleccione";
                cmbAñoVentas.Items.Add(item);
            }
        }
        #region Botones
        public static string RazonSocial;
        public static string Cuit;
        private void btnVentas_Click(object sender, EventArgs e)
        {
            //TareaClienteWF _tarea = new TareaClienteWF(RazonSocial, Cuit);
            //_tarea.Show();
            //Hide();
        }
        #endregion
        private void btnCompras_Click(object sender, EventArgs e)
        {
            ComprasWF _compras = new ComprasWF(RazonSocial, Cuit);
            _compras.Show();
            Hide();
        }
        private void cmbAño_SelectedIndexChanged(object sender, EventArgs e)
        {
            string año = cmbAño.Text;
            List<string> Periodos = new List<string>();
            Periodos = ClienteNeg.CargarComboPeriodosCompras(año, cuit);
            if (Periodos.Count > 0)
            {
                cmbPeriodoCompras.Enabled = true;
                cmbPeriodoCompras.Items.Add("Seleccione");
                cmbPeriodoCompras.Items.Clear();
                foreach (string item in Periodos)
                {
                    cmbPeriodoCompras.Text = "Seleccione";
                    cmbPeriodoCompras.Items.Add(item);
                }
            }
        }
        private void cmbAñoVentas_SelectedIndexChanged(object sender, EventArgs e)
        {
            //string año = cmbAñoVentas.Text;
            //List<string> Periodos = new List<string>();
            //Periodos = ClienteNeg.CargarComboPeriodos(año, cuit);
            //if (Periodos.Count > 0)
            //{
            //    cmbPeriodosVentas.Enabled = true;
            //    cmbPeriodosVentas.Items.Add("Seleccione");
            //    cmbPeriodosVentas.Items.Clear();
            //    foreach (string item in Periodos)
            //    {
            //        cmbPeriodosVentas.Text = "Seleccione";
            //        cmbPeriodosVentas.Items.Add(item);
            //    }
            //}

        }
        public List<Entidades.FacturaCompraAnual> ListaTotalFacturacion
        {
            set
            {
                if (value.Count > 0)
                {
                    ListaComprasStatic = value;
                    if (value != dgvComprasAnuales.DataSource && dgvComprasAnuales.DataSource != null)
                    {
                        dgvComprasAnuales.Columns.Clear();
                        dgvComprasAnuales.Refresh();
                    }
                    lblComprasGraficar.Visible = true;
                    chart1.Visible = false;
                    lblGraficarVentas.Visible = true;
                    dgvComprasAnuales.Visible = true;
                    dgvComprasAnuales.ReadOnly = true;
                    dgvComprasAnuales.RowHeadersVisible = false;

                    double TotalMonto = CalcularTotalMonto(value);
                    double TotalImporte1 = CalcularTotalImporte1(value);
                    double TotalImporte2 = CalcularTotalImporte2(value);
                    double TotalImporte3 = CalcularTotalImporte3(value);

                    double TotalNeto10 = CalcularTotalNeto10(value);
                    double TotalNeto21 = CalcularTotalNeto21(value);
                    double TotalNeto27 = CalcularTotalNeto27(value);

                    double TotalIva10 = CalcularTotalIva10(value);
                    double TotalIva21 = CalcularTotalIva21(value);
                    double TotalIva27 = CalcularTotalIva27(value);
                    double NoGravado = CalcularTotalNoGravado(value);
                    double PercepIngBrutos = CalcularTotalPercepIngBrutos(value);
                    double PercepIva = CalcularTotalPercepIva(value);
                    FacturaCompraAnual ultimo = new FacturaCompraAnual();
                    ultimo.Periodo = "TOTALES";
                    ultimo.Total1 = Convert.ToDecimal(TotalImporte1);
                    ultimo.Total2 = Convert.ToDecimal(TotalImporte2);
                    ultimo.Total3 = Convert.ToDecimal(TotalImporte3);

                    ultimo.Neto1 = Convert.ToDecimal(TotalNeto10);
                    ultimo.Neto2 = Convert.ToDecimal(TotalNeto21);
                    ultimo.Neto3 = Convert.ToDecimal(TotalNeto27);

                    ultimo.Iva1 = Convert.ToDecimal(TotalIva10);
                    ultimo.Iva2 = Convert.ToDecimal(TotalIva21);
                    ultimo.Iva3 = Convert.ToDecimal(TotalIva27);
                    ultimo.Monto = Convert.ToDecimal(TotalMonto);
                    ultimo.NoGravado = Convert.ToDecimal(TotalMonto);
                    ultimo.PercepIngBrutos = Convert.ToDecimal(PercepIngBrutos);
                    ultimo.PercepIva = Convert.ToDecimal(PercepIva);
                    value.Add(ultimo);
                    dgvComprasAnuales.DataSource = value;

                    dgvComprasAnuales.Columns[0].HeaderText = "Periodo";
                    dgvComprasAnuales.Columns[0].Width = 200;
                    dgvComprasAnuales.Columns[0].HeaderCell.Style.BackColor = Color.DarkBlue;
                    dgvComprasAnuales.Columns[0].HeaderCell.Style.Font = new System.Drawing.Font("Tahoma", 8, FontStyle.Bold);
                    dgvComprasAnuales.Columns[0].HeaderCell.Style.ForeColor = Color.White;
                    dgvComprasAnuales.Columns[0].Visible = true;

                    dgvComprasAnuales.Columns[1].HeaderText = "Monto";
                    dgvComprasAnuales.Columns[1].Width = 200;
                    dgvComprasAnuales.Columns[1].HeaderCell.Style.BackColor = Color.DarkBlue;
                    dgvComprasAnuales.Columns[1].HeaderCell.Style.Font = new System.Drawing.Font("Tahoma", 8, FontStyle.Bold);
                    dgvComprasAnuales.Columns[1].HeaderCell.Style.ForeColor = Color.White;
                    dgvComprasAnuales.Columns[1].Visible = true;


                    dgvComprasAnuales.Columns[2].HeaderText = "Total 1";
                    dgvComprasAnuales.Columns[2].Width = 200;
                    dgvComprasAnuales.Columns[2].HeaderCell.Style.BackColor = Color.DarkBlue;
                    dgvComprasAnuales.Columns[2].HeaderCell.Style.Font = new System.Drawing.Font("Tahoma", 8, FontStyle.Bold);
                    dgvComprasAnuales.Columns[2].HeaderCell.Style.ForeColor = Color.White;
                    dgvComprasAnuales.Columns[2].Visible = true;

                    dgvComprasAnuales.Columns[3].HeaderText = "Total 2";
                    dgvComprasAnuales.Columns[3].Width = 200;
                    dgvComprasAnuales.Columns[3].HeaderCell.Style.BackColor = Color.DarkBlue;
                    dgvComprasAnuales.Columns[3].HeaderCell.Style.Font = new System.Drawing.Font("Tahoma", 8, FontStyle.Bold);
                    dgvComprasAnuales.Columns[3].HeaderCell.Style.ForeColor = Color.White;
                    dgvComprasAnuales.Columns[3].Visible = true;

                    dgvComprasAnuales.Columns[4].HeaderText = "Total 3";
                    dgvComprasAnuales.Columns[4].Visible = true;
                    dgvComprasAnuales.Columns[4].Width = 80;
                    dgvComprasAnuales.Columns[4].HeaderCell.Style.BackColor = Color.DarkBlue;
                    dgvComprasAnuales.Columns[4].HeaderCell.Style.Font = new System.Drawing.Font("Tahoma", 8, FontStyle.Bold);

                    dgvComprasAnuales.Columns[5].HeaderText = "Neto al 10,5";
                    dgvComprasAnuales.Columns[5].Visible = true;
                    dgvComprasAnuales.Columns[5].Width = 80;
                    dgvComprasAnuales.Columns[5].HeaderCell.Style.BackColor = Color.DarkBlue;
                    dgvComprasAnuales.Columns[5].HeaderCell.Style.Font = new System.Drawing.Font("Tahoma", 8, FontStyle.Bold);

                    dgvComprasAnuales.Columns[6].HeaderText = "Neto al 21";
                    dgvComprasAnuales.Columns[6].Visible = true;
                    dgvComprasAnuales.Columns[6].Width = 80;
                    dgvComprasAnuales.Columns[6].HeaderCell.Style.BackColor = Color.DarkBlue;
                    dgvComprasAnuales.Columns[6].HeaderCell.Style.Font = new System.Drawing.Font("Tahoma", 8, FontStyle.Bold);

                    dgvComprasAnuales.Columns[7].HeaderText = "Neto al 27";
                    dgvComprasAnuales.Columns[7].Visible = true;
                    dgvComprasAnuales.Columns[7].Width = 80;
                    dgvComprasAnuales.Columns[7].HeaderCell.Style.BackColor = Color.DarkBlue;
                    dgvComprasAnuales.Columns[7].HeaderCell.Style.Font = new System.Drawing.Font("Tahoma", 8, FontStyle.Bold);

                    dgvComprasAnuales.Columns[8].HeaderText = "Iva al 10,5";
                    dgvComprasAnuales.Columns[8].Visible = true;
                    dgvComprasAnuales.Columns[8].Width = 80;
                    dgvComprasAnuales.Columns[8].HeaderCell.Style.BackColor = Color.DarkBlue;
                    dgvComprasAnuales.Columns[8].HeaderCell.Style.Font = new System.Drawing.Font("Tahoma", 8, FontStyle.Bold);

                    dgvComprasAnuales.Columns[9].HeaderText = "Iva al 21";
                    dgvComprasAnuales.Columns[9].Width = 80;
                    dgvComprasAnuales.Columns[9].HeaderCell.Style.BackColor = Color.DarkBlue;
                    dgvComprasAnuales.Columns[9].HeaderCell.Style.Font = new System.Drawing.Font("Tahoma", 8, FontStyle.Bold);

                    dgvComprasAnuales.Columns[10].HeaderText = "Iva al 27";
                    dgvComprasAnuales.Columns[10].Width = 80;
                    dgvComprasAnuales.Columns[10].HeaderCell.Style.BackColor = Color.DarkBlue;
                    dgvComprasAnuales.Columns[10].HeaderCell.Style.Font = new System.Drawing.Font("Tahoma", 8, FontStyle.Bold);

                    dgvComprasAnuales.Columns[11].HeaderText = "Percepción Ingresos Brutos";
                    dgvComprasAnuales.Columns[11].Width = 80;
                    dgvComprasAnuales.Columns[11].HeaderCell.Style.BackColor = Color.DarkBlue;
                    dgvComprasAnuales.Columns[11].HeaderCell.Style.Font = new System.Drawing.Font("Tahoma", 8, FontStyle.Bold);

                    dgvComprasAnuales.Columns[12].HeaderText = "No Gravado";
                    dgvComprasAnuales.Columns[12].Width = 80;
                    dgvComprasAnuales.Columns[12].HeaderCell.Style.BackColor = Color.DarkBlue;
                    dgvComprasAnuales.Columns[12].HeaderCell.Style.Font = new System.Drawing.Font("Tahoma", 8, FontStyle.Bold);

                    dgvComprasAnuales.Columns[13].HeaderText = "Percepción Iva";
                    dgvComprasAnuales.Columns[13].Width = 80;
                    dgvComprasAnuales.Columns[13].HeaderCell.Style.BackColor = Color.DarkBlue;
                    dgvComprasAnuales.Columns[13].HeaderCell.Style.Font = new System.Drawing.Font("Tahoma", 8, FontStyle.Bold);

                    dgvComprasAnuales.Columns[14].HeaderText = "idCliente";
                    dgvComprasAnuales.Columns[14].Width = 80;
                    dgvComprasAnuales.Columns[14].HeaderCell.Style.BackColor = Color.DarkBlue;
                    dgvComprasAnuales.Columns[14].HeaderCell.Style.Font = new System.Drawing.Font("Tahoma", 8, FontStyle.Bold);
                    dgvComprasAnuales.Columns[14].Visible = false;


                    dgvComprasAnuales.Rows[dgvComprasAnuales.Rows.Count - 1].DefaultCellStyle.BackColor = Color.Red;
                }
                else
                {
                    dgvComprasAnuales.Visible = false;
                    MessageBox.Show("No se encontraron datos con los parametros ingresados en Compras.");
                }
            }
        }
        public static List<Entidades.FacturaVentaAnual> ListaVentasStatic;
        public static bool GraficoMonto;
        public static bool GraficoIVA;
        public static bool GraficoNeto;
        public static List<Entidades.FacturaCompraAnual> ListaComprasStatic;
        public List<Entidades.FacturaVentaAnual> ListaTotalFacturacionVentas
        {
            set
            {
                if (value.Count > 0)
                {
                    ListaVentasStatic = value;
                    if (value != dgvVentasAnuales.DataSource && dgvVentasAnuales.DataSource != null)
                    {
                        dgvVentasAnuales.Columns.Clear();
                        dgvVentasAnuales.Refresh();
                    }
                    chart1.Visible = false;
                    lblGraficarVentas.Visible = true;
                    dgvVentasAnuales.Visible = true;
                    dgvVentasAnuales.ReadOnly = true;
                    dgvVentasAnuales.RowHeadersVisible = false;

                    double TotalMonto = CalcularTotalMontoVentas(value);
                    double TotalImporte1 = CalcularTotalImporte1Ventas(value);
                    double TotalImporte2 = CalcularTotalImporte2Ventas(value);
                    double TotalImporte3 = CalcularTotalImporte3Ventas(value);

                    double TotalNeto10 = CalcularTotalNeto10Ventas(value);
                    double TotalNeto21 = CalcularTotalNeto21Ventas(value);
                    double TotalNeto27 = CalcularTotalNeto27Ventas(value);

                    double TotalIva10 = CalcularTotalIva10Ventas(value);
                    double TotalIva21 = CalcularTotalIva21Ventas(value);
                    double TotalIva27 = CalcularTotalIva27Ventas(value);
                    FacturaVentaAnual ultimo = new FacturaVentaAnual();
                    ultimo.Periodo = "TOTALES";
                    ultimo.Monto = Convert.ToDecimal(TotalMonto);
                    ultimo.Total1 = Convert.ToDecimal(TotalImporte1);
                    ultimo.Total2 = Convert.ToDecimal(TotalImporte2);
                    ultimo.Total3 = Convert.ToDecimal(TotalImporte3);

                    ultimo.Neto1 = Convert.ToDecimal(TotalNeto10);
                    ultimo.Neto2 = Convert.ToDecimal(TotalNeto21);
                    ultimo.Neto3 = Convert.ToDecimal(TotalNeto27);

                    ultimo.Iva1 = Convert.ToDecimal(TotalIva10);
                    ultimo.Iva2 = Convert.ToDecimal(TotalIva21);
                    ultimo.Iva3 = Convert.ToDecimal(TotalIva27);
                    value.Add(ultimo);
                    dgvVentasAnuales.DataSource = value;

                    dgvVentasAnuales.Columns[0].HeaderText = "Periodo";
                    dgvVentasAnuales.Columns[0].Width = 200;
                    dgvVentasAnuales.Columns[0].HeaderCell.Style.BackColor = Color.DarkBlue;
                    dgvVentasAnuales.Columns[0].HeaderCell.Style.Font = new System.Drawing.Font("Tahoma", 8, FontStyle.Bold);
                    dgvVentasAnuales.Columns[0].HeaderCell.Style.ForeColor = Color.White;
                    dgvVentasAnuales.Columns[0].Visible = true;

                    dgvVentasAnuales.Columns[1].HeaderText = "Monto";
                    dgvVentasAnuales.Columns[1].Width = 200;
                    dgvVentasAnuales.Columns[1].HeaderCell.Style.BackColor = Color.DarkBlue;
                    dgvVentasAnuales.Columns[1].HeaderCell.Style.Font = new System.Drawing.Font("Tahoma", 8, FontStyle.Bold);
                    dgvVentasAnuales.Columns[1].HeaderCell.Style.ForeColor = Color.White;
                    dgvVentasAnuales.Columns[1].Visible = true;


                    dgvVentasAnuales.Columns[2].HeaderText = "Total 1";
                    dgvVentasAnuales.Columns[2].Width = 200;
                    dgvVentasAnuales.Columns[2].HeaderCell.Style.BackColor = Color.DarkBlue;
                    dgvVentasAnuales.Columns[2].HeaderCell.Style.Font = new System.Drawing.Font("Tahoma", 8, FontStyle.Bold);
                    dgvVentasAnuales.Columns[2].HeaderCell.Style.ForeColor = Color.White;
                    dgvVentasAnuales.Columns[2].Visible = true;

                    dgvVentasAnuales.Columns[3].HeaderText = "Total 2";
                    dgvVentasAnuales.Columns[3].Width = 200;
                    dgvVentasAnuales.Columns[3].HeaderCell.Style.BackColor = Color.DarkBlue;
                    dgvVentasAnuales.Columns[3].HeaderCell.Style.Font = new System.Drawing.Font("Tahoma", 8, FontStyle.Bold);
                    dgvVentasAnuales.Columns[3].HeaderCell.Style.ForeColor = Color.White;
                    dgvVentasAnuales.Columns[3].Visible = true;

                    dgvVentasAnuales.Columns[4].HeaderText = "Total 3";
                    dgvVentasAnuales.Columns[4].Visible = true;
                    dgvVentasAnuales.Columns[4].Width = 80;
                    dgvVentasAnuales.Columns[4].HeaderCell.Style.BackColor = Color.DarkBlue;
                    dgvVentasAnuales.Columns[4].HeaderCell.Style.Font = new System.Drawing.Font("Tahoma", 8, FontStyle.Bold);

                    dgvVentasAnuales.Columns[5].HeaderText = "Neto al 10,5";
                    dgvVentasAnuales.Columns[5].Visible = true;
                    dgvVentasAnuales.Columns[5].Width = 80;
                    dgvVentasAnuales.Columns[5].HeaderCell.Style.BackColor = Color.DarkBlue;
                    dgvVentasAnuales.Columns[5].HeaderCell.Style.Font = new System.Drawing.Font("Tahoma", 8, FontStyle.Bold);

                    dgvVentasAnuales.Columns[6].HeaderText = "Neto al 21";
                    dgvVentasAnuales.Columns[6].Visible = true;
                    dgvVentasAnuales.Columns[6].Width = 80;
                    dgvVentasAnuales.Columns[6].HeaderCell.Style.BackColor = Color.DarkBlue;
                    dgvVentasAnuales.Columns[6].HeaderCell.Style.Font = new System.Drawing.Font("Tahoma", 8, FontStyle.Bold);

                    dgvVentasAnuales.Columns[7].HeaderText = "Neto al 27";
                    dgvVentasAnuales.Columns[7].Visible = true;
                    dgvVentasAnuales.Columns[7].Width = 80;
                    dgvVentasAnuales.Columns[7].HeaderCell.Style.BackColor = Color.DarkBlue;
                    dgvVentasAnuales.Columns[7].HeaderCell.Style.Font = new System.Drawing.Font("Tahoma", 8, FontStyle.Bold);

                    dgvVentasAnuales.Columns[8].HeaderText = "Iva al 10,5";
                    dgvVentasAnuales.Columns[8].Visible = true;
                    dgvVentasAnuales.Columns[8].Width = 80;
                    dgvVentasAnuales.Columns[8].HeaderCell.Style.BackColor = Color.DarkBlue;
                    dgvVentasAnuales.Columns[8].HeaderCell.Style.Font = new System.Drawing.Font("Tahoma", 8, FontStyle.Bold);

                    dgvVentasAnuales.Columns[9].HeaderText = "Iva al 21";
                    dgvVentasAnuales.Columns[9].Width = 80;
                    dgvVentasAnuales.Columns[9].HeaderCell.Style.BackColor = Color.DarkBlue;
                    dgvVentasAnuales.Columns[9].HeaderCell.Style.Font = new System.Drawing.Font("Tahoma", 8, FontStyle.Bold);

                    dgvVentasAnuales.Columns[10].HeaderText = "Iva al 27";
                    dgvVentasAnuales.Columns[10].Width = 80;
                    dgvVentasAnuales.Columns[10].HeaderCell.Style.BackColor = Color.DarkBlue;
                    dgvVentasAnuales.Columns[10].HeaderCell.Style.Font = new System.Drawing.Font("Tahoma", 8, FontStyle.Bold);

                    dgvVentasAnuales.Columns[11].HeaderText = "idCliente";
                    dgvVentasAnuales.Columns[11].Width = 80;
                    dgvVentasAnuales.Columns[11].HeaderCell.Style.BackColor = Color.DarkBlue;
                    dgvVentasAnuales.Columns[11].HeaderCell.Style.Font = new System.Drawing.Font("Tahoma", 8, FontStyle.Bold);
                    dgvVentasAnuales.Columns[11].Visible = false;


                    dgvVentasAnuales.Rows[dgvVentasAnuales.Rows.Count - 1].DefaultCellStyle.BackColor = Color.Red;
                }
                else
                {
                    dgvVentasAnuales.Visible = false;
                    MessageBox.Show("No se encontraron datos con los parametros ingresados en Ventas.");
                }
            }
        }
        #region Calculos totales
        private double CalcularTotalPercepIva(List<FacturaCompraAnual> value)
        {
            decimal totalPercepIva = 0;
            decimal MontoNegativo = 0;
            foreach (var item in value)
            {

                totalPercepIva += item.PercepIva;

            }
            double valor = Convert.ToDouble(totalPercepIva - MontoNegativo);
            return valor;
        }
        private double CalcularTotalPercepIngBrutos(List<FacturaCompraAnual> value)
        {
            decimal totalPercepIngBrutos = 0;
            decimal MontoNegativo = 0;
            foreach (var item in value)
            {
                totalPercepIngBrutos += item.PercepIngBrutos;

            }
            double valor = Convert.ToDouble(totalPercepIngBrutos - MontoNegativo);
            return valor;
        }
        private double CalcularTotalIva27(List<FacturaCompraAnual> value)
        {
            decimal totaliva27 = 0;
            decimal MontoNegativoiva27 = 0;
            foreach (var item in value)
            {
                totaliva27 += item.Iva3;

            }
            double valor = Convert.ToDouble(totaliva27 - MontoNegativoiva27);
            return valor;
        }
        private double CalcularTotalIva21(List<FacturaCompraAnual> value)
        {
            decimal totaliva21 = 0;
            decimal MontoNegativoiva21 = 0;
            foreach (var item in value)
            {
                totaliva21 += item.Iva2;
            }
            double valor = Convert.ToDouble(totaliva21 - MontoNegativoiva21);
            return valor;
        }
        private double CalcularTotalIva10(List<FacturaCompraAnual> value)
        {
            decimal totaliva10 = 0;
            decimal MontoNegativoiva10 = 0;
            foreach (var item in value)
            {
                totaliva10 += item.Iva1;

            }
            double valor = Convert.ToDouble(totaliva10 - MontoNegativoiva10);
            return valor;
        }
        private double CalcularTotalNeto27(List<FacturaCompraAnual> value)
        {
            decimal totalNeto27 = 0;
            decimal MontoNegativo27 = 0;
            foreach (var item in value)
            {

                totalNeto27 += item.Neto3;

            }
            double valor = Convert.ToDouble(totalNeto27 - MontoNegativo27);
            return valor;
        }
        private double CalcularTotalNeto21(List<FacturaCompraAnual> value)
        {
            decimal totalNeto21 = 0;
            decimal MontoNegativo21 = 0;
            foreach (var item in value)
            {
                totalNeto21 += item.Neto2;
            }
            double valor = Convert.ToDouble(totalNeto21 - MontoNegativo21);
            return valor;
        }
        private double CalcularTotalNeto10(List<FacturaCompraAnual> value)
        {
            decimal totalNeto10 = 0;
            decimal MontoNegativo10 = 0;
            foreach (var item in value)
            {
                totalNeto10 += item.Neto1;
            }
            double valor = Convert.ToDouble(totalNeto10 - MontoNegativo10);
            return valor;
        }
        private double CalcularTotalImporte3(List<FacturaCompraAnual> value)
        {
            decimal totalImporte3 = 0;
            decimal MontoNegativo3 = 0;
            foreach (var item in value)
            {

                totalImporte3 += item.Total3;
            }
            double valor = Convert.ToDouble(totalImporte3 - MontoNegativo3);
            return valor;
        }
        private double CalcularTotalImporte2(List<FacturaCompraAnual> value)
        {
            decimal totalImporte2 = 0;
            decimal MontoNegativo2 = 0;
            foreach (var item in value)
            {
                totalImporte2 += item.Total2;
            }
            double valor = Convert.ToDouble(totalImporte2 - MontoNegativo2);
            return valor;
        }
        private double CalcularTotalImporte1(List<FacturaCompraAnual> value)
        {
            decimal totalImporte1 = 0;
            decimal MontoNegativo1 = 0;
            foreach (var item in value)
            {

                totalImporte1 += item.Total1;

            }
            double valor = Convert.ToDouble(totalImporte1 - MontoNegativo1);
            return valor;
        }
        private double CalcularTotalMonto(List<FacturaCompraAnual> value)
        {
            decimal totalMonto = 0;
            decimal MontoNegativo = 0;
            foreach (var item in value)
            {

                totalMonto += item.Monto;

            }
            double valor = Convert.ToDouble(totalMonto - MontoNegativo);
            return valor;
        }
        private double CalcularTotalNoGravado(List<FacturaCompraAnual> value)
        {
            decimal totalnoGravado = 0;
            decimal MontoNegativo = 0;
            foreach (var item in value)
            {
                totalnoGravado += item.NoGravado;

            }
            double valor = Convert.ToDouble(totalnoGravado - MontoNegativo);
            return valor;
        }
        #endregion
        #region Calculos totales Ventas
        private double CalcularTotalIva27Ventas(List<FacturaVentaAnual> value)
        {
            decimal totaliva27 = 0;
            decimal MontoNegativoiva27 = 0;
            foreach (var item in value)
            {
                totaliva27 += item.Iva3;

            }
            double valor = Convert.ToDouble(totaliva27 - MontoNegativoiva27);
            return valor;
        }
        private double CalcularTotalIva21Ventas(List<FacturaVentaAnual> value)
        {
            decimal totaliva21 = 0;
            decimal MontoNegativoiva21 = 0;
            foreach (var item in value)
            {

                totaliva21 += item.Iva2;

            }
            double valor = Convert.ToDouble(totaliva21 - MontoNegativoiva21);
            return valor;
        }
        private double CalcularTotalIva10Ventas(List<FacturaVentaAnual> value)
        {
            decimal totaliva10 = 0;
            decimal MontoNegativoiva10 = 0;
            foreach (var item in value)
            {
                totaliva10 += item.Iva1;
            }
            double valor = Convert.ToDouble(totaliva10 - MontoNegativoiva10);
            return valor;
        }
        private double CalcularTotalNeto27Ventas(List<FacturaVentaAnual> value)
        {
            decimal totalNeto27 = 0;
            decimal MontoNegativo27 = 0;
            foreach (var item in value)
            {

                totalNeto27 += item.Neto3;


            }
            double valor = Convert.ToDouble(totalNeto27 - MontoNegativo27);
            return valor;
        }
        private double CalcularTotalNeto21Ventas(List<FacturaVentaAnual> value)
        {
            decimal totalNeto21 = 0;
            decimal MontoNegativo21 = 0;
            foreach (var item in value)
            {
                totalNeto21 += item.Neto2;

            }
            double valor = Convert.ToDouble(totalNeto21 - MontoNegativo21);
            return valor;
        }
        private double CalcularTotalNeto10Ventas(List<FacturaVentaAnual> value)
        {
            decimal totalNeto10 = 0;
            decimal MontoNegativo10 = 0;
            foreach (var item in value)
            {
                totalNeto10 += item.Neto1;
            }
            double valor = Convert.ToDouble(totalNeto10 - MontoNegativo10);
            return valor;
        }
        private double CalcularTotalImporte3Ventas(List<FacturaVentaAnual> value)
        {
            decimal totalImporte3 = 0;
            decimal MontoNegativo3 = 0;
            foreach (var item in value)
            {
                totalImporte3 += item.Total3;

            }
            double valor = Convert.ToDouble(totalImporte3 - MontoNegativo3);
            return valor;
        }
        private double CalcularTotalImporte2Ventas(List<FacturaVentaAnual> value)
        {
            decimal totalImporte2 = 0;
            decimal MontoNegativo2 = 0;
            foreach (var item in value)
            {
                totalImporte2 += item.Total2;
            }
            double valor = Convert.ToDouble(totalImporte2 - MontoNegativo2);
            return valor;
        }
        private double CalcularTotalImporte1Ventas(List<FacturaVentaAnual> value)
        {
            decimal totalImporte1 = 0;
            decimal MontoNegativo1 = 0;
            foreach (var item in value)
            {
                //if (item.NroFacturaNotaDeCredtio != "" & item.NroFacturaNotaDeCredtio != null)
                //{
                //    MontoNegativo1 += item.Total1;
                //}
                //else {
                totalImporte1 += item.Total1;
                //}

            }
            double valor = Convert.ToDouble(totalImporte1 - MontoNegativo1);
            return valor;
        }
        private double CalcularTotalMontoVentas(List<FacturaVentaAnual> value)
        {
            decimal totalMonto = 0;
            decimal MontoNegativo = 0;
            foreach (var item in value)
            {
                totalMonto += item.Monto;

            }
            double valor = Convert.ToDouble(totalMonto - MontoNegativo);
            return valor;
        }
        #endregion
        private void btnVencimientos_Click(object sender, EventArgs e)
        {
            VencimientoPorClienteWF _vencimientos = new VencimientoPorClienteWF(RazonSocial, Cuit);
            _vencimientos.Show();
            Hide();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            ConsultaVencimientosWF _consulta = new ConsultaVencimientosWF(razonSocial, cuit);
            _consulta.Show();
            Hide();
        }
        private void label6_Click(object sender, EventArgs e)
        {

        }
        private void btnBuscarVentas_Click(object sender, EventArgs e)
        {
            try
            {

                string Año = cmbAñoVentas.Text;
                string Periodo = cmbPeriodosVentas.Text;
                if (Año == "Seleccione")
                {
                    const string message = "Debe seleccionar un Año para realizar la busqueda.";
                    const string caption = "Atención";
                    var result = MessageBox.Show(message, caption,
                                                 MessageBoxButtons.OK,
                                               MessageBoxIcon.Warning);
                    throw new Exception();
                }
                if (Año != "Seleccione" && Periodo != "Seleccione")
                {
                    ListaTotalFacturacionVentas = ComprasNeg.FacturacionAnualVentasPorPeriodos(cuit, Periodo);
                }
                if (Año != "Seleccione" && Periodo == "Seleccione")
                {
                    ListaTotalFacturacionVentas = ComprasNeg.FacturacionAnualVentasPorAño(cuit, Año);
                }
            }
            catch (Exception ex)
            { }
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            lblVentasIva.Visible = true;
            lblVentasNeto.Visible = true;
            lblVentasPorMonto.Visible = true;
            lblBarras.Visible = true;
            lblLineas.Visible = true;
        }
        private void fillChart(string[] series1, List<FacturaVentaAnual> listaVentasStatic)
        {
            chart1.Visible = true;
            dgvVentasAnuales.Visible = false;
            chart1.Series.Clear();
            string nombreNuevaSerie = series1[0].ToString();
            chart1.Series.Add(nombreNuevaSerie);
            foreach (var item in listaVentasStatic)
            {
                chart1.Series[nombreNuevaSerie].Points.AddXY(item.Monto, item.Periodo);
            }
        }
        private void lblVentasPorMonto_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.chart1.Titles.Clear();
            GraficoMonto = true;
            GraficoNeto = false;
            GraficoIVA = false;
            chart1.Visible = true;
            dgvVentasAnuales.Visible = false;
            this.chart1.Series.Clear();
            this.chart1.Titles.Add("Total Por Monto");
            foreach (var item in ListaVentasStatic)
            {
                if (item.Periodo == "TOTALES")
                {
                    ListaVentasStatic.Remove(item);
                    break;
                }
            }
            foreach (var item in ListaVentasStatic)
            {
                Series series = this.chart1.Series.Add(item.Periodo + "(" + "$ " + item.Monto + ")");
                series.Points.AddXY("-", item.Monto);
            }
        }
        private void lblVentasNeto_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.chart1.Titles.Clear();
            GraficoMonto = false;
            GraficoNeto = true;
            GraficoIVA = false;
            chart1.Visible = true;
            dgvVentasAnuales.Visible = false;
            this.chart1.Series.Clear();
            this.chart1.Titles.Add("Total Por Neto Grabado");
            foreach (var item in ListaVentasStatic)
            {
                if (item.Periodo == "TOTALES")
                {
                    ListaVentasStatic.Remove(item);
                    break;
                }
            }
            foreach (var item in ListaVentasStatic)
            {
                decimal TotalNeto = item.Neto1 + item.Neto2 + item.Neto3;
                Series series = this.chart1.Series.Add(item.Periodo + "(" + "$" + TotalNeto + ")");
                series.Points.AddXY("-", TotalNeto);
            }
        }
        private void lblVentasIva_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.chart1.Titles.Clear();
            GraficoMonto = false;
            GraficoNeto = false;
            GraficoIVA = true;
            chart1.Visible = true;
            dgvVentasAnuales.Visible = false;
            this.chart1.Series.Clear();
            this.chart1.Titles.Add("Total Por IVA");
            foreach (var item in ListaVentasStatic)
            {
                if (item.Periodo == "TOTALES")
                {
                    ListaVentasStatic.Remove(item);
                    break;
                }
            }
            foreach (var item in ListaVentasStatic)
            {
                decimal TotalIva = item.Iva1 + item.Iva2 + item.Iva3;
                Series series = this.chart1.Series.Add(item.Periodo + "(" + "$" + TotalIva + ")");
                series.Points.AddXY("-", TotalIva);
            }
        }
        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (GraficoMonto == true)
            {
                GraficoBarraPorMonto();
            }
            if (GraficoIVA == true)
            {
                GraficoBarraPorIVA();
            }
            if (GraficoNeto == true)
            {
                GraficoBarraPorNeto();
            }
        }
        private void GraficoBarraPorMonto()
        {
            this.chart1.Titles.Clear();
            GraficoMonto = true;
            GraficoNeto = false;
            GraficoIVA = false;
            chart1.Visible = true;
            dgvVentasAnuales.Visible = false;
            this.chart1.Series.Clear();
            this.chart1.Titles.Add("Total Por Monto");
            foreach (var item in ListaVentasStatic)
            {
                if (item.Periodo == "TOTALES")
                {
                    ListaVentasStatic.Remove(item);
                    break;
                }
            }
            foreach (var item in ListaVentasStatic)
            {
                Series series = this.chart1.Series.Add(item.Periodo + "(" + "$ " + item.Monto + ")");
                series.Points.AddXY("-", item.Monto);
            }
        }
        private void GraficoBarraPorNeto()
        {
            this.chart1.Titles.Clear();
            GraficoMonto = false;
            GraficoNeto = true;
            GraficoIVA = false;
            chart1.Visible = true;
            dgvVentasAnuales.Visible = false;
            this.chart1.Series.Clear();
            this.chart1.Titles.Add("Total Por Neto Grabado");
            foreach (var item in ListaVentasStatic)
            {
                if (item.Periodo == "TOTALES")
                {
                    ListaVentasStatic.Remove(item);
                    break;
                }
            }
            foreach (var item in ListaVentasStatic)
            {
                decimal TotalNeto = item.Neto1 + item.Neto2 + item.Neto3;
                Series series = this.chart1.Series.Add(item.Periodo + "(" + "$" + TotalNeto + ")");
                series.Points.AddXY("-", TotalNeto);
            }
        }
        private void GraficoBarraPorIVA()
        {
            this.chart1.Titles.Clear();
            GraficoMonto = false;
            GraficoNeto = false;
            GraficoIVA = true;
            chart1.Visible = true;
            dgvVentasAnuales.Visible = false;
            this.chart1.Series.Clear();
            this.chart1.Titles.Add("Total Por IVA");
            foreach (var item in ListaVentasStatic)
            {
                if (item.Periodo == "TOTALES")
                {
                    ListaVentasStatic.Remove(item);
                    break;
                }
            }
            foreach (var item in ListaVentasStatic)
            {
                decimal TotalIva = item.Iva1 + item.Iva2 + item.Iva3;
                Series series = this.chart1.Series.Add(item.Periodo + "(" + "$" + TotalIva + ")");
                series.Points.AddXY("-", TotalIva);
            }
        }
        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (GraficoMonto == true)
            {
                GraficoLineaMonto();
            }
            if (GraficoIVA == true)
            {
                GraficoLineaIVA();
            }
            if (GraficoNeto == true)
            {
                GraficoLineaNeto();
            }
        }
        private void GraficoLineaMonto()
        {
            this.chart1.Titles.Clear();
            this.chart1.Series.Clear();
            this.chart1.Titles.Add("Total Por Monto");
            Series series = this.chart1.Series.Add("Total Por Monto");
            series.ChartType = SeriesChartType.Spline;
            foreach (var item in ListaVentasStatic)
            {
                if (item.Periodo == "TOTALES")
                {
                    ListaVentasStatic.Remove(item);
                    break;
                }
            }
            foreach (var item in ListaVentasStatic)
            {
                series.Points.AddXY(item.Periodo + "(" + item.Monto + ")", item.Monto);
            }
        }
        private void GraficoLineaNeto()
        {
            this.chart1.Titles.Clear();
            this.chart1.Series.Clear();
            this.chart1.Titles.Add("Total Por Neto Grabado");
            Series series = this.chart1.Series.Add("Total Por Neto Grabado");
            series.ChartType = SeriesChartType.Spline;
            foreach (var item in ListaVentasStatic)
            {
                if (item.Periodo == "TOTALES")
                {
                    ListaVentasStatic.Remove(item);
                    break;
                }
            }
            foreach (var item in ListaVentasStatic)
            {
                decimal TotalNeto = item.Neto1 + item.Neto2 + item.Neto3;
                series.Points.AddXY(item.Periodo + "(" + TotalNeto + ")", TotalNeto);
            }
        }
        private void GraficoLineaIVA()
        {
            this.chart1.Titles.Clear();
            this.chart1.Series.Clear();
            this.chart1.Titles.Add("Total Por IVA");
            Series series = this.chart1.Series.Add("Total Por IVA");
            series.ChartType = SeriesChartType.Spline;
            foreach (var item in ListaVentasStatic)
            {
                if (item.Periodo == "TOTALES")
                {
                    ListaVentasStatic.Remove(item);
                    break;
                }
            }
            foreach (var item in ListaVentasStatic)
            {
                decimal TotalIva = item.Iva1 + item.Iva2 + item.Iva3;
                series.Points.AddXY(item.Periodo + "(" + TotalIva + ")", TotalIva);
            }
        }
        private void btnBuscarCompras_Click(object sender, EventArgs e)
        {
            try
            {

                string Año = cmbAño.Text;
                string Periodo = cmbPeriodoCompras.Text;
                if (Año == "Seleccione")
                {
                    const string message = "Debe seleccionar un Año para realizar la busqueda.";
                    const string caption = "Atención";
                    var result = MessageBox.Show(message, caption,
                                                 MessageBoxButtons.OK,
                                               MessageBoxIcon.Warning);
                    throw new Exception();
                }
                if (Año != "Seleccione" && Periodo != "Seleccione")
                {
                    ListaTotalFacturacion = ComprasNeg.FacturacionAnualPorPeriodos(cuit, Periodo);
                }
                if (Año != "Seleccione" && Periodo == "Seleccione")
                {
                    //ListaTotalFacturacion = ComprasNeg.FacturacionAnualPorAño(cuit, Año);
                }
            }
            catch (Exception ex)
            { }
        }
        private void lblComprasGraficar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            lblComprasIva.Visible = true;
            lblComprasNeto.Visible = true;
            lblComprasMonto.Visible = true;
            lblComprasBarra.Visible = true;
            lblComprasLinea.Visible = true;
        }
        public static bool GraficoComprasMonto;
        public static bool GraficoComprasIVA;
        public static bool GraficoComprasNeto;
        private void lblComprasMonto_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.chart2.Titles.Clear();
            GraficoComprasMonto = true;
            GraficoComprasNeto = false;
            GraficoComprasIVA = false;
            chart2.Visible = true;
            dgvComprasAnuales.Visible = false;
            this.chart2.Series.Clear();
            this.chart2.Titles.Add("Total Por Monto");
            foreach (var item in ListaComprasStatic)
            {
                if (item.Periodo == "TOTALES")
                {
                    ListaComprasStatic.Remove(item);
                    break;
                }
            }
            foreach (var item in ListaComprasStatic)
            {
                Series series = this.chart2.Series.Add(item.Periodo + "(" + "$ " + item.Monto + ")");
                series.Points.AddXY("-", item.Monto);
            }
        }
        private void lblComprasNeto_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.chart2.Titles.Clear();
            GraficoComprasMonto = false;
            GraficoComprasNeto = true;
            GraficoComprasIVA = false;
            chart2.Visible = true;
            dgvComprasAnuales.Visible = false;
            this.chart2.Series.Clear();
            this.chart2.Titles.Add("Total Por Neto Grabado");
            foreach (var item in ListaComprasStatic)
            {
                if (item.Periodo == "TOTALES")
                {
                    ListaComprasStatic.Remove(item);
                    break;
                }
            }
            foreach (var item in ListaComprasStatic)
            {
                decimal NetoTotal = item.Neto1 + item.Neto2 + item.Neto3;
                Series series = this.chart2.Series.Add(item.Periodo + "(" + "$ " + NetoTotal + ")");
                series.Points.AddXY("-", NetoTotal);
            }
        }
        private void lblComprasIva_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.chart2.Titles.Clear();
            GraficoComprasMonto = false;
            GraficoComprasNeto = false;
            GraficoComprasIVA = true;
            chart2.Visible = true;
            dgvComprasAnuales.Visible = false;
            this.chart2.Series.Clear();
            this.chart2.Titles.Add("Total Por IVA");
            foreach (var item in ListaComprasStatic)
            {
                if (item.Periodo == "TOTALES")
                {
                    ListaComprasStatic.Remove(item);
                    break;
                }
            }
            foreach (var item in ListaComprasStatic)
            {
                decimal IvaTotal = item.Iva1 + item.Iva2 + item.Iva3;
                Series series = this.chart2.Series.Add(item.Periodo + "(" + "$ " + IvaTotal + ")");
                series.Points.AddXY("-", IvaTotal);
            }
        }
        private void lblComprasBarra_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (GraficoComprasMonto == true)
            {
                GraficoComprasBarraPorMonto();
            }
            if (GraficoComprasIVA == true)
            {
                GraficoComprasBarraPorIVA();
            }
            if (GraficoComprasNeto == true)
            {
                GraficoComprasBarraPorNeto();
            }
        }
        private void GraficoComprasBarraPorNeto()
        {
            this.chart1.Titles.Clear();
            GraficoComprasMonto = false;
            GraficoComprasNeto = true;
            GraficoComprasIVA = false;
            chart2.Visible = true;
            dgvComprasAnuales.Visible = false;
            this.chart2.Series.Clear();
            this.chart2.Titles.Add("Total Por Neto Grabado");
            foreach (var item in ListaComprasStatic)
            {
                if (item.Periodo == "TOTALES")
                {
                    ListaComprasStatic.Remove(item);
                    break;
                }
            }
            foreach (var item in ListaComprasStatic)
            {
                decimal NetoTotal = item.Neto1 + item.Neto2 + item.Neto3;
                Series series = this.chart2.Series.Add(item.Periodo + "(" + "$ " + NetoTotal + ")");
                series.Points.AddXY("-", NetoTotal);
            }
        }
        private void GraficoComprasBarraPorIVA()
        {
            this.chart1.Titles.Clear();
            GraficoComprasMonto = false;
            GraficoComprasNeto = false;
            GraficoComprasIVA = true;
            chart2.Visible = true;
            dgvComprasAnuales.Visible = false;
            this.chart2.Series.Clear();
            this.chart2.Titles.Add("Total Por IVA");
            foreach (var item in ListaComprasStatic)
            {
                if (item.Periodo == "TOTALES")
                {
                    ListaComprasStatic.Remove(item);
                    break;
                }
            }
            foreach (var item in ListaComprasStatic)
            {
                decimal IvaTotal = item.Iva1 + item.Iva2 + item.Iva3;
                Series series = this.chart2.Series.Add(item.Periodo + "(" + "$ " + IvaTotal + ")");
                series.Points.AddXY("-", IvaTotal);
            }
        }
        private void GraficoComprasBarraPorMonto()
        {
            this.chart1.Titles.Clear();
            GraficoComprasMonto = true;
            GraficoComprasNeto = false;
            GraficoComprasIVA = false;
            chart2.Visible = true;
            dgvComprasAnuales.Visible = false;
            this.chart2.Series.Clear();
            this.chart2.Titles.Add("Total Por Monto");
            foreach (var item in ListaComprasStatic)
            {
                if (item.Periodo == "TOTALES")
                {
                    ListaComprasStatic.Remove(item);
                    break;
                }
            }
            foreach (var item in ListaComprasStatic)
            {
                Series series = this.chart1.Series.Add(item.Periodo + "(" + "$ " + item.Monto + ")");
                series.Points.AddXY("-", item.Monto);
            }
        }
        private void lblComprasLinea_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (GraficoComprasMonto == true)
            {
                GraficoComprasLineaMonto();
            }
            if (GraficoComprasIVA == true)
            {
                GraficoComprasLineaIVA();
            }
            if (GraficoComprasNeto == true)
            {
                GraficoComprasLineaNeto();
            }
        }
        private void GraficoComprasLineaNeto()
        {
            this.chart2.Titles.Clear();
            this.chart2.Series.Clear();
            this.chart2.Titles.Add("Total Por Neto Grabado");
            Series series = this.chart2.Series.Add("Total Por Neto Grabado");
            series.ChartType = SeriesChartType.Spline;
            foreach (var item in ListaComprasStatic)
            {
                if (item.Periodo == "TOTALES")
                {
                    ListaComprasStatic.Remove(item);
                    break;
                }
            }
            foreach (var item in ListaComprasStatic)
            {
                decimal TotalNeto = item.Neto1 + item.Neto2 + item.Neto3;
                series.Points.AddXY(item.Periodo + "(" + TotalNeto + ")", TotalNeto);
            }
        }
        private void GraficoComprasLineaIVA()
        {
            this.chart2.Titles.Clear();
            this.chart2.Series.Clear();
            this.chart2.Titles.Add("Total Por IVA");
            Series series = this.chart2.Series.Add("Total Por IVA");
            series.ChartType = SeriesChartType.Spline;
            foreach (var item in ListaComprasStatic)
            {
                if (item.Periodo == "TOTALES")
                {
                    ListaComprasStatic.Remove(item);
                    break;
                }
            }
            foreach (var item in ListaComprasStatic)
            {
                decimal TotalIva = item.Iva1 + item.Iva2 + item.Iva3;
                series.Points.AddXY(item.Periodo + "(" + TotalIva + ")", TotalIva);
            }
        }
        private void GraficoComprasLineaMonto()
        {
            this.chart2.Titles.Clear();
            this.chart2.Series.Clear();
            this.chart2.Titles.Add("Total Por Monto");
            Series series = this.chart2.Series.Add("Total Por Monto");
            series.ChartType = SeriesChartType.Spline;
            foreach (var item in ListaComprasStatic)
            {
                if (item.Periodo == "TOTALES")
                {
                    ListaComprasStatic.Remove(item);
                    break;
                }
            }
            foreach (var item in ListaComprasStatic)
            {
                series.Points.AddXY(item.Periodo + "(" + item.Monto + ")", item.Monto);
            }
        }
    }
}
