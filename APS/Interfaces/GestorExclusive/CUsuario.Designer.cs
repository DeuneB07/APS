namespace APS.Interfaces.GestorExclusive
{
    partial class CUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CUsuario));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lShowRol = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lShowMail = new System.Windows.Forms.Label();
            this.lEmail = new System.Windows.Forms.Label();
            this.lShowNoun = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bBorrar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.lShowRol);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lShowMail);
            this.panel1.Controls.Add(this.lEmail);
            this.panel1.Controls.Add(this.bBorrar);
            this.panel1.Controls.Add(this.lShowNoun);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(569, 94);
            this.panel1.TabIndex = 3;
            // 
            // lShowRol
            // 
            this.lShowRol.AutoSize = true;
            this.lShowRol.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lShowRol.Location = new System.Drawing.Point(39, 67);
            this.lShowRol.Name = "lShowRol";
            this.lShowRol.Size = new System.Drawing.Size(37, 14);
            this.lShowRol.TabIndex = 8;
            this.lShowRol.Text = "comp";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(5, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 14);
            this.label3.TabIndex = 7;
            this.label3.Text = "Rol:";
            // 
            // lShowMail
            // 
            this.lShowMail.AutoSize = true;
            this.lShowMail.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lShowMail.Location = new System.Drawing.Point(50, 38);
            this.lShowMail.Name = "lShowMail";
            this.lShowMail.Size = new System.Drawing.Size(37, 14);
            this.lShowMail.TabIndex = 6;
            this.lShowMail.Text = "comp";
            // 
            // lEmail
            // 
            this.lEmail.AutoSize = true;
            this.lEmail.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lEmail.Location = new System.Drawing.Point(5, 38);
            this.lEmail.Name = "lEmail";
            this.lEmail.Size = new System.Drawing.Size(39, 14);
            this.lEmail.TabIndex = 5;
            this.lEmail.Text = "Email:";
            // 
            // lShowNoun
            // 
            this.lShowNoun.AutoSize = true;
            this.lShowNoun.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lShowNoun.Location = new System.Drawing.Point(64, 8);
            this.lShowNoun.Name = "lShowNoun";
            this.lShowNoun.Size = new System.Drawing.Size(35, 14);
            this.lShowNoun.TabIndex = 1;
            this.lShowNoun.Text = "noun";
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
            // CUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orchid;
            this.Controls.Add(this.panel1);
            this.Name = "CUsuario";
            this.Size = new System.Drawing.Size(575, 100);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lShowRol;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lShowMail;
        private System.Windows.Forms.Label lEmail;
        private System.Windows.Forms.Button bBorrar;
        private System.Windows.Forms.Label lShowNoun;
        private System.Windows.Forms.Label label1;
    }
}
