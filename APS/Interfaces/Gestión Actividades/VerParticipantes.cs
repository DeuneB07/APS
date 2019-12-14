using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using APS.Mapeo;
using APS.Interfaces.Personalizados;

namespace APS.Interfaces.Gestión_Actividades
{
    public partial class VerParticipantes : Form
    {
        private Usuario logeado;
        private Actividad actividad;
        public VerParticipantes(Actividad actividad, Usuario logeado)
        {
            InitializeComponent();
            this.actividad = actividad;
            this.logeado = logeado;
            tabSolicitudes.Visible = true;

            if (logeado.Rol.NombreRol.Equals("ONG"))
            {
                cargarPendientesONG();
                tabSolicitudes.Controls.Remove(this.pSolicitudesEnEsperaONG);
            }
            else
            {
                cargarPendientesPDI();
                cargarEnEsperaONG();
            }
            cargarAceptadas();
        }

        private void cargarEnEsperaONG()
        {
            pSolicitudesEnEsperaONG.Controls.Clear();
            panelSolicitudesEsperaONG.AutoScroll = false;
            panelSolicitudesEsperaONG.AutoScroll = true;
            pSolicitudesEnEsperaONG.Controls.Add(panelSolicitudesEsperaONG);
            panelSolicitudesEsperaONG.RowCount = 1;
            panelSolicitudesEsperaONG.Controls.Clear();

            List<Usuario> lista = Actividad_Solicitud.ListaActividadesSolicitudes(actividad, Actividad_Solicitud.EstadoActividadSolicitudE.EN_ESPERA_ONG);
            CartelSolicitantesActividad[] carSolAct = new CartelSolicitantesActividad[lista.Count];

            int c = 0;
            foreach (Usuario user in lista)
            {
                if (actividad.Responsable.Equals(logeado))
                {
                    carSolAct[c] = new CartelSolicitantesActividad(logeado, user);
                    panelSolicitudesEsperaONG.Controls.Add(carSolAct[c], 0, c);
                    panelSolicitudesEsperaONG.RowCount = panelSolicitudesEsperaONG.RowCount + 1;
                    carSolAct[c].Location = new Point(carSolAct[c].Location.X, (carSolAct[c].Size.Height * c));
                    carSolAct[c].BackColor = Color.Orange;

                    //BOTONES
                    Panel panel = (Panel)carSolAct[c].Controls.Find("panel1", false)[0];
                    Button bAceptar = (Button)panel.Controls.Find("bAceptar", false)[0];
                    Button bRechazar = (Button)panel.Controls.Find("bRechazar", false)[0];

                    bAceptar.Visible = false;
                    bRechazar.Visible = false;

                    c++;
                }
            }
        }

        private void cargarAceptadas()
        {
            pSolicitudesAceptadas.Controls.Clear();
            panelSolAceptadas.AutoScroll = false;
            panelSolAceptadas.AutoScroll = true;
            pSolicitudesAceptadas.Controls.Add(panelSolAceptadas);
            panelSolAceptadas.RowCount = 1;
            panelSolAceptadas.Controls.Clear();

            List<Usuario> lista = Actividad_Solicitud.ListaActividadesSolicitudes(actividad, Actividad_Solicitud.EstadoActividadSolicitudE.ACEPTADA);
            CartelSolicitantesActividad[] carSolAct = new CartelSolicitantesActividad[lista.Count];

            int c = 0;
            foreach (Usuario user in lista)
            {
                carSolAct[c] = new CartelSolicitantesActividad(logeado, user);
                panelSolAceptadas.Controls.Add(carSolAct[c], 0, c);
                panelSolAceptadas.RowCount = panelSolAceptadas.RowCount + 1;
                carSolAct[c].Location = new Point(carSolAct[c].Location.X, (carSolAct[c].Size.Height * c));
                carSolAct[c].BackColor = Color.Green;

                 //BOTONES
                Panel panel = (Panel)carSolAct[c].Controls.Find("panel1", false)[0];
                Button bAceptar = (Button)panel.Controls.Find("bAceptar", false)[0];
                Button bRechazar = (Button)panel.Controls.Find("bRechazar", false)[0];

                bAceptar.Visible = false;
                bRechazar.Visible = false;

                c++;
            }
        }

