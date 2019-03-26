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
            this.lblSeleccionar = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnCuentaCorriente = new System.Windows.Forms.Button();
            this.btnCargarCompra = new System.Windows.Forms.Button();
            this.btnAgregarProveedor = new System.Windows.Forms.Button();
            this.dgvCompras = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblCuitEdit = new System.Windows.Forms.Label();
            this.lblNombreEdit = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnConsultarTotales = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompras)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSeleccionar
            // 
            this.lblSeleccionar.AutoSize = true;
            this.lblSeleccionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeleccionar.Location = new System.Drawing.Point(243, 278);
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
            this.txtBuscar.Location = new System.Drawing.Point(450, 277);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(336, 20);
            this.txtBuscar.TabIndex = 30;
            this.txtBuscar.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 275);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 20);
            this.label2.TabIndex = 29;
            this.label2.Text = "Últimas Compras";
            this.label2.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnCuentaCorriente);
            this.groupBox2.Controls.Add(this.btnCargarCompra);
            this.groupBox2.Controls.Add(this.btnAgregarProveedor);
            this.groupBox2.Location = new System.Drawing.Point(950, 77);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(186, 452);
            this.groupBox2.TabIndex = 28;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Funciones";
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
            this.btnCargarCompra.UseVisualStyleBackColor = true;
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
            this.btnAgregarProveedor.UseVisualStyleBackColor = true;
            this.btnAgregarProveedor.Click += new System.EventHandler(this.btnAgregarProveedor_Click);
            // 
            // dgvCompras
            // 
            this.dgvCompras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCompras.Location = new System.Drawing.Point(68, 312);
            this.dgvCompras.Name = "dgvCompras";
            this.dgvCompras.Size = new System.Drawing.Size(830, 305);
            this.dgvCompras.TabIndex = 27;
            this.dgvCompras.Visible = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.lblCuitEdit);
            this.groupBox3.Controls.Add(this.lblNombreEdit);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(20, 130);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(878, 121);
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
            this.btnConsultarTotales.Location = new System.Drawing.Point(847, 262);
            this.btnConsultarTotales.Name = "btnConsultarTotales";
            this.btnConsultarTotales.Size = new System.Drawing.Size(49, 39);
            this.btnConsultarTotales.TabIndex = 33;
            this.btnConsultarTotales.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnConsultarTotales.UseVisualStyleBackColor = true;
            this.btnConsultarTotales.Visible = false;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Image = global::Sico.Properties.Resources.buscar_con_herramienta_en_esquema;
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnBuscar.Location = new System.Drawing.Point(792, 262);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(49, 39);
            this.btnBuscar.TabIndex = 32;
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Visible = false;
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
            // ComprasWF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 657);
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
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompras)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
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
    }
}