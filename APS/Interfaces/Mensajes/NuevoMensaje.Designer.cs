namespace APS.Interfaces.Mensajes
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
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(572, 198);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 25);
            this.label1.TabIndex = 0;
            // 
            // tReceptor
            // 
            this.tReceptor.Location = new System.Drawing.Point(241, 88);
            this.tReceptor.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tReceptor.Name = "tReceptor";
            this.tReceptor.Size = new System.Drawing.Size(340, 31);
            this.tReceptor.TabIndex = 4;
            // 
            // tAsunto
            // 
            this.tAsunto.Location = new System.Drawing.Point(239, 153);
            this.tAsunto.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tAsunto.Name = "tAsunto";
            this.tAsunto.Size = new System.Drawing.Size(340, 31);
            this.tAsunto.TabIndex = 5;
            // 
            // tTexto
            // 
            this.tTexto.BackColor = System.Drawing.Color.White;
            this.tTexto.Location = new System.Drawing.Point(38, 254);
            this.tTexto.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tTexto.Multiline = true;
            this.tTexto.Name = "tTexto";
            this.tTexto.Size = new System.Drawing.Size(604, 244);
            this.tTexto.TabIndex = 6;
            // 
            // bEnviar
            // 
            this.bEnviar.BackColor = System.Drawing.Color.Transparent;
            this.bEnviar.BackgroundImage = global::APS.Properties.Resources.escribir;
            this.bEnviar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bEnviar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bEnviar.FlatAppearance.BorderSize = 0;
            this.bEnviar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bEnviar.Location = new System.Drawing.Point(168, 532);
            this.bEnviar.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.bEnviar.Name = "bEnviar";
            this.bEnviar.Size = new System.Drawing.Size(86, 83);
            this.bEnviar.TabIndex = 8;
            this.bEnviar.UseVisualStyleBackColor = false;
            this.bEnviar.Click += new System.EventHandler(this.bEnviar_Click);
            // 
            // lTexto
            // 
            this.lTexto.AutoSize = true;
            this.lTexto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTexto.Location = new System.Drawing.Point(32, 219);
            this.lTexto.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lTexto.Name = "lTexto";
            this.lTexto.Size = new System.Drawing.Size(101, 26);
            this.lTexto.TabIndex = 11;
            this.lTexto.Text = "Mensaje";
            // 
            // lDestino
            // 
            this.lDestino.AutoSize = true;
            this.lDestino.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lDestino.Location = new System.Drawing.Point(122, 90);
            this.lDestino.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lDestino.Name = "lDestino";
            this.lDestino.Size = new System.Drawing.Size(107, 26);
            this.lDestino.TabIndex = 12;
            this.lDestino.Text = "Enviar a:";
            // 
            // lAsunto
            // 
            this.lAsunto.AutoSize = true;
            this.lAsunto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lAsunto.Location = new System.Drawing.Point(134, 153);
            this.lAsunto.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lAsunto.Name = "lAsunto";
            this.lAsunto.Size = new System.Drawing.Size(93, 26);
            this.lAsunto.TabIndex = 13;
            this.lAsunto.Text = "Asunto:";
            // 
            // bAtras
            // 
            this.bAtras.BackColor = System.Drawing.Color.Transparent;
            this.bAtras.BackgroundImage = global::APS.Properties.Resources.exiticon;
            this.bAtras.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bAtras.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bAtras.FlatAppearance.BorderSize = 0;
            this.bAtras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bAtras.Location = new System.Drawing.Point(454, 513);
            this.bAtras.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.bAtras.Name = "bAtras";
            this.bAtras.Size = new System.Drawing.Size(118, 121);
            this.bAtras.TabIndex = 9;
            this.bAtras.UseVisualStyleBackColor = false;
            this.bAtras.Click += new System.EventHandler(this.bAtras_Click);
            // 
            // lExit
            // 
            this.lExit.AutoSize = true;
            this.lExit.BackColor = System.Drawing.Color.Transparent;
            this.lExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lExit.Location = new System.Drawing.Point(484, 637);
            this.lExit.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lExit.Name = "lExit";
            this.lExit.Size = new System.Drawing.Size(68, 26);
            this.lExit.TabIndex = 14;
            this.lExit.Text = "Atrás";
            // 
            // lEnviar
            // 
            this.lEnviar.AutoSize = true;
            this.lEnviar.BackColor = System.Drawing.Color.Transparent;
            this.lEnviar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lEnviar.Location = new System.Drawing.Point(174, 637);
            this.lEnviar.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lEnviar.Name = "lEnviar";
            this.lEnviar.Size = new System.Drawing.Size(80, 26);
            this.lEnviar.TabIndex = 15;
            this.lEnviar.Text = "Enviar";
            // 
            // NuevoMensaje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(680, 683);
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "NuevoMensaje";
            this.Text = "Nuevo Mensaje";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tReceptor;
        private System.Windows.Forms.TextBox tAsunto;
        private System.Windows.Forms.TextBox tTexto;
        private System.Windows.Forms.Button bEnviar;
        private System.Windows.Forms.Button bAtras;
        private System.Windows.Forms.Label lTexto;
        private System.Windows.Forms.Label lDestino;
        private System.Windows.Forms.Label lAsunto;
        private System.Windows.Forms.Label lExit;
        private System.Windows.Forms.Label lEnviar;
    }
}