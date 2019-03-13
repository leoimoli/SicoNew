using Sico.Entidades;
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
    public partial class CuentaEmailWF : Form
    {
        public CuentaEmailWF()
        {
            InitializeComponent();
        }
        private void CuentaEmailWF_Load(object sender, EventArgs e)
        {
            int idusuarioLogueado = Sesion.UsuarioLogueado.IdUsuario;
            List<CuentaEmailPorUsuario> _cuenta = new List<CuentaEmailPorUsuario>();
            _cuenta = Negocio.UsuarioNeg.BuscarCuentaEmailPorUsuario(idusuarioLogueado);
            if (_cuenta.Count > 0)
            {
                var cuenta = _cuenta.First();
                txtEmail.Text = cuenta.CuentaEmail;
                txtClave.Text = cuenta.ClaveEmail;
                txtFirmaEmail.Text = cuenta.FirmaEmail;
            }
            else { txtEmail.Focus(); }

        }
        #region Botones
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                Entidades.CuentaEmailPorUsuario _cuenta = CargarEntidad();
                bool Exito = UsuarioNeg.GuardarCuentaEmail(_cuenta);
                if (Exito == true)
                {
                    ProgressBar();
                    const string message2 = "Se registro la información de la cuenta de email exitosamente.";
                    const string caption2 = "Éxito";
                    var result2 = MessageBox.Show(message2, caption2,
                                                 MessageBoxButtons.OK,
                                                 MessageBoxIcon.Asterisk);
                    LimpiarCampos();
                }
                else
                {

                }
            }
            catch { }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }
        #endregion
        #region Funciones
        private void ProgressBar()
        {
            progressBar1.Visible = true;
            progressBar1.Maximum = 100000;
            progressBar1.Step = 1;

            for (int j = 0; j < 100000; j++)
            {
                Caluculate(j);
                progressBar1.PerformStep();
            }
        }
        private void Caluculate(int i)
        {
            double pow = Math.Pow(i, i);
        }
        private CuentaEmailPorUsuario CargarEntidad()
        {
            CuentaEmailPorUsuario _cuenta = new CuentaEmailPorUsuario();
            _cuenta.CuentaEmail = txtEmail.Text;
            _cuenta.ClaveEmail = txtClave.Text;
            _cuenta.FirmaEmail = txtFirmaEmail.Text;
            _cuenta.IdUsuario = Sesion.UsuarioLogueado.IdUsuario;
            return _cuenta;
        }
        private void LimpiarCampos()
        {
            txtEmail.Clear();
            txtClave.Clear();
            txtFirmaEmail.Clear();
            progressBar1.Value = Convert.ToInt32(null);
            progressBar1.Visible = false;
        }
        #endregion
    }
}
