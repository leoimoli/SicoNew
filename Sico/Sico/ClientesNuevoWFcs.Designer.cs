namespace Sico
{
    partial class ClientesNuevoWFcs
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtCuitBuscar = new System.Windows.Forms.MaskedTextBox();
            this.txtBuscarRazonSocial = new System.Windows.Forms.TextBox();
            this.lblDniOApellidoNombre = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PanelRegistroPlan = new System.Windows.Forms.Panel();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtCodigoPostal = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtAltura = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtCalle = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cmbLocalidad = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbProvincia = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCodArea = new System.Windows.Forms.TextBox();
            this.cmbCondicionAntiAfip = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.dtFechaInscripcion = new System.Windows.Forms.DateTimePicker();
            this.label15 = new System.Windows.Forms.Label();
            this.txtActividad = new System.Windows.Forms.TextBox();
            this.txtCuit = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblRegistroEmpresa = new System.Windows.Forms.Label();
            this.txtNombreRazonSocial = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.dgvTodosLosClientes = new System.Windows.Forms.DataGridView();
            this.idEmpresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RazonSocial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cuit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ActividadNuevo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CondicionNuevo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SeleccionarNuevo = new System.Windows.Forms.DataGridViewButtonColumn();
            this.EditarNuevo = new System.Windows.Forms.DataGridViewButtonColumn();
            this.PanelRegistroPlan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTodosLosClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCuitBuscar
            // 
            this.txtCuitBuscar.Location = new System.Drawing.Point(118, 43);
            this.txtCuitBuscar.Mask = "00-00000000-0";
            this.txtCuitBuscar.Name = "txtCuitBuscar";
            this.txtCuitBuscar.Size = new System.Drawing.Size(84, 20);
            this.txtCuitBuscar.TabIndex = 4;
            this.txtCuitBuscar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCuitBuscar_KeyDown);
            // 
            // txtBuscarRazonSocial
            // 
            this.txtBuscarRazonSocial.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBuscarRazonSocial.Location = new System.Drawing.Point(404, 43);
            this.txtBuscarRazonSocial.Name = "txtBuscarRazonSocial";
            this.txtBuscarRazonSocial.Size = new System.Drawing.Size(293, 20);
            this.txtBuscarRazonSocial.TabIndex = 2;
            this.txtBuscarRazonSocial.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBuscarRazonSocial_KeyDown);
            // 
            // lblDniOApellidoNombre
            // 
            this.lblDniOApellidoNombre.AutoSize = true;
            this.lblDniOApellidoNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDniOApellidoNombre.ForeColor = System.Drawing.Color.Black;
            this.lblDniOApellidoNombre.Location = new System.Drawing.Point(19, 45);
            this.lblDniOApellidoNombre.Name = "lblDniOApellidoNombre";
            this.lblDniOApellidoNombre.Size = new System.Drawing.Size(93, 15);
            this.lblDniOApellidoNombre.TabIndex = 3;
            this.lblDniOApellidoNombre.Text = "Buscar por Cuit:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(276, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 15);
            this.label1.TabIndex = 27;
            this.label1.Text = "Buscar por Empresa:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(19, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 20);
            this.label2.TabIndex = 28;
            this.label2.Text = "Listado de Empresas";
            // 
            // PanelRegistroPlan
            // 
            this.PanelRegistroPlan.BackColor = System.Drawing.Color.Gainsboro;
            this.PanelRegistroPlan.Controls.Add(this.progressBar1);
            this.PanelRegistroPlan.Controls.Add(this.btnGuardar);
            this.PanelRegistroPlan.Controls.Add(this.txtCodigoPostal);
            this.PanelRegistroPlan.Controls.Add(this.label13);
            this.PanelRegistroPlan.Controls.Add(this.txtAltura);
            this.PanelRegistroPlan.Controls.Add(this.label12);
            this.PanelRegistroPlan.Controls.Add(this.txtCalle);
            this.PanelRegistroPlan.Controls.Add(this.label11);
            this.PanelRegistroPlan.Controls.Add(this.cmbLocalidad);
            this.PanelRegistroPlan.Controls.Add(this.label10);
            this.PanelRegistroPlan.Controls.Add(this.cmbProvincia);
            this.PanelRegistroPlan.Controls.Add(this.label9);
            this.PanelRegistroPlan.Controls.Add(this.label7);
            this.PanelRegistroPlan.Controls.Add(this.txtEmail);
            this.PanelRegistroPlan.Controls.Add(this.label8);
            this.PanelRegistroPlan.Controls.Add(this.txtTelefono);
            this.PanelRegistroPlan.Controls.Add(this.label6);
            this.PanelRegistroPlan.Controls.Add(this.txtCodArea);
            this.PanelRegistroPlan.Controls.Add(this.cmbCondicionAntiAfip);
            this.PanelRegistroPlan.Controls.Add(this.label5);
            this.PanelRegistroPlan.Controls.Add(this.label14);
            this.PanelRegistroPlan.Controls.Add(this.dtFechaInscripcion);
            this.PanelRegistroPlan.Controls.Add(this.label15);
            this.PanelRegistroPlan.Controls.Add(this.txtActividad);
            this.PanelRegistroPlan.Controls.Add(this.txtCuit);
            this.PanelRegistroPlan.Controls.Add(this.label4);
            this.PanelRegistroPlan.Controls.Add(this.label3);
            this.PanelRegistroPlan.Controls.Add(this.lblRegistroEmpresa);
            this.PanelRegistroPlan.Controls.Add(this.txtNombreRazonSocial);
            this.PanelRegistroPlan.Enabled = false;
            this.PanelRegistroPlan.Location = new System.Drawing.Point(756, 70);
            this.PanelRegistroPlan.Name = "PanelRegistroPlan";
            this.PanelRegistroPlan.Size = new System.Drawing.Size(339, 400);
            this.PanelRegistroPlan.TabIndex = 29;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(71, 200);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(235, 23);
            this.progressBar1.TabIndex = 57;
            this.progressBar1.Value = 50;
            this.progressBar1.Visible = false;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.SteelBlue;
            this.btnGuardar.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(36, 356);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(289, 38);
            this.btnGuardar.TabIndex = 56;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtCodigoPostal
            // 
            this.txtCodigoPostal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCodigoPostal.Location = new System.Drawing.Point(158, 330);
            this.txtCodigoPostal.Name = "txtCodigoPostal";
            this.txtCodigoPostal.Size = new System.Drawing.Size(172, 20);
            this.txtCodigoPostal.TabIndex = 54;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(68, 331);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(85, 15);
            this.label13.TabIndex = 55;
            this.label13.Text = "Código postal:";
            // 
            // txtAltura
            // 
            this.txtAltura.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtAltura.Location = new System.Drawing.Point(158, 305);
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(172, 20);
            this.txtAltura.TabIndex = 52;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(112, 306);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(41, 15);
            this.label12.TabIndex = 53;
            this.label12.Text = "Altura:";
            // 
            // txtCalle
            // 
            this.txtCalle.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCalle.Location = new System.Drawing.Point(158, 279);
            this.txtCalle.Name = "txtCalle";
            this.txtCalle.Size = new System.Drawing.Size(172, 20);
            this.txtCalle.TabIndex = 50;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(115, 280);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(38, 15);
            this.label11.TabIndex = 51;
            this.label11.Text = "Calle:";
            // 
            // cmbLocalidad
            // 
            this.cmbLocalidad.Enabled = false;
            this.cmbLocalidad.FormattingEnabled = true;
            this.cmbLocalidad.Location = new System.Drawing.Point(158, 252);
            this.cmbLocalidad.Name = "cmbLocalidad";
            this.cmbLocalidad.Size = new System.Drawing.Size(172, 21);
            this.cmbLocalidad.TabIndex = 48;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(89, 253);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 15);
            this.label10.TabIndex = 49;
            this.label10.Text = "Localidad:";
            // 
            // cmbProvincia
            // 
            this.cmbProvincia.FormattingEnabled = true;
            this.cmbProvincia.Location = new System.Drawing.Point(158, 225);
            this.cmbProvincia.Name = "cmbProvincia";
            this.cmbProvincia.Size = new System.Drawing.Size(172, 21);
            this.cmbProvincia.TabIndex = 46;
            this.cmbProvincia.SelectedIndexChanged += new System.EventHandler(this.cmbProvincia_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(93, 226);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 15);
            this.label9.TabIndex = 47;
            this.label9.Text = "Provincia:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(111, 204);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 15);
            this.label7.TabIndex = 45;
            this.label7.Text = "Email:";
            // 
            // txtEmail
            // 
            this.txtEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtEmail.Location = new System.Drawing.Point(159, 199);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(172, 20);
            this.txtEmail.TabIndex = 44;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(227, 173);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(14, 20);
            this.label8.TabIndex = 43;
            this.label8.Text = "-";
            // 
            // txtTelefono
            // 
            this.txtTelefono.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTelefono.Location = new System.Drawing.Point(245, 173);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(85, 20);
            this.txtTelefono.TabIndex = 41;
            this.txtTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SoloNumeros);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(95, 176);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 15);
            this.label6.TabIndex = 42;
            this.label6.Text = "Telefono:";
            // 
            // txtCodArea
            // 
            this.txtCodArea.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCodArea.Location = new System.Drawing.Point(158, 173);
            this.txtCodArea.Name = "txtCodArea";
            this.txtCodArea.Size = new System.Drawing.Size(63, 20);
            this.txtCodArea.TabIndex = 40;
            this.txtCodArea.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SoloNumeros);
            // 
            // cmbCondicionAntiAfip
            // 
            this.cmbCondicionAntiAfip.FormattingEnabled = true;
            this.cmbCondicionAntiAfip.Location = new System.Drawing.Point(159, 146);
            this.cmbCondicionAntiAfip.Name = "cmbCondicionAntiAfip";
            this.cmbCondicionAntiAfip.Size = new System.Drawing.Size(172, 21);
            this.cmbCondicionAntiAfip.TabIndex = 38;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(33, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 15);
            this.label5.TabIndex = 39;
            this.label5.Text = "Condición anti Afip(*):";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(109, 123);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(44, 15);
            this.label14.TabIndex = 37;
            this.label14.Text = "Fecha:";
            // 
            // dtFechaInscripcion
            // 
            this.dtFechaInscripcion.Location = new System.Drawing.Point(158, 119);
            this.dtFechaInscripcion.Name = "dtFechaInscripcion";
            this.dtFechaInscripcion.Size = new System.Drawing.Size(172, 20);
            this.dtFechaInscripcion.TabIndex = 36;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(95, 90);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(58, 15);
            this.label15.TabIndex = 35;
            this.label15.Text = "Actividad:";
            // 
            // txtActividad
            // 
            this.txtActividad.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtActividad.Location = new System.Drawing.Point(158, 89);
            this.txtActividad.Name = "txtActividad";
            this.txtActividad.Size = new System.Drawing.Size(172, 20);
            this.txtActividad.TabIndex = 34;
            // 
            // txtCuit
            // 
            this.txtCuit.Location = new System.Drawing.Point(159, 63);
            this.txtCuit.Mask = "00-00000000-0";
            this.txtCuit.Name = "txtCuit";
            this.txtCuit.Size = new System.Drawing.Size(172, 20);
            this.txtCuit.TabIndex = 33;
            this.txtCuit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SoloNumeros);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(109, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 15);
            this.label4.TabIndex = 32;
            this.label4.Text = "Cuit(*):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(3, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 15);
            this.label3.TabIndex = 31;
            this.label3.Text = "Nombre o Razón Social(*):";
            // 
            // lblRegistroEmpresa
            // 
            this.lblRegistroEmpresa.AutoSize = true;
            this.lblRegistroEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistroEmpresa.ForeColor = System.Drawing.Color.Black;
            this.lblRegistroEmpresa.Location = new System.Drawing.Point(14, 11);
            this.lblRegistroEmpresa.Name = "lblRegistroEmpresa";
            this.lblRegistroEmpresa.Size = new System.Drawing.Size(160, 17);
            this.lblRegistroEmpresa.TabIndex = 29;
            this.lblRegistroEmpresa.Text = "Registro de Empresa";
            // 
            // txtNombreRazonSocial
            // 
            this.txtNombreRazonSocial.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNombreRazonSocial.Location = new System.Drawing.Point(159, 37);
            this.txtNombreRazonSocial.Name = "txtNombreRazonSocial";
            this.txtNombreRazonSocial.Size = new System.Drawing.Size(172, 20);
            this.txtNombreRazonSocial.TabIndex = 30;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.SteelBlue;
            this.btnBuscar.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Image = global::Sico.Properties.Resources.buscar__2_;
            this.btnBuscar.Location = new System.Drawing.Point(714, 38);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(36, 28);
            this.btnBuscar.TabIndex = 60;
            this.toolTip1.SetToolTip(this.btnBuscar, "Buscar Cliente");
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Visible = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.Color.SteelBlue;
            this.btnNuevo.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen;
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.ForeColor = System.Drawing.Color.White;
            this.btnNuevo.Location = new System.Drawing.Point(22, 444);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(77, 28);
            this.btnNuevo.TabIndex = 58;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // dgvTodosLosClientes
            // 
            this.dgvTodosLosClientes.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTodosLosClientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTodosLosClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTodosLosClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idEmpresa,
            this.RazonSocial,
            this.Cuit,
            this.ActividadNuevo,
            this.CondicionNuevo,
            this.SeleccionarNuevo,
            this.EditarNuevo});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTodosLosClientes.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTodosLosClientes.EnableHeadersVisualStyles = false;
            this.dgvTodosLosClientes.Location = new System.Drawing.Point(12, 70);
            this.dgvTodosLosClientes.Name = "dgvTodosLosClientes";
            this.dgvTodosLosClientes.RowHeadersVisible = false;
            this.dgvTodosLosClientes.Size = new System.Drawing.Size(728, 369);
            this.dgvTodosLosClientes.TabIndex = 61;
            this.dgvTodosLosClientes.Visible = false;
            this.dgvTodosLosClientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTodosLosClientes_CellClick);
            this.dgvTodosLosClientes.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgvTodosLosClientes_CellPainting);
            // 
            // idEmpresa
            // 
            this.idEmpresa.HeaderText = "id Empresa";
            this.idEmpresa.Name = "idEmpresa";
            this.idEmpresa.Width = 70;
            // 
            // RazonSocial
            // 
            this.RazonSocial.HeaderText = "Razón Social";
            this.RazonSocial.Name = "RazonSocial";
            this.RazonSocial.Width = 190;
            // 
            // Cuit
            // 
            this.Cuit.HeaderText = "Cuit";
            this.Cuit.Name = "Cuit";
            // 
            // ActividadNuevo
            // 
            this.ActividadNuevo.HeaderText = "Actividad";
            this.ActividadNuevo.Name = "ActividadNuevo";
            this.ActividadNuevo.Width = 110;
            // 
            // CondicionNuevo
            // 
            this.CondicionNuevo.HeaderText = "Condición";
            this.CondicionNuevo.Name = "CondicionNuevo";
            this.CondicionNuevo.Width = 110;
            // 
            // SeleccionarNuevo
            // 
            this.SeleccionarNuevo.HeaderText = "Seleccionar";
            this.SeleccionarNuevo.Name = "SeleccionarNuevo";
            this.SeleccionarNuevo.Width = 80;
            // 
            // EditarNuevo
            // 
            this.EditarNuevo.HeaderText = "Editar";
            this.EditarNuevo.Name = "EditarNuevo";
            this.EditarNuevo.Width = 50;
            // 
            // ClientesNuevoWFcs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1099, 482);
            this.Controls.Add(this.dgvTodosLosClientes);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.PanelRegistroPlan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCuitBuscar);
            this.Controls.Add(this.lblDniOApellidoNombre);
            this.Controls.Add(this.txtBuscarRazonSocial);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ClientesNuevoWFcs";
            this.Text = "ClientesNuevoWFcs";
            this.Load += new System.EventHandler(this.ClientesNuevoWFcs_Load);
            this.PanelRegistroPlan.ResumeLayout(false);
            this.PanelRegistroPlan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTodosLosClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MaskedTextBox txtCuitBuscar;
        private System.Windows.Forms.TextBox txtBuscarRazonSocial;
        private System.Windows.Forms.Label lblDniOApellidoNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel PanelRegistroPlan;
        private System.Windows.Forms.Label lblRegistroEmpresa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNombreRazonSocial;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox txtCuit;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtActividad;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DateTimePicker dtFechaInscripcion;
        private System.Windows.Forms.ComboBox cmbCondicionAntiAfip;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCodArea;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.ComboBox cmbProvincia;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbLocalidad;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtCalle;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtAltura;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtCodigoPostal;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.DataGridView dgvTodosLosClientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn idEmpresa;
        private System.Windows.Forms.DataGridViewTextBoxColumn RazonSocial;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cuit;
        private System.Windows.Forms.DataGridViewTextBoxColumn ActividadNuevo;
        private System.Windows.Forms.DataGridViewTextBoxColumn CondicionNuevo;
        private System.Windows.Forms.DataGridViewButtonColumn SeleccionarNuevo;
        private System.Windows.Forms.DataGridViewButtonColumn EditarNuevo;
    }
}