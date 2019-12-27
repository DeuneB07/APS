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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EvaluarParticipantes));
            this.tabValoraciones = new System.Windows.Forms.TabControl();
            this.pPorEvaluar = new System.Windows.Forms.TabPage();
            this.panelPorEvaluar = new System.Windows.Forms.TableLayoutPanel();
            this.pEnProceso = new System.Windows.Forms.TabPage();
            this.panelEnProceso = new System.Windows.Forms.TableLayoutPanel();
            this.pAusente = new System.Windows.Forms.TabPage();
            this.panelAusentes = new System.Windows.Forms.TableLayoutPanel();
            this.pEvaluados = new System.Windows.Forms.TabPage();
            this.panelEvaluados = new System.Windows.Forms.TableLayoutPanel();
            this.tabValoraciones.SuspendLayout();
            this.pPorEvaluar.SuspendLayout();
            this.pEnProceso.SuspendLayout();
            this.pAusente.SuspendLayout();
            this.pEvaluados.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabValoraciones
            // 
            this.tabValoraciones.Controls.Add(this.pPorEvaluar);
            this.tabValoraciones.Controls.Add(this.pEnProceso);
            this.tabValoraciones.Controls.Add(this.pAusente);
            this.tabValoraciones.Controls.Add(this.pEvaluados);
            this.tabValoraciones.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabValoraciones.Location = new System.Drawing.Point(11, 11);
            this.tabValoraciones.Margin = new System.Windows.Forms.Padding(2);
            this.tabValoraciones.Name = "tabValoraciones";
            this.tabValoraciones.SelectedIndex = 0;
            this.tabValoraciones.Size = new System.Drawing.Size(531, 344);
            this.tabValoraciones.TabIndex = 34;
            // 
            // pPorEvaluar
            // 
            this.pPorEvaluar.Controls.Add(this.panelPorEvaluar);
            this.pPorEvaluar.Location = new System.Drawing.Point(4, 22);
            this.pPorEvaluar.Margin = new System.Windows.Forms.Padding(2);
            this.pPorEvaluar.Name = "pPorEvaluar";
            this.pPorEvaluar.Padding = new System.Windows.Forms.Padding(2);
            this.pPorEvaluar.Size = new System.Drawing.Size(523, 318);
            this.pPorEvaluar.TabIndex = 0;
            this.pPorEvaluar.Text = "Requiere Evaluación";
            this.pPorEvaluar.UseVisualStyleBackColor = true;
            // 
            // panelPorEvaluar
            // 
            this.panelPorEvaluar.AutoScroll = true;
            this.panelPorEvaluar.ColumnCount = 1;
            this.panelPorEvaluar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panelPorEvaluar.Location = new System.Drawing.Point(0, 0);
            this.panelPorEvaluar.Name = "panelPorEvaluar";
            this.panelPorEvaluar.RowCount = 1;
            this.panelPorEvaluar.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.panelPorEvaluar.Size = new System.Drawing.Size(523, 318);
            this.panelPorEvaluar.TabIndex = 3;
            // 
            // pEnProceso
            // 
            this.pEnProceso.Controls.Add(this.panelEnProceso);
            this.pEnProceso.Location = new System.Drawing.Point(4, 22);
            this.pEnProceso.Name = "pEnProceso";
            this.pEnProceso.Size = new System.Drawing.Size(523, 318);
            this.pEnProceso.TabIndex = 3;
            this.pEnProceso.Text = "En Proceso";
            this.pEnProceso.UseVisualStyleBackColor = true;
            // 
            // panelEnProceso
            // 
            this.panelEnProceso.AutoScroll = true;
            this.panelEnProceso.ColumnCount = 1;
            this.panelEnProceso.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panelEnProceso.Location = new System.Drawing.Point(0, 0);
            this.panelEnProceso.Name = "panelEnProceso";
            this.panelEnProceso.RowCount = 1;
            this.panelEnProceso.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.panelEnProceso.Size = new System.Drawing.Size(523, 318);
            this.panelEnProceso.TabIndex = 4;
            // 
            // pAusente
            // 
            this.pAusente.Controls.Add(this.panelAusentes);
            this.pAusente.Location = new System.Drawing.Point(4, 22);
            this.pAusente.Margin = new System.Windows.Forms.Padding(2);
            this.pAusente.Name = "pAusente";
            this.pAusente.Padding = new System.Windows.Forms.Padding(2);
            this.pAusente.Size = new System.Drawing.Size(523, 318);
            this.pAusente.TabIndex = 2;
            this.pAusente.Text = "Evaluación Ausente";
            this.pAusente.UseVisualStyleBackColor = true;
            // 
            // panelAusentes
            // 
            this.panelAusentes.AutoScroll = true;
            this.panelAusentes.ColumnCount = 1;
            this.panelAusentes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panelAusentes.Location = new System.Drawing.Point(0, 0);
            this.panelAusentes.Name = "panelAusentes";
            this.panelAusentes.RowCount = 1;
            this.panelAusentes.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.panelAusentes.Size = new System.Drawing.Size(523, 318);
            this.panelAusentes.TabIndex = 4;
            // 
            // pEvaluados
            // 
            this.pEvaluados.Controls.Add(this.panelEvaluados);
            this.pEvaluados.Location = new System.Drawing.Point(4, 22);
            this.pEvaluados.Margin = new System.Windows.Forms.Padding(2);
            this.pEvaluados.Name = "pEvaluados";
            this.pEvaluados.Padding = new System.Windows.Forms.Padding(2);
            this.pEvaluados.Size = new System.Drawing.Size(523, 318);
            this.pEvaluados.TabIndex = 1;
            this.pEvaluados.Text = "Evaluados";
            this.pEvaluados.UseVisualStyleBackColor = true;
            // 
            // panelEvaluados
            // 
            this.panelEvaluados.AutoScroll = true;
            this.panelEvaluados.ColumnCount = 1;
            this.panelEvaluados.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panelEvaluados.Location = new System.Drawing.Point(0, 0);
            this.panelEvaluados.Name = "panelEvaluados";
            this.panelEvaluados.RowCount = 1;
            this.panelEvaluados.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.panelEvaluados.Size = new System.Drawing.Size(523, 318);
            this.panelEvaluados.TabIndex = 3;
            // 
            // EvaluarParticipantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 379);
            this.Controls.Add(this.tabValoraciones);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "EvaluarParticipantes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Lista de Participantes";
            this.tabValoraciones.ResumeLayout(false);
            this.pPorEvaluar.ResumeLayout(false);
            this.pEnProceso.ResumeLayout(false);
            this.pAusente.ResumeLayout(false);
            this.pEvaluados.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabValoraciones;
        private System.Windows.Forms.TabPage pPorEvaluar;
        private System.Windows.Forms.TableLayoutPanel panelPorEvaluar;
        private System.Windows.Forms.TabPage pEvaluados;
        private System.Windows.Forms.TableLayoutPanel panelEvaluados;
        private System.Windows.Forms.TabPage pAusente;
        private System.Windows.Forms.TableLayoutPanel panelAusentes;
        private System.Windows.Forms.TabPage pEnProceso;
        private System.Windows.Forms.TableLayoutPanel panelEnProceso;
    }
}