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
                else
                {
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
            TareaClienteWF _tarea = new TareaClienteWF(RazonSocial, Cuit);
            _tarea.Show();
            Hide();
        }
        #endregion


    }
}
