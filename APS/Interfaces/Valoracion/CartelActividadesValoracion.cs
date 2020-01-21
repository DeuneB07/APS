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
using System.IO;

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
            if (Actividad_Realizada.Contains(user, actividad))
            {
                VerActividadRealizada vAct = new VerActividadRealizada(user, new Actividad_Realizada(user, actividad));
                vAct.ShowDialog();
            }
            else
            {
                VerActividadAbierta vAct = new VerActividadAbierta(this.user, this.actividad);
                vAct.ShowDialog();
            }
        }

        private void bExpedir_Click(object sender, EventArgs e)
        {
            
            saveFileDialog1.Filter = "Archivos pdf (*.pdf)|*.pdf";
            openFileDialog1.Filter = "Archivos pdf (*.pdf)|*.pdf";
            saveFileDialog1.Title = "Save a PDF File";
            String urlDestino = null;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                urlDestino = saveFileDialog1.FileName;
            }
            if (urlDestino != null)
            {
                Actividad_Realizada actRealizada = new Actividad_Realizada(user, actividad);
                Certificados.PlantillaCertificado.CrearCertificado(urlDestino, actRealizada);
                MessageBox.Show("Se ha creado el certificado correctamente");
            }
        }
    }
}
