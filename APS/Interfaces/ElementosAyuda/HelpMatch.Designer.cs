namespace APS.Interfaces.ElementosAyuda
{
    partial class HelpMatch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HelpMatch));
            this.lpMatch = new System.Windows.Forms.Label();
            this.lpMatch2 = new System.Windows.Forms.Label();
            this.pPendGestor = new System.Windows.Forms.Panel();
            this.bOK = new System.Windows.Forms.Button();
            this.lOK = new System.Windows.Forms.Label();
            this.lMatch2 = new System.Windows.Forms.Label();
            this.lMatch = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lpMatch
            // 
            this.lpMatch.AutoSize = true;
            this.lpMatch.BackColor = System.Drawing.Color.Transparent;
            this.lpMatch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lpMatch.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lpMatch.Location = new System.Drawing.Point(12, 12);
            this.lpMatch.Name = "lpMatch";
            this.lpMatch.Size = new System.Drawing.Size(39, 14);
            this.lpMatch.TabIndex = 0;
            this.lpMatch.Text = "Match";
            // 
            // lpMatch2
            // 
            this.lpMatch2.BackColor = System.Drawing.Color.Transparent;
            this.lpMatch2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lpMatch2.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lpMatch2.Location = new System.Drawing.Point(12, 26);
            this.lpMatch2.Name = "lpMatch2";
            this.lpMatch2.Size = new System.Drawing.Size(284, 53);
            this.lpMatch2.TabIndex = 3;
            this.lpMatch2.Text = ">> Actividades que coinciden con tus preferencias. Puedes usar el filtro para mos" +
    "trar las coincidencias con alguna de tus preferencias";
            // 
            // pPendGestor
            // 
            this.pPendGestor.BackColor = System.Drawing.Color.Teal;
            this.pPendGestor.Location = new System.Drawing.Point(26, 97);
            this.pPendGestor.Name = "pPendGestor";
            this.pPendGestor.Size = new System.Drawing.Size(40, 40);
            this.pPendGestor.TabIndex = 6;
            // 
            // bOK
            // 
            this.bOK.BackColor = System.Drawing.Color.Transparent;
            this.bOK.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bOK.BackgroundImage")));
            this.bOK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bOK.FlatAppearance.BorderSize = 0;
            this.bOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bOK.Location = new System.Drawing.Point(312, 12);
            this.bOK.Name = "bOK";
            this.bOK.Size = new System.Drawing.Size(40, 40);
            this.bOK.TabIndex = 8;
            this.bOK.UseVisualStyleBackColor = false;
            this.bOK.Click += new System.EventHandler(this.bOK_Click);
            // 
            // lOK
            // 
            this.lOK.AutoSize = true;
            this.lOK.BackColor = System.Drawing.Color.Transparent;
            this.lOK.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lOK.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lOK.Location = new System.Drawing.Point(302, 55);
            this.lOK.Name = "lOK";
            this.lOK.Size = new System.Drawing.Size(60, 14);
            this.lOK.TabIndex = 9;
            this.lOK.Text = "¡Entiendo!";
            // 
            // lMatch2
            // 
            this.lMatch2.BackColor = System.Drawing.Color.Transparent;
            this.lMatch2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lMatch2.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lMatch2.Location = new System.Drawing.Point(82, 111);
            this.lMatch2.Name = "lMatch2";
            this.lMatch2.Size = new System.Drawing.Size(220, 35);
            this.lMatch2.TabIndex = 11;
            this.lMatch2.Text = ">> En un inicio, sólo aquellas que coinciden con tus Grados y Asignaturas";
            // 
            // lMatch
            // 
            this.lMatch.AutoSize = true;
            this.lMatch.BackColor = System.Drawing.Color.Transparent;
            this.lMatch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lMatch.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lMatch.Location = new System.Drawing.Point(72, 97);
            this.lMatch.Name = "lMatch";
            this.lMatch.Size = new System.Drawing.Size(257, 14);
            this.lMatch.TabIndex = 10;
            this.lMatch.Text = "Actividades que Coinciden con tus Preferencias";
            // 
            // HelpMatch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(373, 164);
            this.Controls.Add(this.lMatch2);
            this.Controls.Add(this.lMatch);
            this.Controls.Add(this.lOK);
            this.Controls.Add(this.bOK);
            this.Controls.Add(this.pPendGestor);
            this.Controls.Add(this.lpMatch2);
            this.Controls.Add(this.lpMatch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HelpMatch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HelpMatch";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lpMatch;
        private System.Windows.Forms.Label lpMatch2;
        private System.Windows.Forms.Panel pPendGestor;
        private System.Windows.Forms.Button bOK;
        private System.Windows.Forms.Label lOK;
        private System.Windows.Forms.Label lMatch2;
        private System.Windows.Forms.Label lMatch;
    }
}