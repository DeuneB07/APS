using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using APS.Mapeo;

namespace APS.Interfaces.Personalizados
{
    public partial class CartelParticipante : UserControl
    {
        private Usuario user;
        public CartelParticipante(Usuario user)
        {
            InitializeComponent();
            this.user = user;
            this.labelName.Text = user.Nombre + " " + user.Apellido1 + " " + user.Apellido2;
            this.lShowNick.Text = user.NombreUser;
            this.lShowRol.Text = user.Rol.NombreRol;
            this.lShowMail.Text = user.Email;
            if (user.Imagen != null) this.pict.Image = user.Imagen;
        }

        private void bVerTodo_Click(object sender, EventArgs e)
        {

        }
    }
}
