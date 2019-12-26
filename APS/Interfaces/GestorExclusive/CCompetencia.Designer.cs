namespace APS.Interfaces.GestorExclusive
{
    partial class CCompetencia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CCompetencia));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lShowTipo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bBorrar = new System.Windows.Forms.Button();
            this.lShowDesc = new System.Windows.Forms.Label();
            this.lDesc = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.lShowDesc);
            this.panel1.Controls.Add(this.lDesc);
            this.panel1.Controls.Add(this.bBorrar);
            this.panel1.Controls.Add(this.lShowTipo);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(569, 69);
            this.panel1.TabIndex = 1;
            // 
            // lShowTipo
            // 
            this.lShowTipo.AutoSize = true;
            this.lShowTipo.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lShowTipo.Location = new System.Drawing.Point(64, 8);
            this.lShowTipo.Name = "lShowTipo";
            this.lShowTipo.Size = new System.Drawing.Size(37, 14);
            this.lShowTipo.TabIndex = 1;
            this.lShowTipo.Text = "comp";
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
            // bBorrar
            // 
            this.bBorrar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bBorrar.BackgroundImage")));
            this.bBorrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bBorrar.FlatAppearance.BorderSize = 0;
            this.bBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bBorrar.Location = new System.Drawing.Point(538, 3);
            this.bBorrar.Name = "bBorrar";
            this.bBorrar.Size = new System.Drawing.Size(28, 28);
            this.bBorrar.TabIndex = 4;
            this.bBorrar.UseVisualStyleBackColor = true;
            // 
            // lShowDesc
            // 
            this.lShowDesc.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lShowDesc.Location = new System.Drawing.Point(85, 28);
            this.lShowDesc.Name = "lShowDesc";
            this.lShowDesc.Size = new System.Drawing.Size(447, 30);
            this.lShowDesc.TabIndex = 6;
            this.lShowDesc.Text = "comp";
            // 
            // lDesc
            // 
            this.lDesc.AutoSize = true;
            this.lDesc.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lDesc.Location = new System.Drawing.Point(5, 28);
            this.lDesc.Name = "lDesc";
            this.lDesc.Size = new System.Drawing.Size(74, 14);
            this.lDesc.TabIndex = 5;
            this.lDesc.Text = "Descripción:";
            // 
            // CCompetencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSalmon;
            this.Controls.Add(this.panel1);
            this.Name = "CCompetencia";
            this.Size = new System.Drawing.Size(575, 75);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bBorrar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lShowTipo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lShowDesc;
        private System.Windows.Forms.Label lDesc;
    }
}
