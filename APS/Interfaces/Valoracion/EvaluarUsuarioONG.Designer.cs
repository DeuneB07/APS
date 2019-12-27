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
            Syncfusion.Windows.Forms.Tools.CustomImageCollection customImageCollection1 = new Syncfusion.Windows.Forms.Tools.CustomImageCollection();
            Syncfusion.Windows.Forms.Tools.ResetButton resetButton1 = new Syncfusion.Windows.Forms.Tools.ResetButton();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EvaluarUsuarioONG));
            this.ratingValoracion = new Syncfusion.Windows.Forms.Tools.RatingControl();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.textBoxComentario = new System.Windows.Forms.RichTextBox();
            this.labelComentario = new System.Windows.Forms.Label();
            this.labelValoracion = new System.Windows.Forms.Label();
            this.bCancelarEvaluacion = new System.Windows.Forms.Button();
            this.bAceptarEvaluacion = new System.Windows.Forms.Button();
            this.lblArchivoAdjunto = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.txtURL = new System.Windows.Forms.TextBox();
            this.btnExaminar = new System.Windows.Forms.Button();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.labelError = new System.Windows.Forms.Label();
            this.numericHoras = new System.Windows.Forms.NumericUpDown();
            this.labelHoras = new System.Windows.Forms.Label();
            this.userEvaluado = new System.Windows.Forms.Label();
            this.lUserEvaluado = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericHoras)).BeginInit();
            this.SuspendLayout();
            // 
            // ratingValoracion
            // 
            this.ratingValoracion.Images = customImageCollection1;
            this.ratingValoracion.ItemBackColor = System.Drawing.Color.White;
            this.ratingValoracion.ItemBorderColor = System.Drawing.Color.Black;
            this.ratingValoracion.Location = new System.Drawing.Point(116, 177);
            this.ratingValoracion.Margin = new System.Windows.Forms.Padding(2);
            this.ratingValoracion.Name = "ratingValoracion";
            this.ratingValoracion.Precision = Syncfusion.Windows.Forms.Tools.PrecisionMode.Half;
            this.ratingValoracion.ResetButton = resetButton1;
            this.ratingValoracion.Size = new System.Drawing.Size(219, 27);
            this.ratingValoracion.TabIndex = 41;
            this.ratingValoracion.Text = "ratingControl1";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.DarkCyan;
            this.lblTitulo.Location = new System.Drawing.Point(44, 7);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(347, 58);
            this.lblTitulo.TabIndex = 39;
            this.lblTitulo.Text = "¿CÓMO HA TRABAJADO EL USUARIO \r\nNOMBRE_USUARIO? ¡PUNTÚALO!";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textBoxComentario
            // 
            this.textBoxComentario.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxComentario.Location = new System.Drawing.Point(116, 222);
            this.textBoxComentario.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxComentario.Name = "textBoxComentario";
            this.textBoxComentario.Size = new System.Drawing.Size(223, 88);
            this.textBoxComentario.TabIndex = 37;
            this.textBoxComentario.Text = "";
            // 
            // labelComentario
            // 
            this.labelComentario.AutoSize = true;
            this.labelComentario.Font = new System.Drawing.Font("Bahnschrift", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelComentario.Location = new System.Drawing.Point(29, 222);
            this.labelComentario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelComentario.Name = "labelComentario";
            this.labelComentario.Size = new System.Drawing.Size(86, 17);
            this.labelComentario.TabIndex = 36;
            this.labelComentario.Text = "Comentario:";
            // 
            // labelValoracion
            // 
            this.labelValoracion.AutoSize = true;
            this.labelValoracion.Font = new System.Drawing.Font("Bahnschrift", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelValoracion.Location = new System.Drawing.Point(37, 177);
            this.labelValoracion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelValoracion.Name = "labelValoracion";
            this.labelValoracion.Size = new System.Drawing.Size(78, 17);
            this.labelValoracion.TabIndex = 34;
            this.labelValoracion.Text = "Valoración:";
            // 
            // bCancelarEvaluacion
            // 
            this.bCancelarEvaluacion.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bCancelarEvaluacion.Font = new System.Drawing.Font("Modern No. 20", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bCancelarEvaluacion.Location = new System.Drawing.Point(294, 413);
            this.bCancelarEvaluacion.Margin = new System.Windows.Forms.Padding(2);
            this.bCancelarEvaluacion.Name = "bCancelarEvaluacion";
            this.bCancelarEvaluacion.Size = new System.Drawing.Size(74, 24);
            this.bCancelarEvaluacion.TabIndex = 33;
            this.bCancelarEvaluacion.Text = "Cancelar";
            this.bCancelarEvaluacion.UseVisualStyleBackColor = true;
            this.bCancelarEvaluacion.Click += new System.EventHandler(this.bCancelar_Click);
            // 
            // bAceptarEvaluacion
            // 
            this.bAceptarEvaluacion.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bAceptarEvaluacion.Font = new System.Drawing.Font("Modern No. 20", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bAceptarEvaluacion.Location = new System.Drawing.Point(209, 413);
            this.bAceptarEvaluacion.Margin = new System.Windows.Forms.Padding(2);
            this.bAceptarEvaluacion.Name = "bAceptarEvaluacion";
            this.bAceptarEvaluacion.Size = new System.Drawing.Size(68, 24);
            this.bAceptarEvaluacion.TabIndex = 32;
            this.bAceptarEvaluacion.Text = "Aceptar";
            this.bAceptarEvaluacion.UseVisualStyleBackColor = true;
            this.bAceptarEvaluacion.Click += new System.EventHandler(this.bAceptar_Click);
            // 
            // lblArchivoAdjunto
            // 
            this.lblArchivoAdjunto.AutoSize = true;
            this.lblArchivoAdjunto.Font = new System.Drawing.Font("Bahnschrift", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArchivoAdjunto.Location = new System.Drawing.Point(29, 339);
            this.lblArchivoAdjunto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblArchivoAdjunto.Name = "lblArchivoAdjunto";
            this.lblArchivoAdjunto.Size = new System.Drawing.Size(114, 17);
            this.lblArchivoAdjunto.TabIndex = 42;
            this.lblArchivoAdjunto.Text = "Archivo Adjunto:";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // txtURL
            // 
            this.txtURL.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtURL.Location = new System.Drawing.Point(146, 340);
            this.txtURL.Margin = new System.Windows.Forms.Padding(2);
            this.txtURL.Name = "txtURL";
            this.txtURL.Size = new System.Drawing.Size(151, 22);
            this.txtURL.TabIndex = 43;
            // 
            // btnExaminar
            // 
            this.btnExaminar.Font = new System.Drawing.Font("Bahnschrift", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExaminar.Location = new System.Drawing.Point(304, 340);
            this.btnExaminar.Margin = new System.Windows.Forms.Padding(2);
            this.btnExaminar.Name = "btnExaminar";
            this.btnExaminar.Size = new System.Drawing.Size(74, 19);
            this.btnExaminar.TabIndex = 44;
            this.btnExaminar.Text = "Examinar";
            this.btnExaminar.UseVisualStyleBackColor = true;
            this.btnExaminar.Click += new System.EventHandler(this.btnExaminar_Click);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.BackColor = System.Drawing.Color.Transparent;
            this.labelError.Font = new System.Drawing.Font("Bahnschrift", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelError.ForeColor = System.Drawing.Color.Red;
            this.labelError.Location = new System.Drawing.Point(28, 413);
            this.labelError.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(34, 13);
            this.labelError.TabIndex = 45;
            this.labelError.Text = "error";
            // 
            // numericHoras
            // 
            this.numericHoras.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericHoras.Location = new System.Drawing.Point(146, 131);
            this.numericHoras.Margin = new System.Windows.Forms.Padding(2);
            this.numericHoras.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericHoras.Name = "numericHoras";
            this.numericHoras.Size = new System.Drawing.Size(90, 22);
            this.numericHoras.TabIndex = 47;
            // 
            // labelHoras
            // 
            this.labelHoras.AutoSize = true;
            this.labelHoras.Font = new System.Drawing.Font("Bahnschrift", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHoras.Location = new System.Drawing.Point(29, 129);
            this.labelHoras.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelHoras.Name = "labelHoras";
            this.labelHoras.Size = new System.Drawing.Size(117, 17);
            this.labelHoras.TabIndex = 46;
            this.labelHoras.Text = "Horas Invertidas:";
            // 
            // userEvaluado
            // 
            this.userEvaluado.AutoSize = true;
            this.userEvaluado.Font = new System.Drawing.Font("Bahnschrift", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userEvaluado.Location = new System.Drawing.Point(29, 96);
            this.userEvaluado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.userEvaluado.Name = "userEvaluado";
            this.userEvaluado.Size = new System.Drawing.Size(121, 17);
            this.userEvaluado.TabIndex = 48;
            this.userEvaluado.Text = "Usuario Evaluado:";
            // 
            // lUserEvaluado
            // 
            this.lUserEvaluado.AutoSize = true;
            this.lUserEvaluado.Font = new System.Drawing.Font("Bahnschrift", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lUserEvaluado.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lUserEvaluado.Location = new System.Drawing.Point(153, 99);
            this.lUserEvaluado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lUserEvaluado.Name = "lUserEvaluado";
            this.lUserEvaluado.Size = new System.Drawing.Size(49, 14);
            this.lUserEvaluado.TabIndex = 49;
            this.lUserEvaluado.Text = "nombre";
            // 
            // EvaluarUsuarioONG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(403, 459);
            this.Controls.Add(this.lUserEvaluado);
            this.Controls.Add(this.userEvaluado);
            this.Controls.Add(this.numericHoras);
            this.Controls.Add(this.labelHoras);
            this.Controls.Add(this.labelError);
            this.Controls.Add(this.btnExaminar);
            this.Controls.Add(this.txtURL);
            this.Controls.Add(this.lblArchivoAdjunto);
            this.Controls.Add(this.ratingValoracion);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.textBoxComentario);
            this.Controls.Add(this.labelComentario);
            this.Controls.Add(this.labelValoracion);
            this.Controls.Add(this.bCancelarEvaluacion);
            this.Controls.Add(this.bAceptarEvaluacion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "EvaluarUsuarioONG";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Evaluar al Participante";
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericHoras)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Syncfusion.Windows.Forms.Tools.RatingControl ratingValoracion;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.RichTextBox textBoxComentario;
        private System.Windows.Forms.Label labelComentario;
        private System.Windows.Forms.Label labelValoracion;
        private System.Windows.Forms.Button bCancelarEvaluacion;
        private System.Windows.Forms.Button bAceptarEvaluacion;
        private System.Windows.Forms.Label lblArchivoAdjunto;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox txtURL;
        private System.Windows.Forms.Button btnExaminar;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Label labelError;
        private System.Windows.Forms.NumericUpDown numericHoras;
        private System.Windows.Forms.Label labelHoras;
        private System.Windows.Forms.Label userEvaluado;
        private System.Windows.Forms.Label lUserEvaluado;
    }
}