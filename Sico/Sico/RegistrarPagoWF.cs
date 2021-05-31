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
using Sico.Negocio;

namespace Sico
{
    public partial class RegistrarPagoWF : Form
    {
        public int idPlan;
        public double MontoTotal;
        public RegistrarPagoWF(int idPlan, double MontoTotal)
        {
            InitializeComponent();
            this.idPlan = idPlan;
            this.MontoTotal = MontoTotal;
        }
        private void RegistrarPagoWF_Load(object sender, EventArgs e)
        {
            BuscarHistoricoDePagos(idPlan, MontoTotal);
        }
        private void BuscarHistoricoDePagos(int idPlan, double montoTotal)
        {
            List<Entidades.PlanHonorarios> ListarClientes = HonorariosNeg.BuscarHistoricoDePagos(idPlan);
            if (ListarClientes.Count > 0)
            {
                double SaldoDeudor = 0;
                foreach (var item in ListarClientes)
                {
                    SaldoDeudor = SaldoDeudor + item.MontoPago;
                }
                SaldoDeudor = montoTotal - SaldoDeudor;
                txtSaldoDeudor.Text = Convert.ToString(SaldoDeudor);
            }
            else { txtSaldoDeudor.Text = Convert.ToString(montoTotal); }
        }

        private void SoloNumeros(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }
            // solo 1 punto decimal
            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }
            //e.Handled = !char.IsNumber(e.KeyChar) && e.KeyChar != Convert.ToChar(Keys.Back);
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                Entidades.PlanHonorarios _plan = CargarEntidad();
                bool Exito = HonorariosNeg.RegistroPago(_plan);
                if (Exito == true)
                {
                    ProgressBar();
                    const string message2 = "El pago se registro exitosamente.";
                    const string caption2 = "Éxito";
                    var result2 = MessageBox.Show(message2, caption2,
                                                 MessageBoxButtons.OK,
                                                 MessageBoxIcon.Asterisk);
                    LimpiarCampos();
                }
                else
                {
                    const string message2 = "No se pudo registrar el pago ingresada.";
                    const string caption2 = "Atención";
                    var result2 = MessageBox.Show(message2, caption2,
                                                 MessageBoxButtons.OK,
                                                 MessageBoxIcon.Error);
                }
            }
            catch { }
        }
        private PlanHonorarios CargarEntidad()
        {
            PlanHonorarios _plan = new PlanHonorarios();
            DateTime fecha = dtFecha.Value;
            _plan.FechaPago = fecha;
            _plan.MontoPago = Convert.ToInt32(txtMonto.Text);
            _plan.Observaciones = txtObservaciones.Text;
            int idEmpresa = Sesion.UsuarioLogueado.idEmpresaSeleccionado;
            _plan.idCliente = idEmpresa;
            _plan.idPlan = idPlan;
            _plan.MontoTotal = MontoTotal;
            return _plan;
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
            txtMonto.Clear();
            dtFecha.Value = DateTime.Now;
            txtObservaciones.Clear();
            progressBar1.Value = Convert.ToInt32(null);
            progressBar1.Visible = false;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            PlanDeHonorariosWF planDeHonorarios = new PlanDeHonorariosWF();
            planDeHonorarios.BuscarTodasLosPlanesParaElCliente(Sesion.UsuarioLogueado.idEmpresaSeleccionado);
            Hide();
        }
    }
}
