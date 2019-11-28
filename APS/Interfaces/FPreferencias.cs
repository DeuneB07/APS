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
                listPreferencias.Items.Add(pref);
            }
        }

        private void bAnadirPref_Click(object sender, EventArgs e)
        {
            FAnadirPreferencias ventAnadir = new FAnadirPreferencias(user);
            ventAnadir.ShowDialog();
            cargarPreferencias();
        }

        private void bVerPref_Click(object sender, EventArgs e)
        {
            try
            {
                VerPreferencia ventAnadir = new VerPreferencia(new Preferencia(listPreferencias.SelectedItem.ToString(), user, true));
                ventAnadir.ShowDialog();
            } catch(NullReferenceException)
            {
                MessageBox.Show("Debe seleccionar una Preferencia", "ATENCIÓN", MessageBoxButtons.OK);
            }
            
        }

        private void bBorrarPref_Click(object sender, EventArgs e)
        {
            try
            {
                Preferencia p = new Preferencia(listPreferencias.SelectedItem.ToString(), user);
                p.RemovePreferencia();
                cargarPreferencias();
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Debe seleccionar una Preferencia", "ATENCIÓN", MessageBoxButtons.OK);
            }
        }

        private void bRetornar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
