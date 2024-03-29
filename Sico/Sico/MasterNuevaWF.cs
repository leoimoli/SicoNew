﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.IO;
using Sico.Properties;

namespace Sico
{
    public partial class MasterNuevaWF : Form
    {
        public int idEmpresa;
        public string Empresa;

        //perfil 1 = SuperAdmin
        //perfil 2 = administrador
        //perfil 3 = Operador
        public MasterNuevaWF(int idEmpresa, string empresa)
        {
            InitializeComponent();
            AbrirFormEnPanel(new InicioWF());
            var imagen = new Bitmap(Sico.Properties.Resources.pagina_de_inicio);
            ImagenPagina.Image = imagen;
            lblPantalla.Text = "Inicio";
            if (Sesion.UsuarioLogueado.Perfil == "1")
            {
                panelConfiguracion.Visible = true;
                btnConfiguracion.Visible = true;
            }
            else
            {
                panelConfiguracion.Visible = false;
                btnConfiguracion.Visible = false;
            }

            if (idEmpresa > 0 && empresa != null)
            {
                //InitializeComponent();
                grbEmpresaSeleccionada.Visible = true;
                lblEmpresa.Text = empresa;
                lblidEmpresa.Text = Convert.ToString(idEmpresa);
                AbrirFormEnPanel(new InicioNuevoWF());
                menuSupEmpresa.Visible = false;
                MenuSupContabilidad.Visible = false;
                MenuSupIva.Visible = false;
                MenuSupSueldos.Visible = false;
            }
            else
            {
                //InitializeComponent();
                AbrirFormEnPanel(new InicioNuevoWF());
                menuSupEmpresa.Visible = false;
                MenuSupContabilidad.Visible = false;
                MenuSupIva.Visible = false;
                MenuSupSueldos.Visible = false;
            }
        }
        public void MasterNuevaWF_Load(object sender, EventArgs e)
        {
            label6.Text = Sesion.UsuarioLogueado.Apellido + "  " + Sesion.UsuarioLogueado.Nombre;
        }
        public void ValidarEmpresaSeleccionada(int idEmpresaSeleccionado, string EmpresaSeleccionada)
        {

            grbEmpresaSeleccionada.Visible = true;
            if (Sesion.UsuarioLogueado.idEmpresaSeleccionado > 0 && Sesion.UsuarioLogueado.EmpresaSeleccionada != "")
            {
                lblEmpresa.Text = Sesion.UsuarioLogueado.EmpresaSeleccionada;
                lblidEmpresa.Text = Convert.ToString(Sesion.UsuarioLogueado.idEmpresaSeleccionado);
            }
            else
            {
                grbEmpresaSeleccionada.Visible = false;
            }
        }
        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClienteWF _cliente = new ClienteWF();
            _cliente.Show();
        }
        private void btnRazonSocial_Click(object sender, EventArgs e)
        {
            panel5.Visible = true;
            menuSupEmpresa.Dock = DockStyle.Top;
            menuSupEmpresa.Visible = true;
            MenuSupContabilidad.Visible = false;
            MenuSupIva.Visible = false;
            MenuSupSueldos.Visible = false;
            MenuSupHonorarios.Visible = false;
            AbrirFormEnPanel(new ClientesNuevoWFcs());
            var imagen = new Bitmap(Sico.Properties.Resources.empresa);
            ImagenPagina.Image = imagen;
            lblPantalla.Text = "Empresas";
        }
        private void btnIva_Click(object sender, EventArgs e)
        {
            panel5.Visible = true;
            MenuSupIva.Dock = DockStyle.Top;
            menuSupEmpresa.Visible = false;
            MenuSupContabilidad.Visible = false;
            MenuSupIva.Visible = true;
            MenuSupSueldos.Visible = false;
            MenuSupHonorarios.Visible = false;
            AbrirFormEnPanel(new IvaWF());
            var imagen = new Bitmap(Sico.Properties.Resources.impuesto);
            ImagenPagina.Image = imagen;
            lblPantalla.Text = "Iva";

        }
        private void btnContabilidad_Click(object sender, EventArgs e)
        {
            panel5.Visible = true;
            MenuSupContabilidad.Dock = DockStyle.Top;
            menuSupEmpresa.Visible = false;
            MenuSupContabilidad.Visible = true;
            MenuSupIva.Visible = false;
            MenuSupSueldos.Visible = false;
            MenuSupHonorarios.Visible = false;
            AbrirFormEnPanel(new InicioNuevoWF());
            var imagen = new Bitmap(Sico.Properties.Resources.contabilidad);
            ImagenPagina.Image = imagen;
            lblPantalla.Text = "Contabilidad";
        }
        private void btnSueldos_Click(object sender, EventArgs e)
        {
            panel5.Visible = true;
            MenuSupSueldos.Dock = DockStyle.Top;
            menuSupEmpresa.Visible = false;
            MenuSupContabilidad.Visible = false;
            MenuSupIva.Visible = false;
            MenuSupSueldos.Visible = true;
            MenuSupHonorarios.Visible = false;
            AbrirFormEnPanel(new InicioNuevoWF());
            var imagen = new Bitmap(Sico.Properties.Resources.nomina_de_sueldos);
            ImagenPagina.Image = imagen;
            lblPantalla.Text = "Sueldos";

        }
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnMaximizar.Visible = false;
            btnRestaurar.Visible = true;
        }
        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnMaximizar.Visible = true;
            btnRestaurar.Visible = false;
        }
        private void toolStripMenuItem9_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new ClientesNuevoWFcs());
        }
        private void AbrirFormEnPanel(object formhija)
        {
            if (this.PanelContenedor.Controls.Count > 0)
                this.PanelContenedor.Controls.RemoveAt(0);
            Form fh = formhija as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.PanelContenedor.Controls.Add(fh);
            this.PanelContenedor.Tag = fh;
            fh.Show();
        }
        private void PanelContenedor_Paint(object sender, PaintEventArgs e)
        {

        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int IParam);

        private void MenuCabecera_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        public void Validar(int id, string empresa)
        {
            MasterNuevaWF _inicio = new MasterNuevaWF(id, empresa);
            _inicio.Show();
            Hide();
        }
        private void btnSeleccionarEmpresa_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new ClientesNuevoWFcs());
        }
        private void toolStripMenuItem10_Click(object sender, EventArgs e)
        {
            if (Sesion.UsuarioLogueado.idEmpresaSeleccionado == 0)
            {
                const string message2 = "Atención: Usted debe seleccionar una empresa previamente.";
                const string caption2 = "Atención";
                var result2 = MessageBox.Show(message2, caption2,
                                              MessageBoxButtons.OK,
                                              MessageBoxIcon.Asterisk);
            }
            AbrirFormEnPanel(new PlanDeHonorariosWF());
        }
        private void btnHonorarios_Click(object sender, EventArgs e)
        {
            panel5.Visible = true;
            MenuSupHonorarios.Dock = DockStyle.Top;
            menuSupEmpresa.Visible = false;
            MenuSupContabilidad.Visible = false;
            MenuSupIva.Visible = false;
            MenuSupSueldos.Visible = false;
            MenuSupHonorarios.Visible = true;
            AbrirFormEnPanel(new PlanDeHonorariosWF());
            var imagen = new Bitmap(Sico.Properties.Resources.honorarios);
            ImagenPagina.Image = imagen;
            lblPantalla.Text = "Honorarios";
        }

        private void comprobantesDeVentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new FacturacionSubClientesWF(null, null));
        }

        private void clientesToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            SubClienteWF _subcliente = new SubClienteWF(null, 0);
            _subcliente.Show();
        }

        private void informesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new InformesEmpresaWF());
        }
        private void iVAVentasToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }
        private void MenuSupContabilidad_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
        private void comprobanteDeCompraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new FacturacionCompraWF(null, null, null));
        }
        private void proveedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProveedoresWF _proveedor = new ProveedoresWF();
            _proveedor.Show();
        }

        private void iVAComprasToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void reporteMensualToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new VistaConsultaFacturacionComprasMensualWF(null, null));
        }
        private void reporteMensualToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new VistaConsultaFacturacionMensualWF(null, 0));
        }

        private void reporteAnualToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new FacturacionAnualVentasWF());
        }

        private void reporteAnualToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new FacturacionAnualComprasWF());
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new InicioWF());
            var imagen = new Bitmap(Sico.Properties.Resources.usuarios_2_);
            ImagenPagina.Image = imagen;
            lblPantalla.Text = "Usuarios";
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new InicioNuevoWF());
            var imagen = new Bitmap(Sico.Properties.Resources.pagina_de_inicio);
            ImagenPagina.Image = imagen;
            lblPantalla.Text = "Inicio";
        }

        private void btnConfiguracion_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new ConfiguracionesWF());
            var imagen = new Bitmap(Sico.Properties.Resources.boton_de_configuracion_negro);
            ImagenPagina.Image = imagen;
            lblPantalla.Text = "Configuración";
        }

        private void btnAgenda_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new AgendaWF());
            var imagen = new Bitmap(Sico.Properties.Resources.marcador_en_la_agenda);
            ImagenPagina.Image = imagen;
            lblPantalla.Text = "Agenda";           
        }
    }
}
