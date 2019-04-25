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
    public partial class PeriodosVentasWF : Form
    {
        private string razonSocial;
        private string cuit;
        public PeriodosVentasWF(string cuit, string razonSocial)
        {
            InitializeComponent();
            this.cuit = cuit;
            this.razonSocial = razonSocial;
        }

        private void PeriodosVentasWF_Load(object sender, EventArgs e)
        {
            CargarCombo();
        }
        private void CargarCombo()
        {
            string[] Años = Clases_Maestras.ValoresConstantes.Años;
            cmbAño.Items.Add("Seleccione");
            cmbAño.Items.Clear();
            foreach (string item in Años)
            {
                cmbAño.Text = "Seleccione";
                cmbAño.Items.Add(item);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string Año = cmbAño.Text;
            string nombre = txtPeriodo.Text;
            bool Exito = PeriodoNeg.GuardarPeriodoVenta(cuit, nombre, Año);
            if (Exito == true)
            {
                ProgressBar();
                const string message2 = "Se registro el período exitosamente.";
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
            txtPeriodo.Clear();
            progressBar1.Value = Convert.ToInt32(null);
            progressBar1.Visible = false;
            CargarCombo();
        }
        private void btnVolver_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }
    }
}
