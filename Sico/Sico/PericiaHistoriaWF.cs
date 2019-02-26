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
        public static string archivo2;
        public static string archivo3;
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
        #endregion
        #region Botones
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

        #endregion
    }
}
