using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace APS.Interfaces.GestorExclusive
{
    public partial class CNoticia : UserControl
    {

        private ImagenesDB.Noticias n;

        public CNoticia(ImagenesDB.Noticias n)
        {
            InitializeComponent();
            this.n = n;

            MemoryStream m_MemoryStream = new MemoryStream(n.imagen);
            this.pictImage.BackgroundImage = Image.FromStream(m_MemoryStream);
            this.lNoticia.Text = n.titular;
            this.lFecha.Text = n.fechaPublicacion.ToShortDateString();
        }
    }
}
