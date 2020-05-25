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
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.ReadOnly = true;
            dataGridView1.RowsDefaultCellStyle.BackColor = Color.MediumSpringGreen;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.DodgerBlue;
            dataGridView1.DataSource = _listaVencimientos;

            dataGridView1.Columns[0].HeaderText = "Tipo de Vencimiento";
            dataGridView1.Columns[0].Width = 200;
            dataGridView1.Columns[0].HeaderCell.Style.BackColor = Color.DarkBlue;
            dataGridView1.Columns[0].HeaderCell.Style.Font = new System.Drawing.Font("Tahoma", 10, FontStyle.Bold);
            dataGridView1.Columns[0].HeaderCell.Style.ForeColor = Color.White;
            dataGridView1.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.TopCenter;
            dataGridView1.Columns[0].DefaultCellStyle.Font = new Font("Tahoma", 15);
            dataGridView1.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopCenter;

            dataGridView1.Columns[1].HeaderText = "Fecha";
            dataGridView1.Columns[1].Width = 200;
            dataGridView1.Columns[1].HeaderCell.Style.BackColor = Color.DarkBlue;
            dataGridView1.Columns[1].HeaderCell.Style.Font = new System.Drawing.Font("Tahoma", 10, FontStyle.Bold);
            dataGridView1.Columns[1].HeaderCell.Style.ForeColor = Color.White;
            dataGridView1.Columns[1].DefaultCellStyle.Font = new Font("Tahoma", 20);
            dataGridView1.Columns[1].Visible = false;

            dataGridView1.Columns[2].HeaderText = "Día";
            dataGridView1.Columns[2].Width = 200;
            dataGridView1.Columns[2].HeaderCell.Style.BackColor = Color.DarkBlue;
            dataGridView1.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.TopCenter;
            dataGridView1.Columns[2].HeaderCell.Style.Font = new System.Drawing.Font("Tahoma", 10, FontStyle.Bold);
            dataGridView1.Columns[2].HeaderCell.Style.ForeColor = Color.White;
            dataGridView1.Columns[2].DefaultCellStyle.Font = new Font("Tahoma", 25);
            dataGridView1.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopCenter;

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
    }
}
