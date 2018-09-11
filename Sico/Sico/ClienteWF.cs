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
    public partial class ClienteWF : MasterWF
    {
        public ClienteWF()
        {
            InitializeComponent();
        }
        private void ClienteWF_Load(object sender, EventArgs e)
        {

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
            chcPorApellido.Checked = false;
            chcPorDni.Checked = false;
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
        private void chcPorDni_CheckedChanged(object sender, EventArgs e)
        {
            if (chcPorDni.Checked == true)
            {
                txtBuscar.Enabled = true;
                chcPorApellido.Checked = false;
                lblDniOApellidoNombre.Text = "Buscar Por Dni(*):";
                txtBuscar.Focus();
            }
        }
        private void chcPorApellido_CheckedChanged(object sender, EventArgs e)
        {
            if (chcPorApellido.Checked == true)
            {
                txtBuscar.AutoCompleteCustomSource = Clases_Maestras.AutoCompleClass.Autocomplete();
                txtBuscar.AutoCompleteMode = AutoCompleteMode.Suggest;
                txtBuscar.AutoCompleteSource = AutoCompleteSource.CustomSource;
                txtBuscar.Enabled = true;
                chcPorDni.Checked = false;
                lblDniOApellidoNombre.Text = "Buscar Por Apellido(*):";
                txtBuscar.Focus();
            }
        }
        private void LimpiarCamposBotonNuevoCliente()
        {
            //txtDniBuscar.Clear();
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
            CargarComboLocalidad();
        }
        private void CargarComboLocalidad()
        {
            throw new NotImplementedException();
        }
        private void CargarComboProvincia()
        {
            throw new NotImplementedException();
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
        #endregion
        #region Botones
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
        #endregion
    }
}
