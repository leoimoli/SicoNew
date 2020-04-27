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
using Sico.Entidades;

namespace Sico
{
    public partial class ClienteWF : MasterWF
    {
        public ClienteWF()
        {
            InitializeComponent();
        }
        private void ClienteWF_Load(object sender, EventArgs e)
        {
            if (chcTodosLosClientes.Checked == true)
            {
                ListarClientes = ClienteNeg.ListarTodosLosClientes();
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
        #region Funciones
        private void FuncionesBotonHabilitarBuscar()
        {
            btnHabilitarBuscar.Visible = false;
            groupBox3.Visible = true;
            dgvTodosLosClientes.Columns.Clear();
            dgvTodosLosClientes.Visible = false;
        }
        private void SoloNumeros(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsNumber(e.KeyChar) && e.KeyChar != Convert.ToChar(Keys.Back);
        }
        private void FuncionesBotonCancelar()
        {
            txtNombreRazonSocial.Clear();
            txtCuit.Clear();
            txtActividad.Clear();
            DateTime fecha = DateTime.Now;
            dtFechaInscripcion.Value = fecha;
            CargarComboCondicion();
            groupBox1.Enabled = false;
            txtEmail.Clear();
            txtCalle.Clear();
            txtAltura.Clear();
            txtCodigoPostal.Clear();
            txtCodArea.Clear();
            txtTelefono.Clear();
            CargarComboProvincia();
            CargarComboLocalidad();
        }
        private void FuncionesBotonNuevoCliente()
        {
            chcPorNombreRazonSocial.Checked = false;
            chcPorCuit.Checked = false;
            txtBuscar.Clear();
            groupBox3.Visible = false;
            LimpiarCamposBotonNuevoCliente();
            groupBox1.Enabled = true;
            txtNombreRazonSocial.Focus();
            groupBox1.Text = "Nuevo Usuario";
            btnHabilitarBuscar.Visible = true;
        }
        private void FuncionesBotonEditar()
        {
            groupBox1.Enabled = true;
            groupBox1.Text = "Editar Usuario";
            txtActividad.Focus();
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
        private void chcPorCuit_CheckedChanged(object sender, EventArgs e)
        {
            if (chcPorCuit.Checked == true)
            {
                txtBuscar.Clear();
                txtBuscar.Visible = false;
                txtCuitBuscar.Visible = true;
                chcPorNombreRazonSocial.Checked = false;
                chcTodosLosClientes.Checked = false;
                lblDniOApellidoNombre.Visible = true;
                lblDniOApellidoNombre.Text = "Buscar Por Cuit(*):";
                txtBuscar.Focus();
            }
        }
        private void chcPorNombreRazonSocial_CheckedChanged(object sender, EventArgs e)
        {
            if (chcPorNombreRazonSocial.Checked == true)
            {
                txtCuitBuscar.Clear();
                txtCuitBuscar.Visible = false;
                txtBuscar.Visible = true;
                txtBuscar.AutoCompleteCustomSource = Clases_Maestras.AutoCompleteRazonSocial.Autocomplete();
                txtBuscar.AutoCompleteMode = AutoCompleteMode.Suggest;
                txtBuscar.AutoCompleteSource = AutoCompleteSource.CustomSource;
                txtBuscar.Enabled = true;
                chcPorCuit.Checked = false;
                chcTodosLosClientes.Checked = false;
                lblDniOApellidoNombre.Visible = true;
                lblDniOApellidoNombre.Text = "Buscar Por Nombre o Razón Social(*):";
                txtBuscar.Focus();
            }
        }
        private void LimpiarCamposBotonNuevoCliente()
        {
            txtNombreRazonSocial.Clear();
            txtCuit.Clear();
            txtActividad.Clear();
            DateTime fecha = DateTime.Now;
            dtFechaInscripcion.Value = fecha;
            CargarComboCondicion();
            progressBar1.Value = Convert.ToInt32(null);
            progressBar1.Visible = false;
            groupBox1.Enabled = false;
            txtEmail.Clear();
            txtCalle.Clear();
            txtAltura.Clear();
            txtCodigoPostal.Clear();
            txtCodArea.Clear();
            txtTelefono.Clear();
            CargarComboProvincia();
            //CargarComboLocalidad();
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
            groupBox1.Enabled = false;
            groupBox4.Enabled = false;
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
        #endregion
        #region Botones

        public static string RazonSocial;
        public static string Cuit;
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                Entidades.Cliente _cliente = CargarEntidad();
                if (groupBox3.Visible == true)
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
                    }
                }
                else
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
                    }
                    else
                    {

                    }
                }
            }
            catch { }
        }
        private void btnNuevoCliente_Click(object sender, EventArgs e)
        {
            try
            {
                FuncionesBotonNuevoCliente();

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
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            try
            {
                FuncionesBotonCancelar();
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
        private void btnHabilitarBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                FuncionesBotonHabilitarBuscar();
            }
            catch (Exception ex)
            {

            }
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                if (chcPorCuit.Checked == true)
                {
                    dgvTodosLosClientes.Columns.Clear();
                    dgvTodosLosClientes.Visible = false;
                    lblCantidad.Visible = false;
                    lblCantidadEdit.Visible = false;
                    List<Cliente> _cliente = new List<Cliente>();
                    var cuit = txtCuitBuscar.Text;
                    _cliente = ClienteNeg.BuscarClientePorCuit(cuit);

                    if (_cliente.Count > 0)
                    {
                        var cliente = _cliente.First();
                        RazonSocial = cliente.NombreRazonSocial;
                        Cuit = cliente.Cuit;
                        txtNombreRazonSocial.Text = cliente.NombreRazonSocial;
                        txtCuit.Text = cliente.Cuit;
                        txtActividad.Text = cliente.Actividad;
                        var tel = cliente.Telefono;
                        string var = tel;
                        var split1 = var.Split('-')[0];
                        var split2 = var.Split('-')[1];
                        split1 = split1.Trim();
                        split2 = split2.Trim();
                        txtCodArea.Text = split1;
                        txtTelefono.Text = split2;
                        txtEmail.Text = cliente.Email;
                        txtCalle.Text = cliente.Calle;
                        txtAltura.Text = cliente.Altura;
                        txtCodigoPostal.Text = cliente.CodigoPostal;
                        cmbCondicionAntiAfip.Text = cliente.CondicionAntiAfip;
                        cmbProvincia.Text = cliente.Provincia;
                        cmbLocalidad.Text = cliente.Localidad;
                        txtCuit.Enabled = false;
                        btnEditar.Visible = true;
                        btnEliminar.Visible = true;
                        btnHistorial.Visible = true;
                    }
                    else
                    {
                        txtBuscar.Focus();
                        const string message = "No existe ningun cliente con el cuit ingresado.";
                        const string caption = "Atención";
                        var result = MessageBox.Show(message, caption,
                                                     MessageBoxButtons.OK,
                                                   MessageBoxIcon.Exclamation);
                        throw new Exception();
                    }
                }
                if (chcPorNombreRazonSocial.Checked == true)
                {
                    dgvTodosLosClientes.Columns.Clear();
                    dgvTodosLosClientes.DataSource = null;
                    dgvTodosLosClientes.Visible = false;
                    lblCantidad.Visible = false;
                    lblCantidadEdit.Visible = false;
                    List<Cliente> _cliente = new List<Cliente>();
                    var nombreRazonSocial = txtBuscar.Text;
                    _cliente = ClienteNeg.BuscarClientePorNombreRazonSocial(nombreRazonSocial);
                    if (_cliente.Count > 0)
                    {
                        var cliente = _cliente.First();
                        RazonSocial = cliente.NombreRazonSocial;
                        Cuit = cliente.Cuit;
                        txtNombreRazonSocial.Text = cliente.NombreRazonSocial;
                        txtCuit.Text = cliente.Cuit;
                        txtActividad.Text = cliente.Actividad;
                        var tel = cliente.Telefono;
                        string var = tel;
                        var split1 = var.Split('-')[0];
                        var split2 = var.Split('-')[1];
                        split1 = split1.Trim();
                        split2 = split2.Trim();
                        txtCodArea.Text = split1;
                        txtTelefono.Text = split2;
                        txtEmail.Text = cliente.Email;
                        txtCalle.Text = cliente.Calle;
                        txtAltura.Text = cliente.Altura;
                        txtCodigoPostal.Text = cliente.CodigoPostal;
                        cmbCondicionAntiAfip.Text = cliente.CondicionAntiAfip;
                        cmbProvincia.Text = cliente.Provincia;
                        cmbLocalidad.Text = cliente.Localidad;
                        txtCuit.Enabled = false;
                        btnEditar.Visible = true;
                        btnEliminar.Visible = true;
                        btnHistorial.Visible = true;
                    }
                    else
                    {
                        txtBuscar.Focus();
                        const string message = "No existe ningun cliente con el nombre o razón social ingresado.";
                        const string caption = "Atención";
                        var result = MessageBox.Show(message, caption,
                                                     MessageBoxButtons.OK,
                                                   MessageBoxIcon.Exclamation);
                        throw new Exception();
                    }
                }

                if (chcTodosLosClientes.Checked == true)
                {
                    ListarClientes = ClienteNeg.ListarTodosLosClientes();
                }
            }
            catch (Exception ex)
            {

            }
        }
        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                FuncionesBotonEditar();

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
        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }
        private void btnHistorial_Click(object sender, EventArgs e)
        {
            MenuClienteWF _tarea = new MenuClienteWF(RazonSocial, Cuit);
            _tarea.Show();
            Hide();
        }

        #endregion
        public List<Entidades.Cliente> ListarClientes
        {
            set
            {
                if (value.Count > 0)
                {
                    lblDniOApellidoNombre.Visible = false;
                    dgvTodosLosClientes.Columns.Clear();
                    groupBox1.Enabled = true;
                    groupBox1.Text = "Listado de Clientes";
                    groupBox3.Visible = true;
                    lblCantidad.Visible = true;
                    lblCantidadEdit.Visible = true;
                    lblCantidadEdit.Text = Convert.ToString(value.Count);
                    dgvTodosLosClientes.Visible = true;
                    dgvTodosLosClientes.ReadOnly = true;
                    dgvTodosLosClientes.RowHeadersVisible = false;
                    dgvTodosLosClientes.DataSource = value;

                    dgvTodosLosClientes.Columns[0].HeaderText = "Id Cliente";
                    dgvTodosLosClientes.Columns[0].Width = 80;
                    dgvTodosLosClientes.Columns[0].HeaderCell.Style.BackColor = Color.DarkBlue;
                    dgvTodosLosClientes.Columns[0].HeaderCell.Style.Font = new System.Drawing.Font("Tahoma", 10, FontStyle.Bold);
                    dgvTodosLosClientes.Columns[0].HeaderCell.Style.ForeColor = Color.White;

                    dgvTodosLosClientes.Columns[1].HeaderText = "Nombre o Razón Social";
                    dgvTodosLosClientes.Columns[1].Width = 230;
                    dgvTodosLosClientes.Columns[1].HeaderCell.Style.BackColor = Color.DarkBlue;
                    dgvTodosLosClientes.Columns[1].HeaderCell.Style.Font = new System.Drawing.Font("Tahoma", 10, FontStyle.Bold);
                    dgvTodosLosClientes.Columns[1].HeaderCell.Style.ForeColor = Color.White;

                    dgvTodosLosClientes.Columns[2].HeaderText = "Cuit";
                    dgvTodosLosClientes.Columns[2].Width = 150;
                    dgvTodosLosClientes.Columns[2].HeaderCell.Style.BackColor = Color.DarkBlue;
                    dgvTodosLosClientes.Columns[2].HeaderCell.Style.Font = new System.Drawing.Font("Tahoma", 10, FontStyle.Bold);
                    dgvTodosLosClientes.Columns[2].HeaderCell.Style.ForeColor = Color.White;

                    dgvTodosLosClientes.Columns[3].HeaderText = "Actividad";
                    dgvTodosLosClientes.Columns[3].Width = 160;
                    dgvTodosLosClientes.Columns[3].HeaderCell.Style.BackColor = Color.DarkBlue;
                    dgvTodosLosClientes.Columns[3].HeaderCell.Style.Font = new System.Drawing.Font("Tahoma", 10, FontStyle.Bold);
                    dgvTodosLosClientes.Columns[3].HeaderCell.Style.ForeColor = Color.White;

                    dgvTodosLosClientes.Columns[4].HeaderText = "Fecha";
                    dgvTodosLosClientes.Columns[4].Width = 80;
                    dgvTodosLosClientes.Columns[4].HeaderCell.Style.BackColor = Color.DarkBlue;
                    dgvTodosLosClientes.Columns[4].HeaderCell.Style.Font = new System.Drawing.Font("Tahoma", 10, FontStyle.Bold);
                    dgvTodosLosClientes.Columns[4].HeaderCell.Style.ForeColor = Color.White;
                    dgvTodosLosClientes.Columns[4].Visible = false;

                    dgvTodosLosClientes.Columns[5].HeaderText = "Condición";
                    dgvTodosLosClientes.Columns[5].Width = 150;
                    dgvTodosLosClientes.Columns[5].HeaderCell.Style.BackColor = Color.DarkBlue;
                    dgvTodosLosClientes.Columns[5].HeaderCell.Style.Font = new System.Drawing.Font("Tahoma", 10, FontStyle.Bold);
                    dgvTodosLosClientes.Columns[5].HeaderCell.Style.ForeColor = Color.White;
                    dgvTodosLosClientes.Columns[5].Visible = true;

                    dgvTodosLosClientes.Columns[6].HeaderText = "Telefono";
                    dgvTodosLosClientes.Columns[6].Width = 100;
                    dgvTodosLosClientes.Columns[6].HeaderCell.Style.BackColor = Color.DarkBlue;
                    dgvTodosLosClientes.Columns[6].HeaderCell.Style.Font = new System.Drawing.Font("Tahoma", 10, FontStyle.Bold);
                    dgvTodosLosClientes.Columns[6].HeaderCell.Style.ForeColor = Color.White;
                    dgvTodosLosClientes.Columns[6].Visible = false;

                    dgvTodosLosClientes.Columns[7].HeaderText = "Email";
                    dgvTodosLosClientes.Columns[7].Width = 95;
                    dgvTodosLosClientes.Columns[7].HeaderCell.Style.BackColor = Color.DarkBlue;
                    dgvTodosLosClientes.Columns[7].HeaderCell.Style.Font = new System.Drawing.Font("Tahoma", 10, FontStyle.Bold);
                    dgvTodosLosClientes.Columns[7].HeaderCell.Style.ForeColor = Color.White;
                    dgvTodosLosClientes.Columns[7].Visible = false;

                    dgvTodosLosClientes.Columns[8].HeaderText = "Provincia";
                    dgvTodosLosClientes.Columns[8].Visible = false;

                    dgvTodosLosClientes.Columns[9].HeaderText = "Localidad";
                    dgvTodosLosClientes.Columns[9].Visible = false;

                    dgvTodosLosClientes.Columns[10].HeaderText = "Calle";
                    dgvTodosLosClientes.Columns[10].Visible = false;

                    dgvTodosLosClientes.Columns[11].HeaderText = "Altura";
                    dgvTodosLosClientes.Columns[11].Visible = false;

                    dgvTodosLosClientes.Columns[12].HeaderText = "Codigo Postal";
                    dgvTodosLosClientes.Columns[12].Visible = false;

                    dgvTodosLosClientes.Columns[13].HeaderText = "id Usuario";
                    dgvTodosLosClientes.Columns[13].Visible = false;

                    DataGridViewButtonColumn BotonVer = new DataGridViewButtonColumn();
                    BotonVer.Name = "Ver";
                    BotonVer.HeaderText = "Ver";
                    this.dgvTodosLosClientes.Columns.Add(BotonVer);
                    dgvTodosLosClientes.Columns[14].Width = 50;
                    dgvTodosLosClientes.Columns[14].HeaderCell.Style.BackColor = Color.DarkBlue;
                    dgvTodosLosClientes.Columns[14].HeaderCell.Style.Font = new Font("Tahoma", 10, FontStyle.Bold);
                    dgvTodosLosClientes.Columns[14].HeaderCell.Style.ForeColor = Color.White;

                    DataGridViewButtonColumn BotonEditar = new DataGridViewButtonColumn();
                    BotonEditar.Name = "Editar";
                    BotonEditar.HeaderText = "Editar";
                    this.dgvTodosLosClientes.Columns.Add(BotonEditar);
                    dgvTodosLosClientes.Columns[15].Width = 100;
                    dgvTodosLosClientes.Columns[15].HeaderCell.Style.BackColor = Color.DarkBlue;
                    dgvTodosLosClientes.Columns[15].HeaderCell.Style.Font = new Font("Tahoma", 10, FontStyle.Bold);
                    dgvTodosLosClientes.Columns[15].HeaderCell.Style.ForeColor = Color.White;
                }
            }
        }
        private void btnEliminar_Click_1(object sender, EventArgs e)
        {

        }
        private void chcTodosLosClientes_CheckedChanged(object sender, EventArgs e)
        {
            if (chcTodosLosClientes.Checked == true)
            {
                txtCuitBuscar.Clear();
                txtCuitBuscar.Visible = false;
                txtBuscar.Visible = false;
                txtBuscar.Enabled = false;
                chcPorCuit.Checked = false;
                chcPorNombreRazonSocial.Checked = false;
                lblDniOApellidoNombre.Visible = false;
                btnBuscar.Focus();
            }
        }

        private void dgvTodosLosClientes_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex >= 0 && this.dgvTodosLosClientes.Columns[e.ColumnIndex].Name == "Ver" && e.RowIndex >= 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                DataGridViewButtonCell BotonVer = this.dgvTodosLosClientes.Rows[e.RowIndex].Cells["Ver"] as DataGridViewButtonCell;
                Icon icoAtomico = new Icon(Environment.CurrentDirectory + "\\" + @"lupa.ico");
                e.Graphics.DrawIcon(icoAtomico, e.CellBounds.Left + 5, e.CellBounds.Top + 5);

                this.dgvTodosLosClientes.Rows[e.RowIndex].Height = icoAtomico.Height + 6;
                this.dgvTodosLosClientes.Columns[e.ColumnIndex].Width = icoAtomico.Width + 6;

                e.Handled = true;
            }
            if (e.ColumnIndex >= 0 && this.dgvTodosLosClientes.Columns[e.ColumnIndex].Name == "Editar" && e.RowIndex >= 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                DataGridViewButtonCell BotonVer = this.dgvTodosLosClientes.Rows[e.RowIndex].Cells["Editar"] as DataGridViewButtonCell;
                Icon icoAtomico = new Icon(Environment.CurrentDirectory + "\\" + @"editar.ico");
                e.Graphics.DrawIcon(icoAtomico, e.CellBounds.Left + 5, e.CellBounds.Top + 5);

                this.dgvTodosLosClientes.Rows[e.RowIndex].Height = icoAtomico.Height + 6;
                this.dgvTodosLosClientes.Columns[e.ColumnIndex].Width = icoAtomico.Width + 6;

                e.Handled = true;
            }
        }

        private void dgvTodosLosClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvTodosLosClientes.CurrentCell.ColumnIndex == 14)
            {
                //var idsubCliente = Convert.ToString(this.dgvTodosLosClientes.CurrentRow.Cells[0].Value);
                string RazonSocial = this.dgvTodosLosClientes.CurrentRow.Cells[1].Value.ToString();
                string Cuit = this.dgvTodosLosClientes.CurrentRow.Cells[2].Value.ToString();
                MenuClienteWF _tarea = new MenuClienteWF(RazonSocial, Cuit);
                _tarea.Show();
                Hide();
            }
            if (dgvTodosLosClientes.CurrentCell.ColumnIndex == 15)
            {
                List<Cliente> _cliente = new List<Cliente>();
                var cuit = dgvTodosLosClientes.CurrentRow.Cells[2].Value.ToString();
                _cliente = ClienteNeg.BuscarClientePorCuit(cuit);
                if (_cliente.Count > 0)
                {
                    dgvTodosLosClientes.Visible = false;
                    var cliente = _cliente.First();
                    RazonSocial = cliente.NombreRazonSocial;
                    Cuit = cliente.Cuit;
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
                    btnEditar.Visible = true;
                    btnEliminar.Visible = true;
                    btnHistorial.Visible = true;
                }
            }
        }
    }
}

