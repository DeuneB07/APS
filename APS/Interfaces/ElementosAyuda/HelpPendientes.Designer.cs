namespace APS.Interfaces.ElementosAyuda
{
    partial class HelpPendientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HelpPendientes));
            this.lPendGestor = new System.Windows.Forms.Label();
            this.lPendGestor2 = new System.Windows.Forms.Label();
            this.pPendGestor = new System.Windows.Forms.Panel();
            this.bOK = new System.Windows.Forms.Button();
            this.lOK = new System.Windows.Forms.Label();
            this.lpPendientes2 = new System.Windows.Forms.Label();
            this.lpPendientes = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lPendGestor
            // 
            this.lPendGestor.AutoSize = true;
            this.lPendGestor.BackColor = System.Drawing.Color.Transparent;
            this.lPendGestor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lPendGestor.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lPendGestor.Location = new System.Drawing.Point(82, 72);
            this.lPendGestor.Name = "lPendGestor";
            this.lPendGestor.Size = new System.Drawing.Size(132, 14);
            this.lPendGestor.TabIndex = 0;
            this.lPendGestor.Text = "Actividades por Revisar";
            // 
            // lPendGestor2
            // 
            this.lPendGestor2.BackColor = System.Drawing.Color.Transparent;
            this.lPendGestor2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lPendGestor2.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lPendGestor2.Location = new System.Drawing.Point(95, 86);
            this.lPendGestor2.Name = "lPendGestor2";
            this.lPendGestor2.Size = new System.Drawing.Size(183, 33);
            this.lPendGestor2.TabIndex = 3;
            this.lPendGestor2.Text = ">> Actividad creada por una ONG que debe ser aceptada";
            // 
            // pPendGestor
            // 
            this.pPendGestor.BackColor = System.Drawing.Color.Black;
            this.pPendGestor.Location = new System.Drawing.Point(36, 72);
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
            // lpPendientes2
            // 
            this.lpPendientes2.BackColor = System.Drawing.Color.Transparent;
            this.lpPendientes2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lpPendientes2.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lpPendientes2.Location = new System.Drawing.Point(12, 25);
            this.lpPendientes2.Name = "lpPendientes2";
            this.lpPendientes2.Size = new System.Drawing.Size(284, 44);
            this.lpPendientes2.TabIndex = 11;
            this.lpPendientes2.Text = ">> Actividades que deben ser valoradas por el Gestor para ver si podrían o no pub" +
    "licarse en el sistema.";
            // 
            // lpPendientes
            // 
            this.lpPendientes.AutoSize = true;
            this.lpPendientes.BackColor = System.Drawing.Color.Transparent;
            this.lpPendientes.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lpPendientes.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lpPendientes.Location = new System.Drawing.Point(12, 11);
            this.lpPendientes.Name = "lpPendientes";
            this.lpPendientes.Size = new System.Drawing.Size(64, 14);
            this.lpPendientes.TabIndex = 10;
            this.lpPendientes.Text = "Pendientes";
            // 
            // HelpPendientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(373, 136);
            this.Controls.Add(this.lpPendientes2);
            this.Controls.Add(this.lpPendientes);
            this.Controls.Add(this.lOK);
            this.Controls.Add(this.bOK);
            this.Controls.Add(this.pPendGestor);
            this.Controls.Add(this.lPendGestor2);
            this.Controls.Add(this.lPendGestor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HelpPendientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HelpPendientes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lPendGestor;
        private System.Windows.Forms.Label lPendGestor2;
        private System.Windows.Forms.Panel pPendGestor;
        private System.Windows.Forms.Button bOK;
        private System.Windows.Forms.Label lOK;
        private System.Windows.Forms.Label lpPendientes2;
        private System.Windows.Forms.Label lpPendientes;
    }
}