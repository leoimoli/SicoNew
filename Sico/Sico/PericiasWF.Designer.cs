namespace Sico
{
    partial class PericiasWF
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
            this.cmbTribunalBuscar = new System.Windows.Forms.ComboBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.chcPorTribunal = new System.Windows.Forms.CheckBox();
            this.chcPorCausa = new System.Windows.Forms.CheckBox();
            this.txtCausaBuscar = new System.Windows.Forms.TextBox();
            this.lblDniOApellidoNombre = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnHabilitarBuscar = new System.Windows.Forms.Button();
            this.btnNuevaPericia = new System.Windows.Forms.Button();
            this.btnHistorial = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvPericias = new System.Windows.Forms.DataGridView();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.chcCompartirPericia = new System.Windows.Forms.CheckBox();
            this.btnCargarArchivo3 = new System.Windows.Forms.Button();
            this.btnCargarArchivo2 = new System.Windows.Forms.Button();
            this.btnCargarArchivo1 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtArchivo3 = new System.Windows.Forms.TextBox();
            this.txtArchivo2 = new System.Windows.Forms.TextBox();
            this.txtArchivo1 = new System.Windows.Forms.TextBox();
            this.txtCausa = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNroCausa = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.dtFechaPericia = new System.Windows.Forms.DateTimePicker();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.cmbTribunal = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog3 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPericias)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cmbTribunalBuscar);
            this.groupBox3.Controls.Add(this.btnBuscar);
            this.groupBox3.Controls.Add(this.chcPorTribunal);
            this.groupBox3.Controls.Add(this.chcPorCausa);
            this.groupBox3.Controls.Add(this.txtCausaBuscar);
            this.groupBox3.Controls.Add(this.lblDniOApellidoNombre);
            this.groupBox3.Location = new System.Drawing.Point(54, 85);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(878, 72);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Buscar Pericias";
            this.groupBox3.Visible = false;
            // 
            // cmbTribunalBuscar
            // 
            this.cmbTribunalBuscar.FormattingEnabled = true;
            this.cmbTribunalBuscar.Location = new System.Drawing.Point(118, 45);
            this.cmbTribunalBuscar.Name = "cmbTribunalBuscar";
            this.cmbTribunalBuscar.Size = new System.Drawing.Size(180, 21);
            this.cmbTribunalBuscar.TabIndex = 4;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Image = global::Sico.Properties.Resources.buscar_con_herramienta_en_esquema;
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnBuscar.Location = new System.Drawing.Point(738, 29);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(49, 39);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // chcPorTribunal
            // 
            this.chcPorTribunal.AutoSize = true;
            this.chcPorTribunal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chcPorTribunal.Location = new System.Drawing.Point(108, 19);
            this.chcPorTribunal.Name = "chcPorTribunal";
            this.chcPorTribunal.Size = new System.Drawing.Size(105, 21);
            this.chcPorTribunal.TabIndex = 0;
            this.chcPorTribunal.Text = "Por Tribunal";
            this.chcPorTribunal.UseVisualStyleBackColor = true;
            this.chcPorTribunal.CheckedChanged += new System.EventHandler(this.chcPorTribunal_CheckedChanged);
            // 
            // chcPorCausa
            // 
            this.chcPorCausa.AutoSize = true;
            this.chcPorCausa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chcPorCausa.Location = new System.Drawing.Point(238, 19);
            this.chcPorCausa.Name = "chcPorCausa";
            this.chcPorCausa.Size = new System.Drawing.Size(93, 21);
            this.chcPorCausa.TabIndex = 1;
            this.chcPorCausa.Text = "Por Causa";
            this.chcPorCausa.UseVisualStyleBackColor = true;
            this.chcPorCausa.CheckedChanged += new System.EventHandler(this.chcPorCausa_CheckedChanged);
            // 
            // txtCausaBuscar
            // 
            this.txtCausaBuscar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCausaBuscar.Enabled = false;
            this.txtCausaBuscar.Location = new System.Drawing.Point(317, 45);
            this.txtCausaBuscar.Name = "txtCausaBuscar";
            this.txtCausaBuscar.Size = new System.Drawing.Size(401, 20);
            this.txtCausaBuscar.TabIndex = 2;
            this.txtCausaBuscar.Visible = false;
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
            this.groupBox2.Controls.Add(this.btnNuevaPericia);
            this.groupBox2.Controls.Add(this.btnHistorial);
            this.groupBox2.Controls.Add(this.btnEliminar);
            this.groupBox2.Controls.Add(this.btnEditar);
            this.groupBox2.Location = new System.Drawing.Point(948, 162);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(186, 452);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Funciones";
            // 
            // btnHabilitarBuscar
            // 
            this.btnHabilitarBuscar.Image = global::Sico.Properties.Resources.buscar_con_herramienta_en_esquema;
            this.btnHabilitarBuscar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnHabilitarBuscar.Location = new System.Drawing.Point(45, 98);
            this.btnHabilitarBuscar.Name = "btnHabilitarBuscar";
            this.btnHabilitarBuscar.Size = new System.Drawing.Size(90, 61);
            this.btnHabilitarBuscar.TabIndex = 1;
            this.btnHabilitarBuscar.Text = "Buscar";
            this.btnHabilitarBuscar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnHabilitarBuscar.UseVisualStyleBackColor = true;
            this.btnHabilitarBuscar.Click += new System.EventHandler(this.btnHabilitarBuscar_Click);
            // 
            // btnNuevaPericia
            // 
            this.btnNuevaPericia.Image = global::Sico.Properties.Resources.agregar_usuario_nuevo;
            this.btnNuevaPericia.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnNuevaPericia.Location = new System.Drawing.Point(45, 19);
            this.btnNuevaPericia.Name = "btnNuevaPericia";
            this.btnNuevaPericia.Size = new System.Drawing.Size(90, 61);
            this.btnNuevaPericia.TabIndex = 0;
            this.btnNuevaPericia.Text = "Nueva Pericia";
            this.btnNuevaPericia.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnNuevaPericia.UseVisualStyleBackColor = true;
            this.btnNuevaPericia.Click += new System.EventHandler(this.btnNuevaPericia_Click);
            // 
            // btnHistorial
            // 
            this.btnHistorial.Image = global::Sico.Properties.Resources.diagnostico;
            this.btnHistorial.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnHistorial.Location = new System.Drawing.Point(45, 348);
            this.btnHistorial.Name = "btnHistorial";
            this.btnHistorial.Size = new System.Drawing.Size(90, 61);
            this.btnHistorial.TabIndex = 4;
            this.btnHistorial.Text = "Tareas";
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
            this.btnEliminar.TabIndex = 3;
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
            this.btnEditar.TabIndex = 2;
            this.btnEditar.Text = "Editar";
            this.btnEditar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvPericias);
            this.groupBox1.Controls.Add(this.progressBar1);
            this.groupBox1.Controls.Add(this.lblEmail);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.chcCompartirPericia);
            this.groupBox1.Controls.Add(this.btnCargarArchivo3);
            this.groupBox1.Controls.Add(this.btnCargarArchivo2);
            this.groupBox1.Controls.Add(this.btnCargarArchivo1);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtArchivo3);
            this.groupBox1.Controls.Add(this.txtArchivo2);
            this.groupBox1.Controls.Add(this.txtArchivo1);
            this.groupBox1.Controls.Add(this.txtCausa);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtNroCausa);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.dtFechaPericia);
            this.groupBox1.Controls.Add(this.btnGuardar);
            this.groupBox1.Controls.Add(this.btnCancelar);
            this.groupBox1.Controls.Add(this.cmbTribunal);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Enabled = false;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(54, 160);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(878, 400);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // dgvPericias
            // 
            this.dgvPericias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPericias.Location = new System.Drawing.Point(6, 37);
            this.dgvPericias.Name = "dgvPericias";
            this.dgvPericias.Size = new System.Drawing.Size(830, 358);
            this.dgvPericias.TabIndex = 14;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(264, 319);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(330, 23);
            this.progressBar1.TabIndex = 19;
            this.progressBar1.Value = 50;
            this.progressBar1.Visible = false;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(334, 296);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(127, 20);
            this.lblEmail.TabIndex = 39;
            this.lblEmail.Text = "Email Destino(*):";
            this.lblEmail.Visible = false;
            // 
            // txtEmail
            // 
            this.txtEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtEmail.Location = new System.Drawing.Point(457, 296);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(250, 23);
            this.txtEmail.TabIndex = 38;
            this.txtEmail.Visible = false;
            // 
            // chcCompartirPericia
            // 
            this.chcCompartirPericia.AutoSize = true;
            this.chcCompartirPericia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chcCompartirPericia.Location = new System.Drawing.Point(186, 298);
            this.chcCompartirPericia.Name = "chcCompartirPericia";
            this.chcCompartirPericia.Size = new System.Drawing.Size(114, 21);
            this.chcCompartirPericia.TabIndex = 37;
            this.chcCompartirPericia.Text = "Enviar Pericia";
            this.chcCompartirPericia.UseVisualStyleBackColor = true;
            this.chcCompartirPericia.CheckedChanged += new System.EventHandler(this.chcCompartirPericia_CheckedChanged);
            // 
            // btnCargarArchivo3
            // 
            this.btnCargarArchivo3.BackColor = System.Drawing.Color.Transparent;
            this.btnCargarArchivo3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCargarArchivo3.Location = new System.Drawing.Point(594, 249);
            this.btnCargarArchivo3.Name = "btnCargarArchivo3";
            this.btnCargarArchivo3.Size = new System.Drawing.Size(45, 35);
            this.btnCargarArchivo3.TabIndex = 36;
            this.btnCargarArchivo3.UseVisualStyleBackColor = false;
            this.btnCargarArchivo3.Click += new System.EventHandler(this.btnCargarArchivo3_Click);
            // 
            // btnCargarArchivo2
            // 
            this.btnCargarArchivo2.BackColor = System.Drawing.Color.Transparent;
            this.btnCargarArchivo2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCargarArchivo2.Location = new System.Drawing.Point(594, 208);
            this.btnCargarArchivo2.Name = "btnCargarArchivo2";
            this.btnCargarArchivo2.Size = new System.Drawing.Size(45, 35);
            this.btnCargarArchivo2.TabIndex = 35;
            this.btnCargarArchivo2.UseVisualStyleBackColor = false;
            this.btnCargarArchivo2.Click += new System.EventHandler(this.btnCargarArchivo2_Click);
            // 
            // btnCargarArchivo1
            // 
            this.btnCargarArchivo1.BackColor = System.Drawing.Color.Transparent;
            this.btnCargarArchivo1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCargarArchivo1.Location = new System.Drawing.Point(594, 169);
            this.btnCargarArchivo1.Name = "btnCargarArchivo1";
            this.btnCargarArchivo1.Size = new System.Drawing.Size(45, 35);
            this.btnCargarArchivo1.TabIndex = 34;
            this.btnCargarArchivo1.UseVisualStyleBackColor = false;
            this.btnCargarArchivo1.Click += new System.EventHandler(this.btnCargarArchivo1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(182, 257);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(129, 20);
            this.label8.TabIndex = 33;
            this.label8.Text = "Adjuntar Archivo:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(182, 216);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(129, 20);
            this.label7.TabIndex = 32;
            this.label7.Text = "Adjuntar Archivo:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(182, 177);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 20);
            this.label6.TabIndex = 31;
            this.label6.Text = "Adjuntar Archivo:";
            // 
            // txtArchivo3
            // 
            this.txtArchivo3.Location = new System.Drawing.Point(317, 257);
            this.txtArchivo3.Name = "txtArchivo3";
            this.txtArchivo3.Size = new System.Drawing.Size(250, 23);
            this.txtArchivo3.TabIndex = 30;
            // 
            // txtArchivo2
            // 
            this.txtArchivo2.Location = new System.Drawing.Point(317, 216);
            this.txtArchivo2.Name = "txtArchivo2";
            this.txtArchivo2.Size = new System.Drawing.Size(250, 23);
            this.txtArchivo2.TabIndex = 29;
            // 
            // txtArchivo1
            // 
            this.txtArchivo1.Location = new System.Drawing.Point(317, 177);
            this.txtArchivo1.Name = "txtArchivo1";
            this.txtArchivo1.Size = new System.Drawing.Size(250, 23);
            this.txtArchivo1.TabIndex = 28;
            // 
            // txtCausa
            // 
            this.txtCausa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCausa.Location = new System.Drawing.Point(544, 116);
            this.txtCausa.Name = "txtCausa";
            this.txtCausa.Size = new System.Drawing.Size(250, 23);
            this.txtCausa.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(463, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 20);
            this.label5.TabIndex = 26;
            this.label5.Text = "Causa(*):";
            // 
            // txtNroCausa
            // 
            this.txtNroCausa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNroCausa.Location = new System.Drawing.Point(177, 116);
            this.txtNroCausa.Name = "txtNroCausa";
            this.txtNroCausa.Size = new System.Drawing.Size(250, 23);
            this.txtNroCausa.TabIndex = 25;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(480, 39);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(58, 20);
            this.label14.TabIndex = 23;
            this.label14.Text = "Fecha:";
            // 
            // dtFechaPericia
            // 
            this.dtFechaPericia.Location = new System.Drawing.Point(544, 37);
            this.dtFechaPericia.Name = "dtFechaPericia";
            this.dtFechaPericia.Size = new System.Drawing.Size(250, 23);
            this.dtFechaPericia.TabIndex = 3;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Image = global::Sico.Properties.Resources.copia_de_seguridad;
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnGuardar.Location = new System.Drawing.Point(421, 343);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(80, 51);
            this.btnGuardar.TabIndex = 9;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Image = global::Sico.Properties.Resources.cancelar;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCancelar.Location = new System.Drawing.Point(323, 343);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(80, 51);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // cmbTribunal
            // 
            this.cmbTribunal.FormattingEnabled = true;
            this.cmbTribunal.Location = new System.Drawing.Point(177, 39);
            this.cmbTribunal.Name = "cmbTribunal";
            this.cmbTribunal.Size = new System.Drawing.Size(250, 24);
            this.cmbTribunal.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(75, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Nro.Causa(*):";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(94, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tribunal(*):";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            // 
            // openFileDialog3
            // 
            this.openFileDialog3.FileName = "openFileDialog3";
            // 
            // PericiasWF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 743);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "PericiasWF";
            this.Text = "PericiasWF";
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.groupBox2, 0);
            this.Controls.SetChildIndex(this.groupBox3, 0);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPericias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.CheckBox chcPorTribunal;
        private System.Windows.Forms.CheckBox chcPorCausa;
        private System.Windows.Forms.TextBox txtCausaBuscar;
        private System.Windows.Forms.Label lblDniOApellidoNombre;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnHabilitarBuscar;
        private System.Windows.Forms.Button btnNuevaPericia;
        private System.Windows.Forms.Button btnHistorial;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DateTimePicker dtFechaPericia;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ComboBox cmbTribunal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbTribunalBuscar;
        private System.Windows.Forms.TextBox txtNroCausa;
        private System.Windows.Forms.TextBox txtCausa;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtArchivo3;
        private System.Windows.Forms.TextBox txtArchivo2;
        private System.Windows.Forms.TextBox txtArchivo1;
        private System.Windows.Forms.Button btnCargarArchivo3;
        private System.Windows.Forms.Button btnCargarArchivo2;
        private System.Windows.Forms.Button btnCargarArchivo1;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.CheckBox chcCompartirPericia;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.OpenFileDialog openFileDialog3;
        private System.Windows.Forms.DataGridView dgvPericias;
    }
}