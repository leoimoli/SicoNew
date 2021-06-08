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
using System.Linq;

namespace Sico
{
    public partial class SubClientesNuevoWF : Form
    {
        public SubClientesNuevoWF()
        {
            InitializeComponent();
        }
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void SubClientesNuevoWF_Load(object sender, EventArgs e)
        {
            ListarSubClientes();
        }
        private void ListarSubClientes()
        {
            List<Entidades.SubCliente> ListaSubCliente = new List<Entidades.SubCliente>();
            ListaSubCliente = ClienteNeg.BuscarSubClientes(Sesion.UsuarioLogueado.idEmpresaSeleccionado);
            if (ListaSubCliente.Count > 0)
            {
                DiseñoGrilla();
                dgvSubClientes.Visible = true;
                foreach (var item in ListaSubCliente)
                {
                    dgvSubClientes.Rows.Add(item.idSubCliente, item.Dni, item.ApellidoNombre);
                }
                dgvSubClientes.AllowUserToAddRows = false;
            }
        }
        private void DiseñoGrilla()
        {
            this.dgvSubClientes.DefaultCellStyle.Font = new Font("Tahoma", 9);
            this.dgvSubClientes.DefaultCellStyle.ForeColor = Color.Black;
            this.dgvSubClientes.DefaultCellStyle.BackColor = Color.White;
            this.dgvSubClientes.DefaultCellStyle.SelectionForeColor = Color.Black;
            this.dgvSubClientes.DefaultCellStyle.SelectionBackColor = Color.White;
        }
        private void dgvSubClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvSubClientes.CurrentCell.ColumnIndex == 3)
            {
                string idSub = dgvSubClientes.CurrentRow.Cells[0].Value.ToString();
                string Dni = dgvSubClientes.CurrentRow.Cells[1].Value.ToString();
                string RazonSocial = dgvSubClientes.CurrentRow.Cells[2].Value.ToString();

                FacturacionSubClientesWF frm2 = Application.OpenForms.OfType<FacturacionSubClientesWF>().SingleOrDefault();
                if (frm2 != null)
                {
                    frm2.txtRazonSocial.Text = RazonSocial;
                    frm2.txtCuit.Text = Dni;
                    frm2.lblidSubCliente.Text = idSub;
                    frm2.IniciarPantalla();
                    Close();
                }
            }
        }
        private void dgvSubClientes_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex >= 0 && this.dgvSubClientes.Columns[e.ColumnIndex].Name == "Seleccionar" && e.RowIndex >= 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                DataGridViewButtonCell BotonVer = this.dgvSubClientes.Rows[e.RowIndex].Cells["Seleccionar"] as DataGridViewButtonCell;
                Icon icoAtomico = new Icon(Environment.CurrentDirectory + "\\" + @"Ver.ico");
                e.Graphics.DrawIcon(icoAtomico, e.CellBounds.Left + 20, e.CellBounds.Top + 4);
                this.dgvSubClientes.Rows[e.RowIndex].Height = icoAtomico.Height + 8;
                this.dgvSubClientes.Columns[e.ColumnIndex].Width = icoAtomico.Width + 40;
                e.Handled = true;
            }
        }
        private void txtDni_TextChanged(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = dgvSubClientes.DataSource;
            bs.Filter = "Dni like '%" + txtDni.Text + "%'";
            dgvSubClientes.DataSource = bs;
        }
        string BuscarDni = "";
        private void dataGridView1_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            BuscarDni = dgvSubClientes.Columns[e.ColumnIndex].DataPropertyName.Trim();
        }
        private void FiltrarDatosDatagridviewPorDni(DataGridView datagrid, string nombre_columna, TextBox txt_buscar)
        {
            string cadena = txtDni.Text.Trim().Replace("*", "");
            string filtro = string.Format("convert([{0}], System.String) LIKE '{1}%'", nombre_columna, cadena);
            (datagrid.DataSource as DataTable).DefaultView.RowFilter = filtro;
        }
    }
}
