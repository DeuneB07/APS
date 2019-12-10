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
            this.labelDNI = new System.Windows.Forms.Label();
            this.tDNI = new System.Windows.Forms.TextBox();
            this.dateTimePickerFechNacimiento = new System.Windows.Forms.DateTimePicker();
            this.labelFechNacimiento = new System.Windows.Forms.Label();
            this.tConfirmar = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(449, 292);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(83, 28);
            this.btnAceptar.TabIndex = 0;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.b_aceptarReg_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(557, 292);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(83, 28);
            this.btnCancelar.TabIndex = 2;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.b_cancelarReg_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(137, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Correo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(107, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Contraseña";
            // 
            // tEmail
            // 
            this.tEmail.Location = new System.Drawing.Point(213, 44);
            this.tEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tEmail.Name = "tEmail";
            this.tEmail.Size = new System.Drawing.Size(369, 22);
            this.tEmail.TabIndex = 5;
            // 
            // tPassword
            // 
            this.tPassword.Location = new System.Drawing.Point(213, 89);
            this.tPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tPassword.Name = "tPassword";
            this.tPassword.PasswordChar = '*';
            this.tPassword.Size = new System.Drawing.Size(369, 22);
            this.tPassword.TabIndex = 6;
            this.tPassword.UseSystemPasswordChar = true;
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.BackColor = System.Drawing.Color.Transparent;
            this.labelError.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelError.ForeColor = System.Drawing.Color.Red;
            this.labelError.Location = new System.Drawing.Point(127, 298);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(44, 17);
            this.labelError.TabIndex = 8;
            this.labelError.Text = "error";
            // 
            // labelUsuario
            // 
            this.labelUsuario.AutoSize = true;
            this.labelUsuario.Location = new System.Drawing.Point(73, 184);
            this.labelUsuario.Name = "labelUsuario";
            this.labelUsuario.Size = new System.Drawing.Size(115, 17);
            this.labelUsuario.TabIndex = 9;
            this.labelUsuario.Text = "Nombre Usuario:";
            // 
            // tUsuario
            // 
            this.tUsuario.Location = new System.Drawing.Point(213, 184);
            this.tUsuario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tUsuario.Name = "tUsuario";
            this.tUsuario.Size = new System.Drawing.Size(101, 22);
            this.tUsuario.TabIndex = 10;
            // 
            // labelDNI
            // 
            this.labelDNI.AutoSize = true;
            this.labelDNI.Location = new System.Drawing.Point(127, 227);
            this.labelDNI.Name = "labelDNI";
            this.labelDNI.Size = new System.Drawing.Size(61, 17);
            this.labelDNI.TabIndex = 11;
            this.labelDNI.Text = "DNI/NIE:";
            // 
            // tDNI
            // 
            this.tDNI.Location = new System.Drawing.Point(213, 227);
            this.tDNI.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tDNI.Name = "tDNI";
            this.tDNI.Size = new System.Drawing.Size(101, 22);
            this.tDNI.TabIndex = 12;
            // 
            // dateTimePickerFechNacimiento
            // 
            this.dateTimePickerFechNacimiento.Location = new System.Drawing.Point(460, 182);
            this.dateTimePickerFechNacimiento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePickerFechNacimiento.Name = "dateTimePickerFechNacimiento";
            this.dateTimePickerFechNacimiento.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerFechNacimiento.TabIndex = 13;
            // 
            // labelFechNacimiento
            // 
            this.labelFechNacimiento.AutoSize = true;
            this.labelFechNacimiento.Location = new System.Drawing.Point(329, 184);
            this.labelFechNacimiento.Name = "labelFechNacimiento";
            this.labelFechNacimiento.Size = new System.Drawing.Size(125, 17);
            this.labelFechNacimiento.TabIndex = 14;
            this.labelFechNacimiento.Text = "Fecha Nacimiento:";
            // 
            // tConfirmar
            // 
            this.tConfirmar.Location = new System.Drawing.Point(213, 133);
            this.tConfirmar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tConfirmar.Name = "tConfirmar";
            this.tConfirmar.PasswordChar = '*';
            this.tConfirmar.Size = new System.Drawing.Size(369, 22);
            this.tConfirmar.TabIndex = 15;
            this.tConfirmar.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 17);
            this.label3.TabIndex = 16;
            this.label3.Text = "Confirmar Contraseña";
            // 
            // RegistroONG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 346);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tConfirmar);
            this.Controls.Add(this.labelFechNacimiento);
            this.Controls.Add(this.dateTimePickerFechNacimiento);
            this.Controls.Add(this.tDNI);
            this.Controls.Add(this.labelDNI);
            this.Controls.Add(this.tUsuario);
            this.Controls.Add(this.labelUsuario);
            this.Controls.Add(this.labelError);
            this.Controls.Add(this.tPassword);
            this.Controls.Add(this.tEmail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "RegistroONG";
            this.Text = "Registro";
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
        private System.Windows.Forms.Label labelDNI;
        private System.Windows.Forms.TextBox tDNI;
        private System.Windows.Forms.DateTimePicker dateTimePickerFechNacimiento;
        private System.Windows.Forms.Label labelFechNacimiento;
        private System.Windows.Forms.TextBox tConfirmar;
        private System.Windows.Forms.Label label3;
    }
}