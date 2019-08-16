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
using System.Diagnostics;
using System.Text.RegularExpressions;

namespace Sico
{
    public partial class FacturacionSubClientesWF : MasterWF
    {
        private string cuit;
        private string razonSocial;
        public FacturacionSubClientesWF(string razonSocial, string cuit)
        {
            InitializeComponent();
            this.razonSocial = razonSocial;
            this.cuit = cuit;
        }
        private void FacturacionSubClientesWF_Load(object sender, EventArgs e)
        {
            try
            {
                lblNombreEdit.Text = razonSocial;
                lblCuitEdit.Text = cuit;
                CargarComboPersonas();
                CargarCombo();
                string NroFactura = ClienteNeg.BuscarNroFactura(cuit);
                txtFactura.Text = NroFactura;
                Total = 0;
                cmbCodigoMoneda.Text = "PES - PesosArgentinos";
                cmbCodigoOperacion.Text = "0 - NO CORRESPONDE";
                cmbTipoComprobante.Text = "006 - FACTURAS B";
                txtTipoCambio.Text = "1,000000";
            }
            catch (Exception ex)
            { }

        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                Entidades.SubCliente _subCliente = CargarEntidad();
                bool Exito = ClienteNeg.GuardarFacturaSubCliente(_subCliente, cuit);
                if (Exito == true)
                {
                    ProgressBar();
                    const string message2 = "Se registro la factura exitosamente.";
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
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            try
            {
                FuncionesBotonCancelar();
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
        private void btnCargarArchivo1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string path = "";
                System.IO.StreamReader sr = new
                   System.IO.StreamReader(openFileDialog1.FileName);
                path = openFileDialog1.FileName;
                txtAdjunto.Text = path;
                sr.Close();
            }
        }
        private void btnNuevoSubCliente_Click(object sender, EventArgs e)
        {
            SubClienteWF _sub = new SubClienteWF(razonSocial, cuit);
            _sub.Show();
            Hide();
        }
        private void btnAdjuntarFacturaElectronica_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string path = "";
                System.IO.StreamReader sr = new
                   System.IO.StreamReader(openFileDialog1.FileName);
                path = openFileDialog1.FileName;
                txtAdjunto.Text = path;
                sr.Close();
            }
        }
        private void btnCrearPeriodo_Click(object sender, EventArgs e)
        {
            PeriodosVentasWF _periodo = new PeriodosVentasWF(cuit, razonSocial);
            _periodo.Show();
        }
        private void btnActualizarCombo_Click(object sender, EventArgs e)
        {
            CargarCombo();
        }
        #region Funciones
        public static decimal Total;
        private void CargarCombo()
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
            List<string> Periodo = new List<string>();
            Periodo = PeriodoNeg.CargarComboPeriodoVenta(cuit);
            cmbPeriodo.Items.Clear();
            foreach (string item in Periodo)
            {
                cmbPeriodo.Items.Add(item);
            }
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
        private void CargarComboPersonas()
        {
            List<string> Personas = new List<string>();
            Personas = ClienteNeg.CargarComboPersonas(cuit);
            cmbPersonas.Items.Clear();
            cmbPersonas.Text = "Seleccione";
            cmbPersonas.Items.Add("Seleccione");
            foreach (string item in Personas)
            {
                cmbPersonas.Text = "Seleccione";
                cmbPersonas.Items.Add(item);
            }
        }
        private void cmbPersonas_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string persona = cmbPersonas.Text;
                string NuevoNroFactura = ClienteNeg.BuscarNroFactura(cuit);
                txtFactura.Text = NuevoNroFactura;
                dtFecha.Enabled = true;
                string apellidoNombre = cmbPersonas.Text;
                List<SubCliente> DatosPersonales = ClienteNeg.BuscarDatosSubClientePorApellidoNombre(apellidoNombre, cuit);
                if (DatosPersonales.Count > 0)
                {
                    HabilitarLabels();
                    var datos = DatosPersonales.First();
                    if (String.IsNullOrEmpty(datos.Dni))
                    { lblDniEdit.Text = "No informa"; }
                    else { lblDniEdit.Text = datos.Dni; }

                    if (String.IsNullOrEmpty(datos.Direccion))
                    { lblDireccionEdit.Text = "No informa"; }
                    else { lblDireccionEdit.Text = datos.Direccion; }

                    if (String.IsNullOrEmpty(datos.Observacion))
                    { lblObservacionsEdit.Text = "No informa"; }
                    else { lblObservacionsEdit.Text = datos.Observacion; }
                }
            }
            catch (Exception ex)
            { }
        }
        private void HabilitarLabels()
        {
            lblDni.Visible = true;
            lblDniEdit.Visible = true;
            lblObservaciones.Visible = true;
            lblObservacionsEdit.Visible = true;
            lblDireccion.Visible = true;
            lblDireccionEdit.Visible = true;
        }
        private SubCliente CargarEntidad()
        {
            SubCliente _subCliente = new SubCliente();
            _subCliente.ApellidoNombre = cmbPersonas.Text;
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
            _subCliente.NroFactura = nroFactura;
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
            _subCliente.TipoComprobante = cmbTipoComprobante.Text;
            _subCliente.CodigoMoneda = cmbCodigoMoneda.Text;
            _subCliente.TipoDeCambio = txtTipoCambio.Text;
            _subCliente.CodigoTipoOperacion = cmbCodigoOperacion.Text;
            _subCliente.Adjunto = txtAdjunto.Text;
            _subCliente.Periodo = cmbPeriodo.Text;
            return _subCliente;
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
            //DateTime fecha = DateTime.Now;
            //dtFecha.Value = fecha;
            //CargarComboPersonas();
            progressBar1.Value = Convert.ToInt32(null);
            progressBar1.Visible = false;
            lblTotalEdit.Text = "-";
            Total = 0;
            //lblDireccionEdit.Clear();
            //lblDniEdit.Clear();
            //lblObservacionsEdit.Text = "";
            //lblDni.Visible = false;
            //lblDireccion.Visible = false;
            //lblObservaciones.Visible = false;
            //lblDireccionEdit.Visible = false;
            //lblDniEdit.Visible = false;
            txtAdjunto.Clear();
            CalcularProximoNumeroBoleta();
        }
        private void CalcularProximoNumeroBoleta()
        {
            string FacturaVieja = txtFactura.Text;
            ///// Primera parte del numero
            var split1 = FacturaVieja.Split('-')[0];
            split1 = split1.Trim();
            ///// Segunda parte del numero
            var split2 = FacturaVieja.Split('-')[1];
            split2 = split2.Trim();
            string prueba = string.Concat(split1, split2);
            int Numero = Convert.ToInt32(prueba);
            int Fac = Numero + 1;
            string prueba2 = Convert.ToString(Fac);
            txtFactura.Text = string.Concat("0000", prueba2);
        }
        private void FuncionesBotonCancelar()
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
            CargarComboPersonas();
            progressBar1.Value = Convert.ToInt32(null);
            progressBar1.Visible = false;
            lblTotalEdit.Text = "-";
            Total = 0;
            lblDireccionEdit.Clear();
            lblDniEdit.Clear();
            lblObservacionsEdit.Text = "";
            lblDni.Visible = false;
            lblDireccion.Visible = false;
            lblObservaciones.Visible = false;
            lblDireccionEdit.Visible = false;
            lblDniEdit.Visible = false;
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

        private void btnVolver_Click(object sender, EventArgs e)
        {
            TareaClienteWF _tarea = new TareaClienteWF(razonSocial, cuit);
            _tarea.Show();
            Hide();
        }
    }
}
