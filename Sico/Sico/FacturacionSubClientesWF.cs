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
    public partial class FacturacionSubClientesWF : Form
    {
        private string cuit;
        private string razonSocial;

        public FacturacionSubClientesWF(string razonSocial, string cuit)
        {
            InitializeComponent();
            this.razonSocial = razonSocial;
            this.cuit = cuit;
        }
        private void FacturacionSubClientesWF_Load(object sender, EventArgs e)
        {
            try
            {
                lblNombreEdit.Text = razonSocial;
                lblCuitEdit.Text = cuit;
                CargarComboPersonas();

            }
            catch (Exception ex)
            { }

        }
        private void CargarComboPersonas()
        {
            List<string> Personas = new List<string>();
            Personas = ClienteNeg.CargarComboPersonas(cuit);
            cmbPersonas.Items.Clear();
            cmbPersonas.Text = "Seleccione";
            cmbPersonas.Items.Add("Seleccione");
            foreach (string item in Personas)
            {
                cmbPersonas.Text = "Seleccione";
                cmbPersonas.Items.Add(item);
            }
        }
        private void cmbPersonas_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string persona = cmbPersonas.Text;
                string NuevoNroFactura = ClienteNeg.BuscarNuevoNroFactura(persona);
                txtFactura.Text = NuevoNroFactura;
                dtFecha.Enabled = true;
            }
            catch (Exception ex)
            { }
        }
    }
}
