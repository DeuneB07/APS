namespace APS.Interfaces.Perfil
{
    partial class BandejaMensajes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BandejaMensajes));
            this.lMensajes = new System.Windows.Forms.Label();
            this.panelMensajes = new System.Windows.Forms.TableLayoutPanel();
            this.lEscribir = new System.Windows.Forms.Label();
            this.lSend = new System.Windows.Forms.Label();
            this.lReceived = new System.Windows.Forms.Label();
            this.pictEnviados = new System.Windows.Forms.PictureBox();
            this.pictCont3 = new System.Windows.Forms.PictureBox();
            this.pictEscribir = new System.Windows.Forms.PictureBox();
            this.pictCont1 = new System.Windows.Forms.PictureBox();
            this.pictRecibidos = new System.Windows.Forms.PictureBox();
            this.pictSobres = new System.Windows.Forms.PictureBox();
            this.pictCont2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictEnviados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictCont3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictEscribir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictCont1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictRecibidos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictSobres)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictCont2)).BeginInit();
            this.SuspendLayout();
            // 
            // lMensajes
            // 
            this.lMensajes.AutoSize = true;
            this.lMensajes.BackColor = System.Drawing.Color.Transparent;
            this.lMensajes.Font = new System.Drawing.Font("Bahnschrift", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lMensajes.ForeColor = System.Drawing.Color.DarkMagenta;
            this.lMensajes.Location = new System.Drawing.Point(71, 12);
            this.lMensajes.Name = "lMensajes";
            this.lMensajes.Size = new System.Drawing.Size(128, 33);
            this.lMensajes.TabIndex = 0;
            this.lMensajes.Text = "Mensajes";
            // 
            // panelMensajes
            // 
            this.panelMensajes.BackColor = System.Drawing.Color.Transparent;
            this.panelMensajes.ColumnCount = 1;
            this.panelMensajes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panelMensajes.Location = new System.Drawing.Point(133, 65);
            this.panelMensajes.Name = "panelMensajes";
            this.panelMensajes.RowCount = 1;
            this.panelMensajes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panelMensajes.Size = new System.Drawing.Size(560, 273);
            this.panelMensajes.TabIndex = 20;
            // 
            // lEscribir
            // 
            this.lEscribir.AutoSize = true;
            this.lEscribir.BackColor = System.Drawing.Color.Transparent;
            this.lEscribir.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lEscribir.ForeColor = System.Drawing.Color.Black;
            this.lEscribir.Location = new System.Drawing.Point(37, 153);
            this.lEscribir.Name = "lEscribir";
            this.lEscribir.Size = new System.Drawing.Size(52, 13);
            this.lEscribir.TabIndex = 26;
            this.lEscribir.Text = "Redactar";
            // 
            // lSend
            // 
            this.lSend.AutoSize = true;
            this.lSend.BackColor = System.Drawing.Color.Transparent;
            this.lSend.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lSend.ForeColor = System.Drawing.Color.Black;
            this.lSend.Location = new System.Drawing.Point(26, 252);
            this.lSend.Name = "lSend";
            this.lSend.Size = new System.Drawing.Size(73, 13);
            this.lSend.TabIndex = 27;
            this.lSend.Text = "Ver Enviados";
            // 
            // lReceived
            // 
            this.lReceived.AutoSize = true;
            this.lReceived.BackColor = System.Drawing.Color.Transparent;
            this.lReceived.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lReceived.ForeColor = System.Drawing.Color.Black;
            this.lReceived.Location = new System.Drawing.Point(26, 341);
            this.lReceived.Name = "lReceived";
            this.lReceived.Size = new System.Drawing.Size(73, 13);
            this.lReceived.TabIndex = 30;
            this.lReceived.Text = "Ver Enviados";
            // 
            // pictEnviados
            // 
            this.pictEnviados.BackgroundImage = global::APS.Properties.Resources.received;
            this.pictEnviados.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictEnviados.Location = new System.Drawing.Point(44, 286);
            this.pictEnviados.Name = "pictEnviados";
            this.pictEnviados.Size = new System.Drawing.Size(37, 37);
            this.pictEnviados.TabIndex = 29;
            this.pictEnviados.TabStop = false;
            // 
            // pictCont3
            // 
            this.pictCont3.BackgroundImage = global::APS.Properties.Resources.newmessage;
            this.pictCont3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictCont3.Location = new System.Drawing.Point(27, 271);
            this.pictCont3.Controls.Add(pictRecibidos);
            this.pictCont3.Name = "pictCont3";
            this.pictCont3.Size = new System.Drawing.Size(68, 67);
            this.pictCont3.TabIndex = 28;
            this.pictCont3.TabStop = false;
            // 
            // pictEscribir
            // 
            this.pictEscribir.BackgroundImage = global::APS.Properties.Resources.escribir;
            this.pictEscribir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictEscribir.Location = new System.Drawing.Point(44, 101);
            this.pictEscribir.Name = "pictEscribir";
            this.pictEscribir.Size = new System.Drawing.Size(37, 33);
            this.pictEscribir.TabIndex = 24;
            this.pictEscribir.TabStop = false;
            // 
            // pictCont1
            // 
            this.pictCont1.BackgroundImage = global::APS.Properties.Resources.newmessage;
            this.pictCont1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictCont1.Location = new System.Drawing.Point(27, 83);
            this.pictCont1.Controls.Add(pictEscribir);
            this.pictCont1.Name = "pictCont1";
            this.pictCont1.Size = new System.Drawing.Size(68, 67);
            this.pictCont1.TabIndex = 22;
            this.pictCont1.TabStop = false;
            // 
            // pictRecibidos
            // 
            this.pictRecibidos.BackgroundImage = global::APS.Properties.Resources.enviados;
            this.pictRecibidos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictRecibidos.Location = new System.Drawing.Point(44, 203);
            this.pictRecibidos.Name = "pictRecibidos";
            this.pictRecibidos.Size = new System.Drawing.Size(37, 30);
            this.pictRecibidos.TabIndex = 25;
            this.pictRecibidos.TabStop = false;
            // 
            // pictSobres
            // 
            this.pictSobres.BackgroundImage = global::APS.Properties.Resources.sobres;
            this.pictSobres.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictSobres.Location = new System.Drawing.Point(12, 12);
            this.pictSobres.Name = "pictSobres";
            this.pictSobres.Size = new System.Drawing.Size(53, 50);
            this.pictSobres.TabIndex = 21;
            this.pictSobres.TabStop = false;
            // 
            // pictCont2
            // 
            this.pictCont2.BackgroundImage = global::APS.Properties.Resources.newmessage;
            this.pictCont2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictCont2.Location = new System.Drawing.Point(27, 182);
            this.pictCont2.Controls.Add(pictEnviados);
            this.pictCont2.Name = "pictCont2";
            this.pictCont2.Size = new System.Drawing.Size(68, 67);
            this.pictCont2.TabIndex = 24;
            this.pictCont2.TabStop = false;
            // 
            // BandejaMensajes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(705, 378);
            this.Controls.Add(this.lReceived);
            this.Controls.Add(this.pictEnviados);
            this.Controls.Add(this.pictCont3);
            this.Controls.Add(this.lSend);
            this.Controls.Add(this.lEscribir);
            this.Controls.Add(this.pictEscribir);
            this.Controls.Add(this.pictCont1);
            this.Controls.Add(this.pictRecibidos);
            this.Controls.Add(this.pictSobres);
            this.Controls.Add(this.panelMensajes);
            this.Controls.Add(this.lMensajes);
            this.Controls.Add(this.pictCont2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BandejaMensajes";
            this.Text = "Bandeja de Entrada";
            ((System.ComponentModel.ISupportInitialize)(this.pictEnviados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictCont3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictEscribir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictCont1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictRecibidos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictSobres)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictCont2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lMensajes;
        private System.Windows.Forms.TableLayoutPanel panelMensajes;
        private System.Windows.Forms.PictureBox pictSobres;
        private System.Windows.Forms.PictureBox pictCont2;
        private System.Windows.Forms.PictureBox pictRecibidos;
        private System.Windows.Forms.PictureBox pictCont1;
        private System.Windows.Forms.PictureBox pictEscribir;
        private System.Windows.Forms.Label lEscribir;
        private System.Windows.Forms.Label lSend;
        private System.Windows.Forms.Label lReceived;
        private System.Windows.Forms.PictureBox pictEnviados;
        private System.Windows.Forms.PictureBox pictCont3;
    }
}