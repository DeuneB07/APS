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

namespace APS.Interfaces.Personalizados
{
    public partial class Filtros : Form
    {
        CartelFiltros2 cartel;
        public List<Actividad> listaFiltrada;

        public Filtros(CartelFiltros2 cartel)
        {
            InitializeComponent();
            this.cartel = cartel;
            CargarGrados();
            CargarCompetencias();
            listaFiltrada = Actividad.ListaActividades(Actividad.EstadoActividadE.ABIERTA);
            dateTimePickerInicio.Value = DateTimePicker.MinimumDateTime;
            dateTimePickerFin.Value = DateTimePicker.MaximumDateTime;
            listComp1.DisplayMember = "nombreComp";
            listComp2.DisplayMember = "nombreComp";
        }

        private void CargarCompetencias()
        {
            listComp1.Items.Clear();
            foreach(Competencia c in Competencia.ListaCompetencias())
            {
                listComp1.Items.Add(c);
            }
        }

        private void CargarGrados()
        {
            comboGrado.Items.Clear();
            foreach(Grado g in Grado.ListaGrados())
            {
                comboGrado.Items.Add(g);
            }
            comboGrado.DisplayMember = "nombreGrado";
        }

        private void comboGrado_SelectedIndexChanged(object sender, EventArgs e)
        {
            Grado g = (Grado) comboGrado.SelectedItem;
            CargarAsignaturas(g);
        }

        private void CargarAsignaturas(Grado g)
        {
            comboAsig.Items.Clear();
            foreach(Asignatura a in Asignatura.ListaAsignaturas(g))
            {
                comboAsig.Items.Add(a);
            }
            comboAsig.DisplayMember = "nombreAsig";
        }

        private void btnAñadirComp_Click(object sender, EventArgs e)
        {
            foreach(Object o in listComp1.SelectedItems)
            {
                if (!listComp2.Items.Contains(o))
                {
                    listComp2.Items.Add(o);
                }
            }
        }

        private void btnQuitarComp_Click(object sender, EventArgs e)
        {
            List<Object> aux = new List<Object>();
            foreach(Object o in listComp2.SelectedItems)
            {
                aux.Add(o);
            }

            foreach(Object o in aux)
            {
                listComp2.Items.Remove(o);
            }

        }

        private void trackBarHoras_Scroll(object sender, EventArgs e)
        {
            txtNumHoras.Text = trackBarHoras.Value.ToString();
        }

