using System;
using System.Collections.Generic;
using BDLibrary;
using APS.BD;

namespace APS.Mapeo
{
    public class Proyecto
    {
        public enum TipoProyectoE { FORMACION, INVESTIGACION };
        public enum EstadoProyectoE { PREINICIO, EN_CURSO, FINALIZADO };

        private static string BD_SERVER = Properties.Settings.Default.BD_SERVER;
        private static string BD_NAME = Properties.Settings.Default.BD_NAME;

        private int ID_proyecto;
        private TipoProyectoE tipoProy;
        private EstadoProyectoE estadoProy;
        private Usuario responsable;
        private String nombreProy;
        private String descProy;
        private List<Actividad> actividades;    //Lazy

        public Actividad PrimeraActividadProyecto()
        {
            SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
            String sel = "SELECT r.idAct " +
              "FROM Proyectos p INNER JOIN Rel_Proyecto_Actividades r ON r.idProy = p.ID_Proyecto " +
              "INNER JOIN Actividades a ON r.idAct = a.ID_Actividad " +
              "WHERE p.ID_Proyecto = " + this.ID_Proyecto + " " +
              "ORDER BY a.fechaInicio;";
            Object[] tupla = miBD.Select(sel)[0];
            Actividad primeraAct = new Actividad((int)tupla[0]);
            return primeraAct;
        }

        public Actividad UltimaActividadProyecto()
        {
            SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
            String sel = "SELECT r.idAct " +
                            "FROM Proyectos p INNER JOIN Rel_Proyecto_Actividades r ON r.idProy = p.ID_Proyecto " +
                            "INNER JOIN Actividades a ON r.idAct = a.ID_Actividad " +
                            "WHERE p.ID_Proyecto = " + this.ID_Proyecto + " " +
                            "ORDER BY a.fechaFin DESC;";
            Object[] tupla = miBD.Select(sel)[0];
            Actividad ultimaAct = new Actividad((int)tupla[0]);
            return ultimaAct;
        }

        public static void ActualizarEstadoProyectos()
        {
            SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
            foreach(Proyecto p in ListaProyectos())
            {
                if (p.Actividades.Count > 0)
                {
                    String sel = "SELECT r.idAct " +
                                  "FROM Proyectos p INNER JOIN Rel_Proyecto_Actividades r ON r.idProy = p.ID_Proyecto " +
                                  "INNER JOIN Actividades a ON r.idAct = a.ID_Actividad " +
                                  "WHERE p.ID_Proyecto = " + p.ID_Proyecto + " " +
                                  "ORDER BY a.fechaInicio;";
                    Object[] tupla = miBD.Select(sel)[0];
                    Actividad primeraAct = new Actividad((int)tupla[0]);

                    //EN_CURSO
                    if (primeraAct.EstadoAct.ToString().Equals("EN_PROCESO") && !p.EstadoProy.ToString().Equals("EN_CURSO"))
                    {
                        miBD.Update("UPDATE Proyectos SET estadoProy='" + EstadoProyectoE.EN_CURSO.ToString() + "' " +
                                    "WHERE ID_Proyecto= " + p.ID_Proyecto + ";");
                    }

                    sel = "SELECT r.idAct " +
                  "FROM Proyectos p INNER JOIN Rel_Proyecto_Actividades r ON r.idProy = p.ID_Proyecto " +
                  "INNER JOIN Actividades a ON r.idAct = a.ID_Actividad " +
                  "WHERE p.ID_Proyecto = " + p.ID_Proyecto + " " +
                  "ORDER BY a.fechaFin DESC;";
                    tupla = miBD.Select(sel)[0];
                    Actividad ultimaAct = new Actividad((int)tupla[0]);

                    //FINALIZADO
                    if (ultimaAct.EstadoAct.ToString().Equals("CONCLUIDA") && !p.EstadoProy.ToString().Equals("FINALIZADO"))
                    {
                        miBD.Update("UPDATE Proyectos SET estadoProy='" + EstadoProyectoE.FINALIZADO.ToString() + "' " +
                                    "WHERE ID_Proyecto= " + p.ID_Proyecto + ";");
                    }
                }
            }
        }

