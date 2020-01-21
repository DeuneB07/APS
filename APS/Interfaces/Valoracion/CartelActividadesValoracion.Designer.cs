namespace APS.Interfaces.Personalizados
{
    partial class CartelActividadesValoracion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CartelActividadesValoracion));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lDescripcion = new System.Windows.Forms.RichTextBox();
            this.bExpedir = new System.Windows.Forms.Button();
            this.lShowResp = new System.Windows.Forms.Label();
            this.lResp = new System.Windows.Forms.Label();
            this.lShowOrg = new System.Windows.Forms.Label();
            this.lOrg = new System.Windows.Forms.Label();
            this.bValorar = new System.Windows.Forms.Button();
            this.bVerMas = new System.Windows.Forms.Button();
            this.labelName = new System.Windows.Forms.Label();
            this.pict = new System.Windows.Forms.PictureBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pict)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.lDescripcion);
            this.panel1.Controls.Add(this.bExpedir);
            this.panel1.Controls.Add(this.lShowResp);
            this.panel1.Controls.Add(this.lResp);
            this.panel1.Controls.Add(this.lShowOrg);
            this.panel1.Controls.Add(this.lOrg);
            this.panel1.Controls.Add(this.bValorar);
            this.panel1.Controls.Add(this.bVerMas);
            this.panel1.Controls.Add(this.labelName);
            this.panel1.Controls.Add(this.pict);
            this.panel1.Location = new System.Drawing.Point(4, 4);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(831, 209);
            this.panel1.TabIndex = 4;
            // 
            // lDescripcion
            // 
            this.lDescripcion.BackColor = System.Drawing.Color.White;
            this.lDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lDescripcion.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lDescripcion.Location = new System.Drawing.Point(197, 101);
            this.lDescripcion.Name = "lDescripcion";
            this.lDescripcion.ReadOnly = true;
            this.lDescripcion.Size = new System.Drawing.Size(322, 91);
            this.lDescripcion.TabIndex = 21;
            this.lDescripcion.Text = "";
            // 
            // bExpedir
            // 
            this.bExpedir.BackColor = System.Drawing.Color.Transparent;
            this.bExpedir.Cursor = System.Windows.Forms.Cursors.Default;
            this.bExpedir.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.bExpedir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bExpedir.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bExpedir.ForeColor = System.Drawing.Color.Black;
            this.bExpedir.Location = new System.Drawing.Point(551, 165);
            this.bExpedir.Margin = new System.Windows.Forms.Padding(4);
            this.bExpedir.Name = "bExpedir";
            this.bExpedir.Size = new System.Drawing.Size(183, 40);
            this.bExpedir.TabIndex = 20;
            this.bExpedir.Text = "Expedir Certificado";
            this.bExpedir.UseVisualStyleBackColor = false;
            this.bExpedir.Click += new System.EventHandler(this.bExpedir_Click);
            // 
            // lShowResp
            // 
            this.lShowResp.AutoSize = true;
            this.lShowResp.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lShowResp.Location = new System.Drawing.Point(140, 72);
            this.lShowResp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lShowResp.Name = "lShowResp";
            this.lShowResp.Size = new System.Drawing.Size(69, 17);
            this.lShowResp.TabIndex = 19;
            this.lShowResp.Text = "nounresp";
            // 
            // lResp
            // 
            this.lResp.AutoSize = true;
            this.lResp.Font = new System.Drawing.Font("Bahnschrift", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lResp.Location = new System.Drawing.Point(20, 72);
            this.lResp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lResp.Name = "lResp";
            this.lResp.Size = new System.Drawing.Size(93, 17);
            this.lResp.TabIndex = 18;
            this.lResp.Text = "Responsable:";
            // 
            // lShowOrg
            // 
            this.lShowOrg.AutoSize = true;
            this.lShowOrg.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lShowOrg.Location = new System.Drawing.Point(111, 44);
            this.lShowOrg.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lShowOrg.Name = "lShowOrg";
            this.lShowOrg.Size = new System.Drawing.Size(62, 17);
            this.lShowOrg.TabIndex = 17;
            this.lShowOrg.Text = "nounorg";
            // 
            // lOrg
            // 
            this.lOrg.AutoSize = true;
            this.lOrg.Font = new System.Drawing.Font("Bahnschrift", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lOrg.Location = new System.Drawing.Point(20, 44);
            this.lOrg.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lOrg.Name = "lOrg";
            this.lOrg.Size = new System.Drawing.Size(67, 17);
            this.lOrg.TabIndex = 13;
            this.lOrg.Text = "Organiza:";
            // 
            // bValorar
            // 
            this.bValorar.BackColor = System.Drawing.Color.Transparent;
            this.bValorar.Cursor = System.Windows.Forms.Cursors.Default;
            this.bValorar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.bValorar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bValorar.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bValorar.ForeColor = System.Drawing.Color.Black;
            this.bValorar.Location = new System.Drawing.Point(742, 165);
            this.bValorar.Margin = new System.Windows.Forms.Padding(4);
            this.bValorar.Name = "bValorar";
            this.bValorar.Size = new System.Drawing.Size(85, 40);
            this.bValorar.TabIndex = 10;
            this.bValorar.Text = "Valorar";
            this.bValorar.UseVisualStyleBackColor = false;
            // 
            // bVerMas
            // 
            this.bVerMas.FlatAppearance.BorderSize = 0;
            this.bVerMas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bVerMas.Image = ((System.Drawing.Image)(resources.GetObject("bVerMas.Image")));
            this.bVerMas.Location = new System.Drawing.Point(755, 4);
            this.bVerMas.Margin = new System.Windows.Forms.Padding(4);
            this.bVerMas.Name = "bVerMas";
            this.bVerMas.Size = new System.Drawing.Size(72, 68);
            this.bVerMas.TabIndex = 7;
            this.bVerMas.UseVisualStyleBackColor = true;
            this.bVerMas.Click += new System.EventHandler(this.bVerMas_Click);
            // 
            // labelName
            // 
            this.labelName.Font = new System.Drawing.Font("Bahnschrift", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.pict.Image = global::APS.Properties.Resources.no_image;
            this.pict.Location = new System.Drawing.Point(4, 101);
            this.pict.Margin = new System.Windows.Forms.Padding(4);
            this.pict.Name = "pict";
            this.pict.Size = new System.Drawing.Size(176, 100);
            this.pict.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pict.TabIndex = 6;
            this.pict.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // CartelActividadesValoracion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "CartelActividadesValoracion";
            this.Size = new System.Drawing.Size(840, 218);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pict)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lShowResp;
        private System.Windows.Forms.Label lResp;
        private System.Windows.Forms.Label lShowOrg;
        private System.Windows.Forms.Label lOrg;
        private System.Windows.Forms.Button bValorar;
        private System.Windows.Forms.Button bVerMas;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.PictureBox pict;
        private System.Windows.Forms.Button bExpedir;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.RichTextBox lDescripcion;
    }
}
