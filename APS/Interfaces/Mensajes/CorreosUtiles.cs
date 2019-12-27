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

namespace APS.Interfaces.Mensajes
{
    public partial class CorreosUtiles : Form
    {
        public CorreosUtiles()
        {
            InitializeComponent();

            cargarRoles();
        }

        private void cargarRoles()
        {
            foreach(Rol r in Rol.ListaRoles())
            {
                if(!r.NombreRol.Equals("Estudiante") && !r.NombreRol.Equals("PAS")) 
                    comboRol.Items.Add(r);
            }
            comboRol.DisplayMember = "nombreRol";
        }

        private void comboRol_SelectedIndexChanged(object sender, EventArgs e)
        {
            listUtil.Items.Clear();
            foreach(Usuario u in Usuario.ListaUsuarios((Rol)comboRol.SelectedItem))
            {
                String nombre = buscarNombre(u);
                listUtil.Items.Add(u.Email + " :: "+ nombre);
            }
        }

        private string buscarNombre(Usuario u)
        {
            string nombre = "No se ha encontrado";
            if (u.Nombre != null && !u.Nombre.Equals(""))
            {
                nombre = u.Nombre;
                if (u.Apellido1 != null && !u.Apellido1.Equals(""))
                {
                    nombre = nombre + " " + u.Apellido1;
                    if (u.Apellido2 != null && !u.Apellido2.Equals(""))
                        nombre = nombre + " " + u.Apellido2;
                }
            }
            return nombre;
        }

        private void pictExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
