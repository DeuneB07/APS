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
    public partial class CAmbTrab : UserControl
    {

        private AmbitoTrabajo amb;
        public CAmbTrab(AmbitoTrabajo amb)
        {
            InitializeComponent();
            this.amb = amb;
            lShowAmb.Text = amb.Ambito_Trabajo;
        }
    }
}
