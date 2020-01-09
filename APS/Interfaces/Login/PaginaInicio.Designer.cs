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
            this.bExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
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
            // bExit
            // 
            this.bExit.BackColor = System.Drawing.Color.Transparent;
            this.bExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bExit.BackgroundImage")));
            this.bExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bExit.FlatAppearance.BorderSize = 0;
            this.bExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bExit.Location = new System.Drawing.Point(634, 12);
            this.bExit.Name = "bExit";
            this.bExit.Size = new System.Drawing.Size(50, 50);
            this.bExit.TabIndex = 9;
            this.bExit.UseVisualStyleBackColor = false;
            this.bExit.Click += new System.EventHandler(this.bExit_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(631, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 28);
            this.label1.TabIndex = 10;
            this.label1.Text = "Cerrar Aplicación";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PaginaInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(696, 358);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bExit);
            this.Controls.Add(this.bPersonalExt);
            this.Controls.Add(this.bPersonalUMA);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
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
        private System.Windows.Forms.Button bExit;
        private System.Windows.Forms.Label label1;
    }
}