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
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
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
            this.panel1.Location = new System.Drawing.Point(17, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(523, 144);
            this.panel1.TabIndex = 0;
            // 
            // lShowMensaje
            // 
            this.lShowMensaje.BackColor = System.Drawing.Color.White;
            this.lShowMensaje.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lShowMensaje.Cursor = System.Windows.Forms.Cursors.Default;
            this.lShowMensaje.Enabled = false;
            this.lShowMensaje.Location = new System.Drawing.Point(16, 37);
            this.lShowMensaje.Multiline = true;
            this.lShowMensaje.Name = "lShowMensaje";
            this.lShowMensaje.ReadOnly = true;
            this.lShowMensaje.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.lShowMensaje.Size = new System.Drawing.Size(491, 59);
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
            this.bEliminar.Location = new System.Drawing.Point(484, 105);
            this.bEliminar.Name = "bEliminar";
            this.bEliminar.Size = new System.Drawing.Size(36, 36);
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
            this.bResponder.Location = new System.Drawing.Point(442, 105);
            this.bResponder.Name = "bResponder";
            this.bResponder.Size = new System.Drawing.Size(36, 36);
            this.bResponder.TabIndex = 9;
            this.bResponder.UseVisualStyleBackColor = false;
            // 
            // lShowFecha
            // 
            this.lShowFecha.AutoSize = true;
            this.lShowFecha.Location = new System.Drawing.Point(337, 122);
            this.lShowFecha.Name = "lShowFecha";
            this.lShowFecha.Size = new System.Drawing.Size(34, 13);
            this.lShowFecha.TabIndex = 8;
            this.lShowFecha.Text = "fecha";
            // 
            // l
            // 
            this.l.AutoSize = true;
            this.l.Font = new System.Drawing.Font("Calibri Light", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l.Location = new System.Drawing.Point(286, 122);
            this.l.Name = "l";
            this.l.Size = new System.Drawing.Size(45, 14);
            this.l.TabIndex = 7;
            this.l.Text = "Fecha:";
            // 
            // lShowRemite
            // 
            this.lShowRemite.AutoSize = true;
            this.lShowRemite.Location = new System.Drawing.Point(89, 100);
            this.lShowRemite.Name = "lShowRemite";
            this.lShowRemite.Size = new System.Drawing.Size(35, 13);
            this.lShowRemite.TabIndex = 5;
            this.lShowRemite.Text = "remite";
            // 
            // lShowDest
            // 
            this.lShowDest.AutoSize = true;
            this.lShowDest.Cursor = System.Windows.Forms.Cursors.Default;
            this.lShowDest.Location = new System.Drawing.Point(101, 122);
            this.lShowDest.Name = "lShowDest";
            this.lShowDest.Size = new System.Drawing.Size(41, 13);
            this.lShowDest.TabIndex = 4;
            this.lShowDest.Text = "destino";
            // 
            // lShowAsunto
            // 
            this.lShowAsunto.AutoSize = true;
            this.lShowAsunto.Location = new System.Drawing.Point(70, 11);
            this.lShowAsunto.Name = "lShowAsunto";
            this.lShowAsunto.Size = new System.Drawing.Size(39, 13);
            this.lShowAsunto.TabIndex = 3;
            this.lShowAsunto.Text = "asunto";
            // 
            // lAsunto
            // 
            this.lAsunto.AutoSize = true;
            this.lAsunto.Font = new System.Drawing.Font("Calibri Light", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lAsunto.Location = new System.Drawing.Point(13, 11);
            this.lAsunto.Name = "lAsunto";
            this.lAsunto.Size = new System.Drawing.Size(51, 14);
            this.lAsunto.TabIndex = 2;
            this.lAsunto.Text = "Asunto:";
            // 
            // lReceptor
            // 
            this.lReceptor.AutoSize = true;
            this.lReceptor.Font = new System.Drawing.Font("Calibri Light", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lReceptor.Location = new System.Drawing.Point(13, 121);
            this.lReceptor.Name = "lReceptor";
            this.lReceptor.Size = new System.Drawing.Size(82, 14);
            this.lReceptor.TabIndex = 1;
            this.lReceptor.Text = "Destinatario:";
            // 
            // lEmisor
            // 
            this.lEmisor.AutoSize = true;
            this.lEmisor.Font = new System.Drawing.Font("Calibri Light", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lEmisor.Location = new System.Drawing.Point(13, 99);
            this.lEmisor.Name = "lEmisor";
            this.lEmisor.Size = new System.Drawing.Size(70, 14);
            this.lEmisor.TabIndex = 0;
            this.lEmisor.Text = "Remitente:";
            // 
            // CartelMensajes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.Controls.Add(this.panel1);
            this.Name = "CartelMensajes";
            this.Size = new System.Drawing.Size(560, 150);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lShowRemite;
        private System.Windows.Forms.Label lShowDest;
        private System.Windows.Forms.Label lShowAsunto;
        private System.Windows.Forms.Label lAsunto;
        private System.Windows.Forms.Label lReceptor;
        private System.Windows.Forms.Label lEmisor;
        private System.Windows.Forms.Label lShowFecha;
        private System.Windows.Forms.Label l;
        private System.Windows.Forms.Button bEliminar;
        private System.Windows.Forms.Button bResponder;
        private System.Windows.Forms.TextBox lShowMensaje;
    }
}
