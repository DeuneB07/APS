namespace APS.Interfaces.Personalizados
{
    partial class CartelParticipante
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CartelParticipante));
            this.panel1 = new System.Windows.Forms.Panel();
            this.bVerTodo = new System.Windows.Forms.Button();
            this.lShowNick = new System.Windows.Forms.Label();
            this.lNick = new System.Windows.Forms.Label();
            this.lRol = new System.Windows.Forms.Label();
            this.lShowRol = new System.Windows.Forms.Label();
            this.bEvaluar = new System.Windows.Forms.Button();
            this.lShowMail = new System.Windows.Forms.Label();
            this.lMail = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.pict = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pict)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.bVerTodo);
            this.panel1.Controls.Add(this.lShowNick);
            this.panel1.Controls.Add(this.lNick);
            this.panel1.Controls.Add(this.lRol);
            this.panel1.Controls.Add(this.lShowRol);
            this.panel1.Controls.Add(this.bEvaluar);
            this.panel1.Controls.Add(this.lShowMail);
            this.panel1.Controls.Add(this.lMail);
            this.panel1.Controls.Add(this.labelName);
            this.panel1.Controls.Add(this.pict);
            this.panel1.Location = new System.Drawing.Point(4, 4);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(603, 143);
            this.panel1.TabIndex = 4;
            // 
            // bVerTodo
            // 
            this.bVerTodo.BackColor = System.Drawing.Color.White;
            this.bVerTodo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bVerTodo.BackgroundImage")));
            this.bVerTodo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bVerTodo.Cursor = System.Windows.Forms.Cursors.Default;
            this.bVerTodo.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.bVerTodo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bVerTodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bVerTodo.ForeColor = System.Drawing.Color.Black;
            this.bVerTodo.Location = new System.Drawing.Point(555, 6);
            this.bVerTodo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bVerTodo.Name = "bVerTodo";
            this.bVerTodo.Size = new System.Drawing.Size(41, 37);
            this.bVerTodo.TabIndex = 18;
            this.bVerTodo.UseVisualStyleBackColor = false;
            this.bVerTodo.Click += new System.EventHandler(this.bVerTodo_Click);
            // 
            // lShowNick
            // 
            this.lShowNick.AutoSize = true;
            this.lShowNick.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lShowNick.Location = new System.Drawing.Point(321, 50);
            this.lShowNick.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lShowNick.Name = "lShowNick";
            this.lShowNick.Size = new System.Drawing.Size(34, 17);
            this.lShowNick.TabIndex = 16;
            this.lShowNick.Text = "nick";
            // 
            // lNick
            // 
            this.lNick.AutoSize = true;
            this.lNick.BackColor = System.Drawing.Color.Transparent;
            this.lNick.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lNick.Location = new System.Drawing.Point(172, 50);
            this.lNick.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lNick.Name = "lNick";
            this.lNick.Size = new System.Drawing.Size(136, 17);
            this.lNick.TabIndex = 15;
            this.lNick.Text = "Nombre de Usuario:";
            // 
            // lRol
            // 
            this.lRol.AutoSize = true;
            this.lRol.BackColor = System.Drawing.Color.Transparent;
            this.lRol.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lRol.Location = new System.Drawing.Point(172, 75);
            this.lRol.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lRol.Name = "lRol";
            this.lRol.Size = new System.Drawing.Size(32, 17);
            this.lRol.TabIndex = 13;
            this.lRol.Text = "Rol:";
            // 
            // lShowRol
            // 
            this.lShowRol.AutoSize = true;
            this.lShowRol.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lShowRol.Location = new System.Drawing.Point(213, 75);
            this.lShowRol.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lShowRol.Name = "lShowRol";
            this.lShowRol.Size = new System.Drawing.Size(41, 17);
            this.lShowRol.TabIndex = 12;
            this.lShowRol.Text = "rolex";
            // 
            // bEvaluar
            // 
            this.bEvaluar.BackColor = System.Drawing.Color.Transparent;
            this.bEvaluar.Cursor = System.Windows.Forms.Cursors.Default;
            this.bEvaluar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.bEvaluar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bEvaluar.ForeColor = System.Drawing.Color.Black;
            this.bEvaluar.Location = new System.Drawing.Point(513, 97);
            this.bEvaluar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bEvaluar.Name = "bEvaluar";
            this.bEvaluar.Size = new System.Drawing.Size(85, 40);
            this.bEvaluar.TabIndex = 10;
            this.bEvaluar.Text = "Evaluar";
            this.bEvaluar.UseVisualStyleBackColor = false;
            // 
            // lShowMail
            // 
            this.lShowMail.AutoSize = true;
            this.lShowMail.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lShowMail.Location = new System.Drawing.Point(235, 99);
            this.lShowMail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lShowMail.Name = "lShowMail";
            this.lShowMail.Size = new System.Drawing.Size(43, 17);
            this.lShowMail.TabIndex = 9;
            this.lShowMail.Text = "email";
            // 
            // lMail
            // 
            this.lMail.AutoSize = true;
            this.lMail.BackColor = System.Drawing.Color.Transparent;
            this.lMail.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lMail.Location = new System.Drawing.Point(172, 99);
            this.lMail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lMail.Name = "lMail";
            this.lMail.Size = new System.Drawing.Size(53, 17);
            this.lMail.TabIndex = 8;
            this.lMail.Text = "e-mail:";
            // 
            // labelName
            // 
            this.labelName.Font = new System.Drawing.Font("Bahnschrift", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(4, 5);
            this.labelName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(543, 28);
            this.labelName.TabIndex = 4;
            this.labelName.Text = "Nombre";
            // 
            // pict
            // 
            this.pict.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pict.Image = global::APS.Properties.Resources.userDefault;
            this.pict.Location = new System.Drawing.Point(8, 37);
            this.pict.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pict.Name = "pict";
            this.pict.Size = new System.Drawing.Size(130, 100);
            this.pict.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pict.TabIndex = 6;
            this.pict.TabStop = false;
            // 
            // CartelParticipante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BlueViolet;
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "CartelParticipante";
            this.Size = new System.Drawing.Size(612, 151);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pict)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bVerTodo;
        private System.Windows.Forms.Label lShowNick;
        private System.Windows.Forms.Label lNick;
        private System.Windows.Forms.Label lRol;
        private System.Windows.Forms.Label lShowRol;
        private System.Windows.Forms.Button bEvaluar;
        private System.Windows.Forms.Label lShowMail;
        private System.Windows.Forms.Label lMail;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.PictureBox pict;
    }
}
