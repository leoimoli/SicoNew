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
        private bool EsEditar;
        public VistaFacturacionSubClienteWF(string idsubCliente, string cuit, string razonSocial, bool EsEditar)
        {
            InitializeComponent();
            this.idsubCliente = idsubCliente;
            this.cuit = cuit;
            this.razonSocial = razonSocial;
            this.EsEditar = EsEditar;
        }
        private void VistaFacturacionSubClienteWF_Load(object sender, EventArgs e)
        {
            lblNombreEdit.Text = razonSocial;
            lblCuitEdit.Text = cuit;
            if (EsEditar == true)
            {
                try
                {
                    List<SubCliente> _Factura = new List<SubCliente>();
                    _Factura = ClienteNeg.BuscarDetalleFacturaSubCliente(idsubCliente);
                    if (_Factura.Count <= 0)
                    {
                        MessageBox.Show("La factura seleccionada no tiene un detalle cargado.");
                        TareaClienteWF _tarea = new TareaClienteWF(razonSocial, cuit);
                        _tarea.Show();
                        Close();
                    }
                    HabilitarCamposConDatosEditar(_Factura);
                }
                catch (Exception ex) { }
            }
            else
            {
                try
                {
                    List<SubCliente> _Factura = new List<SubCliente>();
                    _Factura = ClienteNeg.BuscarDetalleFacturaSubCliente(idsubCliente);
                    if (_Factura.Count <= 0)
                    {
                        MessageBox.Show("La factura seleccionada no tiene un detalle cargado.");
                        TareaClienteWF _tarea = new TareaClienteWF(razonSocial, cuit);
                        _tarea.Show();
                        Close();
                    }
                    HabilitarCamposConDatos(_Factura);
                }
                catch (Exception ex) { }
            }
        }
        private void HabilitarCamposConDatosEditar(List<SubCliente> _Factura)
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
            if (Factura.Monto > 0)
                lblTotalEdit.Text = Convert.ToString(Factura.Monto);
            btnGuardar.Visible = true;
            btnPdf.Visible = false;
            dtFecha.Enabled = true;
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
            ProgressBar();
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
            LimpiarCampos();
        }
        private void LimpiarCampos()
        {
            progressBar1.Value = Convert.ToInt32(null);
            progressBar1.Visible = false;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            TareaClienteWF _tarea = new TareaClienteWF(razonSocial, cuit);
            _tarea.Show();
            Hide();
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
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                Entidades.SubCliente _subCliente = CargarEntidad();
                bool Exito = ClienteNeg.GuardarEdicionFacturaSubCliente(_subCliente, cuit, idsubCliente);
                if (Exito == true)
                {
                    ProgressBar();
                    const string message2 = "Se registro la edición de la factura exitosamente.";
                    const string caption2 = "Éxito";
                    var result2 = MessageBox.Show(message2, caption2,
                                                 MessageBoxButtons.OK,
                                                 MessageBoxIcon.Asterisk);
                    LimpiarCampos();
                }
                else
                {

                }
            }
            catch (Exception ex) { }
        }
        private SubCliente CargarEntidad()
        {
            SubCliente _subCliente = new SubCliente();
            _subCliente.ApellidoNombre = lblsubCliente.Text;
            _subCliente.NroFactura = txtFactura.Text;
            DateTime fecha = dtFecha.Value;
            _subCliente.Fecha = fecha.ToShortDateString();
            if (!String.IsNullOrEmpty(txtTotal1.Text))
                _subCliente.Total1 = Convert.ToDecimal(txtTotal1.Text);
            if (!String.IsNullOrEmpty(txtTotal2.Text))
                _subCliente.Total2 = Convert.ToDecimal(txtTotal2.Text);
            if (!String.IsNullOrEmpty(txtTotal3.Text))
                _subCliente.Total3 = Convert.ToDecimal(txtTotal3.Text);
            if (!String.IsNullOrEmpty(txtNeto1.Text))
                _subCliente.Neto1 = Convert.ToDecimal(txtNeto1.Text);
            if (!String.IsNullOrEmpty(txtNeto2.Text))
                _subCliente.Neto2 = Convert.ToDecimal(txtNeto2.Text);
            if (!String.IsNullOrEmpty(txtNeto3.Text))
                _subCliente.Neto3 = Convert.ToDecimal(txtNeto3.Text);
            _subCliente.Alicuota1 = lbl105.Text;
            _subCliente.Alicuota2 = lbl21.Text;
            _subCliente.Alicuota3 = lbl27.Text;
            if (!String.IsNullOrEmpty(txtIva1.Text))
                _subCliente.Iva1 = Convert.ToDecimal(txtIva1.Text);
            if (!String.IsNullOrEmpty(txtIva2.Text))
                _subCliente.Iva2 = Convert.ToDecimal(txtIva2.Text);
            if (!String.IsNullOrEmpty(txtIva3.Text))
                _subCliente.Iva3 = Convert.ToDecimal(txtIva3.Text);
            _subCliente.Monto = Convert.ToDecimal(lblTotalEdit.Text);
            //int idusuarioLogueado = Sesion.UsuarioLogueado.IdUsuario;
            //_subCliente.idUsuario = idusuarioLogueado;
            return _subCliente;
        }
        #region Funciones
        public static decimal Total;
        private void txtTotal1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ///// Calculo el NetoGral Alicuota 10,5
                double Total1 = Convert.ToDouble(txtTotal1.Text);
                decimal NetoCalculado = CalcularValorNeto1(Total1);
                txtNeto1.Text = Convert.ToString(NetoCalculado);

                ///// Calculo el IVA Alicuota 10,5
                decimal IvaCalculado = CalcularIva1(NetoCalculado);
                txtIva1.Text = Convert.ToString(IvaCalculado);

                ///// Calculo el Monto Total
                if (Total == 0)
                {
                    lblTotalEdit.Text = Convert.ToString(Total1);
                    decimal TotalCargado = Convert.ToDecimal(Total1);
                    Total = TotalCargado;
                }
                else
                {
                    RecalcularTotal1();
                    //decimal TotalCargado = Convert.ToDecimal(Total1);
                    //decimal TotalMostrar = Total + TotalCargado;
                    //Total = TotalMostrar;
                    lblTotalEdit.Text = Convert.ToString(Total);
                }
                txtTotal2.Focus();
            }
        }
        private void txtTotal2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ///// Calculo el NetoGral Alicuota 21
                double Total2 = Convert.ToDouble(txtTotal2.Text);
                decimal NetoCalculado = CalcularValorNeto2(Total2);
                txtNeto2.Text = Convert.ToString(NetoCalculado);

                ///// Calculo el IVA Alicuota 21
                decimal IvaCalculado = CalcularIva2(NetoCalculado);
                txtIva2.Text = Convert.ToString(IvaCalculado);

                ///// Calculo el Monto Total
                if (Total == 0)
                {
                    lblTotalEdit.Text = Convert.ToString(Total2);
                    decimal TotalCargado = Convert.ToDecimal(Total2);
                    Total = TotalCargado;
                }
                else
                {
                    RecalcularTotal2();
                    lblTotalEdit.Text = Convert.ToString(Total);
                    //decimal TotalCargado = Convert.ToDecimal(Total2);
                    //decimal TotalMostrar = Total + TotalCargado;
                    //Total = TotalMostrar;
                    //lblTotalEdit.Text = Convert.ToString(TotalMostrar);
                }
                txtTotal3.Focus();
            }
        }
        private void txtTotal3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ///// Calculo el NetoGral Alicuota 27
                double Total3 = Convert.ToDouble(txtTotal3.Text);
                decimal NetoCalculado = CalcularValorNeto3(Total3);
                txtNeto3.Text = Convert.ToString(NetoCalculado);

                ///// Calculo el IVA Alicuota 27
                decimal IvaCalculado = CalcularIva3(NetoCalculado);
                txtIva3.Text = Convert.ToString(IvaCalculado);

                ///// Calculo el Monto Total
                if (Total == 0)
                {
                    lblTotalEdit.Text = Convert.ToString(Total3);
                    decimal TotalCargado = Convert.ToDecimal(Total3);
                    Total = TotalCargado;
                }
                else
                {
                    RecalcularTotal3();
                    //lblTotalEdit.Text = Convert.ToString(Total);
                    //decimal TotalCargado = Convert.ToDecimal(Total3);
                    //decimal TotalMostrar = Total + TotalCargado;
                    //Total = TotalMostrar;
                    lblTotalEdit.Text = Convert.ToString(Total);
                }
            }
        }
        private decimal CalcularValorNeto1(double total1)
        {
            string res = Convert.ToString(Math.Round((total1 / 1.105), 2));
            decimal resultado = Convert.ToDecimal(res);
            return resultado;
        }
        private decimal CalcularIva1(decimal netoCalculado)
        {
            double NetoCalculado = Convert.ToDouble(netoCalculado);
            string res = Convert.ToString(Math.Round((NetoCalculado * 0.105), 2));
            decimal resultado = Convert.ToDecimal(res);
            return resultado;
        }
        private decimal CalcularValorNeto2(double total2)
        {
            string res = Convert.ToString(Math.Round((total2 / 1.21), 2));
            decimal resultado = Convert.ToDecimal(res);
            return resultado;
        }
        private decimal CalcularIva2(decimal netoCalculado)
        {
            double NetoCalculado = Convert.ToDouble(netoCalculado);
            string res = Convert.ToString(Math.Round((NetoCalculado * 0.21), 2));
            decimal resultado = Convert.ToDecimal(res);
            return resultado;
        }
        private decimal CalcularValorNeto3(double total3)
        {
            string res = Convert.ToString(Math.Round((total3 / 1.27), 2));
            decimal resultado = Convert.ToDecimal(res);
            return resultado;
        }
        private decimal CalcularIva3(decimal netoCalculado)
        {
            double NetoCalculado = Convert.ToDouble(netoCalculado);
            string res = Convert.ToString(Math.Round((NetoCalculado * 0.27), 2));
            decimal resultado = Convert.ToDecimal(res);
            return resultado;
        }
        public void RecalcularTotal1()
        {
            decimal Valor2 = 0;
            decimal Valor3 = 0;
            decimal NuevoValor = Convert.ToDecimal(txtTotal1.Text);

            if (txtTotal2.Text != "") { Valor2 = Convert.ToDecimal(txtTotal2.Text); }
            if (txtTotal3.Text != "") { Valor3 = Convert.ToDecimal(txtTotal3.Text); }

            Total = NuevoValor + Valor2 + Valor3;
        }
        public void RecalcularTotal2()
        {
            decimal Valor1 = 0;
            decimal Valor3 = 0;
            decimal NuevoValor2 = Convert.ToDecimal(txtTotal2.Text);

            if (txtTotal1.Text != "") { Valor1 = Convert.ToDecimal(txtTotal1.Text); }
            if (txtTotal3.Text != "") { Valor3 = Convert.ToDecimal(txtTotal3.Text); }

            Total = NuevoValor2 + Valor1 + Valor3;
        }
        public void RecalcularTotal3()
        {
            decimal Valor2 = 0;
            decimal Valor1 = 0;
            decimal NuevoValor3 = Convert.ToDecimal(txtTotal3.Text);

            if (txtTotal2.Text != "") { Valor2 = Convert.ToDecimal(txtTotal2.Text); }
            if (txtTotal1.Text != "") { Valor1 = Convert.ToDecimal(txtTotal1.Text); }

            Total = NuevoValor3 + Valor2 + Valor1;
        }
        #endregion
    }
}

