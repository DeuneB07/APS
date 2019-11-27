using System;
using System.Collections.Generic;
using BDLibrary;
using APS.BD;

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
        private Actividad.TurnoE turno;
        private Actividad.TipoActividadE tipoAct;

        private List<Competencia> competencias;   //lazzy

        public static List<Preferencia> ListaPreferencias(Competencia c)
        {
            // Retorna una lista con todos los obejtos de la clase almacenados en la base de datos
            SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
            List<Preferencia> lista = new List<Preferencia>();

            foreach (Object[] tupla in miBD.Select("SELECT ID_Preferencia FROM Rel_Preferencia_Competencia WHERE idCompetencia=" + c.ID_Competencia + ";"))
            {
                int id = (int)tupla[0];
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

            foreach (Object[] tupla in miBD.Select("SELECT ID_Preferencia FROM Preferencias WHERE emailUsuario='"+user.Email+"';"))
            {
                int id = (int)tupla[0];
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
            if (tupla[2] != null)
            {
                user = new Usuario((String)tupla[2]);
            }
            if (tupla[3] != null)
            {
                grado = new Grado((int)tupla[3]);
            }
            if (tupla[4] != null)
            {
                asig = new Asignatura((int)tupla[4]);
            }
            if(tupla[5] != null)
            {
                horasPosibles = (int)tupla[5];
            }
            if (tupla[6] != null)
            {
                Enum.TryParse<Actividad.TurnoE>((String)tupla[6], true, out turno);
            }
            if (tupla[7] != null)
            {
                Enum.TryParse<Actividad.TipoActividadE>((String)tupla[7], true, out tipoAct);
            }
            competencias = null;
        }

        public Preferencia(String nombre_preferencia, Usuario user, bool t)
        {
            SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
            String sel = "Select ID_Preferencia FROM Preferencias WHERE nombre_preferencia = '" + nombre_preferencia + "' and emailUser ='" + user.Email + "';";
            Object[] tupla = miBD.Select(sel)[0];
            ID_preferencia = (int)tupla[0];
            this.nombre_preferencia = nombre_preferencia;
            this.user = user;
            competencias = null;
        }

        public Preferencia(String nombre_preferencia, Usuario user)
        {
            SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
            String ins = "INSERT INTO Preferencias (nombre_preferencia,emailUser) VALUES ('"+ nombre_preferencia +"','"+user.Email+"');";
            miBD.Insert(ins);
            ID_preferencia= (int)miBD.SelectScalar("SELECT max(ID_Preferencia) FROM Preferencias;");
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
             String del = "DELETE FROM PREFERENCIAS WHERE ID_Preferencia=" + this.ID_Preferencia + ";";
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
