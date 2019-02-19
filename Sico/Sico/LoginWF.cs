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
    public partial class LoginWF : Form
    {
        public LoginWF()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            List<Entidades.Usuario> usuarios = new List<Entidades.Usuario>();
            try
            {
                string usuario = txtUsuario.Text;
                string contraseña = txtContraseña.Text;
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
                    InicioWF _usuario = new InicioWF();
                    //Usb oUsb = new Usb();
                    //List<USBInfo> lstUSBD = oUsb.GetUSBDevices();
                    bool Exito = Dao.UsuarioDao.LevantarBackup();
                    if (Exito == true)
                    {
                        _usuario.Show();
                        Hide();
                    }
                    else { MessageBox.Show("ATENCIÓN no se pudo importar el backup de base de datos"); }
                }
            }
            catch (Exception ex)
            {
                const string message = "Error en el sistema. Intente nuevamente o comuniquese con el administrador.";
                const string caption = "Atención";
                var result = MessageBox.Show(message, caption,
                                             MessageBoxButtons.OK,
                                           MessageBoxIcon.Warning);
                throw new Exception();
            }
        }
    }
}
