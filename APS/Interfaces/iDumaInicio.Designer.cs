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
            this.bEntrar = new System.Windows.Forms.Button();
            this.labelError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tIdentificacion
            // 
            this.tIdentificacion.BackColor = System.Drawing.SystemColors.HighlightText;
            this.tIdentificacion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tIdentificacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tIdentificacion.Location = new System.Drawing.Point(229, 230);
            this.tIdentificacion.Name = "tIdentificacion";
            this.tIdentificacion.Size = new System.Drawing.Size(258, 21);
            this.tIdentificacion.TabIndex = 0;
            // 
            // tPassword
            // 
            this.tPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tPassword.Cursor = System.Windows.Forms.Cursors.Default;
            this.tPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tPassword.ForeColor = System.Drawing.Color.ForestGreen;
            this.tPassword.Location = new System.Drawing.Point(229, 294);
            this.tPassword.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.tPassword.Name = "tPassword";
            this.tPassword.Size = new System.Drawing.Size(258, 21);
            this.tPassword.TabIndex = 5;
            // 
            // bEntrar
            // 
            this.bEntrar.BackColor = System.Drawing.Color.Transparent;
            this.bEntrar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bEntrar.BackgroundImage")));
            this.bEntrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bEntrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bEntrar.FlatAppearance.BorderSize = 0;
            this.bEntrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bEntrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bEntrar.Location = new System.Drawing.Point(47, 347);
            this.bEntrar.Name = "bEntrar";
            this.bEntrar.Size = new System.Drawing.Size(81, 39);
            this.bEntrar.TabIndex = 6;
            this.bEntrar.UseVisualStyleBackColor = false;
            this.bEntrar.Click += new System.EventHandler(this.bEntrar_Click);
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.BackColor = System.Drawing.Color.Transparent;
            this.labelError.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelError.ForeColor = System.Drawing.Color.Red;
            this.labelError.Location = new System.Drawing.Point(226, 336);
            this.labelError.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(44, 17);
            this.labelError.TabIndex = 7;
            this.labelError.Text = "error";
            // 
            // iDumaInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1133, 629);
            this.Controls.Add(this.labelError);
            this.Controls.Add(this.bEntrar);
            this.Controls.Add(this.tPassword);
            this.Controls.Add(this.tIdentificacion);
            this.Name = "iDumaInicio";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tIdentificacion;
        private System.Windows.Forms.TextBox tPassword;
        private System.Windows.Forms.Button bEntrar;
        private System.Windows.Forms.Label labelError;
    }
}