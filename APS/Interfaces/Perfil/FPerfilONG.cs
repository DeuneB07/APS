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
            if (usr.Imagen != null) this.pictureBoxPerfil.Image = usr.Imagen;
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
            this.btnBorrarImagen.Visible = true;
            this.btnCambiarImagen.Visible = true;
            this.lPass2.Visible = false;
            this.textPass.Visible = true;
            this.textPass.Text = usr.Password;
        }

        private void bBaja_Click(object sender, EventArgs e)
        {
            usr.BorraUsuario();
            this.Close();
        }

        private void bAceptarC_Click(object sender, EventArgs e)
        {

            if (modiUser.Text != "")
            {
                usr.NombreUser = modiUser.Text;
                lShowUser.Text = usr.NombreUser;
            }

            if (!textPass.Text.Equals(usr.Password) && textPass.Text.Equals(""))
                usr.Password = textPass.Text;

            if (!this.tURL.Text.Trim().Equals("")) usr.Imagen = pictureBoxPerfil.Image;

            this.bBaja.Visible = true;
            this.bAtras.Visible = true;
            this.bModPerfil.Visible = true;
            this.lShowUser.Visible = true;
            this.bAceptarC.Visible = false;
            this.bCancelarC.Visible = false;
            this.modiUser.Visible = false;
            this.btnCambiarImagen.Visible = false;
            this.btnBorrarImagen.Visible = false;
            this.lPass2.Visible = true;
            this.textPass.Visible = false;
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
            this.btnCambiarImagen.Visible = false;
            this.btnBorrarImagen.Visible = false;
            this.lPass2.Visible = true;
            this.textPass.Visible = false;
        }

        private void bAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCambiarImagen_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Archivos jpg (*.jpg)|*.jpg|Archivos png(*.png)|*.png";
            openFileDialog1.FilterIndex = 1;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                tURL.Text = openFileDialog1.FileName;
            }

            pictureBoxPerfil.ImageLocation = openFileDialog1.FileName;
        }

        private void btnBorrarImagen_Click(object sender, EventArgs e)
        {
            tURL.Text = "";
            pictureBoxPerfil.Image = global::APS.Properties.Resources.userDefault;
        }
    }
}
