namespace APS.Interfaces.Personalizados
{
    partial class CartelActividadesStandard
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lNumPlazas = new System.Windows.Forms.Label();
            this.lPlazas = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.lDescripcion = new System.Windows.Forms.Label();
            this.bSolicitar = new System.Windows.Forms.Button();
            this.bVerMas = new System.Windows.Forms.Button();
            this.pict = new System.Windows.Forms.PictureBox();
            this.lTipoA = new System.Windows.Forms.Label();
            this.lTipoActividad = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pict)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.lTipoActividad);
            this.panel1.Controls.Add(this.lTipoA);
            this.panel1.Controls.Add(this.bSolicitar);
            this.panel1.Controls.Add(this.lNumPlazas);
            this.panel1.Controls.Add(this.lPlazas);
            this.panel1.Controls.Add(this.bVerMas);
            this.panel1.Controls.Add(this.labelName);
            this.panel1.Controls.Add(this.lDescripcion);
            this.panel1.Controls.Add(this.pict);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(452, 116);
            this.panel1.TabIndex = 3;
            // 
            // lNumPlazas
            // 
            this.lNumPlazas.AutoSize = true;
            this.lNumPlazas.Location = new System.Drawing.Point(153, 92);
            this.lNumPlazas.Name = "lNumPlazas";
            this.lNumPlazas.Size = new System.Drawing.Size(57, 13);
            this.lNumPlazas.TabIndex = 9;
            this.lNumPlazas.Text = "numplazas";
            // 
            // lPlazas
            // 
            this.lPlazas.AutoSize = true;
            this.lPlazas.Location = new System.Drawing.Point(144, 79);
            this.lPlazas.Name = "lPlazas";
            this.lPlazas.Size = new System.Drawing.Size(44, 13);
            this.lPlazas.TabIndex = 8;
            this.lPlazas.Text = "Plazas: ";
            // 
            // labelName
            // 
            this.labelName.Font = new System.Drawing.Font("Calibri", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(3, 4);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(407, 23);
            this.labelName.TabIndex = 4;
            this.labelName.Text = "Nombre";
            // 
            // lDescripcion
            // 
            this.lDescripcion.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lDescripcion.Location = new System.Drawing.Point(144, 33);
            this.lDescripcion.Name = "lDescripcion";
            this.lDescripcion.Size = new System.Drawing.Size(266, 43);
            this.lDescripcion.TabIndex = 5;
            this.lDescripcion.Text = "Descripción";
            // 
            // bSolicitar
            // 
            this.bSolicitar.BackColor = System.Drawing.Color.Transparent;
            this.bSolicitar.Cursor = System.Windows.Forms.Cursors.Default;
            this.bSolicitar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.bSolicitar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bSolicitar.ForeColor = System.Drawing.Color.Black;
            this.bSolicitar.Location = new System.Drawing.Point(385, 79);
            this.bSolicitar.Name = "bSolicitar";
            this.bSolicitar.Size = new System.Drawing.Size(64, 32);
            this.bSolicitar.TabIndex = 10;
            this.bSolicitar.Text = "Solicitar";
            this.bSolicitar.UseVisualStyleBackColor = false;
            // 
            // bVerMas
            // 
            this.bVerMas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bVerMas.FlatAppearance.BorderSize = 0;
            this.bVerMas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bVerMas.Location = new System.Drawing.Point(419, 3);
            this.bVerMas.Name = "bVerMas";
            this.bVerMas.Size = new System.Drawing.Size(30, 30);
            this.bVerMas.TabIndex = 7;
            this.bVerMas.UseVisualStyleBackColor = true;
            this.bVerMas.Click += new System.EventHandler(this.bVerMas_Click);
            // 
            // pict
            // 
            this.pict.Location = new System.Drawing.Point(6, 30);
            this.pict.Name = "pict";
            this.pict.Size = new System.Drawing.Size(132, 81);
            this.pict.TabIndex = 6;
            this.pict.TabStop = false;
            // 
            // lTipoA
            // 
            this.lTipoA.AutoSize = true;
            this.lTipoA.Location = new System.Drawing.Point(235, 79);
            this.lTipoA.Name = "lTipoA";
            this.lTipoA.Size = new System.Drawing.Size(93, 13);
            this.lTipoA.TabIndex = 11;
            this.lTipoA.Text = "Tipo de Actividad:";
            // 
            // lTipoActividad
            // 
            this.lTipoActividad.AutoSize = true;
            this.lTipoActividad.Location = new System.Drawing.Point(248, 92);
            this.lTipoActividad.Name = "lTipoActividad";
            this.lTipoActividad.Size = new System.Drawing.Size(39, 13);
            this.lTipoActividad.TabIndex = 12;
            this.lTipoActividad.Text = "tipoact";
            // 
            // CartelActividadesStandard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.Controls.Add(this.panel1);
            this.Name = "CartelActividadesStandard";
            this.Size = new System.Drawing.Size(460, 122);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pict)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label lDescripcion;
        private System.Windows.Forms.PictureBox pict;
        private System.Windows.Forms.Button bVerMas;
        private System.Windows.Forms.Label lNumPlazas;
        private System.Windows.Forms.Label lPlazas;
        private System.Windows.Forms.Button bSolicitar;
        private System.Windows.Forms.Label lTipoActividad;
        private System.Windows.Forms.Label lTipoA;
    }
}
