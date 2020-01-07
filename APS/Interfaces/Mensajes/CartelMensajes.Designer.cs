namespace APS.Interfaces.Personalizados
{
    partial class CartelMensajes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CartelMensajes));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictNovedad = new System.Windows.Forms.PictureBox();
            this.lShowMensaje = new System.Windows.Forms.TextBox();
            this.bEliminar = new System.Windows.Forms.Button();
            this.bResponder = new System.Windows.Forms.Button();
            this.lShowFecha = new System.Windows.Forms.Label();
            this.l = new System.Windows.Forms.Label();
            this.lShowRemite = new System.Windows.Forms.Label();
            this.lShowDest = new System.Windows.Forms.Label();
            this.lShowAsunto = new System.Windows.Forms.Label();
            this.lAsunto = new System.Windows.Forms.Label();
            this.lReceptor = new System.Windows.Forms.Label();
            this.lEmisor = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictNovedad)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.pictNovedad);
            this.panel1.Controls.Add(this.lShowMensaje);
            this.panel1.Controls.Add(this.bEliminar);
            this.panel1.Controls.Add(this.bResponder);
            this.panel1.Controls.Add(this.lShowFecha);
            this.panel1.Controls.Add(this.l);
            this.panel1.Controls.Add(this.lShowRemite);
            this.panel1.Controls.Add(this.lShowDest);
            this.panel1.Controls.Add(this.lShowAsunto);
            this.panel1.Controls.Add(this.lAsunto);
            this.panel1.Controls.Add(this.lReceptor);
            this.panel1.Controls.Add(this.lEmisor);
            this.panel1.Location = new System.Drawing.Point(23, 4);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(697, 177);
            this.panel1.TabIndex = 0;
            // 
            // pictNovedad
            // 
            this.pictNovedad.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictNovedad.BackgroundImage")));
            this.pictNovedad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictNovedad.Location = new System.Drawing.Point(657, 0);
            this.pictNovedad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictNovedad.Name = "pictNovedad";
            this.pictNovedad.Size = new System.Drawing.Size(40, 37);
            this.pictNovedad.TabIndex = 12;
            this.pictNovedad.TabStop = false;
            // 
            // lShowMensaje
            // 
            this.lShowMensaje.BackColor = System.Drawing.Color.White;
            this.lShowMensaje.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lShowMensaje.Cursor = System.Windows.Forms.Cursors.Default;
            this.lShowMensaje.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lShowMensaje.Location = new System.Drawing.Point(21, 46);
            this.lShowMensaje.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lShowMensaje.Multiline = true;
            this.lShowMensaje.Name = "lShowMensaje";
            this.lShowMensaje.ReadOnly = true;
            this.lShowMensaje.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.lShowMensaje.Size = new System.Drawing.Size(655, 73);
            this.lShowMensaje.TabIndex = 11;
            this.lShowMensaje.Text = "mensaje";
            // 
            // bEliminar
            // 
            this.bEliminar.BackColor = System.Drawing.Color.Transparent;
            this.bEliminar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bEliminar.BackgroundImage")));
            this.bEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bEliminar.FlatAppearance.BorderSize = 0;
            this.bEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bEliminar.Location = new System.Drawing.Point(645, 129);
            this.bEliminar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bEliminar.Name = "bEliminar";
            this.bEliminar.Size = new System.Drawing.Size(48, 44);
            this.bEliminar.TabIndex = 10;
            this.bEliminar.UseVisualStyleBackColor = false;
            // 
            // bResponder
            // 
            this.bResponder.BackColor = System.Drawing.Color.Transparent;
            this.bResponder.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bResponder.BackgroundImage")));
            this.bResponder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bResponder.FlatAppearance.BorderSize = 0;
            this.bResponder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bResponder.Location = new System.Drawing.Point(589, 129);
            this.bResponder.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bResponder.Name = "bResponder";
            this.bResponder.Size = new System.Drawing.Size(48, 44);
            this.bResponder.TabIndex = 9;
            this.bResponder.UseVisualStyleBackColor = false;
            // 
            // lShowFecha
            // 
            this.lShowFecha.AutoSize = true;
            this.lShowFecha.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lShowFecha.Location = new System.Drawing.Point(445, 151);
            this.lShowFecha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lShowFecha.Name = "lShowFecha";
            this.lShowFecha.Size = new System.Drawing.Size(42, 17);
            this.lShowFecha.TabIndex = 8;
            this.lShowFecha.Text = "fecha";
            // 
            // l
            // 
            this.l.AutoSize = true;
            this.l.Font = new System.Drawing.Font("Bahnschrift", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l.Location = new System.Drawing.Point(381, 150);
            this.l.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.l.Name = "l";
            this.l.Size = new System.Drawing.Size(50, 18);
            this.l.TabIndex = 7;
            this.l.Text = "Fecha:";
            // 
            // lShowRemite
            // 
            this.lShowRemite.AutoSize = true;
            this.lShowRemite.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lShowRemite.Location = new System.Drawing.Point(111, 123);
            this.lShowRemite.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lShowRemite.Name = "lShowRemite";
            this.lShowRemite.Size = new System.Drawing.Size(51, 17);
            this.lShowRemite.TabIndex = 5;
            this.lShowRemite.Text = "remite";
            // 
            // lShowDest
            // 
            this.lShowDest.AutoSize = true;
            this.lShowDest.Cursor = System.Windows.Forms.Cursors.Default;
            this.lShowDest.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lShowDest.Location = new System.Drawing.Point(125, 150);
            this.lShowDest.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lShowDest.Name = "lShowDest";
            this.lShowDest.Size = new System.Drawing.Size(56, 17);
            this.lShowDest.TabIndex = 4;
            this.lShowDest.Text = "destino";
            // 
            // lShowAsunto
            // 
            this.lShowAsunto.AutoSize = true;
            this.lShowAsunto.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lShowAsunto.Location = new System.Drawing.Point(91, 15);
            this.lShowAsunto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lShowAsunto.Name = "lShowAsunto";
            this.lShowAsunto.Size = new System.Drawing.Size(51, 17);
            this.lShowAsunto.TabIndex = 3;
            this.lShowAsunto.Text = "asunto";
            // 
            // lAsunto
            // 
            this.lAsunto.AutoSize = true;
            this.lAsunto.Font = new System.Drawing.Font("Bahnschrift", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lAsunto.Location = new System.Drawing.Point(17, 14);
            this.lAsunto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lAsunto.Name = "lAsunto";
            this.lAsunto.Size = new System.Drawing.Size(58, 18);
            this.lAsunto.TabIndex = 2;
            this.lAsunto.Text = "Asunto:";
            // 
            // lReceptor
            // 
            this.lReceptor.AutoSize = true;
            this.lReceptor.Font = new System.Drawing.Font("Bahnschrift", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lReceptor.Location = new System.Drawing.Point(17, 149);
            this.lReceptor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lReceptor.Name = "lReceptor";
            this.lReceptor.Size = new System.Drawing.Size(93, 18);
            this.lReceptor.TabIndex = 1;
            this.lReceptor.Text = "Destinatario:";
            // 
            // lEmisor
            // 
            this.lEmisor.AutoSize = true;
            this.lEmisor.Font = new System.Drawing.Font("Bahnschrift", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lEmisor.Location = new System.Drawing.Point(17, 122);
            this.lEmisor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lEmisor.Name = "lEmisor";
            this.lEmisor.Size = new System.Drawing.Size(80, 18);
            this.lEmisor.TabIndex = 0;
            this.lEmisor.Text = "Remitente:";
            // 
            // CartelMensajes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "CartelMensajes";
            this.Size = new System.Drawing.Size(747, 185);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictNovedad)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox lShowMensaje;
        private System.Windows.Forms.Button bEliminar;
        private System.Windows.Forms.Button bResponder;
        private System.Windows.Forms.Label lShowFecha;
        private System.Windows.Forms.Label l;
        private System.Windows.Forms.Label lShowRemite;
        private System.Windows.Forms.Label lShowDest;
        private System.Windows.Forms.Label lShowAsunto;
        private System.Windows.Forms.Label lAsunto;
        private System.Windows.Forms.Label lReceptor;
        private System.Windows.Forms.Label lEmisor;
        private System.Windows.Forms.PictureBox pictNovedad;
    }
}
