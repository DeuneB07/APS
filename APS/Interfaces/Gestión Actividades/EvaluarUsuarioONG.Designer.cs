namespace APS.Interfaces.Gestión_Actividades
{
    partial class EvaluarUsuarioONG
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
            this.bAceptar = new System.Windows.Forms.Button();
            this.bCancelar = new System.Windows.Forms.Button();
            this.labelValoracion = new System.Windows.Forms.Label();
            this.labelComentario = new System.Windows.Forms.Label();
            this.textBoxValoracion = new System.Windows.Forms.TextBox();
            this.textBoxComentario = new System.Windows.Forms.RichTextBox();
            this.labelError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bAceptar
            // 
            this.bAceptar.Location = new System.Drawing.Point(511, 527);
            this.bAceptar.Name = "bAceptar";
            this.bAceptar.Size = new System.Drawing.Size(104, 51);
            this.bAceptar.TabIndex = 0;
            this.bAceptar.Text = "Aceptar";
            this.bAceptar.UseVisualStyleBackColor = true;
            this.bAceptar.Click += new System.EventHandler(this.bAceptar_Click);
            // 
            // bCancelar
            // 
            this.bCancelar.Location = new System.Drawing.Point(639, 530);
            this.bCancelar.Name = "bCancelar";
            this.bCancelar.Size = new System.Drawing.Size(133, 45);
            this.bCancelar.TabIndex = 1;
            this.bCancelar.Text = "Cancelar";
            this.bCancelar.UseVisualStyleBackColor = true;
            this.bCancelar.Click += new System.EventHandler(this.bCancelar_Click);
            // 
            // labelValoracion
            // 
            this.labelValoracion.AutoSize = true;
            this.labelValoracion.Location = new System.Drawing.Point(169, 173);
            this.labelValoracion.Name = "labelValoracion";
            this.labelValoracion.Size = new System.Drawing.Size(120, 25);
            this.labelValoracion.TabIndex = 2;
            this.labelValoracion.Text = "Valoracion:";
            // 
            // labelComentario
            // 
            this.labelComentario.AutoSize = true;
            this.labelComentario.Location = new System.Drawing.Point(169, 305);
            this.labelComentario.Name = "labelComentario";
            this.labelComentario.Size = new System.Drawing.Size(128, 25);
            this.labelComentario.TabIndex = 3;
            this.labelComentario.Text = "Comentario:";
            // 
            // textBoxValoracion
            // 
            this.textBoxValoracion.Location = new System.Drawing.Point(318, 173);
            this.textBoxValoracion.Name = "textBoxValoracion";
            this.textBoxValoracion.Size = new System.Drawing.Size(57, 31);
            this.textBoxValoracion.TabIndex = 4;
            // 
            // textBoxComentario
            // 
            this.textBoxComentario.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxComentario.Location = new System.Drawing.Point(318, 305);
            this.textBoxComentario.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxComentario.Name = "textBoxComentario";
            this.textBoxComentario.Size = new System.Drawing.Size(332, 110);
            this.textBoxComentario.TabIndex = 18;
            this.textBoxComentario.Text = "";
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.BackColor = System.Drawing.Color.Transparent;
            this.labelError.Font = new System.Drawing.Font("Bahnschrift", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelError.ForeColor = System.Drawing.Color.Red;
            this.labelError.Location = new System.Drawing.Point(32, 551);
            this.labelError.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(63, 27);
            this.labelError.TabIndex = 29;
            this.labelError.Text = "error";
            // 
            // EvaluarUsuarioONG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 617);
            this.Controls.Add(this.labelError);
            this.Controls.Add(this.textBoxComentario);
            this.Controls.Add(this.textBoxValoracion);
            this.Controls.Add(this.labelComentario);
            this.Controls.Add(this.labelValoracion);
            this.Controls.Add(this.bCancelar);
            this.Controls.Add(this.bAceptar);
            this.Name = "EvaluarUsuarioONG";
            this.Text = "EvaluarUsuarioONG";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bAceptar;
        private System.Windows.Forms.Button bCancelar;
        private System.Windows.Forms.Label labelValoracion;
        private System.Windows.Forms.Label labelComentario;
        private System.Windows.Forms.TextBox textBoxValoracion;
        private System.Windows.Forms.RichTextBox textBoxComentario;
        private System.Windows.Forms.Label labelError;
    }
}