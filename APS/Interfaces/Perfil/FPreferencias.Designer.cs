namespace APS.Interfaces
{
    partial class FPreferencias
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FPreferencias));
            this.bAnadirPref = new System.Windows.Forms.Button();
            this.bRetornar = new System.Windows.Forms.Button();
            this.bBorrarPref = new System.Windows.Forms.Button();
            this.bVerPref = new System.Windows.Forms.Button();
            this.listPreferencias = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // bAnadirPref
            // 
            this.bAnadirPref.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bAnadirPref.Location = new System.Drawing.Point(16, 494);
            this.bAnadirPref.Margin = new System.Windows.Forms.Padding(4);
            this.bAnadirPref.Name = "bAnadirPref";
            this.bAnadirPref.Size = new System.Drawing.Size(131, 28);
            this.bAnadirPref.TabIndex = 12;
            this.bAnadirPref.Text = "Añadir";
            this.bAnadirPref.UseVisualStyleBackColor = true;
            this.bAnadirPref.Click += new System.EventHandler(this.bAnadirPref_Click);
            // 
            // bRetornar
            // 
            this.bRetornar.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bRetornar.Location = new System.Drawing.Point(579, 494);
            this.bRetornar.Margin = new System.Windows.Forms.Padding(4);
            this.bRetornar.Name = "bRetornar";
            this.bRetornar.Size = new System.Drawing.Size(131, 28);
            this.bRetornar.TabIndex = 13;
            this.bRetornar.Text = "Retornar";
            this.bRetornar.UseVisualStyleBackColor = true;
            this.bRetornar.Click += new System.EventHandler(this.bRetornar_Click);
            // 
            // bBorrarPref
            // 
            this.bBorrarPref.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bBorrarPref.Location = new System.Drawing.Point(381, 494);
            this.bBorrarPref.Margin = new System.Windows.Forms.Padding(4);
            this.bBorrarPref.Name = "bBorrarPref";
            this.bBorrarPref.Size = new System.Drawing.Size(167, 28);
            this.bBorrarPref.TabIndex = 14;
            this.bBorrarPref.Text = "Borrar Seleccionada";
            this.bBorrarPref.UseVisualStyleBackColor = true;
            this.bBorrarPref.Click += new System.EventHandler(this.bBorrarPref_Click);
            // 
            // bVerPref
            // 
            this.bVerPref.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bVerPref.Location = new System.Drawing.Point(184, 494);
            this.bVerPref.Margin = new System.Windows.Forms.Padding(4);
            this.bVerPref.Name = "bVerPref";
            this.bVerPref.Size = new System.Drawing.Size(167, 28);
            this.bVerPref.TabIndex = 15;
            this.bVerPref.Text = "Ver Seleccionada";
            this.bVerPref.UseVisualStyleBackColor = true;
            this.bVerPref.Click += new System.EventHandler(this.bVerPref_Click);
            // 
            // listPreferencias
            // 
            this.listPreferencias.FormattingEnabled = true;
            this.listPreferencias.ItemHeight = 16;
            this.listPreferencias.Location = new System.Drawing.Point(16, 15);
            this.listPreferencias.Margin = new System.Windows.Forms.Padding(4);
            this.listPreferencias.Name = "listPreferencias";
            this.listPreferencias.Size = new System.Drawing.Size(692, 452);
            this.listPreferencias.TabIndex = 16;
            // 
            // FPreferencias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 554);
            this.Controls.Add(this.listPreferencias);
            this.Controls.Add(this.bVerPref);
            this.Controls.Add(this.bBorrarPref);
            this.Controls.Add(this.bRetornar);
            this.Controls.Add(this.bAnadirPref);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FPreferencias";
            this.Text = "Tus Preferencias";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bAnadirPref;
        private System.Windows.Forms.Button bRetornar;
        private System.Windows.Forms.Button bBorrarPref;
        private System.Windows.Forms.Button bVerPref;
        private System.Windows.Forms.ListBox listPreferencias;
    }
}