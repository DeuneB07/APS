using APS.Mapeo;

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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NuevaActividad));
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
            this.tURL = new System.Windows.Forms.TextBox();
            this.labelError = new System.Windows.Forms.Label();
            this.ambitoTrabajoEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tipoTrabajoEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnExaminar = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.actividadBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listTurno = new System.Windows.Forms.ComboBox();
            this.listAmbito = new System.Windows.Forms.ComboBox();
            this.listTrabajo = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.ambitoTrabajoEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoTrabajoEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.actividadBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // labelOrganizador
            // 
            this.labelOrganizador.AutoSize = true;
            this.labelOrganizador.Location = new System.Drawing.Point(112, 37);
            this.labelOrganizador.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelOrganizador.Name = "labelOrganizador";
            this.labelOrganizador.Size = new System.Drawing.Size(67, 13);
            this.labelOrganizador.TabIndex = 0;
            this.labelOrganizador.Text = "Organizador:";
            // 
            // labelNombreAct
            // 
            this.labelNombreAct.AutoSize = true;
            this.labelNombreAct.Location = new System.Drawing.Point(88, 74);
            this.labelNombreAct.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNombreAct.Name = "labelNombreAct";
            this.labelNombreAct.Size = new System.Drawing.Size(94, 13);
            this.labelNombreAct.TabIndex = 1;
            this.labelNombreAct.Text = "Nombre Actividad:";
            // 
            // labelDescripcion
            // 
            this.labelDescripcion.AutoSize = true;
            this.labelDescripcion.Location = new System.Drawing.Point(70, 107);
            this.labelDescripcion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDescripcion.Name = "labelDescripcion";
            this.labelDescripcion.Size = new System.Drawing.Size(113, 13);
            this.labelDescripcion.TabIndex = 2;
            this.labelDescripcion.Text = "Descripción Actividad:";
            // 
            // labelNumPlazas
            // 
            this.labelNumPlazas.AutoSize = true;
            this.labelNumPlazas.Location = new System.Drawing.Point(97, 184);
            this.labelNumPlazas.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNumPlazas.Name = "labelNumPlazas";
            this.labelNumPlazas.Size = new System.Drawing.Size(81, 13);
            this.labelNumPlazas.TabIndex = 3;
            this.labelNumPlazas.Text = "Número Plazas:";
            // 
            // labelNumHoras
            // 
            this.labelNumHoras.AutoSize = true;
            this.labelNumHoras.Location = new System.Drawing.Point(100, 214);
            this.labelNumHoras.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNumHoras.Name = "labelNumHoras";
            this.labelNumHoras.Size = new System.Drawing.Size(78, 13);
            this.labelNumHoras.TabIndex = 4;
            this.labelNumHoras.Text = "Número Horas:";
            // 
            // labelFechaInicio
            // 
            this.labelFechaInicio.AutoSize = true;
            this.labelFechaInicio.Location = new System.Drawing.Point(112, 248);
            this.labelFechaInicio.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelFechaInicio.Name = "labelFechaInicio";
            this.labelFechaInicio.Size = new System.Drawing.Size(68, 13);
            this.labelFechaInicio.TabIndex = 5;
            this.labelFechaInicio.Text = "Fecha Inicio:";
            // 
            // labelFechaFin
            // 
            this.labelFechaFin.AutoSize = true;
            this.labelFechaFin.Location = new System.Drawing.Point(122, 280);
            this.labelFechaFin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelFechaFin.Name = "labelFechaFin";
            this.labelFechaFin.Size = new System.Drawing.Size(57, 13);
            this.labelFechaFin.TabIndex = 6;
            this.labelFechaFin.Text = "Fecha Fin:";
            // 
            // labelLugar
            // 
            this.labelLugar.AutoSize = true;
            this.labelLugar.Location = new System.Drawing.Point(141, 316);
            this.labelLugar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelLugar.Name = "labelLugar";
            this.labelLugar.Size = new System.Drawing.Size(37, 13);
            this.labelLugar.TabIndex = 7;
            this.labelLugar.Text = "Lugar:";
            // 
            // labelTurno
            // 
            this.labelTurno.AutoSize = true;
            this.labelTurno.Location = new System.Drawing.Point(141, 349);
            this.labelTurno.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTurno.Name = "labelTurno";
            this.labelTurno.Size = new System.Drawing.Size(38, 13);
            this.labelTurno.TabIndex = 8;
            this.labelTurno.Text = "Turno:";
            // 
            // labelImagen
            // 
            this.labelImagen.AutoSize = true;
            this.labelImagen.Location = new System.Drawing.Point(278, 349);
            this.labelImagen.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelImagen.Name = "labelImagen";
            this.labelImagen.Size = new System.Drawing.Size(45, 13);
            this.labelImagen.TabIndex = 9;
            this.labelImagen.Text = "Imagen:";
            // 
            // labelAmbito
            // 
            this.labelAmbito.AutoSize = true;
            this.labelAmbito.Location = new System.Drawing.Point(97, 384);
            this.labelAmbito.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelAmbito.Name = "labelAmbito";
            this.labelAmbito.Size = new System.Drawing.Size(81, 13);
            this.labelAmbito.TabIndex = 10;
            this.labelAmbito.Text = "Ambito Trabajo:";
            // 
            // labelTipo
            // 
            this.labelTipo.AutoSize = true;
            this.labelTipo.Location = new System.Drawing.Point(108, 413);
            this.labelTipo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTipo.Name = "labelTipo";
            this.labelTipo.Size = new System.Drawing.Size(70, 13);
            this.labelTipo.TabIndex = 11;
            this.labelTipo.Text = "Tipo Trabajo:";
            // 
            // bAceptar
            // 
            this.bAceptar.Location = new System.Drawing.Point(328, 453);
            this.bAceptar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bAceptar.Name = "bAceptar";
            this.bAceptar.Size = new System.Drawing.Size(56, 19);
            this.bAceptar.TabIndex = 12;
            this.bAceptar.Text = "Aceptar";
            this.bAceptar.UseVisualStyleBackColor = true;
            this.bAceptar.Click += new System.EventHandler(this.bAceptar_Click);
            // 
            // bCancelar
            // 
            this.bCancelar.Location = new System.Drawing.Point(406, 453);
            this.bCancelar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bCancelar.Name = "bCancelar";
            this.bCancelar.Size = new System.Drawing.Size(56, 19);
            this.bCancelar.TabIndex = 13;
            this.bCancelar.Text = "Cancelar";
            this.bCancelar.UseVisualStyleBackColor = true;
            this.bCancelar.Click += new System.EventHandler(this.bCancelar_Click);
            // 
            // tOrganizador
            // 
            this.tOrganizador.Enabled = false;
            this.tOrganizador.Location = new System.Drawing.Point(185, 37);
            this.tOrganizador.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tOrganizador.Name = "tOrganizador";
            this.tOrganizador.Size = new System.Drawing.Size(138, 20);
            this.tOrganizador.TabIndex = 14;
            // 
            // tNombreAct
            // 
            this.tNombreAct.Location = new System.Drawing.Point(185, 74);
            this.tNombreAct.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tNombreAct.Name = "tNombreAct";
            this.tNombreAct.Size = new System.Drawing.Size(138, 20);
            this.tNombreAct.TabIndex = 15;
            // 
            // tDescripcion
            // 
            this.tDescripcion.Location = new System.Drawing.Point(185, 107);
            this.tDescripcion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tDescripcion.Name = "tDescripcion";
            this.tDescripcion.Size = new System.Drawing.Size(138, 59);
            this.tDescripcion.TabIndex = 16;
            this.tDescripcion.Text = "";
            // 
            // tNumPlazas
            // 
            this.tNumPlazas.Location = new System.Drawing.Point(182, 184);
            this.tNumPlazas.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tNumPlazas.Name = "tNumPlazas";
            this.tNumPlazas.Size = new System.Drawing.Size(43, 20);
            this.tNumPlazas.TabIndex = 18;
            // 
            // tNumHoras
            // 
            this.tNumHoras.Location = new System.Drawing.Point(182, 214);
            this.tNumHoras.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tNumHoras.Name = "tNumHoras";
            this.tNumHoras.Size = new System.Drawing.Size(43, 20);
            this.tNumHoras.TabIndex = 19;
            // 
            // dateTimePickerFechaIni
            // 
            this.dateTimePickerFechaIni.Location = new System.Drawing.Point(182, 248);
            this.dateTimePickerFechaIni.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateTimePickerFechaIni.Name = "dateTimePickerFechaIni";
            this.dateTimePickerFechaIni.Size = new System.Drawing.Size(151, 20);
            this.dateTimePickerFechaIni.TabIndex = 20;
            // 
            // dateTimePickerFechaFin
            // 
            this.dateTimePickerFechaFin.Location = new System.Drawing.Point(182, 280);
            this.dateTimePickerFechaFin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateTimePickerFechaFin.Name = "dateTimePickerFechaFin";
            this.dateTimePickerFechaFin.Size = new System.Drawing.Size(151, 20);
            this.dateTimePickerFechaFin.TabIndex = 21;
            // 
            // tLugar
            // 
            this.tLugar.Location = new System.Drawing.Point(185, 316);
            this.tLugar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tLugar.Name = "tLugar";
            this.tLugar.Size = new System.Drawing.Size(148, 20);
            this.tLugar.TabIndex = 22;
            // 
            // tURL
            // 
            this.tURL.Enabled = false;
            this.tURL.Location = new System.Drawing.Point(326, 349);
            this.tURL.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tURL.Name = "tURL";
            this.tURL.Size = new System.Drawing.Size(87, 20);
            this.tURL.TabIndex = 23;
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.BackColor = System.Drawing.Color.Transparent;
            this.labelError.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelError.ForeColor = System.Drawing.Color.Red;
            this.labelError.Location = new System.Drawing.Point(36, 468);
            this.labelError.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(33, 13);
            this.labelError.TabIndex = 27;
            this.labelError.Text = "error";
            // 
            // ambitoTrabajoEBindingSource
            // 
            this.ambitoTrabajoEBindingSource.DataSource = typeof(APS.Mapeo.Actividad.AmbitoTrabajoE);
            // 
            // tipoTrabajoEBindingSource
            // 
            this.tipoTrabajoEBindingSource.DataSource = typeof(APS.Mapeo.Actividad.TipoTrabajoE);
            // 
            // btnExaminar
            // 
            this.btnExaminar.Location = new System.Drawing.Point(417, 349);
            this.btnExaminar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnExaminar.Name = "btnExaminar";
            this.btnExaminar.Size = new System.Drawing.Size(56, 19);
            this.btnExaminar.TabIndex = 28;
            this.btnExaminar.Text = "Examinar";
            this.btnExaminar.UseVisualStyleBackColor = true;
            this.btnExaminar.Click += new System.EventHandler(this.btnExaminar_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(328, 384);
            this.pictureBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(102, 48);
            this.pictureBox.TabIndex = 29;
            this.pictureBox.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // actividadBindingSource
            // 
            this.actividadBindingSource.DataSource = typeof(APS.Mapeo.Actividad);
            // 
            // listTurno
            // 
            this.listTurno.FormattingEnabled = true;
            this.listTurno.Location = new System.Drawing.Point(182, 349);
            this.listTurno.Name = "listTurno";
            this.listTurno.Size = new System.Drawing.Size(91, 21);
            this.listTurno.TabIndex = 30;
            // 
            // listAmbito
            // 
            this.listAmbito.FormattingEnabled = true;
            this.listAmbito.Location = new System.Drawing.Point(182, 381);
            this.listAmbito.Name = "listAmbito";
            this.listAmbito.Size = new System.Drawing.Size(104, 21);
            this.listAmbito.TabIndex = 31;
            // 
            // listTrabajo
            // 
            this.listTrabajo.FormattingEnabled = true;
            this.listTrabajo.Location = new System.Drawing.Point(182, 410);
            this.listTrabajo.Name = "listTrabajo";
            this.listTrabajo.Size = new System.Drawing.Size(104, 21);
            this.listTrabajo.TabIndex = 32;
            // 
            // NuevaActividad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 511);
            this.Controls.Add(this.listTrabajo);
            this.Controls.Add(this.listAmbito);
            this.Controls.Add(this.listTurno);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.btnExaminar);
            this.Controls.Add(this.labelError);
            this.Controls.Add(this.tURL);
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "NuevaActividad";
            this.Text = "Nueva Actividad";
            ((System.ComponentModel.ISupportInitialize)(this.ambitoTrabajoEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoTrabajoEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.actividadBindingSource)).EndInit();
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
        private System.Windows.Forms.TextBox tURL;
        private System.Windows.Forms.Label labelError;
        private System.Windows.Forms.BindingSource ambitoTrabajoEBindingSource;
        private System.Windows.Forms.BindingSource tipoTrabajoEBindingSource;
        private System.Windows.Forms.BindingSource actividadBindingSource;
        private System.Windows.Forms.Button btnExaminar;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ComboBox listTurno;
        private System.Windows.Forms.ComboBox listAmbito;
        private System.Windows.Forms.ComboBox listTrabajo;
    }
}