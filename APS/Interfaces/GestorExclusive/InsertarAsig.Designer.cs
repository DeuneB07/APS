namespace APS.Interfaces.GestorExclusive
{
    partial class InsertarAsig
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InsertarAsig));
            this.panel1 = new System.Windows.Forms.Panel();
            this.tAsig = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictOK = new System.Windows.Forms.PictureBox();
            this.pictCancelar = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboGrado = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictOK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictCancelar)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.comboGrado);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictOK);
            this.panel1.Controls.Add(this.pictCancelar);
            this.panel1.Controls.Add(this.tAsig);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(3, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(436, 126);
            this.panel1.TabIndex = 3;
            // 
            // tAsig
            // 
            this.tAsig.Font = new System.Drawing.Font("Bahnschrift", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tAsig.Location = new System.Drawing.Point(36, 27);
            this.tAsig.Name = "tAsig";
            this.tAsig.Size = new System.Drawing.Size(375, 21);
            this.tAsig.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "Introduzca Asignatura";
            // 
            // pictOK
            // 
            this.pictOK.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictOK.BackgroundImage")));
            this.pictOK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictOK.Location = new System.Drawing.Point(367, 93);
            this.pictOK.Name = "pictOK";
            this.pictOK.Size = new System.Drawing.Size(30, 30);
            this.pictOK.TabIndex = 3;
            this.pictOK.TabStop = false;
            this.pictOK.Click += new System.EventHandler(this.pictOK_Click);
            // 
            // pictCancelar
            // 
            this.pictCancelar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictCancelar.BackgroundImage")));
            this.pictCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictCancelar.Location = new System.Drawing.Point(403, 93);
            this.pictCancelar.Name = "pictCancelar";
            this.pictCancelar.Size = new System.Drawing.Size(30, 30);
            this.pictCancelar.TabIndex = 2;
            this.pictCancelar.TabStop = false;
            this.pictCancelar.Click += new System.EventHandler(this.pictCancelar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 14);
            this.label2.TabIndex = 4;
            this.label2.Text = "Elija grado al que pertenece";
            // 
            // comboGrado
            // 
            this.comboGrado.FormattingEnabled = true;
            this.comboGrado.Location = new System.Drawing.Point(36, 78);
            this.comboGrado.Name = "comboGrado";
            this.comboGrado.Size = new System.Drawing.Size(325, 21);
            this.comboGrado.TabIndex = 5;
            // 
            // InsertarAsig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateBlue;
            this.ClientSize = new System.Drawing.Size(443, 157);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "InsertarAsig";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Insertar Asignatura";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictOK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictCancelar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictOK;
        private System.Windows.Forms.PictureBox pictCancelar;
        private System.Windows.Forms.TextBox tAsig;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboGrado;
        private System.Windows.Forms.Label label2;
    }
}