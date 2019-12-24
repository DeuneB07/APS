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
    public partial class EvaluarUsuarioPDI : Form
    {
        private Actividad_Realizada act;
        public EvaluarUsuarioPDI(Actividad_Realizada act)
        {
            InitializeComponent();
            this.act = act;
            lHoras.Text = act.NumHorasRealizadas.ToString();
            lValoracion.Text = act.ValoracionONG.ToString();
            textBoxComentarioONG.Text = act.ComentarioONG;
            labelError.Text = "";
        }

        private void bAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxValoracionPDI.Text.Equals("")) throw new Exception("El campo valoración es obligatorio rellenarlo.");
                if (int.Parse(textBoxValoracionPDI.Text) < 0 || int.Parse(textBoxValoracionPDI.Text) > 10) throw new Exception("La valoracion tiene que estar comprendidad entre 0 y 10.");

                act.ValoracionProfesor = int.Parse(textBoxValoracionPDI.Text);
                act.ComentarioProfesor = textBoxComentarioPDI.Text;
                act.FechaValoracionProfesor = DateTime.Today;
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
    }
}
