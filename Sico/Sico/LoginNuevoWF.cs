using MySql.Data.MySqlClient;
using Sico.Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Web.Configuration;
using System.Windows.Forms;


namespace Sico
{
    public partial class LoginNuevoWF : Form
    {
        public LoginNuevoWF()
        {
            InitializeComponent();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnAcceder_Click(object sender, EventArgs e)
        {
            Login();
        }
        private void LoginConNuevaIP()
        {
            //Configuration configuration = ConfigurationManager.OpenExeConfiguration(Assembly.GetExecutingAssembly().Location);
            //configuration.AppSettings.Settings["servidor"].Value = txtIP.Text;
            //configuration.Save();
            //ConfigurationManager.RefreshSection("appSettings");
            ////return new MySqlConnection("server=" + WebConfigurationManager.AppSettings["servidor"].ToString() + ";user id=root;Port=3307;database=sico_desarrollo;password=admin;Persist Security Info=True");
            //Login();
        }
        private void Login()
        {
            List<Entidades.Usuario> usuarios = new List<Entidades.Usuario>();
            try
            {
                //bool coneccion = CheckPort();
                //if (coneccion == true)
                //{
                string usuario = txtUsuario.Text;
                string contraseña = txtClave.Text;
                usuarios = UsuarioNeg.LoginUsuario(usuario, contraseña);
                if (usuarios.Count == 0)
                {
                    const string message2 = "Usuario/contraseña ingresado incorrecta.";
                    const string caption2 = "Error";
                    var result2 = MessageBox.Show(message2, caption2,
                                                 MessageBoxButtons.OK,
                                                 MessageBoxIcon.Exclamation);
                }
                else
                {
                    Sesion.UsuarioLogueado = usuarios.First();
                    MasterNuevaWF _inicio = new MasterNuevaWF(0, null);
                    _inicio.Show();
                    Hide();
                }
                //}              
            }
            catch (Exception ex)
            {

            }
        }
        //public static bool CheckPort()
        //{
        //    using (TcpClient tcpClient = new TcpClient())
        //    {
        //        try
        //        {
        //            string ip = WebConfigurationManager.AppSettings["servidor"].ToString();
        //            tcpClient.Connect(WebConfigurationManager.AppSettings["servidor"].ToString(), 3307);
        //            return true;
        //        }
        //        catch (Exception)
        //        {
        //            return false;
        //        }
        //    }
        //}
        private void txtUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Login();
            }
        }
        private void txtClave_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Login();
            }
        }
        private void txtIP_KeyDown(object sender, KeyEventArgs e)
        {
        }
    }
}

