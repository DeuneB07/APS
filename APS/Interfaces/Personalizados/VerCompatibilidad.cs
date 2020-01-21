using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using APS.Mapeo;

namespace APS.Interfaces.Personalizados
{
    public partial class VerCompatibilidad : Form
    {
        Preferencia pref;
        Actividad act;
        Usuario user;
        public VerCompatibilidad(Preferencia pref, Actividad act, Usuario user)
        {
            InitializeComponent();
            this.Location = System.Windows.Forms.Cursor.Position;
            this.gradientPanel1.Size = this.Size;
            this.pref = pref;
            this.act = act;
            this.user = user;

            CompararTipoActividad();
            CompararGrado();
            CompararAsignatura();
            CompararCompetencias();
            CompararTurno();
            CompararHoras();
            CompararTipoTrabajo();
            CompararAmbitoTrabajo();

        }

        private void CompararAmbitoTrabajo()
        {
            if (pref != null)
            {
                if (pref.AmbitoTrabajo.Ambito_Trabajo.Equals("TODAS") || pref.AmbitoTrabajo.Equals(act.AmbitoTrabajo))
                {
                    checkBoxAdvAmbitoTrabajo.Checked = true;
                }
            }
            else
            {
                checkBoxAdvAmbitoTrabajo.Checked = true;
            }
        }

        private void CompararTipoTrabajo()
        {
            if (pref != null)
            {
                if (pref.TipoTrabajo.Tipo_Trabajo.Equals("TODAS") || pref.TipoTrabajo.Equals(act.TipoTrabajo))
                {
                    checkBoxAdvTipoTrabajo.Checked = true;
                }
            }
            else
            {
                checkBoxAdvTipoTrabajo.Checked = true;
            }
        }

        private void CompararHoras()
        {
            if (pref != null)
            {
                if (pref.HorasPosibles == 0 || pref.HorasPosibles >= act.NumHoras)
                {
                    checkBoxAdvHoras.Checked = true;
                }
            }
            else
            {
                checkBoxAdvHoras.Checked = true;
            }
        }

        private void CompararTurno()
        {
            if (pref != null)
            {
                if (pref.Turno.Equals(Actividad.TurnoE.AMBAS) || pref.Turno.Equals(act.Turno))
                {
                    checkBoxAdvTurno.Checked = true;
                }
            }
            else
            {
                checkBoxAdvTurno.Checked = true;
            }
        }

        private void CompararCompetencias()
        {
            int numerador = 0;
            int denominador = 0;
            if (pref != null)
            {
                denominador = pref.Competencias.Count;
                foreach (Competencia c in pref.Competencias)
                {
                    if (act.Competencias.Contains(c))
                    {
                        numerador++;
                    }
                }
            }
            lblShowCompetencias.Text = numerador + "/" + denominador;
            if (numerador == denominador) lblShowCompetencias.ForeColor = Color.Green;
            else if (numerador >= (denominador / 2)) lblShowCompetencias.ForeColor = Color.Teal;
            else lblShowCompetencias.ForeColor = Color.Red;
        }

        private void CompararAsignatura()
        {
            if (pref != null)
            {
                if (pref.Asignatura == null)
                {
                    checkBoxAdvAsig.Checked = true;
                }
                else
                {
                    if (act.Asignatura != null && pref.Asignatura.Equals(act.Asignatura))
                    {
                        checkBoxAdvAsig.Checked = true;
                    }
                }
            }
            else
            {
                if (!user.Rol.NombreRol.Equals("PAS"))
                {
                    if (act.Asignatura != null && user.Asignaturas.Contains(act.Asignatura))
                    {
                        checkBoxAdvAsig.Checked = true;
                    }
                }
            }
        }

        private void CompararGrado()
        {
            if (pref != null)
            {
                if (pref.Grado == null)
                {
                    checkBoxAdvGrado.Checked = true;
                }
                else
                {
                    if (act.Grado!=null && pref.Grado.Equals(act.Grado))
                    {
                        checkBoxAdvGrado.Checked = true;
                    }
                }
            }
            else
            {
                if (!user.Rol.NombreRol.Equals("PAS"))
                {
                    if(act.Grado!=null && user.Grados.Contains(act.Grado))
                    {
                        checkBoxAdvGrado.Checked = true;
                    }
                }
            }
        }

        private void CompararTipoActividad()
        {
            if (pref != null)
            {
                if (pref.TipoActividad.Equals(Actividad.TipoActividadE.TODAS) || pref.TipoActividad.Equals(act.TipoAct))
                {
                    checkBoxAdvTipoAct.Checked = true;
                }
            }
            else
            {
                if (user.Rol.NombreRol.Equals("Estudiante"))
                {
                    if (act.TipoAct.Equals(Actividad.TipoActividadE.FORMACION))
                    {
                        checkBoxAdvTipoAct.Checked = true;
                    }
                }else if (user.Rol.NombreRol.Equals("PDI"))
                {
                    if (act.TipoAct.Equals(Actividad.TipoActividadE.INVESTIGACION))
                    {
                        checkBoxAdvTipoAct.Checked = true;
                    }
                }
                else
                {
                    if (act.TipoAct.Equals(Actividad.TipoActividadE.VOLUNTARIADO))
                    {
                        checkBoxAdvTipoAct.Checked = true;
                    }
                }
            }
        }
    }
}
