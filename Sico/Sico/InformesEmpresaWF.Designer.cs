namespace Sico
{
    partial class InformesEmpresaWF
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.dgvVencimientos = new System.Windows.Forms.DataGridView();
            this.idEmpresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Empresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaVencimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvPagosRecibidos = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.chartPagosRecibidos = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Año = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MontoTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ver = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.btnPlanesCerrados = new System.Windows.Forms.Button();
            this.btnPlanesAbiertos = new System.Windows.Forms.Button();
            this.btnCobroHonorarios = new System.Windows.Forms.Button();
            this.btnPlanesGenerados = new System.Windows.Forms.Button();
            this.lblTotalVentas = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblCajaVentas = new System.Windows.Forms.Label();
            this.lblTotalCompras = new System.Windows.Forms.Label();
            this.lblPagosProveedores = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVencimientos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPagosRecibidos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartPagosRecibidos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvVencimientos
            // 
            this.dgvVencimientos.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvVencimientos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvVencimientos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVencimientos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idEmpresa,
            this.Empresa,
            this.Descripcion,
            this.FechaVencimiento});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvVencimientos.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvVencimientos.EnableHeadersVisualStyles = false;
            this.dgvVencimientos.Location = new System.Drawing.Point(2, 31);
            this.dgvVencimientos.Name = "dgvVencimientos";
            this.dgvVencimientos.RowHeadersVisible = false;
            this.dgvVencimientos.Size = new System.Drawing.Size(476, 200);
            this.dgvVencimientos.TabIndex = 62;
            this.dgvVencimientos.Visible = false;
            // 
            // idEmpresa
            // 
            this.idEmpresa.HeaderText = "id Empresa";
            this.idEmpresa.Name = "idEmpresa";
            this.idEmpresa.Width = 70;
            // 
            // Empresa
            // 
            this.Empresa.HeaderText = "Empresa";
            this.Empresa.Name = "Empresa";
            this.Empresa.Width = 190;
            // 
            // Descripcion
            // 
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.Name = "Descripcion";
            // 
            // FechaVencimiento
            // 
            this.FechaVencimiento.HeaderText = "Fecha Vencimiento";
            this.FechaVencimiento.Name = "FechaVencimiento";
            this.FechaVencimiento.Width = 110;
            // 
            // dgvPagosRecibidos
            // 
            this.dgvPagosRecibidos.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPagosRecibidos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPagosRecibidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPagosRecibidos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Año,
            this.Mes,
            this.MontoTotal,
            this.Ver});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPagosRecibidos.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvPagosRecibidos.EnableHeadersVisualStyles = false;
            this.dgvPagosRecibidos.Location = new System.Drawing.Point(2, 261);
            this.dgvPagosRecibidos.Name = "dgvPagosRecibidos";
            this.dgvPagosRecibidos.RowHeadersVisible = false;
            this.dgvPagosRecibidos.Size = new System.Drawing.Size(476, 209);
            this.dgvPagosRecibidos.TabIndex = 63;
            this.dgvPagosRecibidos.Visible = false;
            this.dgvPagosRecibidos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPagosRecibidos_CellClick);
            this.dgvPagosRecibidos.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgvPagosRecibidos_CellPainting);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(12, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(223, 20);
            this.label2.TabIndex = 64;
            this.label2.Text = "Listado vencimientos de pago ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(12, 239);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 20);
            this.label1.TabIndex = 65;
            this.label1.Text = "Pagos Recibidos";
            // 
            // chartPagosRecibidos
            // 
            this.chartPagosRecibidos.BackColor = System.Drawing.SystemColors.Control;
            chartArea1.BackColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            this.chartPagosRecibidos.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartPagosRecibidos.Legends.Add(legend1);
            this.chartPagosRecibidos.Location = new System.Drawing.Point(522, 261);
            this.chartPagosRecibidos.Name = "chartPagosRecibidos";
            this.chartPagosRecibidos.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series1.Color = System.Drawing.Color.Transparent;
            series1.IsValueShownAsLabel = true;
            series1.LabelForeColor = System.Drawing.Color.White;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            series1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            this.chartPagosRecibidos.Series.Add(series1);
            this.chartPagosRecibidos.Size = new System.Drawing.Size(523, 206);
            this.chartPagosRecibidos.TabIndex = 66;
            this.chartPagosRecibidos.Text = "CharPagosRecibidos";
            title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            title1.ForeColor = System.Drawing.Color.SteelBlue;
            title1.Name = "Title1";
            title1.Text = "Pagos Recibidos";
            this.chartPagosRecibidos.Titles.Add(title1);
            // 
            // Año
            // 
            this.Año.HeaderText = "Año";
            this.Año.Name = "Año";
            // 
            // Mes
            // 
            this.Mes.HeaderText = "Mes";
            this.Mes.Name = "Mes";
            this.Mes.Width = 190;
            // 
            // MontoTotal
            // 
            this.MontoTotal.HeaderText = "Monto Total";
            this.MontoTotal.Name = "MontoTotal";
            // 
            // Ver
            // 
            this.Ver.HeaderText = "Ver";
            this.Ver.Name = "Ver";
            this.Ver.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Ver.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Ver.Width = 80;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.SteelBlue;
            this.label3.Location = new System.Drawing.Point(656, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(290, 20);
            this.label3.TabIndex = 71;
            this.label3.Text = "Estadisticas generales del año en curso";
            // 
            // btnPlanesCerrados
            // 
            this.btnPlanesCerrados.BackColor = System.Drawing.Color.SteelBlue;
            this.btnPlanesCerrados.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen;
            this.btnPlanesCerrados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlanesCerrados.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlanesCerrados.ForeColor = System.Drawing.Color.White;
            this.btnPlanesCerrados.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPlanesCerrados.Location = new System.Drawing.Point(818, 171);
            this.btnPlanesCerrados.Name = "btnPlanesCerrados";
            this.btnPlanesCerrados.Size = new System.Drawing.Size(181, 53);
            this.btnPlanesCerrados.TabIndex = 70;
            this.btnPlanesCerrados.Text = "Planes Cerrados";
            this.btnPlanesCerrados.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnPlanesCerrados.UseVisualStyleBackColor = false;
            // 
            // btnPlanesAbiertos
            // 
            this.btnPlanesAbiertos.BackColor = System.Drawing.Color.SteelBlue;
            this.btnPlanesAbiertos.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen;
            this.btnPlanesAbiertos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlanesAbiertos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlanesAbiertos.ForeColor = System.Drawing.Color.White;
            this.btnPlanesAbiertos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPlanesAbiertos.Location = new System.Drawing.Point(601, 171);
            this.btnPlanesAbiertos.Name = "btnPlanesAbiertos";
            this.btnPlanesAbiertos.Size = new System.Drawing.Size(181, 53);
            this.btnPlanesAbiertos.TabIndex = 69;
            this.btnPlanesAbiertos.Text = "Planes Abiertos";
            this.btnPlanesAbiertos.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnPlanesAbiertos.UseVisualStyleBackColor = false;
            // 
            // btnCobroHonorarios
            // 
            this.btnCobroHonorarios.BackColor = System.Drawing.Color.SteelBlue;
            this.btnCobroHonorarios.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen;
            this.btnCobroHonorarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCobroHonorarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCobroHonorarios.ForeColor = System.Drawing.Color.White;
            this.btnCobroHonorarios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCobroHonorarios.Location = new System.Drawing.Point(818, 64);
            this.btnCobroHonorarios.Name = "btnCobroHonorarios";
            this.btnCobroHonorarios.Size = new System.Drawing.Size(181, 53);
            this.btnCobroHonorarios.TabIndex = 68;
            this.btnCobroHonorarios.Text = "Cobro de Honorarios";
            this.btnCobroHonorarios.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnCobroHonorarios.UseVisualStyleBackColor = false;
            // 
            // btnPlanesGenerados
            // 
            this.btnPlanesGenerados.BackColor = System.Drawing.Color.SteelBlue;
            this.btnPlanesGenerados.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen;
            this.btnPlanesGenerados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlanesGenerados.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlanesGenerados.ForeColor = System.Drawing.Color.White;
            this.btnPlanesGenerados.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPlanesGenerados.Location = new System.Drawing.Point(601, 64);
            this.btnPlanesGenerados.Name = "btnPlanesGenerados";
            this.btnPlanesGenerados.Size = new System.Drawing.Size(181, 53);
            this.btnPlanesGenerados.TabIndex = 67;
            this.btnPlanesGenerados.Text = "Planes Generados";
            this.btnPlanesGenerados.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnPlanesGenerados.UseVisualStyleBackColor = false;
            // 
            // lblTotalVentas
            // 
            this.lblTotalVentas.AutoSize = true;
            this.lblTotalVentas.BackColor = System.Drawing.Color.SteelBlue;
            this.lblTotalVentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalVentas.ForeColor = System.Drawing.Color.White;
            this.lblTotalVentas.Location = new System.Drawing.Point(716, 91);
            this.lblTotalVentas.Name = "lblTotalVentas";
            this.lblTotalVentas.Size = new System.Drawing.Size(22, 17);
            this.lblTotalVentas.TabIndex = 72;
            this.lblTotalVentas.Text = "@";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.SteelBlue;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(929, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 17);
            this.label4.TabIndex = 74;
            this.label4.Text = "$";
            // 
            // lblCajaVentas
            // 
            this.lblCajaVentas.AutoSize = true;
            this.lblCajaVentas.BackColor = System.Drawing.Color.SteelBlue;
            this.lblCajaVentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCajaVentas.ForeColor = System.Drawing.Color.White;
            this.lblCajaVentas.Location = new System.Drawing.Point(951, 91);
            this.lblCajaVentas.Name = "lblCajaVentas";
            this.lblCajaVentas.Size = new System.Drawing.Size(22, 17);
            this.lblCajaVentas.TabIndex = 73;
            this.lblCajaVentas.Text = "@";
            // 
            // lblTotalCompras
            // 
            this.lblTotalCompras.AutoSize = true;
            this.lblTotalCompras.BackColor = System.Drawing.Color.SteelBlue;
            this.lblTotalCompras.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCompras.ForeColor = System.Drawing.Color.White;
            this.lblTotalCompras.Location = new System.Drawing.Point(716, 198);
            this.lblTotalCompras.Name = "lblTotalCompras";
            this.lblTotalCompras.Size = new System.Drawing.Size(22, 17);
            this.lblTotalCompras.TabIndex = 75;
            this.lblTotalCompras.Text = "@";
            // 
            // lblPagosProveedores
            // 
            this.lblPagosProveedores.AutoSize = true;
            this.lblPagosProveedores.BackColor = System.Drawing.Color.SteelBlue;
            this.lblPagosProveedores.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPagosProveedores.ForeColor = System.Drawing.Color.White;
            this.lblPagosProveedores.Location = new System.Drawing.Point(951, 198);
            this.lblPagosProveedores.Name = "lblPagosProveedores";
            this.lblPagosProveedores.Size = new System.Drawing.Size(22, 17);
            this.lblPagosProveedores.TabIndex = 76;
            this.lblPagosProveedores.Text = "@";
            // 
            // InformesEmpresaWF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1099, 482);
            this.Controls.Add(this.lblPagosProveedores);
            this.Controls.Add(this.lblTotalCompras);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblCajaVentas);
            this.Controls.Add(this.lblTotalVentas);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnPlanesCerrados);
            this.Controls.Add(this.btnPlanesAbiertos);
            this.Controls.Add(this.btnCobroHonorarios);
            this.Controls.Add(this.btnPlanesGenerados);
            this.Controls.Add(this.chartPagosRecibidos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvPagosRecibidos);
            this.Controls.Add(this.dgvVencimientos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InformesEmpresaWF";
            this.Text = "InformesEmpresaWF";
            this.Load += new System.EventHandler(this.InformesEmpresaWF_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVencimientos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPagosRecibidos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartPagosRecibidos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvVencimientos;
        private System.Windows.Forms.DataGridViewTextBoxColumn idEmpresa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Empresa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaVencimiento;
        private System.Windows.Forms.DataGridView dgvPagosRecibidos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartPagosRecibidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Año;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mes;
        private System.Windows.Forms.DataGridViewTextBoxColumn MontoTotal;
        private System.Windows.Forms.DataGridViewButtonColumn Ver;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnPlanesCerrados;
        private System.Windows.Forms.Button btnPlanesAbiertos;
        private System.Windows.Forms.Button btnCobroHonorarios;
        private System.Windows.Forms.Button btnPlanesGenerados;
        private System.Windows.Forms.Label lblTotalVentas;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblCajaVentas;
        private System.Windows.Forms.Label lblTotalCompras;
        private System.Windows.Forms.Label lblPagosProveedores;
    }
}