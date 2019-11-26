using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;
using Newtonsoft.Json;

namespace APS.JSON
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main2()
        {
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());

            //Solicitar el Json desde desde la web
            string url;
            url = "http://idumamockup-env.3mca2qexfx.eu-central-1.elasticbeanstalk.com/getuser/jmmunoz@uma.es/sanche12";

            WebRequest wrGETURL;
            wrGETURL = WebRequest.Create(url);

            Stream objStream;
            objStream = wrGETURL.GetResponse().GetResponseStream();

            StreamReader objReader = new StreamReader(objStream);

            string sLine = "";
            sLine = objReader.ReadLine();

            //Deserializar el Json en la clase usuario
            UsuarioJSON usuario = JsonConvert.DeserializeObject<UsuarioJSON>(sLine);

            Console.WriteLine(usuario);

        }
    }
}
