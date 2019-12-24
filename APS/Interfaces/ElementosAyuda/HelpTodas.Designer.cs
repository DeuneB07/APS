namespace APS.Interfaces.ElementosAyuda
{
    partial class HelpTodas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HelpTodas));
            this.lpTodas = new System.Windows.Forms.Label();
            this.lpTodas2 = new System.Windows.Forms.Label();
            this.pTodas = new System.Windows.Forms.Panel();
            this.bOK = new System.Windows.Forms.Button();
            this.lOK = new System.Windows.Forms.Label();
            this.lTodas2 = new System.Windows.Forms.Label();
            this.lTodas = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lpTodas
            // 
            this.lpTodas.AutoSize = true;
            this.lpTodas.BackColor = System.Drawing.Color.Transparent;
            this.lpTodas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lpTodas.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lpTodas.Location = new System.Drawing.Point(12, 12);
            this.lpTodas.Name = "lpTodas";
            this.lpTodas.Size = new System.Drawing.Size(37, 14);
            this.lpTodas.TabIndex = 0;
            this.lpTodas.Text = "Todas";
            // 
            // lpTodas2
            // 
            this.lpTodas2.BackColor = System.Drawing.Color.Transparent;
            this.lpTodas2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lpTodas2.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lpTodas2.Location = new System.Drawing.Point(12, 26);
            this.lpTodas2.Name = "lpTodas2";
            this.lpTodas2.Size = new System.Drawing.Size(284, 43);
            this.lpTodas2.TabIndex = 3;
            this.lpTodas2.Text = ">> Actividades publicadas. Pueden usarse los filtros para ver actividades que pue" +
    "dan interesar";
            // 
            // pTodas
            // 
            this.pTodas.BackColor = System.Drawing.Color.Teal;
            this.pTodas.Location = new System.Drawing.Point(25, 83);
            this.pTodas.Name = "pTodas";
            this.pTodas.Size = new System.Drawing.Size(40, 40);
            this.pTodas.TabIndex = 6;
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
            // lTodas2
            // 
            this.lTodas2.BackColor = System.Drawing.Color.Transparent;
            this.lTodas2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lTodas2.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTodas2.Location = new System.Drawing.Point(81, 97);
            this.lTodas2.Name = "lTodas2";
            this.lTodas2.Size = new System.Drawing.Size(220, 35);
            this.lTodas2.TabIndex = 11;
            this.lTodas2.Text = ">> En un inicio, todas las actividades que están Abiertas";
            // 
            // lTodas
            // 
            this.lTodas.AutoSize = true;
            this.lTodas.BackColor = System.Drawing.Color.Transparent;
            this.lTodas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lTodas.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTodas.Location = new System.Drawing.Point(71, 83);
            this.lTodas.Name = "lTodas";
            this.lTodas.Size = new System.Drawing.Size(127, 14);
            this.lTodas.TabIndex = 10;
            this.lTodas.Text = "Actividades Publicadas";
            // 
            // HelpTodas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(373, 143);
            this.Controls.Add(this.lTodas2);
            this.Controls.Add(this.lTodas);
            this.Controls.Add(this.lOK);
            this.Controls.Add(this.bOK);
            this.Controls.Add(this.pTodas);
            this.Controls.Add(this.lpTodas2);
            this.Controls.Add(this.lpTodas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HelpTodas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HelpTodas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lpTodas;
        private System.Windows.Forms.Label lpTodas2;
        private System.Windows.Forms.Panel pTodas;
        private System.Windows.Forms.Button bOK;
        private System.Windows.Forms.Label lOK;
        private System.Windows.Forms.Label lTodas2;
        private System.Windows.Forms.Label lTodas;
    }
}