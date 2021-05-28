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
                if (txtCuitBuscar.Text != "")
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
            dgvTodosLosClientes.Columns.Clear();
            dgvTodosLosClientes.DataSource = null;
            dgvTodosLosClientes.Visible = false;
            //lblCantidad.Visible = false;
            //lblCantidadEdit.Visible = false;
            List<Cliente> _cliente = new List<Cliente>();
            var nombreRazonSocial = txtBuscarRazonSocial.Text;
            _cliente = ClienteNeg.BuscarClientePorNombreRazonSocial(nombreRazonSocial);
            if (_cliente.Count > 0)
            {
                foreach (var item in _cliente)
                {
                    dgvTodosLosClientes.Rows.Add(item.IdCliente, item.NombreRazonSocial, item.Cuit, item.Actividad, item.CondicionAntiAfip);
                }
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
            dgvTodosLosClientes.Columns.Clear();
            dgvTodosLosClientes.Visible = false;
            List<Cliente> _cliente = new List<Cliente>();
            var cuit = txtCuitBuscar.Text;
            _cliente = ClienteNeg.BuscarClientePorCuit(cuit);
            if (_cliente.Count > 0)
            {
                foreach (var item in _cliente)
                {
                    dgvTodosLosClientes.Rows.Add(item.IdCliente, item.NombreRazonSocial, item.Cuit, item.Actividad, item.CondicionAntiAfip);
                }
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
            List<Entidades.Cliente> ListarClientes = ClienteNeg.ListarTodosLosClientes();
            if (ListarClientes.Count > 0)
            {
                foreach (var item in ListarClientes)
                {
                    dgvTodosLosClientes.Visible = true;
                    dgvTodosLosClientes.Rows.Add(item.IdCliente, item.NombreRazonSocial, item.Cuit, item.Actividad, item.CondicionAntiAfip);
                }
                dgvTodosLosClientes.AllowUserToAddRows = false;
            }
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
            PanelRegistroEmpresa.Enabled = true;
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
            if (e.ColumnIndex >= 0 && this.dgvTodosLosClientes.Columns[e.ColumnIndex].Name == "Seleccionar" && e.RowIndex >= 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                DataGridViewButtonCell BotonVer = this.dgvTodosLosClientes.Rows[e.RowIndex].Cells["Seleccionar"] as DataGridViewButtonCell;
                Icon icoAtomico = new Icon(Environment.CurrentDirectory + "\\" + @"Editar.ico");
                e.Graphics.DrawIcon(icoAtomico, e.CellBounds.Left + 5, e.CellBounds.Top + 5);
                this.dgvTodosLosClientes.Rows[e.RowIndex].Height = icoAtomico.Height + 6;
                this.dgvTodosLosClientes.Columns[e.ColumnIndex].Width = icoAtomico.Width + 15;
                e.Handled = true;
            }
            if (e.ColumnIndex >= 0 && this.dgvTodosLosClientes.Columns[e.ColumnIndex].Name == "Editar" && e.RowIndex >= 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                DataGridViewButtonCell BotonVer = this.dgvTodosLosClientes.Rows[e.RowIndex].Cells["Editar"] as DataGridViewButtonCell;
                Icon icoAtomico = new Icon(Environment.CurrentDirectory + "\\" + @"Eliminar.ico");
                e.Graphics.DrawIcon(icoAtomico, e.CellBounds.Left + 5, e.CellBounds.Top + 5);
                this.dgvTodosLosClientes.Rows[e.RowIndex].Height = icoAtomico.Height + 6;
                this.dgvTodosLosClientes.Columns[e.ColumnIndex].Width = icoAtomico.Width + 15;
                e.Handled = true;
            }
        }
        private void dgvTodosLosClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvTodosLosClientes.CurrentCell.ColumnIndex == 5)
            {
                //var idsubCliente = Convert.ToString(this.dgvTodosLosClientes.CurrentRow.Cells[0].Value);
                string RazonSocial = this.dgvTodosLosClientes.CurrentRow.Cells[1].Value.ToString();
                string Cuit = this.dgvTodosLosClientes.CurrentRow.Cells[2].Value.ToString();
                MenuClienteWF _tarea = new MenuClienteWF(RazonSocial, Cuit);
                _tarea.Show();
                Hide();
            }
            if (dgvTodosLosClientes.CurrentCell.ColumnIndex == 6)
            {
                PanelRegistroEmpresa.Enabled = true;
                List<Cliente> _cliente = new List<Cliente>();
                var cuit = dgvTodosLosClientes.CurrentRow.Cells[2].Value.ToString();
                _cliente = ClienteNeg.BuscarClientePorCuit(cuit);
                if (_cliente.Count > 0)
                {
                    dgvTodosLosClientes.Visible = false;
                    var cliente = _cliente.First();
                    //RazonSocial = cliente.NombreRazonSocial;
                    //Cuit = cliente.Cuit;
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
    }
}



