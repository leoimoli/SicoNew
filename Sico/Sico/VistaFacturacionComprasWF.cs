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
    public partial class VistaFacturacionComprasWF : MasterWF
    {
        private string cuit;
        private bool EsEditar;
        private string idFactura;
        private string razonSocial;
        public VistaFacturacionComprasWF(string idFactura, string cuit, string razonSocial, bool esEditar)
        {
            InitializeComponent();
            this.idFactura = idFactura;
            this.cuit = cuit;
            this.razonSocial = razonSocial;
            this.EsEditar = esEditar;
        }
        private void VistaFacturacionComprasWF_Load(object sender, EventArgs e)
        {
            if (EsEditar == true)
            {
                try
                {
                    lblNombreEdit.Text = razonSocial;
                    lblCuitEdit.Text = cuit;
                    List<FacturaCompra> _Factura = new List<FacturaCompra>();
                    _Factura = ComprasNeg.BuscarDetalleFacturaFacturaCompra(idFactura);
                    Total = _Factura[0].Monto;
                    if (_Factura.Count <= 0)
                    {
                        MessageBox.Show("La factura seleccionada no tiene un detalle cargado.");
                        TareaClienteWF _tarea = new TareaClienteWF(razonSocial, cuit);
                        _tarea.Show();
                        Close();
                    }
                    HabilitarCamposConDatosEditar(_Factura);
                    HabilitarCampos();
                }
                catch (Exception ex) { }
            }
            else
            {
                try
                {
                    List<FacturaCompra> _Factura = new List<FacturaCompra>();
                    _Factura = ComprasNeg.BuscarDetalleFacturaFacturaCompra(idFactura);
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
        }
        private void HabilitarCamposConDatosEditar(List<FacturaCompra> _Factura)
        {
            var Factura = _Factura.First();
            txtCuit.Text = Factura.Cuit;
            txtCodigoDocumento.Text = "80-Cuit";
            txtFactura.Text = Factura.NroFactura;
            txtFactura.Enabled = false;
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
            dtFecha.Enabled = true;
            if (Factura.PercepIngBrutos > 0)
                txtPercepIngBrutos.Text = Convert.ToString(Factura.PercepIngBrutos);
            if (Factura.PercepIva > 0)
                txtPercepIVA.Text = Convert.ToString(Factura.PercepIva);
            if (Factura.NoGravado > 0)
                txtNoGravado.Text = Convert.ToString(Factura.NoGravado);
            cmbCodigoMoneda.Text = Factura.CodigoMoneda;
            txtTipoCambio.Text = Factura.TipoDeCambio;
            cmbCodigoOperacion.Text = Factura.CodigoTipoOperacion;
            txtApellidoNombre.Text = Factura.ApellidoNombre;
            //txtCodigoDocumento.Text = Factura.CodigoDocumento;
            cmbTipoComprobante.Text = Factura.TipoComprobante;
            cmbPeriodo.Text = Factura.Periodo;
            cmbPeriodo.Enabled = true;
            btnCrearPeriodo.Visible = true;

            if (txtTotal1.Text != "")
            {
                double ValorIncial = Convert.ToDouble(txtTotal1.Text);
                double Result = Convert.ToDouble(Factura.Neto1 + Factura.Iva1);
                txtTotal1.Text = Convert.ToString(Math.Round((Result), 2));
                if (ValorIncial != Result)
                {
                    txtTotal1.BackColor = Color.LightCoral;
                    txtNeto1.BackColor = Color.LightCoral;
                    txtIva1.BackColor = Color.LightCoral;
                }
            }
            if (txtTotal2.Text != "")
            {
                double ValorIncial = Convert.ToDouble(txtTotal2.Text);
                double Result = Convert.ToDouble(Factura.Neto2 + Factura.Iva2);
                txtTotal2.Text = Convert.ToString(Math.Round((Result), 2));
                if (ValorIncial != Result)
                {
                    txtTotal2.BackColor = Color.LightCoral;
                    txtNeto2.BackColor = Color.LightCoral;
                    txtIva2.BackColor = Color.LightCoral;
                }
            }
            if (txtTotal3.Text != "")
            {
                double ValorIncial = Convert.ToDouble(txtTotal3.Text);
                double Result = Convert.ToDouble(Factura.Neto3 + Factura.Iva3);
                txtTotal3.Text = Convert.ToString(Math.Round((Result), 2));
                if (ValorIncial != Result)
                {
                    txtTotal3.BackColor = Color.LightCoral;
                    txtNeto3.BackColor = Color.LightCoral;
                    txtIva3.BackColor = Color.LightCoral;
                }
            }

            if (cmbTipoComprobante.Text == "001 - Factura A" || cmbTipoComprobante.Text == "003 - Nota de Crédito A")
            {
                txtNeto1.Enabled = true;
                txtNeto2.Enabled = true;
                txtNeto3.Enabled = true;
                txtTotal1.Enabled = false;
                txtTotal2.Enabled = false;
                txtTotal3.Enabled = false;
                txtIva1.Enabled = false;
                txtIva2.Enabled = false;
                txtIva3.Enabled = false;
            }
            if (cmbTipoComprobante.Text == "6 - Factura B" || cmbTipoComprobante.Text == "8 - Nota de Crédito B")
            {
                txtNeto1.Enabled = false;
                txtNeto2.Enabled = false;
                txtNeto3.Enabled = false;
                txtTotal1.Enabled = true;
                txtTotal2.Enabled = true;
                txtTotal3.Enabled = true;
                txtIva1.Enabled = false;
                txtIva2.Enabled = false;
                txtIva3.Enabled = false;
            }
            if (cmbTipoComprobante.Text == "11 - Factura C" || cmbTipoComprobante.Text == "13 - Nota de Crédito C")
            {
                txtNeto1.Enabled = false;
                txtNeto2.Enabled = false;
                txtNeto3.Enabled = false;
                txtTotal1.Enabled = false;
                txtTotal2.Enabled = false;
                txtTotal3.Enabled = false;
                txtIva1.Enabled = false;
                txtIva2.Enabled = false;
                txtIva3.Enabled = false;
            }
        }
        private void HabilitarCampos()
        {
            dtFecha.Enabled = true;
            cmbTipoComprobante.Enabled = false;
            txtFactura.Enabled = false;
            txtTotal1.Enabled = true;
            txtTotal2.Enabled = true;
            txtTotal3.Enabled = true;
            txtNeto1.Enabled = true;
            txtNeto2.Enabled = true;
            txtNeto3.Enabled = true;
            txtIva1.Enabled = true;
            txtIva2.Enabled = true;
            txtIva3.Enabled = true;
            txtPercepIngBrutos.Enabled = true;
            txtPercepIVA.Enabled = true;
            labelNoGravado.Enabled = true;
            cmbCodigoMoneda.Enabled = true;
            cmbCodigoOperacion.Enabled = true;
            txtTipoCambio.Enabled = true;
            btnGuardar.Enabled = true;
            txtNoGravado.Enabled = true;
            cmbPeriodo.Enabled = false;
            //btnActualizar.Visible = true;
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                FacturaCompra _factura = CargarEntidad();
                bool Exito = ComprasNeg.GuardarEdicionFacturaCompras(_factura, cuit, idFactura);
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
        public static decimal Total;
        private void LimpiarCampos()
        {
            progressBar1.Value = Convert.ToInt32(null);
            progressBar1.Visible = false;
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
        private FacturaCompra CargarEntidad()
        {
            FacturaCompra _factura = new FacturaCompra();
            _factura.idProveedor = _factura.idProveedor;
            _factura.CodigoDocumento = txtCodigoDocumento.Text;
            _factura.ApellidoNombre = txtApellidoNombre.Text;
            DateTime fecha = dtFecha.Value;
            _factura.Fecha = fecha.ToShortDateString();
            _factura.TipoComprobante = cmbTipoComprobante.Text;
            _factura.NroFactura = txtFactura.Text;
            if (!String.IsNullOrEmpty(txtTotal1.Text))
                _factura.Total1 = Convert.ToDecimal(txtTotal1.Text);
            if (!String.IsNullOrEmpty(txtTotal2.Text))
                _factura.Total2 = Convert.ToDecimal(txtTotal2.Text);
            if (!String.IsNullOrEmpty(txtTotal3.Text))
                _factura.Total3 = Convert.ToDecimal(txtTotal3.Text);
            if (!String.IsNullOrEmpty(txtNeto1.Text))
                _factura.Neto1 = Convert.ToDecimal(txtNeto1.Text);
            if (!String.IsNullOrEmpty(txtNeto2.Text))
                _factura.Neto2 = Convert.ToDecimal(txtNeto2.Text);
            if (!String.IsNullOrEmpty(txtNeto3.Text))
                _factura.Neto3 = Convert.ToDecimal(txtNeto3.Text);
            _factura.Alicuota1 = lbl105.Text;
            _factura.Alicuota2 = lbl21.Text;
            _factura.Alicuota3 = lbl27.Text;
            if (!String.IsNullOrEmpty(txtIva1.Text))
                _factura.Iva1 = Convert.ToDecimal(txtIva1.Text);
            if (!String.IsNullOrEmpty(txtIva2.Text))
                _factura.Iva2 = Convert.ToDecimal(txtIva2.Text);
            if (!String.IsNullOrEmpty(txtIva3.Text))
                _factura.Iva3 = Convert.ToDecimal(txtIva3.Text);
            _factura.Monto = Convert.ToDecimal(lblTotalEdit.Text);
            if (!String.IsNullOrEmpty(txtPercepIngBrutos.Text))
                _factura.PercepIngBrutos = Convert.ToDecimal(txtPercepIngBrutos.Text);
            _factura.Monto = Convert.ToDecimal(lblTotalEdit.Text);
            if (!String.IsNullOrEmpty(txtPercepIVA.Text))
                _factura.PercepIva = Convert.ToDecimal(txtPercepIVA.Text);
            _factura.Monto = Convert.ToDecimal(lblTotalEdit.Text);
            if (!String.IsNullOrEmpty(txtNoGravado.Text))
                _factura.NoGravado = Convert.ToDecimal(txtNoGravado.Text);
            _factura.Monto = Convert.ToDecimal(lblTotalEdit.Text);
            _factura.CodigoMoneda = cmbCodigoMoneda.Text;
            _factura.TipoDeCambio = txtTipoCambio.Text;
            _factura.CodigoTipoOperacion = cmbCodigoOperacion.Text;
            _factura.Monto = Convert.ToDecimal(lblTotalEdit.Text);
            _factura.Periodo = cmbPeriodo.Text;
            return _factura;
        }
        private void txtNeto1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ///// Calculo el IVA Alicuota 10,5
                double Total1 = Convert.ToDouble(txtNeto1.Text);
                decimal DatoIngresado = Convert.ToDecimal(Total1);
                string res = Convert.ToString(Math.Round((Total1 * 0.105), 2));
                decimal resultadoIva1 = Convert.ToDecimal(res);
                txtIva1.Text = res;
                ///// Calculo el total1             
                decimal CampoTotal = resultadoIva1 + DatoIngresado;
                txtTotal1.Text = Convert.ToString(CampoTotal);
                if (Total == 0)
                {
                    lblTotalEdit.Text = Convert.ToString(CampoTotal);
                    decimal TotalCargado = Convert.ToDecimal(CampoTotal);
                    Total = TotalCargado;
                }
                else
                {
                    RecalcularTotal1();
                    lblTotalEdit.Text = Convert.ToString(Total);
                }
                txtNeto2.Focus();
            }
        }
        private void txtNeto2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ///// Calculo el IVA Alicuota 21
                double Total2 = Convert.ToDouble(txtNeto2.Text);
                decimal DatoIngresado = Convert.ToDecimal(Total2);
                string res = Convert.ToString(Math.Round((Total2 * 0.21), 2));
                decimal resultadoIva2 = Convert.ToDecimal(res);
                txtIva2.Text = res;
                ///// Calculo el total2          
                decimal CampoTotal = resultadoIva2 + DatoIngresado;
                txtTotal2.Text = Convert.ToString(CampoTotal);
                if (Total == 0)
                {
                    lblTotalEdit.Text = Convert.ToString(CampoTotal);
                    decimal TotalCargado = Convert.ToDecimal(CampoTotal);
                    Total = TotalCargado;
                }
                else
                {
                    RecalcularTotal1();
                    lblTotalEdit.Text = Convert.ToString(Total);
                }
                txtNeto3.Focus();
            }
        }
        private void txtNeto3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ///// Calculo el IVA Alicuota 27
                double Total3 = Convert.ToDouble(txtNeto3.Text);
                decimal DatoIngresado = Convert.ToDecimal(Total3);
                string res = Convert.ToString(Math.Round((Total3 * 0.27), 2));
                decimal resultadoIva3 = Convert.ToDecimal(res);
                txtIva3.Text = res;
                ///// Calculo el total2          
                decimal CampoTotal = resultadoIva3 + DatoIngresado;
                txtTotal3.Text = Convert.ToString(CampoTotal);
                if (Total == 0)
                {
                    lblTotalEdit.Text = Convert.ToString(CampoTotal);
                    decimal TotalCargado = Convert.ToDecimal(CampoTotal);
                    Total = TotalCargado;
                }
                else
                {
                    RecalcularTotal1();
                    lblTotalEdit.Text = Convert.ToString(Total);
                }
            }
        }
        private void txtPercepIngBrutos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (Total == 0)
                {
                    decimal ValorIngresado = Convert.ToDecimal(txtPercepIngBrutos.Text);
                    lblTotalEdit.Text = Convert.ToString(ValorIngresado);
                    decimal TotalCargado = Convert.ToDecimal(ValorIngresado);
                    Total = TotalCargado;
                }
                else
                {
                    RecalcularTotal4();
                    lblTotalEdit.Text = Convert.ToString(Total);
                }
                txtPercepIVA.Focus();
            }
        }
        private void txtPercepIVA_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (Total == 0)
                {
                    decimal ValorIngresado = Convert.ToDecimal(txtPercepIVA.Text);
                    lblTotalEdit.Text = Convert.ToString(ValorIngresado);
                    decimal TotalCargado = Convert.ToDecimal(ValorIngresado);
                    Total = TotalCargado;
                }
                else
                {
                    RecalcularTotal5();
                    lblTotalEdit.Text = Convert.ToString(Total);
                }
                txtNoGravado.Focus();
            }
        }
        private void txtNoGravado_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (Total == 0)
                {
                    decimal ValorIngresado = Convert.ToDecimal(txtNoGravado.Text);
                    lblTotalEdit.Text = Convert.ToString(ValorIngresado);
                    decimal TotalCargado = Convert.ToDecimal(ValorIngresado);
                    Total = TotalCargado;
                }
                else
                {
                    RecalcularTotal6();
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
            decimal Valor1 = 0;
            decimal Valor2 = 0;
            decimal Valor3 = 0;
            decimal Valor4 = 0;
            decimal Valor5 = 0;
            decimal Valor6 = 0;
            if (txtTotal1.Text != "") { Valor1 = Convert.ToDecimal(txtTotal1.Text); }
            if (txtTotal2.Text != "") { Valor2 = Convert.ToDecimal(txtTotal2.Text); }
            if (txtTotal3.Text != "") { Valor3 = Convert.ToDecimal(txtTotal3.Text); }
            if (txtPercepIVA.Text != "") { Valor4 = Convert.ToDecimal(txtPercepIVA.Text); }
            if (txtPercepIVA.Text != "") { Valor5 = Convert.ToDecimal(txtPercepIngBrutos.Text); }
            if (txtNoGravado.Text != "") { Valor6 = Convert.ToDecimal(txtNoGravado.Text); }

            Total = Valor1 + Valor2 + Valor3 + Valor4 + Valor5 + Valor6;
        }
        public void RecalcularTotal2()
        {
            decimal Valor1 = 0;
            decimal Valor2 = 0;
            decimal Valor3 = 0;
            decimal Valor4 = 0;
            decimal Valor5 = 0;
            decimal Valor6 = 0;
            if (txtTotal1.Text != "") { Valor1 = Convert.ToDecimal(txtTotal1.Text); }
            if (txtTotal2.Text != "") { Valor2 = Convert.ToDecimal(txtTotal2.Text); }
            if (txtTotal3.Text != "") { Valor3 = Convert.ToDecimal(txtTotal3.Text); }
            if (txtPercepIVA.Text != "") { Valor4 = Convert.ToDecimal(txtPercepIVA.Text); }
            if (txtPercepIVA.Text != "") { Valor5 = Convert.ToDecimal(txtPercepIngBrutos.Text); }
            if (txtNoGravado.Text != "") { Valor5 = Convert.ToDecimal(txtNoGravado.Text); }

            Total = Valor1 + Valor2 + Valor3 + Valor4 + Valor5 + Valor6;
        }
        public void RecalcularTotal3()
        {
            decimal Valor1 = 0;
            decimal Valor2 = 0;
            decimal Valor3 = 0;
            decimal Valor4 = 0;
            decimal Valor5 = 0;
            decimal Valor6 = 0;
            if (txtTotal1.Text != "") { Valor1 = Convert.ToDecimal(txtTotal1.Text); }
            if (txtTotal2.Text != "") { Valor2 = Convert.ToDecimal(txtTotal2.Text); }
            if (txtTotal3.Text != "") { Valor3 = Convert.ToDecimal(txtTotal3.Text); }
            if (txtPercepIVA.Text != "") { Valor4 = Convert.ToDecimal(txtPercepIVA.Text); }
            if (txtPercepIVA.Text != "") { Valor5 = Convert.ToDecimal(txtPercepIngBrutos.Text); }
            if (txtNoGravado.Text != "") { Valor5 = Convert.ToDecimal(txtNoGravado.Text); }

            Total = Valor1 + Valor2 + Valor3 + Valor4 + Valor5 + Valor6;
        }
        public void RecalcularTotal4()
        {
            decimal Valor1 = 0;
            decimal Valor2 = 0;
            decimal Valor3 = 0;
            decimal Valor4 = 0;
            decimal Valor5 = 0;
            decimal Valor6 = 0;
            if (txtTotal1.Text != "") { Valor1 = Convert.ToDecimal(txtTotal1.Text); }
            if (txtTotal2.Text != "") { Valor2 = Convert.ToDecimal(txtTotal2.Text); }
            if (txtTotal3.Text != "") { Valor3 = Convert.ToDecimal(txtTotal3.Text); }
            if (txtPercepIVA.Text != "") { Valor4 = Convert.ToDecimal(txtPercepIVA.Text); }
            if (txtPercepIVA.Text != "") { Valor5 = Convert.ToDecimal(txtPercepIngBrutos.Text); }
            if (txtNoGravado.Text != "") { Valor5 = Convert.ToDecimal(txtNoGravado.Text); }

            Total = Valor1 + Valor2 + Valor3 + Valor4 + Valor5 + Valor6;
        }
        private void RecalcularTotal5()
        {
            decimal Valor1 = 0;
            decimal Valor2 = 0;
            decimal Valor3 = 0;
            decimal Valor4 = 0;
            decimal Valor5 = 0;
            decimal Valor6 = 0;
            if (txtTotal1.Text != "") { Valor1 = Convert.ToDecimal(txtTotal1.Text); }
            if (txtTotal2.Text != "") { Valor2 = Convert.ToDecimal(txtTotal2.Text); }
            if (txtTotal3.Text != "") { Valor3 = Convert.ToDecimal(txtTotal3.Text); }
            if (txtPercepIVA.Text != "") { Valor4 = Convert.ToDecimal(txtPercepIVA.Text); }
            if (txtPercepIngBrutos.Text != "") { Valor5 = Convert.ToDecimal(txtPercepIngBrutos.Text); }
            if (txtNoGravado.Text != "") { Valor5 = Convert.ToDecimal(txtNoGravado.Text); }

            Total = Valor1 + Valor2 + Valor3 + Valor4 + Valor5 + Valor6;
        }
        private void RecalcularTotal6()
        {
            decimal Valor1 = 0;
            decimal Valor2 = 0;
            decimal Valor3 = 0;
            decimal Valor4 = 0;
            decimal Valor5 = 0;
            decimal Valor6 = 0;
            if (txtTotal1.Text != "") { Valor1 = Convert.ToDecimal(txtTotal1.Text); }
            if (txtTotal2.Text != "") { Valor2 = Convert.ToDecimal(txtTotal2.Text); }
            if (txtTotal3.Text != "") { Valor3 = Convert.ToDecimal(txtTotal3.Text); }
            if (txtPercepIVA.Text != "") { Valor4 = Convert.ToDecimal(txtPercepIVA.Text); }
            if (txtPercepIVA.Text != "") { Valor5 = Convert.ToDecimal(txtPercepIngBrutos.Text); }
            if (txtNoGravado.Text != "") { Valor5 = Convert.ToDecimal(txtNoGravado.Text); }

            Total = Valor1 + Valor2 + Valor3 + Valor4 + Valor5 + Valor6;
        }
        private void btnVolver_Click(object sender, EventArgs e)
        {
            ComprasWF _tarea = new ComprasWF(razonSocial, cuit);
            _tarea.Show();
            Hide();
        }

        private void btnActualizarCombo_Click(object sender, EventArgs e)
        {
            List<string> Periodo = new List<string>();
            Periodo = PeriodoNeg.CargarComboPeriodo(cuit);
            cmbPeriodo.Items.Clear();
            //cmbCodigoMoneda.Text = "Seleccione";
            //cmbCodigoMoneda.Items.Add("Seleccione");
            foreach (string item in Periodo)
            {
                //cmbCodigoMoneda.Text = "Seleccione";
                cmbPeriodo.Items.Add(item);
            }
        }
    }
}
