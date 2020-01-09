namespace APS.Interfaces.GestorExclusive
{
    partial class CNoticia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CNoticia));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lFecha = new System.Windows.Forms.Label();
            this.bBorrar = new System.Windows.Forms.Button();
            this.pictImage = new System.Windows.Forms.PictureBox();
            this.lNoticia = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictImage)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.lNoticia);
            this.panel1.Controls.Add(this.bBorrar);
            this.panel1.Controls.Add(this.lFecha);
            this.panel1.Controls.Add(this.pictImage);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(569, 64);
            this.panel1.TabIndex = 0;
            // 
            // lFecha
            // 
            this.lFecha.AutoSize = true;
            this.lFecha.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lFecha.Location = new System.Drawing.Point(478, 48);
            this.lFecha.Name = "lFecha";
            this.lFecha.Size = new System.Drawing.Size(33, 13);
            this.lFecha.TabIndex = 2;
            this.lFecha.Text = "fecha";
            // 
            // bBorrar
            // 
            this.bBorrar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bBorrar.BackgroundImage")));
            this.bBorrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bBorrar.FlatAppearance.BorderSize = 0;
            this.bBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bBorrar.Location = new System.Drawing.Point(538, 3);
            this.bBorrar.Name = "bBorrar";
            this.bBorrar.Size = new System.Drawing.Size(28, 28);
            this.bBorrar.TabIndex = 5;
            this.bBorrar.UseVisualStyleBackColor = true;
            // 
            // pictImage
            // 
            this.pictImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictImage.Location = new System.Drawing.Point(3, 3);
            this.pictImage.Name = "pictImage";
            this.pictImage.Size = new System.Drawing.Size(95, 58);
            this.pictImage.TabIndex = 0;
            this.pictImage.TabStop = false;
            // 
            // lNoticia
            // 
            this.lNoticia.Location = new System.Drawing.Point(104, 3);
            this.lNoticia.Multiline = true;
            this.lNoticia.Name = "lNoticia";
            this.lNoticia.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.lNoticia.Size = new System.Drawing.Size(368, 58);
            this.lNoticia.TabIndex = 6;
            // 
            // CNoticia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.panel1);
            this.Name = "CNoticia";
            this.Size = new System.Drawing.Size(575, 70);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictImage;
        private System.Windows.Forms.Label lFecha;
        private System.Windows.Forms.Button bBorrar;
        private System.Windows.Forms.TextBox lNoticia;
    }
}
