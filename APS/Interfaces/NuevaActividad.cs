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
                TurnoE turno;
                Enum.TryParse<TurnoE>(listTurno.SelectedItem.ToString(), true, out turno);
                AmbitoTrabajoE ambito;
                Enum.TryParse<AmbitoTrabajoE>(listAmbito.SelectedItem.ToString(),true, out ambito);
                TipoTrabajoE trabajo;
                Enum.TryParse<TipoTrabajoE>(listTrabajo.SelectedItem.ToString(),true,out trabajo);

                Actividad a = new Actividad(tNombreAct.Text,tDescripcion.Text,int.Parse(tNumPlazas.Text),int.Parse(tNumHoras.Text),turno,dateTimePickerFechaIni.Value.ToShortDateString(),dateTimePickerFechaFin.Value.ToShortDateString(),
                                            tLugar.Text,ong,EstadoActividadE.PENDIENTES,ambito,trabajo);

                MessageBox.Show("Actividad creada correctamente.\n La actividad pasará a trámite del gestor del sistema");
                this.Close();

            }catch(Exception ex)
            {
                labelError.Text = "ERROR: Faltan Parámetros o son incorrectos";
            }

        }

        private void bCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
