﻿using Sico.Entidades;
using Sico.Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
        private void btnCuentaCorriente_Click(object sender, EventArgs e)
        {
            NotaDeCreditoWF _ctaCorriente = new NotaDeCreditoWF(razonSocial, cuit);
            _ctaCorriente.Show();
        }
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
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                //List<SubCliente> _cliente = new List<SubCliente>();
                //List<SubCliente> ListaFacturas = new List<SubCliente>();
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
        private void btnNuevoSubCliente_Click(object sender, EventArgs e)
        {
            SubClienteWF _sub = new SubClienteWF(razonSocial, cuit);
            _sub.Show();
            Hide();
        }
        private void btnNuevoSubCliente_Click_1(object sender, EventArgs e)
        {
            SubClienteWF _sub = new SubClienteWF(razonSocial, cuit);
            _sub.Show();
            Hide();
        }
        private void btnConsultarTotales_Click(object sender, EventArgs e)
        {
            VistaConsultaFacturacionMensualWF _consulta = new VistaConsultaFacturacionMensualWF(razonSocial, cuit);
            _consulta.Show();
            Hide();
        }
        #endregion
        #region Funciones
        public List<Entidades.SubCliente> ListaFacturas
        {
            set
            {
                if (value.Count > 0)
                {
                    if (value != dgvSubClientes.DataSource && dgvSubClientes.DataSource != null)
                    {
                        dgvSubClientes.Columns.Clear();
                        dgvSubClientes.Refresh();
                    }
                    lblCantidad.Visible = true;
                    lblCantidadEdit.Visible = true;
                    lblCantidadEdit.Text = Convert.ToString(value.Count);
                    btnBuscar.Visible = true;
                    btnConsultarTotales.Visible = true;
                    label2.Visible = true;
                    lblSeleccionar.Visible = true;
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
                    dgvSubClientes.Columns[3].Width = 200;
                    dgvSubClientes.Columns[3].HeaderCell.Style.BackColor = Color.DarkBlue;
                    dgvSubClientes.Columns[3].HeaderCell.Style.Font = new System.Drawing.Font("Tahoma", 10, FontStyle.Bold);
                    dgvSubClientes.Columns[3].HeaderCell.Style.ForeColor = Color.White;

                    dgvSubClientes.Columns[4].HeaderText = "Dni";
                    dgvSubClientes.Columns[4].Width = 80;
                    dgvSubClientes.Columns[4].HeaderCell.Style.BackColor = Color.DarkBlue;
                    dgvSubClientes.Columns[4].HeaderCell.Style.Font = new System.Drawing.Font("Tahoma", 10, FontStyle.Bold);
                    dgvSubClientes.Columns[4].HeaderCell.Style.ForeColor = Color.White;
                    dgvSubClientes.Columns[4].Visible = false;

                    dgvSubClientes.Columns[5].HeaderText = "Dirección";
                    dgvSubClientes.Columns[5].Width = 250;
                    dgvSubClientes.Columns[5].HeaderCell.Style.BackColor = Color.DarkBlue;
                    dgvSubClientes.Columns[5].HeaderCell.Style.Font = new System.Drawing.Font("Tahoma", 10, FontStyle.Bold);
                    dgvSubClientes.Columns[5].HeaderCell.Style.ForeColor = Color.White;
                    dgvSubClientes.Columns[5].Visible = false;

                    dgvSubClientes.Columns[6].HeaderText = "Monto";
                    dgvSubClientes.Columns[6].Width = 135;
                    dgvSubClientes.Columns[6].HeaderCell.Style.BackColor = Color.DarkBlue;
                    dgvSubClientes.Columns[6].HeaderCell.Style.Font = new System.Drawing.Font("Tahoma", 10, FontStyle.Bold);
                    dgvSubClientes.Columns[6].HeaderCell.Style.ForeColor = Color.White;
                    dgvSubClientes.Columns[6].Visible = true;

                    dgvSubClientes.Columns[7].HeaderText = "Cliente";
                    dgvSubClientes.Columns[7].Width = 95;
                    dgvSubClientes.Columns[7].HeaderCell.Style.BackColor = Color.DarkBlue;
                    dgvSubClientes.Columns[7].HeaderCell.Style.Font = new System.Drawing.Font("Tahoma", 10, FontStyle.Bold);
                    dgvSubClientes.Columns[7].HeaderCell.Style.ForeColor = Color.White;
                    dgvSubClientes.Columns[7].Visible = false;

                    dgvSubClientes.Columns[8].HeaderText = "Cliente";
                    dgvSubClientes.Columns[8].Visible = false;

                    dgvSubClientes.Columns[9].HeaderText = "Cliente";
                    dgvSubClientes.Columns[9].Visible = false;

                    dgvSubClientes.Columns[10].HeaderText = "Cliente";
                    dgvSubClientes.Columns[10].Visible = false;

                    dgvSubClientes.Columns[11].HeaderText = "Cliente";
                    dgvSubClientes.Columns[11].Visible = false;

                    dgvSubClientes.Columns[12].HeaderText = "Cliente";
                    dgvSubClientes.Columns[12].Visible = false;

                    dgvSubClientes.Columns[13].HeaderText = "Cliente";
                    dgvSubClientes.Columns[13].Visible = false;

                    dgvSubClientes.Columns[14].HeaderText = "Cliente";
                    dgvSubClientes.Columns[14].Visible = false;

                    dgvSubClientes.Columns[15].HeaderText = "Cliente";
                    dgvSubClientes.Columns[15].Visible = false;

                    dgvSubClientes.Columns[16].HeaderText = "Cliente";
                    dgvSubClientes.Columns[16].Visible = false;

                    dgvSubClientes.Columns[17].HeaderText = "Cliente";
                    dgvSubClientes.Columns[17].Visible = false;

                    dgvSubClientes.Columns[18].HeaderText = "Cliente";
                    dgvSubClientes.Columns[18].Visible = false;

                    dgvSubClientes.Columns[19].HeaderText = "Cliente";
                    dgvSubClientes.Columns[19].Visible = false;

                    dgvSubClientes.Columns[20].HeaderText = "Observacion";
                    dgvSubClientes.Columns[20].Visible = false;

                    DataGridViewButtonColumn BotonVer = new DataGridViewButtonColumn();
                    BotonVer.Name = "Ver";
                    BotonVer.HeaderText = "Ver";
                    this.dgvSubClientes.Columns.Add(BotonVer);
                    dgvSubClientes.Columns[21].Width = 40;
                    dgvSubClientes.Columns[21].HeaderCell.Style.BackColor = Color.DarkBlue;
                    dgvSubClientes.Columns[21].HeaderCell.Style.Font = new Font("Tahoma", 10, FontStyle.Bold);
                    dgvSubClientes.Columns[21].HeaderCell.Style.ForeColor = Color.White;
                }

                else { MessageBox.Show("No se encontraron resultados para la persona seleccionada."); }
            }
        }

        private void dgvSubClientes_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex >= 0 && this.dgvSubClientes.Columns[e.ColumnIndex].Name == "Ver" && e.RowIndex >= 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                DataGridViewButtonCell celBoton = this.dgvSubClientes.Rows[e.RowIndex].Cells["Ver"] as DataGridViewButtonCell;
                e.Handled = true;
            }
        }
        private void ClickBoton(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvSubClientes.CurrentCell.ColumnIndex == 20)
            {
                var idsubCliente = Convert.ToString(this.dgvSubClientes.CurrentRow.Cells[0].Value);
                VistaFacturacionSubClienteWF _vista = new VistaFacturacionSubClienteWF(idsubCliente, cuit, razonSocial);
                _vista.Show();
                Hide();
            }
        }

        #endregion

       
    }
}
