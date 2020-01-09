using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using APS.Mapeo;
using static APS.Mapeo.Actividad;

namespace APS.Interfaces.Personalizados
{
    public partial class CartelFiltros2 : UserControl
    {

        private Usuario usrLogin;
        public Filtros filtros;

        public CartelFiltros2(Usuario usrLogin)
        {
            InitializeComponent();
            this.usrLogin = usrLogin;
            filtros = new Filtros(this);

        }

        private void label1_Click(object sender, EventArgs e)
        {
            filtros.Show();
        }

        private void pictFiltro_Click(object sender, EventArgs e)
        {
            filtros.Show();
        }

        private void panelFiltro_Click(object sender, EventArgs e)
        {
            filtros.Show();
        }

        private void txtBusqueda_Click(object sender, EventArgs e)
        {
            txtBusqueda.Text = "";
            txtBusqueda.ForeColor = Color.Black;
        }

        private void txtBusqueda_Leave(object sender, EventArgs e)
        {
            if (txtBusqueda.Text.Trim().Equals(""))
            {
                txtBusqueda.Text = "Buscador de Actividades...";
                txtBusqueda.ForeColor = SystemColors.AppWorkspace;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            filtros.checkFormacion.Checked = false;
            filtros.checkInvestigacion.Checked = false;
            filtros.checkVoluntariado.Checked = false;
            filtros.ActualizarFiltro();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            filtros.comboGrado.SelectedText = null;
            filtros.comboGrado.SelectedValue = null;
            filtros.comboGrado.SelectedItem = null;
            filtros.comboGrado.Text = "";
            filtros.comboAsig.SelectedValue = null;
            filtros.comboAsig.SelectedText = null;
            filtros.comboAsig.SelectedItem = null;
            filtros.comboAsig.Text = "";
            filtros.ActualizarFiltro();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            filtros.listComp2.Items.Clear();
            filtros.ActualizarFiltro();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            filtros.checkMañana.Checked = false;
            filtros.checkTarde.Checked = false;
            filtros.ActualizarFiltro();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            filtros.trackBarHoras.Value = 0;
            filtros.txtNumHoras.Text = "0";
            filtros.ActualizarFiltro();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            filtros.dateTimePickerInicio.Value = Filtros.dateDefault;
            filtros.dateTimePickerFin.Value = Filtros.dateDefault;
            filtros.ActualizarFiltro();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            filtros.checkInmigracion.Checked = false;
            filtros.checkSinHogar.Checked = false;
            filtros.checkPobreza.Checked = false;
            filtros.checkDiscapacidad.Checked = false;
            filtros.checkTerceraEdad.Checked = false;
            filtros.checkNiños.Checked = false;
            filtros.checkAnimales.Checked = false;
            filtros.checkOtrosAmb.Checked = false;
            filtros.ActualizarFiltro();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            filtros.checkSalud.Checked = false;
            filtros.checkEvento.Checked = false;
            filtros.checkViaje.Checked = false;
            filtros.checkInvestigacionTrabajo.Checked = false;
            filtros.checkAdministracion.Checked = false;
            filtros.checkOtrosTipo.Checked = false;
            filtros.ActualizarFiltro();
        }
    }
}
