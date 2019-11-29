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
        public GestorGestionaActividad(Usuario ong,Actividad act)
        {
            
            InitializeComponent();
            this.Visible = true;
            this.ong = ong;
            this.act = act;
            labelOrganizador.Visible = false;
            labelOrganizador.Text = ong.Nombre;
            labelNombreActividad.Visible = false;
            labelNombreActividad.Text = act.NombreAct;
            /*
            cargarGrados();
            cargarAsignaturas();*/
        }

        private void cargarGrados()
        {
            foreach (Grado g in Grado.ListaGrados())
            {
                comboGrado.Items.Add(g);
            }
            comboGrado.DisplayMember = "nombreGrado";
        }

        private void cargarAsignaturas()
        {
            Grado g = (Grado) comboGrado.SelectedItem;
            foreach (Asignatura a in Asignatura.ListaAsignaturas(g))
            {
                comboAsig.Items.Add(a);
            }
            comboAsig.DisplayMember = "nombreAsig";
        }

        private void Aceptar_Click(object sender, EventArgs e)
        {
            try
            {

                Asignatura a = (Asignatura)comboAsig.SelectedItem;
                Grado g = (Grado)comboGrado.SelectedItem;

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

        private void comboGrado_SelectedIndexChanged(object sender, EventArgs e)
        {
            cargarAsignaturas();
        }
    }
}
