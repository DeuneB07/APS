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
    public partial class CGrado : UserControl
    {

        private Grado g;
        public CGrado(Grado g)
        {
            InitializeComponent();
            this.g = g;

            lShowNoun.Text = g.NombreGrado;
            lShowMatriculados.Text = Grado.AlumnosPorGrado(g).ToString();
            lShowNumAsig.Text = Grado.ListaAsignaturas(g).ToString();
        }
    }
}
