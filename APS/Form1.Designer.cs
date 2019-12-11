namespace APS
{
    partial class Form1
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnExaminar = new System.Windows.Forms.Button();
            this.btnCargarExaminar = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnArray = new System.Windows.Forms.Button();
            this.btnCargarArray = new System.Windows.Forms.Button();
            this.btnCargarString = new System.Windows.Forms.Button();
            this.textFile = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(69, 34);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(222, 205);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(450, 34);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(222, 205);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // btnExaminar
            // 
            this.btnExaminar.Location = new System.Drawing.Point(93, 307);
            this.btnExaminar.Name = "btnExaminar";
            this.btnExaminar.Size = new System.Drawing.Size(164, 72);
            this.btnExaminar.TabIndex = 2;
            this.btnExaminar.Text = "Examinar";
            this.btnExaminar.UseVisualStyleBackColor = true;
            this.btnExaminar.Click += new System.EventHandler(this.btnExaminar_Click);
            // 
            // btnCargarExaminar
            // 
            this.btnCargarExaminar.Location = new System.Drawing.Point(495, 307);
            this.btnCargarExaminar.Name = "btnCargarExaminar";
            this.btnCargarExaminar.Size = new System.Drawing.Size(140, 45);
            this.btnCargarExaminar.TabIndex = 3;
            this.btnCargarExaminar.Text = "Cargar Examinar";
            this.btnCargarExaminar.UseVisualStyleBackColor = true;
            this.btnCargarExaminar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnArray
            // 
            this.btnArray.Location = new System.Drawing.Point(301, 329);
            this.btnArray.Name = "btnArray";
            this.btnArray.Size = new System.Drawing.Size(116, 50);
            this.btnArray.TabIndex = 4;
            this.btnArray.Text = "ToArray";
            this.btnArray.UseVisualStyleBackColor = true;
            this.btnArray.Click += new System.EventHandler(this.btnArray_Click);
            // 
            // btnCargarArray
            // 
            this.btnCargarArray.Location = new System.Drawing.Point(495, 358);
            this.btnCargarArray.Name = "btnCargarArray";
            this.btnCargarArray.Size = new System.Drawing.Size(140, 45);
            this.btnCargarArray.TabIndex = 5;
            this.btnCargarArray.Text = "Cargar Array";
            this.btnCargarArray.UseVisualStyleBackColor = true;
            this.btnCargarArray.Click += new System.EventHandler(this.btnCargarArray_Click);
            // 
            // btnCargarString
            // 
            this.btnCargarString.Location = new System.Drawing.Point(648, 307);
            this.btnCargarString.Name = "btnCargarString";
            this.btnCargarString.Size = new System.Drawing.Size(140, 45);
            this.btnCargarString.TabIndex = 6;
            this.btnCargarString.Text = "Cargar String";
            this.btnCargarString.UseVisualStyleBackColor = true;
            this.btnCargarString.Click += new System.EventHandler(this.btnCargarString_Click);
            // 
            // textFile
            // 
            this.textFile.Location = new System.Drawing.Point(69, 279);
            this.textFile.Name = "textFile";
            this.textFile.Size = new System.Drawing.Size(222, 22);
            this.textFile.TabIndex = 7;
            this.textFile.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(450, 252);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(222, 22);
            this.textBox2.TabIndex = 8;
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(69, 251);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(222, 22);
            this.textName.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textFile);
            this.Controls.Add(this.btnCargarString);
            this.Controls.Add(this.btnCargarArray);
            this.Controls.Add(this.btnArray);
            this.Controls.Add(this.btnCargarExaminar);
            this.Controls.Add(this.btnExaminar);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnExaminar;
        private System.Windows.Forms.Button btnCargarExaminar;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnArray;
        private System.Windows.Forms.Button btnCargarArray;
        private System.Windows.Forms.Button btnCargarString;
        private System.Windows.Forms.TextBox textFile;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textName;
    }
}