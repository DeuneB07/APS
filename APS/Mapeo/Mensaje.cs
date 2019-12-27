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
        private Boolean borradoEmisor;
        private Boolean borradoReceptor;
        private Boolean leido;
        
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

            foreach (object[] tupla in miBD.Select("SELECT ID_Mensaje, emailEmisor, emailReceptor FROM Mensajes WHERE emailEmisor = '" + emisor.Email + "' and borradoEmisor = "+ 0 + " ORDER BY fecha desc;"))
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

            foreach (object[] tupla in miBD.Select("SELECT ID_Mensaje, emailEmisor, emailReceptor FROM Mensajes WHERE emailReceptor = '" + receptor.Email + "' and borradoReceptor = "+ 0 + " ORDER BY fecha desc;"))
            {
                String emailE = tupla[1].ToString();
                String emailR = tupla[2].ToString();
                int id = int.Parse(tupla[0].ToString());
                Mensaje m = new Mensaje(id, new Usuario(emailE), new Usuario(emailR));
                lista.Add(m);
            }
            return lista;
        }

        public static int ListaMensajesNoLeidos(Usuario receptor)
        {
            // Retorna una lista con todos los obejtos de la clase almacenados en la base de datos
            SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
            List<Mensaje> lista = new List<Mensaje>();

            int num = 0;
            object[] tupla = miBD.Select("SELECT count(ID_Mensaje) FROM Mensajes WHERE emailReceptor = '" + receptor.Email + "' and leido = " + 0 + ";")[0];
            if (tupla[0] != null) num = (int)tupla[0];
            return num;
        }

        public Mensaje(int id ,Usuario emisor, Usuario receptor)
        {
            SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
            Object[] tupla = miBD.Select("SELECT * FROM Mensajes "
                    + "WHERE emailEmisor='" + emisor.Email + "' and emailReceptor='" + receptor.Email +"' and ID_Mensaje = "+id+";")[0];
            ID_mensaje = int.Parse(tupla[0].ToString());
            asunto = tupla[1].ToString();
            texto = tupla[2].ToString();

            string[] fechaIn = tupla[3].ToString().Split('-');
            date = new DateTime(int.Parse(fechaIn[0]), int.Parse(fechaIn[1]), int.Parse(fechaIn[2]));

            this.emisor = new Usuario(tupla[4].ToString());
            this.receptor = new Usuario(tupla[5].ToString());

            this.borradoEmisor = (Boolean) tupla[6];
            this.borradoReceptor = (Boolean) tupla[7];
            this.leido = (Boolean)tupla[8];
        }

        public Mensaje(String asunto, String texto, DateTime date, Usuario emisor, Usuario receptor)
        {
            // Crea el objeto y lo inserta en la base de datos
            SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
            miBD.Insert("INSERT INTO Mensajes (asunto,texto,fecha,emailEmisor, emailReceptor, borradoEmisor, borradoReceptor, leido) VALUES("
                    + "'" + asunto + "', '" + texto + "', '" + date.ToShortDateString() + "', '" + emisor.Email + "', '" + receptor.Email + "', " + 0 + ", " + 0 +", " + 0 + ");");
            this.asunto = asunto;
            this.texto = texto;
            this.date = date;
            this.emisor = emisor;
            this.receptor = receptor;
            this.borradoEmisor = false;
            this.borradoReceptor = false;
            this.leido = false;
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
                + "' WHERE ID_Mensaje = " + ID_Mensaje + ";");
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

        public Boolean BorradoEmisor
        {
            get { return borradoEmisor; }
            set
            {
                SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
                miBD.Update("UPDATE Mensajes SET borradoEmisor = " + (value ? 1 : 0)
                + " WHERE ID_Mensaje =" + this.ID_Mensaje + ";");
                borradoEmisor = value;
            }
        }

        public Boolean BorradoReceptor
        {
            get { return borradoReceptor; }
            set
            {
                SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
                miBD.Update("UPDATE Mensajes SET borradoReceptor = " + (value ? 1 : 0)
                + " WHERE ID_Mensaje =" + this.ID_Mensaje + ";");
                borradoReceptor = value;
            }
        }

        public Boolean Leido
        {
            get { return leido; }
            set
            {
                SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
                miBD.Update("UPDATE Mensajes SET leido = " + (value ? 1 : 0)
                + " WHERE ID_Mensaje =" + this.ID_Mensaje + ";");
                leido = value;
            }
        }

        public void BorraMensaje()
        {
            // Actualiza el atributo en memoria y en la base de datos
            SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
            miBD.Delete("DELETE FROM Mensajes WHERE ID_Mensaje =" + this.ID_mensaje + ";");
            emisor = receptor = null;
            asunto = texto = null;
            date = DateTime.Today;
            borradoEmisor = borradoReceptor = false;
            ID_mensaje = -1;
            leido = false;
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
