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

                string año = cmbAño.Text;
                string MesSeleccionado = cmbMes.Text;
                int mes = ValidarMesSeleccionado(MesSeleccionado);
                ListaTotalFacturacion = ClienteNeg.BuscarFacturacionTotal(cuit, mes, año);
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
            ArchivosParaSiap ruta = new ArchivosParaSiap();
            string NombreTxt = lblNombreEdit.Text;
            //string path = ruta.Carpeta + "\\" + NombreTxt + ".txt";
            string path = @"C:\Users\limoli\Desktop\Txt\" + NombreTxt + ".txt";
            if (!File.Exists(path))
            {
                // Create a file to write to.
                using (StreamWriter sw = File.CreateText(path))
                {
                    string Blancos = " ";
                    int restan = 0;
                    foreach (var item in Lista)
                    {
                        if (item.Fecha != null)
                        {
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
                                //char pad = '0';
                                PuntoDeVenta = PuntoDeVenta.PadLeft(1, '0');
                                //restan = 5 - PuntoDeVenta.Length;
                                //Console.WriteLine(PuntoDeVenta.PadLeft(restan, pad));
                            }
                            totalCaracteres = totalCaracteres + PuntoDeVenta.Length;
                            //////"Número de Comprobante"
                            string Factura = item.NroFactura;
                            var FacturaSegundaParte = var.Split('-')[1];
                            FacturaSegundaParte = FacturaSegundaParte.Trim();
                            totalCaracteres = totalCaracteres + FacturaSegundaParte.Length;
                            //////""Código de Documento del comprador
                            string CodigoDocumentoComprador = "96";
                            totalCaracteres = totalCaracteres + CodigoDocumentoComprador.Length;
                            //////""Número de Identificación del comprador"
                            string Dni = item.Dni;
                            totalCaracteres = totalCaracteres + Dni.Length;
                            //////"Apellido y Nombre"
                            string ApellidoNombre = item.ApellidoNombre;
                            totalCaracteres = totalCaracteres + ApellidoNombre.Length;
                            //////"Importe total de la de la operacion"
                            decimal Monto = item.Monto;
                            string MontoContar = Convert.ToString(Monto);
                            totalCaracteres = totalCaracteres + MontoContar.Length;
                            //////"importe total de concepto que no integran"
                            string ImpTotalConcep = "0";
                            totalCaracteres = totalCaracteres + ImpTotalConcep.Length;
                            ////// Percepcion a no categorizados
                            string PercNoCatego = "0";
                            totalCaracteres = totalCaracteres + PercNoCatego.Length;
                            ////// Importe de operaciones exentas.
                            string ImpOpeExe = "0";
                            totalCaracteres = totalCaracteres + ImpOpeExe.Length;
                            ////// Importe percepciones o pagos a cuenta de impuestos 
                            string ImpPerPagoImp = "0";
                            totalCaracteres = totalCaracteres + ImpPerPagoImp.Length;
                            ////// Importe percepciones ingresos bruto
                            string IImpPerIngBrutos = "0";
                            totalCaracteres = totalCaracteres + IImpPerIngBrutos.Length;
                            ////// Importe percepciones de impuesto municipales
                            string IImpPerImpMun = "0";
                            totalCaracteres = totalCaracteres + IImpPerImpMun.Length;
                            ////// Importe  de impuesto internos
                            string ImpImpInt = "0";
                            totalCaracteres = totalCaracteres + ImpImpInt.Length;
                            ////// Codigo de moneda
                            string CodMoneda = "PES";
                            totalCaracteres = totalCaracteres + CodMoneda.Length;
                            ////// Tipo de Cambio
                            string TipoCambio = "1";
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
                            string CodOperacion = "0";
                            totalCaracteres = totalCaracteres + CodOperacion.Length;
                            //////Otro Tributo
                            string OtroTributo = "0";
                            totalCaracteres = totalCaracteres + OtroTributo.Length;
                            ////// Fecha de vencimiento
                            DateTime Fecha2 = Convert.ToDateTime(item.Fecha);
                            string dateFormatted2 = Fecha2.ToString("yyyyMMdd");
                            string FechaFinal2 = dateFormatted2;
                            totalCaracteres = totalCaracteres + FechaFinal2.Length;
                            ////// Importe Neto  gravado
                            //decimal Neto = 0;
                            //if (item.Neto1 > 0)
                            //{
                            //    Neto = item.Neto1;
                            //}
                            //if (item.Neto2 > 0)
                            //{
                            //    Neto = item.Neto2;
                            //}
                            //if (item.Neto3 > 0)
                            //{
                            //    Neto = item.Neto3;
                            //}

                            /////// Alicuota de Iva
                            //string CodigoIva = "0";
                            //if (item.Iva1 > 0)
                            //{
                            //    CodigoIva = "10,50%";
                            //}
                            //if (item.Iva2 > 0)
                            //{
                            //    CodigoIva = "21%";
                            //}
                            //if (item.Iva3 > 0)
                            //{
                            //    CodigoIva = "27%";
                            //}
                            /////// Iva liquidado
                            //decimal Iva = 0;
                            //if (item.Iva1 > 0)
                            //{
                            //    Iva = item.Iva1;
                            //}
                            //if (item.Iva2 > 0)
                            //{
                            //    Iva = item.Iva2;
                            //}
                            //if (item.Iva3 > 0)
                            //{
                            //    Iva = item.Iva3;
                            //}

                            if (totalCaracteres < 266)
                            {
                                restan = 266 - totalCaracteres;
                                Blancos = Blancos.PadLeft(restan, ' ');
                                sw.WriteLine(FechaFinal + TipoComprobante + PuntoDeVenta + FacturaSegundaParte + FacturaSegundaParte + CodigoDocumentoComprador + Dni + ApellidoNombre + Blancos + Monto + ImpTotalConcep + PercNoCatego + ImpOpeExe + ImpPerPagoImp + IImpPerIngBrutos + IImpPerImpMun + ImpImpInt + CodMoneda + TipoCambio + cantidadAlicuotas + CodOperacion + OtroTributo + FechaFinal2); /*+ Neto + CodigoIva + Iva);*/
                            }
                            if (totalCaracteres == 266)
                            {
                                sw.WriteLine(FechaFinal + TipoComprobante + PuntoDeVenta + FacturaSegundaParte + FacturaSegundaParte + CodigoDocumentoComprador + Dni + ApellidoNombre + Monto + ImpTotalConcep + PercNoCatego + ImpOpeExe + ImpPerPagoImp + IImpPerIngBrutos + IImpPerImpMun + ImpImpInt + CodMoneda + TipoCambio + cantidadAlicuotas + CodOperacion + OtroTributo + FechaFinal2); /*+ Neto + CodigoIva + Iva);*/
                            }
                        }
                    }
                }
            }

            // Open the file to read from.
            using (StreamReader sr = File.OpenText(path))
            {
                string s = "";
                while ((s = sr.ReadLine()) != null)
                {
                    Console.WriteLine(s);
                }
            }
        }
    }
}
