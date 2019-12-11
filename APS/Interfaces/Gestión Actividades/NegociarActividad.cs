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

namespace APS.Interfaces.Gestión_Actividades
{
    public partial class NegociarActividad : Form
    {
        private Usuario user;
        private Actividad actividad;
        public NegociarActividad(Usuario user, Actividad actividad)
        {
            InitializeComponent();
            this.user = user;
            this.actividad = actividad;
            this.Text = "Actividad " + actividad.NombreAct;
            tOrganizadorNegociar.Text = actividad.Organizador.Nombre;
            tNombreActNegociar.Text = actividad.NombreAct;
            tDescripcionNegociar.Text = actividad.DescAct;
            tNumPlazasNegociar.Text = actividad.NumPlazas.ToString();
            tNumHorasNegociar.Text = actividad.NumHoras.ToString();
            dateTimePickerFechaIniNegociar.Value = actividad.FechaInicio;
            dateTimePickerFechaFinNegociar.Value = actividad.FechaFin;
            tLugarNegociar.Text = actividad.Lugar;
            listTurnoNegociar.Text = actividad.Turno.ToString();
            listAmbitoNegociar.Text = actividad.AmbitoTrabajo.ToString();
            listTrabajoNegociar.Text = actividad.TipoTrabajo.ToString();
        }

        private void btnCancelarNegociar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptarNegociar_Click(object sender, EventArgs e)
        {   
            APS.Mapeo.Actividad.TurnoE turno;
            if (!tNumPlazasNegociar.Text.Equals("") && !tNumPlazasNegociar.Text.Equals(actividad.NumPlazas.ToString())) actividad.NumPlazas = int.Parse(tNumPlazasNegociar.Text);
            if (!tNumHorasNegociar.Text.Equals("") && !tNumHorasNegociar.Text.Equals(actividad.NumHoras.ToString())) actividad.NumHoras = int.Parse(tNumHorasNegociar.Text);
            Enum.TryParse<APS.Mapeo.Actividad.TurnoE>(listTurnoNegociar.Text, true, out turno);
            if (!listTurnoNegociar.Text.Equals("") && !listTurnoNegociar.Text.Equals(actividad.Turno.ToString())) actividad.Turno = turno;
            if (user.ToString().Equals("PDI"))
            {
                actividad.EstadoAct = Actividad.EstadoActividadE.NEGOCIACION_ONG;
            } else
            {
                actividad.EstadoAct = Actividad.EstadoActividadE.NEGOCIACION_PDI;
            }
            this.Close();
        }
    }
}
