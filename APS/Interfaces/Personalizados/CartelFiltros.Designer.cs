namespace APS.Interfaces.Personalizados
{
    partial class CartelFiltros
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CartelFiltros));
            this.panel1 = new System.Windows.Forms.Panel();
            this.datePickerIni = new System.Windows.Forms.DateTimePicker();
            this.cHoras = new System.Windows.Forms.ComboBox();
            this.cTurno = new System.Windows.Forms.ComboBox();
            this.cTipoAct = new System.Windows.Forms.ComboBox();
            this.cAsig = new System.Windows.Forms.ComboBox();
            this.cGrado = new System.Windows.Forms.ComboBox();
            this.lFecha = new System.Windows.Forms.Label();
            this.lTipoAct = new System.Windows.Forms.Label();
            this.lAsig = new System.Windows.Forms.Label();
            this.lHoras = new System.Windows.Forms.Label();
            this.lGrado = new System.Windows.Forms.Label();
            this.bAplicar = new System.Windows.Forms.Button();
            this.lTurno = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.datePickerIni);
            this.panel1.Controls.Add(this.cHoras);
            this.panel1.Controls.Add(this.cTurno);
            this.panel1.Controls.Add(this.cTipoAct);
            this.panel1.Controls.Add(this.cAsig);
            this.panel1.Controls.Add(this.cGrado);
            this.panel1.Controls.Add(this.lFecha);
            this.panel1.Controls.Add(this.lTipoAct);
            this.panel1.Controls.Add(this.lAsig);
            this.panel1.Controls.Add(this.lHoras);
            this.panel1.Controls.Add(this.lGrado);
            this.panel1.Controls.Add(this.bAplicar);
            this.panel1.Controls.Add(this.lTurno);
            this.panel1.Location = new System.Drawing.Point(15, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(599, 120);
            this.panel1.TabIndex = 3;
            // 
            // datePickerIni
            // 
            this.datePickerIni.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datePickerIni.Location = new System.Drawing.Point(88, 86);
            this.datePickerIni.Name = "datePickerIni";
            this.datePickerIni.Size = new System.Drawing.Size(200, 21);
            this.datePickerIni.TabIndex = 25;
            // 
            // cHoras
            // 
            this.cHoras.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cHoras.FormattingEnabled = true;
            this.cHoras.Location = new System.Drawing.Point(365, 88);
            this.cHoras.Name = "cHoras";
            this.cHoras.Size = new System.Drawing.Size(109, 21);
            this.cHoras.TabIndex = 24;
            // 
            // cTurno
            // 
            this.cTurno.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cTurno.FormattingEnabled = true;
            this.cTurno.Location = new System.Drawing.Point(365, 59);
            this.cTurno.Name = "cTurno";
            this.cTurno.Size = new System.Drawing.Size(109, 21);
            this.cTurno.TabIndex = 23;
            // 
            // cTipoAct
            // 
            this.cTipoAct.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cTipoAct.FormattingEnabled = true;
            this.cTipoAct.Location = new System.Drawing.Point(114, 59);
            this.cTipoAct.Name = "cTipoAct";
            this.cTipoAct.Size = new System.Drawing.Size(109, 21);
            this.cTipoAct.TabIndex = 22;
            // 
            // cAsig
            // 
            this.cAsig.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cAsig.FormattingEnabled = true;
            this.cAsig.Location = new System.Drawing.Point(85, 33);
            this.cAsig.Name = "cAsig";
            this.cAsig.Size = new System.Drawing.Size(358, 21);
            this.cAsig.TabIndex = 21;
            // 
            // cGrado
            // 
            this.cGrado.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cGrado.FormattingEnabled = true;
            this.cGrado.Location = new System.Drawing.Point(60, 8);
            this.cGrado.Name = "cGrado";
            this.cGrado.Size = new System.Drawing.Size(384, 21);
            this.cGrado.TabIndex = 20;
            // 
            // lFecha
            // 
            this.lFecha.AutoSize = true;
            this.lFecha.Font = new System.Drawing.Font("Bahnschrift", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lFecha.Location = new System.Drawing.Point(15, 91);
            this.lFecha.Name = "lFecha";
            this.lFecha.Size = new System.Drawing.Size(67, 13);
            this.lFecha.TabIndex = 19;
            this.lFecha.Text = "Fecha Inicio:";
            // 
            // lTipoAct
            // 
            this.lTipoAct.AutoSize = true;
            this.lTipoAct.Font = new System.Drawing.Font("Bahnschrift", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTipoAct.Location = new System.Drawing.Point(15, 62);
            this.lTipoAct.Name = "lTipoAct";
            this.lTipoAct.Size = new System.Drawing.Size(93, 13);
            this.lTipoAct.TabIndex = 18;
            this.lTipoAct.Text = "Tipo de Actividad:";
            // 
            // lAsig
            // 
            this.lAsig.AutoSize = true;
            this.lAsig.Font = new System.Drawing.Font("Bahnschrift", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lAsig.Location = new System.Drawing.Point(15, 36);
            this.lAsig.Name = "lAsig";
            this.lAsig.Size = new System.Drawing.Size(64, 13);
            this.lAsig.TabIndex = 14;
            this.lAsig.Text = "Asignatura:";
            // 
            // lHoras
            // 
            this.lHoras.AutoSize = true;
            this.lHoras.Font = new System.Drawing.Font("Bahnschrift", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lHoras.Location = new System.Drawing.Point(322, 91);
            this.lHoras.Name = "lHoras";
            this.lHoras.Size = new System.Drawing.Size(39, 13);
            this.lHoras.TabIndex = 13;
            this.lHoras.Text = "Horas:";
            // 
            // lGrado
            // 
            this.lGrado.AutoSize = true;
            this.lGrado.Font = new System.Drawing.Font("Bahnschrift", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lGrado.Location = new System.Drawing.Point(15, 11);
            this.lGrado.Name = "lGrado";
            this.lGrado.Size = new System.Drawing.Size(39, 13);
            this.lGrado.TabIndex = 11;
            this.lGrado.Text = "Grado:";
            // 
            // bAplicar
            // 
            this.bAplicar.BackColor = System.Drawing.Color.Transparent;
            this.bAplicar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bAplicar.BackgroundImage")));
            this.bAplicar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bAplicar.Cursor = System.Windows.Forms.Cursors.Default;
            this.bAplicar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.bAplicar.FlatAppearance.BorderSize = 0;
            this.bAplicar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bAplicar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bAplicar.ForeColor = System.Drawing.Color.Black;
            this.bAplicar.Location = new System.Drawing.Point(550, 75);
            this.bAplicar.Name = "bAplicar";
            this.bAplicar.Size = new System.Drawing.Size(46, 42);
            this.bAplicar.TabIndex = 10;
            this.bAplicar.UseVisualStyleBackColor = false;
            // 
            // lTurno
            // 
            this.lTurno.AutoSize = true;
            this.lTurno.Font = new System.Drawing.Font("Bahnschrift", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTurno.Location = new System.Drawing.Point(322, 62);
            this.lTurno.Name = "lTurno";
            this.lTurno.Size = new System.Drawing.Size(37, 13);
            this.lTurno.TabIndex = 8;
            this.lTurno.Text = "Turno:";
            // 
            // CartelFiltros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tomato;
            this.Controls.Add(this.panel1);
            this.Name = "CartelFiltros";
            this.Size = new System.Drawing.Size(629, 153);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lTurno;
        private System.Windows.Forms.Button bAplicar;
        private System.Windows.Forms.Label lGrado;
        private System.Windows.Forms.Label lAsig;
        private System.Windows.Forms.Label lHoras;
        private System.Windows.Forms.Label lTipoAct;
        private System.Windows.Forms.DateTimePicker datePickerIni;
        private System.Windows.Forms.ComboBox cHoras;
        private System.Windows.Forms.ComboBox cTurno;
        private System.Windows.Forms.ComboBox cTipoAct;
        private System.Windows.Forms.ComboBox cAsig;
        private System.Windows.Forms.ComboBox cGrado;
        private System.Windows.Forms.Label lFecha;
    }
}
