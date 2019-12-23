namespace APS.Interfaces.Gestión_Actividades
{
    partial class EvaluarActividad
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
            this.bAceptarEvaluacion = new System.Windows.Forms.Button();
            this.bCancelarEvaluacion = new System.Windows.Forms.Button();
            this.labelParticipante = new System.Windows.Forms.Label();
            this.lParticipante = new System.Windows.Forms.Label();
            this.labelValoracion = new System.Windows.Forms.Label();
            this.labelHoras = new System.Windows.Forms.Label();
            this.labelComentario = new System.Windows.Forms.Label();
            this.textBoxValoracion = new System.Windows.Forms.TextBox();
            this.textBoxHoras = new System.Windows.Forms.TextBox();
            this.textBoxComentario = new System.Windows.Forms.RichTextBox();
            this.labelError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bAceptarEvaluacion
            // 
            this.bAceptarEvaluacion.Location = new System.Drawing.Point(611, 694);
            this.bAceptarEvaluacion.Name = "bAceptarEvaluacion";
            this.bAceptarEvaluacion.Size = new System.Drawing.Size(114, 46);
            this.bAceptarEvaluacion.TabIndex = 0;
            this.bAceptarEvaluacion.Text = "Aceptar";
            this.bAceptarEvaluacion.UseVisualStyleBackColor = true;
            this.bAceptarEvaluacion.Click += new System.EventHandler(this.bAceptarEvaluacion_Click_1);
            // 
            // bCancelarEvaluacion
            // 
            this.bCancelarEvaluacion.Location = new System.Drawing.Point(759, 694);
            this.bCancelarEvaluacion.Name = "bCancelarEvaluacion";
            this.bCancelarEvaluacion.Size = new System.Drawing.Size(137, 46);
            this.bCancelarEvaluacion.TabIndex = 1;
            this.bCancelarEvaluacion.Text = "Cancelar";
            this.bCancelarEvaluacion.UseVisualStyleBackColor = true;
            this.bCancelarEvaluacion.Click += new System.EventHandler(this.bCancelarEvaluacion_Click_1);
            // 
            // labelParticipante
            // 
            this.labelParticipante.AutoSize = true;
            this.labelParticipante.Location = new System.Drawing.Point(229, 202);
            this.labelParticipante.Name = "labelParticipante";
            this.labelParticipante.Size = new System.Drawing.Size(132, 25);
            this.labelParticipante.TabIndex = 2;
            this.labelParticipante.Text = "Participante:";
            // 
            // lParticipante
            // 
            this.lParticipante.AutoSize = true;
            this.lParticipante.Location = new System.Drawing.Point(409, 202);
            this.lParticipante.Name = "lParticipante";
            this.lParticipante.Size = new System.Drawing.Size(177, 25);
            this.lParticipante.TabIndex = 3;
            this.lParticipante.Text = "emailParticipante";
            // 
            // labelValoracion
            // 
            this.labelValoracion.AutoSize = true;
            this.labelValoracion.Location = new System.Drawing.Point(229, 311);
            this.labelValoracion.Name = "labelValoracion";
            this.labelValoracion.Size = new System.Drawing.Size(120, 25);
            this.labelValoracion.TabIndex = 4;
            this.labelValoracion.Text = "Valoracion:";
            // 
            // labelHoras
            // 
            this.labelHoras.AutoSize = true;
            this.labelHoras.Location = new System.Drawing.Point(229, 412);
            this.labelHoras.Name = "labelHoras";
            this.labelHoras.Size = new System.Drawing.Size(174, 25);
            this.labelHoras.TabIndex = 5;
            this.labelHoras.Text = "Horas Invertidas:";
            // 
            // labelComentario
            // 
            this.labelComentario.AutoSize = true;
            this.labelComentario.Location = new System.Drawing.Point(233, 507);
            this.labelComentario.Name = "labelComentario";
            this.labelComentario.Size = new System.Drawing.Size(128, 25);
            this.labelComentario.TabIndex = 6;
            this.labelComentario.Text = "Comentario:";
            // 
            // textBoxValoracion
            // 
            this.textBoxValoracion.Location = new System.Drawing.Point(414, 311);
            this.textBoxValoracion.Name = "textBoxValoracion";
            this.textBoxValoracion.Size = new System.Drawing.Size(64, 31);
            this.textBoxValoracion.TabIndex = 7;
            // 
            // textBoxHoras
            // 
            this.textBoxHoras.Location = new System.Drawing.Point(437, 409);
            this.textBoxHoras.Name = "textBoxHoras";
            this.textBoxHoras.Size = new System.Drawing.Size(64, 31);
            this.textBoxHoras.TabIndex = 8;
            // 
            // textBoxComentario
            // 
            this.textBoxComentario.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxComentario.Location = new System.Drawing.Point(407, 500);
            this.textBoxComentario.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxComentario.Name = "textBoxComentario";
            this.textBoxComentario.Size = new System.Drawing.Size(332, 110);
            this.textBoxComentario.TabIndex = 17;
            this.textBoxComentario.Text = "";
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.BackColor = System.Drawing.Color.Transparent;
            this.labelError.Font = new System.Drawing.Font("Bahnschrift", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelError.ForeColor = System.Drawing.Color.Red;
            this.labelError.Location = new System.Drawing.Point(42, 713);
            this.labelError.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(63, 27);
            this.labelError.TabIndex = 28;
            this.labelError.Text = "error";
            // 
            // EvaluarActividad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 788);
            this.Controls.Add(this.labelError);
            this.Controls.Add(this.textBoxComentario);
            this.Controls.Add(this.textBoxHoras);
            this.Controls.Add(this.textBoxValoracion);
            this.Controls.Add(this.labelComentario);
            this.Controls.Add(this.labelHoras);
            this.Controls.Add(this.labelValoracion);
            this.Controls.Add(this.lParticipante);
            this.Controls.Add(this.labelParticipante);
            this.Controls.Add(this.bCancelarEvaluacion);
            this.Controls.Add(this.bAceptarEvaluacion);
            this.Name = "EvaluarActividad";
            this.Text = "EvaluarActividad";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bAceptarEvaluacion;
        private System.Windows.Forms.Button bCancelarEvaluacion;
        private System.Windows.Forms.Label labelParticipante;
        private System.Windows.Forms.Label lParticipante;
        private System.Windows.Forms.Label labelValoracion;
        private System.Windows.Forms.Label labelHoras;
        private System.Windows.Forms.Label labelComentario;
        private System.Windows.Forms.TextBox textBoxValoracion;
        private System.Windows.Forms.TextBox textBoxHoras;
        private System.Windows.Forms.RichTextBox textBoxComentario;
        private System.Windows.Forms.Label labelError;
    }
}