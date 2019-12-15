using APS.Interfaces.Gestión_Actividades;
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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APS.Interfaces
{
    public partial class PaginaPrincipal : Form
    {

        Usuario user;

        public PaginaPrincipal(Usuario user)
        {
            InitializeComponent();
            this.user = user;
            if (user.Imagen != null) pictureUser.Image = user.Imagen;
            
            tabUser.Visible = true;
            if (!user.AccesoPantalla("MATCH")) tabUser.Controls.Remove(this.pMatch); //HECHO
            if (!user.AccesoPantalla("TODAS")) tabUser.Controls.Remove(this.pTodas); //HECHO
            if (!user.AccesoPantalla("PROYECTOS")) tabUser.Controls.Remove(this.pProyectos);
            if (!user.AccesoPantalla("VALORACION")) tabUser.Controls.Remove(this.pValoracion);
            if (!user.AccesoPantalla("PENDIENTES")) tabUser.Controls.Remove(this.pPendientes); //HECHO
            if (!user.AccesoPantalla("REVISION")) tabUser.Controls.Remove(this.pRevision); //HECHO
            if (!user.AccesoPantalla("MIS ACTIVIDADES")) tabUser.Controls.Remove(this.pMisActividades);
            if (!user.AccesoPantalla("ACTIVIDADES INSCRITAS")) tabUser.Controls.Remove(this.pActividadesInscritas);

            if (user.NombreUser != null) lWelcome.Text = "¡Bienvenido, " + user.Nombre + " " + user.Apellido1 + "!";
            else lWelcome.Text = "¡Bienvenido!";

            lNewAct.Visible = user.InsertarPantalla("ACTIVIDADES");
            lNuevoProy.Visible = user.InsertarPantalla("PROYECTOS");

            if (user.AccesoPantalla("MATCH")) cargarMatchActividadesInicio(); //HECHO
            if (user.AccesoPantalla("TODAS")) cargarTodasActividadesInicio(); //HECHO
            //if (user.AccesoPantalla("PROYECTOS")) tabUser.Controls.Remove(this.pProyectos);
            //if (user.AccesoPantalla("VALORACION")) tabUser.Controls.Remove(this.pValoracion);
            if (user.AccesoPantalla("PENDIENTES")) cargarPendientesActividadesInicio(); //HECHO
            if (user.AccesoPantalla("REVISION")) cargarRevisionActividadesInicio(); //HECHO
            if (user.AccesoPantalla("MIS ACTIVIDADES")) cargarMisActividadesInicio();
            if (user.AccesoPantalla("ACTIVIDADES INSCRITAS")) cargarActividadesInscritas();
        }

        //
        // PESTAÑA MATCH
        //
        private void cargarMatchActividadesInicio()
        {
            pMatch.Controls.Add(panelMatch);
            cargarFiltrosMatch();

            List<Actividad> actividades = Actividad.ListaActividades(Actividad.EstadoActividadE.ABIERTA);
            CartelActividadesStandard[] actsCarteles = new CartelActividadesStandard[actividades.Count];

            int c = 0;
            foreach (Actividad act in actividades)
            {
                foreach(Asignatura asig in user.Asignaturas)
                {
                    if (act.Asignatura != null && act.Asignatura.Equals(asig))
                    {
                        actsCarteles[c] = new CartelActividadesStandard(user, act);
                        panelMatch.Controls.Add(actsCarteles[c], 0, c + 1);
                        panelMatch.RowCount = panelMatch.RowCount + 1;
                        actsCarteles[c].Location = new Point(actsCarteles[c].Location.X, (actsCarteles[c].Size.Height * c));

                        //Programar Solicitar
                        Panel panel = (Panel)actsCarteles[c].Controls.Find("panel1",false)[0];
                        Button bSolicitar = (Button)panel.Controls.Find("bSolicitar", false)[0];
                        bSolicitar.Click += (sender, EventArgs) => { bSolicitar_Click(sender, EventArgs, act); };

                        c++;
                    }
                }
            }
        }

        private void bSolicitar_Click(object sender, EventArgs eventArgs, Actividad act)
        {
            List<Actividad_Solicitud> lista = Actividad_Solicitud.ListaActividadesSolicitudes(user);
            Boolean encontrada = false;
            int contador = 0;
            while (!encontrada && lista.Count > contador)
            {
                if (lista[contador].Actividad.Equals(act)) encontrada = true;
                contador++;
            }
            Console.WriteLine("Encontrado: " + encontrada.ToString());
            if(!encontrada)
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
            else
            {
                DialogResult emCierreDialog;
                string mensaje = "Esta actividad ya ha sido solicitada anteriormente.";
                string caption = "¡AVISO!";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                emCierreDialog = MessageBox.Show(mensaje, caption, buttons);
            }

        }

        private void cargarFiltrosMatch()
        {
            //pMatch
            CartelFiltroMatch cFiltro = new CartelFiltroMatch(this.user);
            panelMatch.Controls.Add(cFiltro, 0, 0);
            panelMatch.RowCount = panelMatch.RowCount + 1;

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
                Grado g = ((Preferencia)cBox.SelectedItem).Grado;
                Asignatura asig = ((Preferencia)cBox.SelectedItem).Asignatura;
                Actividad.TurnoE turnoF = ((Preferencia)cBox.SelectedItem).Turno;
                Actividad.TipoActividadE tipoActF = ((Preferencia)cBox.SelectedItem).TipoActividad;
                Actividad.TipoTrabajoE tipoTrabF = ((Preferencia)cBox.SelectedItem).TipoTrabajo;
                Actividad.AmbitoTrabajoE ambTrabF = ((Preferencia)cBox.SelectedItem).AmbitoTrabajo;
                int horas = -1;

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
                if (!turnoF.Equals(null) && !turnoF.Equals(Actividad.TurnoE.AMBAS))
                {
                    foreach (Actividad a in Actividad.ListaActividades())
                    {
                        if (!a.Turno.Equals(turnoF)) lAct.Remove(a);
                    }
                }

                //Filtro TipoActividad
                if (!tipoActF.Equals(null) && !tipoActF.Equals(Actividad.TipoActividadE.TODAS))
                {
                    foreach (Actividad a in Actividad.ListaActividades())
                    {
                        if (!a.TipoAct.Equals(tipoActF)) lAct.Remove(a);
                    }
                }

                //Filtro TipoTrab
                if (!tipoTrabF.Equals(null) && !tipoTrabF.Equals(Actividad.TipoActividadE.TODAS))
                {
                    foreach (Actividad a in Actividad.ListaActividades())
                    {
                        if (!a.TipoAct.Equals(tipoTrabF)) lAct.Remove(a);
                    }
                }

                //Filtro AmbTrabajo
                if (!ambTrabF.Equals(null) && !ambTrabF.Equals(Actividad.TipoActividadE.TODAS))
                {
                    foreach (Actividad a in Actividad.ListaActividades())
                    {
                        if (!a.TipoAct.Equals(ambTrabF)) lAct.Remove(a);
                    }
                }

                //Filtro Horas
                if (horas != -1)
                {
                    foreach (Actividad a in Actividad.ListaActividades())
                    {
                        if (a.NumHoras != horas) lAct.Remove(a);
                    }
                }

            }

            cargarMatchActividadesFiltro(lAct);
        }

        private void cargarMatchActividadesFiltro(List<Actividad> listAct)
        {
            panelMatch.Controls.Clear();
            panelMatch.AutoScroll = false;
            panelMatch.AutoScroll = true;
            panelMatch.RowCount = 1;
            cargarFiltrosMatch();

            CartelActividadesStandard[] actsCarteles = new CartelActividadesStandard[listAct.Count];

            int c = 0;
            foreach (Actividad act in listAct)
            {
                if (act.EstadoAct.ToString().Equals("ABIERTA"))
                {
                    actsCarteles[c] = new CartelActividadesStandard(user, act);
                    panelMatch.Controls.Add(actsCarteles[c], 0, c + 1);
                    panelMatch.RowCount = panelMatch.RowCount + 1;
                    actsCarteles[c].Location = new Point(actsCarteles[c].Location.X, (actsCarteles[c].Size.Height * c));                  
                    //BOTON SOLICITAR
                    Panel panel = (Panel)actsCarteles[c].Controls.Find("panel1", false)[0];
                    Button bSolicitar = (Button)panel.Controls.Find("bSolicitar", false)[0];
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

            pTodas.Controls.Add(panelTodas);
            panelTodas.Controls.Clear();
            panelTodas.RowCount = 1;
            cargarFiltrosTodas();

            List<Actividad> actividades = Actividad.ListaActividades(Actividad.EstadoActividadE.ABIERTA);
            CartelActividadesStandard[] actsCarteles = new CartelActividadesStandard[actividades.Count];

            int c = 0;
            foreach (Actividad act in actividades)
            {
                 actsCarteles[c] = new CartelActividadesStandard(user, act);
                 panelTodas.Controls.Add(actsCarteles[c], 0, c + 1);
                 panelTodas.RowCount = panelTodas.RowCount + 1;
                 actsCarteles[c].Location = new Point(actsCarteles[c].Location.X, (actsCarteles[c].Size.Height * c));
                //BOTON SOLICITAR
                Panel panel = (Panel)actsCarteles[c].Controls.Find("panel1", false)[0];
                Button bSolicitar = (Button)panel.Controls.Find("bSolicitar", false)[0];
                if (user.Rol.NombreRol.Equals("GESTOR"))
                {
                    bSolicitar.Visible = false;
                }
                //PROGRAMACIÓN BOTONES
                bSolicitar.Click += (sender, EventArgs) => { bSolicitar_Click(sender, EventArgs, act); };
                c++;
            }

        }

        private void cargarTodasActividadesFiltro(List<Actividad> listAct)
        {
            panelTodas.Controls.Clear();
            panelTodas.AutoScroll = false;
            panelTodas.AutoScroll = true;
            panelTodas.RowCount = 1;
            cargarFiltrosTodas();

            CartelActividadesStandard[] actsCarteles = new CartelActividadesStandard[listAct.Count];

            int c = 0;
            foreach (Actividad act in listAct)
            {
                actsCarteles[c] = new CartelActividadesStandard(user, act);
                panelTodas.Controls.Add(actsCarteles[c], 0, c + 1);
                panelTodas.RowCount = panelTodas.RowCount + 1;
                actsCarteles[c].Location = new Point(actsCarteles[c].Location.X, (actsCarteles[c].Size.Height * c));
                //Programar Solicitar
                Panel panel = (Panel)actsCarteles[c].Controls.Find("panel1", false)[0];
                Button bSolicitar = (Button)panel.Controls.Find("bSolicitar", false)[0];
                bSolicitar.Click += (sender, EventArgs) => { bSolicitar_Click(sender, EventArgs, act); };
                c++;
            }
        }

        private void cargarFiltrosTodas()
        {
            //pTodas
            CartelFiltros cFiltro = new CartelFiltros(this.user);
            panelTodas.Controls.Add(cFiltro, 0, 0);
            panelTodas.RowCount = panelTodas.RowCount + 1;

            //Pulsación Filtros
            Control panelFiltro = cFiltro.Controls.Find("panel1", false)[0]; //Panel de Filtros
            List<ComboBox> cBox = new List<ComboBox>(); //ComboBox de Filtros [Horas, Turno, TipoAct, Asig, Grado];
            DateTimePicker dtIni = new DateTimePicker(); //DateTimePicker de Filtros
            Button bFiltros = new Button(); //Button de Filtros -> Aplicar

            //Recojo los Botones
            foreach (Control cPanel in panelFiltro.Controls)
            {
                if (cPanel.GetType().ToString().Equals("System.Windows.Forms.ComboBox")) cBox.Add((ComboBox)cPanel);
                if (cPanel.GetType().ToString().Equals("System.Windows.Forms.Button")) bFiltros = (Button)cPanel;
                if (cPanel.GetType().ToString().Equals("System.Windows.Forms.DateTimePicker")) dtIni = (DateTimePicker)cPanel;
            }

            //Añadimos Parámetros para el Filtro
            bFiltros.Click += (sender, EventArgs) => { bFiltros_Click(sender, EventArgs, cBox, dtIni); };
        }

        private void bFiltros_Click(object sender, EventArgs e, List<ComboBox> cBox, DateTimePicker dtIni)
        {
            List<Actividad> lAct = Actividad.ListaActividades(Actividad.EstadoActividadE.ABIERTA);
            Grado g = null;
            Asignatura asig = null;
            Actividad.TurnoE turnoF;
            Actividad.TipoActividadE tipoActF;
            //DateTime example = new DateTime(DateTime.Today.Year+100, 1, 1);
            DateTime inicio = dtIni.Value;
            int horas = -1;

            if (cBox[0].SelectedItem != null) horas = int.Parse(cBox[0].SelectedItem.ToString());
            if (cBox[4].SelectedItem != null) g = (Grado)cBox[4].SelectedItem;
            if (cBox[3].SelectedItem != null) asig = (Asignatura)cBox[3].SelectedItem;

            Enum.TryParse<Actividad.TurnoE>(cBox[1].Text, true, out turnoF);
            Enum.TryParse<Actividad.TipoActividadE>(cBox[2].Text, true, out tipoActF);

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
            if (!turnoF.Equals(null) && !turnoF.Equals(Actividad.TurnoE.AMBAS))
            {
                foreach (Actividad a in Actividad.ListaActividades())
                {
                    if (!a.Turno.Equals(turnoF)) lAct.Remove(a);
                }
            }

            //Filtro TipoActividad
            if (!tipoActF.Equals(null) && !tipoActF.Equals(Actividad.TipoActividadE.TODAS))
            {
                foreach (Actividad a in Actividad.ListaActividades())
                {
                    if (!a.TipoAct.Equals(tipoActF)) lAct.Remove(a);
                }
            }

            //Filtro Horas
            if (horas != -1)
            {
                foreach (Actividad a in Actividad.ListaActividades())
                {
                    if (a.NumHoras != horas) lAct.Remove(a);
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

            cargarTodasActividadesFiltro(lAct);
        }

        //
        // PESTAÑA PENDIENTES -> estado= 'PENDIENTE_ACEPTACION' (SÓLO GESTOR)
        //
        private void cargarPendientesActividadesInicio()
        {
            pPendientes.Controls.Clear();
            panelPendientes.AutoScroll = false;
            panelPendientes.AutoScroll = true;
            pPendientes.Controls.Add(panelPendientes);
            panelPendientes.RowCount = 1;
            panelPendientes.Controls.Clear();

            List<Actividad> actividades = Actividad.ListaActividades(Actividad.EstadoActividadE.PENDIENTE_ACEPTACION);
            CartelPendientes[] actsCarteles = new CartelPendientes[actividades.Count];

            int c = 0;
            foreach (Actividad act in actividades)
            {
                actsCarteles[c] = new CartelPendientes(user, act);
                panelPendientes.Controls.Add(actsCarteles[c], 0, c);
                panelPendientes.RowCount = panelPendientes.RowCount + 1;
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
            //this.Visible = false;
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

            if (emCierreDialog == DialogResult.Yes) act.BorrarActividad();
            cargarRevisionActividadesInicio();
            cargarPendientesActividadesInicio();
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
            pRevision.Controls.Clear();
            panelRevision.AutoScroll = false;
            panelRevision.AutoScroll = true;
            pRevision.Controls.Add(panelRevision);
            panelRevision.RowCount = 1;
            panelRevision.Controls.Clear();

            //ORDEN -> PRIMERO LAS QUE TIENE QUE DECIDIR SI ES VIABLE
            //      -> DESPUÉS, LAS QUE TIENE QUE REVISAR
            //      -> POR ÚLTIMO, LAS QUE TIENE QUE ESPERAR PARA VER (revisión en el otro lado)

            int c = 0;
            cargarAceptadasGestor(c); //Carga las Actividades recién aceptadas por el gestor
            c = panelRevision.Controls.Count;

            //Listas de Actividades en Negociación
            List<Actividad> actNegPDI = Actividad.ListaActividades(Actividad.EstadoActividadE.NEGOCIACION_PDI);
            List<Actividad> actNegONG = Actividad.ListaActividades(Actividad.EstadoActividadE.NEGOCIACION_ONG);
            List<Actividad> actNegCAN = Actividad.ListaActividades(Actividad.EstadoActividadE.NEGOCIACION_CANCELADA);
            List<Actividad> actPenGestor = Actividad.ListaActividades(Actividad.EstadoActividadE.PENDIENTE_ACEPTACION);

            if (user.Rol.NombreRol.Equals("PDI"))
            {
                cargarRevisionPDI(c, actNegPDI, actNegONG);
            }
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
                Console.WriteLine("ActsGestor: " + actAcGestor);
                foreach (Actividad act in actAcGestor)
                {

                    if (act.Responsable.Equals(user))
                    {
                        carAcGestor[c] = new CartelPendientes(user, act);
                        panelRevision.Controls.Add(carAcGestor[c], 0, c);
                        panelRevision.RowCount = panelRevision.RowCount + 1;
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
                    panelRevision.Controls.Add(carNegPDI[c2], 0, c);
                    panelRevision.RowCount = panelRevision.RowCount + 1;
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
                    panelRevision.Controls.Add(carNegONG[c2], 0, c);
                    panelRevision.RowCount = panelRevision.RowCount + 1;
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
                    panelRevision.Controls.Add(carPenGestor[c2], 0, c);
                    panelRevision.RowCount = panelRevision.RowCount + 1;
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
                    panelRevision.Controls.Add(carNegCancelada[c2], 0, c);
                    panelRevision.RowCount = panelRevision.RowCount + 1;
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
                    panelRevision.Controls.Add(carNegONG[c2], 0, c);
                    panelRevision.RowCount = panelRevision.RowCount + 1;
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
                    panelPendientes.Controls.Add(carNegPDI[c2], 0, c);
                    panelPendientes.RowCount = panelPendientes.RowCount + 1;
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
            cargarTodasActividadesInicio();
        }

        private void bRevisarRevGestor_Click(object sender, EventArgs eventArgs, Actividad act)
        {
            VerActividadRevision actRevision = new VerActividadRevision(user,act);
            actRevision.ShowDialog();
            cargarRevisionActividadesInicio();
            cargarTodasActividadesInicio();
            cargarMisActividadesInicio();
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
            cargarTodasActividadesInicio();
            cargarMisActividadesInicio();
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
            cargarTodasActividadesInicio();
            cargarMisActividadesInicio();
        }


        //
        // PESTAÑA MIS ACTIVIDADES -> Sólo ONG (organizador) y PDI (responsable) // Sólo Actividades Abiertas y Publicadas
        //
        private void cargarMisActividadesInicio()
        {
            pMisActividades.Controls.Clear();
            panelMisActs.AutoScroll = false;
            panelMisActs.AutoScroll = true;
            pMisActividades.Controls.Add(panelMisActs);
            panelMisActs.RowCount = 1;
            panelMisActs.Controls.Clear();


            if (user.Rol.NombreRol.Equals("PDI"))
            {
                List<Actividad> actsPDI = Actividad.ListaActividades(Actividad.EstadoActividadE.ABIERTA);
                cargarMisActsPDI(actsPDI);
            }
            else
            { //ES ONG -> lo mismo que para el PDI, pero al contrario 
                List<Actividad> actsONG = Actividad.ListaActividades(Actividad.EstadoActividadE.ABIERTA);
                cargarMisActsONG(actsONG);
            }
        }

        private void cargarMisActsONG(List<Actividad> actsONG)
        {

            CartelPendientes[] carActsONG = new CartelPendientes[actsONG.Count];
            int c = 0;
            foreach (Actividad act in actsONG)
            {
                if (act.Organizador.Equals(user))
                {
                    carActsONG[c] = new CartelPendientes(user, act);
                    panelMisActs.Controls.Add(carActsONG[c], 0, c);
                    panelMisActs.RowCount = panelMisActs.RowCount + 1;
                    carActsONG[c].Location = new Point(carActsONG[c].Location.X, (carActsONG[c].Size.Height * c));
                    carActsONG[c].BackColor = Color.Orange;

                    //BOTONES GESTOR
                    Panel panel = (Panel)carActsONG[c].Controls.Find("panel1", false)[0];
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

        private void cargarMisActsPDI(List<Actividad> actsPDI)
        {
            CartelPendientes[] carActsPDI = new CartelPendientes[actsPDI.Count];
            int c = 0;
            foreach (Actividad act in actsPDI)
            {
                if (act.Responsable != null && act.Responsable.Equals(user))
                {
                    carActsPDI[c] = new CartelPendientes(user, act);
                    panelMisActs.Controls.Add(carActsPDI[c], 0, c);
                    panelMisActs.RowCount = panelMisActs.RowCount + 1;
                    carActsPDI[c].Location = new Point(carActsPDI[c].Location.X, (carActsPDI[c].Size.Height * c));
                    carActsPDI[c].BackColor = Color.Orange;

                    //BOTONES GESTOR
                    Panel panel = (Panel)carActsPDI[c].Controls.Find("panel1", false)[0];
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
            cargarMatchActividadesInicio();
            cargarTodasActividadesInicio();
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
            pActividadesInscritas.Controls.Clear();
            panelActIns.AutoScroll = false;
            panelActIns.AutoScroll = true;
            pActividadesInscritas.Controls.Add(panelActIns);
            panelActIns.RowCount = 1;
            panelActIns.Controls.Clear();

            int c = 0;

            List<Actividad_Solicitud> actSolAceptada = Actividad_Solicitud.ListaActividadesSolicitudes(user, Actividad_Solicitud.EstadoActividadSolicitudE.ACEPTADA);
            List<Actividad_Solicitud> actSolEsperaPDI = Actividad_Solicitud.ListaActividadesSolicitudes(user, Actividad_Solicitud.EstadoActividadSolicitudE.EN_ESPERA_PDI);
            List<Actividad_Solicitud> actSolEsperaONG = Actividad_Solicitud.ListaActividadesSolicitudes(user, Actividad_Solicitud.EstadoActividadSolicitudE.EN_ESPERA_ONG);
            List<Actividad_Solicitud> actSolDenegada = Actividad_Solicitud.ListaActividadesSolicitudes(user, Actividad_Solicitud.EstadoActividadSolicitudE.DENEGADA);

            cargarSolicitudesAceptadas(actSolAceptada,c);
            c = panelActIns.Controls.Count;
            cargarSolicitudesEsperaPDI(actSolEsperaPDI,c);
            c = panelActIns.Controls.Count;
            cargarSolicitudesEsperaONG(actSolEsperaONG,c);
            c = panelActIns.Controls.Count;
            cargarSolicitudesDenegadas(actSolDenegada,c);
        }

        private void cargarSolicitudesDenegadas(List<Actividad_Solicitud> actSolDenegada, int c)
        {
            CartelActividadesStandard[] carActInsDenegada = new CartelActividadesStandard[actSolDenegada.Count];

            int c2 = 0;
            foreach (Actividad_Solicitud aS in actSolDenegada)
            {
                carActInsDenegada[c2] = new CartelActividadesStandard(user, aS.Actividad);
                panelActIns.Controls.Add(carActInsDenegada[c2], 0, c);
                panelActIns.RowCount = panelActIns.RowCount + 1;
                carActInsDenegada[c2].Location = new Point(carActInsDenegada[c2].Location.X, (carActInsDenegada[c2].Size.Height * c));
                carActInsDenegada[c2].BackColor = Color.Red;

                //BOTONES GESTOR
                Panel panel = (Panel)carActInsDenegada[c2].Controls.Find("panel1", false)[0];
                Button bCancelar = (Button)panel.Controls.Find("bSolicitar", false)[0];
                Label estado = (Label)panel.Controls.Find("lEstado", false)[0];
                estado.Text = aS.EstadoSolicitud.ToString();
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
                panelActIns.Controls.Add(carActInsEsperaONG[c2], 0, c);
                panelActIns.RowCount = panelActIns.RowCount + 1;
                carActInsEsperaONG[c2].Location = new Point(carActInsEsperaONG[c2].Location.X, (carActInsEsperaONG[c2].Size.Height * c));
                carActInsEsperaONG[c2].BackColor = Color.Violet;

                //BOTONES GESTOR
                Panel panel = (Panel)carActInsEsperaONG[c2].Controls.Find("panel1", false)[0];
                Button bCancelar = (Button)panel.Controls.Find("bSolicitar", false)[0];
                Label estado = (Label)panel.Controls.Find("lEstado", false)[0];
                estado.Text = aS.EstadoSolicitud.ToString();
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
                panelActIns.Controls.Add(carActInsEsperaPDI[c2], 0, c);
                panelActIns.RowCount = panelActIns.RowCount + 1;
                carActInsEsperaPDI[c2].Location = new Point(carActInsEsperaPDI[c2].Location.X, (carActInsEsperaPDI[c2].Size.Height * c));
                carActInsEsperaPDI[c2].BackColor = Color.Purple;

                //BOTONES GESTOR
                Panel panel = (Panel)carActInsEsperaPDI[c2].Controls.Find("panel1", false)[0];
                Button bCancelar = (Button)panel.Controls.Find("bSolicitar", false)[0];
                Label estado = (Label)panel.Controls.Find("lEstado", false)[0];
                estado.Text = aS.EstadoSolicitud.ToString();
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
                panelActIns.Controls.Add(carActInsAceptada[c2], 0, c);
                panelActIns.RowCount = panelActIns.RowCount + 1;
                carActInsAceptada[c2].Location = new Point(carActInsAceptada[c2].Location.X, (carActInsAceptada[c2].Size.Height * c));
                carActInsAceptada[c2].BackColor = Color.Green;

                //BOTONES
                Panel panel = (Panel)carActInsAceptada[c2].Controls.Find("panel1", false)[0];
                Button bCancelar = (Button)panel.Controls.Find("bSolicitar", false)[0];
                Label estado = (Label)panel.Controls.Find("lEstado", false)[0];
                estado.Text = aS.EstadoSolicitud.ToString();
                bCancelar.Visible = false;


                c++;
                c2++;
            }
        }


        //
        // MÉTODOS EXTRA
        //
        private void bLogout_Click(object sender, EventArgs e)
        {
            crearCierreSesion();
        }

        private void crearCierreSesion()
        {
            DialogResult emCierreDialog;
            string mensaje = "¿Quieres cerrar la sesión actual?";
            string caption = "¡AVISO!";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            emCierreDialog = MessageBox.Show(mensaje, caption, buttons);

            if (emCierreDialog == DialogResult.Yes) this.Close();
        }

        private void lPerfil_Click(object sender, EventArgs e)
        {
            this.GoPerfilUsuario();
        }

        private void GoPerfilUsuario()
        {

            if (user.Rol.NombreRol.Equals("ONG"))
            {
                FPerfilONG pagONG = new FPerfilONG(user);
                this.Visible = false;
                pagONG.ShowDialog();
            }
            else if(user.Rol.NombreRol.Equals("PAS"))
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

            if(user.Email.Trim().Equals(""))
            {
                this.Close();
            }
            else
            {
                this.Visible = true;
            }
        }

        private void lNewAct_Click(object sender, EventArgs e)
        {
            goNuevaActividad();
        }

        private void goNuevaActividad()
        {
            NuevaActividad newAct = new NuevaActividad(user);
            this.Visible = false;
            newAct.ShowDialog();
            this.Visible = true;
            cargarRevisionActividadesInicio();
        }

        private void lMensajes_Click(object sender, EventArgs e)
        {
            //this.goBandeja();
        }

        private void goBandeja()
        {
            //BandejaMensajes msg = new BandejaMensajes(user);
            this.Visible = false;
            //msg.showDialog();
            this.Visible = true;
        }
    }
}
