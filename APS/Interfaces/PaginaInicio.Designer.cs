namespace APS.Interfaces
{
    partial class PaginaInicio
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
            this.bIniciar_PagIni = new System.Windows.Forms.Button();
            this.bRegistrar_PagIni = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.t_correoPagIni = new System.Windows.Forms.TextBox();
            this.t_pwdPagIni = new System.Windows.Forms.TextBox();
            this.labelError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bIniciar_PagIni
            // 
            this.bIniciar_PagIni.Location = new System.Drawing.Point(74, 183);
            this.bIniciar_PagIni.Margin = new System.Windows.Forms.Padding(2);
            this.bIniciar_PagIni.Name = "bIniciar_PagIni";
            this.bIniciar_PagIni.Size = new System.Drawing.Size(92, 24);
            this.bIniciar_PagIni.TabIndex = 0;
            this.bIniciar_PagIni.Text = "Iniciar Sesión";
            this.bIniciar_PagIni.UseVisualStyleBackColor = true;
            this.bIniciar_PagIni.Click += new System.EventHandler(this.bIniciar_PagIni_Click);
            // 
            // bRegistrar_PagIni
            // 
            this.bRegistrar_PagIni.Location = new System.Drawing.Point(296, 183);
            this.bRegistrar_PagIni.Margin = new System.Windows.Forms.Padding(2);
            this.bRegistrar_PagIni.Name = "bRegistrar_PagIni";
            this.bRegistrar_PagIni.Size = new System.Drawing.Size(92, 24);
            this.bRegistrar_PagIni.TabIndex = 1;
            this.bRegistrar_PagIni.Text = "Registrarse";
            this.bRegistrar_PagIni.UseVisualStyleBackColor = true;
            this.bRegistrar_PagIni.Click += new System.EventHandler(this.bRegistrar_PagIni_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 57);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Correo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 110);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Contraseña";
            // 
            // t_correoPagIni
            // 
            this.t_correoPagIni.Location = new System.Drawing.Point(134, 57);
            this.t_correoPagIni.Margin = new System.Windows.Forms.Padding(2);
            this.t_correoPagIni.Name = "t_correoPagIni";
            this.t_correoPagIni.Size = new System.Drawing.Size(257, 20);
            this.t_correoPagIni.TabIndex = 4;
            // 
            // t_pwdPagIni
            // 
            this.t_pwdPagIni.Location = new System.Drawing.Point(134, 110);
            this.t_pwdPagIni.Margin = new System.Windows.Forms.Padding(2);
            this.t_pwdPagIni.Name = "t_pwdPagIni";
            this.t_pwdPagIni.PasswordChar = '*';
            this.t_pwdPagIni.Size = new System.Drawing.Size(257, 20);
            this.t_pwdPagIni.TabIndex = 5;
            this.t_pwdPagIni.UseSystemPasswordChar = true;
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.BackColor = System.Drawing.Color.Transparent;
            this.labelError.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelError.ForeColor = System.Drawing.Color.Red;
            this.labelError.Location = new System.Drawing.Point(71, 218);
            this.labelError.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(33, 13);
            this.labelError.TabIndex = 6;
            this.labelError.Text = "error";
            // 
            // PaginaInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 268);
            this.Controls.Add(this.labelError);
            this.Controls.Add(this.t_pwdPagIni);
            this.Controls.Add(this.t_correoPagIni);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bRegistrar_PagIni);
            this.Controls.Add(this.bIniciar_PagIni);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "PaginaInicio";
            this.Text = "PaginaInicio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bIniciar_PagIni;
        private System.Windows.Forms.Button bRegistrar_PagIni;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox t_correoPagIni;
        private System.Windows.Forms.TextBox t_pwdPagIni;
        private System.Windows.Forms.Label labelError;
    }
}