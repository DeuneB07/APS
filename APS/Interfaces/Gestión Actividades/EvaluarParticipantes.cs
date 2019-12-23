using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using APS.Interfaces.Personalizados;
using APS.Mapeo;

namespace APS.Interfaces.Gestión_Actividades
{
    public partial class EvaluarParticipantes : Form
    {
        private Actividad actividad;
        private Usuario user;
        public EvaluarParticipantes(Usuario user, Actividad actividad)
        {
            InitializeComponent();
            this.actividad = actividad;
            this.user = user;
            if (user.Rol.NombreRol.Equals("ONG")) cargarParticipantesONG();
            else cargarParticipantesPDI();
        }

        private void cargarParticipantesONG()
        {
            panelParticipantes.Controls.Clear();
            panelParticipantes.RowCount = 1;
            panelParticipantes.AutoScroll = false;
            panel1.AutoScroll = false;
            panel1.AutoScroll = true;

            List<Actividad_Realizada> lista = Actividad_Realizada.ListaActividadesRealizadas(actividad, Actividad_Realizada.EstadoActividadR.EVALUACION_ONG);
            CartelParticipante[] cartParticipante = new CartelParticipante[lista.Count];

            int c = 0;
            foreach(Actividad_Realizada act in lista)
            {
                cartParticipante[c] = new CartelParticipante(act.Participante);
                panelParticipantes.Controls.Add(cartParticipante[c], 0, c + 1);
                panelParticipantes.RowCount = panelParticipantes.RowCount + 1;
                cartParticipante[c].Location = new Point(cartParticipante[c].Location.X, (cartParticipante[c].Size.Height * c));
                cartParticipante[c].BackColor = Color.Aqua;

                //BOTON SOLICITAR
                Panel panel = (Panel)cartParticipante[c].Controls.Find("panel1", false)[0];
                Button bEvaluar = (Button)panel.Controls.Find("bEvaluar", false)[0];
                //PROGRAMACIÓN BOTONES
                bEvaluar.Click += (sender, EventArgs) => { bEvaluarONG_Click(sender, EventArgs, act); };
                c++;
            }
        }

        private void bEvaluarONG_Click(object sender, EventArgs eventArgs, Actividad_Realizada act)
        {
            EvaluarUsuarioONG evUser = new EvaluarUsuarioONG(act);
            evUser.ShowDialog();
            cargarParticipantesONG();
        }

        private void cargarParticipantesPDI()
        {
            panelParticipantes.Controls.Clear();
            panelParticipantes.RowCount = 1;
            panelParticipantes.AutoScroll = false;
            panel1.AutoScroll = false;
            panel1.AutoScroll = true;

            List<Actividad_Realizada> lista = Actividad_Realizada.ListaActividadesRealizadas(actividad, Actividad_Realizada.EstadoActividadR.EVALUACION_PDI);
            CartelParticipante[] cartParticipante = new CartelParticipante[lista.Count];

            int c = 0;
            foreach (Actividad_Realizada act in lista)
            {
                cartParticipante[c] = new CartelParticipante(act.Participante);
                panelParticipantes.Controls.Add(cartParticipante[c], 0, c + 1);
                panelParticipantes.RowCount = panelParticipantes.RowCount + 1;
                cartParticipante[c].Location = new Point(cartParticipante[c].Location.X, (cartParticipante[c].Size.Height * c));
                cartParticipante[c].BackColor = Color.Aqua;

                //BOTON SOLICITAR
                Panel panel = (Panel)cartParticipante[c].Controls.Find("panel1", false)[0];
                Button bEvaluar = (Button)panel.Controls.Find("bEvaluar", false)[0];
                //PROGRAMACIÓN BOTONES
                bEvaluar.Click += (sender, EventArgs) => { bEvaluarPDI_Click(sender, EventArgs, act); };
                c++;
            }
        }

        private void bEvaluarPDI_Click(object sender, EventArgs eventArgs, Actividad_Realizada act)
        {
            EvaluarUsuarioPDI evUser = new EvaluarUsuarioPDI(act);
            evUser.ShowDialog();
            cargarParticipantesONG();
        }
    }
}
