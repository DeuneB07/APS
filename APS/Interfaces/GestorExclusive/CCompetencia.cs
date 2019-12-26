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
    public partial class CCompetencia : UserControl
    {
        private Competencia comp;
        public CCompetencia(Competencia comp)
        {
            InitializeComponent();
            this.comp = comp;

            lShowTipo.Text = comp.NombreComp;
            lShowDesc.Text = comp.DescComp;
        }
    }
}
