namespace APS.Interfaces
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
            this.SuspendLayout();
            // 
            // listCompetencias
            // 
            this.listCompetencias.FormattingEnabled = true;
            this.listCompetencias.Location = new System.Drawing.Point(110, 238);
            this.listCompetencias.Name = "listCompetencias";
            this.listCompetencias.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listCompetencias.Size = new System.Drawing.Size(356, 121);
            this.listCompetencias.TabIndex = 46;
            // 
            // lNombrePref
            // 
            this.lNombrePref.AutoSize = true;
            this.lNombrePref.Font = new System.Drawing.Font("Calibri Light", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lNombrePref.Location = new System.Drawing.Point(29, 29);
            this.lNombrePref.Name = "lNombrePref";
            this.lNombrePref.Size = new System.Drawing.Size(108, 14);
            this.lNombrePref.TabIndex = 40;
            this.lNombrePref.Text = "Nombre Preferencia:";
            // 
            // lAsig
            // 
            this.lAsig.AutoSize = true;
            this.lAsig.Font = new System.Drawing.Font("Calibri Light", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lAsig.Location = new System.Drawing.Point(29, 143);
            this.lAsig.Name = "lAsig";
            this.lAsig.Size = new System.Drawing.Size(63, 14);
            this.lAsig.TabIndex = 39;
            this.lAsig.Text = "Asignatura:";
            // 
            // lHoras
            // 
            this.lHoras.AutoSize = true;
            this.lHoras.Font = new System.Drawing.Font("Calibri Light", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lHoras.Location = new System.Drawing.Point(322, 163);
            this.lHoras.Name = "lHoras";
            this.lHoras.Size = new System.Drawing.Size(95, 14);
            this.lHoras.TabIndex = 38;
            this.lHoras.Text = "Número de Horas:";
            // 
            // lGrado
            // 
            this.lGrado.AutoSize = true;
            this.lGrado.Font = new System.Drawing.Font("Calibri Light", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lGrado.Location = new System.Drawing.Point(29, 84);
            this.lGrado.Name = "lGrado";
            this.lGrado.Size = new System.Drawing.Size(40, 14);
            this.lGrado.TabIndex = 37;
            this.lGrado.Text = "Grado:";
            // 
            // lTurno
            // 
            this.lTurno.AutoSize = true;
            this.lTurno.Font = new System.Drawing.Font("Calibri Light", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTurno.Location = new System.Drawing.Point(356, 84);
            this.lTurno.Name = "lTurno";
            this.lTurno.Size = new System.Drawing.Size(37, 14);
            this.lTurno.TabIndex = 36;
            this.lTurno.Text = "Turno:";
            // 
            // lTipo
            // 
            this.lTipo.AutoSize = true;
            this.lTipo.Font = new System.Drawing.Font("Calibri Light", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTipo.Location = new System.Drawing.Point(322, 121);
            this.lTipo.Name = "lTipo";
            this.lTipo.Size = new System.Drawing.Size(94, 14);
            this.lTipo.TabIndex = 35;
            this.lTipo.Text = "Tipo de Actividad:";
            // 
            // lComp
            // 
            this.lComp.AutoSize = true;
            this.lComp.Font = new System.Drawing.Font("Calibri Light", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lComp.Location = new System.Drawing.Point(29, 208);
            this.lComp.Name = "lComp";
            this.lComp.Size = new System.Drawing.Size(78, 14);
            this.lComp.TabIndex = 34;
            this.lComp.Text = "Competencias:";
            // 
            // bConfirmar
            // 
            this.bConfirmar.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bConfirmar.Location = new System.Drawing.Point(218, 386);
            this.bConfirmar.Name = "bConfirmar";
            this.bConfirmar.Size = new System.Drawing.Size(125, 23);
            this.bConfirmar.TabIndex = 32;
            this.bConfirmar.Text = "Confirmar";
            this.bConfirmar.UseVisualStyleBackColor = true;
            this.bConfirmar.Click += new System.EventHandler(this.bConfirmar_Click);
            // 
            // lShowNoun
            // 
            this.lShowNoun.AutoSize = true;
            this.lShowNoun.Font = new System.Drawing.Font("Calibri Light", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lShowNoun.Location = new System.Drawing.Point(143, 29);
            this.lShowNoun.Name = "lShowNoun";
            this.lShowNoun.Size = new System.Drawing.Size(0, 14);
            this.lShowNoun.TabIndex = 47;
            // 
            // lShowHoras
            // 
            this.lShowHoras.AutoSize = true;
            this.lShowHoras.Font = new System.Drawing.Font("Calibri Light", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lShowHoras.Location = new System.Drawing.Point(423, 163);
            this.lShowHoras.Name = "lShowHoras";
            this.lShowHoras.Size = new System.Drawing.Size(0, 14);
            this.lShowHoras.TabIndex = 48;
            // 
            // lShowTipo
            // 
            this.lShowTipo.AutoSize = true;
            this.lShowTipo.Font = new System.Drawing.Font("Calibri Light", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lShowTipo.Location = new System.Drawing.Point(422, 121);
            this.lShowTipo.Name = "lShowTipo";
            this.lShowTipo.Size = new System.Drawing.Size(0, 14);
            this.lShowTipo.TabIndex = 49;
            // 
            // lShowTurno
            // 
            this.lShowTurno.AutoSize = true;
            this.lShowTurno.Font = new System.Drawing.Font("Calibri Light", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lShowTurno.Location = new System.Drawing.Point(410, 84);
            this.lShowTurno.Name = "lShowTurno";
            this.lShowTurno.Size = new System.Drawing.Size(0, 14);
            this.lShowTurno.TabIndex = 50;
            // 
            // lShowPreferencia
            // 
            this.lShowPreferencia.AutoSize = true;
            this.lShowPreferencia.Font = new System.Drawing.Font("Calibri Light", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lShowPreferencia.Location = new System.Drawing.Point(107, 143);
            this.lShowPreferencia.Name = "lShowPreferencia";
            this.lShowPreferencia.Size = new System.Drawing.Size(0, 14);
            this.lShowPreferencia.TabIndex = 51;
            // 
            // lShowGrado
            // 
            this.lShowGrado.AutoSize = true;
            this.lShowGrado.Font = new System.Drawing.Font("Calibri Light", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lShowGrado.Location = new System.Drawing.Point(75, 84);
            this.lShowGrado.Name = "lShowGrado";
            this.lShowGrado.Size = new System.Drawing.Size(0, 14);
            this.lShowGrado.TabIndex = 52;
            // 
            // VerPreferencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 450);
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
            this.Name = "VerPreferencia";
            this.Text = "Añadir Preferencias";
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
    }
}