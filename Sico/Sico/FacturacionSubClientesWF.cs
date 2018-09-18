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



        #region Funciones
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
            }
            catch (Exception ex)
            { }
        }
        #endregion      
    }
}
