namespace APS.Interfaces
{
    partial class FAnadirPreferencias
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
            this.bConfirmar = new System.Windows.Forms.Button();
            this.bCancelar = new System.Windows.Forms.Button();
            this.lComp = new System.Windows.Forms.Label();
            this.lTipo = new System.Windows.Forms.Label();
            this.lTurno = new System.Windows.Forms.Label();
            this.lGrado = new System.Windows.Forms.Label();
            this.lHoras = new System.Windows.Forms.Label();
            this.lAsig = new System.Windows.Forms.Label();
            this.lNombrePref = new System.Windows.Forms.Label();
            this.comboGrado = new System.Windows.Forms.ComboBox();
            this.gradosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.wePassDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.wePassDataSet = new APS.WePassDataSet();
            this.comboAsig = new System.Windows.Forms.ComboBox();
            this.comboTurno = new System.Windows.Forms.ComboBox();
            this.comboTipo = new System.Windows.Forms.ComboBox();
            this.comboHoras = new System.Windows.Forms.ComboBox();
            this.listCompetencias = new System.Windows.Forms.ListBox();
            this.textNombreComp = new System.Windows.Forms.TextBox();
            this.gradosTableAdapter = new APS.WePassDataSetTableAdapters.GradosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.gradosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wePassDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wePassDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // bConfirmar
            // 
            this.bConfirmar.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bConfirmar.Location = new System.Drawing.Point(117, 395);
            this.bConfirmar.Name = "bConfirmar";
            this.bConfirmar.Size = new System.Drawing.Size(125, 23);
            this.bConfirmar.TabIndex = 16;
            this.bConfirmar.Text = "Confirmar";
            this.bConfirmar.UseVisualStyleBackColor = true;
            this.bConfirmar.Click += new System.EventHandler(this.bConfirmar_Click);
            // 
            // bCancelar
            // 
            this.bCancelar.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bCancelar.Location = new System.Drawing.Point(348, 395);
            this.bCancelar.Name = "bCancelar";
            this.bCancelar.Size = new System.Drawing.Size(125, 23);
            this.bCancelar.TabIndex = 17;
            this.bCancelar.Text = "Cancelar";
            this.bCancelar.UseVisualStyleBackColor = true;
            this.bCancelar.Click += new System.EventHandler(this.bCancelar_Click);
            // 
            // lComp
            // 
            this.lComp.AutoSize = true;
            this.lComp.Font = new System.Drawing.Font("Calibri Light", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lComp.Location = new System.Drawing.Point(36, 215);
            this.lComp.Name = "lComp";
            this.lComp.Size = new System.Drawing.Size(78, 14);
            this.lComp.TabIndex = 18;
            this.lComp.Text = "Competencias:";
            // 
            // lTipo
            // 
            this.lTipo.AutoSize = true;
            this.lTipo.Font = new System.Drawing.Font("Calibri Light", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTipo.Location = new System.Drawing.Point(329, 128);
            this.lTipo.Name = "lTipo";
            this.lTipo.Size = new System.Drawing.Size(94, 14);
            this.lTipo.TabIndex = 19;
            this.lTipo.Text = "Tipo de Actividad:";
            // 
            // lTurno
            // 
            this.lTurno.AutoSize = true;
            this.lTurno.Font = new System.Drawing.Font("Calibri Light", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTurno.Location = new System.Drawing.Point(363, 91);
            this.lTurno.Name = "lTurno";
            this.lTurno.Size = new System.Drawing.Size(37, 14);
            this.lTurno.TabIndex = 20;
            this.lTurno.Text = "Turno:";
            // 
            // lGrado
            // 
            this.lGrado.AutoSize = true;
            this.lGrado.Font = new System.Drawing.Font("Calibri Light", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lGrado.Location = new System.Drawing.Point(36, 91);
            this.lGrado.Name = "lGrado";
            this.lGrado.Size = new System.Drawing.Size(40, 14);
            this.lGrado.TabIndex = 21;
            this.lGrado.Text = "Grado:";
            // 
            // lHoras
            // 
            this.lHoras.AutoSize = true;
            this.lHoras.Font = new System.Drawing.Font("Calibri Light", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lHoras.Location = new System.Drawing.Point(329, 170);
            this.lHoras.Name = "lHoras";
            this.lHoras.Size = new System.Drawing.Size(95, 14);
            this.lHoras.TabIndex = 22;
            this.lHoras.Text = "Número de Horas:";
            // 
            // lAsig
            // 
            this.lAsig.AutoSize = true;
            this.lAsig.Font = new System.Drawing.Font("Calibri Light", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lAsig.Location = new System.Drawing.Point(36, 150);
            this.lAsig.Name = "lAsig";
            this.lAsig.Size = new System.Drawing.Size(63, 14);
            this.lAsig.TabIndex = 23;
            this.lAsig.Text = "Asignatura:";
            // 
            // lNombrePref
            // 
            this.lNombrePref.AutoSize = true;
            this.lNombrePref.Font = new System.Drawing.Font("Calibri Light", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lNombrePref.Location = new System.Drawing.Point(36, 36);
            this.lNombrePref.Name = "lNombrePref";
            this.lNombrePref.Size = new System.Drawing.Size(108, 14);
            this.lNombrePref.TabIndex = 24;
            this.lNombrePref.Text = "Nombre Preferencia:";
            // 
            // comboGrado
            // 
            this.comboGrado.FormattingEnabled = true;
            this.comboGrado.Location = new System.Drawing.Point(57, 108);
            this.comboGrado.Name = "comboGrado";
            this.comboGrado.Size = new System.Drawing.Size(193, 21);
            this.comboGrado.TabIndex = 25;
            this.comboGrado.SelectedIndexChanged += new System.EventHandler(this.comboGrado_SelectedIndexChanged);
            // 
            // gradosBindingSource
            // 
            this.gradosBindingSource.DataMember = "Grados";
            this.gradosBindingSource.DataSource = this.wePassDataSetBindingSource;
            // 
            // wePassDataSetBindingSource
            // 
            this.wePassDataSetBindingSource.DataSource = this.wePassDataSet;
            this.wePassDataSetBindingSource.Position = 0;
            // 
            // wePassDataSet
            // 
            this.wePassDataSet.DataSetName = "WePassDataSet";
            this.wePassDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboAsig
            // 
            this.comboAsig.Location = new System.Drawing.Point(57, 167);
            this.comboAsig.Name = "comboAsig";
            this.comboAsig.Size = new System.Drawing.Size(193, 21);
            this.comboAsig.TabIndex = 26;
            // 
            // comboTurno
            // 
            this.comboTurno.FormattingEnabled = true;
            this.comboTurno.Items.AddRange(new object[] {
            "AM",
            "PM"});
            this.comboTurno.Location = new System.Drawing.Point(429, 84);
            this.comboTurno.Name = "comboTurno";
            this.comboTurno.Size = new System.Drawing.Size(101, 21);
            this.comboTurno.TabIndex = 27;
            // 
            // comboTipo
            // 
            this.comboTipo.FormattingEnabled = true;
            this.comboTipo.Items.AddRange(new object[] {
            "Voluntariado"});
            this.comboTipo.Location = new System.Drawing.Point(429, 125);
            this.comboTipo.Name = "comboTipo";
            this.comboTipo.Size = new System.Drawing.Size(101, 21);
            this.comboTipo.TabIndex = 28;
            // 
            // comboHoras
            // 
            this.comboHoras.FormattingEnabled = true;
            this.comboHoras.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30"});
            this.comboHoras.Location = new System.Drawing.Point(429, 167);
            this.comboHoras.Name = "comboHoras";
            this.comboHoras.Size = new System.Drawing.Size(101, 21);
            this.comboHoras.TabIndex = 29;
            // 
            // listCompetencias
            // 
            this.listCompetencias.FormattingEnabled = true;
            this.listCompetencias.Location = new System.Drawing.Point(117, 245);
            this.listCompetencias.Name = "listCompetencias";
            this.listCompetencias.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listCompetencias.Size = new System.Drawing.Size(356, 121);
            this.listCompetencias.TabIndex = 30;
            // 
            // textNombreComp
            // 
            this.textNombreComp.Location = new System.Drawing.Point(151, 29);
            this.textNombreComp.Name = "textNombreComp";
            this.textNombreComp.Size = new System.Drawing.Size(379, 20);
            this.textNombreComp.TabIndex = 31;
            // 
            // gradosTableAdapter
            // 
            this.gradosTableAdapter.ClearBeforeFill = true;
            // 
            // FAnadirPreferencias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 450);
            this.Controls.Add(this.textNombreComp);
            this.Controls.Add(this.listCompetencias);
            this.Controls.Add(this.comboHoras);
            this.Controls.Add(this.comboTipo);
            this.Controls.Add(this.comboTurno);
            this.Controls.Add(this.comboAsig);
            this.Controls.Add(this.comboGrado);
            this.Controls.Add(this.lNombrePref);
            this.Controls.Add(this.lAsig);
            this.Controls.Add(this.lHoras);
            this.Controls.Add(this.lGrado);
            this.Controls.Add(this.lTurno);
            this.Controls.Add(this.lTipo);
            this.Controls.Add(this.lComp);
            this.Controls.Add(this.bCancelar);
            this.Controls.Add(this.bConfirmar);
            this.Name = "FAnadirPreferencias";
            this.Text = "Introduzca Preferencia";
            this.Load += new System.EventHandler(this.FAnadirPreferencias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gradosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wePassDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wePassDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bConfirmar;
        private System.Windows.Forms.Button bCancelar;
        private System.Windows.Forms.Label lComp;
        private System.Windows.Forms.Label lTipo;
        private System.Windows.Forms.Label lTurno;
        private System.Windows.Forms.Label lGrado;
        private System.Windows.Forms.Label lHoras;
        private System.Windows.Forms.Label lAsig;
        private System.Windows.Forms.Label lNombrePref;
        private System.Windows.Forms.ComboBox comboGrado;
        private System.Windows.Forms.ComboBox comboAsig;
        private System.Windows.Forms.ComboBox comboTurno;
        private System.Windows.Forms.ComboBox comboTipo;
        private System.Windows.Forms.ComboBox comboHoras;
        private System.Windows.Forms.ListBox listCompetencias;
        private System.Windows.Forms.TextBox textNombreComp;
        private System.Windows.Forms.BindingSource wePassDataSetBindingSource;
        private WePassDataSet wePassDataSet;
        private System.Windows.Forms.BindingSource gradosBindingSource;
        private WePassDataSetTableAdapters.GradosTableAdapter gradosTableAdapter;
    }
}