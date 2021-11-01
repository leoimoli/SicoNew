using Sico.Dao;
using Sico.Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace Sico
{
    public partial class InicioNuevoWF : Form
    {
        public InicioNuevoWF()
        {
            InitializeComponent();
        }

        private void InicioNuevoWF_Load(object sender, EventArgs e)
        {
            ///// Dia y Hora
            CheckForIllegalCrossThreadCalls = false;
            System.Timers.Timer t = new System.Timers.Timer(1000);
            t.Elapsed += new System.Timers.ElapsedEventHandler(this.timer1_Tick);
            t.Start();
            String DiaDeLaSemana = DateTime.Now.DayOfWeek.ToString();
            string Dia = ValidarDia(DiaDeLaSemana);
            String FechaDia = DateTime.Now.Day.ToString();
            String Month = DateTime.Now.Month.ToString();
            string Mes = ValidarMes(Month);
            String Year = DateTime.Now.Year.ToString();
            int month = Convert.ToInt32(Month);
            int year = Convert.ToInt32(Year);
            lblDia.Text = Dia + "," + " " + FechaDia + " " + "de" + " " + Mes + " " + Year;

            BuscarAgendaParaUsuario(Sesion.UsuarioLogueado.IdUsuario);

            ////// Obtener Informacion clima
            ObtenerInformacion();

            ///// Armo Panel de Informacion
            int Clientes = DaoConsultasGenerales.ContadorClientes();
            int Tareas = DaoConsultasGenerales.ContadorTareas();
            int Pendientes = DaoConsultasGenerales.ContadorPendientes();
            int Usuarios = DaoConsultasGenerales.ContadorUsuarios();
            if (Clientes > 9999)
            {
                lblContadorClientes.Text = "+ 10.000";
            }
            if (Clientes > 99999)
            {
                lblContadorClientes.Text = "+ 100.000";
            }
            if (Clientes > 999999)
            {
                lblContadorClientes.Text = "+ 1.000.000";
            }
            else
            {
                lblContadorClientes.Text = Convert.ToString(Clientes);
            }
            if (Tareas > 9999)
            {
                lblContadorProdcutos.Text = "+ 10.000";
            }
            if (Tareas > 99999)
            {
                lblContadorProdcutos.Text = "+ 100.000";
            }
            if (Tareas > 999999)
            {
                lblContadorProdcutos.Text = "+ 1.000.000";
            }
            else
            {
                lblContadorProdcutos.Text = Convert.ToString(Tareas);
            }
            if (Pendientes > 9999)
            {
                lblContadorPendientes.Text = "+ 10.000";
            }
            if (Pendientes > 99999)
            {
                lblContadorPendientes.Text = "+ 100.000";
            }
            if (Pendientes > 999999)
            {
                lblContadorPendientes.Text = "+ 1.000.000";
            }
            else
            {
                lblContadorPendientes.Text = Convert.ToString(Pendientes);
            }
            if (Usuarios > 9999)
            {
                lblContadorUsuarios.Text = "+ 10.000";
            }
            if (Usuarios > 99999)
            {
                lblContadorUsuarios.Text = "+ 100.000";
            }
            if (Usuarios > 999999)
            {
                lblContadorUsuarios.Text = "+ 1.000.000";
            }
            else
            {
                lblContadorUsuarios.Text = Convert.ToString(Usuarios);
            }
        }
        private void BuscarAgendaParaUsuario(int idUsuario)
        {
            dgvAgenda.Rows.Clear();
            List<Entidades.Agenda> ListarClientes = AgendaNeg.ListarRecordatoriosUsuario(idUsuario);
            if (ListarClientes.Count > 0)
            {
                lblAgenda.Visible = true;
                lblAgenda.Text = "Agenda de pendientes";
                DiseñoGrilla();
                dgvAgenda.Visible = true;
                foreach (var item in ListarClientes)
                {
                    string fecha = Convert.ToString(item.Fecha.ToShortDateString());
                    dgvAgenda.Rows.Add(item.idAgenda, fecha, item.Descripcion);
                }
                dgvAgenda.AllowUserToAddRows = false;
            }
            else
            {
                lblAgenda.Visible = true;
                lblAgenda.Text = "Usted no tiene pendientes en su agenda";
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
        private void ObtenerInformacion()
        {
            CalcularDolar();
            BuscarClima();
        }
        private void BuscarClima()
        {
            pictureBox1.Load($"https://www.meteored.com.ar/wimages/fotoa39e1a900a69ff1c11dc7566b24cdd04.png");
        }
        private void CalcularDolar()
        {
            // webBrowser2.Navigate($"https://www.dolarsi.com/cotizador/cotizadorDolarsiSmall.php");
        }

        private string ValidarDia(string diaDeLaSemana)
        {
            string Dia = "";
            if (diaDeLaSemana == "Monday")
            {
                Dia = "Lunes";
            }
            if (diaDeLaSemana == "Tuesday")
            {
                Dia = "Martes";
            }
            if (diaDeLaSemana == "Wednesday")
            {
                Dia = "Miercoles";
            }
            if (diaDeLaSemana == "Thursday")
            {
                Dia = "Jueves";
            }
            if (diaDeLaSemana == "Friday")
            {
                Dia = "Viernes";
            }
            if (diaDeLaSemana == "Saturday")
            {
                Dia = "Sábado";
            }
            if (diaDeLaSemana == "Sunday")
            {
                Dia = "Domingo";
            }
            return Dia;
        }
        private string ValidarMes(string Month)
        {
            string Mes = "";
            if (Month == "1")
            {
                Mes = "Enero";
            }
            if (Month == "2")
            {
                Mes = "Febrero";
            }
            if (Month == "3")
            {
                Mes = "Marzo";
            }
            if (Month == "4")
            {
                Mes = "Abril";
            }
            if (Month == "5")
            {
                Mes = "Mayo";
            }
            if (Month == "6")
            {
                Mes = "Junio";
            }
            if (Month == "7")
            {
                Mes = "Julio";
            }
            if (Month == "8")
            {
                Mes = "Agosto";
            }
            if (Month == "9")
            {
                Mes = "Septiembre";
            }
            if (Month == "10")
            {
                Mes = "Octubre";
            }
            if (Month == "11")
            {
                Mes = "Noviembre";
            }
            if (Month == "12")
            {
                Mes = "Diciembre";
            }
            return Mes;
        }
        private void timer1_Tick(object sender, ElapsedEventArgs el)
        {
            CheckForIllegalCrossThreadCalls = false;
            lblMaster_FechaHoraReal.Text = Convert.ToString(DateTime.Now.ToString("HH:mm:ss"));
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
        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
    }
}
