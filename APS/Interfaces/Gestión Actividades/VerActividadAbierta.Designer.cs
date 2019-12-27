namespace APS.Interfaces.Gestión_Actividades
{
    partial class VerActividadAbierta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VerActividadAbierta));
            this.listTrabajo = new System.Windows.Forms.ComboBox();
            this.listAmbito = new System.Windows.Forms.ComboBox();
            this.listTurno = new System.Windows.Forms.ComboBox();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.btnAtras = new System.Windows.Forms.Button();
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textEstadoAct = new System.Windows.Forms.TextBox();
            this.labelEstado = new System.Windows.Forms.Label();
            this.listCompetencias = new System.Windows.Forms.ListBox();
            this.lblCompetencias = new System.Windows.Forms.Label();
            this.comboResponsable = new System.Windows.Forms.ComboBox();
            this.labelResponsable = new System.Windows.Forms.Label();
            this.comboAsignatura = new System.Windows.Forms.ComboBox();
            this.labelAsignatura = new System.Windows.Forms.Label();
            this.labelGrado = new System.Windows.Forms.Label();
            this.comboGrado = new System.Windows.Forms.ComboBox();
            this.comboTipoAct = new System.Windows.Forms.ComboBox();
            this.labelTipoActividad = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // listTrabajo
            // 
            this.listTrabajo.Enabled = false;
            this.listTrabajo.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listTrabajo.FormattingEnabled = true;
            this.listTrabajo.Location = new System.Drawing.Point(416, 265);
            this.listTrabajo.Name = "listTrabajo";
            this.listTrabajo.Size = new System.Drawing.Size(121, 21);
            this.listTrabajo.TabIndex = 84;
            // 
            // listAmbito
            // 
            this.listAmbito.Enabled = false;
            this.listAmbito.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listAmbito.FormattingEnabled = true;
            this.listAmbito.Location = new System.Drawing.Point(416, 232);
            this.listAmbito.Name = "listAmbito";
            this.listAmbito.Size = new System.Drawing.Size(121, 21);
            this.listAmbito.TabIndex = 83;
            // 
            // listTurno
            // 
            this.listTurno.Enabled = false;
            this.listTurno.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listTurno.FormattingEnabled = true;
            this.listTurno.Location = new System.Drawing.Point(131, 270);
            this.listTurno.Name = "listTurno";
            this.listTurno.Size = new System.Drawing.Size(121, 21);
            this.listTurno.TabIndex = 82;
            // 
            // pictureBox
            // 
            this.pictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox.Image")));
            this.pictureBox.Location = new System.Drawing.Point(363, 10);
            this.pictureBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(201, 129);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 81;
            this.pictureBox.TabStop = false;
            // 
            // btnAtras
            // 
            this.btnAtras.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtras.Location = new System.Drawing.Point(536, 501);
            this.btnAtras.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(68, 25);
            this.btnAtras.TabIndex = 80;
            this.btnAtras.Text = "Atrás";
            this.btnAtras.UseVisualStyleBackColor = true;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // tLugar
            // 
            this.tLugar.Enabled = false;
            this.tLugar.Font = new System.Drawing.Font("Bahnschrift", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tLugar.Location = new System.Drawing.Point(131, 232);
            this.tLugar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tLugar.Name = "tLugar";
            this.tLugar.Size = new System.Drawing.Size(163, 20);
            this.tLugar.TabIndex = 77;
            // 
            // dateTimePickerFechaFin
            // 
            this.dateTimePickerFechaFin.Enabled = false;
            this.dateTimePickerFechaFin.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerFechaFin.Location = new System.Drawing.Point(358, 193);
            this.dateTimePickerFechaFin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateTimePickerFechaFin.Name = "dateTimePickerFechaFin";
            this.dateTimePickerFechaFin.Size = new System.Drawing.Size(222, 22);
            this.dateTimePickerFechaFin.TabIndex = 76;
            // 
            // dateTimePickerFechaIni
            // 
            this.dateTimePickerFechaIni.Enabled = false;
            this.dateTimePickerFechaIni.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerFechaIni.Location = new System.Drawing.Point(358, 167);
            this.dateTimePickerFechaIni.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateTimePickerFechaIni.Name = "dateTimePickerFechaIni";
            this.dateTimePickerFechaIni.Size = new System.Drawing.Size(222, 22);
            this.dateTimePickerFechaIni.TabIndex = 75;
            // 
            // tNumHoras
            // 
            this.tNumHoras.Enabled = false;
            this.tNumHoras.Font = new System.Drawing.Font("Bahnschrift", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tNumHoras.Location = new System.Drawing.Point(131, 192);
            this.tNumHoras.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tNumHoras.Name = "tNumHoras";
            this.tNumHoras.Size = new System.Drawing.Size(43, 20);
            this.tNumHoras.TabIndex = 74;
            // 
            // tNumPlazas
            // 
            this.tNumPlazas.Enabled = false;
            this.tNumPlazas.Font = new System.Drawing.Font("Bahnschrift", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tNumPlazas.Location = new System.Drawing.Point(130, 161);
            this.tNumPlazas.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tNumPlazas.Name = "tNumPlazas";
            this.tNumPlazas.Size = new System.Drawing.Size(43, 20);
            this.tNumPlazas.TabIndex = 73;
            // 
            // tDescripcion
            // 
            this.tDescripcion.Font = new System.Drawing.Font("Bahnschrift", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tDescripcion.Location = new System.Drawing.Point(130, 78);
            this.tDescripcion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tDescripcion.Name = "tDescripcion";
            this.tDescripcion.ReadOnly = true;
            this.tDescripcion.Size = new System.Drawing.Size(164, 72);
            this.tDescripcion.TabIndex = 72;
            this.tDescripcion.Text = "";
            // 
            // tNombreAct
            // 
            this.tNombreAct.Enabled = false;
            this.tNombreAct.Font = new System.Drawing.Font("Bahnschrift", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tNombreAct.Location = new System.Drawing.Point(130, 47);
            this.tNombreAct.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tNombreAct.Name = "tNombreAct";
            this.tNombreAct.Size = new System.Drawing.Size(164, 20);
            this.tNombreAct.TabIndex = 71;
            // 
            // tOrganizador
            // 
            this.tOrganizador.Enabled = false;
            this.tOrganizador.Font = new System.Drawing.Font("Bahnschrift", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tOrganizador.Location = new System.Drawing.Point(130, 15);
            this.tOrganizador.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tOrganizador.Name = "tOrganizador";
            this.tOrganizador.Size = new System.Drawing.Size(164, 20);
            this.tOrganizador.TabIndex = 70;
            // 
            // labelTipo
            // 
            this.labelTipo.AutoSize = true;
            this.labelTipo.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTipo.Location = new System.Drawing.Point(335, 267);
            this.labelTipo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTipo.Name = "labelTipo";
            this.labelTipo.Size = new System.Drawing.Size(76, 14);
            this.labelTipo.TabIndex = 69;
            this.labelTipo.Text = "Tipo Trabajo:";
            // 
            // labelAmbito
            // 
            this.labelAmbito.AutoSize = true;
            this.labelAmbito.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAmbito.Location = new System.Drawing.Point(319, 233);
            this.labelAmbito.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelAmbito.Name = "labelAmbito";
            this.labelAmbito.Size = new System.Drawing.Size(92, 14);
            this.labelAmbito.TabIndex = 68;
            this.labelAmbito.Text = "Ambito Trabajo:";
            // 
            // labelTurno
            // 
            this.labelTurno.AutoSize = true;
            this.labelTurno.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTurno.Location = new System.Drawing.Point(89, 272);
            this.labelTurno.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTurno.Name = "labelTurno";
            this.labelTurno.Size = new System.Drawing.Size(42, 14);
            this.labelTurno.TabIndex = 67;
            this.labelTurno.Text = "Turno:";
            // 
            // labelLugar
            // 
            this.labelLugar.AutoSize = true;
            this.labelLugar.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLugar.Location = new System.Drawing.Point(89, 233);
            this.labelLugar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelLugar.Name = "labelLugar";
            this.labelLugar.Size = new System.Drawing.Size(40, 14);
            this.labelLugar.TabIndex = 66;
            this.labelLugar.Text = "Lugar:";
            // 
            // labelFechaFin
            // 
            this.labelFechaFin.AutoSize = true;
            this.labelFechaFin.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFechaFin.Location = new System.Drawing.Point(292, 193);
            this.labelFechaFin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelFechaFin.Name = "labelFechaFin";
            this.labelFechaFin.Size = new System.Drawing.Size(62, 14);
            this.labelFechaFin.TabIndex = 65;
            this.labelFechaFin.Text = "Fecha Fin:";
            // 
            // labelFechaInicio
            // 
            this.labelFechaInicio.AutoSize = true;
            this.labelFechaInicio.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFechaInicio.Location = new System.Drawing.Point(285, 167);
            this.labelFechaInicio.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelFechaInicio.Name = "labelFechaInicio";
            this.labelFechaInicio.Size = new System.Drawing.Size(74, 14);
            this.labelFechaInicio.TabIndex = 64;
            this.labelFechaInicio.Text = "Fecha Inicio:";
            // 
            // labelNumHoras
            // 
            this.labelNumHoras.AutoSize = true;
            this.labelNumHoras.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumHoras.Location = new System.Drawing.Point(41, 193);
            this.labelNumHoras.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNumHoras.Name = "labelNumHoras";
            this.labelNumHoras.Size = new System.Drawing.Size(88, 14);
            this.labelNumHoras.TabIndex = 63;
            this.labelNumHoras.Text = "Número Horas:";
            // 
            // labelNumPlazas
            // 
            this.labelNumPlazas.AutoSize = true;
            this.labelNumPlazas.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumPlazas.Location = new System.Drawing.Point(37, 162);
            this.labelNumPlazas.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNumPlazas.Name = "labelNumPlazas";
            this.labelNumPlazas.Size = new System.Drawing.Size(90, 14);
            this.labelNumPlazas.TabIndex = 62;
            this.labelNumPlazas.Text = "Número Plazas:";
            // 
            // labelDescripcion
            // 
            this.labelDescripcion.AutoSize = true;
            this.labelDescripcion.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescripcion.Location = new System.Drawing.Point(2, 78);
            this.labelDescripcion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDescripcion.Name = "labelDescripcion";
            this.labelDescripcion.Size = new System.Drawing.Size(125, 14);
            this.labelDescripcion.TabIndex = 61;
            this.labelDescripcion.Text = "Descripción Actividad:";
            // 
            // labelNombreAct
            // 
            this.labelNombreAct.AutoSize = true;
            this.labelNombreAct.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombreAct.Location = new System.Drawing.Point(22, 47);
            this.labelNombreAct.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNombreAct.Name = "labelNombreAct";
            this.labelNombreAct.Size = new System.Drawing.Size(104, 14);
            this.labelNombreAct.TabIndex = 60;
            this.labelNombreAct.Text = "Nombre Actividad:";
            // 
            // labelOrganizador
            // 
            this.labelOrganizador.AutoSize = true;
            this.labelOrganizador.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOrganizador.Location = new System.Drawing.Point(52, 16);
            this.labelOrganizador.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelOrganizador.Name = "labelOrganizador";
            this.labelOrganizador.Size = new System.Drawing.Size(74, 14);
            this.labelOrganizador.TabIndex = 59;
            this.labelOrganizador.Text = "Organizador:";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.listTrabajo);
            this.panel1.Controls.Add(this.listAmbito);
            this.panel1.Controls.Add(this.listTurno);
            this.panel1.Controls.Add(this.pictureBox);
            this.panel1.Controls.Add(this.tLugar);
            this.panel1.Controls.Add(this.dateTimePickerFechaFin);
            this.panel1.Controls.Add(this.dateTimePickerFechaIni);
            this.panel1.Controls.Add(this.tNumHoras);
            this.panel1.Controls.Add(this.tNumPlazas);
            this.panel1.Controls.Add(this.tDescripcion);
            this.panel1.Controls.Add(this.tNombreAct);
            this.panel1.Controls.Add(this.tOrganizador);
            this.panel1.Controls.Add(this.labelTipo);
            this.panel1.Controls.Add(this.labelAmbito);
            this.panel1.Controls.Add(this.labelTurno);
            this.panel1.Controls.Add(this.labelLugar);
            this.panel1.Controls.Add(this.labelFechaFin);
            this.panel1.Controls.Add(this.labelFechaInicio);
            this.panel1.Controls.Add(this.labelNumHoras);
            this.panel1.Controls.Add(this.labelNumPlazas);
            this.panel1.Controls.Add(this.labelDescripcion);
            this.panel1.Controls.Add(this.labelNombreAct);
            this.panel1.Controls.Add(this.labelOrganizador);
            this.panel1.Location = new System.Drawing.Point(9, 5);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(595, 306);
            this.panel1.TabIndex = 85;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.textEstadoAct);
            this.panel2.Controls.Add(this.labelEstado);
            this.panel2.Controls.Add(this.listCompetencias);
            this.panel2.Controls.Add(this.lblCompetencias);
            this.panel2.Controls.Add(this.comboResponsable);
            this.panel2.Controls.Add(this.labelResponsable);
            this.panel2.Controls.Add(this.comboAsignatura);
            this.panel2.Controls.Add(this.labelAsignatura);
            this.panel2.Controls.Add(this.labelGrado);
            this.panel2.Controls.Add(this.comboGrado);
            this.panel2.Controls.Add(this.comboTipoAct);
            this.panel2.Controls.Add(this.labelTipoActividad);
            this.panel2.Location = new System.Drawing.Point(9, 315);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(595, 170);
            this.panel2.TabIndex = 86;
            // 
            // textEstadoAct
            // 
            this.textEstadoAct.Enabled = false;
            this.textEstadoAct.Font = new System.Drawing.Font("Bahnschrift", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEstadoAct.Location = new System.Drawing.Point(393, 18);
            this.textEstadoAct.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textEstadoAct.Name = "textEstadoAct";
            this.textEstadoAct.Size = new System.Drawing.Size(121, 20);
            this.textEstadoAct.TabIndex = 85;
            // 
            // labelEstado
            // 
            this.labelEstado.AutoSize = true;
            this.labelEstado.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEstado.Location = new System.Drawing.Point(292, 19);
            this.labelEstado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelEstado.Name = "labelEstado";
            this.labelEstado.Size = new System.Drawing.Size(97, 14);
            this.labelEstado.TabIndex = 80;
            this.labelEstado.Text = "Estado Actividad:";
            // 
            // listCompetencias
            // 
            this.listCompetencias.Enabled = false;
            this.listCompetencias.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listCompetencias.FormattingEnabled = true;
            this.listCompetencias.Location = new System.Drawing.Point(393, 57);
            this.listCompetencias.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listCompetencias.Name = "listCompetencias";
            this.listCompetencias.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listCompetencias.Size = new System.Drawing.Size(198, 69);
            this.listCompetencias.TabIndex = 79;
            // 
            // lblCompetencias
            // 
            this.lblCompetencias.AutoSize = true;
            this.lblCompetencias.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompetencias.Location = new System.Drawing.Point(304, 57);
            this.lblCompetencias.Name = "lblCompetencias";
            this.lblCompetencias.Size = new System.Drawing.Size(85, 14);
            this.lblCompetencias.TabIndex = 78;
            this.lblCompetencias.Text = "Competencias:";
            // 
            // comboResponsable
            // 
            this.comboResponsable.Enabled = false;
            this.comboResponsable.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboResponsable.FormattingEnabled = true;
            this.comboResponsable.Location = new System.Drawing.Point(129, 137);
            this.comboResponsable.Name = "comboResponsable";
            this.comboResponsable.Size = new System.Drawing.Size(133, 21);
            this.comboResponsable.TabIndex = 77;
            // 
            // labelResponsable
            // 
            this.labelResponsable.AutoSize = true;
            this.labelResponsable.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResponsable.Location = new System.Drawing.Point(45, 139);
            this.labelResponsable.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelResponsable.Name = "labelResponsable";
            this.labelResponsable.Size = new System.Drawing.Size(79, 14);
            this.labelResponsable.TabIndex = 76;
            this.labelResponsable.Text = "Responsable:";
            // 
            // comboAsignatura
            // 
            this.comboAsignatura.Enabled = false;
            this.comboAsignatura.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboAsignatura.FormattingEnabled = true;
            this.comboAsignatura.Location = new System.Drawing.Point(129, 99);
            this.comboAsignatura.Name = "comboAsignatura";
            this.comboAsignatura.Size = new System.Drawing.Size(133, 21);
            this.comboAsignatura.TabIndex = 75;
            // 
            // labelAsignatura
            // 
            this.labelAsignatura.AutoSize = true;
            this.labelAsignatura.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAsignatura.Location = new System.Drawing.Point(56, 101);
            this.labelAsignatura.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelAsignatura.Name = "labelAsignatura";
            this.labelAsignatura.Size = new System.Drawing.Size(68, 14);
            this.labelAsignatura.TabIndex = 74;
            this.labelAsignatura.Text = "Asignatura:";
            // 
            // labelGrado
            // 
            this.labelGrado.AutoSize = true;
            this.labelGrado.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGrado.Location = new System.Drawing.Point(83, 59);
            this.labelGrado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelGrado.Name = "labelGrado";
            this.labelGrado.Size = new System.Drawing.Size(42, 14);
            this.labelGrado.TabIndex = 73;
            this.labelGrado.Text = "Grado:";
            // 
            // comboGrado
            // 
            this.comboGrado.Enabled = false;
            this.comboGrado.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboGrado.FormattingEnabled = true;
            this.comboGrado.Location = new System.Drawing.Point(130, 57);
            this.comboGrado.Name = "comboGrado";
            this.comboGrado.Size = new System.Drawing.Size(133, 21);
            this.comboGrado.TabIndex = 72;
            // 
            // comboTipoAct
            // 
            this.comboTipoAct.Enabled = false;
            this.comboTipoAct.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboTipoAct.Items.AddRange(new object[] {
            "TODAS",
            "VOLUNTARIADO",
            "FORMACION",
            "INVESTIGACION"});
            this.comboTipoAct.Location = new System.Drawing.Point(131, 20);
            this.comboTipoAct.Name = "comboTipoAct";
            this.comboTipoAct.Size = new System.Drawing.Size(133, 21);
            this.comboTipoAct.TabIndex = 71;
            // 
            // labelTipoActividad
            // 
            this.labelTipoActividad.AutoSize = true;
            this.labelTipoActividad.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTipoActividad.Location = new System.Drawing.Point(41, 25);
            this.labelTipoActividad.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTipoActividad.Name = "labelTipoActividad";
            this.labelTipoActividad.Size = new System.Drawing.Size(84, 14);
            this.labelTipoActividad.TabIndex = 70;
            this.labelTipoActividad.Text = "Tipo Actividad:";
            // 
            // VerActividadAbierta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(622, 533);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnAtras);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "VerActividadAbierta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Ver Actividad";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox listTrabajo;
        private System.Windows.Forms.ComboBox listAmbito;
        private System.Windows.Forms.ComboBox listTurno;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button btnAtras;
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelTipoActividad;
        private System.Windows.Forms.ComboBox comboTipoAct;
        private System.Windows.Forms.Label labelGrado;
        private System.Windows.Forms.ComboBox comboGrado;
        private System.Windows.Forms.ComboBox comboAsignatura;
        private System.Windows.Forms.Label labelAsignatura;
        private System.Windows.Forms.ComboBox comboResponsable;
        private System.Windows.Forms.Label labelResponsable;
        private System.Windows.Forms.Label lblCompetencias;
        private System.Windows.Forms.ListBox listCompetencias;
        private System.Windows.Forms.TextBox textEstadoAct;
        private System.Windows.Forms.Label labelEstado;
    }
}