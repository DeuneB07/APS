namespace APS.Interfaces.Gestión_Actividades
{
    partial class EvaluarUsuarioPDI
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
            Syncfusion.Windows.Forms.Tools.CustomImageCollection customImageCollection2 = new Syncfusion.Windows.Forms.Tools.CustomImageCollection();
            Syncfusion.Windows.Forms.Tools.ResetButton resetButton2 = new Syncfusion.Windows.Forms.Tools.ResetButton();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EvaluarUsuarioPDI));
            this.labelError = new System.Windows.Forms.Label();
            this.textBoxComentarioPDI = new System.Windows.Forms.RichTextBox();
            this.labelComentario = new System.Windows.Forms.Label();
            this.bCancelar = new System.Windows.Forms.Button();
            this.bAceptar = new System.Windows.Forms.Button();
            this.labelValoracionONG = new System.Windows.Forms.Label();
            this.labelComentarioONG = new System.Windows.Forms.Label();
            this.textBoxComentarioONG = new System.Windows.Forms.RichTextBox();
            this.labelValoracionPDI = new System.Windows.Forms.Label();
            this.lHoras = new System.Windows.Forms.Label();
            this.lblHorasInvertidas = new System.Windows.Forms.Label();
            this.lblArchivoAdjunto = new System.Windows.Forms.Label();
            this.btnDescargar = new System.Windows.Forms.Button();
            this.txtNombreArchivo = new System.Windows.Forms.TextBox();
            this.ratingONG = new Syncfusion.Windows.Forms.Tools.RatingControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lNombreOrganizador = new System.Windows.Forms.Label();
            this.lblOrganizador = new System.Windows.Forms.Label();
            this.lblTitONG = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lNombreActividad = new System.Windows.Forms.Label();
            this.lblActividad = new System.Windows.Forms.Label();
            this.lUserEvaluado = new System.Windows.Forms.Label();
            this.userEvaluado = new System.Windows.Forms.Label();
            this.ratingPDI = new Syncfusion.Windows.Forms.Tools.RatingControl();
            this.lblTitPDI = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.BackColor = System.Drawing.Color.Transparent;
            this.labelError.Font = new System.Drawing.Font("Bahnschrift", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelError.ForeColor = System.Drawing.Color.Red;
            this.labelError.Location = new System.Drawing.Point(26, 287);
            this.labelError.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(34, 13);
            this.labelError.TabIndex = 36;
            this.labelError.Text = "error";
            // 
            // textBoxComentarioPDI
            // 
            this.textBoxComentarioPDI.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxComentarioPDI.Location = new System.Drawing.Point(144, 195);
            this.textBoxComentarioPDI.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxComentarioPDI.Name = "textBoxComentarioPDI";
            this.textBoxComentarioPDI.Size = new System.Drawing.Size(180, 59);
            this.textBoxComentarioPDI.TabIndex = 35;
            this.textBoxComentarioPDI.Text = "";
            // 
            // labelComentario
            // 
            this.labelComentario.AutoSize = true;
            this.labelComentario.Font = new System.Drawing.Font("Bahnschrift", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelComentario.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelComentario.Location = new System.Drawing.Point(25, 195);
            this.labelComentario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelComentario.Name = "labelComentario";
            this.labelComentario.Size = new System.Drawing.Size(118, 17);
            this.labelComentario.TabIndex = 33;
            this.labelComentario.Text = "Comentario ONG:";
            // 
            // bCancelar
            // 
            this.bCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bCancelar.Font = new System.Drawing.Font("Modern No. 20", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bCancelar.Location = new System.Drawing.Point(621, 394);
            this.bCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.bCancelar.Name = "bCancelar";
            this.bCancelar.Size = new System.Drawing.Size(79, 27);
            this.bCancelar.TabIndex = 31;
            this.bCancelar.Text = "Cancelar";
            this.bCancelar.UseVisualStyleBackColor = true;
            this.bCancelar.Click += new System.EventHandler(this.bCancelar_Click);
            // 
            // bAceptar
            // 
            this.bAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bAceptar.Font = new System.Drawing.Font("Modern No. 20", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bAceptar.Location = new System.Drawing.Point(520, 394);
            this.bAceptar.Margin = new System.Windows.Forms.Padding(2);
            this.bAceptar.Name = "bAceptar";
            this.bAceptar.Size = new System.Drawing.Size(82, 27);
            this.bAceptar.TabIndex = 30;
            this.bAceptar.Text = "Aceptar";
            this.bAceptar.UseVisualStyleBackColor = true;
            this.bAceptar.Click += new System.EventHandler(this.bAceptar_Click);
            // 
            // labelValoracionONG
            // 
            this.labelValoracionONG.AutoSize = true;
            this.labelValoracionONG.Font = new System.Drawing.Font("Bahnschrift", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelValoracionONG.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelValoracionONG.Location = new System.Drawing.Point(16, 140);
            this.labelValoracionONG.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelValoracionONG.Name = "labelValoracionONG";
            this.labelValoracionONG.Size = new System.Drawing.Size(110, 17);
            this.labelValoracionONG.TabIndex = 37;
            this.labelValoracionONG.Text = "Valoracion ONG:";
            // 
            // labelComentarioONG
            // 
            this.labelComentarioONG.AutoSize = true;
            this.labelComentarioONG.Font = new System.Drawing.Font("Bahnschrift", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelComentarioONG.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelComentarioONG.Location = new System.Drawing.Point(16, 194);
            this.labelComentarioONG.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelComentarioONG.Name = "labelComentarioONG";
            this.labelComentarioONG.Size = new System.Drawing.Size(118, 17);
            this.labelComentarioONG.TabIndex = 38;
            this.labelComentarioONG.Text = "Comentario ONG:";
            // 
            // textBoxComentarioONG
            // 
            this.textBoxComentarioONG.Enabled = false;
            this.textBoxComentarioONG.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxComentarioONG.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.textBoxComentarioONG.Location = new System.Drawing.Point(135, 194);
            this.textBoxComentarioONG.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxComentarioONG.Name = "textBoxComentarioONG";
            this.textBoxComentarioONG.ReadOnly = true;
            this.textBoxComentarioONG.Size = new System.Drawing.Size(168, 59);
            this.textBoxComentarioONG.TabIndex = 39;
            this.textBoxComentarioONG.Text = "";
            // 
            // labelValoracionPDI
            // 
            this.labelValoracionPDI.AutoSize = true;
            this.labelValoracionPDI.Font = new System.Drawing.Font("Bahnschrift", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelValoracionPDI.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelValoracionPDI.Location = new System.Drawing.Point(25, 141);
            this.labelValoracionPDI.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelValoracionPDI.Name = "labelValoracionPDI";
            this.labelValoracionPDI.Size = new System.Drawing.Size(104, 17);
            this.labelValoracionPDI.TabIndex = 40;
            this.labelValoracionPDI.Text = "Valoracion PDI:";
            // 
            // lHoras
            // 
            this.lHoras.AutoSize = true;
            this.lHoras.Font = new System.Drawing.Font("Bahnschrift Condensed", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lHoras.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lHoras.Location = new System.Drawing.Point(133, 98);
            this.lHoras.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lHoras.Name = "lHoras";
            this.lHoras.Size = new System.Drawing.Size(92, 17);
            this.lHoras.TabIndex = 42;
            this.lHoras.Text = "horasParticipante";
            // 
            // lblHorasInvertidas
            // 
            this.lblHorasInvertidas.AutoSize = true;
            this.lblHorasInvertidas.Font = new System.Drawing.Font("Bahnschrift", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHorasInvertidas.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblHorasInvertidas.Location = new System.Drawing.Point(14, 96);
            this.lblHorasInvertidas.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHorasInvertidas.Name = "lblHorasInvertidas";
            this.lblHorasInvertidas.Size = new System.Drawing.Size(117, 17);
            this.lblHorasInvertidas.TabIndex = 48;
            this.lblHorasInvertidas.Text = "Horas Invertidas:";
            // 
            // lblArchivoAdjunto
            // 
            this.lblArchivoAdjunto.AutoSize = true;
            this.lblArchivoAdjunto.Font = new System.Drawing.Font("Bahnschrift", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArchivoAdjunto.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblArchivoAdjunto.Location = new System.Drawing.Point(16, 280);
            this.lblArchivoAdjunto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblArchivoAdjunto.Name = "lblArchivoAdjunto";
            this.lblArchivoAdjunto.Size = new System.Drawing.Size(114, 17);
            this.lblArchivoAdjunto.TabIndex = 49;
            this.lblArchivoAdjunto.Text = "Archivo Adjunto:";
            // 
            // btnDescargar
            // 
            this.btnDescargar.Enabled = false;
            this.btnDescargar.Font = new System.Drawing.Font("Bahnschrift", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDescargar.Location = new System.Drawing.Point(248, 282);
            this.btnDescargar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDescargar.Name = "btnDescargar";
            this.btnDescargar.Size = new System.Drawing.Size(76, 19);
            this.btnDescargar.TabIndex = 51;
            this.btnDescargar.Text = "Descargar";
            this.btnDescargar.UseVisualStyleBackColor = true;
            this.btnDescargar.Click += new System.EventHandler(this.btnDescargar_Click);
            // 
            // txtNombreArchivo
            // 
            this.txtNombreArchivo.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreArchivo.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.txtNombreArchivo.Location = new System.Drawing.Point(136, 282);
            this.txtNombreArchivo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNombreArchivo.Name = "txtNombreArchivo";
            this.txtNombreArchivo.ReadOnly = true;
            this.txtNombreArchivo.Size = new System.Drawing.Size(104, 22);
            this.txtNombreArchivo.TabIndex = 50;
            // 
            // ratingONG
            // 
            this.ratingONG.Enabled = false;
            this.ratingONG.Images = customImageCollection1;
            this.ratingONG.ItemBackColor = System.Drawing.Color.White;
            this.ratingONG.ItemBorderColor = System.Drawing.Color.Black;
            this.ratingONG.Location = new System.Drawing.Point(135, 140);
            this.ratingONG.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ratingONG.Name = "ratingONG";
            this.ratingONG.Precision = Syncfusion.Windows.Forms.Tools.PrecisionMode.Half;
            this.ratingONG.ResetButton = resetButton1;
            this.ratingONG.Size = new System.Drawing.Size(167, 27);
            this.ratingONG.TabIndex = 52;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lNombreOrganizador);
            this.panel1.Controls.Add(this.lblOrganizador);
            this.panel1.Controls.Add(this.lblTitONG);
            this.panel1.Controls.Add(this.ratingONG);
            this.panel1.Controls.Add(this.btnDescargar);
            this.panel1.Controls.Add(this.txtNombreArchivo);
            this.panel1.Controls.Add(this.lblArchivoAdjunto);
            this.panel1.Controls.Add(this.lblHorasInvertidas);
            this.panel1.Controls.Add(this.lHoras);
            this.panel1.Controls.Add(this.textBoxComentarioONG);
            this.panel1.Controls.Add(this.labelComentarioONG);
            this.panel1.Controls.Add(this.labelValoracionONG);
            this.panel1.Location = new System.Drawing.Point(13, 55);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(338, 329);
            this.panel1.TabIndex = 53;
            // 
            // lNombreOrganizador
            // 
            this.lNombreOrganizador.AutoSize = true;
            this.lNombreOrganizador.Font = new System.Drawing.Font("Bahnschrift Condensed", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lNombreOrganizador.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lNombreOrganizador.Location = new System.Drawing.Point(132, 61);
            this.lNombreOrganizador.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lNombreOrganizador.Name = "lNombreOrganizador";
            this.lNombreOrganizador.Size = new System.Drawing.Size(43, 17);
            this.lNombreOrganizador.TabIndex = 58;
            this.lNombreOrganizador.Text = "nombre";
            // 
            // lblOrganizador
            // 
            this.lblOrganizador.AutoSize = true;
            this.lblOrganizador.Font = new System.Drawing.Font("Bahnschrift", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrganizador.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblOrganizador.Location = new System.Drawing.Point(37, 61);
            this.lblOrganizador.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOrganizador.Name = "lblOrganizador";
            this.lblOrganizador.Size = new System.Drawing.Size(88, 17);
            this.lblOrganizador.TabIndex = 57;
            this.lblOrganizador.Text = "Organizador:";
            // 
            // lblTitONG
            // 
            this.lblTitONG.AutoSize = true;
            this.lblTitONG.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitONG.ForeColor = System.Drawing.Color.DarkGray;
            this.lblTitONG.Location = new System.Drawing.Point(14, 7);
            this.lblTitONG.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitONG.Name = "lblTitONG";
            this.lblTitONG.Size = new System.Drawing.Size(120, 19);
            this.lblTitONG.TabIndex = 53;
            this.lblTitONG.Text = "VALORACIÓN ONG";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lNombreActividad);
            this.panel2.Controls.Add(this.lblActividad);
            this.panel2.Controls.Add(this.lUserEvaluado);
            this.panel2.Controls.Add(this.userEvaluado);
            this.panel2.Controls.Add(this.ratingPDI);
            this.panel2.Controls.Add(this.lblTitPDI);
            this.panel2.Controls.Add(this.labelValoracionPDI);
            this.panel2.Controls.Add(this.labelError);
            this.panel2.Controls.Add(this.textBoxComentarioPDI);
            this.panel2.Controls.Add(this.labelComentario);
            this.panel2.Location = new System.Drawing.Point(350, 55);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(351, 329);
            this.panel2.TabIndex = 54;
            // 
            // lNombreActividad
            // 
            this.lNombreActividad.AutoSize = true;
            this.lNombreActividad.Font = new System.Drawing.Font("Bahnschrift", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lNombreActividad.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lNombreActividad.Location = new System.Drawing.Point(149, 90);
            this.lNombreActividad.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lNombreActividad.Name = "lNombreActividad";
            this.lNombreActividad.Size = new System.Drawing.Size(49, 14);
            this.lNombreActividad.TabIndex = 58;
            this.lNombreActividad.Text = "nombre";
            // 
            // lblActividad
            // 
            this.lblActividad.AutoSize = true;
            this.lblActividad.Font = new System.Drawing.Font("Bahnschrift", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActividad.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblActividad.Location = new System.Drawing.Point(15, 88);
            this.lblActividad.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblActividad.Name = "lblActividad";
            this.lblActividad.Size = new System.Drawing.Size(130, 17);
            this.lblActividad.TabIndex = 57;
            this.lblActividad.Text = "Actividad Evaluada:";
            // 
            // lUserEvaluado
            // 
            this.lUserEvaluado.AutoSize = true;
            this.lUserEvaluado.Font = new System.Drawing.Font("Bahnschrift", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lUserEvaluado.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lUserEvaluado.Location = new System.Drawing.Point(149, 53);
            this.lUserEvaluado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lUserEvaluado.Name = "lUserEvaluado";
            this.lUserEvaluado.Size = new System.Drawing.Size(49, 14);
            this.lUserEvaluado.TabIndex = 56;
            this.lUserEvaluado.Text = "nombre";
            // 
            // userEvaluado
            // 
            this.userEvaluado.AutoSize = true;
            this.userEvaluado.Font = new System.Drawing.Font("Bahnschrift", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userEvaluado.ForeColor = System.Drawing.SystemColors.ControlText;
            this.userEvaluado.Location = new System.Drawing.Point(26, 50);
            this.userEvaluado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.userEvaluado.Name = "userEvaluado";
            this.userEvaluado.Size = new System.Drawing.Size(121, 17);
            this.userEvaluado.TabIndex = 55;
            this.userEvaluado.Text = "Usuario Evaluado:";
            // 
            // ratingPDI
            // 
            this.ratingPDI.Images = customImageCollection2;
            this.ratingPDI.ItemBackColor = System.Drawing.Color.White;
            this.ratingPDI.ItemBorderColor = System.Drawing.Color.Black;
            this.ratingPDI.Location = new System.Drawing.Point(144, 141);
            this.ratingPDI.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ratingPDI.Name = "ratingPDI";
            this.ratingPDI.Precision = Syncfusion.Windows.Forms.Tools.PrecisionMode.Half;
            this.ratingPDI.ResetButton = resetButton2;
            this.ratingPDI.Size = new System.Drawing.Size(167, 27);
            this.ratingPDI.TabIndex = 54;
            // 
            // lblTitPDI
            // 
            this.lblTitPDI.AutoSize = true;
            this.lblTitPDI.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitPDI.ForeColor = System.Drawing.Color.DarkGray;
            this.lblTitPDI.Location = new System.Drawing.Point(14, 8);
            this.lblTitPDI.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitPDI.Name = "lblTitPDI";
            this.lblTitPDI.Size = new System.Drawing.Size(114, 19);
            this.lblTitPDI.TabIndex = 54;
            this.lblTitPDI.Text = "VALORACIÓN PDI";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.DarkCyan;
            this.lblTitulo.Location = new System.Drawing.Point(9, 7);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(636, 29);
            this.lblTitulo.TabIndex = 55;
            this.lblTitulo.Text = "¿CUÁL ES LA NOTA DEL USUARIO nombreUser EN ESTA ACTIVIDAD?";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // EvaluarUsuarioPDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(721, 446);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bCancelar);
            this.Controls.Add(this.bAceptar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "EvaluarUsuarioPDI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "EvaluarUsuarioPDI";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelError;
        private System.Windows.Forms.RichTextBox textBoxComentarioPDI;
        private System.Windows.Forms.Label labelComentario;
        private System.Windows.Forms.Button bCancelar;
        private System.Windows.Forms.Button bAceptar;
        private System.Windows.Forms.Label labelValoracionONG;
        private System.Windows.Forms.Label labelComentarioONG;
        private System.Windows.Forms.RichTextBox textBoxComentarioONG;
        private System.Windows.Forms.Label labelValoracionPDI;
        private System.Windows.Forms.Label lHoras;
        private System.Windows.Forms.Label lblHorasInvertidas;
        private System.Windows.Forms.Label lblArchivoAdjunto;
        private System.Windows.Forms.Button btnDescargar;
        private System.Windows.Forms.TextBox txtNombreArchivo;
        private Syncfusion.Windows.Forms.Tools.RatingControl ratingONG;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTitONG;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblTitPDI;
        private Syncfusion.Windows.Forms.Tools.RatingControl ratingPDI;
        private System.Windows.Forms.Label lUserEvaluado;
        private System.Windows.Forms.Label userEvaluado;
        private System.Windows.Forms.Label lblOrganizador;
        private System.Windows.Forms.Label lNombreOrganizador;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lNombreActividad;
        private System.Windows.Forms.Label lblActividad;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}