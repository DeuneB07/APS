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
            this.panelPrincipal = new System.Windows.Forms.Panel();
            this.tablePP = new System.Windows.Forms.TableLayoutPanel();
            this.pictDevelop = new System.Windows.Forms.PictureBox();
            this.lDevelop = new System.Windows.Forms.Label();
            this.pdiMenu = new APS.Interfaces.ControllersPP.PDIControllerPP();
            this.pasMenu = new APS.Interfaces.ControllersPP.PASControllerPP();
            this.ongMenu = new APS.Interfaces.ControllersPP.ONGControllerPP();
            this.gestorMenu = new APS.Interfaces.ControllersPP.GestorControllerPP();
            this.estudianteMenu = new APS.Interfaces.EstudianteControllerPP();
            this.pictDuda1 = new System.Windows.Forms.PictureBox();
            this.lHelpy = new System.Windows.Forms.Label();
            this.bDuda = new System.Windows.Forms.Button();
            this.pictGestor = new System.Windows.Forms.PictureBox();
            this.lGestor = new System.Windows.Forms.Label();
            this.bNotis = new System.Windows.Forms.Button();
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
            this.panelPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictDevelop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictDuda1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictGestor)).BeginInit();
            this.SuspendLayout();
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
            this.lWelcome.Location = new System.Drawing.Point(42, 20);
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
            this.lHistorial.Location = new System.Drawing.Point(869, 358);
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
            this.lProyecto.Location = new System.Drawing.Point(851, 450);
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
            this.lActividad.Location = new System.Drawing.Point(852, 450);
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
            this.lPerfil.Location = new System.Drawing.Point(878, 176);
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
            this.lMensajes.Location = new System.Drawing.Point(869, 265);
            this.lMensajes.Name = "lMensajes";
            this.lMensajes.Size = new System.Drawing.Size(55, 13);
            this.lMensajes.TabIndex = 31;
            this.lMensajes.Text = "Mensajes";
            // 
            // pictCerrarSesion
            // 
            this.pictCerrarSesion.BackColor = System.Drawing.Color.Transparent;
            this.pictCerrarSesion.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictCerrarSesion.BackgroundImage")));
            this.pictCerrarSesion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictCerrarSesion.Location = new System.Drawing.Point(864, 475);
            this.pictCerrarSesion.Name = "pictCerrarSesion";
            this.pictCerrarSesion.Size = new System.Drawing.Size(60, 60);
            this.pictCerrarSesion.TabIndex = 37;
            this.pictCerrarSesion.TabStop = false;
            this.pictCerrarSesion.Click += new System.EventHandler(this.pictCerrarSesion_Click);
            // 
            // pictMensajes
            // 
            this.pictMensajes.BackColor = System.Drawing.Color.Transparent;
            this.pictMensajes.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictMensajes.BackgroundImage")));
            this.pictMensajes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictMensajes.Location = new System.Drawing.Point(864, 202);
            this.pictMensajes.Name = "pictMensajes";
            this.pictMensajes.Size = new System.Drawing.Size(60, 60);
            this.pictMensajes.TabIndex = 36;
            this.pictMensajes.TabStop = false;
            this.pictMensajes.Click += new System.EventHandler(this.pictMensajes_Click);
            // 
            // pictActividad
            // 
            this.pictActividad.BackColor = System.Drawing.Color.Transparent;
            this.pictActividad.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictActividad.BackgroundImage")));
            this.pictActividad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictActividad.Location = new System.Drawing.Point(864, 387);
            this.pictActividad.Name = "pictActividad";
            this.pictActividad.Size = new System.Drawing.Size(60, 60);
            this.pictActividad.TabIndex = 35;
            this.pictActividad.TabStop = false;
            this.pictActividad.Click += new System.EventHandler(this.pictActividad_Click);
            // 
            // pictProyectos
            // 
            this.pictProyectos.BackColor = System.Drawing.Color.Transparent;
            this.pictProyectos.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictProyectos.BackgroundImage")));
            this.pictProyectos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictProyectos.Location = new System.Drawing.Point(864, 387);
            this.pictProyectos.Name = "pictProyectos";
            this.pictProyectos.Size = new System.Drawing.Size(60, 60);
            this.pictProyectos.TabIndex = 34;
            this.pictProyectos.TabStop = false;
            // 
            // pictPerfil
            // 
            this.pictPerfil.BackColor = System.Drawing.Color.Transparent;
            this.pictPerfil.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictPerfil.BackgroundImage")));
            this.pictPerfil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictPerfil.Location = new System.Drawing.Point(864, 113);
            this.pictPerfil.Name = "pictPerfil";
            this.pictPerfil.Size = new System.Drawing.Size(60, 60);
            this.pictPerfil.TabIndex = 32;
            this.pictPerfil.TabStop = false;
            this.pictPerfil.Click += new System.EventHandler(this.pictPerfil_Click);
            // 
            // pictureUser
            // 
            this.pictureUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureUser.Image = ((System.Drawing.Image)(resources.GetObject("pictureUser.Image")));
            this.pictureUser.Location = new System.Drawing.Point(861, 20);
            this.pictureUser.Name = "pictureUser";
            this.pictureUser.Size = new System.Drawing.Size(70, 70);
            this.pictureUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureUser.TabIndex = 2;
            this.pictureUser.TabStop = false;
            // 
            // pictHistorial
            // 
            this.pictHistorial.BackColor = System.Drawing.Color.Transparent;
            this.pictHistorial.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictHistorial.BackgroundImage")));
            this.pictHistorial.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictHistorial.Location = new System.Drawing.Point(864, 295);
            this.pictHistorial.Name = "pictHistorial";
            this.pictHistorial.Size = new System.Drawing.Size(60, 60);
            this.pictHistorial.TabIndex = 33;
            this.pictHistorial.TabStop = false;
            this.pictHistorial.Click += new System.EventHandler(this.pictHistorial_Click);
            // 
            // lCerrarSesion
            // 
            this.lCerrarSesion.AutoSize = true;
            this.lCerrarSesion.BackColor = System.Drawing.Color.Transparent;
            this.lCerrarSesion.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lCerrarSesion.ForeColor = System.Drawing.Color.Black;
            this.lCerrarSesion.Location = new System.Drawing.Point(855, 538);
            this.lCerrarSesion.Name = "lCerrarSesion";
            this.lCerrarSesion.Size = new System.Drawing.Size(76, 13);
            this.lCerrarSesion.TabIndex = 38;
            this.lCerrarSesion.Text = "Cierre Sesión";
            // 
            // panelPrincipal
            // 
            this.panelPrincipal.AutoScroll = true;
            this.panelPrincipal.Controls.Add(this.tablePP);
            this.panelPrincipal.Location = new System.Drawing.Point(184, 79);
            this.panelPrincipal.Name = "panelPrincipal";
            this.panelPrincipal.Size = new System.Drawing.Size(657, 490);
            this.panelPrincipal.TabIndex = 44;
            // 
            // tablePP
            // 
            this.tablePP.AutoSize = true;
            this.tablePP.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tablePP.BackColor = System.Drawing.Color.Transparent;
            this.tablePP.ColumnCount = 1;
            this.tablePP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tablePP.Dock = System.Windows.Forms.DockStyle.Top;
            this.tablePP.Location = new System.Drawing.Point(0, 0);
            this.tablePP.Name = "tablePP";
            this.tablePP.RowCount = 1;
            this.tablePP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tablePP.Size = new System.Drawing.Size(657, 0);
            this.tablePP.TabIndex = 45;
            // 
            // pictDevelop
            // 
            this.pictDevelop.BackColor = System.Drawing.Color.Transparent;
            this.pictDevelop.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictDevelop.BackgroundImage")));
            this.pictDevelop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictDevelop.Location = new System.Drawing.Point(829, 590);
            this.pictDevelop.Name = "pictDevelop";
            this.pictDevelop.Size = new System.Drawing.Size(123, 41);
            this.pictDevelop.TabIndex = 45;
            this.pictDevelop.TabStop = false;
            this.pictDevelop.Click += new System.EventHandler(this.pictDevelop_Click);
            // 
            // lDevelop
            // 
            this.lDevelop.BackColor = System.Drawing.Color.Transparent;
            this.lDevelop.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lDevelop.Location = new System.Drawing.Point(749, 596);
            this.lDevelop.Name = "lDevelop";
            this.lDevelop.Size = new System.Drawing.Size(74, 35);
            this.lDevelop.TabIndex = 46;
            this.lDevelop.Text = "Desarrollado por:";
            this.lDevelop.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pdiMenu
            // 
            this.pdiMenu.BackColor = System.Drawing.Color.LightGreen;
            this.pdiMenu.Location = new System.Drawing.Point(12, 79);
            this.pdiMenu.Margin = new System.Windows.Forms.Padding(4);
            this.pdiMenu.Name = "pdiMenu";
            this.pdiMenu.Size = new System.Drawing.Size(163, 509);
            this.pdiMenu.TabIndex = 43;
            this.pdiMenu.Visible = false;
            // 
            // pasMenu
            // 
            this.pasMenu.BackColor = System.Drawing.Color.PaleTurquoise;
            this.pasMenu.Location = new System.Drawing.Point(11, 102);
            this.pasMenu.Margin = new System.Windows.Forms.Padding(4);
            this.pasMenu.Name = "pasMenu";
            this.pasMenu.Size = new System.Drawing.Size(163, 313);
            this.pasMenu.TabIndex = 42;
            this.pasMenu.Visible = false;
            // 
            // ongMenu
            // 
            this.ongMenu.BackColor = System.Drawing.Color.DeepPink;
            this.ongMenu.Location = new System.Drawing.Point(11, 102);
            this.ongMenu.Margin = new System.Windows.Forms.Padding(4);
            this.ongMenu.Name = "ongMenu";
            this.ongMenu.Size = new System.Drawing.Size(162, 429);
            this.ongMenu.TabIndex = 41;
            this.ongMenu.Visible = false;
            // 
            // gestorMenu
            // 
            this.gestorMenu.BackColor = System.Drawing.Color.Wheat;
            this.gestorMenu.Location = new System.Drawing.Point(11, 102);
            this.gestorMenu.Margin = new System.Windows.Forms.Padding(4);
            this.gestorMenu.Name = "gestorMenu";
            this.gestorMenu.Size = new System.Drawing.Size(162, 429);
            this.gestorMenu.TabIndex = 40;
            this.gestorMenu.Visible = false;
            // 
            // estudianteMenu
            // 
            this.estudianteMenu.BackColor = System.Drawing.Color.LightGreen;
            this.estudianteMenu.Location = new System.Drawing.Point(11, 102);
            this.estudianteMenu.Margin = new System.Windows.Forms.Padding(4);
            this.estudianteMenu.Name = "estudianteMenu";
            this.estudianteMenu.Size = new System.Drawing.Size(163, 449);
            this.estudianteMenu.TabIndex = 39;
            this.estudianteMenu.Visible = false;
            // 
            // pictDuda1
            // 
            this.pictDuda1.BackColor = System.Drawing.Color.Transparent;
            this.pictDuda1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictDuda1.BackgroundImage")));
            this.pictDuda1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictDuda1.Location = new System.Drawing.Point(575, 51);
            this.pictDuda1.Name = "pictDuda1";
            this.pictDuda1.Size = new System.Drawing.Size(25, 25);
            this.pictDuda1.TabIndex = 48;
            this.pictDuda1.TabStop = false;
            // 
            // lHelpy
            // 
            this.lHelpy.AutoSize = true;
            this.lHelpy.BackColor = System.Drawing.Color.Transparent;
            this.lHelpy.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lHelpy.Location = new System.Drawing.Point(606, 57);
            this.lHelpy.Name = "lHelpy";
            this.lHelpy.Size = new System.Drawing.Size(204, 13);
            this.lHelpy.TabIndex = 49;
            this.lHelpy.Text = "¿Qué significa cada color? Averígualo >>";
            // 
            // bDuda
            // 
            this.bDuda.BackColor = System.Drawing.Color.Transparent;
            this.bDuda.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bDuda.BackgroundImage")));
            this.bDuda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bDuda.FlatAppearance.BorderSize = 0;
            this.bDuda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bDuda.Location = new System.Drawing.Point(816, 51);
            this.bDuda.Name = "bDuda";
            this.bDuda.Size = new System.Drawing.Size(25, 25);
            this.bDuda.TabIndex = 50;
            this.bDuda.UseVisualStyleBackColor = false;
            this.bDuda.Click += new System.EventHandler(this.bDuda_Click);
            // 
            // pictGestor
            // 
            this.pictGestor.BackColor = System.Drawing.Color.Transparent;
            this.pictGestor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictGestor.BackgroundImage")));
            this.pictGestor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictGestor.Location = new System.Drawing.Point(864, 295);
            this.pictGestor.Name = "pictGestor";
            this.pictGestor.Size = new System.Drawing.Size(60, 60);
            this.pictGestor.TabIndex = 52;
            this.pictGestor.TabStop = false;
            this.pictGestor.Click += new System.EventHandler(this.pictGestor_Click);
            // 
            // lGestor
            // 
            this.lGestor.AutoSize = true;
            this.lGestor.BackColor = System.Drawing.Color.Transparent;
            this.lGestor.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lGestor.ForeColor = System.Drawing.Color.Black;
            this.lGestor.Location = new System.Drawing.Point(847, 358);
            this.lGestor.Name = "lGestor";
            this.lGestor.Size = new System.Drawing.Size(96, 13);
            this.lGestor.TabIndex = 51;
            this.lGestor.Text = "Añadir Elementos";
            // 
            // bNotis
            // 
            this.bNotis.BackColor = System.Drawing.Color.Transparent;
            this.bNotis.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bNotis.BackgroundImage")));
            this.bNotis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bNotis.FlatAppearance.BorderSize = 0;
            this.bNotis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bNotis.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bNotis.ForeColor = System.Drawing.Color.Black;
            this.bNotis.Location = new System.Drawing.Point(918, 186);
            this.bNotis.Name = "bNotis";
            this.bNotis.Size = new System.Drawing.Size(29, 29);
            this.bNotis.TabIndex = 53;
            this.bNotis.Text = "+";
            this.bNotis.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bNotis.UseVisualStyleBackColor = false;
            // 
            // PaginaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(955, 634);
            this.Controls.Add(this.bNotis);
            this.Controls.Add(this.pictGestor);
            this.Controls.Add(this.lGestor);
            this.Controls.Add(this.bDuda);
            this.Controls.Add(this.lHelpy);
            this.Controls.Add(this.pictDuda1);
            this.Controls.Add(this.lDevelop);
            this.Controls.Add(this.pictDevelop);
            this.Controls.Add(this.panelPrincipal);
            this.Controls.Add(this.pdiMenu);
            this.Controls.Add(this.pasMenu);
            this.Controls.Add(this.ongMenu);
            this.Controls.Add(this.gestorMenu);
            this.Controls.Add(this.estudianteMenu);
            this.Controls.Add(this.lCerrarSesion);
            this.Controls.Add(this.pictCerrarSesion);
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
            this.Controls.Add(this.pictHistorial);
            this.Controls.Add(this.pictMensajes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PaginaPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pagina Principal";
            this.Load += new System.EventHandler(this.PaginaPrincipal_Load);
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
            this.panelPrincipal.ResumeLayout(false);
            this.panelPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictDevelop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictDuda1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictGestor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lWelcome;
        private System.Windows.Forms.PictureBox pictureUser;
        private System.Windows.Forms.BindingSource wePassDataSetBindingSource;
        private WePassDataSet wePassDataSet;
        private System.Windows.Forms.BindingSource gradosBindingSource;
        private WePassDataSetTableAdapters.GradosTableAdapter gradosTableAdapter;
        private System.Windows.Forms.BindingSource actividadesBindingSource;
        private WePassDataSetTableAdapters.ActividadesTableAdapter actividadesTableAdapter;
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
        private EstudianteControllerPP estudianteMenu;
        private ControllersPP.GestorControllerPP gestorMenu;
        private ControllersPP.ONGControllerPP ongMenu;
        private ControllersPP.PASControllerPP pasMenu;
        private ControllersPP.PDIControllerPP pdiMenu;
        private System.Windows.Forms.Panel panelPrincipal;
        private System.Windows.Forms.TableLayoutPanel tablePP;
        private System.Windows.Forms.PictureBox pictDevelop;
        private System.Windows.Forms.Label lDevelop;
        private System.Windows.Forms.PictureBox pictDuda1;
        private System.Windows.Forms.Label lHelpy;
        private System.Windows.Forms.Button bDuda;
        private System.Windows.Forms.PictureBox pictGestor;
        private System.Windows.Forms.Label lGestor;
        private System.Windows.Forms.Button bNotis;
    }
}