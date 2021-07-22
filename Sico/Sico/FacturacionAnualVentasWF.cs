using iTextSharp.text;
using iTextSharp.text.pdf;
using Sico.Entidades;
using Sico.Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Sico
{
    public partial class FacturacionAnualVentasWF : Form
    {
        public FacturacionAnualVentasWF()
        {
            InitializeComponent();
        }
        private void FacturacionAnualVentasWF_Load(object sender, EventArgs e)
        {

            List<Entidades.FacturaVentaAnual> ListaTotalFacturacionVentas = new List<Entidades.FacturaVentaAnual>();
            ListaTotalFacturacionVentas = ComprasNeg.FacturacionAnualVentas(Sesion.UsuarioLogueado.idEmpresaSeleccionado);
            if (ListaTotalFacturacionVentas.Count > 0)
            {
                ArmarGrafico(ListaTotalFacturacionVentas);
                DiseñoGrilla();
                double TotalMonto = CalcularTotalMontoVentas(ListaTotalFacturacionVentas);
                double TotalImporte1 = CalcularTotalImporte1Ventas(ListaTotalFacturacionVentas);
                double TotalImporte2 = CalcularTotalImporte2Ventas(ListaTotalFacturacionVentas);
                double TotalImporte3 = CalcularTotalImporte3Ventas(ListaTotalFacturacionVentas);

                double TotalNeto10 = CalcularTotalNeto10Ventas(ListaTotalFacturacionVentas);
                double TotalNeto21 = CalcularTotalNeto21Ventas(ListaTotalFacturacionVentas);
                double TotalNeto27 = CalcularTotalNeto27Ventas(ListaTotalFacturacionVentas);

                double TotalIva10 = CalcularTotalIva10Ventas(ListaTotalFacturacionVentas);
                double TotalIva21 = CalcularTotalIva21Ventas(ListaTotalFacturacionVentas);
                double TotalIva27 = CalcularTotalIva27Ventas(ListaTotalFacturacionVentas);
                Entidades.FacturaVentaAnual ultimo = new Entidades.FacturaVentaAnual();
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
                ListaTotalFacturacionVentas.Add(ultimo);
                ListaStatica = ListaTotalFacturacionVentas;
                dgvVentasAnuales.Visible = true;
                foreach (var item in ListaTotalFacturacionVentas)
                {

                    if (item.Periodo != "")
                    {
                        dgvVentasAnuales.Rows.Add(item.Periodo, item.Monto, item.Neto1, item.Neto2, item.Neto3, item.Iva1, item.Iva2, item.Iva3);
                    }
                }
                dgvVentasAnuales.AllowUserToAddRows = false;
                PanelBotones.Visible = true;
                             
            }
            else
            {
                dgvVentasAnuales.Rows.Clear();
                PanelBotones.Visible = false;
                chart1.Series.Clear();
                chart1.Visible = false;
            }
        }
        private void ArmarGrafico(List<FacturaVentaAnual> listaTotalFacturacionVentas)
        {
            chart1.Visible = true;
            List<string> Nombre = new List<string>();
            List<string> Total = new List<string>();
            foreach (var item in listaTotalFacturacionVentas)
            {
                if (item.Periodo == "TOTALES")
                {
                    listaTotalFacturacionVentas.Remove(item);
                    break;
                }
            }
            foreach (var item in listaTotalFacturacionVentas)
            {
                if (item.Periodo != "")
                {
                    Series series = this.chart1.Series.Add(item.Periodo + "(" + "$ " + item.Monto + ")");
                    series.Points.AddXY("-", item.Monto);
                }
            }
            chart1.Series[0].Points.DataBindXY(Nombre, Total);
        }

        private void DiseñoGrilla()
        {
            this.dgvVentasAnuales.DefaultCellStyle.Font = new System.Drawing.Font("Tahoma", 9);
            this.dgvVentasAnuales.DefaultCellStyle.ForeColor = Color.Black;
            this.dgvVentasAnuales.DefaultCellStyle.BackColor = Color.White;
            this.dgvVentasAnuales.DefaultCellStyle.SelectionForeColor = Color.Black;
            this.dgvVentasAnuales.DefaultCellStyle.SelectionBackColor = Color.White;
        }
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
        private void btnExcel_Click(object sender, EventArgs e)
        {
            ProgressBar();
            dgvVentasAnuales.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            dgvVentasAnuales.MultiSelect = true;
            dgvVentasAnuales.SelectAll();
            DataObject dataObj = dgvVentasAnuales.GetClipboardContent();
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
            progressBar1.Value = Convert.ToInt32(null);
            progressBar1.Visible = false;
        }
        public static List<FacturaVentaAnual> ListaStatica;
        private void btnPdf_Click(object sender, EventArgs e)
        {
            MemoryStream m = new MemoryStream();
            Document doc = new Document(PageSize.LETTER);
            //PdfWriter writer = PdfWriter.GetInstance(doc, m);

            string folderPath = "C:\\SICO-Archivos\\PDFs\\Reporte Anual Ventas\\";
            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }
            //string ruta = System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Personal));
            string ruta = folderPath;
            // Creamos el documento con el tamaño de página tradicional
            //Document doc = new Document(PageSize.LETTER);
            string Periodo = "Reporte Anual";
            // Indicamos donde vamos a guardar el documento
            PdfWriter writer = PdfWriter.GetInstance(doc,
                                        new FileStream(ruta + Sesion.UsuarioLogueado.EmpresaSeleccionada + Periodo + ".pdf", FileMode.Create));
            writer.PageEvent = new PDF();

            // Le colocamos el título y el autor
            // **Nota: Esto no será visible en el documento
            doc.AddTitle("PDF");
            doc.AddCreator("jliCode");

            // Abrimos el archivo
            doc.Open();
            // Creamos el tipo de Font que vamos utilizar
            iTextSharp.text.Font _standardFont = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 7, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);
            iTextSharp.text.Font letraContenido = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 5, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);
            iTextSharp.text.Font UltimoRegistro = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 5, iTextSharp.text.Font.NORMAL, BaseColor.BLUE);

            // Escribimos el encabezamiento en el documento
            string TextoInicial = "Libro I.V.A. Ventas - ";
            string PeriodoEncabezado = " Reporte Anual ";
            //string Empresa = Sesion.UsuarioLogueado.EmpresaSeleccionada;
            doc.Add(new Paragraph(TextoInicial + " " + PeriodoEncabezado + " "));
            doc.Add(Chunk.NEWLINE);

            // Creamos una tabla que contendrá el nombre, apellido y país
            // de nuestros visitante.
            PdfPTable tblPrueba = new PdfPTable(11);
            tblPrueba.WidthPercentage = 110;

            // Configuramos el título de las columnas de la tabla
            PdfPCell clPeriodo = new PdfPCell(new Phrase("Periodo", _standardFont));
            clPeriodo.BorderWidth = 0;
            clPeriodo.BorderWidthBottom = 0.50f;
            clPeriodo.BorderWidthLeft = 0.50f;
            clPeriodo.BorderWidthRight = 0.50f;
            clPeriodo.BorderWidthTop = 0.50f;

            PdfPCell clMontoTotal = new PdfPCell(new Phrase("Monto Total", _standardFont));
            clMontoTotal.BorderWidth = 0;
            clMontoTotal.BorderWidthBottom = 0.50f;
            clMontoTotal.BorderWidthLeft = 0.50f;
            clMontoTotal.BorderWidthRight = 0.50f;
            clMontoTotal.BorderWidthTop = 0.50f;

            PdfPCell clTotal1 = new PdfPCell(new Phrase("Total 1", _standardFont));
            clTotal1.BorderWidth = 0;
            clTotal1.BorderWidthBottom = 0.50f;
            clTotal1.BorderWidthLeft = 0.50f;
            clTotal1.BorderWidthRight = 0.50f;
            clTotal1.BorderWidthTop = 0.50f;


            PdfPCell clTotal2 = new PdfPCell(new Phrase("Total 2", _standardFont));
            clTotal2.BorderWidth = 0;
            clTotal2.BorderWidthBottom = 0.50f;
            clTotal2.BorderWidthLeft = 0.50f;
            clTotal2.BorderWidthRight = 0.50f;
            clTotal2.BorderWidthTop = 0.50f;

            PdfPCell clTotal3 = new PdfPCell(new Phrase("Total 3", _standardFont));
            clTotal3.BorderWidth = 0;
            clTotal3.BorderWidthBottom = 0.50f;
            clTotal3.BorderWidthLeft = 0.50f;
            clTotal3.BorderWidthRight = 0.50f;
            clTotal3.BorderWidthTop = 0.50f;

            PdfPCell clNeto10 = new PdfPCell(new Phrase("Neto10,5", _standardFont));
            clNeto10.BorderWidth = 0;
            clNeto10.BorderWidthBottom = 0.50f;
            clNeto10.BorderWidthLeft = 0.50f;
            clNeto10.BorderWidthRight = 0.50f;
            clNeto10.BorderWidthTop = 0.50f;

            PdfPCell clNeto21 = new PdfPCell(new Phrase("Neto21", _standardFont));
            clNeto21.BorderWidth = 0;
            clNeto21.BorderWidthBottom = 0.50f;
            clNeto21.BorderWidthLeft = 0.50f;
            clNeto21.BorderWidthRight = 0.50f;
            clNeto21.BorderWidthTop = 0.50f;

            PdfPCell clNeto27 = new PdfPCell(new Phrase("Neto27", _standardFont));
            clNeto27.BorderWidth = 0;
            clNeto27.BorderWidthBottom = 0.50f;
            clNeto27.BorderWidthLeft = 0.50f;
            clNeto27.BorderWidthRight = 0.50f;
            clNeto27.BorderWidthTop = 0.50f;

            PdfPCell clIva10 = new PdfPCell(new Phrase("Iva10,5", _standardFont));
            clIva10.BorderWidth = 0;
            clIva10.BorderWidthBottom = 0.50f;
            clIva10.BorderWidthLeft = 0.50f;
            clIva10.BorderWidthRight = 0.50f;
            clIva10.BorderWidthTop = 0.50f;

            PdfPCell clIva21 = new PdfPCell(new Phrase("Iva21", _standardFont));
            clIva21.BorderWidth = 0;
            clIva21.BorderWidthBottom = 0.50f;
            clIva21.BorderWidthLeft = 0.50f;
            clIva21.BorderWidthRight = 0.50f;
            clIva21.BorderWidthTop = 0.50f;

            PdfPCell clIva27 = new PdfPCell(new Phrase("Iva27", _standardFont));
            clIva27.BorderWidth = 0;
            clIva27.BorderWidthBottom = 0.50f;
            clIva27.BorderWidthLeft = 0.50f;
            clIva27.BorderWidthRight = 0.50f;
            clIva27.BorderWidthTop = 0.50f;

            // Añadimos las celdas a la tabla
            tblPrueba.AddCell(clPeriodo);
            tblPrueba.AddCell(clMontoTotal);
            tblPrueba.AddCell(clTotal1);
            tblPrueba.AddCell(clTotal2);
            tblPrueba.AddCell(clTotal3);
            tblPrueba.AddCell(clNeto10);
            tblPrueba.AddCell(clNeto21);
            tblPrueba.AddCell(clNeto27);
            tblPrueba.AddCell(clIva10);
            tblPrueba.AddCell(clIva21);
            tblPrueba.AddCell(clIva27);
            // Llenamos la tabla con información
            int TotalDeElementos = ListaStatica.Count;
            int Contador = 0;
            foreach (var item in ListaStatica)
            {
                Contador = Contador + 1;
                if (item.Periodo != "")
                {                    
                    if (TotalDeElementos == Contador)
                    {
                        clPeriodo = new PdfPCell(new Phrase(item.Periodo, UltimoRegistro));
                        clPeriodo.BorderWidth = 0;

                        string Monto = Convert.ToString(item.Monto);
                        clMontoTotal = new PdfPCell(new Phrase(Monto, UltimoRegistro));
                        clMontoTotal.BorderWidth = 0;

                        string Total1 = Convert.ToString(item.Total1);
                        clTotal1 = new PdfPCell(new Phrase(Total1, UltimoRegistro));
                        clTotal1.BorderWidth = 0;

                        string Total2 = Convert.ToString(item.Total2);
                        clTotal2 = new PdfPCell(new Phrase(Total2, UltimoRegistro));
                        clTotal2.BorderWidth = 0;

                        string Total3 = Convert.ToString(item.Total3);
                        clTotal3 = new PdfPCell(new Phrase(Total3, UltimoRegistro));
                        clTotal3.BorderWidth = 0;

                        string Neto1 = Convert.ToString(item.Neto1);
                        clNeto10 = new PdfPCell(new Phrase(Neto1, UltimoRegistro));
                        clNeto10.BorderWidth = 0;

                        string Neto2 = Convert.ToString(item.Neto2);
                        clNeto21 = new PdfPCell(new Phrase(Neto2, UltimoRegistro));
                        clNeto21.BorderWidth = 0;

                        string Neto3 = Convert.ToString(item.Neto3);
                        clNeto27 = new PdfPCell(new Phrase(Neto3, UltimoRegistro));
                        clNeto27.BorderWidth = 0;

                        string Iva1 = Convert.ToString(item.Iva1);
                        clIva10 = new PdfPCell(new Phrase(Iva1, UltimoRegistro));
                        clIva10.BorderWidth = 0;

                        string Iva2 = Convert.ToString(item.Iva2);
                        clIva21 = new PdfPCell(new Phrase(Iva2, UltimoRegistro));
                        clIva21.BorderWidth = 0;

                        string Iva3 = Convert.ToString(item.Iva3);
                        clIva27 = new PdfPCell(new Phrase(Iva3, UltimoRegistro));
                        clIva27.BorderWidth = 0;

                        tblPrueba.AddCell(clPeriodo);
                        tblPrueba.AddCell(clMontoTotal);
                        tblPrueba.AddCell(clTotal1);
                        tblPrueba.AddCell(clTotal2);
                        tblPrueba.AddCell(clTotal3);
                        tblPrueba.AddCell(clNeto10);
                        tblPrueba.AddCell(clNeto21);
                        tblPrueba.AddCell(clNeto27);
                        tblPrueba.AddCell(clIva10);
                        tblPrueba.AddCell(clIva21);
                        tblPrueba.AddCell(clIva27);
                    }
                    else
                    {
                        clPeriodo = new PdfPCell(new Phrase(item.Periodo, letraContenido));
                        clPeriodo.BorderWidth = 0;

                        string Monto = Convert.ToString(item.Monto);
                        clMontoTotal = new PdfPCell(new Phrase(Monto, letraContenido));
                        clMontoTotal.BorderWidth = 0;

                        string Total1 = Convert.ToString(item.Total1);
                        clTotal1 = new PdfPCell(new Phrase(Total1, letraContenido));
                        clTotal1.BorderWidth = 0;

                        string Total2 = Convert.ToString(item.Total2);
                        clTotal2 = new PdfPCell(new Phrase(Total2, letraContenido));
                        clTotal2.BorderWidth = 0;

                        string Total3 = Convert.ToString(item.Total3);
                        clTotal3 = new PdfPCell(new Phrase(Total3, letraContenido));
                        clTotal3.BorderWidth = 0;


                        string Neto1 = Convert.ToString(item.Neto1);
                        clNeto10 = new PdfPCell(new Phrase(Neto1, letraContenido));
                        clNeto10.BorderWidth = 0;

                        string Neto2 = Convert.ToString(item.Neto2);
                        clNeto21 = new PdfPCell(new Phrase(Neto2, letraContenido));
                        clNeto21.BorderWidth = 0;

                        string Neto3 = Convert.ToString(item.Neto3);
                        clNeto27 = new PdfPCell(new Phrase(Neto3, letraContenido));
                        clNeto27.BorderWidth = 0;

                        string Iva1 = Convert.ToString(item.Iva1);
                        clIva10 = new PdfPCell(new Phrase(Iva1, letraContenido));
                        clIva10.BorderWidth = 0;

                        string Iva2 = Convert.ToString(item.Iva2);
                        clIva21 = new PdfPCell(new Phrase(Iva2, letraContenido));
                        clIva21.BorderWidth = 0;

                        string Iva3 = Convert.ToString(item.Iva3);
                        clIva27 = new PdfPCell(new Phrase(Iva3, letraContenido));
                        clIva27.BorderWidth = 0;

                        tblPrueba.AddCell(clPeriodo);
                        tblPrueba.AddCell(clMontoTotal);
                        tblPrueba.AddCell(clTotal1);
                        tblPrueba.AddCell(clTotal2);
                        tblPrueba.AddCell(clTotal3);
                        tblPrueba.AddCell(clNeto10);
                        tblPrueba.AddCell(clNeto21);
                        tblPrueba.AddCell(clNeto27);
                        tblPrueba.AddCell(clIva10);
                        tblPrueba.AddCell(clIva21);
                        tblPrueba.AddCell(clIva27);
                    }
                }
            }
            doc.Add(tblPrueba);
            doc.Close();
            writer.Close();
            string mensaje = "Se generó el PDF exitosamente en la carpeta" + " " + folderPath;
            string message2 = mensaje;
            const string caption2 = "Éxito";
            var result2 = MessageBox.Show(message2, caption2,
                                         MessageBoxButtons.OK,
                                         MessageBoxIcon.Asterisk);
        }
    }
}
