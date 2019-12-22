namespace APS.Interfaces
{
    partial class iDumaInicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(iDumaInicio));
            this.tIdentificacion = new System.Windows.Forms.TextBox();
            this.tPassword = new System.Windows.Forms.TextBox();
            this.labelError = new System.Windows.Forms.Label();
            this.btnEntrar = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // tIdentificacion
            // 
            this.tIdentificacion.BackColor = System.Drawing.SystemColors.HighlightText;
            this.tIdentificacion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tIdentificacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tIdentificacion.Location = new System.Drawing.Point(170, 164);
            this.tIdentificacion.Margin = new System.Windows.Forms.Padding(2);
            this.tIdentificacion.Name = "tIdentificacion";
            this.tIdentificacion.Size = new System.Drawing.Size(194, 17);
            this.tIdentificacion.TabIndex = 10;
            // 
            // tPassword
            // 
            this.tPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tPassword.Cursor = System.Windows.Forms.Cursors.Default;
            this.tPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tPassword.ForeColor = System.Drawing.Color.Black;
            this.tPassword.Location = new System.Drawing.Point(170, 209);
            this.tPassword.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.tPassword.Name = "tPassword";
            this.tPassword.Size = new System.Drawing.Size(194, 17);
            this.tPassword.TabIndex = 11;
            this.tPassword.UseSystemPasswordChar = true;
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.BackColor = System.Drawing.Color.Transparent;
            this.labelError.Font = new System.Drawing.Font("Bahnschrift", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelError.ForeColor = System.Drawing.Color.Red;
            this.labelError.Location = new System.Drawing.Point(135, 239);
            this.labelError.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(34, 13);
            this.labelError.TabIndex = 12;
            this.labelError.Text = "error";
            // 
            // btnEntrar
            // 
            this.btnEntrar.BackColor = System.Drawing.Color.Transparent;
            this.btnEntrar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEntrar.BackgroundImage")));
            this.btnEntrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEntrar.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnEntrar.FlatAppearance.BorderSize = 0;
            this.btnEntrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEntrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEntrar.Location = new System.Drawing.Point(34, 249);
            this.btnEntrar.Margin = new System.Windows.Forms.Padding(2);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(61, 32);
            this.btnEntrar.TabIndex = 9;
            this.btnEntrar.UseVisualStyleBackColor = true;
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox.BackgroundImage")));
            this.pictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox.InitialImage = null;
            this.pictureBox.Location = new System.Drawing.Point(-1, 1);
            this.pictureBox.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(842, 450);
            this.pictureBox.TabIndex = 8;
            this.pictureBox.TabStop = false;
            // 
            // iDumaInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(837, 447);
            this.Controls.Add(this.labelError);
            this.Controls.Add(this.tPassword);
            this.Controls.Add(this.tIdentificacion);
            this.Controls.Add(this.btnEntrar);
            this.Controls.Add(this.pictureBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "iDumaInicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "iDUMA";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button btnEntrar;
        private System.Windows.Forms.TextBox tIdentificacion;
        private System.Windows.Forms.TextBox tPassword;
        private System.Windows.Forms.Label labelError;
    }
}