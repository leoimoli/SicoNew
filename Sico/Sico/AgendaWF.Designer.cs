namespace Sico
{
    partial class AgendaWF
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
            this.btnEditar = new System.Windows.Forms.Button();
            this.dgvAgenda = new System.Windows.Forms.DataGridView();
            this.idPlan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaDesde = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Finalizar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.PanelRegistroPlan = new System.Windows.Forms.Panel();
            this.chcEmail = new System.Windows.Forms.CheckBox();
            this.chcUsuarios = new System.Windows.Forms.CheckBox();
            this.chcPersonal = new System.Windows.Forms.CheckBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.dtFecha = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.lblRegistroAgenda = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lbllistado = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAgenda)).BeginInit();
            this.PanelRegistroPlan.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.SteelBlue;
            this.btnEditar.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.Color.White;
            this.btnEditar.Location = new System.Drawing.Point(114, 434);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(77, 28);
            this.btnEditar.TabIndex = 71;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Visible = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // dgvAgenda
            // 
            this.dgvAgenda.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAgenda.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAgenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAgenda.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idPlan,
            this.FechaDesde,
            this.Descripcion,
            this.Finalizar});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAgenda.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAgenda.EnableHeadersVisualStyles = false;
            this.dgvAgenda.Location = new System.Drawing.Point(10, 59);
            this.dgvAgenda.Name = "dgvAgenda";
            this.dgvAgenda.ReadOnly = true;
            this.dgvAgenda.RowHeadersVisible = false;
            this.dgvAgenda.Size = new System.Drawing.Size(728, 369);
            this.dgvAgenda.TabIndex = 70;
            this.dgvAgenda.Visible = false;
            this.dgvAgenda.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAgenda_CellClick);
            this.dgvAgenda.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgvAgenda_CellPainting);
            // 
            // idPlan
            // 
            this.idPlan.HeaderText = "id Agenda";
            this.idPlan.Name = "idPlan";
            this.idPlan.ReadOnly = true;
            // 
            // FechaDesde
            // 
            this.FechaDesde.HeaderText = "Fecha";
            this.FechaDesde.Name = "FechaDesde";
            this.FechaDesde.ReadOnly = true;
            this.FechaDesde.Width = 150;
            // 
            // Descripcion
            // 
            this.Descripcion.HeaderText = "Recordatorio";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            this.Descripcion.Width = 400;
            // 
            // Finalizar
            // 
            this.Finalizar.HeaderText = "Finalizar";
            this.Finalizar.Name = "Finalizar";
            this.Finalizar.ReadOnly = true;
            this.Finalizar.Width = 70;
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.Color.SteelBlue;
            this.btnNuevo.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen;
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.ForeColor = System.Drawing.Color.White;
            this.btnNuevo.Location = new System.Drawing.Point(20, 433);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(77, 28);
            this.btnNuevo.TabIndex = 69;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // PanelRegistroPlan
            // 
            this.PanelRegistroPlan.BackColor = System.Drawing.Color.Gainsboro;
            this.PanelRegistroPlan.Controls.Add(this.chcEmail);
            this.PanelRegistroPlan.Controls.Add(this.chcUsuarios);
            this.PanelRegistroPlan.Controls.Add(this.chcPersonal);
            this.PanelRegistroPlan.Controls.Add(this.progressBar1);
            this.PanelRegistroPlan.Controls.Add(this.btnGuardar);
            this.PanelRegistroPlan.Controls.Add(this.label14);
            this.PanelRegistroPlan.Controls.Add(this.dtFecha);
            this.PanelRegistroPlan.Controls.Add(this.label3);
            this.PanelRegistroPlan.Controls.Add(this.lblRegistroAgenda);
            this.PanelRegistroPlan.Controls.Add(this.txtDescripcion);
            this.PanelRegistroPlan.Enabled = false;
            this.PanelRegistroPlan.Location = new System.Drawing.Point(743, 59);
            this.PanelRegistroPlan.Name = "PanelRegistroPlan";
            this.PanelRegistroPlan.Size = new System.Drawing.Size(339, 400);
            this.PanelRegistroPlan.TabIndex = 68;
            // 
            // chcEmail
            // 
            this.chcEmail.AutoSize = true;
            this.chcEmail.ForeColor = System.Drawing.Color.Black;
            this.chcEmail.Location = new System.Drawing.Point(105, 293);
            this.chcEmail.Name = "chcEmail";
            this.chcEmail.Size = new System.Drawing.Size(124, 17);
            this.chcEmail.TabIndex = 60;
            this.chcEmail.Text = "Notificarme por email";
            this.chcEmail.UseVisualStyleBackColor = true;
            // 
            // chcUsuarios
            // 
            this.chcUsuarios.AutoSize = true;
            this.chcUsuarios.ForeColor = System.Drawing.Color.Black;
            this.chcUsuarios.Location = new System.Drawing.Point(186, 52);
            this.chcUsuarios.Name = "chcUsuarios";
            this.chcUsuarios.Size = new System.Drawing.Size(120, 17);
            this.chcUsuarios.TabIndex = 59;
            this.chcUsuarios.Text = "Usuarios de sistema";
            this.chcUsuarios.UseVisualStyleBackColor = true;
            this.chcUsuarios.CheckedChanged += new System.EventHandler(this.chcUsuarios_CheckedChanged);
            // 
            // chcPersonal
            // 
            this.chcPersonal.AutoSize = true;
            this.chcPersonal.Checked = true;
            this.chcPersonal.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chcPersonal.ForeColor = System.Drawing.Color.Black;
            this.chcPersonal.Location = new System.Drawing.Point(105, 52);
            this.chcPersonal.Name = "chcPersonal";
            this.chcPersonal.Size = new System.Drawing.Size(67, 17);
            this.chcPersonal.TabIndex = 58;
            this.chcPersonal.Text = "Personal";
            this.chcPersonal.UseVisualStyleBackColor = true;
            this.chcPersonal.CheckedChanged += new System.EventHandler(this.chcPersonal_CheckedChanged);
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
            this.btnGuardar.TabIndex = 6;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(45, 91);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(57, 15);
            this.label14.TabIndex = 37;
            this.label14.Text = "Fecha(*):";
            // 
            // dtFecha
            // 
            this.dtFecha.Location = new System.Drawing.Point(104, 91);
            this.dtFecha.Name = "dtFecha";
            this.dtFecha.Size = new System.Drawing.Size(202, 20);
            this.dtFecha.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(14, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 15);
            this.label3.TabIndex = 31;
            this.label3.Text = "Descripción(*):";
            // 
            // lblRegistroAgenda
            // 
            this.lblRegistroAgenda.AutoSize = true;
            this.lblRegistroAgenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistroAgenda.ForeColor = System.Drawing.Color.Black;
            this.lblRegistroAgenda.Location = new System.Drawing.Point(14, 11);
            this.lblRegistroAgenda.Name = "lblRegistroAgenda";
            this.lblRegistroAgenda.Size = new System.Drawing.Size(152, 17);
            this.lblRegistroAgenda.TabIndex = 29;
            this.lblRegistroAgenda.Text = "Registro de Agenda";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDescripcion.Location = new System.Drawing.Point(105, 131);
            this.txtDescripcion.MaxLength = 200;
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(201, 136);
            this.txtDescripcion.TabIndex = 0;
            // 
            // lbllistado
            // 
            this.lbllistado.AutoSize = true;
            this.lbllistado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbllistado.ForeColor = System.Drawing.Color.Black;
            this.lbllistado.Location = new System.Drawing.Point(6, 21);
            this.lbllistado.Name = "lbllistado";
            this.lbllistado.Size = new System.Drawing.Size(170, 20);
            this.lbllistado.TabIndex = 67;
            this.lbllistado.Text = "Agenda de pendientes";
            this.lbllistado.Visible = false;
            // 
            // AgendaWF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1099, 482);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.dgvAgenda);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.PanelRegistroPlan);
            this.Controls.Add(this.lbllistado);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AgendaWF";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AgendaWF";
            this.Load += new System.EventHandler(this.AgendaWF_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAgenda)).EndInit();
            this.PanelRegistroPlan.ResumeLayout(false);
            this.PanelRegistroPlan.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.DataGridView dgvAgenda;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Panel PanelRegistroPlan;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DateTimePicker dtFecha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblRegistroAgenda;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lbllistado;
        private System.Windows.Forms.CheckBox chcUsuarios;
        private System.Windows.Forms.CheckBox chcPersonal;
        private System.Windows.Forms.CheckBox chcEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPlan;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaDesde;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewButtonColumn Finalizar;
    }
}