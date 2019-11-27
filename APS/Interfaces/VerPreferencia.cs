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
    public partial class VerPreferencia : Form
    {
        Preferencia p;
        public VerPreferencia(Preferencia p) 
        {
            InitializeComponent();
            this.p = p;

            this.Text = "Preferencia: " + p.Nombre_Preferencia;
            lShowGrado.Text = p.Grado.NombreGrado;
            lShowHoras.Text = p.HorasPosibles.ToString();
            lShowNoun.Text = p.Nombre_Preferencia;
            lShowTipo.Text = p.TipoActividad.ToString();
            lShowTurno.Text = p.Turno.ToString();
            lShowPreferencia.Text = p.Asignatura.NombreAsig;
            cargarCompetencias();

        }

        private void cargarCompetencias()
        {
            foreach(Competencia c in Competencia.ListaCompetencias(p))
            {
                listCompetencias.Items.Add(c.NombreComp);
            }
        }

        private void bConfirmar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
