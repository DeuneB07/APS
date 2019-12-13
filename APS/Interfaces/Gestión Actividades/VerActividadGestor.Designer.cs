﻿namespace APS.Interfaces.Gestión_Actividades
{
    partial class VerActividadGestor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VerActividadGestor));
            this.listTrabajo = new System.Windows.Forms.ListBox();
            this.listAmbito = new System.Windows.Forms.ListBox();
            this.listTurno = new System.Windows.Forms.ListBox();
            this.tLugar = new System.Windows.Forms.TextBox();
            this.dateTimePickerFechaFin = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerFechaIni = new System.Windows.Forms.DateTimePicker();
            this.tNumHoras = new System.Windows.Forms.TextBox();
            this.tNumPlazas = new System.Windows.Forms.TextBox();
            this.tDescripcion = new System.Windows.Forms.RichTextBox();
            this.tNombreAct = new System.Windows.Forms.TextBox();
            this.tOrganizador = new System.Windows.Forms.TextBox();
            this.labelTipo = new System.Windows.Forms.Label();
            this.labelAmbito = new System.Windows.Forms.Label();
            this.labelTurno = new System.Windows.Forms.Label();
            this.labelLugar = new System.Windows.Forms.Label();
            this.labelFechaFin = new System.Windows.Forms.Label();
            this.labelFechaInicio = new System.Windows.Forms.Label();
            this.labelNumHoras = new System.Windows.Forms.Label();
            this.labelNumPlazas = new System.Windows.Forms.Label();
            this.labelDescripcion = new System.Windows.Forms.Label();
            this.labelNombreAct = new System.Windows.Forms.Label();
            this.labelOrganizador = new System.Windows.Forms.Label();
            this.btnGestionar = new System.Windows.Forms.Button();
            this.btnRechazar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // listTrabajo
            // 
            this.listTrabajo.Enabled = false;
            this.listTrabajo.FormattingEnabled = true;
            this.listTrabajo.ItemHeight = 25;
            this.listTrabajo.Items.AddRange(new object[] {
            "TODAS",
            "SALUD",
            "EVENTO"});
            this.listTrabajo.Location = new System.Drawing.Point(422, 773);
            this.listTrabajo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listTrabajo.Name = "listTrabajo";
            this.listTrabajo.Size = new System.Drawing.Size(205, 29);
            this.listTrabajo.TabIndex = 50;
            // 
            // listAmbito
            // 
            this.listAmbito.Enabled = false;
            this.listAmbito.FormattingEnabled = true;
            this.listAmbito.ItemHeight = 25;
            this.listAmbito.Items.AddRange(new object[] {
            "TODAS",
            "INMIGRACION",
            "POBREZA",
            "TERCERA_EDAD",
            "SIN_HOGAR",
            "DISCAPACIDAD"});
            this.listAmbito.Location = new System.Drawing.Point(422, 725);
            this.listAmbito.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listAmbito.Name = "listAmbito";
            this.listAmbito.Size = new System.Drawing.Size(205, 29);
            this.listAmbito.TabIndex = 49;
            // 
            // listTurno
            // 
            this.listTurno.Enabled = false;
            this.listTurno.FormattingEnabled = true;
            this.listTurno.ItemHeight = 25;
            this.listTurno.Items.AddRange(new object[] {
            "AMBAS",
            "MAÑANA",
            "TARDE"});
            this.listTurno.Location = new System.Drawing.Point(428, 659);
            this.listTurno.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listTurno.Name = "listTurno";
            this.listTurno.Size = new System.Drawing.Size(178, 29);
            this.listTurno.TabIndex = 48;
            // 
            // tLugar
            // 
            this.tLugar.Enabled = false;
            this.tLugar.Location = new System.Drawing.Point(428, 595);
            this.tLugar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tLugar.Name = "tLugar";
            this.tLugar.Size = new System.Drawing.Size(292, 31);
            this.tLugar.TabIndex = 46;
            // 
            // dateTimePickerFechaFin
            // 
            this.dateTimePickerFechaFin.Enabled = false;
            this.dateTimePickerFechaFin.Location = new System.Drawing.Point(422, 527);
            this.dateTimePickerFechaFin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dateTimePickerFechaFin.Name = "dateTimePickerFechaFin";
            this.dateTimePickerFechaFin.Size = new System.Drawing.Size(298, 31);
            this.dateTimePickerFechaFin.TabIndex = 45;
            // 
            // dateTimePickerFechaIni
            // 
            this.dateTimePickerFechaIni.Enabled = false;
            this.dateTimePickerFechaIni.Location = new System.Drawing.Point(422, 464);
            this.dateTimePickerFechaIni.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dateTimePickerFechaIni.Name = "dateTimePickerFechaIni";
            this.dateTimePickerFechaIni.Size = new System.Drawing.Size(298, 31);
            this.dateTimePickerFechaIni.TabIndex = 44;
            // 
            // tNumHoras
            // 
            this.tNumHoras.Enabled = false;
            this.tNumHoras.Location = new System.Drawing.Point(422, 400);
            this.tNumHoras.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tNumHoras.Name = "tNumHoras";
            this.tNumHoras.Size = new System.Drawing.Size(82, 31);
            this.tNumHoras.TabIndex = 43;
            // 
            // tNumPlazas
            // 
            this.tNumPlazas.Enabled = false;
            this.tNumPlazas.Location = new System.Drawing.Point(422, 341);
            this.tNumPlazas.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tNumPlazas.Name = "tNumPlazas";
            this.tNumPlazas.Size = new System.Drawing.Size(82, 31);
            this.tNumPlazas.TabIndex = 42;
            // 
            // tDescripcion
            // 
            this.tDescripcion.Enabled = false;
            this.tDescripcion.Location = new System.Drawing.Point(428, 194);
            this.tDescripcion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tDescripcion.Name = "tDescripcion";
            this.tDescripcion.Size = new System.Drawing.Size(271, 110);
            this.tDescripcion.TabIndex = 41;
            this.tDescripcion.Text = "";
            // 
            // tNombreAct
            // 
            this.tNombreAct.Enabled = false;
            this.tNombreAct.Location = new System.Drawing.Point(428, 130);
            this.tNombreAct.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tNombreAct.Name = "tNombreAct";
            this.tNombreAct.Size = new System.Drawing.Size(271, 31);
            this.tNombreAct.TabIndex = 40;
            // 
            // tOrganizador
            // 
            this.tOrganizador.Enabled = false;
            this.tOrganizador.Location = new System.Drawing.Point(428, 59);
            this.tOrganizador.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tOrganizador.Name = "tOrganizador";
            this.tOrganizador.Size = new System.Drawing.Size(271, 31);
            this.tOrganizador.TabIndex = 39;
            // 
            // labelTipo
            // 
            this.labelTipo.AutoSize = true;
            this.labelTipo.Location = new System.Drawing.Point(273, 773);
            this.labelTipo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTipo.Name = "labelTipo";
            this.labelTipo.Size = new System.Drawing.Size(139, 25);
            this.labelTipo.TabIndex = 38;
            this.labelTipo.Text = "Tipo Trabajo:";
            // 
            // labelAmbito
            // 
            this.labelAmbito.AutoSize = true;
            this.labelAmbito.Location = new System.Drawing.Point(250, 725);
            this.labelAmbito.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAmbito.Name = "labelAmbito";
            this.labelAmbito.Size = new System.Drawing.Size(163, 25);
            this.labelAmbito.TabIndex = 37;
            this.labelAmbito.Text = "Ambito Trabajo:";
            // 
            // labelTurno
            // 
            this.labelTurno.AutoSize = true;
            this.labelTurno.Location = new System.Drawing.Point(339, 659);
            this.labelTurno.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTurno.Name = "labelTurno";
            this.labelTurno.Size = new System.Drawing.Size(74, 25);
            this.labelTurno.TabIndex = 35;
            this.labelTurno.Text = "Turno:";
            // 
            // labelLugar
            // 
            this.labelLugar.AutoSize = true;
            this.labelLugar.Location = new System.Drawing.Point(339, 595);
            this.labelLugar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelLugar.Name = "labelLugar";
            this.labelLugar.Size = new System.Drawing.Size(73, 25);
            this.labelLugar.TabIndex = 34;
            this.labelLugar.Text = "Lugar:";
            // 
            // labelFechaFin
            // 
            this.labelFechaFin.AutoSize = true;
            this.labelFechaFin.Location = new System.Drawing.Point(302, 527);
            this.labelFechaFin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFechaFin.Name = "labelFechaFin";
            this.labelFechaFin.Size = new System.Drawing.Size(114, 25);
            this.labelFechaFin.TabIndex = 33;
            this.labelFechaFin.Text = "Fecha Fin:";
            // 
            // labelFechaInicio
            // 
            this.labelFechaInicio.AutoSize = true;
            this.labelFechaInicio.Location = new System.Drawing.Point(282, 464);
            this.labelFechaInicio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFechaInicio.Name = "labelFechaInicio";
            this.labelFechaInicio.Size = new System.Drawing.Size(134, 25);
            this.labelFechaInicio.TabIndex = 32;
            this.labelFechaInicio.Text = "Fecha Inicio:";
            // 
            // labelNumHoras
            // 
            this.labelNumHoras.AutoSize = true;
            this.labelNumHoras.Location = new System.Drawing.Point(256, 400);
            this.labelNumHoras.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNumHoras.Name = "labelNumHoras";
            this.labelNumHoras.Size = new System.Drawing.Size(156, 25);
            this.labelNumHoras.TabIndex = 31;
            this.labelNumHoras.Text = "Número Horas:";
            // 
            // labelNumPlazas
            // 
            this.labelNumPlazas.AutoSize = true;
            this.labelNumPlazas.Location = new System.Drawing.Point(250, 341);
            this.labelNumPlazas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNumPlazas.Name = "labelNumPlazas";
            this.labelNumPlazas.Size = new System.Drawing.Size(164, 25);
            this.labelNumPlazas.TabIndex = 30;
            this.labelNumPlazas.Text = "Número Plazas:";
            // 
            // labelDescripcion
            // 
            this.labelDescripcion.AutoSize = true;
            this.labelDescripcion.Location = new System.Drawing.Point(198, 194);
            this.labelDescripcion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDescripcion.Name = "labelDescripcion";
            this.labelDescripcion.Size = new System.Drawing.Size(225, 25);
            this.labelDescripcion.TabIndex = 29;
            this.labelDescripcion.Text = "Descripción Actividad:";
            // 
            // labelNombreAct
            // 
            this.labelNombreAct.AutoSize = true;
            this.labelNombreAct.Location = new System.Drawing.Point(234, 130);
            this.labelNombreAct.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNombreAct.Name = "labelNombreAct";
            this.labelNombreAct.Size = new System.Drawing.Size(187, 25);
            this.labelNombreAct.TabIndex = 28;
            this.labelNombreAct.Text = "Nombre Actividad:";
            // 
            // labelOrganizador
            // 
            this.labelOrganizador.AutoSize = true;
            this.labelOrganizador.Location = new System.Drawing.Point(282, 59);
            this.labelOrganizador.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelOrganizador.Name = "labelOrganizador";
            this.labelOrganizador.Size = new System.Drawing.Size(136, 25);
            this.labelOrganizador.TabIndex = 27;
            this.labelOrganizador.Text = "Organizador:";
            // 
            // btnGestionar
            // 
            this.btnGestionar.Location = new System.Drawing.Point(428, 1005);
            this.btnGestionar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGestionar.Name = "btnGestionar";
            this.btnGestionar.Size = new System.Drawing.Size(132, 36);
            this.btnGestionar.TabIndex = 51;
            this.btnGestionar.Text = "Gestionar";
            this.btnGestionar.UseVisualStyleBackColor = true;
            this.btnGestionar.Click += new System.EventHandler(this.btnGestionar_Click);
            // 
            // btnRechazar
            // 
            this.btnRechazar.Location = new System.Drawing.Point(588, 1005);
            this.btnRechazar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRechazar.Name = "btnRechazar";
            this.btnRechazar.Size = new System.Drawing.Size(147, 36);
            this.btnRechazar.TabIndex = 52;
            this.btnRechazar.Text = "Rechazar";
            this.btnRechazar.UseVisualStyleBackColor = true;
            this.btnRechazar.Click += new System.EventHandler(this.btnRechazar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(764, 1005);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(135, 36);
            this.btnCancelar.TabIndex = 53;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox.BackgroundImage")));
            this.pictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox.Location = new System.Drawing.Point(422, 831);
            this.pictureBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(198, 127);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 55;
            this.pictureBox.TabStop = false;
            // 
            // VerActividadGestor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 1059);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnRechazar);
            this.Controls.Add(this.btnGestionar);
            this.Controls.Add(this.listTrabajo);
            this.Controls.Add(this.listAmbito);
            this.Controls.Add(this.listTurno);
            this.Controls.Add(this.tLugar);
            this.Controls.Add(this.dateTimePickerFechaFin);
            this.Controls.Add(this.dateTimePickerFechaIni);
            this.Controls.Add(this.tNumHoras);
            this.Controls.Add(this.tNumPlazas);
            this.Controls.Add(this.tDescripcion);
            this.Controls.Add(this.tNombreAct);
            this.Controls.Add(this.tOrganizador);
            this.Controls.Add(this.labelTipo);
            this.Controls.Add(this.labelAmbito);
            this.Controls.Add(this.labelTurno);
            this.Controls.Add(this.labelLugar);
            this.Controls.Add(this.labelFechaFin);
            this.Controls.Add(this.labelFechaInicio);
            this.Controls.Add(this.labelNumHoras);
            this.Controls.Add(this.labelNumPlazas);
            this.Controls.Add(this.labelDescripcion);
            this.Controls.Add(this.labelNombreAct);
            this.Controls.Add(this.labelOrganizador);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "VerActividadGestor";
            this.Text = "Ver Actividad";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listTrabajo;
        private System.Windows.Forms.ListBox listAmbito;
        private System.Windows.Forms.ListBox listTurno;
        private System.Windows.Forms.TextBox tLugar;
        private System.Windows.Forms.DateTimePicker dateTimePickerFechaFin;
        private System.Windows.Forms.DateTimePicker dateTimePickerFechaIni;
        private System.Windows.Forms.TextBox tNumHoras;
        private System.Windows.Forms.TextBox tNumPlazas;
        private System.Windows.Forms.RichTextBox tDescripcion;
        private System.Windows.Forms.TextBox tNombreAct;
        private System.Windows.Forms.TextBox tOrganizador;
        private System.Windows.Forms.Label labelTipo;
        private System.Windows.Forms.Label labelAmbito;
        private System.Windows.Forms.Label labelTurno;
        private System.Windows.Forms.Label labelLugar;
        private System.Windows.Forms.Label labelFechaFin;
        private System.Windows.Forms.Label labelFechaInicio;
        private System.Windows.Forms.Label labelNumHoras;
        private System.Windows.Forms.Label labelNumPlazas;
        private System.Windows.Forms.Label labelDescripcion;
        private System.Windows.Forms.Label labelNombreAct;
        private System.Windows.Forms.Label labelOrganizador;
        private System.Windows.Forms.Button btnGestionar;
        private System.Windows.Forms.Button btnRechazar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.PictureBox pictureBox;
    }
}