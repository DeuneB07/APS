﻿using APS.Mapeo;
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
    public partial class PaginaPrincipalAlumno : Form
    {

        Usuario user;

        public PaginaPrincipalAlumno(Mapeo.Usuario user)
        {
            InitializeComponent();
            this.user = user;

            tabUser.Visible = true;
            if (!user.AccesoPantalla("MATCH")) tabUser.Controls.Remove(this.pMatch);
            if (!user.AccesoPantalla("TODAS")) tabUser.Controls.Remove(this.pTodas);
            if (!user.AccesoPantalla("PROYECTOS")) tabUser.Controls.Remove(this.pProyectos);
            if (!user.AccesoPantalla("VALORACION")) tabUser.Controls.Remove(this.pValoracion);

            lWelcome.Text = "¡Bienvenido, " + user.NombreUser + "!";
            



        }

        private void bLogout_Click(object sender, EventArgs e)
        {
            crearCierreSesion();
        }

        private void crearCierreSesion()
        {
            DialogResult emCierreDialog;
            string mensaje = "¿Quieres cerrar la sesión actual?";
            string caption = "¡AVISO!";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            emCierreDialog = MessageBox.Show(mensaje, caption, buttons);

            if (emCierreDialog == DialogResult.Yes) this.Close();
        }

        private void pTodas_Click(object sender, EventArgs e)
        {

        }

        private void lPerfil_Click(object sender, EventArgs e)
        {
            goPerfilUsuario();
        }

        private void goPerfilUsuario()
        {
            FPerfil perfil = new FPerfil(user);
            this.Visible = false;
            perfil.ShowDialog();
            this.Visible = true;
        }

    }
}
