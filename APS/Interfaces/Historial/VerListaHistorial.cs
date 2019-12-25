using APS.Interfaces.Gestión_Actividades;
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
            if (user.NombreUser!=null && !user.NombreUser.Equals("")) this.labelTitulo.Text = "HISTORIAL " + user.NombreUser;
            else this.labelTitulo.Text = "HISTORIAL " + user.Nombre;

            cargarHistorialEventosDescendente();
        }

        
        public void cargarHistorialEventosDescendente()
        {
            tablePP.Controls.Clear();
            tablePP.RowCount = 1;
            tablePP.AutoScroll = false;
            panelHistorial.AutoScroll = false;
            panelHistorial.AutoScroll = true;

            List<Mapeo.Historial> lista = Mapeo.Historial.ListaHistorialDesc(user);
            CargarCarteles(lista);
        }

        public void cargarHistorialEventosAscendente()
        {
            tablePP.Controls.Clear();
            tablePP.RowCount = 1;
            tablePP.AutoScroll = false;
            panelHistorial.AutoScroll = false;
            panelHistorial.AutoScroll = true;

            List<Mapeo.Historial> lista = Mapeo.Historial.ListaHistorialAsc(user);
            CargarCarteles(lista);
        }

        private void cargarHistorialActividadesRealizadasDescendente()
        {
            tablePP.Controls.Clear();
            tablePP.RowCount = 1;
            tablePP.AutoScroll = false;
            panelHistorial.AutoScroll = false;
            panelHistorial.AutoScroll = true;

            List<Actividad_Realizada> lista = Actividad_Realizada.ListaActividadesRealizadasDescendente(user);
            CargarCarteles(lista);
        }

        private void cargarHistorialActividadesRealizadasAscendente()
        {
            tablePP.Controls.Clear();
            tablePP.RowCount = 1;
            tablePP.AutoScroll = false;
            panelHistorial.AutoScroll = false;
            panelHistorial.AutoScroll = true;

            List<Actividad_Realizada> lista = Actividad_Realizada.ListaActividadesRealizadasAscendente(user);
            CargarCarteles(lista);
        }

        private void CargarCarteles(List<Mapeo.Historial> lista)
        {
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
                Panel panel = (Panel)carteles[c].Controls.Find("panel1", false)[0];
                Button bVerTodo = (Button)panel.Controls.Find("bVerTodo", false)[0];

                if (h.Actividad != null)
                {
                    if (Actividad_Realizada.Contains(h.Usuario, h.Actividad))
                    {
                        Actividad_Realizada actRealizada = new Actividad_Realizada(h.Usuario, h.Actividad);
                        //MOSTRAR VISTA DE LA ACTIVIDAD_REALIZADA
                        bVerTodo.Click += (sender, EventArgs) => { bVerTodo_Click(sender, EventArgs, actRealizada); };
                    }
                    else
                    {
                        //MOSTRAR VISTA DE SÓLO LA ACTIVIDAD
                        bVerTodo.Click += (sender, EventArgs) => { bVerTodo_Click(sender, EventArgs, h.Actividad); };
                    }

                }

                c++;
            }
        }

        private void CargarCarteles(List<Actividad_Realizada> lista)
        {
            CartelActividadesRealizadas[] carteles = new CartelActividadesRealizadas[lista.Count];

            int c = 0;
            foreach (Actividad_Realizada act in lista)
            {
                CartelActividadesRealizadas cartel = new CartelActividadesRealizadas(user,act);
                if (c % 3 == 0) cartel.BackColor = System.Drawing.Color.DarkBlue;
                if (c % 3 == 1) cartel.BackColor = System.Drawing.Color.DarkCyan;
                if (c % 3 == 2) cartel.BackColor = System.Drawing.Color.LightBlue;
                carteles[c] = cartel;
                tablePP.Controls.Add(carteles[c], 0, c);
                tablePP.RowCount = tablePP.RowCount + 1;
                carteles[c].Location = new Point(carteles[c].Location.X, (carteles[c].Size.Height * c));

                c++;
            }
        }

        private void bVerTodo_Click(object sender, EventArgs eventArgs, Actividad_Realizada actRealizada)
        {
            VerActividadRealizada verActividad = new VerActividadRealizada(user, actRealizada);
            verActividad.ShowDialog();
        }

        private void bVerTodo_Click(object sender, EventArgs eventArgs, Actividad actividad)
        {
            VerActividadAbierta verActividad = new VerActividadAbierta(user,actividad);
            verActividad.ShowDialog();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEventos_Click(object sender, EventArgs e)
        {
            if (!lblEv_Act.Text.Equals("Eventos"))
            {
                lblEv_Act.Text = "Eventos";
                if (lblOrden2.Text.Equals("Descendente"))
                {
                    cargarHistorialEventosDescendente();
                }
                else
                {
                    cargarHistorialEventosAscendente();
                }
            }
        }

        private void pictOrden_Click(object sender, EventArgs e)
        {
            if (lblOrden2.Text.Equals("Descendente"))
            {
                pictOrden.BackgroundImage = global::APS.Properties.Resources.uparrow_arriba_10286;
                lblOrden2.Text ="Ascendente";
                if (lblEv_Act.Text.Equals("Eventos")) cargarHistorialEventosAscendente();
                else cargarHistorialActividadesRealizadasAscendente();
            }
            else
            {
                pictOrden.BackgroundImage = global::APS.Properties.Resources.downarrow_abajo_10289;
                lblOrden2.Text = "Descendente";
                if (lblEv_Act.Text.Equals("Eventos")) cargarHistorialEventosDescendente();
                else cargarHistorialActividadesRealizadasDescendente();
            }
        }

        private void btnActRealizadas_Click(object sender, EventArgs e)
        {
            if (!lblEv_Act.Text.Equals("Actividades Realizadas"))
            {
                lblEv_Act.Text = "Actividades Realizadas";
                if (lblOrden2.Text.Equals("Descendente"))
                {
                    cargarHistorialActividadesRealizadasDescendente();
                }
                else
                {
                    cargarHistorialActividadesRealizadasAscendente();
                }
            }
        }
    }
}
