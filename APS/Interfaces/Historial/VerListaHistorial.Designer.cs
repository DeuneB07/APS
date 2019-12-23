namespace APS.Interfaces.Historial
{
    partial class VerListaHistorial
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
            this.panelHistorial = new System.Windows.Forms.Panel();
            this.tablePP = new System.Windows.Forms.TableLayoutPanel();
            this.panelHistorial.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHistorial
            // 
            this.panelHistorial.AutoScroll = true;
            this.panelHistorial.Controls.Add(this.tablePP);
            this.panelHistorial.Location = new System.Drawing.Point(1, 12);
            this.panelHistorial.Name = "panelHistorial";
            this.panelHistorial.Size = new System.Drawing.Size(1155, 489);
            this.panelHistorial.TabIndex = 0;
            // 
            // tablePP
            // 
            this.tablePP.AutoSize = true;
            this.tablePP.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tablePP.BackColor = System.Drawing.Color.Transparent;
            this.tablePP.ColumnCount = 1;
            this.tablePP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tablePP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tablePP.Dock = System.Windows.Forms.DockStyle.Top;
            this.tablePP.Location = new System.Drawing.Point(0, 0);
            this.tablePP.Margin = new System.Windows.Forms.Padding(4);
            this.tablePP.Name = "tablePP";
            this.tablePP.RowCount = 1;
            this.tablePP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tablePP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tablePP.Size = new System.Drawing.Size(1155, 0);
            this.tablePP.TabIndex = 45;
            // 
            // VerListaHistorial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1156, 510);
            this.Controls.Add(this.panelHistorial);
            this.Name = "VerListaHistorial";
            this.Text = "Historial";
            this.panelHistorial.ResumeLayout(false);
            this.panelHistorial.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHistorial;
        private System.Windows.Forms.TableLayoutPanel tablePP;
    }
}