namespace APS.Interfaces.Gestión_Actividades
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
            this.listTrabajo.ItemHeight = 16;
            this.listTrabajo.Items.AddRange(new object[] {
            "TODAS",
            "SALUD",
            "EVENTO"});
            this.listTrabajo.Location = new System.Drawing.Point(281, 495);
            this.listTrabajo.Name = "listTrabajo";
            this.listTrabajo.Size = new System.Drawing.Size(138, 20);
            this.listTrabajo.TabIndex = 50;
            // 
            // listAmbito
            // 
            this.listAmbito.Enabled = false;
            this.listAmbito.FormattingEnabled = true;
            this.listAmbito.ItemHeight = 16;
            this.listAmbito.Items.AddRange(new object[] {
            "TODAS",
            "INMIGRACION",
            "POBREZA",
            "TERCERA_EDAD",
            "SIN_HOGAR",
            "DISCAPACIDAD"});
            this.listAmbito.Location = new System.Drawing.Point(281, 464);
            this.listAmbito.Name = "listAmbito";
            this.listAmbito.Size = new System.Drawing.Size(138, 20);
            this.listAmbito.TabIndex = 49;
            // 
            // listTurno
            // 
            this.listTurno.Enabled = false;
            this.listTurno.FormattingEnabled = true;
            this.listTurno.ItemHeight = 16;
            this.listTurno.Items.AddRange(new object[] {
            "AMBAS",
            "MAÑANA",
            "TARDE"});
            this.listTurno.Location = new System.Drawing.Point(285, 422);
            this.listTurno.Name = "listTurno";
            this.listTurno.Size = new System.Drawing.Size(120, 20);
            this.listTurno.TabIndex = 48;
            // 
            // tLugar
            // 
            this.tLugar.Enabled = false;
            this.tLugar.Location = new System.Drawing.Point(285, 381);
            this.tLugar.Name = "tLugar";
            this.tLugar.Size = new System.Drawing.Size(196, 22);
            this.tLugar.TabIndex = 46;
            // 
            // dateTimePickerFechaFin
            // 
            this.dateTimePickerFechaFin.Enabled = false;
            this.dateTimePickerFechaFin.Location = new System.Drawing.Point(281, 337);
            this.dateTimePickerFechaFin.Name = "dateTimePickerFechaFin";
            this.dateTimePickerFechaFin.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerFechaFin.TabIndex = 45;
            // 
            // dateTimePickerFechaIni
            // 
            this.dateTimePickerFechaIni.Enabled = false;
            this.dateTimePickerFechaIni.Location = new System.Drawing.Point(281, 297);
            this.dateTimePickerFechaIni.Name = "dateTimePickerFechaIni";
            this.dateTimePickerFechaIni.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerFechaIni.TabIndex = 44;
            // 
            // tNumHoras
            // 
            this.tNumHoras.Enabled = false;
            this.tNumHoras.Location = new System.Drawing.Point(281, 256);
            this.tNumHoras.Name = "tNumHoras";
            this.tNumHoras.Size = new System.Drawing.Size(56, 22);
            this.tNumHoras.TabIndex = 43;
            // 
            // tNumPlazas
            // 
            this.tNumPlazas.Enabled = false;
            this.tNumPlazas.Location = new System.Drawing.Point(281, 218);
            this.tNumPlazas.Name = "tNumPlazas";
            this.tNumPlazas.Size = new System.Drawing.Size(56, 22);
            this.tNumPlazas.TabIndex = 42;
            // 
            // tDescripcion
            // 
            this.tDescripcion.Enabled = false;
            this.tDescripcion.Location = new System.Drawing.Point(285, 124);
            this.tDescripcion.Name = "tDescripcion";
            this.tDescripcion.Size = new System.Drawing.Size(182, 72);
            this.tDescripcion.TabIndex = 41;
            this.tDescripcion.Text = "";
            // 
            // tNombreAct
            // 
            this.tNombreAct.Enabled = false;
            this.tNombreAct.Location = new System.Drawing.Point(285, 83);
            this.tNombreAct.Name = "tNombreAct";
            this.tNombreAct.Size = new System.Drawing.Size(182, 22);
            this.tNombreAct.TabIndex = 40;
            // 
            // tOrganizador
            // 
            this.tOrganizador.Enabled = false;
            this.tOrganizador.Location = new System.Drawing.Point(285, 38);
            this.tOrganizador.Name = "tOrganizador";
            this.tOrganizador.Size = new System.Drawing.Size(182, 22);
            this.tOrganizador.TabIndex = 39;
            // 
            // labelTipo
            // 
            this.labelTipo.AutoSize = true;
            this.labelTipo.Location = new System.Drawing.Point(182, 495);
            this.labelTipo.Name = "labelTipo";
            this.labelTipo.Size = new System.Drawing.Size(93, 17);
            this.labelTipo.TabIndex = 38;
            this.labelTipo.Text = "Tipo Trabajo:";
            // 
            // labelAmbito
            // 
            this.labelAmbito.AutoSize = true;
            this.labelAmbito.Location = new System.Drawing.Point(167, 464);
            this.labelAmbito.Name = "labelAmbito";
            this.labelAmbito.Size = new System.Drawing.Size(108, 17);
            this.labelAmbito.TabIndex = 37;
            this.labelAmbito.Text = "Ambito Trabajo:";
            // 
            // labelTurno
            // 
            this.labelTurno.AutoSize = true;
            this.labelTurno.Location = new System.Drawing.Point(226, 422);
            this.labelTurno.Name = "labelTurno";
            this.labelTurno.Size = new System.Drawing.Size(50, 17);
            this.labelTurno.TabIndex = 35;
            this.labelTurno.Text = "Turno:";
            // 
            // labelLugar
            // 
            this.labelLugar.AutoSize = true;
            this.labelLugar.Location = new System.Drawing.Point(226, 381);
            this.labelLugar.Name = "labelLugar";
            this.labelLugar.Size = new System.Drawing.Size(49, 17);
            this.labelLugar.TabIndex = 34;
            this.labelLugar.Text = "Lugar:";
            // 
            // labelFechaFin
            // 
            this.labelFechaFin.AutoSize = true;
            this.labelFechaFin.Location = new System.Drawing.Point(201, 337);
            this.labelFechaFin.Name = "labelFechaFin";
            this.labelFechaFin.Size = new System.Drawing.Size(74, 17);
            this.labelFechaFin.TabIndex = 33;
            this.labelFechaFin.Text = "Fecha Fin:";
            // 
            // labelFechaInicio
            // 
            this.labelFechaInicio.AutoSize = true;
            this.labelFechaInicio.Location = new System.Drawing.Point(188, 297);
            this.labelFechaInicio.Name = "labelFechaInicio";
            this.labelFechaInicio.Size = new System.Drawing.Size(87, 17);
            this.labelFechaInicio.TabIndex = 32;
            this.labelFechaInicio.Text = "Fecha Inicio:";
            // 
            // labelNumHoras
            // 
            this.labelNumHoras.AutoSize = true;
            this.labelNumHoras.Location = new System.Drawing.Point(171, 256);
            this.labelNumHoras.Name = "labelNumHoras";
            this.labelNumHoras.Size = new System.Drawing.Size(104, 17);
            this.labelNumHoras.TabIndex = 31;
            this.labelNumHoras.Text = "Número Horas:";
            // 
            // labelNumPlazas
            // 
            this.labelNumPlazas.AutoSize = true;
            this.labelNumPlazas.Location = new System.Drawing.Point(167, 218);
            this.labelNumPlazas.Name = "labelNumPlazas";
            this.labelNumPlazas.Size = new System.Drawing.Size(108, 17);
            this.labelNumPlazas.TabIndex = 30;
            this.labelNumPlazas.Text = "Número Plazas:";
            // 
            // labelDescripcion
            // 
            this.labelDescripcion.AutoSize = true;
            this.labelDescripcion.Location = new System.Drawing.Point(132, 124);
            this.labelDescripcion.Name = "labelDescripcion";
            this.labelDescripcion.Size = new System.Drawing.Size(147, 17);
            this.labelDescripcion.TabIndex = 29;
            this.labelDescripcion.Text = "Descripción Actividad:";
            // 
            // labelNombreAct
            // 
            this.labelNombreAct.AutoSize = true;
            this.labelNombreAct.Location = new System.Drawing.Point(156, 83);
            this.labelNombreAct.Name = "labelNombreAct";
            this.labelNombreAct.Size = new System.Drawing.Size(123, 17);
            this.labelNombreAct.TabIndex = 28;
            this.labelNombreAct.Text = "Nombre Actividad:";
            // 
            // labelOrganizador
            // 
            this.labelOrganizador.AutoSize = true;
            this.labelOrganizador.Location = new System.Drawing.Point(188, 38);
            this.labelOrganizador.Name = "labelOrganizador";
            this.labelOrganizador.Size = new System.Drawing.Size(91, 17);
            this.labelOrganizador.TabIndex = 27;
            this.labelOrganizador.Text = "Organizador:";
            // 
            // btnGestionar
            // 
            this.btnGestionar.Location = new System.Drawing.Point(285, 643);
            this.btnGestionar.Name = "btnGestionar";
            this.btnGestionar.Size = new System.Drawing.Size(88, 23);
            this.btnGestionar.TabIndex = 51;
            this.btnGestionar.Text = "Gestionar";
            this.btnGestionar.UseVisualStyleBackColor = true;
            this.btnGestionar.Click += new System.EventHandler(this.btnGestionar_Click);
            // 
            // btnRechazar
            // 
            this.btnRechazar.Location = new System.Drawing.Point(392, 643);
            this.btnRechazar.Name = "btnRechazar";
            this.btnRechazar.Size = new System.Drawing.Size(98, 23);
            this.btnRechazar.TabIndex = 52;
            this.btnRechazar.Text = "Rechazar";
            this.btnRechazar.UseVisualStyleBackColor = true;
            this.btnRechazar.Click += new System.EventHandler(this.btnRechazar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(509, 643);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(90, 23);
            this.btnCancelar.TabIndex = 53;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox.BackgroundImage")));
            this.pictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox.Location = new System.Drawing.Point(281, 532);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(132, 81);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 55;
            this.pictureBox.TabStop = false;
            // 
            // VerActividadGestor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 678);
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