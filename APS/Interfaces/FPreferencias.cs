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

namespace APS.Interfaces
{
    public partial class FPreferencias : Form
    {

        Usuario user;

        public FPreferencias(Usuario user)
        {
            InitializeComponent();
            this.user = user;

            cargarPreferencias();

        }

        private void cargarPreferencias()
        {
            foreach(Preferencia pref in user.Preferencias)
            {
                listPreferencias.Items.Add(pref.Nombre_Preferencia);
            }
        }

        private void bAnadirPref_Click(object sender, EventArgs e)
        {
            FAnadirPreferencias ventAnadir = new FAnadirPreferencias(user);
            ventAnadir.ShowDialog();
        }

        private void bVerPref_Click(object sender, EventArgs e)
        {
            VerPreferencia ventAnadir = new VerPreferencia(new Preferencia(listPreferencias.SelectedItem.ToString(), user, true));
            ventAnadir.ShowDialog();
        }

        private void bBorrarPref_Click(object sender, EventArgs e)
        {
            if(listPreferencias.SelectedItem != null)
            {
                Preferencia p = new Preferencia(listPreferencias.SelectedItem.ToString(), user);
                p.RemovePreferencia();
                cargarPreferencias();
            }
        }

        private void bRetornar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
