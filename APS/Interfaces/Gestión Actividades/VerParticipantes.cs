using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using APS.Mapeo;

namespace APS.Interfaces.Gestión_Actividades
{
    public partial class VerParticipantes : Form
    {
        private Usuario user;
        private Actividad actividad;
        public VerParticipantes(Actividad actividad, Usuario user)
        {
            InitializeComponent();
            this.actividad = actividad;
            this.user = user;
            tabSolicitudes.Visible = true;

            if (user.Rol.NombreRol.Equals("ONG"))
            {
                cargarPendientesONG();
            }
            else
            {
                cargarPendientesPDI();
                cargarEnEsperaONG();
            }
            cargarAceptadas();
        }

        private void cargarEnEsperaONG()
        {
            throw new NotImplementedException();
        }

        private void cargarAceptadas()
        {
            throw new NotImplementedException();
        }

        private void cargarPendientesPDI()
        {
            throw new NotImplementedException();
        }

        private void cargarPendientesONG()
        {
            throw new NotImplementedException();
        }
    }
}
