using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace APS.Certificados
{
    public class PlantillaCertificado
    {
        private const string ORIGEN = @"C:\Users\Jesús\Desktop\Ingeniería de Software UMA\Curso 3\Semestre 1\Ingeniería de Requisitos\Proyecto APS\ProyectoC#\GitHub\APS\APS\Certificados\PlantillaCertificado.pdf";

        public static void CrearCertificado(String urlDestino, String nombreUser, String nombreAct)
        {
            string oldFile = ORIGEN;
            string newFile = urlDestino;

            // open the reader
            PdfReader reader = new PdfReader(oldFile);
            //Objeto que tiene el tamaño de nuestro documento
            Rectangle size = reader.GetPageSizeWithRotation(1);
            //documento de itextsharp para realizar el trabajo asignandole el tamaño del original
            Document doc = new Document(size);

            // Creamos el objeto en el cual haremos la inserción
            FileStream fs = new FileStream(newFile, FileMode.Create, FileAccess.Write);
            PdfWriter writer = PdfWriter.GetInstance(doc, fs);
            doc.Open();

            //El contenido del pdf, aqui se hace la escritura del contenido
            PdfContentByte cb = writer.DirectContent;

            //Propiedades de nuestra fuente a insertar
            BaseFont bf = BaseFont.CreateFont(BaseFont.HELVETICA_BOLD, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
            cb.SetColorFill(BaseColor.DARK_GRAY);
            cb.SetFontAndSize(bf, 20);

            cb.BeginText();
            // put the alignment and coordinates here
            cb.ShowTextAligned(1, nombreUser, size.Width/2, size.Height/2+40, 0);
            cb.EndText();
            cb.BeginText();
            cb.SetColorFill(BaseColor.BLACK);
            cb.SetFontAndSize(bf, 16);
            // put the alignment and coordinates here
            cb.ShowTextAligned(1, nombreAct, size.Width/2, size.Height/2-35, 0);
            cb.EndText();

            PdfImportedPage page = writer.GetImportedPage(reader, 1);
            cb.AddTemplate(page, 0, 0);

            // close the streams and voilá the file should be changed :)
            doc.Close();
            fs.Close();
            writer.Close();
            reader.Close();
        }

    }
}
