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
    public partial class PericiasWF : MasterWF
    {
        public PericiasWF()
        {
            InitializeComponent();
        }
        #region Funciones
        private void FuncionesBotonNuevaPericia()
        {
            chcPorCausa.Checked = false;
            chcPorTribunal.Checked = false;
            txtCausaBuscar.Clear();
            groupBox3.Visible = false;
            LimpiarCamposBotonNuevaPericia();
            groupBox1.Enabled = true;
            cmbTribunal.Focus();
            groupBox1.Text = "Nueva Pericia";
            btnHabilitarBuscar.Visible = true;
            txtArchivo1.Clear();
            txtArchivo2.Clear();
            txtArchivo3.Clear();
        }
        private void LimpiarCamposBotonNuevaPericia()
        {
            dtFechaPericia.Value = DateTime.Now;
            txtCausa.Clear();
            txtNroCausa.Clear();
            CargarComboTribunal();
            progressBar1.Value = Convert.ToInt32(null);
            progressBar1.Visible = false;
            groupBox1.Enabled = false;
            txtEmail.Clear();
            chcCompartirPericia.Checked = false;
        }
        private void CargarComboTribunal()
        {
            string[] Tribunal = Clases_Maestras.ValoresConstantes.Tribunal;
            cmbTribunal.Items.Add("Seleccione");
            cmbTribunal.Items.Clear();
            foreach (string item in Tribunal)
            {
                cmbTribunal.Text = "Seleccione";
                cmbTribunal.Items.Add(item);
            }

            cmbTribunalBuscar.Items.Add("Seleccione");
            cmbTribunalBuscar.Items.Clear();
            foreach (string item in Tribunal)
            {
                cmbTribunalBuscar.Text = "Seleccione";
                cmbTribunalBuscar.Items.Add(item);
            }

        }
        private void chcCompartirPericia_CheckedChanged(object sender, EventArgs e)
        {
            if (chcCompartirPericia.Checked == true)
            {
                txtEmail.Visible = true;
                txtEmail.Focus();
            }
            else
            {
                txtEmail.Visible = false;
                txtEmail.Clear();
            }
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
        private void LimpiarCampos()
        {
            txtCausa.Clear();
            txtNroCausa.Clear();
            txtEmail.Clear();
            CargarComboTribunal();
            txtArchivo1.Clear();
            txtArchivo2.Clear();
            txtArchivo3.Clear();
            chcCompartirPericia.Checked = false;
            txtEmail.Visible = false;
            dtFechaPericia.Value = DateTime.Now;
            progressBar1.Value = Convert.ToInt32(null);
            progressBar1.Visible = false;
            groupBox1.Enabled = false;
        }
        private Pericias CargarEntidad()
        {
            Pericias _pericia = new Pericias();
            _pericia.Tribunal = cmbTribunal.Text;
            _pericia.Fecha = dtFechaPericia.Value;
            _pericia.NroCausa = txtNroCausa.Text;
            _pericia.Causa = txtCausa.Text;
            _pericia.Archivo1 = txtArchivo1.Text;
            _pericia.Archivo2 = txtArchivo1.Text;
            _pericia.Archivo3 = txtArchivo1.Text;
            _pericia.Email = txtEmail.Text;
            if (chcCompartirPericia.Checked == true)
            { _pericia.Compartido = 1; }
            else { _pericia.Compartido = 0; }
            return _pericia;
        }
        #endregion
        #region Botones
        private void btnNuevaPericia_Click(object sender, EventArgs e)
        {
            try
            {
                FuncionesBotonNuevaPericia();

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
        private void btnCargarArchivo1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string path = "";
                System.IO.StreamReader sr = new
                   System.IO.StreamReader(openFileDialog1.FileName);
                path = openFileDialog1.FileName;
                txtArchivo1.Text = path;
                sr.Close();
            }
        }
        private void btnCargarArchivo2_Click(object sender, EventArgs e)
        {
            if (openFileDialog2.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string path2 = "";
                System.IO.StreamReader sr = new
                   System.IO.StreamReader(openFileDialog2.FileName);
                path2 = openFileDialog2.FileName;
                txtArchivo1.Text = path2;
                sr.Close();
            }
        }
        private void btnCargarArchivo3_Click(object sender, EventArgs e)
        {
            if (openFileDialog3.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string path3 = "";
                System.IO.StreamReader sr = new
                   System.IO.StreamReader(openFileDialog3.FileName);
                path3 = openFileDialog3.FileName;
                txtArchivo1.Text = path3;
                sr.Close();
            }
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                Entidades.Pericias _pericia = CargarEntidad();
                bool Exito = PericiaNeg.GurdarPericia(_pericia);
                if (Exito == true)
                {
                    ProgressBar();
                    const string message2 = "Se registro la pericia exitosamente.";
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
            catch { }
        }
        #endregion

    }
}
