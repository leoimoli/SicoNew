using Sico.Entidades;
using Sico.Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sico
{
    public partial class ClientesNuevoWFcs : Form
    {
        public ClientesNuevoWFcs()
        {
            InitializeComponent();
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            BuscarRazonSocial();
        }
        private void BuscarRazonSocial()
        {
            try
            {
                if (txtCuitBuscar.Text != "  -        -")
                {
                    BuscarEmpresaPorCuit();
                }
                if (txtBuscarRazonSocial.Text != "")
                {
                    BuscarEmpresaPorRazonSocial();
                }
            }
            catch (Exception ex)
            { }
        }
        private void BuscarEmpresaPorRazonSocial()
        {
            List<Cliente> _cliente = new List<Cliente>();
            var nombreRazonSocial = txtBuscarRazonSocial.Text;
            _cliente = ClienteNeg.BuscarClientePorNombreRazonSocial(nombreRazonSocial);
            if (_cliente.Count > 0)
            {
                dgvTodosLosClientes.Rows.Clear();
                DiseñoGrilla();
                dgvTodosLosClientes.Visible = true;
                foreach (var item in _cliente)
                {
                    dgvTodosLosClientes.Rows.Add(item.IdCliente, item.NombreRazonSocial, item.Cuit, item.Actividad, item.CondicionAntiAfip);
                }
                dgvTodosLosClientes.AllowUserToAddRows = false;
            }
            else
            {
                txtBuscarRazonSocial.Focus();
                const string message = "No existe ningun cliente con el nombre o razón social ingresado.";
                const string caption = "Atención";
                var result = MessageBox.Show(message, caption,
                                             MessageBoxButtons.OK,
                                           MessageBoxIcon.Exclamation);
                throw new Exception();
            }
        }
        private void BuscarEmpresaPorCuit()
        {
            List<Cliente> _cliente = new List<Cliente>();
            var cuit = txtCuitBuscar.Text;
            _cliente = ClienteNeg.BuscarClientePorCuit(cuit);
            if (_cliente.Count > 0)
            {
                dgvTodosLosClientes.Rows.Clear();
                DiseñoGrilla();
                dgvTodosLosClientes.Visible = true;
                foreach (var item in _cliente)
                {
                    dgvTodosLosClientes.Rows.Add(item.IdCliente, item.NombreRazonSocial, item.Cuit, item.Actividad, item.CondicionAntiAfip);
                }
                dgvTodosLosClientes.AllowUserToAddRows = false;
            }
            else
            {
                txtBuscarRazonSocial.Focus();
                const string message = "No existe ningun cliente con el cuit ingresado.";
                const string caption = "Atención";
                var result = MessageBox.Show(message, caption,
                                             MessageBoxButtons.OK,
                                           MessageBoxIcon.Exclamation);
                throw new Exception();
            }
        }
        private void ClientesNuevoWFcs_Load(object sender, EventArgs e)
        {
            BuscarTexto();
            BuscarTodasLasEmpresas();
            Hide();
        }
        private void BuscarTexto()
        {
            txtBuscarRazonSocial.AutoCompleteCustomSource = Clases_Maestras.AutoCompleteRazonSocial.Autocomplete();
            txtBuscarRazonSocial.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtBuscarRazonSocial.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }
        private void BuscarTodasLasEmpresas()
        {
            dgvTodosLosClientes.Rows.Clear();
            List<Entidades.Cliente> ListarClientes = ClienteNeg.ListarTodosLosClientes();
            if (ListarClientes.Count > 0)
            {
                PanelTotales.Visible = true;
                lblClientesEdit.Text = Convert.ToString(ListarClientes.Count);
                DiseñoGrilla();
                dgvTodosLosClientes.Visible = true;
                foreach (var item in ListarClientes)
                {
                    dgvTodosLosClientes.Rows.Add(item.IdCliente, item.NombreRazonSocial, item.Cuit, item.Actividad, item.CondicionAntiAfip);
                }
                dgvTodosLosClientes.AllowUserToAddRows = false;
            }
            else
            {
                PanelTotales.Visible = false;
            }
        }
        private void DiseñoGrilla()
        {
            this.dgvTodosLosClientes.DefaultCellStyle.Font = new Font("Tahoma", 9);
            this.dgvTodosLosClientes.DefaultCellStyle.ForeColor = Color.Black;
            this.dgvTodosLosClientes.DefaultCellStyle.BackColor = Color.White;
            this.dgvTodosLosClientes.DefaultCellStyle.SelectionForeColor = Color.SteelBlue;
            this.dgvTodosLosClientes.DefaultCellStyle.SelectionBackColor = Color.White;
        }
        public static int Funcion = 0;
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                Entidades.Cliente _cliente = CargarEntidad();
                if (Funcion == 2)
                {
                    bool Exito = ClienteNeg.EditarCliente(_cliente);
                    if (Exito == true)
                    {
                        ProgressBar();
                        const string message2 = "La edición del cliente se registro exitosamente.";
                        const string caption2 = "Éxito";
                        var result2 = MessageBox.Show(message2, caption2,
                                                     MessageBoxButtons.OK,
                                                     MessageBoxIcon.Asterisk);
                        LimpiarCampos();
                        BuscarTodasLasEmpresas();
                    }
                }
                if (Funcion == 1)
                {

                    bool Exito = ClienteNeg.GurdarCliente(_cliente);
                    if (Exito == true)
                    {
                        ProgressBar();
                        const string message2 = "Se registro el cliente exitosamente.";
                        const string caption2 = "Éxito";
                        var result2 = MessageBox.Show(message2, caption2,
                                                     MessageBoxButtons.OK,
                                                     MessageBoxIcon.Asterisk);
                        LimpiarCampos();
                        BuscarTodasLasEmpresas();
                    }
                    else
                    {
                        const string message2 = "No se pudo registrar la empresa ingresada.";
                        const string caption2 = "Atención";
                        var result2 = MessageBox.Show(message2, caption2,
                                                     MessageBoxButtons.OK,
                                                     MessageBoxIcon.Asterisk);
                    }
                }
            }
            catch { }
        }
        private void CargarComboLocalidad()
        {
            List<string> Localidades = new List<string>();
            Localidades = ClienteNeg.CargarComboLocalidades();
            cmbLocalidad.Items.Clear();
            cmbLocalidad.Text = "Seleccione";
            cmbLocalidad.Items.Add("Seleccione");
            foreach (string item in Localidades)
            {
                cmbLocalidad.Text = "Seleccione";
                cmbLocalidad.Items.Add(item);
            }
        }
        private void CargarComboProvincia()
        {
            List<string> Provincia = new List<string>();
            Provincia = ClienteNeg.CargarComboProvincia();
            cmbProvincia.Items.Clear();
            cmbProvincia.Text = "Seleccione";
            cmbProvincia.Items.Add("Seleccione");
            foreach (string item in Provincia)
            {
                cmbProvincia.Text = "Seleccione";
                cmbProvincia.Items.Add(item);
            }
        }
        private void CargarComboCondicion()
        {
            string[] Condicion = Clases_Maestras.ValoresConstantes.CondicionAntiAfip;
            cmbCondicionAntiAfip.Items.Add("Seleccione");
            cmbCondicionAntiAfip.Items.Clear();
            foreach (string item in Condicion)
            {
                cmbCondicionAntiAfip.Text = "Seleccione";
                cmbCondicionAntiAfip.Items.Add(item);
            }
        }
        private void LimpiarCampos()
        {
            txtNombreRazonSocial.Clear();
            txtCuit.Clear();
            txtActividad.Clear();
            CargarComboCondicion();
            txtCodArea.Clear();
            txtTelefono.Clear();
            txtEmail.Clear();
            txtCalle.Clear();
            txtAltura.Clear();
            txtCodigoPostal.Clear();
            DateTime fecha = DateTime.Now;
            dtFechaInscripcion.Value = fecha;
            CargarComboProvincia();
            cmbLocalidad.Text = "Seleccione";
            progressBar1.Value = Convert.ToInt32(null);
            progressBar1.Visible = false;
        }
        private Cliente CargarEntidad()
        {
            Cliente _cliente = new Cliente();
            _cliente.NombreRazonSocial = txtNombreRazonSocial.Text;
            _cliente.Cuit = txtCuit.Text;
            _cliente.Actividad = txtActividad.Text;
            DateTime fecha = dtFechaInscripcion.Value;
            _cliente.FechaDeInscripcion = fecha;
            _cliente.CondicionAntiAfip = cmbCondicionAntiAfip.Text;
            string telefono = txtCodArea.Text + "-" + txtTelefono.Text;
            _cliente.Telefono = telefono;
            _cliente.Email = txtEmail.Text;
            ////// Datos del domicilio
            _cliente.Provincia = cmbProvincia.Text;
            _cliente.Localidad = cmbLocalidad.Text;
            _cliente.Calle = txtCalle.Text;
            _cliente.Altura = txtAltura.Text;
            _cliente.CodigoPostal = txtCodigoPostal.Text;
            int idusuarioLogueado = Sesion.UsuarioLogueado.IdUsuario;
            _cliente.idUsuario = idusuarioLogueado;
            return _cliente;
        }
        private void ProgressBar()
        {
            progressBar1.Visible = true;
            progressBar1.Maximum = 100000;
            progressBar1.Step = 1;

            for (int j = 0; j < 100000; j++)
            {
                Caluculate(j);
                progressBar1.PerformStep();
            }
        }
        private void Caluculate(int i)
        {
            double pow = Math.Pow(i, i);
        }
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            LimpiarCamposBotonNuevoCliente();
            Funcion = 1;
        }
        private void LimpiarCamposBotonNuevoCliente()
        {
            PanelRegistroPlan.Enabled = true;
            txtNombreRazonSocial.Clear();
            txtCuit.Clear();
            txtActividad.Clear();
            DateTime fecha = DateTime.Now;
            dtFechaInscripcion.Value = fecha;
            CargarComboCondicion();
            progressBar1.Value = Convert.ToInt32(null);
            progressBar1.Visible = false;
            txtEmail.Clear();
            txtCalle.Clear();
            txtAltura.Clear();
            txtCodigoPostal.Clear();
            txtCodArea.Clear();
            txtTelefono.Clear();
            CargarComboProvincia();
            txtNombreRazonSocial.Focus();
            //CargarComboLocalidad();
        }
        private void dgvTodosLosClientes_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex >= 0 && this.dgvTodosLosClientes.Columns[e.ColumnIndex].Name == "SeleccionarNuevo" && e.RowIndex >= 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                DataGridViewButtonCell BotonVer = this.dgvTodosLosClientes.Rows[e.RowIndex].Cells["SeleccionarNuevo"] as DataGridViewButtonCell;
                Icon icoAtomico = new Icon(Environment.CurrentDirectory + "\\" + @"grifo.ico");
                e.Graphics.DrawIcon(icoAtomico, e.CellBounds.Left + 25, e.CellBounds.Top + 0);
                this.dgvTodosLosClientes.Rows[e.RowIndex].Height = icoAtomico.Height + 3;
                this.dgvTodosLosClientes.Columns[e.ColumnIndex].Width = icoAtomico.Width + 45;
                e.Handled = true;
            }
            if (e.ColumnIndex >= 0 && this.dgvTodosLosClientes.Columns[e.ColumnIndex].Name == "EditarNuevo" && e.RowIndex >= 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                DataGridViewButtonCell BotonVer = this.dgvTodosLosClientes.Rows[e.RowIndex].Cells["EditarNuevo"] as DataGridViewButtonCell;
                Icon icoAtomico = new Icon(Environment.CurrentDirectory + "\\" + @"Editar.ico");
                e.Graphics.DrawIcon(icoAtomico, e.CellBounds.Left + 8, e.CellBounds.Top + 0);
                this.dgvTodosLosClientes.Rows[e.RowIndex].Height = icoAtomico.Height + 3;
                this.dgvTodosLosClientes.Columns[e.ColumnIndex].Width = icoAtomico.Width + 10;
                e.Handled = true;
            }
        }
        private void dgvTodosLosClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvTodosLosClientes.CurrentCell.ColumnIndex == 5)
            {
                int idEmpresa = Convert.ToInt32(this.dgvTodosLosClientes.CurrentRow.Cells[0].Value.ToString());
                string RazonSocial = this.dgvTodosLosClientes.CurrentRow.Cells[1].Value.ToString();
                Sesion.UsuarioLogueado.idEmpresaSeleccionado = idEmpresa;
                Sesion.UsuarioLogueado.EmpresaSeleccionada = RazonSocial;
                MasterNuevaWF frm2 = Application.OpenForms.OfType<MasterNuevaWF>().SingleOrDefault();
                if (frm2 != null)
                {
                    frm2.lblidEmpresa.Text = Convert.ToString(idEmpresa);
                    frm2.lblEmpresa.Text = RazonSocial;
                    frm2.grbEmpresaSeleccionada.Visible = true;
                    Hide();
                }
            }
            if (dgvTodosLosClientes.CurrentCell.ColumnIndex == 6)
            {
                Funcion = 2;
                PanelRegistroPlan.Enabled = true;
                List<Cliente> _cliente = new List<Cliente>();
                var cuit = dgvTodosLosClientes.CurrentRow.Cells[2].Value.ToString();
                _cliente = ClienteNeg.BuscarClientePorCuit(cuit);
                if (_cliente.Count > 0)
                {
                    var cliente = _cliente.First();
                    txtNombreRazonSocial.Text = cliente.NombreRazonSocial;
                    txtCuit.Text = cliente.Cuit;
                    txtActividad.Text = cliente.Actividad;
                    var tel = cliente.Telefono;
                    string varTel = tel;
                    if (varTel != "")
                    {
                        var split1 = varTel.Split('-')[0];
                        var split2 = varTel.Split('-')[1];
                        split1 = split1.Trim();
                        split2 = split2.Trim();
                        txtCodArea.Text = split1;
                        txtTelefono.Text = split2;
                    }
                    txtEmail.Text = cliente.Email;
                    txtCalle.Text = cliente.Calle;
                    txtAltura.Text = cliente.Altura;
                    txtCodigoPostal.Text = cliente.CodigoPostal;
                    cmbCondicionAntiAfip.Text = cliente.CondicionAntiAfip;
                    cmbProvincia.Text = cliente.Provincia;
                    cmbLocalidad.Text = cliente.Localidad;
                    txtCuit.Enabled = false;
                }
            }
        }
        private void txtBuscarRazonSocial_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    BuscarRazonSocial();
                }
                catch (Exception ex)
                { }
            }

        }
        private void txtCuitBuscar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    BuscarRazonSocial();
                }
                catch (Exception ex)
                { }
            }

        }
        private void cmbProvincia_Click(object sender, EventArgs e)
        {
            try
            {
                string var = cmbProvincia.Text;
                if (var != "Seleccione")
                {
                    var split1 = var.Split(',')[0];
                    split1 = split1.Trim();
                    int idProvinciaSeleccionada = Convert.ToInt32(split1);


                    List<string> Localidades = new List<string>();
                    Localidades = ClienteNeg.CargarComboLocalidadesPorIdProvincia(idProvinciaSeleccionada);
                    cmbLocalidad.Items.Clear();
                    cmbLocalidad.Text = "Seleccione";
                    cmbLocalidad.Items.Add("Seleccione");
                    foreach (string item in Localidades)
                    {
                        cmbLocalidad.Text = "Seleccione";
                        cmbLocalidad.Items.Add(item);
                    }
                    this.cmbLocalidad.Enabled = true;

                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void SoloNumeros(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }
            // solo 1 punto decimal
            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }
            //e.Handled = !char.IsNumber(e.KeyChar) && e.KeyChar != Convert.ToChar(Keys.Back);
        }
    }
}



