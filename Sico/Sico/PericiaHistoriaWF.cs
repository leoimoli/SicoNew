using Sico.Clases_Maestras;
using Sico.Entidades;
using Sico.Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;

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
        public static string EstadoCombo;
        private void PericiaHistoriaWF_Load(object sender, EventArgs e)
        {
            List<Pericias> objListOrder = new List<Pericias>();
            objListOrder = PericiaNeg.BuscarHistorialPericia(idPericiaSeleccionada);
            List<Pericias> SortedList = objListOrder.OrderByDescending(o => o.Fecha).ToList();
            ListaPericias = SortedList;
            var lista = SortedList.First();
            cmbEstado.Text = lista.Estado;
            List<string> listaArchivos = new List<string>();
            listaArchivos = Dao.PericiaDao.CargarArchivos(idPericiaSeleccionada);
            int contador = 0;
            if (listaArchivos.Count > 0)
            {
                if (listaArchivos.Count > contador)
                {
                    txtAdjunto1.Text = listaArchivos[0].ToString();
                    txtAdjunto1.Visible = true; btnAbrir1.Visible = true; lblAdjunto1.Visible = true; contador = 1;
                }

                if (listaArchivos.Count > contador)
                {
                    txtAdjunto2.Text = listaArchivos[1].ToString();
                    txtAdjunto2.Visible = true; btnAbrir2.Visible = true; lblAdjunto2.Visible = true; contador = 2;
                }

                if (listaArchivos.Count > contador)
                {
                    txtAdjunto3.Text = listaArchivos[2].ToString();
                    txtAdjunto3.Visible = true; btnAbrir3.Visible = true; lblAdjunto3.Visible = true; contador = 3;
                }

                if (listaArchivos.Count > contador)
                {
                    txtAdjunto4.Text = listaArchivos[3].ToString();
                    txtAdjunto4.Visible = true; btnAbrir4.Visible = true; lblAdjunto4.Visible = true; contador = 4;
                }

                if (listaArchivos.Count > contador)
                {
                    txtAdjunto5.Text = listaArchivos[4].ToString();
                    txtAdjunto5.Visible = true; btnAbrir5.Visible = true; lblAdjunto5.Visible = true; contador = 5;
                }

                if (listaArchivos.Count > contador)
                {
                    txtAdjunto6.Text = listaArchivos[5].ToString();
                    txtAdjunto6.Visible = true; btnAbrir6.Visible = true; lblAdjunto6.Visible = true; contador = 6;
                }

                if (listaArchivos.Count > contador)
                {
                    txtAdjunto7.Text = listaArchivos[6].ToString();
                    txtAdjunto7.Visible = true; btnAbrir7.Visible = true; lblAdjunto7.Visible = true; contador = 7;
                }

                if (listaArchivos.Count > contador)
                {
                    txtAdjunto8.Text = listaArchivos[7].ToString();
                    txtAdjunto8.Visible = true; btnAbrir8.Visible = true; lblAdjunto8.Visible = true; contador = 8;
                }

                if (listaArchivos.Count > contador)
                {
                    txtAdjunto9.Text = listaArchivos[8].ToString();
                    txtAdjunto9.Visible = true; btnAbrir9.Visible = true; lblAdjunto9.Visible = true; contador = 9;
                }

                if (listaArchivos.Count > contador)
                {
                    txtAdjunto10.Text = listaArchivos[9].ToString();
                    txtAdjunto10.Visible = true; btnAbrir10.Visible = true; lblAdjunto10.Visible = true; contador = 10;
                }

                groupBox3.Visible = true;
            }
        }
        #region Funciones
        public static int totalArchivos;
        public static int idPericia;
        public static int Compartir;
        public static string Email;
        public static string Causa;
        public static string NroCausa;
        public static string Tribunal;
        public static int TotalHistorial;
        public static List<string> listaArchivos;
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
            _pericia.Archivo4 = txtArchivo4.Text;
            _pericia.Archivo5 = txtArchivo5.Text;
            _pericia.Archivo6 = txtArchivo6.Text;
            _pericia.Archivo7 = txtArchivo7.Text;
            _pericia.Archivo8 = txtArchivo8.Text;
            _pericia.Archivo9 = txtArchivo9.Text;
            _pericia.Archivo10 = txtArchivo10.Text;
            if (Compartir == 1 & chcEmail.Checked == true)
                _pericia.Email = Email;
            _pericia.Compartido = Compartir;
            if (Compartir == 0 & chcEmail.Checked == true)
                MessageBox.Show("La pericia nunca fue enviada por email a ningun destinatario.");
            if (Compartir == 1 & chcEmail.Checked == false)
                Compartir = 0;
            _pericia.Causa = Causa;
            _pericia.NroCausa = NroCausa;
            _pericia.Tribunal = Tribunal;
            _pericia.TotalEstados = TotalHistorial;
            _pericia.UsuarioLogin = Sesion.UsuarioLogueado.IdUsuario;
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
                    Causa = value[0].Causa;
                    NroCausa = value[0].NroCausa;
                    Tribunal = value[0].Tribunal;
                    TotalHistorial = value.Count;

                    if (txtAdjunto1.Text != "" || txtAdjunto1.Text != null || txtAdjunto2.Text != "" || txtAdjunto2.Text != null || txtAdjunto3.Text != "" || txtAdjunto3.Text != null)
                        groupBox3.Visible = true;



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
                    dgvPericias.Columns[4].Width = 170;
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
                    dgvPericias.Columns[10].Width = 100;
                    dgvPericias.Columns[10].HeaderCell.Style.BackColor = Color.DarkBlue;
                    dgvPericias.Columns[10].HeaderCell.Style.Font = new System.Drawing.Font("Tahoma", 10, FontStyle.Bold);
                    dgvPericias.Columns[10].HeaderCell.Style.ForeColor = Color.White;

                    dgvPericias.Columns[11].HeaderText = "Descripción";
                    dgvPericias.Columns[11].Width = 135;
                    dgvPericias.Columns[11].HeaderCell.Style.BackColor = Color.DarkBlue;
                    dgvPericias.Columns[11].HeaderCell.Style.Font = new System.Drawing.Font("Tahoma", 10, FontStyle.Bold);
                    dgvPericias.Columns[11].HeaderCell.Style.ForeColor = Color.White;

                    dgvPericias.Columns[12].HeaderText = "TotalPericias";
                    dgvPericias.Columns[12].Width = 120;
                    dgvPericias.Columns[12].HeaderCell.Style.BackColor = Color.DarkBlue;
                    dgvPericias.Columns[12].HeaderCell.Style.Font = new System.Drawing.Font("Tahoma", 10, FontStyle.Bold);
                    dgvPericias.Columns[12].HeaderCell.Style.ForeColor = Color.White;
                    dgvPericias.Columns[12].Visible = false;

                    dgvPericias.Columns[13].HeaderText = "Total Estados";
                    dgvPericias.Columns[13].Width = 120;
                    dgvPericias.Columns[13].HeaderCell.Style.BackColor = Color.DarkBlue;
                    dgvPericias.Columns[13].HeaderCell.Style.Font = new System.Drawing.Font("Tahoma", 10, FontStyle.Bold);
                    dgvPericias.Columns[13].HeaderCell.Style.ForeColor = Color.White;
                    dgvPericias.Columns[13].Visible = false;

                    dgvPericias.Columns[14].HeaderText = "Archivos 4";
                    dgvPericias.Columns[14].Width = 120;
                    dgvPericias.Columns[14].HeaderCell.Style.BackColor = Color.DarkBlue;
                    dgvPericias.Columns[14].HeaderCell.Style.Font = new System.Drawing.Font("Tahoma", 10, FontStyle.Bold);
                    dgvPericias.Columns[14].HeaderCell.Style.ForeColor = Color.White;
                    dgvPericias.Columns[14].Visible = false;

                    dgvPericias.Columns[15].HeaderText = "Total Estados";
                    dgvPericias.Columns[15].Width = 120;
                    dgvPericias.Columns[15].HeaderCell.Style.BackColor = Color.DarkBlue;
                    dgvPericias.Columns[15].HeaderCell.Style.Font = new System.Drawing.Font("Tahoma", 10, FontStyle.Bold);
                    dgvPericias.Columns[15].HeaderCell.Style.ForeColor = Color.White;
                    dgvPericias.Columns[15].Visible = false;

                    dgvPericias.Columns[16].HeaderText = "Total Estados";
                    dgvPericias.Columns[16].Width = 120;
                    dgvPericias.Columns[16].HeaderCell.Style.BackColor = Color.DarkBlue;
                    dgvPericias.Columns[16].HeaderCell.Style.Font = new System.Drawing.Font("Tahoma", 10, FontStyle.Bold);
                    dgvPericias.Columns[16].HeaderCell.Style.ForeColor = Color.White;
                    dgvPericias.Columns[16].Visible = false;

                    dgvPericias.Columns[17].HeaderText = "Total Estados";
                    dgvPericias.Columns[17].Width = 120;
                    dgvPericias.Columns[17].HeaderCell.Style.BackColor = Color.DarkBlue;
                    dgvPericias.Columns[17].HeaderCell.Style.Font = new System.Drawing.Font("Tahoma", 10, FontStyle.Bold);
                    dgvPericias.Columns[17].HeaderCell.Style.ForeColor = Color.White;
                    dgvPericias.Columns[17].Visible = false;

                    dgvPericias.Columns[18].HeaderText = "Total Estados";
                    dgvPericias.Columns[18].Width = 120;
                    dgvPericias.Columns[18].HeaderCell.Style.BackColor = Color.DarkBlue;
                    dgvPericias.Columns[18].HeaderCell.Style.Font = new System.Drawing.Font("Tahoma", 10, FontStyle.Bold);
                    dgvPericias.Columns[18].HeaderCell.Style.ForeColor = Color.White;
                    dgvPericias.Columns[18].Visible = false;

                    dgvPericias.Columns[19].HeaderText = "Total Estados";
                    dgvPericias.Columns[19].Width = 120;
                    dgvPericias.Columns[19].HeaderCell.Style.BackColor = Color.DarkBlue;
                    dgvPericias.Columns[19].HeaderCell.Style.Font = new System.Drawing.Font("Tahoma", 10, FontStyle.Bold);
                    dgvPericias.Columns[19].HeaderCell.Style.ForeColor = Color.White;
                    dgvPericias.Columns[19].Visible = false;


                    dgvPericias.Columns[20].HeaderText = "Total Estados";
                    dgvPericias.Columns[20].Width = 120;
                    dgvPericias.Columns[20].HeaderCell.Style.BackColor = Color.DarkBlue;
                    dgvPericias.Columns[20].HeaderCell.Style.Font = new System.Drawing.Font("Tahoma", 10, FontStyle.Bold);
                    dgvPericias.Columns[20].HeaderCell.Style.ForeColor = Color.White;
                    dgvPericias.Columns[20].Visible = false;

                    dgvPericias.Columns[21].HeaderText = "idUsuario";
                    dgvPericias.Columns[21].Width = 120;
                    dgvPericias.Columns[21].HeaderCell.Style.BackColor = Color.DarkBlue;
                    dgvPericias.Columns[21].HeaderCell.Style.Font = new System.Drawing.Font("Tahoma", 10, FontStyle.Bold);
                    dgvPericias.Columns[21].HeaderCell.Style.ForeColor = Color.White;
                    dgvPericias.Columns[21].Visible = false;
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
            txtArchivo4.Clear();
            txtArchivo5.Clear();
            txtArchivo6.Clear();
            txtArchivo7.Clear();
            txtArchivo8.Clear();
            txtArchivo9.Clear();
            txtArchivo10.Clear();
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
                lblArchivo4.Visible = true;
                lblArchivo5.Visible = true;
                lblArchivo6.Visible = true;
                lblArchivo7.Visible = true;
                lblArchivo8.Visible = true;
                lblArchivo9.Visible = true;
                lblArchivo10.Visible = true;

                txtArchivo1.Visible = true;
                txtArchivo2.Visible = true;
                txtArchivo3.Visible = true;
                txtArchivo4.Visible = true;
                txtArchivo5.Visible = true;
                txtArchivo6.Visible = true;
                txtArchivo7.Visible = true;
                txtArchivo8.Visible = true;
                txtArchivo9.Visible = true;
                txtArchivo10.Visible = true;

                btnCargarArchivo1.Visible = true;
                btnCargarArchivo2.Visible = true;
                btnCargarArchivo3.Visible = true;
                btnCargarArchivo4.Visible = true;
                btnCargarArchivo5.Visible = true;
                btnCargarArchivo6.Visible = true;
                btnCargarArchivo7.Visible = true;
                btnCargarArchivo8.Visible = true;
                btnCargarArchivo9.Visible = true;
                btnCargarArchivo10.Visible = true;
            }
            if (totalArchivos == 1)
            {
                lblArchivo1.Visible = true;
                lbl2Archivo2.Visible = true;
                lblArchivo3.Visible = true;
                lblArchivo4.Visible = true;
                lblArchivo5.Visible = true;
                lblArchivo6.Visible = true;
                lblArchivo7.Visible = true;
                lblArchivo8.Visible = true;
                lblArchivo9.Visible = true;

                txtArchivo1.Visible = true;
                txtArchivo2.Visible = true;
                txtArchivo3.Visible = true;
                txtArchivo4.Visible = true;
                txtArchivo5.Visible = true;
                txtArchivo6.Visible = true;
                txtArchivo7.Visible = true;
                txtArchivo8.Visible = true;
                txtArchivo9.Visible = true;

                btnCargarArchivo1.Visible = true;
                btnCargarArchivo2.Visible = true;
                btnCargarArchivo3.Visible = true;
                btnCargarArchivo4.Visible = true;
                btnCargarArchivo5.Visible = true;
                btnCargarArchivo6.Visible = true;
                btnCargarArchivo7.Visible = true;
                btnCargarArchivo8.Visible = true;
                btnCargarArchivo9.Visible = true;

            }
            if (totalArchivos == 2)
            {
                lblArchivo1.Visible = true;
                lbl2Archivo2.Visible = true;
                lblArchivo3.Visible = true;
                lblArchivo4.Visible = true;
                lblArchivo5.Visible = true;
                lblArchivo6.Visible = true;
                lblArchivo7.Visible = true;
                lblArchivo8.Visible = true;
                txtArchivo1.Visible = true;
                txtArchivo2.Visible = true;
                txtArchivo3.Visible = true;
                txtArchivo4.Visible = true;
                txtArchivo5.Visible = true;
                txtArchivo6.Visible = true;
                txtArchivo7.Visible = true;
                txtArchivo8.Visible = true;
                btnCargarArchivo1.Visible = true;
                btnCargarArchivo2.Visible = true;
                btnCargarArchivo3.Visible = true;
                btnCargarArchivo4.Visible = true;
                btnCargarArchivo5.Visible = true;
                btnCargarArchivo6.Visible = true;
                btnCargarArchivo7.Visible = true;
                btnCargarArchivo8.Visible = true;
            }
            if (totalArchivos == 3)
            {
                lblArchivo1.Visible = true;
                lbl2Archivo2.Visible = true;
                lblArchivo3.Visible = true;
                lblArchivo4.Visible = true;
                lblArchivo5.Visible = true;
                lblArchivo6.Visible = true;
                lblArchivo7.Visible = true;

                txtArchivo1.Visible = true;
                txtArchivo2.Visible = true;
                txtArchivo3.Visible = true;
                txtArchivo4.Visible = true;
                txtArchivo5.Visible = true;
                txtArchivo6.Visible = true;
                txtArchivo7.Visible = true;

                btnCargarArchivo1.Visible = true;
                btnCargarArchivo2.Visible = true;
                btnCargarArchivo3.Visible = true;
                btnCargarArchivo4.Visible = true;
                btnCargarArchivo5.Visible = true;
                btnCargarArchivo6.Visible = true;
                btnCargarArchivo7.Visible = true;

            }
            if (totalArchivos == 4)
            {
                lblArchivo1.Visible = true;
                lbl2Archivo2.Visible = true;
                lblArchivo3.Visible = true;
                lblArchivo4.Visible = true;
                lblArchivo5.Visible = true;
                lblArchivo6.Visible = true;

                txtArchivo1.Visible = true;
                txtArchivo2.Visible = true;
                txtArchivo3.Visible = true;
                txtArchivo4.Visible = true;
                txtArchivo5.Visible = true;
                txtArchivo6.Visible = true;

                btnCargarArchivo1.Visible = true;
                btnCargarArchivo2.Visible = true;
                btnCargarArchivo3.Visible = true;
                btnCargarArchivo4.Visible = true;
                btnCargarArchivo5.Visible = true;
                btnCargarArchivo6.Visible = true;
            }
            if (totalArchivos == 5)
            {
                lblArchivo1.Visible = true;
                lbl2Archivo2.Visible = true;
                lblArchivo3.Visible = true;
                lblArchivo4.Visible = true;
                lblArchivo5.Visible = true;

                txtArchivo1.Visible = true;
                txtArchivo2.Visible = true;
                txtArchivo3.Visible = true;
                txtArchivo4.Visible = true;
                txtArchivo5.Visible = true;

                btnCargarArchivo1.Visible = true;
                btnCargarArchivo2.Visible = true;
                btnCargarArchivo3.Visible = true;
                btnCargarArchivo4.Visible = true;
                btnCargarArchivo5.Visible = true;
            }
            if (totalArchivos == 6)
            {
                lblArchivo1.Visible = true;
                lbl2Archivo2.Visible = true;
                lblArchivo3.Visible = true;
                lblArchivo4.Visible = true;

                txtArchivo1.Visible = true;
                txtArchivo2.Visible = true;
                txtArchivo3.Visible = true;
                txtArchivo4.Visible = true;

                btnCargarArchivo1.Visible = true;
                btnCargarArchivo2.Visible = true;
                btnCargarArchivo3.Visible = true;
                btnCargarArchivo4.Visible = true;
            }
            if (totalArchivos == 7)
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

            if (totalArchivos == 8)
            {
                lblArchivo1.Visible = true;
                lbl2Archivo2.Visible = true;
                txtArchivo1.Visible = true;
                txtArchivo2.Visible = true;
                btnCargarArchivo1.Visible = true;
                btnCargarArchivo2.Visible = true;

            }
            if (totalArchivos == 9)
            {
                lblArchivo1.Visible = true;
                txtArchivo1.Visible = true;
                btnCargarArchivo1.Visible = true;
            }
            if (totalArchivos == 10)
            {
                chcEmail.Visible = false;
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
        private void btnCargarArchivo4_Click(object sender, EventArgs e)
        {
            if (openFileDialog4.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string path4 = "";
                System.IO.StreamReader sr = new
                   System.IO.StreamReader(openFileDialog4.FileName);
                path4 = openFileDialog4.FileName;
                txtArchivo4.Text = path4;
                sr.Close();
            }
        }
        private void btnCargarArchivo5_Click(object sender, EventArgs e)
        {
            if (openFileDialog5.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string path5 = "";
                System.IO.StreamReader sr = new
                   System.IO.StreamReader(openFileDialog5.FileName);
                path5 = openFileDialog3.FileName;
                txtArchivo5.Text = path5;
                sr.Close();
            }
        }
        private void btnCargarArchivo6_Click(object sender, EventArgs e)
        {
            if (openFileDialog6.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string path6 = "";
                System.IO.StreamReader sr = new
                   System.IO.StreamReader(openFileDialog6.FileName);
                path6 = openFileDialog6.FileName;
                txtArchivo6.Text = path6;
                sr.Close();
            }
        }
        private void btnCargarArchivo7_Click(object sender, EventArgs e)
        {
            if (openFileDialog7.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string path7 = "";
                System.IO.StreamReader sr = new
                   System.IO.StreamReader(openFileDialog7.FileName);
                path7 = openFileDialog7.FileName;
                txtArchivo7.Text = path7;
                sr.Close();
            }
        }
        private void btnCargarArchivo8_Click(object sender, EventArgs e)
        {
            if (openFileDialog8.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string path8 = "";
                System.IO.StreamReader sr = new
                   System.IO.StreamReader(openFileDialog8.FileName);
                path8 = openFileDialog8.FileName;
                txtArchivo8.Text = path8;
                sr.Close();
            }
        }
        private void btnCargarArchivo9_Click(object sender, EventArgs e)
        {
            if (openFileDialog9.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string path9 = "";
                System.IO.StreamReader sr = new
                   System.IO.StreamReader(openFileDialog9.FileName);
                path9 = openFileDialog3.FileName;
                txtArchivo9.Text = path9;
                sr.Close();
            }
        }
        private void btnCargarArchivo10_Click(object sender, EventArgs e)
        {
            if (openFileDialog10.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string path10 = "";
                System.IO.StreamReader sr = new
                   System.IO.StreamReader(openFileDialog10.FileName);
                path10 = openFileDialog10.FileName;
                txtArchivo10.Text = path10;
                sr.Close();
            }
        }
        #endregion
        #region Botones
        private void btnGuardarHistorial_Click(object sender, EventArgs e)
        {
            try
            {
                string aaa = "";
                PericiaHistoriaWF periciaForm = new PericiaHistoriaWF(aaa);
                periciaForm.Enabled = false;

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
                    btnNuevaHistoria.Visible = true;
                    btnVolver.Visible = true;
                    periciaForm.Enabled = true;
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
            btnNuevaHistoria.Visible = false;
            btnVolver.Visible = false;
            grbTexto.Visible = false;
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
        private void btnVolver_Click(object sender, EventArgs e)
        {
            Close();
            PericiasWF _pericia = new PericiasWF();
            _pericia.Show();
        }
        private void btnAbrir1_Click(object sender, EventArgs e)
        {
            Process.Start("explorer.exe", txtAdjunto1.Text);
        }
        private void btnAbrir2_Click(object sender, EventArgs e)
        {
            Process.Start("explorer.exe", txtAdjunto2.Text);
        }
        private void btnAbrir3_Click(object sender, EventArgs e)
        {
            Process.Start("explorer.exe", txtAdjunto3.Text);
        }
        private void btnAbrir4_Click(object sender, EventArgs e)
        {
            Process.Start("explorer.exe", txtAdjunto4.Text);
        }
        private void btnAbrir5_Click(object sender, EventArgs e)
        {
            Process.Start("explorer.exe", txtAdjunto5.Text);
        }
        private void btnAbrir6_Click(object sender, EventArgs e)
        {
            Process.Start("explorer.exe", txtAdjunto6.Text);
        }
        private void btnAbrir7_Click(object sender, EventArgs e)
        {
            Process.Start("explorer.exe", txtAdjunto7.Text);
        }
        private void btnAbrir8_Click(object sender, EventArgs e)
        {
            Process.Start("explorer.exe", txtAdjunto8.Text);
        }
        private void btnAbrir9_Click(object sender, EventArgs e)
        {
            Process.Start("explorer.exe", txtAdjunto9.Text);
        }
        private void btnAbrir10_Click(object sender, EventArgs e)
        {
            Process.Start("explorer.exe", txtAdjunto10.Text);
        }
        #endregion
        private void cmbEstado_Click(object sender, EventArgs e)
        {
            CargarComboEstado();
        }
        private void btnGenerarTexto_Click(object sender, EventArgs e)
        {
            groupBox2.Visible = false;
            groupBox3.Visible = false;
            grbTexto.Visible = true;
            btnNuevaHistoria.Visible = true;
            btnVolver.Visible = true;
            btnGenerarTexto.Visible = false;
            txtTexto.Focus();
        }
        private void chcRedactar_CheckedChanged(object sender, EventArgs e)
        {
            if (chcRedactar.Checked == true)
            {
                txtTexto.Clear();
                cmbRespuestas.Visible = false;
                chcRespuestaPredefinida.Checked = false;
            }
        }
        private void chcRespuestaPredefinida_CheckedChanged(object sender, EventArgs e)
        {
            if (chcRespuestaPredefinida.Checked == true)
            {
                chcRedactar.Checked = false;
                cmbRespuestas.Visible = true;
                CargarComboRespuestas();
                cmbRespuestas.Enabled = true;
            }
        }
        private void CargarComboRespuestas()
        {
            List<string> Plantillas = new List<string>();
            Plantillas = PericiaNeg.CargarComboRespuestas();
            cmbRespuestas.Items.Clear();
            cmbRespuestas.Text = "Seleccione";
            cmbRespuestas.Items.Add("Seleccione");
            foreach (string item in Plantillas)
            {
                cmbRespuestas.Text = "Seleccione";
                cmbRespuestas.Items.Add(item);
            }
        }
        private void cmbRespuestas_Click(object sender, EventArgs e)
        {
            try
            {
                string var = cmbRespuestas.Text;
                if (var != "Seleccione")
                {
                    List<string> Texto = new List<string>();
                    Texto = PericiaNeg.CargarComboRespuestasPorTituloSeleccionado(var);
                    if (Texto.Count > 0)
                    {
                        CargarTextoEnPantalla(Texto);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void CargarTextoEnPantalla(List<string> texto)
        {
            Entidades.Pericias _pericia = CargarEntidad();
            if (cmbRespuestas.Text == "Perito contador solicita domicilio de compulsa")
            {
                var textoNuevo = texto.First();
                string Plantilla = textoNuevo;
                string Causa = _pericia.Causa;
                string NroCausa = "N°" + _pericia.NroCausa;
                string Tribunal = _pericia.Tribunal;
                string source = Plantilla;
                var replacement = source.Replace("@Causa", '"' + Causa + '"');
                var replacement2 = replacement.Replace("@NroCausa", '"' + NroCausa + '"');
                var replacement3 = replacement2.Replace("@Tribunal", '"' + Tribunal + '"');
                var replacement4 = replacement3.Replace("<Salto>", "\r\n");
                var replacement5 = replacement4.Replace('"', ' ');
                var replacement6 = replacement5.Replace('+', ' ');
                txtTexto.Text = replacement6;
            }
            if (cmbRespuestas.Text == "Escrito Perito Contado Acepta Cargo")
            {
                var textoNuevo = texto.First();
                string Plantilla = textoNuevo;
                string Causa = _pericia.Causa;
                string NroCausa = "N°" + _pericia.NroCausa;
                string Tribunal = _pericia.Tribunal;
                string source = Plantilla;
                var replacement = source.Replace("+ @Causa +", '"' + Causa + '"');
                var replacement2 = replacement.Replace("+ @NroCausa +", '"' + NroCausa + '"');
                var replacement3 = replacement2.Replace("+ @Tribunal +", '"' + Tribunal + '"');
                var replacement4 = replacement3.Replace("<Salto>", "\r\n");
                var replacement5 = replacement4.Replace('"', ' ');
                var replacement6 = replacement5.Replace('+', ' ');
                txtTexto.Text = replacement6;
            }
        }
        private void btnGenerarEscrito_Click(object sender, EventArgs e)
        {
            Entidades.Pericias _pericia = CargarEntidad();
            if (cmbRespuestas.Text == "Perito contador solicita domicilio de compulsa")
            {
                Microsoft.Office.Interop.Word._Application oWord = new Microsoft.Office.Interop.Word.Application();
                oWord.Visible = true;
                var oDoc = oWord.Documents.Add();
                var paragraph1 = oDoc.Content.Paragraphs.Add();
                paragraph1.Range.Text = txtTexto.Text;
                //paragraph1.Range.Font.Bold = 1;
                paragraph1.Format.SpaceAfter = 24;
                string NombreArchivo = "Domicilio de compulsa" + " " + "Causa N°" + _pericia.NroCausa; /*_pericia.Causa; +;*/
                oDoc.SaveAs2(@"C:\Sico-Setup\Dropbox\Escritos\" + NombreArchivo + "'");
                oWord.Quit();

                const string message2 = "Se genero y se guardo el escrito exitosamente.";
                const string caption2 = "Éxito";
                var result2 = MessageBox.Show(message2, caption2,
                                             MessageBoxButtons.OK,
                                             MessageBoxIcon.Asterisk);

            }

            if (cmbRespuestas.Text == "Escrito Perito Contado Acepta Cargo")
            {
                Microsoft.Office.Interop.Word._Application oWord = new Microsoft.Office.Interop.Word.Application();
                oWord.Visible = true;
                var oDoc = oWord.Documents.Add();
                var paragraph1 = oDoc.Content.Paragraphs.Add();
                paragraph1.Range.Text = txtTexto.Text;
                //paragraph1.Range.Font.Bold = 1;
                paragraph1.Format.SpaceAfter = 24;
                string NombreArchivo = "Acepta Cargo" + " " + " " + "Causa N°" + _pericia.NroCausa; /*_pericia.Causa + "Causa N°" + _pericia.NroCausa;*/
                oDoc.SaveAs2(@"C:\Sico-Setup\Dropbox\Escritos\" + NombreArchivo + "'");
                oWord.Quit();

                const string message2 = "Se genero y se guardo el escrito exitosamente.";
                const string caption2 = "Éxito";
                var result2 = MessageBox.Show(message2, caption2,
                                             MessageBoxButtons.OK,
                                             MessageBoxIcon.Asterisk);
            }
        }
        private void btnMandarEmail_Click(object sender, EventArgs e)
        {
            if (chcRedactar.Checked)
            {
                txtAsunto.Text = "";
                grbCuentaEmail.Visible = true;
                txtCuentaEmail.Focus();
                btnMandarEmail.Visible = false;
                btnGenerarEscrito.Visible = false;
            }
            if (chcRespuestaPredefinida.Checked)
            {
                txtAsunto.Text = cmbRespuestas.Text;
                grbCuentaEmail.Visible = true;
                txtCuentaEmail.Focus();
                btnMandarEmail.Visible = false;
                btnGenerarEscrito.Visible = false;
            }
        }
        private void btnEnviarEmail_Click(object sender, EventArgs e)
        {
            bool Exito = false;
            Entidades.Pericias _pericia = CargarEntidad();
            if (!String.IsNullOrEmpty(txtCuentaEmail.Text) & !String.IsNullOrEmpty(txtAsunto.Text))
            {
                Exito = PericiaNeg.EnviarEmailConEscrito(txtTexto.Text, txtCuentaEmail.Text, _pericia.UsuarioLogin, cmbRespuestas.Text);
            }
            else
            {
                const string message = "Los campos Asuntos y cuenta de email son obligatorios.";
                const string caption = "Atención";
                var result = MessageBox.Show(message, caption,
                                             MessageBoxButtons.OK,
                                           MessageBoxIcon.Warning);
            }
            if (Exito == true)
            {
                const string message2 = "Se envio el email correctamente.";
                const string caption2 = "Éxito";
                var result2 = MessageBox.Show(message2, caption2,
                                             MessageBoxButtons.OK,
                                             MessageBoxIcon.Asterisk);
            }
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtCuentaEmail.Clear();
            grbCuentaEmail.Visible = false;
            btnGenerarEscrito.Visible = true;
            btnMandarEmail.Visible = true;
        }
    }
}
