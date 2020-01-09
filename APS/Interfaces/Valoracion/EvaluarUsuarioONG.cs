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
    public partial class EvaluarUsuarioONG : Form
    {
        private Actividad_Realizada act;
        public EvaluarUsuarioONG(Actividad_Realizada act)
        {
            InitializeComponent();
            lUserEvaluado.Text = act.Participante.Nombre + " " + act.Participante.Apellido1 + " " + act.Participante.Apellido2;
            this.act = act;
            dateTimePickerIni.Value = act.Actividad.FechaInicio;
            dateTimePickerFin.Value = act.Actividad.FechaFin;
            labelError.Text = "";
            lblTitulo.Text = "¿CÓMO HA TRABAJADO EL USUARIO\n" + act.Participante.Nombre.ToUpper() + "? ¡PUNTÚALO!";
        }

        private void bAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                if (numericHoras.Value < 0) throw new Exception("Las horas invertidas tienen que ser mayores o iguales a 0");

                act.ValoracionONG = ratingValoracion.Value;
                act.NumHorasRealizadas = decimal.ToInt32(numericHoras.Value);
                act.ComentarioONG = textBoxComentario.Text;
                act.FechaInicialUsuario = dateTimePickerIni.Value;
                act.FechaFinalUsuario = dateTimePickerFin.Value;
                act.FechaValoracionONG = DateTime.Now;
                if (!txtURL.Text.Trim().Equals(""))
                {
                    act.ArchivoAdjuntoONG = File.ReadAllBytes(txtURL.Text);
                }
      
                if (act.Actividad.TipoAct.ToString().Equals(Actividad.TipoActividadE.VOLUNTARIADO.ToString())) act.EstadoRealizacion = Actividad_Realizada.EstadoActividadR.EVALUACION_FINALIZADA;
                else act.EstadoRealizacion = Actividad_Realizada.EstadoActividadR.EVALUACION_PDI;
                this.Close();
            }catch(Exception ex)
            {
                labelError.Text = "No se puede guardar el archivo";
                Console.WriteLine(ex.StackTrace);
            }
        }

        private void bCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExaminar_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Archivos pdf (*.pdf)|*.pdf";
            openFileDialog1.FilterIndex = 1;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtURL.Text = openFileDialog1.FileName;
            }
        }
    }
}
