namespace APS.Interfaces.Personalizados
{
    partial class CartelHistorial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CartelHistorial));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblFecha = new System.Windows.Forms.Label();
            this.bVerTodo = new System.Windows.Forms.Button();
            this.lblComentario = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.lblFecha);
            this.panel1.Controls.Add(this.bVerTodo);
            this.panel1.Controls.Add(this.lblComentario);
            this.panel1.Location = new System.Drawing.Point(4, 4);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1067, 82);
            this.panel1.TabIndex = 3;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.ForeColor = System.Drawing.Color.DimGray;
            this.lblFecha.Location = new System.Drawing.Point(15, 54);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(44, 18);
            this.lblFecha.TabIndex = 19;
            this.lblFecha.Text = "fecha";
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
            this.bVerTodo.Location = new System.Drawing.Point(997, 16);
            this.bVerTodo.Margin = new System.Windows.Forms.Padding(4);
            this.bVerTodo.Name = "bVerTodo";
            this.bVerTodo.Size = new System.Drawing.Size(53, 47);
            this.bVerTodo.TabIndex = 18;
            this.bVerTodo.UseVisualStyleBackColor = false;
            this.bVerTodo.Visible = false;
            // 
            // lblComentario
            // 
            this.lblComentario.BackColor = System.Drawing.Color.White;
            this.lblComentario.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComentario.ForeColor = System.Drawing.Color.Navy;
            this.lblComentario.Location = new System.Drawing.Point(14, 0);
            this.lblComentario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblComentario.Name = "lblComentario";
            this.lblComentario.Size = new System.Drawing.Size(986, 54);
            this.lblComentario.TabIndex = 4;
            this.lblComentario.Text = "Comentario";
            // 
            // CartelHistorial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CartelHistorial";
            this.Size = new System.Drawing.Size(1078, 90);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblComentario;
        private System.Windows.Forms.Button bVerTodo;
        private System.Windows.Forms.Label lblFecha;
    }
}
