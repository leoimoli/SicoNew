namespace Sico
{
    partial class ProveedoresWF
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
            this.grbFiltros = new System.Windows.Forms.GroupBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCuitBuscar = new System.Windows.Forms.MaskedTextBox();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.lblDniOApellidoNombre = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtCodigoPostal = new System.Windows.Forms.TextBox();
            this.chcFacturaC = new System.Windows.Forms.CheckBox();
            this.label13 = new System.Windows.Forms.Label();
            this.chcFacturaB = new System.Windows.Forms.CheckBox();
            this.txtAltura = new System.Windows.Forms.TextBox();
            this.chcFacturaA = new System.Windows.Forms.CheckBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtCalle = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.cmbLocalidad = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cmbProvincia = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCuit = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbCondicionAntiAfip = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCodArea = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtNombreRazonSocial = new System.Windows.Forms.TextBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnHabilitarBusqueda = new System.Windows.Forms.Button();
            this.btnCrearSubCliente = new System.Windows.Forms.Button();
            this.grbFiltros.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbFiltros
            // 
            this.grbFiltros.Controls.Add(this.btnBuscar);
            this.grbFiltros.Controls.Add(this.label2);
            this.grbFiltros.Controls.Add(this.txtCuitBuscar);
            this.grbFiltros.Controls.Add(this.txtBuscar);
            this.grbFiltros.Controls.Add(this.lblDniOApellidoNombre);
            this.grbFiltros.Location = new System.Drawing.Point(22, 82);
            this.grbFiltros.Name = "grbFiltros";
            this.grbFiltros.Size = new System.Drawing.Size(594, 54);
            this.grbFiltros.TabIndex = 13;
            this.grbFiltros.TabStop = false;
            this.grbFiltros.Text = "Filtros de Busqueda";
            this.grbFiltros.Visible = false;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.SteelBlue;
            this.btnBuscar.Image = global::Sico.Properties.Resources.buscar__2_;
            this.btnBuscar.Location = new System.Drawing.Point(538, 13);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(40, 32);
            this.btnBuscar.TabIndex = 17;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(220, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Razón Social:";
            // 
            // txtCuitBuscar
            // 
            this.txtCuitBuscar.Location = new System.Drawing.Point(82, 20);
            this.txtCuitBuscar.Mask = "00-00000000-0";
            this.txtCuitBuscar.Name = "txtCuitBuscar";
            this.txtCuitBuscar.Size = new System.Drawing.Size(84, 20);
            this.txtCuitBuscar.TabIndex = 4;
            // 
            // txtBuscar
            // 
            this.txtBuscar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBuscar.Location = new System.Drawing.Point(317, 20);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(200, 20);
            this.txtBuscar.TabIndex = 2;
            // 
            // lblDniOApellidoNombre
            // 
            this.lblDniOApellidoNombre.AutoSize = true;
            this.lblDniOApellidoNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDniOApellidoNombre.Location = new System.Drawing.Point(29, 21);
            this.lblDniOApellidoNombre.Name = "lblDniOApellidoNombre";
            this.lblDniOApellidoNombre.Size = new System.Drawing.Size(33, 16);
            this.lblDniOApellidoNombre.TabIndex = 3;
            this.lblDniOApellidoNombre.Text = "Cuit:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtCodigoPostal);
            this.groupBox1.Controls.Add(this.chcFacturaC);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.chcFacturaB);
            this.groupBox1.Controls.Add(this.txtAltura);
            this.groupBox1.Controls.Add(this.chcFacturaA);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.txtCalle);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.cmbLocalidad);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.cmbProvincia);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtTelefono);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtCuit);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.cmbCondicionAntiAfip);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtCodArea);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.txtNombreRazonSocial);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 134);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(613, 345);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            // 
            // txtCodigoPostal
            // 
            this.txtCodigoPostal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCodigoPostal.Location = new System.Drawing.Point(18, 314);
            this.txtCodigoPostal.Name = "txtCodigoPostal";
            this.txtCodigoPostal.Size = new System.Drawing.Size(211, 23);
            this.txtCodigoPostal.TabIndex = 4;
            // 
            // chcFacturaC
            // 
            this.chcFacturaC.AutoSize = true;
            this.chcFacturaC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chcFacturaC.Location = new System.Drawing.Point(518, 155);
            this.chcFacturaC.Name = "chcFacturaC";
            this.chcFacturaC.Size = new System.Drawing.Size(84, 20);
            this.chcFacturaC.TabIndex = 26;
            this.chcFacturaC.Text = "Factura C";
            this.chcFacturaC.UseVisualStyleBackColor = true;
            this.chcFacturaC.CheckedChanged += new System.EventHandler(this.chcFacturaC_CheckedChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(15, 295);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(95, 16);
            this.label13.TabIndex = 22;
            this.label13.Text = "Código postal:";
            // 
            // chcFacturaB
            // 
            this.chcFacturaB.AutoSize = true;
            this.chcFacturaB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chcFacturaB.Location = new System.Drawing.Point(437, 155);
            this.chcFacturaB.Name = "chcFacturaB";
            this.chcFacturaB.Size = new System.Drawing.Size(84, 20);
            this.chcFacturaB.TabIndex = 25;
            this.chcFacturaB.Text = "Factura B";
            this.chcFacturaB.UseVisualStyleBackColor = true;
            this.chcFacturaB.CheckedChanged += new System.EventHandler(this.chcFacturaB_CheckedChanged);
            // 
            // txtAltura
            // 
            this.txtAltura.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtAltura.Location = new System.Drawing.Point(350, 263);
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(211, 23);
            this.txtAltura.TabIndex = 3;
            // 
            // chcFacturaA
            // 
            this.chcFacturaA.AutoSize = true;
            this.chcFacturaA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chcFacturaA.Location = new System.Drawing.Point(356, 155);
            this.chcFacturaA.Name = "chcFacturaA";
            this.chcFacturaA.Size = new System.Drawing.Size(84, 20);
            this.chcFacturaA.TabIndex = 24;
            this.chcFacturaA.Text = "Factura A";
            this.chcFacturaA.UseVisualStyleBackColor = true;
            this.chcFacturaA.CheckedChanged += new System.EventHandler(this.chcFacturaA_CheckedChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(349, 244);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(45, 16);
            this.label12.TabIndex = 16;
            this.label12.Text = "Altura:";
            // 
            // txtCalle
            // 
            this.txtCalle.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCalle.Location = new System.Drawing.Point(18, 263);
            this.txtCalle.Name = "txtCalle";
            this.txtCalle.Size = new System.Drawing.Size(211, 23);
            this.txtCalle.TabIndex = 2;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(350, 130);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(156, 16);
            this.label14.TabIndex = 23;
            this.label14.Text = "Tipo de Comprobante(*):";
            // 
            // cmbLocalidad
            // 
            this.cmbLocalidad.Enabled = false;
            this.cmbLocalidad.FormattingEnabled = true;
            this.cmbLocalidad.Location = new System.Drawing.Point(350, 202);
            this.cmbLocalidad.Name = "cmbLocalidad";
            this.cmbLocalidad.Size = new System.Drawing.Size(211, 24);
            this.cmbLocalidad.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(15, 244);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(42, 16);
            this.label11.TabIndex = 15;
            this.label11.Text = "Calle:";
            // 
            // cmbProvincia
            // 
            this.cmbProvincia.FormattingEnabled = true;
            this.cmbProvincia.Location = new System.Drawing.Point(18, 202);
            this.cmbProvincia.Name = "cmbProvincia";
            this.cmbProvincia.Size = new System.Drawing.Size(211, 24);
            this.cmbProvincia.TabIndex = 0;
            this.cmbProvincia.SelectedIndexChanged += new System.EventHandler(this.cmbProvincia_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(87, 92);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(14, 20);
            this.label8.TabIndex = 22;
            this.label8.Text = "-";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(349, 183);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 16);
            this.label10.TabIndex = 14;
            this.label10.Text = "Localidad:";
            // 
            // txtTelefono
            // 
            this.txtTelefono.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTelefono.Location = new System.Drawing.Point(106, 92);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(123, 23);
            this.txtTelefono.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(15, 183);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 16);
            this.label9.TabIndex = 13;
            this.label9.Text = "Provincia:";
            // 
            // txtCuit
            // 
            this.txtCuit.Location = new System.Drawing.Point(350, 40);
            this.txtCuit.Mask = "00-00000000-0";
            this.txtCuit.Name = "txtCuit";
            this.txtCuit.Size = new System.Drawing.Size(98, 23);
            this.txtCuit.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(351, 73);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 16);
            this.label7.TabIndex = 12;
            this.label7.Text = "Email:";
            // 
            // cmbCondicionAntiAfip
            // 
            this.cmbCondicionAntiAfip.FormattingEnabled = true;
            this.cmbCondicionAntiAfip.Location = new System.Drawing.Point(18, 149);
            this.cmbCondicionAntiAfip.Name = "cmbCondicionAntiAfip";
            this.cmbCondicionAntiAfip.Size = new System.Drawing.Size(211, 24);
            this.cmbCondicionAntiAfip.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(15, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Telefono:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Condición anti Afip(*):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(350, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Cuit(*):";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre o Razón Social(*):";
            // 
            // txtCodArea
            // 
            this.txtCodArea.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCodArea.Location = new System.Drawing.Point(18, 92);
            this.txtCodArea.Name = "txtCodArea";
            this.txtCodArea.Size = new System.Drawing.Size(63, 23);
            this.txtCodArea.TabIndex = 5;
            // 
            // txtEmail
            // 
            this.txtEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtEmail.Location = new System.Drawing.Point(350, 92);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(200, 23);
            this.txtEmail.TabIndex = 7;
            // 
            // txtNombreRazonSocial
            // 
            this.txtNombreRazonSocial.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNombreRazonSocial.Location = new System.Drawing.Point(18, 40);
            this.txtNombreRazonSocial.Name = "txtNombreRazonSocial";
            this.txtNombreRazonSocial.Size = new System.Drawing.Size(211, 23);
            this.txtNombreRazonSocial.TabIndex = 0;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(285, 664);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(330, 23);
            this.progressBar1.TabIndex = 19;
            this.progressBar1.Value = 50;
            this.progressBar1.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnCerrar);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(641, 32);
            this.panel1.TabIndex = 47;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 20);
            this.label3.TabIndex = 77;
            this.label3.Text = "Proveedor";
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Image = global::Sico.Properties.Resources.cancelar2;
            this.btnCerrar.Location = new System.Drawing.Point(610, 3);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(25, 25);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar.TabIndex = 76;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.SteelBlue;
            this.btnGuardar.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(335, 481);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(84, 40);
            this.btnGuardar.TabIndex = 171;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.SteelBlue;
            this.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(203, 481);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(84, 40);
            this.btnCancelar.TabIndex = 170;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnHabilitarBusqueda);
            this.panel2.Controls.Add(this.btnCrearSubCliente);
            this.panel2.Location = new System.Drawing.Point(-2, 33);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(641, 33);
            this.panel2.TabIndex = 172;
            // 
            // btnHabilitarBusqueda
            // 
            this.btnHabilitarBusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHabilitarBusqueda.Image = global::Sico.Properties.Resources.lupa__1_1;
            this.btnHabilitarBusqueda.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnHabilitarBusqueda.Location = new System.Drawing.Point(49, 0);
            this.btnHabilitarBusqueda.Name = "btnHabilitarBusqueda";
            this.btnHabilitarBusqueda.Size = new System.Drawing.Size(40, 32);
            this.btnHabilitarBusqueda.TabIndex = 166;
            this.btnHabilitarBusqueda.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnHabilitarBusqueda.UseVisualStyleBackColor = true;
            this.btnHabilitarBusqueda.Click += new System.EventHandler(this.btnHabilitarBusqueda_Click);
            // 
            // btnCrearSubCliente
            // 
            this.btnCrearSubCliente.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnCrearSubCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearSubCliente.Image = global::Sico.Properties.Resources.mas__2_;
            this.btnCrearSubCliente.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCrearSubCliente.Location = new System.Drawing.Point(3, 0);
            this.btnCrearSubCliente.Name = "btnCrearSubCliente";
            this.btnCrearSubCliente.Size = new System.Drawing.Size(40, 32);
            this.btnCrearSubCliente.TabIndex = 165;
            this.btnCrearSubCliente.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCrearSubCliente.UseVisualStyleBackColor = false;
            this.btnCrearSubCliente.Click += new System.EventHandler(this.btnCrearSubCliente_Click);
            // 
            // ProveedoresWF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(640, 533);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.grbFiltros);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.progressBar1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProveedoresWF";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProveedoresWF";
            this.Load += new System.EventHandler(this.ProveedoresWF_Load);
            this.grbFiltros.ResumeLayout(false);
            this.grbFiltros.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbFiltros;
        private System.Windows.Forms.MaskedTextBox txtCuitBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label lblDniOApellidoNombre;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtCodigoPostal;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtAltura;
        private System.Windows.Forms.TextBox txtCalle;
        private System.Windows.Forms.ComboBox cmbLocalidad;
        private System.Windows.Forms.ComboBox cmbProvincia;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.MaskedTextBox txtCuit;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ComboBox cmbCondicionAntiAfip;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCodArea;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtNombreRazonSocial;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.CheckBox chcFacturaC;
        private System.Windows.Forms.CheckBox chcFacturaB;
        private System.Windows.Forms.CheckBox chcFacturaA;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnHabilitarBusqueda;
        private System.Windows.Forms.Button btnCrearSubCliente;
    }
}