using Sico.Clases_Maestras;
using Sico.Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sico
{
    public partial class VentasImportarFacturasWF : Form
    {
        private string cuit;
        private string razonSocial;
        public VentasImportarFacturasWF(string razonSocial, string cuit)
        {
            InitializeComponent();
            this.razonSocial = razonSocial;
            this.cuit = cuit;
        }
        private void VentasImportarFacturasWF_Load(object sender, EventArgs e)
        {
            try
            {
                lblCuitEdit.Text = cuit;
                lblNombreEdit.Text = razonSocial;
                CargarCombo();
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
        private void CargarCombo()
        {
            List<string> Periodo = new List<string>();
            Periodo = PeriodoNeg.CargarComboPeriodoVenta(cuit);
            cmbPeriodo.Items.Clear();
            foreach (string item in Periodo)
            {

                cmbPeriodo.Items.Add(item);
            }
        }
        private void bntCargarDatos_Click(object sender, EventArgs e)
        {
            ProgressBar();
            btnCargarDatos.Enabled = false;
            Datos();
            LimpiarCampos();
        }
        public void LimpiarCampos()
        {
            progressBar1.Value = Convert.ToInt32(null);
            progressBar1.Visible = false;
            btnVolver.Enabled = true;
        }
        private void Datos()
        {
            string RutaCargada = txtRuta.Text;
            Ventas_CargaMasiva ruta = new Ventas_CargaMasiva();
            //Obtenemos el archivo desde la ubicación actual
            var executableFolderPath = ruta.Carpeta;
            //Hoja desde donde obtendremos los datos
            string hoja = "Sheet1";
            //Cadena de conexión
            string conexion = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" +
                           RutaCargada +
                            ";Extended Properties='Excel 12.0;HDR=YES;';";

            OleDbConnection con = new OleDbConnection(conexion);
            //Consulta contra la hoja de Excel
            OleDbCommand cmd = new OleDbCommand("Select * From [" + hoja + "$]", con);
            List<Entidades.SubCliente> listaSubCliente = new List<Entidades.SubCliente>();
            try
            {
                //Conectarse al archivo de Excel
                con.Open();
                OleDbDataAdapter sda = new OleDbDataAdapter(cmd);
                DataTable data = new DataTable();
                //Cargar los datos
                sda.Fill(data);
                //Cargar la grilla
                if (data.Rows.Count > 0)
                {
                    foreach (DataRow item in data.Rows)
                    {
                        ////// Para Importar Factura C
                        Entidades.SubCliente list = new Entidades.SubCliente();
                        list.TipoComprobante = item[1].ToString();
                        if (list.TipoComprobante == "11 - Factura C")
                        {
                            list.Fecha = item[0].ToString();
                            list.NroFactura = item[2].ToString() + "|" + item[3].ToString();
                            list.Dni = item[6].ToString();
                            list.Dni = item[7].ToString();
                            list.ApellidoNombre = item[8].ToString();
                            list.TipoDeCambio = item[9].ToString();
                            list.CodigoMoneda = item[10].ToString();
                            list.Monto = Convert.ToDecimal(item[15].ToString());
                            listaSubCliente.Add(list);
                        }
                    }
                }
                ListaFacturasVentas = listaSubCliente;
                btnCargaMasiva.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error en la lectura del archivo");
            }
            finally
            {
                //Funcione o no, cerramos la cadena de conexión
                con.Close();

            }
        }

        public static List<Entidades.SubCliente> ListaPrecargada;
        public List<Entidades.SubCliente> ListaFacturasVentas
        {
            set
            {
                dataGridView1.DataSource = value;
                dataGridView1.Visible = true;
                var contadortotal = value.Count;
                label4.Visible = true;
                label5.Visible = true;
                label4.Text = Convert.ToString(contadortotal);
                ListaPrecargada = value;

                dataGridView1.Columns[0].HeaderText = "Id Movimiento";
                dataGridView1.Columns[0].Width = 130;
                dataGridView1.Columns[0].HeaderCell.Style.BackColor = Color.DarkBlue;
                dataGridView1.Columns[0].HeaderCell.Style.Font = new System.Drawing.Font("Tahoma", 8, FontStyle.Bold);
                dataGridView1.Columns[0].HeaderCell.Style.ForeColor = Color.White;
                dataGridView1.Columns[0].Visible = false;

                dataGridView1.Columns[1].HeaderText = "Nro.Factura";
                dataGridView1.Columns[1].Width = 130;
                dataGridView1.Columns[1].HeaderCell.Style.BackColor = Color.DarkBlue;
                dataGridView1.Columns[1].HeaderCell.Style.Font = new System.Drawing.Font("Tahoma", 8, FontStyle.Bold);
                dataGridView1.Columns[1].HeaderCell.Style.ForeColor = Color.White;

                dataGridView1.Columns[2].HeaderText = "Fecha";
                dataGridView1.Columns[2].Width = 80;
                dataGridView1.Columns[2].HeaderCell.Style.BackColor = Color.DarkBlue;
                dataGridView1.Columns[2].HeaderCell.Style.Font = new System.Drawing.Font("Tahoma", 8, FontStyle.Bold);
                dataGridView1.Columns[2].HeaderCell.Style.ForeColor = Color.White;

                dataGridView1.Columns[3].HeaderText = "Persona";
                dataGridView1.Columns[3].Width = 200;
                dataGridView1.Columns[3].HeaderCell.Style.BackColor = Color.DarkBlue;
                dataGridView1.Columns[3].HeaderCell.Style.Font = new System.Drawing.Font("Tahoma", 8, FontStyle.Bold);
                dataGridView1.Columns[3].HeaderCell.Style.ForeColor = Color.White;
                dataGridView1.Columns[3].Visible = true;

                dataGridView1.Columns[4].HeaderText = "Dni";
                dataGridView1.Columns[4].Width = 80;
                dataGridView1.Columns[4].HeaderCell.Style.BackColor = Color.DarkBlue;
                dataGridView1.Columns[4].HeaderCell.Style.Font = new System.Drawing.Font("Tahoma", 8, FontStyle.Bold);
                dataGridView1.Columns[4].HeaderCell.Style.ForeColor = Color.White;
                dataGridView1.Columns[4].Visible = true;

                dataGridView1.Columns[5].HeaderText = "Dirección";
                dataGridView1.Columns[5].Width = 250;
                dataGridView1.Columns[5].HeaderCell.Style.BackColor = Color.DarkBlue;
                dataGridView1.Columns[5].HeaderCell.Style.Font = new System.Drawing.Font("Tahoma", 8, FontStyle.Bold);
                dataGridView1.Columns[5].HeaderCell.Style.ForeColor = Color.White;
                dataGridView1.Columns[5].Visible = false;

                dataGridView1.Columns[6].HeaderText = "Monto";
                dataGridView1.Columns[6].Width = 100;
                dataGridView1.Columns[6].HeaderCell.Style.BackColor = Color.DarkBlue;
                dataGridView1.Columns[6].HeaderCell.Style.Font = new System.Drawing.Font("Tahoma", 10, FontStyle.Bold);
                dataGridView1.Columns[6].HeaderCell.Style.ForeColor = Color.White;
                dataGridView1.Columns[6].Visible = true;

                dataGridView1.Columns[7].HeaderText = "Cliente";
                dataGridView1.Columns[7].Width = 95;
                dataGridView1.Columns[7].HeaderCell.Style.BackColor = Color.DarkBlue;
                dataGridView1.Columns[7].HeaderCell.Style.Font = new System.Drawing.Font("Tahoma", 8, FontStyle.Bold);
                dataGridView1.Columns[7].HeaderCell.Style.ForeColor = Color.White;
                dataGridView1.Columns[7].Visible = false;

                dataGridView1.Columns[8].HeaderText = "Importe 1";
                dataGridView1.Columns[8].Visible = false;

                dataGridView1.Columns[9].HeaderText = "Importe 2";
                dataGridView1.Columns[9].Visible = false;

                dataGridView1.Columns[10].HeaderText = "Importe 3";
                dataGridView1.Columns[10].Visible = false;

                dataGridView1.Columns[11].HeaderText = "Neto al 10,5";
                dataGridView1.Columns[11].Visible = false;
                dataGridView1.Columns[11].Width = 80;
                dataGridView1.Columns[11].HeaderCell.Style.BackColor = Color.DarkBlue;
                dataGridView1.Columns[11].HeaderCell.Style.Font = new System.Drawing.Font("Tahoma", 8, FontStyle.Bold);

                dataGridView1.Columns[12].HeaderText = "Neto al 21";
                dataGridView1.Columns[12].Visible = false;
                dataGridView1.Columns[12].Width = 80;
                dataGridView1.Columns[12].HeaderCell.Style.BackColor = Color.DarkBlue;
                dataGridView1.Columns[12].HeaderCell.Style.Font = new System.Drawing.Font("Tahoma", 8, FontStyle.Bold);

                dataGridView1.Columns[13].HeaderText = "Neto al 27";
                dataGridView1.Columns[13].Visible = false;
                dataGridView1.Columns[13].Width = 80;
                dataGridView1.Columns[13].HeaderCell.Style.BackColor = Color.DarkBlue;
                dataGridView1.Columns[13].HeaderCell.Style.Font = new System.Drawing.Font("Tahoma", 8, FontStyle.Bold);

                dataGridView1.Columns[14].HeaderText = "alicuota 1";
                dataGridView1.Columns[14].Visible = false;

                dataGridView1.Columns[15].HeaderText = "alicuota 2";
                dataGridView1.Columns[15].Visible = false;

                dataGridView1.Columns[16].HeaderText = "alicuota 3";
                dataGridView1.Columns[16].Visible = false;

                dataGridView1.Columns[17].HeaderText = "Iva al 10,5";
                dataGridView1.Columns[17].Visible = true;
                dataGridView1.Columns[17].Width = 80;
                dataGridView1.Columns[17].HeaderCell.Style.BackColor = Color.DarkBlue;
                dataGridView1.Columns[17].HeaderCell.Style.Font = new System.Drawing.Font("Tahoma", 8, FontStyle.Bold);

                dataGridView1.Columns[18].HeaderText = "Iva al 21";
                dataGridView1.Columns[18].Visible = false;
                dataGridView1.Columns[18].Width = 80;
                dataGridView1.Columns[18].HeaderCell.Style.BackColor = Color.DarkBlue;
                dataGridView1.Columns[18].HeaderCell.Style.Font = new System.Drawing.Font("Tahoma", 8, FontStyle.Bold);

                dataGridView1.Columns[19].HeaderText = "Iva al 27";
                dataGridView1.Columns[19].Visible = false;
                dataGridView1.Columns[19].Width = 80;
                dataGridView1.Columns[19].HeaderCell.Style.BackColor = Color.DarkBlue;
                dataGridView1.Columns[19].HeaderCell.Style.Font = new System.Drawing.Font("Tahoma", 8, FontStyle.Bold);

                dataGridView1.Columns[20].HeaderText = "Observacion";
                dataGridView1.Columns[20].Visible = false;

                dataGridView1.Columns[21].HeaderText = "Nota De Credito";
                dataGridView1.Columns[21].Visible = false;
                dataGridView1.Columns[21].Width = 80;
                dataGridView1.Columns[21].HeaderCell.Style.BackColor = Color.DarkBlue;
                dataGridView1.Columns[21].HeaderCell.Style.Font = new System.Drawing.Font("Tahoma", 8, FontStyle.Bold);

                dataGridView1.Columns[22].HeaderText = "Observacion";
                dataGridView1.Columns[22].Visible = false;


                dataGridView1.Columns[23].HeaderText = "Observacion";
                dataGridView1.Columns[23].Visible = false;


                dataGridView1.Columns[24].HeaderText = "Observacion";
                dataGridView1.Columns[24].Visible = false;


                dataGridView1.Columns[25].HeaderText = "Observacion";
                dataGridView1.Columns[25].Visible = false;


                dataGridView1.Columns[26].HeaderText = "Código de Operación";
                dataGridView1.Columns[26].Width = 80;
                dataGridView1.Columns[26].HeaderCell.Style.BackColor = Color.DarkBlue;
                dataGridView1.Columns[26].HeaderCell.Style.Font = new System.Drawing.Font("Tahoma", 8, FontStyle.Bold);



                dataGridView1.Columns[27].HeaderText = "Tipo de cambio";

                dataGridView1.Columns[27].Width = 80;
                dataGridView1.Columns[27].HeaderCell.Style.BackColor = Color.DarkBlue;
                dataGridView1.Columns[27].HeaderCell.Style.Font = new System.Drawing.Font("Tahoma", 8, FontStyle.Bold);

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
        private void btnCargarArchivo_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string path = "";
                System.IO.StreamReader sr = new
                   System.IO.StreamReader(openFileDialog1.FileName);
                path = openFileDialog1.FileName;
                txtRuta.Text = path;
                sr.Close();
            }
        }
        private void btnCargaMasiva_Click(object sender, EventArgs e)
        {
            try
            {
                ProgressBar();
                string Periodo = cmbPeriodo.Text;
                bool Exito = ClienteNeg.GuardarCargaMasivaVentas(ListaPrecargada, cuit, Periodo);
                if (Exito == true)
                {
                    const string message2 = "Se registro la factura exitosamente.";
                    const string caption2 = "Éxito";
                    var result2 = MessageBox.Show(message2, caption2,
                                                 MessageBoxButtons.OK,
                                                 MessageBoxIcon.Asterisk);
                    LimpiarCampos();
                }

                else
                {
                    const string message2 = "Algo fallo.";
                    const string caption2 = "Error";
                    var result2 = MessageBox.Show(message2, caption2,
                                                 MessageBoxButtons.OK,
                                                 MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            { }
        }

        private void btnCrearPeriodo_Click(object sender, EventArgs e)
        {
            PeriodosVentasWF _periodo = new PeriodosVentasWF(cuit, razonSocial);
            _periodo.Show();
        }
        private void btnActualizarCombo_Click(object sender, EventArgs e)
        {
            CargarCombo();
        }
    }
}
