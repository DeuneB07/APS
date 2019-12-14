namespace APS.Interfaces
{
    partial class InicioPersExterno
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InicioPersExterno));
            this.bRegistrar = new System.Windows.Forms.Button();
            this.bIniciar = new System.Windows.Forms.Button();
            this.labelError = new System.Windows.Forms.Label();
            this.labelCorreo = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.tCorreo = new System.Windows.Forms.TextBox();
            this.tPassword = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // bRegistrar
            // 
            this.bRegistrar.BackColor = System.Drawing.Color.LightCyan;
            this.bRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bRegistrar.Location = new System.Drawing.Point(322, 197);
            this.bRegistrar.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.bRegistrar.Name = "bRegistrar";
            this.bRegistrar.Size = new System.Drawing.Size(156, 29);
            this.bRegistrar.TabIndex = 3;
            this.bRegistrar.Text = "Registrarse";
            this.bRegistrar.UseVisualStyleBackColor = false;
            this.bRegistrar.Click += new System.EventHandler(this.bRegistrar_Click);
            // 
            // bIniciar
            // 
            this.bIniciar.BackColor = System.Drawing.Color.LightCyan;
            this.bIniciar.FlatAppearance.BorderSize = 0;
            this.bIniciar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bIniciar.Location = new System.Drawing.Point(150, 197);
            this.bIniciar.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.bIniciar.Name = "bIniciar";
            this.bIniciar.Size = new System.Drawing.Size(156, 29);
            this.bIniciar.TabIndex = 2;
            this.bIniciar.Text = "Iniciar Sesión";
            this.bIniciar.UseVisualStyleBackColor = false;
            this.bIniciar.Click += new System.EventHandler(this.bIniciar_Click);
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.BackColor = System.Drawing.Color.Transparent;
            this.labelError.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelError.ForeColor = System.Drawing.Color.Red;
            this.labelError.Location = new System.Drawing.Point(147, 61);
            this.labelError.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(44, 17);
            this.labelError.TabIndex = 7;
            this.labelError.Text = "error";
            // 
            // labelCorreo
            // 
            this.labelCorreo.AutoSize = true;
            this.labelCorreo.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCorreo.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelCorreo.Location = new System.Drawing.Point(69, 90);
            this.labelCorreo.Name = "labelCorreo";
            this.labelCorreo.Size = new System.Drawing.Size(66, 20);
            this.labelCorreo.TabIndex = 8;
            this.labelCorreo.Text = "Correo:";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPassword.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelPassword.Location = new System.Drawing.Point(35, 140);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(100, 20);
            this.labelPassword.TabIndex = 9;
            this.labelPassword.Text = "Contraseña:";
            // 
            // tCorreo
            // 
            this.tCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tCorreo.Location = new System.Drawing.Point(150, 90);
            this.tCorreo.Name = "tCorreo";
            this.tCorreo.Size = new System.Drawing.Size(328, 27);
            this.tCorreo.TabIndex = 10;
            // 
            // tPassword
            // 
            this.tPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tPassword.Location = new System.Drawing.Point(150, 137);
            this.tPassword.Name = "tPassword";
            this.tPassword.PasswordChar = '●';
            this.tPassword.Size = new System.Drawing.Size(328, 27);
            this.tPassword.TabIndex = 11;
            // 
            // InicioPersExterno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(571, 354);
            this.Controls.Add(this.tPassword);
            this.Controls.Add(this.tCorreo);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelCorreo);
            this.Controls.Add(this.labelError);
            this.Controls.Add(this.bRegistrar);
            this.Controls.Add(this.bIniciar);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "InicioPersExterno";
            this.Text = "Personal Externo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bRegistrar;
        private System.Windows.Forms.Button bIniciar;
        private System.Windows.Forms.Label labelError;
        private System.Windows.Forms.Label labelCorreo;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.TextBox tCorreo;
        private System.Windows.Forms.TextBox tPassword;
    }
}