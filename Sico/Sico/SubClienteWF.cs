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
        private string cuit;
        private string razonSocial;
        public SubClienteWF(string razonSocial, string cuit)
        {
            InitializeComponent();
            this.razonSocial = razonSocial;
            this.cuit = cuit;
        }
        private void SubClienteWF_Load(object sender, EventArgs e)
        {
            lblNombreEdit.Text = razonSocial;
            lblCuitEdit.Text = cuit;
        }
        #region Botones        
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                Entidades.SubCliente _subCliente = CargarEntidad();
                bool Exito = ClienteNeg.GuardarNuevoSubCliente(_subCliente, cuit);
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
            catch (Exception ex)
            { }
        }
        #endregion
        #region Funciones
        private void LimpiarCampos()
        {
            txtDni.Clear();
            txtApellido.Clear();
            txtNombre.Clear();
            txtCalle.Clear();
            txtAltura.Clear();
        }
        private SubCliente CargarEntidad()
        {
            SubCliente _subCliente = new SubCliente();
            _subCliente.Dni = txtDni.Text;
            _subCliente.ApellidoNombre = txtApellido.Text + " " + txtNombre.Text;
            _subCliente.Direccion = txtCalle.Text + " " + txtAltura.Text;
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

        private void button1_Click(object sender, EventArgs e)
        {
            TareaClienteWF _tarea = new TareaClienteWF(razonSocial,cuit);
            _tarea.Show();
            Hide();
        }
    }
}
