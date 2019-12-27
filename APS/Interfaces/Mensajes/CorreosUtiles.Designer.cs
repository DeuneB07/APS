namespace APS.Interfaces.Mensajes
{
    partial class CorreosUtiles
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CorreosUtiles));
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboRol = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listUtil = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictExit = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictExit)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.pictExit);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.listUtil);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.comboRol);
            this.panel1.Location = new System.Drawing.Point(4, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(446, 182);
            this.panel1.TabIndex = 0;
            // 
            // comboRol
            // 
            this.comboRol.FormattingEnabled = true;
            this.comboRol.Location = new System.Drawing.Point(121, 17);
            this.comboRol.Name = "comboRol";
            this.comboRol.Size = new System.Drawing.Size(126, 21);
            this.comboRol.TabIndex = 0;
            this.comboRol.SelectedIndexChanged += new System.EventHandler(this.comboRol_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Rol para el Filtro:";
            // 
            // listUtil
            // 
            this.listUtil.FormattingEnabled = true;
            this.listUtil.Location = new System.Drawing.Point(37, 67);
            this.listUtil.Name = "listUtil";
            this.listUtil.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.listUtil.Size = new System.Drawing.Size(380, 95);
            this.listUtil.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Resultados:";
            // 
            // pictExit
            // 
            this.pictExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictExit.BackgroundImage")));
            this.pictExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictExit.Location = new System.Drawing.Point(389, 17);
            this.pictExit.Name = "pictExit";
            this.pictExit.Size = new System.Drawing.Size(40, 40);
            this.pictExit.TabIndex = 4;
            this.pictExit.TabStop = false;
            this.pictExit.Click += new System.EventHandler(this.pictExit_Click);
            // 
            // CorreosUtiles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Turquoise;
            this.ClientSize = new System.Drawing.Size(455, 210);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CorreosUtiles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Correos Utiles";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictExit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox listUtil;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboRol;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictExit;
    }
}