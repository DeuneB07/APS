using APS.BD;
using APS.Interfaces.Personalizados;
using APS.JSON;
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
    public partial class PaginaInicio : Form
    {

        private int i = -1;
        private List<ImagenesDB.Noticias> noticias;
        public PaginaInicio()
        {
            InitializeComponent();
            panel1.Controls.Add(table);
            
            CargarNoticias();
        }

        private void bPersonalUMA_Click(object sender, EventArgs e)
        {
            this.GoPersonalUMA();
        }

        private void GoPersonalUMA()
        {
            iDumaInicio panel = new iDumaInicio();
            this.Visible = false;
            panel.ShowDialog();
            CargarNoticias();
            this.Visible = true;
        }

        private void bPersonalExt_Click(object sender, EventArgs e)
        {
            this.GoInicioPersExterno();
        }

        private void GoInicioPersExterno()
        {
            InicioPersExterno pagina = new InicioPersExterno();
            this.Visible = false;
            pagina.ShowDialog();
            CargarNoticias();
            this.Visible = true;
        }

        private void bExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            i = (i + 1) % noticias.Count;
            CargarImagen();
        }

        private void CargarImagen()
        {
            table.Controls.Clear();
            ImagenesDB.Noticias n = noticias[i];
            CartelNoticias cartel = new CartelNoticias(n);
            table.Controls.Add(cartel, 0, 0);
            //table.RowCount = table.RowCount + 1;
        }

        private void CargarNoticias()
        {
            noticias = new List<ImagenesDB.Noticias>();
            ImagenesDB.WePassEntities1 contexto = new ImagenesDB.WePassEntities1();
            //noticias = contexto.Noticias.ToList();
            var query = from n in contexto.Noticias
                           orderby n.fechaPublicacion
                           select n;
            noticias = query.ToList<ImagenesDB.Noticias>();
            if (noticias.Count > 1)
            {
                i = 0;
                timer1.Start();
                CargarImagen();
            }
        }
    }
}
