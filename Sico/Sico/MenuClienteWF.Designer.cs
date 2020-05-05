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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblCuitEdit = new System.Windows.Forms.Label();
            this.lblNombreEdit = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbAño = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.dgvComprasAnuales = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbAñoVentas = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvVentasAnuales = new System.Windows.Forms.DataGridView();
            this.btnConsultarVencimientos = new System.Windows.Forms.Button();
            this.btnVencimientos = new System.Windows.Forms.Button();
            this.btnCompras = new System.Windows.Forms.Button();
            this.btnVentas = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComprasAnuales)).BeginInit();
            this.groupBox2.SuspendLayout();
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
            // groupBox1
            // 
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
            // cmbAño
            // 
            this.cmbAño.FormattingEnabled = true;
            this.cmbAño.Location = new System.Drawing.Point(234, 38);
            this.cmbAño.Name = "cmbAño";
            this.cmbAño.Size = new System.Drawing.Size(162, 21);
            this.cmbAño.TabIndex = 47;
            this.cmbAño.SelectedIndexChanged += new System.EventHandler(this.cmbAño_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(190, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 17);
            this.label6.TabIndex = 46;
            this.label6.Text = "Año:";
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
            this.dgvComprasAnuales.Location = new System.Drawing.Point(4, 68);
            this.dgvComprasAnuales.Name = "dgvComprasAnuales";
            this.dgvComprasAnuales.Size = new System.Drawing.Size(590, 340);
            this.dgvComprasAnuales.TabIndex = 43;
            this.dgvComprasAnuales.Visible = false;
            // 
            // groupBox2
            // 
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
            // cmbAñoVentas
            // 
            this.cmbAñoVentas.FormattingEnabled = true;
            this.cmbAñoVentas.Location = new System.Drawing.Point(294, 39);
            this.cmbAñoVentas.Name = "cmbAñoVentas";
            this.cmbAñoVentas.Size = new System.Drawing.Size(162, 21);
            this.cmbAñoVentas.TabIndex = 49;
            this.cmbAñoVentas.SelectedIndexChanged += new System.EventHandler(this.cmbAñoVentas_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(250, 40);
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
            this.label5.Location = new System.Drawing.Point(228, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(228, 20);
            this.label5.TabIndex = 45;
            this.label5.Text = "Facturación de ventas Anuales";
            // 
            // dgvVentasAnuales
            // 
            this.dgvVentasAnuales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVentasAnuales.Location = new System.Drawing.Point(6, 68);
            this.dgvVentasAnuales.Name = "dgvVentasAnuales";
            this.dgvVentasAnuales.Size = new System.Drawing.Size(590, 340);
            this.dgvVentasAnuales.TabIndex = 44;
            this.dgvVentasAnuales.Visible = false;
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvComprasAnuales)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
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
    }
}