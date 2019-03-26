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
    public partial class ComprasWF : MasterWF
    {
        private string cuit;
        private string razonSocial;
        private bool EsEditar;
        public ComprasWF(string razonSocial, string cuit)
        {
            InitializeComponent();
            this.razonSocial = razonSocial;
            this.cuit = cuit;
        }
        private void ComprasWF_Load(object sender, EventArgs e)
        {
            lblNombreEdit.Text = razonSocial;
            lblCuitEdit.Text = cuit;
        }
        private void btnAgregarProveedor_Click(object sender, EventArgs e)
        {
            ProveedoresWF _proveedores = new ProveedoresWF();
            _proveedores.Show();
            Hide();
        }

        private void btnCargarCompra_Click(object sender, EventArgs e)
        {
            FacturacionCompraWF _compra = new FacturacionCompraWF();
            _compra.Show();
            Hide();
        }
    }
}
