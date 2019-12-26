using APS.Mapeo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APS.Interfaces.GestorExclusive
{
    public partial class InsertarAmbito : Form
    {
        public InsertarAmbito()
        {
            InitializeComponent();
        }

        private void pictOK_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text.Equals("")) throw new Exception("Campo Incompleto.");

                String ambtrab = textBox1.Text;
                if (comprobarExistencia(ambtrab)) throw new Exception("Ya existe ese Ámbito.");


                AmbitoTrabajo newAmbito = new AmbitoTrabajo(ambtrab);
                this.Close();

            }
            catch (Exception ex)
            {
                DialogResult emCierreDialog;
                string mensaje = "Se ha producido un error. " + ex.Message;
                string caption = "Lo sentimos...";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                emCierreDialog = MessageBox.Show(mensaje, caption, buttons);

            }
        }

        private void pictCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private Boolean comprobarExistencia(string amb)
        {
            foreach (AmbitoTrabajo tt in AmbitoTrabajo.ListaAmbitoTrabajo())
            {
                if (tt.Ambito_Trabajo.ToLower().Equals(amb.ToLower())) return true;
            }
            return false;
        }
    }
}