        private void cargarPendientesPDI()
        {
            pSolicitudesPendientes.Controls.Clear();
            panelSolPendientes.AutoScroll = false;
            panelSolPendientes.AutoScroll = true;
            pSolicitudesPendientes.Controls.Add(panelSolPendientes);
            panelSolPendientes.RowCount = 1;
            panelSolPendientes.Controls.Clear();

            List<Usuario> lista = Actividad_Solicitud.ListaActividadesSolicitudes(actividad,Actividad_Solicitud.EstadoActividadSolicitudE.EN_ESPERA_PDI);
            CartelSolicitantesActividad[] carSolAct = new CartelSolicitantesActividad[lista.Count];

            int c = 0;
            foreach(Usuario user in lista)
            {
                if (actividad.Responsable.Equals(logeado))
                {
                    carSolAct[c] = new CartelSolicitantesActividad(logeado,user);
                    panelSolPendientes.Controls.Add(carSolAct[c], 0, c);
                    panelSolPendientes.RowCount = panelSolPendientes.RowCount + 1;
                    carSolAct[c].Location = new Point(carSolAct[c].Location.X, (carSolAct[c].Size.Height * c));
                    carSolAct[c].BackColor = Color.Orange;

                    //BOTONES
                    Panel panel = (Panel)carSolAct[c].Controls.Find("panel1", false)[0];
                    Button bAceptar = (Button)panel.Controls.Find("bAceptar", false)[0];
                    Button bRechazar = (Button)panel.Controls.Find("bDenegar", false)[0];

                    //PROGRAMACIÓN BOTONES
                    bAceptar.Click += (sender, EventArgs) => { bAceptarPDI_Click(sender, EventArgs, user); };
                    bRechazar.Click += (sender, EventArgs) => { bRechazar_Click(sender, EventArgs, user); };

                    c++;
                }
            }
        }

        private void cargarPendientesONG()
        {
            pSolicitudesPendientes.Controls.Clear();
            panelSolPendientes.AutoScroll = false;
            panelSolPendientes.AutoScroll = true;
            pSolicitudesPendientes.Controls.Add(panelSolPendientes);
            panelSolPendientes.RowCount = 1;
            panelSolPendientes.Controls.Clear();

            List<Usuario> lista = Actividad_Solicitud.ListaActividadesSolicitudes(actividad, Actividad_Solicitud.EstadoActividadSolicitudE.EN_ESPERA_ONG);
            CartelSolicitantesActividad[] carSolAct = new CartelSolicitantesActividad[lista.Count];

            int c = 0;
            foreach (Usuario user in lista)
            {
                if (actividad.Organizador.Equals(logeado))
                {
                    carSolAct[c] = new CartelSolicitantesActividad(logeado, user);
                    panelSolPendientes.Controls.Add(carSolAct[c], 0, c);
                    panelSolPendientes.RowCount = panelSolPendientes.RowCount + 1;
                    carSolAct[c].Location = new Point(carSolAct[c].Location.X, (carSolAct[c].Size.Height * c));
                    carSolAct[c].BackColor = Color.Orange;

                    //BOTONES
                    Panel panel = (Panel)carSolAct[c].Controls.Find("panel1", false)[0];
                    Button bAceptar = (Button)panel.Controls.Find("bAceptar", false)[0];
                    Button bRechazar = (Button)panel.Controls.Find("bRechazar", false)[0];

                    //PROGRAMACIÓN BOTONES
                    bAceptar.Click += (sender, EventArgs) => { bAceptarONG_Click(sender, EventArgs, user); };
                    bRechazar.Click += (sender, EventArgs) => { bRechazar_Click(sender, EventArgs, user); };

                    c++;
                }
            }
        }

        private void bAceptarONG_Click(object sender, EventArgs eventArgs, Usuario user)
        {
            Actividad_Solicitud actSolicitud = new Actividad_Solicitud(user, actividad);
            actSolicitud.EstadoSolicitud = Actividad_Solicitud.EstadoActividadSolicitudE.ACEPTADA;
            cargarPendientesONG();
            cargarAceptadas();
        }

        private void bAceptarPDI_Click(object sender, EventArgs eventArgs, Usuario user)
        {
            Actividad_Solicitud actSolicitud = new Actividad_Solicitud(user, actividad);
            actSolicitud.EstadoSolicitud = Actividad_Solicitud.EstadoActividadSolicitudE.EN_ESPERA_ONG;
            cargarPendientesPDI();
        }

        private void bRechazar_Click(object sender, EventArgs eventArgs, Usuario user)
        {
            Actividad_Solicitud actSolicitud = new Actividad_Solicitud(user, actividad);
            actSolicitud.EstadoSolicitud = Actividad_Solicitud.EstadoActividadSolicitudE.DENEGADA;

            if (logeado.Rol.NombreRol.Equals("PDI"))
            {
                cargarPendientesPDI();
            }
            else
            {
                cargarPendientesONG();
            }
        }
    }
}
