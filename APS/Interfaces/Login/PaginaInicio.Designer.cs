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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PaginaInicio));
            this.bPersonalUMA = new System.Windows.Forms.Button();
            this.bPersonalExt = new System.Windows.Forms.Button();
            this.bExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.table = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // bPersonalUMA
            // 
            this.bPersonalUMA.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bPersonalUMA.BackgroundImage")));
            this.bPersonalUMA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bPersonalUMA.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bPersonalUMA.Location = new System.Drawing.Point(153, 51);
            this.bPersonalUMA.Margin = new System.Windows.Forms.Padding(4);
            this.bPersonalUMA.Name = "bPersonalUMA";
            this.bPersonalUMA.Size = new System.Drawing.Size(213, 182);
            this.bPersonalUMA.TabIndex = 7;
            this.bPersonalUMA.UseVisualStyleBackColor = true;
            this.bPersonalUMA.Click += new System.EventHandler(this.bPersonalUMA_Click);
            // 
            // bPersonalExt
            // 
            this.bPersonalExt.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bPersonalExt.BackgroundImage")));
            this.bPersonalExt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bPersonalExt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bPersonalExt.Location = new System.Drawing.Point(432, 51);
            this.bPersonalExt.Margin = new System.Windows.Forms.Padding(4);
            this.bPersonalExt.Name = "bPersonalExt";
            this.bPersonalExt.Size = new System.Drawing.Size(216, 182);
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
            this.bExit.Location = new System.Drawing.Point(709, 13);
            this.bExit.Margin = new System.Windows.Forms.Padding(4);
            this.bExit.Name = "bExit";
            this.bExit.Size = new System.Drawing.Size(67, 62);
            this.bExit.TabIndex = 9;
            this.bExit.UseVisualStyleBackColor = false;
            this.bExit.Click += new System.EventHandler(this.bExit_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(705, 67);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 34);
            this.label1.TabIndex = 10;
            this.label1.Text = "Cerrar Aplicación";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(99, 359);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(596, 155);
            this.panel1.TabIndex = 11;
            // 
            // timer1
            // 
            this.timer1.Interval = 3000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // table
            // 
            this.table.AutoSize = true;
            this.table.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.table.ColumnCount = 1;
            this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.table.Dock = System.Windows.Forms.DockStyle.Top;
            this.table.Location = new System.Drawing.Point(0, 0);
            this.table.Name = "table";
            this.table.RowCount = 1;
            this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.table.Size = new System.Drawing.Size(795, 0);
            this.table.TabIndex = 12;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox2.Location = new System.Drawing.Point(99, 262);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(596, 68);
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            // 
            // PaginaInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(795, 532);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.table);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bExit);
            this.Controls.Add(this.bPersonalExt);
            this.Controls.Add(this.bPersonalUMA);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(7, 4, 7, 4);
            this.Name = "PaginaInicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button bPersonalUMA;
        private System.Windows.Forms.Button bPersonalExt;
        private System.Windows.Forms.Button bExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TableLayoutPanel table;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}