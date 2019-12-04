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

                if (user.Rol.NombreRol == "GESTOR" || user.Rol.NombreRol == "ONG")
                {
                    //Comprobar contraseña con nuestra BBDD
                    user = new Usuario(email, pwd);
                }
                else
                {
                    throw new Exception("Usuario y/o contraseña incorrectos");
                    
                }

                this.GoPaginaPrincipal(user);
            }
            catch (Exception ex)
            {
                labelError.Text = ex.Message;
            }
        }

        private void GoPaginaPrincipal(Usuario user)
        {
            PaginaPrincipal pagina = new PaginaPrincipal(user);
            this.Visible = false;
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
