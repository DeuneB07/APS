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
    public partial class CartelProyecto : UserControl
    {

        private Proyecto proy;
        private Usuario user;

        public CartelProyecto(Usuario user, Proyecto proy)
        {
            InitializeComponent();
            this.proy = proy;
            this.user = user;
            this.labelName.Text = proy.NombreProyecto;
            this.lDescripcion.Text = proy.DescripcionProyecto;

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

        }

    }
}
