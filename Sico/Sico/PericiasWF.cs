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
using System.IO;
using System.IO.Compression;
using System.Threading;
using Sico.Dao;


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
            groupBox1.Visible = true;
            groupBox1.Enabled = true;
            cmbTribunal.Focus();
            groupBox1.Text = "Nueva Pericia";
            btnHabilitarBuscar.Visible = true;
            txtArchivo1.Clear();
            txtArchivo2.Clear();
            txtArchivo3.Clear();
            dgvPericias.Visible = false;
            btnCargarArchivo10.Visible = true;
            txtCausaBuscar.AutoCompleteCustomSource = Clases_Maestras.AutoCompleteCausa.Autocomplete();
            txtCausaBuscar.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtCausaBuscar.AutoCompleteSource = AutoCompleteSource.CustomSource;
            grbEnlances.Visible = false;
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
                List<CuentaEmailPorUsuario> cuenta = new List<CuentaEmailPorUsuario>();
                cuenta = UsuarioDao.BuscarCuentaEmailPorUsuario(Sesion.UsuarioLogueado.IdUsuario);
                if (cuenta.Count <= 0)
                {
                    const string message = "Desea agregar una cuenta de email relacionada al usuario login nuevo producto ?";
                    const string caption = "Cuenta de Email inexistente";
                    var result = MessageBox.Show(message, caption,
                                                 MessageBoxButtons.YesNo,
                                                 MessageBoxIcon.Question);
                    {
                        if (result == DialogResult.Yes)
                        {
                            CuentaEmailWF _cuenta = new CuentaEmailWF();
                            _cuenta.Show();
                        }
                        else
                        { }

                    }
                }
                txtEmail.AutoCompleteCustomSource = Clases_Maestras.AutoCompleteClassEmailPericia.Autocomplete();
                txtEmail.AutoCompleteMode = AutoCompleteMode.Suggest;
                txtEmail.AutoCompleteSource = AutoCompleteSource.CustomSource;
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
            txtArchivo4.Clear();
            txtArchivo5.Clear();
            txtArchivo6.Clear();
            txtArchivo7.Clear();
            txtArchivo8.Clear();
            txtArchivo9.Clear();
            txtArchivo10.Clear();
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
            _pericia.Archivo4 = txtArchivo4.Text;
            _pericia.Archivo5 = txtArchivo5.Text;
            _pericia.Archivo6 = txtArchivo6.Text;
            _pericia.Archivo7 = txtArchivo7.Text;
            _pericia.Archivo8 = txtArchivo8.Text;
            _pericia.Archivo9 = txtArchivo9.Text;
            _pericia.Archivo10 = txtArchivo10.Text;
            _pericia.Email = txtEmail.Text;
            _pericia.UsuarioLogin = Sesion.UsuarioLogueado.IdUsuario;
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
            groupBox1.Visible = false;
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
                txtCausaBuscar.Enabled = true;
                txtCausaBuscar.Focus();
                txtCausaBuscar.Visible = true;
                cmbTribunalBuscar.Visible = false;
                chcPorTribunal.Checked = false;
                lblDniOApellidoNombre.Text = "Buscar Por Causa(*):";
                txtCausaBuscar.AutoCompleteCustomSource = Clases_Maestras.AutoCompleteCausa.Autocomplete();
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
                    grbEnlances.Visible = true;
                    btnCargarArchivo10.Visible = false;
                    btnBuscar.Visible = true;
                    groupBox1.Visible = true;
                    groupBox1.Enabled = true;
                    dgvPericias.Visible = true;
                    dgvPericias.ReadOnly = true;
                    dgvPericias.RowHeadersVisible = false;
                    dgvPericias.DataSource = value;

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

                    dgvPericias.Columns[9].HeaderText = "Email compartido";
                    dgvPericias.Columns[9].Width = 120;
                    dgvPericias.Columns[9].HeaderCell.Style.BackColor = Color.DarkBlue;
                    dgvPericias.Columns[9].HeaderCell.Style.Font = new System.Drawing.Font("Tahoma", 10, FontStyle.Bold);
                    dgvPericias.Columns[9].HeaderCell.Style.ForeColor = Color.White;

                    dgvPericias.Columns[10].HeaderText = "Estado";
                    dgvPericias.Columns[10].Width = 100;
                    dgvPericias.Columns[10].HeaderCell.Style.BackColor = Color.DarkBlue;
                    dgvPericias.Columns[10].HeaderCell.Style.Font = new System.Drawing.Font("Tahoma", 10, FontStyle.Bold);
                    dgvPericias.Columns[10].HeaderCell.Style.ForeColor = Color.White;

                    dgvPericias.Columns[11].HeaderText = "Descripcion";
                    dgvPericias.Columns[11].Width = 95;
                    dgvPericias.Columns[11].HeaderCell.Style.BackColor = Color.DarkBlue;
                    dgvPericias.Columns[11].HeaderCell.Style.Font = new System.Drawing.Font("Tahoma", 10, FontStyle.Bold);
                    dgvPericias.Columns[11].HeaderCell.Style.ForeColor = Color.White;
                    dgvPericias.Columns[11].Visible = false;

                    dgvPericias.Columns[12].HeaderText = "TotalPericias";
                    dgvPericias.Columns[12].Width = 95;
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

                    DataGridViewButtonColumn BotonVer = new DataGridViewButtonColumn();
                    BotonVer.Name = "Ver";
                    BotonVer.HeaderText = "Ver";
                    this.dgvPericias.Columns.Add(BotonVer);
                    dgvPericias.Columns[22].Width = 55;
                    dgvPericias.Columns[22].HeaderCell.Style.BackColor = Color.DarkBlue;
                    dgvPericias.Columns[22].HeaderCell.Style.Font = new Font("Tahoma", 10, FontStyle.Bold);
                    dgvPericias.Columns[22].HeaderCell.Style.ForeColor = Color.White;

                }
                else { MessageBox.Show("No se encontraron resultados para los filtros seleccionados."); }
            }
        }
        private void dgvPericias_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex >= 0 && this.dgvPericias.Columns[e.ColumnIndex].Name == "Ver" && e.RowIndex >= 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                DataGridViewButtonCell celBoton = this.dgvPericias.Rows[e.RowIndex].Cells["Ver"] as DataGridViewButtonCell;
                Icon icoAtomico = new Icon(Environment.CurrentDirectory + "\\" + @"lupa.ico");
                e.Graphics.DrawIcon(icoAtomico, e.CellBounds.Left + 3, e.CellBounds.Top + 3);

                this.dgvPericias.Rows[e.RowIndex].Height = icoAtomico.Height + 6;
                this.dgvPericias.Columns[e.ColumnIndex].Width = icoAtomico.Width + 6;

                e.Handled = true;
            }
        }
        private void ClickBoton(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvPericias.CurrentCell.ColumnIndex == 22)
            {
                var idPericia = Convert.ToString(this.dgvPericias.CurrentRow.Cells[0].Value);
                PericiaHistoriaWF _vista = new PericiaHistoriaWF(idPericia);
                _vista.Show();
                Hide();
            }
        }
        private void imgJudicial1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("IExplore.exe", "https://notificaciones.scba.gov.ar/");
        }
        private void imgJudicialMesaDeEntrada_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://mev.scba.gov.ar/loguin.asp");
        }
        private void imgMinisterioDeTrabajo_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://convenios.trabajo.gob.ar/ConsultaWeb/consultaBasica.asp");
        }
        private void imgAfip_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.afip.gob.ar/sitio/externos/default.asp");
        }
        //private void imgApr_Click(object sender, EventArgs e)
        //{
        //    System.Diagnostics.Process.Start("http://apronline.gov.ar/");
        //}
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
        public static double PesoTotalArchivos;
        public int contadorArchivos;
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
                FileInfo file = new FileInfo(path);
                var Peso = file.Length;
                double PesoArchivos = ((double)Peso / (1024 * 1024));
                if (PesoArchivos > 23.84186)
                {
                    MessageBox.Show("Atención con este adjunto se supera el tamaño limite permitido.");
                    txtArchivo1.Clear();
                }
                else
                {
                    PesoTotalArchivos = PesoTotalArchivos + PesoArchivos;
                }
                contadorArchivos = contadorArchivos + 1;
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
                FileInfo file = new FileInfo(path2);
                var Peso = file.Length;
                double PesoArchivos = ((double)Peso / (1024 * 1024));
                PesoTotalArchivos = PesoArchivos;
                if (PesoArchivos > 23.84186)
                {
                    MessageBox.Show("Atención con este adjunto se supera el tamaño limite permitido.");
                    txtArchivo2.Clear();
                }
                else
                {
                    PesoTotalArchivos = PesoTotalArchivos + PesoArchivos;
                }
                contadorArchivos = contadorArchivos + 1;
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
                FileInfo file = new FileInfo(path3);
                var Peso = file.Length;
                double PesoArchivos = ((double)Peso / (1024 * 1024));
                PesoTotalArchivos = PesoArchivos;
                if (PesoArchivos > 23.84186)
                {
                    MessageBox.Show("Atención con este adjunto se supera el tamaño limite permitido.");
                    txtArchivo3.Clear();
                }
                else
                {
                    PesoTotalArchivos = PesoTotalArchivos + PesoArchivos;
                }
                contadorArchivos = contadorArchivos + 1;
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
                FileInfo file = new FileInfo(path4);
                var Peso = file.Length;
                double PesoArchivos = ((double)Peso / (1024 * 1024));
                PesoTotalArchivos = PesoArchivos;
                if (PesoArchivos > 23.84186)
                {
                    MessageBox.Show("Atención con este adjunto se supera el tamaño limite permitido.");
                    txtArchivo4.Clear();
                }
                else
                {
                    PesoTotalArchivos = PesoTotalArchivos + PesoArchivos;
                }
                contadorArchivos = contadorArchivos + 1;
            }
        }
        private void btnCargarArchivo5_Click(object sender, EventArgs e)
        {
            if (openFileDialog5.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string path5 = "";
                System.IO.StreamReader sr = new
                   System.IO.StreamReader(openFileDialog5.FileName);
                path5 = openFileDialog5.FileName;
                txtArchivo5.Text = path5;
                sr.Close();
                FileInfo file = new FileInfo(path5);
                var Peso = file.Length;
                double PesoArchivos = ((double)Peso / (1024 * 1024));
                PesoTotalArchivos = PesoArchivos;
                if (PesoArchivos > 23.84186)
                {
                    MessageBox.Show("Atención con este adjunto se supera el tamaño limite permitido.");
                    txtArchivo5.Clear();
                }
                else
                {
                    PesoTotalArchivos = PesoTotalArchivos + PesoArchivos;
                }
                contadorArchivos = contadorArchivos + 1;
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
                FileInfo file = new FileInfo(path6);
                var Peso = file.Length;
                double PesoArchivos = ((double)Peso / (1024 * 1024));
                PesoTotalArchivos = PesoArchivos;
                if (PesoArchivos > 23.84186)
                {
                    MessageBox.Show("Atención con este adjunto se supera el tamaño limite permitido.");
                    txtArchivo6.Clear();
                }
                else
                {
                    PesoTotalArchivos = PesoTotalArchivos + PesoArchivos;
                }
            }
            contadorArchivos = contadorArchivos + 1;
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
                FileInfo file = new FileInfo(path7);
                var Peso = file.Length;
                double PesoArchivos = ((double)Peso / (1024 * 1024));
                PesoTotalArchivos = PesoArchivos;
                if (PesoArchivos > 23.84186)
                {
                    MessageBox.Show("Atención con este adjunto se supera el tamaño limite permitido.");
                    txtArchivo7.Clear();
                }
                else
                {
                    PesoTotalArchivos = PesoTotalArchivos + PesoArchivos;
                }
                contadorArchivos = contadorArchivos + 1;
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
                FileInfo file = new FileInfo(path8);
                var Peso = file.Length;
                double PesoArchivos = ((double)Peso / (1024 * 1024));
                PesoTotalArchivos = PesoArchivos;
                if (PesoArchivos > 23.84186)
                {
                    MessageBox.Show("Atención con este adjunto se supera el tamaño limite permitido.");
                    txtArchivo8.Clear();
                }
                else
                {
                    PesoTotalArchivos = PesoTotalArchivos + PesoArchivos;
                }
                contadorArchivos = contadorArchivos + 1;
            }
        }
        private void btnCargarArchivo9_Click(object sender, EventArgs e)
        {
            if (openFileDialog9.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string path9 = "";
                System.IO.StreamReader sr = new
                   System.IO.StreamReader(openFileDialog9.FileName);
                path9 = openFileDialog9.FileName;
                txtArchivo9.Text = path9;
                sr.Close();
                FileInfo file = new FileInfo(path9);
                var Peso = file.Length;
                double PesoArchivos = ((double)Peso / (1024 * 1024));
                PesoTotalArchivos = PesoArchivos;
                if (PesoArchivos > 23.84186)
                {
                    MessageBox.Show("Atención con este adjunto se supera el tamaño limite permitido.");
                    txtArchivo9.Clear();
                }
                else
                {
                    PesoTotalArchivos = PesoTotalArchivos + PesoArchivos;
                }
                contadorArchivos = contadorArchivos + 1;
            }
        }
        private void btnCargarArchivo10_Click(object sender, EventArgs e)
        {
            if (openFileDialog10.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string path10 = "";
                System.IO.StreamReader sr = new
                   System.IO.StreamReader(openFileDialog10.FileName);
                path10 = openFileDialog3.FileName;
                txtArchivo10.Text = path10;
                sr.Close();
                FileInfo file = new FileInfo(path10);
                var Peso = file.Length;
                double PesoArchivos = ((double)Peso / (1024 * 1024));
                PesoTotalArchivos = PesoArchivos;
                if (PesoArchivos > 23.84186)
                {
                    MessageBox.Show("Atención con este adjunto se supera el tamaño limite permitido.");
                    txtArchivo10.Clear();
                }
                else
                {
                    PesoTotalArchivos = PesoTotalArchivos + PesoArchivos;
                }
                contadorArchivos = contadorArchivos + 1;
            }
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (PesoTotalArchivos > 23.84186)
                {
                    const string message = "Atención el peso de los archivos supera el maximo permitido.";
                    const string caption = "Error";
                    var result = MessageBox.Show(message, caption,
                                                 MessageBoxButtons.OK,
                                               MessageBoxIcon.Exclamation);
                    throw new Exception();
                }

                Entidades.Pericias _pericia = CargarEntidad();
                groupBox1.Enabled = false;
                groupBox2.Enabled = false;
                groupBox3.Enabled = false;
                //UploadFile();
                bool Exito = PericiaNeg.GurdarPericia(_pericia);
                if (Exito == true)
                {
                    ProgressBar();
                    const string message2 = "Se registro la pericia exitosamente.";
                    const string caption2 = "Éxito";
                    var result2 = MessageBox.Show(message2, caption2,
                                                 MessageBoxButtons.OK,
                                                 MessageBoxIcon.Asterisk);
                    groupBox1.Enabled = true;
                    groupBox2.Enabled = true;
                    groupBox3.Enabled = true;
                    LimpiarCampos();
                }
                else
                {
                    groupBox1.Enabled = true;
                    groupBox2.Enabled = true;
                    groupBox3.Enabled = true;
                    LimpiarCampos();
                }
            }
            catch (Exception ex) { }
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
        private void PericiasWF_Load(object sender, EventArgs e)
        {

        }      
    }
}
