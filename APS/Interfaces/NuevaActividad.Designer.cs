namespace APS.Interfaces
{
    partial class NuevaActividad
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
            this.labelOrganizador = new System.Windows.Forms.Label();
            this.labelNombreAct = new System.Windows.Forms.Label();
            this.labelDescripcion = new System.Windows.Forms.Label();
            this.labelNumPlazas = new System.Windows.Forms.Label();
            this.labelNumHoras = new System.Windows.Forms.Label();
            this.labelFechaInicio = new System.Windows.Forms.Label();
            this.labelFechaFin = new System.Windows.Forms.Label();
            this.labelLugar = new System.Windows.Forms.Label();
            this.labelTurno = new System.Windows.Forms.Label();
            this.labelImagen = new System.Windows.Forms.Label();
            this.labelAmbito = new System.Windows.Forms.Label();
            this.labelTipo = new System.Windows.Forms.Label();
            this.bAceptar = new System.Windows.Forms.Button();
            this.bCancelar = new System.Windows.Forms.Button();
            this.tOrganizador = new System.Windows.Forms.TextBox();
            this.tNombreAct = new System.Windows.Forms.TextBox();
            this.tDescripcion = new System.Windows.Forms.RichTextBox();
            this.tNumPlazas = new System.Windows.Forms.TextBox();
            this.tNumHoras = new System.Windows.Forms.TextBox();
            this.dateTimePickerFechaIni = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerFechaFin = new System.Windows.Forms.DateTimePicker();
            this.tLugar = new System.Windows.Forms.TextBox();
            this.tImagen = new System.Windows.Forms.TextBox();
            this.listTurno = new System.Windows.Forms.ListBox();
            this.listAmbito = new System.Windows.Forms.ListBox();
            this.listTrabajo = new System.Windows.Forms.ListBox();
            this.labelError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelOrganizador
            // 
            this.labelOrganizador.AutoSize = true;
            this.labelOrganizador.Location = new System.Drawing.Point(150, 46);
            this.labelOrganizador.Name = "labelOrganizador";
            this.labelOrganizador.Size = new System.Drawing.Size(91, 17);
            this.labelOrganizador.TabIndex = 0;
            this.labelOrganizador.Text = "Organizador:";
            // 
            // labelNombreAct
            // 
            this.labelNombreAct.AutoSize = true;
            this.labelNombreAct.Location = new System.Drawing.Point(118, 91);
            this.labelNombreAct.Name = "labelNombreAct";
            this.labelNombreAct.Size = new System.Drawing.Size(123, 17);
            this.labelNombreAct.TabIndex = 1;
            this.labelNombreAct.Text = "Nombre Actividad:";
            // 
            // labelDescripcion
            // 
            this.labelDescripcion.AutoSize = true;
            this.labelDescripcion.Location = new System.Drawing.Point(94, 132);
            this.labelDescripcion.Name = "labelDescripcion";
            this.labelDescripcion.Size = new System.Drawing.Size(147, 17);
            this.labelDescripcion.TabIndex = 2;
            this.labelDescripcion.Text = "Descripción Actividad:";
            // 
            // labelNumPlazas
            // 
            this.labelNumPlazas.AutoSize = true;
            this.labelNumPlazas.Location = new System.Drawing.Point(129, 226);
            this.labelNumPlazas.Name = "labelNumPlazas";
            this.labelNumPlazas.Size = new System.Drawing.Size(108, 17);
            this.labelNumPlazas.TabIndex = 3;
            this.labelNumPlazas.Text = "Número Plazas:";
            // 
            // labelNumHoras
            // 
            this.labelNumHoras.AutoSize = true;
            this.labelNumHoras.Location = new System.Drawing.Point(133, 264);
            this.labelNumHoras.Name = "labelNumHoras";
            this.labelNumHoras.Size = new System.Drawing.Size(104, 17);
            this.labelNumHoras.TabIndex = 4;
            this.labelNumHoras.Text = "Número Horas:";
            // 
            // labelFechaInicio
            // 
            this.labelFechaInicio.AutoSize = true;
            this.labelFechaInicio.Location = new System.Drawing.Point(150, 305);
            this.labelFechaInicio.Name = "labelFechaInicio";
            this.labelFechaInicio.Size = new System.Drawing.Size(87, 17);
            this.labelFechaInicio.TabIndex = 5;
            this.labelFechaInicio.Text = "Fecha Inicio:";
            // 
            // labelFechaFin
            // 
            this.labelFechaFin.AutoSize = true;
            this.labelFechaFin.Location = new System.Drawing.Point(163, 345);
            this.labelFechaFin.Name = "labelFechaFin";
            this.labelFechaFin.Size = new System.Drawing.Size(74, 17);
            this.labelFechaFin.TabIndex = 6;
            this.labelFechaFin.Text = "Fecha Fin:";
            // 
            // labelLugar
            // 
            this.labelLugar.AutoSize = true;
            this.labelLugar.Location = new System.Drawing.Point(188, 389);
            this.labelLugar.Name = "labelLugar";
            this.labelLugar.Size = new System.Drawing.Size(49, 17);
            this.labelLugar.TabIndex = 7;
            this.labelLugar.Text = "Lugar:";
            // 
            // labelTurno
            // 
            this.labelTurno.AutoSize = true;
            this.labelTurno.Location = new System.Drawing.Point(188, 430);
            this.labelTurno.Name = "labelTurno";
            this.labelTurno.Size = new System.Drawing.Size(50, 17);
            this.labelTurno.TabIndex = 8;
            this.labelTurno.Text = "Turno:";
            // 
            // labelImagen
            // 
            this.labelImagen.AutoSize = true;
            this.labelImagen.Location = new System.Drawing.Point(371, 430);
            this.labelImagen.Name = "labelImagen";
            this.labelImagen.Size = new System.Drawing.Size(58, 17);
            this.labelImagen.TabIndex = 9;
            this.labelImagen.Text = "Imagen:";
            // 
            // labelAmbito
            // 
            this.labelAmbito.AutoSize = true;
            this.labelAmbito.Location = new System.Drawing.Point(129, 472);
            this.labelAmbito.Name = "labelAmbito";
            this.labelAmbito.Size = new System.Drawing.Size(108, 17);
            this.labelAmbito.TabIndex = 10;
            this.labelAmbito.Text = "Ambito Trabajo:";
            // 
            // labelTipo
            // 
            this.labelTipo.AutoSize = true;
            this.labelTipo.Location = new System.Drawing.Point(144, 503);
            this.labelTipo.Name = "labelTipo";
            this.labelTipo.Size = new System.Drawing.Size(93, 17);
            this.labelTipo.TabIndex = 11;
            this.labelTipo.Text = "Tipo Trabajo:";
            // 
            // bAceptar
            // 
            this.bAceptar.Location = new System.Drawing.Point(438, 558);
            this.bAceptar.Name = "bAceptar";
            this.bAceptar.Size = new System.Drawing.Size(75, 23);
            this.bAceptar.TabIndex = 12;
            this.bAceptar.Text = "Aceptar";
            this.bAceptar.UseVisualStyleBackColor = true;
            this.bAceptar.Click += new System.EventHandler(this.bAceptar_Click);
            // 
            // bCancelar
            // 
            this.bCancelar.Location = new System.Drawing.Point(541, 558);
            this.bCancelar.Name = "bCancelar";
            this.bCancelar.Size = new System.Drawing.Size(75, 23);
            this.bCancelar.TabIndex = 13;
            this.bCancelar.Text = "Cancelar";
            this.bCancelar.UseVisualStyleBackColor = true;
            this.bCancelar.Click += new System.EventHandler(this.bCancelar_Click);
            // 
            // tOrganizador
            // 
            this.tOrganizador.Enabled = false;
            this.tOrganizador.Location = new System.Drawing.Point(247, 46);
            this.tOrganizador.Name = "tOrganizador";
            this.tOrganizador.Size = new System.Drawing.Size(182, 22);
            this.tOrganizador.TabIndex = 14;
            // 
            // tNombreAct
            // 
            this.tNombreAct.Location = new System.Drawing.Point(247, 91);
            this.tNombreAct.Name = "tNombreAct";
            this.tNombreAct.Size = new System.Drawing.Size(182, 22);
            this.tNombreAct.TabIndex = 15;
            // 
            // tDescripcion
            // 
            this.tDescripcion.Location = new System.Drawing.Point(247, 132);
            this.tDescripcion.Name = "tDescripcion";
            this.tDescripcion.Size = new System.Drawing.Size(182, 72);
            this.tDescripcion.TabIndex = 16;
            this.tDescripcion.Text = "";
            // 
            // tNumPlazas
            // 
            this.tNumPlazas.Location = new System.Drawing.Point(243, 226);
            this.tNumPlazas.Name = "tNumPlazas";
            this.tNumPlazas.Size = new System.Drawing.Size(56, 22);
            this.tNumPlazas.TabIndex = 18;
            // 
            // tNumHoras
            // 
            this.tNumHoras.Location = new System.Drawing.Point(243, 264);
            this.tNumHoras.Name = "tNumHoras";
            this.tNumHoras.Size = new System.Drawing.Size(56, 22);
            this.tNumHoras.TabIndex = 19;
            // 
            // dateTimePickerFechaIni
            // 
            this.dateTimePickerFechaIni.Location = new System.Drawing.Point(243, 305);
            this.dateTimePickerFechaIni.Name = "dateTimePickerFechaIni";
            this.dateTimePickerFechaIni.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerFechaIni.TabIndex = 20;
            // 
            // dateTimePickerFechaFin
            // 
            this.dateTimePickerFechaFin.Location = new System.Drawing.Point(243, 345);
            this.dateTimePickerFechaFin.Name = "dateTimePickerFechaFin";
            this.dateTimePickerFechaFin.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerFechaFin.TabIndex = 21;
            // 
            // tLugar
            // 
            this.tLugar.Location = new System.Drawing.Point(247, 389);
            this.tLugar.Name = "tLugar";
            this.tLugar.Size = new System.Drawing.Size(196, 22);
            this.tLugar.TabIndex = 22;
            // 
            // tImagen
            // 
            this.tImagen.Location = new System.Drawing.Point(435, 430);
            this.tImagen.Name = "tImagen";
            this.tImagen.Size = new System.Drawing.Size(170, 22);
            this.tImagen.TabIndex = 23;
            // 
            // listTurno
            // 
            this.listTurno.FormattingEnabled = true;
            this.listTurno.ItemHeight = 16;
            this.listTurno.Items.AddRange(new object[] {
            "MAÑANA",
            "TARDE"});
            this.listTurno.Location = new System.Drawing.Point(247, 430);
            this.listTurno.Name = "listTurno";
            this.listTurno.Size = new System.Drawing.Size(120, 20);
            this.listTurno.TabIndex = 24;
            // 
            // listAmbito
            // 
            this.listAmbito.FormattingEnabled = true;
            this.listAmbito.ItemHeight = 16;
            this.listAmbito.Items.AddRange(new object[] {
            "SALUD",
            "INMIGRACIÓN",
            "POBREZA",
            "HAMBRUNA"});
            this.listAmbito.Location = new System.Drawing.Point(243, 472);
            this.listAmbito.Name = "listAmbito";
            this.listAmbito.Size = new System.Drawing.Size(138, 20);
            this.listAmbito.TabIndex = 25;
            // 
            // listTrabajo
            // 
            this.listTrabajo.FormattingEnabled = true;
            this.listTrabajo.ItemHeight = 16;
            this.listTrabajo.Items.AddRange(new object[] {
            "EVENTO"});
            this.listTrabajo.Location = new System.Drawing.Point(243, 503);
            this.listTrabajo.Name = "listTrabajo";
            this.listTrabajo.Size = new System.Drawing.Size(138, 20);
            this.listTrabajo.TabIndex = 26;
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.BackColor = System.Drawing.Color.Transparent;
            this.labelError.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelError.ForeColor = System.Drawing.Color.Red;
            this.labelError.Location = new System.Drawing.Point(48, 576);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(44, 17);
            this.labelError.TabIndex = 27;
            this.labelError.Text = "error";
            // 
            // NuevaActividad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 629);
            this.Controls.Add(this.labelError);
            this.Controls.Add(this.listTrabajo);
            this.Controls.Add(this.listAmbito);
            this.Controls.Add(this.listTurno);
            this.Controls.Add(this.tImagen);
            this.Controls.Add(this.tLugar);
            this.Controls.Add(this.dateTimePickerFechaFin);
            this.Controls.Add(this.dateTimePickerFechaIni);
            this.Controls.Add(this.tNumHoras);
            this.Controls.Add(this.tNumPlazas);
            this.Controls.Add(this.tDescripcion);
            this.Controls.Add(this.tNombreAct);
            this.Controls.Add(this.tOrganizador);
            this.Controls.Add(this.bCancelar);
            this.Controls.Add(this.bAceptar);
            this.Controls.Add(this.labelTipo);
            this.Controls.Add(this.labelAmbito);
            this.Controls.Add(this.labelImagen);
            this.Controls.Add(this.labelTurno);
            this.Controls.Add(this.labelLugar);
            this.Controls.Add(this.labelFechaFin);
            this.Controls.Add(this.labelFechaInicio);
            this.Controls.Add(this.labelNumHoras);
            this.Controls.Add(this.labelNumPlazas);
            this.Controls.Add(this.labelDescripcion);
            this.Controls.Add(this.labelNombreAct);
            this.Controls.Add(this.labelOrganizador);
            this.Name = "NuevaActividad";
            this.Text = "º";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelOrganizador;
        private System.Windows.Forms.Label labelNombreAct;
        private System.Windows.Forms.Label labelDescripcion;
        private System.Windows.Forms.Label labelNumPlazas;
        private System.Windows.Forms.Label labelNumHoras;
        private System.Windows.Forms.Label labelFechaInicio;
        private System.Windows.Forms.Label labelFechaFin;
        private System.Windows.Forms.Label labelLugar;
        private System.Windows.Forms.Label labelTurno;
        private System.Windows.Forms.Label labelImagen;
        private System.Windows.Forms.Label labelAmbito;
        private System.Windows.Forms.Label labelTipo;
        private System.Windows.Forms.Button bAceptar;
        private System.Windows.Forms.Button bCancelar;
        private System.Windows.Forms.TextBox tOrganizador;
        private System.Windows.Forms.TextBox tNombreAct;
        private System.Windows.Forms.RichTextBox tDescripcion;
        private System.Windows.Forms.TextBox tNumPlazas;
        private System.Windows.Forms.TextBox tNumHoras;
        private System.Windows.Forms.DateTimePicker dateTimePickerFechaIni;
        private System.Windows.Forms.DateTimePicker dateTimePickerFechaFin;
        private System.Windows.Forms.TextBox tLugar;
        private System.Windows.Forms.TextBox tImagen;
        private System.Windows.Forms.ListBox listTurno;
        private System.Windows.Forms.ListBox listAmbito;
        private System.Windows.Forms.ListBox listTrabajo;
        private System.Windows.Forms.Label labelError;
    }
}