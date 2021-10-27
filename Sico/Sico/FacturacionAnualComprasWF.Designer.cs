namespace Sico
{
    partial class FacturacionAnualComprasWF
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.dgvComprasAnuales = new System.Windows.Forms.DataGridView();
            this.Periodo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Monto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Neto10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Neto21 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Neto27 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Iva10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Iva21 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Iva27 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PercepIngBrutos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NoGravado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PercepIva = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.PanelBotones = new System.Windows.Forms.Panel();
            this.btnPdf = new System.Windows.Forms.Button();
            this.btnExcel = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComprasAnuales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.PanelBotones.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvComprasAnuales
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvComprasAnuales.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvComprasAnuales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvComprasAnuales.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Periodo,
            this.Monto,
            this.Total1,
            this.Total2,
            this.Total3,
            this.Neto10,
            this.Neto21,
            this.Neto27,
            this.Iva10,
            this.Iva21,
            this.Iva27,
            this.PercepIngBrutos,
            this.NoGravado,
            this.PercepIva});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvComprasAnuales.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvComprasAnuales.EnableHeadersVisualStyles = false;
            this.dgvComprasAnuales.Location = new System.Drawing.Point(12, 45);
            this.dgvComprasAnuales.Name = "dgvComprasAnuales";
            this.dgvComprasAnuales.RowHeadersVisible = false;
            this.dgvComprasAnuales.Size = new System.Drawing.Size(523, 385);
            this.dgvComprasAnuales.TabIndex = 79;
            this.dgvComprasAnuales.Visible = false;
            // 
            // Periodo
            // 
            this.Periodo.HeaderText = "Periodo";
            this.Periodo.Name = "Periodo";
            this.Periodo.Width = 120;
            // 
            // Monto
            // 
            this.Monto.HeaderText = "Monto Total";
            this.Monto.Name = "Monto";
            // 
            // Total1
            // 
            this.Total1.HeaderText = "Total1";
            this.Total1.Name = "Total1";
            // 
            // Total2
            // 
            this.Total2.HeaderText = "Total2";
            this.Total2.Name = "Total2";
            // 
            // Total3
            // 
            this.Total3.HeaderText = "Total3";
            this.Total3.Name = "Total3";
            // 
            // Neto10
            // 
            this.Neto10.HeaderText = "Neto10";
            this.Neto10.Name = "Neto10";
            // 
            // Neto21
            // 
            this.Neto21.HeaderText = "Neto21";
            this.Neto21.Name = "Neto21";
            // 
            // Neto27
            // 
            this.Neto27.HeaderText = "Neto27";
            this.Neto27.Name = "Neto27";
            // 
            // Iva10
            // 
            this.Iva10.HeaderText = "Iva10";
            this.Iva10.Name = "Iva10";
            // 
            // Iva21
            // 
            this.Iva21.HeaderText = "Iva21";
            this.Iva21.Name = "Iva21";
            // 
            // Iva27
            // 
            this.Iva27.HeaderText = "Iva27";
            this.Iva27.Name = "Iva27";
            // 
            // PercepIngBrutos
            // 
            this.PercepIngBrutos.HeaderText = "Percepción Ingresos Brutos";
            this.PercepIngBrutos.Name = "PercepIngBrutos";
            this.PercepIngBrutos.Width = 120;
            // 
            // NoGravado
            // 
            this.NoGravado.HeaderText = "No Gravado";
            this.NoGravado.Name = "NoGravado";
            // 
            // PercepIva
            // 
            this.PercepIva.HeaderText = "Percepción Iva";
            this.PercepIva.Name = "PercepIva";
            // 
            // chart1
            // 
            chartArea2.AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea2.AxisY.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(560, 45);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.EarthTones;
            this.chart1.Size = new System.Drawing.Size(527, 385);
            this.chart1.TabIndex = 166;
            this.chart1.Text = "chart1";
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // PanelBotones
            // 
            this.PanelBotones.Controls.Add(this.btnPdf);
            this.PanelBotones.Controls.Add(this.btnExcel);
            this.PanelBotones.Location = new System.Drawing.Point(194, 440);
            this.PanelBotones.Name = "PanelBotones";
            this.PanelBotones.Size = new System.Drawing.Size(140, 40);
            this.PanelBotones.TabIndex = 167;
            this.PanelBotones.Visible = false;
            // 
            // btnPdf
            // 
            this.btnPdf.BackColor = System.Drawing.SystemColors.Control;
            this.btnPdf.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen;
            this.btnPdf.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPdf.ForeColor = System.Drawing.Color.White;
            this.btnPdf.Image = global::Sico.Properties.Resources.pdf1;
            this.btnPdf.Location = new System.Drawing.Point(19, 7);
            this.btnPdf.Name = "btnPdf";
            this.btnPdf.Size = new System.Drawing.Size(36, 28);
            this.btnPdf.TabIndex = 162;
            this.btnPdf.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnPdf.UseVisualStyleBackColor = false;
            this.btnPdf.Click += new System.EventHandler(this.btnPdf_Click);
            // 
            // btnExcel
            // 
            this.btnExcel.BackColor = System.Drawing.SystemColors.Control;
            this.btnExcel.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen;
            this.btnExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcel.ForeColor = System.Drawing.Color.White;
            this.btnExcel.Image = global::Sico.Properties.Resources.excel;
            this.btnExcel.Location = new System.Drawing.Point(80, 7);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(36, 28);
            this.btnExcel.TabIndex = 160;
            this.btnExcel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnExcel.UseVisualStyleBackColor = false;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.SteelBlue;
            this.label3.Location = new System.Drawing.Point(430, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(249, 20);
            this.label3.TabIndex = 168;
            this.label3.Text = "I.V.A. Compras Facturación Anual";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(153, 350);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(235, 23);
            this.progressBar1.TabIndex = 169;
            this.progressBar1.Value = 50;
            this.progressBar1.Visible = false;
            // 
            // FacturacionAnualComprasWF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1099, 482);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PanelBotones);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.dgvComprasAnuales);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FacturacionAnualComprasWF";
            this.Text = "FacturacionAnualComprasWF";
            this.Load += new System.EventHandler(this.FacturacionAnualComprasWF_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvComprasAnuales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.PanelBotones.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvComprasAnuales;
        private System.Windows.Forms.DataGridViewTextBoxColumn Periodo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Monto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Neto10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Neto21;
        private System.Windows.Forms.DataGridViewTextBoxColumn Neto27;
        private System.Windows.Forms.DataGridViewTextBoxColumn Iva10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Iva21;
        private System.Windows.Forms.DataGridViewTextBoxColumn Iva27;
        private System.Windows.Forms.DataGridViewTextBoxColumn PercepIngBrutos;
        private System.Windows.Forms.DataGridViewTextBoxColumn NoGravado;
        private System.Windows.Forms.DataGridViewTextBoxColumn PercepIva;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Panel PanelBotones;
        private System.Windows.Forms.Button btnPdf;
        private System.Windows.Forms.Button btnExcel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}