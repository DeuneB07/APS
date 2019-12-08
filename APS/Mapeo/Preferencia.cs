using System;
using System.Collections.Generic;
using BDLibrary;
using APS.BD;
using static APS.Mapeo.Actividad;

namespace APS.Mapeo
{
    public class Preferencia
    {

        private static string BD_SERVER = Properties.Settings.Default.BD_SERVER;
        private static string BD_NAME = Properties.Settings.Default.BD_NAME;

        private int ID_preferencia;
        private String nombre_preferencia;
        private Usuario user;
        private Grado grado;
        private Asignatura asig;
        private int horasPosibles;
        private TurnoE turno;
        private TipoActividadE tipoAct;
        private TipoTrabajoE tipoTrabajo;
        private AmbitoTrabajoE ambitoTrabajo;

        private List<Competencia> competencias;   //lazzy

        public static List<Preferencia> ListaPreferencias(Competencia c)
        {
            // Retorna una lista con todos los obejtos de la clase almacenados en la base de datos
            SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
            List<Preferencia> lista = new List<Preferencia>();

            foreach (Object[] tupla in miBD.Select("SELECT ID_Preferencia FROM Rel_Preferencia_Competencia WHERE idCompetencia=" + c.ID_Competencia + ";"))
            {
                int id = int.Parse((string)tupla[0]);
                Preferencia p = new Preferencia(id);
                lista.Add(p);
            }
            return lista;
        }

        public static List<Preferencia> ListaPreferencias(Usuario user)
        {
            // Retorna una lista con todos los obejtos de la clase almacenados en la base de datos
            SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
            List<Preferencia> lista = new List<Preferencia>();

            foreach (Object[] tupla in miBD.Select("SELECT ID_Preferencia FROM Preferencias WHERE emailUser='"+user.Email+"';"))
            {
                int id = int.Parse(tupla[0].ToString());
                Preferencia p = new Preferencia(id);
                lista.Add(p);
            }
            return lista;
        }

        public Preferencia(int id)
        {
            SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
            Object[] tupla = miBD.Select("SELECT * FROM Preferencias "
                        + "WHERE ID_Preferencia=" + id + ";")[0];
            ID_preferencia = (int)tupla[0];
            nombre_preferencia = (String)tupla[1];
            if ( tupla[2].ToString() != "") user = new Usuario((String)tupla[2]);
            if ( tupla[3].ToString() != "") grado = new Grado((int.Parse(tupla[3].ToString())));
            if ( tupla[4].ToString() != "") asig = new Asignatura(int.Parse(tupla[4].ToString()));
            if( tupla[5].ToString() != "") horasPosibles = int.Parse(tupla[5].ToString());
            if (tupla[6].ToString() != "") Enum.TryParse<Actividad.TurnoE>(tupla[6].ToString(), true, out turno);
            if (tupla[7].ToString() != "") Enum.TryParse<Actividad.TipoActividadE>(tupla[7].ToString(), true, out tipoAct);
            if (tupla[8].ToString() != "") Enum.TryParse<Actividad.TipoTrabajoE>(tupla[7].ToString(), true, out tipoTrabajo);
            if (tupla[9].ToString() != "") Enum.TryParse<Actividad.AmbitoTrabajoE>(tupla[7].ToString(), true, out ambitoTrabajo);
            competencias = null;
        }

        public Preferencia(String nombre_preferencia, Usuario user, bool t)
        {
            SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
            String sel = "Select ID_Preferencia FROM Preferencias WHERE nombre_preferencia = '" + nombre_preferencia + "' and emailUser ='" + user.Email + "';";
            Object[] tupla = miBD.Select(sel)[0];
            ID_preferencia = int.Parse(tupla[0].ToString());
            this.nombre_preferencia = nombre_preferencia;
            this.user = user;
            competencias = null;
        }

        public Preferencia(String nombre_preferencia, Usuario user)
        {
            SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
            String ins = "INSERT INTO Preferencias (nombre_preferencia,emailUser) VALUES ('"+ nombre_preferencia +"','"+user.Email+"');";
            miBD.Insert(ins);
            ID_preferencia= int.Parse(miBD.SelectScalar("SELECT max(ID_Preferencia) FROM Preferencias;").ToString());
            this.nombre_preferencia = nombre_preferencia;
            this.user = user;
            competencias = null;
        }

        public int ID_Preferencia
        {
            get { return ID_preferencia; }
            set
            {
                throw new Exception("ID_Preferencia no se puede cambiar, es autoindexado");
            }
        }

