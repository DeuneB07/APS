namespace APS.Interfaces
{
    partial class RegistroUMA
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistroUMA));
            this.b_aceptarReg = new System.Windows.Forms.Button();
            this.b_cancelarReg = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelError = new System.Windows.Forms.Label();
            this.labelUsuario = new System.Windows.Forms.Label();
            this.tUsuario = new System.Windows.Forms.TextBox();
            this.labelDNI = new System.Windows.Forms.Label();
            this.tDNI = new System.Windows.Forms.TextBox();
            this.dateTimePickerFechNacimiento = new System.Windows.Forms.DateTimePicker();
            this.labelFechNacimiento = new System.Windows.Forms.Label();
            this.t_correoReg = new System.Windows.Forms.TextBox();
            this.t_Nombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblRol = new System.Windows.Forms.Label();
            this.tRol = new System.Windows.Forms.TextBox();
            this.listGrado = new System.Windows.Forms.ListBox();
            this.listAsig = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnExaminar = new System.Windows.Forms.Button();
            this.tURL = new System.Windows.Forms.TextBox();
            this.pictureBoxPerfil = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.bBorrarPref = new System.Windows.Forms.Button();
            this.bAddPref = new System.Windows.Forms.Button();
            this.listPreferencias = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPerfil)).BeginInit();
            this.SuspendLayout();
            // 
            // b_aceptarReg
            // 
            this.b_aceptarReg.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.b_aceptarReg.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_aceptarReg.Location = new System.Drawing.Point(382, 431);
            this.b_aceptarReg.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.b_aceptarReg.Name = "b_aceptarReg";
            this.b_aceptarReg.Size = new System.Drawing.Size(79, 23);
            this.b_aceptarReg.TabIndex = 0;
            this.b_aceptarReg.Text = "Aceptar";
            this.b_aceptarReg.UseVisualStyleBackColor = true;
            this.b_aceptarReg.Click += new System.EventHandler(this.b_aceptarReg_Click);
            // 
            // b_cancelarReg
            // 
            this.b_cancelarReg.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.b_cancelarReg.Location = new System.Drawing.Point(478, 431);
            this.b_cancelarReg.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.b_cancelarReg.Name = "b_cancelarReg";
            this.b_cancelarReg.Size = new System.Drawing.Size(75, 23);
            this.b_cancelarReg.TabIndex = 2;
            this.b_cancelarReg.Text = "Omitir";
            this.b_cancelarReg.UseVisualStyleBackColor = true;
            this.b_cancelarReg.Click += new System.EventHandler(this.b_cancelarReg_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Correo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 64);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nombre";
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.BackColor = System.Drawing.Color.Transparent;
            this.labelError.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelError.ForeColor = System.Drawing.Color.Red;
            this.labelError.Location = new System.Drawing.Point(29, 431);
            this.labelError.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(33, 13);
            this.labelError.TabIndex = 8;
            this.labelError.Text = "error";
            // 
            // labelUsuario
            // 
            this.labelUsuario.AutoSize = true;
            this.labelUsuario.Location = new System.Drawing.Point(2, 43);
            this.labelUsuario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelUsuario.Name = "labelUsuario";
            this.labelUsuario.Size = new System.Drawing.Size(86, 13);
            this.labelUsuario.TabIndex = 9;
            this.labelUsuario.Text = "Nombre Usuario:";
            // 
            // tUsuario
            // 
            this.tUsuario.Location = new System.Drawing.Point(99, 43);
            this.tUsuario.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tUsuario.Name = "tUsuario";
            this.tUsuario.Size = new System.Drawing.Size(94, 20);
            this.tUsuario.TabIndex = 10;
            // 
            // labelDNI
            // 
            this.labelDNI.AutoSize = true;
            this.labelDNI.Location = new System.Drawing.Point(43, 80);
            this.labelDNI.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDNI.Name = "labelDNI";
            this.labelDNI.Size = new System.Drawing.Size(52, 13);
            this.labelDNI.TabIndex = 11;
            this.labelDNI.Text = "DNI/NIE:";
            // 
            // tDNI
            // 
            this.tDNI.Location = new System.Drawing.Point(99, 80);
            this.tDNI.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tDNI.Name = "tDNI";
            this.tDNI.Size = new System.Drawing.Size(94, 20);
            this.tDNI.TabIndex = 12;
            // 
            // dateTimePickerFechNacimiento
            // 
            this.dateTimePickerFechNacimiento.Location = new System.Drawing.Point(355, 43);
            this.dateTimePickerFechNacimiento.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateTimePickerFechNacimiento.Name = "dateTimePickerFechNacimiento";
            this.dateTimePickerFechNacimiento.Size = new System.Drawing.Size(151, 20);
            this.dateTimePickerFechNacimiento.TabIndex = 13;
            // 
            // labelFechNacimiento
            // 
            this.labelFechNacimiento.AutoSize = true;
            this.labelFechNacimiento.Location = new System.Drawing.Point(237, 43);
            this.labelFechNacimiento.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelFechNacimiento.Name = "labelFechNacimiento";
            this.labelFechNacimiento.Size = new System.Drawing.Size(96, 13);
            this.labelFechNacimiento.TabIndex = 14;
            this.labelFechNacimiento.Text = "Fecha Nacimiento:";
            // 
            // t_correoReg
            // 
            this.t_correoReg.Location = new System.Drawing.Point(62, 40);
            this.t_correoReg.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.t_correoReg.Name = "t_correoReg";
            this.t_correoReg.Size = new System.Drawing.Size(278, 20);
            this.t_correoReg.TabIndex = 5;
            // 
            // t_Nombre
            // 
            this.t_Nombre.Location = new System.Drawing.Point(62, 62);
            this.t_Nombre.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.t_Nombre.Name = "t_Nombre";
            this.t_Nombre.Size = new System.Drawing.Size(278, 20);
            this.t_Nombre.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 125);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Grado";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(172, 120);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Asignaturas";
            // 
            // lblRol
            // 
            this.lblRol.AutoSize = true;
            this.lblRol.Location = new System.Drawing.Point(31, 93);
            this.lblRol.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRol.Name = "lblRol";
            this.lblRol.Size = new System.Drawing.Size(23, 13);
            this.lblRol.TabIndex = 19;
            this.lblRol.Text = "Rol";
            // 
            // tRol
            // 
            this.tRol.Location = new System.Drawing.Point(62, 90);
            this.tRol.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tRol.Name = "tRol";
            this.tRol.Size = new System.Drawing.Size(83, 20);
            this.tRol.TabIndex = 20;
            // 
            // listGrado
            // 
            this.listGrado.FormattingEnabled = true;
            this.listGrado.Location = new System.Drawing.Point(62, 120);
            this.listGrado.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listGrado.Name = "listGrado";
            this.listGrado.Size = new System.Drawing.Size(98, 30);
            this.listGrado.TabIndex = 21;
            // 
            // listAsig
            // 
            this.listAsig.FormattingEnabled = true;
            this.listAsig.Location = new System.Drawing.Point(239, 111);
            this.listAsig.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listAsig.Name = "listAsig";
            this.listAsig.Size = new System.Drawing.Size(218, 43);
            this.listAsig.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Modern No. 20", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Location = new System.Drawing.Point(13, 14);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 24);
            this.label5.TabIndex = 23;
            this.label5.Text = "iDUMA";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.listAsig);
            this.panel1.Controls.Add(this.t_correoReg);
            this.panel1.Controls.Add(this.listGrado);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.t_Nombre);
            this.panel1.Controls.Add(this.lblRol);
            this.panel1.Controls.Add(this.tRol);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(26, 10);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(528, 178);
            this.panel1.TabIndex = 24;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnBorrar);
            this.panel2.Controls.Add(this.btnExaminar);
            this.panel2.Controls.Add(this.tURL);
            this.panel2.Controls.Add(this.pictureBoxPerfil);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.bBorrarPref);
            this.panel2.Controls.Add(this.bAddPref);
            this.panel2.Controls.Add(this.listPreferencias);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.labelUsuario);
            this.panel2.Controls.Add(this.tUsuario);
            this.panel2.Controls.Add(this.dateTimePickerFechNacimiento);
            this.panel2.Controls.Add(this.labelFechNacimiento);
            this.panel2.Controls.Add(this.labelDNI);
            this.panel2.Controls.Add(this.tDNI);
            this.panel2.Location = new System.Drawing.Point(26, 184);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(528, 238);
            this.panel2.TabIndex = 25;
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(178, 180);
            this.btnBorrar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(79, 23);
            this.btnBorrar.TabIndex = 32;
            this.btnBorrar.Text = "Reset";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnExaminar
            // 
            this.btnExaminar.Location = new System.Drawing.Point(178, 145);
            this.btnExaminar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnExaminar.Name = "btnExaminar";
            this.btnExaminar.Size = new System.Drawing.Size(79, 23);
            this.btnExaminar.TabIndex = 31;
            this.btnExaminar.Text = "Examinar";
            this.btnExaminar.UseVisualStyleBackColor = true;
            this.btnExaminar.Click += new System.EventHandler(this.btnExaminar_Click);
            // 
            // tURL
            // 
            this.tURL.Enabled = false;
            this.tURL.Location = new System.Drawing.Point(99, 111);
            this.tURL.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tURL.Name = "tURL";
            this.tURL.Size = new System.Drawing.Size(137, 20);
            this.tURL.TabIndex = 30;
            // 
            // pictureBoxPerfil
            // 
            this.pictureBoxPerfil.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxPerfil.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxPerfil.Image")));
            this.pictureBoxPerfil.Location = new System.Drawing.Point(99, 145);
            this.pictureBoxPerfil.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBoxPerfil.Name = "pictureBoxPerfil";
            this.pictureBoxPerfil.Size = new System.Drawing.Size(76, 82);
            this.pictureBoxPerfil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPerfil.TabIndex = 29;
            this.pictureBoxPerfil.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(31, 114);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 13);
            this.label8.TabIndex = 28;
            this.label8.Text = "Imgen Perfil:";
            // 
            // bBorrarPref
            // 
            this.bBorrarPref.Location = new System.Drawing.Point(421, 122);
            this.bBorrarPref.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bBorrarPref.Name = "bBorrarPref";
            this.bBorrarPref.Size = new System.Drawing.Size(79, 23);
            this.bBorrarPref.TabIndex = 27;
            this.bBorrarPref.Text = "Borrar";
            this.bBorrarPref.UseVisualStyleBackColor = true;
            this.bBorrarPref.Click += new System.EventHandler(this.bBorrarPref_Click);
            // 
            // bAddPref
            // 
            this.bAddPref.Location = new System.Drawing.Point(338, 122);
            this.bAddPref.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bAddPref.Name = "bAddPref";
            this.bAddPref.Size = new System.Drawing.Size(79, 23);
            this.bAddPref.TabIndex = 26;
            this.bAddPref.Text = "Añadir";
            this.bAddPref.UseVisualStyleBackColor = true;
            this.bAddPref.Click += new System.EventHandler(this.bAddPref_Click);
            // 
            // listPreferencias
            // 
            this.listPreferencias.FormattingEnabled = true;
            this.listPreferencias.Location = new System.Drawing.Point(321, 76);
            this.listPreferencias.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listPreferencias.Name = "listPreferencias";
            this.listPreferencias.Size = new System.Drawing.Size(185, 43);
            this.listPreferencias.TabIndex = 24;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(248, 76);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 13);
            this.label7.TabIndex = 25;
            this.label7.Text = "Preferencias:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Modern No. 20", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label6.Location = new System.Drawing.Point(13, 4);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 24);
            this.label6.TabIndex = 24;
            this.label6.Text = "ApS";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // RegistroUMA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(586, 466);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelError);
            this.Controls.Add(this.b_cancelarReg);
            this.Controls.Add(this.b_aceptarReg);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "RegistroUMA";
            this.Text = "Registro";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPerfil)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button b_aceptarReg;
        private System.Windows.Forms.Button b_cancelarReg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelError;
        private System.Windows.Forms.Label labelUsuario;
        private System.Windows.Forms.TextBox tUsuario;
        private System.Windows.Forms.Label labelDNI;
        private System.Windows.Forms.TextBox tDNI;
        private System.Windows.Forms.DateTimePicker dateTimePickerFechNacimiento;
        private System.Windows.Forms.Label labelFechNacimiento;
        private System.Windows.Forms.TextBox t_correoReg;
        private System.Windows.Forms.TextBox t_Nombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblRol;
        private System.Windows.Forms.TextBox tRol;
        private System.Windows.Forms.ListBox listGrado;
        private System.Windows.Forms.ListBox listAsig;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox listPreferencias;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button bBorrarPref;
        private System.Windows.Forms.Button bAddPref;
        private System.Windows.Forms.PictureBox pictureBoxPerfil;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnExaminar;
        private System.Windows.Forms.TextBox tURL;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}