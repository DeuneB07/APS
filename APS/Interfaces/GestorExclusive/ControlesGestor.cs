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

namespace APS.Interfaces.GestorExclusive
{
    public partial class ControlesGestor : Form
    {

        private enum opcion { TIPO_TRABAJO, AMBITO_TRABAJO, GRADOS, ASIGNATURAS, USUARIOS, SOLICITUDES, COMPETENCIAS, NOTHING};
        private opcion charged;

        public ControlesGestor()
        {
            InitializeComponent();
            charged = opcion.NOTHING;
        }

        //COMPROBACIONES
        private void pictCompetencia_Click(object sender, EventArgs e)
        {
            if (!charged.Equals(opcion.COMPETENCIAS))
            {
                panelContainer.Visible = true;
                bInsertar.Visible = true;
                charged = opcion.COMPETENCIAS;
                cargarCompetencias();
            }
        }

        private void pictAmbTrab_Click(object sender, EventArgs e)
        {
            if (!charged.Equals(opcion.AMBITO_TRABAJO))
            {
                panelContainer.Visible = true;
                bInsertar.Visible = true;
                charged = opcion.AMBITO_TRABAJO;
                cargarAmbitosTrabajo();
            }
        }

        private void pictTipoTrab_Click(object sender, EventArgs e)
        {
            if (!charged.Equals(opcion.TIPO_TRABAJO))
            {
                panelContainer.Visible = true;
                bInsertar.Visible = true;
                charged = opcion.TIPO_TRABAJO;
                cargarTiposTrabajo();
            }
        }

        private void pictSolicitudes_Click(object sender, EventArgs e)
        {
            if (!charged.Equals(opcion.SOLICITUDES))
            {
                panelContainer.Visible = true;
                bInsertar.Visible = false;
                charged = opcion.SOLICITUDES;
                cargarSolicitudes();
            }
        }

        private void pictAsignatura_Click(object sender, EventArgs e)
        {
            if (!charged.Equals(opcion.ASIGNATURAS))
            {
                panelContainer.Visible = true;
                bInsertar.Visible = true;
                charged = opcion.ASIGNATURAS;
                cargarAsignaturas();
            }
        }

        private void pictGrados_Click(object sender, EventArgs e)
        {
            if (!charged.Equals(opcion.GRADOS))
            {
                panelContainer.Visible = true;
                bInsertar.Visible = true;
                charged = opcion.GRADOS;
                cargarGrados();
            }
        }

        private void pictUsuario_Click(object sender, EventArgs e)
        {
            if (!charged.Equals(opcion.USUARIOS))
            {
                panelContainer.Visible = true;
                bInsertar.Visible = true;
                charged = opcion.USUARIOS;
                cargarUsuarios();
            }
        }

        //CARGAR ELEMENTOS
        private void cargarCompetencias()
        {

            panelElements.Controls.Clear();
            panelElements.RowCount = 1;
            panelElements.AutoScroll = false;
            panelUtil.AutoScroll = false;
            panelUtil.AutoScroll = true;

            List<Competencia> competencias = Competencia.ListaCompetencias();
            CCompetencia[] compC = new CCompetencia[competencias.Count];

            int c = 0;
            foreach (Competencia comp in competencias)
            {
                compC[c] = new CCompetencia(comp);
                panelElements.Controls.Add(compC[c], 0, c);
                panelElements.RowCount = panelElements.RowCount + 1;
                compC[c].Location = new Point(compC[c].Location.X, (compC[c].Size.Height * c));
                compC[c].BackColor = Color.DeepPink;

                //BOTON SOLICITAR
                Panel panel = (Panel)compC[c].Controls.Find("panel1", false)[0];
                Button bBorrar = (Button)panel.Controls.Find("bBorrar", false)[0];

                //PROGRAMACIÓN BOTONES
                bBorrar.Click += (sender, EventArgs) => { bBorrarCompT_Click(sender, EventArgs, comp); };

                c++;
            }
        }

        private void bBorrarCompT_Click(object sender, EventArgs eventArgs, Competencia comp)
        {
            DialogResult emCierreDialog;
            string mensaje = "¿Está seguro de que quiere eliminarlo?";
            string caption = "¡AVISO!";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            emCierreDialog = MessageBox.Show(mensaje, caption, buttons);

            if (emCierreDialog == DialogResult.Yes)
            {
                comp.BorraCompetencia();
                cargarCompetencias();
            }
        }

        private void cargarSolicitudes()
        {

        }
        
