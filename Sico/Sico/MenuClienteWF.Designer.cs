namespace Sico
{
    partial class MenuClienteWF
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea11 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend11 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea12 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend12 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnConsultarVencimientos = new System.Windows.Forms.Button();
            this.btnVencimientos = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCompras = new System.Windows.Forms.Button();
            this.btnVentas = new System.Windows.Forms.Button();
            this.lblCuitEdit = new System.Windows.Forms.Label();
            this.lblNombreEdit = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblComprasGraficar = new System.Windows.Forms.LinkLabel();
            this.lblComprasLinea = new System.Windows.Forms.LinkLabel();
            this.lblComprasBarra = new System.Windows.Forms.LinkLabel();
            this.lblComprasIva = new System.Windows.Forms.LinkLabel();
            this.lblComprasNeto = new System.Windows.Forms.LinkLabel();
            this.lblComprasMonto = new System.Windows.Forms.LinkLabel();
            this.btnBuscarCompras = new System.Windows.Forms.Button();
            this.cmbPeriodoCompras = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbAño = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.dgvComprasAnuales = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblLineas = new System.Windows.Forms.LinkLabel();
            this.lblBarras = new System.Windows.Forms.LinkLabel();
            this.lblVentasIva = new System.Windows.Forms.LinkLabel();
            this.lblVentasNeto = new System.Windows.Forms.LinkLabel();
            this.lblVentasPorMonto = new System.Windows.Forms.LinkLabel();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblGraficarVentas = new System.Windows.Forms.LinkLabel();
            this.btnBuscarVentas = new System.Windows.Forms.Button();
            this.cmbPeriodosVentas = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbAñoVentas = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvVentasAnuales = new System.Windows.Forms.DataGridView();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComprasAnuales)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentasAnuales)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnConsultarVencimientos);
            this.groupBox3.Controls.Add(this.btnVencimientos);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.btnCompras);
            this.groupBox3.Controls.Add(this.btnVentas);
            this.groupBox3.Controls.Add(this.lblCuitEdit);
            this.groupBox3.Controls.Add(this.lblNombreEdit);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(270, 94);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(878, 121);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tareas";
            // 
            // btnConsultarVencimientos
            // 
            this.btnConsultarVencimientos.Image = global::Sico.Properties.Resources.buscar__1_;
            this.btnConsultarVencimientos.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnConsultarVencimientos.Location = new System.Drawing.Point(404, 54);
            this.btnConsultarVencimientos.Name = "btnConsultarVencimientos";
            this.btnConsultarVencimientos.Size = new System.Drawing.Size(90, 61);
            this.btnConsultarVencimientos.TabIndex = 19;
            this.btnConsultarVencimientos.Text = "Consultar Vencimientos";
            this.btnConsultarVencimientos.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnConsultarVencimientos.UseVisualStyleBackColor = true;
            this.btnConsultarVencimientos.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnVencimientos
            // 
            this.btnVencimientos.Image = global::Sico.Properties.Resources.calendario1;
            this.btnVencimientos.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnVencimientos.Location = new System.Drawing.Point(282, 54);
            this.btnVencimientos.Name = "btnVencimientos";
            this.btnVencimientos.Size = new System.Drawing.Size(90, 61);
            this.btnVencimientos.TabIndex = 18;
            this.btnVencimientos.Text = "Cargar Vencimientos";
            this.btnVencimientos.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnVencimientos.UseVisualStyleBackColor = true;
            this.btnVencimientos.Click += new System.EventHandler(this.btnVencimientos_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(167, 20);
            this.label4.TabIndex = 17;
            this.label4.Text = "Nombre/Razón Social:";
            // 
            // btnCompras
            // 
            this.btnCompras.Image = global::Sico.Properties.Resources.tarjeta;
            this.btnCompras.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCompras.Location = new System.Drawing.Point(25, 54);
            this.btnCompras.Name = "btnCompras";
            this.btnCompras.Size = new System.Drawing.Size(90, 61);
            this.btnCompras.TabIndex = 15;
            this.btnCompras.Text = "Compras";
            this.btnCompras.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCompras.UseVisualStyleBackColor = true;
            this.btnCompras.Click += new System.EventHandler(this.btnCompras_Click);
            // 
            // btnVentas
            // 
            this.btnVentas.Image = global::Sico.Properties.Resources.estadisticas_de_ventas;
            this.btnVentas.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnVentas.Location = new System.Drawing.Point(154, 54);
            this.btnVentas.Name = "btnVentas";
            this.btnVentas.Size = new System.Drawing.Size(90, 61);
            this.btnVentas.TabIndex = 16;
            this.btnVentas.Text = "Ventas";
            this.btnVentas.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnVentas.UseVisualStyleBackColor = true;
            this.btnVentas.Click += new System.EventHandler(this.btnVentas_Click);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(626, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Cuit:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chart2);
            this.groupBox1.Controls.Add(this.lblComprasGraficar);
            this.groupBox1.Controls.Add(this.lblComprasLinea);
            this.groupBox1.Controls.Add(this.lblComprasBarra);
            this.groupBox1.Controls.Add(this.lblComprasIva);
            this.groupBox1.Controls.Add(this.lblComprasNeto);
            this.groupBox1.Controls.Add(this.lblComprasMonto);
            this.groupBox1.Controls.Add(this.btnBuscarCompras);
            this.groupBox1.Controls.Add(this.cmbPeriodoCompras);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.cmbAño);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.dgvComprasAnuales);
            this.groupBox1.Location = new System.Drawing.Point(30, 221);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(600, 420);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            // 
            // chart2
            // 
            chartArea11.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea11);
            legend11.Name = "Legend1";
            this.chart2.Legends.Add(legend11);
            this.chart2.Location = new System.Drawing.Point(4, 92);
            this.chart2.Name = "chart2";
            this.chart2.Size = new System.Drawing.Size(590, 280);
            this.chart2.TabIndex = 140;
            this.chart2.Text = "chart2";
            this.chart2.Visible = false;
            // 
            // lblComprasGraficar
            // 
            this.lblComprasGraficar.AutoSize = true;
            this.lblComprasGraficar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComprasGraficar.LinkColor = System.Drawing.Color.DodgerBlue;
            this.lblComprasGraficar.Location = new System.Drawing.Point(246, 67);
            this.lblComprasGraficar.Name = "lblComprasGraficar";
            this.lblComprasGraficar.Size = new System.Drawing.Size(74, 22);
            this.lblComprasGraficar.TabIndex = 139;
            this.lblComprasGraficar.TabStop = true;
            this.lblComprasGraficar.Text = "Graficar";
            this.toolTip1.SetToolTip(this.lblComprasGraficar, " Graficar Reportes");
            this.lblComprasGraficar.Visible = false;
            this.lblComprasGraficar.VisitedLinkColor = System.Drawing.Color.Blue;
            this.lblComprasGraficar.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblComprasGraficar_LinkClicked);
            // 
            // lblComprasLinea
            // 
            this.lblComprasLinea.AutoSize = true;
            this.lblComprasLinea.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComprasLinea.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblComprasLinea.Location = new System.Drawing.Point(324, 402);
            this.lblComprasLinea.Name = "lblComprasLinea";
            this.lblComprasLinea.Size = new System.Drawing.Size(99, 15);
            this.lblComprasLinea.TabIndex = 138;
            this.lblComprasLinea.TabStop = true;
            this.lblComprasLinea.Text = "Grafico De Línea";
            this.toolTip1.SetToolTip(this.lblComprasLinea, " Graficar Reportes");
            this.lblComprasLinea.Visible = false;
            this.lblComprasLinea.VisitedLinkColor = System.Drawing.Color.Blue;
            this.lblComprasLinea.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblComprasLinea_LinkClicked);
            // 
            // lblComprasBarra
            // 
            this.lblComprasBarra.AutoSize = true;
            this.lblComprasBarra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComprasBarra.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblComprasBarra.Location = new System.Drawing.Point(111, 402);
            this.lblComprasBarra.Name = "lblComprasBarra";
            this.lblComprasBarra.Size = new System.Drawing.Size(98, 15);
            this.lblComprasBarra.TabIndex = 137;
            this.lblComprasBarra.TabStop = true;
            this.lblComprasBarra.Text = "Grafico De Barra";
            this.toolTip1.SetToolTip(this.lblComprasBarra, " Graficar Reportes");
            this.lblComprasBarra.Visible = false;
            this.lblComprasBarra.VisitedLinkColor = System.Drawing.Color.Blue;
            this.lblComprasBarra.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblComprasBarra_LinkClicked);
            // 
            // lblComprasIva
            // 
            this.lblComprasIva.AutoSize = true;
            this.lblComprasIva.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComprasIva.LinkColor = System.Drawing.Color.DodgerBlue;
            this.lblComprasIva.Location = new System.Drawing.Point(416, 375);
            this.lblComprasIva.Name = "lblComprasIva";
            this.lblComprasIva.Size = new System.Drawing.Size(90, 15);
            this.lblComprasIva.TabIndex = 136;
            this.lblComprasIva.TabStop = true;
            this.lblComprasIva.Text = "Graficar Por Iva";
            this.toolTip1.SetToolTip(this.lblComprasIva, " Graficar Reportes");
            this.lblComprasIva.Visible = false;
            this.lblComprasIva.VisitedLinkColor = System.Drawing.Color.Blue;
            this.lblComprasIva.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblComprasIva_LinkClicked);
            // 
            // lblComprasNeto
            // 
            this.lblComprasNeto.AutoSize = true;
            this.lblComprasNeto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComprasNeto.LinkColor = System.Drawing.Color.DodgerBlue;
            this.lblComprasNeto.Location = new System.Drawing.Point(206, 375);
            this.lblComprasNeto.Name = "lblComprasNeto";
            this.lblComprasNeto.Size = new System.Drawing.Size(152, 15);
            this.lblComprasNeto.TabIndex = 135;
            this.lblComprasNeto.TabStop = true;
            this.lblComprasNeto.Text = "Graficar Por Neto Grabado";
            this.toolTip1.SetToolTip(this.lblComprasNeto, " Graficar Reportes");
            this.lblComprasNeto.Visible = false;
            this.lblComprasNeto.VisitedLinkColor = System.Drawing.Color.Blue;
            this.lblComprasNeto.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblComprasNeto_LinkClicked);
            // 
            // lblComprasMonto
            // 
            this.lblComprasMonto.AutoSize = true;
            this.lblComprasMonto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComprasMonto.LinkColor = System.Drawing.Color.DodgerBlue;
            this.lblComprasMonto.Location = new System.Drawing.Point(48, 375);
            this.lblComprasMonto.Name = "lblComprasMonto";
            this.lblComprasMonto.Size = new System.Drawing.Size(110, 15);
            this.lblComprasMonto.TabIndex = 134;
            this.lblComprasMonto.TabStop = true;
            this.lblComprasMonto.Text = "Graficar Por Monto";
            this.toolTip1.SetToolTip(this.lblComprasMonto, " Graficar Reportes");
            this.lblComprasMonto.Visible = false;
            this.lblComprasMonto.VisitedLinkColor = System.Drawing.Color.Blue;
            this.lblComprasMonto.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblComprasMonto_LinkClicked);
            // 
            // btnBuscarCompras
            // 
            this.btnBuscarCompras.Image = global::Sico.Properties.Resources.buscar_con_herramienta_en_esquema;
            this.btnBuscarCompras.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnBuscarCompras.Location = new System.Drawing.Point(522, 32);
            this.btnBuscarCompras.Name = "btnBuscarCompras";
            this.btnBuscarCompras.Size = new System.Drawing.Size(49, 39);
            this.btnBuscarCompras.TabIndex = 123;
            this.btnBuscarCompras.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip1.SetToolTip(this.btnBuscarCompras, "Buscar Compras");
            this.btnBuscarCompras.UseVisualStyleBackColor = true;
            this.btnBuscarCompras.Click += new System.EventHandler(this.btnBuscarCompras_Click);
            // 
            // cmbPeriodoCompras
            // 
            this.cmbPeriodoCompras.Enabled = false;
            this.cmbPeriodoCompras.FormattingEnabled = true;
            this.cmbPeriodoCompras.Location = new System.Drawing.Point(354, 45);
            this.cmbPeriodoCompras.Name = "cmbPeriodoCompras";
            this.cmbPeriodoCompras.Size = new System.Drawing.Size(162, 21);
            this.cmbPeriodoCompras.TabIndex = 53;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(287, 46);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 17);
            this.label9.TabIndex = 52;
            this.label9.Text = "Periodo:";
            // 
            // cmbAño
            // 
            this.cmbAño.FormattingEnabled = true;
            this.cmbAño.Location = new System.Drawing.Point(106, 44);
            this.cmbAño.Name = "cmbAño";
            this.cmbAño.Size = new System.Drawing.Size(162, 21);
            this.cmbAño.TabIndex = 47;
            this.cmbAño.SelectedIndexChanged += new System.EventHandler(this.cmbAño_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(63, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 17);
            this.label6.TabIndex = 46;
            this.label6.Text = "Año:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.SteelBlue;
            this.label18.Location = new System.Drawing.Point(188, 13);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(242, 20);
            this.label18.TabIndex = 44;
            this.label18.Text = "Facturación de compras Anuales";
            // 
            // dgvComprasAnuales
            // 
            this.dgvComprasAnuales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvComprasAnuales.Location = new System.Drawing.Point(4, 92);
            this.dgvComprasAnuales.Name = "dgvComprasAnuales";
            this.dgvComprasAnuales.Size = new System.Drawing.Size(590, 280);
            this.dgvComprasAnuales.TabIndex = 43;
            this.dgvComprasAnuales.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblLineas);
            this.groupBox2.Controls.Add(this.lblBarras);
            this.groupBox2.Controls.Add(this.lblVentasIva);
            this.groupBox2.Controls.Add(this.lblVentasNeto);
            this.groupBox2.Controls.Add(this.lblVentasPorMonto);
            this.groupBox2.Controls.Add(this.chart1);
            this.groupBox2.Controls.Add(this.lblGraficarVentas);
            this.groupBox2.Controls.Add(this.btnBuscarVentas);
            this.groupBox2.Controls.Add(this.cmbPeriodosVentas);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.cmbAñoVentas);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.dgvVentasAnuales);
            this.groupBox2.Location = new System.Drawing.Point(657, 221);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(600, 420);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            // 
            // lblLineas
            // 
            this.lblLineas.AutoSize = true;
            this.lblLineas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLineas.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblLineas.Location = new System.Drawing.Point(344, 402);
            this.lblLineas.Name = "lblLineas";
            this.lblLineas.Size = new System.Drawing.Size(99, 15);
            this.lblLineas.TabIndex = 133;
            this.lblLineas.TabStop = true;
            this.lblLineas.Text = "Grafico De Línea";
            this.toolTip1.SetToolTip(this.lblLineas, " Graficar Reportes");
            this.lblLineas.Visible = false;
            this.lblLineas.VisitedLinkColor = System.Drawing.Color.Blue;
            this.lblLineas.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // lblBarras
            // 
            this.lblBarras.AutoSize = true;
            this.lblBarras.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBarras.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblBarras.Location = new System.Drawing.Point(131, 402);
            this.lblBarras.Name = "lblBarras";
            this.lblBarras.Size = new System.Drawing.Size(98, 15);
            this.lblBarras.TabIndex = 132;
            this.lblBarras.TabStop = true;
            this.lblBarras.Text = "Grafico De Barra";
            this.toolTip1.SetToolTip(this.lblBarras, " Graficar Reportes");
            this.lblBarras.Visible = false;
            this.lblBarras.VisitedLinkColor = System.Drawing.Color.Blue;
            this.lblBarras.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked_1);
            // 
            // lblVentasIva
            // 
            this.lblVentasIva.AutoSize = true;
            this.lblVentasIva.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVentasIva.LinkColor = System.Drawing.Color.DodgerBlue;
            this.lblVentasIva.Location = new System.Drawing.Point(436, 375);
            this.lblVentasIva.Name = "lblVentasIva";
            this.lblVentasIva.Size = new System.Drawing.Size(90, 15);
            this.lblVentasIva.TabIndex = 131;
            this.lblVentasIva.TabStop = true;
            this.lblVentasIva.Text = "Graficar Por Iva";
            this.toolTip1.SetToolTip(this.lblVentasIva, " Graficar Reportes");
            this.lblVentasIva.Visible = false;
            this.lblVentasIva.VisitedLinkColor = System.Drawing.Color.Blue;
            this.lblVentasIva.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblVentasIva_LinkClicked);
            // 
            // lblVentasNeto
            // 
            this.lblVentasNeto.AutoSize = true;
            this.lblVentasNeto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVentasNeto.LinkColor = System.Drawing.Color.DodgerBlue;
            this.lblVentasNeto.Location = new System.Drawing.Point(226, 375);
            this.lblVentasNeto.Name = "lblVentasNeto";
            this.lblVentasNeto.Size = new System.Drawing.Size(152, 15);
            this.lblVentasNeto.TabIndex = 130;
            this.lblVentasNeto.TabStop = true;
            this.lblVentasNeto.Text = "Graficar Por Neto Grabado";
            this.toolTip1.SetToolTip(this.lblVentasNeto, " Graficar Reportes");
            this.lblVentasNeto.Visible = false;
            this.lblVentasNeto.VisitedLinkColor = System.Drawing.Color.Blue;
            this.lblVentasNeto.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblVentasNeto_LinkClicked);
            // 
            // lblVentasPorMonto
            // 
            this.lblVentasPorMonto.AutoSize = true;
            this.lblVentasPorMonto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVentasPorMonto.LinkColor = System.Drawing.Color.DodgerBlue;
            this.lblVentasPorMonto.Location = new System.Drawing.Point(68, 375);
            this.lblVentasPorMonto.Name = "lblVentasPorMonto";
            this.lblVentasPorMonto.Size = new System.Drawing.Size(110, 15);
            this.lblVentasPorMonto.TabIndex = 129;
            this.lblVentasPorMonto.TabStop = true;
            this.lblVentasPorMonto.Text = "Graficar Por Monto";
            this.toolTip1.SetToolTip(this.lblVentasPorMonto, " Graficar Reportes");
            this.lblVentasPorMonto.Visible = false;
            this.lblVentasPorMonto.VisitedLinkColor = System.Drawing.Color.Blue;
            this.lblVentasPorMonto.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblVentasPorMonto_LinkClicked);
            // 
            // chart1
            // 
            chartArea12.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea12);
            legend12.Name = "Legend1";
            this.chart1.Legends.Add(legend12);
            this.chart1.Location = new System.Drawing.Point(4, 92);
            this.chart1.Name = "chart1";
            this.chart1.Size = new System.Drawing.Size(590, 280);
            this.chart1.TabIndex = 128;
            this.chart1.Text = "chart1";
            this.chart1.Visible = false;
            // 
            // lblGraficarVentas
            // 
            this.lblGraficarVentas.AutoSize = true;
            this.lblGraficarVentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGraficarVentas.LinkColor = System.Drawing.Color.DodgerBlue;
            this.lblGraficarVentas.Location = new System.Drawing.Point(267, 67);
            this.lblGraficarVentas.Name = "lblGraficarVentas";
            this.lblGraficarVentas.Size = new System.Drawing.Size(74, 22);
            this.lblGraficarVentas.TabIndex = 127;
            this.lblGraficarVentas.TabStop = true;
            this.lblGraficarVentas.Text = "Graficar";
            this.toolTip1.SetToolTip(this.lblGraficarVentas, " Graficar Reportes");
            this.lblGraficarVentas.Visible = false;
            this.lblGraficarVentas.VisitedLinkColor = System.Drawing.Color.Blue;
            this.lblGraficarVentas.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // btnBuscarVentas
            // 
            this.btnBuscarVentas.Image = global::Sico.Properties.Resources.buscar_con_herramienta_en_esquema;
            this.btnBuscarVentas.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnBuscarVentas.Location = new System.Drawing.Point(526, 32);
            this.btnBuscarVentas.Name = "btnBuscarVentas";
            this.btnBuscarVentas.Size = new System.Drawing.Size(49, 39);
            this.btnBuscarVentas.TabIndex = 122;
            this.btnBuscarVentas.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip1.SetToolTip(this.btnBuscarVentas, "Buscar Ventas");
            this.btnBuscarVentas.UseVisualStyleBackColor = true;
            this.btnBuscarVentas.Click += new System.EventHandler(this.btnBuscarVentas_Click);
            // 
            // cmbPeriodosVentas
            // 
            this.cmbPeriodosVentas.Enabled = false;
            this.cmbPeriodosVentas.FormattingEnabled = true;
            this.cmbPeriodosVentas.Location = new System.Drawing.Point(347, 45);
            this.cmbPeriodosVentas.Name = "cmbPeriodosVentas";
            this.cmbPeriodosVentas.Size = new System.Drawing.Size(162, 21);
            this.cmbPeriodosVentas.TabIndex = 51;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(280, 46);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 17);
            this.label8.TabIndex = 50;
            this.label8.Text = "Periodo:";
            // 
            // cmbAñoVentas
            // 
            this.cmbAñoVentas.FormattingEnabled = true;
            this.cmbAñoVentas.Location = new System.Drawing.Point(112, 45);
            this.cmbAñoVentas.Name = "cmbAñoVentas";
            this.cmbAñoVentas.Size = new System.Drawing.Size(162, 21);
            this.cmbAñoVentas.TabIndex = 49;
            this.cmbAñoVentas.SelectedIndexChanged += new System.EventHandler(this.cmbAñoVentas_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(68, 46);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 17);
            this.label7.TabIndex = 48;
            this.label7.Text = "Año:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.SteelBlue;
            this.label5.Location = new System.Drawing.Point(197, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(228, 20);
            this.label5.TabIndex = 45;
            this.label5.Text = "Facturación de ventas Anuales";
            // 
            // dgvVentasAnuales
            // 
            this.dgvVentasAnuales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVentasAnuales.Location = new System.Drawing.Point(4, 92);
            this.dgvVentasAnuales.Name = "dgvVentasAnuales";
            this.dgvVentasAnuales.Size = new System.Drawing.Size(590, 280);
            this.dgvVentasAnuales.TabIndex = 44;
            this.dgvVentasAnuales.Visible = false;
            // 
            // MenuClienteWF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 657);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "MenuClienteWF";
            this.Text = "Menú Cliente";
            this.Load += new System.EventHandler(this.MenuClienteWF_Load);
            this.Controls.SetChildIndex(this.groupBox3, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.groupBox2, 0);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComprasAnuales)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentasAnuales)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCompras;
        private System.Windows.Forms.Button btnVentas;
        private System.Windows.Forms.Label lblCuitEdit;
        private System.Windows.Forms.Label lblNombreEdit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvComprasAnuales;
        private System.Windows.Forms.DataGridView dgvVentasAnuales;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbAño;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbAñoVentas;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnVencimientos;
        private System.Windows.Forms.Button btnConsultarVencimientos;
        private System.Windows.Forms.ComboBox cmbPeriodosVentas;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnBuscarVentas;
        private System.Windows.Forms.ComboBox cmbPeriodoCompras;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnBuscarCompras;
        private System.Windows.Forms.LinkLabel lblGraficarVentas;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.LinkLabel lblVentasIva;
        private System.Windows.Forms.LinkLabel lblVentasNeto;
        private System.Windows.Forms.LinkLabel lblVentasPorMonto;
        private System.Windows.Forms.LinkLabel lblLineas;
        private System.Windows.Forms.LinkLabel lblBarras;
        private System.Windows.Forms.LinkLabel lblComprasGraficar;
        private System.Windows.Forms.LinkLabel lblComprasLinea;
        private System.Windows.Forms.LinkLabel lblComprasBarra;
        private System.Windows.Forms.LinkLabel lblComprasIva;
        private System.Windows.Forms.LinkLabel lblComprasNeto;
        private System.Windows.Forms.LinkLabel lblComprasMonto;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
    }
}