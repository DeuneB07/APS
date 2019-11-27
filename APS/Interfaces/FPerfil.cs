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

namespace APS.Interfaces
{
    public partial class FPerfil : Form
    {

        Usuario user;

        public FPerfil(Usuario user)
        {
            InitializeComponent();
            this.user = user;

            bAceptarC.Visible = false;
            bCancelarC.Visible = false;
            textNombreUser.Visible = false;

            lUserNoun2.Text = user.NombreUser;
            lDNI2.Text = user.DNI;
            lNombre2.Text = user.Nombre + " " + user.Apellido1 + " " + user.Apellido2;
            lMail2.Text = user.Email;
            cargarAsignaturas();
            cargarGrados();
            

        }

        private void cargarAsignaturas()
        {
            foreach(Asignatura a in user.Asignaturas)
            {
                listAsignaturas.Items.Add(a.NombreAsig);
            }
            
        }

        private void cargarGrados()
        {
            List<Grado> gradoUser = user.Grados;
            if (user.Grados.Count == 0) lGradosUno.Text = "No hay Grados Actuales";
            else if (user.Grados.Count == 1) lGradosUno.Text = user.Grados.ElementAt(1).NombreGrado;
            else
            {
                foreach (Grado a in user.Grados)
                {
                    listGrados.Items.Add(a.NombreGrado);
                }
            }
            
        }

        private void bModPerfil_Click(object sender, EventArgs e)
        {

        }

        private void bAceptarC_Click(object sender, EventArgs e)
        {

        }

        private void bCancelarC_Click(object sender, EventArgs e)
        {

        }

        private void bBaja_Click(object sender, EventArgs e)
        {

        }
    }
}
