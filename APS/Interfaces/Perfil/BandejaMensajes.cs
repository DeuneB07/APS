using APS.Mapeo;
using APS.Interfaces.Perfil;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using APS.Interfaces.Perfil;

namespace APS.Interfaces.Perfil
{
    public partial class BandejaMensajes : Form
    {

        Usuario user;

        public BandejaMensajes(Usuario user)
        {
            this.user = user;
            InitializeComponent();
            cargaMensajes();
        }

        private void cargaMensajes()
        {
            listMensajes.Items.Clear();
            try {
                foreach (APS.Mapeo.Mensaje msg in user.Mensajes)
                {
                    listMensajes.Items.Add(msg);
                }
            }catch(Exception exc)
            {
                Console.WriteLine(exc.StackTrace);
            }
            }


       private void bNuevoMensaje_Click(object sender, EventArgs e)
        {
            NuevoMensaje nuevo = new NuevoMensaje(user,(Mensaje) listMensajes.SelectedItem);
            this.Visible = false;
            nuevo.ShowDialog();
            this.Visible = true;
        }

        private void bVerMensaje_Click(object sender, EventArgs e)
        {
            goMensaje(listMensajes.SelectedItem);
        }

        private void goMensaje(object msg)
        {
            AperturaMensajes open = new AperturaMensajes((Mensaje) msg);
            this.Visible = false;
            open.ShowDialog();
            cargaMensajes();
            this.Visible = true;
        }
    }
}
