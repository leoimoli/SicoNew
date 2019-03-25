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
        public ComprasWF()
        {
            InitializeComponent();
        }

        private void ComprasWF_Load(object sender, EventArgs e)
        {

        }

        private void btnAgregarProveedor_Click(object sender, EventArgs e)
        {
            ProveedoresWF _proveedores = new ProveedoresWF();
            _proveedores.Show();
            Hide();
        }
    }
}
