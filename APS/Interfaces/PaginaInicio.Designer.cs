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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PaginaInicio));
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
            this.bIniciar_PagIni.BackColor = System.Drawing.Color.LightCyan;
            this.bIniciar_PagIni.FlatAppearance.BorderSize = 0;
            this.bIniciar_PagIni.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bIniciar_PagIni.Location = new System.Drawing.Point(141, 207);
            this.bIniciar_PagIni.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.bIniciar_PagIni.Name = "bIniciar_PagIni";
            this.bIniciar_PagIni.Size = new System.Drawing.Size(139, 29);
            this.bIniciar_PagIni.TabIndex = 0;
            this.bIniciar_PagIni.Text = "Iniciar Sesión";
            this.bIniciar_PagIni.UseVisualStyleBackColor = false;
            this.bIniciar_PagIni.Click += new System.EventHandler(this.bIniciar_PagIni_Click);
            // 
            // bRegistrar_PagIni
            // 
            this.bRegistrar_PagIni.BackColor = System.Drawing.Color.LightCyan;
            this.bRegistrar_PagIni.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bRegistrar_PagIni.Location = new System.Drawing.Point(448, 207);
            this.bRegistrar_PagIni.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.bRegistrar_PagIni.Name = "bRegistrar_PagIni";
            this.bRegistrar_PagIni.Size = new System.Drawing.Size(139, 29);
            this.bRegistrar_PagIni.TabIndex = 1;
            this.bRegistrar_PagIni.Text = "Registrarse";
            this.bRegistrar_PagIni.UseVisualStyleBackColor = false;
            this.bRegistrar_PagIni.Click += new System.EventHandler(this.bRegistrar_PagIni_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(106, 70);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Correo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(74, 136);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Contraseña";
            // 
            // t_correoPagIni
            // 
            this.t_correoPagIni.ForeColor = System.Drawing.Color.ForestGreen;
            this.t_correoPagIni.Location = new System.Drawing.Point(203, 70);
            this.t_correoPagIni.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.t_correoPagIni.Name = "t_correoPagIni";
            this.t_correoPagIni.Size = new System.Drawing.Size(384, 23);
            this.t_correoPagIni.TabIndex = 4;
            // 
            // t_pwdPagIni
            // 
            this.t_pwdPagIni.Location = new System.Drawing.Point(203, 136);
            this.t_pwdPagIni.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.t_pwdPagIni.Name = "t_pwdPagIni";
            this.t_pwdPagIni.PasswordChar = '*';
            this.t_pwdPagIni.Size = new System.Drawing.Size(384, 23);
            this.t_pwdPagIni.TabIndex = 5;
            this.t_pwdPagIni.UseSystemPasswordChar = true;
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.BackColor = System.Drawing.Color.Transparent;
            this.labelError.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelError.ForeColor = System.Drawing.Color.Red;
            this.labelError.Location = new System.Drawing.Point(74, 36);
            this.labelError.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(44, 17);
            this.labelError.TabIndex = 6;
            this.labelError.Text = "error";
            // 
            // PaginaInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(668, 369);
            this.Controls.Add(this.labelError);
            this.Controls.Add(this.t_pwdPagIni);
            this.Controls.Add(this.t_correoPagIni);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bRegistrar_PagIni);
            this.Controls.Add(this.bIniciar_PagIni);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Verdana Pro Black", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.Name = "PaginaInicio";
            this.Text = "Página Inicio";
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