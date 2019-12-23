using APS.Interfaces.Personalizados;
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

namespace APS.Interfaces.Historial
{
    public partial class VerListaHistorial : Form
    {
        private Usuario user;

        public VerListaHistorial(Usuario user)
        {
            InitializeComponent();
            this.user = user;

            cargarHistorial();
        }

        
        public void cargarHistorial()
        {
            try
            {
                tablePP.Controls.Clear();
                tablePP.RowCount = 1;
                tablePP.AutoScroll = false;
                panelHistorial.AutoScroll = false;
                panelHistorial.AutoScroll = true;

                List<Mapeo.Historial> lista = Mapeo.Historial.ListaHistorial(user);
                CartelHistorial[] carteles = new CartelHistorial[lista.Count];

                int c = 0;
                foreach (Mapeo.Historial h in lista)
                {
                    CartelHistorial cartel = new CartelHistorial(h);
                    if (c % 3 == 0) cartel.BackColor = System.Drawing.Color.DarkRed;
                    if (c % 3 == 1) cartel.BackColor = System.Drawing.Color.Firebrick;
                    if (c % 3 == 2) cartel.BackColor = System.Drawing.Color.IndianRed;
                    carteles[c] = cartel;
                    tablePP.Controls.Add(carteles[c], 0, c);
                    tablePP.RowCount = tablePP.RowCount + 1;
                    carteles[c].Location = new Point(carteles[c].Location.X, (carteles[c].Size.Height * c));
                    
                    //Programar verTodo


                    c++;
                }
            }catch(Exception e)
            {
                MessageBox.Show(e.Message);
                Console.WriteLine(e.StackTrace);
            }

        }

    }
}
