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

        }

        private void bAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                TurnoE turno;
                Enum.TryParse<TurnoE>(listTurno.SelectedItem.ToString(), true, out turno);
                AmbitoTrabajoE ambito;
                Enum.TryParse(listAmbito.SelectedItem.ToString(),true, out ambito);
                TipoTrabajoE trabajo;
                Enum.TryParse<TipoTrabajoE>(listTrabajo.SelectedItem.ToString(),true,out trabajo);

                Actividad a = new Actividad(tNombreAct.Text,tDescripcion.Text,int.Parse(tNumPlazas.Text),int.Parse(tNumHoras.Text),turno,dateTimePickerFechaIni.Value,dateTimePickerFechaFin.Value,
                                            tLugar.Text,ong,EstadoActividadE.PENDIENTE_ACEPTACION,ambito,trabajo);

                MessageBox.Show("Actividad creada correctamente.\n La actividad pasará a trámite del gestor del sistema");
                MessageBox.Show("ambito; " + ambito + " trabajo: " + trabajo);
                this.Close();


            }catch(Exception ex)
            {
                labelError.Text = "ERROR: Faltan Parámetros o son incorrectos. \n"+ex.Message;
            }

        }

        private void bCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      /*  private void btnExaminar_Click(object sender, EventArgs e)
        {
            OpenFileDialog OD = new OpenFileDialog();
            OD.Filter = "Imagenes jpg(*.jpg)| *.jpg | All Files(*.*) | *.*";
            if (OD.ShowDialog() == true)
            {
                using (Stream stream = OD.OpenFile())
                {
                    bitCoder = BitmapDecoder.Create(stream, BitmapCreateOptions.PreservePixelFormat,
                        BitmapCacheOption.OnLoad);
                    Foto.Source = bitCoder.Frames[0];
                    txtRutaImagen.Text = OD.FileName;
                }
            }
            else
            {
                Foto.Source = null;
            }
            System.IO.FileStream fs;
            fs = new System.IO.FileStream(txtRutaImagen.Text, System.IO.FileMode.Open);
            imagen = new byte[Convert.ToInt32(fs.Length.ToString())];
            fs.Read(imagen, 0, imagen.Length);
        }*/
    }
}
