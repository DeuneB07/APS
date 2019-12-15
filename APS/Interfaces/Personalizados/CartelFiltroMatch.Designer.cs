namespace APS.Interfaces.Personalizados
{
    partial class CartelFiltroMatch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CartelFiltroMatch));
            this.panel1 = new System.Windows.Forms.Panel();
            this.bAplicar = new System.Windows.Forms.Button();
            this.cPreferencia = new System.Windows.Forms.ComboBox();
            this.lFiltro = new System.Windows.Forms.Label();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.bAplicar);
            this.panel1.Controls.Add(this.cPreferencia);
            this.panel1.Controls.Add(this.lFiltro);
            this.panel1.Controls.Add(this.labelTitulo);
            this.panel1.Location = new System.Drawing.Point(17, 15);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(598, 75);
            this.panel1.TabIndex = 3;
            // 
            // bAplicar
            // 
            this.bAplicar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bAplicar.BackgroundImage")));
            this.bAplicar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bAplicar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bAplicar.FlatAppearance.BorderSize = 0;
            this.bAplicar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bAplicar.Location = new System.Drawing.Point(527, 4);
            this.bAplicar.Name = "bAplicar";
            this.bAplicar.Size = new System.Drawing.Size(68, 68);
            this.bAplicar.TabIndex = 4;
            this.bAplicar.UseVisualStyleBackColor = true;
            // 
            // cPreferencia
            // 
            this.cPreferencia.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cPreferencia.FormattingEnabled = true;
            this.cPreferencia.Location = new System.Drawing.Point(99, 36);
            this.cPreferencia.Name = "cPreferencia";
            this.cPreferencia.Size = new System.Drawing.Size(367, 21);
            this.cPreferencia.TabIndex = 7;
            // 
            // lFiltro
            // 
            this.lFiltro.AutoSize = true;
            this.lFiltro.Font = new System.Drawing.Font("Bahnschrift", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lFiltro.Location = new System.Drawing.Point(26, 39);
            this.lFiltro.Name = "lFiltro";
            this.lFiltro.Size = new System.Drawing.Size(67, 13);
            this.lFiltro.TabIndex = 5;
            this.lFiltro.Text = "Preferencia:";
            // 
            // labelTitulo
            // 
            this.labelTitulo.Font = new System.Drawing.Font("Bahnschrift", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitulo.Location = new System.Drawing.Point(3, 4);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(214, 23);
            this.labelTitulo.TabIndex = 4;
            this.labelTitulo.Text = "Elija Preferencia Para Buscar";
            // 
            // CartelFiltroMatch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.Controls.Add(this.panel1);
            this.Name = "CartelFiltroMatch";
            this.Size = new System.Drawing.Size(629, 103);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.ComboBox cPreferencia;
        private System.Windows.Forms.Label lFiltro;
        private System.Windows.Forms.Button bAplicar;
    }
}