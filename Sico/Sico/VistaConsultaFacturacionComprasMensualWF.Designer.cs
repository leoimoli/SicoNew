namespace Sico
{
    partial class VistaConsultaFacturacionComprasMensualWF
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VistaConsultaFacturacionComprasMensualWF));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnVolver2 = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.NroFactura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CuitProveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RazonSocialProveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Monto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Neto1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Neto2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Neto3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Iva1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Iva2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Iva3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PercepIngBru = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NoGravado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PercepIva = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbPeriodo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCantidadEdit = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnPdf = new System.Windows.Forms.Button();
            this.btnCitiVentas = new System.Windows.Forms.Button();
            this.btnExcel = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.PanelBotones = new System.Windows.Forms.Panel();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.PanelBotones.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnVolver2);
            this.groupBox2.Controls.Add(this.progressBar1);
            this.groupBox2.Controls.Add(this.btnBuscar);
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Controls.Add(this.cmbPeriodo);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(12, 40);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1075, 391);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            // 
            // btnVolver2
            // 
            this.btnVolver2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver2.Image = global::Sico.Properties.Resources.flecha_curva_hacia_atras_a_la_izquierda;
            this.btnVolver2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnVolver2.Location = new System.Drawing.Point(755, 19);
            this.btnVolver2.Name = "btnVolver2";
            this.btnVolver2.Size = new System.Drawing.Size(49, 39);
            this.btnVolver2.TabIndex = 50;
            this.btnVolver2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnVolver2.UseVisualStyleBackColor = true;
            this.btnVolver2.Visible = false;
            this.btnVolver2.Click += new System.EventHandler(this.btnVolver2_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(410, 204);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(330, 23);
            this.progressBar1.TabIndex = 42;
            this.progressBar1.Value = 50;
            this.progressBar1.Visible = false;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Image = global::Sico.Properties.Resources.buscar_con_herramienta_en_esquema;
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnBuscar.Location = new System.Drawing.Point(691, 19);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(49, 39);
            this.btnBuscar.TabIndex = 45;
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Visible = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NroFactura,
            this.CuitProveedor,
            this.RazonSocialProveedor,
            this.Fecha,
            this.Monto,
            this.Neto1,
            this.Neto2,
            this.Neto3,
            this.Iva1,
            this.Iva2,
            this.Iva3,
            this.PercepIngBru,
            this.NoGravado,
            this.PercepIva});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(9, 64);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(1066, 321);
            this.dataGridView1.TabIndex = 42;
            this.dataGridView1.Visible = false;
            // 
            // NroFactura
            // 
            this.NroFactura.HeaderText = "Nro.Factura";
            this.NroFactura.Name = "NroFactura";
            // 
            // CuitProveedor
            // 
            this.CuitProveedor.HeaderText = "Cuit";
            this.CuitProveedor.Name = "CuitProveedor";
            // 
            // RazonSocialProveedor
            // 
            this.RazonSocialProveedor.HeaderText = "Razón Social";
            this.RazonSocialProveedor.Name = "RazonSocialProveedor";
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            this.Fecha.Width = 80;
            // 
            // Monto
            // 
            this.Monto.HeaderText = "Monto";
            this.Monto.Name = "Monto";
            this.Monto.Width = 90;
            // 
            // Neto1
            // 
            this.Neto1.HeaderText = "Neto 10,5";
            this.Neto1.Name = "Neto1";
            this.Neto1.Width = 90;
            // 
            // Neto2
            // 
            this.Neto2.HeaderText = "Neto 21";
            this.Neto2.Name = "Neto2";
            this.Neto2.Width = 90;
            // 
            // Neto3
            // 
            this.Neto3.HeaderText = "Neto 27";
            this.Neto3.Name = "Neto3";
            this.Neto3.Width = 90;
            // 
            // Iva1
            // 
            this.Iva1.HeaderText = "Iva 10,5";
            this.Iva1.Name = "Iva1";
            this.Iva1.Width = 90;
            // 
            // Iva2
            // 
            this.Iva2.HeaderText = "Iva 21";
            this.Iva2.Name = "Iva2";
            this.Iva2.Width = 90;
            // 
            // Iva3
            // 
            this.Iva3.HeaderText = "Iva 27";
            this.Iva3.Name = "Iva3";
            this.Iva3.Width = 90;
            // 
            // PercepIngBru
            // 
            this.PercepIngBru.HeaderText = "Percepción Ing.Brutos";
            this.PercepIngBru.Name = "PercepIngBru";
            this.PercepIngBru.Width = 95;
            // 
            // NoGravado
            // 
            this.NoGravado.HeaderText = "No Gravado";
            this.NoGravado.Name = "NoGravado";
            this.NoGravado.Width = 90;
            // 
            // PercepIva
            // 
            this.PercepIva.HeaderText = "Percepción Iva";
            this.PercepIva.Name = "PercepIva";
            this.PercepIva.Width = 90;
            // 
            // cmbPeriodo
            // 
            this.cmbPeriodo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPeriodo.FormattingEnabled = true;
            this.cmbPeriodo.Location = new System.Drawing.Point(455, 30);
            this.cmbPeriodo.Name = "cmbPeriodo";
            this.cmbPeriodo.Size = new System.Drawing.Size(214, 21);
            this.cmbPeriodo.TabIndex = 41;
            this.cmbPeriodo.SelectedIndexChanged += new System.EventHandler(this.btnBuscar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(388, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 17);
            this.label2.TabIndex = 40;
            this.label2.Text = "Período:";
            // 
            // lblCantidadEdit
            // 
            this.lblCantidadEdit.AutoSize = true;
            this.lblCantidadEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidadEdit.Location = new System.Drawing.Point(1054, 443);
            this.lblCantidadEdit.Name = "lblCantidadEdit";
            this.lblCantidadEdit.Size = new System.Drawing.Size(33, 20);
            this.lblCantidadEdit.TabIndex = 54;
            this.lblCantidadEdit.Text = "****";
            this.lblCantidadEdit.Visible = false;
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.Location = new System.Drawing.Point(1000, 443);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(48, 20);
            this.lblCantidad.TabIndex = 53;
            this.lblCantidad.Text = "Total:";
            this.lblCantidad.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.SteelBlue;
            this.label3.Location = new System.Drawing.Point(420, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(268, 20);
            this.label3.TabIndex = 77;
            this.label3.Text = "I.V.A. Compras Facturación Mensual";
            // 
            // btnPdf
            // 
            this.btnPdf.BackColor = System.Drawing.SystemColors.Control;
            this.btnPdf.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen;
            this.btnPdf.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPdf.ForeColor = System.Drawing.Color.White;
            this.btnPdf.Image = global::Sico.Properties.Resources.pdf1;
            this.btnPdf.Location = new System.Drawing.Point(2, 7);
            this.btnPdf.Name = "btnPdf";
            this.btnPdf.Size = new System.Drawing.Size(36, 28);
            this.btnPdf.TabIndex = 165;
            this.btnPdf.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnPdf.UseVisualStyleBackColor = false;
            this.btnPdf.Click += new System.EventHandler(this.btnPdf_Click);
            // 
            // btnCitiVentas
            // 
            this.btnCitiVentas.BackColor = System.Drawing.SystemColors.Control;
            this.btnCitiVentas.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen;
            this.btnCitiVentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCitiVentas.ForeColor = System.Drawing.Color.White;
            this.btnCitiVentas.Image = global::Sico.Properties.Resources.txt1;
            this.btnCitiVentas.Location = new System.Drawing.Point(118, 7);
            this.btnCitiVentas.Name = "btnCitiVentas";
            this.btnCitiVentas.Size = new System.Drawing.Size(36, 28);
            this.btnCitiVentas.TabIndex = 164;
            this.btnCitiVentas.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnCitiVentas.UseVisualStyleBackColor = false;
            this.btnCitiVentas.Click += new System.EventHandler(this.btnCitiVentas_Click);
            // 
            // btnExcel
            // 
            this.btnExcel.BackColor = System.Drawing.SystemColors.Control;
            this.btnExcel.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen;
            this.btnExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcel.ForeColor = System.Drawing.Color.White;
            this.btnExcel.Image = global::Sico.Properties.Resources.excel;
            this.btnExcel.Location = new System.Drawing.Point(63, 7);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(36, 28);
            this.btnExcel.TabIndex = 163;
            this.btnExcel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnExcel.UseVisualStyleBackColor = false;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // PanelBotones
            // 
            this.PanelBotones.Controls.Add(this.btnPdf);
            this.PanelBotones.Controls.Add(this.btnCitiVentas);
            this.PanelBotones.Controls.Add(this.btnExcel);
            this.PanelBotones.Location = new System.Drawing.Point(484, 437);
            this.PanelBotones.Name = "PanelBotones";
            this.PanelBotones.Size = new System.Drawing.Size(157, 42);
            this.PanelBotones.TabIndex = 166;
            this.PanelBotones.Visible = false;
            // 
            // VistaConsultaFacturacionComprasMensualWF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1099, 482);
            this.Controls.Add(this.PanelBotones);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblCantidadEdit);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "VistaConsultaFacturacionComprasMensualWF";
            this.Text = "Vista Consulta Facturación Compras Mensual";
            this.Load += new System.EventHandler(this.VistaConsultaFacturacionComprasMensualWF_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.PanelBotones.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cmbPeriodo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCantidadEdit;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Button btnVolver2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnPdf;
        private System.Windows.Forms.Button btnCitiVentas;
        private System.Windows.Forms.Button btnExcel;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.DataGridViewTextBoxColumn NroFactura;
        private System.Windows.Forms.DataGridViewTextBoxColumn CuitProveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn RazonSocialProveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Monto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Neto1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Neto2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Neto3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Iva1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Iva2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Iva3;
        private System.Windows.Forms.DataGridViewTextBoxColumn PercepIngBru;
        private System.Windows.Forms.DataGridViewTextBoxColumn NoGravado;
        private System.Windows.Forms.DataGridViewTextBoxColumn PercepIva;
        private System.Windows.Forms.Panel PanelBotones;
    }
}