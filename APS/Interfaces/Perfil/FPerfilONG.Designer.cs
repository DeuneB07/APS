﻿namespace APS.Interfaces.Perfil
{
    partial class FPerfilONG
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
            this.pictureBoxPerfil = new System.Windows.Forms.PictureBox();
            this.bCancelarC = new System.Windows.Forms.Button();
            this.bAtras = new System.Windows.Forms.Button();
            this.modiUser = new System.Windows.Forms.TextBox();
            this.lNombreUser = new System.Windows.Forms.Label();
            this.bAceptarC = new System.Windows.Forms.Button();
            this.bBaja = new System.Windows.Forms.Button();
            this.bModPerfil = new System.Windows.Forms.Button();
            this.lShowMail = new System.Windows.Forms.Label();
            this.lMail = new System.Windows.Forms.Label();
            this.lShowNombre = new System.Windows.Forms.Label();
            this.lNombre = new System.Windows.Forms.Label();
            this.lShowUser = new System.Windows.Forms.Label();
            this.lFechaIns = new System.Windows.Forms.Label();
            this.lShowFecha = new System.Windows.Forms.Label();
            this.btnCambiarImagen = new System.Windows.Forms.Button();
            this.btnBorrarImagen = new System.Windows.Forms.Button();
            this.tURL = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPerfil)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxPerfil
            // 
            this.pictureBoxPerfil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxPerfil.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxPerfil.Image = global::APS.Properties.Resources.userDefault;
            this.pictureBoxPerfil.Location = new System.Drawing.Point(16, 15);
            this.pictureBoxPerfil.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxPerfil.Name = "pictureBoxPerfil";
            this.pictureBoxPerfil.Size = new System.Drawing.Size(139, 129);
            this.pictureBoxPerfil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPerfil.TabIndex = 0;
            this.pictureBoxPerfil.TabStop = false;
            // 
            // bCancelarC
            // 
            this.bCancelarC.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bCancelarC.Location = new System.Drawing.Point(173, 511);
            this.bCancelarC.Margin = new System.Windows.Forms.Padding(4);
            this.bCancelarC.Name = "bCancelarC";
            this.bCancelarC.Size = new System.Drawing.Size(167, 28);
            this.bCancelarC.TabIndex = 35;
            this.bCancelarC.Text = "Cancelar Cambios";
            this.bCancelarC.UseVisualStyleBackColor = true;
            this.bCancelarC.Click += new System.EventHandler(this.bCancelarC_Click);
            // 
            // bAtras
            // 
            this.bAtras.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bAtras.Location = new System.Drawing.Point(355, 511);
            this.bAtras.Margin = new System.Windows.Forms.Padding(4);
            this.bAtras.Name = "bAtras";
            this.bAtras.Size = new System.Drawing.Size(131, 28);
            this.bAtras.TabIndex = 34;
            this.bAtras.Text = "Atrás";
            this.bAtras.UseVisualStyleBackColor = true;
            this.bAtras.Click += new System.EventHandler(this.bAtras_Click);
            // 
            // modiUser
            // 
            this.modiUser.Location = new System.Drawing.Point(173, 265);
            this.modiUser.Margin = new System.Windows.Forms.Padding(4);
            this.modiUser.Name = "modiUser";
            this.modiUser.Size = new System.Drawing.Size(132, 22);
            this.modiUser.TabIndex = 33;
            // 
            // lNombreUser
            // 
            this.lNombreUser.AutoSize = true;
            this.lNombreUser.Font = new System.Drawing.Font("Calibri Light", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lNombreUser.Location = new System.Drawing.Point(25, 268);
            this.lNombreUser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lNombreUser.Name = "lNombreUser";
            this.lNombreUser.Size = new System.Drawing.Size(128, 18);
            this.lNombreUser.TabIndex = 32;
            this.lNombreUser.Text = "Nombre Usuario:";
            // 
            // bAceptarC
            // 
            this.bAceptarC.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bAceptarC.Location = new System.Drawing.Point(173, 475);
            this.bAceptarC.Margin = new System.Windows.Forms.Padding(4);
            this.bAceptarC.Name = "bAceptarC";
            this.bAceptarC.Size = new System.Drawing.Size(167, 28);
            this.bAceptarC.TabIndex = 31;
            this.bAceptarC.Text = "Aceptar Cambios";
            this.bAceptarC.UseVisualStyleBackColor = true;
            this.bAceptarC.Click += new System.EventHandler(this.bAceptarC_Click);
            // 
            // bBaja
            // 
            this.bBaja.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bBaja.Location = new System.Drawing.Point(24, 511);
            this.bBaja.Margin = new System.Windows.Forms.Padding(4);
            this.bBaja.Name = "bBaja";
            this.bBaja.Size = new System.Drawing.Size(131, 28);
            this.bBaja.TabIndex = 30;
            this.bBaja.Text = "Darse de Baja";
            this.bBaja.UseVisualStyleBackColor = true;
            this.bBaja.Click += new System.EventHandler(this.bBaja_Click);
            // 
            // bModPerfil
            // 
            this.bModPerfil.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bModPerfil.Location = new System.Drawing.Point(24, 475);
            this.bModPerfil.Margin = new System.Windows.Forms.Padding(4);
            this.bModPerfil.Name = "bModPerfil";
            this.bModPerfil.Size = new System.Drawing.Size(131, 28);
            this.bModPerfil.TabIndex = 29;
            this.bModPerfil.Text = "Modificar Perfil";
            this.bModPerfil.UseVisualStyleBackColor = true;
            this.bModPerfil.Click += new System.EventHandler(this.bModPerfil_Click);
            // 
            // lShowMail
            // 
            this.lShowMail.AutoSize = true;
            this.lShowMail.Font = new System.Drawing.Font("Calibri Light", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lShowMail.Location = new System.Drawing.Point(99, 352);
            this.lShowMail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lShowMail.Name = "lShowMail";
            this.lShowMail.Size = new System.Drawing.Size(49, 18);
            this.lShowMail.TabIndex = 28;
            this.lShowMail.Text = "(email)";
            // 
            // lMail
            // 
            this.lMail.AutoSize = true;
            this.lMail.Font = new System.Drawing.Font("Calibri Light", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lMail.Location = new System.Drawing.Point(25, 352);
            this.lMail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lMail.Name = "lMail";
            this.lMail.Size = new System.Drawing.Size(57, 18);
            this.lMail.TabIndex = 27;
            this.lMail.Text = "e-mail:";
            // 
            // lShowNombre
            // 
            this.lShowNombre.AutoSize = true;
            this.lShowNombre.Font = new System.Drawing.Font("Calibri Light", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lShowNombre.Location = new System.Drawing.Point(108, 311);
            this.lShowNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lShowNombre.Name = "lShowNombre";
            this.lShowNombre.Size = new System.Drawing.Size(48, 18);
            this.lShowNombre.TabIndex = 26;
            this.lShowNombre.Text = "(noun)";
            // 
            // lNombre
            // 
            this.lNombre.AutoSize = true;
            this.lNombre.Font = new System.Drawing.Font("Calibri Light", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lNombre.Location = new System.Drawing.Point(25, 311);
            this.lNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lNombre.Name = "lNombre";
            this.lNombre.Size = new System.Drawing.Size(69, 18);
            this.lNombre.TabIndex = 25;
            this.lNombre.Text = "Nombre:";
            // 
            // lShowUser
            // 
            this.lShowUser.AutoSize = true;
            this.lShowUser.Font = new System.Drawing.Font("Calibri Light", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lShowUser.Location = new System.Drawing.Point(173, 265);
            this.lShowUser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lShowUser.Name = "lShowUser";
            this.lShowUser.Size = new System.Drawing.Size(42, 18);
            this.lShowUser.TabIndex = 36;
            this.lShowUser.Text = "(user)";
            // 
            // lFechaIns
            // 
            this.lFechaIns.AutoSize = true;
            this.lFechaIns.Font = new System.Drawing.Font("Calibri Light", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lFechaIns.Location = new System.Drawing.Point(25, 395);
            this.lFechaIns.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lFechaIns.Name = "lFechaIns";
            this.lFechaIns.Size = new System.Drawing.Size(155, 18);
            this.lFechaIns.TabIndex = 37;
            this.lFechaIns.Text = "Fecha de Inscripción:";
            // 
            // lShowFecha
            // 
            this.lShowFecha.AutoSize = true;
            this.lShowFecha.Font = new System.Drawing.Font("Calibri Light", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lShowFecha.Location = new System.Drawing.Point(207, 395);
            this.lShowFecha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lShowFecha.Name = "lShowFecha";
            this.lShowFecha.Size = new System.Drawing.Size(66, 18);
            this.lShowFecha.TabIndex = 38;
            this.lShowFecha.Text = "(fechains)";
            // 
            // btnCambiarImagen
            // 
            this.btnCambiarImagen.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCambiarImagen.Location = new System.Drawing.Point(176, 45);
            this.btnCambiarImagen.Margin = new System.Windows.Forms.Padding(4);
            this.btnCambiarImagen.Name = "btnCambiarImagen";
            this.btnCambiarImagen.Size = new System.Drawing.Size(131, 28);
            this.btnCambiarImagen.TabIndex = 39;
            this.btnCambiarImagen.Text = "Cambiar";
            this.btnCambiarImagen.UseVisualStyleBackColor = true;
            this.btnCambiarImagen.Visible = false;
            this.btnCambiarImagen.Click += new System.EventHandler(this.btnCambiarImagen_Click);
            // 
            // btnBorrarImagen
            // 
            this.btnBorrarImagen.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrarImagen.Location = new System.Drawing.Point(176, 97);
            this.btnBorrarImagen.Margin = new System.Windows.Forms.Padding(4);
            this.btnBorrarImagen.Name = "btnBorrarImagen";
            this.btnBorrarImagen.Size = new System.Drawing.Size(131, 28);
            this.btnBorrarImagen.TabIndex = 40;
            this.btnBorrarImagen.Text = "Borrar Imagen";
            this.btnBorrarImagen.UseVisualStyleBackColor = true;
            this.btnBorrarImagen.Visible = false;
            this.btnBorrarImagen.Click += new System.EventHandler(this.btnBorrarImagen_Click);
            // 
            // tURL
            // 
            this.tURL.Location = new System.Drawing.Point(176, 15);
            this.tURL.Margin = new System.Windows.Forms.Padding(4);
            this.tURL.Name = "tURL";
            this.tURL.Size = new System.Drawing.Size(132, 22);
            this.tURL.TabIndex = 41;
            this.tURL.Visible = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // FPerfilONG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(501, 554);
            this.Controls.Add(this.tURL);
            this.Controls.Add(this.btnBorrarImagen);
            this.Controls.Add(this.btnCambiarImagen);
            this.Controls.Add(this.lShowFecha);
            this.Controls.Add(this.lFechaIns);
            this.Controls.Add(this.modiUser);
            this.Controls.Add(this.lShowUser);
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
            this.Controls.Add(this.pictureBoxPerfil);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FPerfilONG";
            this.Text = "Perfil";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPerfil)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxPerfil;
        private System.Windows.Forms.Button bCancelarC;
        private System.Windows.Forms.Button bAtras;
        private System.Windows.Forms.TextBox modiUser;
        private System.Windows.Forms.Label lNombreUser;
        private System.Windows.Forms.Button bAceptarC;
        private System.Windows.Forms.Button bBaja;
        private System.Windows.Forms.Button bModPerfil;
        private System.Windows.Forms.Label lShowMail;
        private System.Windows.Forms.Label lMail;
        private System.Windows.Forms.Label lShowNombre;
        private System.Windows.Forms.Label lNombre;
        private System.Windows.Forms.Label lShowUser;
        private System.Windows.Forms.Label lFechaIns;
        private System.Windows.Forms.Label lShowFecha;
        private System.Windows.Forms.Button btnCambiarImagen;
        private System.Windows.Forms.Button btnBorrarImagen;
        private System.Windows.Forms.TextBox tURL;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}