        private void cargarAmbitosTrabajo()
        {
            panelElements.Controls.Clear();
            panelElements.RowCount = 1;
            panelElements.AutoScroll = false;
            panelUtil.AutoScroll = false;
            panelUtil.AutoScroll = true;

            List<AmbitoTrabajo> ambito = AmbitoTrabajo.ListaAmbitoTrabajo();
            CAmbTrab[] ambC = new CAmbTrab[ambito.Count];

            int c = 0;
            foreach (AmbitoTrabajo amb in ambito)
            {
                ambC[c] = new CAmbTrab(amb);
                panelElements.Controls.Add(ambC[c], 0, c);
                panelElements.RowCount = panelElements.RowCount + 1;
                ambC[c].Location = new Point(ambC[c].Location.X, (ambC[c].Size.Height * c));
                ambC[c].BackColor = Color.DeepPink;

                //BOTON SOLICITAR
                Panel panel = (Panel)ambC[c].Controls.Find("panel1", false)[0];
                //Button bBorrar = (Button)panel.Controls.Find("bBorrar", false)[0];

                //PROGRAMACIÓN BOTONES
                //bBorrar.Click += (sender, EventArgs) => { bBorrarAmbTrab_Click(sender, EventArgs, amb); };

                c++;
            }
        }

        private void bBorrarAmbTrab_Click(object sender, EventArgs eventArgs, AmbitoTrabajo amb)
        {
            DialogResult emCierreDialog;
            string mensaje = "¿Está seguro de que quiere eliminarlo?";
            string caption = "¡AVISO!";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            emCierreDialog = MessageBox.Show(mensaje, caption, buttons);

            if (emCierreDialog == DialogResult.Yes)
            {
                //amb.BorraAmbitoTrabajo();
                cargarAmbitosTrabajo();
            }
        }

        private void cargarTiposTrabajo()
        {
            panelElements.Controls.Clear();
            panelElements.RowCount = 1;
            panelElements.AutoScroll = false;
            panelUtil.AutoScroll = false;
            panelUtil.AutoScroll = true;

            List<TipoTrabajo> tipo = TipoTrabajo.ListaTipoTrabajo();
            CTipoTrab[] tipC = new CTipoTrab[tipo.Count];

            int c = 0;
            foreach (TipoTrabajo t in tipo)
            {
                tipC[c] = new CTipoTrab(t);
                panelElements.Controls.Add(tipC[c], 0, c);
                panelElements.RowCount = panelElements.RowCount + 1;
                tipC[c].Location = new Point(tipC[c].Location.X, (tipC[c].Size.Height * c));
                tipC[c].BackColor = Color.DeepPink;

                //BOTON SOLICITAR
                Panel panel = (Panel)tipC[c].Controls.Find("panel1", false)[0];
                //Button bBorrar = (Button)panel.Controls.Find("bBorrar", false)[0];

                //PROGRAMACIÓN BOTONES
                //bBorrar.Click += (sender, EventArgs) => { bBorrarTipoTrab_Click(sender, EventArgs, t); };

                c++;
            }
        }

        private void bBorrarTipoTrab_Click(object sender, EventArgs eventArgs, TipoTrabajo t)
        {
            DialogResult emCierreDialog;
            string mensaje = "¿Está seguro de que quiere eliminarlo?";
            string caption = "¡AVISO!";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            emCierreDialog = MessageBox.Show(mensaje, caption, buttons);

            if (emCierreDialog == DialogResult.Yes)
            {
                //t.BorrarTipoTrabajo();
                cargarTiposTrabajo();
            }
        }

        private void cargarGrados()
        {
            panelElements.Controls.Clear();
            panelElements.RowCount = 1;
            panelElements.AutoScroll = false;
            panelUtil.AutoScroll = false;
            panelUtil.AutoScroll = true;

            List<Grado> grados = Grado.ListaGrados();
            CGrado[] gradoC = new CGrado[grados.Count];

            int c = 0;
            foreach (Grado g in grados)
            {
                gradoC[c] = new CGrado(g);
                panelElements.Controls.Add(gradoC[c], 0, c);
                panelElements.RowCount = panelElements.RowCount + 1;
                gradoC[c].Location = new Point(gradoC[c].Location.X, (gradoC[c].Size.Height * c));
                gradoC[c].BackColor = Color.DeepPink;

                //BOTON SOLICITAR
                Panel panel = (Panel)gradoC[c].Controls.Find("panel1", false)[0];
                //Button bBorrar = (Button)panel.Controls.Find("bBorrar", false)[0];

                //PROGRAMACIÓN BOTONES
                //bBorrar.Click += (sender, EventArgs) => { bBorrarGrado_Click(sender, EventArgs, g); };

                c++;
            }
        }

        private void bBorrarGrado_Click(object sender, EventArgs eventArgs, Grado g)
        {
            DialogResult emCierreDialog;
            string mensaje = "¿Está seguro de que quiere eliminarlo?";
            string caption = "¡AVISO!";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            emCierreDialog = MessageBox.Show(mensaje, caption, buttons);

            if (emCierreDialog == DialogResult.Yes)
            {
                //g.BorrarGrado();
                cargarGrados();
            }
        }

