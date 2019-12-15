namespace APS.Interfaces
{
    partial class LoadingPagPrinc
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
            this.gif = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.gif)).BeginInit();
            this.SuspendLayout();
            // 
            // gif
            // 
            this.gif.BackColor = System.Drawing.Color.White;
            this.gif.Image = global::APS.Properties.Resources.Loading_2;
            this.gif.Location = new System.Drawing.Point(62, 31);
            this.gif.Name = "gif";
            this.gif.Size = new System.Drawing.Size(217, 202);
            this.gif.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gif.TabIndex = 1;
            this.gif.TabStop = false;
            // 
            // LoadingPagPrinc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(357, 284);
            this.ControlBox = false;
            this.Controls.Add(this.gif);
            this.Name = "LoadingPagPrinc";
            this.Opacity = 0.6D;
            this.ShowIcon = false;
            ((System.ComponentModel.ISupportInitialize)(this.gif)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox gif;
    }
}