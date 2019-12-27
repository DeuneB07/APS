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
                lInsertar.Visible = true;
                lBusqRol.Visible = false;
                comboBusqRol.Visible = false;
                lBusqAsig.Visible = false;
                combBusqAsig.Visible = false;
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
                lInsertar.Visible = true;
                lBusqRol.Visible = false;
                comboBusqRol.Visible = false;
                lBusqAsig.Visible = false;
                combBusqAsig.Visible = false;
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
                lInsertar.Visible = true;
                lBusqRol.Visible = false;
                comboBusqRol.Visible = false;
                lBusqAsig.Visible = false;
                combBusqAsig.Visible = false;
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
                lInsertar.Visible = false;
                lBusqRol.Visible = false;
                comboBusqRol.Visible = false;
                lBusqAsig.Visible = false;
                combBusqAsig.Visible = false;
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
                lInsertar.Visible = true;
                lBusqRol.Visible = false;
                comboBusqRol.Visible = false;
                lBusqAsig.Visible = true;
                combBusqAsig.Visible = true;
                if (combBusqAsig.Items.Count == 0) cargarComboGrados();
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
                lInsertar.Visible = true;
                lBusqRol.Visible = false;
                comboBusqRol.Visible = false;
                lBusqAsig.Visible = false;
                combBusqAsig.Visible = false;
                charged = opcion.GRADOS;
                cargarGrados();
            }
        }

        private void pictUsuario_Click(object sender, EventArgs e)
        {
            if (!charged.Equals(opcion.USUARIOS))
            {
                panelContainer.Visible = true;
                bInsertar.Visible = false;
                lInsertar.Visible = false;
                lBusqAsig.Visible = false;
                combBusqAsig.Visible = false;
                lBusqRol.Visible = true;
                comboBusqRol.Visible = true;
                if(comboBusqRol.Items.Count == 0) cargarRoles();
                charged = opcion.USUARIOS;
                cargarUsuarios();
            }
        }

        private void cargarRoles()
        {
            comboBusqRol.Items.Add("TODOS");
            foreach(Rol r in Rol.ListaRoles())
            {
                comboBusqRol.Items.Add(r);
            }
            comboBusqRol.DisplayMember = "nombreRol";
        }

        private void cargarComboGrados()
        {
            combBusqAsig.Items.Add("TODOS");
            foreach (Grado g in Grado.ListaGrados())
            {
                combBusqAsig.Items.Add(g);
            }
            combBusqAsig.DisplayMember = "nombreGrado";
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
            panelElements.Controls.Clear();
            panelElements.RowCount = 1;
            panelElements.AutoScroll = false;
            panelUtil.AutoScroll = false;
            panelUtil.AutoScroll = true;

            List<Usuario> solicitudes = Usuario.ListaSolicitudes();
            CSolicitudes[] solC = new CSolicitudes[solicitudes.Count];
            int c = 0;

            foreach (Usuario usr in solicitudes)
            {
                solC[c] = new CSolicitudes(usr);
                panelElements.Controls.Add(solC[c], 0, c);
                panelElements.RowCount = panelElements.RowCount + 1;
                solC[c].Location = new Point(solC[c].Location.X, (solC[c].Size.Height * c));

                //BOTONES
                Panel panel = (Panel)solC[c].Controls.Find("panel1", false)[0];
                Button bCancelar = (Button)panel.Controls.Find("bCancelar", false)[0];
                Button bAceptar = (Button)panel.Controls.Find("bAceptar", false)[0];

                //PROGRAMACIÓN BOTONES
                bCancelar.Click += (sender, EventArgs) => { bCancelarSolicitud_Click(sender, EventArgs, usr); };
                bAceptar.Click += (sender, EventArgs) => { bAceptarSolicitud_Click(sender, EventArgs, usr); };

                c++;
            }
        }

        private void bAceptarSolicitud_Click(object sender, EventArgs eventArgs, Usuario usr)
        {
            DialogResult emCierreDialog;
            string mensaje = "¿Está seguro de que quiere aceptar?";
            string caption = "¡AVISO!";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            emCierreDialog = MessageBox.Show(mensaje, caption, buttons);

            if (emCierreDialog == DialogResult.Yes)
            {
                usr.Aceptado = true;
                cargarSolicitudes();
            }
        }

        private void bCancelarSolicitud_Click(object sender, EventArgs eventArgs, Usuario usr)
        {
            DialogResult emCierreDialog;
            string mensaje = "¿Está seguro de que quiere cancelar?";
            string caption = "¡AVISO!";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            emCierreDialog = MessageBox.Show(mensaje, caption, buttons);

            if (emCierreDialog == DialogResult.Yes)
            {
                usr.BorraUsuario();
                cargarSolicitudes();
            }
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

                c++;
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

                c++;
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

                c++;
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

                //BOTON SOLICITAR
                Panel panel = (Panel)asigsC[c].Controls.Find("panel1", false)[0];

                c++;
            }
        }

        private void cargarAsignaturas(Grado g)
        {
            panelElements.Controls.Clear();
            panelElements.RowCount = 1;
            panelElements.AutoScroll = false;
            panelUtil.AutoScroll = false;
            panelUtil.AutoScroll = true;

            List<Asignatura> asignaturas = Asignatura.ListaAsignaturas(g);
            CAsignatura[] asigsC = new CAsignatura[asignaturas.Count];

            int c = 0;
            foreach (Asignatura a in asignaturas)
            {
                asigsC[c] = new CAsignatura(a);
                panelElements.Controls.Add(asigsC[c], 0, c);
                panelElements.RowCount = panelElements.RowCount + 1;
                asigsC[c].Location = new Point(asigsC[c].Location.X, (asigsC[c].Size.Height * c));

                c++;
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

                //BOTON SOLICITAR
                Panel panel = (Panel)usrC[c].Controls.Find("panel1", false)[0];
                Button bBorrar = (Button)panel.Controls.Find("bBorrar", false)[0];

                //PROGRAMACIÓN BOTONES
                bBorrar.Click += (sender, EventArgs) => { bBorrarUsuario_Click(sender, EventArgs, u); };

                c++;
            }
        }

        private void cargarUsuarios(Rol r)
        {
            panelElements.Controls.Clear();
            panelElements.RowCount = 1;
            panelElements.AutoScroll = false;
            panelUtil.AutoScroll = false;
            panelUtil.AutoScroll = true;

            List<Usuario> usuarios = Usuario.ListaUsuarios(r);
            CUsuario[] usrC = new CUsuario[usuarios.Count];

            int c = 0;
            foreach (Usuario u in usuarios)
            {
                usrC[c] = new CUsuario(u);
                panelElements.Controls.Add(usrC[c], 0, c);
                panelElements.RowCount = panelElements.RowCount + 1;
                usrC[c].Location = new Point(usrC[c].Location.X, (usrC[c].Size.Height * c));

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
        }

        private void pictExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        //Métodos Filtros
        private void comboBusqRol_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBusqRol.SelectedItem.ToString().Equals("TODOS")) cargarUsuarios();
            else cargarUsuarios((Rol)comboBusqRol.SelectedItem);
        }

        private void combBusqAsig_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (combBusqAsig.SelectedItem.ToString().Equals("TODOS")) cargarAsignaturas();
            else cargarAsignaturas((Grado)combBusqAsig.SelectedItem);
        }
    }
}
