using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using APS.Mapeo;
using APS.Interfaces.Gestión_Actividades;

namespace APS.Interfaces.Gestión_Proyectos
{
    public partial class CartelProyecto : UserControl
    {

        private Proyecto proy;
        private Usuario user;
        private int i;  //indice imagenes
        private int sentido = 1;

        public CartelProyecto(Usuario user, Proyecto proy)
        {
            InitializeComponent();
            this.proy = proy;
            this.user = user;
            this.labelName.Text = proy.NombreProyecto;
            this.lDescripcion.Text = proy.DescripcionProyecto;
            this.lShowResp.Text = proy.Responsable.Nombre + " " + proy.Responsable.Apellido1 + " " + proy.Responsable.Apellido2;
            this.lShowTipoProy.Text = proy.TipoProy.ToString();
            this.lShowEstadoProy.Text = proy.EstadoProy.ToString();
            this.lShowNumActividades.Text = proy.Actividades.Count.ToString();
            i = -1;

            this.lShowIni.Text = proy.PrimeraActividadProyecto().FechaInicio.ToShortDateString() + " - " +
                                    proy.UltimaActividadProyecto().FechaFin.ToShortDateString();

            CargarPrimeraImagen();
        }

        private void CargarPrimeraImagen()
        {
            if (proy.Actividades.Count > 0)
            {
                i = 0;
                pictAtras.Visible = false;
                if (proy.Actividades.Count > 1) pictAlante.Visible = true;
                lNombreAct.Text = proy.Actividades[i].NombreAct;
                Image imagen = proy.Actividades[i].Imagen;
                if (imagen != null) pict.Image = imagen;
                else pict.Image = Properties.Resources.no_image;
            }
            else
            {
                pictAlante.Visible = false;
                pictAtras.Visible = false;
                pict.Visible = false;
                lNombreAct.Visible = false;
            }
        }

        private void pictAtras_Click(object sender, EventArgs e)
        {
            --i;
            if (i == 0)
            {
                pictAtras.Visible = false;
                sentido = 1;
            }
            pictAlante.Visible = true;
            lNombreAct.Text = proy.Actividades[i].NombreAct;
            Image imagen = proy.Actividades[i].Imagen;
            if (imagen != null) pict.Image = imagen;
            else pict.Image = Properties.Resources.no_image;
        }

        private void pictAlante_Click(object sender, EventArgs e)
        {
            ++i;
            timer1.Enabled = false;
            timer1.Enabled = true;
            if(i == (proy.Actividades.Count-1))
            {
                pictAlante.Visible = false;
                sentido = -1;
            }
            pictAtras.Visible = true;
            lNombreAct.Text = proy.Actividades[i].NombreAct;
            Image imagen = proy.Actividades[i].Imagen;
            if (imagen != null) pict.Image = imagen;
            else pict.Image = Properties.Resources.no_image;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (sentido == 1)
            {
                pictAlante_Click(null,null);
            }
            else
            {
                pictAtras_Click(null, null);
            }
        }


        #region Properties
        private string _noun;
        private string _description;
        private string _plazas;
        private string _estado;
        private string _tipoact;
        private DateTime _fechaini;
        private DateTime _fechafin;
        private string _organizador;
        private string _responsable;
        private Image _icon;

        [Category("Custom Props")]
        public string Nombre
        {
            get { return _noun; }
            set { _noun = value; labelName.Text = value; }
        }

        [Category("Custom Props")]
        public string Description
        {
            get { return _description; }
            set { _description = value; lDescripcion.Text = value; }
        }

        private void pict_DoubleClick(object sender, EventArgs e)
        {
            Actividad act = proy.Actividades[i];
            VerActividadAbierta verAct = new VerActividadAbierta(this.user, act);
            verAct.ShowDialog();
        }
    }

        #endregion



}
