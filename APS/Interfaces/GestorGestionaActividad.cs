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
using static APS.Mapeo.Actividad;

namespace APS.Interfaces
{
    public partial class GestorGestionaActividad : Form
    {
        private Usuario ong;
        private Actividad act;
        private Usuario user;
        public GestorGestionaActividad(Usuario ong,Actividad act)
        {
            InitializeComponent();
            this.ong = ong;
            this.act = act;
            labelOrganizador.Visible = false;
            labelOrganizador.Text = ong.Nombre;
            labelNombreActividad.Visible = false;
            labelNombreActividad.Text = act.NombreAct;

            cargarGrados();
            cargarAsignaturas();
        }

        private void cargarGrados()
        {
            foreach (Grado g in Grado.ListaGrados())
            {
                comboGrado.Items.Add(g.NombreGrado);
            }
        }

        private void cargarAsignaturas()
        {
            Grado g = (Grado) comboGrado.SelectedItem;
            foreach (Asignatura a in Asignatura.ListaAsignaturas(g))
            {
                comboAsig.Items.Add(a.NombreAsig + "-" + a.Grado.NombreGrado);
            }
        }

        private void Aceptar_Click(object sender, EventArgs e)
        {
            try
            {
               

                string[] asig = comboAsig.SelectedItem.ToString().Split('-');
                Asignatura a = new Asignatura(asig[0], new Grado(asig[1], true));
                Grado g = new Grado(comboGrado.SelectedItem.ToString(), true);

                TipoTrabajoE trabajo;
                Enum.TryParse<TipoTrabajoE>(comboResponsable.SelectedItem.ToString(), true, out trabajo);

                TipoActividadE tipo;
                Enum.TryParse<TipoActividadE>(comboTipoAct.SelectedItem.ToString(), true, out tipo);

                MessageBox.Show("Actividad modificada correctamente.");
                this.Close();

            }
            catch (Exception ex)
            {
                labelError.Text = ex.Message;
            }

        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Aceptar_Click_1(object sender, EventArgs e)
        {

        }

        private void comboGrado_SelectedIndexChanged(object sender, EventArgs e)
        {
            cargarAsignaturas();
        }
    }
}
