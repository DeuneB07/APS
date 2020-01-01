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

namespace APS.Interfaces.Personalizados
{
    public partial class CartelSolicitantesActividad : UserControl
    {
        private Usuario usrLogin;
        private Usuario usrShow;

        public CartelSolicitantesActividad(Usuario usrLogin, Usuario usrShow)
        {
            InitializeComponent();
            this.usrLogin = usrLogin;
            this.usrShow = usrShow;
            this.labelName.Text = usrShow.Nombre + " " +usrShow.Apellido1 + " " +usrShow.Apellido2;
            this.lShowNick.Text = usrShow.NombreUser;
            this.lShowMail.Text = usrShow.Email;
            this.lShowRol.Text = usrShow.Rol.NombreRol;
            this.lShowNac.Text = usrShow.FechaNac.ToShortDateString();
            if (usrShow.Imagen != null) pict.Image = usrShow.Imagen;
            if (usrShow.Grados.Count > 0)
            {
                Grado g = usrShow.Grados[0];
                lblGrado.Visible = true;
                lGrado.Visible = true;
                lGrado.Text = g.NombreGrado;
                lblAsignaturas.Visible = true;
                listAsig.Visible = true;
                foreach(Asignatura a in usrShow.Asignaturas)
                {
                    Console.WriteLine(a.NombreAsig);
                    listAsig.Items.Add(a.NombreAsig);
                }
                
            }

            if (usrLogin.Rol.NombreRol.Equals("ONG"))
            {
                labelName.Text = "ANÓNIMO";
                lShowNick.Text = "Anónimo";
                lMail.Visible = false;
                lShowMail.Visible = false;
                lShowNac.Visible = false;
                lNacimiento.Visible = false;
                if (usrShow.Rol.NombreRol.Equals("Estudiante"))
                {
                    pict.Image = Properties.Resources.Estudiantes_UMA;
                }else if (usrShow.Rol.NombreRol.Equals("ONG"))
                {
                    pict.Image = Properties.Resources.Cooperacion_Internacional;
                }
                else
                {
                    pict.Image = Properties.Resources.Personal_UMA_PDI_PAS;
                }
            }
        }

        #region Properties
        private string _noun;
        private string _nick;
        private string _rol;
        private string _email;
        private string _nacimiento;
        private Image _icon;

        [Category("Custom Props")]
        public string Nombre
        {
            get { return _noun; }
            set { _noun = value; labelName.Text = value; }
        }

        [Category("Custom Props")]
        public string Nick
        {
            get { return _nick; }
            set { _nick = value; lShowNick.Text = value; }
        }

        [Category("Custom Props")]
        public string E_MAIL
        {
            get { return _email; }
            set { _email = value; lShowMail.Text = value; }
        }

        [Category("Custom Props")]
        public string Fecha_Nacimiento
        {
            get { return _nacimiento; }
            set { _nacimiento = value; lShowNac.Text = value; }
        }

        [Category("Custom Props")]
        public string Rol
        {
            get { return _rol; }
            set { _rol = value; lShowRol.Text = value; }
        }

        [Category("Custom Props")]
        public Image ImagenUser
        {
            get { return _icon; }
            set { _icon = value; pict.Image = value; }
        }

        #endregion

        private void bVerTodo_Click(object sender, EventArgs e)
        {
            //VerUsuario vUsr = new VerUsuario(this.usrLogin, this.usrShow);
            //vUsr.ShowDialog();
        }

        private void listAsig_SelectedIndexChanged(object sender, EventArgs e)
        {
            listAsig.SelectedItem = null;
            listAsig.SelectedText = "";
            listAsig.SelectedValue = null;
            listAsig.Text = "";
        }
    }
}
