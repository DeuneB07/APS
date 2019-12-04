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
            this.bBorrarPref = new System.Windows.Forms.Button();
            this.bAddPref = new System.Windows.Forms.Button();
            this.listPreferencias = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // b_aceptarReg
            // 
            this.b_aceptarReg.Location = new System.Drawing.Point(454, 463);
            this.b_aceptarReg.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.b_aceptarReg.Name = "b_aceptarReg";
            this.b_aceptarReg.Size = new System.Drawing.Size(83, 28);
            this.b_aceptarReg.TabIndex = 0;
            this.b_aceptarReg.Text = "Aceptar";
            this.b_aceptarReg.UseVisualStyleBackColor = true;
            this.b_aceptarReg.Click += new System.EventHandler(this.b_aceptarReg_Click);
            // 
            // b_cancelarReg
            // 
            this.b_cancelarReg.Location = new System.Drawing.Point(558, 463);
            this.b_cancelarReg.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.b_cancelarReg.Name = "b_cancelarReg";
            this.b_cancelarReg.Size = new System.Drawing.Size(83, 28);
            this.b_cancelarReg.TabIndex = 2;
            this.b_cancelarReg.Text = "Cancelar";
            this.b_cancelarReg.UseVisualStyleBackColor = true;
            this.b_cancelarReg.Click += new System.EventHandler(this.b_cancelarReg_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Correo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nombre";
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.BackColor = System.Drawing.Color.Transparent;
            this.labelError.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelError.ForeColor = System.Drawing.Color.Red;
            this.labelError.Location = new System.Drawing.Point(32, 469);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(44, 17);
            this.labelError.TabIndex = 8;
            this.labelError.Text = "error";
            // 
            // labelUsuario
            // 
            this.labelUsuario.AutoSize = true;
            this.labelUsuario.Location = new System.Drawing.Point(41, 53);
            this.labelUsuario.Name = "labelUsuario";
            this.labelUsuario.Size = new System.Drawing.Size(115, 17);
            this.labelUsuario.TabIndex = 9;
            this.labelUsuario.Text = "Nombre Usuario:";
            // 
            // tUsuario
            // 
            this.tUsuario.Location = new System.Drawing.Point(168, 53);
            this.tUsuario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tUsuario.Name = "tUsuario";
            this.tUsuario.Size = new System.Drawing.Size(124, 22);
            this.tUsuario.TabIndex = 10;
            // 
            // labelDNI
            // 
            this.labelDNI.AutoSize = true;
            this.labelDNI.Location = new System.Drawing.Point(79, 93);
            this.labelDNI.Name = "labelDNI";
            this.labelDNI.Size = new System.Drawing.Size(61, 17);
            this.labelDNI.TabIndex = 11;
            this.labelDNI.Text = "DNI/NIE:";
            // 
            // tDNI
            // 
            this.tDNI.Location = new System.Drawing.Point(168, 90);
            this.tDNI.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tDNI.Name = "tDNI";
            this.tDNI.Size = new System.Drawing.Size(124, 22);
            this.tDNI.TabIndex = 12;
            // 
            // dateTimePickerFechNacimiento
            // 
            this.dateTimePickerFechNacimiento.Location = new System.Drawing.Point(473, 53);
            this.dateTimePickerFechNacimiento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePickerFechNacimiento.Name = "dateTimePickerFechNacimiento";
            this.dateTimePickerFechNacimiento.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerFechNacimiento.TabIndex = 13;
            // 
            // labelFechNacimiento
            // 
            this.labelFechNacimiento.AutoSize = true;
            this.labelFechNacimiento.Location = new System.Drawing.Point(316, 53);
            this.labelFechNacimiento.Name = "labelFechNacimiento";
            this.labelFechNacimiento.Size = new System.Drawing.Size(125, 17);
            this.labelFechNacimiento.TabIndex = 14;
            this.labelFechNacimiento.Text = "Fecha Nacimiento:";
            // 
            // t_correoReg
            // 
            this.t_correoReg.Location = new System.Drawing.Point(82, 49);
            this.t_correoReg.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.t_correoReg.Name = "t_correoReg";
            this.t_correoReg.Size = new System.Drawing.Size(369, 22);
            this.t_correoReg.TabIndex = 5;
            // 
            // t_Nombre
            // 
            this.t_Nombre.Location = new System.Drawing.Point(82, 76);
            this.t_Nombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.t_Nombre.Name = "t_Nombre";
            this.t_Nombre.Size = new System.Drawing.Size(369, 22);
            this.t_Nombre.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 17);
            this.label3.TabIndex = 15;
            this.label3.Text = "Grado";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(230, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 17);
            this.label4.TabIndex = 17;
            this.label4.Text = "Asignaturas";
            // 
            // lblRol
            // 
            this.lblRol.AutoSize = true;
            this.lblRol.Location = new System.Drawing.Point(41, 114);
            this.lblRol.Name = "lblRol";
            this.lblRol.Size = new System.Drawing.Size(29, 17);
            this.lblRol.TabIndex = 19;
            this.lblRol.Text = "Rol";
            // 
            // tRol
            // 
            this.tRol.Location = new System.Drawing.Point(82, 111);
            this.tRol.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tRol.Name = "tRol";
            this.tRol.Size = new System.Drawing.Size(109, 22);
            this.tRol.TabIndex = 20;
            // 
            // listGrado
            // 
            this.listGrado.FormattingEnabled = true;
            this.listGrado.ItemHeight = 16;
            this.listGrado.Location = new System.Drawing.Point(82, 148);
            this.listGrado.Name = "listGrado";
            this.listGrado.Size = new System.Drawing.Size(129, 36);
            this.listGrado.TabIndex = 21;
            // 
            // listAsig
            // 
            this.listAsig.FormattingEnabled = true;
            this.listAsig.ItemHeight = 16;
            this.listAsig.Location = new System.Drawing.Point(319, 137);
            this.listAsig.Name = "listAsig";
            this.listAsig.Size = new System.Drawing.Size(290, 52);
            this.listAsig.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Modern No. 20", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Location = new System.Drawing.Point(17, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 30);
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
            this.panel1.Location = new System.Drawing.Point(35, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(703, 218);
            this.panel1.TabIndex = 24;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
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
            this.panel2.Location = new System.Drawing.Point(35, 227);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(703, 207);
            this.panel2.TabIndex = 25;
            // 
            // bBorrarPref
            // 
            this.bBorrarPref.Location = new System.Drawing.Point(561, 150);
            this.bBorrarPref.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bBorrarPref.Name = "bBorrarPref";
            this.bBorrarPref.Size = new System.Drawing.Size(105, 28);
            this.bBorrarPref.TabIndex = 27;
            this.bBorrarPref.Text = "Borrar";
            this.bBorrarPref.UseVisualStyleBackColor = true;
            this.bBorrarPref.Click += new System.EventHandler(this.bBorrarPref_Click);
            // 
            // bAddPref
            // 
            this.bAddPref.Location = new System.Drawing.Point(450, 150);
            this.bAddPref.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bAddPref.Name = "bAddPref";
            this.bAddPref.Size = new System.Drawing.Size(105, 28);
            this.bAddPref.TabIndex = 26;
            this.bAddPref.Text = "Añadir";
            this.bAddPref.UseVisualStyleBackColor = true;
            this.bAddPref.Click += new System.EventHandler(this.bAddPref_Click);
            // 
            // listPreferencias
            // 
            this.listPreferencias.FormattingEnabled = true;
            this.listPreferencias.ItemHeight = 16;
            this.listPreferencias.Location = new System.Drawing.Point(428, 93);
            this.listPreferencias.Name = "listPreferencias";
            this.listPreferencias.Size = new System.Drawing.Size(245, 52);
            this.listPreferencias.TabIndex = 24;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(330, 93);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 17);
            this.label7.TabIndex = 25;
            this.label7.Text = "Preferencias:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Modern No. 20", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label6.Location = new System.Drawing.Point(17, 5);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 30);
            this.label6.TabIndex = 24;
            this.label6.Text = "ApS";
            // 
            // RegistroUMA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 520);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelError);
            this.Controls.Add(this.b_cancelarReg);
            this.Controls.Add(this.b_aceptarReg);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "RegistroUMA";
            this.Text = "Registro";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
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
    }
}