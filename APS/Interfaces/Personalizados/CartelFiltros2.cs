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
using static APS.Mapeo.Actividad;

namespace APS.Interfaces.Personalizados
{
    public partial class CartelFiltros2 : UserControl
    {

        private Usuario usrLogin;
        public Filtros filtros;

        public CartelFiltros2(Usuario usrLogin)
        {
            InitializeComponent();
            this.usrLogin = usrLogin;
            filtros = new Filtros(this);

        }

        private void label1_Click(object sender, EventArgs e)
        {
            filtros.Show();
        }

        private void pictFiltro_Click(object sender, EventArgs e)
        {
            filtros.Show();
        }

        private void panelFiltro_Click(object sender, EventArgs e)
        {
            filtros.Show();
        }
    }
}
