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
    public partial class PlanDeHonorariosWF : Form
    {
        public PlanDeHonorariosWF()
        {
            InitializeComponent();
        }

        private void PlanDeHonorariosWF_Load(object sender, EventArgs e)
        {
            try
            {
                if (Sesion.UsuarioLogueado.idEmpresaSeleccionado > 0)
                {
                    BuscarTodasLosPlanesParaElCliente(Sesion.UsuarioLogueado.idEmpresaSeleccionado);
                }
                //else
                //{
                //    const string message2 = "Atención: Usted debe seleccionar una empresa previamente.";
                //    const string caption2 = "Atención";
                //    var result2 = MessageBox.Show(message2, caption2,
                //                                 MessageBoxButtons.OK,
                //                                 MessageBoxIcon.Asterisk);
                //    throw new Exception();
                //}
            }
            catch (Exception ex)
            { }
        }
        private void DiseñoGrilla()
        {
            this.dgvPlanesHonorarios.DefaultCellStyle.Font = new Font("Tahoma", 9);
            this.dgvPlanesHonorarios.DefaultCellStyle.ForeColor = Color.Black;
            this.dgvPlanesHonorarios.DefaultCellStyle.BackColor = Color.White;
            this.dgvPlanesHonorarios.DefaultCellStyle.SelectionForeColor = Color.SteelBlue;
            this.dgvPlanesHonorarios.DefaultCellStyle.SelectionBackColor = Color.White;
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
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            LimpiarCamposBotonNuevoCliente();
            Funcion = 1;
        }
        public static int Funcion = 0;
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                Entidades.PlanHonorarios _plan = CargarEntidad();
                if (Funcion == 2)
                {
                    bool Exito = HonorariosNeg.EditarPlan(_plan);
                    if (Exito == true)
                    {
                        ProgressBar();
                        const string message2 = "La edición del plan se registro exitosamente.";
                        const string caption2 = "Éxito";
                        var result2 = MessageBox.Show(message2, caption2,
                                                     MessageBoxButtons.OK,
                                                     MessageBoxIcon.Asterisk);
                        LimpiarCampos();
                        BuscarTodasLosPlanesParaElCliente(Sesion.UsuarioLogueado.idEmpresaSeleccionado);
                    }
                }
                if (Funcion == 1)
                {
                    _plan.Estado = "Abierto";
                    bool Exito = HonorariosNeg.GurdarPlan(_plan);
                    if (Exito == true)
                    {
                        ProgressBar();
                        const string message2 = "Se registro el plan exitosamente.";
                        const string caption2 = "Éxito";
                        var result2 = MessageBox.Show(message2, caption2,
                                                     MessageBoxButtons.OK,
                                                     MessageBoxIcon.Asterisk);
                        LimpiarCampos();
                        BuscarTodasLosPlanesParaElCliente(Sesion.UsuarioLogueado.idEmpresaSeleccionado);
                    }
                    else
                    {
                        const string message2 = "No se pudo registrar el plan ingresada.";
                        const string caption2 = "Atención";
                        var result2 = MessageBox.Show(message2, caption2,
                                                     MessageBoxButtons.OK,
                                                     MessageBoxIcon.Error);
                    }
                }
            }
            catch { }
        }
        public void BuscarTodasLosPlanesParaElCliente(int idEmpresaSeleccionado)
        {
            dgvPlanesHonorarios.Rows.Clear();
            List<Entidades.PlanHonorarios> ListarClientes = HonorariosNeg.ListarTodosPlanesParaCliente(idEmpresaSeleccionado);
            if (ListarClientes.Count > 0)
            {           
                DiseñoGrilla();
                dgvPlanesHonorarios.Visible = true;
                btnNuevo.Visible = true;
                btnEditar.Visible = true;
                lbllistado.Visible = true;
                foreach (var item in ListarClientes)
                {
                    string FechaDesde = item.FechaDesde.ToShortDateString();
                    string FechaHasta = item.FechaHasta.ToShortDateString();
                    dgvPlanesHonorarios.Rows.Add(item.idPlan, item.Descripcion, FechaDesde, FechaHasta, item.MontoTotal, item.Estado, item.Observaciones);
                }
                dgvPlanesHonorarios.AllowUserToAddRows = false;
            }
            else
            {              
                dgvPlanesHonorarios.Visible = false;
                btnNuevo.Visible = false;
                btnEditar.Visible = false;
                lbllistado.Visible = false;
            }
        }
        private void LimpiarCampos()
        {
            PanelRegistroPlan.Enabled = true;
            txtDescripcion.Clear();
            DateTime fecha = DateTime.Now;
            dtFechaDesde.Value = fecha;
            dtFechaHasta.Value = fecha;
            progressBar1.Value = Convert.ToInt32(null);
            progressBar1.Visible = false;
            txtMontoMensual.Clear();
            txtMontoTotal.Clear();
            txtObservaciones.Clear();
            txtDescripcion.Focus();
        }
        private void LimpiarCamposBotonNuevoCliente()
        {
            PanelRegistroPlan.Enabled = true;
            txtDescripcion.Clear();
            DateTime fecha = DateTime.Now;
            dtFechaDesde.Value = fecha;
            dtFechaHasta.Value = fecha;
            progressBar1.Value = Convert.ToInt32(null);
            progressBar1.Visible = false;
            txtMontoMensual.Clear();
            txtMontoTotal.Clear();
            txtObservaciones.Clear();
            txtDescripcion.Focus();

        }
        private PlanHonorarios CargarEntidad()
        {
            PlanHonorarios _plan = new PlanHonorarios();
            if (idPlanSeleccionado > 0)
            {
                _plan.idPlan = idPlanSeleccionado;
            }
            _plan.Descripcion = txtDescripcion.Text;
            DateTime fecha = dtFechaDesde.Value;
            _plan.FechaDesde = fecha;
            DateTime fechahasta = dtFechaHasta.Value;
            _plan.FechaHasta = fechahasta;
            _plan.MontoMensual = Convert.ToInt32(txtMontoMensual.Text);
            _plan.MontoTotal = Convert.ToInt32(txtMontoTotal.Text);
            _plan.Observaciones = txtObservaciones.Text;
            int idEmpresa = Sesion.UsuarioLogueado.idEmpresaSeleccionado;
            _plan.idCliente = idEmpresa;
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
        private void CalcularMontoTotal()
        {
            if (txtMontoMensual.Text != "")
            {
                DateTime FechaDesde = dtFechaDesde.Value;
                DateTime FechaHasta = dtFechaHasta.Value;
                double Meses = Math.Abs((FechaHasta.Month - FechaDesde.Month) + 12 * (FechaHasta.Year - FechaDesde.Year));
                Meses = Meses + 1;
                double MontoMensual = Convert.ToDouble(txtMontoMensual.Text);
                double MontoTotal = Meses * MontoMensual;
                txtMontoTotal.Text = Convert.ToString(MontoTotal);
            }
        }
        private void txtMontoMensual_TextChanged(object sender, EventArgs e)
        {
            CalcularMontoTotal();
        }
        private void dgvPlanesHonorarios_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex >= 0 && this.dgvPlanesHonorarios.Columns[e.ColumnIndex].Name == "Ver" && e.RowIndex >= 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                DataGridViewButtonCell BotonVer = this.dgvPlanesHonorarios.Rows[e.RowIndex].Cells["Ver"] as DataGridViewButtonCell;
                Icon icoAtomico = new Icon(Environment.CurrentDirectory + "\\" + @"Ver.ico");
                e.Graphics.DrawIcon(icoAtomico, e.CellBounds.Left + 20, e.CellBounds.Top + 4);
                this.dgvPlanesHonorarios.Rows[e.RowIndex].Height = icoAtomico.Height + 8;
                this.dgvPlanesHonorarios.Columns[e.ColumnIndex].Width = icoAtomico.Width + 40;
                e.Handled = true;
            }
            if (e.ColumnIndex >= 0 && this.dgvPlanesHonorarios.Columns[e.ColumnIndex].Name == "RegistroPago" && e.RowIndex >= 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                DataGridViewButtonCell BotonVer = this.dgvPlanesHonorarios.Rows[e.RowIndex].Cells["RegistroPago"] as DataGridViewButtonCell;
                Icon icoAtomico = new Icon(Environment.CurrentDirectory + "\\" + @"metodo-de-pago.ico");
                e.Graphics.DrawIcon(icoAtomico, e.CellBounds.Left + 20, e.CellBounds.Top + 4);
                this.dgvPlanesHonorarios.Rows[e.RowIndex].Height = icoAtomico.Height + 8;
                this.dgvPlanesHonorarios.Columns[e.ColumnIndex].Width = icoAtomico.Width + 40;
                e.Handled = true;
            }
        }
        private void dgvPlanesHonorarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvPlanesHonorarios.CurrentCell.ColumnIndex == 7)
            {
                string Estado = dgvPlanesHonorarios.CurrentRow.Cells[5].Value.ToString();
                if (Estado != "Cerrado")
                {
                    int idPlan = Convert.ToInt32(this.dgvPlanesHonorarios.CurrentRow.Cells[0].Value.ToString());
                    double MontoTotal = Convert.ToDouble(this.dgvPlanesHonorarios.CurrentRow.Cells[4].Value.ToString());
                    RegistrarPagoWF frm2 = new RegistrarPagoWF(idPlan, MontoTotal);
                    frm2.Show();
                }
                else
                {
                    const string message2 = "No se puede registrar un pago en un plan con estado cerrado.";
                    const string caption2 = "Atención";
                    var result2 = MessageBox.Show(message2, caption2,
                                                 MessageBoxButtons.OK,
                                                 MessageBoxIcon.Exclamation);
                }
            }
            if (dgvPlanesHonorarios.CurrentCell.ColumnIndex == 8)
            {
                int idPlan = Convert.ToInt32(this.dgvPlanesHonorarios.CurrentRow.Cells[0].Value.ToString());
                double MontoTotal = Convert.ToDouble(this.dgvPlanesHonorarios.CurrentRow.Cells[4].Value.ToString());
                DetalleDePagosWF frm2 = new DetalleDePagosWF(idPlan, MontoTotal);
                frm2.Show();
            }
        }
        public static int idPlanSeleccionado;
        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (this.dgvPlanesHonorarios.RowCount > 0)
            {
                string Estado = dgvPlanesHonorarios.CurrentRow.Cells[5].Value.ToString();
                if (Estado != "Cerrado")
                {
                    PanelRegistroPlan.Enabled = true;
                    Funcion = 2;
                    List<Entidades.PlanHonorarios> _plan = new List<Entidades.PlanHonorarios>();
                    idPlanSeleccionado = Convert.ToInt32(this.dgvPlanesHonorarios.CurrentRow.Cells[0].Value);
                    txtDescripcion.Text = dgvPlanesHonorarios.CurrentRow.Cells[1].Value.ToString();
                    dtFechaDesde.Value = Convert.ToDateTime(dgvPlanesHonorarios.CurrentRow.Cells[2].Value.ToString());
                    dtFechaHasta.Value = Convert.ToDateTime(dgvPlanesHonorarios.CurrentRow.Cells[3].Value.ToString());
                    txtMontoTotal.Text = dgvPlanesHonorarios.CurrentRow.Cells[4].Value.ToString();
                    CalculoSinTenerMontoMensual(dtFechaDesde.Value, dtFechaHasta.Value, txtMontoTotal.Text);
                    txtObservaciones.Text = dgvPlanesHonorarios.CurrentRow.Cells[6].Value.ToString();
                }
            }
            else
            {
                const string message2 = "Debe seleccionar un plan de la grilla.";
                const string caption2 = "Atención";
                var result2 = MessageBox.Show(message2, caption2,
                                             MessageBoxButtons.OK,
                                             MessageBoxIcon.Asterisk);
            }
        }

        private void CalculoSinTenerMontoMensual(DateTime valueDesde1, DateTime valueHasta2, string MontoTotalObtenido)
        {
            DateTime FechaDesde = valueDesde1;
            DateTime FechaHasta = valueHasta2;
            double Meses = Math.Abs((FechaHasta.Month - FechaDesde.Month) + 12 * (FechaHasta.Year - FechaDesde.Year));
            Meses = Meses + 1;
            double MontoTotal = Convert.ToDouble(MontoTotalObtenido);
            double MontoMensual = MontoTotal / Meses;
            txtMontoMensual.Text = Convert.ToString(MontoMensual);
        }
    }
}

