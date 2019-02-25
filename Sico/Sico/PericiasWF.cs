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
            _pericia.Archivo2 = txtArchivo2.Text;
            _pericia.Archivo3 = txtArchivo3.Text;
            _pericia.Email = txtEmail.Text;
            if (chcCompartirPericia.Checked == true)
            { _pericia.Compartido = 1; }
            else { _pericia.Compartido = 0; }
            return _pericia;
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
        private void FuncionesBotonHabilitarBuscar()
        {
            chcPorTribunal.Checked = true;
            btnHabilitarBuscar.Visible = false;
            groupBox3.Visible = true;
            cmbTribunalBuscar.Focus();
            CargarComboTribunal();
        }
        private void chcPorTribunal_CheckedChanged(object sender, EventArgs e)
        {
            if (chcPorTribunal.Checked == true)
            {
                txtCausaBuscar.Clear();
                txtCausaBuscar.Visible = false;
                cmbTribunalBuscar.Visible = true;
                chcPorCausa.Checked = false;
                lblDniOApellidoNombre.Text = "Buscar Por Tribunal(*):";
                cmbTribunalBuscar.Focus();
            }
        }
        private void chcPorCausa_CheckedChanged(object sender, EventArgs e)
        {
            if (chcPorCausa.Checked == true)
            {
                txtCausaBuscar.Clear();
                txtCausa.Enabled = true;
                txtCausaBuscar.Focus();
                txtCausaBuscar.Visible = true;
                cmbTribunalBuscar.Visible = false;
                chcPorTribunal.Checked = false;
                lblDniOApellidoNombre.Text = "Buscar Por Causa(*):";
                txtCausaBuscar.Focus();
                txtCausaBuscar.AutoCompleteCustomSource = Clases_Maestras.AutoCompleteRazonSocial.Autocomplete();
                txtCausaBuscar.AutoCompleteMode = AutoCompleteMode.Suggest;
                txtCausaBuscar.AutoCompleteSource = AutoCompleteSource.CustomSource;
            }
        }
        public List<Entidades.Pericias> ListaPericias
        {
            set
            {
                if (value.Count > 0)
                {
                    if (value != dgvPericias.DataSource && dgvPericias.DataSource != null)
                    {
                        dgvPericias.Columns.Clear();
                        dgvPericias.Refresh();
                    }
                    //lblCantidad.Visible = true;
                    //lblCantidadEdit.Visible = true;
                    //lblCantidadEdit.Text = Convert.ToString(value.Count);
                    btnBuscar.Visible = true;
                    //btnConsultarTotales.Visible = true;
                    //label2.Visible = true;
                    //lblSeleccionar.Visible = true;
                    //txtBuscar.Visible = true;
                    //txtBuscar.Enabled = true;
                    //txtBuscar.Focus();
                    dgvPericias.Visible = true;
                    dgvPericias.ReadOnly = true;
                    dgvPericias.RowHeadersVisible = false;
                    groupBox1.Enabled = true;
                    dgvPericias.DataSource = value;

                    dgvPericias.Columns[0].HeaderText = "Id Pericia";
                    dgvPericias.Columns[0].Width = 130;
                    dgvPericias.Columns[0].HeaderCell.Style.BackColor = Color.DarkBlue;
                    dgvPericias.Columns[0].HeaderCell.Style.Font = new System.Drawing.Font("Tahoma", 10, FontStyle.Bold);
                    dgvPericias.Columns[0].HeaderCell.Style.ForeColor = Color.White;

                    dgvPericias.Columns[1].HeaderText = "Tribunal";
                    dgvPericias.Columns[1].Width = 170;
                    dgvPericias.Columns[1].HeaderCell.Style.BackColor = Color.DarkBlue;
                    dgvPericias.Columns[1].HeaderCell.Style.Font = new System.Drawing.Font("Tahoma", 10, FontStyle.Bold);
                    dgvPericias.Columns[1].HeaderCell.Style.ForeColor = Color.White;

                    dgvPericias.Columns[2].HeaderText = "Fecha";
                    dgvPericias.Columns[2].Width = 100;
                    dgvPericias.Columns[2].HeaderCell.Style.BackColor = Color.DarkBlue;
                    dgvPericias.Columns[2].HeaderCell.Style.Font = new System.Drawing.Font("Tahoma", 10, FontStyle.Bold);
                    dgvPericias.Columns[2].HeaderCell.Style.ForeColor = Color.White;

                    dgvPericias.Columns[3].HeaderText = "Nro.Causa";
                    dgvPericias.Columns[3].Width = 110;
                    dgvPericias.Columns[3].HeaderCell.Style.BackColor = Color.DarkBlue;
                    dgvPericias.Columns[3].HeaderCell.Style.Font = new System.Drawing.Font("Tahoma", 10, FontStyle.Bold);
                    dgvPericias.Columns[3].HeaderCell.Style.ForeColor = Color.White;

                    dgvPericias.Columns[4].HeaderText = "Causa";
                    dgvPericias.Columns[4].Width = 150;
                    dgvPericias.Columns[4].HeaderCell.Style.BackColor = Color.DarkBlue;
                    dgvPericias.Columns[4].HeaderCell.Style.Font = new System.Drawing.Font("Tahoma", 10, FontStyle.Bold);
                    dgvPericias.Columns[4].HeaderCell.Style.ForeColor = Color.White;


                    dgvPericias.Columns[5].HeaderText = "Archivo1";
                    dgvPericias.Columns[5].Width = 250;
                    dgvPericias.Columns[5].HeaderCell.Style.BackColor = Color.DarkBlue;
                    dgvPericias.Columns[5].HeaderCell.Style.Font = new System.Drawing.Font("Tahoma", 10, FontStyle.Bold);
                    dgvPericias.Columns[5].HeaderCell.Style.ForeColor = Color.White;
                    dgvPericias.Columns[5].Visible = false;

                    dgvPericias.Columns[6].HeaderText = "Archivo2";
                    dgvPericias.Columns[6].Width = 135;
                    dgvPericias.Columns[6].HeaderCell.Style.BackColor = Color.DarkBlue;
                    dgvPericias.Columns[6].HeaderCell.Style.Font = new System.Drawing.Font("Tahoma", 10, FontStyle.Bold);
                    dgvPericias.Columns[6].HeaderCell.Style.ForeColor = Color.White;
                    dgvPericias.Columns[6].Visible = false;

                    dgvPericias.Columns[7].HeaderText = "Archivo3";
                    dgvPericias.Columns[7].Width = 95;
                    dgvPericias.Columns[7].HeaderCell.Style.BackColor = Color.DarkBlue;
                    dgvPericias.Columns[7].HeaderCell.Style.Font = new System.Drawing.Font("Tahoma", 10, FontStyle.Bold);
                    dgvPericias.Columns[7].HeaderCell.Style.ForeColor = Color.White;
                    dgvPericias.Columns[7].Visible = false;

                    dgvPericias.Columns[8].HeaderText = "Compartir";
                    dgvPericias.Columns[8].Width = 50;
                    dgvPericias.Columns[8].HeaderCell.Style.BackColor = Color.DarkBlue;
                    dgvPericias.Columns[8].HeaderCell.Style.Font = new System.Drawing.Font("Tahoma", 10, FontStyle.Bold);
                    dgvPericias.Columns[8].HeaderCell.Style.ForeColor = Color.White;
                    dgvPericias.Columns[8].Visible = false;

                    dgvPericias.Columns[9].HeaderText = "Email";
                    dgvPericias.Columns[9].Width = 95;
                    dgvPericias.Columns[9].HeaderCell.Style.BackColor = Color.DarkBlue;
                    dgvPericias.Columns[9].HeaderCell.Style.Font = new System.Drawing.Font("Tahoma", 10, FontStyle.Bold);
                    dgvPericias.Columns[9].HeaderCell.Style.ForeColor = Color.White;

                    dgvPericias.Columns[10].HeaderText = "Estado";
                    dgvPericias.Columns[10].Width = 95;
                    dgvPericias.Columns[10].HeaderCell.Style.BackColor = Color.DarkBlue;
                    dgvPericias.Columns[10].HeaderCell.Style.Font = new System.Drawing.Font("Tahoma", 10, FontStyle.Bold);
                    dgvPericias.Columns[10].HeaderCell.Style.ForeColor = Color.White;
                }
                else { MessageBox.Show("No se encontraron resultados para los filtros seleccionados."); }
            }
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
                txtArchivo2.Text = path2;
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
                txtArchivo3.Text = path3;
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
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {

                if (chcPorTribunal.Checked == true)
                {
                    var tribunal = cmbTribunalBuscar.Text;
                    ListaPericias = PericiaNeg.BuscarPericiasPorTribunal(tribunal);
                }
                else
                {
                    var Causa = txtCausaBuscar.Text;
                    ListaPericias = PericiaNeg.BuscarPericiasPorCausa(Causa);

                }
            }
            catch (Exception ex)
            {

            }
        }
        #endregion      
    }
}
