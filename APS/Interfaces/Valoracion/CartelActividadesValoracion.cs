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
    public partial class CartelActividadesValoracion : UserControl
    {
        private Usuario user;
        private Actividad actividad;
        public CartelActividadesValoracion(Usuario user, Actividad actividad)
        {
            InitializeComponent();
            this.user = user;
            this.actividad = actividad;
            this.labelName.Text = actividad.NombreAct;
            this.lDescripcion.Text = actividad.DescAct;
            this.lShowOrg.Text = actividad.Organizador.Nombre;
            if (actividad.Imagen != null) pict.Image = actividad.Imagen;

            if (actividad.Responsable != null)
            {
                this.lShowResp.Text = actividad.Responsable.Nombre + " " + actividad.Responsable.Apellido1 + " " + actividad.Responsable.Apellido2;
            }
            else
            {
                lResp.Visible = false;
                lShowResp.Visible = false;
            }
        }

        private void bVerMas_Click(object sender, EventArgs e)
        {
            VerActividadGestor vAct = new VerActividadGestor(this.user, this.actividad);
            vAct.ShowDialog();
        }
    }
}
