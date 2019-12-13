namespace APS.Interfaces.Perfil
{
    partial class FPerfilPAS
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
            this.lShowFecha = new System.Windows.Forms.Label();
            this.lFechaNac = new System.Windows.Forms.Label();
            this.modiUser = new System.Windows.Forms.TextBox();
            this.bCancelarC = new System.Windows.Forms.Button();
            this.bAtras = new System.Windows.Forms.Button();
            this.lNombreUser = new System.Windows.Forms.Label();
            this.bAceptarC = new System.Windows.Forms.Button();
            this.bBaja = new System.Windows.Forms.Button();
            this.bModPerfil = new System.Windows.Forms.Button();
            this.lShowMail = new System.Windows.Forms.Label();
            this.lMail = new System.Windows.Forms.Label();
            this.lShowNombre = new System.Windows.Forms.Label();
            this.lNombre = new System.Windows.Forms.Label();
            this.pict = new System.Windows.Forms.PictureBox();
            this.bPreferencias = new System.Windows.Forms.Button();
            this.lDNI = new System.Windows.Forms.Label();
            this.lShowDNI = new System.Windows.Forms.Label();
            this.lShowUser = new System.Windows.Forms.Label();
            this.modiDNI = new System.Windows.Forms.TextBox();
            this.dateNac = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.pict)).BeginInit();
            this.SuspendLayout();
            // 
            // lShowFecha
            // 
            this.lShowFecha.AutoSize = true;
            this.lShowFecha.Font = new System.Drawing.Font("Calibri Light", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lShowFecha.Location = new System.Drawing.Point(155, 321);
            this.lShowFecha.Name = "lShowFecha";
            this.lShowFecha.Size = new System.Drawing.Size(56, 14);
            this.lShowFecha.TabIndex = 52;
            this.lShowFecha.Text = "(fechains)";
            // 
            // lFechaNac
            // 
            this.lFechaNac.AutoSize = true;
            this.lFechaNac.Font = new System.Drawing.Font("Calibri Light", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lFechaNac.Location = new System.Drawing.Point(19, 321);
            this.lFechaNac.Name = "lFechaNac";
            this.lFechaNac.Size = new System.Drawing.Size(133, 14);
            this.lFechaNac.TabIndex = 51;
            this.lFechaNac.Text = "Fecha de Nacimiento:";
            // 
            // modiUser
            // 
            this.modiUser.Location = new System.Drawing.Point(130, 169);
            this.modiUser.Name = "modiUser";
            this.modiUser.Size = new System.Drawing.Size(100, 20);
            this.modiUser.TabIndex = 48;
            // 
            // bCancelarC
            // 
            this.bCancelarC.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bCancelarC.Location = new System.Drawing.Point(130, 415);
            this.bCancelarC.Name = "bCancelarC";
            this.bCancelarC.Size = new System.Drawing.Size(125, 23);
            this.bCancelarC.TabIndex = 50;
            this.bCancelarC.Text = "Cancelar Cambios";
            this.bCancelarC.UseVisualStyleBackColor = true;
            this.bCancelarC.Click += new System.EventHandler(this.bCancelarC_Click);
            // 
            // bAtras
            // 
            this.bAtras.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bAtras.Location = new System.Drawing.Point(277, 415);
            this.bAtras.Name = "bAtras";
            this.bAtras.Size = new System.Drawing.Size(98, 23);
            this.bAtras.TabIndex = 49;
            this.bAtras.Text = "Atrás";
            this.bAtras.UseVisualStyleBackColor = true;
            this.bAtras.Click += new System.EventHandler(this.bAtras_Click);
            // 
            // lNombreUser
            // 
            this.lNombreUser.AutoSize = true;
            this.lNombreUser.Font = new System.Drawing.Font("Calibri Light", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lNombreUser.Location = new System.Drawing.Point(19, 172);
            this.lNombreUser.Name = "lNombreUser";
            this.lNombreUser.Size = new System.Drawing.Size(105, 14);
            this.lNombreUser.TabIndex = 47;
            this.lNombreUser.Text = "Nombre Usuario:";
            // 
            // bAceptarC
            // 
            this.bAceptarC.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bAceptarC.Location = new System.Drawing.Point(130, 386);
            this.bAceptarC.Name = "bAceptarC";
            this.bAceptarC.Size = new System.Drawing.Size(125, 23);
            this.bAceptarC.TabIndex = 46;
            this.bAceptarC.Text = "Aceptar Cambios";
            this.bAceptarC.UseVisualStyleBackColor = true;
            this.bAceptarC.Click += new System.EventHandler(this.bAceptarC_Click);
            // 
            // bBaja
            // 
            this.bBaja.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bBaja.Location = new System.Drawing.Point(12, 415);
            this.bBaja.Name = "bBaja";
            this.bBaja.Size = new System.Drawing.Size(98, 23);
            this.bBaja.TabIndex = 45;
            this.bBaja.Text = "Darse de Baja";
            this.bBaja.UseVisualStyleBackColor = true;
            this.bBaja.Click += new System.EventHandler(this.bBaja_Click);
            // 
            // bModPerfil
            // 
            this.bModPerfil.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bModPerfil.Location = new System.Drawing.Point(12, 386);
            this.bModPerfil.Name = "bModPerfil";
            this.bModPerfil.Size = new System.Drawing.Size(98, 23);
            this.bModPerfil.TabIndex = 44;
            this.bModPerfil.Text = "Modificar Perfil";
            this.bModPerfil.UseVisualStyleBackColor = true;
            this.bModPerfil.Click += new System.EventHandler(this.bModPerfil_Click);
            // 
            // lShowMail
            // 
            this.lShowMail.AutoSize = true;
            this.lShowMail.Font = new System.Drawing.Font("Calibri Light", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lShowMail.Location = new System.Drawing.Point(73, 283);
            this.lShowMail.Name = "lShowMail";
            this.lShowMail.Size = new System.Drawing.Size(42, 14);
            this.lShowMail.TabIndex = 43;
            this.lShowMail.Text = "(email)";
            // 
            // lMail
            // 
            this.lMail.AutoSize = true;
            this.lMail.Font = new System.Drawing.Font("Calibri Light", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lMail.Location = new System.Drawing.Point(19, 283);
            this.lMail.Name = "lMail";
            this.lMail.Size = new System.Drawing.Size(48, 14);
            this.lMail.TabIndex = 42;
            this.lMail.Text = "e-mail:";
            // 
            // lShowNombre
            // 
            this.lShowNombre.AutoSize = true;
            this.lShowNombre.Font = new System.Drawing.Font("Calibri Light", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lShowNombre.Location = new System.Drawing.Point(81, 212);
            this.lShowNombre.Name = "lShowNombre";
            this.lShowNombre.Size = new System.Drawing.Size(39, 14);
            this.lShowNombre.TabIndex = 41;
            this.lShowNombre.Text = "(noun)";
            // 
            // lNombre
            // 
            this.lNombre.AutoSize = true;
            this.lNombre.Font = new System.Drawing.Font("Calibri Light", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lNombre.Location = new System.Drawing.Point(19, 212);
            this.lNombre.Name = "lNombre";
            this.lNombre.Size = new System.Drawing.Size(56, 14);
            this.lNombre.TabIndex = 40;
            this.lNombre.Text = "Nombre:";
            // 
            // pict
            // 
            this.pict.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pict.Location = new System.Drawing.Point(12, 12);
            this.pict.Name = "pict";
            this.pict.Size = new System.Drawing.Size(104, 105);
            this.pict.TabIndex = 39;
            this.pict.TabStop = false;
            // 
            // bPreferencias
            // 
            this.bPreferencias.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bPreferencias.Location = new System.Drawing.Point(277, 386);
            this.bPreferencias.Name = "bPreferencias";
            this.bPreferencias.Size = new System.Drawing.Size(98, 23);
            this.bPreferencias.TabIndex = 53;
            this.bPreferencias.Text = "Ver Preferencias";
            this.bPreferencias.UseVisualStyleBackColor = true;
            this.bPreferencias.Click += new System.EventHandler(this.bPreferencias_Click);
            // 
            // lDNI
            // 
            this.lDNI.AutoSize = true;
            this.lDNI.Font = new System.Drawing.Font("Calibri Light", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lDNI.Location = new System.Drawing.Point(19, 244);
            this.lDNI.Name = "lDNI";
            this.lDNI.Size = new System.Drawing.Size(32, 14);
            this.lDNI.TabIndex = 54;
            this.lDNI.Text = "DNI:";
            // 
            // lShowDNI
            // 
            this.lShowDNI.AutoSize = true;
            this.lShowDNI.Font = new System.Drawing.Font("Calibri Light", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lShowDNI.Location = new System.Drawing.Point(57, 244);
            this.lShowDNI.Name = "lShowDNI";
            this.lShowDNI.Size = new System.Drawing.Size(30, 14);
            this.lShowDNI.TabIndex = 55;
            this.lShowDNI.Text = "(dni)";
            // 
            // lShowUser
            // 
            this.lShowUser.AutoSize = true;
            this.lShowUser.Font = new System.Drawing.Font("Calibri Light", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lShowUser.Location = new System.Drawing.Point(130, 172);
            this.lShowUser.Name = "lShowUser";
            this.lShowUser.Size = new System.Drawing.Size(36, 14);
            this.lShowUser.TabIndex = 56;
            this.lShowUser.Text = "(user)";
            // 
            // modiDNI
            // 
            this.modiDNI.Location = new System.Drawing.Point(60, 241);
            this.modiDNI.Name = "modiDNI";
            this.modiDNI.Size = new System.Drawing.Size(100, 20);
            this.modiDNI.TabIndex = 57;
            // 
            // dateNac
            // 
            this.dateNac.Location = new System.Drawing.Point(158, 315);
            this.dateNac.Name = "dateNac";
            this.dateNac.Size = new System.Drawing.Size(200, 20);
            this.dateNac.TabIndex = 58;
            // 
            // FPerfilPAS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 450);
            this.Controls.Add(this.dateNac);
            this.Controls.Add(this.modiUser);
            this.Controls.Add(this.modiDNI);
            this.Controls.Add(this.lShowUser);
            this.Controls.Add(this.lShowDNI);
            this.Controls.Add(this.lDNI);
            this.Controls.Add(this.bPreferencias);
            this.Controls.Add(this.lShowFecha);
            this.Controls.Add(this.lFechaNac);
            this.Controls.Add(this.bCancelarC);
            this.Controls.Add(this.bAtras);
            this.Controls.Add(this.lNombreUser);
            this.Controls.Add(this.bAceptarC);
            this.Controls.Add(this.bBaja);
            this.Controls.Add(this.bModPerfil);
            this.Controls.Add(this.lShowMail);
            this.Controls.Add(this.lMail);
            this.Controls.Add(this.lShowNombre);
            this.Controls.Add(this.lNombre);
            this.Controls.Add(this.pict);
            this.Name = "FPerfilPAS";
            this.Text = "Perfil";
            ((System.ComponentModel.ISupportInitialize)(this.pict)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lShowFecha;
        private System.Windows.Forms.Label lFechaNac;
        private System.Windows.Forms.TextBox modiUser;
        private System.Windows.Forms.Button bCancelarC;
        private System.Windows.Forms.Button bAtras;
        private System.Windows.Forms.Label lNombreUser;
        private System.Windows.Forms.Button bAceptarC;
        private System.Windows.Forms.Button bBaja;
        private System.Windows.Forms.Button bModPerfil;
        private System.Windows.Forms.Label lShowMail;
        private System.Windows.Forms.Label lMail;
        private System.Windows.Forms.Label lShowNombre;
        private System.Windows.Forms.Label lNombre;
        private System.Windows.Forms.PictureBox pict;
        private System.Windows.Forms.Button bPreferencias;
        private System.Windows.Forms.Label lDNI;
        private System.Windows.Forms.Label lShowDNI;
        private System.Windows.Forms.Label lShowUser;
        private System.Windows.Forms.TextBox modiDNI;
        private System.Windows.Forms.DateTimePicker dateNac;
    }
}