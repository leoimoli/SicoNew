﻿namespace Sico
{
    partial class VistaFacturacionSubClienteWF
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VistaFacturacionSubClienteWF));
            this.button1 = new System.Windows.Forms.Button();
            this.btnPdf = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label26 = new System.Windows.Forms.Label();
            this.lblCuitEdit = new System.Windows.Forms.Label();
            this.lblNombreEdit = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbPeriodo = new System.Windows.Forms.TextBox();
            this.cmbPersonas = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.cmbCodigoOperacion = new System.Windows.Forms.ComboBox();
            this.cmbCodigoMoneda = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtTipoCambio = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbTipoComprobante = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAdjuntarFacturaElectronica = new System.Windows.Forms.Button();
            this.lblArchivo1 = new System.Windows.Forms.Label();
            this.txtAdjunto = new System.Windows.Forms.TextBox();
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
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::Sico.Properties.Resources.flecha_curva_hacia_atras_a_la_izquierda;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(584, 417);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 51);
            this.button1.TabIndex = 45;
            this.button1.Text = "Volver";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnPdf
            // 
            this.btnPdf.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPdf.Image = global::Sico.Properties.Resources.pdf;
            this.btnPdf.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPdf.Location = new System.Drawing.Point(698, 417);
            this.btnPdf.Name = "btnPdf";
            this.btnPdf.Size = new System.Drawing.Size(80, 51);
            this.btnPdf.TabIndex = 46;
            this.btnPdf.Text = "Exportar PDF";
            this.btnPdf.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPdf.UseVisualStyleBackColor = true;
            this.btnPdf.Click += new System.EventHandler(this.btnPdf_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Image = global::Sico.Properties.Resources.copia_de_seguridad;
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnGuardar.Location = new System.Drawing.Point(707, 417);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(80, 51);
            this.btnGuardar.TabIndex = 47;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Visible = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label26);
            this.groupBox3.Controls.Add(this.lblCuitEdit);
            this.groupBox3.Controls.Add(this.lblNombreEdit);
            this.groupBox3.Controls.Add(this.label27);
            this.groupBox3.Location = new System.Drawing.Point(299, 100);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(878, 50);
            this.groupBox3.TabIndex = 50;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tareas";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(20, 16);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(167, 20);
            this.label26.TabIndex = 17;
            this.label26.Text = "Nombre/Razón Social:";
            // 
            // lblCuitEdit
            // 
            this.lblCuitEdit.AutoSize = true;
            this.lblCuitEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCuitEdit.Location = new System.Drawing.Point(673, 16);
            this.lblCuitEdit.Name = "lblCuitEdit";
            this.lblCuitEdit.Size = new System.Drawing.Size(41, 20);
            this.lblCuitEdit.TabIndex = 14;
            this.lblCuitEdit.Text = "Cuit:";
            // 
            // lblNombreEdit
            // 
            this.lblNombreEdit.AutoSize = true;
            this.lblNombreEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreEdit.Location = new System.Drawing.Point(193, 16);
            this.lblNombreEdit.Name = "lblNombreEdit";
            this.lblNombreEdit.Size = new System.Drawing.Size(167, 20);
            this.lblNombreEdit.TabIndex = 13;
            this.lblNombreEdit.Text = "Nombre/Razón Social:";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(626, 16);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(41, 20);
            this.label27.TabIndex = 12;
            this.label27.Text = "Cuit:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.SteelBlue;
            this.label18.Location = new System.Drawing.Point(602, 72);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(181, 25);
            this.label18.TabIndex = 49;
            this.label18.Text = "Facturación Ventas";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmbPeriodo);
            this.groupBox2.Controls.Add(this.cmbPersonas);
            this.groupBox2.Controls.Add(this.btnGuardar);
            this.groupBox2.Controls.Add(this.btnPdf);
            this.groupBox2.Controls.Add(this.label28);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.cmbCodigoOperacion);
            this.groupBox2.Controls.Add(this.cmbCodigoMoneda);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.txtTipoCambio);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.cmbTipoComprobante);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.btnAdjuntarFacturaElectronica);
            this.groupBox2.Controls.Add(this.lblArchivo1);
            this.groupBox2.Controls.Add(this.txtAdjunto);
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
            this.groupBox2.Location = new System.Drawing.Point(40, 156);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1220, 480);
            this.groupBox2.TabIndex = 48;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Factura sub-cliente";
            // 
            // cmbPeriodo
            // 
            this.cmbPeriodo.Location = new System.Drawing.Point(707, 25);
            this.cmbPeriodo.Name = "cmbPeriodo";
            this.cmbPeriodo.Size = new System.Drawing.Size(211, 20);
            this.cmbPeriodo.TabIndex = 96;
            // 
            // cmbPersonas
            // 
            this.cmbPersonas.Location = new System.Drawing.Point(283, 22);
            this.cmbPersonas.Name = "cmbPersonas";
            this.cmbPersonas.Size = new System.Drawing.Size(211, 20);
            this.cmbPersonas.TabIndex = 95;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.Location = new System.Drawing.Point(624, 23);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(83, 20);
            this.label28.TabIndex = 91;
            this.label28.Text = "Período(*):";
            // 
            // cmbCodigoOperacion
            // 
            this.cmbCodigoOperacion.FormattingEnabled = true;
            this.cmbCodigoOperacion.Location = new System.Drawing.Point(1000, 310);
            this.cmbCodigoOperacion.Name = "cmbCodigoOperacion";
            this.cmbCodigoOperacion.Size = new System.Drawing.Size(211, 21);
            this.cmbCodigoOperacion.TabIndex = 73;
            // 
            // cmbCodigoMoneda
            // 
            this.cmbCodigoMoneda.FormattingEnabled = true;
            this.cmbCodigoMoneda.Location = new System.Drawing.Point(174, 310);
            this.cmbCodigoMoneda.Name = "cmbCodigoMoneda";
            this.cmbCodigoMoneda.Size = new System.Drawing.Size(211, 21);
            this.cmbCodigoMoneda.TabIndex = 72;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(827, 308);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(156, 20);
            this.label15.TabIndex = 71;
            this.label15.Text = "Código Operación(*):";
            // 
            // txtTipoCambio
            // 
            this.txtTipoCambio.Location = new System.Drawing.Point(559, 310);
            this.txtTipoCambio.Name = "txtTipoCambio";
            this.txtTipoCambio.Size = new System.Drawing.Size(211, 20);
            this.txtTipoCambio.TabIndex = 70;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(414, 308);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(139, 20);
            this.label16.TabIndex = 69;
            this.label16.Text = "Tipo de Cambio(*):";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(27, 308);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(141, 20);
            this.label17.TabIndex = 68;
            this.label17.Text = "Código Moneda(*):";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(145, 20);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(133, 20);
            this.label10.TabIndex = 55;
            this.label10.Text = "Persona Fisica(*):";
            // 
            // cmbTipoComprobante
            // 
            this.cmbTipoComprobante.FormattingEnabled = true;
            this.cmbTipoComprobante.Location = new System.Drawing.Point(599, 118);
            this.cmbTipoComprobante.Name = "cmbTipoComprobante";
            this.cmbTipoComprobante.Size = new System.Drawing.Size(350, 21);
            this.cmbTipoComprobante.TabIndex = 54;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(414, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 20);
            this.label1.TabIndex = 53;
            this.label1.Text = "Tipo de comprobante(*):";
            // 
            // btnAdjuntarFacturaElectronica
            // 
            this.btnAdjuntarFacturaElectronica.BackColor = System.Drawing.Color.Transparent;
            this.btnAdjuntarFacturaElectronica.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdjuntarFacturaElectronica.Image = ((System.Drawing.Image)(resources.GetObject("btnAdjuntarFacturaElectronica.Image")));
            this.btnAdjuntarFacturaElectronica.Location = new System.Drawing.Point(859, 354);
            this.btnAdjuntarFacturaElectronica.Name = "btnAdjuntarFacturaElectronica";
            this.btnAdjuntarFacturaElectronica.Size = new System.Drawing.Size(45, 35);
            this.btnAdjuntarFacturaElectronica.TabIndex = 52;
            this.btnAdjuntarFacturaElectronica.UseVisualStyleBackColor = false;
            this.btnAdjuntarFacturaElectronica.Click += new System.EventHandler(this.btnAdjuntarFacturaElectronica_Click);
            // 
            // lblArchivo1
            // 
            this.lblArchivo1.AutoSize = true;
            this.lblArchivo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArchivo1.Location = new System.Drawing.Point(375, 360);
            this.lblArchivo1.Name = "lblArchivo1";
            this.lblArchivo1.Size = new System.Drawing.Size(215, 20);
            this.lblArchivo1.TabIndex = 51;
            this.lblArchivo1.Text = "Adjuntar Factura Eléctronica:";
            // 
            // txtAdjunto
            // 
            this.txtAdjunto.Location = new System.Drawing.Point(600, 362);
            this.txtAdjunto.Name = "txtAdjunto";
            this.txtAdjunto.Size = new System.Drawing.Size(250, 20);
            this.txtAdjunto.TabIndex = 50;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(538, 240);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(330, 23);
            this.progressBar1.TabIndex = 40;
            this.progressBar1.Value = 50;
            this.progressBar1.Visible = false;
            // 
            // lblTotalEdit
            // 
            this.lblTotalEdit.AutoSize = true;
            this.lblTotalEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalEdit.Location = new System.Drawing.Point(59, 417);
            this.lblTotalEdit.Name = "lblTotalEdit";
            this.lblTotalEdit.Size = new System.Drawing.Size(14, 20);
            this.lblTotalEdit.TabIndex = 39;
            this.lblTotalEdit.Text = "-";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(13, 417);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(44, 20);
            this.label13.TabIndex = 38;
            this.label13.Text = "Total";
            // 
            // lbl105
            // 
            this.lbl105.AutoSize = true;
            this.lbl105.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl105.Location = new System.Drawing.Point(792, 179);
            this.lbl105.Name = "lbl105";
            this.lbl105.Size = new System.Drawing.Size(54, 20);
            this.lbl105.TabIndex = 37;
            this.lbl105.Text = "10,5%";
            // 
            // lbl21
            // 
            this.lbl21.AutoSize = true;
            this.lbl21.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl21.Location = new System.Drawing.Point(796, 221);
            this.lbl21.Name = "lbl21";
            this.lbl21.Size = new System.Drawing.Size(41, 20);
            this.lbl21.TabIndex = 36;
            this.lbl21.Text = "21%";
            // 
            // lbl27
            // 
            this.lbl27.AutoSize = true;
            this.lbl27.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl27.Location = new System.Drawing.Point(796, 266);
            this.lbl27.Name = "lbl27";
            this.lbl27.Size = new System.Drawing.Size(41, 20);
            this.lbl27.TabIndex = 35;
            this.lbl27.Text = "27%";
            // 
            // txtIva3
            // 
            this.txtIva3.Location = new System.Drawing.Point(981, 265);
            this.txtIva3.Name = "txtIva3";
            this.txtIva3.Size = new System.Drawing.Size(149, 20);
            this.txtIva3.TabIndex = 34;
            // 
            // txtIva2
            // 
            this.txtIva2.Location = new System.Drawing.Point(981, 223);
            this.txtIva2.Name = "txtIva2";
            this.txtIva2.Size = new System.Drawing.Size(149, 20);
            this.txtIva2.TabIndex = 33;
            // 
            // txtIva1
            // 
            this.txtIva1.Location = new System.Drawing.Point(981, 181);
            this.txtIva1.Name = "txtIva1";
            this.txtIva1.Size = new System.Drawing.Size(149, 20);
            this.txtIva1.TabIndex = 32;
            // 
            // txtNeto3
            // 
            this.txtNeto3.Location = new System.Drawing.Point(486, 265);
            this.txtNeto3.Name = "txtNeto3";
            this.txtNeto3.Size = new System.Drawing.Size(149, 20);
            this.txtNeto3.TabIndex = 31;
            // 
            // txtNeto2
            // 
            this.txtNeto2.Location = new System.Drawing.Point(486, 220);
            this.txtNeto2.Name = "txtNeto2";
            this.txtNeto2.Size = new System.Drawing.Size(149, 20);
            this.txtNeto2.TabIndex = 30;
            // 
            // txtNeto1
            // 
            this.txtNeto1.Location = new System.Drawing.Point(486, 181);
            this.txtNeto1.Name = "txtNeto1";
            this.txtNeto1.Size = new System.Drawing.Size(149, 20);
            this.txtNeto1.TabIndex = 29;
            // 
            // txtTotal3
            // 
            this.txtTotal3.Location = new System.Drawing.Point(174, 265);
            this.txtTotal3.Name = "txtTotal3";
            this.txtTotal3.Size = new System.Drawing.Size(149, 20);
            this.txtTotal3.TabIndex = 28;
            this.txtTotal3.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTotal3_KeyDown);
            // 
            // txtTotal2
            // 
            this.txtTotal2.Location = new System.Drawing.Point(174, 220);
            this.txtTotal2.Name = "txtTotal2";
            this.txtTotal2.Size = new System.Drawing.Size(149, 20);
            this.txtTotal2.TabIndex = 27;
            this.txtTotal2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTotal2_KeyDown);
            // 
            // txtTotal1
            // 
            this.txtTotal1.Location = new System.Drawing.Point(174, 178);
            this.txtTotal1.Name = "txtTotal1";
            this.txtTotal1.Size = new System.Drawing.Size(149, 20);
            this.txtTotal1.TabIndex = 26;
            this.txtTotal1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTotal1_KeyDown);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(511, 149);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(104, 20);
            this.label9.TabIndex = 25;
            this.label9.Text = "Neto General";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(1038, 149);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 20);
            this.label8.TabIndex = 24;
            this.label8.Text = "Iva";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(784, 149);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 20);
            this.label7.TabIndex = 23;
            this.label7.Text = "Alicuota";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(197, 149);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 20);
            this.label6.TabIndex = 22;
            this.label6.Text = "Total";
            // 
            // txtFactura
            // 
            this.txtFactura.Location = new System.Drawing.Point(1093, 118);
            this.txtFactura.Mask = "00000-00000000";
            this.txtFactura.Name = "txtFactura";
            this.txtFactura.Size = new System.Drawing.Size(90, 20);
            this.txtFactura.TabIndex = 21;
            // 
            // dtFecha
            // 
            this.dtFecha.Enabled = false;
            this.dtFecha.Location = new System.Drawing.Point(177, 115);
            this.dtFecha.Name = "dtFecha";
            this.dtFecha.Size = new System.Drawing.Size(211, 20);
            this.dtFecha.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(175, 20);
            this.label5.TabIndex = 19;
            this.label5.Text = "Fecha Comprobante(*):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(985, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 17);
            this.label4.TabIndex = 17;
            this.label4.Text = "Nro.Factura(*):";
            // 
            // VistaFacturacionSubClienteWF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 731);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.groupBox2);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "VistaFacturacionSubClienteWF";
            this.Text = "Vista Facturación Sub-Cliente";
            this.Load += new System.EventHandler(this.VistaFacturacionSubClienteWF_Load);
            this.Controls.SetChildIndex(this.groupBox2, 0);
            this.Controls.SetChildIndex(this.label18, 0);
            this.Controls.SetChildIndex(this.groupBox3, 0);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnPdf;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label lblCuitEdit;
        private System.Windows.Forms.Label lblNombreEdit;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.ComboBox cmbCodigoOperacion;
        private System.Windows.Forms.ComboBox cmbCodigoMoneda;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtTipoCambio;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbTipoComprobante;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAdjuntarFacturaElectronica;
        private System.Windows.Forms.Label lblArchivo1;
        private System.Windows.Forms.TextBox txtAdjunto;
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
        private System.Windows.Forms.TextBox cmbPersonas;
        private System.Windows.Forms.TextBox cmbPeriodo;
    }
}