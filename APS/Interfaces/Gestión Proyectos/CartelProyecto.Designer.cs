namespace APS.Interfaces.Gestión_Proyectos
{
    partial class CartelProyecto
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CartelProyecto));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lNombreAct = new System.Windows.Forms.Label();
            this.pictAtras = new System.Windows.Forms.PictureBox();
            this.pictAlante = new System.Windows.Forms.PictureBox();
            this.lShowNumActividades = new System.Windows.Forms.Label();
            this.lblNumAct = new System.Windows.Forms.Label();
            this.lShowEstadoProy = new System.Windows.Forms.Label();
            this.lblEstadoProy = new System.Windows.Forms.Label();
            this.lShowTipoProy = new System.Windows.Forms.Label();
            this.lblTipoProy = new System.Windows.Forms.Label();
            this.lShowResp = new System.Windows.Forms.Label();
            this.lResp = new System.Windows.Forms.Label();
            this.lShowIni = new System.Windows.Forms.Label();
            this.lFecha = new System.Windows.Forms.Label();
            this.bVerMas = new System.Windows.Forms.Button();
            this.labelName = new System.Windows.Forms.Label();
            this.lDescripcion = new System.Windows.Forms.Label();
            this.pict = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictAtras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictAlante)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pict)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lNombreAct);
            this.panel1.Controls.Add(this.pictAtras);
            this.panel1.Controls.Add(this.pictAlante);
            this.panel1.Controls.Add(this.lShowNumActividades);
            this.panel1.Controls.Add(this.lblNumAct);
            this.panel1.Controls.Add(this.lShowEstadoProy);
            this.panel1.Controls.Add(this.lblEstadoProy);
            this.panel1.Controls.Add(this.lShowTipoProy);
            this.panel1.Controls.Add(this.lblTipoProy);
            this.panel1.Controls.Add(this.lShowResp);
            this.panel1.Controls.Add(this.lResp);
            this.panel1.Controls.Add(this.lShowIni);
            this.panel1.Controls.Add(this.lFecha);
            this.panel1.Controls.Add(this.bVerMas);
            this.panel1.Controls.Add(this.labelName);
            this.panel1.Controls.Add(this.lDescripcion);
            this.panel1.Controls.Add(this.pict);
            this.panel1.Location = new System.Drawing.Point(4, 4);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(831, 209);
            this.panel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(67, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 63);
            this.label1.TabIndex = 29;
            this.label1.Text = "NO CONTIENE\r\nACTIVIDADES\r\nTODAVÍA";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Visible = false;
            // 
            // lNombreAct
            // 
            this.lNombreAct.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lNombreAct.Font = new System.Drawing.Font("Bahnschrift Condensed", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lNombreAct.Location = new System.Drawing.Point(33, 81);
            this.lNombreAct.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lNombreAct.Name = "lNombreAct";
            this.lNombreAct.Size = new System.Drawing.Size(176, 17);
            this.lNombreAct.TabIndex = 28;
            this.lNombreAct.Text = "nombreActividad";
            this.lNombreAct.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictAtras
            // 
            this.pictAtras.Image = ((System.Drawing.Image)(resources.GetObject("pictAtras.Image")));
            this.pictAtras.Location = new System.Drawing.Point(10, 132);
            this.pictAtras.Name = "pictAtras";
            this.pictAtras.Size = new System.Drawing.Size(16, 33);
            this.pictAtras.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictAtras.TabIndex = 27;
            this.pictAtras.TabStop = false;
            this.pictAtras.Click += new System.EventHandler(this.pictAtras_Click);
            // 
            // pictAlante
            // 
            this.pictAlante.Image = ((System.Drawing.Image)(resources.GetObject("pictAlante.Image")));
            this.pictAlante.Location = new System.Drawing.Point(216, 132);
            this.pictAlante.Name = "pictAlante";
            this.pictAlante.Size = new System.Drawing.Size(16, 33);
            this.pictAlante.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictAlante.TabIndex = 26;
            this.pictAlante.TabStop = false;
            this.pictAlante.Click += new System.EventHandler(this.pictAlante_Click);
            // 
            // lShowNumActividades
            // 
            this.lShowNumActividades.AutoSize = true;
            this.lShowNumActividades.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lShowNumActividades.Location = new System.Drawing.Point(739, 148);
            this.lShowNumActividades.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lShowNumActividades.Name = "lShowNumActividades";
            this.lShowNumActividades.Size = new System.Drawing.Size(36, 17);
            this.lShowNumActividades.TabIndex = 25;
            this.lShowNumActividades.Text = "num";
            // 
            // lblNumAct
            // 
            this.lblNumAct.AutoSize = true;
            this.lblNumAct.Font = new System.Drawing.Font("Bahnschrift", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumAct.Location = new System.Drawing.Point(627, 148);
            this.lblNumAct.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumAct.Name = "lblNumAct";
            this.lblNumAct.Size = new System.Drawing.Size(104, 17);
            this.lblNumAct.TabIndex = 24;
            this.lblNumAct.Text = "Nº Actividades:";
            // 
            // lShowEstadoProy
            // 
            this.lShowEstadoProy.AutoSize = true;
            this.lShowEstadoProy.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lShowEstadoProy.Location = new System.Drawing.Point(694, 113);
            this.lShowEstadoProy.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lShowEstadoProy.Name = "lShowEstadoProy";
            this.lShowEstadoProy.Size = new System.Drawing.Size(51, 17);
            this.lShowEstadoProy.TabIndex = 23;
            this.lShowEstadoProy.Text = "estado";
            // 
            // lblEstadoProy
            // 
            this.lblEstadoProy.AutoSize = true;
            this.lblEstadoProy.Font = new System.Drawing.Font("Bahnschrift", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstadoProy.Location = new System.Drawing.Point(627, 113);
            this.lblEstadoProy.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEstadoProy.Name = "lblEstadoProy";
            this.lblEstadoProy.Size = new System.Drawing.Size(54, 17);
            this.lblEstadoProy.TabIndex = 22;
            this.lblEstadoProy.Text = "Estado:";
            // 
            // lShowTipoProy
            // 
            this.lShowTipoProy.AutoSize = true;
            this.lShowTipoProy.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lShowTipoProy.Location = new System.Drawing.Point(689, 54);
            this.lShowTipoProy.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lShowTipoProy.Name = "lShowTipoProy";
            this.lShowTipoProy.Size = new System.Drawing.Size(33, 17);
            this.lShowTipoProy.TabIndex = 21;
            this.lShowTipoProy.Text = "tipo";
            // 
            // lblTipoProy
            // 
            this.lblTipoProy.AutoSize = true;
            this.lblTipoProy.Font = new System.Drawing.Font("Bahnschrift", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoProy.Location = new System.Drawing.Point(581, 55);
            this.lblTipoProy.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTipoProy.Name = "lblTipoProy";
            this.lblTipoProy.Size = new System.Drawing.Size(100, 17);
            this.lblTipoProy.TabIndex = 20;
            this.lblTipoProy.Text = "Tipo Proyecto:";
            // 
            // lShowResp
            // 
            this.lShowResp.AutoSize = true;
            this.lShowResp.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lShowResp.Location = new System.Drawing.Point(128, 42);
            this.lShowResp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lShowResp.Name = "lShowResp";
            this.lShowResp.Size = new System.Drawing.Size(69, 17);
            this.lShowResp.TabIndex = 19;
            this.lShowResp.Text = "nounresp";
            // 
            // lResp
            // 
            this.lResp.AutoSize = true;
            this.lResp.Font = new System.Drawing.Font("Bahnschrift", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lResp.Location = new System.Drawing.Point(27, 42);
            this.lResp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lResp.Name = "lResp";
            this.lResp.Size = new System.Drawing.Size(93, 17);
            this.lResp.TabIndex = 18;
            this.lResp.Text = "Responsable:";
            // 
            // lShowIni
            // 
            this.lShowIni.AutoSize = true;
            this.lShowIni.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lShowIni.Location = new System.Drawing.Point(694, 81);
            this.lShowIni.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lShowIni.Name = "lShowIni";
            this.lShowIni.Size = new System.Drawing.Size(24, 17);
            this.lShowIni.TabIndex = 16;
            this.lShowIni.Text = "ini";
            // 
            // lFecha
            // 
            this.lFecha.AutoSize = true;
            this.lFecha.Font = new System.Drawing.Font("Bahnschrift", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lFecha.Location = new System.Drawing.Point(627, 81);
            this.lFecha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lFecha.Name = "lFecha";
            this.lFecha.Size = new System.Drawing.Size(49, 17);
            this.lFecha.TabIndex = 14;
            this.lFecha.Text = "Fecha:";
            // 
            // bVerMas
            // 
            this.bVerMas.FlatAppearance.BorderSize = 0;
            this.bVerMas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bVerMas.Image = ((System.Drawing.Image)(resources.GetObject("bVerMas.Image")));
            this.bVerMas.Location = new System.Drawing.Point(755, 4);
            this.bVerMas.Margin = new System.Windows.Forms.Padding(4);
            this.bVerMas.Name = "bVerMas";
            this.bVerMas.Size = new System.Drawing.Size(72, 68);
            this.bVerMas.TabIndex = 7;
            this.bVerMas.UseVisualStyleBackColor = true;
            this.bVerMas.Visible = false;
            // 
            // labelName
            // 
            this.labelName.Font = new System.Drawing.Font("Bahnschrift", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(6, 4);
            this.labelName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(592, 28);
            this.labelName.TabIndex = 4;
            this.labelName.Text = "Nombre";
            // 
            // lDescripcion
            // 
            this.lDescripcion.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lDescripcion.Location = new System.Drawing.Point(259, 70);
            this.lDescripcion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lDescripcion.Name = "lDescripcion";
            this.lDescripcion.Size = new System.Drawing.Size(339, 119);
            this.lDescripcion.TabIndex = 5;
            this.lDescripcion.Text = "Descripción";
            // 
            // pict
            // 
            this.pict.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pict.Image = global::APS.Properties.Resources.no_image;
            this.pict.Location = new System.Drawing.Point(33, 102);
            this.pict.Margin = new System.Windows.Forms.Padding(4);
            this.pict.Name = "pict";
            this.pict.Size = new System.Drawing.Size(176, 100);
            this.pict.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pict.TabIndex = 6;
            this.pict.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // CartelProyecto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkMagenta;
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CartelProyecto";
            this.Size = new System.Drawing.Size(839, 217);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictAtras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictAlante)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pict)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label lDescripcion;
        private System.Windows.Forms.PictureBox pict;
        private System.Windows.Forms.Button bVerMas;
        private System.Windows.Forms.Label lShowIni;
        private System.Windows.Forms.Label lFecha;
        private System.Windows.Forms.Label lShowResp;
        private System.Windows.Forms.Label lResp;
        private System.Windows.Forms.Label lShowEstadoProy;
        private System.Windows.Forms.Label lblEstadoProy;
        private System.Windows.Forms.Label lShowTipoProy;
        private System.Windows.Forms.Label lblTipoProy;
        private System.Windows.Forms.Label lblNumAct;
        private System.Windows.Forms.Label lShowNumActividades;
        private System.Windows.Forms.PictureBox pictAlante;
        private System.Windows.Forms.PictureBox pictAtras;
        private System.Windows.Forms.Label lNombreAct;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
    }
}
