namespace APS.Interfaces
{
    partial class PaginaPrincipal
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PaginaPrincipal));
            this.tabUser = new System.Windows.Forms.TabControl();
            this.pMatch = new System.Windows.Forms.TabPage();
            this.pTodas = new System.Windows.Forms.TabPage();
            this.panelTodas = new System.Windows.Forms.TableLayoutPanel();
            this.pProyectos = new System.Windows.Forms.TabPage();
            this.pValoracion = new System.Windows.Forms.TabPage();
            this.pPendientes = new System.Windows.Forms.TabPage();
            this.bGestionar = new System.Windows.Forms.Button();
            this.dataGridViewPendientes = new System.Windows.Forms.DataGridView();
            this.pRevision = new System.Windows.Forms.TabPage();
            this.dataGridViewRevision = new System.Windows.Forms.DataGridView();
            this.pMisActividades = new System.Windows.Forms.TabPage();
            this.pActividadesInscritas = new System.Windows.Forms.TabPage();
            this.gradosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.wePassDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.wePassDataSet = new APS.WePassDataSet();
            this.actividadesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lWelcome = new System.Windows.Forms.Label();
            this.pictureUser = new System.Windows.Forms.PictureBox();
            this.lPerfil = new System.Windows.Forms.Label();
            this.lMensajes = new System.Windows.Forms.Label();
            this.lHistorial = new System.Windows.Forms.Label();
            this.bLogout = new System.Windows.Forms.Button();
            this.lNuevoProy = new System.Windows.Forms.Label();
            this.lNewAct = new System.Windows.Forms.Label();
            this.gradosTableAdapter = new APS.WePassDataSetTableAdapters.GradosTableAdapter();
            this.actividadesTableAdapter = new APS.WePassDataSetTableAdapters.ActividadesTableAdapter();
            this.tabUser.SuspendLayout();
            this.pTodas.SuspendLayout();
            this.pPendientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPendientes)).BeginInit();
            this.pRevision.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRevision)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wePassDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wePassDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.actividadesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureUser)).BeginInit();
            this.SuspendLayout();
            // 
            // tabUser
            // 
            this.tabUser.Controls.Add(this.pMatch);
            this.tabUser.Controls.Add(this.pTodas);
            this.tabUser.Controls.Add(this.pProyectos);
            this.tabUser.Controls.Add(this.pValoracion);
            this.tabUser.Controls.Add(this.pPendientes);
            this.tabUser.Controls.Add(this.pRevision);
            this.tabUser.Controls.Add(this.pMisActividades);
            this.tabUser.Controls.Add(this.pActividadesInscritas);
            this.tabUser.HotTrack = true;
            this.tabUser.Location = new System.Drawing.Point(28, 72);
            this.tabUser.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabUser.Name = "tabUser";
            this.tabUser.SelectedIndex = 0;
            this.tabUser.Size = new System.Drawing.Size(887, 440);
            this.tabUser.TabIndex = 0;
            // 
            // pMatch
            // 
            this.pMatch.Location = new System.Drawing.Point(4, 25);
            this.pMatch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pMatch.Name = "pMatch";
            this.pMatch.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pMatch.Size = new System.Drawing.Size(879, 411);
            this.pMatch.TabIndex = 0;
            this.pMatch.Text = "Match";
            this.pMatch.UseVisualStyleBackColor = true;
            // 
            // pTodas
            // 
            this.pTodas.Controls.Add(this.panelTodas);
            this.pTodas.Location = new System.Drawing.Point(4, 25);
            this.pTodas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pTodas.Name = "pTodas";
            this.pTodas.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pTodas.Size = new System.Drawing.Size(879, 411);
            this.pTodas.TabIndex = 1;
            this.pTodas.Text = "Todas";
            this.pTodas.UseVisualStyleBackColor = true;
            // 
            // panelTodas
            // 
            this.panelTodas.AutoScroll = true;
            this.panelTodas.ColumnCount = 1;
            this.panelTodas.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panelTodas.Location = new System.Drawing.Point(0, 0);
            this.panelTodas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelTodas.Name = "panelTodas";
            this.panelTodas.RowCount = 2;
            this.panelTodas.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panelTodas.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panelTodas.Size = new System.Drawing.Size(876, 408);
            this.panelTodas.TabIndex = 0;
            // 
            // pProyectos
            // 
            this.pProyectos.Location = new System.Drawing.Point(4, 25);
            this.pProyectos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pProyectos.Name = "pProyectos";
            this.pProyectos.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pProyectos.Size = new System.Drawing.Size(879, 411);
            this.pProyectos.TabIndex = 2;
            this.pProyectos.Text = "Proyectos";
            this.pProyectos.UseVisualStyleBackColor = true;
            // 
            // pValoracion
            // 
            this.pValoracion.Location = new System.Drawing.Point(4, 25);
            this.pValoracion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pValoracion.Name = "pValoracion";
            this.pValoracion.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pValoracion.Size = new System.Drawing.Size(879, 411);
            this.pValoracion.TabIndex = 3;
            this.pValoracion.Text = "Valoración";
            this.pValoracion.UseVisualStyleBackColor = true;
            // 
            // pPendientes
            // 
            this.pPendientes.Controls.Add(this.bGestionar);
            this.pPendientes.Controls.Add(this.dataGridViewPendientes);
            this.pPendientes.Location = new System.Drawing.Point(4, 25);
            this.pPendientes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pPendientes.Name = "pPendientes";
            this.pPendientes.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pPendientes.Size = new System.Drawing.Size(879, 411);
            this.pPendientes.TabIndex = 4;
            this.pPendientes.Text = "Pendientes";
            this.pPendientes.UseVisualStyleBackColor = true;
            // 
            // bGestionar
            // 
            this.bGestionar.Location = new System.Drawing.Point(731, 28);
            this.bGestionar.Name = "bGestionar";
            this.bGestionar.Size = new System.Drawing.Size(85, 24);
            this.bGestionar.TabIndex = 2;
            this.bGestionar.Text = "Gestionar";
            this.bGestionar.UseVisualStyleBackColor = true;
            this.bGestionar.Click += new System.EventHandler(this.bGestionar_Click);
            // 
            // dataGridViewPendientes
            // 
            this.dataGridViewPendientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPendientes.Location = new System.Drawing.Point(35, 19);
            this.dataGridViewPendientes.Name = "dataGridViewPendientes";
            this.dataGridViewPendientes.RowHeadersWidth = 82;
            this.dataGridViewPendientes.RowTemplate.Height = 24;
            this.dataGridViewPendientes.Size = new System.Drawing.Size(655, 365);
            this.dataGridViewPendientes.TabIndex = 0;
            this.dataGridViewPendientes.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPendientes_CellDoubleClick);
            // 
            // pRevision
            // 
            this.pRevision.Controls.Add(this.dataGridViewRevision);
            this.pRevision.Location = new System.Drawing.Point(4, 25);
            this.pRevision.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pRevision.Name = "pRevision";
            this.pRevision.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pRevision.Size = new System.Drawing.Size(879, 411);
            this.pRevision.TabIndex = 5;
            this.pRevision.Text = "Revisión";
            this.pRevision.UseVisualStyleBackColor = true;
            // 
            // dataGridViewRevision
            // 
            this.dataGridViewRevision.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRevision.Location = new System.Drawing.Point(99, 22);
            this.dataGridViewRevision.Name = "dataGridViewRevision";
            this.dataGridViewRevision.RowHeadersWidth = 82;
            this.dataGridViewRevision.RowTemplate.Height = 24;
            this.dataGridViewRevision.Size = new System.Drawing.Size(655, 365);
            this.dataGridViewRevision.TabIndex = 1;
            this.dataGridViewRevision.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewRevision_CellDoubleClick);
            // 
            // pMisActividades
            // 
            this.pMisActividades.Location = new System.Drawing.Point(4, 25);
            this.pMisActividades.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pMisActividades.Name = "pMisActividades";
            this.pMisActividades.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pMisActividades.Size = new System.Drawing.Size(879, 411);
            this.pMisActividades.TabIndex = 6;
            this.pMisActividades.Text = "Mis Actividades";
            this.pMisActividades.UseVisualStyleBackColor = true;
            // 
            // pActividadesInscritas
            // 
            this.pActividadesInscritas.Location = new System.Drawing.Point(4, 25);
            this.pActividadesInscritas.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pActividadesInscritas.Name = "pActividadesInscritas";
            this.pActividadesInscritas.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pActividadesInscritas.Size = new System.Drawing.Size(879, 411);
            this.pActividadesInscritas.TabIndex = 7;
            this.pActividadesInscritas.Text = "Actividades Inscritas";
            this.pActividadesInscritas.UseVisualStyleBackColor = true;
            // 
            // gradosBindingSource
            // 
            this.gradosBindingSource.DataMember = "Grados";
            this.gradosBindingSource.DataSource = this.wePassDataSetBindingSource;
            // 
            // wePassDataSetBindingSource
            // 
            this.wePassDataSetBindingSource.DataSource = this.wePassDataSet;
            this.wePassDataSetBindingSource.Position = 0;
            // 
            // wePassDataSet
            // 
            this.wePassDataSet.DataSetName = "WePassDataSet";
            this.wePassDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // actividadesBindingSource
            // 
            this.actividadesBindingSource.DataMember = "Actividades";
            this.actividadesBindingSource.DataSource = this.wePassDataSetBindingSource;
            // 
            // lWelcome
            // 
            this.lWelcome.AutoSize = true;
            this.lWelcome.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lWelcome.ForeColor = System.Drawing.Color.Maroon;
            this.lWelcome.Location = new System.Drawing.Point(61, 24);
            this.lWelcome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lWelcome.Name = "lWelcome";
            this.lWelcome.Size = new System.Drawing.Size(0, 29);
            this.lWelcome.TabIndex = 1;
            // 
            // pictureUser
            // 
            this.pictureUser.Location = new System.Drawing.Point(940, 15);
            this.pictureUser.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureUser.Name = "pictureUser";
            this.pictureUser.Size = new System.Drawing.Size(105, 93);
            this.pictureUser.TabIndex = 2;
            this.pictureUser.TabStop = false;
            // 
            // lPerfil
            // 
            this.lPerfil.AutoSize = true;
            this.lPerfil.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lPerfil.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lPerfil.Location = new System.Drawing.Point(923, 152);
            this.lPerfil.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lPerfil.Name = "lPerfil";
            this.lPerfil.Size = new System.Drawing.Size(54, 24);
            this.lPerfil.TabIndex = 3;
            this.lPerfil.Text = "Perfil";
            this.lPerfil.Click += new System.EventHandler(this.lPerfil_Click);
            // 
            // lMensajes
            // 
            this.lMensajes.AutoSize = true;
            this.lMensajes.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lMensajes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lMensajes.Location = new System.Drawing.Point(923, 176);
            this.lMensajes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lMensajes.Name = "lMensajes";
            this.lMensajes.Size = new System.Drawing.Size(90, 24);
            this.lMensajes.TabIndex = 4;
            this.lMensajes.Text = "Mensajes";
            // 
            // lHistorial
            // 
            this.lHistorial.AutoSize = true;
            this.lHistorial.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lHistorial.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lHistorial.Location = new System.Drawing.Point(923, 246);
            this.lHistorial.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lHistorial.Name = "lHistorial";
            this.lHistorial.Size = new System.Drawing.Size(82, 24);
            this.lHistorial.TabIndex = 5;
            this.lHistorial.Text = "Historial";
            // 
            // bLogout
            // 
            this.bLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bLogout.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.bLogout.FlatAppearance.BorderSize = 2;
            this.bLogout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.bLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bLogout.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bLogout.Location = new System.Drawing.Point(928, 116);
            this.bLogout.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bLogout.Name = "bLogout";
            this.bLogout.Size = new System.Drawing.Size(131, 33);
            this.bLogout.TabIndex = 6;
            this.bLogout.Text = "Cerrar Sesión";
            this.bLogout.UseVisualStyleBackColor = true;
            this.bLogout.Click += new System.EventHandler(this.bLogout_Click);
            // 
            // lNuevoProy
            // 
            this.lNuevoProy.AutoSize = true;
            this.lNuevoProy.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lNuevoProy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lNuevoProy.Location = new System.Drawing.Point(923, 223);
            this.lNuevoProy.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lNuevoProy.Name = "lNuevoProy";
            this.lNuevoProy.Size = new System.Drawing.Size(143, 24);
            this.lNuevoProy.TabIndex = 7;
            this.lNuevoProy.Text = "Nuevo Proyecto";
            // 
            // lNewAct
            // 
            this.lNewAct.AutoSize = true;
            this.lNewAct.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lNewAct.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lNewAct.Location = new System.Drawing.Point(923, 200);
            this.lNewAct.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lNewAct.Name = "lNewAct";
            this.lNewAct.Size = new System.Drawing.Size(148, 24);
            this.lNewAct.TabIndex = 8;
            this.lNewAct.Text = "Nueva Actividad";
            this.lNewAct.Click += new System.EventHandler(this.lNewAct_Click);
            // 
            // gradosTableAdapter
            // 
            this.gradosTableAdapter.ClearBeforeFill = true;
            // 
            // actividadesTableAdapter
            // 
            this.actividadesTableAdapter.ClearBeforeFill = true;
            // 
            // PaginaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1093, 571);
            this.Controls.Add(this.lNewAct);
            this.Controls.Add(this.lNuevoProy);
            this.Controls.Add(this.bLogout);
            this.Controls.Add(this.lHistorial);
            this.Controls.Add(this.lMensajes);
            this.Controls.Add(this.lPerfil);
            this.Controls.Add(this.pictureUser);
            this.Controls.Add(this.lWelcome);
            this.Controls.Add(this.tabUser);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "PaginaPrincipal";
            this.Text = "Pagina Principal";
            this.Load += new System.EventHandler(this.PaginaPrincipal_Load);
            this.tabUser.ResumeLayout(false);
            this.pTodas.ResumeLayout(false);
            this.pPendientes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPendientes)).EndInit();
            this.pRevision.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRevision)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wePassDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wePassDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.actividadesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabUser;
        private System.Windows.Forms.TabPage pMatch;
        private System.Windows.Forms.TabPage pTodas;
        private System.Windows.Forms.TabPage pProyectos;
        private System.Windows.Forms.TabPage pValoracion;
        private System.Windows.Forms.TabPage pPendientes;
        private System.Windows.Forms.TabPage pRevision;
        private System.Windows.Forms.Label lWelcome;
        private System.Windows.Forms.PictureBox pictureUser;
        private System.Windows.Forms.Label lPerfil;
        private System.Windows.Forms.Label lMensajes;
        private System.Windows.Forms.Label lHistorial;
        private System.Windows.Forms.Button bLogout;
        private System.Windows.Forms.Label lNuevoProy;
        private System.Windows.Forms.Label lNewAct;
        private System.Windows.Forms.BindingSource wePassDataSetBindingSource;
        private WePassDataSet wePassDataSet;
        private System.Windows.Forms.BindingSource gradosBindingSource;
        private WePassDataSetTableAdapters.GradosTableAdapter gradosTableAdapter;
        private System.Windows.Forms.BindingSource actividadesBindingSource;
        private WePassDataSetTableAdapters.ActividadesTableAdapter actividadesTableAdapter;
        private System.Windows.Forms.Button bGestionar;
        private System.Windows.Forms.DataGridView dataGridViewPendientes;
        private System.Windows.Forms.DataGridView dataGridViewRevision;
        private System.Windows.Forms.TableLayoutPanel panelTodas;
        private System.Windows.Forms.TabPage pMisActividades;
        private System.Windows.Forms.TabPage pActividadesInscritas;
    }
}