using System;
using System.Net;
using System.IO;
using Newtonsoft.Json;

namespace APS.JSON
{
    class IDUMA
    {
        public static UsuarioJSON Acceso(String email, String pwd)
        {
            //Solicitar el Json desde desde la web string url;
            String url;
            url = "http://idumamockup-env.3mca2qexfx.eu-central-1.elasticbeanstalk.com/getuser/"+email+"/"+pwd;
            WebRequest wrGETURL;
            wrGETURL = WebRequest.Create(url);

            Stream objStream;
            objStream = wrGETURL.GetResponse().GetResponseStream();
            StreamReader objReader = new StreamReader(objStream);

            string sLine = "";
            sLine = objReader.ReadLine();

            //Deserializar el Json en la clase usuario 
            UsuarioJSON user = JsonConvert.DeserializeObject<UsuarioJSON>(sLine);
            if (user.UserEmail == null) throw new Exception("El email y/o contraseña no son correctas");

            return user;
        }

    }
}
