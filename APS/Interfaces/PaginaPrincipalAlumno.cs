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
    public partial class PaginaPrincipalAlumno : Form
    {

        Usuario user;

        public PaginaPrincipalAlumno(Mapeo.Usuario user)
        {
            InitializeComponent();
            this.user = user;
            lWelcome.Text = "¡Bienvenido, " + user.NombreUser + "!";




        }

        private void bLogout_Click(object sender, EventArgs e)
        {

            //EmergenteCierre emCierre = new EmergenteCierre();

            this.Close();
        }
    }
}
