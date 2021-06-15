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
using Sico.Negocio;

namespace Sico
{
    public partial class SubClienteWF : Form
    {
        private int idEmpresa;
        private string razonSocial;
        public SubClienteWF(string razonSocial, int idEmpresa)
        {
            InitializeComponent();
            this.razonSocial = razonSocial;
            this.idEmpresa = Sesion.UsuarioLogueado.idEmpresaSeleccionado;
        }
        private void SubClienteWF_Load(object sender, EventArgs e)
        {
            txtApellidoNombreBuscar.Focus();
            txtApellidoNombreBuscar.AutoCompleteCustomSource = Clases_Maestras.AutoCompleteSubCliente.Autocomplete(idEmpresa);
            txtApellidoNombreBuscar.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtApellidoNombreBuscar.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }
        #region Botones        
        private void button1_Click(object sender, EventArgs e)
        {
            TareaClienteWF _tarea = new TareaClienteWF(razonSocial, idEmpresa);
            _tarea.Show();
            Hide();
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }
        private void btnNuevoSubCliente_Click(object sender, EventArgs e)
        {
            try
            {
                txtApellidoNombreBuscar.Clear();
                groupBox1.Enabled = true;
                txtDni.Focus();
            }
            catch (Exception ex)
            { }
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            BuscarSubcliente();
        }

        private void BuscarSubcliente()
        {
            List<Entidades.SubCliente> SubCliente = new List<Entidades.SubCliente>();
            var ApellidoNombre = txtApellidoNombreBuscar.Text;
            var DNI = txtDniBuscar.Text;
            if (ApellidoNombre != "")
            {
                SubCliente = ClienteNeg.BuscarSubClientePorApellidoNombre(ApellidoNombre, idEmpresa);
            }
            if (DNI != "")
            {
                SubCliente = ClienteNeg.BuscarSubClientePorDni(DNI, idEmpresa);

            }
            if (SubCliente.Count > 0)
            {
                groupBox1.Enabled = true;
                txtDni.Enabled = false;
                var subcliente = SubCliente.First();
                txtDni.Text = subcliente.Dni;
                txtApellidoNombre.Text = subcliente.ApellidoNombre;
                string dir = subcliente.Direccion;
                var split3 = dir.Split(' ')[0];
                split3 = split3.Trim();
                string dir2 = subcliente.Direccion;
                int cantidad2 = dir2.Split().Count();
                string valor2 = "";
                string valorFinal2 = "";
                for (int i = 1; i < cantidad2; i++)
                {
                    var split4 = dir2.Split(' ')[i];
                    string split = split4.Trim();
                    valorFinal2 = valor2 + " " + split4;
                    valor2 = split;
                }
                txtCalle.Text = split3;
                txtAltura.Text = valorFinal2;
                txtObservacion.Text = subcliente.Observacion;
                if (subcliente.TipoDNI != "")
                {
                    CargarCombo();
                    cmbTipoDoc.Text = subcliente.TipoDNI;
                }
                else { CargarCombo(); }
               
            }
            else
            {
                txtApellidoNombreBuscar.Clear();
                MessageBox.Show("No se encontraron datos para el cliente ingresado.");
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                Entidades.SubCliente _subCliente = CargarEntidad();
                if (txtDni.Enabled == false)
                {
                    bool Exito = ClienteNeg.EditarSubCliente(_subCliente, idEmpresa);
                    if (Exito == true)
                    {
                        ProgressBar();
                        const string message2 = "El sub-cliente se edito exitosamente.";
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
                else
                {
                    bool Exito = ClienteNeg.GuardarNuevoSubCliente(_subCliente, idEmpresa);
                    if (Exito == true)
                    {
                        ProgressBar();
                        const string message2 = "Se registro el sub-cliente exitosamente.";
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
            catch (Exception ex)
            { }
        }
        #endregion
        #region Funciones
        private void LimpiarCampos()
        {
            txtDni.Clear();
            txtApellidoNombre.Clear();
            txtApellidoNombre.Clear();
            txtCalle.Clear();
            txtAltura.Clear();
            txtObservacion.Clear();
            progressBar1.Value = Convert.ToInt32(null);
            progressBar1.Visible = false;
        }
        private SubCliente CargarEntidad()
        {
            SubCliente _subCliente = new SubCliente();
            _subCliente.Dni = txtDni.Text;
            _subCliente.ApellidoNombre = txtApellidoNombre.Text;
            //_subCliente.ApellidoNombre = txtApellidoNombre.Text + " " + txtNombre.Text;
            _subCliente.Direccion = txtCalle.Text + " " + txtAltura.Text;
            _subCliente.Observacion = txtObservacion.Text;
            _subCliente.TipoDNI = cmbTipoDoc.Text;
            return _subCliente;
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
        #endregion
        private void btnCrearSubCliente_Click(object sender, EventArgs e)
        {
            try
            {
                txtApellidoNombreBuscar.Clear();
                txtDniBuscar.Clear();
                groupBox1.Enabled = true;
                txtDni.Focus();
                CargarCombo();
            }
            catch (Exception ex)
            { }
        }
        private void CargarCombo()
        {
            string[] TipoDoc = Clases_Maestras.ValoresConstantes.TipoDocumento;
            cmbTipoDoc.Items.Clear();
            cmbTipoDoc.Text = "Seleccione";
            cmbTipoDoc.Items.Add("Seleccione");
            foreach (string item in TipoDoc)
            {
                cmbTipoDoc.Text = "Seleccione";
                cmbTipoDoc.Items.Add(item);
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Entidades.SubCliente _subCliente = CargarEntidad();
                if (txtDni.Enabled == false)
                {
                    bool Exito = ClienteNeg.EditarSubCliente(_subCliente, idEmpresa);
                    if (Exito == true)
                    {
                        ProgressBar();
                        const string message2 = "El sub-cliente se edito exitosamente.";
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
                else
                {
                    bool Exito = ClienteNeg.GuardarNuevoSubCliente(_subCliente, idEmpresa);
                    if (Exito == true)
                    {
                        ProgressBar();
                        const string message2 = "Se registro el sub-cliente exitosamente.";
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
            catch (Exception ex)
            { }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void btnHabilitarBusqueda_Click(object sender, EventArgs e)
        {
            grbFiltros.Visible = true;
            txtApellidoNombreBuscar.Focus();
            txtApellidoNombreBuscar.AutoCompleteCustomSource = Clases_Maestras.AutoCompleteSubCliente.Autocomplete(idEmpresa);
            txtApellidoNombreBuscar.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtApellidoNombreBuscar.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }
    }
}
