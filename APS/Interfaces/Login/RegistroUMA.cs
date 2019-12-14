using APS.BD;
using APS.JSON;
using APS.Mapeo;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APS.Interfaces
{
    partial class RegistroUMA : Form
    {
        private UsuarioJSON userJSON;
        private Usuario user;
        private List<Grado> grados;
        private List<Asignatura> asigs;

        public RegistroUMA(UsuarioJSON userJSON)
        {
            InitializeComponent();
            
            this.userJSON = userJSON;
            grados = new List<Grado>();
            asigs = new List<Asignatura>();
            listGrado.Enabled = false;
            listAsig.Enabled = false;
            listPreferencias.DisplayMember = "nombre_preferencia";
            labelError.Text = "";
            t_correoReg.Text = userJSON.UserEmail;
            t_correoReg.Enabled = false;
            t_Nombre.Text = userJSON.Nombre + " " + userJSON.PrimerApellido + " " + userJSON.SegundoApellido;
            t_Nombre.Enabled = false;
            tRol.Text = userJSON.CategoryName;
            tRol.Enabled = false;
            if (userJSON.CategoryName.ToUpper().Equals("ESTUDIANTE") || userJSON.CategoryName.ToUpper().Equals("PDI"))
            {
                CargarGrados();
                foreach(Grado g in grados){
                    CargarAsignaturas(g);
                }
            }
            //AÑADIR USUARIO A LA BD
            user = new Usuario(userJSON.UserEmail, new Rol(userJSON.CategoryName), userJSON.Nombre, userJSON.PrimerApellido, userJSON.SegundoApellido, userJSON.Situation);
            foreach(Grado g in grados)
            {
                user.AddGrado(g);
            }
            foreach(Asignatura a in asigs)
            {
                user.AddAsignatura(a);
            }

        }

        public void CargarGrados()
        {
            //El mockup sólo nos da medicina
            //Pero habría que añadir los grados en los que cursa o imparte el estudiante/profesor
            Grado medicina = new Grado(5);
            listGrado.Items.Add(medicina.NombreGrado);
            grados.Add(medicina);
        }

        public void CargarAsignaturas(Grado g)
        {
            //Se deberían cargar todas las asignaturas que cursa
            //Pero sólo tenemos de medicina
            foreach (CursoJSON curso in userJSON.Courses) {
                Asignatura asig = new Asignatura(g, curso.Name);
                listAsig.Items.Add(asig.NombreAsig);
                asigs.Add(asig);
             }
        }

        public void CargarPreferencias()
        {
            listPreferencias.Items.Clear();
            foreach(Preferencia pref in Preferencia.ListaPreferencias(user))
            {
                listPreferencias.Items.Add(pref);
            }
        }

        private void b_cancelarReg_Click(object sender, EventArgs e)
        {
            GoToPaginaPrincipal(user);
            this.Close();
        }

        private void b_aceptarReg_Click(object sender, EventArgs e)
        {
            try
            {
                if (tUsuario.Text != "") user.NombreUser = tUsuario.Text;
                if (tDNI.Text != "") user.DNI = tDNI.Text;
                if (dateTimePickerFechNacimiento.Value != DateTime.Today) user.FechaNac = dateTimePickerFechNacimiento.Value;
                if (!tURL.Text.Trim().Equals("")) user.Imagen = pictureBoxPerfil.Image;

                MessageBox.Show("Usuario creado correctamente");

                GoToPaginaPrincipal(user);
                this.Close();

            }catch(Exception ex)
            {
                labelError.Text = ex.Message;
            }
            
        }

        private void GoToPaginaPrincipal(Usuario user)
        {
            PaginaPrincipal pagina = new PaginaPrincipal(user);
            this.Visible = false;
            pagina.ShowDialog();
            this.Visible = true;
        }

        private void bAddPref_Click(object sender, EventArgs e)
        {
            FAnadirPreferencias ventana = new FAnadirPreferencias(user);
            this.Visible = false;
            ventana.ShowDialog();
            this.Visible = true;
            this.CargarPreferencias();
        }

        private void bBorrarPref_Click(object sender, EventArgs e)
        {
            try
            {
                Preferencia p = (Preferencia)listPreferencias.SelectedItem;
                listPreferencias.Items.Remove(p);
                p.RemovePreferencia();
                user.RemovePrefrencia(p);
                CargarPreferencias();
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Debe seleccionar una Preferencia", "ATENCIÓN", MessageBoxButtons.OK);
            }
        }

        private void btnExaminar_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Archivos jpg (*.jpg)|*.jpg|Archivos png(*.png)|*.png";
            openFileDialog1.FilterIndex = 1;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                tURL.Text = openFileDialog1.FileName;
            }

            pictureBoxPerfil.ImageLocation = openFileDialog1.FileName;
            Console.WriteLine(openFileDialog1.FileName);
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            tURL.Text = "";
            pictureBoxPerfil.Image = null;
        }
    }
}
