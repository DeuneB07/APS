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
    
    public partial class InicioPersExterno : Form
    {
        public InicioPersExterno()
        {
            InitializeComponent();
            labelError.Text = "";
        }

        private void bIniciar_Click(object sender, EventArgs e)
        {
            try
            {

                string email = tCorreo.Text;
                string pwd = tPassword.Text;
                Usuario user = new Usuario(email);
                labelError.Text = "";
                if (user.Email == null) throw new Exception("Usuario y/o contraseña incorrectos");

                if(user.Aceptado)
                {
                    if (user.Rol.NombreRol == "GESTOR" || user.Rol.NombreRol == "ONG")
                    {
                        //Comprobar contraseña con nuestra BBDD
                        user = new Usuario(email, pwd);
                        this.GoPaginaPrincipal(user);
                    }
                    else
                    {
                        throw new Exception("Usuario y/o contraseña incorrectos");

                    }
                } else
                {
                    DialogResult emCierreDialog;
                    string mensaje = "Lo sentimos, pero su solicitud está siendo tramitada \n por el Gestor. Intente de nuevo más tarde.";
                    string caption = "Lo sentimos...";
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    emCierreDialog = MessageBox.Show(mensaje, caption, buttons);
                    this.Close();
                }
               
            }
            catch (Exception ex)
            {
                labelError.Text = ex.Message;
            }
        }

        private void GoPaginaPrincipal(Usuario user)
        {
            this.Visible = false;
            PaginaPrincipal pagina = new PaginaPrincipal(user);
            pagina.ShowDialog();
            this.Close();
        }

        private void bRegistrar_Click(object sender, EventArgs e)
        {
            GoRegistro();
        }

        private void GoRegistro()
        {
            RegistroONG registro = new RegistroONG();
            this.Visible = false;
            registro.ShowDialog();
            this.Close();
        }
    }
}
