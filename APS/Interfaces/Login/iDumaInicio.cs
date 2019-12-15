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
    public partial class iDumaInicio : Form
    {
        private Usuario user;


        public iDumaInicio()
        {
            InitializeComponent();
            user = null;
            labelError.Text = "";
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            try
            {

                string email = tIdentificacion.Text;
                string pwd = tPassword.Text;
                labelError.Text = "";

                //Comprobar contraseña con IDUMA
                UsuarioJSON userJSON = IDUMA.Acceso(email, pwd);
                user = new Usuario(userJSON.UserEmail);
          
                if (user.Email == null)
                {
                    GoRegistro(userJSON);
                }
                else
                {
                    GoPaginaPrincipal();
                }
                this.Close();
            }
            catch (Exception ex)
            {
                labelError.Text = ex.Message;
                Console.WriteLine(ex.StackTrace);
            }
        }

        private void GoPaginaPrincipal()
        {
            PaginaPrincipal pagPrinc = new PaginaPrincipal(user);
            this.Visible = false;
            pagPrinc.ShowDialog();
            this.Close();

        }

        private void GoRegistro(UsuarioJSON userJSON)
        {
            RegistroUMA registro = new RegistroUMA(userJSON);
            this.Visible = false;
            registro.ShowDialog();
            this.Close();
        }

    }
}
