﻿namespace APS.Interfaces.Mensajes
{
    partial class NuevoMensaje
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NuevoMensaje));
            this.label1 = new System.Windows.Forms.Label();
            this.tReceptor = new System.Windows.Forms.TextBox();
            this.tAsunto = new System.Windows.Forms.TextBox();
            this.tTexto = new System.Windows.Forms.TextBox();
            this.bEnviar = new System.Windows.Forms.Button();
            this.lTexto = new System.Windows.Forms.Label();
            this.lDestino = new System.Windows.Forms.Label();
            this.lAsunto = new System.Windows.Forms.Label();
            this.bAtras = new System.Windows.Forms.Button();
            this.lExit = new System.Windows.Forms.Label();
            this.lEnviar = new System.Windows.Forms.Label();
            this.pictUtil = new System.Windows.Forms.PictureBox();
            this.lUtil = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictUtil)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(286, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 0;
            // 
            // tReceptor
            // 
            this.tReceptor.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tReceptor.Location = new System.Drawing.Point(90, 44);
            this.tReceptor.Name = "tReceptor";
            this.tReceptor.Size = new System.Drawing.Size(172, 24);
            this.tReceptor.TabIndex = 4;
            // 
            // tAsunto
            // 
            this.tAsunto.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tAsunto.Location = new System.Drawing.Point(89, 77);
            this.tAsunto.Name = "tAsunto";
            this.tAsunto.Size = new System.Drawing.Size(172, 24);
            this.tAsunto.TabIndex = 5;
            // 
            // tTexto
            // 
            this.tTexto.BackColor = System.Drawing.Color.White;
            this.tTexto.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tTexto.Location = new System.Drawing.Point(19, 132);
            this.tTexto.Multiline = true;
            this.tTexto.Name = "tTexto";
            this.tTexto.Size = new System.Drawing.Size(304, 129);
            this.tTexto.TabIndex = 6;
            // 
            // bEnviar
            // 
            this.bEnviar.BackColor = System.Drawing.Color.Transparent;
            this.bEnviar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bEnviar.BackgroundImage")));
            this.bEnviar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bEnviar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bEnviar.FlatAppearance.BorderSize = 0;
            this.bEnviar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bEnviar.Location = new System.Drawing.Point(84, 277);
            this.bEnviar.Name = "bEnviar";
            this.bEnviar.Size = new System.Drawing.Size(43, 43);
            this.bEnviar.TabIndex = 8;
            this.bEnviar.UseVisualStyleBackColor = false;
            this.bEnviar.Click += new System.EventHandler(this.bEnviar_Click);
            // 
            // lTexto
            // 
            this.lTexto.AutoSize = true;
            this.lTexto.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTexto.Location = new System.Drawing.Point(16, 114);
            this.lTexto.Name = "lTexto";
            this.lTexto.Size = new System.Drawing.Size(61, 17);
            this.lTexto.TabIndex = 11;
            this.lTexto.Text = "Mensaje";
            // 
            // lDestino
            // 
            this.lDestino.AutoSize = true;
            this.lDestino.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lDestino.Location = new System.Drawing.Point(33, 47);
            this.lDestino.Name = "lDestino";
            this.lDestino.Size = new System.Drawing.Size(62, 17);
            this.lDestino.TabIndex = 12;
            this.lDestino.Text = "Enviar a:";
            // 
            // lAsunto
            // 
            this.lAsunto.AutoSize = true;
            this.lAsunto.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lAsunto.Location = new System.Drawing.Point(39, 80);
            this.lAsunto.Name = "lAsunto";
            this.lAsunto.Size = new System.Drawing.Size(56, 17);
            this.lAsunto.TabIndex = 13;
            this.lAsunto.Text = "Asunto:";
            // 
            // bAtras
            // 
            this.bAtras.BackColor = System.Drawing.Color.Transparent;
            this.bAtras.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bAtras.BackgroundImage")));
            this.bAtras.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bAtras.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bAtras.FlatAppearance.BorderSize = 0;
            this.bAtras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bAtras.Location = new System.Drawing.Point(227, 267);
            this.bAtras.Name = "bAtras";
            this.bAtras.Size = new System.Drawing.Size(59, 63);
            this.bAtras.TabIndex = 9;
            this.bAtras.UseVisualStyleBackColor = false;
            this.bAtras.Click += new System.EventHandler(this.bAtras_Click);
            // 
            // lExit
            // 
            this.lExit.AutoSize = true;
            this.lExit.BackColor = System.Drawing.Color.Transparent;
            this.lExit.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lExit.Location = new System.Drawing.Point(242, 331);
            this.lExit.Name = "lExit";
            this.lExit.Size = new System.Drawing.Size(42, 17);
            this.lExit.TabIndex = 14;
            this.lExit.Text = "Atrás";
            // 
            // lEnviar
            // 
            this.lEnviar.AutoSize = true;
            this.lEnviar.BackColor = System.Drawing.Color.Transparent;
            this.lEnviar.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lEnviar.Location = new System.Drawing.Point(87, 331);
            this.lEnviar.Name = "lEnviar";
            this.lEnviar.Size = new System.Drawing.Size(48, 17);
            this.lEnviar.TabIndex = 15;
            this.lEnviar.Text = "Enviar";
            // 
            // pictUtil
            // 
            this.pictUtil.BackColor = System.Drawing.Color.Transparent;
            this.pictUtil.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictUtil.BackgroundImage")));
            this.pictUtil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictUtil.Location = new System.Drawing.Point(287, 25);
            this.pictUtil.Name = "pictUtil";
            this.pictUtil.Size = new System.Drawing.Size(40, 40);
            this.pictUtil.TabIndex = 16;
            this.pictUtil.TabStop = false;
            this.pictUtil.Click += new System.EventHandler(this.pictUtil_Click);
            // 
            // lUtil
            // 
            this.lUtil.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lUtil.Location = new System.Drawing.Point(282, 68);
            this.lUtil.Name = "lUtil";
            this.lUtil.Size = new System.Drawing.Size(51, 30);
            this.lUtil.TabIndex = 17;
            this.lUtil.Text = "Correos Útiles";
            this.lUtil.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NuevoMensaje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(345, 355);
            this.Controls.Add(this.lUtil);
            this.Controls.Add(this.pictUtil);
            this.Controls.Add(this.lEnviar);
            this.Controls.Add(this.lExit);
            this.Controls.Add(this.lAsunto);
            this.Controls.Add(this.lDestino);
            this.Controls.Add(this.lTexto);
            this.Controls.Add(this.bEnviar);
            this.Controls.Add(this.tTexto);
            this.Controls.Add(this.tAsunto);
            this.Controls.Add(this.tReceptor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bAtras);
            this.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NuevoMensaje";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Nuevo Mensaje";
            ((System.ComponentModel.ISupportInitialize)(this.pictUtil)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tReceptor;
        private System.Windows.Forms.TextBox tTexto;
        private System.Windows.Forms.Button bEnviar;
        private System.Windows.Forms.Button bAtras;
        private System.Windows.Forms.Label lTexto;
        private System.Windows.Forms.Label lDestino;
        private System.Windows.Forms.Label lAsunto;
        private System.Windows.Forms.Label lExit;
        private System.Windows.Forms.Label lEnviar;
        private System.Windows.Forms.PictureBox pictUtil;
        private System.Windows.Forms.Label lUtil;
        public System.Windows.Forms.TextBox tAsunto;
    }
}