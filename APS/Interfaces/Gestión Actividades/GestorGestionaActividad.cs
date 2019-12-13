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
using static APS.Mapeo.Actividad;

namespace APS.Interfaces
{
    public partial class GestorGestionaActividad : Form
    {
        private Usuario user;
        private Actividad act;
        public GestorGestionaActividad(Usuario user,Actividad act)
        {
            
            InitializeComponent();
            this.user = user;
            Usuario ong = act.Organizador;
            this.act = act;
            labelError.Text = "";

            tOrganizador.Text = act.Organizador.Nombre;
            tNombreAct.Text = act.NombreAct;
            tDescripcion.Text = act.DescAct;
            tNumPlazas.Text = act.NumPlazas.ToString();
            tNumHoras.Text = act.NumHoras.ToString();
            dateTimePickerFechaIni.Value = act.FechaInicio;
            dateTimePickerFechaFin.Value = act.FechaFin;
            tLugar.Text = act.Lugar;
            listTurno.Text = act.Turno.ToString();
            listAmbito.Text = act.AmbitoTrabajo.ToString();
            listTrabajo.Text = act.TipoTrabajo.ToString();

            cargarGrados();
            cargarAsignaturas();
            cargarResponsables();
            cargarCompetencias();
            cargarTurnos();
            cargarTipoTrabajo();
            cargarAmbitoTrabajo();
        }

        private void cargarGrados()
        {
            foreach (Grado g in Grado.ListaGrados())
            {
                comboGrado.Items.Add(g);
            }
            comboGrado.DisplayMember = "nombreGrado";
        }

        private void cargarAsignaturas()
        {
            comboAsig.Items.Clear();
            if (comboGrado.SelectedItem!=null)
            {
                Grado g = (Grado)comboGrado.SelectedItem;
                foreach (Asignatura a in Asignatura.ListaAsignaturas(g))
                {
                    comboAsig.Items.Add(a);
                }
            }
            else
            {
                foreach (Asignatura a in Asignatura.ListaAsignaturas())
                {
                    comboAsig.Items.Add(a);
                }
            }
            comboAsig.DisplayMember = "nombreAsig";
        }

        private void comboGrado_SelectedIndexChanged(object sender, EventArgs e)
        {
            cargarAsignaturas();
            cargarCompetencias();
        }

        private void cargarResponsables()
        {
            comboResponsable.Items.Clear();
            if (comboAsig.SelectedItem != null)
            {
                Asignatura a = (Asignatura)comboAsig.SelectedItem;
                foreach (Usuario u in Usuario.ListaResponsables(a))
                {
                    comboResponsable.Items.Add(u);
                }
            }
            else
            {
                foreach (Usuario u in Usuario.ListaResponsables())
                {
                    comboResponsable.Items.Add(u);
                }
            }
            comboResponsable.DisplayMember = "email";
        }

        public void cargarCompetencias()
        {
            listCompetencias.Items.Clear();
            if (comboGrado.SelectedItem != null)
            {
                Grado g = (Grado)comboGrado.SelectedItem;
                foreach(Competencia c in Competencia.ListaCompetencias(g))
                {
                    listCompetencias.Items.Add(c);
                }
            }
            else
            {
                foreach(Competencia c in Competencia.ListaCompetencias())
                {
                    listCompetencias.Items.Add(c);
                }
            }
            listCompetencias.DisplayMember = "nombreComp";
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

        private void Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Aceptar_Click(object sender, EventArgs e)
        {
            try
            {
                Grado g = (Grado)comboGrado.SelectedItem;
                Asignatura a = (Asignatura)comboAsig.SelectedItem;

                TipoActividadE tipo;
                Enum.TryParse<TipoActividadE>(comboTipoAct.SelectedItem.ToString(), true, out tipo);

                Usuario responsable = null;
                if (!tipo.ToString().Equals("VOLUNTARIADO"))
                {
                    if (comboResponsable.SelectedItem == null) throw new Exception("Debe tener un responsable");
                    responsable = (Usuario)comboResponsable.SelectedItem;
                }

                List<Competencia> comps = new List<Competencia>();
                foreach(Competencia c in listCompetencias.SelectedItems)
                {
                    comps.Add(c);
                }

                //ACTUALIZAR EN LA BD
                if(g!=null) act.Grado = g;
                if(a!= null) act.Asignatura = a;
                act.TipoAct = tipo;
                if(responsable!=null) act.Responsable = responsable;
                foreach(Competencia c in comps)
                {
                    act.AddCompetencia(c);
                }

                if (tipo.ToString().Equals("VOLUNTARIADO"))
                {
                    act.EstadoAct = EstadoActividadE.ABIERTA;
                    MessageBox.Show("Actividad gestionada correctamente.\n La actividad voluntaria pasa a formar parte de las actividades PREINICIO");
                }
                else
                {
                    act.EstadoAct = EstadoActividadE.ACEPTADA_GESTOR;
                    MessageBox.Show("Actividad gestionada correctamente.\n La actividad pasará a ser revisada por el profesor responsable.");
                }
               
                this.Close();

            }
            catch (Exception ex)
            {
                labelError.Text = ex.Message;
            }

        }

        private void comboAsig_SelectedIndexChanged(object sender, EventArgs e)
        {
            cargarResponsables();
        }

        private void comboTipoAct_SelectedIndexChanged(object sender, EventArgs e)
        {
            TipoActividadE tipo;
            Enum.TryParse<TipoActividadE>(comboTipoAct.SelectedItem.ToString(), true, out tipo);
            if (tipo.ToString().Equals("VOLUNTARIADO"))
            {
                comboResponsable.Items.Clear();
                comboResponsable.Enabled = false;
            }
            else
            {
                comboResponsable.Enabled = true;
            }
        }

    }
}
