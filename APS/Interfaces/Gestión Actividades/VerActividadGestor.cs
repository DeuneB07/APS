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
using static APS.Mapeo.Actividad;

namespace APS.Interfaces.Gestión_Actividades
{
    public partial class VerActividadGestor : Form
    {
        private Usuario user;
        private Actividad actividad;

        public VerActividadGestor(Usuario user, Actividad actividad)
        {
            InitializeComponent();
            this.user = user;
            this.actividad = actividad;
            this.Text = "Actividad " + actividad.NombreAct;
            tOrganizador.Text = actividad.Organizador.Nombre;
            tNombreAct.Text = actividad.NombreAct;
            tDescripcion.Text = actividad.DescAct;
            tNumPlazas.Text = actividad.NumPlazas.ToString();
            tNumHoras.Text = actividad.NumHoras.ToString();
            dateTimePickerFechaIni.Value = actividad.FechaInicio;
            dateTimePickerFechaFin.Value = actividad.FechaFin;
            tLugar.Text = actividad.Lugar;
            listTurno.Text = actividad.Turno.ToString();
            listAmbito.Text = actividad.AmbitoTrabajo.ToString();
            listTrabajo.Text = actividad.TipoTrabajo.ToString();

            if (actividad.Imagen != null)
            {
                pictureBox.Image = actividad.Imagen;
            }
            if (!user.Rol.NombreRol.Equals("GESTOR") || actividad.EstadoAct.ToString().Equals("ABIERTA"))
            {
                btnGestionar.Visible = false;
                btnRechazar.Visible = false;
                btnCancelar.Text = "Atrás";
            }

            cargarTurnos();
            cargarTipoTrabajo();
            cargarAmbitoTrabajo();
        }

        private void cargarTurnos()
        {
            foreach (TurnoE t in Enum.GetValues(typeof(TurnoE)))
            {
                listTurno.Items.Add(t);
            }
        }

        private void cargarTipoTrabajo()
        {
            foreach (TipoTrabajoE tTrab in Enum.GetValues(typeof(TipoTrabajoE)))
            {
                listTrabajo.Items.Add(tTrab);
            }
        }

        private void cargarAmbitoTrabajo()
        {
            foreach (AmbitoTrabajoE tAmb in Enum.GetValues(typeof(AmbitoTrabajoE)))
            {
                listAmbito.Items.Add(tAmb);
            }
        }

        private void btnGestionar_Click(object sender, EventArgs e)
        {
            GestorGestionaActividad gestionaActividad = new GestorGestionaActividad(user, actividad);
            this.Visible = false;
            gestionaActividad.ShowDialog();
            this.Close();
        }

        private void btnRechazar_Click(object sender, EventArgs e)
        {
            actividad.BorrarActividad();
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
