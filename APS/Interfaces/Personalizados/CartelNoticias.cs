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

namespace APS.Interfaces.Personalizados
{
    public partial class CartelNoticias : UserControl
    {

        private ImagenesDB.Noticias n;

        public CartelNoticias(ImagenesDB.Noticias n)
        {
            InitializeComponent();
            this.n = n;

            MemoryStream m_MemoryStream = new MemoryStream(n.imagen);
            this.pictureBox1.Image = Image.FromStream(m_MemoryStream);
            this.lNoticia.Text = n.titular;

        }
    }
}
