namespace Sico
{
    partial class ComprasWF
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblSeleccionar = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnInportarCompras = new System.Windows.Forms.Button();
            this.btnEstadisticas = new System.Windows.Forms.Button();
            this.btnVentas = new System.Windows.Forms.Button();
            this.btnCuentaCorriente = new System.Windows.Forms.Button();
            this.btnCargarCompra = new System.Windows.Forms.Button();
            this.btnAgregarProveedor = new System.Windows.Forms.Button();
            this.dgvCompras = new System.Windows.Forms.DataGridView();
            this.idFactura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NroFactura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Monto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Proveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ver = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Editar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Total1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Neto1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Neto2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Neto3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Iva1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Iva2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Iva3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PerIva = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PercIngre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NoGravado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblCuitEdit = new System.Windows.Forms.Label();
            this.lblNombreEdit = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnConsultarTotales = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.lblCantidadEdit = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.grbEnlances = new System.Windows.Forms.GroupBox();
            this.imgAutoGestion = new System.Windows.Forms.PictureBox();
            this.imgApr = new System.Windows.Forms.PictureBox();
            this.imgArba = new System.Windows.Forms.PictureBox();
            this.imgAnses = new System.Windows.Forms.PictureBox();
            this.imgAfip = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.lblFacturasMensaje = new System.Windows.Forms.Label();
            this.btnCoral = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompras)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.grbEnlances.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgAutoGestion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgApr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgArba)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgAnses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgAfip)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSeleccionar
            // 
            this.lblSeleccionar.AutoSize = true;
            this.lblSeleccionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeleccionar.Location = new System.Drawing.Point(243, 200);
            this.lblSeleccionar.Name = "lblSeleccionar";
            this.lblSeleccionar.Size = new System.Drawing.Size(201, 15);
            this.lblSeleccionar.TabIndex = 31;
            this.lblSeleccionar.Text = "Buscar Por Nombre o Razón Social";
            this.lblSeleccionar.Visible = false;
            // 
            // txtBuscar
            // 
            this.txtBuscar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBuscar.Enabled = false;
            this.txtBuscar.Location = new System.Drawing.Point(450, 199);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(336, 20);
            this.txtBuscar.TabIndex = 30;
            this.txtBuscar.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 20);
            this.label2.TabIndex = 29;
            this.label2.Text = "Últimas Compras";
            this.label2.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnInportarCompras);
            this.groupBox2.Controls.Add(this.btnVentas);
            this.groupBox2.Controls.Add(this.btnCuentaCorriente);
            this.groupBox2.Controls.Add(this.btnEstadisticas);
            this.groupBox2.Controls.Add(this.btnCargarCompra);
            this.groupBox2.Controls.Add(this.btnAgregarProveedor);
            this.groupBox2.Location = new System.Drawing.Point(950, 77);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(186, 540);
            this.groupBox2.TabIndex = 28;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Funciones";
            // 
            // btnInportarCompras
            // 
            this.btnInportarCompras.Image = global::Sico.Properties.Resources.importacion__5_;
            this.btnInportarCompras.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnInportarCompras.Location = new System.Drawing.Point(45, 323);
            this.btnInportarCompras.Name = "btnInportarCompras";
            this.btnInportarCompras.Size = new System.Drawing.Size(90, 61);
            this.btnInportarCompras.TabIndex = 19;
            this.btnInportarCompras.Text = "Importar Compras";
            this.btnInportarCompras.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnInportarCompras.UseVisualStyleBackColor = true;
            this.btnInportarCompras.Click += new System.EventHandler(this.btnInportarCompras_Click);
            // 
            // btnEstadisticas
            // 
            this.btnEstadisticas.Image = global::Sico.Properties.Resources.diagrama;
            this.btnEstadisticas.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEstadisticas.Location = new System.Drawing.Point(45, 433);
            this.btnEstadisticas.Name = "btnEstadisticas";
            this.btnEstadisticas.Size = new System.Drawing.Size(90, 61);
            this.btnEstadisticas.TabIndex = 18;
            this.btnEstadisticas.Text = "Estadísticas";
            this.btnEstadisticas.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip1.SetToolTip(this.btnEstadisticas, "Estadisticas");
            this.btnEstadisticas.UseVisualStyleBackColor = true;
            this.btnEstadisticas.Visible = false;
            this.btnEstadisticas.Click += new System.EventHandler(this.btnEstadisticas_Click);
            // 
            // btnVentas
            // 
            this.btnVentas.Image = global::Sico.Properties.Resources.estadisticas_de_ventas;
            this.btnVentas.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnVentas.Location = new System.Drawing.Point(45, 433);
            this.btnVentas.Name = "btnVentas";
            this.btnVentas.Size = new System.Drawing.Size(90, 61);
            this.btnVentas.TabIndex = 17;
            this.btnVentas.Text = "Menú Ventas";
            this.btnVentas.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip1.SetToolTip(this.btnVentas, "Ventas");
            this.btnVentas.UseVisualStyleBackColor = true;
            this.btnVentas.Click += new System.EventHandler(this.btnVentas_Click);
            // 
            // btnCuentaCorriente
            // 
            this.btnCuentaCorriente.Image = global::Sico.Properties.Resources.dinero;
            this.btnCuentaCorriente.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCuentaCorriente.Location = new System.Drawing.Point(45, 220);
            this.btnCuentaCorriente.Name = "btnCuentaCorriente";
            this.btnCuentaCorriente.Size = new System.Drawing.Size(90, 61);
            this.btnCuentaCorriente.TabIndex = 4;
            this.btnCuentaCorriente.Text = "Nota de crédito";
            this.btnCuentaCorriente.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCuentaCorriente.UseVisualStyleBackColor = true;
            // 
            // btnCargarCompra
            // 
            this.btnCargarCompra.Image = global::Sico.Properties.Resources.factura;
            this.btnCargarCompra.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCargarCompra.Location = new System.Drawing.Point(45, 127);
            this.btnCargarCompra.Name = "btnCargarCompra";
            this.btnCargarCompra.Size = new System.Drawing.Size(90, 61);
            this.btnCargarCompra.TabIndex = 2;
            this.btnCargarCompra.Text = "Cargar Compra";
            this.btnCargarCompra.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip1.SetToolTip(this.btnCargarCompra, "Nueva Compra");
            this.btnCargarCompra.UseVisualStyleBackColor = true;
            this.btnCargarCompra.Click += new System.EventHandler(this.btnCargarCompra_Click);
            // 
            // btnAgregarProveedor
            // 
            this.btnAgregarProveedor.Image = global::Sico.Properties.Resources.agregar_usuario_nuevo;
            this.btnAgregarProveedor.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAgregarProveedor.Location = new System.Drawing.Point(45, 34);
            this.btnAgregarProveedor.Name = "btnAgregarProveedor";
            this.btnAgregarProveedor.Size = new System.Drawing.Size(90, 61);
            this.btnAgregarProveedor.TabIndex = 0;
            this.btnAgregarProveedor.Text = "Proveedor";
            this.btnAgregarProveedor.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip1.SetToolTip(this.btnAgregarProveedor, "Nuevo Proveedor");
            this.btnAgregarProveedor.UseVisualStyleBackColor = true;
            this.btnAgregarProveedor.Click += new System.EventHandler(this.btnAgregarProveedor_Click);
            // 
            // dgvCompras
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCompras.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCompras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCompras.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idFactura,
            this.NroFactura,
            this.Fecha,
            this.Monto,
            this.Proveedor,
            this.Ver,
            this.Editar,
            this.Total1,
            this.Total2,
            this.Total3,
            this.Neto1,
            this.Neto2,
            this.Neto3,
            this.Iva1,
            this.Iva2,
            this.Iva3,
            this.PerIva,
            this.PercIngre,
            this.NoGravado});
            this.dgvCompras.Location = new System.Drawing.Point(68, 234);
            this.dgvCompras.Name = "dgvCompras";
            this.dgvCompras.Size = new System.Drawing.Size(830, 305);
            this.dgvCompras.TabIndex = 27;
            this.dgvCompras.Visible = false;
            this.dgvCompras.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ClickBoton);
            this.dgvCompras.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgvCompras_CellPainting);
            // 
            // idFactura
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idFactura.DefaultCellStyle = dataGridViewCellStyle2;
            this.idFactura.HeaderText = "idFactura";
            this.idFactura.Name = "idFactura";
            // 
            // NroFactura
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NroFactura.DefaultCellStyle = dataGridViewCellStyle3;
            this.NroFactura.HeaderText = "Nro.Factura";
            this.NroFactura.Name = "NroFactura";
            this.NroFactura.Width = 160;
            // 
            // Fecha
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fecha.DefaultCellStyle = dataGridViewCellStyle4;
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            this.Fecha.Width = 80;
            // 
            // Monto
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Monto.DefaultCellStyle = dataGridViewCellStyle5;
            this.Monto.HeaderText = "Monto";
            this.Monto.Name = "Monto";
            // 
            // Proveedor
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Proveedor.DefaultCellStyle = dataGridViewCellStyle6;
            this.Proveedor.HeaderText = "Proveedor";
            this.Proveedor.Name = "Proveedor";
            this.Proveedor.Width = 280;
            // 
            // Ver
            // 
            this.Ver.HeaderText = "Ver";
            this.Ver.Name = "Ver";
            this.Ver.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Ver.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Editar
            // 
            this.Editar.HeaderText = "Editar";
            this.Editar.Name = "Editar";
            // 
            // Total1
            // 
            this.Total1.HeaderText = "Total1";
            this.Total1.Name = "Total1";
            this.Total1.Visible = false;
            // 
            // Total2
            // 
            this.Total2.HeaderText = "Total2";
            this.Total2.Name = "Total2";
            this.Total2.Visible = false;
            // 
            // Total3
            // 
            this.Total3.HeaderText = "Total3";
            this.Total3.Name = "Total3";
            this.Total3.Visible = false;
            // 
            // Neto1
            // 
            this.Neto1.HeaderText = "Neto1";
            this.Neto1.Name = "Neto1";
            this.Neto1.Visible = false;
            // 
            // Neto2
            // 
            this.Neto2.HeaderText = "Neto2";
            this.Neto2.Name = "Neto2";
            this.Neto2.Visible = false;
            // 
            // Neto3
            // 
            this.Neto3.HeaderText = "Neto3";
            this.Neto3.Name = "Neto3";
            this.Neto3.Visible = false;
            // 
            // Iva1
            // 
            this.Iva1.HeaderText = "Iva1";
            this.Iva1.Name = "Iva1";
            this.Iva1.Visible = false;
            // 
            // Iva2
            // 
            this.Iva2.HeaderText = "Iva2";
            this.Iva2.Name = "Iva2";
            this.Iva2.Visible = false;
            // 
            // Iva3
            // 
            this.Iva3.HeaderText = "Iva3";
            this.Iva3.Name = "Iva3";
            this.Iva3.Visible = false;
            // 
            // PerIva
            // 
            this.PerIva.HeaderText = "PerIva";
            this.PerIva.Name = "PerIva";
            this.PerIva.Visible = false;
            // 
            // PercIngre
            // 
            this.PercIngre.HeaderText = "PercIngre";
            this.PercIngre.Name = "PercIngre";
            this.PercIngre.Visible = false;
            // 
            // NoGravado
            // 
            this.NoGravado.HeaderText = "NoGravado";
            this.NoGravado.Name = "NoGravado";
            this.NoGravado.Visible = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.lblCuitEdit);
            this.groupBox3.Controls.Add(this.lblNombreEdit);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(20, 130);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(878, 50);
            this.groupBox3.TabIndex = 26;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tareas";
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
            // btnConsultarTotales
            // 
            this.btnConsultarTotales.Image = global::Sico.Properties.Resources.factura__1_;
            this.btnConsultarTotales.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnConsultarTotales.Location = new System.Drawing.Point(847, 184);
            this.btnConsultarTotales.Name = "btnConsultarTotales";
            this.btnConsultarTotales.Size = new System.Drawing.Size(49, 39);
            this.btnConsultarTotales.TabIndex = 33;
            this.btnConsultarTotales.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip1.SetToolTip(this.btnConsultarTotales, "Facturación Mensual");
            this.btnConsultarTotales.UseVisualStyleBackColor = true;
            this.btnConsultarTotales.Visible = false;
            this.btnConsultarTotales.Click += new System.EventHandler(this.btnConsultarTotales_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Image = global::Sico.Properties.Resources.buscar_con_herramienta_en_esquema;
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnBuscar.Location = new System.Drawing.Point(792, 184);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(49, 39);
            this.btnBuscar.TabIndex = 32;
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip1.SetToolTip(this.btnBuscar, "Buscar por proveedor");
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Visible = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.SteelBlue;
            this.label18.Location = new System.Drawing.Point(468, 77);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(92, 25);
            this.label18.TabIndex = 34;
            this.label18.Text = "Compras";
            // 
            // btnActualizar
            // 
            this.btnActualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.Image = global::Sico.Properties.Resources.refrescar;
            this.btnActualizar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnActualizar.Location = new System.Drawing.Point(152, 193);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(40, 30);
            this.btnActualizar.TabIndex = 86;
            this.btnActualizar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip1.SetToolTip(this.btnActualizar, "Actualizar grilla");
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // lblCantidadEdit
            // 
            this.lblCantidadEdit.AutoSize = true;
            this.lblCantidadEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidadEdit.Location = new System.Drawing.Point(788, 545);
            this.lblCantidadEdit.Name = "lblCantidadEdit";
            this.lblCantidadEdit.Size = new System.Drawing.Size(33, 20);
            this.lblCantidadEdit.TabIndex = 88;
            this.lblCantidadEdit.Text = "****";
            this.lblCantidadEdit.Visible = false;
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.Location = new System.Drawing.Point(734, 545);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(48, 20);
            this.lblCantidad.TabIndex = 87;
            this.lblCantidad.Text = "Total:";
            this.lblCantidad.Visible = false;
            // 
            // grbEnlances
            // 
            this.grbEnlances.Controls.Add(this.imgAutoGestion);
            this.grbEnlances.Controls.Add(this.imgApr);
            this.grbEnlances.Controls.Add(this.imgArba);
            this.grbEnlances.Controls.Add(this.imgAnses);
            this.grbEnlances.Controls.Add(this.imgAfip);
            this.grbEnlances.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbEnlances.Location = new System.Drawing.Point(58, 565);
            this.grbEnlances.Name = "grbEnlances";
            this.grbEnlances.Size = new System.Drawing.Size(850, 70);
            this.grbEnlances.TabIndex = 93;
            this.grbEnlances.TabStop = false;
            this.grbEnlances.Text = "Enlaces";
            // 
            // imgAutoGestion
            // 
            this.imgAutoGestion.Image = global::Sico.Properties.Resources.AutoGestion2;
            this.imgAutoGestion.Location = new System.Drawing.Point(680, 24);
            this.imgAutoGestion.Name = "imgAutoGestion";
            this.imgAutoGestion.Size = new System.Drawing.Size(145, 35);
            this.imgAutoGestion.TabIndex = 91;
            this.imgAutoGestion.TabStop = false;
            this.toolTip1.SetToolTip(this.imgAutoGestion, "AutoGestión");
            this.imgAutoGestion.Click += new System.EventHandler(this.imgAutoGestion_Click);
            // 
            // imgApr
            // 
            this.imgApr.Image = global::Sico.Properties.Resources.Apr;
            this.imgApr.Location = new System.Drawing.Point(510, 24);
            this.imgApr.Name = "imgApr";
            this.imgApr.Size = new System.Drawing.Size(145, 35);
            this.imgApr.TabIndex = 89;
            this.imgApr.TabStop = false;
            this.toolTip1.SetToolTip(this.imgApr, "Agencia Platense de racaudación");
            this.imgApr.Click += new System.EventHandler(this.imgApr_Click);
            // 
            // imgArba
            // 
            this.imgArba.Image = global::Sico.Properties.Resources.Arba;
            this.imgArba.Location = new System.Drawing.Point(19, 24);
            this.imgArba.Name = "imgArba";
            this.imgArba.Size = new System.Drawing.Size(145, 35);
            this.imgArba.TabIndex = 86;
            this.imgArba.TabStop = false;
            this.toolTip1.SetToolTip(this.imgArba, "Arba");
            this.imgArba.Click += new System.EventHandler(this.imgArba_Click);
            // 
            // imgAnses
            // 
            this.imgAnses.Image = global::Sico.Properties.Resources.Anses_2;
            this.imgAnses.Location = new System.Drawing.Point(344, 24);
            this.imgAnses.Name = "imgAnses";
            this.imgAnses.Size = new System.Drawing.Size(145, 35);
            this.imgAnses.TabIndex = 88;
            this.imgAnses.TabStop = false;
            this.toolTip1.SetToolTip(this.imgAnses, "Anses");
            this.imgAnses.Click += new System.EventHandler(this.imgAnses_Click);
            // 
            // imgAfip
            // 
            this.imgAfip.Image = global::Sico.Properties.Resources.Afip_1_;
            this.imgAfip.Location = new System.Drawing.Point(182, 24);
            this.imgAfip.Name = "imgAfip";
            this.imgAfip.Size = new System.Drawing.Size(145, 35);
            this.imgAfip.TabIndex = 87;
            this.imgAfip.TabStop = false;
            this.toolTip1.SetToolTip(this.imgAfip, "Afip");
            this.imgAfip.Click += new System.EventHandler(this.imgAfip_Click);
            // 
            // lblFacturasMensaje
            // 
            this.lblFacturasMensaje.AutoSize = true;
            this.lblFacturasMensaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFacturasMensaje.Location = new System.Drawing.Point(194, 545);
            this.lblFacturasMensaje.Name = "lblFacturasMensaje";
            this.lblFacturasMensaje.Size = new System.Drawing.Size(265, 20);
            this.lblFacturasMensaje.TabIndex = 94;
            this.lblFacturasMensaje.Text = "Facturas con montos inconsistentes";
            this.lblFacturasMensaje.Visible = false;
            // 
            // btnCoral
            // 
            this.btnCoral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnCoral.Enabled = false;
            this.btnCoral.Location = new System.Drawing.Point(158, 541);
            this.btnCoral.Name = "btnCoral";
            this.btnCoral.Size = new System.Drawing.Size(30, 30);
            this.btnCoral.TabIndex = 95;
            this.btnCoral.UseVisualStyleBackColor = false;
            // 
            // ComprasWF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 657);
            this.Controls.Add(this.btnCoral);
            this.Controls.Add(this.lblFacturasMensaje);
            this.Controls.Add(this.grbEnlances);
            this.Controls.Add(this.lblCantidadEdit);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.btnConsultarTotales);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.lblSeleccionar);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dgvCompras);
            this.Controls.Add(this.groupBox3);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "ComprasWF";
            this.Text = "Compras";
            this.Load += new System.EventHandler(this.ComprasWF_Load);
            this.Controls.SetChildIndex(this.groupBox3, 0);
            this.Controls.SetChildIndex(this.dgvCompras, 0);
            this.Controls.SetChildIndex(this.groupBox2, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.txtBuscar, 0);
            this.Controls.SetChildIndex(this.lblSeleccionar, 0);
            this.Controls.SetChildIndex(this.btnBuscar, 0);
            this.Controls.SetChildIndex(this.btnConsultarTotales, 0);
            this.Controls.SetChildIndex(this.label18, 0);
            this.Controls.SetChildIndex(this.btnActualizar, 0);
            this.Controls.SetChildIndex(this.lblCantidad, 0);
            this.Controls.SetChildIndex(this.lblCantidadEdit, 0);
            this.Controls.SetChildIndex(this.grbEnlances, 0);
            this.Controls.SetChildIndex(this.lblFacturasMensaje, 0);
            this.Controls.SetChildIndex(this.btnCoral, 0);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompras)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.grbEnlances.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgAutoGestion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgApr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgArba)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgAnses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgAfip)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConsultarTotales;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblSeleccionar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnCuentaCorriente;
        private System.Windows.Forms.Button btnCargarCompra;
        private System.Windows.Forms.Button btnAgregarProveedor;
        private System.Windows.Forms.DataGridView dgvCompras;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblCuitEdit;
        private System.Windows.Forms.Label lblNombreEdit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button btnVentas;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnEstadisticas;
        private System.Windows.Forms.Label lblCantidadEdit;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.GroupBox grbEnlances;
        private System.Windows.Forms.PictureBox imgApr;
        private System.Windows.Forms.PictureBox imgArba;
        private System.Windows.Forms.PictureBox imgAnses;
        private System.Windows.Forms.PictureBox imgAfip;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.PictureBox imgAutoGestion;
        private System.Windows.Forms.Button btnInportarCompras;
        private System.Windows.Forms.DataGridViewTextBoxColumn idFactura;
        private System.Windows.Forms.DataGridViewTextBoxColumn NroFactura;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Monto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Proveedor;
        private System.Windows.Forms.DataGridViewButtonColumn Ver;
        private System.Windows.Forms.DataGridViewButtonColumn Editar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Neto1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Neto2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Neto3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Iva1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Iva2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Iva3;
        private System.Windows.Forms.DataGridViewTextBoxColumn PerIva;
        private System.Windows.Forms.DataGridViewTextBoxColumn PercIngre;
        private System.Windows.Forms.DataGridViewTextBoxColumn NoGravado;
        private System.Windows.Forms.Label lblFacturasMensaje;
        private System.Windows.Forms.Button btnCoral;
    }
}