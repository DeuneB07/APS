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
            this.tabSolicitudes.SuspendLayout();
            this.pSolicitudesPendientes.SuspendLayout();
            this.pSolicitudesAceptadas.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabSolicitudes
            // 
            this.tabSolicitudes.Controls.Add(this.pSolicitudesPendientes);
            this.tabSolicitudes.Controls.Add(this.pSolicitudesAceptadas);
            this.tabSolicitudes.Controls.Add(this.pSolicitudesEnEsperaONG);
            this.tabSolicitudes.Location = new System.Drawing.Point(2, 0);
            this.tabSolicitudes.Name = "tabSolicitudes";
            this.tabSolicitudes.SelectedIndex = 0;
            this.tabSolicitudes.Size = new System.Drawing.Size(1807, 843);
            this.tabSolicitudes.TabIndex = 0;
            // 
            // pSolicitudesPendientes
            // 
            this.pSolicitudesPendientes.Controls.Add(this.panelSolPendientes);
            this.pSolicitudesPendientes.Location = new System.Drawing.Point(8, 39);
            this.pSolicitudesPendientes.Name = "pSolicitudesPendientes";
            this.pSolicitudesPendientes.Padding = new System.Windows.Forms.Padding(3);
            this.pSolicitudesPendientes.Size = new System.Drawing.Size(1791, 796);
            this.pSolicitudesPendientes.TabIndex = 0;
            this.pSolicitudesPendientes.Text = "Solicitudes Pendientes";
            this.pSolicitudesPendientes.UseVisualStyleBackColor = true;
            // 
            // panelSolPendientes
            // 
            this.panelSolPendientes.AutoScroll = true;
            this.panelSolPendientes.ColumnCount = 1;
            this.panelSolPendientes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panelSolPendientes.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.panelSolPendientes.Location = new System.Drawing.Point(0, 0);
            this.panelSolPendientes.Margin = new System.Windows.Forms.Padding(6);
            this.panelSolPendientes.Name = "panelSolPendientes";
            this.panelSolPendientes.RowCount = 1;
            this.panelSolPendientes.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.panelSolPendientes.Size = new System.Drawing.Size(1791, 796);
            this.panelSolPendientes.TabIndex = 3;
            // 
            // pSolicitudesAceptadas
            // 
            this.pSolicitudesAceptadas.Controls.Add(this.panelSolAceptadas);
            this.pSolicitudesAceptadas.Location = new System.Drawing.Point(8, 39);
            this.pSolicitudesAceptadas.Name = "pSolicitudesAceptadas";
            this.pSolicitudesAceptadas.Padding = new System.Windows.Forms.Padding(3);
            this.pSolicitudesAceptadas.Size = new System.Drawing.Size(1791, 796);
            this.pSolicitudesAceptadas.TabIndex = 1;
            this.pSolicitudesAceptadas.Text = "Solicitudes Aceptadas";
            this.pSolicitudesAceptadas.UseVisualStyleBackColor = true;
            // 
            // panelSolAceptadas
            // 
            this.panelSolAceptadas.AutoScroll = true;
            this.panelSolAceptadas.ColumnCount = 1;
            this.panelSolAceptadas.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panelSolAceptadas.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.panelSolAceptadas.Location = new System.Drawing.Point(0, 0);
            this.panelSolAceptadas.Margin = new System.Windows.Forms.Padding(6);
            this.panelSolAceptadas.Name = "panelSolAceptadas";
            this.panelSolAceptadas.RowCount = 1;
            this.panelSolAceptadas.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.panelSolAceptadas.Size = new System.Drawing.Size(1791, 796);
            this.panelSolAceptadas.TabIndex = 3;
            // 
            // pSolicitudesEnEsperaONG
            // 
            this.pSolicitudesEnEsperaONG.Location = new System.Drawing.Point(8, 39);
            this.pSolicitudesEnEsperaONG.Name = "pSolicitudesEnEsperaONG";
            this.pSolicitudesEnEsperaONG.Padding = new System.Windows.Forms.Padding(3);
            this.pSolicitudesEnEsperaONG.Size = new System.Drawing.Size(1791, 796);
            this.pSolicitudesEnEsperaONG.TabIndex = 2;
            this.pSolicitudesEnEsperaONG.Text = "Solicitudes en Espera ONG";
            this.pSolicitudesEnEsperaONG.UseVisualStyleBackColor = true;
            // 
            // VerParticipantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1811, 845);
            this.Controls.Add(this.tabSolicitudes);
            this.Name = "VerParticipantes";
            this.Text = "VerParticipantes";
            this.tabSolicitudes.ResumeLayout(false);
            this.pSolicitudesPendientes.ResumeLayout(false);
            this.pSolicitudesAceptadas.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabSolicitudes;
        private System.Windows.Forms.TabPage pSolicitudesPendientes;
        private System.Windows.Forms.TabPage pSolicitudesAceptadas;
        private System.Windows.Forms.TableLayoutPanel panelSolPendientes;
        private System.Windows.Forms.TableLayoutPanel panelSolAceptadas;
        private System.Windows.Forms.TabPage pSolicitudesEnEsperaONG;
    }
}