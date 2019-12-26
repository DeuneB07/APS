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

namespace APS.Interfaces.GestorExclusive
{
    public partial class CUsuario : UserControl
    {
        private Usuario u;
        public CUsuario(Usuario u)
        {
            InitializeComponent();
            this.u = u;

            lShowMail.Text = u.Email;
            lShowRol.Text = u.Rol.NombreRol;
            lShowNoun.Text = u.Nombre + " " + u.Apellido1 + " " + u.Apellido2;
        }
    }
}
