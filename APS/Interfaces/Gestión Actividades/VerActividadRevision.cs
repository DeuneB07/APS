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
    }
}
