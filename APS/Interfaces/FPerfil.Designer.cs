namespace APS.Interfaces
{
    partial class FPerfil
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
            this.bCancelarC = new System.Windows.Forms.Button();
            this.lNombreUser = new System.Windows.Forms.Label();
            this.lUserNoun2 = new System.Windows.Forms.Label();
            this.textNombreUser = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picPerfil)).BeginInit();
            this.SuspendLayout();
            // 
            // lNombre
            // 
            this.lNombre.AutoSize = true;
            this.lNombre.Font = new System.Drawing.Font("Calibri Light", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lNombre.Location = new System.Drawing.Point(68, 158);
            this.lNombre.Name = "lNombre";
            this.lNombre.Size = new System.Drawing.Size(49, 14);
            this.lNombre.TabIndex = 0;
            this.lNombre.Text = "Nombre:";
            // 
            // picPerfil
            // 
            this.picPerfil.Location = new System.Drawing.Point(36, 12);
            this.picPerfil.Name = "picPerfil";
            this.picPerfil.Size = new System.Drawing.Size(92, 91);
            this.picPerfil.TabIndex = 2;
            this.picPerfil.TabStop = false;
            // 
            // lDNI2
            // 
            this.lDNI2.AutoSize = true;
            this.lDNI2.Font = new System.Drawing.Font("Calibri Light", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lDNI2.Location = new System.Drawing.Point(123, 198);
            this.lDNI2.Name = "lDNI2";
            this.lDNI2.Size = new System.Drawing.Size(30, 14);
            this.lDNI2.TabIndex = 3;
            this.lDNI2.Text = "(dni)";
            // 
            // lNombre2
            // 
            this.lNombre2.AutoSize = true;
            this.lNombre2.Font = new System.Drawing.Font("Calibri Light", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lNombre2.Location = new System.Drawing.Point(123, 158);
            this.lNombre2.Name = "lNombre2";
            this.lNombre2.Size = new System.Drawing.Size(39, 14);
            this.lNombre2.TabIndex = 4;
            this.lNombre2.Text = "(noun)";
            // 
            // lFecha
            // 
            this.lFecha.AutoSize = true;
            this.lFecha.Font = new System.Drawing.Font("Calibri Light", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lFecha.Location = new System.Drawing.Point(68, 277);
            this.lFecha.Name = "lFecha";
            this.lFecha.Size = new System.Drawing.Size(98, 14);
            this.lFecha.TabIndex = 5;
            this.lFecha.Text = "Fecha Nacimiento:";
            // 
            // lMail
            // 
            this.lMail.AutoSize = true;
            this.lMail.Font = new System.Drawing.Font("Calibri Light", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lMail.Location = new System.Drawing.Point(68, 238);
            this.lMail.Name = "lMail";
            this.lMail.Size = new System.Drawing.Size(41, 14);
            this.lMail.TabIndex = 6;
            this.lMail.Text = "e-mail:";
            // 
            // lDNI
            // 
            this.lDNI.AutoSize = true;
            this.lDNI.Font = new System.Drawing.Font("Calibri Light", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lDNI.Location = new System.Drawing.Point(68, 198);
            this.lDNI.Name = "lDNI";
            this.lDNI.Size = new System.Drawing.Size(28, 14);
            this.lDNI.TabIndex = 7;
            this.lDNI.Text = "DNI:";
            // 
            // lMail2
            // 
            this.lMail2.AutoSize = true;
            this.lMail2.Font = new System.Drawing.Font("Calibri Light", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lMail2.Location = new System.Drawing.Point(123, 238);
            this.lMail2.Name = "lMail2";
            this.lMail2.Size = new System.Drawing.Size(42, 14);
            this.lMail2.TabIndex = 8;
            this.lMail2.Text = "(email)";
            // 
            // lFecha2
            // 
            this.lFecha2.AutoSize = true;
            this.lFecha2.Font = new System.Drawing.Font("Calibri Light", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lFecha2.Location = new System.Drawing.Point(172, 277);
            this.lFecha2.Name = "lFecha2";
            this.lFecha2.Size = new System.Drawing.Size(61, 14);
            this.lFecha2.TabIndex = 9;
            this.lFecha2.Text = "(fechaNac)";
            // 
            // bModPerfil
            // 
            this.bModPerfil.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.bPreferencias.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bPreferencias.Location = new System.Drawing.Point(351, 361);
            this.bPreferencias.Name = "bPreferencias";
            this.bPreferencias.Size = new System.Drawing.Size(98, 23);
            this.bPreferencias.TabIndex = 11;
            this.bPreferencias.Text = "Ver Preferencias";
            this.bPreferencias.UseVisualStyleBackColor = true;
            // 
            // bBaja
            // 
            this.bBaja.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.listAsignaturas.FormattingEnabled = true;
            this.listAsignaturas.Location = new System.Drawing.Point(467, 209);
            this.listAsignaturas.Name = "listAsignaturas";
            this.listAsignaturas.Size = new System.Drawing.Size(294, 82);
            this.listAsignaturas.TabIndex = 13;
            // 
            // lAsignaturas
            // 
            this.lAsignaturas.AutoSize = true;
            this.lAsignaturas.Font = new System.Drawing.Font("Calibri Light", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lAsignaturas.Location = new System.Drawing.Point(348, 209);
            this.lAsignaturas.Name = "lAsignaturas";
            this.lAsignaturas.Size = new System.Drawing.Size(113, 14);
            this.lAsignaturas.TabIndex = 14;
            this.lAsignaturas.Text = "Asignaturas en Curso:";
            // 
            // lGrados
            // 
            this.lGrados.AutoSize = true;
            this.lGrados.Font = new System.Drawing.Font("Calibri Light", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lGrados.Location = new System.Drawing.Point(348, 138);
            this.lGrados.Name = "lGrados";
            this.lGrados.Size = new System.Drawing.Size(90, 14);
            this.lGrados.TabIndex = 15;
            this.lGrados.Text = "Grados en Curso:";
            // 
            // lGradosUno
            // 
            this.lGradosUno.AutoSize = true;
            this.lGradosUno.Font = new System.Drawing.Font("Calibri Light", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lGradosUno.Location = new System.Drawing.Point(464, 138);
            this.lGradosUno.Name = "lGradosUno";
            this.lGradosUno.Size = new System.Drawing.Size(76, 14);
            this.lGradosUno.TabIndex = 16;
            this.lGradosUno.Text = "(gradosSiUno)";
            // 
            // listGrados
            // 
            this.listGrados.FormattingEnabled = true;
            this.listGrados.Location = new System.Drawing.Point(467, 134);
            this.listGrados.Name = "listGrados";
            this.listGrados.Size = new System.Drawing.Size(294, 69);
            this.listGrados.TabIndex = 17;
            // 
            // bAceptarC
            // 
            this.bAceptarC.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bAceptarC.Location = new System.Drawing.Point(192, 361);
            this.bAceptarC.Name = "bAceptarC";
            this.bAceptarC.Size = new System.Drawing.Size(125, 23);
            this.bAceptarC.TabIndex = 18;
            this.bAceptarC.Text = "Aceptar Cambios";
            this.bAceptarC.UseVisualStyleBackColor = true;
            this.bAceptarC.Click += new System.EventHandler(this.bAceptarC_Click);
            // 
            // bCancelarC
            // 
            this.bCancelarC.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bCancelarC.Location = new System.Drawing.Point(498, 361);
            this.bCancelarC.Name = "bCancelarC";
            this.bCancelarC.Size = new System.Drawing.Size(125, 23);
            this.bCancelarC.TabIndex = 19;
            this.bCancelarC.Text = "Cancelar Cambios";
            this.bCancelarC.UseVisualStyleBackColor = true;
            this.bCancelarC.Click += new System.EventHandler(this.bCancelarC_Click);
            // 
            // lNombreUser
            // 
            this.lNombreUser.AutoSize = true;
            this.lNombreUser.Font = new System.Drawing.Font("Calibri Light", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lNombreUser.Location = new System.Drawing.Point(68, 122);
            this.lNombreUser.Name = "lNombreUser";
            this.lNombreUser.Size = new System.Drawing.Size(90, 14);
            this.lNombreUser.TabIndex = 20;
            this.lNombreUser.Text = "Nombre Usuario:";
            // 
            // lUserNoun2
            // 
            this.lUserNoun2.AutoSize = true;
            this.lUserNoun2.Font = new System.Drawing.Font("Calibri Light", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lUserNoun2.Location = new System.Drawing.Point(172, 122);
            this.lUserNoun2.Name = "lUserNoun2";
            this.lUserNoun2.Size = new System.Drawing.Size(60, 14);
            this.lUserNoun2.TabIndex = 21;
            this.lUserNoun2.Text = "(usernoun)";
            // 
            // textNombreUser
            // 
            this.textNombreUser.Location = new System.Drawing.Point(175, 119);
            this.textNombreUser.Name = "textNombreUser";
            this.textNombreUser.Size = new System.Drawing.Size(100, 20);
            this.textNombreUser.TabIndex = 22;
            // 
            // FPerfil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textNombreUser);
            this.Controls.Add(this.lUserNoun2);
            this.Controls.Add(this.lNombreUser);
            this.Controls.Add(this.bCancelarC);
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
            this.Name = "FPerfil";
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
        private System.Windows.Forms.Button bCancelarC;
        private System.Windows.Forms.Label lNombreUser;
        private System.Windows.Forms.Label lUserNoun2;
        private System.Windows.Forms.TextBox textNombreUser;
    }
}