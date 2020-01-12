using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APS.Interfaces.GestorExclusive
{
    public partial class InsertarNoticia : Form
    {
        public InsertarNoticia()
        {
            InitializeComponent();
        }

        private void pictCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictOK_Click(object sender, EventArgs e)
        {
            try
            {
                //if (textTitular.Text.Equals("")) throw new Exception("Campo Titular Incompleto.");
                if (tURL.Text.Trim().Equals("")) throw new Exception("Imagen Requerida.");
                String titular = textTitular.Text;

                ImagenesDB.WePassEntities1 contexto = new ImagenesDB.WePassEntities1();
                ImagenesDB.Noticias n = new ImagenesDB.Noticias();

                n.titular = titular;
                n.fechaPublicacion = DateTime.Today;
                ImageConverter _imageConverter = new ImageConverter();
                n.imagen = (byte[])_imageConverter.ConvertTo(pict.Image, typeof(byte[]));
                contexto.Noticias.Add(n);
                contexto.SaveChanges();

                this.Close();

            }
            catch (Exception ex)
            {
                DialogResult emCierreDialog;
                string mensaje = "Se ha producido un error. " + ex.Message;
                string caption = "Lo sentimos...";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                emCierreDialog = MessageBox.Show(mensaje, caption, buttons);

            }
        }

        private void btnExaminar_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Archivos jpg (*.jpg)|*.jpg|Archivos png(*.png)|*.png";
            openFileDialog1.FilterIndex = 1;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                tURL.Text = openFileDialog1.FileName;
            }

            pict.ImageLocation = openFileDialog1.FileName;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            this.tURL.Text = "";
            this.pict.Image = global::APS.Properties.Resources.no_image;
        }
    }
}
