using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APS
{
    public partial class Form1 : Form
    {

        Image imagen;
        byte[] bytes;
        String str;
        public Form1()
        {
            InitializeComponent();
            imagen = null;
            bytes = null;
            str = null;
        }

        private void btnExaminar_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Archivos jpg (*.jpg)|*.jpg|Archivos png(*.png)|*.png";
            openFileDialog1.FilterIndex = 1;

            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textFile.Text = openFileDialog1.FileName;
            }
            
            pictureBox1.ImageLocation = openFileDialog1.FileName;
            
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            imagen = pictureBox1.Image;
            pictureBox2.Image = imagen;
        }

        private void btnCargarString_Click(object sender, EventArgs e)
        {
            Console.WriteLine("inicio: " + bytes.Length);
            str = Encoding.UTF32.GetString(bytes);
            byte[] m_imagen = Encoding.UTF32.GetBytes(str);
            Console.WriteLine("fin: " + m_imagen.Length);
            MemoryStream m_MemoryStream = new MemoryStream(m_imagen);
            pictureBox2.Image = Image.FromStream(m_MemoryStream);
        }

        private void btnCargarArray_Click(object sender, EventArgs e)
        {
            byte[] m_imagen = bytes;
            MemoryStream m_MemoryStream = new MemoryStream(m_imagen);
            pictureBox2.Image = Image.FromStream(m_MemoryStream);
        }

        private void btnArray_Click(object sender, EventArgs e)
        {
            MemoryStream m_MemoryStream = new MemoryStream();
            pictureBox1.Image.Save(m_MemoryStream, System.Drawing.Imaging.ImageFormat.Png);
            byte[] m_imagen = m_MemoryStream.ToArray();
            bytes = m_imagen;

            byte[] file = null;
            Stream myStream = openFileDialog1.OpenFile();
            using(MemoryStream ms = new MemoryStream())
            {
                myStream.CopyTo(ms);
                file = ms.ToArray();
            }

            using (ActividadesDB.Entities db = new ActividadesDB.Entities())
            {
                ActividadesDB.Actividades obj = new ActividadesDB.Actividades();
                obj.imagen = file;

                db.Actividades.Add(obj);
                db.SaveChanges();
               
            }

                str = Convert.ToBase64String(bytes);
            Console.WriteLine(str);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
