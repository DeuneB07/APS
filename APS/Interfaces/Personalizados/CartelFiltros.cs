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
using static APS.Mapeo.Actividad;

namespace APS.Interfaces.Personalizados
{
    public partial class CartelFiltros : UserControl
    {

        private Usuario usrLogin;

        public CartelFiltros(Usuario usrLogin)
        {
            InitializeComponent();

            this.usrLogin = usrLogin;

            cargarTurnos();
            cargarTipoActividad();
            cargarGrados();
            cargarAsignaturas();
            cargarHoras();

        }

        private void cargarGrados()
        {
            if (usrLogin.Rol.NombreRol.Equals("GESTOR"))
            {
                foreach (Grado g in Grado.ListaGrados())
                {
                    cGrado.Items.Add(g);
                }
                cGrado.DisplayMember = "nombreGrado";
            } else
            {
                foreach (Grado g in usrLogin.Grados)
                {
                    cGrado.Items.Add(g);
                }
                cGrado.DisplayMember = "nombreGrado";
            }
            
        }

        private void cargarAsignaturas()
        {
            foreach (Asignatura a in usrLogin.Asignaturas)
            {
                cAsig.Items.Add(a);
            }
            cAsig.DisplayMember = "nombreAsig";
        }

        private void cargarTurnos()
        {
            foreach (TurnoE t in Enum.GetValues(typeof(TurnoE)))
            {
                cTurno.Items.Add(t);
            }
        }

        private void cargarTipoActividad()
        {
            foreach (TipoActividadE tAct in Enum.GetValues(typeof(TipoActividadE)))
            {
                if (tAct.ToString().Equals("VOLUNTARIADO"))
                {
                    cTipoAct.Items.Add(tAct);
                }
                else if (usrLogin.Rol.NombreRol.Equals("Estudiante"))
                {
                    cTipoAct.Items.Add(tAct);
                }
            }
        }

        private void cargarHoras()
        {
            for (int c = 0; c <= 50; c++)
            {
                cHoras.Items.Add(c);
            }
        }


    }
}
