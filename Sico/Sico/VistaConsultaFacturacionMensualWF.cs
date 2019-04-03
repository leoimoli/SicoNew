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
using Sico.Entidades;
using Sico.Clases_Maestras;
using System.IO;
using System.Text.RegularExpressions;

namespace Sico
{
    public partial class VistaConsultaFacturacionMensualWF : Form
    {
        private string cuit;
        private string razonSocial;
        public VistaConsultaFacturacionMensualWF(string razonSocial, string cuit)
        {
            InitializeComponent();
            this.razonSocial = razonSocial;
            this.cuit = cuit;
        }
        private void VistaConsultaFacturacionMensualWF_Load(object sender, EventArgs e)
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
        public List<Entidades.SubCliente> ListaTotalFacturacion
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

                    SubCliente ultimo = new SubCliente();
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

                    dataGridView1.Columns[3].HeaderText = "Persona";
                    dataGridView1.Columns[3].Width = 200;
                    dataGridView1.Columns[3].HeaderCell.Style.BackColor = Color.DarkBlue;
                    dataGridView1.Columns[3].HeaderCell.Style.Font = new System.Drawing.Font("Tahoma", 8, FontStyle.Bold);
                    dataGridView1.Columns[3].HeaderCell.Style.ForeColor = Color.White;
                    dataGridView1.Columns[3].Visible = true;

                    dataGridView1.Columns[4].HeaderText = "Dni";
                    dataGridView1.Columns[4].Width = 80;
                    dataGridView1.Columns[4].HeaderCell.Style.BackColor = Color.DarkBlue;
                    dataGridView1.Columns[4].HeaderCell.Style.Font = new System.Drawing.Font("Tahoma", 8, FontStyle.Bold);
                    dataGridView1.Columns[4].HeaderCell.Style.ForeColor = Color.White;
                    dataGridView1.Columns[4].Visible = false;

                    dataGridView1.Columns[5].HeaderText = "Dirección";
                    dataGridView1.Columns[5].Width = 250;
                    dataGridView1.Columns[5].HeaderCell.Style.BackColor = Color.DarkBlue;
                    dataGridView1.Columns[5].HeaderCell.Style.Font = new System.Drawing.Font("Tahoma", 8, FontStyle.Bold);
                    dataGridView1.Columns[5].HeaderCell.Style.ForeColor = Color.White;
                    dataGridView1.Columns[5].Visible = false;

                    dataGridView1.Columns[6].HeaderText = "Monto";
                    dataGridView1.Columns[6].Width = 100;
                    dataGridView1.Columns[6].HeaderCell.Style.BackColor = Color.DarkBlue;
                    dataGridView1.Columns[6].HeaderCell.Style.Font = new System.Drawing.Font("Tahoma", 10, FontStyle.Bold);
                    dataGridView1.Columns[6].HeaderCell.Style.ForeColor = Color.White;
                    dataGridView1.Columns[6].Visible = true;

                    dataGridView1.Columns[7].HeaderText = "Cliente";
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

                    dataGridView1.Columns[20].HeaderText = "Observacion";
                    dataGridView1.Columns[20].Visible = false;

                    dataGridView1.Columns[21].HeaderText = "Nota De Credito";
                    dataGridView1.Columns[21].Visible = true;
                    dataGridView1.Columns[18].Width = 80;
                    dataGridView1.Columns[18].HeaderCell.Style.BackColor = Color.DarkBlue;
                    dataGridView1.Columns[18].HeaderCell.Style.Font = new System.Drawing.Font("Tahoma", 8, FontStyle.Bold);

