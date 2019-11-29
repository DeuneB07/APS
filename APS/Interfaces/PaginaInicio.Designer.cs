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
            this.labelError = new System.Windows.Forms.Label();
            this.bPersonalUMA = new System.Windows.Forms.Button();
            this.bPersonalExt = new System.Windows.Forms.Button();
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
            // bPersonalUMA
            // 
            this.bPersonalUMA.Location = new System.Drawing.Point(109, 67);
            this.bPersonalUMA.Name = "bPersonalUMA";
            this.bPersonalUMA.Size = new System.Drawing.Size(205, 121);
            this.bPersonalUMA.TabIndex = 7;
            this.bPersonalUMA.Text = "PERSONAL UMA";
            this.bPersonalUMA.UseVisualStyleBackColor = true;
            this.bPersonalUMA.Click += new System.EventHandler(this.bPersonalUMA_Click);
            // 
            // bPersonalExt
            // 
            this.bPersonalExt.Location = new System.Drawing.Point(398, 67);
            this.bPersonalExt.Name = "bPersonalExt";
            this.bPersonalExt.Size = new System.Drawing.Size(205, 121);
            this.bPersonalExt.TabIndex = 8;
            this.bPersonalExt.Text = "PERSONAL EXTERNO";
            this.bPersonalExt.UseVisualStyleBackColor = true;
            // 
            // PaginaInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(668, 369);
            this.Controls.Add(this.bPersonalExt);
            this.Controls.Add(this.bPersonalUMA);
            this.Controls.Add(this.labelError);
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
        private System.Windows.Forms.Label labelError;
        private System.Windows.Forms.Button bPersonalUMA;
        private System.Windows.Forms.Button bPersonalExt;
    }
}