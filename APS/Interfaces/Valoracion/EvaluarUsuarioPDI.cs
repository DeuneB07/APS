using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using APS.Mapeo;

namespace APS.Interfaces.Gestión_Actividades
{
    public partial class EvaluarUsuarioPDI : Form
    {
        private Actividad_Realizada act;
        public EvaluarUsuarioPDI(Actividad_Realizada act)
        {
            InitializeComponent();
            this.act = act;
            lblTitulo.Text = "¿CUÁL ES LA NOTA DEL USUARIO " + act.Participante.Nombre.ToUpper() + " EN ESTA ACTIVIDAD?";
            lNombreOrganizador.Text = act.Actividad.Organizador.Nombre;
            lHoras.Text = act.NumHorasRealizadas.ToString();
            ratingONG.Value = act.ValoracionONG;
            textBoxComentarioONG.Text = act.ComentarioONG;
            lUserEvaluado.Text = act.Participante.Nombre + " " + act.Participante.Apellido1 + " " + act.Participante.Apellido2;
            lNombreActividad.Text = act.Actividad.NombreAct;

            if (act.ArchivoAdjuntoONG != null)
            {
                btnDescargar.Enabled = true;
                txtNombreArchivo.Text = "Archivo.pdf";
            }

            labelError.Text = "";
        }

        private void bAceptar_Click(object sender, EventArgs e)
        {
            try
            {

                act.ValoracionProfesor = ratingPDI.Value;
                act.ComentarioProfesor = textBoxComentarioPDI.Text;
                act.FechaValoracionProfesor = DateTime.Now;
                act.EstadoRealizacion = Actividad_Realizada.EstadoActividadR.EVALUACION_FINALIZADA;
                this.Close();
            }
            catch (Exception ex)
            {
                labelError.Text = "ERROR: Faltan Parámetros o son incorrectos. \n" + ex.Message;
                Console.WriteLine(ex.StackTrace);
            }
            this.Close();
        }

        private void bCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDescargar_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Archivos pdf (*.pdf)|*.pdf";
            saveFileDialog1.Title = "Save a PDF File";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllBytes(saveFileDialog1.FileName, act.ArchivoAdjuntoONG);
            }
        }
    }
}
