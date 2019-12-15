using System;
using System.Collections.Generic;
using BDLibrary;
using APS.BD;

namespace APS.Mapeo
{
    public class Mensaje
    {

        private static string BD_SERVER = Properties.Settings.Default.BD_SERVER;
        private static string BD_NAME = Properties.Settings.Default.BD_NAME;

        private int ID_mensaje;
        private String asunto;
        private String texto;
        private DateTime date;
        private Usuario emisor;
        private Usuario receptor;
        
        public static List<Mensaje> ListaMensajes()
        {
            // Retorna una lista con todos los obejtos de la clase almacenados en la base de datos
            SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
            List<Mensaje> lista = new List<Mensaje>();

            foreach (object[] tupla in miBD.Select("SELECT ID_Mensaje, emailEmisor, emailReceptor FROM Mensajes;"))
            {
                String emailE = tupla[1].ToString();
                String emailR = tupla[2].ToString();
                int id = int.Parse(tupla[0].ToString());
                Mensaje m = new Mensaje(id,new Usuario(emailE), new Usuario(emailR));
                lista.Add(m);
            }
            return lista;
        }

        public static List<Mensaje> ListaMensajesEnviados(Usuario emisor)
        {
            // Retorna una lista con todos los obejtos de la clase almacenados en la base de datos
            SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
            List<Mensaje> lista = new List<Mensaje>();

            foreach (object[] tupla in miBD.Select("SELECT ID_Mensaje, emailEmisor, emailReceptor FROM Mensajes WHERE emailEmisor = '" + emisor.Email + "';"))
            {
                String emailE = tupla[1].ToString();
                String emailR = tupla[2].ToString();
                int id = int.Parse(tupla[0].ToString());
                Mensaje m = new Mensaje(id, new Usuario(emailE), new Usuario(emailR));
                lista.Add(m);
            }
            return lista;
        }

        public static List<Mensaje> ListaMensajesRecibidos(Usuario receptor)
        {
            // Retorna una lista con todos los obejtos de la clase almacenados en la base de datos
            SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
            List<Mensaje> lista = new List<Mensaje>();

            foreach (object[] tupla in miBD.Select("SELECT ID_Mensaje, emailEmisor, emailReceptor FROM Mensajes WHERE emailReceptor = '" + receptor.Email + "';"))
            {
                String emailE = tupla[1].ToString();
                String emailR = tupla[2].ToString();
                int id = int.Parse(tupla[0].ToString());
                Mensaje m = new Mensaje(id, new Usuario(emailE), new Usuario(emailR));
                lista.Add(m);
            }
            return lista;
        }

        public Mensaje(int id ,Usuario emisor, Usuario receptor)
        {
            SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
            Object[] tupla = miBD.Select("SELECT * FROM Mensajes "
                    + "WHERE emailEmisor='" + emisor.Email + "' and emailReceptor='" + receptor.Email +"' and ID_Mensaje = "+id+";")[0];
            ID_mensaje = int.Parse(tupla[0].ToString());
            asunto = tupla[1].ToString();
            texto =tupla[2].ToString();

            string[] fechaIn = tupla[3].ToString().Split('-');
            date = new DateTime(int.Parse(fechaIn[0]), int.Parse(fechaIn[1]), int.Parse(fechaIn[2]));

            emisor = new Usuario(tupla[4].ToString());
            receptor = new Usuario(tupla[5].ToString());
        }

        public Mensaje(String asunto, String texto, DateTime date, Usuario emisor, Usuario receptor)
        {
            // Crea el objeto y lo inserta en la base de datos
            SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
            miBD.Insert("INSERT INTO Mensajes (asunto,texto,fecha,emailEmisor, emailReceptor) VALUES("
                    + "'" + asunto + "', '" + texto + "', '" + date.ToShortDateString() + "', '" + emisor.Email + "', '" + receptor.Email + "');");
            this.asunto = asunto;
            this.texto = texto;
            this.date = date;
            this.emisor = emisor;
            this.receptor = receptor;
            ID_mensaje = (int)miBD.SelectScalar("SELECT max(ID_Mensaje) FROM Mensajes;");
        }

        public int ID_Mensaje
        {
            get { return ID_mensaje; }
            set {
                 throw new BDException("Error: No se puede modificar el ID de un mensaje");
            }
        }

        public String Asunto
        {
            get { return asunto; }
            set {
                 SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
                 miBD.Update("UPDATE Mensajes SET asunto = '" + value
                 + "' WHERE ID_Mensaje ='" + this.ID_Mensaje + "';");
                  asunto = value;
            }
        }

        public String Texto
        {
            get { return texto; }
            set {
                    SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
                    miBD.Update("UPDATE Mensajes SET TEXTO = '" + value
                    + "' WHERE ID_Mensaje ='" + this.ID_Mensaje + "';");
                    texto = value;
            }
        }

        public Usuario Emisor
        {
            get { return emisor; }
            set
            {
                SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
                miBD.Update("UPDATE Mensajes SET emailEmisor = '" + value.Email
                + "' WHERE ID_Mensaje = " + this.ID_Mensaje + ";");
                emisor = value;
            }
        }

        public Usuario Receptor
        {
            get { return receptor; }
            set
            {
                SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
                miBD.Update("UPDATE Mensajes SET emailReceptor = '" + value.Email
                + "' WHERE ID_Mensaje =" + this.ID_Mensaje + ";");
                receptor = value;
            }
        }

        public DateTime Date
        {
            get { return date; }
            set
            {
                SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
                miBD.Update("UPDATE Mensajes SET fecha = '" + value.ToShortDateString()
                + "' WHERE ID_Mensaje =" + this.ID_Mensaje + ";");
                date = value;
            }
        }

        public void BorraMensaje()
        {
            // Actualiza el atributo en memoria y en la base de datos
            SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
            miBD.Delete("DELETE FROM Mensajes WHERE ID_Mensaje =" + this.ID_mensaje + ";");
            emisor = receptor= null;
            asunto = texto = null;
            date = DateTime.Today;
            ID_mensaje = -1;
        }


        public override string ToString()
        {
            return "Emisor: " +"\t Receptor: "  + "\t Fecha: " + date.ToShortDateString() + "\t Asunto: " + asunto + "\t Texto: " + texto;
        }

        public override bool Equals(object obj)
        {
            return obj is Mensaje && (((Mensaje)obj).ID_mensaje == this.ID_mensaje);
        }

        public override int GetHashCode()
        {
            return ID_mensaje.GetHashCode();
        }

    }
}
