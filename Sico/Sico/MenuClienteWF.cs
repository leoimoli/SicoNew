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

        }
        private void CargarCombo()
        {
            string[] Años = Clases_Maestras.ValoresConstantes.Años;
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
            TareaClienteWF _tarea = new TareaClienteWF(RazonSocial, Cuit);
            _tarea.Show();
            Hide();
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
            ListaTotalFacturacion = ComprasNeg.FacturacionAnualPorPeriodos(cuit, año);
        }
        private void cmbAñoVentas_SelectedIndexChanged(object sender, EventArgs e)
        {
            string año = cmbAñoVentas.Text;
            ListaTotalFacturacionVentas = ComprasNeg.FacturacionAnualVentasPorPeriodos(cuit, año);
        }
        public List<Entidades.FacturaCompraAnual> ListaTotalFacturacion
        {
            set
            {
                if (value.Count > 0)
                {

                    if (value != dgvComprasAnuales.DataSource && dgvComprasAnuales.DataSource != null)
                    {
                        dgvComprasAnuales.Columns.Clear();
                        dgvComprasAnuales.Refresh();
                    }
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
                    MessageBox.Show("No se encontraron datos con los parametros ingresados.");
                }
            }
        }
        public List<Entidades.FacturaVentaAnual> ListaTotalFacturacionVentas
        {
            set
            {
                if (value.Count > 0)
                {

                    if (value != dgvVentasAnuales.DataSource && dgvVentasAnuales.DataSource != null)
                    {
                        dgvVentasAnuales.Columns.Clear();
                        dgvVentasAnuales.Refresh();
                    }
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
                    MessageBox.Show("No se encontraron datos con los parametros ingresados.");
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
                //if (item.NroFacturaNotaDeCredtio != "" & item.NroFacturaNotaDeCredtio != null)
                //{
                //    MontoNegativo += item.NoGravado;
                //}
                //else {
                totalPercepIva += item.PercepIva;
                //}

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
                //if (item.NroFacturaNotaDeCredtio != "" & item.NroFacturaNotaDeCredtio != null)
                //{
                //    MontoNegativo += item.PercepIngBrutos;
                //}
                //else {
                totalPercepIngBrutos += item.PercepIngBrutos;
                //}

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
                //if (item.NroFacturaNotaDeCredtio != "" & item.NroFacturaNotaDeCredtio != null)
                //{
                //    MontoNegativoiva27 += item.Iva3;
                //}
                //else {
                totaliva27 += item.Iva3;
                //}

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
                //if (item.NroFacturaNotaDeCredtio != "" & item.NroFacturaNotaDeCredtio != null)
                //{
                //    MontoNegativoiva21 += item.Iva2;
                //}
                //else {
                totaliva21 += item.Iva2;
                //}

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
                //if (item.NroFacturaNotaDeCredtio != "" & item.NroFacturaNotaDeCredtio != null)
                //{
                //    MontoNegativoiva10 += item.Iva1;
                //}
                //else {
                totaliva10 += item.Iva1;
                //}

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
                //if (item.NroFacturaNotaDeCredtio != "" & item.NroFacturaNotaDeCredtio != null)
                //{
                //    MontoNegativo27 += item.Neto3;
                //}
                //else {
                totalNeto27 += item.Neto3;
                //}

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
                //    if (item.NroFacturaNotaDeCredtio != "" & item.NroFacturaNotaDeCredtio != null)
                //    {
                //        MontoNegativo21 += item.Neto2;
                //    }
                //    else {
                totalNeto21 += item.Neto2;
                //}

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
                //if (item.NroFacturaNotaDeCredtio != "" & item.NroFacturaNotaDeCredtio != null)
                //{
                //    MontoNegativo10 += item.Neto1;
                //}
                //else {
                totalNeto10 += item.Neto1;
                //}

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
                //if (item.NroFacturaNotaDeCredtio != "" & item.NroFacturaNotaDeCredtio != null)
                //{
                //    MontoNegativo3 += item.Total3;
                //}
                //else {
                totalImporte3 += item.Total3;
                //}

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
                //if (item.NroFacturaNotaDeCredtio != "" & item.NroFacturaNotaDeCredtio != null)
                //{
                //    MontoNegativo2 += item.Total2;
                //}
                //else {
                totalImporte2 += item.Total2;
                //}

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
        private double CalcularTotalMonto(List<FacturaCompraAnual> value)
        {
            decimal totalMonto = 0;
            decimal MontoNegativo = 0;
            foreach (var item in value)
            {
                //if (item.NroFacturaNotaDeCredtio != "" & item.NroFacturaNotaDeCredtio != null)
                //{
                //    MontoNegativo += item.Monto;
                //}
                //else {
                totalMonto += item.Monto;
                //}

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
                //if (item.NroFacturaNotaDeCredtio != "" & item.NroFacturaNotaDeCredtio != null)
                //{
                //    MontoNegativo += item.NoGravado;
                //}
                //else {
                totalnoGravado += item.NoGravado;
                //}

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
                //if (item.NroFacturaNotaDeCredtio != "" & item.NroFacturaNotaDeCredtio != null)
                //{
                //    MontoNegativoiva27 += item.Iva3;
                //}
                //else {
                totaliva27 += item.Iva3;
                //}

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
                //if (item.NroFacturaNotaDeCredtio != "" & item.NroFacturaNotaDeCredtio != null)
                //{
                //    MontoNegativoiva21 += item.Iva2;
                //}
                //else {
                totaliva21 += item.Iva2;
                //}

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
                //if (item.NroFacturaNotaDeCredtio != "" & item.NroFacturaNotaDeCredtio != null)
                //{
                //    MontoNegativoiva10 += item.Iva1;
                //}
                //else {
                totaliva10 += item.Iva1;
                //}

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
                //if (item.NroFacturaNotaDeCredtio != "" & item.NroFacturaNotaDeCredtio != null)
                //{
                //    MontoNegativo27 += item.Neto3;
                //}
                //else {
                totalNeto27 += item.Neto3;
                //}

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
                //    if (item.NroFacturaNotaDeCredtio != "" & item.NroFacturaNotaDeCredtio != null)
                //    {
                //        MontoNegativo21 += item.Neto2;
                //    }
                //    else {
                totalNeto21 += item.Neto2;
                //}

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
                //if (item.NroFacturaNotaDeCredtio != "" & item.NroFacturaNotaDeCredtio != null)
                //{
                //    MontoNegativo10 += item.Neto1;
                //}
                //else {
                totalNeto10 += item.Neto1;
                //}

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
                //if (item.NroFacturaNotaDeCredtio != "" & item.NroFacturaNotaDeCredtio != null)
                //{
                //    MontoNegativo3 += item.Total3;
                //}
                //else {
                totalImporte3 += item.Total3;
                //}

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
                //if (item.NroFacturaNotaDeCredtio != "" & item.NroFacturaNotaDeCredtio != null)
                //{
                //    MontoNegativo2 += item.Total2;
                //}
                //else {
                totalImporte2 += item.Total2;
                //}

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
                //if (item.NroFacturaNotaDeCredtio != "" & item.NroFacturaNotaDeCredtio != null)
                //{
                //    MontoNegativo += item.Monto;
                //}
                //else {
                totalMonto += item.Monto;
                //}

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
    }
}
