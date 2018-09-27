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
    public partial class VistaConsultaFacturacionMensualWF : Form
    {
        private string cuit;
        private string razonSocial;
        public VistaConsultaFacturacionMensualWF(string razonSocial, string cuit)
        {
            InitializeComponent();
            this.razonSocial = razonSocial;
            this.cuit = cuit;
        }
        private void VistaConsultaFacturacionMensualWF_Load(object sender, EventArgs e)
        {
            try
            {
                lblCuitEdit.Text = cuit;
                lblNombreEdit.Text = razonSocial;
                CargarCombo();
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
        private void CargarCombo()
        {
            string[] Meses = Clases_Maestras.ValoresConstantes.Meses;
            cmbMes.Items.Add("Seleccione");
            cmbMes.Items.Clear();
            foreach (string item in Meses)
            {
                cmbMes.Text = "Seleccione";
                cmbMes.Items.Add(item);
            }
            string[] Años = Clases_Maestras.ValoresConstantes.Años;
            cmbAño.Items.Add("Seleccione");
            cmbAño.Items.Clear();
            foreach (string item in Años)
            {
                cmbAño.Text = "Seleccione";
                cmbAño.Items.Add(item);
            }
        }
        private int ValidarMesSeleccionado(string mesSeleccionado)
        {
            int mes = 0;
            if (mesSeleccionado == "Enero")
                mes = 01;
            if (mesSeleccionado == "Febrero")
                mes = 02;
            if (mesSeleccionado == "Marzo")
                mes = 03;
            if (mesSeleccionado == "Abril")
                mes = 04;
            if (mesSeleccionado == "Mayo")
                mes = 05;
            if (mesSeleccionado == "Junio")
                mes = 06;
            if (mesSeleccionado == "Julio")
                mes = 07;
            if (mesSeleccionado == "Agosto")
                mes = 08;
            if (mesSeleccionado == "Septiembre")
                mes = 09;
            if (mesSeleccionado == "Octubre")
                mes = 10;
            if (mesSeleccionado == "Noviembre")
                mes = 11;
            if (mesSeleccionado == "Diciembre")
                mes = 12;
            return mes;

        }
        public List<Entidades.SubCliente> ListaTotalFacturacion
        {
            set
            {
                if (value.Count > 0)
                {
                    if (value != dataGridView1.DataSource && dataGridView1.DataSource != null)
                    {
                        dataGridView1.Columns.Clear();
                        dataGridView1.Refresh();
                    }
                    dataGridView1.Visible = true;
                    dataGridView1.ReadOnly = true;
                    dataGridView1.RowHeadersVisible = false;
                    dataGridView1.DataSource = value;

                    dataGridView1.Columns[0].HeaderText = "Id Movimiento";
                    dataGridView1.Columns[0].Width = 130;
                    dataGridView1.Columns[0].HeaderCell.Style.BackColor = Color.DarkBlue;
                    dataGridView1.Columns[0].HeaderCell.Style.Font = new System.Drawing.Font("Tahoma", 8, FontStyle.Bold);
                    dataGridView1.Columns[0].HeaderCell.Style.ForeColor = Color.White;
                    dataGridView1.Columns[0].Visible = false;

                    dataGridView1.Columns[1].HeaderText = "Nro.Factura";
                    dataGridView1.Columns[1].Width = 130;
                    dataGridView1.Columns[1].HeaderCell.Style.BackColor = Color.DarkBlue;
                    dataGridView1.Columns[1].HeaderCell.Style.Font = new System.Drawing.Font("Tahoma", 8, FontStyle.Bold);
                    dataGridView1.Columns[1].HeaderCell.Style.ForeColor = Color.White;

                    dataGridView1.Columns[2].HeaderText = "Fecha";
                    dataGridView1.Columns[2].Width = 80;
                    dataGridView1.Columns[2].HeaderCell.Style.BackColor = Color.DarkBlue;
                    dataGridView1.Columns[2].HeaderCell.Style.Font = new System.Drawing.Font("Tahoma", 8, FontStyle.Bold);
                    dataGridView1.Columns[2].HeaderCell.Style.ForeColor = Color.White;

                    dataGridView1.Columns[3].HeaderText = "Persona";
                    dataGridView1.Columns[3].Width = 200;
                    dataGridView1.Columns[3].HeaderCell.Style.BackColor = Color.DarkBlue;
                    dataGridView1.Columns[3].HeaderCell.Style.Font = new System.Drawing.Font("Tahoma", 8, FontStyle.Bold);
                    dataGridView1.Columns[3].HeaderCell.Style.ForeColor = Color.White;
                    dataGridView1.Columns[3].Visible = false;

                    dataGridView1.Columns[4].HeaderText = "Dni";
                    dataGridView1.Columns[4].Width = 80;
                    dataGridView1.Columns[4].HeaderCell.Style.BackColor = Color.DarkBlue;
                    dataGridView1.Columns[4].HeaderCell.Style.Font = new System.Drawing.Font("Tahoma", 8, FontStyle.Bold);
                    dataGridView1.Columns[4].HeaderCell.Style.ForeColor = Color.White;
                    dataGridView1.Columns[4].Visible = false;

                    dataGridView1.Columns[5].HeaderText = "Dirección";
                    dataGridView1.Columns[5].Width = 250;
                    dataGridView1.Columns[5].HeaderCell.Style.BackColor = Color.DarkBlue;
                    dataGridView1.Columns[5].HeaderCell.Style.Font = new System.Drawing.Font("Tahoma", 8, FontStyle.Bold);
                    dataGridView1.Columns[5].HeaderCell.Style.ForeColor = Color.White;
                    dataGridView1.Columns[5].Visible = false;

                    dataGridView1.Columns[6].HeaderText = "Monto";
                    dataGridView1.Columns[6].Width = 100;
                    dataGridView1.Columns[6].HeaderCell.Style.BackColor = Color.DarkBlue;
                    dataGridView1.Columns[6].HeaderCell.Style.Font = new System.Drawing.Font("Tahoma", 10, FontStyle.Bold);
                    dataGridView1.Columns[6].HeaderCell.Style.ForeColor = Color.White;
                    dataGridView1.Columns[6].Visible = true;

                    dataGridView1.Columns[7].HeaderText = "Cliente";
                    dataGridView1.Columns[7].Width = 95;
                    dataGridView1.Columns[7].HeaderCell.Style.BackColor = Color.DarkBlue;
                    dataGridView1.Columns[7].HeaderCell.Style.Font = new System.Drawing.Font("Tahoma", 8, FontStyle.Bold);
                    dataGridView1.Columns[7].HeaderCell.Style.ForeColor = Color.White;
                    dataGridView1.Columns[7].Visible = false;

                    dataGridView1.Columns[8].HeaderText = "Importe 1";
                    dataGridView1.Columns[8].Visible = false;

                    dataGridView1.Columns[9].HeaderText = "Importe 2";
                    dataGridView1.Columns[9].Visible = false;

                    dataGridView1.Columns[10].HeaderText = "Importe 3";
                    dataGridView1.Columns[10].Visible = false;

                    dataGridView1.Columns[11].HeaderText = "Neto al 10,5";
                    dataGridView1.Columns[11].Visible = true;
                    dataGridView1.Columns[11].Width = 80;
                    dataGridView1.Columns[11].HeaderCell.Style.BackColor = Color.DarkBlue;
                    dataGridView1.Columns[11].HeaderCell.Style.Font = new System.Drawing.Font("Tahoma", 8, FontStyle.Bold);

                    dataGridView1.Columns[12].HeaderText = "Neto al 21";
                    dataGridView1.Columns[12].Visible = true;
                    dataGridView1.Columns[12].Width = 80;
                    dataGridView1.Columns[12].HeaderCell.Style.BackColor = Color.DarkBlue;
                    dataGridView1.Columns[12].HeaderCell.Style.Font = new System.Drawing.Font("Tahoma", 8, FontStyle.Bold);

                    dataGridView1.Columns[13].HeaderText = "Neto al 27";
                    dataGridView1.Columns[13].Visible = true;
                    dataGridView1.Columns[13].Width = 80;
                    dataGridView1.Columns[13].HeaderCell.Style.BackColor = Color.DarkBlue;
                    dataGridView1.Columns[13].HeaderCell.Style.Font = new System.Drawing.Font("Tahoma", 8, FontStyle.Bold);

                    dataGridView1.Columns[14].HeaderText = "alicuota 1";
                    dataGridView1.Columns[14].Visible = false;

                    dataGridView1.Columns[15].HeaderText = "alicuota 2";
                    dataGridView1.Columns[15].Visible = false;

                    dataGridView1.Columns[16].HeaderText = "alicuota 3";
                    dataGridView1.Columns[16].Visible = false;

                    dataGridView1.Columns[17].HeaderText = "Iva al 10,5";
                    dataGridView1.Columns[17].Visible = true;
                    dataGridView1.Columns[17].Width = 80;
                    dataGridView1.Columns[17].HeaderCell.Style.BackColor = Color.DarkBlue;
                    dataGridView1.Columns[17].HeaderCell.Style.Font = new System.Drawing.Font("Tahoma", 8, FontStyle.Bold);

                    dataGridView1.Columns[18].HeaderText = "Iva al 21";
                    dataGridView1.Columns[18].Visible = true;
                    dataGridView1.Columns[18].Width = 80;
                    dataGridView1.Columns[18].HeaderCell.Style.BackColor = Color.DarkBlue;
                    dataGridView1.Columns[18].HeaderCell.Style.Font = new System.Drawing.Font("Tahoma", 8, FontStyle.Bold);

                    dataGridView1.Columns[19].HeaderText = "Iva al 27";
                    dataGridView1.Columns[19].Visible = true;
                    dataGridView1.Columns[19].Width = 80;
                    dataGridView1.Columns[19].HeaderCell.Style.BackColor = Color.DarkBlue;
                    dataGridView1.Columns[19].HeaderCell.Style.Font = new System.Drawing.Font("Tahoma", 8, FontStyle.Bold);
                }
            }
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                string año = cmbAño.Text;
                string MesSeleccionado = cmbMes.Text;
                int mes = ValidarMesSeleccionado(MesSeleccionado);
                ListaTotalFacturacion = ClienteNeg.BuscarFacturacionTotal(cuit, mes, año);
                //if (ListaTotalFacturacion.ToString() == "")
                //{ MessageBox.Show("No se encontro facturación cargada con el mes y año seleccionado."); }

            }
            catch (Exception ex)
            { }
        }
    }
}
