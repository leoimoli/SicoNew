using Sico.Entidades;
using Sico.Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sico
{
    public partial class FacturacionCompraWF : Form
    {
        private string cuitCliente;
        private string RazonSocial;
        private string Cuit;
        public FacturacionCompraWF(string cuitCliente, string razonSocial, string cuit)
        {
            InitializeComponent();
            this.cuitCliente = cuitCliente;
            this.razonSocial = razonSocial;
            this.cuit = cuit;
            //lblNombreEdit.Text = razonSocial;
            //lblCuitEdit.Text = cuit;
        }

        private void FacturacionCompraWF_Load(object sender, EventArgs e)
        {
            CargarCombos();
            txtTipoCambio.Text = "1,000000";
        }
        #region Funciones
        public void IniciarPantalla()
        {
            CargarCombos();
            //BuscarFacturaParaClienteSeleccionado();
            dtFecha.Enabled = true;
        }
        private void CargarCombos()
        {
            List<string> TipoComprobante = new List<string>();
            TipoComprobante = ComprasNeg.CargarComboTipoComprobante();
            cmbTipoComprobante.Items.Clear();
            cmbTipoComprobante.Text = "Seleccione";
            cmbTipoComprobante.Items.Add("Seleccione");
            foreach (string item in TipoComprobante)
            {
                cmbTipoComprobante.Text = "Seleccione";
                cmbTipoComprobante.Items.Add(item);
            }
            List<string> CodigoOperacion = new List<string>();
            CodigoOperacion = ComprasNeg.CargarComboCodigoOperacion();
            cmbCodigoOperacion.Items.Clear();
            cmbCodigoOperacion.Text = "Seleccione";
            cmbCodigoOperacion.Items.Add("Seleccione");
            foreach (string item in CodigoOperacion)
            {
                cmbCodigoOperacion.Text = "Seleccione";
                cmbCodigoOperacion.Items.Add(item);
            }
            List<string> TipoMoneda = new List<string>();
            TipoMoneda = ComprasNeg.CargarComboTipoMoneda();
            cmbCodigoMoneda.Items.Clear();
            cmbCodigoMoneda.Text = "Seleccione";
            cmbCodigoMoneda.Items.Add("Seleccione");
            foreach (string item in TipoMoneda)
            {
                cmbCodigoMoneda.Text = "Seleccione";               
                cmbCodigoMoneda.Items.Add(item);
            }
            List<string> Periodo = new List<string>();
            Periodo = PeriodoNeg.CargarComboPeriodo(Sesion.UsuarioLogueado.idEmpresaSeleccionado);
            cmbPeriodo.Items.Clear();
            cmbPeriodo.Text = "Seleccione";
            cmbPeriodo.Items.Add("Seleccione");
            foreach (string item in Periodo)
            {
                cmbPeriodo.Text = "Seleccione";
                cmbPeriodo.Items.Add(item);
            }
        }
        public static decimal Total;
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
        private void HabilitarCampos()
        {
            dtFecha.Enabled = true;
            cmbTipoComprobante.Enabled = true;
            txtFactura.Enabled = true;
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
            btnCancelar.Enabled = true;
            btnGuardar.Enabled = true;
            txtNoGravado.Enabled = true;
            //btnActualizar.Visible = true;
            cmbPeriodo.Enabled = true;
            btnCrearPeriodo.Visible = true;
        }
        private const char SignoDecimal = '.'; // Carácter separador decimal
        private string _prevTextBoxValue; // Variable que almacena el valor anterior del Textbox
        private void txtTotal1_TextChanged(object sender, EventArgs e)
        {
            var textBox = (TextBox)sender;
            // Comprueba si el valor del TextBox se ajusta a un valor válido
            if (Regex.IsMatch(textBox.Text, @"^(?:\d+\,?\d*)?$"))
            {
                // Si es válido se almacena el valor actual en la variable privada
                _prevTextBoxValue = textBox.Text;
            }
            else
            {
                // Si no es válido se recupera el valor de la variable privada con el valor anterior
                // Calcula el nº de caracteres después del cursor para dejar el cursor en la misma posición
                var charsAfterCursor = textBox.TextLength - textBox.SelectionStart - textBox.SelectionLength;
                // Recupera el valor anterior
                textBox.Text = _prevTextBoxValue;
                // Posiciona el cursor en la misma posición
                textBox.SelectionStart = Math.Max(0, textBox.TextLength - charsAfterCursor);
            }
        }
        private void LimpiarCampos()
        {
            txtTotal1.Clear();
            txtTotal2.Clear();
            txtTotal3.Clear();
            txtNeto1.Clear();
            txtNeto2.Clear();
            txtNeto3.Clear();
            txtIva1.Clear();
            txtIva2.Clear();
            txtIva3.Clear();
            DateTime fecha = DateTime.Now;
            dtFecha.Value = fecha;
            CargarCombos();
            txtPercepIngBrutos.Clear();
            txtPercepIVA.Clear();
            txtNoGravado.Clear();
            txtFactura.Clear();
            Total = 0;
            lblTotalEdit.Text = "0";
            progressBar1.Value = Convert.ToInt32(null);
            progressBar1.Visible = false;
            lblTotalEdit.Text = "-";
        }
        private void InhabilitarCampos()
        {
            dtFecha.Enabled = false;
            cmbTipoComprobante.Enabled = false;
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
            txtPercepIngBrutos.Enabled = false;
            txtPercepIVA.Enabled = false;
            txtNoGravado.Enabled = false;
            cmbCodigoMoneda.Enabled = false;
            cmbCodigoOperacion.Enabled = false;
            txtTipoCambio.Enabled = false;
            btnCancelar.Enabled = false;
            btnGuardar.Enabled = false;
            labelNoGravado.Enabled = false;
            //btnActualizar.Visible = false;
            txtApellidoNombre.Clear();
            txtCodigoDocumento.Clear();
            txtCuit.Clear();
            txtCuit.Focus();
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
        public static int idProveedorSeleccionado;
        private string razonSocial;
        private string cuit;

        private void txtCuit_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    string cuit = txtCuit.Text;
                    List<Proveedor> _DatosProveedor = new List<Proveedor>();
                    _DatosProveedor = ProveedorNeg.BuscarProveedorPorCuit(cuit);
                    if (_DatosProveedor.Count > 0)
                    {
                        var datos = _DatosProveedor.First();
                        idProveedorSeleccionado = datos.IdProveedor;
                        txtApellidoNombre.Text = datos.NombreRazonSocial;
                        txtCodigoDocumento.Text = "80-Cuit";
                        cmbCodigoMoneda.Text = "PES - PesosArgentinos";
                        cmbCodigoOperacion.Text = "0 - NO CORRESPONDE";
                        string TipoComprobante = datos.Factura;
                        txtTipoCambio.Text = "1,000000";
                        if (TipoComprobante.Length > 8)
                        {
                            string Fact = TipoComprobante;
                            var splitFactura1 = Fact.Split('-')[0];
                            var splitFactura2 = Fact.Split('-')[1];
                            splitFactura1 = splitFactura1.Trim();
                            splitFactura2 = splitFactura2.Trim();
                            if (splitFactura1 == "FacturaA")
                            {
                                cmbTipoComprobante.Text = "001 - FACTURAS A";
                            }
                        }
                        else
                        {
                            if (TipoComprobante == "FacturaA")
                            {
                                cmbTipoComprobante.Text = "001 - FACTURAS A";
                            }
                            if (TipoComprobante == "FacturaB")
                            {
                                cmbTipoComprobante.Text = "006 - FACTURAS B";
                            }
                            if (TipoComprobante == "FacturaC")
                            {
                                cmbTipoComprobante.Text = "FACTURAS C";
                            }
                        }
                        HabilitarCampos();
                    }
                    else { MessageBox.Show("No existe ningun proveedor en la base de datos con el cuit ingresado."); }
                }
                catch (Exception ex)
                { }
            }
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
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {

                Entidades.FacturaCompra _factura = CargarEntidad();
                bool Exito = ComprasNeg.GuardarFacturaCompra(_factura, cuitCliente);
                if (Exito == true)
                {
                    ProgressBar();
                    const string message2 = "Se registro la factura de compra exitosamente.";
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
            catch (Exception ex)
            { }
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
            if (txtPercepIngBrutos.Text != "") { Valor5 = Convert.ToDecimal(txtPercepIngBrutos.Text); }
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
            if (txtPercepIngBrutos.Text != "") { Valor5 = Convert.ToDecimal(txtPercepIngBrutos.Text); }
            if (txtNoGravado.Text != "") { Valor6 = Convert.ToDecimal(txtNoGravado.Text); }

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
            if (txtPercepIngBrutos.Text != "") { Valor5 = Convert.ToDecimal(txtPercepIngBrutos.Text); }
            if (txtNoGravado.Text != "") { Valor6 = Convert.ToDecimal(txtNoGravado.Text); }

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
            if (txtPercepIngBrutos.Text != "") { Valor5 = Convert.ToDecimal(txtPercepIngBrutos.Text); }
            if (txtNoGravado.Text != "") { Valor6 = Convert.ToDecimal(txtNoGravado.Text); }

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
            if (txtNoGravado.Text != "") { Valor6 = Convert.ToDecimal(txtNoGravado.Text); }

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
            if (txtPercepIngBrutos.Text != "") { Valor5 = Convert.ToDecimal(txtPercepIngBrutos.Text); }
            if (txtNoGravado.Text != "") { Valor6 = Convert.ToDecimal(txtNoGravado.Text); }

            Total = Valor1 + Valor2 + Valor3 + Valor4 + Valor5 + Valor6;
        }
        private FacturaCompra CargarEntidad()
        {
            FacturaCompra _factura = new FacturaCompra();
            _factura.idProveedor = Convert.ToInt32(lblidProveedor.Text);
            _factura.CodigoDocumento = txtCodigoDocumento.Text;
            _factura.ApellidoNombre = txtApellidoNombre.Text;
            DateTime fecha = dtFecha.Value;
            _factura.Fecha = fecha.ToShortDateString();
            _factura.TipoComprobante = cmbTipoComprobante.Text;

            string factura = txtFactura.Text;
            ///// Primera parte del numero
            var split1 = factura.Split('-')[0];
            split1 = split1.Trim();
            ///// Segunda parte del numero
            var split2 = factura.Split('-')[1];
            split2 = split2.Trim();

            if (split1.Length < 5)
            {
                split1 = split1.PadLeft(5, '0');
            }
            if (split2.Length < 8)
            {
                split2 = split2.PadLeft(8, '0');
            }
            string nroFactura = string.Concat(split1, "-", split2);
            _factura.NroFactura = nroFactura;
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
        #endregion
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            InhabilitarCampos();
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            string RazonSocial = this.razonSocial;
            string cuit = this.cuit;
            ComprasWF _tarea = new ComprasWF(razonSocial, cuit);
            _tarea.Show();
            Hide();
        }

        private void cmbTipoComprobante_TextChanged(object sender, EventArgs e)
        {
            if (cmbTipoComprobante.Text == "001 - FACTURA A\r" || cmbTipoComprobante.Text == "003 - NOTA DE CREDITO A\r")
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
                txtFactura.Focus();
            }
            if (cmbTipoComprobante.Text == "006 - FACTURA B\r" || cmbTipoComprobante.Text == "008 - NOTA DE CREDITO B\r")
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
                txtFactura.Focus();
            }
            if (cmbTipoComprobante.Text == "011 - FACTURA C" || cmbTipoComprobante.Text == "013 - NOTA DE CREDITO C")
            {
                txtTotal1.Enabled = false;
                txtTotal2.Enabled = false;
                txtTotal3.Enabled = false;
                txtNeto1.Enabled = false;
                txtNeto2.Enabled = false;
                txtNeto3.Enabled = false;
                txtIva1.Enabled = false;
                txtIva2.Enabled = false;
                txtIva3.Enabled = false;
                txtPercepIngBrutos.Enabled = false;
                txtPercepIVA.Enabled = false;
                txtNoGravado.Enabled = true;
                txtFactura.Focus();
            }
        }
        public static int idCliente;
        private void btnCrearPeriodo_Click(object sender, EventArgs e)
        {

            PeriodosWF _periodo = new PeriodosWF(cuit, razonSocial);
            _periodo.Show();
        }
        private void btnActualizarCombo_Click(object sender, EventArgs e)
        {
            CargarCombos();
        }
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

        private void btnAltaProveedor_Click(object sender, EventArgs e)
        {
            ProveedoresWF _proveedor = new ProveedoresWF();
            _proveedor.Show();
        }
        private void btnBuscarProveedor_Click(object sender, EventArgs e)
        {
            ProveedorNuevoWF _proveedor = new ProveedorNuevoWF();
            _proveedor.Show();
        }
        private void btnCargaMasiva_Click(object sender, EventArgs e)
        {
            ComprasImportarComprasWF _compras = new ComprasImportarComprasWF(null, null);
            _compras.Show();
        }
    }
}

