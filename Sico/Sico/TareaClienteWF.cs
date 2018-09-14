using Sico.Entidades;
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
    public partial class TareaClienteWF : MasterWF
    {
        private string cuit;
        private string razonSocial;

        public TareaClienteWF(string razonSocial, string cuit)
        {
            InitializeComponent();
            this.razonSocial = razonSocial;
            this.cuit = cuit;
        }

        private void TareaClienteWF_Load(object sender, EventArgs e)
        {
            lblNombreEdit.Text = razonSocial;
            lblCuitEdit.Text = cuit;
        }
        #region Botones
        private void btnFacturar_Click(object sender, EventArgs e)
        {
            try
            {
                ListaFacturas = ClienteNeg.BuscarTodasFacturasSubCliente(cuit);
                txtBuscar.AutoCompleteCustomSource = Clases_Maestras.AutoCompleteSubCliente.Autocomplete();
                txtBuscar.AutoCompleteMode = AutoCompleteMode.Suggest;
                txtBuscar.AutoCompleteSource = AutoCompleteSource.CustomSource;
            }
            catch (Exception ex) { }
        }
        #endregion
        #region Funciones
        public List<Entidades.SubCliente> ListaFacturas
        {
            set
            {
                if (value.Count > 0)
                {
                    lblCantidad.Visible = true;
                    lblCantidadEdit.Visible = true;
                    lblCantidadEdit.Text = Convert.ToString(value.Count);
                    btnBuscar.Visible = true;
                    label2.Visible = true;
                    label4.Visible = true;
                    txtBuscar.Visible = true;
                    txtBuscar.Enabled = true;
                    txtBuscar.Focus();
                    dgvSubClientes.Visible = true;
                    dgvSubClientes.ReadOnly = true;
                    dgvSubClientes.RowHeadersVisible = false;
                    dgvSubClientes.DataSource = value;

                    dgvSubClientes.Columns[0].HeaderText = "Id Movimiento";
                    dgvSubClientes.Columns[0].Width = 130;
                    dgvSubClientes.Columns[0].HeaderCell.Style.BackColor = Color.DarkBlue;
                    dgvSubClientes.Columns[0].HeaderCell.Style.Font = new System.Drawing.Font("Tahoma", 10, FontStyle.Bold);
                    dgvSubClientes.Columns[0].HeaderCell.Style.ForeColor = Color.White;
                    ////dataGridView1.Columns[0].Visible = true;

                    dgvSubClientes.Columns[1].HeaderText = "Nro.Factura";
                    dgvSubClientes.Columns[1].Width = 200;
                    dgvSubClientes.Columns[1].HeaderCell.Style.BackColor = Color.DarkBlue;
                    dgvSubClientes.Columns[1].HeaderCell.Style.Font = new System.Drawing.Font("Tahoma", 10, FontStyle.Bold);
                    dgvSubClientes.Columns[1].HeaderCell.Style.ForeColor = Color.White;

                    dgvSubClientes.Columns[2].HeaderText = "Fecha";
                    dgvSubClientes.Columns[2].Width = 100;
                    dgvSubClientes.Columns[2].HeaderCell.Style.BackColor = Color.DarkBlue;
                    dgvSubClientes.Columns[2].HeaderCell.Style.Font = new System.Drawing.Font("Tahoma", 10, FontStyle.Bold);
                    dgvSubClientes.Columns[2].HeaderCell.Style.ForeColor = Color.White;

                    dgvSubClientes.Columns[3].HeaderText = "Persona";
                    dgvSubClientes.Columns[3].Width = 250;
                    dgvSubClientes.Columns[3].HeaderCell.Style.BackColor = Color.DarkBlue;
                    dgvSubClientes.Columns[3].HeaderCell.Style.Font = new System.Drawing.Font("Tahoma", 10, FontStyle.Bold);
                    dgvSubClientes.Columns[3].HeaderCell.Style.ForeColor = Color.White;

                    dgvSubClientes.Columns[4].HeaderText = "Dni";
                    dgvSubClientes.Columns[4].Width = 100;
                    dgvSubClientes.Columns[4].HeaderCell.Style.BackColor = Color.DarkBlue;
                    dgvSubClientes.Columns[4].HeaderCell.Style.Font = new System.Drawing.Font("Tahoma", 10, FontStyle.Bold);
                    dgvSubClientes.Columns[4].HeaderCell.Style.ForeColor = Color.White;

                    dgvSubClientes.Columns[5].HeaderText = "Dirección";
                    dgvSubClientes.Columns[5].Width = 250;
                    dgvSubClientes.Columns[5].HeaderCell.Style.BackColor = Color.DarkBlue;
                    dgvSubClientes.Columns[5].HeaderCell.Style.Font = new System.Drawing.Font("Tahoma", 10, FontStyle.Bold);
                    dgvSubClientes.Columns[5].HeaderCell.Style.ForeColor = Color.White;
                    dgvSubClientes.Columns[5].Visible = false;

                    dgvSubClientes.Columns[6].HeaderText = "Monto";
                    dgvSubClientes.Columns[6].Width = 250;
                    dgvSubClientes.Columns[6].HeaderCell.Style.BackColor = Color.DarkBlue;
                    dgvSubClientes.Columns[6].HeaderCell.Style.Font = new System.Drawing.Font("Tahoma", 10, FontStyle.Bold);
                    dgvSubClientes.Columns[6].HeaderCell.Style.ForeColor = Color.White;
                    dgvSubClientes.Columns[6].Visible = false;

                    dgvSubClientes.Columns[7].HeaderText = "Cliente";
                    dgvSubClientes.Columns[7].Width = 95;
                    dgvSubClientes.Columns[7].HeaderCell.Style.BackColor = Color.DarkBlue;
                    dgvSubClientes.Columns[7].HeaderCell.Style.Font = new System.Drawing.Font("Tahoma", 10, FontStyle.Bold);
                    dgvSubClientes.Columns[7].HeaderCell.Style.ForeColor = Color.White;
                    dgvSubClientes.Columns[7].Visible = false;
                }
            }
        }
        #endregion

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                List<SubCliente> _cliente = new List<SubCliente>();
                var ApellidoNombre = txtBuscar.Text;
                ListaFacturas = ClienteNeg.BuscarSubClientePorApellidoNombre(ApellidoNombre, cuit);
            }
            catch (Exception ex)
            {

            }
        }

        private void btnNuevaFactura_Click(object sender, EventArgs e)
        {
            FacturacionSubClientesWF _facturacion = new FacturacionSubClientesWF(razonSocial, cuit);
            _facturacion.Show();
        }
    }
}