        public String Nombre_Preferencia
        {
            get { return nombre_preferencia; }
            set
            {
                SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
                miBD.Update("UPDATE Preferencias SET nombre_preferencia='" + value + "' "
                        + "WHERE ID_Preferencia=" + ID_preferencia + ";");
                nombre_preferencia = value;
            }
        }

        public Usuario User
        {
            get { return user; }
            set
            {
                SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
                miBD.Update("UPDATE Preferencias SET emailUser='" + value.Email + "' "
                        + "WHERE ID_Preferencia=" + ID_preferencia + ";");
                user = value;
            }
        }

        public Grado Grado
        {
            get { return grado; }
            set
            {
                SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
                miBD.Update("UPDATE Preferencias SET idGrado=" + value.ID_Grado + " "
                        + "WHERE ID_Preferencia=" + ID_preferencia + ";");
                grado = value;
            }
        }

        public Asignatura Asignatura
        {
            get { return asig; }
            set
            {
                SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
                miBD.Update("UPDATE Preferencias SET idAsignatura=" + value.ID_Asig + " "
                        + "WHERE ID_Preferencia=" + ID_preferencia + ";");
                asig = value;
            }
        }

        public int HorasPosibles
        {
            get { return horasPosibles; }
            set
            {
                SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
                miBD.Update("UPDATE Preferencias SET horasPosibles=" + value + " "
                        + "WHERE ID_Preferencia=" + ID_preferencia + ";");
                horasPosibles = value;
            }
        }

        public Actividad.TurnoE Turno
        {
            get { return turno; }
            set
            {
                SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
                miBD.Update("UPDATE Preferencias SET turno='" + value.ToString() + "' "
                        + "WHERE ID_Preferencia=" + ID_preferencia + ";");
                turno = value;
            }
        }

        public Actividad.TipoActividadE TipoActividad
        {
            get { return tipoAct; }
            set
            {
                SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
                miBD.Update("UPDATE Preferencias SET tipoAct='" + value.ToString() + "' "
                        + "WHERE ID_Preferencia=" + ID_preferencia + ";");
                tipoAct = value;
            }
        }

        public Actividad.TipoTrabajoE TipoTrabajo
        {
            get { return tipoTrabajo; }
            set
            {
                SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
                miBD.Update("UPDATE Preferencias SET tipoTrabajo='" + value.ToString() + "' "
                        + "WHERE ID_Preferencia=" + ID_preferencia + ";");
                tipoTrabajo = value;
            }
        }

        public Actividad.AmbitoTrabajoE AmbitoTrabajo
        {
            get { return ambitoTrabajo; }
            set
            {
                SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
                miBD.Update("UPDATE Preferencias SET ambitoTrabajo='" + value.ToString() + "' "
                        + "WHERE ID_Preferencia=" + ID_preferencia + ";");
                ambitoTrabajo = value;
            }
        }

        public List<Competencia> Competencias
        {
            get
            {
                if (competencias == null)
                {
                    competencias = Competencia.ListaCompetencias(this);
                }
                return competencias;
            }
        }

        public void AddCompetencia(Competencia c)
        {
            if (competencias == null) competencias = Competencia.ListaCompetencias(this);
            if (!competencias.Contains(c))
            {
                SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
                String ins = "INSERT INTO Rel_Preferencia_Competencia VALUES ("+this.ID_Preferencia+", "+c.ID_Competencia+");";
                miBD.Insert(ins);
                competencias.Add(c);
            }
        }

        public void RemoveCompetencia(Competencia c)
        {
            if (competencias == null) competencias = Competencia.ListaCompetencias(this);
            if (competencias.Contains(c))
            {
                SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
                String del = "DELETE FROM Rel_Preferencia_Competencia WHERE ID_Preferencia=" + this.ID_Preferencia + " AND idCompetencia=" + c.ID_Competencia + ";";
                miBD.Delete(del);
                competencias.Remove(c);
            }
        }

        public void RemovePreferencia()
        {
             SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
             String del = "DELETE FROM Preferencias WHERE ID_Preferencia=" + this.ID_Preferencia + ";";
             miBD.Delete(del);

            ID_preferencia = -1;
            nombre_preferencia = null;
            user = null;
            grado = null;
            asig = null;
            horasPosibles = -1;
            //turno = null;
            //tipoAct = null;
            //competencias= null
        }

        public override string ToString()
        {
            return "Preferencia ["+ID_Preferencia+"; "+user.Email+"; "+nombre_preferencia+"]";
        }

        public override bool Equals(object obj)
        {
            return obj is Preferencia && (((Preferencia)obj).ID_Preferencia.CompareTo(this.ID_Preferencia) == 0);
        }

        public override int GetHashCode()
        {
            return ID_Preferencia.GetHashCode();
        }


    }
}
