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
    public partial class InsertarAsig : Form
    {
        public InsertarAsig()
        {
            InitializeComponent();
            cargarGrados();
        }

        private void pictOK_Click(object sender, EventArgs e)
        {
            try
            {
                if (tAsig.Text.Equals("")) throw new Exception("Nombre de Asignatura Incompleto.");
                if (comboGrado.SelectedItem == null) throw new Exception("Es obligatorio elegir un grado existente. \n " +
                    "                                                     Si no existe, insertelo antes de hacer esto.");

                String nounasig = tAsig.Text;
                Grado newGrado = (Grado)comboGrado.SelectedItem;
                if (comprobarExistencia(nounasig, newGrado)) throw new Exception("Ya existe esa Asignatura en ese grado.");


                Asignatura newAsig = new Asignatura(nounasig, newGrado);
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

        private bool comprobarExistencia(string nounasig, Grado newGrado)
        {
            foreach(Asignatura a in Asignatura.ListaAsignaturas(newGrado))
            {
                if (nounasig.ToLower().Equals(a.NombreAsig.ToLower())) return true;
            }
            return false;
        }

        private void pictCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cargarGrados()
        {
            foreach(Grado g in Grado.ListaGrados())
            {
                comboGrado.Items.Add(g);
            }
            comboGrado.DisplayMember = "nombreGrado";
        }
    }
}
