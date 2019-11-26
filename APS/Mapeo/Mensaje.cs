using System;
using System.Collections.Generic;
using BDLibrary;
using APS.BD;

namespace APS.Mapeo
{
    class Mensaje
    {

        private static string BD_SERVER = Properties.Settings.Default.BD_SERVER;
        private static string BD_NAME = Properties.Settings.Default.BD_NAME;

        private int ID_mensaje;
        private String asunto;
        private String texto;
        private String date;
        private Usuario emisor;
        private Usuario receptor;
        
        public static List<Mensaje> ListaMensajes()
        {
            // Retorna una lista con todos los obejtos de la clase almacenados en la base de datos
            SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
            List<Mensaje> lista = new List<Mensaje>();

            foreach (object[] tupla in miBD.Select("SELECT emailEmisor, emailReceptor FROM Mensajes;"))
            {
                String emailE = (String)tupla[0];
                String emailR = (String)tupla[1];
                Mensaje m = new Mensaje(new Usuario(emailE), new Usuario(emailR));
                lista.Add(m);
            }
            return lista;
        }

        public Mensaje(Usuario emisor, Usuario receptor)
        {
            SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
            Object[] tupla = miBD.Select("SELECT * FROM Mensajes "
                    + "WHERE emailEmisor='" + emisor.Email + "' and emailReceptor='" + receptor.Email + "';")[0];
            ID_mensaje = (int)tupla[0];
            asunto = (String)tupla[1];
            texto = (String)tupla[2];
            date = (String)tupla[3];
            emisor = new Usuario((String)tupla[4]);
            receptor = new Usuario((String)tupla[5]);
        }

        public Mensaje(String asunto, String texto, String date, Usuario emisor, Usuario receptor)
        {
            // Crea el objeto y lo inserta en la base de datos
            SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
            miBD.Insert("INSERT INTO Mensajes (asunto,texto,date,emailEmisor, emailReceptor) VALUES("
                    + "'" + asunto + "', '" + texto + "', '" + date + "', '" + emisor.Email + "', '" + receptor.Email + "');");
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
                + "' WHERE ID_Mensaje ='" + this.ID_Mensaje + "';");
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
                + "' WHERE ID_Mensaje ='" + this.ID_Mensaje + "';");
                receptor = value;
            }
        }

        public String Date
        {
            get { return date; }
            set
            {
                SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
                miBD.Update("UPDATE Mensajes SET date = '" + value
                + "' WHERE ID_Mensaje ='" + this.ID_Mensaje + "';");
                date = value;
            }
        }

        public void BorraMensaje()
        {
            // Actualiza el atributo en memoria y en la base de datos
            SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
            miBD.Delete("DELETE FROM Mensajes WHERE ID_Mensaje ='" + this.ID_mensaje + "';");
            emisor = receptor= null;
            asunto = texto = null;
            date = null;
            ID_mensaje = -1;
        }


        public override string ToString()
        {
            return "Emisor: " + emisor.Email +"\n Receptor: " + receptor.Email + "\n Fecha: " + date + "\n Asunto: " + asunto + "\n Texto: " + texto;
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
