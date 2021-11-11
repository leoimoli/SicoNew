namespace Sico
{
    partial class FacturacionAnualVentasWF
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvVentasAnuales = new System.Windows.Forms.DataGridView();
            this.PanelBotones = new System.Windows.Forms.Panel();
            this.btnPdf = new System.Windows.Forms.Button();
            this.btnExcel = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.Periodo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Monto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExentoIva = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Neto10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Neto21 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Neto27 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Iva10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Iva21 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Iva27 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentasAnuales)).BeginInit();
            this.PanelBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.SteelBlue;
            this.label3.Location = new System.Drawing.Point(413, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(236, 20);
            this.label3.TabIndex = 77;
            this.label3.Text = "I.V.A. Ventas Facturación Anual";
            // 
            // dgvVentasAnuales
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvVentasAnuales.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvVentasAnuales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVentasAnuales.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Periodo,
            this.Monto,
            this.ExentoIva,
            this.Total1,
            this.Total2,
            this.Total3,
            this.Neto10,
            this.Neto21,
            this.Neto27,
            this.Iva10,
            this.Iva21,
            this.Iva27});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvVentasAnuales.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvVentasAnuales.EnableHeadersVisualStyles = false;
            this.dgvVentasAnuales.Location = new System.Drawing.Point(12, 50);
            this.dgvVentasAnuales.Name = "dgvVentasAnuales";
            this.dgvVentasAnuales.RowHeadersVisible = false;
            this.dgvVentasAnuales.Size = new System.Drawing.Size(523, 385);
            this.dgvVentasAnuales.TabIndex = 78;
            this.dgvVentasAnuales.Visible = false;
            // 
            // PanelBotones
            // 
            this.PanelBotones.Controls.Add(this.btnPdf);
            this.PanelBotones.Controls.Add(this.btnExcel);
            this.PanelBotones.Location = new System.Drawing.Point(213, 441);
            this.PanelBotones.Name = "PanelBotones";
            this.PanelBotones.Size = new System.Drawing.Size(140, 40);
            this.PanelBotones.TabIndex = 164;
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
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(560, 50);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.EarthTones;
            this.chart1.Size = new System.Drawing.Size(527, 385);
            this.chart1.TabIndex = 165;
            this.chart1.Text = "chart1";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(146, 369);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(235, 23);
            this.progressBar1.TabIndex = 163;
            this.progressBar1.Value = 50;
            this.progressBar1.Visible = false;
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
            // ExentoIva
            // 
            this.ExentoIva.HeaderText = "Exento Iva";
            this.ExentoIva.Name = "ExentoIva";
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
            // FacturacionAnualVentasWF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1099, 482);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.PanelBotones);
            this.Controls.Add(this.dgvVentasAnuales);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FacturacionAnualVentasWF";
            this.Text = "FacturacionAnualVentasWF";
            this.Load += new System.EventHandler(this.FacturacionAnualVentasWF_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentasAnuales)).EndInit();
            this.PanelBotones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvVentasAnuales;
        private System.Windows.Forms.Panel PanelBotones;
        private System.Windows.Forms.Button btnPdf;
        private System.Windows.Forms.Button btnExcel;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Periodo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Monto;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExentoIva;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Neto10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Neto21;
        private System.Windows.Forms.DataGridViewTextBoxColumn Neto27;
        private System.Windows.Forms.DataGridViewTextBoxColumn Iva10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Iva21;
        private System.Windows.Forms.DataGridViewTextBoxColumn Iva27;
    }
}