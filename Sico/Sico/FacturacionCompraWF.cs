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
    public partial class FacturacionCompraWF : MasterWF
    {
        public FacturacionCompraWF()
        {
            InitializeComponent();
        }
        private void FacturacionCompraWF_Load(object sender, EventArgs e)
        {
            CargarCombos();
        }
        #region Funciones
        private void CargarCombos()
        {
            List<string> TipoComprobante = new List<string>();
            TipoComprobante = ComprasNeg.CargarComboTipoComprobante();
            cmbTipoComprobante.Items.Clear();
            //cmbTipoComprobante.Text = "Seleccione";
            //cmbTipoComprobante.Items.Add("Seleccione");
            foreach (string item in TipoComprobante)
            {
                //cmbTipoComprobante.Text = "Seleccione";
                cmbTipoComprobante.Items.Add(item);
            }

            List<string> CodigoOperacion = new List<string>();
            CodigoOperacion = ComprasNeg.CargarComboCodigoOperacion();
            cmbCodigoOperacion.Items.Clear();
            //cmbCodigoOperacion.Text = "Seleccione";
            //cmbCodigoOperacion.Items.Add("Seleccione");
            foreach (string item in CodigoOperacion)
            {
                //cmbCodigoOperacion.Text = "Seleccione";
                cmbCodigoOperacion.Items.Add(item);
            }

            List<string> TipoMoneda = new List<string>();
            TipoMoneda = ComprasNeg.CargarComboTipoMoneda();
            cmbCodigoMoneda.Items.Clear();
            //cmbCodigoMoneda.Text = "Seleccione";
            //cmbCodigoMoneda.Items.Add("Seleccione");
            foreach (string item in TipoMoneda)
            {
                //cmbCodigoMoneda.Text = "Seleccione";
                cmbCodigoMoneda.Items.Add(item);
            }
        }
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
            btnActualizar.Visible = true;
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
            labelNoGravado.Enabled = false;
            cmbCodigoMoneda.Enabled = false;
            cmbCodigoOperacion.Enabled = false;
            txtTipoCambio.Enabled = false;
            btnCancelar.Enabled = false;
            btnGuardar.Enabled = false;
            labelNoGravado.Enabled = false;
            btnActualizar.Visible = false;
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
        #endregion
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
                        txtApellidoNombre.Text = datos.NombreRazonSocial;
                        txtCodigoDocumento.Text = "80-Cuit";
                        cmbCodigoMoneda.Text = "PES - PesosArgentinos";
                        cmbCodigoOperacion.Text = "0 - NO CORRESPONDE";
                        string TipoComprobante = datos.Factura;
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
                }
                catch (Exception ex)
                { }
            }
        }
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            InhabilitarCampos();
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }
    }
}
