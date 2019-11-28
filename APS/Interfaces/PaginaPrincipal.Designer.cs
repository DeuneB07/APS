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
            this.tabUser = new System.Windows.Forms.TabControl();
            this.pMatch = new System.Windows.Forms.TabPage();
            this.pTodas = new System.Windows.Forms.TabPage();
            this.dataGridViewActividades = new System.Windows.Forms.DataGridView();
            this.nombreActDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionActDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numPlazasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numHorasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.turnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaInicioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaFinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lugarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailOrganizadorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emaiResponsableDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoActDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idProyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notaMediaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imagenDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.tipoTrabajoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ambitoTrabajoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.actividadesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.wePassDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.wePassDataSet = new APS.WePassDataSet();
            this.labelGrado = new System.Windows.Forms.Label();
            this.listGrados = new System.Windows.Forms.ListBox();
            this.gradosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pProyectos = new System.Windows.Forms.TabPage();
            this.pValoracion = new System.Windows.Forms.TabPage();
            this.pPendientes = new System.Windows.Forms.TabPage();
            this.pRevision = new System.Windows.Forms.TabPage();
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
            this.dataGridViewPendientes = new System.Windows.Forms.DataGridView();
            this.iDActividadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreActDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionActDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailOrganizadorDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bGestionar = new System.Windows.Forms.Button();
            this.tabUser.SuspendLayout();
            this.pTodas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewActividades)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.actividadesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wePassDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wePassDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradosBindingSource)).BeginInit();
            this.pPendientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPendientes)).BeginInit();
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
            this.tabUser.HotTrack = true;
            this.tabUser.Location = new System.Drawing.Point(28, 73);
            this.tabUser.Margin = new System.Windows.Forms.Padding(4);
            this.tabUser.Name = "tabUser";
            this.tabUser.SelectedIndex = 0;
            this.tabUser.Size = new System.Drawing.Size(860, 439);
            this.tabUser.TabIndex = 0;
            // 
            // pMatch
            // 
            this.pMatch.Location = new System.Drawing.Point(4, 25);
            this.pMatch.Margin = new System.Windows.Forms.Padding(4);
            this.pMatch.Name = "pMatch";
            this.pMatch.Padding = new System.Windows.Forms.Padding(4);
            this.pMatch.Size = new System.Drawing.Size(852, 410);
            this.pMatch.TabIndex = 0;
            this.pMatch.Text = "Match";
            this.pMatch.UseVisualStyleBackColor = true;
            // 
            // pTodas
            // 
            this.pTodas.Controls.Add(this.dataGridViewActividades);
            this.pTodas.Controls.Add(this.labelGrado);
            this.pTodas.Controls.Add(this.listGrados);
            this.pTodas.Location = new System.Drawing.Point(4, 25);
            this.pTodas.Margin = new System.Windows.Forms.Padding(4);
            this.pTodas.Name = "pTodas";
            this.pTodas.Padding = new System.Windows.Forms.Padding(4);
            this.pTodas.Size = new System.Drawing.Size(852, 410);
            this.pTodas.TabIndex = 1;
            this.pTodas.Text = "Todas";
            this.pTodas.UseVisualStyleBackColor = true;
            // 
            // dataGridViewActividades
            // 
            this.dataGridViewActividades.AutoGenerateColumns = false;
            this.dataGridViewActividades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewActividades.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombreActDataGridViewTextBoxColumn,
            this.descripcionActDataGridViewTextBoxColumn,
            this.numPlazasDataGridViewTextBoxColumn,
            this.numHorasDataGridViewTextBoxColumn,
            this.turnoDataGridViewTextBoxColumn,
            this.fechaInicioDataGridViewTextBoxColumn,
            this.fechaFinDataGridViewTextBoxColumn,
            this.lugarDataGridViewTextBoxColumn,
            this.emailOrganizadorDataGridViewTextBoxColumn,
            this.emaiResponsableDataGridViewTextBoxColumn,
            this.tipoActDataGridViewTextBoxColumn,
            this.idProyDataGridViewTextBoxColumn,
            this.notaMediaDataGridViewTextBoxColumn,
            this.imagenDataGridViewImageColumn,
            this.tipoTrabajoDataGridViewTextBoxColumn,
            this.ambitoTrabajoDataGridViewTextBoxColumn});
            this.dataGridViewActividades.DataSource = this.actividadesBindingSource;
            this.dataGridViewActividades.Location = new System.Drawing.Point(34, 55);
            this.dataGridViewActividades.Name = "dataGridViewActividades";
            this.dataGridViewActividades.RowTemplate.Height = 24;
            this.dataGridViewActividades.Size = new System.Drawing.Size(783, 338);
            this.dataGridViewActividades.TabIndex = 2;
            // 
            // nombreActDataGridViewTextBoxColumn
            // 
            this.nombreActDataGridViewTextBoxColumn.DataPropertyName = "nombreAct";
            this.nombreActDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreActDataGridViewTextBoxColumn.Name = "nombreActDataGridViewTextBoxColumn";
            // 
            // descripcionActDataGridViewTextBoxColumn
            // 
            this.descripcionActDataGridViewTextBoxColumn.DataPropertyName = "descripcionAct";
            this.descripcionActDataGridViewTextBoxColumn.HeaderText = "Descripcion";
            this.descripcionActDataGridViewTextBoxColumn.Name = "descripcionActDataGridViewTextBoxColumn";
            // 
            // numPlazasDataGridViewTextBoxColumn
            // 
            this.numPlazasDataGridViewTextBoxColumn.DataPropertyName = "numPlazas";
            this.numPlazasDataGridViewTextBoxColumn.HeaderText = "Nº Plazas";
            this.numPlazasDataGridViewTextBoxColumn.Name = "numPlazasDataGridViewTextBoxColumn";
            // 
            // numHorasDataGridViewTextBoxColumn
            // 
            this.numHorasDataGridViewTextBoxColumn.DataPropertyName = "numHoras";
            this.numHorasDataGridViewTextBoxColumn.HeaderText = "Nº Horas";
            this.numHorasDataGridViewTextBoxColumn.Name = "numHorasDataGridViewTextBoxColumn";
            // 
            // turnoDataGridViewTextBoxColumn
            // 
            this.turnoDataGridViewTextBoxColumn.DataPropertyName = "turno";
            this.turnoDataGridViewTextBoxColumn.HeaderText = "Turno";
            this.turnoDataGridViewTextBoxColumn.Name = "turnoDataGridViewTextBoxColumn";
            // 
            // fechaInicioDataGridViewTextBoxColumn
            // 
            this.fechaInicioDataGridViewTextBoxColumn.DataPropertyName = "fechaInicio";
            this.fechaInicioDataGridViewTextBoxColumn.HeaderText = "Fecha Inicio";
            this.fechaInicioDataGridViewTextBoxColumn.Name = "fechaInicioDataGridViewTextBoxColumn";
            // 
            // fechaFinDataGridViewTextBoxColumn
            // 
            this.fechaFinDataGridViewTextBoxColumn.DataPropertyName = "fechaFin";
            this.fechaFinDataGridViewTextBoxColumn.HeaderText = "Fecha Fin";
            this.fechaFinDataGridViewTextBoxColumn.Name = "fechaFinDataGridViewTextBoxColumn";
            // 
            // lugarDataGridViewTextBoxColumn
            // 
            this.lugarDataGridViewTextBoxColumn.DataPropertyName = "lugar";
            this.lugarDataGridViewTextBoxColumn.HeaderText = "Lugar";
            this.lugarDataGridViewTextBoxColumn.Name = "lugarDataGridViewTextBoxColumn";
            // 
            // emailOrganizadorDataGridViewTextBoxColumn
            // 
            this.emailOrganizadorDataGridViewTextBoxColumn.DataPropertyName = "emailOrganizador";
            this.emailOrganizadorDataGridViewTextBoxColumn.HeaderText = "ONG";
            this.emailOrganizadorDataGridViewTextBoxColumn.Name = "emailOrganizadorDataGridViewTextBoxColumn";
            // 
            // emaiResponsableDataGridViewTextBoxColumn
            // 
            this.emaiResponsableDataGridViewTextBoxColumn.DataPropertyName = "emaiResponsable";
            this.emaiResponsableDataGridViewTextBoxColumn.HeaderText = "Responsable";
            this.emaiResponsableDataGridViewTextBoxColumn.Name = "emaiResponsableDataGridViewTextBoxColumn";
            // 
            // tipoActDataGridViewTextBoxColumn
            // 
            this.tipoActDataGridViewTextBoxColumn.DataPropertyName = "tipoAct";
            this.tipoActDataGridViewTextBoxColumn.HeaderText = "Tipo Actividad";
            this.tipoActDataGridViewTextBoxColumn.Name = "tipoActDataGridViewTextBoxColumn";
            // 
            // idProyDataGridViewTextBoxColumn
            // 
            this.idProyDataGridViewTextBoxColumn.DataPropertyName = "idProy";
            this.idProyDataGridViewTextBoxColumn.HeaderText = "idProy";
            this.idProyDataGridViewTextBoxColumn.Name = "idProyDataGridViewTextBoxColumn";
            // 
            // notaMediaDataGridViewTextBoxColumn
            // 
            this.notaMediaDataGridViewTextBoxColumn.DataPropertyName = "notaMedia";
            this.notaMediaDataGridViewTextBoxColumn.HeaderText = "Nota Media";
            this.notaMediaDataGridViewTextBoxColumn.Name = "notaMediaDataGridViewTextBoxColumn";
            // 
            // imagenDataGridViewImageColumn
            // 
            this.imagenDataGridViewImageColumn.DataPropertyName = "imagen";
            this.imagenDataGridViewImageColumn.HeaderText = "imagen";
            this.imagenDataGridViewImageColumn.Name = "imagenDataGridViewImageColumn";
            // 
            // tipoTrabajoDataGridViewTextBoxColumn
            // 
            this.tipoTrabajoDataGridViewTextBoxColumn.DataPropertyName = "tipoTrabajo";
            this.tipoTrabajoDataGridViewTextBoxColumn.HeaderText = "Tipo Trabajo";
            this.tipoTrabajoDataGridViewTextBoxColumn.Name = "tipoTrabajoDataGridViewTextBoxColumn";
            // 
            // ambitoTrabajoDataGridViewTextBoxColumn
            // 
            this.ambitoTrabajoDataGridViewTextBoxColumn.DataPropertyName = "ambitoTrabajo";
            this.ambitoTrabajoDataGridViewTextBoxColumn.HeaderText = "Ambito Trabajo";
            this.ambitoTrabajoDataGridViewTextBoxColumn.Name = "ambitoTrabajoDataGridViewTextBoxColumn";
            // 
            // actividadesBindingSource
            // 
            this.actividadesBindingSource.DataMember = "Actividades";
            this.actividadesBindingSource.DataSource = this.wePassDataSetBindingSource;
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
            // labelGrado
            // 
            this.labelGrado.AutoSize = true;
            this.labelGrado.Location = new System.Drawing.Point(120, 18);
            this.labelGrado.Name = "labelGrado";
            this.labelGrado.Size = new System.Drawing.Size(52, 17);
            this.labelGrado.TabIndex = 1;
            this.labelGrado.Text = "Grado:";
            // 
            // listGrados
            // 
            this.listGrados.DataSource = this.gradosBindingSource;
            this.listGrados.DisplayMember = "nombreGrado";
            this.listGrados.FormattingEnabled = true;
            this.listGrados.ItemHeight = 16;
            this.listGrados.Location = new System.Drawing.Point(189, 18);
            this.listGrados.Name = "listGrados";
            this.listGrados.Size = new System.Drawing.Size(93, 20);
            this.listGrados.TabIndex = 0;
            this.listGrados.SelectedIndexChanged += new System.EventHandler(this.listGrados_SelectedIndexChanged);
            // 
            // gradosBindingSource
            // 
            this.gradosBindingSource.DataMember = "Grados";
            this.gradosBindingSource.DataSource = this.wePassDataSetBindingSource;
            // 
            // pProyectos
            // 
            this.pProyectos.Location = new System.Drawing.Point(4, 25);
            this.pProyectos.Margin = new System.Windows.Forms.Padding(4);
            this.pProyectos.Name = "pProyectos";
            this.pProyectos.Padding = new System.Windows.Forms.Padding(4);
            this.pProyectos.Size = new System.Drawing.Size(852, 410);
            this.pProyectos.TabIndex = 2;
            this.pProyectos.Text = "Proyectos";
            this.pProyectos.UseVisualStyleBackColor = true;
            // 
            // pValoracion
            // 
            this.pValoracion.Location = new System.Drawing.Point(4, 25);
            this.pValoracion.Margin = new System.Windows.Forms.Padding(4);
            this.pValoracion.Name = "pValoracion";
            this.pValoracion.Padding = new System.Windows.Forms.Padding(4);
            this.pValoracion.Size = new System.Drawing.Size(852, 410);
            this.pValoracion.TabIndex = 3;
            this.pValoracion.Text = "Valoración";
            this.pValoracion.UseVisualStyleBackColor = true;
            // 
            // pPendientes
            // 
            this.pPendientes.Controls.Add(this.bGestionar);
            this.pPendientes.Controls.Add(this.dataGridViewPendientes);
            this.pPendientes.Location = new System.Drawing.Point(4, 25);
            this.pPendientes.Margin = new System.Windows.Forms.Padding(4);
            this.pPendientes.Name = "pPendientes";
            this.pPendientes.Padding = new System.Windows.Forms.Padding(4);
            this.pPendientes.Size = new System.Drawing.Size(852, 410);
            this.pPendientes.TabIndex = 4;
            this.pPendientes.Text = "Pendientes";
            this.pPendientes.UseVisualStyleBackColor = true;
            // 
            // pRevision
            // 
            this.pRevision.Location = new System.Drawing.Point(4, 25);
            this.pRevision.Margin = new System.Windows.Forms.Padding(4);
            this.pRevision.Name = "pRevision";
            this.pRevision.Padding = new System.Windows.Forms.Padding(4);
            this.pRevision.Size = new System.Drawing.Size(852, 410);
            this.pRevision.TabIndex = 5;
            this.pRevision.Text = "Revisión";
            this.pRevision.UseVisualStyleBackColor = true;
            // 
            // lWelcome
            // 
            this.lWelcome.AutoSize = true;
            this.lWelcome.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lWelcome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lWelcome.Location = new System.Drawing.Point(61, 25);
            this.lWelcome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lWelcome.Name = "lWelcome";
            this.lWelcome.Size = new System.Drawing.Size(0, 29);
            this.lWelcome.TabIndex = 1;
            // 
            // pictureUser
            // 
            this.pictureUser.Location = new System.Drawing.Point(940, 15);
            this.pictureUser.Margin = new System.Windows.Forms.Padding(4);
            this.pictureUser.Name = "pictureUser";
            this.pictureUser.Size = new System.Drawing.Size(105, 94);
            this.pictureUser.TabIndex = 2;
            this.pictureUser.TabStop = false;
            // 
            // lPerfil
            // 
            this.lPerfil.AutoSize = true;
            this.lPerfil.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lPerfil.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lPerfil.Location = new System.Drawing.Point(923, 153);
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
            this.bLogout.Margin = new System.Windows.Forms.Padding(4);
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
            this.lNewAct.Location = new System.Drawing.Point(923, 199);
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
            // dataGridViewPendientes
            // 
            this.dataGridViewPendientes.AutoGenerateColumns = false;
            this.dataGridViewPendientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPendientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDActividadDataGridViewTextBoxColumn,
            this.nombreActDataGridViewTextBoxColumn1,
            this.descripcionActDataGridViewTextBoxColumn1,
            this.emailOrganizadorDataGridViewTextBoxColumn1});
            this.dataGridViewPendientes.DataSource = this.actividadesBindingSource;
            this.dataGridViewPendientes.Location = new System.Drawing.Point(34, 18);
            this.dataGridViewPendientes.Name = "dataGridViewPendientes";
            this.dataGridViewPendientes.RowTemplate.Height = 24;
            this.dataGridViewPendientes.Size = new System.Drawing.Size(655, 366);
            this.dataGridViewPendientes.TabIndex = 0;
            // 
            // iDActividadDataGridViewTextBoxColumn
            // 
            this.iDActividadDataGridViewTextBoxColumn.DataPropertyName = "ID_Actividad";
            this.iDActividadDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDActividadDataGridViewTextBoxColumn.Name = "iDActividadDataGridViewTextBoxColumn";
            this.iDActividadDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreActDataGridViewTextBoxColumn1
            // 
            this.nombreActDataGridViewTextBoxColumn1.DataPropertyName = "nombreAct";
            this.nombreActDataGridViewTextBoxColumn1.HeaderText = "Nombre";
            this.nombreActDataGridViewTextBoxColumn1.Name = "nombreActDataGridViewTextBoxColumn1";
            // 
            // descripcionActDataGridViewTextBoxColumn1
            // 
            this.descripcionActDataGridViewTextBoxColumn1.DataPropertyName = "descripcionAct";
            this.descripcionActDataGridViewTextBoxColumn1.HeaderText = "Descripcion";
            this.descripcionActDataGridViewTextBoxColumn1.Name = "descripcionActDataGridViewTextBoxColumn1";
            // 
            // emailOrganizadorDataGridViewTextBoxColumn1
            // 
            this.emailOrganizadorDataGridViewTextBoxColumn1.DataPropertyName = "emailOrganizador";
            this.emailOrganizadorDataGridViewTextBoxColumn1.HeaderText = "ONG";
            this.emailOrganizadorDataGridViewTextBoxColumn1.Name = "emailOrganizadorDataGridViewTextBoxColumn1";
            // 
            // bGestionar
            // 
            this.bGestionar.Location = new System.Drawing.Point(730, 28);
            this.bGestionar.Name = "bGestionar";
            this.bGestionar.Size = new System.Drawing.Size(86, 23);
            this.bGestionar.TabIndex = 2;
            this.bGestionar.Text = "Gestionar";
            this.bGestionar.UseVisualStyleBackColor = true;
            this.bGestionar.Click += new System.EventHandler(this.bGestionar_Click);
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
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PaginaPrincipal";
            this.Text = "Pagina Principal";
            this.Load += new System.EventHandler(this.PaginaPrincipal_Load);
            this.tabUser.ResumeLayout(false);
            this.pTodas.ResumeLayout(false);
            this.pTodas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewActividades)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.actividadesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wePassDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wePassDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradosBindingSource)).EndInit();
            this.pPendientes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPendientes)).EndInit();
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
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreActDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionActDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numPlazasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numHorasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn turnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaInicioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaFinDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lugarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailOrganizadorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emaiResponsableDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoActDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn notaMediaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn imagenDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoTrabajoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ambitoTrabajoDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button bGestionar;
        private System.Windows.Forms.DataGridView dataGridViewPendientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDActividadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreActDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionActDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailOrganizadorDataGridViewTextBoxColumn1;
    }
}