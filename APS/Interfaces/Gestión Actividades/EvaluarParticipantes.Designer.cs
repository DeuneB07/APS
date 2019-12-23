namespace APS.Interfaces.Gestión_Actividades
{
    partial class EvaluarParticipantes
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelParticipantes = new System.Windows.Forms.TableLayoutPanel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.panelParticipantes);
            this.panel1.Location = new System.Drawing.Point(5, 6);
            this.panel1.Margin = new System.Windows.Forms.Padding(6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(918, 715);
            this.panel1.TabIndex = 33;
            // 
            // panelParticipantes
            // 
            this.panelParticipantes.AutoSize = true;
            this.panelParticipantes.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelParticipantes.BackColor = System.Drawing.Color.Transparent;
            this.panelParticipantes.ColumnCount = 1;
            this.panelParticipantes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 1431F));
            this.panelParticipantes.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelParticipantes.Location = new System.Drawing.Point(0, 0);
            this.panelParticipantes.Margin = new System.Windows.Forms.Padding(6);
            this.panelParticipantes.Name = "panelParticipantes";
            this.panelParticipantes.RowCount = 1;
            this.panelParticipantes.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.panelParticipantes.Size = new System.Drawing.Size(918, 0);
            this.panelParticipantes.TabIndex = 21;
            // 
            // EvaluarParticipantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 729);
            this.Controls.Add(this.panel1);
            this.Name = "EvaluarParticipantes";
            this.Text = "EvaluarParticipantes";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel panelParticipantes;
    }
}