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
                Usuario nuevoUser = new Usuario(correo, pwd, tUsuario.Text, new Rol("ONG"));

                if (tDNI.Text != "") nuevoUser.DNI = tDNI.Text;
                if (!dateTimePickerFechNacimiento.Value.Equals(DateTime.Today)) nuevoUser.FechaNac = dateTimePickerFechNacimiento.Value;
                
                MessageBox.Show("Usuario creado correctamente");

                this.Close();

            }catch(Exception ex)
            {
                labelError.Text = ex.Message;
            }
            
        }
    }
}
