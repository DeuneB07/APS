namespace APS.Interfaces.GestorExclusive
{
    partial class InsertarTipoTrab
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InsertarTipoTrab));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictCancelar = new System.Windows.Forms.PictureBox();
            this.pictOK = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictCancelar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictOK)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.pictOK);
            this.panel1.Controls.Add(this.pictCancelar);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(2, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(341, 79);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "Introduzca Nombre del Nuevo Tipo de Trabajo";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Bahnschrift", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(32, 39);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(200, 21);
            this.textBox1.TabIndex = 1;
            // 
            // pictCancelar
            // 
            this.pictCancelar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictCancelar.BackgroundImage")));
            this.pictCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictCancelar.Location = new System.Drawing.Point(308, 46);
            this.pictCancelar.Name = "pictCancelar";
            this.pictCancelar.Size = new System.Drawing.Size(30, 30);
            this.pictCancelar.TabIndex = 2;
            this.pictCancelar.TabStop = false;
            this.pictCancelar.Click += new System.EventHandler(this.pictCancelar_Click);
            // 
            // pictOK
            // 
            this.pictOK.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictOK.BackgroundImage")));
            this.pictOK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictOK.Location = new System.Drawing.Point(272, 46);
            this.pictOK.Name = "pictOK";
            this.pictOK.Size = new System.Drawing.Size(30, 30);
            this.pictOK.TabIndex = 3;
            this.pictOK.TabStop = false;
            this.pictOK.Click += new System.EventHandler(this.pictOK_Click);
            // 
            // InsertarTipoTrab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.YellowGreen;
            this.ClientSize = new System.Drawing.Size(347, 99);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "InsertarTipoTrab";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Nuevo Tipo de Trabajo";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictCancelar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictOK)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictOK;
        private System.Windows.Forms.PictureBox pictCancelar;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
    }
}