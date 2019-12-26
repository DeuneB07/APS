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
    public partial class InsertarCompetencia : Form
    {
        public InsertarCompetencia()
        {
            InitializeComponent();
        }

        private void pictOK_Click(object sender, EventArgs e)
        {

            try
            {
                if (tNoun.Text.Equals("")) throw new Exception("Campo Nombre Incompleto.");

                String nouncomp = tNoun.Text;
                if (comprobarExistencia(nouncomp)) throw new Exception("Ya existe esa competencia.");

                Competencia newCompetencia = new Competencia(nouncomp, tDesc.Text);
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

        private Boolean comprobarExistencia(string comp)
        {
            foreach (Competencia tt in Competencia.ListaCompetencias())
            {
                if (tt.NombreComp.ToLower().Equals(comp.ToLower())) return true;
            }
            return false;
        }

    }
}
