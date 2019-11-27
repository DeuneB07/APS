namespace APS.Interfaces
{
    partial class PaginaPrincipalAlumno
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
            this.tabUser = new System.Windows.Forms.TabControl();
            this.pMatch = new System.Windows.Forms.TabPage();
            this.pTodas = new System.Windows.Forms.TabPage();
            this.pProyectos = new System.Windows.Forms.TabPage();
            this.pValoracion = new System.Windows.Forms.TabPage();
            this.lWelcome = new System.Windows.Forms.Label();
            this.pictureUser = new System.Windows.Forms.PictureBox();
            this.lPerfil = new System.Windows.Forms.Label();
            this.lMensajes = new System.Windows.Forms.Label();
            this.lHistorial = new System.Windows.Forms.Label();
            this.bLogout = new System.Windows.Forms.Button();
            this.tabUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureUser)).BeginInit();
            this.SuspendLayout();
            // 
            // tabUser
            // 
            this.tabUser.Controls.Add(this.pMatch);
            this.tabUser.Controls.Add(this.pTodas);
            this.tabUser.Controls.Add(this.pProyectos);
            this.tabUser.Controls.Add(this.pValoracion);
            this.tabUser.HotTrack = true;
            this.tabUser.Location = new System.Drawing.Point(43, 73);
            this.tabUser.Margin = new System.Windows.Forms.Padding(4);
            this.tabUser.Name = "tabUser";
            this.tabUser.SelectedIndex = 0;
            this.tabUser.Size = new System.Drawing.Size(839, 412);
            this.tabUser.TabIndex = 0;
            // 
            // pMatch
            //
                this.pMatch.Location = new System.Drawing.Point(4, 25);
                this.pMatch.Margin = new System.Windows.Forms.Padding(4);
                this.pMatch.Name = "pMatch";
                this.pMatch.Padding = new System.Windows.Forms.Padding(4);
                this.pMatch.Size = new System.Drawing.Size(831, 383);
                this.pMatch.TabIndex = 0;
                this.pMatch.Text = "Match";
                this.pMatch.UseVisualStyleBackColor = true;

            // 
            // pTodas
            // 

                this.pTodas.Location = new System.Drawing.Point(4, 25);
                this.pTodas.Margin = new System.Windows.Forms.Padding(4);
                this.pTodas.Name = "pTodas";
                this.pTodas.Padding = new System.Windows.Forms.Padding(4);
                this.pTodas.Size = new System.Drawing.Size(831, 383);
                this.pTodas.TabIndex = 1;
                this.pTodas.Text = "Todas";
                this.pTodas.UseVisualStyleBackColor = true;
                this.pTodas.Click += new System.EventHandler(this.pTodas_Click);
            
            // 
            // pProyectos
            //

                this.pProyectos.Location = new System.Drawing.Point(4, 25);
                this.pProyectos.Margin = new System.Windows.Forms.Padding(4);
                this.pProyectos.Name = "pProyectos";
                this.pProyectos.Padding = new System.Windows.Forms.Padding(4);
                this.pProyectos.Size = new System.Drawing.Size(831, 383);
                this.pProyectos.TabIndex = 2;
                this.pProyectos.Text = "Proyectos";

            // 
            // pValoracion
            // 

                this.pValoracion.Location = new System.Drawing.Point(4, 25);
                this.pValoracion.Margin = new System.Windows.Forms.Padding(4);
                this.pValoracion.Name = "pValoracion";
                this.pValoracion.Padding = new System.Windows.Forms.Padding(4);
                this.pValoracion.Size = new System.Drawing.Size(831, 383);
                this.pValoracion.TabIndex = 3;
                this.pValoracion.Text = "Valoración";
                this.pValoracion.UseVisualStyleBackColor = true;

            // 
            // lWelcome
            // 
            this.lWelcome.AutoSize = true;
            this.lWelcome.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lWelcome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lWelcome.Location = new System.Drawing.Point(61, 25);
            this.lWelcome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lWelcome.Name = "lWelcome";
            this.lWelcome.Size = new System.Drawing.Size(0, 29);
            this.lWelcome.TabIndex = 1;
            // 
            // pictureUser
            // 
            this.pictureUser.Location = new System.Drawing.Point(932, 15);
            this.pictureUser.Margin = new System.Windows.Forms.Padding(4);
            this.pictureUser.Name = "pictureUser";
            this.pictureUser.Size = new System.Drawing.Size(111, 96);
            this.pictureUser.TabIndex = 2;
            this.pictureUser.TabStop = false;
            // 
            // lPerfil
            // 
            this.lPerfil.AutoSize = true;
            this.lPerfil.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lPerfil.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lPerfil.Location = new System.Drawing.Point(953, 129);
            this.lPerfil.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lPerfil.Name = "lPerfil";
            this.lPerfil.Size = new System.Drawing.Size(54, 24);
            this.lPerfil.TabIndex = 3;
            this.lPerfil.Text = "Perfil";
            this.lPerfil.Click += new System.EventHandler(this.lPerfil_Click);
            // 
            // lMensajes
            // 
            this.lMensajes.AutoSize = true;
            this.lMensajes.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lMensajes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lMensajes.Location = new System.Drawing.Point(953, 176);
            this.lMensajes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lMensajes.Name = "lMensajes";
            this.lMensajes.Size = new System.Drawing.Size(90, 24);
            this.lMensajes.TabIndex = 4;
            this.lMensajes.Text = "Mensajes";
            // 
            // lHistorial
            // 
            this.lHistorial.AutoSize = true;
            this.lHistorial.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lHistorial.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lHistorial.Location = new System.Drawing.Point(953, 153);
            this.lHistorial.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lHistorial.Name = "lHistorial";
            this.lHistorial.Size = new System.Drawing.Size(82, 24);
            this.lHistorial.TabIndex = 5;
            this.lHistorial.Text = "Historial";
            // 
            // bLogout
            // 
            this.bLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bLogout.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.bLogout.FlatAppearance.BorderSize = 2;
            this.bLogout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.bLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bLogout.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bLogout.Location = new System.Drawing.Point(959, 203);
            this.bLogout.Margin = new System.Windows.Forms.Padding(4);
            this.bLogout.Name = "bLogout";
            this.bLogout.Size = new System.Drawing.Size(84, 65);
            this.bLogout.TabIndex = 6;
            this.bLogout.Text = "Cerrar Sesión";
            this.bLogout.UseVisualStyleBackColor = true;
            this.bLogout.Click += new System.EventHandler(this.bLogout_Click);
            // 
            // PaginaPrincipalAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.bLogout);
            this.Controls.Add(this.lHistorial);
            this.Controls.Add(this.lMensajes);
            this.Controls.Add(this.lPerfil);
            this.Controls.Add(this.pictureUser);
            this.Controls.Add(this.lWelcome);
            this.Controls.Add(this.tabUser);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PaginaPrincipalAlumno";
            this.Text = "Pagina Principal";
            this.tabUser.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabUser;
        private System.Windows.Forms.TabPage pMatch;
        private System.Windows.Forms.TabPage pTodas;
        private System.Windows.Forms.TabPage pProyectos;
        private System.Windows.Forms.TabPage pValoracion;
        private System.Windows.Forms.Label lWelcome;
        private System.Windows.Forms.PictureBox pictureUser;
        private System.Windows.Forms.Label lPerfil;
        private System.Windows.Forms.Label lMensajes;
        private System.Windows.Forms.Label lHistorial;
        private System.Windows.Forms.Button bLogout;
    }
}