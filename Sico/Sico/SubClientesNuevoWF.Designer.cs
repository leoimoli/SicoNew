namespace Sico
{
    partial class SubClientesNuevoWF
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.dgvSubClientes = new System.Windows.Forms.DataGridView();
            this.idSub = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RazonSocial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Seleccionar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.txtDni = new System.Windows.Forms.MaskedTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtRazonSocial = new System.Windows.Forms.TextBox();
            this.btnCrearSubCliente = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnActualizarCombo = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubClientes)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnCerrar);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(374, 32);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 20);
            this.label2.TabIndex = 77;
            this.label2.Text = "Clientes";
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Image = global::Sico.Properties.Resources.cancelar2;
            this.btnCerrar.Location = new System.Drawing.Point(343, 3);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(25, 25);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar.TabIndex = 76;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // dgvSubClientes
            // 
            this.dgvSubClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSubClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idSub,
            this.Dni,
            this.RazonSocial,
            this.Seleccionar});
            this.dgvSubClientes.Location = new System.Drawing.Point(4, 115);
            this.dgvSubClientes.Name = "dgvSubClientes";
            this.dgvSubClientes.RowHeadersVisible = false;
            this.dgvSubClientes.Size = new System.Drawing.Size(364, 233);
            this.dgvSubClientes.TabIndex = 1;
            this.dgvSubClientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSubClientes_CellClick);
            this.dgvSubClientes.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgvSubClientes_CellPainting);
            // 
            // idSub
            // 
            this.idSub.HeaderText = "idSub";
            this.idSub.Name = "idSub";
            this.idSub.Visible = false;
            // 
            // Dni
            // 
            this.Dni.HeaderText = "Dni";
            this.Dni.Name = "Dni";
            this.Dni.Width = 110;
            // 
            // RazonSocial
            // 
            this.RazonSocial.HeaderText = "Razón Social";
            this.RazonSocial.Name = "RazonSocial";
            this.RazonSocial.Width = 180;
            // 
            // Seleccionar
            // 
            this.Seleccionar.HeaderText = "Seleccionar";
            this.Seleccionar.Name = "Seleccionar";
            this.Seleccionar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Seleccionar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Seleccionar.Width = 70;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SteelBlue;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(141, 353);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(65, 40);
            this.button1.TabIndex = 160;
            this.button1.Text = "Volver";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(7, 89);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(82, 20);
            this.txtDni.TabIndex = 162;
            this.txtDni.TextChanged += new System.EventHandler(this.txtDni_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(4, 71);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(26, 15);
            this.label10.TabIndex = 161;
            this.label10.Text = "Dni";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(149, 71);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(80, 15);
            this.label11.TabIndex = 164;
            this.label11.Text = "Razón Social";
            // 
            // txtRazonSocial
            // 
            this.txtRazonSocial.Location = new System.Drawing.Point(152, 89);
            this.txtRazonSocial.Name = "txtRazonSocial";
            this.txtRazonSocial.Size = new System.Drawing.Size(216, 20);
            this.txtRazonSocial.TabIndex = 163;
            // 
            // btnCrearSubCliente
            // 
            this.btnCrearSubCliente.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnCrearSubCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearSubCliente.Image = global::Sico.Properties.Resources.mas__2_;
            this.btnCrearSubCliente.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCrearSubCliente.Location = new System.Drawing.Point(3, 0);
            this.btnCrearSubCliente.Name = "btnCrearSubCliente";
            this.btnCrearSubCliente.Size = new System.Drawing.Size(40, 32);
            this.btnCrearSubCliente.TabIndex = 165;
            this.btnCrearSubCliente.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip1.SetToolTip(this.btnCrearSubCliente, "Registrar Cliente");
            this.btnCrearSubCliente.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnActualizarCombo);
            this.panel2.Controls.Add(this.btnCrearSubCliente);
            this.panel2.Location = new System.Drawing.Point(0, 35);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(374, 33);
            this.panel2.TabIndex = 166;
            // 
            // btnActualizarCombo
            // 
            this.btnActualizarCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizarCombo.Image = global::Sico.Properties.Resources.actualizado;
            this.btnActualizarCombo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnActualizarCombo.Location = new System.Drawing.Point(49, 0);
            this.btnActualizarCombo.Name = "btnActualizarCombo";
            this.btnActualizarCombo.Size = new System.Drawing.Size(40, 32);
            this.btnActualizarCombo.TabIndex = 166;
            this.btnActualizarCombo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip1.SetToolTip(this.btnActualizarCombo, "Actualizar Grilla");
            this.btnActualizarCombo.UseVisualStyleBackColor = true;
            this.btnActualizarCombo.Click += new System.EventHandler(this.btnActualizarCombo_Click);
            // 
            // SubClientesNuevoWF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 394);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtRazonSocial);
            this.Controls.Add(this.txtDni);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvSubClientes);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SubClientesNuevoWF";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SubClientesNuevoWF";
            this.Load += new System.EventHandler(this.SubClientesNuevoWF_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubClientes)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvSubClientes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MaskedTextBox txtDni;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtRazonSocial;
        private System.Windows.Forms.Button btnCrearSubCliente;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnActualizarCombo;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idSub;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dni;
        private System.Windows.Forms.DataGridViewTextBoxColumn RazonSocial;
        private System.Windows.Forms.DataGridViewButtonColumn Seleccionar;
    }
}