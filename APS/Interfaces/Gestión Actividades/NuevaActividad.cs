using APS.Mapeo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static APS.Mapeo.Actividad;

namespace APS.Interfaces
{
    public partial class NuevaActividad : Form
    {

        private Usuario ong;

        public NuevaActividad(Usuario ong)
        {
            InitializeComponent();
            this.ong = ong;
            tOrganizador.Enabled = false;
            tOrganizador.Text = ong.Nombre;
            labelError.Text = "";
        }

        private void bAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                if (int.Parse(tNumPlazas.Text) < -1) throw new Exception("Número de plazas debe ser positivo, o -1 si es indefinido");
                if (int.Parse(tNumHoras.Text) <= 0) throw new Exception("Número de horas debe ser positivo");
                if (dateTimePickerFechaIni.Value < DateTime.Today) throw new Exception("Fecha inicio debe ser posterior o igual a la fecha actual");
                if (dateTimePickerFechaFin.Value < dateTimePickerFechaIni.Value) throw new Exception("Fecha fin debe ser posterior o igual a la fecha inicial");
                //if (tLugar.Text.Trim().Equals("")) throw new Exception("Lugar no puede estar vacía");

                TurnoE turno;
                Enum.TryParse<TurnoE>(listTurno.SelectedItem.ToString(), true, out turno);

                //ANTIGUO
                AmbitoTrabajoE ambito;
                Enum.TryParse(listAmbito.Text, true, out ambito);
                TipoTrabajoE trabajo;
                Enum.TryParse<TipoTrabajoE>(listTrabajo.Text, true, out trabajo);
                //NUEVO
                if (listAmbito.SelectedItem.Equals(null)) throw new Exception("Ningún Ambito de trabajo seleccionado");
                if (listTrabajo.SelectedItem.Equals(null)) throw new Exception("Ningún Tipo de trabajo seleccionado");
                AmbitoTrabajo ambito2 = (AmbitoTrabajo)listAmbito.SelectedItem;
                TipoTrabajo trabajo2 = (TipoTrabajo)listTrabajo.SelectedItem;
                Console.WriteLine("idAmbito: " + ambito2.ID_AmbitoTrabajo + "; ambito: " + ambito2.Ambito_Trabajo);
                Console.WriteLine("idTipo: " + trabajo2.ID_TipoTrabajo + "; tipo: " + trabajo2.Tipo_Trabajo);

                Actividad a = new Actividad(tNombreAct.Text, tDescripcion.Text, int.Parse(tNumPlazas.Text), int.Parse(tNumHoras.Text), turno, dateTimePickerFechaIni.Value, dateTimePickerFechaFin.Value,
                                            tLugar.Text, ong, EstadoActividadE.PENDIENTE_ACEPTACION, ambito, trabajo, ambito2, trabajo2);

                if (!tURL.Text.Trim().Equals("")) a.Imagen = pictureBox.Image;

                MessageBox.Show("Actividad creada correctamente.\n La actividad pasará a trámite del gestor del sistema");
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

        private void btnExaminar_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Archivos jpg (*.jpg)|*.jpg|Archivos png(*.png)|*.png";
            openFileDialog1.FilterIndex = 1;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                tURL.Text = openFileDialog1.FileName;
            }

            pictureBox.ImageLocation = openFileDialog1.FileName;
            Console.WriteLine(openFileDialog1.FileName);
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            tURL.Text = "";
            pictureBox.Image = null;
        }


        private void cargarTurnos()
        {
            foreach (TurnoE t in Enum.GetValues(typeof(TurnoE)))
            {
                listTurno.Items.Add(t);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            this.tURL.Text = "";
            this.pictureBox.Image = global::APS.Properties.Resources.no_image;
        }

        private void NuevaActividad_Load(object sender, EventArgs e)
        {
            cargarTurnos();
            cargarAmbitoTrabajo();
            cargarTipoTrabajo();
        }

        private void cargarAmbitoTrabajo()
        {
            listAmbito.Items.Clear();
            foreach(AmbitoTrabajo ambito in AmbitoTrabajo.ListaAmbitoTrabajo())
            {
                listAmbito.Items.Add(ambito);
            }
            listAmbito.DisplayMember = "ambitoTrabajo";
        }

        private void cargarTipoTrabajo()
        {
            listTrabajo.Items.Clear();
            foreach(TipoTrabajo tipo in TipoTrabajo.ListaTipoTrabajo())
            {
                listTrabajo.Items.Add(tipo);
            }
            listTrabajo.DisplayMember = "tipoTrabajo";
        }
    }
}
