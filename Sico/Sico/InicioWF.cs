﻿using System;
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
    public partial class InicioWF : MasterWF
    {
        public InicioWF()
        {
            InitializeComponent();
        }
        private void InicioWF_Load(object sender, EventArgs e)
        {

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
    }
}
