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
            this.panelMatch = new System.Windows.Forms.TableLayoutPanel();
            this.pTodas = new System.Windows.Forms.TabPage();
            this.panelTodas = new System.Windows.Forms.TableLayoutPanel();
            this.pProyectos = new System.Windows.Forms.TabPage();
            this.pValoracion = new System.Windows.Forms.TabPage();
            this.pPendientes = new System.Windows.Forms.TabPage();
            this.panelPendientes = new System.Windows.Forms.TableLayoutPanel();
            this.pRevision = new System.Windows.Forms.TabPage();
            this.panelRevision = new System.Windows.Forms.TableLayoutPanel();
            this.pMisActividades = new System.Windows.Forms.TabPage();
            this.panelMisActs = new System.Windows.Forms.TableLayoutPanel();
            this.pActividadesInscritas = new System.Windows.Forms.TabPage();
            this.panelActIns = new System.Windows.Forms.TableLayoutPanel();
            this.gradosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.wePassDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.wePassDataSet = new APS.WePassDataSet();
            this.actividadesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lWelcome = new System.Windows.Forms.Label();
            this.gradosTableAdapter = new APS.WePassDataSetTableAdapters.GradosTableAdapter();
            this.actividadesTableAdapter = new APS.WePassDataSetTableAdapters.ActividadesTableAdapter();
            this.lHistorial = new System.Windows.Forms.Label();
            this.lProyecto = new System.Windows.Forms.Label();
            this.lActividad = new System.Windows.Forms.Label();
            this.lPerfil = new System.Windows.Forms.Label();
            this.lMensajes = new System.Windows.Forms.Label();
            this.pictCerrarSesion = new System.Windows.Forms.PictureBox();
            this.pictMensajes = new System.Windows.Forms.PictureBox();
            this.pictActividad = new System.Windows.Forms.PictureBox();
            this.pictProyectos = new System.Windows.Forms.PictureBox();
            this.pictPerfil = new System.Windows.Forms.PictureBox();
            this.pictureUser = new System.Windows.Forms.PictureBox();
            this.pictHistorial = new System.Windows.Forms.PictureBox();
            this.lCerrarSesion = new System.Windows.Forms.Label();
            this.tabUser.SuspendLayout();
            this.pMatch.SuspendLayout();
            this.pTodas.SuspendLayout();
            this.pPendientes.SuspendLayout();
            this.pRevision.SuspendLayout();
            this.pMisActividades.SuspendLayout();
            this.pActividadesInscritas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gradosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wePassDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wePassDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.actividadesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictCerrarSesion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictMensajes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictActividad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictProyectos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictPerfil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictHistorial)).BeginInit();
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
            this.tabUser.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabUser.HotTrack = true;
            this.tabUser.Location = new System.Drawing.Point(21, 58);
            this.tabUser.Name = "tabUser";
            this.tabUser.SelectedIndex = 0;
            this.tabUser.Size = new System.Drawing.Size(665, 406);
            this.tabUser.TabIndex = 0;
            // 
            // pMatch
            // 
            this.pMatch.Controls.Add(this.panelMatch);
            this.pMatch.Location = new System.Drawing.Point(4, 22);
            this.pMatch.Name = "pMatch";
            this.pMatch.Padding = new System.Windows.Forms.Padding(3);
            this.pMatch.Size = new System.Drawing.Size(657, 380);
            this.pMatch.TabIndex = 0;
            this.pMatch.Text = "Match";
            this.pMatch.UseVisualStyleBackColor = true;
            // 
            // panelMatch
            // 
            this.panelMatch.AutoScroll = true;
            this.panelMatch.ColumnCount = 1;
            this.panelMatch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panelMatch.Location = new System.Drawing.Point(0, 0);
            this.panelMatch.Name = "panelMatch";
            this.panelMatch.RowCount = 1;
            this.panelMatch.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.panelMatch.Size = new System.Drawing.Size(657, 380);
            this.panelMatch.TabIndex = 2;
            // 
            // pTodas
            // 
            this.pTodas.Controls.Add(this.panelTodas);
            this.pTodas.Location = new System.Drawing.Point(4, 22);
            this.pTodas.Name = "pTodas";
            this.pTodas.Padding = new System.Windows.Forms.Padding(3);
            this.pTodas.Size = new System.Drawing.Size(657, 380);
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
            this.panelTodas.Name = "panelTodas";
            this.panelTodas.RowCount = 1;
            this.panelTodas.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.panelTodas.Size = new System.Drawing.Size(657, 332);
            this.panelTodas.TabIndex = 1;
            // 
            // pProyectos
            // 
            this.pProyectos.Location = new System.Drawing.Point(4, 22);
            this.pProyectos.Name = "pProyectos";
            this.pProyectos.Padding = new System.Windows.Forms.Padding(3);
            this.pProyectos.Size = new System.Drawing.Size(657, 380);
            this.pProyectos.TabIndex = 2;
            this.pProyectos.Text = "Proyectos";
            this.pProyectos.UseVisualStyleBackColor = true;
            // 
            // pValoracion
            // 
            this.pValoracion.Location = new System.Drawing.Point(4, 22);
            this.pValoracion.Name = "pValoracion";
            this.pValoracion.Padding = new System.Windows.Forms.Padding(3);
            this.pValoracion.Size = new System.Drawing.Size(657, 380);
            this.pValoracion.TabIndex = 3;
            this.pValoracion.Text = "Valoración";
            this.pValoracion.UseVisualStyleBackColor = true;
            // 
            // pPendientes
            // 
            this.pPendientes.Controls.Add(this.panelPendientes);
            this.pPendientes.Location = new System.Drawing.Point(4, 22);
            this.pPendientes.Name = "pPendientes";
            this.pPendientes.Padding = new System.Windows.Forms.Padding(3);
            this.pPendientes.Size = new System.Drawing.Size(657, 380);
            this.pPendientes.TabIndex = 4;
            this.pPendientes.Text = "Pendientes";
            this.pPendientes.UseVisualStyleBackColor = true;
            // 
            // panelPendientes
            // 
            this.panelPendientes.AutoScroll = true;
            this.panelPendientes.ColumnCount = 1;
            this.panelPendientes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panelPendientes.Location = new System.Drawing.Point(0, 0);
            this.panelPendientes.Name = "panelPendientes";
            this.panelPendientes.RowCount = 1;
            this.panelPendientes.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.panelPendientes.Size = new System.Drawing.Size(657, 332);
            this.panelPendientes.TabIndex = 2;
            // 
            // pRevision
            // 
            this.pRevision.Controls.Add(this.panelRevision);
            this.pRevision.Location = new System.Drawing.Point(4, 22);
            this.pRevision.Name = "pRevision";
            this.pRevision.Padding = new System.Windows.Forms.Padding(3);
            this.pRevision.Size = new System.Drawing.Size(657, 380);
            this.pRevision.TabIndex = 5;
            this.pRevision.Text = "Revisión";
            this.pRevision.UseVisualStyleBackColor = true;
            // 
            // panelRevision
            // 
            this.panelRevision.AutoScroll = true;
            this.panelRevision.ColumnCount = 1;
            this.panelRevision.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panelRevision.Location = new System.Drawing.Point(0, 0);
            this.panelRevision.Name = "panelRevision";
            this.panelRevision.RowCount = 1;
            this.panelRevision.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.panelRevision.Size = new System.Drawing.Size(657, 332);
            this.panelRevision.TabIndex = 3;
            // 
            // pMisActividades
            // 
            this.pMisActividades.Controls.Add(this.panelMisActs);
            this.pMisActividades.Location = new System.Drawing.Point(4, 22);
            this.pMisActividades.Margin = new System.Windows.Forms.Padding(2);
            this.pMisActividades.Name = "pMisActividades";
            this.pMisActividades.Padding = new System.Windows.Forms.Padding(2);
            this.pMisActividades.Size = new System.Drawing.Size(657, 380);
            this.pMisActividades.TabIndex = 6;
            this.pMisActividades.Text = "Mis Actividades";
            this.pMisActividades.UseVisualStyleBackColor = true;
            // 
            // panelMisActs
            // 
            this.panelMisActs.AutoScroll = true;
            this.panelMisActs.ColumnCount = 1;
            this.panelMisActs.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panelMisActs.Location = new System.Drawing.Point(0, 0);
            this.panelMisActs.Name = "panelMisActs";
            this.panelMisActs.RowCount = 1;
            this.panelMisActs.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.panelMisActs.Size = new System.Drawing.Size(657, 332);
            this.panelMisActs.TabIndex = 4;
            // 
            // pActividadesInscritas
            // 
            this.pActividadesInscritas.Controls.Add(this.panelActIns);
            this.pActividadesInscritas.Location = new System.Drawing.Point(4, 22);
            this.pActividadesInscritas.Margin = new System.Windows.Forms.Padding(2);
            this.pActividadesInscritas.Name = "pActividadesInscritas";
            this.pActividadesInscritas.Padding = new System.Windows.Forms.Padding(2);
            this.pActividadesInscritas.Size = new System.Drawing.Size(657, 380);
            this.pActividadesInscritas.TabIndex = 7;
            this.pActividadesInscritas.Text = "Actividades Inscritas";
            this.pActividadesInscritas.UseVisualStyleBackColor = true;
            // 
            // panelActIns
            // 
            this.panelActIns.AutoScroll = true;
            this.panelActIns.ColumnCount = 1;
            this.panelActIns.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panelActIns.Location = new System.Drawing.Point(0, 1);
            this.panelActIns.Name = "panelActIns";
            this.panelActIns.RowCount = 1;
            this.panelActIns.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.panelActIns.Size = new System.Drawing.Size(657, 332);
            this.panelActIns.TabIndex = 2;
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
            this.lWelcome.Font = new System.Drawing.Font("Bahnschrift", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lWelcome.ForeColor = System.Drawing.Color.Maroon;
            this.lWelcome.Location = new System.Drawing.Point(46, 20);
            this.lWelcome.Name = "lWelcome";
            this.lWelcome.Size = new System.Drawing.Size(86, 23);
            this.lWelcome.TabIndex = 1;
            this.lWelcome.Text = "Welcome";
            // 
            // gradosTableAdapter
            // 
            this.gradosTableAdapter.ClearBeforeFill = true;
            // 
            // actividadesTableAdapter
            // 
            this.actividadesTableAdapter.ClearBeforeFill = true;
            // 
            // lHistorial
            // 
            this.lHistorial.AutoSize = true;
            this.lHistorial.BackColor = System.Drawing.Color.Transparent;
            this.lHistorial.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lHistorial.ForeColor = System.Drawing.Color.Black;
            this.lHistorial.Location = new System.Drawing.Point(712, 304);
            this.lHistorial.Name = "lHistorial";
            this.lHistorial.Size = new System.Drawing.Size(50, 13);
            this.lHistorial.TabIndex = 27;
            this.lHistorial.Text = "Historial";
            // 
            // lProyecto
            // 
            this.lProyecto.AutoSize = true;
            this.lProyecto.BackColor = System.Drawing.Color.Transparent;
            this.lProyecto.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lProyecto.ForeColor = System.Drawing.Color.Black;
            this.lProyecto.Location = new System.Drawing.Point(697, 376);
            this.lProyecto.Name = "lProyecto";
            this.lProyecto.Size = new System.Drawing.Size(86, 13);
            this.lProyecto.TabIndex = 28;
            this.lProyecto.Text = "Nuevo Proyecto";
            // 
            // lActividad
            // 
            this.lActividad.AutoSize = true;
            this.lActividad.BackColor = System.Drawing.Color.Transparent;
            this.lActividad.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lActividad.ForeColor = System.Drawing.Color.Black;
            this.lActividad.Location = new System.Drawing.Point(698, 376);
            this.lActividad.Name = "lActividad";
            this.lActividad.Size = new System.Drawing.Size(85, 13);
            this.lActividad.TabIndex = 29;
            this.lActividad.Text = "Crear Actividad";
            // 
            // lPerfil
            // 
            this.lPerfil.AutoSize = true;
            this.lPerfil.BackColor = System.Drawing.Color.Transparent;
            this.lPerfil.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lPerfil.ForeColor = System.Drawing.Color.Black;
            this.lPerfil.Location = new System.Drawing.Point(721, 157);
            this.lPerfil.Name = "lPerfil";
            this.lPerfil.Size = new System.Drawing.Size(34, 13);
            this.lPerfil.TabIndex = 30;
            this.lPerfil.Text = "Perfil";
            // 
            // lMensajes
            // 
            this.lMensajes.AutoSize = true;
            this.lMensajes.BackColor = System.Drawing.Color.Transparent;
            this.lMensajes.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lMensajes.ForeColor = System.Drawing.Color.Black;
            this.lMensajes.Location = new System.Drawing.Point(712, 230);
            this.lMensajes.Name = "lMensajes";
            this.lMensajes.Size = new System.Drawing.Size(55, 13);
            this.lMensajes.TabIndex = 31;
            this.lMensajes.Text = "Mensajes";
            // 
            // pictCerrarSesion
            // 
            this.pictCerrarSesion.BackColor = System.Drawing.Color.Transparent;
            this.pictCerrarSesion.BackgroundImage = global::APS.Properties.Resources.cerrarsesion;
            this.pictCerrarSesion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictCerrarSesion.Location = new System.Drawing.Point(712, 392);
            this.pictCerrarSesion.Name = "pictCerrarSesion";
            this.pictCerrarSesion.Size = new System.Drawing.Size(50, 50);
            this.pictCerrarSesion.TabIndex = 37;
            this.pictCerrarSesion.TabStop = false;
            this.pictCerrarSesion.Click += new System.EventHandler(this.pictCerrarSesion_Click);
            // 
            // pictMensajes
            // 
            this.pictMensajes.BackColor = System.Drawing.Color.Transparent;
            this.pictMensajes.BackgroundImage = global::APS.Properties.Resources.mensajesicon;
            this.pictMensajes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictMensajes.Location = new System.Drawing.Point(712, 178);
            this.pictMensajes.Name = "pictMensajes";
            this.pictMensajes.Size = new System.Drawing.Size(50, 50);
            this.pictMensajes.TabIndex = 36;
            this.pictMensajes.TabStop = false;
            this.pictMensajes.Click += new System.EventHandler(this.pictMensajes_Click);
            // 
            // pictActividad
            // 
            this.pictActividad.BackColor = System.Drawing.Color.Transparent;
            this.pictActividad.BackgroundImage = global::APS.Properties.Resources.actividadicon;
            this.pictActividad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictActividad.Location = new System.Drawing.Point(712, 323);
            this.pictActividad.Name = "pictActividad";
            this.pictActividad.Size = new System.Drawing.Size(50, 50);
            this.pictActividad.TabIndex = 35;
            this.pictActividad.TabStop = false;
            this.pictActividad.Click += new System.EventHandler(this.pictActividad_Click);
            // 
            // pictProyectos
            // 
            this.pictProyectos.BackColor = System.Drawing.Color.Transparent;
            this.pictProyectos.BackgroundImage = global::APS.Properties.Resources.proyectoicon;
            this.pictProyectos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictProyectos.Location = new System.Drawing.Point(712, 323);
            this.pictProyectos.Name = "pictProyectos";
            this.pictProyectos.Size = new System.Drawing.Size(50, 50);
            this.pictProyectos.TabIndex = 34;
            this.pictProyectos.TabStop = false;
            // 
            // pictPerfil
            // 
            this.pictPerfil.BackColor = System.Drawing.Color.Transparent;
            this.pictPerfil.BackgroundImage = global::APS.Properties.Resources.perfilicon;
            this.pictPerfil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictPerfil.Location = new System.Drawing.Point(712, 104);
            this.pictPerfil.Name = "pictPerfil";
            this.pictPerfil.Size = new System.Drawing.Size(50, 50);
            this.pictPerfil.TabIndex = 32;
            this.pictPerfil.TabStop = false;
            this.pictPerfil.Click += new System.EventHandler(this.pictPerfil_Click);
            // 
            // pictureUser
            // 
            this.pictureUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureUser.Image = global::APS.Properties.Resources.userDefault;
            this.pictureUser.Location = new System.Drawing.Point(707, 12);
            this.pictureUser.Name = "pictureUser";
            this.pictureUser.Size = new System.Drawing.Size(60, 60);
            this.pictureUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureUser.TabIndex = 2;
            this.pictureUser.TabStop = false;
            // 
            // pictHistorial
            // 
            this.pictHistorial.BackColor = System.Drawing.Color.Transparent;
            this.pictHistorial.BackgroundImage = global::APS.Properties.Resources.historialicon1;
            this.pictHistorial.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictHistorial.Location = new System.Drawing.Point(712, 251);
            this.pictHistorial.Name = "pictHistorial";
            this.pictHistorial.Size = new System.Drawing.Size(50, 50);
            this.pictHistorial.TabIndex = 33;
            this.pictHistorial.TabStop = false;
            // 
            // lCerrarSesion
            // 
            this.lCerrarSesion.AutoSize = true;
            this.lCerrarSesion.BackColor = System.Drawing.Color.Transparent;
            this.lCerrarSesion.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lCerrarSesion.ForeColor = System.Drawing.Color.Black;
            this.lCerrarSesion.Location = new System.Drawing.Point(703, 445);
            this.lCerrarSesion.Name = "lCerrarSesion";
            this.lCerrarSesion.Size = new System.Drawing.Size(76, 13);
            this.lCerrarSesion.TabIndex = 38;
            this.lCerrarSesion.Text = "Cierre Sesión";
            // 
            // PaginaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(794, 476);
            this.Controls.Add(this.lCerrarSesion);
            this.Controls.Add(this.pictCerrarSesion);
            this.Controls.Add(this.pictMensajes);
            this.Controls.Add(this.pictActividad);
            this.Controls.Add(this.pictProyectos);
            this.Controls.Add(this.pictPerfil);
            this.Controls.Add(this.lMensajes);
            this.Controls.Add(this.lPerfil);
            this.Controls.Add(this.lActividad);
            this.Controls.Add(this.lProyecto);
            this.Controls.Add(this.lHistorial);
            this.Controls.Add(this.pictureUser);
            this.Controls.Add(this.lWelcome);
            this.Controls.Add(this.tabUser);
            this.Controls.Add(this.pictHistorial);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PaginaPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pagina Principal";
            this.Load += new System.EventHandler(this.PaginaPrincipal_Load);
            this.tabUser.ResumeLayout(false);
            this.pMatch.ResumeLayout(false);
            this.pTodas.ResumeLayout(false);
            this.pPendientes.ResumeLayout(false);
            this.pRevision.ResumeLayout(false);
            this.pMisActividades.ResumeLayout(false);
            this.pActividadesInscritas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gradosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wePassDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wePassDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.actividadesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictCerrarSesion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictMensajes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictActividad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictProyectos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictPerfil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictHistorial)).EndInit();
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
        private System.Windows.Forms.BindingSource wePassDataSetBindingSource;
        private WePassDataSet wePassDataSet;
        private System.Windows.Forms.BindingSource gradosBindingSource;
        private WePassDataSetTableAdapters.GradosTableAdapter gradosTableAdapter;
        private System.Windows.Forms.BindingSource actividadesBindingSource;
        private WePassDataSetTableAdapters.ActividadesTableAdapter actividadesTableAdapter;
        private System.Windows.Forms.TabPage pMisActividades;
        private System.Windows.Forms.TabPage pActividadesInscritas;
        private System.Windows.Forms.TableLayoutPanel panelTodas;
        private System.Windows.Forms.TableLayoutPanel panelMatch;
        private System.Windows.Forms.TableLayoutPanel panelPendientes;
        private System.Windows.Forms.TableLayoutPanel panelRevision;
        private System.Windows.Forms.TableLayoutPanel panelMisActs;
        private System.Windows.Forms.TableLayoutPanel panelActIns;
        private System.Windows.Forms.Label lHistorial;
        private System.Windows.Forms.Label lProyecto;
        private System.Windows.Forms.Label lActividad;
        private System.Windows.Forms.Label lPerfil;
        private System.Windows.Forms.Label lMensajes;
        private System.Windows.Forms.PictureBox pictPerfil;
        private System.Windows.Forms.PictureBox pictHistorial;
        private System.Windows.Forms.PictureBox pictProyectos;
        private System.Windows.Forms.PictureBox pictActividad;
        private System.Windows.Forms.PictureBox pictMensajes;
        private System.Windows.Forms.PictureBox pictCerrarSesion;
        private System.Windows.Forms.Label lCerrarSesion;
    }
}