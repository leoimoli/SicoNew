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
    public partial class VistaConsultaFacturacionComprasMensualWF : Form
    {
        private string cuit;
        private string razonSocial;
        public VistaConsultaFacturacionComprasMensualWF(string razonSocial, string cuit)
        {
            InitializeComponent();
            this.razonSocial = razonSocial;
            this.cuit = cuit;
        }
        private void VistaConsultaFacturacionComprasMensualWF_Load(object sender, EventArgs e)
        {
            try
            {
                lblCuitEdit.Text = cuit;
                lblNombreEdit.Text = razonSocial;
                CargarCombo();
            }
            catch (Exception ex)
            {
                const string message = "Error en el sistema. Intente nuevamente o comuniquese con el administrador.";
                const string caption = "Atención";
                var result = MessageBox.Show(message, caption,
                                             MessageBoxButtons.OK,
                                           MessageBoxIcon.Warning);
                throw new Exception();
            }
        }
        private void CargarCombo()
        {
            string[] Meses = Clases_Maestras.ValoresConstantes.Meses;
            cmbMes.Items.Add("Seleccione");
            cmbMes.Items.Clear();
            foreach (string item in Meses)
            {
                cmbMes.Text = "Seleccione";
                cmbMes.Items.Add(item);
            }
            string[] Años = Clases_Maestras.ValoresConstantes.Años;
            cmbAño.Items.Add("Seleccione");
            cmbAño.Items.Clear();
            foreach (string item in Años)
            {
                cmbAño.Text = "Seleccione";
                cmbAño.Items.Add(item);
            }
        }
        private int ValidarMesSeleccionado(string mesSeleccionado)
        {
            int mes = 0;
            if (mesSeleccionado == "Enero")
                mes = 01;
            if (mesSeleccionado == "Febrero")
                mes = 02;
            if (mesSeleccionado == "Marzo")
                mes = 03;
            if (mesSeleccionado == "Abril")
                mes = 04;
            if (mesSeleccionado == "Mayo")
                mes = 05;
            if (mesSeleccionado == "Junio")
                mes = 06;
            if (mesSeleccionado == "Julio")
                mes = 07;
            if (mesSeleccionado == "Agosto")
                mes = 08;
            if (mesSeleccionado == "Septiembre")
                mes = 09;
            if (mesSeleccionado == "Octubre")
                mes = 10;
            if (mesSeleccionado == "Noviembre")
                mes = 11;
            if (mesSeleccionado == "Diciembre")
                mes = 12;
            return mes;

        }
        private void ProgressBar()
        {
            progressBar1.Visible = true;
            progressBar1.Maximum = 100000;
            progressBar1.Step = 1;

            for (int j = 0; j < 100000; j++)
            {
                Caluculate(j);
                progressBar1.PerformStep();
            }
        }
        private void Caluculate(int i)
        {
            double pow = Math.Pow(i, i);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                groupBox1.Enabled = false;
                groupBox2.Enabled = false;
                ProgressBar();
                string año = cmbAño.Text;
                string MesSeleccionado = cmbMes.Text;
                int mes = ValidarMesSeleccionado(MesSeleccionado);
                ListaTotalFacturacion = ComprasNeg.BuscarFacturacionTotal(cuit, mes, año);
                groupBox1.Enabled = true;
                groupBox2.Enabled = true;
                progressBar1.Value = Convert.ToInt32(null);
                progressBar1.Visible = false;
            }
            catch (Exception ex)
            { }
        }
        public static List<FacturaCompra> Lista;
        public List<Entidades.FacturaCompra> ListaTotalFacturacion
        {
            set
            {
                if (value.Count > 0)
                {

                    Lista = value;
                    if (value != dataGridView1.DataSource && dataGridView1.DataSource != null)
                    {
                        dataGridView1.Columns.Clear();
                        dataGridView1.Refresh();
                    }
                    btnExcel.Visible = true;
                    btnVolver.Visible = true;
                    btnCitiVentas.Visible = true;
                    dataGridView1.Visible = true;
                    dataGridView1.ReadOnly = true;
                    dataGridView1.RowHeadersVisible = false;

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

                    FacturaCompra ultimo = new FacturaCompra();
                    ultimo.NroFactura = "TOTAL";
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
                    dataGridView1.DataSource = value;


                    dataGridView1.Columns[0].HeaderText = "Id Movimiento";
                    dataGridView1.Columns[0].Width = 130;
                    dataGridView1.Columns[0].HeaderCell.Style.BackColor = Color.DarkBlue;
                    dataGridView1.Columns[0].HeaderCell.Style.Font = new System.Drawing.Font("Tahoma", 8, FontStyle.Bold);
                    dataGridView1.Columns[0].HeaderCell.Style.ForeColor = Color.White;
                    dataGridView1.Columns[0].Visible = false;

                    dataGridView1.Columns[1].HeaderText = "Nro.Factura";
                    dataGridView1.Columns[1].Width = 130;
                    dataGridView1.Columns[1].HeaderCell.Style.BackColor = Color.DarkBlue;
                    dataGridView1.Columns[1].HeaderCell.Style.Font = new System.Drawing.Font("Tahoma", 8, FontStyle.Bold);
                    dataGridView1.Columns[1].HeaderCell.Style.ForeColor = Color.White;

                    dataGridView1.Columns[2].HeaderText = "Fecha";
                    dataGridView1.Columns[2].Width = 80;
                    dataGridView1.Columns[2].HeaderCell.Style.BackColor = Color.DarkBlue;
                    dataGridView1.Columns[2].HeaderCell.Style.Font = new System.Drawing.Font("Tahoma", 8, FontStyle.Bold);
                    dataGridView1.Columns[2].HeaderCell.Style.ForeColor = Color.White;

                    dataGridView1.Columns[3].HeaderText = "Monto";
                    dataGridView1.Columns[3].Width = 200;
                    dataGridView1.Columns[3].HeaderCell.Style.BackColor = Color.DarkBlue;
                    dataGridView1.Columns[3].HeaderCell.Style.Font = new System.Drawing.Font("Tahoma", 8, FontStyle.Bold);
                    dataGridView1.Columns[3].HeaderCell.Style.ForeColor = Color.White;
                    dataGridView1.Columns[3].Visible = true;

                    dataGridView1.Columns[4].HeaderText = "id Cliente";
                    dataGridView1.Columns[4].Width = 80;
                    dataGridView1.Columns[4].HeaderCell.Style.BackColor = Color.DarkBlue;
                    dataGridView1.Columns[4].HeaderCell.Style.Font = new System.Drawing.Font("Tahoma", 8, FontStyle.Bold);
                    dataGridView1.Columns[4].HeaderCell.Style.ForeColor = Color.White;
                    dataGridView1.Columns[4].Visible = false;

                    dataGridView1.Columns[5].HeaderText = "id Proveedor";
                    dataGridView1.Columns[5].Width = 250;
                    dataGridView1.Columns[5].HeaderCell.Style.BackColor = Color.DarkBlue;
                    dataGridView1.Columns[5].HeaderCell.Style.Font = new System.Drawing.Font("Tahoma", 8, FontStyle.Bold);
                    dataGridView1.Columns[5].HeaderCell.Style.ForeColor = Color.White;
                    dataGridView1.Columns[5].Visible = false;

                    dataGridView1.Columns[6].HeaderText = "Nombre Proveedor";
                    dataGridView1.Columns[6].Width = 100;
                    dataGridView1.Columns[6].HeaderCell.Style.BackColor = Color.DarkBlue;
                    dataGridView1.Columns[6].HeaderCell.Style.Font = new System.Drawing.Font("Tahoma", 10, FontStyle.Bold);
                    dataGridView1.Columns[6].HeaderCell.Style.ForeColor = Color.White;
                    dataGridView1.Columns[6].Visible = false;

                    dataGridView1.Columns[7].HeaderText = "Codigo Documento";
                    dataGridView1.Columns[7].Width = 95;
                    dataGridView1.Columns[7].HeaderCell.Style.BackColor = Color.DarkBlue;
                    dataGridView1.Columns[7].HeaderCell.Style.Font = new System.Drawing.Font("Tahoma", 8, FontStyle.Bold);
                    dataGridView1.Columns[7].HeaderCell.Style.ForeColor = Color.White;
                    dataGridView1.Columns[7].Visible = false;

                    dataGridView1.Columns[8].HeaderText = "Importe 1";
                    dataGridView1.Columns[8].Visible = false;

                    dataGridView1.Columns[9].HeaderText = "Importe 2";
                    dataGridView1.Columns[9].Visible = false;

                    dataGridView1.Columns[10].HeaderText = "Importe 3";
                    dataGridView1.Columns[10].Visible = false;

                    dataGridView1.Columns[11].HeaderText = "Neto al 10,5";
                    dataGridView1.Columns[11].Visible = true;
                    dataGridView1.Columns[11].Width = 80;
                    dataGridView1.Columns[11].HeaderCell.Style.BackColor = Color.DarkBlue;
                    dataGridView1.Columns[11].HeaderCell.Style.Font = new System.Drawing.Font("Tahoma", 8, FontStyle.Bold);

                    dataGridView1.Columns[12].HeaderText = "Neto al 21";
                    dataGridView1.Columns[12].Visible = true;
                    dataGridView1.Columns[12].Width = 80;
                    dataGridView1.Columns[12].HeaderCell.Style.BackColor = Color.DarkBlue;
                    dataGridView1.Columns[12].HeaderCell.Style.Font = new System.Drawing.Font("Tahoma", 8, FontStyle.Bold);

                    dataGridView1.Columns[13].HeaderText = "Neto al 27";
                    dataGridView1.Columns[13].Visible = true;
                    dataGridView1.Columns[13].Width = 80;
                    dataGridView1.Columns[13].HeaderCell.Style.BackColor = Color.DarkBlue;
                    dataGridView1.Columns[13].HeaderCell.Style.Font = new System.Drawing.Font("Tahoma", 8, FontStyle.Bold);

                    dataGridView1.Columns[14].HeaderText = "alicuota 1";
                    dataGridView1.Columns[14].Visible = false;

                    dataGridView1.Columns[15].HeaderText = "alicuota 2";
                    dataGridView1.Columns[15].Visible = false;

                    dataGridView1.Columns[16].HeaderText = "alicuota 3";
                    dataGridView1.Columns[16].Visible = false;

                    dataGridView1.Columns[17].HeaderText = "Iva al 10,5";
                    dataGridView1.Columns[17].Visible = true;
                    dataGridView1.Columns[17].Width = 80;
                    dataGridView1.Columns[17].HeaderCell.Style.BackColor = Color.DarkBlue;
                    dataGridView1.Columns[17].HeaderCell.Style.Font = new System.Drawing.Font("Tahoma", 8, FontStyle.Bold);

                    dataGridView1.Columns[18].HeaderText = "Iva al 21";
                    dataGridView1.Columns[18].Visible = true;
                    dataGridView1.Columns[18].Width = 80;
                    dataGridView1.Columns[18].HeaderCell.Style.BackColor = Color.DarkBlue;
                    dataGridView1.Columns[18].HeaderCell.Style.Font = new System.Drawing.Font("Tahoma", 8, FontStyle.Bold);

                    dataGridView1.Columns[19].HeaderText = "Iva al 27";
                    dataGridView1.Columns[19].Visible = true;
                    dataGridView1.Columns[19].Width = 80;
                    dataGridView1.Columns[19].HeaderCell.Style.BackColor = Color.DarkBlue;
                    dataGridView1.Columns[19].HeaderCell.Style.Font = new System.Drawing.Font("Tahoma", 8, FontStyle.Bold);

                    dataGridView1.Columns[20].HeaderText = "Codigo Moneda";
                    dataGridView1.Columns[20].Visible = false;

                    dataGridView1.Columns[21].HeaderText = "Codigo Tipo Operacion";
                    dataGridView1.Columns[21].Visible = true;
                    dataGridView1.Columns[21].Width = 80;
                    dataGridView1.Columns[21].HeaderCell.Style.BackColor = Color.DarkBlue;
                    dataGridView1.Columns[21].HeaderCell.Style.Font = new System.Drawing.Font("Tahoma", 8, FontStyle.Bold);
                    dataGridView1.Columns[21].Visible = false;

                    dataGridView1.Columns[22].HeaderText = "Codigo Moneda";
                    dataGridView1.Columns[22].Visible = false;

                    dataGridView1.Columns[23].HeaderText = "Tipo Comprobante";
                    dataGridView1.Columns[23].Visible = false;

                    dataGridView1.Columns[24].HeaderText = "Tipo Comprobante";
                    dataGridView1.Columns[24].Visible = false;

                    dataGridView1.Columns[24].HeaderText = "Tipo Comprobante";
                    dataGridView1.Columns[24].Visible = false;

                    dataGridView1.Columns[24].HeaderText = "Tipo Comprobante";
                    dataGridView1.Columns[24].Visible = false;

                    dataGridView1.Columns[25].HeaderText = "Observacion";
                    dataGridView1.Columns[25].Visible = false;

                    dataGridView1.Columns[26].HeaderText = "Adjunto";
                    dataGridView1.Columns[26].Visible = false;

                    dataGridView1.Columns[27].HeaderText = "Observacion";
                    dataGridView1.Columns[27].Visible = false;

                    dataGridView1.Columns[28].HeaderText = "Adjunto";
                    dataGridView1.Columns[28].Visible = false;

                    dataGridView1.Rows[dataGridView1.Rows.Count - 1].DefaultCellStyle.BackColor = Color.Red;

                }
                else
                {
                    dataGridView1.Visible = false;
                    MessageBox.Show("No se encontraron datos con los parametros ingresados.");
                }
            }
        }
        #region Calculos totales
        private double CalcularTotalIva27(List<FacturaCompra> value)
        {
            decimal totaliva27 = 0;
            decimal MontoNegativoiva27 = 0;
            foreach (var item in value)
            {
                if (item.NroFacturaNotaDeCredtio != "" & item.NroFacturaNotaDeCredtio != null)
                {
                    MontoNegativoiva27 += item.Iva3;
                }
                else { totaliva27 += item.Iva3; }

            }
            double valor = Convert.ToDouble(totaliva27 - MontoNegativoiva27);
            return valor;
        }
        private double CalcularTotalIva21(List<FacturaCompra> value)
        {
            decimal totaliva21 = 0;
            decimal MontoNegativoiva21 = 0;
            foreach (var item in value)
            {
                if (item.NroFacturaNotaDeCredtio != "" & item.NroFacturaNotaDeCredtio != null)
                {
                    MontoNegativoiva21 += item.Iva2;
                }
                else { totaliva21 += item.Iva2; }

            }
            double valor = Convert.ToDouble(totaliva21 - MontoNegativoiva21);
            return valor;
        }
        private double CalcularTotalIva10(List<FacturaCompra> value)
        {
            decimal totaliva10 = 0;
            decimal MontoNegativoiva10 = 0;
            foreach (var item in value)
            {
                if (item.NroFacturaNotaDeCredtio != "" & item.NroFacturaNotaDeCredtio != null)
                {
                    MontoNegativoiva10 += item.Iva1;
                }
                else { totaliva10 += item.Iva1; }

            }
            double valor = Convert.ToDouble(totaliva10 - MontoNegativoiva10);
            return valor;
        }
        private double CalcularTotalNeto27(List<FacturaCompra> value)
        {
            decimal totalNeto27 = 0;
            decimal MontoNegativo27 = 0;
            foreach (var item in value)
            {
                if (item.NroFacturaNotaDeCredtio != "" & item.NroFacturaNotaDeCredtio != null)
                {
                    MontoNegativo27 += item.Neto3;
                }
                else { totalNeto27 += item.Neto3; }

            }
            double valor = Convert.ToDouble(totalNeto27 - MontoNegativo27);
            return valor;
        }
        private double CalcularTotalNeto21(List<FacturaCompra> value)
        {
            decimal totalNeto21 = 0;
            decimal MontoNegativo21 = 0;
            foreach (var item in value)
            {
                if (item.NroFacturaNotaDeCredtio != "" & item.NroFacturaNotaDeCredtio != null)
                {
                    MontoNegativo21 += item.Neto2;
                }
                else { totalNeto21 += item.Neto2; }

            }
            double valor = Convert.ToDouble(totalNeto21 - MontoNegativo21);
            return valor;
        }
        private double CalcularTotalNeto10(List<FacturaCompra> value)
        {
            decimal totalNeto10 = 0;
            decimal MontoNegativo10 = 0;
            foreach (var item in value)
            {
                if (item.NroFacturaNotaDeCredtio != "" & item.NroFacturaNotaDeCredtio != null)
                {
                    MontoNegativo10 += item.Neto1;
                }
                else { totalNeto10 += item.Neto1; }

            }
            double valor = Convert.ToDouble(totalNeto10 - MontoNegativo10);
            return valor;
        }
        private double CalcularTotalImporte3(List<FacturaCompra> value)
        {
            decimal totalImporte3 = 0;
            decimal MontoNegativo3 = 0;
            foreach (var item in value)
            {
                if (item.NroFacturaNotaDeCredtio != "" & item.NroFacturaNotaDeCredtio != null)
                {
                    MontoNegativo3 += item.Total3;
                }
                else { totalImporte3 += item.Total3; }

            }
            double valor = Convert.ToDouble(totalImporte3 - MontoNegativo3);
            return valor;
        }
        private double CalcularTotalImporte2(List<FacturaCompra> value)
        {
            decimal totalImporte2 = 0;
            decimal MontoNegativo2 = 0;
            foreach (var item in value)
            {
                if (item.NroFacturaNotaDeCredtio != "" & item.NroFacturaNotaDeCredtio != null)
                {
                    MontoNegativo2 += item.Total2;
                }
                else { totalImporte2 += item.Total2; }

            }
            double valor = Convert.ToDouble(totalImporte2 - MontoNegativo2);
            return valor;
        }
        private double CalcularTotalImporte1(List<FacturaCompra> value)
        {
            decimal totalImporte1 = 0;
            decimal MontoNegativo1 = 0;
            foreach (var item in value)
            {
                if (item.NroFacturaNotaDeCredtio != "" & item.NroFacturaNotaDeCredtio != null)
                {
                    MontoNegativo1 += item.Total1;
                }
                else { totalImporte1 += item.Total1; }

            }
            double valor = Convert.ToDouble(totalImporte1 - MontoNegativo1);
            return valor;
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
        #endregion

        private void btnVolver_Click(object sender, EventArgs e)
        {
            ComprasWF _tarea = new ComprasWF(razonSocial, cuit);
            _tarea.Show();
            Close();
        }
    }
}