        public static List<Proyecto> ListaProyectos()
        {
            // Retorna una lista con todos los obejtos de la clase almacenados en la base de datos
            SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
            List<Proyecto> lista = new List<Proyecto>();

            foreach (Object[] tupla in miBD.Select("SELECT ID_Proyecto FROM Proyectos;"))
            {
                int id = (int)tupla[0];
                Proyecto p = new Proyecto(id);
                lista.Add(p);
            }
            return lista;
        }

        public static List<Proyecto> ListaProyectos(TipoProyectoE tipoProy)
        {
            // Retorna una lista con todos los obejtos de la clase almacenados en la base de datos
            SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
            List<Proyecto> lista = new List<Proyecto>();

            foreach (Object[] tupla in miBD.Select("SELECT ID_Proyecto FROM Proyectos WHERE tipoProy='" + tipoProy.ToString() + "';"))
            {
                int id = (int)tupla[0];
                Proyecto p = new Proyecto(id);
                lista.Add(p);
            }
            return lista;
        }

        public static List<Proyecto> ListaProyectos(EstadoProyectoE estado)
        {
            // Retorna una lista con todos los obejtos de la clase almacenados en la base de datos
            SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
            List<Proyecto> lista = new List<Proyecto>();

            foreach (Object[] tupla in miBD.Select("SELECT ID_Proyecto FROM Proyectos WHERE estadoProy='" + estado.ToString() + "';"))
            {
                int id = (int)tupla[0];
                Proyecto p = new Proyecto(id);
                lista.Add(p);
            }
            return lista;
        }

        public Proyecto(int id)
        {
            SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
            Object[] tupla = miBD.Select("SELECT * FROM Proyectos "
                    + "WHERE ID_Proyecto=" + id + ";")[0];
            ID_proyecto = (int)tupla[0];
            if(!tupla[1].ToString().Equals("")) Enum.TryParse<TipoProyectoE>(tupla[1].ToString(),true, out tipoProy);
            Enum.TryParse<EstadoProyectoE>(tupla[2].ToString(), true, out estadoProy);
            responsable = new Usuario(tupla[3].ToString());
            nombreProy = tupla[4].ToString();
            if(!tupla[5].ToString().Equals("")) descProy = tupla[5].ToString();
            actividades = null;
        }

        public Proyecto(TipoProyectoE tipoProy, EstadoProyectoE estadoProy, Usuario resp, String nombreProy, String descProy)
        {
            SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
            String ins = "INSERT INTO Proyectos VALUES ('" + tipoProy.ToString() + "','" + estadoProy.ToString() + "','" + resp.Email
                        + "','" + nombreProy + "','" + descProy + "');";
            miBD.Insert(ins);

            ID_proyecto = (int)miBD.SelectScalar("SELECT max(ID_Proyecto) FROM Proyectos;");
            this.tipoProy = tipoProy;
            this.estadoProy = estadoProy;
            this.responsable = resp;
            this.nombreProy = nombreProy;
            this.descProy = descProy;
            actividades = new List<Actividad>();
        }

        public Proyecto(EstadoProyectoE estadoProy, Usuario resp, String nombreProy)
        {
            SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
            String ins = "INSERT INTO Proyectos (estadoProy,emailResponsable,nombreProy) "
                    + "VALUES ('" + tipoProy.ToString() + "','" + estadoProy.ToString() + "','" + resp.Email
                        + "','" + nombreProy + "','" + descProy + "');";
            miBD.Insert(ins);

            ID_proyecto = (int)miBD.SelectScalar("SELECT max(ID_Proyecto) FROM Proyectos;");
            this.estadoProy = estadoProy;
            this.responsable = resp;
            this.nombreProy = nombreProy;
            actividades = new List<Actividad>();
        }

