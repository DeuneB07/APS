using APS.Interfaces.Gestión_Actividades;
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
            if (!user.AccesoPantalla("MATCH")) tabUser.Controls.Remove(this.pMatch);
            if (!user.AccesoPantalla("TODAS")) tabUser.Controls.Remove(this.pTodas);
            if (!user.AccesoPantalla("PROYECTOS")) tabUser.Controls.Remove(this.pProyectos);
            if (!user.AccesoPantalla("VALORACION")) tabUser.Controls.Remove(this.pValoracion);
            if (!user.AccesoPantalla("PENDIENTES")) tabUser.Controls.Remove(this.pPendientes);
            if (!user.AccesoPantalla("REVISION")) tabUser.Controls.Remove(this.pRevision);
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
            
            cargarPendientesActividades();
            cargarRevisionActividades();
            //cargarMisActividades();
            //cargarActividadesInscritas();
        }

        //
        // PESTAÑA MATCH
        //
        private void cargarMatchActividadesInicio()
        {
            Console.WriteLine("HOLA0");
            pMatch.Controls.Add(panelMatch);
            cargarFiltrosMatch();
            Console.WriteLine("HOLA1");

            List<Actividad> actividades = Actividad.ListaActividades(Actividad.EstadoActividadE.ABIERTA);
            CartelActividadesStandard[] actsCarteles = new CartelActividadesStandard[actividades.Count];
            Console.WriteLine("HOLA3");

            int c = 0;
            foreach (Actividad act in actividades)
            {
                Console.WriteLine("HOLAFOR1");
                foreach(Asignatura asig in user.Asignaturas)
                {
                    Console.WriteLine("HOLAFOR2");
                    if (act.Asignatura != null && act.Asignatura.Equals(asig))
                    {
                        Console.WriteLine("HOLAIF");
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


            cargarTodasActividadesFiltro(lAct);
        }

        //
        // PESTAÑA PENDIENTES -> estado= 'PENDIENTE_ACEPTACION' (SÓLO GESTOR)
        //
        private void cargarPendientesActividades()
        {
            List<Actividad> actividades = new List<Actividad>();
            foreach (Actividad act in Actividad.ListaActividades(Actividad.EstadoActividadE.PENDIENTE_ACEPTACION))
            {
                actividades.Add(act);
            }
            this.dataGridViewPendientes.DataSource = actividades;
        }

        private void cargarRevisionActividades()
        {
            List<Actividad> actividades = new List<Actividad>();
            Rol rol = user.Rol;
            if (rol.NombreRol.Equals("PDI"))
            {
                foreach(Actividad act in Actividad.ListaActividades(Actividad.EstadoActividadE.NEGOCIACION_ONG))
                {
                    if (act.Responsable.Email.Equals(user.Email)) actividades.Add(act);
                }
                foreach (Actividad act in Actividad.ListaActividades(Actividad.EstadoActividadE.NEGOCIACION_PDI))
                {
                    if (act.Responsable.Email.Equals(user.Email)) actividades.Add(act);
                }
                foreach (Actividad act in Actividad.ListaActividades(Actividad.EstadoActividadE.ACEPTADA_GESTOR))
                {
                    if (act.Responsable.Email.Equals(user.Email)) actividades.Add(act);
                }
                actividades.Sort();
                this.dataGridViewRevision.DataSource = actividades;
            } 
            else if (rol.NombreRol.Equals("ONG"))
            {
                foreach (Actividad act in Actividad.ListaActividades(Actividad.EstadoActividadE.NEGOCIACION_PDI))
                {
                    if (act.Organizador.Email.Equals(user.Email)) actividades.Add(act);
                }
                foreach (Actividad act in Actividad.ListaActividades(Actividad.EstadoActividadE.NEGOCIACION_ONG))
                {
                    if (act.Organizador.Email.Equals(user.Email)) actividades.Add(act);
                }
                actividades.Sort();
                this.dataGridViewRevision.DataSource = actividades;
            }

            /*if (rol.NombreRol.Equals("PDI") || rol.NombreRol.Equals("ONG"))
            {
                foreach (Actividad act in Actividad.ListaActividades(Actividad.EstadoActividadE.NEGOCIACION_ONG))
                {
                    if(act.Organizador.Email.Equals(user.Email) || act.Responsable.Email.Equals(user.Email)) actividades.Add(act);
                }
                foreach (Actividad act in Actividad.ListaActividades(Actividad.EstadoActividadE.NEGOCIACION_PDI))
                {
                    if (act.Organizador.Email.Equals(user.Email) || act.Responsable.Email.Equals(user.Email)) actividades.Add(act);
                }
                actividades.Sort();
                this.dataGridViewRevision.DataSource = actividades;
            }*/
        }


        //
        // PESTAÑA REVISIÓN -> estado(s) = 'ACEPTADA_GESTOR'(PDI) -> LA VE EL PDI RESPONSABLE ASIGNADO
        //                                  \ 'NEGOCIAR_PDI'(PDI, ONG) -> LA VE EL PDI ASIGNADO (INTERACTÚA) Y LA ONG (NO HACE NADA)
        //                                  \'NEGOCIAR_ONG'(PDI, ONG) -> LA VE EL ONG (INTERACTÚA) Y EL PDI RESPONSABLE (NO HACE NADA)
        //                  
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
            FPerfil pagina = new FPerfil(user);
            this.Visible = false;
            pagina.ShowDialog();
            this.Visible = true;
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

        private void PaginaPrincipal_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'wePassDataSet.Actividades' Puede moverla o quitarla según sea necesario.
            //this.actividadesTableAdapter.Fill(this.wePassDataSet.Actividades);
            // TODO: esta línea de código carga datos en la tabla 'wePassDataSet.Grados' Puede moverla o quitarla según sea necesario.
            //this.gradosTableAdapter.Fill(this.wePassDataSet.Grados);

        }

        private void listGrados_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*
            Grado g = (Grado)listGrados.SelectedItem;
            
            foreach(Asignatura a in Asignatura.ListaAsignaturas(g))
            {

            }*/
        }

        private void bGestionar_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.dataGridViewPendientes.SelectedRows.Count == 0)
                {
                    throw new Exception("Ninguna actividad seleccionada");
                }
                int id = int.Parse(this.dataGridViewPendientes.SelectedRows[0].Cells[0].Value.ToString());
                Actividad pendiente = new Actividad(id);
                GestorGestionaActividad gestorGestionaActividad = new GestorGestionaActividad(user, pendiente);
                this.Visible = false;
                gestorGestionaActividad.ShowDialog();
                this.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridViewPendientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            int id = int.Parse(this.dataGridViewPendientes.Rows[i].Cells[0].Value.ToString());
            Actividad pendiente = new Actividad(id);
            VerActividadGestor verActividad = new VerActividadGestor(user, pendiente);
            this.Visible = false;
            verActividad.ShowDialog();
            this.Visible = true;
            cargarPendientesActividades();
        }

        private void dataGridViewRevision_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            int id = int.Parse(this.dataGridViewRevision.Rows[i].Cells[0].Value.ToString());
            Actividad revision = new Actividad(id);
            Rol rol = user.Rol;

            //VER ACTIVIDAD A REVISAR POR EL PDI
            if (rol.NombreRol.Equals("PDI") && revision.EstadoAct.Equals(Actividad.EstadoActividadE.NEGOCIACION_PDI))
            {
                VerActividadRevision verActividad = new VerActividadRevision(user, revision);
                this.Visible = false;
                verActividad.ShowDialog();
                this.Visible = true;
            }
            //VER ACTIVIDAD A REVISAR POR LA ONG
            else if (revision.EstadoAct.Equals(Actividad.EstadoActividadE.NEGOCIACION_ONG))
            {
                VerActividadRevision verActividad = new VerActividadRevision(user, revision);
                this.Visible = false;
                verActividad.ShowDialog();
                this.Visible = true;
            }
            
            //cargarTodasActividades();
            cargarRevisionActividades();
        }
    }
}
