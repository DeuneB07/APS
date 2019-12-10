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

namespace APS.Interfaces
{
    public partial class PaginaPrincipal : Form
    {

        Usuario user;

        public PaginaPrincipal(Usuario user)
        {
            InitializeComponent();
            this.user = user;

            tabUser.Visible = true;
            if (!user.AccesoPantalla("MATCH")) tabUser.Controls.Remove(this.pMatch);
            if (!user.AccesoPantalla("TODAS")) tabUser.Controls.Remove(this.pTodas);
            if (!user.AccesoPantalla("PROYECTOS")) tabUser.Controls.Remove(this.pProyectos);
            if (!user.AccesoPantalla("VALORACION")) tabUser.Controls.Remove(this.pValoracion);
            if (!user.AccesoPantalla("PENDIENTES")) tabUser.Controls.Remove(this.pPendientes);
            if (!user.AccesoPantalla("REVISION")) tabUser.Controls.Remove(this.pRevision);
            if (!user.AccesoPantalla("MIS ACTIVIDADES")) tabUser.Controls.Remove(this.pMisActividades);
            if (!user.AccesoPantalla("ACTIVIDADES INSCRITAS")) tabUser.Controls.Remove(this.pActividadesInscritas);

            if (user.NombreUser != null) lWelcome.Text = "¡Bienvenido, " + user.Nombre + " " + user.Apellido1 + "!";
            else lWelcome.Text = "¡Bienvenido, " + user.NombreUser + "!";

            lNewAct.Visible = user.InsertarPantalla("ACTIVIDADES");
            lNuevoProy.Visible = user.InsertarPantalla("PROYECTOS");

            //this.gradosTableAdapter.Fill(this.wePassDataSet.Grados);
            //this.actividadesTableAdapter.Fill(this.wePassDataSet.Actividades);

            cargarTodasActividadesChulas();
            //cargarTodasActividades();
            cargarPendientesActividades();
            cargarRevisionActividades();
            //cargarMisActividades();
            //cargarActividadesInscritas();
        }

        private void cargarFiltros()
        {
            CartelFiltros cFiltro = new CartelFiltros(this.user);
            panelTodas.Controls.Add(cFiltro);
        }

        private void cargarTodasActividadesChulas()
        {

            pTodas.Controls.Add(panelTodas);
            cargarFiltros();

            List<Actividad> actividades = Actividad.ListaActividades();
            CartelActividadesStandard[] actsCarteles = new CartelActividadesStandard[actividades.Count];
            

            int c = 0;
            foreach (Actividad act in actividades)
            {
                actsCarteles[c] = new CartelActividadesStandard(user, act);
                panelTodas.Controls.Add(actsCarteles[c]);
                actsCarteles[c].Location = new Point(actsCarteles[c].Location.X, (actsCarteles[c].Size.Height * c) + 50);
                c++;
            }

        }

        private void cargarTodasActividades()
        {
            List<Actividad> actividades = new List<Actividad>();
            foreach (Actividad act in Actividad.ListaActividades(Actividad.EstadoActividadE.ABIERTA))
            {
                actividades.Add(act);
            }
            //this.dataGridViewActividades.DataSource = actividades;
        }

        private void cargarPendientesActividades()
        {
            List<Actividad> actividades = new List<Actividad>();
            foreach (Actividad act in Actividad.ListaActividades(Actividad.EstadoActividadE.PENDIENTE_ACEPTACION))
            {
                actividades.Add(act);
            }
            this.dataGridViewPendientes.DataSource = actividades;
        }

        private void cargarRevisionActividades()
        {
            List<Actividad> actividades = new List<Actividad>();
            foreach(Actividad act in Actividad.ListaActividades(Actividad.EstadoActividadE.NEGOCIACION_ONG))
            {
                actividades.Add(act);
            }
            foreach(Actividad act in Actividad.ListaActividades(Actividad.EstadoActividadE.NEGOCIACION_PDI))
            {
                actividades.Add(act);
            }
            actividades.Sort();
            //this.dataGridViewActividades.DataSource = actividades;
        }

        private void bLogout_Click(object sender, EventArgs e)
        {
            crearCierreSesion();
        }

        private void crearCierreSesion()
        {
            DialogResult emCierreDialog;
            string mensaje = "¿Quieres cerrar la sesión actual?";
            string caption = "¡AVISO!";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            emCierreDialog = MessageBox.Show(mensaje, caption, buttons);

            if (emCierreDialog == DialogResult.Yes) this.Close();
        }

        private void lPerfil_Click(object sender, EventArgs e)
        {
            this.GoPerfilUsuario();
        }

        private void GoPerfilUsuario()
        {
            FPerfil pagina = new FPerfil(user);
            this.Visible = false;
            pagina.ShowDialog();
            this.Visible = true;
        }

        private void lNewAct_Click(object sender, EventArgs e)
        {
            goNuevaActividad();
        }

        private void goNuevaActividad()
        {
            NuevaActividad newAct = new NuevaActividad(user);
            this.Visible = false;
            newAct.ShowDialog();
            this.Visible = true;
        }

        private void PaginaPrincipal_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'wePassDataSet.Actividades' Puede moverla o quitarla según sea necesario.
            //this.actividadesTableAdapter.Fill(this.wePassDataSet.Actividades);
            // TODO: esta línea de código carga datos en la tabla 'wePassDataSet.Grados' Puede moverla o quitarla según sea necesario.
            //this.gradosTableAdapter.Fill(this.wePassDataSet.Grados);

        }

        private void listGrados_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*
            Grado g = (Grado)listGrados.SelectedItem;
            
            foreach(Asignatura a in Asignatura.ListaAsignaturas(g))
            {

            }*/
        }

        private void bGestionar_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.dataGridViewPendientes.SelectedRows.Count == 0)
                {
                    throw new Exception("Ninguna actividad seleccionada");
                }
                int id = int.Parse(this.dataGridViewPendientes.SelectedRows[0].Cells[0].Value.ToString());
                Actividad pendiente = new Actividad(id);
                GestorGestionaActividad gestorGestionaActividad = new GestorGestionaActividad(user, pendiente);
                this.Visible = false;
                gestorGestionaActividad.ShowDialog();
                this.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridViewPendientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            int id = int.Parse(this.dataGridViewPendientes.Rows[i].Cells[0].Value.ToString());
            Actividad pendiente = new Actividad(id);
            VerActividadGestor verActividad = new VerActividadGestor(user, pendiente);
            this.Visible = false;
            verActividad.ShowDialog();
            this.Visible = true;
            cargarTodasActividades();
            cargarPendientesActividades();
        }
    }
}
