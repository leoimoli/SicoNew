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
    public partial class ComprasWF : MasterWF
    {
        private string cuit;
        private string razonSocial;
        private bool EsEditar;
        public ComprasWF(string razonSocial, string cuit)
        {
            InitializeComponent();
            this.razonSocial = razonSocial;
            this.cuit = cuit;
        }
        private void ComprasWF_Load(object sender, EventArgs e)
        {
            lblNombreEdit.Text = razonSocial;
            lblCuitEdit.Text = cuit;
            try
            {
                ListaFacturas = ComprasNeg.BuscarTodasFacturasDeComprasDelCliente(cuit);
                txtBuscar.AutoCompleteCustomSource = Clases_Maestras.AutoCompleteSubCliente.Autocomplete();
                txtBuscar.AutoCompleteMode = AutoCompleteMode.Suggest;
                txtBuscar.AutoCompleteSource = AutoCompleteSource.CustomSource;
            }
            catch (Exception ex) { }
        }
        public static List<FacturaCompra> Lista;
        public List<FacturaCompra> ListaFacturas
        {
            set
            {
                if (value.Count > 0)
                {
                    Lista = value;
                    if (value != dgvCompras.DataSource && dgvCompras.DataSource != null)
                    {
                        dgvCompras.Columns.Clear();
                        dgvCompras.Refresh();
                    }
                    btnBuscar.Visible = true;
                    btnConsultarTotales.Visible = true;
                    label2.Visible = true;
                    lblSeleccionar.Visible = true;
                    txtBuscar.Visible = true;
                    txtBuscar.Enabled = true;
                    txtBuscar.Focus();
                    dgvCompras.Visible = true;
                    dgvCompras.ReadOnly = true;
                    dgvCompras.RowHeadersVisible = false;
                    dgvCompras.DataSource = value;

                    dgvCompras.Columns[0].HeaderText = "Id Factura";
                    dgvCompras.Columns[0].Width = 130;
                    dgvCompras.Columns[0].HeaderCell.Style.BackColor = Color.DarkBlue;
                    dgvCompras.Columns[0].HeaderCell.Style.Font = new System.Drawing.Font("Tahoma", 10, FontStyle.Bold);
                    dgvCompras.Columns[0].HeaderCell.Style.ForeColor = Color.White;
                  
                    dgvCompras.Columns[1].HeaderText = "Nro.Factura";
                    dgvCompras.Columns[1].Width = 200;
                    dgvCompras.Columns[1].HeaderCell.Style.BackColor = Color.DarkBlue;
                    dgvCompras.Columns[1].HeaderCell.Style.Font = new System.Drawing.Font("Tahoma", 10, FontStyle.Bold);
                    dgvCompras.Columns[1].HeaderCell.Style.ForeColor = Color.White;

                    dgvCompras.Columns[2].HeaderText = "Fecha";
                    dgvCompras.Columns[2].Width = 100;
                    dgvCompras.Columns[2].HeaderCell.Style.BackColor = Color.DarkBlue;
                    dgvCompras.Columns[2].HeaderCell.Style.Font = new System.Drawing.Font("Tahoma", 10, FontStyle.Bold);
                    dgvCompras.Columns[2].HeaderCell.Style.ForeColor = Color.White;

                    dgvCompras.Columns[3].HeaderText = "Monto";
                    dgvCompras.Columns[3].Width = 160;
                    dgvCompras.Columns[3].HeaderCell.Style.BackColor = Color.DarkBlue;
                    dgvCompras.Columns[3].HeaderCell.Style.Font = new System.Drawing.Font("Tahoma", 10, FontStyle.Bold);
                    dgvCompras.Columns[3].HeaderCell.Style.ForeColor = Color.White;

                    dgvCompras.Columns[4].HeaderText = "Proveedor";
                    dgvCompras.Columns[4].Width = 80;
                    dgvCompras.Columns[4].HeaderCell.Style.BackColor = Color.DarkBlue;
                    dgvCompras.Columns[4].HeaderCell.Style.Font = new System.Drawing.Font("Tahoma", 10, FontStyle.Bold);
                    dgvCompras.Columns[4].HeaderCell.Style.ForeColor = Color.White;


                    dgvCompras.Columns[5].HeaderText = "Dirección";
                    dgvCompras.Columns[5].Width = 250;
                    dgvCompras.Columns[5].HeaderCell.Style.BackColor = Color.DarkBlue;
                    dgvCompras.Columns[5].HeaderCell.Style.Font = new System.Drawing.Font("Tahoma", 10, FontStyle.Bold);
                    dgvCompras.Columns[5].HeaderCell.Style.ForeColor = Color.White;
                    dgvCompras.Columns[5].Visible = false;

                    dgvCompras.Columns[6].HeaderText = "Monto";
                    dgvCompras.Columns[6].Width = 100;
                    dgvCompras.Columns[6].HeaderCell.Style.BackColor = Color.DarkBlue;
                    dgvCompras.Columns[6].HeaderCell.Style.Font = new System.Drawing.Font("Tahoma", 10, FontStyle.Bold);
                    dgvCompras.Columns[6].HeaderCell.Style.ForeColor = Color.White;
                    dgvCompras.Columns[6].Visible = false;

                    dgvCompras.Columns[7].HeaderText = "Cliente";
                    dgvCompras.Columns[7].Width = 95;
                    dgvCompras.Columns[7].HeaderCell.Style.BackColor = Color.DarkBlue;
                    dgvCompras.Columns[7].HeaderCell.Style.Font = new System.Drawing.Font("Tahoma", 10, FontStyle.Bold);
                    dgvCompras.Columns[7].HeaderCell.Style.ForeColor = Color.White;
                    dgvCompras.Columns[7].Visible = false;

                    dgvCompras.Columns[8].HeaderText = "Cliente";
                    dgvCompras.Columns[8].Visible = false;

                    dgvCompras.Columns[9].HeaderText = "Cliente";
                    dgvCompras.Columns[9].Visible = false;

                    dgvCompras.Columns[10].HeaderText = "Cliente";
                    dgvCompras.Columns[10].Visible = false;

                    dgvCompras.Columns[11].HeaderText = "Cliente";
                    dgvCompras.Columns[11].Visible = false;

                    dgvCompras.Columns[12].HeaderText = "Cliente";
                    dgvCompras.Columns[12].Visible = false;

                    dgvCompras.Columns[13].HeaderText = "Cliente";
                    dgvCompras.Columns[13].Visible = false;

                    dgvCompras.Columns[14].HeaderText = "Cliente";
                    dgvCompras.Columns[14].Visible = false;

                    dgvCompras.Columns[15].HeaderText = "Cliente";
                    dgvCompras.Columns[15].Visible = false;

                    dgvCompras.Columns[16].HeaderText = "Cliente";
                    dgvCompras.Columns[16].Visible = false;

                    dgvCompras.Columns[17].HeaderText = "Cliente";
                    dgvCompras.Columns[17].Visible = false;

                    dgvCompras.Columns[18].HeaderText = "Cliente";
                    dgvCompras.Columns[18].Visible = false;

                    dgvCompras.Columns[19].HeaderText = "Cliente";
                    dgvCompras.Columns[19].Visible = false;

                    dgvCompras.Columns[20].HeaderText = "Observacion";
                    dgvCompras.Columns[20].Visible = false;

                    dgvCompras.Columns[21].HeaderText = "Observacion";
                    dgvCompras.Columns[21].Visible = false;

                    dgvCompras.Columns[22].HeaderText = "Adjunto";
                    dgvCompras.Columns[22].Visible = false;

                    dgvCompras.Columns[23].HeaderText = "Observacion";
                    dgvCompras.Columns[23].Visible = false;

                    dgvCompras.Columns[24].HeaderText = "Adjunto";
                    dgvCompras.Columns[24].Visible = false;

                    dgvCompras.Columns[25].HeaderText = "Observacion";
                    dgvCompras.Columns[25].Visible = false;

                    dgvCompras.Columns[26].HeaderText = "Adjunto";
                    dgvCompras.Columns[26].Visible = false;

                    dgvCompras.Columns[27].HeaderText = "Observacion";
                    dgvCompras.Columns[27].Visible = false;

                    dgvCompras.Columns[28].HeaderText = "Adjunto";
                    dgvCompras.Columns[28].Visible = false;

                    DataGridViewButtonColumn BotonVer = new DataGridViewButtonColumn();
                    BotonVer.Name = "Ver";
                    BotonVer.HeaderText = "Ver";
                    this.dgvCompras.Columns.Add(BotonVer);
                    dgvCompras.Columns[29].Width = 80;
                    dgvCompras.Columns[29].HeaderCell.Style.BackColor = Color.DarkBlue;
                    dgvCompras.Columns[29].HeaderCell.Style.Font = new Font("Tahoma", 10, FontStyle.Bold);
                    dgvCompras.Columns[29].HeaderCell.Style.ForeColor = Color.White;

                    DataGridViewButtonColumn BotonEditar = new DataGridViewButtonColumn();
                    BotonEditar.Name = "Editar";
                    BotonEditar.HeaderText = "Editar";
                    this.dgvCompras.Columns.Add(BotonEditar);
                    dgvCompras.Columns[30].Width = 80;
                    dgvCompras.Columns[30].HeaderCell.Style.BackColor = Color.DarkBlue;
                    dgvCompras.Columns[30].HeaderCell.Style.Font = new Font("Tahoma", 10, FontStyle.Bold);
                    dgvCompras.Columns[30].HeaderCell.Style.ForeColor = Color.White;

                }

                else { MessageBox.Show("No se encontraron resultados para la persona seleccionada."); }
            }
        }
        private void btnAgregarProveedor_Click(object sender, EventArgs e)
        {
            ProveedoresWF _proveedores = new ProveedoresWF();
            _proveedores.Show();
            Hide();
        }

        private void btnCargarCompra_Click(object sender, EventArgs e)
        {
            FacturacionCompraWF _compra = new FacturacionCompraWF();
            _compra.Show();
            Hide();
        }
    }
}
