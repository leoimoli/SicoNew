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
    public partial class ConfigurarVencimientosWF : Form
    {
        public ConfigurarVencimientosWF()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string Año = cmbAño.Text;
            var TipoVencimiento = cmbTipoVencimiento.Text;
            var split1 = TipoVencimiento.Split('-')[0];
            split1 = split1.Trim();
            int idTipoVencimiento = Convert.ToInt32(split1);
            string DiaVencimiento = txtDia.Text;
            bool Exito = ClienteNeg.GuardarVencimiento(Año, idTipoVencimiento, DiaVencimiento);
            if (Exito == true)
            {
                ProgressBar();
                const string message2 = "Se registro el vencimiento exitosamente.";
                const string caption2 = "Éxito";
                var result2 = MessageBox.Show(message2, caption2,
                                             MessageBoxButtons.OK,
                                             MessageBoxIcon.Asterisk);
                LimpiarCampos();
            }
            else
            {

            }        }
        private void LimpiarCampos()
        {
            txtDia.Clear();
            progressBar1.Value = Convert.ToInt32(null);
            progressBar1.Visible = false;
            CargarCombos();
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
        private void ConfigurarVencimientosWF_Load(object sender, EventArgs e)
        {
            CargarCombos();
        }
        private void CargarCombos()
        {
            string[] Años = Clases_Maestras.ValoresConstantes.Años;
            cmbAño.Items.Add("Seleccione");
            cmbAño.Items.Clear();
            foreach (string item in Años)
            {
                cmbAño.Text = "Seleccione";
                cmbAño.Items.Add(item);
            }

            List<string> TipoVencimientos = new List<string>();
            TipoVencimientos = ClienteNeg.CargarComboTipoVencimientos();
            cmbTipoVencimiento.Items.Clear();
            cmbTipoVencimiento.Text = "Seleccione";
            cmbTipoVencimiento.Items.Add("Seleccione");
            foreach (string item in TipoVencimientos)
            {
                cmbTipoVencimiento.Text = "Seleccione";
                cmbTipoVencimiento.Items.Add(item);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            InicioWF _inicio = new InicioWF();
            _inicio.Show();
            Hide();
        }
    }
}
