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
    public partial class ProveedorNuevoWF : Form
    {
        public ProveedorNuevoWF()
        {
            InitializeComponent();
        }
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void ProveedorNuevoWF_Load(object sender, EventArgs e)
        {
            this.Refresh();
            ListarProveedores();
            BuscarTexto();
        }
        private void BuscarTexto()
        {
            txtRazonSocial.AutoCompleteCustomSource = Clases_Maestras.AutoCompleteClassProveedores.Autocomplete(Sesion.UsuarioLogueado.idEmpresaSeleccionado);
            txtRazonSocial.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtRazonSocial.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }
        private void ListarProveedores()
        {
            List<Entidades.Proveedor> ListaProveedor = new List<Entidades.Proveedor>();
            ListaProveedor = ProveedorNeg.BuscarProveedor(Sesion.UsuarioLogueado.idEmpresaSeleccionado);
            if (ListaProveedor.Count > 0)
            {
                DiseñoGrilla();
                dgvProveedor.Visible = true;
                foreach (var item in ListaProveedor)
                {
                    dgvProveedor.Rows.Add(item.IdProveedor, item.Cuit, item.NombreRazonSocial);
                }
                dgvProveedor.AllowUserToAddRows = false;
            }
        }
        private void DiseñoGrilla()
        {
            this.dgvProveedor.DefaultCellStyle.Font = new Font("Tahoma", 9);
            this.dgvProveedor.DefaultCellStyle.ForeColor = Color.Black;
            this.dgvProveedor.DefaultCellStyle.BackColor = Color.White;
            this.dgvProveedor.DefaultCellStyle.SelectionForeColor = Color.Black;
            this.dgvProveedor.DefaultCellStyle.SelectionBackColor = Color.White;
        }
        private void btnActualizarCombo_Click(object sender, EventArgs e)
        {
            this.Refresh();
            ListarProveedores();
            BuscarTexto();
        }

        private void dgvProveedor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvProveedor.CurrentCell.ColumnIndex == 3)
                {
                    string idSub = dgvProveedor.CurrentRow.Cells[0].Value.ToString();
                    string cuit = dgvProveedor.CurrentRow.Cells[1].Value.ToString();
                    string RazonSocial = dgvProveedor.CurrentRow.Cells[2].Value.ToString();

                    //CODIGO SOLO PERMITE 2 INSTANCIAS DEL FORMULARIO CLIENTES
                    //---------------------------------------------
                    int existe = Application.OpenForms.OfType<FacturacionCompraWF>().Count();
                    if (existe <= 2)
                    {
                        FacturacionCompraWF frm2 = Application.OpenForms.OfType<FacturacionCompraWF>().SingleOrDefault();
                        if (frm2 != null)
                        {
                            frm2.txtApellidoNombre.Text = RazonSocial;
                            frm2.txtCuit.Text = cuit;
                            frm2.lblidProveedor.Text = idSub;
                            frm2.IniciarPantalla();
                            Close();
                        }
                        //FacturacionSubClientesWF frm = new FacturacionSubClientesWF(null, null);
                        //frm.Show();
                    }
                    else
                    {
                        foreach (var item in Application.OpenForms.OfType<FacturacionSubClientesWF>())
                        {
                            item.BringToFront();
                        }
                    }
                }
            }
            catch (Exception ex)
            { }
        }
        private void dgvProveedor_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex >= 0 && this.dgvProveedor.Columns[e.ColumnIndex].Name == "Seleccionar" && e.RowIndex >= 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                DataGridViewButtonCell BotonVer = this.dgvProveedor.Rows[e.RowIndex].Cells["Seleccionar"] as DataGridViewButtonCell;
                Icon icoAtomico = new Icon(Environment.CurrentDirectory + "\\" + @"Ver.ico");
                e.Graphics.DrawIcon(icoAtomico, e.CellBounds.Left + 20, e.CellBounds.Top + 4);
                this.dgvProveedor.Rows[e.RowIndex].Height = icoAtomico.Height + 8;
                this.dgvProveedor.Columns[e.ColumnIndex].Width = icoAtomico.Width + 40;
                e.Handled = true;
            }
        }
    }
}
