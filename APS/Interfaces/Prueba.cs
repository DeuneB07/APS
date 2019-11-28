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
    public partial class Prueba : Form
    {
        public Prueba()
        {
            InitializeComponent();

            //tabPage1.AutoScroll = true;
            //cargarTodasActividades();
            cargarCosas();
        }

        private void cargarCosas()
        {
            int index = 0;
            foreach (Asignatura a in Asignatura.ListaAsignaturas(new Usuario("jmmunoz@uma.es")))
            {
                index++;
                Panel panel = grandChildPanel;

                Label l2 = label1;
                Label l3 = label2;
                l2.Text = a.NombreAsig;
                l3.Text = a.Grado.NombreGrado;

                ChildPanel.Controls.Add(panel);
                panel.Top = grandChildPanel.Top + grandChildPanel.Height;
                ChildPanel.Height = grandChildPanel.Height*index;
                vScrollBar1.Maximum = ChildPanel.Height;
            }
        }

        private void cargarTodasActividades()
        {
            
            int c = 1;

            foreach (Asignatura a in Asignatura.ListaAsignaturas(new Usuario("jmmunoz@uma.es")))
            {
                Panel panel = new Panel();
                panel.AutoSize = true;

                
                Label lNombreAct = new Label();
                Label lDescripcionAct = new Label();
                lNombreAct.AutoSize = true;
                lDescripcionAct.AutoSize = true;

                lNombreAct.Text = a.NombreAsig;
                lDescripcionAct.Text = a.Grado.ToString();

                panel.Controls.Add(lNombreAct);
                panel.Controls.Add(lDescripcionAct);

                //tabPage1.Controls.Add(panel);
                panel.AutoSize = true;
            }

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
