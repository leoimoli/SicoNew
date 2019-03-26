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
    public partial class MenuClienteWF : MasterWF
    {
        private string cuit;
        private string razonSocial;
        private bool EsEditar;
        public MenuClienteWF(string razonSocial, string cuit)
        {
            InitializeComponent();
            this.razonSocial = razonSocial;
            this.cuit = cuit;
        }

        private void MenuClienteWF_Load(object sender, EventArgs e)
        {
            
        }
        #region Botones
        public static string RazonSocial;
        public static string Cuit;
        private void btnVentas_Click(object sender, EventArgs e)
        {
            TareaClienteWF _tarea = new TareaClienteWF(RazonSocial, Cuit);
            _tarea.Show();
            Hide();
        }
        #endregion

        private void btnCompras_Click(object sender, EventArgs e)
        {
            ComprasWF _compras = new ComprasWF(RazonSocial,Cuit);
            _compras.Show();
            Hide();
        }
    }
}
