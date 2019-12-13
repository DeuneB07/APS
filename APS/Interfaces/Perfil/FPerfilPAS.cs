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

namespace APS.Interfaces.Perfil
{
    public partial class FPerfilPAS : Form
    {

        private Usuario usr;

        public FPerfilPAS(Usuario usr)
        {
            InitializeComponent();
            this.usr = usr;

            cargarDatos();
        }

        private void cargarDatos()
        {

            modiDNI.Visible = false;
            modiUser.Visible = false;
            bAceptarC.Visible = false;
            bCancelarC.Visible = false;
            dateNac.Visible = false;

            if (!usr.DNI.Equals("")) lShowDNI.Text = usr.DNI;
            else lShowDNI.Visible = false;

            if (!usr.NombreUser.Equals("")) lShowUser.Text = usr.NombreUser;
            else lShowUser.Visible = false;

            if (usr.FechaNac != null) lShowFecha.Text = usr.FechaNac.ToShortDateString();

            lShowNombre.Text = usr.Nombre + " " + usr.Apellido1 + " " + usr.Apellido2;
            lShowMail.Text = usr.Email;



        }

        private void bModPerfil_Click(object sender, EventArgs e)
        {

            if (!usr.NombreUser.Equals("")) modiUser.Text = usr.DNI;
            else modiUser.Text = "";

            if (!usr.DNI.Equals("")) modiDNI.Text = usr.DNI;
            else modiDNI.Text = "";

            if (usr.FechaNac != null) dateNac.Value = usr.FechaNac;
            else dateNac.Value = DateTime.Today;

            modiDNI.Visible = true;
            modiUser.Visible = true;
            dateNac.Visible = true;
            bAceptarC.Visible = true;
            bCancelarC.Visible = true;

            bBaja.Visible = false;
            bModPerfil.Visible = false;
            bAtras.Visible = false;
            lShowUser.Visible = false;
            lShowFecha.Visible = false;
            lShowDNI.Visible = false;
        }

        private void bBaja_Click(object sender, EventArgs e)
        {
            usr.BorraUsuario();

            PaginaInicio ventana = new PaginaInicio();
            this.Visible = false;
            ventana.ShowDialog();
            this.Close();
        }

        private void bAceptarC_Click(object sender, EventArgs e)
        {

            if (!modiDNI.Text.Equals(usr.DNI)) usr.DNI = modiDNI.Text;
            if (!modiUser.Text.Equals(usr.NombreUser)) usr.NombreUser = modiUser.Text;
            if (usr.FechaNac != dateNac.Value) usr.FechaNac = dateNac.Value;

            modiDNI.Visible = false;
            modiUser.Visible = false;
            dateNac.Visible = false;
            bAceptarC.Visible = false;
            bCancelarC.Visible = false;

            bBaja.Visible = true;
            bModPerfil.Visible = true;
            bAtras.Visible = true;
            lShowUser.Visible = true;
            lShowFecha.Visible = true;
            lShowDNI.Visible = true;
        }

        private void bCancelarC_Click(object sender, EventArgs e)
        {
            modiDNI.Visible = false;
            modiUser.Visible = false;
            dateNac.Visible = false;
            bAceptarC.Visible = false;
            bCancelarC.Visible = false;

            bBaja.Visible = true;
            bModPerfil.Visible = true;
            bAtras.Visible = true;
            lShowUser.Visible = true;
            lShowFecha.Visible = true;
            lShowDNI.Visible = true;
        }

        private void bPreferencias_Click(object sender, EventArgs e)
        {
            FPreferencias ventana = new FPreferencias(usr);
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
