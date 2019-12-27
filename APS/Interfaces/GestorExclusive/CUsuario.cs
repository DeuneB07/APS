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

            if (u.Email.Equals("")) lShowMail.Text = u.Email;
            if (u.Rol.NombreRol.Equals("")) lShowRol.Text = u.Rol.NombreRol;
            if (u.Nombre.Equals("")) lShowNoun.Text = u.Nombre + " " + u.Apellido1 + " " + u.Apellido2;
            if (u.DNI.Equals("")) lShowDNI.Text = u.DNI;
            if (u.FechaNac.ToShortDateString().Equals("")) lShowFecha.Text = u.FechaNac.ToShortDateString();
            if (u.Imagen != null) pictImagen.Image = u.Imagen;

        }
    }
}
