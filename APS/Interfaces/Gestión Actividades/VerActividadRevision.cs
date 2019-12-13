﻿using APS.Mapeo;
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

            //Mostrar Imagen
            if(actividad.Imagen != null)
            {
                pictureBox1.Image = actividad.Imagen;
            }
            if (actividad.EstadoAct.ToString().Equals("NEGOCIACION_CANCELADA"))
            {
                btnAceptarRevision.Visible = false;
                btnNegociarRevision.Visible = false;
            }
            else
            {
                bSubirRevision.Visible = false;
            }
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

        private void btnAceptarRevision_Click(object sender, EventArgs e)
        {
            actividad.EstadoAct = Actividad.EstadoActividadE.ABIERTA;
            //Mostrar la actividad en Todas
            //Borrar la actividad de la pantalla En Revisión del PDI
            //Mostrar la actividad en la pantalla de Mis Actividades del PDI
            //Borrar la actividad de la pantalla En Revisión de la ONG
            //Mostrar la actividad en la pantalla de Mis Actividades de la ONG
            //Mandar un mensaje a la ONG de que su actividad ha sido aceptada
            this.Close();
        }

        private void bSubirRevision_Click(object sender, EventArgs e)
        {
            tNumHorasRevision.Text = "";
            tNumPlazasRevision.Text = "";
            listTurnoRevision.SelectedItem = null;
            NegociarActividad negAct = new NegociarActividad(user, actividad);
            negAct.ShowDialog();
            this.Close();
        }
    }
}
