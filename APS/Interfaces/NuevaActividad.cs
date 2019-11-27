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

namespace APS.Interfaces
{
    public partial class NuevaActividad : Form
    {

        private Usuario ong;

        public NuevaActividad(Usuario ong)
        {
            InitializeComponent();
            this.ong = ong;
            tOrganizador.Visible = false;
            tOrganizador.Text = ong.Nombre;
            

        }

        private void bAceptar_Click(object sender, EventArgs e)
        {



        }
    }
}
