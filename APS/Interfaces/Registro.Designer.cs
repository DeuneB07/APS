namespace APS.Interfaces
{
    partial class Registro
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
            this.b_aceptarReg = new System.Windows.Forms.Button();
            this.b_ONGReg = new System.Windows.Forms.Button();
            this.b_cancelarReg = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.t_correoReg = new System.Windows.Forms.TextBox();
            this.t_pwdReg = new System.Windows.Forms.TextBox();
            this.labelError = new System.Windows.Forms.Label();
            this.labelUsuario = new System.Windows.Forms.Label();
            this.tUsuario = new System.Windows.Forms.TextBox();
            this.labelDNI = new System.Windows.Forms.Label();
            this.tDNI = new System.Windows.Forms.TextBox();
            this.dateTimePickerFechNacimiento = new System.Windows.Forms.DateTimePicker();
            this.labelFechNacimiento = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // b_aceptarReg
            // 
            this.b_aceptarReg.Location = new System.Drawing.Point(337, 237);
            this.b_aceptarReg.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.b_aceptarReg.Name = "b_aceptarReg";
            this.b_aceptarReg.Size = new System.Drawing.Size(62, 23);
            this.b_aceptarReg.TabIndex = 0;
            this.b_aceptarReg.Text = "Aceptar";
            this.b_aceptarReg.UseVisualStyleBackColor = true;
            this.b_aceptarReg.Click += new System.EventHandler(this.b_aceptarReg_Click);
            // 
            // b_ONGReg
            // 
            this.b_ONGReg.Location = new System.Drawing.Point(28, 237);
            this.b_ONGReg.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.b_ONGReg.Name = "b_ONGReg";
            this.b_ONGReg.Size = new System.Drawing.Size(62, 23);
            this.b_ONGReg.TabIndex = 1;
            this.b_ONGReg.Text = "Soy ONG";
            this.b_ONGReg.UseVisualStyleBackColor = true;
            this.b_ONGReg.Visible = false;
            // 
            // b_cancelarReg
            // 
            this.b_cancelarReg.Location = new System.Drawing.Point(418, 237);
            this.b_cancelarReg.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.b_cancelarReg.Name = "b_cancelarReg";
            this.b_cancelarReg.Size = new System.Drawing.Size(62, 23);
            this.b_cancelarReg.TabIndex = 2;
            this.b_cancelarReg.Text = "Cancelar";
            this.b_cancelarReg.UseVisualStyleBackColor = true;
            this.b_cancelarReg.Click += new System.EventHandler(this.b_cancelarReg_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(95, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Correo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(73, 74);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Contraseña";
            // 
            // t_correoReg
            // 
            this.t_correoReg.Location = new System.Drawing.Point(160, 36);
            this.t_correoReg.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.t_correoReg.Name = "t_correoReg";
            this.t_correoReg.Size = new System.Drawing.Size(278, 20);
            this.t_correoReg.TabIndex = 5;
            // 
            // t_pwdReg
            // 
            this.t_pwdReg.Location = new System.Drawing.Point(160, 72);
            this.t_pwdReg.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.t_pwdReg.Name = "t_pwdReg";
            this.t_pwdReg.PasswordChar = '*';
            this.t_pwdReg.Size = new System.Drawing.Size(278, 20);
            this.t_pwdReg.TabIndex = 6;
            this.t_pwdReg.UseSystemPasswordChar = true;
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.BackColor = System.Drawing.Color.Transparent;
            this.labelError.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelError.ForeColor = System.Drawing.Color.Red;
            this.labelError.Location = new System.Drawing.Point(95, 242);
            this.labelError.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(33, 13);
            this.labelError.TabIndex = 8;
            this.labelError.Text = "error";
            // 
            // labelUsuario
            // 
            this.labelUsuario.AutoSize = true;
            this.labelUsuario.Location = new System.Drawing.Point(58, 119);
            this.labelUsuario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelUsuario.Name = "labelUsuario";
            this.labelUsuario.Size = new System.Drawing.Size(86, 13);
            this.labelUsuario.TabIndex = 9;
            this.labelUsuario.Text = "Nombre Usuario:";
            // 
            // tUsuario
            // 
            this.tUsuario.Location = new System.Drawing.Point(160, 119);
            this.tUsuario.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tUsuario.Name = "tUsuario";
            this.tUsuario.Size = new System.Drawing.Size(77, 20);
            this.tUsuario.TabIndex = 10;
            // 
            // labelDNI
            // 
            this.labelDNI.AutoSize = true;
            this.labelDNI.Location = new System.Drawing.Point(95, 147);
            this.labelDNI.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDNI.Name = "labelDNI";
            this.labelDNI.Size = new System.Drawing.Size(52, 13);
            this.labelDNI.TabIndex = 11;
            this.labelDNI.Text = "DNI/NIE:";
            // 
            // tDNI
            // 
            this.tDNI.Location = new System.Drawing.Point(160, 147);
            this.tDNI.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tDNI.Name = "tDNI";
            this.tDNI.Size = new System.Drawing.Size(77, 20);
            this.tDNI.TabIndex = 12;
            // 
            // dateTimePickerFechNacimiento
            // 
            this.dateTimePickerFechNacimiento.Location = new System.Drawing.Point(345, 118);
            this.dateTimePickerFechNacimiento.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateTimePickerFechNacimiento.Name = "dateTimePickerFechNacimiento";
            this.dateTimePickerFechNacimiento.Size = new System.Drawing.Size(151, 20);
            this.dateTimePickerFechNacimiento.TabIndex = 13;
            // 
            // labelFechNacimiento
            // 
            this.labelFechNacimiento.AutoSize = true;
            this.labelFechNacimiento.Location = new System.Drawing.Point(247, 118);
            this.labelFechNacimiento.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelFechNacimiento.Name = "labelFechNacimiento";
            this.labelFechNacimiento.Size = new System.Drawing.Size(96, 13);
            this.labelFechNacimiento.TabIndex = 14;
            this.labelFechNacimiento.Text = "Fecha Nacimiento:";
            // 
            // Registro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 281);
            this.Controls.Add(this.labelFechNacimiento);
            this.Controls.Add(this.dateTimePickerFechNacimiento);
            this.Controls.Add(this.tDNI);
            this.Controls.Add(this.labelDNI);
            this.Controls.Add(this.tUsuario);
            this.Controls.Add(this.labelUsuario);
            this.Controls.Add(this.labelError);
            this.Controls.Add(this.t_pwdReg);
            this.Controls.Add(this.t_correoReg);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.b_cancelarReg);
            this.Controls.Add(this.b_ONGReg);
            this.Controls.Add(this.b_aceptarReg);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Registro";
            this.Text = "Registro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button b_aceptarReg;
        private System.Windows.Forms.Button b_ONGReg;
        private System.Windows.Forms.Button b_cancelarReg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox t_correoReg;
        private System.Windows.Forms.TextBox t_pwdReg;
        private System.Windows.Forms.Label labelError;
        private System.Windows.Forms.Label labelUsuario;
        private System.Windows.Forms.TextBox tUsuario;
        private System.Windows.Forms.Label labelDNI;
        private System.Windows.Forms.TextBox tDNI;
        private System.Windows.Forms.DateTimePicker dateTimePickerFechNacimiento;
        private System.Windows.Forms.Label labelFechNacimiento;
    }
}