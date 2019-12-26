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
    public partial class CartelActividadesRealizadas : UserControl
    {

        private Actividad_Realizada actRealizada;
        private Usuario user;

        public CartelActividadesRealizadas(Usuario user, Actividad_Realizada actRealizada)
        {
            InitializeComponent();
            this.actRealizada = actRealizada;
            Actividad a = actRealizada.Actividad;
            this.user = user;
            this.labelName.Text = a.NombreAct;
            this.lTipoActividad.Text = a.TipoAct.ToString();
            this.lShowIni.Text = a.FechaInicio.ToShortDateString();
            this.lShowOrg.Text = a.Organizador.Nombre;
            if (a.Imagen != null) pict.Image = a.Imagen;
            lTipoTrabajo.Text = a.TipoTrabajo.ToString();
            lAmbitoTrabajo.Text = a.AmbitoTrabajo.ToString();
            lShowFin.Text = a.FechaFin.ToShortDateString();
            lNumHoras.Text = a.NumHoras.ToString();

            if (a.Responsable != null)
            {
                this.lShowResp.Text = a.Responsable.Nombre + " " + a.Responsable.Apellido1 + " " + a.Responsable.Apellido2;
                lValoracionPDI.Visible = true;
                ratingPDI.Visible = true;
            } else
            {
                lResp.Visible = false;
                lShowResp.Visible = false;
            }

            if (actRealizada.FechaValoracionUsuario != DateTime.MinValue)
            {
                lHorasHechas.Text = actRealizada.NumHorasRealizadas.ToString();
                ratingUser.Value = actRealizada.ValoracionUsuario;
            }
            else
            {
                lHorasHechas.Text = "";
                ratingUser.ItemBackColor = Color.Silver;
            }


            if(actRealizada.FechaValoracionONG != DateTime.MinValue)
            {
                ratingONG.Value = actRealizada.ValoracionONG;
            }
            else
            {
                ratingONG.ItemBackColor = Color.Silver;
            }

            if (actRealizada.FechaValoracionProfesor != DateTime.MinValue)
            {
                ratingPDI.Value = actRealizada.ValoracionProfesor;
            }
            else
            {
                ratingPDI.ItemBackColor = Color.Silver;
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
            VerActividadRealizada vAct = new VerActividadRealizada(user, actRealizada);
            vAct.ShowDialog();
        }
    }
}
