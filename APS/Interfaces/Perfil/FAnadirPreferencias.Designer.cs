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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FAnadirPreferencias));
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
            this.listCompetencias = new System.Windows.Forms.ListBox();
            this.textNombreComp = new System.Windows.Forms.TextBox();
            this.gradosTableAdapter = new APS.WePassDataSetTableAdapters.GradosTableAdapter();
            this.lTipoTrab = new System.Windows.Forms.Label();
            this.lAmbito = new System.Windows.Forms.Label();
            this.comboAmbitoTrab = new System.Windows.Forms.ComboBox();
            this.comboTipoTrab = new System.Windows.Forms.ComboBox();
            this.numericUpDown = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.gradosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wePassDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wePassDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // bConfirmar
            // 
            this.bConfirmar.BackColor = System.Drawing.Color.Aquamarine;
            this.bConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bConfirmar.Font = new System.Drawing.Font("Georgia", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bConfirmar.Location = new System.Drawing.Point(156, 522);
            this.bConfirmar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bConfirmar.Name = "bConfirmar";
            this.bConfirmar.Size = new System.Drawing.Size(215, 28);
            this.bConfirmar.TabIndex = 16;
            this.bConfirmar.Text = "Confirmar";
            this.bConfirmar.UseVisualStyleBackColor = false;
            this.bConfirmar.Click += new System.EventHandler(this.bConfirmar_Click);
            // 
            // bCancelar
            // 
            this.bCancelar.BackColor = System.Drawing.Color.IndianRed;
            this.bCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bCancelar.Font = new System.Drawing.Font("Georgia", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bCancelar.Location = new System.Drawing.Point(424, 522);
            this.bCancelar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bCancelar.Name = "bCancelar";
            this.bCancelar.Size = new System.Drawing.Size(205, 28);
            this.bCancelar.TabIndex = 17;
            this.bCancelar.Text = "Cancelar";
            this.bCancelar.UseVisualStyleBackColor = false;
            this.bCancelar.Click += new System.EventHandler(this.bCancelar_Click);
            // 
            // lComp
            // 
            this.lComp.AutoSize = true;
            this.lComp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lComp.Location = new System.Drawing.Point(29, 343);
            this.lComp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lComp.Name = "lComp";
            this.lComp.Size = new System.Drawing.Size(116, 18);
            this.lComp.TabIndex = 18;
            this.lComp.Text = "Competencias";
            // 
            // lTipo
            // 
            this.lTipo.AutoSize = true;
            this.lTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTipo.Location = new System.Drawing.Point(29, 117);
            this.lTipo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lTipo.Name = "lTipo";
            this.lTipo.Size = new System.Drawing.Size(143, 18);
            this.lTipo.TabIndex = 19;
            this.lTipo.Text = "Tipo de Actividad*";
            // 
            // lTurno
            // 
            this.lTurno.AutoSize = true;
            this.lTurno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTurno.Location = new System.Drawing.Point(535, 117);
            this.lTurno.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lTurno.Name = "lTurno";
            this.lTurno.Size = new System.Drawing.Size(59, 18);
            this.lTurno.TabIndex = 20;
            this.lTurno.Text = "Turno*";
            // 
            // lGrado
            // 
            this.lGrado.AutoSize = true;
            this.lGrado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lGrado.Location = new System.Drawing.Point(61, 178);
            this.lGrado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lGrado.Name = "lGrado";
            this.lGrado.Size = new System.Drawing.Size(55, 18);
            this.lGrado.TabIndex = 21;
            this.lGrado.Text = "Grado";
            // 
            // lHoras
            // 
            this.lHoras.AutoSize = true;
            this.lHoras.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lHoras.Location = new System.Drawing.Point(381, 277);
            this.lHoras.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lHoras.Name = "lHoras";
            this.lHoras.Size = new System.Drawing.Size(213, 18);
            this.lHoras.TabIndex = 22;
            this.lHoras.Text = "Número de Horas Máximo*";
            // 
            // lAsig
            // 
            this.lAsig.AutoSize = true;
            this.lAsig.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lAsig.Location = new System.Drawing.Point(29, 223);
            this.lAsig.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lAsig.Name = "lAsig";
            this.lAsig.Size = new System.Drawing.Size(87, 18);
            this.lAsig.TabIndex = 23;
            this.lAsig.Text = "Asignatura";
            // 
            // lNombrePref
            // 
            this.lNombrePref.AutoSize = true;
            this.lNombrePref.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lNombrePref.ForeColor = System.Drawing.Color.Navy;
            this.lNombrePref.Location = new System.Drawing.Point(13, 39);
            this.lNombrePref.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lNombrePref.Name = "lNombrePref";
            this.lNombrePref.Size = new System.Drawing.Size(166, 18);
            this.lNombrePref.TabIndex = 24;
            this.lNombrePref.Text = "Nombre Preferencia*";
            // 
            // comboGrado
            // 
            this.comboGrado.Enabled = false;
            this.comboGrado.FormattingEnabled = true;
            this.comboGrado.Location = new System.Drawing.Point(139, 172);
            this.comboGrado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboGrado.Name = "comboGrado";
            this.comboGrado.Size = new System.Drawing.Size(256, 24);
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
            this.comboAsig.Enabled = false;
            this.comboAsig.Location = new System.Drawing.Point(139, 222);
            this.comboAsig.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboAsig.Name = "comboAsig";
            this.comboAsig.Size = new System.Drawing.Size(256, 24);
            this.comboAsig.TabIndex = 26;
            this.comboAsig.Visible = false;
            // 
            // comboTurno
            // 
            this.comboTurno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboTurno.FormattingEnabled = true;
            this.comboTurno.Location = new System.Drawing.Point(616, 114);
            this.comboTurno.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboTurno.Name = "comboTurno";
            this.comboTurno.Size = new System.Drawing.Size(133, 26);
            this.comboTurno.TabIndex = 27;
            // 
            // comboTipo
            // 
            this.comboTipo.FormattingEnabled = true;
            this.comboTipo.Location = new System.Drawing.Point(203, 117);
            this.comboTipo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboTipo.Name = "comboTipo";
            this.comboTipo.Size = new System.Drawing.Size(133, 24);
            this.comboTipo.TabIndex = 28;
            // 
            // listCompetencias
            // 
            this.listCompetencias.FormattingEnabled = true;
            this.listCompetencias.ItemHeight = 16;
            this.listCompetencias.Location = new System.Drawing.Point(156, 343);
            this.listCompetencias.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listCompetencias.Name = "listCompetencias";
            this.listCompetencias.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listCompetencias.Size = new System.Drawing.Size(473, 148);
            this.listCompetencias.TabIndex = 30;
            // 
            // textNombreComp
            // 
            this.textNombreComp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textNombreComp.Location = new System.Drawing.Point(203, 39);
            this.textNombreComp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textNombreComp.Name = "textNombreComp";
            this.textNombreComp.Size = new System.Drawing.Size(546, 24);
            this.textNombreComp.TabIndex = 31;
            // 
            // gradosTableAdapter
            // 
            this.gradosTableAdapter.ClearBeforeFill = true;
            // 
            // lTipoTrab
            // 
            this.lTipoTrab.AutoSize = true;
            this.lTipoTrab.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTipoTrab.Location = new System.Drawing.Point(461, 170);
            this.lTipoTrab.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lTipoTrab.Name = "lTipoTrab";
            this.lTipoTrab.Size = new System.Drawing.Size(133, 18);
            this.lTipoTrab.TabIndex = 32;
            this.lTipoTrab.Text = "Tipo de Trabajo*";
            // 
            // lAmbito
            // 
            this.lAmbito.AutoSize = true;
            this.lAmbito.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lAmbito.Location = new System.Drawing.Point(442, 222);
            this.lAmbito.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lAmbito.Name = "lAmbito";
            this.lAmbito.Size = new System.Drawing.Size(152, 18);
            this.lAmbito.TabIndex = 33;
            this.lAmbito.Text = "Ámbito de Trabajo*";
            // 
            // comboAmbitoTrab
            // 
            this.comboAmbitoTrab.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboAmbitoTrab.FormattingEnabled = true;
            this.comboAmbitoTrab.Location = new System.Drawing.Point(616, 217);
            this.comboAmbitoTrab.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboAmbitoTrab.Name = "comboAmbitoTrab";
            this.comboAmbitoTrab.Size = new System.Drawing.Size(133, 26);
            this.comboAmbitoTrab.TabIndex = 34;
            // 
            // comboTipoTrab
            // 
            this.comboTipoTrab.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboTipoTrab.FormattingEnabled = true;
            this.comboTipoTrab.Location = new System.Drawing.Point(616, 170);
            this.comboTipoTrab.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboTipoTrab.Name = "comboTipoTrab";
            this.comboTipoTrab.Size = new System.Drawing.Size(133, 26);
            this.comboTipoTrab.TabIndex = 35;
            // 
            // numericUpDown
            // 
            this.numericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown.Location = new System.Drawing.Point(616, 275);
            this.numericUpDown.Name = "numericUpDown";
            this.numericUpDown.Size = new System.Drawing.Size(70, 24);
            this.numericUpDown.TabIndex = 36;
            // 
            // FAnadirPreferencias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(788, 570);
            this.Controls.Add(this.numericUpDown);
            this.Controls.Add(this.comboTipoTrab);
            this.Controls.Add(this.comboAmbitoTrab);
            this.Controls.Add(this.lAmbito);
            this.Controls.Add(this.lTipoTrab);
            this.Controls.Add(this.textNombreComp);
            this.Controls.Add(this.listCompetencias);
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FAnadirPreferencias";
            this.Text = "Introduzca Preferencia";
            this.Load += new System.EventHandler(this.FAnadirPreferencias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gradosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wePassDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wePassDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).EndInit();
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
        private System.Windows.Forms.ListBox listCompetencias;
        private System.Windows.Forms.TextBox textNombreComp;
        private System.Windows.Forms.BindingSource wePassDataSetBindingSource;
        private WePassDataSet wePassDataSet;
        private System.Windows.Forms.BindingSource gradosBindingSource;
        private WePassDataSetTableAdapters.GradosTableAdapter gradosTableAdapter;
        private System.Windows.Forms.Label lTipoTrab;
        private System.Windows.Forms.Label lAmbito;
        private System.Windows.Forms.ComboBox comboAmbitoTrab;
        private System.Windows.Forms.ComboBox comboTipoTrab;
        private System.Windows.Forms.NumericUpDown numericUpDown;
    }
}