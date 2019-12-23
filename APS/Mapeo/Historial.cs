using APS.BD;
using BDLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APS.Mapeo
{
    public class Historial
    {
        private static string BD_SERVER = Properties.Settings.Default.BD_SERVER;
        private static string BD_NAME = Properties.Settings.Default.BD_NAME;

        private int id;
        private String comentario;
        private Actividad actividad;
        private Usuario usuario;
        private DateTime fecha;
        
        public static List<Historial> ListaHistorial()
        {
            // Retorna una lista con todos los obejtos de la clase almacenados en la base de datos
            SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
            List<Historial> lista = new List<Historial>();

            foreach (Object[] tupla in miBD.Select("SELECT ID_Historial FROM Historial ORDER BY fecha DESC;"))
            {
                int id = (int)tupla[0];
                Historial h = new Historial(id);
                lista.Add(h);
            }
            return lista;
        }

        public static List<Historial> ListaHistorial(Usuario user)
        {
            // Retorna una lista con todos los obejtos de la clase almacenados en la base de datos
            SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
            List<Historial> lista = new List<Historial>();

            foreach (Object[] tupla in miBD.Select("SELECT ID_Historial FROM Historial WHERE emailUsuario='"+ user.Email +"' ORDER BY fecha DESC;"))
            {
                int id = (int)tupla[0];
                Historial h = new Historial(id);
                lista.Add(h);
            }
            return lista;
        }

        public Historial(int id)
        {
            SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
            string sel = "SELECT * FROM Historial WHERE ID_Historial =" + id + ";";
            Object[] tupla = miBD.Select(sel)[0];
            this.id = id;
            this.comentario = tupla[1].ToString();
            if(!tupla[2].ToString().Equals("")) this.actividad = new Actividad((int)tupla[2]);
            if (!tupla[3].ToString().Equals("")) this.usuario = new Usuario(tupla[3].ToString());

            string[] fechaIn = tupla[4].ToString().Split('/','-',' ',':','.');
            this.fecha = new DateTime(int.Parse(fechaIn[2]), int.Parse(fechaIn[1]), int.Parse(fechaIn[0]),int.Parse(fechaIn[3]),int.Parse(fechaIn[4]),int.Parse(fechaIn[5]));
        }

        public int ID_Historial
        {
            get { return id; }
            set
            {
                throw new BDException("No se puede cambiar el id del historial, es autoindexado");
            }
        }

        public String Comentario
        {
            get { return comentario; }
            set
            {
                SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
                String up = "UPDATE Historial SET comentario='" + value + "' "
                        + "WHERE ID_Historial=" + this.id + ";";
                miBD.Update(up);
                this.comentario = value;
            }
        }

        public Actividad Actividad
        {
            get { return actividad; }
            set
            {
                SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
                String up = "UPDATE Historial SET idActividad=" + value.ID_Actividad + " "
                        + "WHERE ID_Historial=" + this.id + ";";
                miBD.Update(up);
                this.actividad = value;
            }
        }

        public Usuario Usuario
        {
            get { return usuario; }
            set
            {
                SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
                String up = "UPDATE Historial SET emailUsuario='" + value.Email + "' "
                        + "WHERE ID_Historial=" + this.id + ";";
                miBD.Update(up);
                this.usuario = value;
            }
        }

        public DateTime Fecha
        {
            get { return fecha; }
            set
            {
                SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
                String up = "UPDATE Historial SET fecha='" + value.ToLongDateString() + "' "
                        + "WHERE ID_Historial=" + this.id + ";";
                miBD.Update(up);
                this.fecha = value;
            }
        }

        public override string ToString()
        {
            return this.Comentario;
        }

        public override bool Equals(object obj)
        {
            return obj is Historial && (((Historial)obj).ID_Historial.CompareTo(this.ID_Historial) == 0);
        }

        public override int GetHashCode()
        {
            return ID_Historial.GetHashCode();
        }


    }
}