                    dataGridView1.Rows[dataGridView1.Rows.Count - 1].DefaultCellStyle.BackColor = Color.Red;

                }
                else
                {
                    dataGridView1.Visible = false;
                    MessageBox.Show("No se encontraron datos con los parametros ingresados.");
                }
            }
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
        #region Calculos totales
        private double CalcularTotalIva27(List<SubCliente> value)
        {
            decimal totaliva27 = 0;
            decimal MontoNegativoiva27 = 0;
            foreach (var item in value)
            {
                if (item.NroFacturaNotaDeCredtio != "")
                {
                    MontoNegativoiva27 += item.Iva3;
                }
                else { totaliva27 += item.Iva3; }

            }
            double valor = Convert.ToDouble(totaliva27 - MontoNegativoiva27);
            return valor;
        }
        private double CalcularTotalIva21(List<SubCliente> value)
        {
            decimal totaliva21 = 0;
            decimal MontoNegativoiva21 = 0;
            foreach (var item in value)
            {
                if (item.NroFacturaNotaDeCredtio != "")
                {
                    MontoNegativoiva21 += item.Iva2;
                }
                else { totaliva21 += item.Iva2; }

            }
            double valor = Convert.ToDouble(totaliva21 - MontoNegativoiva21);
            return valor;
        }
        private double CalcularTotalIva10(List<SubCliente> value)
        {
            decimal totaliva10 = 0;
            decimal MontoNegativoiva10 = 0;
            foreach (var item in value)
            {
                if (item.NroFacturaNotaDeCredtio != "")
                {
                    MontoNegativoiva10 += item.Iva1;
                }
                else { totaliva10 += item.Iva1; }

            }
            double valor = Convert.ToDouble(totaliva10 - MontoNegativoiva10);
            return valor;
        }
        private double CalcularTotalNeto27(List<SubCliente> value)
        {
            decimal totalNeto27 = 0;
            decimal MontoNegativo27 = 0;
            foreach (var item in value)
            {
                if (item.NroFacturaNotaDeCredtio != "")
                {
                    MontoNegativo27 += item.Neto3;
                }
                else { totalNeto27 += item.Neto3; }

            }
            double valor = Convert.ToDouble(totalNeto27 - MontoNegativo27);
            return valor;
        }
        private double CalcularTotalNeto21(List<SubCliente> value)
        {
            decimal totalNeto21 = 0;
            decimal MontoNegativo21 = 0;
            foreach (var item in value)
            {
                if (item.NroFacturaNotaDeCredtio != "")
                {
                    MontoNegativo21 += item.Neto2;
                }
                else { totalNeto21 += item.Neto2; }

            }
            double valor = Convert.ToDouble(totalNeto21 - MontoNegativo21);
            return valor;
        }
        private double CalcularTotalNeto10(List<SubCliente> value)
        {
            decimal totalNeto10 = 0;
            decimal MontoNegativo10 = 0;
            foreach (var item in value)
            {
                if (item.NroFacturaNotaDeCredtio != "")
                {
                    MontoNegativo10 += item.Neto1;
                }
                else { totalNeto10 += item.Neto1; }

            }
            double valor = Convert.ToDouble(totalNeto10 - MontoNegativo10);
            return valor;
        }
        private double CalcularTotalImporte3(List<SubCliente> value)
        {
            decimal totalImporte3 = 0;
            decimal MontoNegativo3 = 0;
            foreach (var item in value)
            {
                if (item.NroFacturaNotaDeCredtio != "")
                {
                    MontoNegativo3 += item.Total3;
                }
                else { totalImporte3 += item.Total3; }

            }
            double valor = Convert.ToDouble(totalImporte3 - MontoNegativo3);
            return valor;
        }
        private double CalcularTotalImporte2(List<SubCliente> value)
        {
            decimal totalImporte2 = 0;
            decimal MontoNegativo2 = 0;
            foreach (var item in value)
            {
                if (item.NroFacturaNotaDeCredtio != "")
                {
                    MontoNegativo2 += item.Total2;
                }
                else { totalImporte2 += item.Total2; }

            }
            double valor = Convert.ToDouble(totalImporte2 - MontoNegativo2);
            return valor;
        }
        private double CalcularTotalImporte1(List<SubCliente> value)
        {
            decimal totalImporte1 = 0;
            decimal MontoNegativo1 = 0;
            foreach (var item in value)
            {
                if (item.NroFacturaNotaDeCredtio != "")
                {
                    MontoNegativo1 += item.Total1;
                }
                else { totalImporte1 += item.Total1; }

            }
            double valor = Convert.ToDouble(totalImporte1 - MontoNegativo1);
            return valor;
        }
        private double CalcularTotalMonto(List<SubCliente> value)
        {
            decimal totalMonto = 0;
            decimal MontoNegativo = 0;
            foreach (var item in value)
            {
                if (item.NroFacturaNotaDeCredtio != "")
                {
                    MontoNegativo += item.Monto;
                }
                else { totalMonto += item.Monto; }

            }
            double valor = Convert.ToDouble(totalMonto - MontoNegativo);
            return valor;
        }
        #endregion
        public static List<SubCliente> Lista;
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
                ListaTotalFacturacion = ClienteNeg.BuscarFacturacionTotal(cuit, mes, año);
                groupBox1.Enabled = true;
                groupBox2.Enabled = true;
                progressBar1.Value = Convert.ToInt32(null);
                progressBar1.Visible = false;
            }
            catch (Exception ex)
            { }
        }
        private void btnVolver_Click(object sender, EventArgs e)
        {
            TareaClienteWF _tarea = new TareaClienteWF(razonSocial, cuit);
            _tarea.Show();
            Close();
        }
        private void btnExcel_Click(object sender, EventArgs e)
        {
            dataGridView1.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            dataGridView1.MultiSelect = true;
            dataGridView1.SelectAll();
            DataObject dataObj = dataGridView1.GetClipboardContent();
            if (dataObj != null)
                Clipboard.SetDataObject(dataObj);
            //Open an excel instance and paste the copied data
            Microsoft.Office.Interop.Excel.Application xlexcel;
            Microsoft.Office.Interop.Excel.Workbook xlWorkBook;
            Microsoft.Office.Interop.Excel.Worksheet xlWorkSheet;
            object misValue = System.Reflection.Missing.Value;
            xlexcel = new Microsoft.Office.Interop.Excel.Application();
            xlexcel.Visible = true;
            xlWorkBook = xlexcel.Workbooks.Add(misValue);
            xlWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
            Microsoft.Office.Interop.Excel.Range CR = (Microsoft.Office.Interop.Excel.Range)xlWorkSheet.Cells[1, 1];
            CR.Select();
            xlWorkSheet.PasteSpecial(CR, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, true);
        }
        private void btnCitiVentas_Click(object sender, EventArgs e)
        {
            ProgressBar();
            VentasTXTSiap ruta = new VentasTXTSiap();
            DateTime FechaArchivo = DateTime.Now;
            string NombreTxt = lblNombreEdit.Text;
            string FechaFormato = FechaArchivo.ToString("yyyyMMdd");
            var GuardarFichero = NombreTxt + FechaFormato;
            string path = ruta.Carpeta + "\\" + GuardarFichero + ".txt";
            //string path = @"C:\Users\limoli\Desktop\Txt\" + NombreTxt + ".txt";
            if (!File.Exists(path))
            {
                // Create a file to write to.
                using (StreamWriter sw = File.CreateText(path))
                {

                    //string Blancos = " ";
                    //int restan = 0;
                    foreach (var item in Lista)
                    {
                        if (item.Fecha != null)
                        {
                            string patron = @"[^\w]";
                            Regex regex = new Regex(patron);
                            int totalCaracteres = 0;
                            //////Fecha
                            DateTime Fecha = Convert.ToDateTime(item.Fecha);
                            string dateFormatted = Fecha.ToString("yyyyMMdd");
                            string FechaFinal = dateFormatted;
                            totalCaracteres = FechaFinal.Length;


                            //////Tipo Comprobante
                            string TipoComprobante = "006";
                            totalCaracteres = totalCaracteres + TipoComprobante.Length;
                            //////Punto de Venta
                            string var = item.NroFactura;
                            var split1 = var.Split('-')[0];
                            split1 = split1.Trim();
                            string PuntoDeVenta = split1;

                            if (PuntoDeVenta.Length < 5)
                            {
                                PuntoDeVenta = PuntoDeVenta.PadLeft(5, '0');
                            }
                            totalCaracteres = totalCaracteres + PuntoDeVenta.Length;
                            //////"Número de Comprobante"
                            string Factura = item.NroFactura;
                            var FacturaSegundaParte = var.Split('-')[1];
                            FacturaSegundaParte = FacturaSegundaParte.Trim();
                            if (FacturaSegundaParte.Length < 20)
                            {
                                FacturaSegundaParte = FacturaSegundaParte.PadLeft(20, '0');
                            }
                            totalCaracteres = totalCaracteres + FacturaSegundaParte.Length * 2;
                            //////""Código de Documento del comprador
                            string CodigoDocumentoComprador = "96";
                            totalCaracteres = totalCaracteres + CodigoDocumentoComprador.Length;
                            //////""Número de Identificación del comprador"
                            string Dni = item.Dni;
                            if (Dni.Length < 20)
                            {
                                Dni = Dni.PadLeft(20, '0');
                            }
                            totalCaracteres = totalCaracteres + Dni.Length;
                            //////"Apellido y Nombre"
                            string ApellidoNombre = item.ApellidoNombre;
                            if (ApellidoNombre.Length < 30)
                            {
                                ApellidoNombre = ApellidoNombre.PadRight(30, ' ');
                            }
                            totalCaracteres = totalCaracteres + ApellidoNombre.Length;
                            //////"Importe total de la de la operacion"


                            //string Monto = Convert.ToString(item.Monto);
                            string MontoContar = Convert.ToString(item.Monto);
                            MontoContar = regex.Replace(MontoContar, "");
                            if (MontoContar.Length < 15)
                            {
                                MontoContar = MontoContar.PadLeft(15, '0');
                                // Monto = Convert.ToString(MontoContar);
                            }
                            totalCaracteres = totalCaracteres + MontoContar.Length;
                            //////"importe total de concepto que no integran"
                            double ImpTotalConcep = 0;
                            string ImpTotalConcepContar = Convert.ToString(ImpTotalConcep);
                            ImpTotalConcepContar = regex.Replace(ImpTotalConcepContar, "");
                            if (ImpTotalConcepContar.Length < 15)
                            {
                                ImpTotalConcepContar = ImpTotalConcepContar.PadLeft(15, '0');
                                ImpTotalConcep = Convert.ToDouble(ImpTotalConcepContar);
                            }
                            totalCaracteres = totalCaracteres + ImpTotalConcepContar.Length;

                            ////// Percepcion a no categorizados
                            double PercNoCatego = 0;
                            string PercNoCategoContar = Convert.ToString(PercNoCatego);
                            PercNoCategoContar = regex.Replace(PercNoCategoContar, "");
                            if (PercNoCategoContar.Length < 15)
                            {
                                PercNoCategoContar = PercNoCategoContar.PadLeft(15, '0');
                                PercNoCatego = Convert.ToDouble(PercNoCategoContar);
                            }
                            totalCaracteres = totalCaracteres + PercNoCategoContar.Length;
                            ////// Importe de operaciones exentas.
                            double ImpOpeExe = 0;
                            string ImpOpeExeContar = Convert.ToString(ImpOpeExe);
                            ImpOpeExeContar = regex.Replace(ImpOpeExeContar, "");
                            if (ImpOpeExeContar.Length < 15)
                            {
                                ImpOpeExeContar = ImpOpeExeContar.PadLeft(15, '0');
                                ImpOpeExe = Convert.ToDouble(ImpOpeExeContar);
                            }
                            totalCaracteres = totalCaracteres + ImpOpeExeContar.Length;
                            ////// Importe percepciones o pagos a cuenta de impuestos 
                            double ImpPerPagoImp = 0;
                            string ImpPerPagoImpContar = Convert.ToString(ImpPerPagoImp);
                            ImpPerPagoImpContar = regex.Replace(ImpPerPagoImpContar, "");
                            if (ImpPerPagoImpContar.Length < 15)
                            {
                                ImpPerPagoImpContar = ImpPerPagoImpContar.PadLeft(15, '0');
                                ImpPerPagoImp = Convert.ToDouble(ImpPerPagoImpContar);
                            }

                            totalCaracteres = totalCaracteres + ImpPerPagoImpContar.Length;
                            ////// Importe percepciones ingresos bruto
                            double IImpPerIngBrutos = 0;
                            string IImpPerIngBrutosContar = Convert.ToString(IImpPerIngBrutos);
                            IImpPerIngBrutosContar = regex.Replace(IImpPerIngBrutosContar, "");
                            if (IImpPerIngBrutosContar.Length < 15)
                            {
                                IImpPerIngBrutosContar = IImpPerIngBrutosContar.PadLeft(15, '0');
                                IImpPerIngBrutos = Convert.ToDouble(IImpPerIngBrutosContar);
                            }
                            totalCaracteres = totalCaracteres + IImpPerIngBrutosContar.Length;
                            ////// Importe percepciones de impuesto municipales
                            double IImpPerImpMun = 0;
                            string IImpPerImpMunContar = Convert.ToString(IImpPerImpMun);
                            IImpPerImpMunContar = regex.Replace(IImpPerImpMunContar, "");
                            if (IImpPerImpMunContar.Length < 15)
                            {
                                IImpPerImpMunContar = IImpPerImpMunContar.PadLeft(15, '0');
                                IImpPerImpMun = Convert.ToDouble(IImpPerImpMunContar);
                            }
                            totalCaracteres = totalCaracteres + IImpPerImpMunContar.Length;
                            ////// Importe  de impuesto internos
                            double ImpImpInt = 0;
                            string ImpImpIntContar = Convert.ToString(ImpImpInt);
                            ImpImpIntContar = regex.Replace(ImpImpIntContar, "");
                            if (ImpImpIntContar.Length < 15)
                            {
                                ImpImpIntContar = ImpImpIntContar.PadLeft(15, '0');
                                ImpImpInt = Convert.ToDouble(ImpImpIntContar);
                            }
                            totalCaracteres = totalCaracteres + ImpImpIntContar.Length;
                            ////// Codigo de moneda
                            string CodMoneda = "PES";
                            totalCaracteres = totalCaracteres + CodMoneda.Length;
                            ////// Tipo de Cambio

                            string TipoCambio = "0001000000";
                            if (TipoCambio.Length == 1)
                            {
                                TipoCambio = TipoCambio.PadLeft(10, '0');
                            }
                            totalCaracteres = totalCaracteres + TipoCambio.Length;
                            //////Cantida Alicuotas
                            int cantidadAlicuotas = 0;

                            if (item.Neto1 > 0)
                            {
                                cantidadAlicuotas = cantidadAlicuotas + 1;
                            }
                            if (item.Neto2 > 0)
                            {
                                cantidadAlicuotas = cantidadAlicuotas + 1;
                            }
                            if (item.Neto3 > 0)
                            {
                                cantidadAlicuotas = cantidadAlicuotas + 1;
                            }
                            string contar = Convert.ToString(cantidadAlicuotas);
                            totalCaracteres = totalCaracteres + contar.Length;
                            //////Código Operación
                            int CodOperacion = 0;
                            string ContarCodigo = Convert.ToString(CodOperacion);
                            totalCaracteres = totalCaracteres + ContarCodigo.Length;
                            //////Otro Tributo
                            double OtroTributo = 0;
                            string OtroTributoContar = Convert.ToString(OtroTributo);
                            OtroTributoContar = regex.Replace(OtroTributoContar, "");
                            if (OtroTributoContar.Length < 15)
                            {
                                OtroTributoContar = OtroTributoContar.PadLeft(15, '0');
                                OtroTributo = Convert.ToDouble(OtroTributoContar);
                            }
                            totalCaracteres = totalCaracteres + OtroTributoContar.Length;
                            ////// Fecha de vencimiento
                            DateTime Fecha2 = Convert.ToDateTime(item.Fecha);
                            string dateFormatted2 = Fecha2.ToString("yyyyMMdd");
                            string FechaFinal2 = dateFormatted2;
                            totalCaracteres = totalCaracteres + FechaFinal2.Length;
                            if (totalCaracteres == 266)
                            {
                                sw.WriteLine(FechaFinal + TipoComprobante + PuntoDeVenta + FacturaSegundaParte + FacturaSegundaParte + CodigoDocumentoComprador + Dni + ApellidoNombre + MontoContar + ImpTotalConcepContar + PercNoCategoContar + ImpOpeExeContar + ImpPerPagoImpContar + IImpPerIngBrutosContar + IImpPerImpMunContar + ImpImpIntContar + CodMoneda + TipoCambio + cantidadAlicuotas + CodOperacion + OtroTributoContar + FechaFinal2); /*+ Neto + CodigoIva + Iva);*/
                            }

                        }
                    }
                }
                GenerarTXTVentasalicuotas();
                MessageBox.Show("Se generaron los TXT de Ventas y ventas Alicuotas.");
                progressBar1.Value = Convert.ToInt32(null);
                progressBar1.Visible = false;
            }
            else
            {
                MessageBox.Show("Ya existe un archivo guardado con el mismo nombre.");
                progressBar1.Value = Convert.ToInt32(null);
                progressBar1.Visible = false;
            }
            //// Open the file to read from.
            //using (StreamReader sr = File.OpenText(path))
            //{
            //    string s = "";
            //    while ((s = sr.ReadLine()) != null)
            //    {
            //        Console.WriteLine(s);
            //    }
            //}
        }
        private void GenerarTXTVentasalicuotas()
        {
            VentasTXTAlicuota ruta = new VentasTXTAlicuota();
            DateTime FechaArchivo = DateTime.Now;
            string NombreTxt = lblNombreEdit.Text;
            string FechaFormato = FechaArchivo.ToString("yyyyMMdd");
            var GuardarFichero = "Alicuotas -" + NombreTxt + FechaFormato;
            string path = ruta.Carpeta + "\\" + GuardarFichero + ".txt";
            if (!File.Exists(path))
            {
                // Create a file to write to.
                using (StreamWriter sw = File.CreateText(path))
                {
                    //string Blancos = " ";
                    //int restan = 0;
                    foreach (var item in Lista)
                    {
                        if (item.Fecha != null)
                        {
                            string patron = @"[^\w]";
                            Regex regex = new Regex(patron);
                            int totalCaracteres = 0;
                            //////Tipo Comprobante
                            string TipoComprobante = "006";
                            totalCaracteres = totalCaracteres + TipoComprobante.Length;
                            //////Punto de Venta
                            string var = item.NroFactura;
                            var split1 = var.Split('-')[0];
                            split1 = split1.Trim();
                            string PuntoDeVenta = split1;

                            if (PuntoDeVenta.Length < 5)
                            {
                                PuntoDeVenta = PuntoDeVenta.PadLeft(5, '0');
                            }
                            totalCaracteres = totalCaracteres + PuntoDeVenta.Length;

                            //////"Número de Comprobante"
                            string Factura = item.NroFactura;
                            var FacturaSegundaParte = var.Split('-')[1];
                            FacturaSegundaParte = FacturaSegundaParte.Trim();
                            if (FacturaSegundaParte.Length < 20)
                            {
                                FacturaSegundaParte = FacturaSegundaParte.PadLeft(20, '0');
                            }
                            totalCaracteres = totalCaracteres + FacturaSegundaParte.Length;
                            //// Importe Neto  gravado

                            double Neto = 0;
                            string NetoContar = Convert.ToString(Neto);
                            NetoContar = regex.Replace(NetoContar, "");
                            if (item.Neto1 > 0)
                            {
                                NetoContar = Convert.ToString(item.Neto1);
                                NetoContar = regex.Replace(NetoContar, "");
                                if (NetoContar.Length < 15)
                                {
                                    NetoContar = NetoContar.PadLeft(15, '0');
                                }
                            }
                            if (item.Neto2 > 0)
                            {
                                NetoContar = Convert.ToString(item.Neto2);
                                NetoContar = regex.Replace(NetoContar, "");
                                if (NetoContar.Length < 15)
                                {
                                    NetoContar = NetoContar.PadLeft(15, '0');
                                }
                            }
                            if (item.Neto3 > 0)
                            {
                                NetoContar = Convert.ToString(item.Neto3);
                                NetoContar = regex.Replace(NetoContar, "");
                                if (NetoContar.Length < 15)
                                {
                                    NetoContar = NetoContar.PadLeft(15, '0');
                                }
                            }
                            totalCaracteres = totalCaracteres + NetoContar.Length;
                            ///// Alicuota de Iva
                            string codigo = "";
                            Double CodigoIva = 0;
                            if (item.Iva1 > 0)
                            {
                                codigo = "4";
                                if (codigo.Length < 4)
                                {
                                    codigo = codigo.PadLeft(4, '0');
                                }
                                CodigoIva = Convert.ToDouble(codigo);
                            }
                            if (item.Iva2 > 0)
                            {
                                codigo = "5";
                                if (codigo.Length < 4)
                                {
                                    codigo = codigo.PadLeft(4, '0');
                                }
                                CodigoIva = Convert.ToDouble(codigo);
                            }
                            if (item.Iva3 > 0)
                            {
                                codigo = "6";
                                if (codigo.Length < 4)
                                {
                                    codigo = codigo.PadLeft(4, '0');
                                }
                                CodigoIva = Convert.ToDouble(codigo);
                            }
                            totalCaracteres = totalCaracteres + codigo.Length;
                            ///// Iva liquidado
                            double Iva = 0;
                            string IvaContar = Convert.ToString(Iva);
                            if (item.Iva1 > 0)
                            {
                                IvaContar = Convert.ToString(item.Iva1);
                                IvaContar = regex.Replace(IvaContar, "");
                                if (IvaContar.Length < 15)
                                {
                                    IvaContar = IvaContar.PadLeft(15, '0');
                                }
                            }
                            if (item.Iva2 > 0)
                            {
                                IvaContar = Convert.ToString(item.Iva2);
                                IvaContar = regex.Replace(IvaContar, "");
                                if (IvaContar.Length < 15)
                                {
                                    IvaContar = IvaContar.PadLeft(15, '0');
                                }
                            }
                            if (item.Iva3 > 0)
                            {
                                IvaContar = Convert.ToString(item.Iva3);
                                IvaContar = regex.Replace(IvaContar, "");
                                if (IvaContar.Length < 15)
                                {
                                    IvaContar = IvaContar.PadLeft(15, '0');
                                }
                            }
                            totalCaracteres = totalCaracteres + IvaContar.Length;
                            if (totalCaracteres == 62)
                            {
                                sw.WriteLine(TipoComprobante + PuntoDeVenta + FacturaSegundaParte + NetoContar + codigo + IvaContar);
                            }
                        }
                    }
                }
            }
        }
    }
}