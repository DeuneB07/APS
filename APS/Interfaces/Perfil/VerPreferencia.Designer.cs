﻿namespace APS.Interfaces
{
    partial class VerPreferencia
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
            this.listCompetencias = new System.Windows.Forms.ListBox();
            this.lNombrePref = new System.Windows.Forms.Label();
            this.lAsig = new System.Windows.Forms.Label();
            this.lHoras = new System.Windows.Forms.Label();
            this.lGrado = new System.Windows.Forms.Label();
            this.lTurno = new System.Windows.Forms.Label();
            this.lTipo = new System.Windows.Forms.Label();
            this.lComp = new System.Windows.Forms.Label();
            this.bConfirmar = new System.Windows.Forms.Button();
            this.lShowNoun = new System.Windows.Forms.Label();
            this.lShowHoras = new System.Windows.Forms.Label();
            this.lShowTipo = new System.Windows.Forms.Label();
            this.lShowTurno = new System.Windows.Forms.Label();
            this.lShowPreferencia = new System.Windows.Forms.Label();
            this.lShowGrado = new System.Windows.Forms.Label();
            this.lAmbTrab = new System.Windows.Forms.Label();
            this.lTipoTrab = new System.Windows.Forms.Label();
            this.lAmbTrab2 = new System.Windows.Forms.Label();
            this.lTipoTrab2 = new System.Windows.Forms.Label();
            this.bModificar = new System.Windows.Forms.Button();
            this.cModiGrado = new System.Windows.Forms.ComboBox();
            this.cModiAsig = new System.Windows.Forms.ComboBox();
            this.cModiTurno = new System.Windows.Forms.ComboBox();
            this.cModAmb = new System.Windows.Forms.ComboBox();
            this.cModiTipoTrab = new System.Windows.Forms.ComboBox();
            this.cModiHoras = new System.Windows.Forms.ComboBox();
            this.cModiTipoAct = new System.Windows.Forms.ComboBox();
            this.tModiNombre = new System.Windows.Forms.TextBox();
            this.bModiConf = new System.Windows.Forms.Button();
            this.bModiCancelar = new System.Windows.Forms.Button();
            this.listModiCompetencias = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // listCompetencias
            // 
            this.listCompetencias.FormattingEnabled = true;
            this.listCompetencias.ItemHeight = 16;
            this.listCompetencias.Location = new System.Drawing.Point(147, 354);
            this.listCompetencias.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listCompetencias.Name = "listCompetencias";
            this.listCompetencias.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listCompetencias.Size = new System.Drawing.Size(473, 148);
            this.listCompetencias.TabIndex = 46;
            // 
            // lNombrePref
            // 
            this.lNombrePref.AutoSize = true;
            this.lNombrePref.Font = new System.Drawing.Font("Calibri Light", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lNombrePref.Location = new System.Drawing.Point(39, 36);
            this.lNombrePref.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lNombrePref.Name = "lNombrePref";
            this.lNombrePref.Size = new System.Drawing.Size(133, 18);
            this.lNombrePref.TabIndex = 40;
            this.lNombrePref.Text = "Nombre Preferencia:";
            // 
            // lAsig
            // 
            this.lAsig.AutoSize = true;
            this.lAsig.Font = new System.Drawing.Font("Calibri Light", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lAsig.Location = new System.Drawing.Point(39, 176);
            this.lAsig.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lAsig.Name = "lAsig";
            this.lAsig.Size = new System.Drawing.Size(79, 18);
            this.lAsig.TabIndex = 39;
            this.lAsig.Text = "Asignatura:";
            // 
            // lHoras
            // 
            this.lHoras.AutoSize = true;
            this.lHoras.Font = new System.Drawing.Font("Calibri Light", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lHoras.Location = new System.Drawing.Point(429, 201);
            this.lHoras.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lHoras.Name = "lHoras";
            this.lHoras.Size = new System.Drawing.Size(119, 18);
            this.lHoras.TabIndex = 38;
            this.lHoras.Text = "Número de Horas:";
            // 
            // lGrado
            // 
            this.lGrado.AutoSize = true;
            this.lGrado.Font = new System.Drawing.Font("Calibri Light", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lGrado.Location = new System.Drawing.Point(39, 103);
            this.lGrado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lGrado.Name = "lGrado";
            this.lGrado.Size = new System.Drawing.Size(50, 18);
            this.lGrado.TabIndex = 37;
            this.lGrado.Text = "Grado:";
            // 
            // lTurno
            // 
            this.lTurno.AutoSize = true;
            this.lTurno.Font = new System.Drawing.Font("Calibri Light", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTurno.Location = new System.Drawing.Point(475, 103);
            this.lTurno.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lTurno.Name = "lTurno";
            this.lTurno.Size = new System.Drawing.Size(47, 18);
            this.lTurno.TabIndex = 36;
            this.lTurno.Text = "Turno:";
            // 
            // lTipo
            // 
            this.lTipo.AutoSize = true;
            this.lTipo.Font = new System.Drawing.Font("Calibri Light", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTipo.Location = new System.Drawing.Point(429, 149);
            this.lTipo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lTipo.Name = "lTipo";
            this.lTipo.Size = new System.Drawing.Size(114, 18);
            this.lTipo.TabIndex = 35;
            this.lTipo.Text = "Tipo de Actividad:";
            // 
            // lComp
            // 
            this.lComp.AutoSize = true;
            this.lComp.Font = new System.Drawing.Font("Calibri Light", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lComp.Location = new System.Drawing.Point(39, 319);
            this.lComp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lComp.Name = "lComp";
            this.lComp.Size = new System.Drawing.Size(98, 18);
            this.lComp.TabIndex = 34;
            this.lComp.Text = "Competencias:";
            // 
            // bConfirmar
            // 
            this.bConfirmar.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bConfirmar.Location = new System.Drawing.Point(455, 511);
            this.bConfirmar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bConfirmar.Name = "bConfirmar";
            this.bConfirmar.Size = new System.Drawing.Size(167, 28);
            this.bConfirmar.TabIndex = 32;
            this.bConfirmar.Text = "Confirmar";
            this.bConfirmar.UseVisualStyleBackColor = true;
            this.bConfirmar.Click += new System.EventHandler(this.bConfirmar_Click);
            // 
            // lShowNoun
            // 
            this.lShowNoun.AutoSize = true;
            this.lShowNoun.Font = new System.Drawing.Font("Calibri Light", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lShowNoun.Location = new System.Drawing.Point(191, 36);
            this.lShowNoun.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lShowNoun.Name = "lShowNoun";
            this.lShowNoun.Size = new System.Drawing.Size(0, 18);
            this.lShowNoun.TabIndex = 47;
            // 
            // lShowHoras
            // 
            this.lShowHoras.AutoSize = true;
            this.lShowHoras.Font = new System.Drawing.Font("Calibri Light", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lShowHoras.Location = new System.Drawing.Point(564, 201);
            this.lShowHoras.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lShowHoras.Name = "lShowHoras";
            this.lShowHoras.Size = new System.Drawing.Size(0, 18);
            this.lShowHoras.TabIndex = 48;
            // 
            // lShowTipo
            // 
            this.lShowTipo.AutoSize = true;
            this.lShowTipo.Font = new System.Drawing.Font("Calibri Light", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lShowTipo.Location = new System.Drawing.Point(563, 149);
            this.lShowTipo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lShowTipo.Name = "lShowTipo";
            this.lShowTipo.Size = new System.Drawing.Size(0, 18);
            this.lShowTipo.TabIndex = 49;
            // 
            // lShowTurno
            // 
            this.lShowTurno.AutoSize = true;
            this.lShowTurno.Font = new System.Drawing.Font("Calibri Light", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lShowTurno.Location = new System.Drawing.Point(547, 103);
            this.lShowTurno.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lShowTurno.Name = "lShowTurno";
            this.lShowTurno.Size = new System.Drawing.Size(0, 18);
            this.lShowTurno.TabIndex = 50;
            // 
            // lShowPreferencia
            // 
            this.lShowPreferencia.AutoSize = true;
            this.lShowPreferencia.Font = new System.Drawing.Font("Calibri Light", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lShowPreferencia.Location = new System.Drawing.Point(143, 176);
            this.lShowPreferencia.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lShowPreferencia.Name = "lShowPreferencia";
            this.lShowPreferencia.Size = new System.Drawing.Size(0, 18);
            this.lShowPreferencia.TabIndex = 51;
            // 
            // lShowGrado
            // 
            this.lShowGrado.AutoSize = true;
            this.lShowGrado.Font = new System.Drawing.Font("Calibri Light", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lShowGrado.Location = new System.Drawing.Point(100, 103);
            this.lShowGrado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lShowGrado.Name = "lShowGrado";
            this.lShowGrado.Size = new System.Drawing.Size(0, 18);
            this.lShowGrado.TabIndex = 52;
            // 
            // lAmbTrab
            // 
            this.lAmbTrab.AutoSize = true;
            this.lAmbTrab.Font = new System.Drawing.Font("Calibri Light", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lAmbTrab.Location = new System.Drawing.Point(423, 294);
            this.lAmbTrab.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lAmbTrab.Name = "lAmbTrab";
            this.lAmbTrab.Size = new System.Drawing.Size(123, 18);
            this.lAmbTrab.TabIndex = 53;
            this.lAmbTrab.Text = "Ámbito de Trabajo:";
            // 
            // lTipoTrab
            // 
            this.lTipoTrab.AutoSize = true;
            this.lTipoTrab.Font = new System.Drawing.Font("Calibri Light", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTipoTrab.Location = new System.Drawing.Point(433, 247);
            this.lTipoTrab.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lTipoTrab.Name = "lTipoTrab";
            this.lTipoTrab.Size = new System.Drawing.Size(105, 18);
            this.lTipoTrab.TabIndex = 54;
            this.lTipoTrab.Text = "Tipo de Trabajo:";
            // 
            // lAmbTrab2
            // 
            this.lAmbTrab2.AutoSize = true;
            this.lAmbTrab2.Font = new System.Drawing.Font("Calibri Light", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lAmbTrab2.Location = new System.Drawing.Point(563, 294);
            this.lAmbTrab2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lAmbTrab2.Name = "lAmbTrab2";
            this.lAmbTrab2.Size = new System.Drawing.Size(0, 18);
            this.lAmbTrab2.TabIndex = 55;
            // 
            // lTipoTrab2
            // 
            this.lTipoTrab2.AutoSize = true;
            this.lTipoTrab2.Font = new System.Drawing.Font("Calibri Light", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTipoTrab2.Location = new System.Drawing.Point(564, 247);
            this.lTipoTrab2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lTipoTrab2.Name = "lTipoTrab2";
            this.lTipoTrab2.Size = new System.Drawing.Size(0, 18);
            this.lTipoTrab2.TabIndex = 56;
            // 
            // bModificar
            // 
            this.bModificar.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bModificar.Location = new System.Drawing.Point(147, 511);
            this.bModificar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bModificar.Name = "bModificar";
            this.bModificar.Size = new System.Drawing.Size(167, 28);
            this.bModificar.TabIndex = 57;
            this.bModificar.Text = "Modificar";
            this.bModificar.UseVisualStyleBackColor = true;
            this.bModificar.Click += new System.EventHandler(this.bModificar_Click);
            // 
            // cModiGrado
            // 
            this.cModiGrado.FormattingEnabled = true;
            this.cModiGrado.Location = new System.Drawing.Point(67, 124);
            this.cModiGrado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cModiGrado.Name = "cModiGrado";
            this.cModiGrado.Size = new System.Drawing.Size(300, 24);
            this.cModiGrado.TabIndex = 58;
            this.cModiGrado.SelectedIndexChanged += new System.EventHandler(this.cModiGrado_SelectedIndexChanged);
            // 
            // cModiAsig
            // 
            this.cModiAsig.FormattingEnabled = true;
            this.cModiAsig.Location = new System.Drawing.Point(67, 201);
            this.cModiAsig.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cModiAsig.Name = "cModiAsig";
            this.cModiAsig.Size = new System.Drawing.Size(300, 24);
            this.cModiAsig.TabIndex = 59;
            // 
            // cModiTurno
            // 
            this.cModiTurno.FormattingEnabled = true;
            this.cModiTurno.Location = new System.Drawing.Point(567, 103);
            this.cModiTurno.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cModiTurno.Name = "cModiTurno";
            this.cModiTurno.Size = new System.Drawing.Size(133, 24);
            this.cModiTurno.TabIndex = 60;
            // 
            // cModAmb
            // 
            this.cModAmb.FormattingEnabled = true;
            this.cModAmb.Location = new System.Drawing.Point(567, 294);
            this.cModAmb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cModAmb.Name = "cModAmb";
            this.cModAmb.Size = new System.Drawing.Size(133, 24);
            this.cModAmb.TabIndex = 61;
            // 
            // cModiTipoTrab
            // 
            this.cModiTipoTrab.FormattingEnabled = true;
            this.cModiTipoTrab.Location = new System.Drawing.Point(567, 244);
            this.cModiTipoTrab.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cModiTipoTrab.Name = "cModiTipoTrab";
            this.cModiTipoTrab.Size = new System.Drawing.Size(133, 24);
            this.cModiTipoTrab.TabIndex = 62;
            // 
            // cModiHoras
            // 
            this.cModiHoras.FormattingEnabled = true;
            this.cModiHoras.Location = new System.Drawing.Point(567, 192);
            this.cModiHoras.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cModiHoras.Name = "cModiHoras";
            this.cModiHoras.Size = new System.Drawing.Size(133, 24);
            this.cModiHoras.TabIndex = 63;
            // 
            // cModiTipoAct
            // 
            this.cModiTipoAct.FormattingEnabled = true;
            this.cModiTipoAct.Location = new System.Drawing.Point(567, 145);
            this.cModiTipoAct.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cModiTipoAct.Name = "cModiTipoAct";
            this.cModiTipoAct.Size = new System.Drawing.Size(133, 24);
            this.cModiTipoAct.TabIndex = 64;
            // 
            // tModiNombre
            // 
            this.tModiNombre.Location = new System.Drawing.Point(199, 32);
            this.tModiNombre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tModiNombre.Name = "tModiNombre";
            this.tModiNombre.Size = new System.Drawing.Size(501, 22);
            this.tModiNombre.TabIndex = 65;
            // 
            // bModiConf
            // 
            this.bModiConf.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bModiConf.Location = new System.Drawing.Point(147, 511);
            this.bModiConf.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bModiConf.Name = "bModiConf";
            this.bModiConf.Size = new System.Drawing.Size(167, 28);
            this.bModiConf.TabIndex = 66;
            this.bModiConf.Text = "Confirmar";
            this.bModiConf.UseVisualStyleBackColor = true;
            this.bModiConf.Click += new System.EventHandler(this.bModiConf_Click);
            // 
            // bModiCancelar
            // 
            this.bModiCancelar.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bModiCancelar.Location = new System.Drawing.Point(455, 511);
            this.bModiCancelar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bModiCancelar.Name = "bModiCancelar";
            this.bModiCancelar.Size = new System.Drawing.Size(167, 28);
            this.bModiCancelar.TabIndex = 67;
            this.bModiCancelar.Text = "Cancelar";
            this.bModiCancelar.UseVisualStyleBackColor = true;
            this.bModiCancelar.Click += new System.EventHandler(this.bModiCancelar_Click);
            // 
            // listModiCompetencias
            // 
            this.listModiCompetencias.FormattingEnabled = true;
            this.listModiCompetencias.ItemHeight = 16;
            this.listModiCompetencias.Location = new System.Drawing.Point(146, 355);
            this.listModiCompetencias.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listModiCompetencias.Name = "listModiCompetencias";
            this.listModiCompetencias.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listModiCompetencias.Size = new System.Drawing.Size(473, 148);
            this.listModiCompetencias.TabIndex = 68;
            // 
            // VerPreferencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 554);
            this.Controls.Add(this.listModiCompetencias);
            this.Controls.Add(this.bModiCancelar);
            this.Controls.Add(this.bModiConf);
            this.Controls.Add(this.tModiNombre);
            this.Controls.Add(this.cModiTipoAct);
            this.Controls.Add(this.cModiHoras);
            this.Controls.Add(this.cModiTipoTrab);
            this.Controls.Add(this.cModAmb);
            this.Controls.Add(this.cModiTurno);
            this.Controls.Add(this.cModiAsig);
            this.Controls.Add(this.cModiGrado);
            this.Controls.Add(this.bModificar);
            this.Controls.Add(this.lTipoTrab2);
            this.Controls.Add(this.lAmbTrab2);
            this.Controls.Add(this.lTipoTrab);
            this.Controls.Add(this.lAmbTrab);
            this.Controls.Add(this.lShowGrado);
            this.Controls.Add(this.lShowPreferencia);
            this.Controls.Add(this.lShowTurno);
            this.Controls.Add(this.lShowTipo);
            this.Controls.Add(this.lShowHoras);
            this.Controls.Add(this.lShowNoun);
            this.Controls.Add(this.listCompetencias);
            this.Controls.Add(this.lNombrePref);
            this.Controls.Add(this.lAsig);
            this.Controls.Add(this.lHoras);
            this.Controls.Add(this.lGrado);
            this.Controls.Add(this.lTurno);
            this.Controls.Add(this.lTipo);
            this.Controls.Add(this.lComp);
            this.Controls.Add(this.bConfirmar);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "VerPreferencia";
            this.Text = "Ver Preferencia";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox listCompetencias;
        private System.Windows.Forms.Label lNombrePref;
        private System.Windows.Forms.Label lAsig;
        private System.Windows.Forms.Label lHoras;
        private System.Windows.Forms.Label lGrado;
        private System.Windows.Forms.Label lTurno;
        private System.Windows.Forms.Label lTipo;
        private System.Windows.Forms.Label lComp;
        private System.Windows.Forms.Button bConfirmar;
        private System.Windows.Forms.Label lShowNoun;
        private System.Windows.Forms.Label lShowHoras;
        private System.Windows.Forms.Label lShowTipo;
        private System.Windows.Forms.Label lShowTurno;
        private System.Windows.Forms.Label lShowPreferencia;
        private System.Windows.Forms.Label lShowGrado;
        private System.Windows.Forms.Label lAmbTrab;
        private System.Windows.Forms.Label lTipoTrab;
        private System.Windows.Forms.Label lAmbTrab2;
        private System.Windows.Forms.Label lTipoTrab2;
        private System.Windows.Forms.Button bModificar;
        private System.Windows.Forms.ComboBox cModiGrado;
        private System.Windows.Forms.ComboBox cModiAsig;
        private System.Windows.Forms.ComboBox cModiTurno;
        private System.Windows.Forms.ComboBox cModAmb;
        private System.Windows.Forms.ComboBox cModiTipoTrab;
        private System.Windows.Forms.ComboBox cModiHoras;
        private System.Windows.Forms.ComboBox cModiTipoAct;
        private System.Windows.Forms.TextBox tModiNombre;
        private System.Windows.Forms.Button bModiConf;
        private System.Windows.Forms.Button bModiCancelar;
        private System.Windows.Forms.ListBox listModiCompetencias;
    }
}