        private void cargarAsignaturas()
        {
            panelElements.Controls.Clear();
            panelElements.RowCount = 1;
            panelElements.AutoScroll = false;
            panelUtil.AutoScroll = false;
            panelUtil.AutoScroll = true;

            List<Asignatura> asignaturas = Asignatura.ListaAsignaturas();
            CAsignatura[] asigsC = new CAsignatura[asignaturas.Count];

            int c = 0;
            foreach (Asignatura a in asignaturas)
            {
                asigsC[c] = new CAsignatura(a);
                panelElements.Controls.Add(asigsC[c], 0, c);
                panelElements.RowCount = panelElements.RowCount + 1;
                asigsC[c].Location = new Point(asigsC[c].Location.X, (asigsC[c].Size.Height * c));
                asigsC[c].BackColor = Color.DeepPink;

                //BOTON SOLICITAR
                Panel panel = (Panel)asigsC[c].Controls.Find("panel1", false)[0];
                //Button bBorrar = (Button)panel.Controls.Find("bBorrar", false)[0];

                //PROGRAMACIÓN BOTONES
                //bBorrar.Click += (sender, EventArgs) => { bBorrarAsig_Click(sender, EventArgs, a); };

                c++;
            }
        }

        private void bBorrarAsig_Click(object sender, EventArgs eventArgs, Asignatura a)
        {
            DialogResult emCierreDialog;
            string mensaje = "¿Está seguro de que quiere eliminarlo?";
            string caption = "¡AVISO!";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            emCierreDialog = MessageBox.Show(mensaje, caption, buttons);

            if (emCierreDialog == DialogResult.Yes)
            {
                //a.BorrarAsignatura();
                cargarAsignaturas();
            }
        }

        private void cargarUsuarios()
        {
            panelElements.Controls.Clear();
            panelElements.RowCount = 1;
            panelElements.AutoScroll = false;
            panelUtil.AutoScroll = false;
            panelUtil.AutoScroll = true;

            List<Usuario> usuarios = Usuario.ListaUsuarios();
            CUsuario[] usrC = new CUsuario[usuarios.Count];

            int c = 0;
            foreach (Usuario u in usuarios)
            {
                usrC[c] = new CUsuario(u);
                panelElements.Controls.Add(usrC[c], 0, c);
                panelElements.RowCount = panelElements.RowCount + 1;
                usrC[c].Location = new Point(usrC[c].Location.X, (usrC[c].Size.Height * c));
                usrC[c].BackColor = Color.DeepPink;

                //BOTON SOLICITAR
                Panel panel = (Panel)usrC[c].Controls.Find("panel1", false)[0];
                Button bBorrar = (Button)panel.Controls.Find("bBorrar", false)[0];

                //PROGRAMACIÓN BOTONES
                bBorrar.Click += (sender, EventArgs) => { bBorrarUsuario_Click(sender, EventArgs, u); };

                c++;
            }
        }

        private void bBorrarUsuario_Click(object sender, EventArgs eventArgs, Usuario u)
        {
            DialogResult emCierreDialog;
            string mensaje = "¿Está seguro de que quiere eliminarlo?";
            string caption = "¡AVISO!";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            emCierreDialog = MessageBox.Show(mensaje, caption, buttons);

            if (emCierreDialog == DialogResult.Yes)
            {
                u.BorraUsuario();
                cargarUsuarios();
            }
        }

        //BOTONES
        private void bInsertar_Click(object sender, EventArgs e)
        {
            if(charged.Equals(opcion.AMBITO_TRABAJO))
            {
                InsertarAmbito insAmb = new InsertarAmbito();
                insAmb.ShowDialog();
            } 
            else if (charged.Equals(opcion.TIPO_TRABAJO))
            {
                InsertarTipoTrab insTipoTrab = new InsertarTipoTrab();
                insTipoTrab.ShowDialog();
            }
            else if (charged.Equals(opcion.ASIGNATURAS))
            {
                InsertarAsig insAsig = new InsertarAsig();
                insAsig.ShowDialog();
            }
            else if (charged.Equals(opcion.COMPETENCIAS))
            {
                InsertarCompetencia insComp = new InsertarCompetencia();
                insComp.ShowDialog();
            }
            else if (charged.Equals(opcion.GRADOS))
            {
                InsertarGrados insGrados = new InsertarGrados();
                insGrados.ShowDialog();
            }
            else if (charged.Equals(opcion.USUARIOS))
            {
                InsertarUsuarios insUsr = new InsertarUsuarios();
                insUsr.ShowDialog();
            }
        }

        private void pictExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
