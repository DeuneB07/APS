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
    public partial class Registro : Form
    {
        public Registro()
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
            string correo = t_correoReg.Text;
            string pwd = t_pwdReg.Text;

            try
            {
                //Comprobar que no está registrado el email en la BBDD
                try
                {
                    new Usuario(correo);
                    throw new Exception("Existe el usuario con el mismo correo");
                }
                catch (BDException ex)
                {
                    
                }

                UsuarioJSON userJSON = IDUMA.Acceso(correo, pwd);

                //Registra al usuario en la BBDD
                Usuario user = new Usuario(userJSON.UserEmail, new Rol(userJSON.CategoryName), userJSON.Nombre, userJSON.PrimerApellido, userJSON.SegundoApellido, userJSON.Situation);
                if (tUsuario.Text != "") user.NombreUser = tUsuario.Text;
                if (tDNI.Text != "") user.DNI = tDNI.Text;
                if (dateTimePickerFechNacimiento.Value.ToShortDateString() != DateTime.Today.ToShortDateString()) user.FechaNac = dateTimePickerFechNacimiento.Value.ToShortDateString();

                MessageBox.Show("Usuario creado correctamente");

                this.Close();

            }catch(Exception ex)
            {
                labelError.Text = ex.Message;
            }
            
        }


        /*
        private void b_ONGReg_Click(object sender, EventArgs e)
        {
            //Comprobar
        }*/

    }
}
