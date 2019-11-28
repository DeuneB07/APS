namespace APS.Interfaces
{
    partial class Prueba
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
            this.grandChildPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ChildPanel = new System.Windows.Forms.Panel();
            this.ParentPanel = new System.Windows.Forms.Panel();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.grandChildPanel.SuspendLayout();
            this.ChildPanel.SuspendLayout();
            this.ParentPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // grandChildPanel
            // 
            this.grandChildPanel.Controls.Add(this.label2);
            this.grandChildPanel.Controls.Add(this.label1);
            this.grandChildPanel.Location = new System.Drawing.Point(0, 0);
            this.grandChildPanel.Name = "grandChildPanel";
            this.grandChildPanel.Size = new System.Drawing.Size(306, 99);
            this.grandChildPanel.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            // 
            // ChildPanel
            // 
            this.ChildPanel.Controls.Add(this.grandChildPanel);
            this.ChildPanel.Location = new System.Drawing.Point(0, 0);
            this.ChildPanel.Name = "ChildPanel";
            this.ChildPanel.Size = new System.Drawing.Size(306, 99);
            this.ChildPanel.TabIndex = 2;
            // 
            // ParentPanel
            // 
            this.ParentPanel.Controls.Add(this.vScrollBar1);
            this.ParentPanel.Controls.Add(this.ChildPanel);
            this.ParentPanel.Location = new System.Drawing.Point(12, 22);
            this.ParentPanel.Name = "ParentPanel";
            this.ParentPanel.Size = new System.Drawing.Size(329, 99);
            this.ParentPanel.TabIndex = 2;
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(309, 0);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(20, 99);
            this.vScrollBar1.TabIndex = 3;
            // 
            // Prueba
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ParentPanel);
            this.Name = "Prueba";
            this.Text = "Prueba";
            this.grandChildPanel.ResumeLayout(false);
            this.grandChildPanel.PerformLayout();
            this.ChildPanel.ResumeLayout(false);
            this.ParentPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel grandChildPanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel ChildPanel;
        private System.Windows.Forms.Panel ParentPanel;
        private System.Windows.Forms.VScrollBar vScrollBar1;
    }
}