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
            lblTitulo.Text = "¿QUÉ TAL TE HA PARECIDO LA ACTIVIDAD\n" + actividad.Actividad.NombreAct.ToUpper() + "? ¡PUNTÚALA!";
            this.labelError.Text = "";
        }

        private void bAceptarEvaluacion_Click_1(object sender, EventArgs e)
        {
            try
            {
               // if (numericHoras.Value < 0) throw new Exception("Las horas invertidas tienen que ser mayores o iguales a 0");

                actividad.ValoracionUsuario = ratingValoracion.Value;
                actividad.FechaValoracionUsuario = DateTime.Now;
                actividad.ComentarioUsuario = textBoxComentario.Text;
                //actividad.NumHorasRealizadas = decimal.ToInt32(numericHoras.Value);
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