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
            txtNeto1.Enabled = false;
            txtNeto2.Enabled = false;
            txtNeto3.Enabled = false;
            txtIva1.Enabled = false;
            txtIva2.Enabled = false;
            txtIva3.Enabled = false;
        }

        private void btnPdf_Click(object sender, EventArgs e)
        {
            Document documentoPDF = new Document();
            PdfWriter.GetInstance(documentoPDF, new System.IO.FileStream(groupBox2.Text, FileMode.Create));
            documentoPDF.Open();
            documentoPDF.Add(new Paragraph(groupBox2.Text, FontFactory.GetFont(FontFactory.TIMES, 11, iTextSharp.text.Font.NORMAL)));
            // documentoPDF.AddAuthor(groupBox2.Text);
            documentoPDF.AddAuthor(lblNombreEdit.Text);
            documentoPDF.AddCreator("AjpdSoft Convertir texto a PDF - www.ajpdsoft.com");
            documentoPDF.AddKeywords(label1.Text);
            documentoPDF.AddSubject(lblNombreEdit.Text);
            documentoPDF.AddTitle("Hola");
            documentoPDF.AddCreationDate();
            //'Cerramos el objeto documento, guardamos y creamos el PDF
            documentoPDF.Close();
            System.Diagnostics.Process.Start(lblNombreEdit.Text);
        }
       
    }
}

