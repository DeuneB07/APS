namespace APS.Interfaces.GestorExclusive
{
    partial class InsertarNoticia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InsertarNoticia));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lTitular = new System.Windows.Forms.Label();
            this.textTitular = new System.Windows.Forms.TextBox();
            this.pictOK = new System.Windows.Forms.PictureBox();
            this.pictCancelar = new System.Windows.Forms.PictureBox();
            this.pict = new System.Windows.Forms.PictureBox();
            this.btnExaminar = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tURL = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictOK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictCancelar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pict)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnReset);
            this.panel1.Controls.Add(this.tURL);
            this.panel1.Controls.Add(this.btnExaminar);
            this.panel1.Controls.Add(this.pict);
            this.panel1.Controls.Add(this.pictOK);
            this.panel1.Controls.Add(this.pictCancelar);
            this.panel1.Controls.Add(this.textTitular);
            this.panel1.Controls.Add(this.lTitular);
            this.panel1.Location = new System.Drawing.Point(3, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(794, 114);
            this.panel1.TabIndex = 0;
            // 
            // lTitular
            // 
            this.lTitular.AutoSize = true;
            this.lTitular.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTitular.Location = new System.Drawing.Point(292, 11);
            this.lTitular.Name = "lTitular";
            this.lTitular.Size = new System.Drawing.Size(40, 13);
            this.lTitular.TabIndex = 0;
            this.lTitular.Text = "Titular:";
            // 
            // textTitular
            // 
            this.textTitular.Location = new System.Drawing.Point(338, 11);
            this.textTitular.Multiline = true;
            this.textTitular.Name = "textTitular";
            this.textTitular.Size = new System.Drawing.Size(452, 65);
            this.textTitular.TabIndex = 1;
            // 
            // pictOK
            // 
            this.pictOK.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictOK.BackgroundImage")));
            this.pictOK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictOK.Location = new System.Drawing.Point(724, 81);
            this.pictOK.Name = "pictOK";
            this.pictOK.Size = new System.Drawing.Size(30, 30);
            this.pictOK.TabIndex = 5;
            this.pictOK.TabStop = false;
            this.pictOK.Click += new System.EventHandler(this.pictOK_Click);
            // 
            // pictCancelar
            // 
            this.pictCancelar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictCancelar.BackgroundImage")));
            this.pictCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictCancelar.Location = new System.Drawing.Point(760, 81);
            this.pictCancelar.Name = "pictCancelar";
            this.pictCancelar.Size = new System.Drawing.Size(30, 30);
            this.pictCancelar.TabIndex = 4;
            this.pictCancelar.TabStop = false;
            this.pictCancelar.Click += new System.EventHandler(this.pictCancelar_Click);
            // 
            // pict
            // 
            this.pict.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pict.Image = global::APS.Properties.Resources.no_image;
            this.pict.Location = new System.Drawing.Point(3, 3);
            this.pict.Name = "pict";
            this.pict.Size = new System.Drawing.Size(160, 108);
            this.pict.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pict.TabIndex = 6;
            this.pict.TabStop = false;
            // 
            // btnExaminar
            // 
            this.btnExaminar.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExaminar.Location = new System.Drawing.Point(168, 4);
            this.btnExaminar.Margin = new System.Windows.Forms.Padding(2);
            this.btnExaminar.Name = "btnExaminar";
            this.btnExaminar.Size = new System.Drawing.Size(82, 20);
            this.btnExaminar.TabIndex = 29;
            this.btnExaminar.Text = "Examinar";
            this.btnExaminar.UseVisualStyleBackColor = true;
            this.btnExaminar.Click += new System.EventHandler(this.btnExaminar_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // tURL
            // 
            this.tURL.AutoSize = true;
            this.tURL.Location = new System.Drawing.Point(169, 26);
            this.tURL.Name = "tURL";
            this.tURL.Size = new System.Drawing.Size(0, 13);
            this.tURL.TabIndex = 30;
            this.tURL.Visible = false;
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(168, 28);
            this.btnReset.Margin = new System.Windows.Forms.Padding(2);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(82, 20);
            this.btnReset.TabIndex = 34;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // InsertarNoticia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Coral;
            this.ClientSize = new System.Drawing.Size(800, 141);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InsertarNoticia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Insertar Noticia";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictOK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictCancelar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pict)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textTitular;
        private System.Windows.Forms.Label lTitular;
        private System.Windows.Forms.PictureBox pictOK;
        private System.Windows.Forms.PictureBox pictCancelar;
        private System.Windows.Forms.PictureBox pict;
        private System.Windows.Forms.Button btnExaminar;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label tURL;
        private System.Windows.Forms.Button btnReset;
    }
}