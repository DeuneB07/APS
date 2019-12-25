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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VerListaHistorial));
            this.panelHistorial = new System.Windows.Forms.Panel();
            this.tablePP = new System.Windows.Forms.TableLayoutPanel();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.btnAtras = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panelHistorial.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHistorial
            // 
            this.panelHistorial.AutoScroll = true;
            this.panelHistorial.Controls.Add(this.tablePP);
            this.panelHistorial.Location = new System.Drawing.Point(12, 69);
            this.panelHistorial.Name = "panelHistorial";
            this.panelHistorial.Size = new System.Drawing.Size(1113, 441);
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
            this.tablePP.Size = new System.Drawing.Size(1113, 0);
            this.tablePP.TabIndex = 45;
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Font = new System.Drawing.Font("AR JULIAN", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitulo.ForeColor = System.Drawing.Color.DarkRed;
            this.labelTitulo.Location = new System.Drawing.Point(316, 9);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(365, 39);
            this.labelTitulo.TabIndex = 1;
            this.labelTitulo.Text = "HISTORIAL USUARIO";
            // 
            // btnAtras
            // 
            this.btnAtras.BackColor = System.Drawing.Color.Transparent;
            this.btnAtras.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAtras.BackgroundImage")));
            this.btnAtras.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAtras.FlatAppearance.BorderSize = 0;
            this.btnAtras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtras.Location = new System.Drawing.Point(1150, 426);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(63, 54);
            this.btnAtras.TabIndex = 2;
            this.btnAtras.UseVisualStyleBackColor = false;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1160, 483);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Atrás";
            // 
            // VerListaHistorial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1239, 522);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.labelTitulo);
            this.Controls.Add(this.panelHistorial);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "VerListaHistorial";
            this.Text = "Historial";
            this.panelHistorial.ResumeLayout(false);
            this.panelHistorial.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelHistorial;
        private System.Windows.Forms.TableLayoutPanel tablePP;
        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.Label label1;
    }
}