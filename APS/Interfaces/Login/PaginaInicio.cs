using APS.BD;
using APS.JSON;
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
    public partial class PaginaInicio : Form
    {

        public PaginaInicio()
        {
            InitializeComponent();
        }

        private void bPersonalUMA_Click(object sender, EventArgs e)
        {
            this.GoPersonalUMA();
        }

        private void GoPersonalUMA()
        {
            iDumaInicio panel = new iDumaInicio();
            this.Visible = false;
            panel.ShowDialog();
            this.Visible = true;
        }

        private void bPersonalExt_Click(object sender, EventArgs e)
        {
            this.GoInicioPersExterno();
        }

        private void GoInicioPersExterno()
        {
            InicioPersExterno pagina = new InicioPersExterno();
            this.Visible = false;
            pagina.ShowDialog();
            this.Visible = true;
        }

        private void bExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
