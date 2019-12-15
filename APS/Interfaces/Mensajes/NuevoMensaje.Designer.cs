namespace APS.Interfaces.Mensajes
{
    partial class NuevoMensaje
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tReceptor = new System.Windows.Forms.TextBox();
            this.tAsunto = new System.Windows.Forms.TextBox();
            this.tTexto = new System.Windows.Forms.TextBox();
            this.beliminar = new System.Windows.Forms.Button();
            this.bvolver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(286, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(149, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Asunto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(148, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Texto";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(151, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Emisor";
            // 
            // tReceptor
            // 
            this.tReceptor.Location = new System.Drawing.Point(221, 82);
            this.tReceptor.Name = "tReceptor";
            this.tReceptor.Size = new System.Drawing.Size(304, 20);
            this.tReceptor.TabIndex = 4;
            // 
            // tAsunto
            // 
            this.tAsunto.Location = new System.Drawing.Point(221, 119);
            this.tAsunto.Name = "tAsunto";
            this.tAsunto.Size = new System.Drawing.Size(304, 20);
            this.tAsunto.TabIndex = 5;
            // 
            // tTexto
            // 
            this.tTexto.Location = new System.Drawing.Point(221, 163);
            this.tTexto.Multiline = true;
            this.tTexto.Name = "tTexto";
            this.tTexto.Size = new System.Drawing.Size(304, 129);
            this.tTexto.TabIndex = 6;
            // 
            // beliminar
            // 
            this.beliminar.Location = new System.Drawing.Point(323, 347);
            this.beliminar.Name = "beliminar";
            this.beliminar.Size = new System.Drawing.Size(107, 23);
            this.beliminar.TabIndex = 8;
            this.beliminar.Text = "Enviar Mensaje";
            this.beliminar.UseVisualStyleBackColor = true;
            this.beliminar.Click += new System.EventHandler(this.beliminar_Click);
            // 
            // bvolver
            // 
            this.bvolver.Location = new System.Drawing.Point(665, 415);
            this.bvolver.Name = "bvolver";
            this.bvolver.Size = new System.Drawing.Size(112, 23);
            this.bvolver.TabIndex = 9;
            this.bvolver.Text = "Volver a Mensajes";
            this.bvolver.UseVisualStyleBackColor = true;
            this.bvolver.Click += new System.EventHandler(this.bvolver_Click);
            // 
            // NuevoMensaje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bvolver);
            this.Controls.Add(this.beliminar);
            this.Controls.Add(this.tTexto);
            this.Controls.Add(this.tAsunto);
            this.Controls.Add(this.tReceptor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "NuevoMensaje";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tReceptor;
        private System.Windows.Forms.TextBox tAsunto;
        private System.Windows.Forms.TextBox tTexto;
        private System.Windows.Forms.Button beliminar;
        private System.Windows.Forms.Button bvolver;
    }
}