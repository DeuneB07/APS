using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using APS.Mapeo;

namespace APS.Interfaces.Gestión_Actividades
{
    public partial class EvaluarActividad : Form
    {
        private Actividad_Realizada actividad;
        public EvaluarActividad(Actividad_Realizada actividad)
        {
            InitializeComponent();
            this.actividad = actividad;
            this.lParticipante.Text = actividad.Participante.Email;
            this.labelError.Text = "";
        }

        private void bAceptarEvaluacion_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (textBoxValoracion.Text.Equals("")) throw new Exception("El campo valoración es obligatorio rellenarlo");
                if (textBoxHoras.Text.Equals("")) throw new Exception("El campo horas es obligatorio rellenarlo");
                if (int.Parse(textBoxHoras.Text) < 0) throw new Exception("Las horas invertidas tienen que ser mayores o iguales a 0");
                if (int.Parse(textBoxValoracion.Text) < 0 || int.Parse(textBoxValoracion.Text) > 10) throw new Exception("La valoración debe estar comprendida entre 0 y 10");

                actividad.ValoracionUsuario = float.Parse(textBoxValoracion.Text);
                actividad.FechaValoracionUsuario = DateTime.Now;
                actividad.ComentarioUsuario = textBoxComentario.Text;
                actividad.NumHorasRealizadas = int.Parse(textBoxHoras.Text);
                actividad.EstadoRealizacion = Actividad_Realizada.EstadoActividadR.EVALUACION_ONG;

                this.Close();
            }
            catch (Exception ex)
            {
                labelError.Text = "ERROR: Faltan Parámetros o son incorrectos. \n" + ex.Message;
                Console.WriteLine(ex.StackTrace);
            }
        }

        private void bCancelarEvaluacion_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}