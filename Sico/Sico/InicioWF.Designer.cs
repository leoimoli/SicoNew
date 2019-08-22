namespace Sico
{
    partial class InicioWF
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnPericias = new System.Windows.Forms.Button();
            this.btnUsuarios = new System.Windows.Forms.Button();
            this.btnClientes = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.imgHipotecario = new System.Windows.Forms.PictureBox();
            this.imgProvincia = new System.Windows.Forms.PictureBox();
            this.imgNacion = new System.Windows.Forms.PictureBox();
            this.webBrowser2 = new System.Windows.Forms.WebBrowser();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgHipotecario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgProvincia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgNacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnPericias);
            this.groupBox1.Controls.Add(this.btnUsuarios);
            this.groupBox1.Controls.Add(this.btnClientes);
            this.groupBox1.Location = new System.Drawing.Point(108, 78);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(550, 100);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // btnPericias
            // 
            this.btnPericias.Image = global::Sico.Properties.Resources.juicio__1_;
            this.btnPericias.Location = new System.Drawing.Point(218, 14);
            this.btnPericias.Name = "btnPericias";
            this.btnPericias.Size = new System.Drawing.Size(100, 80);
            this.btnPericias.TabIndex = 5;
            this.toolTip1.SetToolTip(this.btnPericias, "Pericias");
            this.btnPericias.UseVisualStyleBackColor = true;
            this.btnPericias.Click += new System.EventHandler(this.btnPericias_Click);
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.Image = global::Sico.Properties.Resources.usuario_hombre__1_;
            this.btnUsuarios.Location = new System.Drawing.Point(415, 14);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Size = new System.Drawing.Size(100, 80);
            this.btnUsuarios.TabIndex = 4;
            this.toolTip1.SetToolTip(this.btnUsuarios, "Usuarios");
            this.btnUsuarios.UseVisualStyleBackColor = true;
            this.btnUsuarios.Click += new System.EventHandler(this.btnUsuarios_Click);
            // 
            // btnClientes
            // 
            this.btnClientes.Image = global::Sico.Properties.Resources.comprador__1_1;
            this.btnClientes.Location = new System.Drawing.Point(43, 14);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(100, 80);
            this.btnClientes.TabIndex = 3;
            this.toolTip1.SetToolTip(this.btnClientes, "Clientes");
            this.btnClientes.UseVisualStyleBackColor = true;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.webBrowser1);
            this.groupBox2.Location = new System.Drawing.Point(821, 122);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 210);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(3, 16);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.ScrollBarsEnabled = false;
            this.webBrowser1.Size = new System.Drawing.Size(200, 210);
            this.webBrowser1.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.imgHipotecario);
            this.groupBox3.Controls.Add(this.imgProvincia);
            this.groupBox3.Controls.Add(this.imgNacion);
            this.groupBox3.Controls.Add(this.webBrowser2);
            this.groupBox3.Location = new System.Drawing.Point(848, 335);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(150, 300);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
            // 
            // imgHipotecario
            // 
            this.imgHipotecario.Image = global::Sico.Properties.Resources.Hipotecario;
            this.imgHipotecario.Location = new System.Drawing.Point(2, 259);
            this.imgHipotecario.Name = "imgHipotecario";
            this.imgHipotecario.Size = new System.Drawing.Size(145, 35);
            this.imgHipotecario.TabIndex = 7;
            this.imgHipotecario.TabStop = false;
            this.toolTip1.SetToolTip(this.imgHipotecario, "Banco Hipotecario");
            this.imgHipotecario.Click += new System.EventHandler(this.imgHipotecario_Click);
            // 
            // imgProvincia
            // 
            this.imgProvincia.Image = global::Sico.Properties.Resources.Provincia_5_;
            this.imgProvincia.Location = new System.Drawing.Point(2, 220);
            this.imgProvincia.Name = "imgProvincia";
            this.imgProvincia.Size = new System.Drawing.Size(145, 35);
            this.imgProvincia.TabIndex = 6;
            this.imgProvincia.TabStop = false;
            this.toolTip1.SetToolTip(this.imgProvincia, "Banco Provincia");
            this.imgProvincia.Click += new System.EventHandler(this.imgProvincia_Click);
            // 
            // imgNacion
            // 
            this.imgNacion.Image = global::Sico.Properties.Resources.Nacion1;
            this.imgNacion.Location = new System.Drawing.Point(2, 182);
            this.imgNacion.Name = "imgNacion";
            this.imgNacion.Size = new System.Drawing.Size(145, 35);
            this.imgNacion.TabIndex = 2;
            this.imgNacion.TabStop = false;
            this.toolTip1.SetToolTip(this.imgNacion, "Banco Nación");
            this.imgNacion.Click += new System.EventHandler(this.imgNacion_Click);
            // 
            // webBrowser2
            // 
            this.webBrowser2.Location = new System.Drawing.Point(0, 16);
            this.webBrowser2.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser2.Name = "webBrowser2";
            this.webBrowser2.ScrollBarsEnabled = false;
            this.webBrowser2.Size = new System.Drawing.Size(150, 160);
            this.webBrowser2.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Sico.Properties.Resources.SistemaContable;
            this.pictureBox1.Location = new System.Drawing.Point(108, 184);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(550, 450);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // InicioWF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 657);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "InicioWF";
            this.Text = "Inicio";
            this.Load += new System.EventHandler(this.InicioWF_Load);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.pictureBox1, 0);
            this.Controls.SetChildIndex(this.groupBox2, 0);
            this.Controls.SetChildIndex(this.groupBox3, 0);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgHipotecario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgProvincia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgNacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.Button btnUsuarios;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnPericias;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.WebBrowser webBrowser2;
        private System.Windows.Forms.PictureBox imgNacion;
        private System.Windows.Forms.PictureBox imgHipotecario;
        private System.Windows.Forms.PictureBox imgProvincia;
    }
}