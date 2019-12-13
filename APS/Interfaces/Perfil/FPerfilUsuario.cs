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
    public partial class FPerfilUsuario : Form
    {

        Usuario user;

        public FPerfilUsuario(Usuario user)
        {

            InitializeComponent();
            //this.Visible = true;
            this.user = user;

            bAceptarC.Visible = false;
            bCancelarC.Visible = false;
            textNombreUser.Visible = false;
                
            if (user.Rol.NombreRol.ToUpper().Equals("ESTUDIANTE")) cargarPerfilAlumno();
            if (user.Rol.NombreRol.Equals("PDI")) cargarPerfilPDI();
            if (user.Rol.NombreRol.ToUpper().Equals("GESTOR")) cargarPerfilGestor();
            

        }

        private void cargarPerfilAlumno()
        {
            lUserNoun2.Text = user.NombreUser;
            lDNI2.Text = user.DNI;
            lNombre2.Text = user.Nombre + " " + user.Apellido1 + " " + user.Apellido2;
            lMail2.Text = user.Email;
            lFecha2.Text = user.FechaNac.ToShortDateString();
            cargarAsignaturas();
            cargarGrados();
        }

        private void cargarPerfilPDI()
        {
            lUserNoun2.Text = user.NombreUser;
            lDNI2.Text = user.DNI;
            lNombre2.Text = user.Nombre + " " + user.Apellido1 + " " + user.Apellido2;
            lMail2.Text = user.Email;
            lFecha2.Text = user.FechaNac.ToShortDateString();
            cargarAsignaturas();
            lGrados.Visible = false;
            lGradosUno.Visible = false;
            listGrados.Visible = false;
        }

        private void cargarPerfilGestor()
        {
            lUserNoun2.Text = user.NombreUser;
            lDNI2.Text = user.DNI;
            lNombre2.Text = user.Nombre + " " + user.Apellido1 + " " + user.Apellido2;
            lMail2.Text = user.Email;
            lFecha2.Text = user.FechaNac.ToShortDateString();

            lAsignaturas.Visible = false;
            listAsignaturas.Visible = false;
            lGrados.Visible = false;
            lGradosUno.Visible = false;
            listGrados.Visible = false;
            bPreferencias.Visible = false;
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
            else if (user.Grados.Count == 1)
            {
                listGrados.Visible = false;
                lGradosUno.Text = user.Grados.ElementAt(0).NombreGrado;
            }
            else
            {
                lGradosUno.Visible = false;
                foreach (Grado a in user.Grados)
                {
                    listGrados.Items.Add(a.NombreGrado);
                }
            }
            
        }

        private void bModPerfil_Click(object sender, EventArgs e)
        {
            bPreferencias.Visible = false;
            bBaja.Visible = false;
            bModPerfil.Visible = false;
            bAceptarC.Visible = true;
            bCancelarC.Visible = true;
            lUserNoun2.Visible = false;

            textNombreUser.Visible = true;
        }

        private void bAceptarC_Click(object sender, EventArgs e)
        {
            bPreferencias.Visible = true;
            bBaja.Visible = true;
            bModPerfil.Visible = true;
            bAceptarC.Visible = false;
            bCancelarC.Visible = false;

            if(textNombreUser.Text != "")
            {
                user.NombreUser = textNombreUser.Text;
                lUserNoun2.Text = user.NombreUser;
            }
            lUserNoun2.Visible = true;
            textNombreUser.Visible = false;
        }

        private void bCancelarC_Click(object sender, EventArgs e)
        {
            bPreferencias.Visible = true;
            bBaja.Visible = true;
            bModPerfil.Visible = true;
            bAceptarC.Visible = false;
            bCancelarC.Visible = false;
            lUserNoun2.Visible = true;
            textNombreUser.Visible = false;

        }

        private void bBaja_Click(object sender, EventArgs e)
        {
            user.BorraUsuario();

            PaginaInicio ventana = new PaginaInicio();
            this.Visible = false;
            ventana.ShowDialog();
            this.Close();
            
        }

        private void bPreferencias_Click(object sender, EventArgs e)
        {
            FPreferencias ventana = new FPreferencias(user);
            this.Visible = false;
            ventana.ShowDialog();
            this.Visible = true;
        }

        private void bAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
