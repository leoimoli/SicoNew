using Sico.Entidades;
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
    public partial class CalendarioWF : Form
    {
        public CalendarioWF()
        {
            InitializeComponent();
        }
        private void CalendarioWF_Load(object sender, EventArgs e)
        {
            FechaActual = DateTime.Now;
            String DiaDeLaSemana = DateTime.Now.DayOfWeek.ToString();
            String FechaDia = DateTime.Now.Day.ToString();
            String Month = DateTime.Now.Month.ToString();
            string Mes = ValidarMes(Month);
            String Year = DateTime.Now.Year.ToString();
            label1.Text = Mes + " " + Year;
            List<VencimientosPorMesAnio> _listaVencimientos = new List<VencimientosPorMesAnio>();
            _listaVencimientos = Dao.ClienteDao.BuscarVencimientosPorMesAño(Month, Year);
            DiseñoDataGridView(dataGridView1, _listaVencimientos);
        }
        public void DiseñoDataGridView(DataGridView dgv, List<VencimientosPorMesAnio> _listaVencimientos)
        {
            
            dataGridView1.Columns.Clear();
            dataGridView1.Refresh();
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.ReadOnly = true;
            dataGridView1.RowsDefaultCellStyle.BackColor = Color.MediumSpringGreen;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.DodgerBlue;
            dataGridView1.DataSource = _listaVencimientos;

            dataGridView1.Columns[0].HeaderText = "Tipo de Vencimiento";
            dataGridView1.Columns[0].Width = 180;
            dataGridView1.Columns[0].HeaderCell.Style.BackColor = Color.DarkBlue;
            dataGridView1.Columns[0].HeaderCell.Style.Font = new System.Drawing.Font("Tahoma", 10, FontStyle.Bold);
            dataGridView1.Columns[0].HeaderCell.Style.ForeColor = Color.White;
            dataGridView1.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[0].DefaultCellStyle.Font = new Font("Tahoma", 12);
            dataGridView1.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dataGridView1.Columns[1].HeaderText = "Fecha";
            dataGridView1.Columns[1].Width = 200;
            dataGridView1.Columns[1].HeaderCell.Style.BackColor = Color.DarkBlue;
            dataGridView1.Columns[1].HeaderCell.Style.Font = new System.Drawing.Font("Tahoma", 10, FontStyle.Bold);
            dataGridView1.Columns[1].HeaderCell.Style.ForeColor = Color.White;
            dataGridView1.Columns[1].DefaultCellStyle.Font = new Font("Tahoma", 20);
            dataGridView1.Columns[1].Visible = false;

            dataGridView1.Columns[2].HeaderText = "Día";
            dataGridView1.Columns[2].Width = 150;
            dataGridView1.Columns[2].HeaderCell.Style.BackColor = Color.DarkBlue;
            dataGridView1.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[2].HeaderCell.Style.Font = new System.Drawing.Font("Tahoma", 10, FontStyle.Bold);
            dataGridView1.Columns[2].HeaderCell.Style.ForeColor = Color.White;
            dataGridView1.Columns[2].DefaultCellStyle.Font = new Font("Tahoma", 25);
            dataGridView1.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dataGridView1.Columns[3].HeaderText = "id Vencimiento";
            dataGridView1.Columns[3].Width = 150;
            dataGridView1.Columns[3].HeaderCell.Style.BackColor = Color.DarkBlue;
            dataGridView1.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[3].HeaderCell.Style.Font = new System.Drawing.Font("Tahoma", 10, FontStyle.Bold);
            dataGridView1.Columns[3].HeaderCell.Style.ForeColor = Color.White;
            dataGridView1.Columns[3].DefaultCellStyle.Font = new Font("Tahoma", 25);
            dataGridView1.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[3].Visible = false;

            DataGridViewButtonColumn BotonVer = new DataGridViewButtonColumn();
            BotonVer.Name = "Ver";
            BotonVer.HeaderText = "Ver";
            this.dataGridView1.Columns.Add(BotonVer);
            dataGridView1.Columns[4].Width = 80;
            dataGridView1.Columns[4].HeaderCell.Style.BackColor = Color.DarkBlue;
            dataGridView1.Columns[4].HeaderCell.Style.Font = new Font("Tahoma", 10, FontStyle.Bold);
            dataGridView1.Columns[4].HeaderCell.Style.ForeColor = Color.White;
            dataGridView1.CurrentCell = null;


        }
        private void dataGridView1_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex >= 0 && this.dataGridView1.Columns[e.ColumnIndex].Name == "Ver" && e.RowIndex >= 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                DataGridViewButtonCell BotonVer = this.dataGridView1.Rows[e.RowIndex].Cells["Ver"] as DataGridViewButtonCell;
                Icon icoAtomico = new Icon(Environment.CurrentDirectory + "\\" + @"lupa.ico");
                e.Graphics.DrawIcon(icoAtomico, e.CellBounds.Left + 5, e.CellBounds.Top + 5);

                this.dataGridView1.Rows[e.RowIndex].Height = icoAtomico.Height + 6;
                this.dataGridView1.Columns[e.ColumnIndex].Width = icoAtomico.Width + 6;

                e.Handled = true;
            }
        }
        private void ClickBoton(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentCell.ColumnIndex == 4)
            {
                var idVencimientos = Convert.ToString(this.dataGridView1.CurrentRow.Cells[3].Value);
                List<string> ListaPersonas = new List<string>();
                ListaPersonas = Dao.ClienteDao.BuscarClientesPorIdVencimientos(idVencimientos);
                if (ListaPersonas.Count > 0)
                {
                    label2.Visible = true;
                    label3.Visible = true;
                    label4.Visible = true;
                    label4.Text = Convert.ToString(ListaPersonas.Count);
                    listBox1.Visible = true;
                    listBox1.Items.Clear();
                    foreach (var item in ListaPersonas)
                    {
                        listBox1.Items.Add(item);
                    }
                }
            }
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
        public static DateTime FechaActual;
        public static DateTime FechaSiguiente;
        public static DateTime FechaAnterior;
        private void btnSiguenteMes_Click(object sender, EventArgs e)
        {
            listBox1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            int Valor = 1;
            RecalcularCalendario(Valor);
        }
        private void btnAnteriorMes_Click(object sender, EventArgs e)
        {
            listBox1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            int Valor = 0;
            RecalcularCalendario(Valor);
        }
        private void RecalcularCalendario(int Valor)
        {
            if (Valor == 1)
            {
                FechaActual = FechaActual.AddMonths(1);
                FechaSiguiente = FechaActual;
            }
            if (Valor == 0)
            {
                FechaActual = FechaActual.AddMonths(-1);
                FechaAnterior = FechaActual;
            }
            String Month = FechaActual.Month.ToString();
            string Mes = ValidarMes(Month);
            if (Mes == "Enero")
            {
                btnAnteriorMes.Enabled = false;
            }
            if (Mes != "Enero")
            {
                btnAnteriorMes.Enabled = true;
            }
            if (Mes == "Diciembre")
            {
                btnSiguenteMes.Enabled = false;
            }
            if (Mes != "Diciembre")
            {
                btnSiguenteMes.Enabled = true;
            }
            String Year = DateTime.Now.Year.ToString();
            label1.Text = Mes + " " + Year;
            List<VencimientosPorMesAnio> _listaVencimientos = new List<VencimientosPorMesAnio>();
            _listaVencimientos = Dao.ClienteDao.BuscarVencimientosPorMesAño(Month, Year);
            DiseñoDataGridView(dataGridView1, _listaVencimientos);
        }
        private void btnVolver_Click(object sender, EventArgs e)
        {
            InicioWF _inicio = new InicioWF();
            _inicio.Show();
            Hide();
        }
    }
}
