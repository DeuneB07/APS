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
            this.panelMensajes = new System.Windows.Forms.TableLayoutPanel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.panelMensajes);
            this.panel1.Location = new System.Drawing.Point(5, 6);
            this.panel1.Margin = new System.Windows.Forms.Padding(6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1431, 747);
            this.panel1.TabIndex = 33;
            // 
            // panelMensajes
            // 
            this.panelMensajes.AutoSize = true;
            this.panelMensajes.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelMensajes.BackColor = System.Drawing.Color.Transparent;
            this.panelMensajes.ColumnCount = 1;
            this.panelMensajes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 1172F));
            this.panelMensajes.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMensajes.Location = new System.Drawing.Point(0, 0);
            this.panelMensajes.Margin = new System.Windows.Forms.Padding(6);
            this.panelMensajes.Name = "panelMensajes";
            this.panelMensajes.RowCount = 1;
            this.panelMensajes.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.panelMensajes.Size = new System.Drawing.Size(1431, 0);
            this.panelMensajes.TabIndex = 21;
            // 
            // EvaluarParticipantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1443, 761);
            this.Controls.Add(this.panel1);
            this.Name = "EvaluarParticipantes";
            this.Text = "EvaluarParticipantes";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel panelMensajes;
    }
}