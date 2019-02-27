namespace Sico
{
    partial class PericiaHistoriaWF
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnNuevaHistoria = new System.Windows.Forms.Button();
            this.dgvPericias = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.btnGuardarHistorial = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.dtFechaPericia = new System.Windows.Forms.DateTimePicker();
            this.btnCargarArchivo3 = new System.Windows.Forms.Button();
            this.btnCargarArchivo2 = new System.Windows.Forms.Button();
            this.btnCargarArchivo1 = new System.Windows.Forms.Button();
            this.lblArchivo3 = new System.Windows.Forms.Label();
            this.lbl2Archivo2 = new System.Windows.Forms.Label();
            this.lblArchivo1 = new System.Windows.Forms.Label();
            this.txtArchivo3 = new System.Windows.Forms.TextBox();
            this.txtArchivo2 = new System.Windows.Forms.TextBox();
            this.txtArchivo1 = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog3 = new System.Windows.Forms.OpenFileDialog();
            this.chcEmail = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPericias)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnNuevaHistoria);
            this.groupBox1.Controls.Add(this.dgvPericias);
            this.groupBox1.Location = new System.Drawing.Point(25, 72);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(880, 300);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Historial Pericia";
            // 
            // btnNuevaHistoria
            // 
            this.btnNuevaHistoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevaHistoria.Image = global::Sico.Properties.Resources.historial_medico__1_;
            this.btnNuevaHistoria.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnNuevaHistoria.Location = new System.Drawing.Point(775, 241);
            this.btnNuevaHistoria.Name = "btnNuevaHistoria";
            this.btnNuevaHistoria.Size = new System.Drawing.Size(80, 51);
            this.btnNuevaHistoria.TabIndex = 17;
            this.btnNuevaHistoria.Text = "Nuevo";
            this.btnNuevaHistoria.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnNuevaHistoria.UseVisualStyleBackColor = true;
            this.btnNuevaHistoria.Click += new System.EventHandler(this.btnNuevaHistoria_Click);
            // 
            // dgvPericias
            // 
            this.dgvPericias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPericias.Location = new System.Drawing.Point(15, 19);
            this.dgvPericias.Name = "dgvPericias";
            this.dgvPericias.Size = new System.Drawing.Size(850, 220);
            this.dgvPericias.TabIndex = 15;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chcEmail);
            this.groupBox2.Controls.Add(this.progressBar1);
            this.groupBox2.Controls.Add(this.lblMensaje);
            this.groupBox2.Controls.Add(this.btnGuardarHistorial);
            this.groupBox2.Controls.Add(this.btnLimpiar);
            this.groupBox2.Controls.Add(this.cmbEstado);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtDescripcion);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.dtFechaPericia);
            this.groupBox2.Controls.Add(this.btnCargarArchivo3);
            this.groupBox2.Controls.Add(this.btnCargarArchivo2);
            this.groupBox2.Controls.Add(this.btnCargarArchivo1);
            this.groupBox2.Controls.Add(this.lblArchivo3);
            this.groupBox2.Controls.Add(this.lbl2Archivo2);
            this.groupBox2.Controls.Add(this.lblArchivo1);
            this.groupBox2.Controls.Add(this.txtArchivo3);
            this.groupBox2.Controls.Add(this.txtArchivo2);
            this.groupBox2.Controls.Add(this.txtArchivo1);
            this.groupBox2.Location = new System.Drawing.Point(25, 376);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(880, 265);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Nuevo Historial";
            this.groupBox2.Visible = false;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(264, 116);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(330, 23);
            this.progressBar1.TabIndex = 86;
            this.progressBar1.Value = 50;
            this.progressBar1.Visible = false;
            // 
            // lblMensaje
            // 
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensaje.Location = new System.Drawing.Point(247, 168);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(64, 25);
            this.lblMensaje.TabIndex = 18;
            this.lblMensaje.Text = "label5";
            this.lblMensaje.Visible = false;
            // 
            // btnGuardarHistorial
            // 
            this.btnGuardarHistorial.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarHistorial.Image = global::Sico.Properties.Resources.copia_de_seguridad;
            this.btnGuardarHistorial.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnGuardarHistorial.Location = new System.Drawing.Point(785, 192);
            this.btnGuardarHistorial.Name = "btnGuardarHistorial";
            this.btnGuardarHistorial.Size = new System.Drawing.Size(80, 51);
            this.btnGuardarHistorial.TabIndex = 85;
            this.btnGuardarHistorial.Text = "Guardar";
            this.btnGuardarHistorial.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGuardarHistorial.UseVisualStyleBackColor = true;
            this.btnGuardarHistorial.Click += new System.EventHandler(this.btnGuardarHistorial_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Image = global::Sico.Properties.Resources.cancelar;
            this.btnLimpiar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnLimpiar.Location = new System.Drawing.Point(687, 191);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(80, 51);
            this.btnLimpiar.TabIndex = 84;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // cmbEstado
            // 
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Location = new System.Drawing.Point(109, 89);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(250, 21);
            this.cmbEstado.TabIndex = 83;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(45, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 20);
            this.label4.TabIndex = 82;
            this.label4.Text = "Fecha:";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(505, 19);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(350, 100);
            this.txtDescripcion.TabIndex = 80;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(413, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 20);
            this.label1.TabIndex = 49;
            this.label1.Text = "Descripción:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(45, 33);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(58, 20);
            this.label14.TabIndex = 47;
            this.label14.Text = "Fecha:";
            // 
            // dtFechaPericia
            // 
            this.dtFechaPericia.Location = new System.Drawing.Point(109, 31);
            this.dtFechaPericia.Name = "dtFechaPericia";
            this.dtFechaPericia.Size = new System.Drawing.Size(250, 20);
            this.dtFechaPericia.TabIndex = 46;
            // 
            // btnCargarArchivo3
            // 
            this.btnCargarArchivo3.BackColor = System.Drawing.Color.Transparent;
            this.btnCargarArchivo3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCargarArchivo3.Location = new System.Drawing.Point(541, 205);
            this.btnCargarArchivo3.Name = "btnCargarArchivo3";
            this.btnCargarArchivo3.Size = new System.Drawing.Size(45, 35);
            this.btnCargarArchivo3.TabIndex = 45;
            this.btnCargarArchivo3.UseVisualStyleBackColor = false;
            this.btnCargarArchivo3.Visible = false;
            this.btnCargarArchivo3.Click += new System.EventHandler(this.btnCargarArchivo3_Click);
            // 
            // btnCargarArchivo2
            // 
            this.btnCargarArchivo2.BackColor = System.Drawing.Color.Transparent;
            this.btnCargarArchivo2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCargarArchivo2.Location = new System.Drawing.Point(541, 164);
            this.btnCargarArchivo2.Name = "btnCargarArchivo2";
            this.btnCargarArchivo2.Size = new System.Drawing.Size(45, 35);
            this.btnCargarArchivo2.TabIndex = 44;
            this.btnCargarArchivo2.UseVisualStyleBackColor = false;
            this.btnCargarArchivo2.Visible = false;
            this.btnCargarArchivo2.Click += new System.EventHandler(this.btnCargarArchivo2_Click);
            // 
            // btnCargarArchivo1
            // 
            this.btnCargarArchivo1.BackColor = System.Drawing.Color.Transparent;
            this.btnCargarArchivo1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCargarArchivo1.Location = new System.Drawing.Point(541, 125);
            this.btnCargarArchivo1.Name = "btnCargarArchivo1";
            this.btnCargarArchivo1.Size = new System.Drawing.Size(45, 35);
            this.btnCargarArchivo1.TabIndex = 43;
            this.btnCargarArchivo1.UseVisualStyleBackColor = false;
            this.btnCargarArchivo1.Visible = false;
            this.btnCargarArchivo1.Click += new System.EventHandler(this.btnCargarArchivo1_Click);
            // 
            // lblArchivo3
            // 
            this.lblArchivo3.AutoSize = true;
            this.lblArchivo3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArchivo3.Location = new System.Drawing.Point(129, 213);
            this.lblArchivo3.Name = "lblArchivo3";
            this.lblArchivo3.Size = new System.Drawing.Size(129, 20);
            this.lblArchivo3.TabIndex = 42;
            this.lblArchivo3.Text = "Adjuntar Archivo:";
            this.lblArchivo3.Visible = false;
            // 
            // lbl2Archivo2
            // 
            this.lbl2Archivo2.AutoSize = true;
            this.lbl2Archivo2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2Archivo2.Location = new System.Drawing.Point(129, 172);
            this.lbl2Archivo2.Name = "lbl2Archivo2";
            this.lbl2Archivo2.Size = new System.Drawing.Size(129, 20);
            this.lbl2Archivo2.TabIndex = 41;
            this.lbl2Archivo2.Text = "Adjuntar Archivo:";
            this.lbl2Archivo2.Visible = false;
            // 
            // lblArchivo1
            // 
            this.lblArchivo1.AutoSize = true;
            this.lblArchivo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArchivo1.Location = new System.Drawing.Point(129, 133);
            this.lblArchivo1.Name = "lblArchivo1";
            this.lblArchivo1.Size = new System.Drawing.Size(129, 20);
            this.lblArchivo1.TabIndex = 40;
            this.lblArchivo1.Text = "Adjuntar Archivo:";
            this.lblArchivo1.Visible = false;
            // 
            // txtArchivo3
            // 
            this.txtArchivo3.Location = new System.Drawing.Point(264, 213);
            this.txtArchivo3.Name = "txtArchivo3";
            this.txtArchivo3.Size = new System.Drawing.Size(250, 20);
            this.txtArchivo3.TabIndex = 39;
            this.txtArchivo3.Visible = false;
            // 
            // txtArchivo2
            // 
            this.txtArchivo2.Location = new System.Drawing.Point(264, 172);
            this.txtArchivo2.Name = "txtArchivo2";
            this.txtArchivo2.Size = new System.Drawing.Size(250, 20);
            this.txtArchivo2.TabIndex = 38;
            this.txtArchivo2.Visible = false;
            // 
            // txtArchivo1
            // 
            this.txtArchivo1.Location = new System.Drawing.Point(264, 133);
            this.txtArchivo1.Name = "txtArchivo1";
            this.txtArchivo1.Size = new System.Drawing.Size(250, 20);
            this.txtArchivo1.TabIndex = 37;
            this.txtArchivo1.Visible = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            // 
            // openFileDialog3
            // 
            this.openFileDialog3.FileName = "openFileDialog3";
            // 
            // chcEmail
            // 
            this.chcEmail.AutoSize = true;
            this.chcEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chcEmail.Location = new System.Drawing.Point(328, 238);
            this.chcEmail.Name = "chcEmail";
            this.chcEmail.Size = new System.Drawing.Size(105, 21);
            this.chcEmail.TabIndex = 87;
            this.chcEmail.Text = "Enviar Email";
            this.chcEmail.UseVisualStyleBackColor = true;
            // 
            // PericiaHistoriaWF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 743);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "PericiaHistoriaWF";
            this.Text = "PericiaHistoriaWF";
            this.Load += new System.EventHandler(this.PericiaHistoriaWF_Load);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.groupBox2, 0);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPericias)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvPericias;
        private System.Windows.Forms.Button btnNuevaHistoria;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnCargarArchivo3;
        private System.Windows.Forms.Button btnCargarArchivo2;
        private System.Windows.Forms.Button btnCargarArchivo1;
        private System.Windows.Forms.Label lblArchivo3;
        private System.Windows.Forms.Label lbl2Archivo2;
        private System.Windows.Forms.Label lblArchivo1;
        private System.Windows.Forms.TextBox txtArchivo3;
        private System.Windows.Forms.TextBox txtArchivo2;
        private System.Windows.Forms.TextBox txtArchivo1;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DateTimePicker dtFechaPericia;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnGuardarHistorial;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.OpenFileDialog openFileDialog3;
        private System.Windows.Forms.CheckBox chcEmail;
    }
}