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
    public partial class InsertarTipoTrab : Form
    {
        public InsertarTipoTrab()
        {
            InitializeComponent();
        }

        private void pictOK_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text.Equals("")) throw new Exception("Campo Incompleto.");

                String tipotrab = textBox1.Text;
                if (comprobarExistencia(tipotrab)) throw new Exception("Ya existe ese Tipo.");
                    
                
                TipoTrabajo newTipo = new TipoTrabajo(tipotrab);
                this.Close();

            } catch(Exception ex)
            {
                DialogResult emCierreDialog;
                string mensaje = "Se ha producido un error. "+ex.Message;
                string caption = "Lo sentimos...";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                emCierreDialog = MessageBox.Show(mensaje, caption, buttons);

            }
        }

        private void pictCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private Boolean comprobarExistencia(string tipo)
        {
            foreach(TipoTrabajo tt in TipoTrabajo.ListaTipoTrabajo())
            {
                if (tt.Tipo_Trabajo.ToLower().Equals(tipo.ToLower())) return true;
            }
            return false;
        }
    }
}
