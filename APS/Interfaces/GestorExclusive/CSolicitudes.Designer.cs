namespace APS.Interfaces.GestorExclusive
{
    partial class CSolicitudes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CSolicitudes));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNombreONG = new System.Windows.Forms.Label();
            this.labelFechNacimiento = new System.Windows.Forms.Label();
            this.labelUsuario = new System.Windows.Forms.Label();
            this.pictImagen = new System.Windows.Forms.PictureBox();
            this.lShowMail = new System.Windows.Forms.Label();
            this.lShowNombreCompleto = new System.Windows.Forms.Label();
            this.lShowFecha = new System.Windows.Forms.Label();
            this.lShowUser = new System.Windows.Forms.Label();
            this.bAceptar = new System.Windows.Forms.Button();
            this.bCancelar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bBuscar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.bBuscar);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.bCancelar);
            this.panel1.Controls.Add(this.bAceptar);
            this.panel1.Controls.Add(this.lShowUser);
            this.panel1.Controls.Add(this.lShowFecha);
            this.panel1.Controls.Add(this.lShowNombreCompleto);
            this.panel1.Controls.Add(this.lShowMail);
            this.panel1.Controls.Add(this.pictImagen);
            this.panel1.Controls.Add(this.labelFechNacimiento);
            this.panel1.Controls.Add(this.labelUsuario);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblNombreONG);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(569, 119);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(123, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 14);
            this.label1.TabIndex = 19;
            this.label1.Text = "Correo:";
            // 
            // lblNombreONG
            // 
            this.lblNombreONG.AutoSize = true;
            this.lblNombreONG.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreONG.Location = new System.Drawing.Point(123, 66);
            this.lblNombreONG.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNombreONG.Name = "lblNombreONG";
            this.lblNombreONG.Size = new System.Drawing.Size(80, 14);
            this.lblNombreONG.TabIndex = 25;
            this.lblNombreONG.Text = "Nombre ONG:";
            // 
            // labelFechNacimiento
            // 
            this.labelFechNacimiento.AutoSize = true;
            this.labelFechNacimiento.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFechNacimiento.Location = new System.Drawing.Point(123, 91);
            this.labelFechNacimiento.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelFechNacimiento.Name = "labelFechNacimiento";
            this.labelFechNacimiento.Size = new System.Drawing.Size(106, 14);
            this.labelFechNacimiento.TabIndex = 27;
            this.labelFechNacimiento.Text = "Fecha de Solicitud:";
            // 
            // labelUsuario
            // 
            this.labelUsuario.AutoSize = true;
            this.labelUsuario.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsuario.Location = new System.Drawing.Point(123, 39);
            this.labelUsuario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelUsuario.Name = "labelUsuario";
            this.labelUsuario.Size = new System.Drawing.Size(98, 14);
            this.labelUsuario.TabIndex = 26;
            this.labelUsuario.Text = "Nombre Usuario:";
            // 
            // pictImagen
            // 
            this.pictImagen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictImagen.Image = ((System.Drawing.Image)(resources.GetObject("pictImagen.Image")));
            this.pictImagen.Location = new System.Drawing.Point(11, 13);
            this.pictImagen.Margin = new System.Windows.Forms.Padding(2);
            this.pictImagen.Name = "pictImagen";
            this.pictImagen.Size = new System.Drawing.Size(97, 92);
            this.pictImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictImagen.TabIndex = 28;
            this.pictImagen.TabStop = false;
            // 
            // lShowMail
            // 
            this.lShowMail.AutoSize = true;
            this.lShowMail.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lShowMail.Location = new System.Drawing.Point(175, 14);
            this.lShowMail.Name = "lShowMail";
            this.lShowMail.Size = new System.Drawing.Size(64, 13);
            this.lShowMail.TabIndex = 29;
            this.lShowMail.Text = "No Añadido";
            // 
            // lShowNombreCompleto
            // 
            this.lShowNombreCompleto.AutoSize = true;
            this.lShowNombreCompleto.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lShowNombreCompleto.Location = new System.Drawing.Point(208, 67);
            this.lShowNombreCompleto.Name = "lShowNombreCompleto";
            this.lShowNombreCompleto.Size = new System.Drawing.Size(64, 13);
            this.lShowNombreCompleto.TabIndex = 30;
            this.lShowNombreCompleto.Text = "No Añadido";
            // 
            // lShowFecha
            // 
            this.lShowFecha.AutoSize = true;
            this.lShowFecha.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lShowFecha.Location = new System.Drawing.Point(234, 92);
            this.lShowFecha.Name = "lShowFecha";
            this.lShowFecha.Size = new System.Drawing.Size(64, 13);
            this.lShowFecha.TabIndex = 31;
            this.lShowFecha.Text = "No Añadido";
            // 
            // lShowUser
            // 
            this.lShowUser.AutoSize = true;
            this.lShowUser.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lShowUser.Location = new System.Drawing.Point(226, 40);
            this.lShowUser.Name = "lShowUser";
            this.lShowUser.Size = new System.Drawing.Size(64, 13);
            this.lShowUser.TabIndex = 32;
            this.lShowUser.Text = "No Añadido";
            // 
            // bAceptar
            // 
            this.bAceptar.BackColor = System.Drawing.Color.Transparent;
            this.bAceptar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bAceptar.BackgroundImage")));
            this.bAceptar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bAceptar.FlatAppearance.BorderSize = 0;
            this.bAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bAceptar.Location = new System.Drawing.Point(484, 5);
            this.bAceptar.Name = "bAceptar";
            this.bAceptar.Size = new System.Drawing.Size(30, 30);
            this.bAceptar.TabIndex = 33;
            this.bAceptar.UseVisualStyleBackColor = false;
            // 
            // bCancelar
            // 
            this.bCancelar.BackColor = System.Drawing.Color.Transparent;
            this.bCancelar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bCancelar.BackgroundImage")));
            this.bCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bCancelar.FlatAppearance.BorderSize = 0;
            this.bCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bCancelar.Location = new System.Drawing.Point(525, 5);
            this.bCancelar.Name = "bCancelar";
            this.bCancelar.Size = new System.Drawing.Size(30, 30);
            this.bCancelar.TabIndex = 34;
            this.bCancelar.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(471, 40);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 14);
            this.label2.TabIndex = 35;
            this.label2.Text = "Aceptar Denegar";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(488, 86);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 32);
            this.label3.TabIndex = 37;
            this.label3.Text = "<<     Buscar Información";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bBuscar
            // 
            this.bBuscar.BackColor = System.Drawing.Color.Transparent;
            this.bBuscar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bBuscar.BackgroundImage")));
            this.bBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bBuscar.FlatAppearance.BorderSize = 0;
            this.bBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bBuscar.Location = new System.Drawing.Point(453, 83);
            this.bBuscar.Name = "bBuscar";
            this.bBuscar.Size = new System.Drawing.Size(30, 30);
            this.bBuscar.TabIndex = 36;
            this.bBuscar.UseVisualStyleBackColor = false;
            this.bBuscar.Click += new System.EventHandler(this.bBuscar_Click);
            // 
            // CSolicitudes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Plum;
            this.Controls.Add(this.panel1);
            this.Name = "CSolicitudes";
            this.Size = new System.Drawing.Size(575, 125);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictImagen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNombreONG;
        private System.Windows.Forms.Label labelFechNacimiento;
        private System.Windows.Forms.Label labelUsuario;
        private System.Windows.Forms.Label lShowUser;
        private System.Windows.Forms.Label lShowFecha;
        private System.Windows.Forms.Label lShowNombreCompleto;
        private System.Windows.Forms.Label lShowMail;
        private System.Windows.Forms.PictureBox pictImagen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bBuscar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bCancelar;
        private System.Windows.Forms.Button bAceptar;
    }
}
