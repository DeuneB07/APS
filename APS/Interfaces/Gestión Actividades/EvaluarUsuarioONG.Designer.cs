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
            // 
            // bCancelar
            // 
            this.bCancelar.Location = new System.Drawing.Point(639, 530);
            this.bCancelar.Name = "bCancelar";
            this.bCancelar.Size = new System.Drawing.Size(133, 45);
            this.bCancelar.TabIndex = 1;
            this.bCancelar.Text = "Cancelar";
            this.bCancelar.UseVisualStyleBackColor = true;
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
            // EvaluarUsuarioONG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 612);
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
    }
}