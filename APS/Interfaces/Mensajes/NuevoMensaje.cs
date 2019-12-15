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

namespace APS.Interfaces.Mensajes
{
    public partial class NuevoMensaje : Form
    {
        Usuario user;
        Mensaje msg;

        public NuevoMensaje(Usuario user, Mensaje msg)
        {
            InitializeComponent();
            this.user = user;
            this.msg = msg;
        }

        private void bEnviar_Click(object sender, EventArgs e)
        {
            try
            {
                Mapeo.Mensaje escrito = new Mapeo.Mensaje(tAsunto.Text.ToString(), tTexto.Text.ToString(), DateTime.Today, user, new Usuario(tReceptor.Text));
                this.Close();
            }
            catch (Exception exc)
            {
                Console.WriteLine(exc.StackTrace);
            }
        }

        private void beliminar_Click(object sender, EventArgs e)
        {
            msg.BorraMensaje();
            this.Close();
        }

        private void bvolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
