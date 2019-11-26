namespace APS.Interfaces
{
    partial class Registro
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
            this.b_aceptarReg = new System.Windows.Forms.Button();
            this.b_ONGReg = new System.Windows.Forms.Button();
            this.b_cancelarReg = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.t_correoReg = new System.Windows.Forms.TextBox();
            this.t_pwdReg = new System.Windows.Forms.TextBox();
            this.labelError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // b_aceptarReg
            // 
            this.b_aceptarReg.Location = new System.Drawing.Point(167, 230);
            this.b_aceptarReg.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.b_aceptarReg.Name = "b_aceptarReg";
            this.b_aceptarReg.Size = new System.Drawing.Size(82, 28);
            this.b_aceptarReg.TabIndex = 0;
            this.b_aceptarReg.Text = "Aceptar";
            this.b_aceptarReg.UseVisualStyleBackColor = true;
            this.b_aceptarReg.Click += new System.EventHandler(this.b_aceptarReg_Click);
            // 
            // b_ONGReg
            // 
            this.b_ONGReg.Location = new System.Drawing.Point(313, 230);
            this.b_ONGReg.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.b_ONGReg.Name = "b_ONGReg";
            this.b_ONGReg.Size = new System.Drawing.Size(82, 28);
            this.b_ONGReg.TabIndex = 1;
            this.b_ONGReg.Text = "Soy ONG";
            this.b_ONGReg.UseVisualStyleBackColor = true;
            // 
            // b_cancelarReg
            // 
            this.b_cancelarReg.Location = new System.Drawing.Point(472, 230);
            this.b_cancelarReg.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.b_cancelarReg.Name = "b_cancelarReg";
            this.b_cancelarReg.Size = new System.Drawing.Size(82, 28);
            this.b_cancelarReg.TabIndex = 2;
            this.b_cancelarReg.Text = "Cancelar";
            this.b_cancelarReg.UseVisualStyleBackColor = true;
            this.b_cancelarReg.Click += new System.EventHandler(this.b_cancelarReg_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(127, 84);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Correo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(96, 147);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Contraseña";
            // 
            // t_correoReg
            // 
            this.t_correoReg.Location = new System.Drawing.Point(214, 84);
            this.t_correoReg.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.t_correoReg.Name = "t_correoReg";
            this.t_correoReg.Size = new System.Drawing.Size(369, 22);
            this.t_correoReg.TabIndex = 5;
            // 
            // t_pwdReg
            // 
            this.t_pwdReg.Location = new System.Drawing.Point(214, 147);
            this.t_pwdReg.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.t_pwdReg.Name = "t_pwdReg";
            this.t_pwdReg.Size = new System.Drawing.Size(369, 22);
            this.t_pwdReg.TabIndex = 6;
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.BackColor = System.Drawing.Color.Transparent;
            this.labelError.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelError.ForeColor = System.Drawing.Color.Red;
            this.labelError.Location = new System.Drawing.Point(127, 278);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(44, 17);
            this.labelError.TabIndex = 8;
            this.labelError.Text = "error";
            // 
            // Registro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 346);
            this.Controls.Add(this.labelError);
            this.Controls.Add(this.t_pwdReg);
            this.Controls.Add(this.t_correoReg);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.b_cancelarReg);
            this.Controls.Add(this.b_ONGReg);
            this.Controls.Add(this.b_aceptarReg);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Registro";
            this.Text = "Registro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button b_aceptarReg;
        private System.Windows.Forms.Button b_ONGReg;
        private System.Windows.Forms.Button b_cancelarReg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox t_correoReg;
        private System.Windows.Forms.TextBox t_pwdReg;
        private System.Windows.Forms.Label labelError;
    }
}