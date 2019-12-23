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
    public partial class EvaluarUsuarioONG : Form
    {
        private Actividad_Realizada act;
        public EvaluarUsuarioONG(Actividad_Realizada act)
        {
            InitializeComponent();
            this.act = act;
            this.labelError.Text = "";
        }

        private void bAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxValoracion.Text.Equals("")) throw new Exception("El campo valoración es obligatorio rellenarlo.");
                if (int.Parse(textBoxValoracion.Text) < 0 || int.Parse(textBoxValoracion.Text) > 10) throw new Exception("La valoracion tiene que estar comprendidad entre 0 y 10.");

                act.ValoracionONG = int.Parse(textBoxValoracion.Text);
                act.ComentarioONG = textBoxComentario.Text;
                act.FechaValoracionONG = DateTime.Today.ToShortDateString();
                if (act.Actividad.EstadoAct.Equals("VOLUNTARIADO")) act.EstadoRealizacion = Actividad_Realizada.EstadoActividadR.EVALUACION_FINALIZADA;
                else act.EstadoRealizacion = Actividad_Realizada.EstadoActividadR.EVALUACION_PDI;
                this.Close();
            } catch (Exception ex)
            {
                labelError.Text = "ERROR: Faltan Parámetros o son incorrectos. \n" + ex.Message;
                Console.WriteLine(ex.StackTrace);
            }
        }

        private void bCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
