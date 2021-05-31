namespace Sico
{
    partial class PlanDeHonorariosWF
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
            this.dgvPlanesHonorarios = new System.Windows.Forms.DataGridView();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.PanelRegistroEmpresa = new System.Windows.Forms.Panel();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.dtFechaDesde = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.lblRegistroPlan = new System.Windows.Forms.Label();
            this.txtNombreRazonSocial = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtFechaHasta = new System.Windows.Forms.DateTimePicker();
            this.label15 = new System.Windows.Forms.Label();
            this.txtMontoMensual = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMontoTotal = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.idPlan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaDesde = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaHasta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MontoTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ver = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlanesHonorarios)).BeginInit();
            this.PanelRegistroEmpresa.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvPlanesHonorarios
            // 
            this.dgvPlanesHonorarios.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPlanesHonorarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPlanesHonorarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPlanesHonorarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idPlan,
            this.Descripcion,
            this.FechaDesde,
            this.FechaHasta,
            this.MontoTotal,
            this.Estado,
            this.Ver});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPlanesHonorarios.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvPlanesHonorarios.EnableHeadersVisualStyles = false;
            this.dgvPlanesHonorarios.Location = new System.Drawing.Point(8, 71);
            this.dgvPlanesHonorarios.Name = "dgvPlanesHonorarios";
            this.dgvPlanesHonorarios.RowHeadersVisible = false;
            this.dgvPlanesHonorarios.Size = new System.Drawing.Size(728, 369);
            this.dgvPlanesHonorarios.TabIndex = 65;
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.Color.SteelBlue;
            this.btnNuevo.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen;
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.ForeColor = System.Drawing.Color.White;
            this.btnNuevo.Location = new System.Drawing.Point(18, 445);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(77, 28);
            this.btnNuevo.TabIndex = 64;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = false;
            // 
            // PanelRegistroEmpresa
            // 
            this.PanelRegistroEmpresa.BackColor = System.Drawing.Color.Gainsboro;
            this.PanelRegistroEmpresa.Controls.Add(this.progressBar1);
            this.PanelRegistroEmpresa.Controls.Add(this.label5);
            this.PanelRegistroEmpresa.Controls.Add(this.textBox1);
            this.PanelRegistroEmpresa.Controls.Add(this.label4);
            this.PanelRegistroEmpresa.Controls.Add(this.txtMontoTotal);
            this.PanelRegistroEmpresa.Controls.Add(this.label15);
            this.PanelRegistroEmpresa.Controls.Add(this.txtMontoMensual);
            this.PanelRegistroEmpresa.Controls.Add(this.label1);
            this.PanelRegistroEmpresa.Controls.Add(this.dtFechaHasta);
            this.PanelRegistroEmpresa.Controls.Add(this.btnGuardar);
            this.PanelRegistroEmpresa.Controls.Add(this.label14);
            this.PanelRegistroEmpresa.Controls.Add(this.dtFechaDesde);
            this.PanelRegistroEmpresa.Controls.Add(this.label3);
            this.PanelRegistroEmpresa.Controls.Add(this.lblRegistroPlan);
            this.PanelRegistroEmpresa.Controls.Add(this.txtNombreRazonSocial);
            this.PanelRegistroEmpresa.Location = new System.Drawing.Point(752, 71);
            this.PanelRegistroEmpresa.Name = "PanelRegistroEmpresa";
            this.PanelRegistroEmpresa.Size = new System.Drawing.Size(339, 400);
            this.PanelRegistroEmpresa.TabIndex = 63;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(71, 327);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(235, 23);
            this.progressBar1.TabIndex = 57;
            this.progressBar1.Value = 50;
            this.progressBar1.Visible = false;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.SteelBlue;
            this.btnGuardar.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(36, 356);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(289, 38);
            this.btnGuardar.TabIndex = 56;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(35, 106);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(83, 15);
            this.label14.TabIndex = 37;
            this.label14.Text = "Fecha Desde:";
            // 
            // dtFechaDesde
            // 
            this.dtFechaDesde.Location = new System.Drawing.Point(123, 102);
            this.dtFechaDesde.Name = "dtFechaDesde";
            this.dtFechaDesde.Size = new System.Drawing.Size(172, 20);
            this.dtFechaDesde.TabIndex = 36;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(30, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 15);
            this.label3.TabIndex = 31;
            this.label3.Text = "Descripción(*):";
            // 
            // lblRegistroPlan
            // 
            this.lblRegistroPlan.AutoSize = true;
            this.lblRegistroPlan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistroPlan.ForeColor = System.Drawing.Color.Black;
            this.lblRegistroPlan.Location = new System.Drawing.Point(14, 11);
            this.lblRegistroPlan.Name = "lblRegistroPlan";
            this.lblRegistroPlan.Size = new System.Drawing.Size(129, 17);
            this.lblRegistroPlan.TabIndex = 29;
            this.lblRegistroPlan.Text = "Registro de Plan";
            // 
            // txtNombreRazonSocial
            // 
            this.txtNombreRazonSocial.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNombreRazonSocial.Location = new System.Drawing.Point(124, 37);
            this.txtNombreRazonSocial.Multiline = true;
            this.txtNombreRazonSocial.Name = "txtNombreRazonSocial";
            this.txtNombreRazonSocial.Size = new System.Drawing.Size(172, 46);
            this.txtNombreRazonSocial.TabIndex = 30;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(4, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(238, 20);
            this.label2.TabIndex = 62;
            this.label2.Text = "Listado de planes de Honorarios";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(39, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 15);
            this.label1.TabIndex = 58;
            this.label1.Text = "Fecha Hasta:";
            // 
            // dtFechaHasta
            // 
            this.dtFechaHasta.Location = new System.Drawing.Point(123, 145);
            this.dtFechaHasta.Name = "dtFechaHasta";
            this.dtFechaHasta.Size = new System.Drawing.Size(172, 20);
            this.dtFechaHasta.TabIndex = 57;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(9, 191);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(109, 15);
            this.label15.TabIndex = 60;
            this.label15.Text = "Monto Mensual(*):";
            // 
            // txtMontoMensual
            // 
            this.txtMontoMensual.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtMontoMensual.Location = new System.Drawing.Point(123, 190);
            this.txtMontoMensual.Name = "txtMontoMensual";
            this.txtMontoMensual.Size = new System.Drawing.Size(172, 20);
            this.txtMontoMensual.TabIndex = 59;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(43, 237);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 15);
            this.label4.TabIndex = 62;
            this.label4.Text = "Monto Total:";
            // 
            // txtMontoTotal
            // 
            this.txtMontoTotal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtMontoTotal.Enabled = false;
            this.txtMontoTotal.Location = new System.Drawing.Point(123, 236);
            this.txtMontoTotal.Name = "txtMontoTotal";
            this.txtMontoTotal.Size = new System.Drawing.Size(172, 20);
            this.txtMontoTotal.TabIndex = 61;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(30, 298);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 15);
            this.label5.TabIndex = 64;
            this.label5.Text = "Observaciones:";
            // 
            // textBox1
            // 
            this.textBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBox1.Location = new System.Drawing.Point(123, 281);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(172, 46);
            this.textBox1.TabIndex = 63;
            // 
            // idPlan
            // 
            this.idPlan.HeaderText = "id Plan";
            this.idPlan.Name = "idPlan";
            this.idPlan.Width = 80;
            // 
            // Descripcion
            // 
            this.Descripcion.HeaderText = "Descripción";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.Width = 190;
            // 
            // FechaDesde
            // 
            this.FechaDesde.HeaderText = "Fecha Desde";
            this.FechaDesde.Name = "FechaDesde";
            // 
            // FechaHasta
            // 
            this.FechaHasta.HeaderText = "Fecha Hasta";
            this.FechaHasta.Name = "FechaHasta";
            // 
            // MontoTotal
            // 
            this.MontoTotal.HeaderText = "Monto Total";
            this.MontoTotal.Name = "MontoTotal";
            this.MontoTotal.Width = 110;
            // 
            // Estado
            // 
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Estado.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Estado.Width = 80;
            // 
            // Ver
            // 
            this.Ver.HeaderText = "Ver";
            this.Ver.Name = "Ver";
            this.Ver.Width = 50;
            // 
            // PlanDeHonorariosWF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1099, 482);
            this.Controls.Add(this.dgvPlanesHonorarios);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.PanelRegistroEmpresa);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PlanDeHonorariosWF";
            this.Text = "PlanDeHonorariosWF";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlanesHonorarios)).EndInit();
            this.PanelRegistroEmpresa.ResumeLayout(false);
            this.PanelRegistroEmpresa.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPlanesHonorarios;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Panel PanelRegistroEmpresa;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DateTimePicker dtFechaDesde;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblRegistroPlan;
        private System.Windows.Forms.TextBox txtNombreRazonSocial;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtFechaHasta;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtMontoMensual;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMontoTotal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPlan;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaDesde;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaHasta;
        private System.Windows.Forms.DataGridViewTextBoxColumn MontoTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.DataGridViewButtonColumn Ver;
    }
}