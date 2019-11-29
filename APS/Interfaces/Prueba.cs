using APS.Mapeo;
using APS.Properties;
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
    public partial class Prueba : Form
    {
        public Prueba()
        {
            InitializeComponent();
            cargarCosas();
        }


        private void cargarCosas()
        {

            List<Asignatura> la = Asignatura.ListaAsignaturas();
            //Console.WriteLine("HOLAAAA: "+la.Count);
            Cartel[] carteles = new Cartel[la.Count];
            tabPage1.Controls.Add(panel1);

            int c = 0;
            foreach(Asignatura a in la)
            {
                carteles[c] = new Cartel();
                carteles[c].Titulo = a.NombreAsig;
                carteles[c].Description = a.Grado.NombreGrado;
                carteles[c].ImagenActividad = Resources.mascot_allsides;

                //if (tabPage1.Controls.Count > 0)
                //{
                //    tabPage1.Controls.Clear();
                //}
                //else
                
                panel1.Controls.Add(carteles[c]);
                carteles[c].Location = new Point(carteles[c].Location.X, (carteles[c].Size.Height * c)+50);
                
                Console.WriteLine("TAAAAAAM: " + (c));
                c++;
            }
        }
    }
}
