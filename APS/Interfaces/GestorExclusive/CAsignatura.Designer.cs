namespace APS.Interfaces.GestorExclusive
{
    partial class CAsignatura
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.lShowGrado = new System.Windows.Forms.Label();
            this.lDesc = new System.Windows.Forms.Label();
            this.lShowNoun = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.lShowGrado);
            this.panel1.Controls.Add(this.lDesc);
            this.panel1.Controls.Add(this.lShowNoun);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(569, 61);
            this.panel1.TabIndex = 2;
            // 
            // lShowGrado
            // 
            this.lShowGrado.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lShowGrado.Location = new System.Drawing.Point(85, 28);
            this.lShowGrado.Name = "lShowGrado";
            this.lShowGrado.Size = new System.Drawing.Size(447, 30);
            this.lShowGrado.TabIndex = 6;
            this.lShowGrado.Text = "gasig";
            // 
            // lDesc
            // 
            this.lDesc.AutoSize = true;
            this.lDesc.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lDesc.Location = new System.Drawing.Point(37, 28);
            this.lDesc.Name = "lDesc";
            this.lDesc.Size = new System.Drawing.Size(42, 14);
            this.lDesc.TabIndex = 5;
            this.lDesc.Text = "Grado:";
            // 
            // lShowNoun
            // 
            this.lShowNoun.AutoSize = true;
            this.lShowNoun.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lShowNoun.Location = new System.Drawing.Point(64, 8);
            this.lShowNoun.Name = "lShowNoun";
            this.lShowNoun.Size = new System.Drawing.Size(28, 14);
            this.lShowNoun.TabIndex = 1;
            this.lShowNoun.Text = "asig";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            // 
            // CAsignatura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.Controls.Add(this.panel1);
            this.Name = "CAsignatura";
            this.Size = new System.Drawing.Size(575, 69);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lShowGrado;
        private System.Windows.Forms.Label lDesc;
        private System.Windows.Forms.Label lShowNoun;
        private System.Windows.Forms.Label label1;
    }
}
