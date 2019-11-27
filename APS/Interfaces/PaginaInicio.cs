﻿using APS.BD;
using APS.JSON;
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
    public partial class PaginaInicio : Form
    {

        Usuario user;

        public PaginaInicio()
        {
            InitializeComponent();
            labelError.Text = "";
            user = null;
        }

        private void bIniciar_PagIni_Click(object sender, EventArgs e)
        {
            try
            {
                string email = t_correoPagIni.Text;
                string pwd = t_pwdPagIni.Text;
                user = new Usuario(email);
                labelError.Text = "";

                if (user.Rol.NombreRol == "ONG")
                {
                    //Comprobar contraseña con nuestra BBDD
                    user = new Usuario(email, pwd);
                }
                else
                {
                    //Comprobar contraseña con IDUMA
                    UsuarioJSON userJSON = IDUMA.Acceso(email, pwd);
                }

                MessageBox.Show("Login Correctamente");

                goPaginaPrincipal();

            }catch(Exception ex)
            {
                labelError.Text = ex.Message;
            }

        }

        private void bRegistrar_PagIni_Click(object sender, EventArgs e)
        {
            goRegistro();
        }

        private void goRegistro()
        {
            Registro registro = new Registro();
            this.Visible = false;
            registro.ShowDialog();
            this.Visible = true;
        }

        private void goPaginaPrincipal()
        {
      
            if (user.Rol.NombreRol == "Estudiante") { 
                PaginaPrincipalAlumno mainWindow = new PaginaPrincipalAlumno(user);
                this.Visible = false;
                mainWindow.ShowDialog();
                this.Visible = true;
            } /*else if(user.Rol.NombreRol == "ONG") {
                PaginaPrincipalONG mainWindow = new PaginaPrincipalONG(user);
                this.Visible = false;
                mainWindow.ShowDialog();
                this.Visible = true;
            } else if (user.Rol.NombreRol == "GESTOR") {   
                PaginaPrincipalGestor mainWindow = new PaginaPrincipalGestor(user);
                this.Visible = false;
                mainWindow.ShowDialog();
                this.Visible = true;
            } else if (user.Rol.NombreRol == "PAS") {
                PaginaPrincipalPAS mainWindow = new PaginaPrincipalPAS(user);
                this.Visible = false;
                mainWindow.ShowDialog();
                this.Visible = true;
            }*/





        }

    }
}
