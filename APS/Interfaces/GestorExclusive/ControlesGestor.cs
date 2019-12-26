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
                panel2.Visible = true;
                bVer.Visible = true;
                bInsertar.Visible = true;
                bBorrar.Visible = true;
                charged = opcion.COMPETENCIAS;
                cargarCompetencias();
            }
        }

        private void pictAmbTrab_Click(object sender, EventArgs e)
        {
            if (!charged.Equals(opcion.AMBITO_TRABAJO))
            {
                panel2.Visible = true;
                bVer.Visible = false;
                bInsertar.Visible = true;
                bBorrar.Visible = true;
                charged = opcion.AMBITO_TRABAJO;
                cargarAmbitosTrabajo();
            }
        }

        private void pictTipoTrab_Click(object sender, EventArgs e)
        {
            if (!charged.Equals(opcion.TIPO_TRABAJO))
            {
                panel2.Visible = true;
                bVer.Visible = false;
                bInsertar.Visible = true;
                bBorrar.Visible = true;
                charged = opcion.TIPO_TRABAJO;
                cargarTiposTrabajo();
            }
        }

        private void pictSolicitudes_Click(object sender, EventArgs e)
        {
            if (!charged.Equals(opcion.SOLICITUDES))
            {
                panel2.Visible = true;
                bVer.Visible = true;
                bInsertar.Visible = true;
                bBorrar.Visible = true;
                charged = opcion.SOLICITUDES;
                cargarSolicitudes();
            }
        }

        private void pictAsignatura_Click(object sender, EventArgs e)
        {
            if (!charged.Equals(opcion.ASIGNATURAS))
            {
                panel2.Visible = true;
                bVer.Visible = true;
                bInsertar.Visible = true;
                bBorrar.Visible = true;
                charged = opcion.ASIGNATURAS;
                cargarAsignaturas();
            }
        }

        private void pictGrados_Click(object sender, EventArgs e)
        {
            if (!charged.Equals(opcion.GRADOS))
            {
                panel2.Visible = true;
                bVer.Visible = true;
                bInsertar.Visible = true;
                bBorrar.Visible = true;
                charged = opcion.GRADOS;
                cargarGrados();
            }
        }

        private void pictUsuario_Click(object sender, EventArgs e)
        {
            if (!charged.Equals(opcion.USUARIOS))
            {
                panel2.Visible = true;
                bVer.Visible = true;
                bInsertar.Visible = true;
                bBorrar.Visible = true;
                charged = opcion.USUARIOS;
                cargarUsuarios();
            }
        }

        //CARGAR ELEMENTOS
        private void cargarCompetencias()
        {
            listElements.Items.Clear();
            foreach(Competencia c in Competencia.ListaCompetencias())
            {
                listElements.Items.Add(c);
            }
            listElements.DisplayMember = "nombComp";
        }

        private void cargarSolicitudes()
        {

        }
        
        private void cargarAmbitosTrabajo()
        {
            listElements.Items.Clear();
            foreach (AmbitoTrabajo aT in AmbitoTrabajo.ListaAmbitoTrabajo())
            {
                listElements.Items.Add(aT);
            }
            listElements.DisplayMember = "ambitoTrabajo";
        }

        private void cargarTiposTrabajo()
        {
            listElements.Items.Clear();
            foreach (TipoTrabajo tT in TipoTrabajo.ListaTipoTrabajo())
            {
                listElements.Items.Add(tT);
            }
            listElements.DisplayMember = "tipoTrabajo";
        }

        private void cargarGrados()
        {
            listElements.Items.Clear();
            foreach (Grado g in Grado.ListaGrados())
            {
                listElements.Items.Add(g);
            }
            listElements.DisplayMember = "nombreGrado";
        }

        private void cargarAsignaturas()
        {
            listElements.Items.Clear();
            foreach (Asignatura a in Asignatura.ListaAsignaturas())
            {
                listElements.Items.Add(a);
            }
            listElements.DisplayMember = "nombreAsig";
        }

        private void cargarUsuarios()
        {
            listElements.Items.Clear();
            foreach (Usuario u in Usuario.ListaUsuarios())
            {
                listElements.Items.Add(u);
            }
            listElements.DisplayMember = "email";
        }

        //BOTONES
        private void bBorrar_Click(object sender, EventArgs e)
        {

        }

        private void bInsertar_Click(object sender, EventArgs e)
        {

        }

        private void bVer_Click(object sender, EventArgs e)
        {

        }

        private void pictExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
