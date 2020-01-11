using APS.Mapeo;
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
        private const string ORIGEN = @"C:\Users\Jesús\Desktop\Ingeniería de Software UMA\Curso 3\Semestre 1\Ingeniería de Requisitos\Proyecto APS\ProyectoC#\GitHub\APS\APS\Certificados\PlantillaCertificado2.pdf";

        public static void CrearCertificado(String urlDestino, Actividad_Realizada actRealizada)
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
            BaseFont bf = BaseFont.CreateFont(@"C:\WINDOWS\FONTS\KUNSTLER.TTF", BaseFont.CP1252, BaseFont.NOT_EMBEDDED);

            ///TÍTULO
            bf = BaseFont.CreateFont(@"C:\WINDOWS\FONTS\CASTELAR.TTF", BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
            cb.SetColorFill(BaseColor.DARK_GRAY);
            cb.SetFontAndSize(bf, 18);
            cb.BeginText();
            // put the alignment and coordinates here
            cb.ShowTextAligned(1, "Plataforma CS-APS & "+actRealizada.Actividad.Organizador.Nombre, size.Width / 2, size.Height - 93, 0);
            cb.ShowTextAligned(1, "LE OTORGAN", size.Width / 2, size.Height - 115, 0);
            cb.EndText();


            ///NOMBRE Y APELLIDOS USUARIO
            bf = BaseFont.CreateFont(@"C:\WINDOWS\FONTS\KUNSTLER.TTF", BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
            cb.SetColorFill(BaseColor.DARK_GRAY);
            cb.SetFontAndSize(bf, 35);
            cb.BeginText();
            // put the alignment and coordinates here
            string nombreParticipante = actRealizada.Participante.Nombre + " " + actRealizada.Participante.Apellido1 + " " + actRealizada.Participante.Apellido2;
            cb.ShowTextAligned(1, nombreParticipante , size.Width/2, size.Height/2+16, 0);
            cb.EndText();

            ///NOMBRE ACTIVIDAD
            bf = BaseFont.CreateFont(BaseFont.HELVETICA_BOLDOBLIQUE, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
            cb.SetColorFill(BaseColor.BLACK);
            cb.SetFontAndSize(bf, 16);
            cb.BeginText();
            // put the alignment and coordinates here
            cb.ShowTextAligned(1, actRealizada.Actividad.NombreAct, size.Width/2, size.Height/2-61, 0);
            cb.EndText();

            ///FECHA Y HORAS
            bf = BaseFont.CreateFont(@"C:\WINDOWS\FONTS\FRAMD.TTF", BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
            cb.SetColorFill(BaseColor.GRAY);
            cb.SetFontAndSize(bf, 12);
            cb.BeginText();
            // put the alignment and coordinates here
            cb.ShowTextAligned(1, "con un total de "+ actRealizada.NumHorasRealizadas +" horas desde "
                + actRealizada.FechaInicialUsuario.ToShortDateString() +" hasta " + actRealizada.FechaFinalUsuario.ToShortDateString(), size.Width / 2, size.Height / 2 - 83, 0);
            cb.EndText();

            //PUNTUACIÓN
            bf = BaseFont.CreateFont(@"C:\WINDOWS\FONTS\FRAMD.TTF", BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
            cb.SetColorFill(BaseColor.BLACK);
            cb.SetFontAndSize(bf, 34);
            cb.BeginText();
            // put the alignment and coordinates here
            cb.ShowTextAligned(1, (actRealizada.ValoracionONG*2).ToString()+"/10", 142, 139, 0);
            cb.EndText();

            PdfImportedPage page = writer.GetImportedPage(reader, 1);
            cb.AddTemplate(page, 0, 0);

            // close the streams and voilá the file should be changed :)
            doc.Close();
            fs.Close();
            writer.Close();
            reader.Close();
        }

        public static BaseFont GetFont(string fileName)
        {
            return BaseFont.CreateFont(fileName, BaseFont.CP1252, BaseFont.EMBEDDED);
        }

    }
}
