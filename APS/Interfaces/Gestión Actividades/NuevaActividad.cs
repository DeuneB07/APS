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

        byte[] imagen;

        public NuevaActividad(Usuario ong)
        {
            InitializeComponent();
            this.ong = ong;
            tOrganizador.Enabled = false;
            tOrganizador.Text = ong.Nombre;
            labelError.Text = "";

            cargarTurnos();
            cargarTipoTrabajo();
            cargarAmbitoTrabajo();
        }

        private void bAceptar_Click(object sender, EventArgs e)
        {
            try
            {

                TurnoE turno;
                Enum.TryParse<TurnoE>(listTurno.SelectedItem.ToString(), true, out turno);
                AmbitoTrabajoE ambito;
                Enum.TryParse(listAmbito.SelectedItem.ToString(), true, out ambito);
                TipoTrabajoE trabajo;
                Enum.TryParse<TipoTrabajoE>(listTrabajo.SelectedItem.ToString(), true, out trabajo);

                /*if (pictureBox.Image != null)
                {
                    //**** GUARDAR IMAGEN****
                    int m_codigo = Convert.ToInt32(1);
                    MemoryStream m_MemoryStream = new MemoryStream();
                    pictureBox.Image.Save(m_MemoryStream, System.Drawing.Imaging.ImageFormat.Jpeg);
                    byte[] m_imagen = m_MemoryStream.ToArray();
                    //Como ven lo que realmente enviamos a la tabla es un arreglo de byte 🙂 
                    //y podemos decir que estas tres lineas anteriores son lo complicado de la tarea.
                    //*******************************
                }*/


                Actividad a = new Actividad(tNombreAct.Text, tDescripcion.Text, int.Parse(tNumPlazas.Text), int.Parse(tNumHoras.Text), turno, dateTimePickerFechaIni.Value, dateTimePickerFechaFin.Value,
                                            tLugar.Text, ong, EstadoActividadE.PENDIENTE_ACEPTACION, ambito, trabajo);

                if (!tURL.Text.Trim().Equals("")) a.Imagen = pictureBox.Image;

                MessageBox.Show("Actividad creada correctamente.\n La actividad pasará a trámite del gestor del sistema");
                MessageBox.Show("ambito; " + ambito + " trabajo: " + trabajo);
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
        }


        private void cargarTurnos()
        {
            foreach (TurnoE t in Enum.GetValues(typeof(TurnoE)))
            {
                listTurno.Items.Add(t);
            }
        }

        private void cargarTipoTrabajo()
        {
            foreach (TipoTrabajoE tTrab in Enum.GetValues(typeof(TipoTrabajoE)))
            {
                listTrabajo.Items.Add(tTrab);
            }
        }

        private void cargarAmbitoTrabajo()
        {
            foreach (AmbitoTrabajoE tAmb in Enum.GetValues(typeof(AmbitoTrabajoE)))
            {
                listAmbito.Items.Add(tAmb);
            }
        }

    }
}
