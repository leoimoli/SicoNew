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
            this.grbPadre = new System.Windows.Forms.GroupBox();
            this.grbMeses = new System.Windows.Forms.GroupBox();
            this.btnSiguenteMes = new System.Windows.Forms.Button();
            this.btnAnteriorMes = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.grbPadre.SuspendLayout();
            this.grbMeses.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // grbPadre
            // 
            this.grbPadre.Controls.Add(this.dataGridView1);
            this.grbPadre.Controls.Add(this.grbMeses);
            this.grbPadre.Location = new System.Drawing.Point(12, 12);
            this.grbPadre.Name = "grbPadre";
            this.grbPadre.Size = new System.Drawing.Size(419, 368);
            this.grbPadre.TabIndex = 1;
            this.grbPadre.TabStop = false;
            // 
            // grbMeses
            // 
            this.grbMeses.Controls.Add(this.btnSiguenteMes);
            this.grbMeses.Controls.Add(this.btnAnteriorMes);
            this.grbMeses.Controls.Add(this.label1);
            this.grbMeses.Location = new System.Drawing.Point(31, 12);
            this.grbMeses.Name = "grbMeses";
            this.grbMeses.Size = new System.Drawing.Size(348, 54);
            this.grbMeses.TabIndex = 1;
            this.grbMeses.TabStop = false;
            // 
            // btnSiguenteMes
            // 
            this.btnSiguenteMes.Location = new System.Drawing.Point(287, 12);
            this.btnSiguenteMes.Name = "btnSiguenteMes";
            this.btnSiguenteMes.Size = new System.Drawing.Size(55, 36);
            this.btnSiguenteMes.TabIndex = 2;
            this.btnSiguenteMes.Text = "button2";
            this.btnSiguenteMes.UseVisualStyleBackColor = true;
            // 
            // btnAnteriorMes
            // 
            this.btnAnteriorMes.Location = new System.Drawing.Point(6, 12);
            this.btnAnteriorMes.Name = "btnAnteriorMes";
            this.btnAnteriorMes.Size = new System.Drawing.Size(55, 36);
            this.btnAnteriorMes.TabIndex = 1;
            this.btnAnteriorMes.Text = "button1";
            this.btnAnteriorMes.UseVisualStyleBackColor = true;
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
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 72);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 50;
            this.dataGridView1.Size = new System.Drawing.Size(402, 264);
            this.dataGridView1.TabIndex = 2;
            // 
            // CalendarioWF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 392);
            this.Controls.Add(this.grbPadre);
            this.Name = "CalendarioWF";
            this.Text = "CalendarioWF";
            this.Load += new System.EventHandler(this.CalendarioWF_Load);
            this.grbPadre.ResumeLayout(false);
            this.grbMeses.ResumeLayout(false);
            this.grbMeses.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbPadre;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox grbMeses;
        private System.Windows.Forms.Button btnSiguenteMes;
        private System.Windows.Forms.Button btnAnteriorMes;
        private System.Windows.Forms.Label label1;
    }
}