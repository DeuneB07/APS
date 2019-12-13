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
    public partial class FPerfilONG : Form
    {
        private Usuario usr;

        public FPerfilONG(Usuario usr)
        {
            InitializeComponent();

            this.usr = usr;
            cargarDatos();
            
        }

        private void cargarDatos()
        {
            this.lShowUser.Text = usr.NombreUser;
            this.lShowNombre.Text = usr.Nombre;
            this.lShowMail.Text = usr.Email;
            if(usr.FechaNac != null) this.lShowFecha.Text = usr.FechaNac.ToShortDateString();
            this.bAceptarC.Visible = false;
            this.bCancelarC.Visible = false;
            this.modiUser.Visible = false;
        }

        private void bModPerfil_Click(object sender, EventArgs e)
        {
            this.bBaja.Visible = false;
            this.bAtras.Visible = false;
            this.bModPerfil.Visible = false;
            this.lShowUser.Visible = false;
            this.bAceptarC.Visible = true;
            this.bCancelarC.Visible = true;
            this.modiUser.Visible = true;
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

            if (modiUser.Text != "")
            {
                usr.NombreUser = modiUser.Text;
                lShowUser.Text = usr.NombreUser;
            }

            this.bBaja.Visible = true;
            this.bAtras.Visible = true;
            this.bModPerfil.Visible = true;
            this.lShowUser.Visible = true;
            this.bAceptarC.Visible = false;
            this.bCancelarC.Visible = false;
            this.modiUser.Visible = false;
        }

        private void bCancelarC_Click(object sender, EventArgs e)
        {
            this.bBaja.Visible = true;
            this.bAtras.Visible = true;
            this.bModPerfil.Visible = true;
            this.lShowUser.Visible = true;
            this.bAceptarC.Visible = false;
            this.bCancelarC.Visible = false;
            this.modiUser.Visible = false;
        }

        private void bAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
