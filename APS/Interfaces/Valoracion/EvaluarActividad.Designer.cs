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
            Syncfusion.Windows.Forms.Tools.CustomImageCollection customImageCollection1 = new Syncfusion.Windows.Forms.Tools.CustomImageCollection();
            Syncfusion.Windows.Forms.Tools.ResetButton resetButton1 = new Syncfusion.Windows.Forms.Tools.ResetButton();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EvaluarActividad));
            this.bAceptarEvaluacion = new System.Windows.Forms.Button();
            this.bCancelarEvaluacion = new System.Windows.Forms.Button();
            this.labelValoracion = new System.Windows.Forms.Label();
            this.labelComentario = new System.Windows.Forms.Label();
            this.textBoxComentario = new System.Windows.Forms.RichTextBox();
            this.labelError = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.ratingValoracion = new Syncfusion.Windows.Forms.Tools.RatingControl();
            this.SuspendLayout();
            // 
            // bAceptarEvaluacion
            // 
            this.bAceptarEvaluacion.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bAceptarEvaluacion.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bAceptarEvaluacion.Location = new System.Drawing.Point(205, 328);
            this.bAceptarEvaluacion.Margin = new System.Windows.Forms.Padding(2);
            this.bAceptarEvaluacion.Name = "bAceptarEvaluacion";
            this.bAceptarEvaluacion.Size = new System.Drawing.Size(68, 24);
            this.bAceptarEvaluacion.TabIndex = 0;
            this.bAceptarEvaluacion.Text = "Aceptar";
            this.bAceptarEvaluacion.UseVisualStyleBackColor = true;
            this.bAceptarEvaluacion.Click += new System.EventHandler(this.bAceptarEvaluacion_Click_1);
            // 
            // bCancelarEvaluacion
            // 
            this.bCancelarEvaluacion.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bCancelarEvaluacion.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bCancelarEvaluacion.Location = new System.Drawing.Point(286, 328);
            this.bCancelarEvaluacion.Margin = new System.Windows.Forms.Padding(2);
            this.bCancelarEvaluacion.Name = "bCancelarEvaluacion";
            this.bCancelarEvaluacion.Size = new System.Drawing.Size(74, 24);
            this.bCancelarEvaluacion.TabIndex = 1;
            this.bCancelarEvaluacion.Text = "Cancelar";
            this.bCancelarEvaluacion.UseVisualStyleBackColor = true;
            this.bCancelarEvaluacion.Click += new System.EventHandler(this.bCancelarEvaluacion_Click_1);
            // 
            // labelValoracion
            // 
            this.labelValoracion.AutoSize = true;
            this.labelValoracion.Font = new System.Drawing.Font("Bahnschrift", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelValoracion.Location = new System.Drawing.Point(31, 146);
            this.labelValoracion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelValoracion.Name = "labelValoracion";
            this.labelValoracion.Size = new System.Drawing.Size(78, 17);
            this.labelValoracion.TabIndex = 4;
            this.labelValoracion.Text = "Valoración:";
            // 
            // labelComentario
            // 
            this.labelComentario.AutoSize = true;
            this.labelComentario.Font = new System.Drawing.Font("Bahnschrift", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelComentario.Location = new System.Drawing.Point(21, 210);
            this.labelComentario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelComentario.Name = "labelComentario";
            this.labelComentario.Size = new System.Drawing.Size(86, 17);
            this.labelComentario.TabIndex = 6;
            this.labelComentario.Text = "Comentario:";
            // 
            // textBoxComentario
            // 
            this.textBoxComentario.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxComentario.Location = new System.Drawing.Point(107, 210);
            this.textBoxComentario.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxComentario.Name = "textBoxComentario";
            this.textBoxComentario.Size = new System.Drawing.Size(230, 88);
            this.textBoxComentario.TabIndex = 17;
            this.textBoxComentario.Text = "";
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.BackColor = System.Drawing.Color.Transparent;
            this.labelError.Font = new System.Drawing.Font("Bahnschrift", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelError.ForeColor = System.Drawing.Color.Red;
            this.labelError.Location = new System.Drawing.Point(21, 328);
            this.labelError.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(34, 13);
            this.labelError.TabIndex = 28;
            this.labelError.Text = "error";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.DarkCyan;
            this.lblTitulo.Location = new System.Drawing.Point(9, 7);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(391, 58);
            this.lblTitulo.TabIndex = 29;
            this.lblTitulo.Text = "¿QUÉ TAL TE HA PARECIDO LA ACTIVIDAD\r\nNOMBRE_ACTIVIDAD? ¡PUNTÚALA!";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ratingValoracion
            // 
            this.ratingValoracion.Images = customImageCollection1;
            this.ratingValoracion.ItemBackColor = System.Drawing.Color.White;
            this.ratingValoracion.ItemBorderColor = System.Drawing.Color.Black;
            this.ratingValoracion.Location = new System.Drawing.Point(117, 141);
            this.ratingValoracion.Margin = new System.Windows.Forms.Padding(2);
            this.ratingValoracion.Name = "ratingValoracion";
            this.ratingValoracion.Precision = Syncfusion.Windows.Forms.Tools.PrecisionMode.Half;
            this.ratingValoracion.ResetButton = resetButton1;
            this.ratingValoracion.Size = new System.Drawing.Size(219, 27);
            this.ratingValoracion.TabIndex = 31;
            this.ratingValoracion.Text = "ratingControl1";
            // 
            // EvaluarActividad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(406, 382);
            this.Controls.Add(this.ratingValoracion);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.labelError);
            this.Controls.Add(this.textBoxComentario);
            this.Controls.Add(this.labelComentario);
            this.Controls.Add(this.labelValoracion);
            this.Controls.Add(this.bCancelarEvaluacion);
            this.Controls.Add(this.bAceptarEvaluacion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "EvaluarActividad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "EvaluarActividad";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bAceptarEvaluacion;
        private System.Windows.Forms.Button bCancelarEvaluacion;
        private System.Windows.Forms.Label labelValoracion;
        private System.Windows.Forms.Label labelComentario;
        private System.Windows.Forms.RichTextBox textBoxComentario;
        private System.Windows.Forms.Label labelError;
        private System.Windows.Forms.Label lblTitulo;
        private Syncfusion.Windows.Forms.Tools.RatingControl ratingValoracion;
    }
}