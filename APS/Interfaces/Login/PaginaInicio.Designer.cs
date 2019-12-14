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
            this.bPersonalUMA = new System.Windows.Forms.Button();
            this.bPersonalExt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bPersonalUMA
            // 
            this.bPersonalUMA.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bPersonalUMA.BackgroundImage")));
            this.bPersonalUMA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bPersonalUMA.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bPersonalUMA.Location = new System.Drawing.Point(147, 64);
            this.bPersonalUMA.Name = "bPersonalUMA";
            this.bPersonalUMA.Size = new System.Drawing.Size(160, 148);
            this.bPersonalUMA.TabIndex = 7;
            this.bPersonalUMA.UseVisualStyleBackColor = true;
            this.bPersonalUMA.Click += new System.EventHandler(this.bPersonalUMA_Click);
            // 
            // bPersonalExt
            // 
            this.bPersonalExt.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bPersonalExt.BackgroundImage")));
            this.bPersonalExt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bPersonalExt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bPersonalExt.Location = new System.Drawing.Point(379, 64);
            this.bPersonalExt.Name = "bPersonalExt";
            this.bPersonalExt.Size = new System.Drawing.Size(162, 148);
            this.bPersonalExt.TabIndex = 8;
            this.bPersonalExt.UseVisualStyleBackColor = true;
            this.bPersonalExt.Click += new System.EventHandler(this.bPersonalExt_Click);
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
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Verdana Pro Black", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.Name = "PaginaInicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Página Inicio";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button bPersonalUMA;
        private System.Windows.Forms.Button bPersonalExt;
    }
}