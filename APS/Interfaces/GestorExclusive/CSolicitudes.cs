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
    public partial class CSolicitudes : UserControl
    {

        Usuario usr;
        public CSolicitudes(Usuario usr)
        {
            InitializeComponent();
            this.usr = usr;

            if (usr.FechaNac != null && !usr.FechaNac.ToShortDateString().Equals("")) lShowFecha.Text = usr.FechaNac.ToShortDateString();
            if (!usr.Email.Equals("")) lShowMail.Text = usr.Email;
            if (usr.NombreUser != null && !usr.NombreUser.Equals("")) lShowUser.Text = usr.NombreUser;
            if (usr.Nombre != null && !usr.Nombre.Equals("")) lShowNombreCompleto.Text = usr.Nombre;
            else bBuscar.Visible = false;
            if (usr.Imagen != null) pictImagen.Image = usr.Imagen;

        }

        private void bBuscar_Click(object sender, EventArgs e)
        {
            String newNoun = usr.Nombre.Replace(" ", "+");
            String url = "http://www.google.com/search?q=" + newNoun;
            System.Diagnostics.Process.Start("firefox.exe", url);
        
        }
    }
}
