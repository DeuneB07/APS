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

        public PaginaPrincipal(Mapeo.Usuario user)
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

            if(user.NombreUser != null) lWelcome.Text = "¡Bienvenido, " + user.Nombre + " " + user.Apellido1 + "!";
            else lWelcome.Text = "¡Bienvenido, " + user.NombreUser + "!";

            lNewAct.Visible = user.InsertarPantalla("ACTIVIDADES");
            lNuevoProy.Visible = user.InsertarPantalla("PROYECTOS");

            //cargarTodasActividades();

        }

        private void cargarTodasActividades()
        {


            Panel panel;
            Label lNombreAct;
            Label lDescripcionAct;

            foreach (Actividad act in Actividad.ListaActividades())
            {
                panel = new Panel();
                lNombreAct = new Label();
                lDescripcionAct = new Label();

                lNombreAct.Text = act.NombreAct;
                lDescripcionAct.Text = act.DescAct;
                
                panel.Controls.Add(lNombreAct);
                panel.Controls.Add(lDescripcionAct);

                pTodas.Controls.Add(panel);
            }
            
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
            goPerfilUsuario();
        }

        private void goPerfilUsuario()
        {
            FPerfil perfil = new FPerfil(user);
            this.Visible = false;
            perfil.ShowDialog();
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
    }
}
