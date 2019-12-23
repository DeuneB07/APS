namespace APS.Interfaces.Gestión_Actividades
{
    partial class VerParticipantes
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
            this.tabSolicitudes = new System.Windows.Forms.TabControl();
            this.pSolicitudesPendientes = new System.Windows.Forms.TabPage();
            this.panelSolPendientes = new System.Windows.Forms.TableLayoutPanel();
            this.pSolicitudesAceptadas = new System.Windows.Forms.TabPage();
            this.panelSolAceptadas = new System.Windows.Forms.TableLayoutPanel();
            this.pSolicitudesEnEsperaONG = new System.Windows.Forms.TabPage();
            this.panelSolicitudesEsperaONG = new System.Windows.Forms.TableLayoutPanel();
            this.tabSolicitudes.SuspendLayout();
            this.pSolicitudesPendientes.SuspendLayout();
            this.pSolicitudesAceptadas.SuspendLayout();
            this.pSolicitudesEnEsperaONG.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabSolicitudes
            // 
            this.tabSolicitudes.Controls.Add(this.pSolicitudesPendientes);
            this.tabSolicitudes.Controls.Add(this.pSolicitudesAceptadas);
            this.tabSolicitudes.Controls.Add(this.pSolicitudesEnEsperaONG);
            this.tabSolicitudes.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabSolicitudes.Location = new System.Drawing.Point(11, 11);
            this.tabSolicitudes.Margin = new System.Windows.Forms.Padding(2);
            this.tabSolicitudes.Name = "tabSolicitudes";
            this.tabSolicitudes.SelectedIndex = 0;
            this.tabSolicitudes.Size = new System.Drawing.Size(531, 344);
            this.tabSolicitudes.TabIndex = 0;
            // 
            // pSolicitudesPendientes
            // 
            this.pSolicitudesPendientes.Controls.Add(this.panelSolPendientes);
            this.pSolicitudesPendientes.Location = new System.Drawing.Point(4, 22);
            this.pSolicitudesPendientes.Margin = new System.Windows.Forms.Padding(2);
            this.pSolicitudesPendientes.Name = "pSolicitudesPendientes";
            this.pSolicitudesPendientes.Padding = new System.Windows.Forms.Padding(2);
            this.pSolicitudesPendientes.Size = new System.Drawing.Size(523, 318);
            this.pSolicitudesPendientes.TabIndex = 0;
            this.pSolicitudesPendientes.Text = "Solicitudes Pendientes";
            this.pSolicitudesPendientes.UseVisualStyleBackColor = true;
            // 
            // panelSolPendientes
            // 
            this.panelSolPendientes.AutoScroll = true;
            this.panelSolPendientes.ColumnCount = 1;
            this.panelSolPendientes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panelSolPendientes.Location = new System.Drawing.Point(0, 0);
            this.panelSolPendientes.Name = "panelSolPendientes";
            this.panelSolPendientes.RowCount = 1;
            this.panelSolPendientes.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.panelSolPendientes.Size = new System.Drawing.Size(523, 318);
            this.panelSolPendientes.TabIndex = 3;
            // 
            // pSolicitudesAceptadas
            // 
            this.pSolicitudesAceptadas.Controls.Add(this.panelSolAceptadas);
            this.pSolicitudesAceptadas.Location = new System.Drawing.Point(4, 22);
            this.pSolicitudesAceptadas.Margin = new System.Windows.Forms.Padding(2);
            this.pSolicitudesAceptadas.Name = "pSolicitudesAceptadas";
            this.pSolicitudesAceptadas.Padding = new System.Windows.Forms.Padding(2);
            this.pSolicitudesAceptadas.Size = new System.Drawing.Size(523, 318);
            this.pSolicitudesAceptadas.TabIndex = 1;
            this.pSolicitudesAceptadas.Text = "Solicitudes Aceptadas";
            this.pSolicitudesAceptadas.UseVisualStyleBackColor = true;
            // 
            // panelSolAceptadas
            // 
            this.panelSolAceptadas.AutoScroll = true;
            this.panelSolAceptadas.ColumnCount = 1;
            this.panelSolAceptadas.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panelSolAceptadas.Location = new System.Drawing.Point(0, 0);
            this.panelSolAceptadas.Name = "panelSolAceptadas";
            this.panelSolAceptadas.RowCount = 1;
            this.panelSolAceptadas.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.panelSolAceptadas.Size = new System.Drawing.Size(523, 318);
            this.panelSolAceptadas.TabIndex = 3;
            // 
            // pSolicitudesEnEsperaONG
            // 
            this.pSolicitudesEnEsperaONG.Controls.Add(this.panelSolicitudesEsperaONG);
            this.pSolicitudesEnEsperaONG.Location = new System.Drawing.Point(4, 22);
            this.pSolicitudesEnEsperaONG.Margin = new System.Windows.Forms.Padding(2);
            this.pSolicitudesEnEsperaONG.Name = "pSolicitudesEnEsperaONG";
            this.pSolicitudesEnEsperaONG.Padding = new System.Windows.Forms.Padding(2);
            this.pSolicitudesEnEsperaONG.Size = new System.Drawing.Size(523, 318);
            this.pSolicitudesEnEsperaONG.TabIndex = 2;
            this.pSolicitudesEnEsperaONG.Text = "Solicitudes en Espera ONG";
            this.pSolicitudesEnEsperaONG.UseVisualStyleBackColor = true;
            // 
            // panelSolicitudesEsperaONG
            // 
            this.panelSolicitudesEsperaONG.AutoScroll = true;
            this.panelSolicitudesEsperaONG.ColumnCount = 1;
            this.panelSolicitudesEsperaONG.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panelSolicitudesEsperaONG.Location = new System.Drawing.Point(0, 0);
            this.panelSolicitudesEsperaONG.Name = "panelSolicitudesEsperaONG";
            this.panelSolicitudesEsperaONG.RowCount = 1;
            this.panelSolicitudesEsperaONG.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.panelSolicitudesEsperaONG.Size = new System.Drawing.Size(523, 318);
            this.panelSolicitudesEsperaONG.TabIndex = 4;
            // 
            // VerParticipantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(546, 408);
            this.Controls.Add(this.tabSolicitudes);
            this.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "VerParticipantes";
            this.Text = "VerParticipantes";
            this.tabSolicitudes.ResumeLayout(false);
            this.pSolicitudesPendientes.ResumeLayout(false);
            this.pSolicitudesAceptadas.ResumeLayout(false);
            this.pSolicitudesEnEsperaONG.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabSolicitudes;
        private System.Windows.Forms.TabPage pSolicitudesPendientes;
        private System.Windows.Forms.TabPage pSolicitudesAceptadas;
        private System.Windows.Forms.TableLayoutPanel panelSolPendientes;
        private System.Windows.Forms.TableLayoutPanel panelSolAceptadas;
        private System.Windows.Forms.TabPage pSolicitudesEnEsperaONG;
        private System.Windows.Forms.TableLayoutPanel panelSolicitudesEsperaONG;
    }
}