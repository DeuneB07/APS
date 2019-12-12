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

namespace APS.Interfaces.Personalizados
{
    public partial class CartelPendientes : UserControl
    {

        private Actividad a;
        private Usuario user;

        public CartelPendientes(Usuario user, Actividad a)
        {
            InitializeComponent();
            this.a = a;
            this.user = user;
            this.labelName.Text = a.NombreAct;
            this.lDescripcion.Text = a.DescAct;
            this.lNumPlazas.Text = a.NumPlazas.ToString();
            this.lShowTipoTrab.Text = a.TipoTrabajo.ToString();
            this.lShowIni.Text = a.FechaInicio.ToShortDateString() + " - " + a.FechaFin.ToShortDateString();
            this.lShowOrg.Text = a.Organizador.Nombre;
            this.lShowAmbito.Text = a.AmbitoTrabajo.ToString();
            this.lShowLugar.Text = a.Lugar;
            this.lShowHoras.Text = a.NumHoras.ToString();
            if (a.Imagen != null) pict.Image = a.Imagen;
        }

        #region Properties
        private string _noun;
        private string _description;
        private int _plazas;
        private string _tipotrab;
        private string _ambtrab;
        private DateTime _fechaini;
        private DateTime _fechafin;
        private string _lugar;
        private string _organizador;
        private int _horas;
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
        public int NumPlazas
        {
            get { return _plazas; }
            set { _plazas = value; lNumPlazas.Text = value.ToString(); }
        }

        [Category("Custom Props")]
        public int NumHoras
        {
            get { return _horas; }
            set { _horas = value; lShowHoras.Text = value.ToString(); }
        }

        [Category("Custom Props")]
        public string TipoTrabajo
        {
            get { return _tipotrab; }
            set { _tipotrab = value; lShowTipoTrab.Text = value; }
        }

        [Category("Custom Props")]
        public string AmbitoTrabajo
        {
            get { return _ambtrab; }
            set { _ambtrab = value; lShowAmbito.Text = value; }
        }

        [Category("Custom Props")]
        public DateTime FechaInicio
        {
            get { return _fechaini; }
            set { _fechaini = value; lShowIni.Text = value.ToShortDateString() +" - "+ _fechafin.ToShortDateString(); }
        }

        [Category("Custom Props")]
        public DateTime FechaFin
        {
            get { return _fechafin; }
            set { _fechafin = value; lShowIni.Text = _fechaini.ToShortDateString() +" - "+ value.ToShortDateString(); }
        }

        [Category("Custom Props")]
        public string Organizador
        {
            get { return _organizador; }
            set { _organizador = value; lShowOrg.Text = value; }
        }

        [Category("Custom Props")]
        public string Lugar
        {
            get { return _lugar; }
            set { _lugar = value; lShowLugar.Text = value; }
        }

        [Category("Custom Props")]
        public Image ImagenActividad
        {
            get { return _icon; }
            set { _icon = value; pict.Image = value; }
        }

        #endregion

    }
}
