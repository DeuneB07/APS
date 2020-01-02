namespace APS.Interfaces.Gestión_Proyectos
{
    partial class NuevoProyecto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NuevoProyecto));
            this.tDescripcion = new System.Windows.Forms.RichTextBox();
            this.tNombreProy = new System.Windows.Forms.TextBox();
            this.tResponsable = new System.Windows.Forms.TextBox();
            this.labelDescripcion = new System.Windows.Forms.Label();
            this.labelNombreProy = new System.Windows.Forms.Label();
            this.labelProyecto = new System.Windows.Forms.Label();
            this.lblTipoProy = new System.Windows.Forms.Label();
            this.comboTipoProy = new System.Windows.Forms.ComboBox();
            this.btnAñadir = new System.Windows.Forms.Button();
            this.btnQuitar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.comboTipoAct = new System.Windows.Forms.ComboBox();
            this.labelFiltrar = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCrear = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblError = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tDescripcion
            // 
            this.tDescripcion.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tDescripcion.Location = new System.Drawing.Point(198, 176);
            this.tDescripcion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tDescripcion.Name = "tDescripcion";
            this.tDescripcion.Size = new System.Drawing.Size(223, 72);
            this.tDescripcion.TabIndex = 27;
            this.tDescripcion.Text = "";
            // 
            // tNombreProy
            // 
            this.tNombreProy.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tNombreProy.Location = new System.Drawing.Point(198, 135);
            this.tNombreProy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tNombreProy.Name = "tNombreProy";
            this.tNombreProy.Size = new System.Drawing.Size(223, 26);
            this.tNombreProy.TabIndex = 26;
            // 
            // tResponsable
            // 
            this.tResponsable.Enabled = false;
            this.tResponsable.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tResponsable.Location = new System.Drawing.Point(198, 85);
            this.tResponsable.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tResponsable.Name = "tResponsable";
            this.tResponsable.Size = new System.Drawing.Size(223, 26);
            this.tResponsable.TabIndex = 25;
            // 
            // labelDescripcion
            // 
            this.labelDescripcion.AutoSize = true;
            this.labelDescripcion.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescripcion.Location = new System.Drawing.Point(26, 180);
            this.labelDescripcion.Name = "labelDescripcion";
            this.labelDescripcion.Size = new System.Drawing.Size(151, 18);
            this.labelDescripcion.TabIndex = 22;
            this.labelDescripcion.Text = "Descripción Proyecto:";
            // 
            // labelNombreProy
            // 
            this.labelNombreProy.AutoSize = true;
            this.labelNombreProy.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombreProy.Location = new System.Drawing.Point(54, 139);
            this.labelNombreProy.Name = "labelNombreProy";
            this.labelNombreProy.Size = new System.Drawing.Size(127, 18);
            this.labelNombreProy.TabIndex = 21;
            this.labelNombreProy.Text = "Nombre Proyecto:";
            // 
            // labelProyecto
            // 
            this.labelProyecto.AutoSize = true;
            this.labelProyecto.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProyecto.Location = new System.Drawing.Point(84, 88);
            this.labelProyecto.Name = "labelProyecto";
            this.labelProyecto.Size = new System.Drawing.Size(97, 18);
            this.labelProyecto.TabIndex = 20;
            this.labelProyecto.Text = "Responsable:";
            // 
            // lblTipoProy
            // 
            this.lblTipoProy.AutoSize = true;
            this.lblTipoProy.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoProy.Location = new System.Drawing.Point(77, 274);
            this.lblTipoProy.Name = "lblTipoProy";
            this.lblTipoProy.Size = new System.Drawing.Size(100, 18);
            this.lblTipoProy.TabIndex = 28;
            this.lblTipoProy.Text = "Tipo Proyecto:";
            // 
            // comboTipoProy
            // 
            this.comboTipoProy.FormattingEnabled = true;
            this.comboTipoProy.Location = new System.Drawing.Point(198, 274);
            this.comboTipoProy.Name = "comboTipoProy";
            this.comboTipoProy.Size = new System.Drawing.Size(223, 24);
            this.comboTipoProy.TabIndex = 29;
            // 
            // btnAñadir
            // 
            this.btnAñadir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAñadir.Font = new System.Drawing.Font("Bahnschrift", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAñadir.Location = new System.Drawing.Point(325, 175);
            this.btnAñadir.Name = "btnAñadir";
            this.btnAñadir.Size = new System.Drawing.Size(75, 23);
            this.btnAñadir.TabIndex = 32;
            this.btnAñadir.Text = "Añadir";
            this.btnAñadir.UseVisualStyleBackColor = true;
            this.btnAñadir.Click += new System.EventHandler(this.btnAñadir_Click);
            // 
            // btnQuitar
            // 
            this.btnQuitar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnQuitar.Font = new System.Drawing.Font("Bahnschrift", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitar.Location = new System.Drawing.Point(325, 216);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(75, 23);
            this.btnQuitar.TabIndex = 33;
            this.btnQuitar.Text = "Quitar";
            this.btnQuitar.UseVisualStyleBackColor = true;
            this.btnQuitar.Click += new System.EventHandler(this.btnQuitar_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.listBox2);
            this.panel1.Controls.Add(this.listBox1);
            this.panel1.Controls.Add(this.labelFiltrar);
            this.panel1.Controls.Add(this.comboTipoAct);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnQuitar);
            this.panel1.Controls.Add(this.btnAñadir);
            this.panel1.Location = new System.Drawing.Point(450, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(712, 333);
            this.panel1.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label1.Location = new System.Drawing.Point(16, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 25);
            this.label1.TabIndex = 34;
            this.label1.Text = "Actividades";
            // 
            // comboTipoAct
            // 
            this.comboTipoAct.Font = new System.Drawing.Font("Bahnschrift", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboTipoAct.FormattingEnabled = true;
            this.comboTipoAct.Location = new System.Drawing.Point(114, 85);
            this.comboTipoAct.Name = "comboTipoAct";
            this.comboTipoAct.Size = new System.Drawing.Size(140, 24);
            this.comboTipoAct.TabIndex = 37;
            this.comboTipoAct.SelectedIndexChanged += new System.EventHandler(this.comboTipoAct_SelectedIndexChanged);
            // 
            // labelFiltrar
            // 
            this.labelFiltrar.AutoSize = true;
            this.labelFiltrar.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFiltrar.Location = new System.Drawing.Point(52, 88);
            this.labelFiltrar.Name = "labelFiltrar";
            this.labelFiltrar.Size = new System.Drawing.Size(51, 18);
            this.labelFiltrar.TabIndex = 36;
            this.labelFiltrar.Text = "Filtrar:";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.comboTipoProy);
            this.panel2.Controls.Add(this.lblTipoProy);
            this.panel2.Controls.Add(this.tDescripcion);
            this.panel2.Controls.Add(this.tNombreProy);
            this.panel2.Controls.Add(this.tResponsable);
            this.panel2.Controls.Add(this.labelDescripcion);
            this.panel2.Controls.Add(this.labelNombreProy);
            this.panel2.Controls.Add(this.labelProyecto);
            this.panel2.Location = new System.Drawing.Point(11, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(440, 333);
            this.panel2.TabIndex = 35;
            // 
            // btnCrear
            // 
            this.btnCrear.Font = new System.Drawing.Font("Bahnschrift", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrear.Location = new System.Drawing.Point(935, 370);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(103, 29);
            this.btnCrear.TabIndex = 36;
            this.btnCrear.Text = "Crear";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Bahnschrift", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(1059, 370);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(103, 29);
            this.btnCancelar.TabIndex = 37;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(21, 126);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(298, 180);
            this.listBox1.TabIndex = 35;
            // 
            // listBox2
            // 
            this.listBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 16;
            this.listBox2.Location = new System.Drawing.Point(406, 128);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(293, 164);
            this.listBox2.TabIndex = 38;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label2.Location = new System.Drawing.Point(24, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 25);
            this.label2.TabIndex = 39;
            this.label2.Text = "Información";
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(72, 363);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(45, 18);
            this.lblError.TabIndex = 38;
            this.lblError.Text = "error";
            // 
            // NuevoProyecto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1197, 424);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NuevoProyecto";
            this.Text = "Nuevo Proyecto";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox tDescripcion;
        private System.Windows.Forms.TextBox tNombreProy;
        private System.Windows.Forms.TextBox tResponsable;
        private System.Windows.Forms.Label labelDescripcion;
        private System.Windows.Forms.Label labelNombreProy;
        private System.Windows.Forms.Label labelProyecto;
        private System.Windows.Forms.Label lblTipoProy;
        private System.Windows.Forms.ComboBox comboTipoProy;
        private System.Windows.Forms.Button btnAñadir;
        private System.Windows.Forms.Button btnQuitar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelFiltrar;
        private System.Windows.Forms.ComboBox comboTipoAct;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblError;
    }
}