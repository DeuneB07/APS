namespace APS.Interfaces
{
    partial class PruebaVer
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
            this.lGrado = new System.Windows.Forms.Label();
            this.lAsig = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lGrado
            // 
            this.lGrado.AutoSize = true;
            this.lGrado.Location = new System.Drawing.Point(308, 28);
            this.lGrado.Name = "lGrado";
            this.lGrado.Size = new System.Drawing.Size(42, 13);
            this.lGrado.TabIndex = 0;
            this.lGrado.Text = "Grado: ";
            // 
            // lAsig
            // 
            this.lAsig.AutoSize = true;
            this.lAsig.Location = new System.Drawing.Point(308, 86);
            this.lAsig.Name = "lAsig";
            this.lAsig.Size = new System.Drawing.Size(60, 13);
            this.lAsig.TabIndex = 1;
            this.lAsig.Text = "Asignatura:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(390, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(393, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "label2";
            // 
            // PruebaVer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lAsig);
            this.Controls.Add(this.lGrado);
            this.Name = "PruebaVer";
            this.Text = "PruebaVer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lGrado;
        private System.Windows.Forms.Label lAsig;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}