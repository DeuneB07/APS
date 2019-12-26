using System;
using System.Collections.Generic;
using BDLibrary;
using APS.BD;

namespace APS.Mapeo
{
    public class Competencia
    {
        private static string BD_SERVER = Properties.Settings.Default.BD_SERVER;
        private static string BD_NAME = Properties.Settings.Default.BD_NAME;

        private int idCompetencia;
        private String nombreComp;
        private String descComp;
        private List<Preferencia> preferencias; //lazzy
        private List<Actividad> actividades;    //lazzy

        public static List<Competencia> ListaCompetencias()
        {
            List<Competencia> lista = new List<Competencia>();
            // Retorna una lista con todos los obejtos de la clase almacenados en la base de datos
            SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);

            foreach (Object[] tupla in miBD.Select("SELECT idCompetencia FROM Competencias;"))
            {
                int id = (int)tupla[0];
                lista.Add(new Competencia(id));
            }
            return lista;
        }

        public static List<Competencia> ListaCompetencias(Actividad a)
        {
            List<Competencia> lista = new List<Competencia>();
            // Retorna una lista con todos los obejtos de la clase almacenados en la base de datos
            SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);

            foreach (Object[] tupla in miBD.Select("SELECT idCompetencia FROM Rel_Actividad_Competencia "
                                        + "WHERE ID_Actividad = " + a.ID_Actividad + ";"))
            {
                int id = (int)tupla[0];
                lista.Add(new Competencia(id));
            }
            return lista;
        }

        public static List<Competencia> ListaCompetencias(Grado g)
        {
            List<Competencia> lista = new List<Competencia>();
            // Retorna una lista con todos los obejtos de la clase almacenados en la base de datos
            SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);

            foreach (Object[] tupla in miBD.Select("SELECT idCompetencia FROM Rel_Grado_Competencia "
                                        + "WHERE ID_Grado = " + g.ID_Grado + ";"))
            {
                int id = (int)tupla[0];
                lista.Add(new Competencia(id));
            }
            return lista;
        }

        public static List<Competencia> ListaCompetencias(Preferencia p)
        {
            List<Competencia> lista = new List<Competencia>();
            // Retorna una lista con todos los obejtos de la clase almacenados en la base de datos
            SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);

            foreach (Object[] tupla in miBD.Select("SELECT idCompetencia FROM Rel_Preferencia_Competencia "
                                        + "WHERE ID_Preferencia = " + p.ID_Preferencia + ";"))
            {
                int id = (int)tupla[0];
                lista.Add(new Competencia(id));
            }
            return lista;
        }

        public Competencia(int id)
        {
            SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
            Object[] tupla = miBD.Select("SELECT * FROM Competencias WHERE idCompetencia=" + id + ";")[0];
            this.idCompetencia = (int)tupla[0];
            this.nombreComp = (String)tupla[1];
            if (tupla[2]!=null) this.descComp = (String)tupla[2];
            preferencias = null;
            actividades = null;
        }

        public Competencia(String nombreComp, String descComp)
        {
            SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
            String ins;
            if (descComp == null)
            {
                ins = "INSERT INTO Competencias (nombreComp) VALUES ('" + nombreComp + "');";
            }
            else
            {
                ins = "INSERT INTO Competencias VALUES ('" + nombreComp + "','" + descComp + "');";
            }
            miBD.Insert(ins);
            this.idCompetencia = (int)miBD.SelectScalar("SELECT max(idCompetencia) FROM Competencias;");
            this.nombreComp = nombreComp;
            this.descComp = descComp;
            preferencias = null;
            actividades = null;
        }

        public int ID_Competencia
        {
            get { return idCompetencia; }
            set
            {
                throw new Exception("Error: No se puede cambiar ID_Competencia, es autoindexado.");
            }
        }

        public String NombreComp
        {
            get { return nombreComp; }
            set
            {
                SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
                String up = "UPDATE Competencias SET nombreComp='" + value + "' WHERE idCompetencia=" + this.idCompetencia + ";";
                miBD.Update(up);
                this.nombreComp = value;
            }
        }

        public String DescComp
        {
            get { return descComp; }
            set
            {
                SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
                String up = "UPDATE Competencias SET descripcionComp='" + value + "' WHERE idCompetencia=" + this.idCompetencia + ";";
                miBD.Update(up);
                this.descComp = value;
            }
        }

        public List<Actividad> Actividades
        {
            get
            {
                if (actividades == null)
                {
                    actividades = Actividad.ListaActividades(this);
                }
                return actividades;
            }
        }

        public List<Preferencia> Preferencias
        {
            get
            {
                if (preferencias == null)
                {
                    preferencias = Preferencia.ListaPreferencias(this);
                }
                return preferencias;
            }
        }

        public void BorraCompetencia()
        {
            // Actualiza el atributo en memoria y en la base de datos
            SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
            miBD.Delete("DELETE FROM Competencias WHERE idCompetencia =" + this.ID_Competencia + ";");

            foreach (Preferencia pref in this.Preferencias) pref.RemoveCompetencia(this);
            foreach (Actividad act in this.Actividades) act.RemoveCompetencia(this);
            this.idCompetencia = -1;
            this.DescComp = "";
            this.NombreComp = "";
            
        }

        public override string ToString()
        {
            return "Competencia [" + ID_Competencia + "; " + this.NombreComp + "; " + this.DescComp + "]";
        }

        public override bool Equals(object obj)
        {
            return obj is Competencia && (((Competencia)obj).ID_Competencia.CompareTo(this.ID_Competencia) == 0);
        }

        public override int GetHashCode()
        {
            return ID_Competencia.GetHashCode();
        }

    }
}
