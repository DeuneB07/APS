using BDLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APS.Mapeo
{
    public class Actividad_Solicitud
    {

        private static string BD_SERVER = Properties.Settings.Default.BD_SERVER;
        private static string BD_NAME = Properties.Settings.Default.BD_NAME;

        public enum EstadoActividadSolicitudE { EN_ESPERA_PDI, EN_ESPERA_ONG, ACEPTADA, DENEGADA };

        private Usuario usuario;
        private Actividad actividad;
        private EstadoActividadSolicitudE estadoSolicitud;


        public static List<Actividad_Solicitud> ListaActividadesSolicitudes(Usuario user)
        {
            // Retorna una lista con todos los obejtos de la clase almacenados en la base de datos
            SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
            List<Actividad_Solicitud> lista = new List<Actividad_Solicitud>();

            foreach (Object[] tupla in miBD.Select("SELECT idAct FROM Actividades_Solicitudes WHERE emailParticipante='"+user.Email+"';"))
            {
                int id = int.Parse(tupla[0].ToString());
                Actividad_Solicitud aS = new Actividad_Solicitud(user, new Actividad(id));
                lista.Add(aS);
            }
            return lista;
        }

        public static List<Actividad_Solicitud> ListaActividadesSolicitudes(Usuario user, EstadoActividadSolicitudE estado)
        {
            // Retorna una lista con todos los obejtos de la clase almacenados en la base de datos
            SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
            List<Actividad_Solicitud> lista = new List<Actividad_Solicitud>();

            foreach (Object[] tupla in miBD.Select("SELECT idAct FROM Actividades_Solicitudes WHERE emailParticipante='" + user.Email + "' AND EstadoSolicitud='"+estado.ToString()+"';"))
            {
                int id = int.Parse(tupla[0].ToString());
                Actividad_Solicitud aS = new Actividad_Solicitud(user, new Actividad(id));
                lista.Add(aS);
            }
            return lista;
        }

        public static List<Actividad_Solicitud> ListaActividadesSolicitudes(Actividad act)
        {
            // Retorna una lista con todos los obejtos de la clase almacenados en la base de datos
            SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
            List<Actividad_Solicitud> lista = new List<Actividad_Solicitud>();

            foreach (Object[] tupla in miBD.Select("SELECT emailParticipante FROM Actividades_Solicitudes WHERE idAct="+act.ID_Actividad+";"))
            {
                String emP = tupla[0].ToString();
                Actividad_Solicitud aS = new Actividad_Solicitud(new Usuario(emP), act);
                lista.Add(aS);
            }
            return lista;
        }

        public static List<Usuario> ListaActividadesSolicitudes(Actividad act, Actividad_Solicitud.EstadoActividadSolicitudE estado)
        {
            // Retorna una lista con todos los obejtos de la clase almacenados en la base de datos
            SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
            List<Usuario> lista = new List<Usuario>();

            foreach (Object[] tupla in miBD.Select("SELECT emailParticipante FROM Actividades_Solicitudes WHERE idAct=" + act.ID_Actividad + " and EstadoSolicitud =  '" + estado.ToString() + "';"))
            {
                String emP = tupla[0].ToString();
                Usuario u = new Usuario(emP);
                lista.Add(u);
            }
            return lista;
        }

        public Actividad_Solicitud(Usuario user, Actividad act)
        {
            SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
            String sel = "SELECT * FROM Actividades_Solicitudes WHERE emailParticipante='" + user.Email + "' AND idAct=" + act.ID_Actividad + ";";
            Object[] tupla = miBD.Select(sel)[0];
            this.usuario = user;
            this.actividad = act;
            Enum.TryParse<EstadoActividadSolicitudE>(tupla[2].ToString(), true, out this.estadoSolicitud);
        }

        public Actividad_Solicitud(Usuario user, Actividad act, EstadoActividadSolicitudE estado)
        {
            SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
            String ins = "INSERT INTO Actividades_Solicitudes VALUES('" + user.Email + "'," + act.ID_Actividad + ",'" + estado.ToString() + "');";
            miBD.Insert(ins);

            this.usuario = user;
            this.actividad = act;
            this.estadoSolicitud = estado;
        }

        public Usuario Usuario
        {
            get { return usuario; }
            set
            {
                SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
                String up = "UPDATE Actividades_Solicitudes SET emailParticipante='" + value.Email + "' "
                        + "WHERE emailParticipante='" + this.usuario.Email + "' and idAct=" + actividad.ID_Actividad + ";";
                miBD.Update(up);
                this.usuario = value;
            }
        }

        public Actividad Actividad
        {
            get { return actividad; }
            set
            {
                SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
                String up = "UPDATE Actividades_Solicitudes SET idActividad=" + value.ID_Actividad + " "
                        + "WHERE emailParticipante='" + this.usuario.Email + "' and idAct=" + actividad.ID_Actividad + ";";
                miBD.Update(up);
                this.actividad = value;
            }
        }

        public EstadoActividadSolicitudE EstadoSolicitud
        {
            get { return estadoSolicitud; }
            set
            {
                SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
                String up = "UPDATE Actividades_Solicitudes SET EstadoSolicitud='" + value.ToString() + "' "
                        + "WHERE emailParticipante='" + this.usuario.Email + "' and idAct=" + actividad.ID_Actividad + ";";
                miBD.Update(up);
                this.estadoSolicitud = value;
            }
        }

        public void BorrarActividadSolicitud()
        {
            SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
            String del = "DELETE FROM Actividades_Solicitudes WHERE emailParticipante='"+usuario.Email+"' and idAct=" + actividad.ID_Actividad + ";";
            miBD.Delete(del);
            usuario = null;
            actividad = null;
        }

        public override string ToString()
        {
            return "Actividad Solicitud [emailUsuario: " + usuario.Email + "; idAct: " + actividad.ID_Actividad + "; EstadoSolicitud: " + estadoSolicitud.ToString() + "]"; 
        }

        public override bool Equals(object obj)
        {
            return obj is Actividad_Solicitud && (((Actividad_Solicitud)obj).Usuario.Equals(this.usuario))
                    && (((Actividad_Solicitud)obj).Actividad.Equals(this.actividad));
        }

        public override int GetHashCode()
        {
            return usuario.GetHashCode() + actividad.GetHashCode();
        }

    }
}
