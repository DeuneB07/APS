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

            //this.gradosTableAdapter.Fill(this.wePassDataSet.Grados);
            //this.actividadesTableAdapter.Fill(this.wePassDataSet.Actividades);

            cargarMatchActividadesInicio();
            cargarTodasActividadesInicio();
            cargarPendientesActividadesInicio();
            cargarRevisionActividadesInicio();

            //cargarMisActividades();
            //cargarActividadesInscritas();
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
                        c++;
                    }
                }
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

            if (user.Rol.NombreRol.Equals("PDI"))
            {
                cargarRevisionPDI(c, actNegPDI, actNegONG);
            }
            else
            { //ES ONG -> lo mismo que para el PDI, pero al contrario 
                cargarRevisionONG(c, actNegPDI, actNegONG);
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

            foreach (Actividad act in actNegPDI)
            {
                if (act.Responsable.Equals(user))
                {
                    carNegPDI[c] = new CartelPendientes(user, act);
                    panelRevision.Controls.Add(carNegPDI[c], 0, c);
                    panelRevision.RowCount = panelRevision.RowCount + 1;
                    carNegPDI[c].Location = new Point(carNegPDI[c].Location.X, (carNegPDI[c].Size.Height * c));
                    carNegPDI[c].BackColor = Color.Green;

                    //BOTONES GESTOR
                    Panel panel = (Panel)carNegPDI[c].Controls.Find("panel1", false)[0];
                    Button bAceptar = (Button)panel.Controls.Find("bRevisar", false)[0];
                    Button bRechazar = (Button)panel.Controls.Find("bRechazar", false)[0];

                    //PROGRAMACIÓN BOTONES
                    bAceptar.Click += (sender, EventArgs) => { bRevisarRevPDI_Click(sender, EventArgs, act); };
                    bRechazar.Click += (sender, EventArgs) => { bRechazarRevPDI_Click(sender, EventArgs, act); };
                    c++;
                }
            }

            //Ahora Carga Las Actividades en revisión por ONGs
            foreach (Actividad act in actNegONG)
            {
                if (act.Responsable.Equals(user))
                {
                    carNegONG[c] = new CartelPendientes(user, act);
                    panelRevision.Controls.Add(carNegONG[c], 0, c);
                    panelRevision.RowCount = panelRevision.RowCount + 1;
                    carNegONG[c].Location = new Point(carNegONG[c].Location.X, (carNegONG[c].Size.Height * c));
                    carNegONG[c].BackColor = Color.Red;

                    //BOTONES GESTOR
                    Panel panel = (Panel)carNegONG[c].Controls.Find("panel1", false)[0];
                    Button bAceptar = (Button)panel.Controls.Find("bRevisar", false)[0];
                    Button bRechazar = (Button)panel.Controls.Find("bRechazar", false)[0];

                    //Ponemos en invisible los botones, pues no es su turno
                    bAceptar.Visible = false;
                    bRechazar.Visible = false;

                    c++;
                }
            }
        }

        private void cargarRevisionONG(int c, List<Actividad> actNegPDI, List<Actividad> actNegONG)
        {
            
            //Carteles que Usaremos
            CartelPendientes[] carNegPDI = new CartelPendientes[actNegPDI.Count];
            CartelPendientes[] carNegONG = new CartelPendientes[actNegONG.Count];

            foreach (Actividad act in actNegONG)
            {
                if (act.Organizador.Equals(user))
                {
                    carNegONG[c] = new CartelPendientes(user, act);
                    panelRevision.Controls.Add(carNegONG[c], 0, c);
                    panelRevision.RowCount = panelRevision.RowCount + 1;
                    carNegONG[c].Location = new Point(carNegONG[c].Location.X, (carNegONG[c].Size.Height * c));
                    carNegONG[c].BackColor = Color.Green;

                    //BOTONES GESTOR
                    Panel panel = (Panel)carNegONG[c].Controls.Find("panel1", false)[0];
                    Button bAceptar = (Button)panel.Controls.Find("bRevisar", false)[0];
                    Button bRechazar = (Button)panel.Controls.Find("bRechazar", false)[0];

                    //PROGRAMACIÓN BOTONES
                    bAceptar.Click += (sender, EventArgs) => { bRevisarRevONG_Click(sender, EventArgs, act); };
                    bRechazar.Click += (sender, EventArgs) => { bRechazarRevONG_Click(sender, EventArgs, act); };

                    c++;
                }
            }

            //Ahora las Actividades del PDI
            foreach (Actividad act in actNegPDI)
            {
                if (act.Organizador.Equals(user))
                {
                    carNegPDI[c] = new CartelPendientes(user, act);
                    panelPendientes.Controls.Add(carNegPDI[c], 0, c);
                    panelPendientes.RowCount = panelPendientes.RowCount + 1;
                    carNegPDI[c].Location = new Point(carNegPDI[c].Location.X, (carNegPDI[c].Size.Height * c));
                    carNegPDI[c].BackColor = Color.Red;

                    //BOTONES GESTOR
                    Panel panel = (Panel)carNegPDI[c].Controls.Find("panel1", false)[0];
                    Button bAceptar = (Button)panel.Controls.Find("bRevisar", false)[0];
                    Button bRechazar = (Button)panel.Controls.Find("bRechazar", false)[0];

                    //PROGRAMACIÓN BOTONES
                    bAceptar.Visible = false;
                    bRechazar.Visible = false;

                    c++;
                }
            }
        }

        //PROGRAMACIÓN BOTONES
          // -> PDI debe Aceptar/Rechazar Actividad Entregada por Gestor
        private void bRechazarRevGestor_Click(object sender, EventArgs eventArgs, Actividad act)
        {
            throw new NotImplementedException();
        }

        private void bRevisarRevGestor_Click(object sender, EventArgs eventArgs, Actividad act)
        {
            throw new NotImplementedException();
        }

        // -> PDI debe Aceptar/Rechazar Actividad en Negociación con ONG
        private void bRechazarRevPDI_Click(object sender, EventArgs eventArgs, Actividad act)
        {
            throw new NotImplementedException();
        }

        private void bRevisarRevPDI_Click(object sender, EventArgs eventArgs, Actividad act)
        {
            throw new NotImplementedException();
        }

        // -> ONG debe Aceptar/Rechazar Actividad en Negociación con PDI
        private void bRechazarRevONG_Click(object sender, EventArgs eventArgs, Actividad act)
        {
            throw new NotImplementedException();
        }

        private void bRevisarRevONG_Click(object sender, EventArgs eventArgs, Actividad act)
        {
            throw new NotImplementedException();
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
                this.Visible = true;
            }
            else if(user.Rol.NombreRol.Equals("PAS"))
            {
                FPerfilPAS pagPAS = new FPerfilPAS(user);
                this.Visible = false;
                pagPAS.ShowDialog();
                this.Visible = true;
            }
            else
            {
                FPerfilUsuario pagina = new FPerfilUsuario(user);
                this.Visible = false;
                pagina.ShowDialog();
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
        }

       private void lMensajes_Click(object sender, EventArgs e)
        {
            this.goBandeja();
        }

        private void goBandeja()
        { 
            BandejaMensajes msg = new BandejaMensajes(user);
            this.Visible = false;
            msg.ShowDialog();
            this.Visible = true;
        }
    }
}
