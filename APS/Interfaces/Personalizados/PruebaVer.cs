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
    public partial class PruebaVer : Form
    {
        public PruebaVer(Asignatura asignatura)
        {
            InitializeComponent();

            label1.Text = asignatura.Grado.NombreGrado;
            label2.Text = asignatura.NombreAsig;
        }
    }
}
