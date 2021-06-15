namespace Sico
{
    partial class VistaConsultaFacturacionMensualWF
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VistaConsultaFacturacionMensualWF));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnVolver2 = new System.Windows.Forms.Button();
            this.cmbPeriodo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnCitiVentas = new System.Windows.Forms.Button();
            this.btnExcel = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.aaa = new System.Windows.Forms.Button();
            this.btnClientesFacturados = new System.Windows.Forms.Button();
            this.btnCajaFacturarEmitidas = new System.Windows.Forms.Button();
            this.btnTotalFacturas = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lblCajaVentas = new System.Windows.Forms.Label();
            this.lblTotalFacturasEmitidas = new System.Windows.Forms.Label();
            this.lblClientesFacturados = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnVolver2);
            this.groupBox2.Controls.Add(this.cmbPeriodo);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.progressBar1);
            this.groupBox2.Controls.Add(this.btnBuscar);
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(12, 21);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(589, 404);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            // 
            // btnVolver2
            // 
            this.btnVolver2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver2.Image = global::Sico.Properties.Resources.flecha_curva_hacia_atras_a_la_izquierda;
            this.btnVolver2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnVolver2.Location = new System.Drawing.Point(530, 11);
            this.btnVolver2.Name = "btnVolver2";
            this.btnVolver2.Size = new System.Drawing.Size(49, 39);
            this.btnVolver2.TabIndex = 49;
            this.btnVolver2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnVolver2.UseVisualStyleBackColor = true;
            this.btnVolver2.Visible = false;
            this.btnVolver2.Click += new System.EventHandler(this.btnVolver2_Click);
            // 
            // cmbPeriodo
            // 
            this.cmbPeriodo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPeriodo.FormattingEnabled = true;
            this.cmbPeriodo.Location = new System.Drawing.Point(203, 20);
            this.cmbPeriodo.Name = "cmbPeriodo";
            this.cmbPeriodo.Size = new System.Drawing.Size(214, 21);
            this.cmbPeriodo.TabIndex = 47;
            this.cmbPeriodo.SelectedIndexChanged += new System.EventHandler(this.btnBuscar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(136, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 17);
            this.label2.TabIndex = 46;
            this.label2.Text = "Período:";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(142, 249);
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
            this.btnBuscar.Location = new System.Drawing.Point(471, 11);
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
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(9, 54);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(570, 344);
            this.dataGridView1.TabIndex = 42;
            this.dataGridView1.Visible = false;
            // 
            // toolTip1
            // 
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // btnCitiVentas
            // 
            this.btnCitiVentas.BackColor = System.Drawing.Color.SteelBlue;
            this.btnCitiVentas.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen;
            this.btnCitiVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCitiVentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCitiVentas.ForeColor = System.Drawing.Color.White;
            this.btnCitiVentas.Image = global::Sico.Properties.Resources.simbolo_de_archivo_txt;
            this.btnCitiVentas.Location = new System.Drawing.Point(555, 431);
            this.btnCitiVentas.Name = "btnCitiVentas";
            this.btnCitiVentas.Size = new System.Drawing.Size(36, 28);
            this.btnCitiVentas.TabIndex = 161;
            this.btnCitiVentas.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.toolTip1.SetToolTip(this.btnCitiVentas, "Generar txt");
            this.btnCitiVentas.UseVisualStyleBackColor = false;
            this.btnCitiVentas.Click += new System.EventHandler(this.btnCitiVentas_Click);
            // 
            // btnExcel
            // 
            this.btnExcel.BackColor = System.Drawing.Color.SteelBlue;
            this.btnExcel.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen;
            this.btnExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcel.ForeColor = System.Drawing.Color.White;
            this.btnExcel.Image = global::Sico.Properties.Resources.sobresalir;
            this.btnExcel.Location = new System.Drawing.Point(497, 431);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(36, 28);
            this.btnExcel.TabIndex = 160;
            this.btnExcel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.toolTip1.SetToolTip(this.btnExcel, "Exportar a Excel");
            this.btnExcel.UseVisualStyleBackColor = false;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.SteelBlue;
            this.label3.Location = new System.Drawing.Point(718, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(290, 20);
            this.label3.TabIndex = 76;
            this.label3.Text = "Estadisticas generales del año en curso";
            // 
            // aaa
            // 
            this.aaa.BackColor = System.Drawing.Color.SteelBlue;
            this.aaa.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen;
            this.aaa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aaa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aaa.ForeColor = System.Drawing.Color.White;
            this.aaa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.aaa.Location = new System.Drawing.Point(877, 182);
            this.aaa.Name = "aaa";
            this.aaa.Size = new System.Drawing.Size(181, 53);
            this.aaa.TabIndex = 75;
            this.aaa.Text = "Planes Cerrados";
            this.aaa.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.aaa.UseVisualStyleBackColor = false;
            // 
            // btnClientesFacturados
            // 
            this.btnClientesFacturados.BackColor = System.Drawing.Color.SteelBlue;
            this.btnClientesFacturados.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen;
            this.btnClientesFacturados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClientesFacturados.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientesFacturados.ForeColor = System.Drawing.Color.White;
            this.btnClientesFacturados.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClientesFacturados.Location = new System.Drawing.Point(660, 182);
            this.btnClientesFacturados.Name = "btnClientesFacturados";
            this.btnClientesFacturados.Size = new System.Drawing.Size(181, 53);
            this.btnClientesFacturados.TabIndex = 74;
            this.btnClientesFacturados.Text = "Total Clientes Facturados";
            this.btnClientesFacturados.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnClientesFacturados.UseVisualStyleBackColor = false;
            // 
            // btnCajaFacturarEmitidas
            // 
            this.btnCajaFacturarEmitidas.BackColor = System.Drawing.Color.SteelBlue;
            this.btnCajaFacturarEmitidas.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen;
            this.btnCajaFacturarEmitidas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCajaFacturarEmitidas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCajaFacturarEmitidas.ForeColor = System.Drawing.Color.White;
            this.btnCajaFacturarEmitidas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCajaFacturarEmitidas.Location = new System.Drawing.Point(877, 75);
            this.btnCajaFacturarEmitidas.Name = "btnCajaFacturarEmitidas";
            this.btnCajaFacturarEmitidas.Size = new System.Drawing.Size(181, 53);
            this.btnCajaFacturarEmitidas.TabIndex = 73;
            this.btnCajaFacturarEmitidas.Text = "Caja de Facturacion";
            this.btnCajaFacturarEmitidas.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnCajaFacturarEmitidas.UseVisualStyleBackColor = false;
            // 
            // btnTotalFacturas
            // 
            this.btnTotalFacturas.BackColor = System.Drawing.Color.SteelBlue;
            this.btnTotalFacturas.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen;
            this.btnTotalFacturas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTotalFacturas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTotalFacturas.ForeColor = System.Drawing.Color.White;
            this.btnTotalFacturas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTotalFacturas.Location = new System.Drawing.Point(660, 75);
            this.btnTotalFacturas.Name = "btnTotalFacturas";
            this.btnTotalFacturas.Size = new System.Drawing.Size(181, 53);
            this.btnTotalFacturas.TabIndex = 72;
            this.btnTotalFacturas.Text = "Facturas Emitidas";
            this.btnTotalFacturas.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnTotalFacturas.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.SteelBlue;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(953, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 17);
            this.label4.TabIndex = 164;
            this.label4.Text = "$";
            // 
            // lblCajaVentas
            // 
            this.lblCajaVentas.AutoSize = true;
            this.lblCajaVentas.BackColor = System.Drawing.Color.SteelBlue;
            this.lblCajaVentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCajaVentas.ForeColor = System.Drawing.Color.White;
            this.lblCajaVentas.Location = new System.Drawing.Point(975, 102);
            this.lblCajaVentas.Name = "lblCajaVentas";
            this.lblCajaVentas.Size = new System.Drawing.Size(22, 17);
            this.lblCajaVentas.TabIndex = 163;
            this.lblCajaVentas.Text = "@";
            // 
            // lblTotalFacturasEmitidas
            // 
            this.lblTotalFacturasEmitidas.AutoSize = true;
            this.lblTotalFacturasEmitidas.BackColor = System.Drawing.Color.SteelBlue;
            this.lblTotalFacturasEmitidas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalFacturasEmitidas.ForeColor = System.Drawing.Color.White;
            this.lblTotalFacturasEmitidas.Location = new System.Drawing.Point(740, 102);
            this.lblTotalFacturasEmitidas.Name = "lblTotalFacturasEmitidas";
            this.lblTotalFacturasEmitidas.Size = new System.Drawing.Size(22, 17);
            this.lblTotalFacturasEmitidas.TabIndex = 162;
            this.lblTotalFacturasEmitidas.Text = "@";
            // 
            // lblClientesFacturados
            // 
            this.lblClientesFacturados.AutoSize = true;
            this.lblClientesFacturados.BackColor = System.Drawing.Color.SteelBlue;
            this.lblClientesFacturados.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientesFacturados.ForeColor = System.Drawing.Color.White;
            this.lblClientesFacturados.Location = new System.Drawing.Point(740, 208);
            this.lblClientesFacturados.Name = "lblClientesFacturados";
            this.lblClientesFacturados.Size = new System.Drawing.Size(22, 17);
            this.lblClientesFacturados.TabIndex = 165;
            this.lblClientesFacturados.Text = "@";
            // 
            // VistaConsultaFacturacionMensualWF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1099, 482);
            this.Controls.Add(this.lblClientesFacturados);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblCajaVentas);
            this.Controls.Add(this.lblTotalFacturasEmitidas);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.aaa);
            this.Controls.Add(this.btnCitiVentas);
            this.Controls.Add(this.btnClientesFacturados);
            this.Controls.Add(this.btnExcel);
            this.Controls.Add(this.btnCajaFacturarEmitidas);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnTotalFacturas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "VistaConsultaFacturacionMensualWF";
            this.Text = "Consulta Facturación Ventas Mensual";
            this.Load += new System.EventHandler(this.VistaConsultaFacturacionMensualWF_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ComboBox cmbPeriodo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnVolver2;
        private System.Windows.Forms.Button btnExcel;
        private System.Windows.Forms.Button btnCitiVentas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button aaa;
        private System.Windows.Forms.Button btnClientesFacturados;
        private System.Windows.Forms.Button btnCajaFacturarEmitidas;
        private System.Windows.Forms.Button btnTotalFacturas;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblCajaVentas;
        private System.Windows.Forms.Label lblTotalFacturasEmitidas;
        private System.Windows.Forms.Label lblClientesFacturados;
    }
}