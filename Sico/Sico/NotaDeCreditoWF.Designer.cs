namespace Sico
{
    partial class NotaDeCreditoWF
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbTipoFactura = new System.Windows.Forms.ComboBox();
            this.lblDireccionEdit = new System.Windows.Forms.TextBox();
            this.lblDniEdit = new System.Windows.Forms.TextBox();
            this.lblObservacionsEdit = new System.Windows.Forms.Label();
            this.lblObservaciones = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblDni = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.lblTotalEdit = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lbl105 = new System.Windows.Forms.Label();
            this.lbl21 = new System.Windows.Forms.Label();
            this.lbl27 = new System.Windows.Forms.Label();
            this.txtIva3 = new System.Windows.Forms.TextBox();
            this.txtIva2 = new System.Windows.Forms.TextBox();
            this.txtIva1 = new System.Windows.Forms.TextBox();
            this.txtNeto3 = new System.Windows.Forms.TextBox();
            this.txtNeto2 = new System.Windows.Forms.TextBox();
            this.txtNeto1 = new System.Windows.Forms.TextBox();
            this.txtTotal3 = new System.Windows.Forms.TextBox();
            this.txtTotal2 = new System.Windows.Forms.TextBox();
            this.txtTotal1 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtFactura = new System.Windows.Forms.MaskedTextBox();
            this.dtFecha = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbPersonas = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblCuitEdit = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNombreEdit = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.cmbTipoFactura);
            this.groupBox2.Controls.Add(this.lblDireccionEdit);
            this.groupBox2.Controls.Add(this.lblDniEdit);
            this.groupBox2.Controls.Add(this.lblObservacionsEdit);
            this.groupBox2.Controls.Add(this.lblObservaciones);
            this.groupBox2.Controls.Add(this.lblDireccion);
            this.groupBox2.Controls.Add(this.lblDni);
            this.groupBox2.Controls.Add(this.progressBar1);
            this.groupBox2.Controls.Add(this.lblTotalEdit);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.lbl105);
            this.groupBox2.Controls.Add(this.lbl21);
            this.groupBox2.Controls.Add(this.lbl27);
            this.groupBox2.Controls.Add(this.txtIva3);
            this.groupBox2.Controls.Add(this.txtIva2);
            this.groupBox2.Controls.Add(this.txtIva1);
            this.groupBox2.Controls.Add(this.txtNeto3);
            this.groupBox2.Controls.Add(this.txtNeto2);
            this.groupBox2.Controls.Add(this.txtNeto1);
            this.groupBox2.Controls.Add(this.txtTotal3);
            this.groupBox2.Controls.Add(this.txtTotal2);
            this.groupBox2.Controls.Add(this.txtTotal1);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtFactura);
            this.groupBox2.Controls.Add(this.dtFecha);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.cmbPersonas);
            this.groupBox2.Location = new System.Drawing.Point(12, 54);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(616, 365);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Factura sub-cliente";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(116, 19);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(127, 17);
            this.label10.TabIndex = 51;
            this.label10.Text = "Tipo de Factura(*):";
            // 
            // cmbTipoFactura
            // 
            this.cmbTipoFactura.FormattingEnabled = true;
            this.cmbTipoFactura.Location = new System.Drawing.Point(244, 19);
            this.cmbTipoFactura.Name = "cmbTipoFactura";
            this.cmbTipoFactura.Size = new System.Drawing.Size(211, 21);
            this.cmbTipoFactura.TabIndex = 50;
            this.cmbTipoFactura.SelectedIndexChanged += new System.EventHandler(this.cmbTipoFactura_SelectedIndexChanged);
            // 
            // lblDireccionEdit
            // 
            this.lblDireccionEdit.Location = new System.Drawing.Point(490, 88);
            this.lblDireccionEdit.Name = "lblDireccionEdit";
            this.lblDireccionEdit.Size = new System.Drawing.Size(120, 20);
            this.lblDireccionEdit.TabIndex = 49;
            this.lblDireccionEdit.Visible = false;
            // 
            // lblDniEdit
            // 
            this.lblDniEdit.Location = new System.Drawing.Point(110, 88);
            this.lblDniEdit.Name = "lblDniEdit";
            this.lblDniEdit.Size = new System.Drawing.Size(140, 20);
            this.lblDniEdit.TabIndex = 48;
            this.lblDniEdit.Visible = false;
            // 
            // lblObservacionsEdit
            // 
            this.lblObservacionsEdit.AutoSize = true;
            this.lblObservacionsEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObservacionsEdit.Location = new System.Drawing.Point(119, 113);
            this.lblObservacionsEdit.Name = "lblObservacionsEdit";
            this.lblObservacionsEdit.Size = new System.Drawing.Size(91, 15);
            this.lblObservacionsEdit.TabIndex = 47;
            this.lblObservacionsEdit.Text = "Observaciones:";
            this.lblObservacionsEdit.Visible = false;
            // 
            // lblObservaciones
            // 
            this.lblObservaciones.AutoSize = true;
            this.lblObservaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObservaciones.Location = new System.Drawing.Point(22, 113);
            this.lblObservaciones.Name = "lblObservaciones";
            this.lblObservaciones.Size = new System.Drawing.Size(91, 15);
            this.lblObservaciones.TabIndex = 46;
            this.lblObservaciones.Text = "Observaciones:";
            this.lblObservaciones.Visible = false;
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccion.Location = new System.Drawing.Point(422, 91);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(62, 15);
            this.lblDireccion.TabIndex = 44;
            this.lblDireccion.Text = "Dirección:";
            this.lblDireccion.Visible = false;
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDni.Location = new System.Drawing.Point(84, 91);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(29, 15);
            this.lblDni.TabIndex = 42;
            this.lblDni.Text = "Dni:";
            this.lblDni.Visible = false;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(155, 336);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(330, 23);
            this.progressBar1.TabIndex = 40;
            this.progressBar1.Value = 50;
            this.progressBar1.Visible = false;
            // 
            // lblTotalEdit
            // 
            this.lblTotalEdit.AutoSize = true;
            this.lblTotalEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalEdit.Location = new System.Drawing.Point(52, 332);
            this.lblTotalEdit.Name = "lblTotalEdit";
            this.lblTotalEdit.Size = new System.Drawing.Size(13, 17);
            this.lblTotalEdit.TabIndex = 39;
            this.lblTotalEdit.Text = "-";
            this.lblTotalEdit.Visible = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(6, 332);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(40, 17);
            this.label13.TabIndex = 38;
            this.label13.Text = "Total";
            this.label13.Visible = false;
            // 
            // lbl105
            // 
            this.lbl105.AutoSize = true;
            this.lbl105.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl105.Location = new System.Drawing.Point(373, 211);
            this.lbl105.Name = "lbl105";
            this.lbl105.Size = new System.Drawing.Size(48, 17);
            this.lbl105.TabIndex = 37;
            this.lbl105.Text = "10,5%";
            this.lbl105.Visible = false;
            // 
            // lbl21
            // 
            this.lbl21.AutoSize = true;
            this.lbl21.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl21.Location = new System.Drawing.Point(385, 253);
            this.lbl21.Name = "lbl21";
            this.lbl21.Size = new System.Drawing.Size(36, 17);
            this.lbl21.TabIndex = 36;
            this.lbl21.Text = "21%";
            this.lbl21.Visible = false;
            // 
            // lbl27
            // 
            this.lbl27.AutoSize = true;
            this.lbl27.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl27.Location = new System.Drawing.Point(385, 298);
            this.lbl27.Name = "lbl27";
            this.lbl27.Size = new System.Drawing.Size(36, 17);
            this.lbl27.TabIndex = 35;
            this.lbl27.Text = "27%";
            this.lbl27.Visible = false;
            // 
            // txtIva3
            // 
            this.txtIva3.Location = new System.Drawing.Point(461, 297);
            this.txtIva3.Name = "txtIva3";
            this.txtIva3.Size = new System.Drawing.Size(149, 20);
            this.txtIva3.TabIndex = 34;
            this.txtIva3.Visible = false;
            // 
            // txtIva2
            // 
            this.txtIva2.Location = new System.Drawing.Point(461, 252);
            this.txtIva2.Name = "txtIva2";
            this.txtIva2.Size = new System.Drawing.Size(149, 20);
            this.txtIva2.TabIndex = 33;
            this.txtIva2.Visible = false;
            // 
            // txtIva1
            // 
            this.txtIva1.Location = new System.Drawing.Point(461, 210);
            this.txtIva1.Name = "txtIva1";
            this.txtIva1.Size = new System.Drawing.Size(149, 20);
            this.txtIva1.TabIndex = 32;
            this.txtIva1.Visible = false;
            // 
            // txtNeto3
            // 
            this.txtNeto3.Location = new System.Drawing.Point(191, 297);
            this.txtNeto3.Name = "txtNeto3";
            this.txtNeto3.Size = new System.Drawing.Size(149, 20);
            this.txtNeto3.TabIndex = 31;
            this.txtNeto3.Visible = false;
            // 
            // txtNeto2
            // 
            this.txtNeto2.Location = new System.Drawing.Point(191, 252);
            this.txtNeto2.Name = "txtNeto2";
            this.txtNeto2.Size = new System.Drawing.Size(149, 20);
            this.txtNeto2.TabIndex = 30;
            this.txtNeto2.Visible = false;
            // 
            // txtNeto1
            // 
            this.txtNeto1.Location = new System.Drawing.Point(191, 210);
            this.txtNeto1.Name = "txtNeto1";
            this.txtNeto1.Size = new System.Drawing.Size(149, 20);
            this.txtNeto1.TabIndex = 29;
            this.txtNeto1.Visible = false;
            // 
            // txtTotal3
            // 
            this.txtTotal3.Location = new System.Drawing.Point(6, 297);
            this.txtTotal3.Name = "txtTotal3";
            this.txtTotal3.Size = new System.Drawing.Size(149, 20);
            this.txtTotal3.TabIndex = 28;
            this.txtTotal3.Visible = false;
            this.txtTotal3.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTotal3_KeyDown);
            // 
            // txtTotal2
            // 
            this.txtTotal2.Location = new System.Drawing.Point(6, 252);
            this.txtTotal2.Name = "txtTotal2";
            this.txtTotal2.Size = new System.Drawing.Size(149, 20);
            this.txtTotal2.TabIndex = 27;
            this.txtTotal2.Visible = false;
            this.txtTotal2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTotal2_KeyDown);
            // 
            // txtTotal1
            // 
            this.txtTotal1.Location = new System.Drawing.Point(6, 210);
            this.txtTotal1.Name = "txtTotal1";
            this.txtTotal1.Size = new System.Drawing.Size(149, 20);
            this.txtTotal1.TabIndex = 26;
            this.txtTotal1.Visible = false;
            this.txtTotal1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTotal1_KeyDown);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(214, 181);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 17);
            this.label9.TabIndex = 25;
            this.label9.Text = "Neto General";
            this.label9.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(520, 181);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(26, 17);
            this.label8.TabIndex = 24;
            this.label8.Text = "Iva";
            this.label8.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(373, 181);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 17);
            this.label7.TabIndex = 23;
            this.label7.Text = "Alicuota";
            this.label7.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(50, 181);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 17);
            this.label6.TabIndex = 22;
            this.label6.Text = "Total";
            this.label6.Visible = false;
            // 
            // txtFactura
            // 
            this.txtFactura.Location = new System.Drawing.Point(490, 56);
            this.txtFactura.Mask = "0000-00000000";
            this.txtFactura.Name = "txtFactura";
            this.txtFactura.Size = new System.Drawing.Size(85, 20);
            this.txtFactura.TabIndex = 21;
            this.txtFactura.Visible = false;
            // 
            // dtFecha
            // 
            this.dtFecha.Enabled = false;
            this.dtFecha.Location = new System.Drawing.Point(110, 149);
            this.dtFecha.Name = "dtFecha";
            this.dtFecha.Size = new System.Drawing.Size(211, 20);
            this.dtFecha.TabIndex = 20;
            this.dtFecha.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Enabled = false;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(43, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 17);
            this.label5.TabIndex = 19;
            this.label5.Text = "Fecha(*):";
            this.label5.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Enabled = false;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(405, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 17);
            this.label4.TabIndex = 17;
            this.label4.Text = "Nro.Boleta:";
            this.label4.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 17);
            this.label2.TabIndex = 16;
            this.label2.Text = "Persona(*):";
            this.label2.Visible = false;
            // 
            // cmbPersonas
            // 
            this.cmbPersonas.FormattingEnabled = true;
            this.cmbPersonas.Location = new System.Drawing.Point(110, 56);
            this.cmbPersonas.Name = "cmbPersonas";
            this.cmbPersonas.Size = new System.Drawing.Size(211, 21);
            this.cmbPersonas.TabIndex = 2;
            this.cmbPersonas.Visible = false;
            this.cmbPersonas.SelectedIndexChanged += new System.EventHandler(this.cmbPersonas_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblCuitEdit);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblNombreEdit);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(12, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(616, 46);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Cliente";
            // 
            // lblCuitEdit
            // 
            this.lblCuitEdit.AutoSize = true;
            this.lblCuitEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCuitEdit.Location = new System.Drawing.Point(501, 16);
            this.lblCuitEdit.Name = "lblCuitEdit";
            this.lblCuitEdit.Size = new System.Drawing.Size(36, 17);
            this.lblCuitEdit.TabIndex = 17;
            this.lblCuitEdit.Text = "Cuit:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(468, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 17);
            this.label1.TabIndex = 16;
            this.label1.Text = "Cuit:";
            // 
            // lblNombreEdit
            // 
            this.lblNombreEdit.AutoSize = true;
            this.lblNombreEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreEdit.Location = new System.Drawing.Point(152, 16);
            this.lblNombreEdit.Name = "lblNombreEdit";
            this.lblNombreEdit.Size = new System.Drawing.Size(149, 17);
            this.lblNombreEdit.TabIndex = 15;
            this.lblNombreEdit.Text = "Nombre/Razón Social:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 17);
            this.label3.TabIndex = 14;
            this.label3.Text = "Nombre/Razón Social:";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Image = global::Sico.Properties.Resources.copia_de_seguridad;
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnGuardar.Location = new System.Drawing.Point(337, 421);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(80, 51);
            this.btnGuardar.TabIndex = 15;
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
            this.btnCancelar.Location = new System.Drawing.Point(239, 421);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(80, 51);
            this.btnCancelar.TabIndex = 14;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // NotaDeCreditoWF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 477);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnCancelar);
            this.Name = "NotaDeCreditoWF";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nota de Credito";
            this.Load += new System.EventHandler(this.CuentaCorrienteWF_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox lblDireccionEdit;
        private System.Windows.Forms.TextBox lblDniEdit;
        private System.Windows.Forms.Label lblObservacionsEdit;
        private System.Windows.Forms.Label lblObservaciones;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label lblTotalEdit;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lbl105;
        private System.Windows.Forms.Label lbl21;
        private System.Windows.Forms.Label lbl27;
        private System.Windows.Forms.TextBox txtIva3;
        private System.Windows.Forms.TextBox txtIva2;
        private System.Windows.Forms.TextBox txtIva1;
        private System.Windows.Forms.TextBox txtNeto3;
        private System.Windows.Forms.TextBox txtNeto2;
        private System.Windows.Forms.TextBox txtNeto1;
        private System.Windows.Forms.TextBox txtTotal3;
        private System.Windows.Forms.TextBox txtTotal2;
        private System.Windows.Forms.TextBox txtTotal1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox txtFactura;
        private System.Windows.Forms.DateTimePicker dtFecha;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbPersonas;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblCuitEdit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNombreEdit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbTipoFactura;
    }
}