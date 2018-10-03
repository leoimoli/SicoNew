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

namespace Sico
{
    public partial class FacturacionSubClientesWF : Form
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
                    decimal TotalCargado = Convert.ToDecimal(Total1);
                    decimal TotalMostrar = Total + TotalCargado;
                    Total = TotalMostrar;
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
                    decimal TotalCargado = Convert.ToDecimal(Total2);
                    decimal TotalMostrar = Total + TotalCargado;
                    Total = TotalMostrar;
                    lblTotalEdit.Text = Convert.ToString(TotalMostrar);
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
                    decimal TotalCargado = Convert.ToDecimal(Total3);
                    decimal TotalMostrar = Total + TotalCargado;
                    Total = TotalMostrar;
                    lblTotalEdit.Text = Convert.ToString(TotalMostrar);
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
                string NuevoNroFactura = ClienteNeg.BuscarNuevoNroFactura(persona);
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
        #endregion

        private void btnNuevoSubCliente_Click(object sender, EventArgs e)
        {
            SubClienteWF _sub = new SubClienteWF(razonSocial, cuit);
            _sub.Show();
            Hide();
        }
    }
}
