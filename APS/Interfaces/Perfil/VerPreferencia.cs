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
    public partial class VerPreferencia : Form
    {
        Preferencia p;
        Usuario usr;
        int mod;    //0 si Viendo; 1 si Modificando

        public VerPreferencia(Preferencia p, Usuario usr) 
        {
            InitializeComponent();
            this.p = p;
            this.usr = usr;

            modificarInvisible();
            visualizarVisible();

        }

        private void cargarVisualizar()
        {
            this.Text = "Preferencia: " + p.Nombre_Preferencia;
            if (p.Grado != null) lShowGrado.Text = p.Grado.NombreGrado;
            if (p.HorasPosibles != 0) lShowHoras.Text = p.HorasPosibles.ToString();
            lShowNoun.Text = p.Nombre_Preferencia;
            lShowTipo.Text = p.TipoActividad.ToString();
            lShowTurno.Text = p.Turno.ToString();
            if (p.Asignatura != null) lShowPreferencia.Text = p.Asignatura.NombreAsig;
            lTipoTrab2.Text = p.TipoTrabajo.ToString();
            lAmbTrab2.Text = p.AmbitoTrabajo.ToString();
            cargarCompetencias();
        }

        private void cargarModificar()
        {
            cargarGrados();
            cargarAsignaturas();
            cargarTurnos();
            cargarTipoActividad();
            cargarNumeroHoras();
            cargarTipoTrabajo();
            cargarAmbitoTrabajo();
            cargarCompetencias();

            cModiGrado.SelectedItem = p.Grado;
            cModiAsig.SelectedItem = p.Asignatura;
            tModiNombre.Text = p.Nombre_Preferencia;
            if (!p.Turno.ToString().Equals("")) cModiTurno.SelectedItem = p.Turno;
            if (!p.TipoActividad.ToString().Equals("")) cModiTipoAct.SelectedItem = p.TipoActividad;
            if (!p.TipoTrabajo.ToString().Equals("")) cModiTipoTrab.SelectedItem = p.TipoTrabajo;
            if (!p.AmbitoTrabajo.ToString().Equals("")) cModAmb.SelectedItem = p.AmbitoTrabajo;
            if (p.HorasPosibles != -1) cModiHoras.SelectedItem = p.HorasPosibles;
        }

        private void cargarTurnos()
        {
            foreach (TurnoE t in Enum.GetValues(typeof(TurnoE)))
            {
                cModiTurno.Items.Add(t);
            }
        }

        private void cargarTipoActividad()
        {
            foreach (TipoActividadE tAct in Enum.GetValues(typeof(TipoActividadE)))
            {
                if (tAct.ToString().Equals("VOLUNTARIADO"))
                {
                    cModiTipoAct.Items.Add(tAct);
                }
                else if (usr.Rol.NombreRol.Equals("Estudiante"))
                {
                    cModiTipoAct.Items.Add(tAct);
                }
            }
        }

        private void cargarNumeroHoras()
        {
            for (int c = 0; c <= 50; c++)
            {
                cModiHoras.Items.Add(c);
            }
        }

        private void cargarTipoTrabajo()
        {
            foreach (TipoTrabajoE tTrab in Enum.GetValues(typeof(TipoTrabajoE)))
            {
                cModiTipoTrab.Items.Add(tTrab);
            }
        }

        private void cargarAmbitoTrabajo()
        {
            foreach (AmbitoTrabajoE ambT in Enum.GetValues(typeof(AmbitoTrabajoE)))
            {
                cModAmb.Items.Add(ambT);
            }
        }

        private void cargarGrados()
        {
            foreach (Grado g in usr.Grados)
            {
                cModiGrado.Items.Add(g);
            }
            cModiGrado.DisplayMember = "nombreGrado";
        }

        private void cargarAsignaturas()
        {
            foreach (Asignatura a in usr.Asignaturas)
            {
                cModiAsig.Items.Add(a);
            }
            cModiAsig.DisplayMember = "nombreAsig";
        }

        private void visualizarVisible()
        {
            cModiGrado.Items.Clear();
            cModiAsig.Items.Clear();
            cModiTurno.Items.Clear();
            cModiTipoAct.Items.Clear();
            cModiHoras.Items.Clear();
            cModiTipoTrab.Items.Clear();
            cModAmb.Items.Clear();
            bConfirmar.Visible = true;
            bModificar.Visible = true;
            lShowGrado.Visible = true;
            lShowHoras.Visible = true;
            lShowTipo.Visible = true;
            lShowNoun.Visible = true;
            lShowTurno.Visible = true;
            lShowPreferencia.Visible = true;
            lShowGrado.Visible = true;
            lAmbTrab2.Visible = true;
            lTipoTrab2.Visible = true;
            listCompetencias.Items.Clear();
            cargarVisualizar();
    }

        private void visualizarInvisible()
        {
            bConfirmar.Visible = false;
            bModificar.Visible = false;
            lShowGrado.Visible = false;
            lShowHoras.Visible = false;
            lShowTipo.Visible = false;
            lShowNoun.Visible = false;
            lShowTurno.Visible = false;
            lShowPreferencia.Visible = false;
            lShowGrado.Visible = false;
            lAmbTrab2.Visible = false;
            lTipoTrab2.Visible = false;
        }

        private void modificarVisible()
        {
            mod = 1;
            bModiConf.Visible = true;
            bModiCancelar.Visible = true;
            cModiGrado.Visible = true;
            cModiAsig.Visible = true;
            cModiTurno.Visible = true;
            cModAmb.Visible = true;
            cModiTipoTrab.Visible = true;
            cModiHoras.Visible = true;
            cModiTipoAct.Visible = true;
            tModiNombre.Visible = true;
            listModiCompetencias.Visible = true;
            listModiCompetencias.Items.Clear();
            cargarModificar();
    }

        private void modificarInvisible()
        {
            mod = 0;
            bModiConf.Visible = false;
            bModiCancelar.Visible = false;
            cModiGrado.Visible = false;
            cModiAsig.Visible = false;
            cModiTurno.Visible = false;
            cModAmb.Visible = false;
            cModiTipoTrab.Visible = false;
            cModiHoras.Visible = false;
            cModiTipoAct.Visible = false;
            tModiNombre.Visible = false;
            listModiCompetencias.Visible = false;
            listModiCompetencias.Items.Clear();
        }

        private void cargarCompetencias()
        {
            if(mod == 0)
            {
                foreach (Competencia c in Competencia.ListaCompetencias(p))
                {
                    listCompetencias.Items.Add(c);
                }
                listCompetencias.DisplayMember = "nombreComp";
            } else
            {
                int index = 0;
                foreach (Competencia c in Competencia.ListaCompetencias())
                {
                    listModiCompetencias.Items.Add(c);
                    if (listCompetencias.Items.Contains(c)) {
                        listModiCompetencias.SetSelected(index, true);
                    }
                    index++;
               
                }
                listModiCompetencias.DisplayMember = "nombreComp";
            }
            
        }

        private void bConfirmar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bModificar_Click(object sender, EventArgs e)
        {
            modificarVisible();
            visualizarInvisible();
        }

        private void bModiConf_Click(object sender, EventArgs e)
        {
            
            try
            {
                //UPDATES
                if (!p.Nombre_Preferencia.Equals(tModiNombre)) 
                    p.Nombre_Preferencia = tModiNombre.Text.ToString();

                Grado g = (Grado)cModiGrado.SelectedItem;
                Asignatura a = (Asignatura)cModiAsig.SelectedItem;
                if (g != null ) p.Grado = g;
                if (a != null ) p.Asignatura = a;

                //HORAS
                if (cModiHoras.Text != "" && !cModiHoras.Text.Equals(p.HorasPosibles.ToString())) p.HorasPosibles = int.Parse(cModiHoras.Text);

                //ENUMERACIONES
                TipoActividadE resTipo;
                TurnoE resTurno;
                TipoTrabajoE resTipoTrab;
                AmbitoTrabajoE resAmbTrabajo;

                Enum.TryParse<TurnoE>(cModiTurno.Text, true, out resTurno);
                if (!cModiTurno.Text.Equals("") && !cModiTurno.Text.Equals(p.Turno.ToString())) p.Turno = resTurno;

                Enum.TryParse<TipoActividadE>(cModiTipoAct.Text, true, out resTipo);
                if (!cModiTipoAct.Text.Equals("") && !cModiTipoAct.Text.Equals(p.TipoActividad.ToString())) p.TipoActividad = resTipo;

                Enum.TryParse<TipoTrabajoE>(cModiTipoTrab.Text, true, out resTipoTrab);
                if (!cModiTipoTrab.Text.Equals("") && !cModiTipoTrab.Text.Equals(p.TipoTrabajo.ToString())) p.TipoTrabajo = resTipoTrab;

                Enum.TryParse<AmbitoTrabajoE>(cModAmb.Text, true, out resAmbTrabajo);
                if (!cModAmb.Text.Equals("") && !cModAmb.Text.Equals(p.AmbitoTrabajo.ToString())) p.AmbitoTrabajo = resAmbTrabajo;

                //COMPETENCIAS
               foreach (Competencia cA in listCompetencias.Items) p.RemoveCompetencia(cA);
               foreach (Competencia cNew in listModiCompetencias.SelectedItems) p.AddCompetencia(cNew); 
            
            } catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                Console.Write(ex.StackTrace);
            }
            //Cambiamos Modo
            modificarInvisible();
            visualizarVisible();
        }

        private void bModiCancelar_Click(object sender, EventArgs e)
        {
            modificarInvisible();
            visualizarVisible();
        }

        private void cModiGrado_SelectedIndexChanged(object sender, EventArgs e)
        {
            Grado g = (Grado)cModiGrado.SelectedItem;
            cargarAsignaturas(g);
        }

        private void cargarAsignaturas(Grado g)
        {
            cModiAsig.Items.Clear();
            foreach (Asignatura a in Asignatura.ListaAsignaturas(g))
            {
                if (usr.Asignaturas.Contains(a)) cModiAsig.Items.Add(a);
            }
            cModiAsig.DisplayMember = "nombreAsig";
        }
    }
}
