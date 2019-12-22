using System.Windows.Forms;

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
            this.listTurno = new System.Windows.Forms.ComboBox();
            this.listAmbito = new System.Windows.Forms.ComboBox();
            this.listTrabajo = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // tLugar
            // 
            this.tLugar.Enabled = false;
            this.tLugar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tLugar.Location = new System.Drawing.Point(195, 299);
            this.tLugar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tLugar.Name = "tLugar";
            this.tLugar.Size = new System.Drawing.Size(196, 22);
            this.tLugar.TabIndex = 46;
            // 
            // dateTimePickerFechaFin
            // 
            this.dateTimePickerFechaFin.Enabled = false;
            this.dateTimePickerFechaFin.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerFechaFin.Location = new System.Drawing.Point(509, 250);
            this.dateTimePickerFechaFin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePickerFechaFin.Name = "dateTimePickerFechaFin";
            this.dateTimePickerFechaFin.Size = new System.Drawing.Size(277, 25);
            this.dateTimePickerFechaFin.TabIndex = 45;
            // 
            // dateTimePickerFechaIni
            // 
            this.dateTimePickerFechaIni.Enabled = false;
            this.dateTimePickerFechaIni.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerFechaIni.Location = new System.Drawing.Point(509, 209);
            this.dateTimePickerFechaIni.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePickerFechaIni.Name = "dateTimePickerFechaIni";
            this.dateTimePickerFechaIni.Size = new System.Drawing.Size(277, 25);
            this.dateTimePickerFechaIni.TabIndex = 44;
            // 
            // tNumHoras
            // 
            this.tNumHoras.Enabled = false;
            this.tNumHoras.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tNumHoras.Location = new System.Drawing.Point(191, 247);
            this.tNumHoras.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tNumHoras.Name = "tNumHoras";
            this.tNumHoras.Size = new System.Drawing.Size(56, 22);
            this.tNumHoras.TabIndex = 43;
            // 
            // tNumPlazas
            // 
            this.tNumPlazas.Enabled = false;
            this.tNumPlazas.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tNumPlazas.Location = new System.Drawing.Point(191, 209);
            this.tNumPlazas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tNumPlazas.Name = "tNumPlazas";
            this.tNumPlazas.Size = new System.Drawing.Size(56, 22);
            this.tNumPlazas.TabIndex = 42;
            // 
            // tDescripcion
            // 
            this.tDescripcion.Enabled = false;
            this.tDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tDescripcion.Location = new System.Drawing.Point(191, 103);
            this.tDescripcion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tDescripcion.Name = "tDescripcion";
            this.tDescripcion.Size = new System.Drawing.Size(217, 88);
            this.tDescripcion.TabIndex = 41;
            this.tDescripcion.Text = "";
            // 
            // tNombreAct
            // 
            this.tNombreAct.Enabled = false;
            this.tNombreAct.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tNombreAct.Location = new System.Drawing.Point(191, 63);
            this.tNombreAct.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tNombreAct.Name = "tNombreAct";
            this.tNombreAct.Size = new System.Drawing.Size(217, 22);
            this.tNombreAct.TabIndex = 40;
            // 
            // tOrganizador
            // 
            this.tOrganizador.Enabled = false;
            this.tOrganizador.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tOrganizador.Location = new System.Drawing.Point(191, 18);
            this.tOrganizador.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tOrganizador.Name = "tOrganizador";
            this.tOrganizador.Size = new System.Drawing.Size(217, 22);
            this.tOrganizador.TabIndex = 39;
            // 
            // labelTipo
            // 
            this.labelTipo.AutoSize = true;
            this.labelTipo.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTipo.Location = new System.Drawing.Point(475, 347);
            this.labelTipo.Name = "labelTipo";
            this.labelTipo.Size = new System.Drawing.Size(97, 18);
            this.labelTipo.TabIndex = 38;
            this.labelTipo.Text = "Tipo Trabajo:";
            // 
            // labelAmbito
            // 
            this.labelAmbito.AutoSize = true;
            this.labelAmbito.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAmbito.Location = new System.Drawing.Point(453, 299);
            this.labelAmbito.Name = "labelAmbito";
            this.labelAmbito.Size = new System.Drawing.Size(117, 18);
            this.labelAmbito.TabIndex = 37;
            this.labelAmbito.Text = "Ambito Trabajo:";
            // 
            // labelTurno
            // 
            this.labelTurno.AutoSize = true;
            this.labelTurno.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTurno.Location = new System.Drawing.Point(100, 367);
            this.labelTurno.Name = "labelTurno";
            this.labelTurno.Size = new System.Drawing.Size(54, 18);
            this.labelTurno.TabIndex = 35;
            this.labelTurno.Text = "Turno:";
            // 
            // labelLugar
            // 
            this.labelLugar.AutoSize = true;
            this.labelLugar.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLugar.Location = new System.Drawing.Point(115, 299);
            this.labelLugar.Name = "labelLugar";
            this.labelLugar.Size = new System.Drawing.Size(53, 18);
            this.labelLugar.TabIndex = 34;
            this.labelLugar.Text = "Lugar:";
            // 
            // labelFechaFin
            // 
            this.labelFechaFin.AutoSize = true;
            this.labelFechaFin.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFechaFin.Location = new System.Drawing.Point(411, 250);
            this.labelFechaFin.Name = "labelFechaFin";
            this.labelFechaFin.Size = new System.Drawing.Size(79, 18);
            this.labelFechaFin.TabIndex = 33;
            this.labelFechaFin.Text = "Fecha Fin:";
            // 
            // labelFechaInicio
            // 
            this.labelFechaInicio.AutoSize = true;
            this.labelFechaInicio.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFechaInicio.Location = new System.Drawing.Point(395, 212);
            this.labelFechaInicio.Name = "labelFechaInicio";
            this.labelFechaInicio.Size = new System.Drawing.Size(96, 18);
            this.labelFechaInicio.TabIndex = 32;
            this.labelFechaInicio.Text = "Fecha Inicio:";
            // 
            // labelNumHoras
            // 
            this.labelNumHoras.AutoSize = true;
            this.labelNumHoras.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumHoras.Location = new System.Drawing.Point(59, 247);
            this.labelNumHoras.Name = "labelNumHoras";
            this.labelNumHoras.Size = new System.Drawing.Size(113, 18);
            this.labelNumHoras.TabIndex = 31;
            this.labelNumHoras.Text = "Número Horas:";
            // 
            // labelNumPlazas
            // 
            this.labelNumPlazas.AutoSize = true;
            this.labelNumPlazas.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumPlazas.Location = new System.Drawing.Point(55, 209);
            this.labelNumPlazas.Name = "labelNumPlazas";
            this.labelNumPlazas.Size = new System.Drawing.Size(115, 18);
            this.labelNumPlazas.TabIndex = 30;
            this.labelNumPlazas.Text = "Número Plazas:";
            // 
            // labelDescripcion
            // 
            this.labelDescripcion.AutoSize = true;
            this.labelDescripcion.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescripcion.Location = new System.Drawing.Point(16, 103);
            this.labelDescripcion.Name = "labelDescripcion";
            this.labelDescripcion.Size = new System.Drawing.Size(156, 18);
            this.labelDescripcion.TabIndex = 29;
            this.labelDescripcion.Text = "Descripción Actividad:";
            // 
            // labelNombreAct
            // 
            this.labelNombreAct.AutoSize = true;
            this.labelNombreAct.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombreAct.Location = new System.Drawing.Point(40, 63);
            this.labelNombreAct.Name = "labelNombreAct";
            this.labelNombreAct.Size = new System.Drawing.Size(134, 18);
            this.labelNombreAct.TabIndex = 28;
            this.labelNombreAct.Text = "Nombre Actividad:";
            // 
            // labelOrganizador
            // 
            this.labelOrganizador.AutoSize = true;
            this.labelOrganizador.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOrganizador.Location = new System.Drawing.Point(72, 18);
            this.labelOrganizador.Name = "labelOrganizador";
            this.labelOrganizador.Size = new System.Drawing.Size(97, 18);
            this.labelOrganizador.TabIndex = 27;
            this.labelOrganizador.Text = "Organizador:";
            // 
            // btnGestionar
            // 
            this.btnGestionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestionar.Location = new System.Drawing.Point(443, 412);
            this.btnGestionar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGestionar.Name = "btnGestionar";
            this.btnGestionar.Size = new System.Drawing.Size(101, 31);
            this.btnGestionar.TabIndex = 51;
            this.btnGestionar.Text = "Gestionar";
            this.btnGestionar.UseVisualStyleBackColor = true;
            this.btnGestionar.Click += new System.EventHandler(this.btnGestionar_Click);
            // 
            // btnRechazar
            // 
            this.btnRechazar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRechazar.Location = new System.Drawing.Point(576, 412);
            this.btnRechazar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRechazar.Name = "btnRechazar";
            this.btnRechazar.Size = new System.Drawing.Size(101, 31);
            this.btnRechazar.TabIndex = 52;
            this.btnRechazar.Text = "Rechazar";
            this.btnRechazar.UseVisualStyleBackColor = true;
            this.btnRechazar.Click += new System.EventHandler(this.btnRechazar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(707, 412);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(91, 31);
            this.btnCancelar.TabIndex = 53;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox.Image")));
            this.pictureBox.Location = new System.Drawing.Point(491, 18);
            this.pictureBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(267, 158);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 55;
            this.pictureBox.TabStop = false;
            // 
            // listTurno
            // 
            this.listTurno.Enabled = false;
            this.listTurno.FormattingEnabled = true;
            this.listTurno.Location = new System.Drawing.Point(191, 364);
            this.listTurno.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listTurno.Name = "listTurno";
            this.listTurno.Size = new System.Drawing.Size(160, 24);
            this.listTurno.TabIndex = 56;
            // 
            // listAmbito
            // 
            this.listAmbito.Enabled = false;
            this.listAmbito.FormattingEnabled = true;
            this.listAmbito.Location = new System.Drawing.Point(619, 297);
            this.listAmbito.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listAmbito.Name = "listAmbito";
            this.listAmbito.Size = new System.Drawing.Size(160, 24);
            this.listAmbito.TabIndex = 57;
            // 
            // listTrabajo
            // 
            this.listTrabajo.Enabled = false;
            this.listTrabajo.FormattingEnabled = true;
            this.listTrabajo.Location = new System.Drawing.Point(619, 345);
            this.listTrabajo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listTrabajo.Name = "listTrabajo";
            this.listTrabajo.Size = new System.Drawing.Size(160, 24);
            this.listTrabajo.TabIndex = 58;
            // 
            // VerActividadGestor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(881, 473);
            this.Controls.Add(this.listTrabajo);
            this.Controls.Add(this.listAmbito);
            this.Controls.Add(this.listTurno);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnRechazar);
            this.Controls.Add(this.btnGestionar);
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
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "VerActividadGestor";
            this.Text = "Ver Actividad";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
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
        private ComboBox listTurno;
        private ComboBox listAmbito;
        private ComboBox listTrabajo;
    }
}