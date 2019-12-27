namespace APS.Interfaces
{
    partial class RegistroONG
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistroONG));
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tEmail = new System.Windows.Forms.TextBox();
            this.tPassword = new System.Windows.Forms.TextBox();
            this.labelError = new System.Windows.Forms.Label();
            this.labelUsuario = new System.Windows.Forms.Label();
            this.tUsuario = new System.Windows.Forms.TextBox();
            this.dateTimePickerFechNacimiento = new System.Windows.Forms.DateTimePicker();
            this.labelFechNacimiento = new System.Windows.Forms.Label();
            this.tConfirmar = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblNombreONG = new System.Windows.Forms.Label();
            this.tNombreONG = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnBorrarImagen = new System.Windows.Forms.Button();
            this.btnExaminar = new System.Windows.Forms.Button();
            this.tURL = new System.Windows.Forms.TextBox();
            this.pictureBoxPerfil = new System.Windows.Forms.PictureBox();
            this.lblImagenPerfil = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPerfil)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAceptar
            // 
            this.btnAceptar.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.Location = new System.Drawing.Point(435, 353);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(2);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(62, 23);
            this.btnAceptar.TabIndex = 0;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.b_aceptarReg_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(512, 353);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(62, 23);
            this.btnCancelar.TabIndex = 2;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.b_cancelarReg_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(115, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 14);
            this.label1.TabIndex = 3;
            this.label1.Text = "Correo*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(91, 69);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 14);
            this.label2.TabIndex = 4;
            this.label2.Text = "Contraseña*";
            // 
            // tEmail
            // 
            this.tEmail.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tEmail.Location = new System.Drawing.Point(168, 28);
            this.tEmail.Margin = new System.Windows.Forms.Padding(2);
            this.tEmail.Name = "tEmail";
            this.tEmail.Size = new System.Drawing.Size(278, 22);
            this.tEmail.TabIndex = 5;
            // 
            // tPassword
            // 
            this.tPassword.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tPassword.Location = new System.Drawing.Point(168, 67);
            this.tPassword.Margin = new System.Windows.Forms.Padding(2);
            this.tPassword.Name = "tPassword";
            this.tPassword.PasswordChar = '*';
            this.tPassword.Size = new System.Drawing.Size(278, 21);
            this.tPassword.TabIndex = 6;
            this.tPassword.UseSystemPasswordChar = true;
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.BackColor = System.Drawing.Color.Transparent;
            this.labelError.Font = new System.Drawing.Font("Bahnschrift", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelError.ForeColor = System.Drawing.Color.Red;
            this.labelError.Location = new System.Drawing.Point(26, 353);
            this.labelError.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(34, 13);
            this.labelError.TabIndex = 8;
            this.labelError.Text = "error";
            // 
            // labelUsuario
            // 
            this.labelUsuario.AutoSize = true;
            this.labelUsuario.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsuario.Location = new System.Drawing.Point(44, 17);
            this.labelUsuario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelUsuario.Name = "labelUsuario";
            this.labelUsuario.Size = new System.Drawing.Size(98, 14);
            this.labelUsuario.TabIndex = 9;
            this.labelUsuario.Text = "Nombre Usuario:";
            // 
            // tUsuario
            // 
            this.tUsuario.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tUsuario.Location = new System.Drawing.Point(146, 13);
            this.tUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.tUsuario.Name = "tUsuario";
            this.tUsuario.Size = new System.Drawing.Size(151, 22);
            this.tUsuario.TabIndex = 10;
            // 
            // dateTimePickerFechNacimiento
            // 
            this.dateTimePickerFechNacimiento.Enabled = false;
            this.dateTimePickerFechNacimiento.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerFechNacimiento.Location = new System.Drawing.Point(146, 45);
            this.dateTimePickerFechNacimiento.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePickerFechNacimiento.Name = "dateTimePickerFechNacimiento";
            this.dateTimePickerFechNacimiento.Size = new System.Drawing.Size(202, 21);
            this.dateTimePickerFechNacimiento.TabIndex = 13;
            // 
            // labelFechNacimiento
            // 
            this.labelFechNacimiento.AutoSize = true;
            this.labelFechNacimiento.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFechNacimiento.Location = new System.Drawing.Point(22, 50);
            this.labelFechNacimiento.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelFechNacimiento.Name = "labelFechNacimiento";
            this.labelFechNacimiento.Size = new System.Drawing.Size(120, 14);
            this.labelFechNacimiento.TabIndex = 14;
            this.labelFechNacimiento.Text = "Fecha de Inscripción:";
            // 
            // tConfirmar
            // 
            this.tConfirmar.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tConfirmar.Location = new System.Drawing.Point(168, 110);
            this.tConfirmar.Margin = new System.Windows.Forms.Padding(2);
            this.tConfirmar.Name = "tConfirmar";
            this.tConfirmar.PasswordChar = '*';
            this.tConfirmar.Size = new System.Drawing.Size(278, 21);
            this.tConfirmar.TabIndex = 15;
            this.tConfirmar.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(34, 112);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 14);
            this.label3.TabIndex = 16;
            this.label3.Text = "Confirmar Contraseña*";
            // 
            // lblNombreONG
            // 
            this.lblNombreONG.AutoSize = true;
            this.lblNombreONG.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreONG.Location = new System.Drawing.Point(28, 151);
            this.lblNombreONG.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNombreONG.Name = "lblNombreONG";
            this.lblNombreONG.Size = new System.Drawing.Size(136, 14);
            this.lblNombreONG.TabIndex = 17;
            this.lblNombreONG.Text = "Nombre Completo ONG*";
            // 
            // tNombreONG
            // 
            this.tNombreONG.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tNombreONG.Location = new System.Drawing.Point(168, 148);
            this.tNombreONG.Margin = new System.Windows.Forms.Padding(2);
            this.tNombreONG.Name = "tNombreONG";
            this.tNombreONG.Size = new System.Drawing.Size(278, 22);
            this.tNombreONG.TabIndex = 18;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tEmail);
            this.panel1.Controls.Add(this.tNombreONG);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblNombreONG);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.tPassword);
            this.panel1.Controls.Add(this.tConfirmar);
            this.panel1.Location = new System.Drawing.Point(24, 10);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(603, 193);
            this.panel1.TabIndex = 19;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnBorrarImagen);
            this.panel2.Controls.Add(this.btnExaminar);
            this.panel2.Controls.Add(this.tURL);
            this.panel2.Controls.Add(this.pictureBoxPerfil);
            this.panel2.Controls.Add(this.lblImagenPerfil);
            this.panel2.Controls.Add(this.dateTimePickerFechNacimiento);
            this.panel2.Controls.Add(this.tUsuario);
            this.panel2.Controls.Add(this.labelFechNacimiento);
            this.panel2.Controls.Add(this.labelUsuario);
            this.panel2.Location = new System.Drawing.Point(24, 202);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(603, 138);
            this.panel2.TabIndex = 20;
            // 
            // btnBorrarImagen
            // 
            this.btnBorrarImagen.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrarImagen.Location = new System.Drawing.Point(528, 93);
            this.btnBorrarImagen.Margin = new System.Windows.Forms.Padding(2);
            this.btnBorrarImagen.Name = "btnBorrarImagen";
            this.btnBorrarImagen.Size = new System.Drawing.Size(62, 23);
            this.btnBorrarImagen.TabIndex = 22;
            this.btnBorrarImagen.Text = "Reset";
            this.btnBorrarImagen.UseVisualStyleBackColor = true;
            this.btnBorrarImagen.Click += new System.EventHandler(this.btnBorrarImagen_Click);
            // 
            // btnExaminar
            // 
            this.btnExaminar.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExaminar.Location = new System.Drawing.Point(528, 47);
            this.btnExaminar.Margin = new System.Windows.Forms.Padding(2);
            this.btnExaminar.Name = "btnExaminar";
            this.btnExaminar.Size = new System.Drawing.Size(63, 23);
            this.btnExaminar.TabIndex = 21;
            this.btnExaminar.Text = "Examinar";
            this.btnExaminar.UseVisualStyleBackColor = true;
            this.btnExaminar.Click += new System.EventHandler(this.btnExaminar_Click);
            // 
            // tURL
            // 
            this.tURL.Enabled = false;
            this.tURL.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tURL.Location = new System.Drawing.Point(411, 15);
            this.tURL.Margin = new System.Windows.Forms.Padding(2);
            this.tURL.Name = "tURL";
            this.tURL.Size = new System.Drawing.Size(180, 21);
            this.tURL.TabIndex = 17;
            // 
            // pictureBoxPerfil
            // 
            this.pictureBoxPerfil.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxPerfil.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxPerfil.Image")));
            this.pictureBoxPerfil.Location = new System.Drawing.Point(440, 45);
            this.pictureBoxPerfil.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxPerfil.Name = "pictureBoxPerfil";
            this.pictureBoxPerfil.Size = new System.Drawing.Size(76, 82);
            this.pictureBoxPerfil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPerfil.TabIndex = 16;
            this.pictureBoxPerfil.TabStop = false;
            // 
            // lblImagenPerfil
            // 
            this.lblImagenPerfil.AutoSize = true;
            this.lblImagenPerfil.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImagenPerfil.Location = new System.Drawing.Point(329, 17);
            this.lblImagenPerfil.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblImagenPerfil.Name = "lblImagenPerfil";
            this.lblImagenPerfil.Size = new System.Drawing.Size(78, 14);
            this.lblImagenPerfil.TabIndex = 15;
            this.lblImagenPerfil.Text = "Imagen Perfil:";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // RegistroONG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(651, 384);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelError);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "RegistroONG";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
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

        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tEmail;
        private System.Windows.Forms.TextBox tPassword;
        private System.Windows.Forms.Label labelError;
        private System.Windows.Forms.Label labelUsuario;
        private System.Windows.Forms.TextBox tUsuario;
        private System.Windows.Forms.DateTimePicker dateTimePickerFechNacimiento;
        private System.Windows.Forms.Label labelFechNacimiento;
        private System.Windows.Forms.TextBox tConfirmar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblNombreONG;
        private System.Windows.Forms.TextBox tNombreONG;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBoxPerfil;
        private System.Windows.Forms.Label lblImagenPerfil;
        private System.Windows.Forms.TextBox tURL;
        private System.Windows.Forms.Button btnExaminar;
        private System.Windows.Forms.Button btnBorrarImagen;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}