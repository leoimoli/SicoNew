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
    public partial class PericiaHistoriaWF : MasterWF
    {
        private string idPericiaSeleccionada;
        public PericiaHistoriaWF(string idPericia)
        {
            InitializeComponent();
            this.idPericiaSeleccionada = idPericia;
        }
        private void PericiaHistoriaWF_Load(object sender, EventArgs e)
        {
            ListaPericias = PericiaNeg.BuscarHistorialPericia(idPericiaSeleccionada);
        }
        #region Funciones
        public static int totalArchivos;
        public static int idPericia;
        public static int Compartir;
        public static string Email;
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
        private Pericias CargarEntidad()
        {
            Pericias _pericia = new Pericias();
            _pericia.idPericia = Convert.ToInt32(idPericiaSeleccionada);
            _pericia.Fecha = dtFechaPericia.Value;
            _pericia.Estado = cmbEstado.Text;
            _pericia.Descripcion = txtDescripcion.Text;
            _pericia.Archivo1 = txtArchivo1.Text;
            _pericia.Archivo2 = txtArchivo2.Text;
            _pericia.Archivo3 = txtArchivo3.Text;
            if (Compartir == 1 & chcEmail.Checked == true)
                _pericia.Email = Email;
            _pericia.Compartido = Compartir;
            if (Compartir == 0 & chcEmail.Checked == true)
                MessageBox.Show("La nunca fue enviada por email a ningun destinatario.");
            return _pericia;
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
                    dgvPericias.Visible = true;
                    dgvPericias.ReadOnly = true;
                    dgvPericias.RowHeadersVisible = false;
                    groupBox1.Enabled = true;
                    dgvPericias.DataSource = value;

                    totalArchivos = value[0].totalArchivos;
                    idPericia = value[0].idPericia;
                    Compartir = value[0].Compartido;
                    Email = value[0].Email;

                    dgvPericias.Columns[0].HeaderText = "Id Pericia";
                    dgvPericias.Columns[0].Width = 60;
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
                    dgvPericias.Columns[9].Visible = false;

                    dgvPericias.Columns[10].HeaderText = "Estado";
                    dgvPericias.Columns[10].Width = 80;
                    dgvPericias.Columns[10].HeaderCell.Style.BackColor = Color.DarkBlue;
                    dgvPericias.Columns[10].HeaderCell.Style.Font = new System.Drawing.Font("Tahoma", 10, FontStyle.Bold);
                    dgvPericias.Columns[10].HeaderCell.Style.ForeColor = Color.White;

                    dgvPericias.Columns[11].HeaderText = "Descripción";
                    dgvPericias.Columns[11].Width = 120;
                    dgvPericias.Columns[11].HeaderCell.Style.BackColor = Color.DarkBlue;
                    dgvPericias.Columns[11].HeaderCell.Style.Font = new System.Drawing.Font("Tahoma", 10, FontStyle.Bold);
                    dgvPericias.Columns[11].HeaderCell.Style.ForeColor = Color.White;

                    dgvPericias.Columns[12].HeaderText = "TotalPericias";
                    dgvPericias.Columns[12].Width = 120;
                    dgvPericias.Columns[12].HeaderCell.Style.BackColor = Color.DarkBlue;
                    dgvPericias.Columns[12].HeaderCell.Style.Font = new System.Drawing.Font("Tahoma", 10, FontStyle.Bold);
                    dgvPericias.Columns[12].HeaderCell.Style.ForeColor = Color.White;
                    dgvPericias.Columns[12].Visible = false;
                }
                else { MessageBox.Show("No se encontraron resultados para los filtros seleccionados."); }

            }
        }
        private void LimpiarCampos()
        {
            txtDescripcion.Clear();
            CargarComboEstado();
            dtFechaPericia.Value = DateTime.Now;
            txtArchivo1.Clear();
            txtArchivo2.Clear();
            txtArchivo3.Clear();
            progressBar1.Value = Convert.ToInt32(null);
            progressBar1.Visible = false;
        }
        private void ValidarCantidadArchivos()
        {
            int cantidadAdjuntos = 0;

            if (totalArchivos == 0)
            {
                lblArchivo1.Visible = true;
                lbl2Archivo2.Visible = true;
                lblArchivo3.Visible = true;
                txtArchivo1.Visible = true;
                txtArchivo2.Visible = true;
                txtArchivo3.Visible = true;
                btnCargarArchivo1.Visible = true;
                btnCargarArchivo2.Visible = true;
                btnCargarArchivo3.Visible = true;
            }
            if (totalArchivos == 1)
            {
                lblArchivo1.Visible = true;
                lbl2Archivo2.Visible = true;
                txtArchivo1.Visible = true;
                txtArchivo2.Visible = true;
                btnCargarArchivo1.Visible = true;
                btnCargarArchivo2.Visible = true;

            }
            if (totalArchivos == 2)
            {
                lblArchivo1.Visible = true;
                txtArchivo1.Visible = true;
                btnCargarArchivo1.Visible = true;
            }
            if (totalArchivos == 3)
            {
                lblMensaje.Text = "Ya posee adjunto el total de archivos que el sistema permite.";
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
        #endregion
        #region Botones
        private void btnGuardarHistorial_Click(object sender, EventArgs e)
        {
            try
            {
                Entidades.Pericias _pericia = CargarEntidad();
                bool Exito = PericiaNeg.GurdarHistorialPericia(_pericia);
                if (Exito == true)
                {
                    ProgressBar();
                    const string message2 = "Se registro el nuevo estadio exitosamente.";
                    const string caption2 = "Éxito";
                    var result2 = MessageBox.Show(message2, caption2,
                                                 MessageBoxButtons.OK,
                                                 MessageBoxIcon.Asterisk);
                    LimpiarCampos();
                    ListaPericias = PericiaNeg.BuscarHistorialPericia(idPericiaSeleccionada);
                    groupBox2.Visible = false;
                }
                else
                {

                }
            }
            catch (Exception ex)
            { }
        }
        private void btnNuevaHistoria_Click(object sender, EventArgs e)
        {
            try
            {
                FuncionesBotonNuevaHistoria();
            }
            catch (Exception ex)
            { }
        }
        private void FuncionesBotonNuevaHistoria()
        {
            groupBox2.Visible = true;
            dtFechaPericia.Focus();
            ValidarCantidadArchivos();
            CargarComboEstado();
            btnNuevaHistoria.Visible = false;
        }
        private void CargarComboEstado()
        {
            string[] Estado = Clases_Maestras.ValoresConstantes.EstadosPericia;
            cmbEstado.Items.Add("Seleccione");
            cmbEstado.Items.Clear();
            foreach (string item in Estado)
            {
                cmbEstado.Text = "Seleccione";
                cmbEstado.Items.Add(item);
            }
        }
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }
        #endregion
    }
}
