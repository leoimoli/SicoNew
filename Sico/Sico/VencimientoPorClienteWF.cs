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
    public partial class VencimientoPorClienteWF : Form
    {
        private string cuit;
        private string razonSocial;

        public VencimientoPorClienteWF(string razonSocial, string cuit)
        {
            InitializeComponent();
            this.razonSocial = razonSocial;
            this.cuit = cuit;
        }

        private void VencimientoPorClienteWF_Load(object sender, EventArgs e)
        {
            lblNombreEdit.Text = razonSocial;
            lblCuitEdit.Text = cuit;
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

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string Año = cmbAño.Text;
            var TipoVencimiento = cmbTipoVencimiento.Text;
            var split1 = TipoVencimiento.Split('-')[0];
            split1 = split1.Trim();
            int idTipoVencimiento = Convert.ToInt32(split1);
            string DiasPrevios = txtDia.Text;
            bool Exito = true;// ClienteNeg.GuardarVencimientoPorCliente(Año, idTipoVencimiento, DiasPrevios, idEmpresa);
            if (Exito == true)
            {
                ProgressBar();
                const string message2 = "Se registro el aviso de notificación exitosamente.";
                const string caption2 = "Éxito";
                var result2 = MessageBox.Show(message2, caption2,
                                             MessageBoxButtons.OK,
                                             MessageBoxIcon.Asterisk);
                LimpiarCampos();
            }
            else
            {
                const string message2 = "No se pudo registrar el vencimiento cargado.";
                const string caption2 = "Atención";
                var result2 = MessageBox.Show(message2, caption2,
                                             MessageBoxButtons.OK,
                                             MessageBoxIcon.Exclamation);
                LimpiarCampos();
            }
        }

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

        private void btnVolver_Click(object sender, EventArgs e)
        {
            MenuClienteWF _menu = new MenuClienteWF(razonSocial, cuit);
            _menu.Show();
            Hide();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }
    }
}

