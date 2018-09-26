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

namespace Sico
{
    public partial class VistaFacturacionSubClienteWF : Form
    {
        private string cuit;
        private string idsubCliente;
        private string razonSocial;
        public VistaFacturacionSubClienteWF(string idsubCliente, string cuit, string razonSocial)
        {
            InitializeComponent();
            this.idsubCliente = idsubCliente;
            this.cuit = cuit;
            this.razonSocial = razonSocial;
        }
        private void VistaFacturacionSubClienteWF_Load(object sender, EventArgs e)
        {
            lblNombreEdit.Text = razonSocial;
            lblCuitEdit.Text = cuit;
            try
            {
                List<SubCliente> _Factura = new List<SubCliente>();
                _Factura = ClienteNeg.BuscarDetalleFacturaSubCliente(idsubCliente);
                HabilitarCamposConDatos(_Factura);
            }
            catch (Exception ex) { }
        }
        private void HabilitarCamposConDatos(List<SubCliente> _Factura)
        {
            var Factura = _Factura.First();
            lblsubCliente.Text = Factura.ApellidoNombre;
            txtFactura.Text = Factura.NroFactura;
            dtFecha.Value = Convert.ToDateTime(Factura.Fecha);
            lblTotalEdit.Text = Convert.ToString(Factura.Monto);
            if (Factura.Total1 > 0)
                txtTotal1.Text = Convert.ToString(Factura.Total1);
            if (Factura.Total2 > 0)
                txtTotal2.Text = Convert.ToString(Factura.Total2);
            if (Factura.Total3 > 0)
                txtTotal3.Text = Convert.ToString(Factura.Total3);
            if (Factura.Neto1 > 0)
                txtNeto1.Text = Convert.ToString(Factura.Neto1);
            if (Factura.Neto2 > 0)
                txtNeto2.Text = Convert.ToString(Factura.Neto2);
            if (Factura.Neto3 > 0)
                txtNeto3.Text = Convert.ToString(Factura.Neto3);
            if (Factura.Iva1 > 0)
                txtIva1.Text = Convert.ToString(Factura.Iva1);
            if (Factura.Iva2 > 0)
                txtIva2.Text = Convert.ToString(Factura.Iva2);
            if (Factura.Iva3 > 0)
                txtIva3.Text = Convert.ToString(Factura.Iva3);
            InhabilitarCampos();
        }
        private void InhabilitarCampos()
        {
            txtFactura.Enabled = false;
            txtTotal1.Enabled = false;
            txtTotal2.Enabled = false;
            txtTotal3.Enabled = false;
            //txtNeto1.Enabled = false;
            txtNeto2.Enabled = false;
            txtNeto3.Enabled = false;
            txtIva1.Enabled = false;
            txtIva2.Enabled = false;
            txtIva3.Enabled = false;
        }

        private void btnPdf_Click(object sender, EventArgs e)
        {
            Document documentoPDF = new Document();
            var prueba =
            PdfWriter.GetInstance(documentoPDF, new FileStream("C:/'" + lblsubCliente.Text + " Nro.Factura " + txtFactura.Text + "'.pdf", FileMode.Create));
            documentoPDF.Open();
            Paragraph p1 = new Paragraph("RAZON SOCIAL:" + lblNombreEdit.Text + "" + "                                                                       " + " CUIT: " + lblCuitEdit.Text + "", FontFactory.GetFont(FontFactory.TIMES, 11, iTextSharp.text.Font.NORMAL));
            Paragraph p1a = new Paragraph("" + System.Environment.NewLine + "");
            Paragraph p2 = new Paragraph("APELLIDO Y NOMBRE:" + lblsubCliente.Text + "", FontFactory.GetFont(FontFactory.TIMES, 11, iTextSharp.text.Font.NORMAL));
            Paragraph p2a = new Paragraph("" + System.Environment.NewLine + "");
            Paragraph p3 = new Paragraph("FECHA:" + dtFecha.Text + "" + "                                            " + " NRO:BOLETA: " + txtFactura.Text + "", FontFactory.GetFont(FontFactory.TIMES, 11, iTextSharp.text.Font.NORMAL));
            Paragraph p3a = new Paragraph("" + System.Environment.NewLine + "");
            Paragraph p4 = new Paragraph("                  " + "Total: " + txtTotal1.Text + "          " + "Neto:" + txtNeto1.Text + "          " + "Alicuota: " + lbl105.Text + "         " + "Iva:" + txtIva1.Text + "", FontFactory.GetFont(FontFactory.TIMES, 11, iTextSharp.text.Font.NORMAL));
            Paragraph p5 = new Paragraph("                  " + "Total: " + txtTotal2.Text + "          " + "Neto:" + txtNeto2.Text + "          " + "Alicuota: " + lbl21.Text + "         " + "Iva:" + txtIva2.Text + "", FontFactory.GetFont(FontFactory.TIMES, 11, iTextSharp.text.Font.NORMAL));
            Paragraph p6 = new Paragraph("                  " + "Total: " + txtTotal3.Text + "          " + "Neto:" + txtNeto3.Text + "          " + "Alicuota: " + lbl27.Text + "         " + "Iva:" + txtIva3.Text + "", FontFactory.GetFont(FontFactory.TIMES, 11, iTextSharp.text.Font.NORMAL));
            Paragraph p6a = new Paragraph("" + System.Environment.NewLine + "");
            Paragraph p7 = new Paragraph("                  " + "          " + "                        " + "Importe Total: " + lblTotalEdit.Text + "         ", FontFactory.GetFont(FontFactory.TIMES, 11, iTextSharp.text.Font.NORMAL));
            documentoPDF.Add(p1);
            documentoPDF.Add(p1a);
            documentoPDF.Add(p2);
            documentoPDF.Add(p2a);
            documentoPDF.Add(p3);
            documentoPDF.Add(p3a);
            documentoPDF.Add(p4);
            documentoPDF.Add(p5);
            documentoPDF.Add(p6);
            documentoPDF.Add(p6a);
            documentoPDF.Add(p7);
            // documentoPDF.Add(new Paragraph(lblNombreEdit.Text +" "+ lblCuitEdit.Text, FontFactory.GetFont(FontFactory.TIMES, 11, iTextSharp.text.Font.NORMAL)));
            // documentoPDF.AddAuthor(groupBox2.Text);
            documentoPDF.AddAuthor(lblNombreEdit.Text);
            documentoPDF.AddCreator("AjpdSoft Convertir texto a PDF - www.ajpdsoft.com");
            documentoPDF.AddKeywords(label1.Text);
            documentoPDF.AddSubject(lblNombreEdit.Text);
            documentoPDF.AddTitle("Hola");
            documentoPDF.AddCreationDate();
            //'Cerramos el objeto documento, guardamos y creamos el PDF
            documentoPDF.Close();
            //System.Diagnostics.Process.Start(lblNombreEdit.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TareaClienteWF _tarea = new TareaClienteWF(razonSocial, cuit);
            _tarea.Show();
            Hide();
        }
    }
}

