namespace APS.Interfaces.Perfil
{
    partial class BandejaMensajes
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
            this.label1 = new System.Windows.Forms.Label();
            this.listMensajes = new System.Windows.Forms.ListBox();
            this.bVerMensaje = new System.Windows.Forms.Button();
            this.bNuevoMensaje = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(359, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "MENSAJES";
            // 
            // listMensajes
            // 
            this.listMensajes.FormattingEnabled = true;
            this.listMensajes.Location = new System.Drawing.Point(95, 70);
            this.listMensajes.Name = "listMensajes";
            this.listMensajes.Size = new System.Drawing.Size(617, 225);
            this.listMensajes.TabIndex = 17;
            // 
            // bVerMensaje
            // 
            this.bVerMensaje.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bVerMensaje.Location = new System.Drawing.Point(166, 369);
            this.bVerMensaje.Name = "bVerMensaje";
            this.bVerMensaje.Size = new System.Drawing.Size(98, 23);
            this.bVerMensaje.TabIndex = 18;
            this.bVerMensaje.Text = "Ver Mensaje";
            this.bVerMensaje.UseVisualStyleBackColor = true;
            this.bVerMensaje.Click += new System.EventHandler(this.bVerMensaje_Click);
            // 
            // bNuevoMensaje
            // 
            this.bNuevoMensaje.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bNuevoMensaje.Location = new System.Drawing.Point(559, 369);
            this.bNuevoMensaje.Name = "bNuevoMensaje";
            this.bNuevoMensaje.Size = new System.Drawing.Size(98, 23);
            this.bNuevoMensaje.TabIndex = 19;
            this.bNuevoMensaje.Text = "Nuevo Mensaje";
            this.bNuevoMensaje.UseVisualStyleBackColor = true;
            this.bNuevoMensaje.Click += new System.EventHandler(this.bNuevoMensaje_Click);
            // 
            // BandejaMensajes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bNuevoMensaje);
            this.Controls.Add(this.bVerMensaje);
            this.Controls.Add(this.listMensajes);
            this.Controls.Add(this.label1);
            this.Name = "BandejaMensajes";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listMensajes;
        private System.Windows.Forms.Button bVerMensaje;
        private System.Windows.Forms.Button bNuevoMensaje;
    }
}