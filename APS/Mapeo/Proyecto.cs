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
            if(tupla[1]!=null) Enum.TryParse<TipoProyectoE>((String)tupla[1],true, out tipoProy);
            Enum.TryParse<EstadoProyectoE>((String)tupla[2], true, out estadoProy);
            responsable = new Usuario((String)tupla[3]);
            nombreProy = (String)tupla[4];
            if(tupla[5]!=null) descProy = (String)tupla[5];
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
