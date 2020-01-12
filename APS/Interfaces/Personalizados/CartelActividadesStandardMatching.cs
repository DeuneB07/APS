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
    public partial class CartelActividadesStandardMatching : UserControl
    {

        private Actividad a;
        private Usuario user;
        private Preferencia preferencia;

        public CartelActividadesStandardMatching(Preferencia preferencia, Usuario user, Actividad a)
        {
            InitializeComponent();
            this.a = a;
            this.user = user;
            this.preferencia = preferencia;
            this.labelName.Text = a.NombreAct;
            this.lDescripcion.Text = a.DescAct;
            this.lNumPlazas.Text = a.NumPlazas.ToString();
            this.lTipoActividad.Text = a.TipoAct.ToString();
            this.lShowIni.Text = a.FechaInicio.ToShortDateString() + " - " + a.FechaFin.ToShortDateString();
            this.lShowOrg.Text = a.Organizador.Nombre;
            if (a.Imagen != null) pict.Image = a.Imagen;

            if (a.Responsable != null)
            {
                this.lShowResp.Text = a.Responsable.Nombre + " " + a.Responsable.Apellido1 + " " + a.Responsable.Apellido2;
            } else
            {
                lResp.Visible = false;
                lShowResp.Visible = false;
            }
            CalcularCompatibilidad();
        }

        public CartelActividadesStandardMatching(Usuario user, Actividad a)
        {
            InitializeComponent();
            this.a = a;
            this.user = user;
            this.labelName.Text = a.NombreAct;
            this.lDescripcion.Text = a.DescAct;
            this.lNumPlazas.Text = a.NumPlazas.ToString();
            this.lTipoActividad.Text = a.TipoAct.ToString();
            this.lShowIni.Text = a.FechaInicio.ToShortDateString() + " - " + a.FechaFin.ToShortDateString();
            this.lShowOrg.Text = a.Organizador.Nombre;
            if (a.Imagen != null) pict.Image = a.Imagen;

            if (a.Responsable != null)
            {
                this.lShowResp.Text = a.Responsable.Nombre + " " + a.Responsable.Apellido1 + " " + a.Responsable.Apellido2;
            }
            else
            {
                lResp.Visible = false;
                lShowResp.Visible = false;
            }

            CalcularCompatibilidadInicio();
        }

        private void CalcularCompatibilidadInicio()
        {
            //8 PARTES
            float porcentaje = 100;

            //TIPO ACTIVIDAD
            if (a.TipoAct.Equals(Actividad.TipoActividadE.FORMACION))
            {
                if (!user.Rol.NombreRol.Equals("Estudiante")) porcentaje -= 100 / 2;
            }
            else if (a.TipoAct.Equals(Actividad.TipoActividadE.INVESTIGACION))
            {
                if (!user.Rol.NombreRol.Equals("PDI")) porcentaje -= 100 / 2;
            }
            else
            {
                if (!user.Rol.NombreRol.Equals("PAS")) porcentaje -= 100 / 2;
            }

            //GRADOS y ASIGNATURAS 
            if (user.Rol.NombreRol.Equals("Estudiante") || user.Rol.NombreRol.Equals("PDI"))
            {
                if (a.Grado == null || !user.Grados.Contains(a.Grado)) porcentaje -= 100 / 4;
                if (a.Asignatura != null || !user.Asignaturas.Contains(a.Asignatura)) porcentaje -= 100 / 4;
            }
            else
            {
                if (a.Grado != null) porcentaje -= 100 / 4;
                if (a.Asignatura != null) porcentaje -= 100 / 4;
            }

            this.Compatibilidad = porcentaje;
            lblCompatibilidad.Text = porcentaje.ToString()+"%";
            if (Compatibilidad >= 80) lblCompatibilidad.ForeColor = Color.OliveDrab;
            else if (Compatibilidad > 50 && Compatibilidad < 80) lblCompatibilidad.ForeColor = Color.LightSeaGreen;
            else if (Compatibilidad > 25 && Compatibilidad <= 50) lblCompatibilidad.ForeColor = Color.BurlyWood;
            else lblCompatibilidad.ForeColor = Color.IndianRed;
        }

        private void CalcularCompatibilidad()
        {
            //8 PARTES
            float porcentaje = 100;
            
            //TIPO ACTIVIDAD
            if (!preferencia.TipoActividad.Equals(Actividad.TipoActividadE.TODAS))
            {
                if (!a.TipoAct.Equals(preferencia.TipoActividad))
                {
                    porcentaje -= 100 / 8;
                }
            }
            
            //GRADO
            if (preferencia.Grado != null)
            {
                if (a.Grado==null || !a.Grado.Equals(preferencia.Grado))
                {
                    porcentaje -= 100 / 8;
                }
            }

            //ASIGNATURA
            if (preferencia.Asignatura != null)
            {
                if (a.Asignatura == null || !a.Asignatura.Equals(preferencia.Asignatura))
                {
                    porcentaje -= 100 / 8;
                }
            }
            
            //TURNO
            if(preferencia.Turno!= Actividad.TurnoE.AMBAS)
            {
                if (!a.Turno.Equals(preferencia.Turno))
                {
                    porcentaje -= 100 / 8;
                }
            }

            //TIPO TRABAJO
            if (!preferencia.TipoTrabajo.Tipo_Trabajo.Equals("TODAS")){
                if (!a.TipoTrabajo.Equals(preferencia.TipoTrabajo))
                {
                    porcentaje -= 100 / 8;
                }
            }

            //AMBITO TRABAJO
            if (!preferencia.AmbitoTrabajo.Ambito_Trabajo.Equals("TODAS"))
            {
                if (!a.AmbitoTrabajo.Equals(preferencia.AmbitoTrabajo))
                {
                    porcentaje -= 100 / 8;
                }
            }

            //COMPETENCIAS
            foreach (Competencia c in preferencia.Competencias)
            {
                if (!a.Competencias.Contains(c))
                {
                    porcentaje -= 100 / (8 * preferencia.Competencias.Count);
                }
            }
            
            //HORAS
            if (preferencia.HorasPosibles != 0)
            {
                if (a.NumHoras > preferencia.HorasPosibles)
                {
                    porcentaje -= 100 / 8;
                }
            }

            this.Compatibilidad = porcentaje;
            lblCompatibilidad.Text = porcentaje.ToString()+"%";
            if (Compatibilidad >= 80) lblCompatibilidad.ForeColor = Color.OliveDrab;
            else if (Compatibilidad > 50 && Compatibilidad < 80) lblCompatibilidad.ForeColor = Color.LightSeaGreen;
            else if (Compatibilidad > 25 && Compatibilidad <= 50) lblCompatibilidad.ForeColor = Color.BurlyWood;
            else lblCompatibilidad.ForeColor = Color.IndianRed;
        }

        #region Properties
        private string _noun;
        private string _description;
        private string _plazas;
        private string _tipoact;
        private DateTime _fechaini;
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

        public float Compatibilidad { get; set; }
        public Actividad Actividad
        {
            get { return a; }
        }
        public Label Solicitada
        {
            get { return lblSolicitada; }
        }
        #endregion

        private void btnVerActividad_Click(object sender, EventArgs e)
        {
            VerActividadAbierta ventana = new VerActividadAbierta(user, a);
            ventana.ShowDialog();
        }
    }
}
