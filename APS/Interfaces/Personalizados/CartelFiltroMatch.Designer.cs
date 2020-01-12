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
            this.cPreferencia = new System.Windows.Forms.ComboBox();
            this.lFiltro = new System.Windows.Forms.Label();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.bAplicar = new System.Windows.Forms.Button();
            this.gradientPanel1 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel1)).BeginInit();
            this.gradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.bAplicar);
            this.panel1.Controls.Add(this.cPreferencia);
            this.panel1.Controls.Add(this.lFiltro);
            this.panel1.Controls.Add(this.labelTitulo);
            this.panel1.Location = new System.Drawing.Point(21, 16);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(797, 92);
            this.panel1.TabIndex = 3;
            // 
            // cPreferencia
            // 
            this.cPreferencia.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cPreferencia.FormattingEnabled = true;
            this.cPreferencia.Location = new System.Drawing.Point(132, 44);
            this.cPreferencia.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cPreferencia.Name = "cPreferencia";
            this.cPreferencia.Size = new System.Drawing.Size(306, 25);
            this.cPreferencia.TabIndex = 7;
            // 
            // lFiltro
            // 
            this.lFiltro.AutoSize = true;
            this.lFiltro.Font = new System.Drawing.Font("Bahnschrift", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lFiltro.Location = new System.Drawing.Point(35, 48);
            this.lFiltro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lFiltro.Name = "lFiltro";
            this.lFiltro.Size = new System.Drawing.Size(86, 17);
            this.lFiltro.TabIndex = 5;
            this.lFiltro.Text = "Preferencia:";
            // 
            // labelTitulo
            // 
            this.labelTitulo.Font = new System.Drawing.Font("Bahnschrift", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitulo.Location = new System.Drawing.Point(4, 5);
            this.labelTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(285, 28);
            this.labelTitulo.TabIndex = 4;
            this.labelTitulo.Text = "Elija Preferencia Para Buscar";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MediumVioletRed;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Bahnschrift", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(470, 45);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Nueva Preferencia";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // bAplicar
            // 
            this.bAplicar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bAplicar.BackgroundImage")));
            this.bAplicar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bAplicar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bAplicar.FlatAppearance.BorderSize = 0;
            this.bAplicar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bAplicar.Location = new System.Drawing.Point(703, 5);
            this.bAplicar.Margin = new System.Windows.Forms.Padding(4);
            this.bAplicar.Name = "bAplicar";
            this.bAplicar.Size = new System.Drawing.Size(91, 84);
            this.bAplicar.TabIndex = 4;
            this.bAplicar.UseVisualStyleBackColor = true;
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.BackColor = System.Drawing.Color.Transparent;
            this.gradientPanel1.BackgroundColor = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Horizontal, new System.Drawing.Color[] {
            System.Drawing.Color.White,
            System.Drawing.Color.YellowGreen,
            System.Drawing.Color.DarkTurquoise,
            System.Drawing.Color.DarkCyan,
            System.Drawing.Color.MediumBlue,
            System.Drawing.Color.Magenta,
            System.Drawing.Color.DarkMagenta});
            this.gradientPanel1.Controls.Add(this.panel1);
            this.gradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(839, 127);
            this.gradientPanel1.TabIndex = 10;
            // 
            // CartelFiltroMatch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.Controls.Add(this.gradientPanel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "CartelFiltroMatch";
            this.Size = new System.Drawing.Size(839, 127);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel1)).EndInit();
            this.gradientPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.ComboBox cPreferencia;
        private System.Windows.Forms.Label lFiltro;
        private System.Windows.Forms.Button bAplicar;
        private System.Windows.Forms.Button button1;
        private Syncfusion.Windows.Forms.Tools.GradientPanel gradientPanel1;
    }
}