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


        //
        // Participantes ONG
        //
        private void cargarParticipantesONG()
        {
            //Participantes que han pasado al PDI
            if (!actividad.TipoAct.Equals(Actividad.TipoActividadE.VOLUNTARIADO)) cargarParticipantesTurnoPDI();
            else tabValoraciones.TabPages.Remove(pEnProceso);

            cargarParticipantesPorEvaluarONG(); //Participante que se debe Evaluar
            cargarParticipantesAusentesONG();   //Participante que aún no han Evaluado
            cargarParticipantesEvaluadosONG();  //Participante Evaluados del Todo
            
        }

        private void cargarParticipantesPorEvaluarONG()
        {

            pPorEvaluar.Controls.Clear();
            panelPorEvaluar.AutoScroll = false;
            panelPorEvaluar.AutoScroll = true;
            pPorEvaluar.Controls.Add(panelPorEvaluar);
            panelPorEvaluar.RowCount = 1;
            panelPorEvaluar.Controls.Clear();

            List<Actividad_Realizada> lista = Actividad_Realizada.ListaActividadesRealizadas(actividad, Actividad_Realizada.EstadoActividadR.EVALUACION_ONG);
            CartelParticipante[] cartParticipante = new CartelParticipante[lista.Count];

            int c = 0;
            foreach (Actividad_Realizada act in lista)
            {
                cartParticipante[c] = new CartelParticipante(act.Participante);
                panelPorEvaluar.Controls.Add(cartParticipante[c], 0, c);
                panelPorEvaluar.RowCount = panelPorEvaluar.RowCount + 1;
                cartParticipante[c].Location = new Point(cartParticipante[c].Location.X, (cartParticipante[c].Size.Height * c));
                cartParticipante[c].BackColor = Color.MistyRose;

                //BOTON SOLICITAR
                Panel panel = (Panel)cartParticipante[c].Controls.Find("panel1", false)[0];
                Button bEvaluar = (Button)panel.Controls.Find("bEvaluar", false)[0];

                //PROGRAMACIÓN BOTONES
                bEvaluar.Click += (sender, EventArgs) => { bEvaluarONG_Click(sender, EventArgs, act); };
                c++;
            }
        }

        private void cargarParticipantesAusentesONG()
        {
            pAusente.Controls.Clear();
            panelAusentes.AutoScroll = false;
            panelAusentes.AutoScroll = true;
            pAusente.Controls.Add(panelAusentes);
            panelAusentes.RowCount = 1;
            panelAusentes.Controls.Clear();

            List<Actividad_Realizada> lista = Actividad_Realizada.ListaActividadesRealizadas(actividad, Actividad_Realizada.EstadoActividadR.EVALUACION_PARTICIPANTE);
            CartelParticipante[] cartParticipante = new CartelParticipante[lista.Count];

            int c = 0;
            foreach (Actividad_Realizada act in lista)
            {
                cartParticipante[c] = new CartelParticipante(act.Participante);
                panelAusentes.Controls.Add(cartParticipante[c], 0, c);
                panelAusentes.RowCount = panelAusentes.RowCount + 1;
                cartParticipante[c].Location = new Point(cartParticipante[c].Location.X, (cartParticipante[c].Size.Height * c));
                cartParticipante[c].BackColor = Color.LightGray;

                //BOTON SOLICITAR
                Panel panel = (Panel)cartParticipante[c].Controls.Find("panel1", false)[0];
                Button bEvaluar = (Button)panel.Controls.Find("bEvaluar", false)[0];
                bEvaluar.Visible = false;

                c++;
            }
        }

        private void cargarParticipantesTurnoPDI()
        {
            pEnProceso.Controls.Clear();
            panelEnProceso.AutoScroll = false;
            panelEnProceso.AutoScroll = true;
            pEnProceso.Controls.Add(panelEnProceso);
            panelEnProceso.RowCount = 1;
            panelEnProceso.Controls.Clear();

            List<Actividad_Realizada> lista = Actividad_Realizada.ListaActividadesRealizadas(actividad, Actividad_Realizada.EstadoActividadR.EVALUACION_PDI);
            CartelParticipante[] cartParticipante = new CartelParticipante[lista.Count];

            int c = 0;
            foreach (Actividad_Realizada act in lista)
            {
                cartParticipante[c] = new CartelParticipante(act.Participante);
                panelEnProceso.Controls.Add(cartParticipante[c], 0, c);
                panelEnProceso.RowCount = panelEnProceso.RowCount + 1;
                cartParticipante[c].Location = new Point(cartParticipante[c].Location.X, (cartParticipante[c].Size.Height * c));
                cartParticipante[c].BackColor = Color.Blue;

                //BOTON SOLICITAR
                Panel panel = (Panel)cartParticipante[c].Controls.Find("panel1", false)[0];
                Button bEvaluar = (Button)panel.Controls.Find("bEvaluar", false)[0];
                bEvaluar.Visible = false;

                c++;
            }
        }

        private void cargarParticipantesEvaluadosONG()
        {
            pEvaluados.Controls.Clear();
            panelEvaluados.AutoScroll = false;
            panelEvaluados.AutoScroll = true;
            pEvaluados.Controls.Add(panelEvaluados);
            panelEvaluados.RowCount = 1;
            panelEvaluados.Controls.Clear();

            List<Actividad_Realizada> lista = Actividad_Realizada.ListaActividadesRealizadas(actividad, Actividad_Realizada.EstadoActividadR.EVALUACION_FINALIZADA);
            CartelParticipante[] cartParticipante = new CartelParticipante[lista.Count];

            int c = 0;
            foreach (Actividad_Realizada act in lista)
            {
                cartParticipante[c] = new CartelParticipante(act.Participante);
                panelEvaluados.Controls.Add(cartParticipante[c], 0, c);
                panelEvaluados.RowCount = panelEvaluados.RowCount + 1;
                cartParticipante[c].Location = new Point(cartParticipante[c].Location.X, (cartParticipante[c].Size.Height * c));
                cartParticipante[c].BackColor = Color.SpringGreen;

                //BOTON SOLICITAR
                Panel panel = (Panel)cartParticipante[c].Controls.Find("panel1", false)[0];
                Button bEvaluar = (Button)panel.Controls.Find("bEvaluar", false)[0];
                bEvaluar.Visible = false;

                c++;
            }
        }

        private void bEvaluarONG_Click(object sender, EventArgs eventArgs, Actividad_Realizada act)
        {
            EvaluarUsuarioONG evUser = new EvaluarUsuarioONG(act);
            evUser.ShowDialog();
            cargarParticipantesONG();
        }

        //
        // Participantes PDI
        //
        private void cargarParticipantesPDI()
        {

            cargarParticipantesTurnoONG();      //Participantes que han pasado a la ONG
            cargarParticipantesPorEvaluarPDI(); //Participante que se debe Evaluar
            cargarParticipantesAusentesPDI();   //Participante que aún no han Evaluado
            cargarParticipantesEvaluadosPDI();  //Participante Evaluados del Todo

        }

        private void cargarParticipantesPorEvaluarPDI()
        {

            pPorEvaluar.Controls.Clear();
            panelPorEvaluar.AutoScroll = false;
            panelPorEvaluar.AutoScroll = true;
            pPorEvaluar.Controls.Add(panelPorEvaluar);
            panelPorEvaluar.RowCount = 1;
            panelPorEvaluar.Controls.Clear();

            List<Actividad_Realizada> lista = Actividad_Realizada.ListaActividadesRealizadas(actividad, Actividad_Realizada.EstadoActividadR.EVALUACION_PDI);
            CartelParticipante[] cartParticipante = new CartelParticipante[lista.Count];

            int c = 0;
            foreach (Actividad_Realizada act in lista)
            {
                cartParticipante[c] = new CartelParticipante(act.Participante);
                panelPorEvaluar.Controls.Add(cartParticipante[c], 0, c);
                panelPorEvaluar.RowCount = panelPorEvaluar.RowCount + 1;
                cartParticipante[c].Location = new Point(cartParticipante[c].Location.X, (cartParticipante[c].Size.Height * c));
                cartParticipante[c].BackColor = Color.Blue;

                //BOTON SOLICITAR
                Panel panel = (Panel)cartParticipante[c].Controls.Find("panel1", false)[0];
                Button bEvaluar = (Button)panel.Controls.Find("bEvaluar", false)[0];

                //PROGRAMACIÓN BOTONES
                bEvaluar.Click += (sender, EventArgs) => { bEvaluarPDI_Click(sender, EventArgs, act); };
                c++;
            }
        }

        private void cargarParticipantesAusentesPDI()
        {
            pAusente.Controls.Clear();
            panelAusentes.AutoScroll = false;
            panelAusentes.AutoScroll = true;
            pAusente.Controls.Add(panelAusentes);
            panelAusentes.RowCount = 1;
            panelAusentes.Controls.Clear();

            List<Actividad_Realizada> lista = Actividad_Realizada.ListaActividadesRealizadas(actividad, Actividad_Realizada.EstadoActividadR.EVALUACION_PARTICIPANTE);
            CartelParticipante[] cartParticipante = new CartelParticipante[lista.Count];

            int c = 0;
            foreach (Actividad_Realizada act in lista)
            {
                cartParticipante[c] = new CartelParticipante(act.Participante);
                panelAusentes.Controls.Add(cartParticipante[c], 0, c);
                panelAusentes.RowCount = panelAusentes.RowCount + 1;
                cartParticipante[c].Location = new Point(cartParticipante[c].Location.X, (cartParticipante[c].Size.Height * c));
                cartParticipante[c].BackColor = Color.LightGray;

                //BOTON SOLICITAR
                Panel panel = (Panel)cartParticipante[c].Controls.Find("panel1", false)[0];
                Button bEvaluar = (Button)panel.Controls.Find("bEvaluar", false)[0];
                bEvaluar.Visible = false;

                c++;
            }
        }

        private void cargarParticipantesTurnoONG()
        {
            pEnProceso.Controls.Clear();
            panelEnProceso.AutoScroll = false;
            panelEnProceso.AutoScroll = true;
            pEnProceso.Controls.Add(panelEnProceso);
            panelEnProceso.RowCount = 1;
            panelEnProceso.Controls.Clear();

            List<Actividad_Realizada> lista = Actividad_Realizada.ListaActividadesRealizadas(actividad, Actividad_Realizada.EstadoActividadR.EVALUACION_ONG);
            CartelParticipante[] cartParticipante = new CartelParticipante[lista.Count];

            int c = 0;
            foreach (Actividad_Realizada act in lista)
            {
                cartParticipante[c] = new CartelParticipante(act.Participante);
                panelEnProceso.Controls.Add(cartParticipante[c], 0, c);
                panelEnProceso.RowCount = panelEnProceso.RowCount + 1;
                cartParticipante[c].Location = new Point(cartParticipante[c].Location.X, (cartParticipante[c].Size.Height * c));
                cartParticipante[c].BackColor = Color.MistyRose;

                //BOTON SOLICITAR
                Panel panel = (Panel)cartParticipante[c].Controls.Find("panel1", false)[0];
                Button bEvaluar = (Button)panel.Controls.Find("bEvaluar", false)[0];
                bEvaluar.Visible = false;

                c++;
            }
        }

        private void cargarParticipantesEvaluadosPDI()
        {
            pEvaluados.Controls.Clear();
            panelEvaluados.AutoScroll = false;
            panelEvaluados.AutoScroll = true;
            pEvaluados.Controls.Add(panelEvaluados);
            panelEvaluados.RowCount = 1;
            panelEvaluados.Controls.Clear();

            List<Actividad_Realizada> lista = Actividad_Realizada.ListaActividadesRealizadas(actividad, Actividad_Realizada.EstadoActividadR.EVALUACION_FINALIZADA);
            CartelParticipante[] cartParticipante = new CartelParticipante[lista.Count];

            int c = 0;
            foreach (Actividad_Realizada act in lista)
            {
                cartParticipante[c] = new CartelParticipante(act.Participante);
                panelEvaluados.Controls.Add(cartParticipante[c], 0, c);
                panelEvaluados.RowCount = panelEvaluados.RowCount + 1;
                cartParticipante[c].Location = new Point(cartParticipante[c].Location.X, (cartParticipante[c].Size.Height * c));
                cartParticipante[c].BackColor = Color.SpringGreen;

                //BOTON SOLICITAR
                Panel panel = (Panel)cartParticipante[c].Controls.Find("panel1", false)[0];
                Button bEvaluar = (Button)panel.Controls.Find("bEvaluar", false)[0];
                bEvaluar.Visible = false;

                c++;
            }
        }

        private void bEvaluarPDI_Click(object sender, EventArgs eventArgs, Actividad_Realizada act)
        {
            EvaluarUsuarioPDI evUser = new EvaluarUsuarioPDI(act);
            evUser.ShowDialog();
            cargarParticipantesPDI();
        }
    }



    /*
    private void cargarParticipantesPorEvaluarONG()
    {

        panelParticipantes.Controls.Clear();
        panelParticipantes.RowCount = 1;
        panelParticipantes.AutoScroll = false;
        panel1.AutoScroll = false;
        panel1.AutoScroll = true;

        List<Actividad_Realizada> lista = Actividad_Realizada.ListaActividadesRealizadas(actividad, Actividad_Realizada.EstadoActividadR.EVALUACION_ONG);
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
            bEvaluar.Click += (sender, EventArgs) => { bEvaluarONG_Click(sender, EventArgs, act); };
            c++;
        }
    }
    */

    /*
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
    }*/

}
