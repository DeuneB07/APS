using APS.Interfaces.Mensajes;
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

namespace APS.Interfaces.Perfil
{
    public partial class BandejaMensajes : Form
    {
        Usuario user;

        public BandejaMensajes(Usuario user)
        {
            this.user = user;

            InitializeComponent();

            cargaMensajesRecibidos();
        }

        private void cargaMensajesRecibidos()
        {

            List<Mensaje> mensajes = Mensaje.ListaMensajesRecibidos(user);

        }
    }
}
