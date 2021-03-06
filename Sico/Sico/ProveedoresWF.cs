﻿using Sico.Entidades;
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
    public partial class ProveedoresWF : Form
    {
        public ProveedoresWF()
        {
            InitializeComponent();
        }

        private void ProveedoresWF_Load(object sender, EventArgs e)
        {
        }

        #region Funciones
        private void FuncionesBotonHabilitarBuscar()
        {
            //btnHabilitarBuscar.Visible = false;
            grbFiltros.Visible = true;
        }
        private void SoloNumeros(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsNumber(e.KeyChar) && e.KeyChar != Convert.ToChar(Keys.Back);
        }
        private void FuncionesBotonCancelar()
        {
            txtNombreRazonSocial.Clear();
            txtCuit.Clear();
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
            chcFacturaA.Checked = false;
            chcFacturaB.Checked = false;
            chcFacturaC.Checked = false;
        }
        private void FuncionesBotonNuevoProveedor()
        {
            //chcPorNombreRazonSocial.Checked = false;
            //chcPorCuit.Checked = false;
            txtBuscar.Clear();
            grbFiltros.Visible = false;
            LimpiarCamposBotonNuevoCliente();
            groupBox1.Enabled = true;
            txtNombreRazonSocial.Focus();
            groupBox1.Text = "Nuevo Proveedor";
            //btnHabilitarBuscar.Visible = true;
            txtCuit.Enabled = true;
        }
        private void FuncionesBotonEditar()
        {
            groupBox1.Enabled = true;
            groupBox1.Text = "Editar Proveedor";
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
            //if (chcPorCuit.Checked == true)
            //{
            txtBuscar.Clear();
            txtBuscar.Visible = false;
            txtCuitBuscar.Visible = true;
            //chcPorNombreRazonSocial.Checked = false;
            lblDniOApellidoNombre.Text = "Buscar Por Cuit(*):";
            txtBuscar.Focus();
            //}
        }
        private void chcPorNombreRazonSocial_CheckedChanged(object sender, EventArgs e)
        {
            //if (chcPorNombreRazonSocial.Checked == true)
            //{
            txtCuitBuscar.Clear();
            txtCuitBuscar.Visible = false;
            txtBuscar.Visible = true;
            txtBuscar.AutoCompleteCustomSource = Clases_Maestras.AutoCompleteRazonSocial.Autocomplete();
            txtBuscar.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtBuscar.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtBuscar.Enabled = true;
            //chcPorCuit.Checked = false;
            lblDniOApellidoNombre.Text = "Buscar Por Nombre o Razón Social(*):";
            txtBuscar.Focus();
            // }
        }
        private void LimpiarCamposBotonNuevoCliente()
        {
            txtNombreRazonSocial.Clear();
            txtCuit.Clear();

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
            CargarComboCondicion();
            txtCodArea.Clear();
            txtTelefono.Clear();
            txtEmail.Clear();
            txtCalle.Clear();
            txtAltura.Clear();
            txtCodigoPostal.Clear();
            chcFacturaA.Checked = false;
            chcFacturaB.Checked = false;
            chcFacturaC.Checked = false;
            CargarComboProvincia();
            cmbLocalidad.Text = "Seleccione";
            progressBar1.Value = Convert.ToInt32(null);
            progressBar1.Visible = false;
        }
        private Proveedor CargarEntidad()
        {
            Proveedor _proveedor = new Proveedor();
            _proveedor.NombreRazonSocial = txtNombreRazonSocial.Text;
            _proveedor.Cuit = txtCuit.Text;
            _proveedor.CondicionAntiAfip = cmbCondicionAntiAfip.Text;
            string telefono = txtCodArea.Text + "-" + txtTelefono.Text;
            _proveedor.Telefono = telefono;
            _proveedor.Email = txtEmail.Text;
            ////// Datos del domicilio
            _proveedor.Provincia = cmbProvincia.Text;
            _proveedor.Localidad = cmbLocalidad.Text;
            _proveedor.Calle = txtCalle.Text;
            _proveedor.Altura = txtAltura.Text;
            _proveedor.CodigoPostal = txtCodigoPostal.Text;
            int idusuarioLogueado = Sesion.UsuarioLogueado.IdUsuario;
            _proveedor.idUsuario = idusuarioLogueado;
            string Factura = "";
            if (chcFacturaA.Checked == true)
                Factura = "FacturaA";
            if (chcFacturaB.Checked == true)
                Factura = "FacturaB";
            if (chcFacturaA.Checked == true & chcFacturaB.Checked == true)
                Factura = "FacturaA-FacturaB";
            if (chcFacturaC.Checked == true)
                Factura = "FacturaC";
            _proveedor.Factura = Factura;
            return _proveedor;
        }
        #endregion
        #region Botones

        public static string RazonSocial;
        public static string Cuit;
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                Entidades.Proveedor _proveedor = CargarEntidad();
                if (Funcion == 2)
                {
                    bool Exito = ProveedorNeg.EditarProvvedor(_proveedor);
                    if (Exito == true)
                    {
                        ProgressBar();
                        const string message2 = "La edición del proveedor se registro exitosamente.";
                        const string caption2 = "Éxito";
                        var result2 = MessageBox.Show(message2, caption2,
                                                     MessageBoxButtons.OK,
                                                     MessageBoxIcon.Asterisk);
                        LimpiarCampos();
                    }
                }
                else
                {

                    bool Exito = ProveedorNeg.GurdarProveedor(_proveedor);
                    if (Exito == true)
                    {
                        ProgressBar();
                        const string message2 = "Se registro el proveedor exitosamente.";
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
                FuncionesBotonNuevoProveedor();

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
        public static int Funcion = 1;
        ///// Funcion 1 Nuevo
        ///// Funcion 2 Editar
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtCuitBuscar.Text != "  -        -")
                {
                    List<Proveedor> _cliente = new List<Proveedor>();
                    var cuit = txtCuitBuscar.Text;
                    _cliente = ProveedorNeg.BuscarProveedorPorCuit(cuit);

                    if (_cliente.Count > 0)
                    {
                        Funcion = 2;
                        var proveedor = _cliente.First();
                        RazonSocial = proveedor.NombreRazonSocial;
                        Cuit = proveedor.Cuit;
                        txtNombreRazonSocial.Text = proveedor.NombreRazonSocial;
                        txtCuit.Text = proveedor.Cuit;
                        var tel = proveedor.Telefono;
                        string var = tel;
                        var split1 = var.Split('-')[0];
                        var split2 = var.Split('-')[1];
                        split1 = split1.Trim();
                        split2 = split2.Trim();
                        txtCodArea.Text = split1;
                        txtTelefono.Text = split2;
                        txtEmail.Text = proveedor.Email;
                        txtCalle.Text = proveedor.Calle;
                        txtAltura.Text = proveedor.Altura;
                        txtCodigoPostal.Text = proveedor.CodigoPostal;
                        CargarCombo();
                        cmbCondicionAntiAfip.Text = proveedor.CondicionAntiAfip;
                        cmbProvincia.Text = proveedor.Provincia;
                        cmbLocalidad.Text = proveedor.Localidad;
                        txtCuit.Enabled = false;
                    }
                    else
                    {
                        txtBuscar.Focus();
                        const string message = "No existe ningún proveedor con el cuit ingresado.";
                        const string caption = "Atención";
                        var result = MessageBox.Show(message, caption,
                                                     MessageBoxButtons.OK,
                                                   MessageBoxIcon.Exclamation);
                        throw new Exception();
                    }
                }
                else
                {
                    List<Proveedor> _proveedor = new List<Proveedor>();
                    var nombreRazonSocial = txtBuscar.Text;
                    _proveedor = ProveedorNeg.BuscarProveedorPorNombreRazonSocial(nombreRazonSocial);
                    if (_proveedor.Count > 0)
                    {
                        Funcion = 2;
                        var proveedor = _proveedor.First();
                        RazonSocial = proveedor.NombreRazonSocial;
                        Cuit = proveedor.Cuit;
                        txtNombreRazonSocial.Text = proveedor.NombreRazonSocial;
                        txtCuit.Text = proveedor.Cuit;
                        var tel = proveedor.Telefono;
                        string var = tel;
                        var split1 = var.Split('-')[0];
                        var split2 = var.Split('-')[1];
                        split1 = split1.Trim();
                        split2 = split2.Trim();
                        txtCodArea.Text = split1;
                        txtTelefono.Text = split2;
                        txtEmail.Text = proveedor.Email;
                        txtCalle.Text = proveedor.Calle;
                        txtAltura.Text = proveedor.Altura;
                        txtCodigoPostal.Text = proveedor.CodigoPostal;
                        CargarCombo();
                        cmbCondicionAntiAfip.Text = proveedor.CondicionAntiAfip;
                        cmbProvincia.Text = proveedor.Provincia;
                        cmbLocalidad.Text = proveedor.Localidad;
                        txtCuit.Enabled = false;
                        var fac = proveedor.Factura;
                        if (fac.Length > 8)
                        {
                            string Fact = fac;
                            var splitFactura1 = Fact.Split('-')[0];
                            var splitFactura2 = Fact.Split('-')[1];
                            splitFactura1 = splitFactura1.Trim();
                            splitFactura2 = splitFactura2.Trim();
                            chcFacturaA.Checked = true;
                            chcFacturaB.Checked = true;
                        }
                        if (fac.Length <= 8)
                        {
                            string Fact = fac;
                            if (Fact == "FacturaA")
                            { chcFacturaA.Checked = true; }
                            if (Fact == "FacturaB")
                            { chcFacturaB.Checked = true; }
                            if (Fact == "FacturaC")
                            { chcFacturaC.Checked = true; }
                        }

                    }
                    else
                    {
                        Funcion = 1;
                        txtBuscar.Focus();
                        const string message = "No existe ningún proveedor con el nombre o razón social ingresado.";
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
            //TareaClienteWF _tarea = new TareaClienteWF(RazonSocial, Cuit);
            //_tarea.Show();
            //Hide();
        }
        #endregion
        private void chcFacturaC_CheckedChanged(object sender, EventArgs e)
        {
            if (chcFacturaC.Checked == true)
            {
                chcFacturaA.Checked = false;
                chcFacturaB.Checked = false;
            }
        }
        private void chcFacturaB_CheckedChanged(object sender, EventArgs e)
        {
            if (chcFacturaB.Checked == true)
            {
                chcFacturaC.Checked = false;
            }
        }
        private void chcFacturaA_CheckedChanged(object sender, EventArgs e)
        {
            if (chcFacturaA.Checked == true)
            {
                chcFacturaC.Checked = false;
            }
        }

        private void chcPorCuit_CheckedChanged_1(object sender, EventArgs e)
        {
            //if (chcPorCuit.Checked == true)
            //{
            txtBuscar.Clear();
            txtBuscar.Visible = false;
            txtCuitBuscar.Visible = true;
            //chcPorNombreRazonSocial.Checked = false;
            lblDniOApellidoNombre.Text = "Buscar Por Cuit(*):";
            txtBuscar.Focus();
            //}
        }
        private void chcPorNombreRazonSocial_CheckedChanged_1(object sender, EventArgs e)
        {
            //if (chcPorNombreRazonSocial.Checked == true)
            //{
            txtCuitBuscar.Clear();
            txtCuitBuscar.Visible = false;
            txtBuscar.Visible = true;
            txtBuscar.AutoCompleteCustomSource = Clases_Maestras.AutoCompleteClassProveedores.Autocomplete(Sesion.UsuarioLogueado.idEmpresaSeleccionado);
            txtBuscar.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtBuscar.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtBuscar.Enabled = true;
            //chcPorCuit.Checked = false;
            lblDniOApellidoNombre.Text = "Buscar Por Nombre o Razón Social(*):";
            txtBuscar.Focus();
            //}
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
        private void btnCompras_Click(object sender, EventArgs e)
        {
            //string RazonSocial = razonSocial;
            //string Cuit = cuit;
            //ComprasWF _compras = new ComprasWF(RazonSocial, Cuit);
            //_compras.Show();
            //Hide();
        }

        private void btnHistorial_Click_1(object sender, EventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void btnHabilitarBusqueda_Click(object sender, EventArgs e)
        {
            grbFiltros.Visible = true;
            txtCuitBuscar.Focus();
            txtBuscar.AutoCompleteCustomSource = Clases_Maestras.AutoCompleteClassProveedores.Autocomplete(Sesion.UsuarioLogueado.idEmpresaSeleccionado);
            txtBuscar.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtBuscar.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        private void btnCrearSubCliente_Click(object sender, EventArgs e)
        {
            try
            {
                LimpiarCampos();
                Funcion = 1;
                txtCuitBuscar.Clear();
                txtBuscar.Clear();
                groupBox1.Enabled = true;
                txtNombreRazonSocial.Focus();
                CargarCombo();
            }
            catch (Exception ex)
            { }
        }
        private void CargarCombo()
        {
            string[] Condicion = Clases_Maestras.ValoresConstantes.CondicionAntiAfip;
            cmbCondicionAntiAfip.Items.Add("Seleccione");
            cmbCondicionAntiAfip.Items.Clear();
            foreach (string item in Condicion)
            {
                cmbCondicionAntiAfip.Text = "Seleccione";
                cmbCondicionAntiAfip.Items.Add(item);
            }
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
    }
}
