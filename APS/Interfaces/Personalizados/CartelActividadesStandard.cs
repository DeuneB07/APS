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

namespace APS.Interfaces.Personalizados
{
    public partial class CartelActividadesStandard : UserControl
    {

        private Actividad a;
        private Usuario user;

        public CartelActividadesStandard(Usuario user, Actividad a)
        {
            InitializeComponent();
            this.a = a;
            this.user = user;
            this.labelName.Text = a.NombreAct;
            this.lDescripcion.Text = a.DescAct;
            this.lNumPlazas.Text = a.NumPlazas.ToString();
            this.lTipoActividad.Text = a.TipoAct.ToString();
            this.lShowIni.Text = a.FechaInicio.ToShortDateString();
            this.lShowFin.Text = a.FechaFin.ToShortDateString();
            this.lShowOrg.Text = a.Organizador.Nombre;
            this.lEstado.Text = a.EstadoAct.ToString();
            if (a.Imagen != null) pict.Image = a.Imagen;

            if (a.Responsable != null)
            {
                this.lShowResp.Text = a.Responsable.Nombre + " " + a.Responsable.Apellido1 + " " + a.Responsable.Apellido2;
            } else
            {
                lResp.Visible = false;
                lShowResp.Visible = false;
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

        [Category("Custom Props")]
        public string NumPlazas
        {
            get { return _plazas; }
            set { _plazas = value; lNumPlazas.Text = value; }
        }

        [Category("Custom Props")]
        public string Estado
        {
            get { return _estado; }
            set { _estado = value; lEstado.Text = value; }
        }

        [Category("Custom Props")]
        public string TipoActividad
        {
            get { return _tipoact; }
            set { _tipoact = value; lTipoActividad.Text = value; }
        }

        [Category("Custom Props")]
        public DateTime FechaInicio
        {
            get { return _fechaini; }
            set { _fechaini = value; lShowIni.Text = value.ToShortTimeString(); }
        }

        [Category("Custom Props")]
        public DateTime FechaFin
        {
            get { return _fechafin; }
            set { _fechafin = value; lShowFin.Text = value.ToShortDateString(); }
        }

        [Category("Custom Props")]
        public string Organizador
        {
            get { return _organizador; }
            set { _organizador = value; lShowOrg.Text = value; }
        }

        [Category("Custom Props")]
        public string Responsable
        {
            get { return _responsable; }
            set { _responsable = value; lShowResp.Text = value; }
        }

        [Category("Custom Props")]
        public Image ImagenActividad
        {
            get { return _icon; }
            set { _icon = value; pict.Image = value; }
        }

        #endregion

        private void bVerMas_Click(object sender, EventArgs e)
        {
            VerActividadGestor vAct = new VerActividadGestor(this.user, this.a);
            vAct.ShowDialog();
        }
    }
}
