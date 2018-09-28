using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace Sico
{
    public partial class MasterWF : Form
    {
        public MasterWF()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            System.Timers.Timer t = new System.Timers.Timer(1000);
            t.Elapsed += new System.Timers.ElapsedEventHandler(this.timer1_Tick);
            t.Start();
        }
        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClienteWF _cliente = new ClienteWF();
            _cliente.Show();
            Hide();
        }
        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UsuarioWF _usuario = new UsuarioWF();
            _usuario.Show();
            Hide();
        }
        private void MasterWF_Load(object sender, EventArgs e)
        {
            if (Sesion.UsuarioLogueado != null)
            {
                lblMaster_UsuarioLogin.Text = Sesion.UsuarioLogueado.Apellido + "  " + Sesion.UsuarioLogueado.Nombre;
                //lblMaster_FechaHoraReal.Text = Convert.ToString(DateTime.Now);
            }
        }
        private void timer1_Tick(object sender, ElapsedEventArgs el)
        {
            CheckForIllegalCrossThreadCalls = false;
            lblFechaHora_Edit.Text = DateTime.Now.ToString();
        }

        private void inicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InicioWF _inicio = new InicioWF();
            _inicio.Show();
            Hide();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
