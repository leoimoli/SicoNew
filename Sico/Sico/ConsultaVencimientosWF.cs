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
    public partial class ConsultaVencimientosWF : Form
    {
        private string cuit;
        private string razonSocial;
        public ConsultaVencimientosWF(string razonSocial, string cuit)
        {
            InitializeComponent();
            this.razonSocial = razonSocial;
            this.cuit = cuit;
        }
        private void ConsultaVencimientosWF_Load(object sender, EventArgs e)
        {
            lblNombreEdit.Text = razonSocial;
            lblCuitEdit.Text = cuit;
            CargarCombos();
            DateTime FechaHoy = DateTime.Now;
            ListaVencimientos = ClienteNeg.BuscarTodosLosVencimientos(cuit, FechaHoy);
        }
        public List<Entidades.Vencimientos> ListaVencimientos
        {
            set
            {

                if (value.Count > 0)
                {
                    dgvVencimientos.Visible = true;
                    dgvVencimientos.ReadOnly = true;
                    dgvVencimientos.RowHeadersVisible = false;
                    dgvVencimientos.DataSource = value;

                    dgvVencimientos.Columns[0].HeaderText = "Id Vencimiento";
                    dgvVencimientos.Columns[0].Width = 130;
                    dgvVencimientos.Columns[0].HeaderCell.Style.BackColor = Color.DarkBlue;
                    dgvVencimientos.Columns[0].HeaderCell.Style.Font = new System.Drawing.Font("Tahoma", 10, FontStyle.Bold);
                    dgvVencimientos.Columns[0].HeaderCell.Style.ForeColor = Color.White;
                    dgvVencimientos.Columns[0].Visible = false;

                    dgvVencimientos.Columns[1].HeaderText = "Año";
                    dgvVencimientos.Columns[1].Width = 200;
                    dgvVencimientos.Columns[1].HeaderCell.Style.BackColor = Color.DarkBlue;
                    dgvVencimientos.Columns[1].HeaderCell.Style.Font = new System.Drawing.Font("Tahoma", 10, FontStyle.Bold);
                    dgvVencimientos.Columns[1].HeaderCell.Style.ForeColor = Color.White;
                    dgvVencimientos.Columns[1].Visible = false;

                    dgvVencimientos.Columns[2].HeaderText = "id Tipo Vencimiento";
                    dgvVencimientos.Columns[2].Width = 100;
                    dgvVencimientos.Columns[2].HeaderCell.Style.BackColor = Color.DarkBlue;
                    dgvVencimientos.Columns[2].HeaderCell.Style.Font = new System.Drawing.Font("Tahoma", 10, FontStyle.Bold);
                    dgvVencimientos.Columns[2].HeaderCell.Style.ForeColor = Color.White;
                    dgvVencimientos.Columns[2].Visible = false;

                    dgvVencimientos.Columns[3].HeaderText = "Día De Vencimiento";
                    dgvVencimientos.Columns[3].Width = 160;
                    dgvVencimientos.Columns[3].HeaderCell.Style.BackColor = Color.DarkBlue;
                    dgvVencimientos.Columns[3].HeaderCell.Style.Font = new System.Drawing.Font("Tahoma", 10, FontStyle.Bold);
                    dgvVencimientos.Columns[3].HeaderCell.Style.ForeColor = Color.White;
                    dgvVencimientos.Columns[3].Visible = false;


                    dgvVencimientos.Columns[4].HeaderText = "Cliente";
                    dgvVencimientos.Columns[4].Width = 180;
                    dgvVencimientos.Columns[4].HeaderCell.Style.BackColor = Color.DarkBlue;
                    dgvVencimientos.Columns[4].HeaderCell.Style.Font = new System.Drawing.Font("Tahoma", 10, FontStyle.Bold);
                    dgvVencimientos.Columns[4].HeaderCell.Style.ForeColor = Color.White;


                    dgvVencimientos.Columns[5].HeaderText = "Tipo De Vencimiento";
                    dgvVencimientos.Columns[5].Width = 180;
                    dgvVencimientos.Columns[5].HeaderCell.Style.BackColor = Color.DarkBlue;
                    dgvVencimientos.Columns[5].HeaderCell.Style.Font = new System.Drawing.Font("Tahoma", 10, FontStyle.Bold);
                    dgvVencimientos.Columns[5].HeaderCell.Style.ForeColor = Color.White;


                    dgvVencimientos.Columns[6].HeaderText = "Fecha";
                    dgvVencimientos.Columns[6].Width = 150;
                    dgvVencimientos.Columns[6].HeaderCell.Style.BackColor = Color.DarkBlue;
                    dgvVencimientos.Columns[6].HeaderCell.Style.Font = new System.Drawing.Font("Tahoma", 10, FontStyle.Bold);
                    dgvVencimientos.Columns[6].HeaderCell.Style.ForeColor = Color.White;

                    dgvVencimientos.Columns[7].HeaderText = "Fecha Vencimiento";
                    dgvVencimientos.Columns[7].Width = 150;
                    dgvVencimientos.Columns[7].HeaderCell.Style.BackColor = Color.DarkBlue;
                    dgvVencimientos.Columns[7].HeaderCell.Style.Font = new System.Drawing.Font("Tahoma", 10, FontStyle.Bold);
                    dgvVencimientos.Columns[7].HeaderCell.Style.ForeColor = Color.White;
                }
            }
        }
        private void CargarCombos()
        {
            List<string> TipoVencimientos = new List<string>();
            TipoVencimientos = ClienteNeg.CargarComboTipoVencimientos();
            cmbTipoVencimiento.Items.Clear();
            cmbTipoVencimiento.Text = "Seleccione";
            cmbTipoVencimiento.Items.Add("Seleccione");
            foreach (string item in TipoVencimientos)
            {
                cmbTipoVencimiento.Text = "Seleccione";
                cmbTipoVencimiento.Items.Add(item);
            }
        }
        private void btnVolver_Click(object sender, EventArgs e)
        {
            MenuClienteWF _menu = new MenuClienteWF(razonSocial, cuit);
            _menu.Show();
            Hide();
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            CargarCombos();
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                string Filtro = cmbTipoVencimiento.Text;
                if (Filtro != "Seleccione")
                {
                    var split1 = Filtro.Split('-')[0];
                    split1 = split1.Trim();
                    int idTipoDeVencimiento = Convert.ToInt32(split1);
                    //ListaVencimientos = ClienteNeg.BuscarTodosLosVencimientosIdVencimiento(cuit, idTipoDeVencimiento);
                    var split2 = Filtro.Split('-')[1];
                    split2 = split2.Trim();
                    lblProximosVencimientos.Text = "Próximos Vencimientos del impuesto '" + split2 + "'";
                }
            }
            catch (Exception ex)
            { }
        }
    }
}
