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

namespace APS.Interfaces.Gestión_Proyectos
{
    public partial class NuevoProyecto : Form
    {
        Usuario user;
        public NuevoProyecto(Usuario user)
        {
            InitializeComponent();
            this.user = user;
            tResponsable.Text = user.Email;
            listBox1.DisplayMember = "nombreAct";
            listBox2.DisplayMember = "nombreAct";
            lblError.Visible = false;

            CargarTipoProy();
            CargarTipoAct();
            comboTipoAct.SelectedItem = Actividad.TipoActividadE.TODAS;
        }

        private void CargarTipoAct()
        {
            comboTipoAct.Items.Clear();
            foreach(Actividad.TipoActividadE tipo in Enum.GetValues(typeof(Actividad.TipoActividadE)))
            {
                comboTipoAct.Items.Add(tipo);
            }
        }

        private void CargarTipoProy()
        {
            comboTipoProy.Items.Clear();
            foreach(Proyecto.TipoProyectoE tipo in Enum.GetValues(typeof(Proyecto.TipoProyectoE))){
                comboTipoProy.Items.Add(tipo);
            }
            
        }

        private void comboTipoAct_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            Actividad.TipoActividadE tipo = (Actividad.TipoActividadE) comboTipoAct.SelectedItem;
            if (tipo.Equals(Actividad.TipoActividadE.TODAS))
            {
                foreach (Actividad act in Actividad.ListaActividades())
                {
                    if (act.EstadoAct.Equals(Actividad.EstadoActividadE.ABIERTA) || act.EstadoAct.Equals(Actividad.EstadoActividadE.CERRADA))
                    {
                        listBox1.Items.Add(act);
                    }
                }
            }
            else
            {
                foreach (Actividad act in Actividad.ListaActividades(tipo))
                {
                    if (act.EstadoAct.Equals(Actividad.EstadoActividadE.ABIERTA) || act.EstadoAct.Equals(Actividad.EstadoActividadE.CERRADA))
                    {
                        listBox1.Items.Add(act);
                    }
                }
            }

        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                Actividad act = (Actividad)listBox1.SelectedItem;
                if(!listBox2.Items.Contains(act)) listBox2.Items.Add(act);
            }
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            if (listBox2.SelectedItem != null)
            {
                Actividad act = (Actividad)listBox2.SelectedItem;
                listBox2.ClearSelected();
                listBox2.Items.Remove(act);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            try
            {
                if (tNombreProy.Text.Trim().Equals("")) throw new Exception("Faltan parámetros: Nombre Proyecto");
                if (comboTipoProy.Text.Trim().Equals("")) throw new Exception("Faltan parámetros: Tipo Proyecto");

                Proyecto.TipoProyectoE tipoProy;
                Enum.TryParse<Proyecto.TipoProyectoE>(comboTipoProy.Text, true, out tipoProy);
                Proyecto.EstadoProyectoE estado = Proyecto.EstadoProyectoE.PREINICIO;

                Proyecto nuevoProyecto = new Proyecto(tipoProy, estado, user, tNombreProy.Text, tDescripcion.Text);

                foreach(Actividad act in listBox2.Items)
                {
                    nuevoProyecto.AddActividadToProyecto(act);
                }

                MessageBox.Show("Se ha creado el proyecto correctamente");
                this.Close();

            }
            catch(Exception ex)
            {
                lblError.Visible = true;
                lblError.Text = ex.Message;
            }
        }
    }
}
