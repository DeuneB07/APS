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

namespace APS.Interfaces.Gestión_Actividades
{
    public partial class VerActividadRealizada : Form
    {
        private Usuario user;
        private Actividad_Realizada actRealizada;

        public VerActividadRealizada(Usuario user, Actividad_Realizada actRealizada)
        {
            InitializeComponent();

            this.user = user;
            this.actRealizada = actRealizada;
            Actividad actividad = actRealizada.Actividad;
            this.Text = "Actividad Realizada " + actividad.NombreAct;
            tOrganizador.Text = actividad.Organizador.Nombre;
            tNombreAct.Text = actividad.NombreAct;
            tDescripcion.Text = actividad.DescAct;
            tNumPlazas.Text = actividad.NumPlazas.ToString();
            tNumHoras.Text = actividad.NumHoras.ToString();
            dateTimePickerFechaIni.Value = actividad.FechaInicio;
            dateTimePickerFechaFin.Value = actividad.FechaFin;
            tLugar.Text = actividad.Lugar;
            listTurno.Text = actividad.Turno.ToString();
            listAmbito.Text = actividad.AmbitoTrabajo.Ambito_Trabajo;
            listTrabajo.Text = actividad.TipoTrabajo.Tipo_Trabajo;

            if (actividad.Imagen != null)
            {
                pictureBox.Image = actividad.Imagen;
            }

            //Panel Usuario
            txtUsuario.Text = user.Nombre + " " + user.Apellido1 + " " + user.Apellido2;
            if (actRealizada.FechaValoracionUsuario != DateTime.MinValue)
            {
                ratingUsuario.Value = actRealizada.ValoracionUsuario;
                txtComentarioUsuario.Text = actRealizada.ComentarioUsuario;
                txtComentarioUsuario.Enabled = true;
                lblFechaUsuario.Text = "Evaluado: "+actRealizada.FechaValoracionUsuario.ToString();
            }
            else
            {
                panelEvUsuario.BackColor = Color.WhiteSmoke;
                lblFechaUsuario.Text = "Sin Evaluar";
            }

            //Panel ONG
            txtONG.Text = actividad.Organizador.Nombre;
            if(actRealizada.FechaValoracionONG != DateTime.MinValue)
            {
                ratingONG.Value = actRealizada.ValoracionONG;
                txtComentarioONG.Text = actRealizada.ComentarioONG;
                txtComentarioONG.Enabled = true;
                lHoras.Text = actRealizada.NumHorasRealizadas.ToString();
                if (actRealizada.ArchivoAdjuntoONG != null)
                {
                    lblArchivo.Enabled = true;
                    lblArchivo.Visible = true;
                }
                lblFechaONG.Text = "Evaluado: " + actRealizada.FechaValoracionONG.ToString();
            }
            else
            {
                panelEvONG.BackColor = Color.WhiteSmoke;
                lblFechaONG.Text = "Sin Evaluar";
            }

            //Panel PDI
            if (actividad.TipoAct.ToString().Equals("VOLUNTARIADO"))
            {
                panelEvPDI.Visible = false;
                //btnAtras.Location = new Point(714, 725);
                //this.Size = new Size(847, 819);
            }
            else
            {
                txtPDI.Text = actividad.Responsable.Nombre + " " + actividad.Responsable.Apellido1 + " " + actividad.Responsable.Apellido2;
                if(actRealizada.FechaValoracionProfesor != DateTime.MinValue)
                {
                    ratingPDI.Value = actRealizada.ValoracionProfesor;
                    txtComentarioPDI.Text = actRealizada.ComentarioProfesor;
                    txtComentarioPDI.Enabled = true;
                    lblFechaPDI.Text = "Evaluado: " + actRealizada.FechaValoracionProfesor;
                }
                else
                {
                    panelEvPDI.BackColor = Color.WhiteSmoke;
                    lblFechaPDI.Text = "Sin Evaluar";
                }
            }

        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Archivos pdf (*.pdf)|*.pdf";
            saveFileDialog1.Title = "Save a PDF File";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllBytes(saveFileDialog1.FileName, actRealizada.ArchivoAdjuntoONG);
            }
        }
    }
}
