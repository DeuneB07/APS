namespace APS.Interfaces.GestorExclusive
{
    partial class CGrado
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
            this.lShowNumAsig = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lShowMatriculados = new System.Windows.Forms.Label();
            this.lDesc = new System.Windows.Forms.Label();
            this.lShowNoun = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.lShowNumAsig);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lShowMatriculados);
            this.panel1.Controls.Add(this.lDesc);
            this.panel1.Controls.Add(this.lShowNoun);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(569, 94);
            this.panel1.TabIndex = 2;
            // 
            // lShowNumAsig
            // 
            this.lShowNumAsig.AutoSize = true;
            this.lShowNumAsig.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lShowNumAsig.Location = new System.Drawing.Point(146, 67);
            this.lShowNumAsig.Name = "lShowNumAsig";
            this.lShowNumAsig.Size = new System.Drawing.Size(37, 14);
            this.lShowNumAsig.TabIndex = 8;
            this.lShowNumAsig.Text = "comp";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(5, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 14);
            this.label3.TabIndex = 7;
            this.label3.Text = "Número de Asignaturas:";
            // 
            // lShowMatriculados
            // 
            this.lShowMatriculados.AutoSize = true;
            this.lShowMatriculados.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lShowMatriculados.Location = new System.Drawing.Point(140, 38);
            this.lShowMatriculados.Name = "lShowMatriculados";
            this.lShowMatriculados.Size = new System.Drawing.Size(37, 14);
            this.lShowMatriculados.TabIndex = 6;
            this.lShowMatriculados.Text = "comp";
            // 
            // lDesc
            // 
            this.lDesc.AutoSize = true;
            this.lDesc.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lDesc.Location = new System.Drawing.Point(5, 38);
            this.lDesc.Name = "lDesc";
            this.lDesc.Size = new System.Drawing.Size(129, 14);
            this.lDesc.TabIndex = 5;
            this.lDesc.Text = "Alumnos Matriculados:";
            // 
            // lShowNoun
            // 
            this.lShowNoun.AutoSize = true;
            this.lShowNoun.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lShowNoun.Location = new System.Drawing.Point(64, 8);
            this.lShowNoun.Name = "lShowNoun";
            this.lShowNoun.Size = new System.Drawing.Size(37, 14);
            this.lShowNoun.TabIndex = 1;
            this.lShowNoun.Text = "grado";
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
            // CGrado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.Controls.Add(this.panel1);
            this.Name = "CGrado";
            this.Size = new System.Drawing.Size(575, 100);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lShowMatriculados;
        private System.Windows.Forms.Label lDesc;
        private System.Windows.Forms.Label lShowNoun;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lShowNumAsig;
        private System.Windows.Forms.Label label3;
    }
}
