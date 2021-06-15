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
using Sico.Clases_Maestras;
using Sico.Dao;
using Sico.Entidades;

namespace Sico
{
    public partial class CargaMasivaSubClientesWF : Form
    {
        public CargaMasivaSubClientesWF()
        {
            InitializeComponent();
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

        private void btnCargarDatos_Click(object sender, EventArgs e)
        {
            ProgressBar();
            btnCargarDatos.Enabled = false;
            Datos();
            btnCargaMasiva.Enabled = true;
            LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            progressBar1.Value = Convert.ToInt32(null);
            progressBar1.Visible = false;
        }

        private void Datos()
        {
            string RutaCargada = txtRuta.Text;
            Ventas_CargaMasiva ruta = new Ventas_CargaMasiva();
            //Obtenemos el archivo desde la ubicación actual
            var executableFolderPath = ruta.Carpeta;
            //Hoja desde donde obtendremos los datos
            string hoja = "Hoja1";
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

                if (data.Rows.Count > 0)
                {
                    foreach (DataRow item in data.Rows)
                    {
                        ////// Para Importar Factura C
                        Entidades.SubCliente list = new Entidades.SubCliente();
                        list.ApellidoNombre = item[0].ToString();
                        if (list.Fecha == "ApellidoNombre")
                        { continue; }
                        if (item[1].ToString() != "")
                        { list.Dni = item[1].ToString(); }
                        else { list.Dni = ""; }

                        if (item[2].ToString() != "")
                        { list.Direccion = item[2].ToString(); }
                        else { list.Direccion = ""; }

                        if (item[3].ToString() != "")
                        { list.Observacion = item[3].ToString(); }
                        else { list.Observacion = ""; }

                        list.idCliente = Convert.ToInt32(item[4].ToString());

                        if (item[5].ToString() != "")
                        { list.TipoDNI = item[5].ToString(); }
                        else { list.TipoDNI = ""; }
                        if (list.Dni == "CUIT")
                        {
                            list.TipoDNI = "80";
                        }
                        if (list.Dni == "DNI")
                        {
                            list.TipoDNI = "96";
                        }
                        listaSubCliente.Add(list);
                    }
                }
                ListaSublCliente = listaSubCliente;
                ArmarGrilla(ListaSublCliente);
                btnCargaMasiva.Visible = true;
            }
            catch (Exception ex)
            { }
        }

        private void ArmarGrilla(List<SubCliente> listaFacturasVentas)
        {
            if (listaFacturasVentas.Count > 0)
            {
                dataGridView1.Visible = true;
                foreach (var item in listaFacturasVentas)
                {
                    dataGridView1.Rows.Add(item.ApellidoNombre, item.Dni, item.Direccion, item.Observacion, item.idCliente, item.TipoDNI);
                }
            }
        }

        public static List<Entidades.SubCliente> ListaSublCliente;

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

        private void btnCargaMasiva_Click(object sender, EventArgs e)
        {
            try
            {
                ProgressBar();
                int Exito = ClienteDao.CargaMasivaSublCiente(ListaSublCliente);
                if (Exito > 0)
                {
                    string Numero = Convert.ToString(Exito);
                    string message2 = "Se registraron '" + Numero + "' facturas exitosamente.";
                    const string caption2 = "Éxito";
                    var result2 = MessageBox.Show(message2, caption2,
                                                 MessageBoxButtons.OK,
                                                 MessageBoxIcon.Asterisk);
                    LimpiarCampos();
                    //dataGridView1.Rows.Clear();
                }
                if (Exito == 0)
                {

                    string message2 = "Las facturas que intento cargar ya se encontraban registradas.";
                    const string caption2 = "Atención";
                    var result2 = MessageBox.Show(message2, caption2,
                                                 MessageBoxButtons.OK,
                                                 MessageBoxIcon.Exclamation);
                    LimpiarCampos();
                }
                if (Exito != 0 && Exito < 0)
                {
                    const string message2 = "Algo falló.";
                    const string caption2 = "Error";
                    var result2 = MessageBox.Show(message2, caption2,
                                                 MessageBoxButtons.OK,
                                                 MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            { }
        }
    }
}
