﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
            //bool Exito = Dao.UsuarioDao.GenerarBackup();
            //if (Exito != true)
            //    MessageBox.Show("Error al cerrar el sistema.");
            Close();
        }
        private void periciasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Estoy trabajando en esta funcionalidad.");
            PericiasWF _pericia = new PericiasWF();
            _pericia.Show();
            Hide();
        }
        private void crearUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UsuarioWF _usuario = new UsuarioWF();
            _usuario.Show();
            Hide();
        }
        private void cargarFirmaEmailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CuentaEmailWF _cuenta = new CuentaEmailWF();
            _cuenta.Show();
        }

        private void vencimientosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConfigurarVencimientosWF _vencimientos = new ConfigurarVencimientosWF();
            _vencimientos.Show();
            Hide();
        }

        private void calculadoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:\Windows\System32\calc.exe"); // Se abre paint
        }

        private void consultarVencimientosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CalendarioWF _calendario = new CalendarioWF();
            _calendario.Show();
            Hide();
        }
    }
}
