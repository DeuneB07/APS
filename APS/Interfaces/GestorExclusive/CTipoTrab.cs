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

    public partial class CTipoTrab : UserControl
    {

        private TipoTrabajo tipoT;
        public CTipoTrab(TipoTrabajo tipo)
        {
            InitializeComponent();
            this.tipoT = tipo;

            lShowTipo.Text = tipoT.Tipo_Trabajo;
        }
    }
}
