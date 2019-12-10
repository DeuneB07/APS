namespace APS.Interfaces
{
    partial class CartelPrimarioPruebil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CartelPrimarioPruebil));
            this.panel1 = new System.Windows.Forms.Panel();
            this.bVerMas = new System.Windows.Forms.Button();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.lDescripcion = new System.Windows.Forms.Label();
            this.pict = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pict)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.bVerMas);
            this.panel1.Controls.Add(this.labelTitulo);
            this.panel1.Controls.Add(this.lDescripcion);
            this.panel1.Controls.Add(this.pict);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(452, 116);
            this.panel1.TabIndex = 3;
            // 
            // bVerMas
            // 
            this.bVerMas.FlatAppearance.BorderSize = 0;
            this.bVerMas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bVerMas.Image = ((System.Drawing.Image)(resources.GetObject("bVerMas.Image")));
            this.bVerMas.Location = new System.Drawing.Point(419, 3);
            this.bVerMas.Name = "bVerMas";
            this.bVerMas.Size = new System.Drawing.Size(30, 30);
            this.bVerMas.TabIndex = 7;
            this.bVerMas.UseVisualStyleBackColor = true;
            this.bVerMas.Click += new System.EventHandler(this.bVerMas_Click);
            // 
            // labelTitulo
            // 
            this.labelTitulo.Font = new System.Drawing.Font("Calibri", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitulo.Location = new System.Drawing.Point(3, 4);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(407, 23);
            this.labelTitulo.TabIndex = 4;
            this.labelTitulo.Text = "Titulo";
            // 
            // lDescripcion
            // 
            this.lDescripcion.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lDescripcion.Location = new System.Drawing.Point(144, 33);
            this.lDescripcion.Name = "lDescripcion";
            this.lDescripcion.Size = new System.Drawing.Size(266, 78);
            this.lDescripcion.TabIndex = 5;
            this.lDescripcion.Text = "Descripción";
            // 
            // pict
            // 
            this.pict.Location = new System.Drawing.Point(6, 30);
            this.pict.Name = "pict";
            this.pict.Size = new System.Drawing.Size(132, 81);
            this.pict.TabIndex = 6;
            this.pict.TabStop = false;
            // 
            // Cartel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Controls.Add(this.panel1);
            this.Name = "Cartel";
            this.Size = new System.Drawing.Size(460, 122);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pict)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.Label lDescripcion;
        private System.Windows.Forms.PictureBox pict;
        private System.Windows.Forms.Button bVerMas;
    }
}
