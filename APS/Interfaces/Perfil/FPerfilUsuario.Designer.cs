namespace APS.Interfaces
{
    partial class FPerfilUsuario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FPerfilUsuario));
            this.lNombre = new System.Windows.Forms.Label();
            this.picPerfil = new System.Windows.Forms.PictureBox();
            this.lDNI2 = new System.Windows.Forms.Label();
            this.lNombre2 = new System.Windows.Forms.Label();
            this.lFecha = new System.Windows.Forms.Label();
            this.lMail = new System.Windows.Forms.Label();
            this.lDNI = new System.Windows.Forms.Label();
            this.lMail2 = new System.Windows.Forms.Label();
            this.lFecha2 = new System.Windows.Forms.Label();
            this.bModPerfil = new System.Windows.Forms.Button();
            this.bPreferencias = new System.Windows.Forms.Button();
            this.bBaja = new System.Windows.Forms.Button();
            this.listAsignaturas = new System.Windows.Forms.ListBox();
            this.lAsignaturas = new System.Windows.Forms.Label();
            this.lGrados = new System.Windows.Forms.Label();
            this.lGradosUno = new System.Windows.Forms.Label();
            this.listGrados = new System.Windows.Forms.ListBox();
            this.bAceptarC = new System.Windows.Forms.Button();
            this.lNombreUser = new System.Windows.Forms.Label();
            this.lUserNoun2 = new System.Windows.Forms.Label();
            this.textNombreUser = new System.Windows.Forms.TextBox();
            this.bAtras = new System.Windows.Forms.Button();
            this.bCancelarC = new System.Windows.Forms.Button();
            this.tURL = new System.Windows.Forms.TextBox();
            this.btnBorrarImagen = new System.Windows.Forms.Button();
            this.btnCambiarImagen = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.picPerfil)).BeginInit();
            this.SuspendLayout();
            // 
            // lNombre
            // 
            this.lNombre.AutoSize = true;
            this.lNombre.Font = new System.Drawing.Font("Bahnschrift", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lNombre.Location = new System.Drawing.Point(68, 158);
            this.lNombre.Name = "lNombre";
            this.lNombre.Size = new System.Drawing.Size(53, 14);
            this.lNombre.TabIndex = 0;
            this.lNombre.Text = "Nombre:";
            // 
            // picPerfil
            // 
            this.picPerfil.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picPerfil.Image = ((System.Drawing.Image)(resources.GetObject("picPerfil.Image")));
            this.picPerfil.Location = new System.Drawing.Point(36, 12);
            this.picPerfil.Name = "picPerfil";
            this.picPerfil.Size = new System.Drawing.Size(93, 91);
            this.picPerfil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPerfil.TabIndex = 2;
            this.picPerfil.TabStop = false;
            // 
            // lDNI2
            // 
            this.lDNI2.AutoSize = true;
            this.lDNI2.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lDNI2.Location = new System.Drawing.Point(123, 198);
            this.lDNI2.Name = "lDNI2";
            this.lDNI2.Size = new System.Drawing.Size(31, 14);
            this.lDNI2.TabIndex = 3;
            this.lDNI2.Text = "(dni)";
            // 
            // lNombre2
            // 
            this.lNombre2.AutoSize = true;
            this.lNombre2.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lNombre2.Location = new System.Drawing.Point(123, 158);
            this.lNombre2.Name = "lNombre2";
            this.lNombre2.Size = new System.Drawing.Size(43, 14);
            this.lNombre2.TabIndex = 4;
            this.lNombre2.Text = "(noun)";
            // 
            // lFecha
            // 
            this.lFecha.AutoSize = true;
            this.lFecha.Font = new System.Drawing.Font("Bahnschrift", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lFecha.Location = new System.Drawing.Point(68, 277);
            this.lFecha.Name = "lFecha";
            this.lFecha.Size = new System.Drawing.Size(105, 14);
            this.lFecha.TabIndex = 5;
            this.lFecha.Text = "Fecha Nacimiento:";
            // 
            // lMail
            // 
            this.lMail.AutoSize = true;
            this.lMail.Font = new System.Drawing.Font("Bahnschrift", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lMail.Location = new System.Drawing.Point(68, 238);
            this.lMail.Name = "lMail";
            this.lMail.Size = new System.Drawing.Size(44, 14);
            this.lMail.TabIndex = 6;
            this.lMail.Text = "e-mail:";
            // 
            // lDNI
            // 
            this.lDNI.AutoSize = true;
            this.lDNI.Font = new System.Drawing.Font("Bahnschrift", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lDNI.Location = new System.Drawing.Point(68, 198);
            this.lDNI.Name = "lDNI";
            this.lDNI.Size = new System.Drawing.Size(29, 14);
            this.lDNI.TabIndex = 7;
            this.lDNI.Text = "DNI:";
            // 
            // lMail2
            // 
            this.lMail2.AutoSize = true;
            this.lMail2.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lMail2.Location = new System.Drawing.Point(123, 238);
            this.lMail2.Name = "lMail2";
            this.lMail2.Size = new System.Drawing.Size(43, 14);
            this.lMail2.TabIndex = 8;
            this.lMail2.Text = "(email)";
            // 
            // lFecha2
            // 
            this.lFecha2.AutoSize = true;
            this.lFecha2.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lFecha2.Location = new System.Drawing.Point(172, 277);
            this.lFecha2.Name = "lFecha2";
            this.lFecha2.Size = new System.Drawing.Size(64, 14);
            this.lFecha2.TabIndex = 9;
            this.lFecha2.Text = "(fechaNac)";
            // 
            // bModPerfil
            // 
            this.bModPerfil.Font = new System.Drawing.Font("Bahnschrift", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bModPerfil.Location = new System.Drawing.Point(68, 361);
            this.bModPerfil.Name = "bModPerfil";
            this.bModPerfil.Size = new System.Drawing.Size(98, 23);
            this.bModPerfil.TabIndex = 10;
            this.bModPerfil.Text = "Modificar Perfil";
            this.bModPerfil.UseVisualStyleBackColor = true;
            this.bModPerfil.Click += new System.EventHandler(this.bModPerfil_Click);
            // 
            // bPreferencias
            // 
            this.bPreferencias.Font = new System.Drawing.Font("Bahnschrift", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bPreferencias.Location = new System.Drawing.Point(351, 361);
            this.bPreferencias.Name = "bPreferencias";
            this.bPreferencias.Size = new System.Drawing.Size(110, 23);
            this.bPreferencias.TabIndex = 11;
            this.bPreferencias.Text = "Ver Preferencias";
            this.bPreferencias.UseVisualStyleBackColor = true;
            this.bPreferencias.Click += new System.EventHandler(this.bPreferencias_Click);
            // 
            // bBaja
            // 
            this.bBaja.Font = new System.Drawing.Font("Bahnschrift", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bBaja.Location = new System.Drawing.Point(663, 361);
            this.bBaja.Name = "bBaja";
            this.bBaja.Size = new System.Drawing.Size(98, 23);
            this.bBaja.TabIndex = 12;
            this.bBaja.Text = "Darse de Baja";
            this.bBaja.UseVisualStyleBackColor = true;
            this.bBaja.Click += new System.EventHandler(this.bBaja_Click);
            // 
            // listAsignaturas
            // 
            this.listAsignaturas.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listAsignaturas.FormattingEnabled = true;
            this.listAsignaturas.HorizontalScrollbar = true;
            this.listAsignaturas.Location = new System.Drawing.Point(467, 209);
            this.listAsignaturas.Name = "listAsignaturas";
            this.listAsignaturas.Size = new System.Drawing.Size(294, 82);
            this.listAsignaturas.TabIndex = 13;
            // 
            // lAsignaturas
            // 
            this.lAsignaturas.AutoSize = true;
            this.lAsignaturas.Font = new System.Drawing.Font("Bahnschrift", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lAsignaturas.Location = new System.Drawing.Point(336, 209);
            this.lAsignaturas.Name = "lAsignaturas";
            this.lAsignaturas.Size = new System.Drawing.Size(125, 14);
            this.lAsignaturas.TabIndex = 14;
            this.lAsignaturas.Text = "Asignaturas en Curso:";
            // 
            // lGrados
            // 
            this.lGrados.AutoSize = true;
            this.lGrados.Font = new System.Drawing.Font("Bahnschrift", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lGrados.Location = new System.Drawing.Point(348, 138);
            this.lGrados.Name = "lGrados";
            this.lGrados.Size = new System.Drawing.Size(99, 14);
            this.lGrados.TabIndex = 15;
            this.lGrados.Text = "Grados en Curso:";
            // 
            // lGradosUno
            // 
            this.lGradosUno.AutoSize = true;
            this.lGradosUno.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lGradosUno.Location = new System.Drawing.Point(464, 138);
            this.lGradosUno.Name = "lGradosUno";
            this.lGradosUno.Size = new System.Drawing.Size(83, 14);
            this.lGradosUno.TabIndex = 16;
            this.lGradosUno.Text = "(gradosSiUno)";
            // 
            // listGrados
            // 
            this.listGrados.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listGrados.FormattingEnabled = true;
            this.listGrados.HorizontalScrollbar = true;
            this.listGrados.Location = new System.Drawing.Point(466, 134);
            this.listGrados.Name = "listGrados";
            this.listGrados.Size = new System.Drawing.Size(294, 69);
            this.listGrados.TabIndex = 17;
            // 
            // bAceptarC
            // 
            this.bAceptarC.Font = new System.Drawing.Font("Bahnschrift", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bAceptarC.Location = new System.Drawing.Point(192, 361);
            this.bAceptarC.Name = "bAceptarC";
            this.bAceptarC.Size = new System.Drawing.Size(125, 23);
            this.bAceptarC.TabIndex = 18;
            this.bAceptarC.Text = "Aceptar Cambios";
            this.bAceptarC.UseVisualStyleBackColor = true;
            this.bAceptarC.Click += new System.EventHandler(this.bAceptarC_Click);
            // 
            // lNombreUser
            // 
            this.lNombreUser.AutoSize = true;
            this.lNombreUser.Font = new System.Drawing.Font("Bahnschrift", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lNombreUser.Location = new System.Drawing.Point(68, 122);
            this.lNombreUser.Name = "lNombreUser";
            this.lNombreUser.Size = new System.Drawing.Size(98, 14);
            this.lNombreUser.TabIndex = 20;
            this.lNombreUser.Text = "Nombre Usuario:";
            // 
            // lUserNoun2
            // 
            this.lUserNoun2.AutoSize = true;
            this.lUserNoun2.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lUserNoun2.Location = new System.Drawing.Point(172, 122);
            this.lUserNoun2.Name = "lUserNoun2";
            this.lUserNoun2.Size = new System.Drawing.Size(67, 14);
            this.lUserNoun2.TabIndex = 21;
            this.lUserNoun2.Text = "(usernoun)";
            // 
            // textNombreUser
            // 
            this.textNombreUser.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textNombreUser.Location = new System.Drawing.Point(172, 120);
            this.textNombreUser.Name = "textNombreUser";
            this.textNombreUser.Size = new System.Drawing.Size(100, 21);
            this.textNombreUser.TabIndex = 22;
            // 
            // bAtras
            // 
            this.bAtras.Font = new System.Drawing.Font("Bahnschrift", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bAtras.Location = new System.Drawing.Point(662, 399);
            this.bAtras.Name = "bAtras";
            this.bAtras.Size = new System.Drawing.Size(98, 23);
            this.bAtras.TabIndex = 23;
            this.bAtras.Text = "Atrás";
            this.bAtras.UseVisualStyleBackColor = true;
            this.bAtras.Click += new System.EventHandler(this.bAtras_Click);
            // 
            // bCancelarC
            // 
            this.bCancelarC.Font = new System.Drawing.Font("Bahnschrift", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bCancelarC.Location = new System.Drawing.Point(491, 361);
            this.bCancelarC.Name = "bCancelarC";
            this.bCancelarC.Size = new System.Drawing.Size(125, 23);
            this.bCancelarC.TabIndex = 24;
            this.bCancelarC.Text = "Cancelar Cambios";
            this.bCancelarC.UseVisualStyleBackColor = true;
            this.bCancelarC.Click += new System.EventHandler(this.bCancelarC_Click);
            // 
            // tURL
            // 
            this.tURL.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tURL.Location = new System.Drawing.Point(148, 10);
            this.tURL.Name = "tURL";
            this.tURL.Size = new System.Drawing.Size(100, 21);
            this.tURL.TabIndex = 44;
            this.tURL.Visible = false;
            // 
            // btnBorrarImagen
            // 
            this.btnBorrarImagen.Font = new System.Drawing.Font("Bahnschrift", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrarImagen.Location = new System.Drawing.Point(148, 76);
            this.btnBorrarImagen.Name = "btnBorrarImagen";
            this.btnBorrarImagen.Size = new System.Drawing.Size(98, 23);
            this.btnBorrarImagen.TabIndex = 43;
            this.btnBorrarImagen.Text = "Borrar Imagen";
            this.btnBorrarImagen.UseVisualStyleBackColor = true;
            this.btnBorrarImagen.Visible = false;
            this.btnBorrarImagen.Click += new System.EventHandler(this.btnBorrarImagen_Click);
            // 
            // btnCambiarImagen
            // 
            this.btnCambiarImagen.Font = new System.Drawing.Font("Bahnschrift", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCambiarImagen.Location = new System.Drawing.Point(148, 34);
            this.btnCambiarImagen.Name = "btnCambiarImagen";
            this.btnCambiarImagen.Size = new System.Drawing.Size(98, 23);
            this.btnCambiarImagen.TabIndex = 42;
            this.btnCambiarImagen.Text = "Cambiar";
            this.btnCambiarImagen.UseVisualStyleBackColor = true;
            this.btnCambiarImagen.Visible = false;
            this.btnCambiarImagen.Click += new System.EventHandler(this.btnCambiarImagen_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // FPerfilUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tURL);
            this.Controls.Add(this.btnBorrarImagen);
            this.Controls.Add(this.btnCambiarImagen);
            this.Controls.Add(this.bCancelarC);
            this.Controls.Add(this.bAtras);
            this.Controls.Add(this.textNombreUser);
            this.Controls.Add(this.lUserNoun2);
            this.Controls.Add(this.lNombreUser);
            this.Controls.Add(this.bAceptarC);
            this.Controls.Add(this.listGrados);
            this.Controls.Add(this.lGradosUno);
            this.Controls.Add(this.lGrados);
            this.Controls.Add(this.lAsignaturas);
            this.Controls.Add(this.listAsignaturas);
            this.Controls.Add(this.bBaja);
            this.Controls.Add(this.bPreferencias);
            this.Controls.Add(this.bModPerfil);
            this.Controls.Add(this.lFecha2);
            this.Controls.Add(this.lMail2);
            this.Controls.Add(this.lDNI);
            this.Controls.Add(this.lMail);
            this.Controls.Add(this.lFecha);
            this.Controls.Add(this.lNombre2);
            this.Controls.Add(this.lDNI2);
            this.Controls.Add(this.picPerfil);
            this.Controls.Add(this.lNombre);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FPerfilUsuario";
            this.Text = "Perfil";
            ((System.ComponentModel.ISupportInitialize)(this.picPerfil)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lNombre;
        private System.Windows.Forms.PictureBox picPerfil;
        private System.Windows.Forms.Label lDNI2;
        private System.Windows.Forms.Label lNombre2;
        private System.Windows.Forms.Label lFecha;
        private System.Windows.Forms.Label lMail;
        private System.Windows.Forms.Label lDNI;
        private System.Windows.Forms.Label lMail2;
        private System.Windows.Forms.Label lFecha2;
        private System.Windows.Forms.Button bModPerfil;
        private System.Windows.Forms.Button bPreferencias;
        private System.Windows.Forms.Button bBaja;
        private System.Windows.Forms.ListBox listAsignaturas;
        private System.Windows.Forms.Label lAsignaturas;
        private System.Windows.Forms.Label lGrados;
        private System.Windows.Forms.Label lGradosUno;
        private System.Windows.Forms.ListBox listGrados;
        private System.Windows.Forms.Button bAceptarC;
        private System.Windows.Forms.Label lNombreUser;
        private System.Windows.Forms.Label lUserNoun2;
        private System.Windows.Forms.TextBox textNombreUser;
        private System.Windows.Forms.Button bAtras;
        private System.Windows.Forms.Button bCancelarC;
        private System.Windows.Forms.TextBox tURL;
        private System.Windows.Forms.Button btnBorrarImagen;
        private System.Windows.Forms.Button btnCambiarImagen;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}