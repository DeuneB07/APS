using APS.Interfaces.ElementosAyuda;
using APS.Interfaces.Gestión_Actividades;
using APS.Interfaces.GestorExclusive;
using APS.Interfaces.Historial;
using APS.Interfaces.Perfil;
using APS.Interfaces.Personalizados;
using APS.Mapeo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace APS.Interfaces
{
    public partial class PaginaPrincipal : Form
    {

        Usuario user;
        private enum PantallaCargada { MATCH, TODAS, REVISION, PENDIENTES, ACTIVIDADES_INSCRITAS, MIS_ACTIVIDADES, PROYECTOS, EVALUACION};
        private PantallaCargada chargedWindow;

        public PaginaPrincipal(Usuario user)
        {
            Thread t = new Thread(new ThreadStart(StartForm));
            t.Start();

            InitializeComponent();
            this.user = user;

            //Cargar Interfaz Adecuado (según Rol)
            cargarInterfaz();

            if (user.NombreUser!=null && !user.NombreUser.Trim().Equals("")) lWelcome.Text = "¡Bienvenido, " + user.NombreUser+"!";
            else lWelcome.Text = "¡Bienvenido, "+ user.Nombre + "!";

            //UPDATES SQL
            Actividad.ActualizarEstadoActividades();

            t.Abort();
        }

        public void StartForm()
        {
            Application.Run(new SplashLoading());
        }


        //
        // Carga Menú Inicial (También activa sus botones)
        //
        public void cargarInterfaz()
        {

            //Cargar Imagen
            if (user.Imagen != null) pictureUser.Image = user.Imagen;

            //Cargar Menús (con Programación Botones)
            if (user.Rol.NombreRol.Equals("Estudiante"))
            {
                estudianteMenu.Visible = true;

                FlowLayoutPanel flowP = (FlowLayoutPanel)estudianteMenu.Controls.Find("flowMain", false)[0];
                PictureBox bMatch = (PictureBox)flowP.Controls.Find("pictMatch", false)[0];
                PictureBox bTodas = (PictureBox)flowP.Controls.Find("pictTodas", false)[0];
                PictureBox bEvaluacion = (PictureBox)flowP.Controls.Find("pictEvaluacion", false)[0];
                PictureBox bProyectos = (PictureBox)flowP.Controls.Find("pictProyectos", false)[0];
                PictureBox bActIns = (PictureBox)flowP.Controls.Find("pictActIns", false)[0];

                bMatch.Click += (sender, EventArgs) => { bMatch_Click(sender, EventArgs); };
                bTodas.Click += (sender, EventArgs) => { bTodas_Click(sender, EventArgs); };
                bEvaluacion.Click += (sender, EventArgs) => { bEvaluacion_Click(sender, EventArgs); };
                bProyectos.Click += (sender, EventArgs) => { bProyectos_Click(sender, EventArgs); };
                bActIns.Click += (sender, EventArgs) => { bActividadesInscritas_Click(sender, EventArgs); };
            }
            else if (user.Rol.NombreRol.Equals("PDI"))
            {
                pdiMenu.Visible = true;

                FlowLayoutPanel flowP = (FlowLayoutPanel)pdiMenu.Controls.Find("flowMain", false)[0];
                PictureBox bMatch = (PictureBox)flowP.Controls.Find("pictMatch", false)[0];
                PictureBox bTodas = (PictureBox)flowP.Controls.Find("pictTodas", false)[0];
                PictureBox bEvaluacion = (PictureBox)flowP.Controls.Find("pictEvaluacion", false)[0];
                PictureBox bProyectos = (PictureBox)flowP.Controls.Find("pictProyectos", false)[0];
                PictureBox bActIns = (PictureBox)flowP.Controls.Find("pictActIns", false)[0];
                PictureBox bMisActs = (PictureBox)flowP.Controls.Find("pictMisActs", false)[0];
                PictureBox bRevision = (PictureBox)flowP.Controls.Find("pictRevision", false)[0];

                bMatch.Click += (sender, EventArgs) => { bMatch_Click(sender, EventArgs); };
                bTodas.Click += (sender, EventArgs) => { bTodas_Click(sender, EventArgs); };
                bEvaluacion.Click += (sender, EventArgs) => { bEvaluacion_Click(sender, EventArgs); };
                bProyectos.Click += (sender, EventArgs) => { bProyectos_Click(sender, EventArgs); };
                bActIns.Click += (sender, EventArgs) => { bActividadesInscritas_Click(sender, EventArgs); };
                bMisActs.Click += (sender, EventArgs) => { bMisActividades_Click(sender, EventArgs); };
                bRevision.Click += (sender, EventArgs) => { bRevision_Click(sender, EventArgs); };

            }
            else if (user.Rol.NombreRol.Equals("PAS"))
            {
                pasMenu.Visible = true;

                FlowLayoutPanel flowP = (FlowLayoutPanel)pasMenu.Controls.Find("flowMain", false)[0];
                PictureBox bMatch = (PictureBox)flowP.Controls.Find("pictMatch", false)[0];
                PictureBox bTodas = (PictureBox)flowP.Controls.Find("pictTodas", false)[0];
                PictureBox bEvaluacion = (PictureBox)flowP.Controls.Find("pictEvaluacion", false)[0];
                PictureBox bActIns = (PictureBox)flowP.Controls.Find("pictActIns", false)[0];

                bMatch.Click += (sender, EventArgs) => { bMatch_Click(sender, EventArgs); };
                bTodas.Click += (sender, EventArgs) => { bTodas_Click(sender, EventArgs); };
                bEvaluacion.Click += (sender, EventArgs) => { bEvaluacion_Click(sender, EventArgs); };
                bActIns.Click += (sender, EventArgs) => { bActividadesInscritas_Click(sender, EventArgs); };
            }
            else if (user.Rol.NombreRol.Equals("ONG"))
            {
                ongMenu.Visible = true;

                FlowLayoutPanel flowP = (FlowLayoutPanel)ongMenu.Controls.Find("flowMain", false)[0];
                PictureBox bEvaluacion = (PictureBox)flowP.Controls.Find("pictEvaluacion", false)[0];
                PictureBox bMisActs = (PictureBox)flowP.Controls.Find("pictMisActs", false)[0];
                PictureBox bRevision = (PictureBox)flowP.Controls.Find("pictRevision", false)[0];

                bEvaluacion.Click += (sender, EventArgs) => { bEvaluacion_Click(sender, EventArgs); };
                bMisActs.Click += (sender, EventArgs) => { bMisActividades_Click(sender, EventArgs); };
                bRevision.Click += (sender, EventArgs) => { bRevision_Click(sender, EventArgs); };
            }
            else if (user.Rol.NombreRol.Equals("GESTOR"))
            {
                gestorMenu.Visible = true;

                FlowLayoutPanel flowP = (FlowLayoutPanel)gestorMenu.Controls.Find("flowMain", false)[0];
                PictureBox bTodas = (PictureBox)flowP.Controls.Find("pictTodas", false)[0];
                PictureBox bProyectos = (PictureBox)flowP.Controls.Find("pictProyectos", false)[0];
                PictureBox bPendientes = (PictureBox)flowP.Controls.Find("pictPendientes", false)[0];

                bTodas.Click += (sender, EventArgs) => { bTodas_Click(sender, EventArgs); };
                bProyectos.Click += (sender, EventArgs) => { bProyectos_Click(sender, EventArgs); };
                bPendientes.Click += (sender, EventArgs) => { bPendientes_Click(sender, EventArgs); };
            }

            //Cargar Botones de Perfil
            lActividad.Visible = user.InsertarPantalla("ACTIVIDADES");
            pictActividad.Visible = user.InsertarPantalla("ACTIVIDADES");
            lProyecto.Visible = user.InsertarPantalla("PROYECTOS");
            pictProyectos.Visible = user.InsertarPantalla("PROYECTOS");
            lGestor.Visible = user.Rol.NombreRol.Equals("GESTOR");
            pictGestor.Visible = user.Rol.NombreRol.Equals("GESTOR");

            //Cargar Botón Ayuda Help
            //Aún no está

            //Primera Pestaña Cargada
            if (user.AccesoPantalla("MATCH")) cargarMatchActividadesInicio();
            else if (user.AccesoPantalla("TODAS")) cargarTodasActividadesInicio();
            else if (user.AccesoPantalla("MIS ACTIVIDADES")) cargarMisActividadesInicio();
            //CUANDO ESTÉ IMPLEMENTADO, QUITAR LA LÍNEA DE ARRIBA Y PONER ESTA DE ABAJO
            //else if (user.AccesoPantalla("VALORACION")) tabUser.Controls.Remove(this.pValoracion);

        }

        private void bMatch_Click(object sender, EventArgs eventArgs)
        {
            if (!chargedWindow.Equals(PantallaCargada.MATCH))
                cargarMatchActividadesInicio();
        }

        private void bTodas_Click(object sender, EventArgs eventArgs)
        {
            if (!chargedWindow.Equals(PantallaCargada.TODAS))
                cargarTodasActividadesInicio();
        }

        private void bEvaluacion_Click(object sender, EventArgs eventArgs)
        {
            if (!chargedWindow.Equals(PantallaCargada.EVALUACION))
                cargarValoracionActividadesInicio();
        }

        private void bMisActividades_Click(object sender, EventArgs eventArgs)
        {
            if (!chargedWindow.Equals(PantallaCargada.MIS_ACTIVIDADES))
                cargarMisActividadesInicio();
        }

        private void bActividadesInscritas_Click(object sender, EventArgs eventArgs)
        {
            if (!chargedWindow.Equals(PantallaCargada.ACTIVIDADES_INSCRITAS))
                cargarActividadesInscritas();
        }

        private void bPendientes_Click(object sender, EventArgs eventArgs)
        {
            if (!chargedWindow.Equals(PantallaCargada.PENDIENTES))
                cargarPendientesActividadesInicio();
        }

        private void bRevision_Click(object sender, EventArgs eventArgs)
        {
            if (!chargedWindow.Equals(PantallaCargada.REVISION))
                cargarRevisionActividadesInicio();
        }

        private void bProyectos_Click(object sender, EventArgs eventArgs)
        {
            DialogResult emCierreDialog;
            string mensaje = "Función No Implementada Aún.";
            string caption = "¡AVISO!";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            emCierreDialog = MessageBox.Show(mensaje, caption, buttons);
        }

        //
        // PESTAÑA MATCH
        //
        private void cargarMatchActividadesInicio()
        {

            chargedWindow = PantallaCargada.MATCH;
            tablePP.Controls.Clear();
            tablePP.RowCount = 1;
            tablePP.AutoScroll = false;
            panelPrincipal.AutoScroll = false;
            panelPrincipal.AutoScroll = true;

            cargarFiltrosMatch();

            List<Actividad> actividades = Actividad.ListaActividades(Actividad.EstadoActividadE.ABIERTA);
            List<Actividad_Solicitud> lista = Actividad_Solicitud.ListaActividadesSolicitudes(user);
            CartelActividadesStandard[] actsCarteles = new CartelActividadesStandard[actividades.Count];

            List<Asignatura> asigs = user.Asignaturas;
            int c = 0;
            foreach (Actividad act in actividades)
            {
                bool encontrado = false;
                int j = 0;
                Asignatura asig = null;
                while (!encontrado && j < asigs.Count)
                {
                    asig = asigs[j];
                    if ((act.Asignatura != null && act.Asignatura.Equals(asig)) || act.TipoAct.Equals(Actividad.TipoActividadE.VOLUNTARIADO))
                    {
                        actsCarteles[c] = new CartelActividadesStandard(user, act);
                        tablePP.Controls.Add(actsCarteles[c], 0, c + 1);
                        tablePP.RowCount = tablePP.RowCount + 1;
                        actsCarteles[c].Location = new Point(actsCarteles[c].Location.X, (actsCarteles[c].Size.Height * c));

                        //Programar Solicitar
                        Panel panel = (Panel)actsCarteles[c].Controls.Find("panel1", false)[0];
                        Button bSolicitar = (Button)panel.Controls.Find("bSolicitar", false)[0];
                        Boolean encontrada = false;
                        int contador = 0;
                        while (!encontrada && lista.Count > contador)
                        {
                            if (lista[contador].Actividad.Equals(act)) encontrada = true;
                            contador++;
                        }
                        if (encontrada)
                        {
                            bSolicitar.Visible = false;
                        }
                        bSolicitar.Click += (sender, EventArgs) => { bSolicitar_Click(sender, EventArgs, act); };

                        encontrado = true;
                        c++;
                    }
                    j++;
                }
            }
        }

        private void bSolicitar_Click(object sender, EventArgs eventArgs, Actividad act)
        {

            if(act.TipoAct.ToString().Equals("VOLUNTARIADO")) user.AddActividadSolicitada(act, Actividad_Solicitud.EstadoActividadSolicitudE.EN_ESPERA_ONG);
            else user.AddActividadSolicitada(act, Actividad_Solicitud.EstadoActividadSolicitudE.EN_ESPERA_PDI);
            
            cargarActividadesInscritas();
            DialogResult emCierreDialog;
            string mensaje = "Actividad solicitada";
            string caption = "¡PERFECTO!";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            emCierreDialog = MessageBox.Show(mensaje, caption, buttons);
        }

        private void cargarFiltrosMatch()
        {

            //pMatch
            CartelFiltroMatch cFiltro = new CartelFiltroMatch(this.user);
            tablePP.Controls.Add(cFiltro, 0, 0);
            tablePP.RowCount = tablePP.RowCount + 1;

            //Pulsación Filtros // Recojo Botones
            Control panelFiltro = cFiltro.Controls.Find("panel1", false)[0]; //Panel de Filtros
            ComboBox cBox = (ComboBox) panelFiltro.Controls.Find("cPreferencia", false)[0]; //ComboBox de Preferencias
            Button bFiltros = (Button)panelFiltro.Controls.Find("bAplicar", false)[0]; //Button de Filtros -> Aplicar

            //Añadimos Parámetros para el Filtro
            bFiltros.Click += (sender, EventArgs) => { bFiltrosMatch_Click(sender, EventArgs, cBox); };
        }

        private void bFiltrosMatch_Click(object sender, EventArgs e, ComboBox cBox)
        {
            List<Actividad> lAct = Actividad.ListaActividades();

            if(cBox.SelectedItem != null)
            {
                Preferencia pref = (Preferencia)cBox.SelectedItem;
                Grado g = ((Preferencia)cBox.SelectedItem).Grado;
                Asignatura asig = ((Preferencia)cBox.SelectedItem).Asignatura;
                Actividad.TurnoE turnoF = ((Preferencia)cBox.SelectedItem).Turno;
                Actividad.TipoActividadE tipoActF = ((Preferencia)cBox.SelectedItem).TipoActividad;
                TipoTrabajo tipoTrabF = ((Preferencia)cBox.SelectedItem).TipoTrabajo;
                AmbitoTrabajo ambTrabF = ((Preferencia)cBox.SelectedItem).AmbitoTrabajo;
                int horas = 0;

                if (!((Preferencia)cBox.SelectedItem).HorasPosibles.ToString().Equals("")) horas = ((Preferencia)cBox.SelectedItem).HorasPosibles;

                //Filtro Grado
                if (g != null)
                {
                    foreach (Actividad a in Actividad.ListaActividades())
                    {
                        if (a.Grado == null || !a.Grado.Equals(g))
                        {
                            lAct.Remove(a);
                        }
                    }
                }

                //Filtro Asignatura
                if (asig != null)
                {
                    foreach (Actividad a in Actividad.ListaActividades())
                    {
                        if (a.Asignatura == null || !a.Asignatura.Equals(asig)) lAct.Remove(a);
                    }
                }

                //Filtro Turno
                if (!turnoF.Equals(Actividad.TurnoE.AMBAS))
                {
                    foreach (Actividad a in Actividad.ListaActividades())
                    {
                        if (!a.Turno.Equals(turnoF)) lAct.Remove(a);
                    }
                }

                //Filtro TipoActividad
                if (!tipoActF.ToString().Equals(Actividad.TipoActividadE.TODAS.ToString()))
                {
                    foreach (Actividad a in Actividad.ListaActividades())
                    {
                        if (!a.TipoAct.Equals(tipoActF)) lAct.Remove(a);
                    }
                }

                //Filtro TipoTrab
                if (!tipoTrabF.Tipo_Trabajo.Equals("TODAS"))
                {
                    foreach (Actividad a in Actividad.ListaActividades())
                    {
                        if (!a.TipoAct.Equals(tipoTrabF)) lAct.Remove(a);
                    }
                }

                //Filtro AmbTrabajo
                if (!ambTrabF.Ambito_Trabajo.Equals("TODAS"))
                {
                    foreach (Actividad a in Actividad.ListaActividades())
                    {
                        if (!a.TipoAct.Equals(ambTrabF)) lAct.Remove(a);
                    }
                }

                //Filtro Horas
                if (horas != 0)
                {
                    foreach (Actividad a in Actividad.ListaActividades())
                    {
                        if (a.NumHoras>horas) lAct.Remove(a);
                    }
                }
                cargarMatchActividadesFiltro(lAct);
            }
            else
            {
                cargarMatchActividadesInicio();
            }
        }

        private void cargarMatchActividadesFiltro(List<Actividad> listAct)
        {
            chargedWindow = PantallaCargada.MATCH;
            tablePP.Controls.Clear();
            tablePP.RowCount = 1;
            tablePP.AutoScroll = false;
            panelPrincipal.AutoScroll = false;
            panelPrincipal.AutoScroll = true;
            cargarFiltrosMatch();

            CartelActividadesStandard[] actsCarteles = new CartelActividadesStandard[listAct.Count];
            List<Actividad_Solicitud> lista = Actividad_Solicitud.ListaActividadesSolicitudes(user);

            int c = 0;
            foreach (Actividad act in listAct)
            {
                if (act.EstadoAct.ToString().Equals("ABIERTA"))
                {
                    actsCarteles[c] = new CartelActividadesStandard(user, act);
                    tablePP.Controls.Add(actsCarteles[c], 0, c + 1);
                    tablePP.RowCount = tablePP.RowCount + 1;
                    actsCarteles[c].Location = new Point(actsCarteles[c].Location.X, (actsCarteles[c].Size.Height * c));                  
                    //BOTON SOLICITAR
                    Panel panel = (Panel)actsCarteles[c].Controls.Find("panel1", false)[0];
                    Button bSolicitar = (Button)panel.Controls.Find("bSolicitar", false)[0];
                    Boolean encontrada = false;
                    int contador = 0;
                    while (!encontrada && lista.Count > contador)
                    {
                        if (lista[contador].Actividad.Equals(act)) encontrada = true;
                        contador++;
                    }
                    if (encontrada)
                    {
                        bSolicitar.Visible = false;
                    }
                    //PROGRAMACIÓN BOTONES
                    bSolicitar.Click += (sender, EventArgs) => { bSolicitar_Click(sender, EventArgs, act); };
                    c++;
                }
            }
        }

        //
        // PESTAÑA TODAS
        //
        private void cargarTodasActividadesInicio()
        {

            chargedWindow = PantallaCargada.TODAS;
            tablePP.Controls.Clear();
            tablePP.RowCount = 1;
            tablePP.AutoScroll = false;
            panelPrincipal.AutoScroll = false;
            panelPrincipal.AutoScroll = true;
            cargarFiltrosTodas(Actividad.TurnoE.AMBAS,Actividad.TipoActividadE.TODAS,null,null,DateTime.Today,0);

            List<Actividad> actividades = Actividad.ListaActividades(Actividad.EstadoActividadE.ABIERTA);
            List<Actividad_Solicitud> lista = Actividad_Solicitud.ListaActividadesSolicitudes(user);
            CartelActividadesStandard[] actsCarteles = new CartelActividadesStandard[actividades.Count];

            int c = 0;
            foreach (Actividad act in actividades)
            {
                actsCarteles[c] = new CartelActividadesStandard(user, act);   
                tablePP.Controls.Add(actsCarteles[c], 0, c + 1);
                tablePP.RowCount = tablePP.RowCount + 1;
                actsCarteles[c].Location = new Point(actsCarteles[c].Location.X, (actsCarteles[c].Size.Height * c));

                //BOTON SOLICITAR
                Panel panel = (Panel)actsCarteles[c].Controls.Find("panel1", false)[0];
                Button bSolicitar = (Button)panel.Controls.Find("bSolicitar", false)[0];
                if (user.Rol.NombreRol.Equals("GESTOR")) bSolicitar.Visible = false;

                
                Boolean encontrada = false;
                int contador = 0;
                while (!encontrada && lista.Count > contador)
                {
                    if (lista[contador].Actividad.Equals(act)) encontrada = true;
                    contador++;
                }
                if (encontrada)
                {
                    bSolicitar.Visible = false;
                }
                //PROGRAMACIÓN BOTONES
                bSolicitar.Click += (sender, EventArgs) => { bSolicitar_Click(sender, EventArgs, act); };
                c++;
            }

        }

        private void cargarTodasActividadesFiltro(List<Actividad> listAct,Actividad.TurnoE turno, Actividad.TipoActividadE tipoAct,
                                                    Asignatura asig, Grado g, DateTime date, int horas)
        {
            chargedWindow = PantallaCargada.TODAS;
            tablePP.Controls.Clear();
            tablePP.RowCount = 1;
            tablePP.AutoScroll = false;
            panelPrincipal.AutoScroll = false;
            panelPrincipal.AutoScroll = true;
            cargarFiltrosTodas(turno,tipoAct,asig,g,date,horas);

            CartelActividadesStandard[] actsCarteles = new CartelActividadesStandard[listAct.Count];

            int c = 0;
            foreach (Actividad act in listAct)
            {
                actsCarteles[c] = new CartelActividadesStandard(user, act);
                tablePP.Controls.Add(actsCarteles[c], 0, c + 1);
                tablePP.RowCount = tablePP.RowCount + 1;
                actsCarteles[c].Location = new Point(actsCarteles[c].Location.X, (actsCarteles[c].Size.Height * c));
                //Programar Solicitar
                Panel panel = (Panel)actsCarteles[c].Controls.Find("panel1", false)[0];
                Button bSolicitar = (Button)panel.Controls.Find("bSolicitar", false)[0];
                bSolicitar.Click += (sender, EventArgs) => { bSolicitar_Click(sender, EventArgs, act); };
                c++;
            }
        }

        private void cargarFiltrosTodas(Actividad.TurnoE turno, Actividad.TipoActividadE tipoAct, Asignatura asig, Grado g, DateTime date, int horas)
        {
            //pTodas
            CartelFiltros cFiltro = new CartelFiltros(this.user);
            tablePP.Controls.Add(cFiltro, 0, 0);
            tablePP.RowCount = tablePP.RowCount + 1;

            //Pulsación Filtros
            Control panelFiltro = cFiltro.Controls.Find("panel1", false)[0]; //Panel de Filtros
            List<ComboBox> cBox = new List<ComboBox>(); //ComboBox de Filtros [Turno, TipoAct, Asig, Grado];
            DateTimePicker dtIni = new DateTimePicker(); //DateTimePicker de Filtros
            Button bFiltros = new Button(); //Button de Filtros -> Aplicar
            NumericUpDown bHoras = new NumericUpDown();

            //Recojo los Botones
            foreach (Control cPanel in panelFiltro.Controls)
            {
                if (cPanel.GetType().ToString().Equals("System.Windows.Forms.ComboBox")) cBox.Add((ComboBox)cPanel);
                if (cPanel.GetType().ToString().Equals("System.Windows.Forms.Button")) bFiltros = (Button)cPanel;
                if (cPanel.GetType().ToString().Equals("System.Windows.Forms.DateTimePicker")) dtIni = (DateTimePicker)cPanel;
                if (cPanel.GetType().ToString().Equals("System.Windows.Forms.NumericUpDown")) bHoras = (NumericUpDown)cPanel;
            }

            //Añadimos Parámetros para el Filtro
            bFiltros.Click += (sender, EventArgs) => { bFiltros_Click(sender, EventArgs, cBox, dtIni, bHoras); };

            //Añadimos valores predefinidos
            cBox[0].SelectedItem = turno;
            cBox[1].SelectedItem = tipoAct;
            cBox[2].SelectedItem = asig;
            cBox[3].SelectedItem = g;
            dtIni.Value = date;
            bHoras.Value = horas;
        }

        private void bFiltros_Click(object sender, EventArgs e, List<ComboBox> cBox, DateTimePicker dtIni, NumericUpDown bHoras)
        {
            List<Actividad> lAct = Actividad.ListaActividades(Actividad.EstadoActividadE.ABIERTA);
            Grado g = null;
            Asignatura asig = null;
            Actividad.TurnoE turnoF = Actividad.TurnoE.AMBAS;
            Actividad.TipoActividadE tipoActF = Actividad.TipoActividadE.TODAS;
            //DateTime example = new DateTime(DateTime.Today.Year+100, 1, 1);
            DateTime inicio = dtIni.Value;
            int horas = -1;

            horas = decimal.ToInt32(bHoras.Value);
            if (cBox[3].SelectedItem != null) g = (Grado)cBox[3].SelectedItem;
            if (cBox[2].SelectedItem != null) asig = (Asignatura)cBox[2].SelectedItem;

            Enum.TryParse<Actividad.TurnoE>(cBox[0].Text, true, out turnoF);
            Enum.TryParse<Actividad.TipoActividadE>(cBox[1].Text, true, out tipoActF);

            //Filtro Grado
            if (g != null)
            {
                foreach (Actividad a in Actividad.ListaActividades())
                {
                    if (a.Grado == null || !a.Grado.Equals(g))
                    {
                        lAct.Remove(a);
                    }
                }
            }

            //Filtro Asignatura
            if (asig != null)
            {
                foreach (Actividad a in Actividad.ListaActividades())
                {
                    if (a.Asignatura == null || !a.Asignatura.Equals(asig)) lAct.Remove(a);
                }
            }

            //Filtro Turno
            if (!turnoF.ToString().Equals(Actividad.TurnoE.AMBAS.ToString()))
            {
                foreach (Actividad a in Actividad.ListaActividades())
                {
                    if (!a.Turno.Equals(turnoF)) lAct.Remove(a);
                }
            }

            //Filtro TipoActividad
            if (!tipoActF.ToString().Equals(Actividad.TipoActividadE.TODAS.ToString()))
            {
                foreach (Actividad a in Actividad.ListaActividades())
                {
                    if (!a.TipoAct.Equals(tipoActF)) lAct.Remove(a);
                }
            }

            //Filtro Horas
            if (horas != 0)
            {
                foreach (Actividad a in Actividad.ListaActividades())
                {
                    if (a.NumHoras > horas) lAct.Remove(a);
                }
            }

            //Filtro Fecha
            if(inicio >= DateTime.Today)
            {
                foreach(Actividad a in Actividad.ListaActividades())
                {
                    if (a.FechaInicio < inicio) lAct.Remove(a); 
                }
            }

            cargarTodasActividadesFiltro(lAct,turnoF,tipoActF,asig,g,inicio,horas);
        }

        //
        // PESTAÑA PENDIENTES -> estado= 'PENDIENTE_ACEPTACION' (SÓLO GESTOR)
        //
        private void cargarPendientesActividadesInicio()
        {
            chargedWindow = PantallaCargada.PENDIENTES;
            tablePP.Controls.Clear();
            tablePP.RowCount = 1;
            tablePP.AutoScroll = false;
            panelPrincipal.AutoScroll = false;
            panelPrincipal.AutoScroll = true;

            List<Actividad> actividades = Actividad.ListaActividades(Actividad.EstadoActividadE.PENDIENTE_ACEPTACION);
            CartelPendientes[] actsCarteles = new CartelPendientes[actividades.Count];

            int c = 0;
            foreach (Actividad act in actividades)
            {
                actsCarteles[c] = new CartelPendientes(user, act);
                tablePP.Controls.Add(actsCarteles[c], 0, c);
                tablePP.RowCount = tablePP.RowCount + 1;
                actsCarteles[c].Location = new Point(actsCarteles[c].Location.X, (actsCarteles[c].Size.Height * c));
                actsCarteles[c].BackColor = Color.DarkCyan;

                //BOTONES GESTOR
                Panel panel = (Panel)actsCarteles[c].Controls.Find("panel1", false)[0];
                Button bAceptar = (Button)panel.Controls.Find("bRevisar", false)[0];
                Button bRechazar = (Button)panel.Controls.Find("bRechazar", false)[0];
                
                //PROGRAMACIÓN BOTONES
                bAceptar.Click += (sender, EventArgs) => { bRevisar_Click(sender, EventArgs, act); };
                bRechazar.Click += (sender, EventArgs) => { bRechazar_Click(sender, EventArgs, act); };
                c++;
            }
            
        }

        private void bRevisar_Click(object sender, EventArgs eventArgs, Actividad act)
        {
            GestorGestionaActividad gestorGestionaActividad = new GestorGestionaActividad(user, act);
            gestorGestionaActividad.ShowDialog();
            this.Visible = true;
            cargarPendientesActividadesInicio();
        }

        private void bRechazar_Click(object sender, EventArgs eventArgs, Actividad act)
        {
            DialogResult emCierreDialog;
            string mensaje = "¿Quieres rechazar la actividad? Se borrará del sistema";
            string caption = "¡AVISO!";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            emCierreDialog = MessageBox.Show(mensaje, caption, buttons);

            if (emCierreDialog == DialogResult.Yes)
            {
                act.BorrarActividad();
                cargarPendientesActividadesInicio();
            }
        }

        //
        //
        //                                  -> 'ACEPTADA_GESTOR'(PDI) -> LA VE EL PDI RESPONSABLE ASIGNADO
        // PESTAÑA REVISIÓN -> estado(s)    -> 'NEGOCIAR_PDI'(PDI, ONG) -> LA VE EL PDI ASIGNADO (INTERACTÚA) Y LA ONG (NO HACE NADA)
        //                                  -> 'NEGOCIAR_ONG'(PDI, ONG) -> LA VE EL ONG (INTERACTÚA) Y EL PDI RESPONSABLE (NO HACE NADA)
        //                  
        //
        private void cargarRevisionActividadesInicio()
        {

            chargedWindow = PantallaCargada.REVISION;
            tablePP.Controls.Clear();
            tablePP.RowCount = 1;
            tablePP.AutoScroll = false;
            panelPrincipal.AutoScroll = false;
            panelPrincipal.AutoScroll = true;

            //ORDEN -> PRIMERO LAS QUE TIENE QUE DECIDIR SI ES VIABLE
            //      -> DESPUÉS, LAS QUE TIENE QUE REVISAR
            //      -> POR ÚLTIMO, LAS QUE TIENE QUE ESPERAR PARA VER (revisión en el otro lado)

            int c = 0;
            cargarAceptadasGestor(c); //Carga las Actividades recién aceptadas por el gestor
            c = tablePP.Controls.Count;

            //Listas de Actividades en Negociación
            List<Actividad> actNegPDI = Actividad.ListaActividades(Actividad.EstadoActividadE.NEGOCIACION_PDI);
            List<Actividad> actNegONG = Actividad.ListaActividades(Actividad.EstadoActividadE.NEGOCIACION_ONG);
            List<Actividad> actNegCAN = Actividad.ListaActividades(Actividad.EstadoActividadE.NEGOCIACION_CANCELADA);
            List<Actividad> actPenGestor = Actividad.ListaActividades(Actividad.EstadoActividadE.PENDIENTE_ACEPTACION);

            if (user.Rol.NombreRol.Equals("PDI")) cargarRevisionPDI(c, actNegPDI, actNegONG);
            else
            { //ES ONG -> lo mismo que para el PDI, pero al contrario 
                cargarRevisionONG(c, actNegPDI, actNegONG, actNegCAN, actPenGestor);
            }
        }

        private void cargarAceptadasGestor(int c)
        {
            //SI ES PDI MOSTRAMOS LAS ACTIVIDADES QUE LE ENVÍA EL GESTOR
            if (user.Rol.NombreRol.Equals("PDI"))
            {
                List<Actividad> actAcGestor = Actividad.ListaActividades(Actividad.EstadoActividadE.ACEPTADA_GESTOR);
                CartelPendientes[] carAcGestor = new CartelPendientes[actAcGestor.Count];
                foreach (Actividad act in actAcGestor)
                {

                    if (act.Responsable.Equals(user))
                    {
                        carAcGestor[c] = new CartelPendientes(user, act);
                        tablePP.Controls.Add(carAcGestor[c], 0, c);
                        tablePP.RowCount = tablePP.RowCount + 1;
                        carAcGestor[c].Location = new Point(carAcGestor[c].Location.X, (carAcGestor[c].Size.Height * c));
                        carAcGestor[c].BackColor = Color.Yellow;

                        //BOTONES
                        Panel panel = (Panel)carAcGestor[c].Controls.Find("panel1", false)[0];
                        Button bAceptar = (Button)panel.Controls.Find("bRevisar", false)[0];
                        Button bRechazar = (Button)panel.Controls.Find("bRechazar", false)[0];

                        //PROGRAMACIÓN BOTONES
                        bAceptar.Click += (sender, EventArgs) => { bRevisarRevGestor_Click(sender, EventArgs, act); };
                        bRechazar.Click += (sender, EventArgs) => { bRechazarRevGestor_Click(sender, EventArgs, act); };
                        c++;
                    }
                }
            }
        }

        private void cargarRevisionPDI(int c, List<Actividad> actNegPDI, List<Actividad> actNegONG)
        {
            //Carteles que Usaremos
            CartelPendientes[] carNegPDI = new CartelPendientes[actNegPDI.Count];
            CartelPendientes[] carNegONG = new CartelPendientes[actNegONG.Count];

            int c2 = 0;
            foreach (Actividad act in actNegPDI)
            {
                if (act.Responsable.Equals(user))
                {
                    
                    carNegPDI[c2] = new CartelPendientes(user, act);
                    tablePP.Controls.Add(carNegPDI[c2], 0, c);
                    tablePP.RowCount = tablePP.RowCount + 1;
                    carNegPDI[c2].Location = new Point(carNegPDI[c2].Location.X, (carNegPDI[c2].Size.Height * c));
                    carNegPDI[c2].BackColor = Color.Green;

                    //BOTONES GESTOR
                    Panel panel = (Panel)carNegPDI[c2].Controls.Find("panel1", false)[0];
                    Button bAceptar = (Button)panel.Controls.Find("bRevisar", false)[0];
                    Button bRechazar = (Button)panel.Controls.Find("bRechazar", false)[0];

                    //PROGRAMACIÓN BOTONES
                    bAceptar.Click += (sender, EventArgs) => { bRevisarRevPDI_Click(sender, EventArgs, act); };
                    bRechazar.Click += (sender, EventArgs) => { bRechazarRevPDI_Click(sender, EventArgs, act); };

                    c++;
                    c2++;
                }
            }

            c2 = 0;
            //Ahora Carga Las Actividades en revisión por ONGs
            foreach (Actividad act in actNegONG)
            {
                if (act.Responsable.Equals(user))
                {
                    carNegONG[c2] = new CartelPendientes(user, act);
                    tablePP.Controls.Add(carNegONG[c2], 0, c);
                    tablePP.RowCount = tablePP.RowCount + 1;
                    carNegONG[c2].Location = new Point(carNegONG[c2].Location.X, (carNegONG[c2].Size.Height * c));
                    carNegONG[c2].BackColor = Color.Red;

                    //BOTONES GESTOR
                    Panel panel = (Panel)carNegONG[c2].Controls.Find("panel1", false)[0];
                    Button bAceptar = (Button)panel.Controls.Find("bRevisar", false)[0];
                    Button bRechazar = (Button)panel.Controls.Find("bRechazar", false)[0];

                    //Ponemos en invisible los botones, pues no es su turno
                    bAceptar.Visible = false;
                    bRechazar.Visible = false;

                    c++;
                    c2++;
                }
            }
        }

        private void cargarRevisionONG(int c, List<Actividad> actNegPDI, List<Actividad> actNegONG, List<Actividad> actNegCancelada, List<Actividad> actPenGestor) 
        {
            
            //Carteles que Usaremos
            CartelPendientes[] carNegPDI = new CartelPendientes[actNegPDI.Count];
            CartelPendientes[] carNegONG = new CartelPendientes[actNegONG.Count];
            CartelPendientes[] carNegCancelada = new CartelPendientes[actNegCancelada.Count];
            CartelPendientes[] carPenGestor = new CartelPendientes[actPenGestor.Count];

            int c2 = 0;
            foreach (Actividad act in actPenGestor)
            {
                if (act.Organizador.Equals(user))
                {
                    carPenGestor[c2] = new CartelPendientes(user, act);
                    tablePP.Controls.Add(carPenGestor[c2], 0, c);
                    tablePP.RowCount = tablePP.RowCount + 1;
                    carPenGestor[c2].Location = new Point(carPenGestor[c2].Location.X, (carPenGestor[c2].Size.Height * c));
                    carPenGestor[c2].BackColor = Color.Black;

                    //BOTONES GESTOR
                    Panel panel = (Panel)carPenGestor[c2].Controls.Find("panel1", false)[0];
                    Button bAceptar = (Button)panel.Controls.Find("bRevisar", false)[0];
                    Button bRechazar = (Button)panel.Controls.Find("bRechazar", false)[0];
                    bAceptar.Visible = false;
                    bRechazar.Visible = false;

                    //PROGRAMACIÓN BOTONES
                    bAceptar.Click += (sender, EventArgs) => { bRevisarRevONG_Click(sender, EventArgs, act); };
                    bRechazar.Click += (sender, EventArgs) => { bRechazarRevONG_Click(sender, EventArgs, act); };

                    c++;
                    c2++;
                }
            }

            c2 = 0;
            foreach (Actividad act in actNegCancelada)
            {
                if (act.Organizador.Equals(user))
                {
                    carNegCancelada[c2] = new CartelPendientes(user, act);
                    tablePP.Controls.Add(carNegCancelada[c2], 0, c);
                    tablePP.RowCount = tablePP.RowCount + 1;
                    carNegCancelada[c2].Location = new Point(carNegCancelada[c2].Location.X, (carNegCancelada[c2].Size.Height * c));
                    carNegCancelada[c2].BackColor = Color.Yellow;

                    //BOTONES GESTOR
                    Panel panel = (Panel)carNegCancelada[c2].Controls.Find("panel1", false)[0];
                    Button bAceptar = (Button)panel.Controls.Find("bRevisar", false)[0];
                    Button bRechazar = (Button)panel.Controls.Find("bRechazar", false)[0];

                    //PROGRAMACIÓN BOTONES
                    bAceptar.Click += (sender, EventArgs) => { bRevisarRevONG_Click(sender, EventArgs, act); };
                    bRechazar.Click += (sender, EventArgs) => { bRechazarRevONG_Click(sender, EventArgs, act); };

                    c++;
                    c2++;
                }
            }

            c2 = 0;
            foreach (Actividad act in actNegONG)
            {
                if (act.Organizador.Equals(user))
                {
                    carNegONG[c2] = new CartelPendientes(user, act);
                    tablePP.Controls.Add(carNegONG[c2], 0, c);
                    tablePP.RowCount = tablePP.RowCount + 1;
                    carNegONG[c2].Location = new Point(carNegONG[c2].Location.X, (carNegONG[c2].Size.Height * c));
                    carNegONG[c2].BackColor = Color.Green;

                    //BOTONES GESTOR
                    Panel panel = (Panel)carNegONG[c2].Controls.Find("panel1", false)[0];
                    Button bAceptar = (Button)panel.Controls.Find("bRevisar", false)[0];
                    Button bRechazar = (Button)panel.Controls.Find("bRechazar", false)[0];

                    //PROGRAMACIÓN BOTONES
                    bAceptar.Click += (sender, EventArgs) => { bRevisarRevONG_Click(sender, EventArgs, act); };
                    bRechazar.Click += (sender, EventArgs) => { bRechazarRevONG_Click(sender, EventArgs, act); };

                    c++;
                    c2++;
                }
            }

            c2 = 0;
            //Ahora las Actividades del PDI
            foreach (Actividad act in actNegPDI)
            {
                if (act.Organizador.Equals(user))
                {
                    carNegPDI[c2] = new CartelPendientes(user, act);
                    tablePP.Controls.Add(carNegPDI[c2], 0, c);
                    tablePP.RowCount = tablePP.RowCount + 1;
                    carNegPDI[c2].Location = new Point(carNegPDI[c2].Location.X, (carNegPDI[c2].Size.Height * c));
                    carNegPDI[c2].BackColor = Color.Red;

                    //BOTONES GESTOR
                    Panel panel = (Panel)carNegPDI[c2].Controls.Find("panel1", false)[0];
                    Button bAceptar = (Button)panel.Controls.Find("bRevisar", false)[0];
                    Button bRechazar = (Button)panel.Controls.Find("bRechazar", false)[0];

                    //PROGRAMACIÓN BOTONES
                    bAceptar.Visible = false;
                    bRechazar.Visible = false;

                    c++;
                    c2++;
                }
            }
        }

        //PROGRAMACIÓN BOTONES
          // -> PDI debe Aceptar/Rechazar Actividad Entregada por Gestor
        private void bRechazarRevGestor_Click(object sender, EventArgs eventArgs, Actividad act)
        {
            act.EstadoAct = Actividad.EstadoActividadE.ABIERTA;
            act.TipoAct = Actividad.TipoActividadE.VOLUNTARIADO;
            act.Responsable = null;
            cargarRevisionActividadesInicio();
        }

        private void bRevisarRevGestor_Click(object sender, EventArgs eventArgs, Actividad act)
        {
            VerActividadRevision actRevision = new VerActividadRevision(user,act);
            actRevision.ShowDialog();
            cargarRevisionActividadesInicio();
        }

        // -> PDI debe Aceptar/Rechazar Actividad en Negociación con ONG
        private void bRechazarRevPDI_Click(object sender, EventArgs eventArgs, Actividad act)
        {
            act.EstadoAct = Actividad.EstadoActividadE.NEGOCIACION_CANCELADA;
            act.TipoAct = Actividad.TipoActividadE.VOLUNTARIADO;
            act.Responsable = null;
            cargarRevisionActividadesInicio();
        }

        private void bRevisarRevPDI_Click(object sender, EventArgs eventArgs, Actividad act)
        {
            VerActividadRevision actRevision = new VerActividadRevision(user, act);
            actRevision.ShowDialog();
            cargarRevisionActividadesInicio();
        }

        // -> ONG debe Aceptar/Rechazar Actividad en Negociación con PDI
        private void bRechazarRevONG_Click(object sender, EventArgs eventArgs, Actividad act)
        {
            if (act.EstadoAct.ToString().Equals("NEGOCIACION_CANCELADA"))
            {
                act.BorrarActividad();
                cargarRevisionActividadesInicio();
            }
            else
            {
                act.EstadoAct = Actividad.EstadoActividadE.NEGOCIACION_CANCELADA;
                act.TipoAct = Actividad.TipoActividadE.VOLUNTARIADO;
                act.Responsable = null;
                cargarRevisionActividadesInicio();
            }
        }

        private void bRevisarRevONG_Click(object sender, EventArgs eventArgs, Actividad act)
        {
            VerActividadRevision actRevision = new VerActividadRevision(user, act);
            actRevision.ShowDialog();
            cargarRevisionActividadesInicio();
        }

        //
        //PESTAÑA VALORACION
        //
        private void cargarValoracionActividadesInicio()
        {
            chargedWindow = PantallaCargada.EVALUACION;
            tablePP.Controls.Clear();
            tablePP.RowCount = 1;
            tablePP.AutoScroll = false;
            panelPrincipal.AutoScroll = false;
            panelPrincipal.AutoScroll = true;

            /*
            List<Actividad_Realizada> actRealizadasPar = Actividad_Realizada.ListaActividadesRealizadas(user, Actividad_Realizada.EstadoActividadR.EVALUACION_PARTICIPANTE);
            List<Actividad> actRealizadaONG = Actividad_Realizada.ListaActividades(Actividad_Realizada.EstadoActividadR.EVALUACION_ONG);
            List<Actividad> actRealizadaPDI = Actividad_Realizada.ListaActividades(Actividad_Realizada.EstadoActividadR.EVALUACION_PDI);
            if(user.Rol.NombreRol.Equals("Estudiante") || user.Rol.NombreRol.Equals("PDI") || user.Rol.NombreRol.Equals("PAS")) cargarEvaluacionParticipante(actRealizadasPar);
            if(user.Rol.NombreRol.Equals("ONG")) cargarEvaluacionONG(actRealizadaONG);
            if(user.Rol.NombreRol.Equals("PDI")) cargarEvaluacionPDI(actRealizadaPDI);
            */

            if (user.Rol.NombreRol.Equals("PDI"))
            {
                cargarEvaluacionPorHacer();                     //Evaluaciones como Participante
                cargarEvaluacionPDI(tablePP.Controls.Count);    //Evaluaciones como PDI
                cargarEvaluacionPorONG(tablePP.Controls.Count); //Evaluaciones como Participante (Espera ONG)
                cargarEvaluacionPorPDI(tablePP.Controls.Count); //Evaluaciones como Participante (Espera PDI)
                cargarEvaluacionFinalizadas(tablePP.Controls.Count); //Evaluaciones que ya han transitado completamente
            }
            if (user.Rol.NombreRol.Equals("Estudiante") || user.Rol.NombreRol.Equals("PAS")) cargarEvaluacionParticipante();
            else cargarEvaluacionONG();                         //Evaluaciones como ONG

            
        }

        private void cargarEvaluacionParticipante() //Carga Para Evaluar Individualmente una Actividad
        {
            cargarEvaluacionPorHacer();
            cargarEvaluacionPorONG(tablePP.Controls.Count);
            cargarEvaluacionPorPDI(tablePP.Controls.Count);
            cargarEvaluacionFinalizadas(tablePP.Controls.Count); //Evaluaciones que ya han transitado completamente
        }

        private void cargarEvaluacionPorHacer()
        {
            List<Actividad_Realizada> actRealizadasP = Actividad_Realizada.ListaActividadesRealizadas(user, Actividad_Realizada.EstadoActividadR.EVALUACION_PARTICIPANTE);
            CartelActividadesValoracion[] actsCarteles = new CartelActividadesValoracion[actRealizadasP.Count];

            int c = 0;
            foreach (Actividad_Realizada act in actRealizadasP)
            {
                actsCarteles[c] = new CartelActividadesValoracion(user, act.Actividad);
                tablePP.Controls.Add(actsCarteles[c], 0, c);
                tablePP.RowCount = tablePP.RowCount + 1;
                actsCarteles[c].Location = new Point(actsCarteles[c].Location.X, (actsCarteles[c].Size.Height * c));
                actsCarteles[c].BackColor = Color.Aqua;

                //BOTON SOLICITAR
                Panel panel = (Panel)actsCarteles[c].Controls.Find("panel1", false)[0];
                Button bValorar = (Button)panel.Controls.Find("bValorar", false)[0];

                //PROGRAMACIÓN BOTONES
                bValorar.Click += (sender, EventArgs) => { bValorar_Click(sender, EventArgs, act); };
                c++;
            }
        }

        private void bValorar_Click(object sender, EventArgs eventArgs, Actividad_Realizada act)
        {
            EvaluarActividad evAct = new EvaluarActividad(act);
            evAct.ShowDialog();
            cargarValoracionActividadesInicio();
        }

        private void cargarEvaluacionPorONG(int c)
        {
            List<Actividad_Realizada> actRealizadasP = Actividad_Realizada.ListaActividadesRealizadas(user, Actividad_Realizada.EstadoActividadR.EVALUACION_ONG);
            CartelActividadesValoracion[] actsCarteles = new CartelActividadesValoracion[actRealizadasP.Count];

            int c2 = 0;
            foreach (Actividad_Realizada act in actRealizadasP)
            {
                actsCarteles[c2] = new CartelActividadesValoracion(user, act.Actividad);
                tablePP.Controls.Add(actsCarteles[c2], 0, c);
                tablePP.RowCount = tablePP.RowCount + 1;
                actsCarteles[c2].Location = new Point(actsCarteles[c2].Location.X, (actsCarteles[c2].Size.Height * c));
                actsCarteles[c2].BackColor = Color.DeepPink;

                //BOTON SOLICITAR
                Panel panel = (Panel)actsCarteles[c2].Controls.Find("panel1", false)[0];
                Button bValorar = (Button)panel.Controls.Find("bValorar", false)[0];
                bValorar.Visible = false;

                c++;
                c2++;
            }
        }

        private void cargarEvaluacionPorPDI(int c)
        {
            List<Actividad_Realizada> actRealizadasP = Actividad_Realizada.ListaActividadesRealizadas(user, Actividad_Realizada.EstadoActividadR.EVALUACION_PDI);
            CartelActividadesValoracion[] actsCarteles = new CartelActividadesValoracion[actRealizadasP.Count];

            int c2 = 0;
            foreach (Actividad_Realizada act in actRealizadasP)
            {
                actsCarteles[c2] = new CartelActividadesValoracion(user, act.Actividad);
                tablePP.Controls.Add(actsCarteles[c2], 0, c);
                tablePP.RowCount = tablePP.RowCount + 1;
                actsCarteles[c2].Location = new Point(actsCarteles[c2].Location.X, (actsCarteles[c2].Size.Height * c));
                actsCarteles[c2].BackColor = Color.Green;

                //BOTON SOLICITAR
                Panel panel = (Panel)actsCarteles[c2].Controls.Find("panel1", false)[0];
                Button bValorar = (Button)panel.Controls.Find("bValorar", false)[0];
                bValorar.Visible = false;

                c++;
                c2++;
            }
        }

        private void cargarEvaluacionFinalizadas(int c)
        {
            List<Actividad_Realizada> actRealizadasP = Actividad_Realizada.ListaActividadesRealizadas(user, Actividad_Realizada.EstadoActividadR.EVALUACION_FINALIZADA);
            CartelActividadesValoracion[] actsCarteles = new CartelActividadesValoracion[actRealizadasP.Count];

            int c2 = 0;
            foreach (Actividad_Realizada act in actRealizadasP)
            {
                actsCarteles[c2] = new CartelActividadesValoracion(user, act.Actividad);
                tablePP.Controls.Add(actsCarteles[c2], 0, c);
                tablePP.RowCount = tablePP.RowCount + 1;
                actsCarteles[c2].Location = new Point(actsCarteles[c2].Location.X, (actsCarteles[c2].Size.Height * c));
                actsCarteles[c2].BackColor = Color.Gold;

                //BOTON SOLICITAR
                Panel panel = (Panel)actsCarteles[c2].Controls.Find("panel1", false)[0];
                Button bValorar = (Button)panel.Controls.Find("bValorar", false)[0];
                bValorar.Text = "Opinión";

                //PROGRAMACIÓN BOTONES
                bValorar.Click += (sender, EventArgs) => { bValorarFinal_Click(sender, EventArgs, act); };

                c++;
                c2++;
            }
        }

        private void bValorarFinal_Click(object sender, EventArgs eventArgs, Actividad_Realizada act)
        {
            DialogResult emCierreDialog;
            string mensaje = "Función No Implementada Aún.";
            string caption = "¡AVISO!";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            emCierreDialog = MessageBox.Show(mensaje, caption, buttons);
        }

        private void cargarEvaluacionPDI(int c) //Carga para el PDI las que tiene que valorar como Responsable
        {
            List<Actividad> actRealizadasP = Actividad_Realizada.ListaActividades();
            CartelActividadesValoracion[] actsCarteles = new CartelActividadesValoracion[actRealizadasP.Count];

            int c2 = 0;
            foreach (Actividad act in actRealizadasP)
            {
                if (act.Responsable!=null && act.Responsable.Equals(user))
                {
                    actsCarteles[c2] = new CartelActividadesValoracion(user, act);
                    tablePP.Controls.Add(actsCarteles[c2], 0, c);
                    tablePP.RowCount = tablePP.RowCount + 1;
                    actsCarteles[c2].Location = new Point(actsCarteles[c2].Location.X, (actsCarteles[c2].Size.Height * c));
                    actsCarteles[c2].BackColor = Color.Blue;

                    //BOTON SOLICITAR
                    Panel panel = (Panel)actsCarteles[c2].Controls.Find("panel1", false)[0];
                    Button bEvaluar = (Button)panel.Controls.Find("bValorar", false)[0];
                    bEvaluar.Text = "Evaluar";

                    //PROGRAMACIÓN BOTONES
                    bEvaluar.Click += (sender, EventArgs) => { bEvaluar_Click(sender, EventArgs, act); };

                    c++;
                    c2++;
                }
            }
        }

        private void cargarEvaluacionONG()
        {
            List<Actividad> actRealizadasP = Actividad_Realizada.ListaActividades();
            CartelActividadesValoracion[] actsCarteles = new CartelActividadesValoracion[actRealizadasP.Count];

            int c = 0;
            foreach (Actividad act in actRealizadasP)
            {
                if (act.Organizador.Equals(user))
                {
                    actsCarteles[c] = new CartelActividadesValoracion(user, act);
                    tablePP.Controls.Add(actsCarteles[c], 0, c);
                    tablePP.RowCount = tablePP.RowCount + 1;
                    actsCarteles[c].Location = new Point(actsCarteles[c].Location.X, (actsCarteles[c].Size.Height * c));
                    actsCarteles[c].BackColor = Color.DeepPink;

                    //BOTON SOLICITAR
                    Panel panel = (Panel)actsCarteles[c].Controls.Find("panel1", false)[0];
                    Button bEvaluar = (Button)panel.Controls.Find("bValorar", false)[0];
                    bEvaluar.Text = "Evaluar";

                    //PROGRAMACIÓN BOTONES
                    bEvaluar.Click += (sender, EventArgs) => { bEvaluar_Click(sender, EventArgs, act); };

                    c++;
                }
            }
        }

        private void bEvaluar_Click(object sender, EventArgs eventArgs, Actividad act)
        {
            EvaluarParticipantes evPar = new EvaluarParticipantes(user, act);
            evPar.ShowDialog();
            cargarValoracionActividadesInicio();
        }

        /*
        private void cargarEvaluacionPDI(List<Actividad> lista)
        {
            CartelActividadesValoracion[] actsCarteles = new CartelActividadesValoracion[lista.Count];
            int c = 0;

            foreach (Actividad act in lista)
            {
                actsCarteles[c] = new CartelActividadesValoracion(user, act);
                tablePP.Controls.Add(actsCarteles[c], 0, c + 1);
                tablePP.RowCount = tablePP.RowCount + 1;
                actsCarteles[c].Location = new Point(actsCarteles[c].Location.X, (actsCarteles[c].Size.Height * c));
                actsCarteles[c].BackColor = Color.Aqua;

                //BOTON SOLICITAR
                Panel panel = (Panel)actsCarteles[c].Controls.Find("panel1", false)[0];
                Button bValorar = (Button)panel.Controls.Find("bValorar", false)[0];
                //PROGRAMACIÓN BOTONES
                bValorar.Click += (sender, EventArgs) => { bValorarONG_Click(sender, EventArgs, act); };
                c++;
            }
        }

        private void cargarEvaluacionONG(List<Actividad> lista)
        {
            CartelActividadesValoracion[] actsCarteles = new CartelActividadesValoracion[lista.Count];
            int c = 0;

            foreach (Actividad act in lista)
            {
                actsCarteles[c] = new CartelActividadesValoracion(user, act);
                tablePP.Controls.Add(actsCarteles[c], 0, c + 1);
                tablePP.RowCount = tablePP.RowCount + 1;
                actsCarteles[c].Location = new Point(actsCarteles[c].Location.X, (actsCarteles[c].Size.Height * c));
                actsCarteles[c].BackColor = Color.Aqua;

                //BOTON SOLICITAR
                Panel panel = (Panel)actsCarteles[c].Controls.Find("panel1", false)[0];
                Button bValorar = (Button)panel.Controls.Find("bValorar", false)[0];
                //PROGRAMACIÓN BOTONES
                bValorar.Click += (sender, EventArgs) => { bValorarONG_Click(sender, EventArgs, act); };
                c++;
            }
        }

        private void cargarEvaluacionParticipante(List<Actividad_Realizada> lista)
        {
            CartelActividadesValoracion[] actsCarteles = new CartelActividadesValoracion[lista.Count];

            int c = 0;
            foreach (Actividad_Realizada act in lista)
            {
                actsCarteles[c] = new CartelActividadesValoracion(user, act.Actividad);
                tablePP.Controls.Add(actsCarteles[c], 0, c + 1);
                tablePP.RowCount = tablePP.RowCount + 1;
                actsCarteles[c].Location = new Point(actsCarteles[c].Location.X, (actsCarteles[c].Size.Height * c));
                actsCarteles[c].BackColor = Color.Aqua;

                //BOTON SOLICITAR
                Panel panel = (Panel)actsCarteles[c].Controls.Find("panel1", false)[0];
                Button bValorar = (Button)panel.Controls.Find("bValorar", false)[0];
                if (!act.EstadoRealizacion.ToString().Equals("EVALUACION_" + user.Rol.NombreRol.ToUpper()) &&
                    !act.EstadoRealizacion.ToString().Equals("EVALUACION_PARTICIPANTE"))
                    bValorar.Visible = false;
                //PROGRAMACIÓN BOTONES
                bValorar.Click += (sender, EventArgs) => { bValorar_Click(sender, EventArgs, act); };
                c++;
            }
        }

        private void bValorar_Click(object sender, EventArgs eventArgs, Actividad_Realizada act)
        {
            EvaluarActividad evAct = new EvaluarActividad(act);
            evAct.ShowDialog();
            cargarValoracionActividadesInicio();
        }

        private void bValorarONG_Click(object sender, EventArgs eventArgs, Actividad act)
        {
            EvaluarParticipantes evPar = new EvaluarParticipantes(user,act);
            evPar.ShowDialog();
            cargarValoracionActividadesInicio();
        }

    */

        //
        // PESTAÑA MIS ACTIVIDADES -> Sólo ONG (organizador) y PDI (responsable) // Sólo Actividades Abiertas y Publicadas
        //
        private void cargarMisActividadesInicio()
        {
            chargedWindow = PantallaCargada.MIS_ACTIVIDADES;
            tablePP.Controls.Clear();
            tablePP.RowCount = 1;
            tablePP.AutoScroll = false;
            panelPrincipal.AutoScroll = false;
            panelPrincipal.AutoScroll = true;

            int c = 0;
            if (user.Rol.NombreRol.Equals("PDI"))
            {
                List<Actividad> actsPDI = Actividad.ListaActividades(Actividad.EstadoActividadE.ABIERTA);
                List<Actividad> actsCERPDI = Actividad.ListaActividades(Actividad.EstadoActividadE.CERRADA);
                List<Actividad> actsPROPDI = Actividad.ListaActividades(Actividad.EstadoActividadE.EN_PROCESO);
                cargarMisActsPDI(c,actsPDI);
                c = tablePP.Controls.Count;
                cargarMisActsPDI(c,actsCERPDI);
                c = tablePP.Controls.Count;
                cargarMisActsPDI(c,actsPROPDI);
                
            }
            else
            { //ES ONG -> lo mismo que para el PDI, pero al contrario 
                List<Actividad> actsONG = Actividad.ListaActividades(Actividad.EstadoActividadE.ABIERTA);
                List<Actividad> actsCERONG = Actividad.ListaActividades(Actividad.EstadoActividadE.CERRADA);
                List<Actividad> actsPROONG = Actividad.ListaActividades(Actividad.EstadoActividadE.EN_PROCESO);
                cargarMisActsONG(c,actsONG);
                c = tablePP.Controls.Count;
                cargarMisActsONG(c,actsCERONG);
                c = tablePP.Controls.Count;
                cargarMisActsONG(c,actsPROONG);
            }
        }

        private void cargarMisActsONG(int c, List<Actividad> actsONG)
        {
            CartelPendientes[] carActsONG = new CartelPendientes[actsONG.Count];
            int c2 = 0;
            foreach (Actividad act in actsONG)
            {
                if (act.Organizador.Equals(user))
                {
                    carActsONG[c2] = new CartelPendientes(user, act);
                    tablePP.Controls.Add(carActsONG[c2], 0, c);
                    tablePP.RowCount = tablePP.RowCount + 1;
                    carActsONG[c2].Location = new Point(carActsONG[c2].Location.X, (carActsONG[c2].Size.Height * c));
                    if(act.EstadoAct.ToString().Equals("ABIERTA")) carActsONG[c2].BackColor = Color.Blue;
                    if (act.EstadoAct.ToString().Equals("CERRADA")) carActsONG[c2].BackColor = Color.OrangeRed;
                    if (act.EstadoAct.ToString().Equals("EN_PROCESO")) carActsONG[c2].BackColor = Color.ForestGreen;

                    //BOTONES GESTOR
                    Panel panel = (Panel)carActsONG[c2].Controls.Find("panel1", false)[0];
                    Button bAceptar = (Button)panel.Controls.Find("bRevisar", false)[0];
                    Button bRechazar = (Button)panel.Controls.Find("bRechazar", false)[0];
                    Button bParticipantes = (Button)panel.Controls.Find("bVerParts", false)[0];
                    bAceptar.Visible = false;
                    bRechazar.Visible = false;
                    bParticipantes.Visible = true;

                    //PROGRAMACIÓN BOTONES
                    bParticipantes.Click += (sender, EventArgs) => { bVerSolicitantesONG_Click(sender, EventArgs, act); };

                    c++;
                }
            }
        }

        private void cargarMisActsPDI(int c, List<Actividad> actsPDI)
        {
            CartelPendientes[] carActsPDI = new CartelPendientes[actsPDI.Count];
            int c2 = 0;
            foreach (Actividad act in actsPDI)
            {
                if (act.Responsable != null && act.Responsable.Equals(user))
                {
                    carActsPDI[c2] = new CartelPendientes(user, act);
                    tablePP.Controls.Add(carActsPDI[c2], 0, c);
                    tablePP.RowCount = tablePP.RowCount + 1;
                    carActsPDI[c2].Location = new Point(carActsPDI[c2].Location.X, (carActsPDI[c2].Size.Height * c));
                    if (act.EstadoAct.ToString().Equals("ABIERTA")) carActsPDI[c2].BackColor = Color.Blue;
                    if (act.EstadoAct.ToString().Equals("CERRADA")) carActsPDI[c2].BackColor = Color.OrangeRed;
                    if (act.EstadoAct.ToString().Equals("EN_PROCESO")) carActsPDI[c2].BackColor = Color.ForestGreen;

                    //BOTONES GESTOR
                    Panel panel = (Panel)carActsPDI[c2].Controls.Find("panel1", false)[0];
                    Button bAceptar = (Button)panel.Controls.Find("bRevisar", false)[0];
                    Button bRechazar = (Button)panel.Controls.Find("bRechazar", false)[0];
                    Button bParticipantes = (Button)panel.Controls.Find("bVerParts", false)[0];
                    bAceptar.Visible = false;
                    bRechazar.Visible = false;
                    bParticipantes.Visible = true;

                    //PROGRAMACIÓN BOTONES
                    bParticipantes.Click += (sender, EventArgs) => { bVerSolicitantesPDI_Click(sender, EventArgs, act); };

                    c++;
                }
            }
        }

        private void bVerSolicitantesONG_Click(object sender, EventArgs eventArgs, Actividad act)
        {
            VerParticipantes verPar = new VerParticipantes(act,user);
            this.Visible = false;
            verPar.ShowDialog();
            this.Visible = true;
            cargarMisActividadesInicio();
        }

        private void bVerSolicitantesPDI_Click(object sender, EventArgs eventArgs, Actividad act)
        {
            VerParticipantes verPar = new VerParticipantes(act, user);
            this.Visible = false;
            verPar.ShowDialog();
            this.Visible = true;
        }


        //
        // PESTAÑA ACTIVIDADES INSCRITAS
        //
        private void cargarActividadesInscritas()
        {
            chargedWindow = PantallaCargada.ACTIVIDADES_INSCRITAS;
            tablePP.Controls.Clear();
            tablePP.RowCount = 1;
            tablePP.AutoScroll = false;
            panelPrincipal.AutoScroll = false;
            panelPrincipal.AutoScroll = true;

            int c = 0;

            List<Actividad_Solicitud> actSolAceptada = Actividad_Solicitud.ListaActividadesSolicitudes(user, Actividad_Solicitud.EstadoActividadSolicitudE.ACEPTADA);
            List<Actividad_Solicitud> actSolEsperaPDI = Actividad_Solicitud.ListaActividadesSolicitudes(user, Actividad_Solicitud.EstadoActividadSolicitudE.EN_ESPERA_PDI);
            List<Actividad_Solicitud> actSolEsperaONG = Actividad_Solicitud.ListaActividadesSolicitudes(user, Actividad_Solicitud.EstadoActividadSolicitudE.EN_ESPERA_ONG);
            List<Actividad_Solicitud> actSolDenegada = Actividad_Solicitud.ListaActividadesSolicitudes(user, Actividad_Solicitud.EstadoActividadSolicitudE.DENEGADA);

            cargarSolicitudesAceptadas(actSolAceptada,c);
            c = tablePP.Controls.Count;
            cargarSolicitudesEsperaPDI(actSolEsperaPDI,c);
            c = tablePP.Controls.Count;
            cargarSolicitudesEsperaONG(actSolEsperaONG,c);
            c = tablePP.Controls.Count;
            cargarSolicitudesDenegadas(actSolDenegada,c);
        }

        private void cargarSolicitudesDenegadas(List<Actividad_Solicitud> actSolDenegada, int c)
        {
            CartelActividadesStandard[] carActInsDenegada = new CartelActividadesStandard[actSolDenegada.Count];

            int c2 = 0;
            foreach (Actividad_Solicitud aS in actSolDenegada)
            {
                carActInsDenegada[c2] = new CartelActividadesStandard(user, aS.Actividad);
                tablePP.Controls.Add(carActInsDenegada[c2], 0, c);
                tablePP.RowCount = tablePP.RowCount + 1;
                carActInsDenegada[c2].Location = new Point(carActInsDenegada[c2].Location.X, (carActInsDenegada[c2].Size.Height * c));
                carActInsDenegada[c2].BackColor = Color.Red;

                //BOTONES GESTOR
                Panel panel = (Panel)carActInsDenegada[c2].Controls.Find("panel1", false)[0];
                Button bCancelar = (Button)panel.Controls.Find("bSolicitar", false)[0];
                Label estado = (Label)panel.Controls.Find("lPlazas", false)[0];
                estado.Text = "Estado Solicitud:";
                carActInsDenegada[c2].NumPlazas = "DENEGADA";

                bCancelar.Visible = false;


                c++;
                c2++;
            }
        }

        private void cargarSolicitudesEsperaONG(List<Actividad_Solicitud> actSolEsperaONG, int c)
        {
            CartelActividadesStandard[] carActInsEsperaONG = new CartelActividadesStandard[actSolEsperaONG.Count];

            int c2 = 0;
            foreach (Actividad_Solicitud aS in actSolEsperaONG)
            {
                carActInsEsperaONG[c2] = new CartelActividadesStandard(user, aS.Actividad);
                tablePP.Controls.Add(carActInsEsperaONG[c2], 0, c);
                tablePP.RowCount = tablePP.RowCount + 1;
                carActInsEsperaONG[c2].Location = new Point(carActInsEsperaONG[c2].Location.X, (carActInsEsperaONG[c2].Size.Height * c));
                carActInsEsperaONG[c2].BackColor = Color.Violet;

                //BOTONES GESTOR
                Panel panel = (Panel)carActInsEsperaONG[c2].Controls.Find("panel1", false)[0];
                Button bCancelar = (Button)panel.Controls.Find("bSolicitar", false)[0];
                Label estado = (Label)panel.Controls.Find("lPlazas", false)[0];
                estado.Text = "Estado Solicitud:";
                carActInsEsperaONG[c2].NumPlazas = "ESPERANDO ONG";
                bCancelar.Text = "Cancelar";

                //Programación Botón
                bCancelar.Click += (sender, EventArgs) => { bCancelarSolicitud_Click(sender, EventArgs, aS); };

                c++;
                c2++;
            }
        }

        private void cargarSolicitudesEsperaPDI(List<Actividad_Solicitud> actSolEsperaPDI, int c)
        {
            CartelActividadesStandard[] carActInsEsperaPDI = new CartelActividadesStandard[actSolEsperaPDI.Count];

            int c2 = 0;
            foreach (Actividad_Solicitud aS in actSolEsperaPDI)
            {
                carActInsEsperaPDI[c2] = new CartelActividadesStandard(user, aS.Actividad);
                tablePP.Controls.Add(carActInsEsperaPDI[c2], 0, c);
                tablePP.RowCount = tablePP.RowCount + 1;
                carActInsEsperaPDI[c2].Location = new Point(carActInsEsperaPDI[c2].Location.X, (carActInsEsperaPDI[c2].Size.Height * c));
                carActInsEsperaPDI[c2].BackColor = Color.Purple;

                //BOTONES GESTOR
                Panel panel = (Panel)carActInsEsperaPDI[c2].Controls.Find("panel1", false)[0];
                Button bCancelar = (Button)panel.Controls.Find("bSolicitar", false)[0];
                Label estado = (Label)panel.Controls.Find("lPlazas", false)[0];
                estado.Text = "Estado Solicitud:";
                carActInsEsperaPDI[c2].NumPlazas = "ESPERANDO PDI";
                bCancelar.Text = "Cancelar";

                //Programación Botón
                bCancelar.Click += (sender, EventArgs) => { bCancelarSolicitud_Click(sender, EventArgs, aS); };


                c++;
                c2++;
            }
        }

        private void bCancelarSolicitud_Click(object sender, EventArgs eventArgs, Actividad_Solicitud aS)
        {
            DialogResult emCierreDialog;
            string mensaje = "¿Desea cancelar esta solicitud?";
            string caption = "¡AVISO!";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            emCierreDialog = MessageBox.Show(mensaje, caption, buttons);

            if (emCierreDialog == DialogResult.Yes)
            {
                user.RemoveActividadSolicitada(aS);
                cargarActividadesInscritas();
                
            }
        }

        private void cargarSolicitudesAceptadas(List<Actividad_Solicitud> actSolAceptada, int c)
        {
            CartelActividadesStandard[] carActInsAceptada = new CartelActividadesStandard[actSolAceptada.Count];

            int c2 = 0;
            foreach (Actividad_Solicitud aS in actSolAceptada)
            {
                carActInsAceptada[c2] = new CartelActividadesStandard(user, aS.Actividad);
                tablePP.Controls.Add(carActInsAceptada[c2], 0, c);
                tablePP.RowCount = tablePP.RowCount + 1;
                carActInsAceptada[c2].Location = new Point(carActInsAceptada[c2].Location.X, (carActInsAceptada[c2].Size.Height * c));
                carActInsAceptada[c2].BackColor = Color.Green;

                //BOTONES
                Panel panel = (Panel)carActInsAceptada[c2].Controls.Find("panel1", false)[0];
                Button bCancelar = (Button)panel.Controls.Find("bSolicitar", false)[0];
                Label estado = (Label)panel.Controls.Find("lPlazas", false)[0];
                estado.Text = "Estado Solicitud:";
                carActInsAceptada[c2].NumPlazas = "ACEPTADA";
                bCancelar.Visible = false;


                c++;
                c2++;
            }
        }


        //
        // MÉTODOS EXTRA
        //
        private void PaginaPrincipal_Load(object sender, EventArgs e)
        {
            TopMost = true;
            TopMost = false;
        }

        private void pictPerfil_Click(object sender, EventArgs e) //Abrir Perfil
        {
            if (user.Rol.NombreRol.Equals("ONG"))
            {
                FPerfilONG pagONG = new FPerfilONG(user);
                this.Visible = false;
                pagONG.ShowDialog();
            }
            else if (user.Rol.NombreRol.Equals("PAS"))
            {
                FPerfilPAS pagPAS = new FPerfilPAS(user);
                this.Visible = false;
                pagPAS.ShowDialog();
            }
            else
            {
                FPerfilUsuario pagina = new FPerfilUsuario(user);
                this.Visible = false;
                pagina.ShowDialog();
            }

            if (user.Email.Trim().Equals(""))
            {
                this.Close();
            }
            else
            {
                this.Visible = true;
            }

            //Extra
            if (user.Imagen != null) pictureUser.Image = user.Imagen;
            else pictureUser.Image = global::APS.Properties.Resources.userDefault;
            cargarMatchActividadesInicio();
        }

        private void pictMensajes_Click(object sender, EventArgs e) //Abrir Mensajes
        {
            BandejaMensajes msg = new BandejaMensajes(user);
            this.Visible = false;
            msg.ShowDialog();
            this.Visible = true;
        }

        private void pictActividad_Click(object sender, EventArgs e) //Abrir Actividad
        {
            NuevaActividad newAct = new NuevaActividad(user);
            this.Visible = false;
            newAct.ShowDialog();
            this.Visible = true;
            cargarRevisionActividadesInicio();
        }

        private void pictCerrarSesion_Click(object sender, EventArgs e) //Cerrar Sesión
        {
            DialogResult emCierreDialog;
            string mensaje = "¿Quieres cerrar la sesión actual?";
            string caption = "¡AVISO!";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            emCierreDialog = MessageBox.Show(mensaje, caption, buttons);

            if (emCierreDialog == DialogResult.Yes) this.Close();
        }

        private void pictHistorial_Click(object sender, EventArgs e) //Abrir Historial
        {
            VerListaHistorial verHistorial = new VerListaHistorial(this.user);
            this.Visible = false;
            verHistorial.ShowDialog();
            this.Visible = true;
        }

        private void pictDevelop_Click(object sender, EventArgs e) //Botón Web Developer
        {
            System.Diagnostics.Process.Start("firefox.exe", "https://wepass502328605.wordpress.com/");
        }

        private void bDuda_Click(object sender, EventArgs e) //Botón Duda Help
        {

            if (chargedWindow.Equals(PantallaCargada.MATCH))
            {

                HelpMatch help = new HelpMatch();
                help.ShowDialog();

            } 
            else if (chargedWindow.Equals(PantallaCargada.TODAS))
            {
                HelpTodas help = new HelpTodas();
                help.ShowDialog();
            }
            else if(chargedWindow.Equals(PantallaCargada.PENDIENTES))
            {
                HelpPendientes help = new HelpPendientes();
                help.ShowDialog();
            } 
            else if (chargedWindow.Equals(PantallaCargada.ACTIVIDADES_INSCRITAS))
            {
                HelpActividadesInscritas help = new HelpActividadesInscritas();
                help.ShowDialog();
            }
            else if (chargedWindow.Equals(PantallaCargada.MIS_ACTIVIDADES))
            {
                HelpMisActividades help = new HelpMisActividades();
                help.ShowDialog();
            }
            else if (chargedWindow.Equals(PantallaCargada.REVISION))
            {
                if (user.Rol.NombreRol.Equals("PDI"))
                {
                    HelpRevisionPDI help = new HelpRevisionPDI();
                    help.ShowDialog();
                }
                else
                {
                    HelpRevisionONG help = new HelpRevisionONG();
                    help.ShowDialog();
                }
            }
            else if (chargedWindow.Equals(PantallaCargada.EVALUACION))
            {
                if (user.Rol.NombreRol.Equals("PDI"))
                {
                    HelpEvaluacionPDI help = new HelpEvaluacionPDI();
                    help.ShowDialog();
                }
                else if (user.Rol.NombreRol.Equals("ONG"))
                {
                    HelpEvaluacionONG help = new HelpEvaluacionONG();
                    help.ShowDialog();
                }
                else
                {
                    HelpEvaluacionEstudiantePAS help = new HelpEvaluacionEstudiantePAS();
                    help.ShowDialog();
                }
            }
            else if(chargedWindow.Equals(PantallaCargada.PROYECTOS))
            {
                DialogResult emCierreDialog;
                string mensaje = "Función No Implementada Aún.";
                string caption = "¡AVISO!";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                emCierreDialog = MessageBox.Show(mensaje, caption, buttons);
            }

        }

        private void pictGestor_Click(object sender, EventArgs e)
        {
            ControlesGestor contGestor = new ControlesGestor();
            contGestor.ShowDialog();
        }
    }
}
