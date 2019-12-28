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

            if (!u.Rol.NombreRol.Equals("ONG") || u.Nombre == null || u.Nombre.Equals(""))
            {
                lBuscar.Visible = false;
                bBuscar.Visible = false;
            }

            if (!u.Email.Equals("")) lShowMail.Text = u.Email;
            if (u.Rol != null) lShowRol.Text = u.Rol.NombreRol;

            if(u.Nombre != null && !u.Nombre.Equals(""))
            {
                lShowNoun.Text = u.Nombre;
                if (u.Apellido1 != null && !u.Apellido1.Equals(""))
                {
                    lShowNoun.Text = lShowNoun.Text + " " +u.Apellido1;
                    if (u.Apellido2 != null && !u.Apellido2.Equals("")) 
                        lShowNoun.Text = lShowNoun.Text + " " + u.Apellido2;
                }
            }

            if (u.DNI != null && !u.DNI.Equals("")) lShowDNI.Text = u.DNI;
            if (u.FechaNac != null && !u.FechaNac.ToShortDateString().Equals("")) lShowFecha.Text = u.FechaNac.ToShortDateString();
            if (u.Imagen != null) pictImagen.Image = u.Imagen;

        }

        private void bBuscar_Click(object sender, EventArgs e)
        {
            String newNoun = u.Nombre.Replace(" ", "+");
            String url = "http://www.google.com/search?q=" + newNoun;
            System.Diagnostics.Process.Start("chrome.exe", url);
        }
    }
}
