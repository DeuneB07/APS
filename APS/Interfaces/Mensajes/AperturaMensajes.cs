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
    public partial class AperturaMensajes : Form
    {
        Mensaje msg;
        public AperturaMensajes(Mensaje msg)
        {
            InitializeComponent();
            this.msg = msg;
            cargarMensaje();
        }

        private void cargarMensaje()
        {
            //   tReceptor.Text = msg.Receptor.ToString();
            tAsunto.Text = msg.Asunto.ToString();
            tTexto.Text = msg.Texto.ToString();
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


        private void bresponder_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            //nuevo.ShowDialog();
            this.Visible = true;
        }
    }
}

