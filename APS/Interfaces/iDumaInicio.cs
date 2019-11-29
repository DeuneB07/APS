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

        private void bEntrar_Click(object sender, EventArgs e)
        {
            try
            {

                string email = tIdentificacion.Text;
                string pwd = tPassword.Text;
                user = new Usuario(email);
                labelError.Text = "";

                //Comprobar contraseña con IDUMA
                UsuarioJSON userJSON = IDUMA.Acceso(email, pwd);

                goPaginaPrincipal();

            }
            catch (Exception ex)
            {
                labelError.Text = ex.Message;
            }
        }

        private void goPaginaPrincipal()
        {
            PaginaPrincipal pagPrinc = new PaginaPrincipal(user);
            this.Visible = false;
            pagPrinc.ShowDialog();
            this.Close();
        }
    }
}
