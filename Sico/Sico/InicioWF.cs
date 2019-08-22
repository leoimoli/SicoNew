using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sico
{
    public partial class InicioWF : MasterWF
    {
        public InicioWF()
        {
            InitializeComponent();
        }
        private void InicioWF_Load(object sender, EventArgs e)
        {
            ObtenerValorDolar();
        }
        private void ObtenerValorDolar()
        {
            CalcularDolar();
            BuscarClima();
        }
        private void BuscarClima()
        {
            webBrowser1.Navigate($"https://www.meteored.com.ar/wimages/foto732421e658351c65f05e4df3beefcc02.png");
            groupBox2.Text = "El clima en la ciudad";
            groupBox2.Font = new Font("Tahoma", 10);
            //groupBox2.Width = 200;
            //groupBox2.Height = 210;
        }
        private void CalcularDolar()
        {
            webBrowser2.Navigate($"https://www.dolarsi.com/cotizador/cotizadorDolarsiFull.php");
            groupBox3.Text = " Cotización";
            groupBox3.Font = new Font("Tahoma", 10);
            //groupBox3.Width = 150;
            //groupBox3.Height = 160;
        }
        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            UsuarioWF _usuario = new UsuarioWF();
            _usuario.Show();
            Hide();
        }
        private void btnClientes_Click(object sender, EventArgs e)
        {
            ClienteWF _cliente = new ClienteWF();
            _cliente.Show();
            Hide();
        }
        private void btnPericias_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Estoy trabajando en esta funcionalidad.");
            PericiasWF _pericia = new PericiasWF();
            _pericia.Show();
            Hide();
        }
        private void imgNacion_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.bna.com.ar/Personas");
        }

        private void imgProvincia_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.bancoprovincia.com.ar/web/inversiones");
        }

        private void imgHipotecario_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://hipotecario.com.ar/default.asp?ID=41");
        }
    }
}
