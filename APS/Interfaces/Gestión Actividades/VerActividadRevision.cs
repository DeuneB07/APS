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
    public partial class VerActividadRevision : Form
    {
        private Usuario user;
        private Actividad actividad;
        public VerActividadRevision(Usuario user, Actividad actividad)
        {
            InitializeComponent();
            this.user = user;
            this.actividad = actividad;
            this.Text = "Actividad " + actividad.NombreAct;
            tOrganizadorRevision.Text = actividad.Organizador.Nombre;
            tNombreActRevision.Text = actividad.NombreAct;
            tDescripcionRevision.Text = actividad.DescAct;
            tNumPlazasRevision.Text = actividad.NumPlazas.ToString();
            tNumHorasRevision.Text = actividad.NumHoras.ToString();
            dateTimePickerFechaIniRevision.Value = actividad.FechaInicio;
            dateTimePickerFechaFinRevision.Value = actividad.FechaFin;
            tLugarRevision.Text = actividad.Lugar;
            listTurnoRevision.Text = actividad.Turno.ToString();
            listAmbitoRevision.Text = actividad.AmbitoTrabajo.ToString();
            listTrabajoRevision.Text = actividad.TipoTrabajo.ToString();
        }

        private void btnCancelarRevision_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNegociarRevision_Click(object sender, EventArgs e)
        {
            NegociarActividad negociarActividad = new NegociarActividad(user, actividad);
            this.Visible = false;
            negociarActividad.ShowDialog();
            this.Close();
        }

        private void btnRechazarRevision_Click(object sender, EventArgs e)
        {
            if (actividad.EstadoAct.Equals("ACEPTADA_GESTOR"))
            {
                actividad.TipoAct = Actividad.TipoActividadE.VOLUNTARIADO;
                actividad.EstadoAct = Actividad.EstadoActividadE.ABIERTA;
                //Mostrar la actividad en Todas
                //Borrar la actividad de la pantalla de En Revisión del PDI
                //Mandar un mensaje a la ONG diciendo que su actividad ha sido rechazada por el profesor y se ha subido como Voluntariado
            } else //Viene de ser negociada por la ONG
            {
                actividad.TipoAct = Actividad.TipoActividadE.VOLUNTARIADO;
                actividad.EstadoAct = Actividad.EstadoActividadE.ABIERTA;
                //Mandar actividad con algunos campos vacios a la ONG para que la rellene otra vez
                //Borrar actividad de la pantalla de En Revisión del PDI
                //Enviar mensaje a la ONG diciendo que la negociación a sido denegada y que deberá rellenar los datos de la actividad de nuevo para poder subirla como voluntariado
            }
        }

        private void btnAceptarRevision_Click(object sender, EventArgs e)
        {
            actividad.EstadoAct = Actividad.EstadoActividadE.ABIERTA;
            //Mostrar la actividad en Todas
            //Borrar la actividad de la pantalla En Revisión del PDI
            //Mostrar la actividad en la pantalla de Mis Actividades del PDI
            //Borrar la actividad de la pantalla En Revisión de la ONG
            //Mostrar la actividad en la pantalla de Mis Actividades de la ONG
            //Mandar un mensaje a la ONG de que su actividad ha sido aceptada
        }
    }
}
