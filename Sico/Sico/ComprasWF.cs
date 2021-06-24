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
                List<FacturaCompra> Lista = new List<FacturaCompra>();
                Lista = ComprasNeg.BuscarTodasFacturasDeComprasDelCliente(cuit);
                dgvCompras.Refresh();
                foreach (var item in Lista)
                {
                    dgvCompras.Rows.Add(item.idFactura, item.NroFactura, item.Fecha, item.Monto, item.NombreProveedor, "", "", item.Total1, item.Total2, item.Total3, item.Neto1, item.Neto2, item.Neto3, item.Iva1, item.Iva2, item.Iva3, item.PercepIva, item.PercepIngBrutos, item.NoGravado);
                }
                lblCantidad.Visible = true;
                lblCantidadEdit.Visible = true;
                lblFacturasMensaje.Visible = true;
                btnCoral.Visible = true;
                lblCantidadEdit.Text = Convert.ToString(Lista.Count);
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
                //dgvCompras.Rows.Add(Lista.Fecha, list.TipoComprobante, list.NroFactura, list.TipoComprobante, list.Cuit, list.NombreProveedor, list.TipoDeCambio, list.CodigoMoneda, VARImpNetoGravado, VARImpNetoNoGravado, VARImpOpExentas, list.PercepIva, list.PercepIngBrutos, Iva, list.Monto);
                txtBuscar.AutoCompleteCustomSource = Clases_Maestras.AutoCompleteClassProveedores.Autocomplete(Sesion.UsuarioLogueado.idEmpresaSeleccionado);
                txtBuscar.AutoCompleteMode = AutoCompleteMode.Suggest;
                txtBuscar.AutoCompleteSource = AutoCompleteSource.CustomSource;
                ValidarDiseñoGrilla();
            }
            catch (Exception ex) { }
        }
        private void ValidarDiseñoGrilla()
        {
            foreach (DataGridViewRow row in dgvCompras.Rows)
            {
                decimal PercIva = 0;
                decimal PercIngBrutos = 0;
                decimal NoGravado = 0;
                decimal Total1 = 0;
                decimal Total2 = 0;
                decimal Total3 = 0;
                decimal Neto1 = 0;
                decimal Neto2 = 0;
                decimal Neto3 = 0;
                decimal Iva1 = 0;
                decimal Iva2 = 0;
                decimal Iva3 = 0;
                if (row.Cells[7].Value != null)
                {
                    Total1 = Convert.ToDecimal(row.Cells[7].Value);
                }
                if (row.Cells[8].Value != null)
                {
                    Total2 = Convert.ToDecimal(row.Cells[8].Value);
                }
                if (row.Cells[9].Value != null)
                {
                    Total3 = Convert.ToDecimal(row.Cells[9].Value);
                }
                if (row.Cells[10].Value != null)
                {
                    Neto1 = Convert.ToDecimal(row.Cells[10].Value);
                }
                if (row.Cells[11].Value != null)
                {
                    Neto2 = Convert.ToDecimal(row.Cells[11].Value);
                }
                if (row.Cells[12].Value != null)
                {
                    Neto3 = Convert.ToDecimal(row.Cells[12].Value);
                }
                if (row.Cells[13].Value != null)
                {
                    Iva1 = Convert.ToDecimal(row.Cells[13].Value);
                }
                if (row.Cells[14].Value != null)
                {
                    Iva2 = Convert.ToDecimal(row.Cells[14].Value);
                }
                if (row.Cells[15].Value != null)
                {
                    Iva3 = Convert.ToDecimal(row.Cells[15].Value);
                }
                if (row.Cells[16].Value != null)
                { PercIva = Convert.ToDecimal(row.Cells[16].Value); }
                else { PercIva = 0; }
                if (row.Cells[17].Value != null)
                { PercIngBrutos = Convert.ToDecimal(row.Cells[17].Value); }
                else { PercIngBrutos = 0; }
                if (row.Cells[18].Value != null)
                { NoGravado = Convert.ToDecimal(row.Cells[18].Value); }
                else { NoGravado = 0; }
                decimal Monto = Convert.ToDecimal(row.Cells[3].Value);

                if (Total1 > 0)
                {
                    double ValorIncial = Convert.ToDouble(Total1);
                    double Result = Convert.ToDouble(Neto1 + Iva1);
                    string valor = Convert.ToString(Math.Round((Result), 2));
                    if (ValorIncial != Result)
                    {
                        Total1 = Convert.ToDecimal(valor);
                    }
                }
                if (Total1 > 0)
                {
                    double ValorIncial = Convert.ToDouble(Total1);
                    double Result = Convert.ToDouble(Neto1 + Iva1);
                    string valor = Convert.ToString(Math.Round((Result), 2));
                    if (ValorIncial != Result)
                    {
                        Total1 = Convert.ToDecimal(valor);
                    }
                }
                if (Total2 > 0)
                {
                    double ValorIncial = Convert.ToDouble(Total2);
                    double Result = Convert.ToDouble(Neto2 + Iva2);
                    string valor = Convert.ToString(Math.Round((Result), 2));
                    if (ValorIncial != Result)
                    {
                        Total2 = Convert.ToDecimal(valor);
                    }
                }
                if (Total3 > 0)
                {
                    double ValorIncial = Convert.ToDouble(Total3);
                    double Result = Convert.ToDouble(Neto3 + Iva3);
                    string valor = Convert.ToString(Math.Round((Result), 2));
                    if (ValorIncial != Result)
                    {
                        Total3 = Convert.ToDecimal(valor);
                    }
                }
                decimal ValidarMonto = Total1 + Total2 + Total3 + PercIngBrutos + PercIva + NoGravado;
                decimal ValidarMontoTotal = Convert.ToDecimal(ValidarMonto);
                if (ValidarMontoTotal != Monto)
                {
                    row.DefaultCellStyle.BackColor = Color.LightCoral;
                }

                else { row.DefaultCellStyle.BackColor = Color.White; }
            }
        }
        public static List<FacturaCompra> Lista;
        //public List<FacturaCompra> ListaFacturas
        //{
        //    set
        //    {
        //        if (value.Count > 0)
        //        {
        //            Lista = value;
        //            if (value != dgvCompras.DataSource && dgvCompras.DataSource != null)
        //            {
        //                dgvCompras.Columns.Clear();
        //                dgvCompras.Refresh();
        //            }
        //            lblCantidad.Visible = true;
        //            lblCantidadEdit.Visible = true;
        //            lblCantidadEdit.Text = Convert.ToString(value.Count);
        //            btnBuscar.Visible = true;
        //            btnConsultarTotales.Visible = true;
        //            label2.Visible = true;
        //            lblSeleccionar.Visible = true;
        //            txtBuscar.Visible = true;
        //            txtBuscar.Enabled = true;
        //            txtBuscar.Focus();
        //            dgvCompras.Visible = true;
        //            dgvCompras.ReadOnly = true;
        //            dgvCompras.RowHeadersVisible = false;
        //            dgvCompras.DataSource = value;

        //            //dgvCompras.Columns[0].HeaderText = "Id Factura";
        //            //dgvCompras.Columns[0].Width = 130;
        //            //dgvCompras.Columns[0].HeaderCell.Style.BackColor = Color.DarkBlue;
        //            //dgvCompras.Columns[0].HeaderCell.Style.Font = new System.Drawing.Font("Tahoma", 10, FontStyle.Bold);
        //            //dgvCompras.Columns[0].HeaderCell.Style.ForeColor = Color.White;

        //            //dgvCompras.Columns[1].HeaderText = "Nro.Factura";
        //            //dgvCompras.Columns[1].Width = 200;
        //            //dgvCompras.Columns[1].HeaderCell.Style.BackColor = Color.DarkBlue;
        //            //dgvCompras.Columns[1].HeaderCell.Style.Font = new System.Drawing.Font("Tahoma", 10, FontStyle.Bold);
        //            //dgvCompras.Columns[1].HeaderCell.Style.ForeColor = Color.White;

        //            //dgvCompras.Columns[2].HeaderText = "Fecha";
        //            //dgvCompras.Columns[2].Width = 100;
        //            //dgvCompras.Columns[2].HeaderCell.Style.BackColor = Color.DarkBlue;
        //            //dgvCompras.Columns[2].HeaderCell.Style.Font = new System.Drawing.Font("Tahoma", 10, FontStyle.Bold);
        //            //dgvCompras.Columns[2].HeaderCell.Style.ForeColor = Color.White;

        //            //dgvCompras.Columns[3].HeaderText = "Monto";
        //            //dgvCompras.Columns[3].Width = 160;
        //            //dgvCompras.Columns[3].HeaderCell.Style.BackColor = Color.DarkBlue;
        //            //dgvCompras.Columns[3].HeaderCell.Style.Font = new System.Drawing.Font("Tahoma", 10, FontStyle.Bold);
        //            //dgvCompras.Columns[3].HeaderCell.Style.ForeColor = Color.White;

        //            //dgvCompras.Columns[4].HeaderText = "Cliente";
        //            //dgvCompras.Columns[4].Width = 80;
        //            //dgvCompras.Columns[4].HeaderCell.Style.BackColor = Color.DarkBlue;
        //            //dgvCompras.Columns[4].HeaderCell.Style.Font = new System.Drawing.Font("Tahoma", 10, FontStyle.Bold);
        //            //dgvCompras.Columns[4].HeaderCell.Style.ForeColor = Color.White;
        //            //dgvCompras.Columns[4].Visible = false;

        //            //dgvCompras.Columns[5].HeaderText = "IdProveedor";
        //            //dgvCompras.Columns[5].Width = 250;
        //            //dgvCompras.Columns[5].HeaderCell.Style.BackColor = Color.DarkBlue;
        //            //dgvCompras.Columns[5].HeaderCell.Style.Font = new System.Drawing.Font("Tahoma", 10, FontStyle.Bold);
        //            //dgvCompras.Columns[5].HeaderCell.Style.ForeColor = Color.White;
        //            //dgvCompras.Columns[5].Visible = false;

        //            //dgvCompras.Columns[6].HeaderText = "Proveedor";
        //            //dgvCompras.Columns[6].Width = 100;
        //            //dgvCompras.Columns[6].HeaderCell.Style.BackColor = Color.DarkBlue;
        //            //dgvCompras.Columns[6].HeaderCell.Style.Font = new System.Drawing.Font("Tahoma", 10, FontStyle.Bold);
        //            //dgvCompras.Columns[6].HeaderCell.Style.ForeColor = Color.White;


        //            //dgvCompras.Columns[7].HeaderText = "Cliente";
        //            //dgvCompras.Columns[7].Width = 95;
        //            //dgvCompras.Columns[7].HeaderCell.Style.BackColor = Color.DarkBlue;
        //            //dgvCompras.Columns[7].HeaderCell.Style.Font = new System.Drawing.Font("Tahoma", 10, FontStyle.Bold);
        //            //dgvCompras.Columns[7].HeaderCell.Style.ForeColor = Color.White;
        //            //dgvCompras.Columns[7].Visible = false;

        //            //dgvCompras.Columns[8].HeaderText = "Cliente";
        //            //dgvCompras.Columns[8].Visible = false;

        //            //dgvCompras.Columns[9].HeaderText = "Cliente";
        //            //dgvCompras.Columns[9].Visible = false;

        //            //dgvCompras.Columns[10].HeaderText = "Cliente";
        //            //dgvCompras.Columns[10].Visible = false;

        //            //dgvCompras.Columns[11].HeaderText = "Cliente";
        //            //dgvCompras.Columns[11].Visible = false;

        //            //dgvCompras.Columns[12].HeaderText = "Cliente";
        //            //dgvCompras.Columns[12].Visible = false;

        //            //dgvCompras.Columns[13].HeaderText = "Cliente";
        //            //dgvCompras.Columns[13].Visible = false;

        //            //dgvCompras.Columns[14].HeaderText = "Cliente";
        //            //dgvCompras.Columns[14].Visible = false;

        //            //dgvCompras.Columns[15].HeaderText = "Cliente";
        //            //dgvCompras.Columns[15].Visible = false;

        //            //dgvCompras.Columns[16].HeaderText = "Cliente";
        //            //dgvCompras.Columns[16].Visible = false;

        //            //dgvCompras.Columns[17].HeaderText = "Cliente";
        //            //dgvCompras.Columns[17].Visible = false;

        //            //dgvCompras.Columns[18].HeaderText = "Cliente";
        //            //dgvCompras.Columns[18].Visible = false;

        //            //dgvCompras.Columns[19].HeaderText = "Cliente";
        //            //dgvCompras.Columns[19].Visible = false;

        //            //dgvCompras.Columns[20].HeaderText = "Observacion";
        //            //dgvCompras.Columns[20].Visible = false;

        //            //dgvCompras.Columns[21].HeaderText = "Observacion";
        //            //dgvCompras.Columns[21].Visible = false;

        //            //dgvCompras.Columns[22].HeaderText = "Adjunto";
        //            //dgvCompras.Columns[22].Visible = false;

        //            //dgvCompras.Columns[23].HeaderText = "Observacion";
        //            //dgvCompras.Columns[23].Visible = false;

        //            //dgvCompras.Columns[24].HeaderText = "Adjunto";
        //            //dgvCompras.Columns[24].Visible = false;

        //            //dgvCompras.Columns[25].HeaderText = "Observacion";
        //            //dgvCompras.Columns[25].Visible = false;

        //            //dgvCompras.Columns[26].HeaderText = "Adjunto";
        //            //dgvCompras.Columns[26].Visible = false;

        //            //dgvCompras.Columns[27].HeaderText = "Observacion";
        //            //dgvCompras.Columns[27].Visible = false;

        //            //dgvCompras.Columns[28].HeaderText = "Adjunto";
        //            //dgvCompras.Columns[28].Visible = false;

        //            //dgvCompras.Columns[29].HeaderText = "Cuit";
        //            //dgvCompras.Columns[29].Visible = false;

        //            //dgvCompras.Columns[30].HeaderText = "Período";
        //            //dgvCompras.Columns[30].Visible = false;

        //            //DataGridViewButtonColumn BotonVer = new DataGridViewButtonColumn();
        //            //BotonVer.Name = "Ver";
        //            //BotonVer.HeaderText = "Ver";
        //            //this.dgvCompras.Columns.Add(BotonVer);
        //            //dgvCompras.Columns[31].Width = 80;
        //            //dgvCompras.Columns[31].HeaderCell.Style.BackColor = Color.DarkBlue;
        //            //dgvCompras.Columns[31].HeaderCell.Style.Font = new Font("Tahoma", 10, FontStyle.Bold);
        //            //dgvCompras.Columns[31].HeaderCell.Style.ForeColor = Color.White;

        //            //DataGridViewButtonColumn BotonEditar = new DataGridViewButtonColumn();
        //            //BotonEditar.Name = "Editar";
        //            //BotonEditar.HeaderText = "Editar";
        //            //this.dgvCompras.Columns.Add(BotonEditar);
        //            //dgvCompras.Columns[32].Width = 100;
        //            //dgvCompras.Columns[32].HeaderCell.Style.BackColor = Color.DarkBlue;
        //            //dgvCompras.Columns[32].HeaderCell.Style.Font = new Font("Tahoma", 10, FontStyle.Bold);
        //            //dgvCompras.Columns[32].HeaderCell.Style.ForeColor = Color.White;                   
        //        }

        //        else { MessageBox.Show("No se encontraron resultados para la persona seleccionada."); }
        //    }
        //}
        private void dgvCompras_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex >= 0 && this.dgvCompras.Columns[e.ColumnIndex].Name == "Ver" && e.RowIndex >= 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                DataGridViewButtonCell BotonVer = this.dgvCompras.Rows[e.RowIndex].Cells["Ver"] as DataGridViewButtonCell;
                Icon icoAtomico = new Icon(Environment.CurrentDirectory + "\\" + @"lupa.ico");
                e.Graphics.DrawIcon(icoAtomico, e.CellBounds.Left + 5, e.CellBounds.Top + 5);

                this.dgvCompras.Rows[e.RowIndex].Height = icoAtomico.Height + 6;
                this.dgvCompras.Columns[e.ColumnIndex].Width = icoAtomico.Width + 6;

                e.Handled = true;
            }

            if (e.ColumnIndex >= 0 && this.dgvCompras.Columns[e.ColumnIndex].Name == "Editar" && e.RowIndex >= 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                DataGridViewButtonCell BotonEditar = this.dgvCompras.Rows[e.RowIndex].Cells["Editar"] as DataGridViewButtonCell;
                Icon icoAtomico = new Icon(Environment.CurrentDirectory + "\\" + @"editar.ico");
                e.Graphics.DrawIcon(icoAtomico, e.CellBounds.Left + 5, e.CellBounds.Top + 5);
                this.dgvCompras.Rows[e.RowIndex].Height = icoAtomico.Height + 6;
                this.dgvCompras.Columns[e.ColumnIndex].Width = icoAtomico.Width + 6;
                e.Handled = true;
            }
        }
        private void ClickBoton(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvCompras.CurrentCell.ColumnIndex == 5)
            {
                EsEditar = false;
                var idFactura = Convert.ToString(this.dgvCompras.CurrentRow.Cells[0].Value);
                //VistaFacturacionComprasWF _vista = new VistaFacturacionComprasWF(idFactura, cuit, razonSocial, EsEditar);
                //_vista.Show();
                Hide();
            }

            if (dgvCompras.CurrentCell.ColumnIndex == 6)
            {
                EsEditar = true;
                var idFactura = Convert.ToString(this.dgvCompras.CurrentRow.Cells[0].Value);
                //VistaFacturacionComprasWF _vista = new VistaFacturacionComprasWF(idFactura, idEmpresa, razonSocial, EsEditar);
                //_vista.Show();
                Hide();
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

            FacturacionCompraWF _compra = new FacturacionCompraWF(cuit, razonSocial, cuit);
            _compra.Show();
            Hide();
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                var ApellidoNombre = txtBuscar.Text;
                Lista = ComprasNeg.BuscarCompraPorProveedor(ApellidoNombre);
                dgvCompras.Rows.Clear();
                foreach (var item in Lista)
                {
                    dgvCompras.Rows.Add(item.idFactura, item.NroFactura, item.Fecha, item.Monto, item.NombreProveedor, "", "", item.Total1, item.Total2, item.Total3, item.Neto1, item.Neto2, item.Neto3, item.Iva1, item.Iva2, item.Iva3, item.PercepIva, item.PercepIngBrutos, item.NoGravado);
                }
                lblCantidad.Visible = true;
                lblCantidadEdit.Visible = true;
                lblFacturasMensaje.Visible = true;
                btnCoral.Visible = true;
                lblCantidadEdit.Text = Convert.ToString(Lista.Count);
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
                txtBuscar.AutoCompleteCustomSource = Clases_Maestras.AutoCompleteClassProveedores.Autocomplete(Sesion.UsuarioLogueado.idEmpresaSeleccionado);
                txtBuscar.AutoCompleteMode = AutoCompleteMode.Suggest;
                txtBuscar.AutoCompleteSource = AutoCompleteSource.CustomSource;
                ValidarDiseñoGrilla();
            }
            catch (Exception ex)
            {

            }
        }
        private void btnVentas_Click(object sender, EventArgs e)
        {
            //string RazonSocial = lblNombreEdit.Text;
            //string Cuit = lblCuitEdit.Text;
            //TareaClienteWF _tarea = new TareaClienteWF(RazonSocial, Cuit);
            //_tarea.Show();
            //Hide();
        }
        private void btnConsultarTotales_Click(object sender, EventArgs e)
        {
            VistaConsultaFacturacionComprasMensualWF _consulta = new VistaConsultaFacturacionComprasMensualWF(razonSocial, cuit);
            _consulta.Show();
            Hide();
        }
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Lista = ComprasNeg.BuscarTodasFacturasDeComprasDelCliente(cuit);
            dgvCompras.Rows.Clear();
            foreach (var item in Lista)
            {
                dgvCompras.Rows.Add(item.idFactura, item.NroFactura, item.Fecha, item.Monto, item.NombreProveedor, "", "", item.Total1, item.Total2, item.Total3, item.Neto1, item.Neto2, item.Neto3, item.Iva1, item.Iva2, item.Iva3, item.PercepIva, item.PercepIngBrutos, item.NoGravado);
            }
            lblCantidad.Visible = true;
            lblCantidadEdit.Visible = true;
            lblFacturasMensaje.Visible = true;
            btnCoral.Visible = true;
            lblCantidadEdit.Text = Convert.ToString(Lista.Count);
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
            txtBuscar.AutoCompleteCustomSource = Clases_Maestras.AutoCompleteClassProveedores.Autocomplete(Sesion.UsuarioLogueado.idEmpresaSeleccionado);
            txtBuscar.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtBuscar.AutoCompleteSource = AutoCompleteSource.CustomSource;
            ValidarDiseñoGrilla();
        }
        private void btnEstadisticas_Click(object sender, EventArgs e)
        {
            string RazonSocial = lblNombreEdit.Text;
            string Cuit = lblCuitEdit.Text;
            ComprasEstadisticasWF _tarea = new ComprasEstadisticasWF(RazonSocial, Cuit);
            _tarea.Show();
            Hide();
        }
        private void imgArba_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.arba.gov.ar/");
        }
        private void imgAfip_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.afip.gob.ar/sitio/externos/default.asp");
        }
        private void imgAnses_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://servicioscorp.anses.gob.ar/clavelogon/logon.aspx?system=mianses");
        }
        private void imgApr_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://apronline.gov.ar/");
        }
        private void imgAutoGestion_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://autogestion.apronline.gov.ar/");
        }
        private void btnInportarCompras_Click(object sender, EventArgs e)
        {
            ComprasImportarComprasWF _importar = new ComprasImportarComprasWF(razonSocial, cuit);
            _importar.Show();
            Hide();
        }
    }
}
