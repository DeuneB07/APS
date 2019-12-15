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
        Usuario usrEmisor;
        Usuario usrReceptor;

        public NuevoMensaje(Usuario usrEmisor, Usuario usrReceptor)
        {
            InitializeComponent();
            this.usrEmisor = usrEmisor;
            this.usrReceptor = usrReceptor;

            if(usrReceptor != null)
            {
                tReceptor.Text = usrReceptor.Email;
                tReceptor.Enabled = false;
            }
        }

        private void bEnviar_Click(object sender, EventArgs e)
        {
            try
            {
                Mensaje msg = new Mensaje(tAsunto.Text, tTexto.Text, DateTime.Today, usrEmisor, new Usuario(tReceptor.Text));
                this.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                DialogResult emFalloEnviar;
                string mensaje = "Se ha producido un error";
                string caption = "Lo sentimos, pero...";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                emFalloEnviar = MessageBox.Show(mensaje, caption, buttons);
            }
            
        }

        private void bAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
