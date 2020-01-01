namespace APS.Interfaces.Personalizados
{
    partial class CartelSolicitantesActividad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CartelSolicitantesActividad));
            this.panel1 = new System.Windows.Forms.Panel();
            this.bAceptar = new System.Windows.Forms.Button();
            this.lShowNick = new System.Windows.Forms.Label();
            this.lNick = new System.Windows.Forms.Label();
            this.lNacimiento = new System.Windows.Forms.Label();
            this.lRol = new System.Windows.Forms.Label();
            this.lShowRol = new System.Windows.Forms.Label();
            this.lShowNac = new System.Windows.Forms.Label();
            this.bDenegar = new System.Windows.Forms.Button();
            this.lShowMail = new System.Windows.Forms.Label();
            this.lMail = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.lblGrado = new System.Windows.Forms.Label();
            this.lGrado = new System.Windows.Forms.Label();
            this.lblAsignaturas = new System.Windows.Forms.Label();
            this.bVerTodo = new System.Windows.Forms.Button();
            this.pict = new System.Windows.Forms.PictureBox();
            this.listAsig = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pict)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.listAsig);
            this.panel1.Controls.Add(this.lblAsignaturas);
            this.panel1.Controls.Add(this.lGrado);
            this.panel1.Controls.Add(this.lblGrado);
            this.panel1.Controls.Add(this.bVerTodo);
            this.panel1.Controls.Add(this.bAceptar);
            this.panel1.Controls.Add(this.lShowNick);
            this.panel1.Controls.Add(this.lNick);
            this.panel1.Controls.Add(this.lNacimiento);
            this.panel1.Controls.Add(this.lRol);
            this.panel1.Controls.Add(this.lShowRol);
            this.panel1.Controls.Add(this.lShowNac);
            this.panel1.Controls.Add(this.bDenegar);
            this.panel1.Controls.Add(this.lShowMail);
            this.panel1.Controls.Add(this.lMail);
            this.panel1.Controls.Add(this.labelName);
            this.panel1.Controls.Add(this.pict);
            this.panel1.Location = new System.Drawing.Point(4, 4);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(681, 143);
            this.panel1.TabIndex = 3;
            // 
            // bAceptar
            // 
            this.bAceptar.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.bAceptar.Cursor = System.Windows.Forms.Cursors.Default;
            this.bAceptar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.bAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bAceptar.ForeColor = System.Drawing.Color.Black;
            this.bAceptar.Location = new System.Drawing.Point(570, 51);
            this.bAceptar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bAceptar.Name = "bAceptar";
            this.bAceptar.Size = new System.Drawing.Size(107, 39);
            this.bAceptar.TabIndex = 17;
            this.bAceptar.Text = "Aceptar";
            this.bAceptar.UseVisualStyleBackColor = false;
            // 
            // lShowNick
            // 
            this.lShowNick.AutoSize = true;
            this.lShowNick.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lShowNick.Location = new System.Drawing.Point(213, 37);
            this.lShowNick.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lShowNick.Name = "lShowNick";
            this.lShowNick.Size = new System.Drawing.Size(34, 17);
            this.lShowNick.TabIndex = 16;
            this.lShowNick.Text = "nick";
            // 
            // lNick
            // 
            this.lNick.AutoSize = true;
            this.lNick.BackColor = System.Drawing.Color.Transparent;
            this.lNick.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lNick.Location = new System.Drawing.Point(141, 37);
            this.lNick.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lNick.Name = "lNick";
            this.lNick.Size = new System.Drawing.Size(63, 17);
            this.lNick.TabIndex = 15;
            this.lNick.Text = "Nombre:";
            // 
            // lNacimiento
            // 
            this.lNacimiento.AutoSize = true;
            this.lNacimiento.BackColor = System.Drawing.Color.Transparent;
            this.lNacimiento.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lNacimiento.Location = new System.Drawing.Point(141, 111);
            this.lNacimiento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lNacimiento.Name = "lNacimiento";
            this.lNacimiento.Size = new System.Drawing.Size(122, 17);
            this.lNacimiento.TabIndex = 14;
            this.lNacimiento.Text = "Fech. Nacimiento:";
            // 
            // lRol
            // 
            this.lRol.AutoSize = true;
            this.lRol.BackColor = System.Drawing.Color.Transparent;
            this.lRol.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lRol.Location = new System.Drawing.Point(141, 62);
            this.lRol.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lRol.Name = "lRol";
            this.lRol.Size = new System.Drawing.Size(32, 17);
            this.lRol.TabIndex = 13;
            this.lRol.Text = "Rol:";
            // 
            // lShowRol
            // 
            this.lShowRol.AutoSize = true;
            this.lShowRol.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lShowRol.Location = new System.Drawing.Point(182, 62);
            this.lShowRol.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lShowRol.Name = "lShowRol";
            this.lShowRol.Size = new System.Drawing.Size(41, 17);
            this.lShowRol.TabIndex = 12;
            this.lShowRol.Text = "rolex";
            // 
            // lShowNac
            // 
            this.lShowNac.AutoSize = true;
            this.lShowNac.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lShowNac.Location = new System.Drawing.Point(273, 111);
            this.lShowNac.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lShowNac.Name = "lShowNac";
            this.lShowNac.Size = new System.Drawing.Size(30, 17);
            this.lShowNac.TabIndex = 11;
            this.lShowNac.Text = "nac";
            // 
            // bDenegar
            // 
            this.bDenegar.BackColor = System.Drawing.Color.Salmon;
            this.bDenegar.Cursor = System.Windows.Forms.Cursors.Default;
            this.bDenegar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.bDenegar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bDenegar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bDenegar.ForeColor = System.Drawing.Color.Black;
            this.bDenegar.Location = new System.Drawing.Point(570, 98);
            this.bDenegar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bDenegar.Name = "bDenegar";
            this.bDenegar.Size = new System.Drawing.Size(107, 39);
            this.bDenegar.TabIndex = 10;
            this.bDenegar.Text = "Denegar";
            this.bDenegar.UseVisualStyleBackColor = false;
            // 
            // lShowMail
            // 
            this.lShowMail.AutoSize = true;
            this.lShowMail.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lShowMail.Location = new System.Drawing.Point(204, 86);
            this.lShowMail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lShowMail.Name = "lShowMail";
            this.lShowMail.Size = new System.Drawing.Size(43, 17);
            this.lShowMail.TabIndex = 9;
            this.lShowMail.Text = "email";
            // 
            // lMail
            // 
            this.lMail.AutoSize = true;
            this.lMail.BackColor = System.Drawing.Color.Transparent;
            this.lMail.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lMail.Location = new System.Drawing.Point(141, 86);
            this.lMail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lMail.Name = "lMail";
            this.lMail.Size = new System.Drawing.Size(53, 17);
            this.lMail.TabIndex = 8;
            this.lMail.Text = "e-mail:";
            // 
            // labelName
            // 
            this.labelName.Font = new System.Drawing.Font("Bahnschrift", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(4, 5);
            this.labelName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(543, 28);
            this.labelName.TabIndex = 4;
            this.labelName.Text = "Nombre";
            // 
            // lblGrado
            // 
            this.lblGrado.AutoSize = true;
            this.lblGrado.BackColor = System.Drawing.Color.Transparent;
            this.lblGrado.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrado.Location = new System.Drawing.Point(361, 37);
            this.lblGrado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGrado.Name = "lblGrado";
            this.lblGrado.Size = new System.Drawing.Size(49, 17);
            this.lblGrado.TabIndex = 19;
            this.lblGrado.Text = "Grado:";
            this.lblGrado.Visible = false;
            // 
            // lGrado
            // 
            this.lGrado.AutoSize = true;
            this.lGrado.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lGrado.Location = new System.Drawing.Point(433, 37);
            this.lGrado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lGrado.Name = "lGrado";
            this.lGrado.Size = new System.Drawing.Size(45, 17);
            this.lGrado.TabIndex = 20;
            this.lGrado.Text = "grado";
            this.lGrado.Visible = false;
            // 
            // lblAsignaturas
            // 
            this.lblAsignaturas.AutoSize = true;
            this.lblAsignaturas.BackColor = System.Drawing.Color.Transparent;
            this.lblAsignaturas.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAsignaturas.Location = new System.Drawing.Point(323, 62);
            this.lblAsignaturas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAsignaturas.Name = "lblAsignaturas";
            this.lblAsignaturas.Size = new System.Drawing.Size(87, 17);
            this.lblAsignaturas.TabIndex = 21;
            this.lblAsignaturas.Text = "Asignaturas:";
            this.lblAsignaturas.Visible = false;
            // 
            // bVerTodo
            // 
            this.bVerTodo.BackColor = System.Drawing.Color.White;
            this.bVerTodo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bVerTodo.BackgroundImage")));
            this.bVerTodo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bVerTodo.Cursor = System.Windows.Forms.Cursors.Default;
            this.bVerTodo.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.bVerTodo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bVerTodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bVerTodo.ForeColor = System.Drawing.Color.Black;
            this.bVerTodo.Location = new System.Drawing.Point(612, 7);
            this.bVerTodo.Margin = new System.Windows.Forms.Padding(4);
            this.bVerTodo.Name = "bVerTodo";
            this.bVerTodo.Size = new System.Drawing.Size(41, 37);
            this.bVerTodo.TabIndex = 18;
            this.bVerTodo.UseVisualStyleBackColor = false;
            this.bVerTodo.Visible = false;
            this.bVerTodo.Click += new System.EventHandler(this.bVerTodo_Click);
            // 
            // pict
            // 
            this.pict.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pict.Image = global::APS.Properties.Resources.userDefault;
            this.pict.Location = new System.Drawing.Point(8, 37);
            this.pict.Margin = new System.Windows.Forms.Padding(4);
            this.pict.Name = "pict";
            this.pict.Size = new System.Drawing.Size(114, 100);
            this.pict.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pict.TabIndex = 6;
            this.pict.TabStop = false;
            // 
            // listAsig
            // 
            this.listAsig.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.listAsig.DropDownWidth = 350;
            this.listAsig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.listAsig.FormattingEnabled = true;
            this.listAsig.Location = new System.Drawing.Point(417, 60);
            this.listAsig.Name = "listAsig";
            this.listAsig.Size = new System.Drawing.Size(22, 24);
            this.listAsig.TabIndex = 23;
            this.listAsig.Visible = false;
            this.listAsig.SelectedIndexChanged += new System.EventHandler(this.listAsig_SelectedIndexChanged);
            // 
            // CartelSolicitantesActividad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Chocolate;
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "CartelSolicitantesActividad";
            this.Size = new System.Drawing.Size(689, 150);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pict)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.PictureBox pict;
        private System.Windows.Forms.Label lShowMail;
        private System.Windows.Forms.Label lMail;
        private System.Windows.Forms.Button bDenegar;
        private System.Windows.Forms.Label lShowRol;
        private System.Windows.Forms.Label lShowNac;
        private System.Windows.Forms.Label lNacimiento;
        private System.Windows.Forms.Label lRol;
        private System.Windows.Forms.Button bAceptar;
        private System.Windows.Forms.Label lShowNick;
        private System.Windows.Forms.Label lNick;
        private System.Windows.Forms.Button bVerTodo;
        private System.Windows.Forms.Label lGrado;
        private System.Windows.Forms.Label lblGrado;
        private System.Windows.Forms.Label lblAsignaturas;
        private System.Windows.Forms.ComboBox listAsig;
    }
}
