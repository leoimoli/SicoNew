namespace Sico
{
    partial class CalendarioWF
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
            this.grbPadre = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.grbMeses = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSiguenteMes = new System.Windows.Forms.Button();
            this.btnAnteriorMes = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnVolver = new System.Windows.Forms.Button();
            this.grbPadre.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.grbMeses.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbPadre
            // 
            this.grbPadre.Controls.Add(this.dataGridView1);
            this.grbPadre.Controls.Add(this.grbMeses);
            this.grbPadre.Location = new System.Drawing.Point(7, 8);
            this.grbPadre.Name = "grbPadre";
            this.grbPadre.Size = new System.Drawing.Size(395, 350);
            this.grbPadre.TabIndex = 1;
            this.grbPadre.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(8, 72);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 50;
            this.dataGridView1.Size = new System.Drawing.Size(373, 264);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ClickBoton);
            this.dataGridView1.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dataGridView1_CellPainting);
            // 
            // grbMeses
            // 
            this.grbMeses.Controls.Add(this.btnSiguenteMes);
            this.grbMeses.Controls.Add(this.btnAnteriorMes);
            this.grbMeses.Controls.Add(this.label1);
            this.grbMeses.Location = new System.Drawing.Point(21, 12);
            this.grbMeses.Name = "grbMeses";
            this.grbMeses.Size = new System.Drawing.Size(348, 54);
            this.grbMeses.TabIndex = 1;
            this.grbMeses.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(111, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mayo";
            // 
            // btnSiguenteMes
            // 
            this.btnSiguenteMes.Image = global::Sico.Properties.Resources.proximo;
            this.btnSiguenteMes.Location = new System.Drawing.Point(294, 10);
            this.btnSiguenteMes.Name = "btnSiguenteMes";
            this.btnSiguenteMes.Size = new System.Drawing.Size(48, 40);
            this.btnSiguenteMes.TabIndex = 2;
            this.toolTip1.SetToolTip(this.btnSiguenteMes, "Siguiente");
            this.btnSiguenteMes.UseVisualStyleBackColor = true;
            this.btnSiguenteMes.Click += new System.EventHandler(this.btnSiguenteMes_Click);
            // 
            // btnAnteriorMes
            // 
            this.btnAnteriorMes.Image = global::Sico.Properties.Resources.espalda;
            this.btnAnteriorMes.Location = new System.Drawing.Point(6, 10);
            this.btnAnteriorMes.Name = "btnAnteriorMes";
            this.btnAnteriorMes.Size = new System.Drawing.Size(48, 40);
            this.btnAnteriorMes.TabIndex = 1;
            this.toolTip1.SetToolTip(this.btnAnteriorMes, "Anterior");
            this.btnAnteriorMes.UseVisualStyleBackColor = true;
            this.btnAnteriorMes.Click += new System.EventHandler(this.btnAnteriorMes_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(407, 84);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(109, 264);
            this.listBox1.TabIndex = 2;
            this.listBox1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(407, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Clientes Asociados";
            this.label2.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(439, 351);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Total:";
            this.label3.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(476, 351);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "label4";
            this.label4.Visible = false;
            // 
            // btnVolver
            // 
            this.btnVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.Image = global::Sico.Properties.Resources.flecha_curva_hacia_atras_a_la_izquierda;
            this.btnVolver.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnVolver.Location = new System.Drawing.Point(218, 364);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(80, 51);
            this.btnVolver.TabIndex = 55;
            this.btnVolver.Text = "Volver";
            this.btnVolver.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // CalendarioWF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 416);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.grbPadre);
            this.Name = "CalendarioWF";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vencimientos";
            this.Load += new System.EventHandler(this.CalendarioWF_Load);
            this.grbPadre.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.grbMeses.ResumeLayout(false);
            this.grbMeses.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbPadre;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox grbMeses;
        private System.Windows.Forms.Button btnSiguenteMes;
        private System.Windows.Forms.Button btnAnteriorMes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnVolver;
    }
}