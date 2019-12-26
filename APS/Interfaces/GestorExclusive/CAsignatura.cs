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
    public partial class CAsignatura : UserControl
    {
        private Asignatura asig;
        public CAsignatura(Asignatura asig)
        {
            InitializeComponent();
            this.asig = asig;

            lShowNoun.Text = asig.NombreAsig;
            lShowGrado.Text = asig.Grado.NombreGrado;
        }
    }
}
