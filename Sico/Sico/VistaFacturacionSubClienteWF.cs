using iTextSharp.text;
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
            txtNeto1.Enabled = false;
            txtNeto2.Enabled = false;
            txtNeto3.Enabled = false;
            txtIva1.Enabled = false;
            txtIva2.Enabled = false;
            txtIva3.Enabled = false;
        }
        //public void Build()
        //{
        //    iTextSharp.text.Document doc = null;

        //    try
        //    {
        //        // Initialize the PDF document 
        //        doc = new Document();
        //        iTextSharp.text.pdf.PdfWriter writer = iTextSharp.text.pdf.PdfWriter.GetInstance(doc,
        //            new System.IO.FileStream(System.IO.Directory.GetCurrentDirectory() + "\\ScienceReport.pdf",
        //                System.IO.FileMode.Create));

        //        // Set margins and page size for the document 
        //        doc.SetMargins(50, 50, 50, 50);
        //        // There are a huge number of possible page sizes, including such sizes as 
        //        // EXECUTIVE, LEGAL, LETTER_LANDSCAPE, and NOTE 
        //        doc.SetPageSize(new iTextSharp.text.Rectangle(iTextSharp.text.PageSize.LETTER.Width,
        //            iTextSharp.text.PageSize.LETTER.Height));

        //        // Add metadata to the document.  This information is visible when viewing the 
        //        // document properities within Adobe Reader. 
        //        doc.AddTitle("My Science Report");
        //        doc.AddCreator("M. Lichtenberg");
        //        doc.AddKeywords("paper airplanes");

        //        // Add Xmp metadata to the document. 
        //        this.CreateXmpMetadata(writer);

        //        // Open the document for writing content 
        //        doc.Open();

        //        // Add pages to the document 
        //        this.AddPageWithBasicFormatting(doc);
        //        this.AddPageWithInternalLinks(doc);
        //        this.AddPageWithBulletList(doc);
        //        this.AddPageWithExternalLinks(doc);
        //        this.AddPageWithImage(doc, System.IO.Directory.GetCurrentDirectory() + "\\FinalGraph.jpg");

        //        // Add page labels to the document 
        //        iTextSharp.text.pdf.PdfPageLabels pdfPageLabels = new iTextSharp.text.pdf.PdfPageLabels();
        //        pdfPageLabels.AddPageLabel(1, iTextSharp.text.pdf.PdfPageLabels.EMPTY, "Basic Formatting");
        //        pdfPageLabels.AddPageLabel(2, iTextSharp.text.pdf.PdfPageLabels.EMPTY, "Internal Links");
        //        pdfPageLabels.AddPageLabel(3, iTextSharp.text.pdf.PdfPageLabels.EMPTY, "Bullet List");
        //        pdfPageLabels.AddPageLabel(4, iTextSharp.text.pdf.PdfPageLabels.EMPTY, "External Links");
        //        pdfPageLabels.AddPageLabel(5, iTextSharp.text.pdf.PdfPageLabels.EMPTY, "Image");
        //        writer.PageLabels = pdfPageLabels;
        //    }
        //    catch (iTextSharp.text.DocumentException dex)
        //    {
        //        // Handle iTextSharp errors 
        //    }
        //    finally
        //    {
        //        // Clean up 
        //        doc.Close();
        //        doc = null;
        //    }
        //}
    }
}

