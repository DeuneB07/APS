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
        }

        #region Properties
        private string _noun;
        private string _description;
        private string _plazas;
        private string _tipoact;
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
        public Image ImagenActividad
        {
            get { return _icon; }
            set { _icon = value; pict.Image = value; }
        }

        #endregion

        private void bVerMas_Click(object sender, EventArgs e)
        {
            VerActividad vAct = new VerActividad(this.user, this.a);
            vAct.ShowDialog();
        }

    }
}