        public int ID_Proyecto
        {
            get { return ID_proyecto; }
            set
            {
                throw new BDException("Error: ID_Proyecto no se cambia, es autoindexado");
            }
        }
        
        public TipoProyectoE TipoProy
        {
            get { return tipoProy; }
            set
            {
                SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
                String up = "UPDATE Proyectos SET tipoProy='" + value.ToString() + "' "
                            + "WHERE ID_Proyecto=" + ID_proyecto + ";";
                miBD.Update(up);
                this.tipoProy = value;
            }
        }
        
        public EstadoProyectoE EstadoProy
        {
            get { return estadoProy; }
            set
            {
                SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
                String up = "UPDATE Proyectos SET estadoProy='" + value.ToString() + "' "
                            + "WHERE ID_Proyecto=" + ID_proyecto + ";";
                miBD.Update(up);
                this.estadoProy = value;
            }
        }
        
        public Usuario Responsable
        {
            get { return responsable; }
            set
            {
                SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
                String up = "UPDATE Proyectos SET emailResponsable='" + value.Email + "' "
                            + "WHERE ID_Proyecto=" + ID_proyecto + ";";
                miBD.Update(up);
                this.responsable = value;
            }
        }

        public String NombreProyecto
        {
            get { return nombreProy; }
            set
            {
                SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
                String up = "UPDATE Proyectos SET nombreProy='" + value + "' "
                            + "WHERE ID_Proyecto=" + ID_proyecto + ";";
                miBD.Update(up);
                this.nombreProy = value;
            }
        }

        public String DescripcionProyecto
        {
            get { return descProy; }
            set
            {
                SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
                String up = "UPDATE Proyectos SET descProy='" + value + "' "
                            + "WHERE ID_Proyecto=" + ID_proyecto + ";";
                miBD.Update(up);
                this.descProy = value;
            }
        }

        public List<Actividad> Actividades
        {
            get
            {
                if (actividades == null)
                {
                    CargarActividades();
                }
                return actividades;
            }
        }

        private void CargarActividades()
        {
            SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
            String sel = "SELECT idAct FROM Rel_Proyecto_Actividades WHERE idProy=" + this.ID_Proyecto + ";";
            actividades = new List<Actividad>();
            foreach(Object[] tupla in miBD.Select(sel))
            {
                Actividad act = new Actividad((int)tupla[0]);
                actividades.Add(act);
            }
        }

        public void AddActividadToProyecto(Actividad act)
        {
            if (!Actividades.Contains(act))
            {
                SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
                String ins = "INSERT INTO Rel_Proyecto_Actividades VALUES (" + this.ID_Proyecto + "," + act.ID_Actividad + ");";
                miBD.Insert(ins);
                Actividades.Add(act);
            }
        }

        public void RemoveActividadFromProyecto(Actividad act)
        {
            if (Actividades.Contains(act))
            {
                SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
                String del = "DELETE FROM Rel_Proyecto_Actividades WHERE idProy="+this.ID_Proyecto+" AND idAct="+act.ID_Actividad+";";
                miBD.Delete(del);
                Actividades.Remove(act);
            }
        }

        public override String ToString()
        {
            return "Proyecto [ID_proyecto=" + ID_proyecto + ", tipoProy=" + tipoProy + ", estadoProy=" + estadoProy
                    + ", responsable=" + responsable + ", nombreProy=" + nombreProy + ", descProy=" + descProy + "]";
        }

        public override bool Equals(object obj)
        {
            return obj is Proyecto && (((Proyecto)obj).ID_Proyecto.CompareTo(this.ID_Proyecto) == 0);
        }

        public override int GetHashCode()
        {
            return ID_Proyecto.GetHashCode();
        }

    }
}
