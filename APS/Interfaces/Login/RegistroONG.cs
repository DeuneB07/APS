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
    public partial class RegistroONG : Form
    {
        public RegistroONG()
        {
            InitializeComponent();
            labelError.Text = "";
        }

        private void b_cancelarReg_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void b_aceptarReg_Click(object sender, EventArgs e)
        {
            string correo = tEmail.Text;
            string pwd = tPassword.Text;
            string pwd2 = tConfirmar.Text;

            try
            {
                if (correo.Equals("")) throw new Exception("El correo no puede estar vacío");
                if (pwd.Equals("")) throw new Exception("La contraseña no puede estar vacía");
                if (!pwd.Equals(pwd2)) throw new Exception("Las contraseñas no coinciden");
                if (tNombreONG.Text.Trim().Equals("")) throw new Exception("El campo nombre completo ONG no puede estar vacío");
                Usuario nuevoUser = new Usuario(correo, pwd, tUsuario.Text, new Rol("ONG"), false);
                nuevoUser.Nombre = tNombreONG.Text;

                if (!tUsuario.Text.Trim().Equals("")) nuevoUser.NombreUser = tUsuario.Text;
                nuevoUser.FechaNac = dateTimePickerFechNacimiento.Value;
                //if (!tURL.Text.Trim().Equals("")) nuevoUser.Imagen = pictureBoxPerfil.Image;
                
                MessageBox.Show("Usuario creado correctamente");

                this.Close();

            }catch(Exception ex)
            {
                labelError.Text = ex.Message;
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
        }

        private void btnBorrarImagen_Click(object sender, EventArgs e)
        {
            tURL.Text = "";
            pictureBoxPerfil.Image = global::APS.Properties.Resources.userDefault; ;
        }
    }
}
