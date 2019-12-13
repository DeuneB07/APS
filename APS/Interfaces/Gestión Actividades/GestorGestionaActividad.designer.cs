namespace APS.Interfaces
{
    partial class GestorGestionaActividad
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
            this.labelGrado = new System.Windows.Forms.Label();
            this.labelAsignatura = new System.Windows.Forms.Label();
            this.labelResponsable = new System.Windows.Forms.Label();
            this.labelTipoActividad = new System.Windows.Forms.Label();
            this.Aceptar = new System.Windows.Forms.Button();
            this.Cancelar = new System.Windows.Forms.Button();
            this.labelError = new System.Windows.Forms.Label();
            this.comboGrado = new System.Windows.Forms.ComboBox();
            this.comboAsig = new System.Windows.Forms.ComboBox();
            this.comboTipoAct = new System.Windows.Forms.ComboBox();
            this.comboResponsable = new System.Windows.Forms.ComboBox();
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.listTurno = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.listCompetencias = new System.Windows.Forms.ListBox();
            this.lblCompetencias = new System.Windows.Forms.Label();
            this.listTrabajo = new System.Windows.Forms.ComboBox();
            this.listAmbito = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelGrado
            // 
            this.labelGrado.AutoSize = true;
            this.labelGrado.Location = new System.Drawing.Point(64, 105);
            this.labelGrado.Name = "labelGrado";
            this.labelGrado.Size = new System.Drawing.Size(39, 13);
            this.labelGrado.TabIndex = 4;
            this.labelGrado.Text = "Grado:";
            // 
            // labelAsignatura
            // 
            this.labelAsignatura.AutoSize = true;
            this.labelAsignatura.Location = new System.Drawing.Point(50, 142);
            this.labelAsignatura.Name = "labelAsignatura";
            this.labelAsignatura.Size = new System.Drawing.Size(60, 13);
            this.labelAsignatura.TabIndex = 8;
            this.labelAsignatura.Text = "Asignatura:";
            // 
            // labelResponsable
            // 
            this.labelResponsable.AutoSize = true;
            this.labelResponsable.Location = new System.Drawing.Point(38, 230);
            this.labelResponsable.Name = "labelResponsable";
            this.labelResponsable.Size = new System.Drawing.Size(72, 13);
            this.labelResponsable.TabIndex = 9;
            this.labelResponsable.Text = "Responsable:";
            // 
            // labelTipoActividad
            // 
            this.labelTipoActividad.AutoSize = true;
            this.labelTipoActividad.Location = new System.Drawing.Point(34, 184);
            this.labelTipoActividad.Name = "labelTipoActividad";
            this.labelTipoActividad.Size = new System.Drawing.Size(78, 13);
            this.labelTipoActividad.TabIndex = 10;
            this.labelTipoActividad.Text = "Tipo Actividad:";
            // 
            // Aceptar
            // 
            this.Aceptar.Location = new System.Drawing.Point(376, 489);
            this.Aceptar.Name = "Aceptar";
            this.Aceptar.Size = new System.Drawing.Size(75, 23);
            this.Aceptar.TabIndex = 12;
            this.Aceptar.Text = "Aceptar";
            this.Aceptar.UseVisualStyleBackColor = true;
            this.Aceptar.Click += new System.EventHandler(this.Aceptar_Click);
            // 
            // Cancelar
            // 
            this.Cancelar.Location = new System.Drawing.Point(482, 489);
            this.Cancelar.Name = "Cancelar";
            this.Cancelar.Size = new System.Drawing.Size(75, 23);
            this.Cancelar.TabIndex = 13;
            this.Cancelar.Text = "Cancelar";
            this.Cancelar.UseVisualStyleBackColor = true;
            this.Cancelar.Click += new System.EventHandler(this.Cancelar_Click);
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.BackColor = System.Drawing.Color.Transparent;
            this.labelError.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelError.ForeColor = System.Drawing.Color.Red;
            this.labelError.Location = new System.Drawing.Point(14, 393);
            this.labelError.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(33, 13);
            this.labelError.TabIndex = 28;
            this.labelError.Text = "error";
            // 
            // comboGrado
            // 
            this.comboGrado.FormattingEnabled = true;
            this.comboGrado.Location = new System.Drawing.Point(124, 105);
            this.comboGrado.Name = "comboGrado";
            this.comboGrado.Size = new System.Drawing.Size(133, 21);
            this.comboGrado.TabIndex = 29;
            this.comboGrado.SelectedIndexChanged += new System.EventHandler(this.comboGrado_SelectedIndexChanged);
            // 
            // comboAsig
            // 
            this.comboAsig.Location = new System.Drawing.Point(124, 142);
            this.comboAsig.Name = "comboAsig";
            this.comboAsig.Size = new System.Drawing.Size(133, 21);
            this.comboAsig.TabIndex = 30;
            this.comboAsig.SelectedIndexChanged += new System.EventHandler(this.comboAsig_SelectedIndexChanged);
            // 
            // comboTipoAct
            // 
            this.comboTipoAct.Items.AddRange(new object[] {
            "TODAS",
            "VOLUNTARIADO",
            "FORMACION",
            "INVESTIGACION"});
            this.comboTipoAct.Location = new System.Drawing.Point(124, 184);
            this.comboTipoAct.Name = "comboTipoAct";
            this.comboTipoAct.Size = new System.Drawing.Size(133, 21);
            this.comboTipoAct.TabIndex = 31;
            this.comboTipoAct.SelectedIndexChanged += new System.EventHandler(this.comboTipoAct_SelectedIndexChanged);
            // 
            // comboResponsable
            // 
            this.comboResponsable.Location = new System.Drawing.Point(124, 228);
            this.comboResponsable.Name = "comboResponsable";
            this.comboResponsable.Size = new System.Drawing.Size(133, 21);
            this.comboResponsable.TabIndex = 32;
            // 
            // tLugar
            // 
            this.tLugar.Enabled = false;
            this.tLugar.Location = new System.Drawing.Point(124, 301);
            this.tLugar.Margin = new System.Windows.Forms.Padding(2);
            this.tLugar.Name = "tLugar";
            this.tLugar.Size = new System.Drawing.Size(148, 20);
            this.tLugar.TabIndex = 69;
            // 
            // dateTimePickerFechaFin
            // 
            this.dateTimePickerFechaFin.Enabled = false;
            this.dateTimePickerFechaFin.Location = new System.Drawing.Point(124, 265);
            this.dateTimePickerFechaFin.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePickerFechaFin.Name = "dateTimePickerFechaFin";
            this.dateTimePickerFechaFin.Size = new System.Drawing.Size(151, 20);
            this.dateTimePickerFechaFin.TabIndex = 68;
            // 
            // dateTimePickerFechaIni
            // 
            this.dateTimePickerFechaIni.Enabled = false;
            this.dateTimePickerFechaIni.Location = new System.Drawing.Point(124, 232);
            this.dateTimePickerFechaIni.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePickerFechaIni.Name = "dateTimePickerFechaIni";
            this.dateTimePickerFechaIni.Size = new System.Drawing.Size(151, 20);
            this.dateTimePickerFechaIni.TabIndex = 67;
            // 
            // tNumHoras
            // 
            this.tNumHoras.Enabled = false;
            this.tNumHoras.Location = new System.Drawing.Point(124, 199);
            this.tNumHoras.Margin = new System.Windows.Forms.Padding(2);
            this.tNumHoras.Name = "tNumHoras";
            this.tNumHoras.Size = new System.Drawing.Size(43, 20);
            this.tNumHoras.TabIndex = 66;
            // 
            // tNumPlazas
            // 
            this.tNumPlazas.Enabled = false;
            this.tNumPlazas.Location = new System.Drawing.Point(124, 168);
            this.tNumPlazas.Margin = new System.Windows.Forms.Padding(2);
            this.tNumPlazas.Name = "tNumPlazas";
            this.tNumPlazas.Size = new System.Drawing.Size(43, 20);
            this.tNumPlazas.TabIndex = 65;
            // 
            // tDescripcion
            // 
            this.tDescripcion.Enabled = false;
            this.tDescripcion.Location = new System.Drawing.Point(128, 92);
            this.tDescripcion.Margin = new System.Windows.Forms.Padding(2);
            this.tDescripcion.Name = "tDescripcion";
            this.tDescripcion.Size = new System.Drawing.Size(138, 59);
            this.tDescripcion.TabIndex = 64;
            this.tDescripcion.Text = "";
            // 
            // tNombreAct
            // 
            this.tNombreAct.Enabled = false;
            this.tNombreAct.Location = new System.Drawing.Point(128, 58);
            this.tNombreAct.Margin = new System.Windows.Forms.Padding(2);
            this.tNombreAct.Name = "tNombreAct";
            this.tNombreAct.Size = new System.Drawing.Size(138, 20);
            this.tNombreAct.TabIndex = 63;
            // 
            // tOrganizador
            // 
            this.tOrganizador.Enabled = false;
            this.tOrganizador.Location = new System.Drawing.Point(128, 22);
            this.tOrganizador.Margin = new System.Windows.Forms.Padding(2);
            this.tOrganizador.Name = "tOrganizador";
            this.tOrganizador.Size = new System.Drawing.Size(138, 20);
            this.tOrganizador.TabIndex = 62;
            // 
            // labelTipo
            // 
            this.labelTipo.AutoSize = true;
            this.labelTipo.Location = new System.Drawing.Point(49, 402);
            this.labelTipo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTipo.Name = "labelTipo";
            this.labelTipo.Size = new System.Drawing.Size(70, 13);
            this.labelTipo.TabIndex = 61;
            this.labelTipo.Text = "Tipo Trabajo:";
            // 
            // labelAmbito
            // 
            this.labelAmbito.AutoSize = true;
            this.labelAmbito.Location = new System.Drawing.Point(39, 368);
            this.labelAmbito.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelAmbito.Name = "labelAmbito";
            this.labelAmbito.Size = new System.Drawing.Size(81, 13);
            this.labelAmbito.TabIndex = 60;
            this.labelAmbito.Text = "Ambito Trabajo:";
            // 
            // labelTurno
            // 
            this.labelTurno.AutoSize = true;
            this.labelTurno.Location = new System.Drawing.Point(83, 334);
            this.labelTurno.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTurno.Name = "labelTurno";
            this.labelTurno.Size = new System.Drawing.Size(38, 13);
            this.labelTurno.TabIndex = 59;
            this.labelTurno.Text = "Turno:";
            // 
            // labelLugar
            // 
            this.labelLugar.AutoSize = true;
            this.labelLugar.Location = new System.Drawing.Point(83, 301);
            this.labelLugar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelLugar.Name = "labelLugar";
            this.labelLugar.Size = new System.Drawing.Size(37, 13);
            this.labelLugar.TabIndex = 58;
            this.labelLugar.Text = "Lugar:";
            // 
            // labelFechaFin
            // 
            this.labelFechaFin.AutoSize = true;
            this.labelFechaFin.Location = new System.Drawing.Point(64, 265);
            this.labelFechaFin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelFechaFin.Name = "labelFechaFin";
            this.labelFechaFin.Size = new System.Drawing.Size(57, 13);
            this.labelFechaFin.TabIndex = 57;
            this.labelFechaFin.Text = "Fecha Fin:";
            // 
            // labelFechaInicio
            // 
            this.labelFechaInicio.AutoSize = true;
            this.labelFechaInicio.Location = new System.Drawing.Point(55, 232);
            this.labelFechaInicio.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelFechaInicio.Name = "labelFechaInicio";
            this.labelFechaInicio.Size = new System.Drawing.Size(68, 13);
            this.labelFechaInicio.TabIndex = 56;
            this.labelFechaInicio.Text = "Fecha Inicio:";
            // 
            // labelNumHoras
            // 
            this.labelNumHoras.AutoSize = true;
            this.labelNumHoras.Location = new System.Drawing.Point(42, 199);
            this.labelNumHoras.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNumHoras.Name = "labelNumHoras";
            this.labelNumHoras.Size = new System.Drawing.Size(78, 13);
            this.labelNumHoras.TabIndex = 55;
            this.labelNumHoras.Text = "Número Horas:";
            // 
            // labelNumPlazas
            // 
            this.labelNumPlazas.AutoSize = true;
            this.labelNumPlazas.Location = new System.Drawing.Point(39, 168);
            this.labelNumPlazas.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNumPlazas.Name = "labelNumPlazas";
            this.labelNumPlazas.Size = new System.Drawing.Size(81, 13);
            this.labelNumPlazas.TabIndex = 54;
            this.labelNumPlazas.Text = "Número Plazas:";
            // 
            // labelDescripcion
            // 
            this.labelDescripcion.AutoSize = true;
            this.labelDescripcion.Location = new System.Drawing.Point(16, 103);
            this.labelDescripcion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDescripcion.Name = "labelDescripcion";
            this.labelDescripcion.Size = new System.Drawing.Size(113, 13);
            this.labelDescripcion.TabIndex = 53;
            this.labelDescripcion.Text = "Descripción Actividad:";
            // 
            // labelNombreAct
            // 
            this.labelNombreAct.AutoSize = true;
            this.labelNombreAct.Location = new System.Drawing.Point(31, 58);
            this.labelNombreAct.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNombreAct.Name = "labelNombreAct";
            this.labelNombreAct.Size = new System.Drawing.Size(94, 13);
            this.labelNombreAct.TabIndex = 52;
            this.labelNombreAct.Text = "Nombre Actividad:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 51;
            this.label1.Text = "Organizador:";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.listAmbito);
            this.panel1.Controls.Add(this.listTrabajo);
            this.panel1.Controls.Add(this.listTurno);
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
            this.panel1.Controls.Add(this.labelNombreAct);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(9, 10);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(292, 440);
            this.panel1.TabIndex = 73;
            // 
            // listTurno
            // 
            this.listTurno.FormattingEnabled = true;
            this.listTurno.Location = new System.Drawing.Point(124, 332);
            this.listTurno.Name = "listTurno";
            this.listTurno.Size = new System.Drawing.Size(121, 21);
            this.listTurno.TabIndex = 73;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.listCompetencias);
            this.panel2.Controls.Add(this.lblCompetencias);
            this.panel2.Controls.Add(this.comboResponsable);
            this.panel2.Controls.Add(this.comboTipoAct);
            this.panel2.Controls.Add(this.comboAsig);
            this.panel2.Controls.Add(this.labelError);
            this.panel2.Controls.Add(this.comboGrado);
            this.panel2.Controls.Add(this.labelTipoActividad);
            this.panel2.Controls.Add(this.labelResponsable);
            this.panel2.Controls.Add(this.labelAsignatura);
            this.panel2.Controls.Add(this.labelGrado);
            this.panel2.Location = new System.Drawing.Point(298, 10);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(273, 440);
            this.panel2.TabIndex = 74;
            // 
            // listCompetencias
            // 
            this.listCompetencias.FormattingEnabled = true;
            this.listCompetencias.Location = new System.Drawing.Point(124, 271);
            this.listCompetencias.Margin = new System.Windows.Forms.Padding(2);
            this.listCompetencias.Name = "listCompetencias";
            this.listCompetencias.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listCompetencias.Size = new System.Drawing.Size(133, 82);
            this.listCompetencias.TabIndex = 34;
            // 
            // lblCompetencias
            // 
            this.lblCompetencias.AutoSize = true;
            this.lblCompetencias.Location = new System.Drawing.Point(34, 274);
            this.lblCompetencias.Name = "lblCompetencias";
            this.lblCompetencias.Size = new System.Drawing.Size(77, 13);
            this.lblCompetencias.TabIndex = 33;
            this.lblCompetencias.Text = "Competencias:";
            // 
            // listTrabajo
            // 
            this.listTrabajo.FormattingEnabled = true;
            this.listTrabajo.Location = new System.Drawing.Point(124, 399);
            this.listTrabajo.Name = "listTrabajo";
            this.listTrabajo.Size = new System.Drawing.Size(121, 21);
            this.listTrabajo.TabIndex = 74;
            // 
            // listAmbito
            // 
            this.listAmbito.FormattingEnabled = true;
            this.listAmbito.Location = new System.Drawing.Point(124, 365);
            this.listAmbito.Name = "listAmbito";
            this.listAmbito.Size = new System.Drawing.Size(121, 21);
            this.listAmbito.TabIndex = 75;
            // 
            // GestorGestionaActividad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(578, 522);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelDescripcion);
            this.Controls.Add(this.Cancelar);
            this.Controls.Add(this.Aceptar);
            this.Name = "GestorGestionaActividad";
            this.Text = "Actividad ...";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelGrado;
        private System.Windows.Forms.Label labelAsignatura;
        private System.Windows.Forms.Label labelResponsable;
        private System.Windows.Forms.Label labelTipoActividad;
        private System.Windows.Forms.Button Aceptar;
        private System.Windows.Forms.Button Cancelar;
        private System.Windows.Forms.Label labelError;
        private System.Windows.Forms.ComboBox comboGrado;
        private System.Windows.Forms.ComboBox comboAsig;
        private System.Windows.Forms.ComboBox comboTipoAct;
        private System.Windows.Forms.ComboBox comboResponsable;
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblCompetencias;
        private System.Windows.Forms.ListBox listCompetencias;
        private System.Windows.Forms.ComboBox listTurno;
        private System.Windows.Forms.ComboBox listAmbito;
        private System.Windows.Forms.ComboBox listTrabajo;
    }
}