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
            this.dataGridViewActividades = new System.Windows.Forms.DataGridView();
            this.labelGrado = new System.Windows.Forms.Label();
            this.listGrados = new System.Windows.Forms.ListBox();
            this.gradosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.wePassDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.wePassDataSet = new APS.WePassDataSet();
            this.pProyectos = new System.Windows.Forms.TabPage();
            this.pValoracion = new System.Windows.Forms.TabPage();
            this.pPendientes = new System.Windows.Forms.TabPage();
            this.bGestionar = new System.Windows.Forms.Button();
            this.dataGridViewPendientes = new System.Windows.Forms.DataGridView();
            this.pRevision = new System.Windows.Forms.TabPage();
            this.dataGridViewRevision = new System.Windows.Forms.DataGridView();
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
            this.pMisActividades = new System.Windows.Forms.TabPage();
            this.pActividadesInscritas = new System.Windows.Forms.TabPage();
            this.dataGridViewMisActividades = new System.Windows.Forms.DataGridView();
            this.dataGridViewActividadesInscritas = new System.Windows.Forms.DataGridView();
            this.tabUser.SuspendLayout();
            this.pTodas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewActividades)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wePassDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wePassDataSet)).BeginInit();
            this.pPendientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPendientes)).BeginInit();
            this.pRevision.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRevision)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.actividadesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureUser)).BeginInit();
            this.pMisActividades.SuspendLayout();
            this.pActividadesInscritas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMisActividades)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewActividadesInscritas)).BeginInit();
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
            this.tabUser.Location = new System.Drawing.Point(42, 114);
            this.tabUser.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tabUser.Name = "tabUser";
            this.tabUser.SelectedIndex = 0;
            this.tabUser.Size = new System.Drawing.Size(1290, 686);
            this.tabUser.TabIndex = 0;
            // 
            // pMatch
            // 
            this.pMatch.Location = new System.Drawing.Point(8, 39);
            this.pMatch.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.pMatch.Name = "pMatch";
            this.pMatch.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.pMatch.Size = new System.Drawing.Size(1274, 639);
            this.pMatch.TabIndex = 0;
            this.pMatch.Text = "Match";
            this.pMatch.UseVisualStyleBackColor = true;
            // 
            // pTodas
            // 
            this.pTodas.Controls.Add(this.dataGridViewActividades);
            this.pTodas.Controls.Add(this.labelGrado);
            this.pTodas.Controls.Add(this.listGrados);
            this.pTodas.Location = new System.Drawing.Point(8, 39);
            this.pTodas.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.pTodas.Name = "pTodas";
            this.pTodas.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.pTodas.Size = new System.Drawing.Size(1274, 639);
            this.pTodas.TabIndex = 1;
            this.pTodas.Text = "Todas";
            this.pTodas.UseVisualStyleBackColor = true;
            // 
            // dataGridViewActividades
            // 
            this.dataGridViewActividades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewActividades.Location = new System.Drawing.Point(51, 102);
            this.dataGridViewActividades.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridViewActividades.Name = "dataGridViewActividades";
            this.dataGridViewActividades.RowHeadersWidth = 82;
            this.dataGridViewActividades.RowTemplate.Height = 24;
            this.dataGridViewActividades.Size = new System.Drawing.Size(1174, 528);
            this.dataGridViewActividades.TabIndex = 2;
            // 
            // labelGrado
            // 
            this.labelGrado.AutoSize = true;
            this.labelGrado.Location = new System.Drawing.Point(180, 28);
            this.labelGrado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelGrado.Name = "labelGrado";
            this.labelGrado.Size = new System.Drawing.Size(77, 25);
            this.labelGrado.TabIndex = 1;
            this.labelGrado.Text = "Grado:";
            // 
            // listGrados
            // 
            this.listGrados.DataSource = this.gradosBindingSource;
            this.listGrados.DisplayMember = "nombreGrado";
            this.listGrados.FormattingEnabled = true;
            this.listGrados.ItemHeight = 25;
            this.listGrados.Location = new System.Drawing.Point(284, 28);
            this.listGrados.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listGrados.Name = "listGrados";
            this.listGrados.Size = new System.Drawing.Size(138, 29);
            this.listGrados.TabIndex = 0;
            this.listGrados.SelectedIndexChanged += new System.EventHandler(this.listGrados_SelectedIndexChanged);
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
            // pProyectos
            // 
            this.pProyectos.Location = new System.Drawing.Point(8, 39);
            this.pProyectos.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.pProyectos.Name = "pProyectos";
            this.pProyectos.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.pProyectos.Size = new System.Drawing.Size(1274, 639);
            this.pProyectos.TabIndex = 2;
            this.pProyectos.Text = "Proyectos";
            this.pProyectos.UseVisualStyleBackColor = true;
            // 
            // pValoracion
            // 
            this.pValoracion.Location = new System.Drawing.Point(8, 39);
            this.pValoracion.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.pValoracion.Name = "pValoracion";
            this.pValoracion.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.pValoracion.Size = new System.Drawing.Size(1274, 639);
            this.pValoracion.TabIndex = 3;
            this.pValoracion.Text = "Valoración";
            this.pValoracion.UseVisualStyleBackColor = true;
            // 
            // pPendientes
            // 
            this.pPendientes.Controls.Add(this.bGestionar);
            this.pPendientes.Controls.Add(this.dataGridViewPendientes);
            this.pPendientes.Location = new System.Drawing.Point(8, 39);
            this.pPendientes.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.pPendientes.Name = "pPendientes";
            this.pPendientes.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.pPendientes.Size = new System.Drawing.Size(1274, 639);
            this.pPendientes.TabIndex = 4;
            this.pPendientes.Text = "Pendientes";
            this.pPendientes.UseVisualStyleBackColor = true;
            // 
            // bGestionar
            // 
            this.bGestionar.Location = new System.Drawing.Point(1095, 44);
            this.bGestionar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bGestionar.Name = "bGestionar";
            this.bGestionar.Size = new System.Drawing.Size(129, 36);
            this.bGestionar.TabIndex = 2;
            this.bGestionar.Text = "Gestionar";
            this.bGestionar.UseVisualStyleBackColor = true;
            this.bGestionar.Click += new System.EventHandler(this.bGestionar_Click);
            // 
            // dataGridViewPendientes
            // 
            this.dataGridViewPendientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPendientes.Location = new System.Drawing.Point(51, 28);
            this.dataGridViewPendientes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridViewPendientes.Name = "dataGridViewPendientes";
            this.dataGridViewPendientes.RowHeadersWidth = 82;
            this.dataGridViewPendientes.RowTemplate.Height = 24;
            this.dataGridViewPendientes.Size = new System.Drawing.Size(982, 572);
            this.dataGridViewPendientes.TabIndex = 0;
            this.dataGridViewPendientes.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPendientes_CellDoubleClick);
            // 
            // pRevision
            // 
            this.pRevision.Controls.Add(this.dataGridViewRevision);
            this.pRevision.Location = new System.Drawing.Point(8, 39);
            this.pRevision.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.pRevision.Name = "pRevision";
            this.pRevision.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.pRevision.Size = new System.Drawing.Size(1274, 639);
            this.pRevision.TabIndex = 5;
            this.pRevision.Text = "Revisión";
            this.pRevision.UseVisualStyleBackColor = true;
            // 
            // dataGridViewRevision
            // 
            this.dataGridViewRevision.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRevision.Location = new System.Drawing.Point(148, 34);
            this.dataGridViewRevision.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridViewRevision.Name = "dataGridViewRevision";
            this.dataGridViewRevision.RowHeadersWidth = 82;
            this.dataGridViewRevision.RowTemplate.Height = 24;
            this.dataGridViewRevision.Size = new System.Drawing.Size(982, 572);
            this.dataGridViewRevision.TabIndex = 1;
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
            this.lWelcome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lWelcome.Location = new System.Drawing.Point(92, 39);
            this.lWelcome.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lWelcome.Name = "lWelcome";
            this.lWelcome.Size = new System.Drawing.Size(0, 46);
            this.lWelcome.TabIndex = 1;
            // 
            // pictureUser
            // 
            this.pictureUser.Location = new System.Drawing.Point(1410, 23);
            this.pictureUser.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.pictureUser.Name = "pictureUser";
            this.pictureUser.Size = new System.Drawing.Size(158, 147);
            this.pictureUser.TabIndex = 2;
            this.pictureUser.TabStop = false;
            // 
            // lPerfil
            // 
            this.lPerfil.AutoSize = true;
            this.lPerfil.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lPerfil.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lPerfil.Location = new System.Drawing.Point(1384, 239);
            this.lPerfil.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lPerfil.Name = "lPerfil";
            this.lPerfil.Size = new System.Drawing.Size(86, 39);
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
            this.lMensajes.Location = new System.Drawing.Point(1384, 275);
            this.lMensajes.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lMensajes.Name = "lMensajes";
            this.lMensajes.Size = new System.Drawing.Size(145, 39);
            this.lMensajes.TabIndex = 4;
            this.lMensajes.Text = "Mensajes";
            // 
            // lHistorial
            // 
            this.lHistorial.AutoSize = true;
            this.lHistorial.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lHistorial.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lHistorial.Location = new System.Drawing.Point(1384, 384);
            this.lHistorial.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lHistorial.Name = "lHistorial";
            this.lHistorial.Size = new System.Drawing.Size(130, 39);
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
            this.bLogout.Location = new System.Drawing.Point(1392, 181);
            this.bLogout.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.bLogout.Name = "bLogout";
            this.bLogout.Size = new System.Drawing.Size(196, 52);
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
            this.lNuevoProy.Location = new System.Drawing.Point(1384, 348);
            this.lNuevoProy.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lNuevoProy.Name = "lNuevoProy";
            this.lNuevoProy.Size = new System.Drawing.Size(227, 39);
            this.lNuevoProy.TabIndex = 7;
            this.lNuevoProy.Text = "Nuevo Proyecto";
            // 
            // lNewAct
            // 
            this.lNewAct.AutoSize = true;
            this.lNewAct.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lNewAct.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lNewAct.Location = new System.Drawing.Point(1384, 311);
            this.lNewAct.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lNewAct.Name = "lNewAct";
            this.lNewAct.Size = new System.Drawing.Size(235, 39);
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
            // pMisActividades
            // 
            this.pMisActividades.Controls.Add(this.dataGridViewMisActividades);
            this.pMisActividades.Location = new System.Drawing.Point(8, 39);
            this.pMisActividades.Name = "pMisActividades";
            this.pMisActividades.Padding = new System.Windows.Forms.Padding(3);
            this.pMisActividades.Size = new System.Drawing.Size(1274, 639);
            this.pMisActividades.TabIndex = 6;
            this.pMisActividades.Text = "Mis Actividades";
            this.pMisActividades.UseVisualStyleBackColor = true;
            // 
            // pActividadesInscritas
            // 
            this.pActividadesInscritas.Controls.Add(this.dataGridViewActividadesInscritas);
            this.pActividadesInscritas.Location = new System.Drawing.Point(8, 39);
            this.pActividadesInscritas.Name = "pActividadesInscritas";
            this.pActividadesInscritas.Padding = new System.Windows.Forms.Padding(3);
            this.pActividadesInscritas.Size = new System.Drawing.Size(1274, 639);
            this.pActividadesInscritas.TabIndex = 7;
            this.pActividadesInscritas.Text = "Actividades Inscritas";
            this.pActividadesInscritas.UseVisualStyleBackColor = true;
            // 
            // dataGridViewMisActividades
            // 
            this.dataGridViewMisActividades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMisActividades.Location = new System.Drawing.Point(20, 11);
            this.dataGridViewMisActividades.Name = "dataGridViewMisActividades";
            this.dataGridViewMisActividades.RowHeadersWidth = 82;
            this.dataGridViewMisActividades.RowTemplate.Height = 33;
            this.dataGridViewMisActividades.Size = new System.Drawing.Size(1227, 603);
            this.dataGridViewMisActividades.TabIndex = 0;
            // 
            // dataGridViewActividadesInscritas
            // 
            this.dataGridViewActividadesInscritas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewActividadesInscritas.Location = new System.Drawing.Point(24, 18);
            this.dataGridViewActividadesInscritas.Name = "dataGridViewActividadesInscritas";
            this.dataGridViewActividadesInscritas.RowHeadersWidth = 82;
            this.dataGridViewActividadesInscritas.RowTemplate.Height = 33;
            this.dataGridViewActividadesInscritas.Size = new System.Drawing.Size(1227, 603);
            this.dataGridViewActividadesInscritas.TabIndex = 1;
            // 
            // PaginaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1640, 892);
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
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "PaginaPrincipal";
            this.Text = "Pagina Principal";
            this.Load += new System.EventHandler(this.PaginaPrincipal_Load);
            this.tabUser.ResumeLayout(false);
            this.pTodas.ResumeLayout(false);
            this.pTodas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewActividades)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wePassDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wePassDataSet)).EndInit();
            this.pPendientes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPendientes)).EndInit();
            this.pRevision.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRevision)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.actividadesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureUser)).EndInit();
            this.pMisActividades.ResumeLayout(false);
            this.pActividadesInscritas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMisActividades)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewActividadesInscritas)).EndInit();
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
        private System.Windows.Forms.ListBox listGrados;
        private System.Windows.Forms.BindingSource wePassDataSetBindingSource;
        private WePassDataSet wePassDataSet;
        private System.Windows.Forms.BindingSource gradosBindingSource;
        private WePassDataSetTableAdapters.GradosTableAdapter gradosTableAdapter;
        private System.Windows.Forms.Label labelGrado;
        private System.Windows.Forms.DataGridView dataGridViewActividades;
        private System.Windows.Forms.BindingSource actividadesBindingSource;
        private WePassDataSetTableAdapters.ActividadesTableAdapter actividadesTableAdapter;
        private System.Windows.Forms.Button bGestionar;
        private System.Windows.Forms.DataGridView dataGridViewPendientes;
        private System.Windows.Forms.DataGridView dataGridViewRevision;
        private System.Windows.Forms.TabPage pMisActividades;
        private System.Windows.Forms.TabPage pActividadesInscritas;
        private System.Windows.Forms.DataGridView dataGridViewMisActividades;
        private System.Windows.Forms.DataGridView dataGridViewActividadesInscritas;
    }
}