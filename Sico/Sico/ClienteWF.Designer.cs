﻿namespace Sico
{
    partial class ClienteWF
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.chcPorDni = new System.Windows.Forms.CheckBox();
            this.chcPorApellido = new System.Windows.Forms.CheckBox();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.lblDniOApellidoNombre = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnHabilitarBuscar = new System.Windows.Forms.Button();
            this.btnNuevoCliente = new System.Windows.Forms.Button();
            this.btnHistorial = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtFechaInscripcion = new System.Windows.Forms.DateTimePicker();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtCodigoPostal = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtAltura = new System.Windows.Forms.TextBox();
            this.txtCalle = new System.Windows.Forms.TextBox();
            this.cmbLocalidad = new System.Windows.Forms.ComboBox();
            this.cmbProvincia = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txtCuit = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.cmbCondicionAntiAfip = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCodArea = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtActividad = new System.Windows.Forms.TextBox();
            this.txtNombreRazonSocial = new System.Windows.Forms.TextBox();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnBuscar);
            this.groupBox3.Controls.Add(this.chcPorDni);
            this.groupBox3.Controls.Add(this.chcPorApellido);
            this.groupBox3.Controls.Add(this.txtBuscar);
            this.groupBox3.Controls.Add(this.lblDniOApellidoNombre);
            this.groupBox3.Location = new System.Drawing.Point(35, 63);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(878, 72);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Buscar Cliente";
            this.groupBox3.Visible = false;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Image = global::Sico.Properties.Resources.buscar_con_herramienta_en_esquema;
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnBuscar.Location = new System.Drawing.Point(738, 29);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(49, 39);
            this.btnBuscar.TabIndex = 10;
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // chcPorDni
            // 
            this.chcPorDni.AutoSize = true;
            this.chcPorDni.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chcPorDni.Location = new System.Drawing.Point(108, 19);
            this.chcPorDni.Name = "chcPorDni";
            this.chcPorDni.Size = new System.Drawing.Size(74, 21);
            this.chcPorDni.TabIndex = 8;
            this.chcPorDni.Text = "Por Dni";
            this.chcPorDni.UseVisualStyleBackColor = true;
            // 
            // chcPorApellido
            // 
            this.chcPorApellido.AutoSize = true;
            this.chcPorApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chcPorApellido.Location = new System.Drawing.Point(238, 19);
            this.chcPorApellido.Name = "chcPorApellido";
            this.chcPorApellido.Size = new System.Drawing.Size(103, 21);
            this.chcPorApellido.TabIndex = 9;
            this.chcPorApellido.Text = "Por Apellido";
            this.chcPorApellido.UseVisualStyleBackColor = true;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Enabled = false;
            this.txtBuscar.Location = new System.Drawing.Point(227, 48);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(491, 20);
            this.txtBuscar.TabIndex = 4;
            // 
            // lblDniOApellidoNombre
            // 
            this.lblDniOApellidoNombre.AutoSize = true;
            this.lblDniOApellidoNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDniOApellidoNombre.Location = new System.Drawing.Point(33, 46);
            this.lblDniOApellidoNombre.Name = "lblDniOApellidoNombre";
            this.lblDniOApellidoNombre.Size = new System.Drawing.Size(79, 20);
            this.lblDniOApellidoNombre.TabIndex = 3;
            this.lblDniOApellidoNombre.Text = "Buscar(*):";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnHabilitarBuscar);
            this.groupBox2.Controls.Add(this.btnNuevoCliente);
            this.groupBox2.Controls.Add(this.btnHistorial);
            this.groupBox2.Controls.Add(this.btnEliminar);
            this.groupBox2.Controls.Add(this.btnEditar);
            this.groupBox2.Location = new System.Drawing.Point(929, 140);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(186, 452);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tareas";
            // 
            // btnHabilitarBuscar
            // 
            this.btnHabilitarBuscar.Image = global::Sico.Properties.Resources.buscar_con_herramienta_en_esquema;
            this.btnHabilitarBuscar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnHabilitarBuscar.Location = new System.Drawing.Point(45, 98);
            this.btnHabilitarBuscar.Name = "btnHabilitarBuscar";
            this.btnHabilitarBuscar.Size = new System.Drawing.Size(90, 61);
            this.btnHabilitarBuscar.TabIndex = 7;
            this.btnHabilitarBuscar.Text = "Buscar";
            this.btnHabilitarBuscar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnHabilitarBuscar.UseVisualStyleBackColor = true;
            // 
            // btnNuevoCliente
            // 
            this.btnNuevoCliente.Image = global::Sico.Properties.Resources.agregar_usuario_nuevo;
            this.btnNuevoCliente.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnNuevoCliente.Location = new System.Drawing.Point(45, 19);
            this.btnNuevoCliente.Name = "btnNuevoCliente";
            this.btnNuevoCliente.Size = new System.Drawing.Size(90, 61);
            this.btnNuevoCliente.TabIndex = 1;
            this.btnNuevoCliente.Text = "Nuevo cliente";
            this.btnNuevoCliente.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnNuevoCliente.UseVisualStyleBackColor = true;
            this.btnNuevoCliente.Click += new System.EventHandler(this.btnNuevoCliente_Click);
            // 
            // btnHistorial
            // 
            this.btnHistorial.Image = global::Sico.Properties.Resources.diagnostico;
            this.btnHistorial.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnHistorial.Location = new System.Drawing.Point(45, 348);
            this.btnHistorial.Name = "btnHistorial";
            this.btnHistorial.Size = new System.Drawing.Size(90, 61);
            this.btnHistorial.TabIndex = 6;
            this.btnHistorial.Text = "Historial";
            this.btnHistorial.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnHistorial.UseVisualStyleBackColor = true;
            this.btnHistorial.Visible = false;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Image = global::Sico.Properties.Resources.borrar_usuario;
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEliminar.Location = new System.Drawing.Point(45, 255);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(90, 61);
            this.btnEliminar.TabIndex = 5;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Visible = false;
            // 
            // btnEditar
            // 
            this.btnEditar.Image = global::Sico.Properties.Resources.usuario;
            this.btnEditar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEditar.Location = new System.Drawing.Point(45, 175);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(90, 61);
            this.btnEditar.TabIndex = 4;
            this.btnEditar.Text = "Editar";
            this.btnEditar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtFechaInscripcion);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtTelefono);
            this.groupBox1.Controls.Add(this.btnGuardar);
            this.groupBox1.Controls.Add(this.btnCancelar);
            this.groupBox1.Controls.Add(this.txtCuit);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.progressBar1);
            this.groupBox1.Controls.Add(this.cmbCondicionAntiAfip);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtCodArea);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.txtActividad);
            this.groupBox1.Controls.Add(this.txtNombreRazonSocial);
            this.groupBox1.Enabled = false;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(35, 138);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(878, 495);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // dtFechaInscripcion
            // 
            this.dtFechaInscripcion.Location = new System.Drawing.Point(626, 114);
            this.dtFechaInscripcion.Name = "dtFechaInscripcion";
            this.dtFechaInscripcion.Size = new System.Drawing.Size(211, 23);
            this.dtFechaInscripcion.TabIndex = 24;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtCodigoPostal);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.txtAltura);
            this.groupBox4.Controls.Add(this.txtCalle);
            this.groupBox4.Controls.Add(this.cmbLocalidad);
            this.groupBox4.Controls.Add(this.cmbProvincia);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Location = new System.Drawing.Point(3, 295);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(869, 125);
            this.groupBox4.TabIndex = 20;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Datos Domicilio";
            // 
            // txtCodigoPostal
            // 
            this.txtCodigoPostal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCodigoPostal.Location = new System.Drawing.Point(652, 66);
            this.txtCodigoPostal.Name = "txtCodigoPostal";
            this.txtCodigoPostal.PasswordChar = '*';
            this.txtCodigoPostal.Size = new System.Drawing.Size(211, 23);
            this.txtCodigoPostal.TabIndex = 23;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(542, 69);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(110, 20);
            this.label13.TabIndex = 22;
            this.label13.Text = "Código postal:";
            // 
            // txtAltura
            // 
            this.txtAltura.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtAltura.Location = new System.Drawing.Point(331, 69);
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.PasswordChar = '*';
            this.txtAltura.Size = new System.Drawing.Size(211, 23);
            this.txtAltura.TabIndex = 20;
            // 
            // txtCalle
            // 
            this.txtCalle.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCalle.Location = new System.Drawing.Point(56, 69);
            this.txtCalle.Name = "txtCalle";
            this.txtCalle.PasswordChar = '*';
            this.txtCalle.Size = new System.Drawing.Size(211, 23);
            this.txtCalle.TabIndex = 19;
            // 
            // cmbLocalidad
            // 
            this.cmbLocalidad.FormattingEnabled = true;
            this.cmbLocalidad.Location = new System.Drawing.Point(623, 19);
            this.cmbLocalidad.Name = "cmbLocalidad";
            this.cmbLocalidad.Size = new System.Drawing.Size(211, 24);
            this.cmbLocalidad.TabIndex = 18;
            // 
            // cmbProvincia
            // 
            this.cmbProvincia.FormattingEnabled = true;
            this.cmbProvincia.Location = new System.Drawing.Point(206, 19);
            this.cmbProvincia.Name = "cmbProvincia";
            this.cmbProvincia.Size = new System.Drawing.Size(211, 24);
            this.cmbProvincia.TabIndex = 17;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(270, 69);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(55, 20);
            this.label12.TabIndex = 16;
            this.label12.Text = "Altura:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(2, 69);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 20);
            this.label11.TabIndex = 15;
            this.label11.Text = "Calle:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(536, 19);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 20);
            this.label10.TabIndex = 14;
            this.label10.Text = "Localidad:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(124, 19);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 20);
            this.label9.TabIndex = 13;
            this.label9.Text = "Provincia:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(695, 192);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(14, 20);
            this.label8.TabIndex = 22;
            this.label8.Text = "-";
            // 
            // txtTelefono
            // 
            this.txtTelefono.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTelefono.Location = new System.Drawing.Point(714, 192);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.PasswordChar = '*';
            this.txtTelefono.Size = new System.Drawing.Size(123, 23);
            this.txtTelefono.TabIndex = 21;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Image = global::Sico.Properties.Resources.copia_de_seguridad;
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnGuardar.Location = new System.Drawing.Point(425, 426);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(80, 51);
            this.btnGuardar.TabIndex = 7;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Image = global::Sico.Properties.Resources.cancelar;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCancelar.Location = new System.Drawing.Point(327, 426);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(80, 51);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // txtCuit
            // 
            this.txtCuit.Location = new System.Drawing.Point(626, 39);
            this.txtCuit.Name = "txtCuit";
            this.txtCuit.Size = new System.Drawing.Size(211, 23);
            this.txtCuit.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(151, 257);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "Email:";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(290, 221);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(330, 23);
            this.progressBar1.TabIndex = 19;
            this.progressBar1.Value = 50;
            this.progressBar1.Visible = false;
            // 
            // cmbCondicionAntiAfip
            // 
            this.cmbCondicionAntiAfip.FormattingEnabled = true;
            this.cmbCondicionAntiAfip.Location = new System.Drawing.Point(209, 189);
            this.cmbCondicionAntiAfip.Name = "cmbCondicionAntiAfip";
            this.cmbCondicionAntiAfip.Size = new System.Drawing.Size(211, 24);
            this.cmbCondicionAntiAfip.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(545, 192);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Telefono:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(42, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(161, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Condición anti Afip(*):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(563, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Cuit(*):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(446, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(174, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Fecha de inscripción(*):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(115, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Actividad(*):";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre o Razón Social(*):";
            // 
            // txtCodArea
            // 
            this.txtCodArea.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCodArea.Location = new System.Drawing.Point(626, 192);
            this.txtCodArea.Name = "txtCodArea";
            this.txtCodArea.PasswordChar = '*';
            this.txtCodArea.Size = new System.Drawing.Size(63, 23);
            this.txtCodArea.TabIndex = 5;
            // 
            // txtEmail
            // 
            this.txtEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtEmail.Location = new System.Drawing.Point(209, 257);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PasswordChar = '*';
            this.txtEmail.Size = new System.Drawing.Size(211, 23);
            this.txtEmail.TabIndex = 4;
            // 
            // txtActividad
            // 
            this.txtActividad.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtActividad.Location = new System.Drawing.Point(209, 116);
            this.txtActividad.Name = "txtActividad";
            this.txtActividad.Size = new System.Drawing.Size(211, 23);
            this.txtActividad.TabIndex = 1;
            // 
            // txtNombreRazonSocial
            // 
            this.txtNombreRazonSocial.Location = new System.Drawing.Point(209, 39);
            this.txtNombreRazonSocial.Name = "txtNombreRazonSocial";
            this.txtNombreRazonSocial.Size = new System.Drawing.Size(211, 23);
            this.txtNombreRazonSocial.TabIndex = 0;
            // 
            // ClienteWF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1474, 657);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "ClienteWF";
            this.Text = "Cliente";
            this.Load += new System.EventHandler(this.ClienteWF_Load);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.groupBox2, 0);
            this.Controls.SetChildIndex(this.groupBox3, 0);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.CheckBox chcPorDni;
        private System.Windows.Forms.CheckBox chcPorApellido;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label lblDniOApellidoNombre;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnHabilitarBuscar;
        private System.Windows.Forms.Button btnNuevoCliente;
        private System.Windows.Forms.Button btnHistorial;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbCondicionAntiAfip;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCodArea;
        private System.Windows.Forms.TextBox txtActividad;
        private System.Windows.Forms.TextBox txtNombreRazonSocial;
        private System.Windows.Forms.MaskedTextBox txtCuit;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox cmbLocalidad;
        private System.Windows.Forms.ComboBox cmbProvincia;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtAltura;
        private System.Windows.Forms.TextBox txtCalle;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtCodigoPostal;
        private System.Windows.Forms.DateTimePicker dtFechaInscripcion;
        private System.Windows.Forms.TextBox txtEmail;
    }
}