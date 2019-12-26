namespace APS.Interfaces.GestorExclusive
{
    partial class InsertarCompetencia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InsertarCompetencia));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictOK = new System.Windows.Forms.PictureBox();
            this.pictCancelar = new System.Windows.Forms.PictureBox();
            this.tNoun = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tDesc = new System.Windows.Forms.RichTextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictOK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictCancelar)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.tDesc);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictOK);
            this.panel1.Controls.Add(this.pictCancelar);
            this.panel1.Controls.Add(this.tNoun);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(3, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(559, 148);
            this.panel1.TabIndex = 2;
            // 
            // pictOK
            // 
            this.pictOK.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictOK.BackgroundImage")));
            this.pictOK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictOK.Location = new System.Drawing.Point(490, 115);
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
            this.pictCancelar.Location = new System.Drawing.Point(526, 115);
            this.pictCancelar.Name = "pictCancelar";
            this.pictCancelar.Size = new System.Drawing.Size(30, 30);
            this.pictCancelar.TabIndex = 2;
            this.pictCancelar.TabStop = false;
            this.pictCancelar.Click += new System.EventHandler(this.pictCancelar_Click);
            // 
            // tNoun
            // 
            this.tNoun.Font = new System.Drawing.Font("Bahnschrift", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tNoun.Location = new System.Drawing.Point(218, 8);
            this.tNoun.Name = "tNoun";
            this.tNoun.Size = new System.Drawing.Size(335, 21);
            this.tNoun.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "Introduzca Nombre de Competencia";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 14);
            this.label2.TabIndex = 4;
            this.label2.Text = "Descripción";
            // 
            // tDesc
            // 
            this.tDesc.Enabled = false;
            this.tDesc.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tDesc.Location = new System.Drawing.Point(44, 65);
            this.tDesc.Margin = new System.Windows.Forms.Padding(2);
            this.tDesc.Name = "tDesc";
            this.tDesc.Size = new System.Drawing.Size(430, 69);
            this.tDesc.TabIndex = 66;
            this.tDesc.Text = "";
            // 
            // InsertarCompetencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSalmon;
            this.ClientSize = new System.Drawing.Size(568, 180);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "InsertarCompetencia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Insertar Competencia";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictOK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictCancelar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictOK;
        private System.Windows.Forms.PictureBox pictCancelar;
        private System.Windows.Forms.TextBox tNoun;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox tDesc;
    }
}