        private void txtNumHoras_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int value = int.Parse(txtNumHoras.Text);
                trackBarHoras.Value = value;
            }
            catch
            {
                MessageBox.Show("Valor incorrecto o fuera de rango");
            }
        }

        private void Cerrar_Click(object sender, EventArgs e)
        {
            ActualizarFiltro();
            this.Hide();
        }

        public void ActualizarFiltro()
        {
            listaFiltrada = Actividad.ListaActividades(Actividad.EstadoActividadE.ABIERTA);
            cartel.flowShowFiltro.Controls.Clear();

            Filtrar_TipoActividad();
            Filtrar_Asignatura();
            Filtrar_Competencias();
            Filtrar_Turno();
            Filtrar_Horas();
            Filtrar_Fecha();
            Filtrar_AmbitoTrabajo();
            Filtrar_TipoTrabajo();
        }

        private void Filtrar_TipoActividad()
        {
            cartel.filtroTipoAct.Visible = false;
            if(checkFormacion.Checked || checkInvestigacion.Checked || checkVoluntariado.Checked)
            {
                cartel.filtroTipoAct.Visible = true;
                cartel.flowShowFiltro.Controls.Add(cartel.filtroTipoAct);

                List<Actividad> aux = new List<Actividad>();
                if (checkFormacion.Checked)
                {
                    aux.AddRange(Actividad.ListaActividades(Actividad.TipoActividadE.FORMACION));
                }
                if (checkInvestigacion.Checked)
                {
                    aux.AddRange(Actividad.ListaActividades(Actividad.TipoActividadE.INVESTIGACION));
                }
                if (checkVoluntariado.Checked)
                {
                    aux.AddRange(Actividad.ListaActividades(Actividad.TipoActividadE.VOLUNTARIADO));
                }

                var query = from act in listaFiltrada
                            where aux.Contains(act)
                            select act;
                
                listaFiltrada = new List<Actividad>();
                foreach(Actividad act in query)
                {
                    listaFiltrada.Add(act);
                }
            }
        }

        private void Filtrar_Asignatura()
        {
            cartel.filtroAsig.Visible = false;
            if(comboAsig.SelectedItem != null)
            {
                cartel.filtroAsig.Visible = true;
                cartel.flowShowFiltro.Controls.Add(cartel.filtroAsig);

                Asignatura asig = (Asignatura) comboAsig.SelectedItem;

                var query = from act in Actividad.ListaActividades(Actividad.EstadoActividadE.ABIERTA)
                            where act.Asignatura == null || !act.Asignatura.Equals(asig)
                            select act;

                foreach(Actividad act in query)
                {
                    listaFiltrada.Remove(act);
                }
            }
        }

        private void Filtrar_Competencias()
        {
            cartel.filtroComp.Visible = false;
            if (listComp2.Items.Count > 0)
            {
                cartel.filtroComp.Visible = true;
                cartel.flowShowFiltro.Controls.Add(cartel.filtroComp);

                List<Actividad> aux = new List<Actividad>();
                List<Competencia> competencias = new List<Competencia>();
                foreach(Competencia c in listComp2.Items)
                {
                    competencias.Add(c);
                }

                foreach(Actividad act in listaFiltrada)
                {
                    foreach(Competencia c in competencias)
                    {
                        if (!act.Competencias.Contains(c)) aux.Add(act);
                    }
                }

                foreach(Actividad act in aux)
                {
                    listaFiltrada.Remove(act);
                }
            }
        }

        private void Filtrar_Turno()
        {
            cartel.filtroTurno.Visible = false;
            if(checkTarde.Checked || checkMañana.Checked)
            {
                cartel.filtroTurno.Visible = true;
                cartel.flowShowFiltro.Controls.Add(cartel.filtroTurno);

                List<Actividad> aux = new List<Actividad>();
                if (checkTarde.Checked && !checkMañana.Checked)
                {
                    foreach(Actividad act in listaFiltrada)
                    {
                        if (act.Turno.Equals(Actividad.TurnoE.MAÑANA)) aux.Add(act);
                    }
                }

                if (!checkTarde.Checked && checkMañana.Checked)
                {
                    foreach (Actividad act in listaFiltrada)
                    {
                        if (act.Turno.Equals(Actividad.TurnoE.TARDE)) aux.Add(act);
                    }
                }

                foreach(Actividad act in aux)
                {
                    listaFiltrada.Remove(act);
                }

            }
        }


        private void Filtrar_Horas()
        {
            cartel.filtroHoras.Visible = false;
            if (!txtNumHoras.Text.Equals("0"))
            {
                cartel.filtroHoras.Visible = true;
                cartel.flowShowFiltro.Controls.Add(cartel.filtroHoras);

                int horas = int.Parse(txtNumHoras.Text);

                var query = from act in Actividad.ListaActividades(Actividad.EstadoActividadE.ABIERTA)
                            where act.NumHoras > horas
                            select act;

                foreach(Actividad act in query)
                {
                    listaFiltrada.Remove(act);
                }

            }
        }

        private void Filtrar_Fecha()
        {
            cartel.filtroFecha.Visible = false;
            if(dateTimePickerInicio.Value != DateTimePicker.MinimumDateTime || dateTimePickerFin.Value != DateTimePicker.MaximumDateTime)
            {
                cartel.filtroFecha.Visible = true;
                cartel.flowShowFiltro.Controls.Add(cartel.filtroFecha);

                List<Actividad> aux = new List<Actividad>();
                if(dateTimePickerInicio.Value!= DateTimePicker.MinimumDateTime)
                {
                    foreach(Actividad act in listaFiltrada)
                    {
                        if (act.FechaInicio < dateTimePickerInicio.Value) aux.Add(act);
                    }
                }
                if (dateTimePickerFin.Value != DateTimePicker.MaximumDateTime)
                {
                    foreach (Actividad act in listaFiltrada)
                    {
                        if (act.FechaFin > dateTimePickerFin.Value) aux.Add(act);
                    }
                }

                foreach(Actividad act in aux)
                {
                    listaFiltrada.Remove(act);
                }

            }
        }

        private void Filtrar_AmbitoTrabajo()
        {
            cartel.filtroAmb.Visible = false;
            if(checkInmigracion.Checked || checkSinHogar.Checked || checkPobreza.Checked || checkDiscapacidad.Checked ||
                checkTerceraEdad.Checked || checkNiños.Checked || checkAnimales.Checked || checkOtrosAmb.Checked)
            {
                cartel.filtroAmb.Visible = true;
                cartel.flowShowFiltro.Controls.Add(cartel.filtroAmb);

                List<Actividad> aux = new List<Actividad>();
                foreach(Actividad act in listaFiltrada)
                {
                    if (checkInmigracion.Checked && act.AmbitoTrabajo.Ambito_Trabajo.Equals("INMIGRACION")) aux.Add(act);
                    if (checkSinHogar.Checked && act.AmbitoTrabajo.Ambito_Trabajo.Equals("SIN_HOGAR")) aux.Add(act);
                    if (checkPobreza.Checked && act.AmbitoTrabajo.Ambito_Trabajo.Equals("POBREZA")) aux.Add(act);
                    if (checkDiscapacidad.Checked && act.AmbitoTrabajo.Ambito_Trabajo.Equals("DISCAPACIDAD")) aux.Add(act);
                    if (checkTerceraEdad.Checked && act.AmbitoTrabajo.Ambito_Trabajo.Equals("TERCERA_EDAD")) aux.Add(act);
                    if (checkNiños.Checked && act.AmbitoTrabajo.Ambito_Trabajo.Equals("NIÑOS")) aux.Add(act);
                    if (checkAnimales.Checked && act.AmbitoTrabajo.Ambito_Trabajo.Equals("ANIMALES")) aux.Add(act);
                    if (checkOtrosAmb.Checked && act.AmbitoTrabajo.Ambito_Trabajo.Equals("OTROS")) aux.Add(act);
                }

                var query = from act in Actividad.ListaActividades(Actividad.EstadoActividadE.ABIERTA)
                            where !aux.Contains(act)
                            select act;

                foreach(Actividad act in query)
                {
                    listaFiltrada.Remove(act);
                }
            }
        }

        private void Filtrar_TipoTrabajo()
        {
            cartel.filtroTipoTrab.Visible = false;
            if (checkSalud.Checked || checkEvento.Checked || checkViaje.Checked || checkInvestigacionTrabajo.Checked ||
                     checkAdministracion.Checked || checkOtrosTipo.Checked)
            {
                cartel.filtroTipoTrab.Visible = true;
                cartel.flowShowFiltro.Controls.Add(cartel.filtroTipoTrab);

                List<Actividad> aux = new List<Actividad>();
                foreach (Actividad act in listaFiltrada)
                {
                    if (checkSalud.Checked && act.TipoTrabajo.Tipo_Trabajo.Equals("SALUD")) aux.Add(act);
                    if (checkEvento.Checked && act.TipoTrabajo.Tipo_Trabajo.Equals("EVENTO")) aux.Add(act);
                    if (checkViaje.Checked && act.TipoTrabajo.Tipo_Trabajo.Equals("VIAJE")) aux.Add(act);
                    if (checkInvestigacionTrabajo.Checked && act.TipoTrabajo.Tipo_Trabajo.Equals("INVESTIGACION")) aux.Add(act);
                    if (checkAdministracion.Checked && act.TipoTrabajo.Tipo_Trabajo.Equals("ADMINISTRACION")) aux.Add(act);
                    if (checkOtrosTipo.Checked && act.TipoTrabajo.Tipo_Trabajo.Equals("OTROS")) aux.Add(act);
                }

                var query = from act in Actividad.ListaActividades(Actividad.EstadoActividadE.ABIERTA)
                            where !aux.Contains(act)
                            select act;

                foreach (Actividad act in query)
                {
                    listaFiltrada.Remove(act);
                }
            }
        }
    }
}
