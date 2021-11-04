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
    public partial class AgendaWF : Form
    {
        public AgendaWF()
        {
            InitializeComponent();
        }
        public static int Funcion = 0;
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            LimpiarCamposBotonNuevo();
            Funcion = 1;
        }
        private void LimpiarCamposBotonNuevo()
        {
            PanelRegistroPlan.Enabled = true;
            txtDescripcion.Clear();
            DateTime fecha = DateTime.Now;
            dtFecha.Value = fecha;
            progressBar1.Value = Convert.ToInt32(null);
            progressBar1.Visible = false;
            txtDescripcion.Focus();
            chcPersonal.Checked = true;
            chcUsuarios.Checked = false;
            chcEmail.Checked = false;
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
                Agenda _agenda = CargarEntidad();
                if (Funcion == 2)
                {
                    bool Exito = AgendaNeg.EditarRecordatorio(_agenda, idAgendaSeleccionado);
                    if (Exito == true)
                    {
                        ProgressBar();
                        const string message2 = "La edición del recordatorio se registro exitosamente.";
                        const string caption2 = "Éxito";
                        var result2 = MessageBox.Show(message2, caption2,
                                                     MessageBoxButtons.OK,
                                                     MessageBoxIcon.Asterisk);
                        LimpiarCampos();
                        BuscarAgendaParaUsuario(Sesion.UsuarioLogueado.IdUsuario);
                    }
                }
                if (Funcion == 1)
                {
                    _agenda.Estado = 1;
                    bool Exito = AgendaNeg.GuardarRecordatorio(_agenda);
                    if (Exito == true)
                    {
                        ProgressBar();
                        const string message2 = "Se registro el recordatorio exitosamente.";
                        const string caption2 = "Éxito";
                        var result2 = MessageBox.Show(message2, caption2,
                                                     MessageBoxButtons.OK,
                                                     MessageBoxIcon.Asterisk);
                        LimpiarCampos();
                        BuscarAgendaParaUsuario(Sesion.UsuarioLogueado.IdUsuario);
                    }
                    else
                    {
                        const string message2 = "No se pudo registrar el recordatorio ingresada.";
                        const string caption2 = "Atención";
                        var result2 = MessageBox.Show(message2, caption2,
                                                     MessageBoxButtons.OK,
                                                     MessageBoxIcon.Error);
                    }
                }
            }
            catch { }
        }
        private void LimpiarCampos()
        {
            PanelRegistroPlan.Enabled = true;
            txtDescripcion.Clear();
            DateTime fecha = DateTime.Now;
            dtFecha.Value = fecha;
            progressBar1.Value = Convert.ToInt32(null);
            progressBar1.Visible = false;
            txtDescripcion.Focus();
            chcPersonal.Checked = true;
            chcUsuarios.Checked = false;
            chcEmail.Checked = false;
        }
        private Agenda CargarEntidad()
        {
            Agenda _agenda = new Agenda();
            //if (idPlanSeleccionado > 0)
            //{
            //    _plan.idPlan = idPlanSeleccionado;
            //}
            _agenda.Descripcion = txtDescripcion.Text;
            DateTime fecha = dtFecha.Value;
            _agenda.Fecha = fecha;
            _agenda.FechaDelRegistro = DateTime.Now;
            if (chcPersonal.Checked == true)
            {
                _agenda.idUsuario = Sesion.UsuarioLogueado.IdUsuario;
            }
            else
            { _agenda.idUsuario = 0; }
            if (chcUsuarios.Checked == true)
            {
                _agenda.UsuariosSistema = 1;
            }
            else
            {
                _agenda.UsuariosSistema = 0;
            }
            if (chcEmail.Checked == true)
            {
                _agenda.Email = 1;
            }
            else
            {
                _agenda.Email = 0;
            }
            return _agenda;
        }
        private void chcPersonal_CheckedChanged(object sender, EventArgs e)
        {
            if (chcPersonal.Checked == true)
            {
                chcUsuarios.Checked = false;
            }
            else
            {
                chcUsuarios.Checked = true;
            }
        }
        private void chcUsuarios_CheckedChanged(object sender, EventArgs e)
        {
            if (chcUsuarios.Checked == true)
            {
                chcPersonal.Checked = false;
            }
            else
            {
                chcPersonal.Checked = true;
            }
        }
        private void dgvAgenda_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex >= 0 && this.dgvAgenda.Columns[e.ColumnIndex].Name == "Finalizar" && e.RowIndex >= 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                DataGridViewButtonCell BotonVer = this.dgvAgenda.Rows[e.RowIndex].Cells["Finalizar"] as DataGridViewButtonCell;
                Icon icoAtomico = new Icon(Environment.CurrentDirectory + "\\" + @"cruzar.ico");
                e.Graphics.DrawIcon(icoAtomico, e.CellBounds.Left + 20, e.CellBounds.Top + 4);
                this.dgvAgenda.Rows[e.RowIndex].Height = icoAtomico.Height + 8;
                this.dgvAgenda.Columns[e.ColumnIndex].Width = icoAtomico.Width + 40;
                e.Handled = true; 
            }
        }
        private void dgvAgenda_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvAgenda.CurrentCell.ColumnIndex == 3)
            {

                const string message = "¿Usted desea cerrar el recordatorio seleccionado?";
                const string caption = "Consulta";
                var result = MessageBox.Show(message, caption,
                                             MessageBoxButtons.YesNo,
                                             MessageBoxIcon.Question);
                {
                    if (result == DialogResult.Yes)
                    {
                        int idRecordatorio = Convert.ToInt32(this.dgvAgenda.CurrentRow.Cells[0].Value.ToString());
                        bool Exito = AgendaNeg.AnularRecordatorio(idRecordatorio);
                        if (Exito == true)
                        {
                            const string message2 = "Se elimino el recordatorio seleccionado exitosamente.";
                            const string caption2 = "Éxito";
                            var result2 = MessageBox.Show(message2, caption2,
                                                         MessageBoxButtons.OK,
                                                         MessageBoxIcon.Asterisk);
                            BuscarAgendaParaUsuario(Sesion.UsuarioLogueado.IdUsuario);
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
                }
            }
        }
        private void AgendaWF_Load(object sender, EventArgs e)
        {
            try
            {
                BuscarAgendaParaUsuario(Sesion.UsuarioLogueado.IdUsuario);
            }
            catch (Exception ex)
            { }
        }
        private void BuscarAgendaParaUsuario(int idUsuario)
        {
            dgvAgenda.Rows.Clear();
            List<Entidades.Agenda> ListarClientes = AgendaNeg.ListarRecordatoriosUsuario(idUsuario);
            btnNuevo.Visible = true;
            int contadorFilas = 0;
            if (ListarClientes.Count > 0)
            {
                DiseñoGrilla();
                dgvAgenda.Visible = true;
                btnEditar.Visible = true;
                lbllistado.Visible = true;
                foreach (var item in ListarClientes)
                {
                    string fecha = Convert.ToString(item.Fecha.ToShortDateString());
                    if (item.Fecha < DateTime.Now)
                    {
                        dgvAgenda.Rows.Add(item.idAgenda, fecha, item.Descripcion);
                        dgvAgenda.Rows[contadorFilas].DefaultCellStyle.ForeColor = Color.Red;
                    }
                    else
                    {
                        dgvAgenda.Rows.Add(item.idAgenda, fecha, item.Descripcion);
                        dgvAgenda.Rows[contadorFilas].DefaultCellStyle.ForeColor = Color.Black;
                    }
                    //dgvAgenda.Rows.Add(item.idAgenda, fecha, item.Descripcion);
                    contadorFilas = contadorFilas + 1;
                }
                dgvAgenda.AllowUserToAddRows = false;
            }
            else
            {
                dgvAgenda.Visible = false;
                btnEditar.Visible = false;
                lbllistado.Visible = false;
            }
        }
        private void DiseñoGrilla()
        {
            this.dgvAgenda.DefaultCellStyle.Font = new Font("Tahoma", 9);
            this.dgvAgenda.DefaultCellStyle.ForeColor = Color.Black;
            this.dgvAgenda.DefaultCellStyle.BackColor = Color.White;
            this.dgvAgenda.DefaultCellStyle.SelectionForeColor = Color.SteelBlue;
            this.dgvAgenda.DefaultCellStyle.SelectionBackColor = Color.White;
        }
        public static int idAgendaSeleccionado;
        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (this.dgvAgenda.RowCount > 0)
            {               
                PanelRegistroPlan.Enabled = true;
                Funcion = 2;
                List<Entidades.Agenda> _plan = new List<Entidades.Agenda>();
                idAgendaSeleccionado = Convert.ToInt32(this.dgvAgenda.CurrentRow.Cells[0].Value);
                List<Entidades.Agenda> ListaRecordatorio = AgendaNeg.BuscarRecordatorio(idAgendaSeleccionado);
                if (ListaRecordatorio.Count > 0)
                {
                    foreach (var item in ListaRecordatorio)
                    {
                        if (item.idUsuario > 0)
                        {
                            chcPersonal.Checked = true;
                        }
                        if (item.UsuariosSistema > 0)
                        {
                            chcUsuarios.Checked = true;
                        }
                        if (item.Email > 0)
                        {
                            chcEmail.Checked = true;
                        }
                    }
                }
                dtFecha.Value = Convert.ToDateTime(dgvAgenda.CurrentRow.Cells[1].Value.ToString());
                txtDescripcion.Text = dgvAgenda.CurrentRow.Cells[2].Value.ToString();                           
            }
            else
            {
                const string message2 = "Debe seleccionar un recordatorio de la grilla.";
                const string caption2 = "Atención";
                var result2 = MessageBox.Show(message2, caption2,
                                             MessageBoxButtons.OK,
                                             MessageBoxIcon.Asterisk);
            }
        }
    }
}
