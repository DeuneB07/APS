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
    public partial class VerActividadAbierta : Form
    {
        private Usuario user;
        private Actividad actividad;

        public VerActividadAbierta(Usuario user, Actividad actividad)
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
            listAmbito.Text = actividad.AmbitoTrabajo.Ambito_Trabajo;
            listTrabajo.Text = actividad.TipoTrabajo.Tipo_Trabajo;

            if (actividad.Imagen != null)
            {
                pictureBox.Image = actividad.Imagen;
            }

            //Panel 2
            comboTipoAct.Text = actividad.TipoAct.ToString();
            if (!actividad.TipoAct.ToString().Equals(Actividad.TipoActividadE.VOLUNTARIADO.ToString()))
            {
                comboGrado.Text = actividad.Grado.NombreGrado;
                comboAsignatura.Text = actividad.Asignatura.NombreAsig;
                comboResponsable.Text = actividad.Responsable.Email;

            }
            foreach (Competencia c in actividad.Competencias)
            {
                listCompetencias.Items.Add(c.NombreComp);
            }
            textEstadoAct.Text = actividad.EstadoAct.ToString();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
