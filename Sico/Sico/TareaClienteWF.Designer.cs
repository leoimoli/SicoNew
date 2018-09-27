namespace Sico
{
    partial class TareaClienteWF
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblCuitEdit = new System.Windows.Forms.Label();
            this.lblNombreEdit = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvSubClientes = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.lblSeleccionar = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblCantidadEdit = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnConsultarTotales = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnNuevaFactura = new System.Windows.Forms.Button();
            this.btnNuevoSubCliente = new System.Windows.Forms.Button();
            this.btnFacturar = new System.Windows.Forms.Button();
            this.btnLibroDiario = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubClientes)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnFacturar);
            this.groupBox3.Controls.Add(this.btnLibroDiario);
            this.groupBox3.Controls.Add(this.lblCuitEdit);
            this.groupBox3.Controls.Add(this.lblNombreEdit);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(38, 86);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(878, 121);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tareas";
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Nombre/Razón Social:";
            // 
            // dgvSubClientes
            // 
            this.dgvSubClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSubClientes.Location = new System.Drawing.Point(86, 268);
            this.dgvSubClientes.Name = "dgvSubClientes";
            this.dgvSubClientes.Size = new System.Drawing.Size(830, 305);
            this.dgvSubClientes.TabIndex = 17;
            this.dgvSubClientes.Visible = false;
            this.dgvSubClientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ClickBoton);
            this.dgvSubClientes.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgvSubClientes_CellPainting);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnNuevaFactura);
            this.groupBox2.Controls.Add(this.btnNuevoSubCliente);
            this.groupBox2.Location = new System.Drawing.Point(968, 91);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(186, 452);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Funciones";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 231);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 20);
            this.label2.TabIndex = 19;
            this.label2.Text = "Últimas Facturaciones";
            this.label2.Visible = false;
            // 
            // txtBuscar
            // 
            this.txtBuscar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBuscar.Enabled = false;
            this.txtBuscar.Location = new System.Drawing.Point(468, 233);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(336, 20);
            this.txtBuscar.TabIndex = 20;
            this.txtBuscar.Visible = false;
            // 
            // lblSeleccionar
            // 
            this.lblSeleccionar.AutoSize = true;
            this.lblSeleccionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeleccionar.Location = new System.Drawing.Point(261, 234);
            this.lblSeleccionar.Name = "lblSeleccionar";
            this.lblSeleccionar.Size = new System.Drawing.Size(201, 15);
            this.lblSeleccionar.TabIndex = 21;
            this.lblSeleccionar.Text = "Buscar Por Nombre o Razón Social";
            this.lblSeleccionar.Visible = false;
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.Location = new System.Drawing.Point(675, 576);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(48, 20);
            this.lblCantidad.TabIndex = 23;
            this.lblCantidad.Text = "Total:";
            this.lblCantidad.Visible = false;
            // 
            // lblCantidadEdit
            // 
            this.lblCantidadEdit.AutoSize = true;
            this.lblCantidadEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidadEdit.Location = new System.Drawing.Point(729, 576);
            this.lblCantidadEdit.Name = "lblCantidadEdit";
            this.lblCantidadEdit.Size = new System.Drawing.Size(33, 20);
            this.lblCantidadEdit.TabIndex = 24;
            this.lblCantidadEdit.Text = "****";
            this.lblCantidadEdit.Visible = false;
            // 
            // btnConsultarTotales
            // 
            this.btnConsultarTotales.Image = global::Sico.Properties.Resources.factura__1_;
            this.btnConsultarTotales.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnConsultarTotales.Location = new System.Drawing.Point(865, 218);
            this.btnConsultarTotales.Name = "btnConsultarTotales";
            this.btnConsultarTotales.Size = new System.Drawing.Size(49, 39);
            this.btnConsultarTotales.TabIndex = 25;
            this.btnConsultarTotales.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip1.SetToolTip(this.btnConsultarTotales, "Facturación Mensual");
            this.btnConsultarTotales.UseVisualStyleBackColor = true;
            this.btnConsultarTotales.Click += new System.EventHandler(this.btnConsultarTotales_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Image = global::Sico.Properties.Resources.buscar_con_herramienta_en_esquema;
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnBuscar.Location = new System.Drawing.Point(810, 218);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(49, 39);
            this.btnBuscar.TabIndex = 22;
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip1.SetToolTip(this.btnBuscar, "Buscar Sub-Cliente");
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Visible = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnNuevaFactura
            // 
            this.btnNuevaFactura.Image = global::Sico.Properties.Resources.factura;
            this.btnNuevaFactura.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnNuevaFactura.Location = new System.Drawing.Point(45, 105);
            this.btnNuevaFactura.Name = "btnNuevaFactura";
            this.btnNuevaFactura.Size = new System.Drawing.Size(90, 61);
            this.btnNuevaFactura.TabIndex = 1;
            this.btnNuevaFactura.Text = "Factura B";
            this.btnNuevaFactura.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnNuevaFactura.UseVisualStyleBackColor = true;
            this.btnNuevaFactura.Click += new System.EventHandler(this.btnNuevaFactura_Click);
            // 
            // btnNuevoSubCliente
            // 
            this.btnNuevoSubCliente.Image = global::Sico.Properties.Resources.agregar_usuario_nuevo;
            this.btnNuevoSubCliente.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnNuevoSubCliente.Location = new System.Drawing.Point(45, 19);
            this.btnNuevoSubCliente.Name = "btnNuevoSubCliente";
            this.btnNuevoSubCliente.Size = new System.Drawing.Size(90, 61);
            this.btnNuevoSubCliente.TabIndex = 0;
            this.btnNuevoSubCliente.Text = "Sub-Cliente";
            this.btnNuevoSubCliente.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnNuevoSubCliente.UseVisualStyleBackColor = true;
            this.btnNuevoSubCliente.Click += new System.EventHandler(this.btnNuevoSubCliente_Click_1);
            // 
            // btnFacturar
            // 
            this.btnFacturar.Image = global::Sico.Properties.Resources.diagnostico1;
            this.btnFacturar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnFacturar.Location = new System.Drawing.Point(55, 54);
            this.btnFacturar.Name = "btnFacturar";
            this.btnFacturar.Size = new System.Drawing.Size(90, 61);
            this.btnFacturar.TabIndex = 15;
            this.btnFacturar.Text = "Facturar";
            this.btnFacturar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnFacturar.UseVisualStyleBackColor = true;
            this.btnFacturar.Click += new System.EventHandler(this.btnFacturar_Click);
            // 
            // btnLibroDiario
            // 
            this.btnLibroDiario.Image = global::Sico.Properties.Resources.diario_abierto;
            this.btnLibroDiario.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnLibroDiario.Location = new System.Drawing.Point(174, 54);
            this.btnLibroDiario.Name = "btnLibroDiario";
            this.btnLibroDiario.Size = new System.Drawing.Size(90, 61);
            this.btnLibroDiario.TabIndex = 16;
            this.btnLibroDiario.Text = "Libro Diario";
            this.btnLibroDiario.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLibroDiario.UseVisualStyleBackColor = true;
            this.btnLibroDiario.Visible = false;
            // 
            // TareaClienteWF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 657);
            this.Controls.Add(this.btnConsultarTotales);
            this.Controls.Add(this.lblCantidadEdit);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.lblSeleccionar);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dgvSubClientes);
            this.Controls.Add(this.groupBox3);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "TareaClienteWF";
            this.Text = "TareaClienteWF";
            this.Load += new System.EventHandler(this.TareaClienteWF_Load);
            this.Controls.SetChildIndex(this.groupBox3, 0);
            this.Controls.SetChildIndex(this.dgvSubClientes, 0);
            this.Controls.SetChildIndex(this.groupBox2, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.txtBuscar, 0);
            this.Controls.SetChildIndex(this.lblSeleccionar, 0);
            this.Controls.SetChildIndex(this.btnBuscar, 0);
            this.Controls.SetChildIndex(this.lblCantidad, 0);
            this.Controls.SetChildIndex(this.lblCantidadEdit, 0);
            this.Controls.SetChildIndex(this.btnConsultarTotales, 0);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubClientes)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblCuitEdit;
        private System.Windows.Forms.Label lblNombreEdit;
        private System.Windows.Forms.Button btnFacturar;
        private System.Windows.Forms.Button btnLibroDiario;
        private System.Windows.Forms.DataGridView dgvSubClientes;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnNuevoSubCliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label lblSeleccionar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lblCantidadEdit;
        private System.Windows.Forms.Button btnNuevaFactura;
        private System.Windows.Forms.Button btnConsultarTotales;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}