using System;
using System.Collections.Generic;
using BDLibrary;
using APS.BD;

namespace APS.Mapeo
{
    public class Actividad
    {
        private static string BD_SERVER = Properties.Settings.Default.BD_SERVER;
        private static string BD_NAME = Properties.Settings.Default.BD_NAME;

        public enum TipoActividadE { FORMACION, INVESTIGACION, VOLUTARIADO };
        public enum EstadoActividadE { PENDIENTES, EN_REVISION_PROFESOR, EN_REVISION_ONG, PREINICIO, FINALIZADO };
        public enum TurnoE { AM, PM }
        public enum TipoTrabajoE { }
        public enum AmbitoTrabajoE { }


        private int ID_actividad;
        private String nombreAct;
        private String descAct;
        private int numPlazas;
        private int numHoras;
        private TurnoE turno;
        private DateTime fechaInicio;
        private DateTime fechaFin;
        private String lugar;
        private Usuario organizador;
        private Usuario responsable;
        private Grado grado;
        private Asignatura asig;
        private TipoActividadE tipoAct;
        private Proyecto proyecto;
        private double notaMedia;
        private EstadoActividadE estadoAct;
        private String imagen;
        private TipoTrabajoE tipoTrabajo;
        private AmbitoTrabajoE ambitoTrabajo;
        private List<Competencia> competencias; //lazzy

        public static List<Actividad> ListaActividades()
        {
            // Retorna una lista con todos los obejtos de la clase almacenados en la base de datos
            SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
            List<Actividad> lista = new List<Actividad>();

            foreach (Object[] tupla in miBD.Select("SELECT ID_Actividad FROM Actividades;"))
            {
                int id = (int)tupla[0];
                Actividad a = new Actividad(id);
                lista.Add(a);
            }
            return lista;
        }

        public static List<Actividad> ListaActividades(Competencia c)
        {
            // Retorna una lista con todos los obejtos de la clase almacenados en la base de datos
            SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
            List<Actividad> lista = new List<Actividad>();

            foreach (Object[] tupla in miBD.Select("SELECT ID_Actividad FROM Rel_Actividad_Competencia " +
                                                    "WHERE idCompetencia="+c.ID_Competencia+";"))
            {
                int id = (int)tupla[0];
                Actividad a = new Actividad(id);
                lista.Add(a);
            }
            return lista;
        }

        public static List<Actividad> ListaActividades(TipoActividadE tipoAct)
        {
            // Retorna una lista con todos los obejtos de la clase almacenados en la base de datos
            SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
            List<Actividad> lista = new List<Actividad>();

            foreach (Object[] tupla in miBD.Select("SELECT ID_Actividad FROM Actividades WHERE tipoAct='" + tipoAct.ToString() + "';"))
            {
                int id = (int)tupla[0];
                Actividad a = new Actividad(id);
                lista.Add(a);
            }
            return lista;
        }

        public static List<Actividad> ListaActividades(EstadoActividadE estadoAct)
        {
            // Retorna una lista con todos los obejtos de la clase almacenados en la base de datos
            SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
            List<Actividad> lista = new List<Actividad>();

            foreach (Object[] tupla in miBD.Select("SELECT ID_Actividad FROM Actividades WHERE estadoAct='" + estadoAct.ToString() + ";"))
            {
                int id = (int)tupla[0];
                Actividad a = new Actividad(id);
                lista.Add(a);
            }
            return lista;
        }

        public Actividad(int id)
        {
            SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
            Object[] tupla = miBD.Select("SELECT * FROM Actividades "
                    + "WHERE ID_Actividad=" + id + ";")[0];
            ID_actividad = (int)tupla[0];
            nombreAct = (String)tupla[1];
            descAct = (String)tupla[2];
            numPlazas = (int)tupla[3];
            numHoras = (int)tupla[4];
            Enum.TryParse<TurnoE>((String)tupla[5],true,out turno);

            string[] fechaIn = tupla[6].ToString().Split('-');
            fechaInicio = new DateTime(int.Parse(fechaIn[0]), int.Parse(fechaIn[1]), int.Parse(fechaIn[2]));
            
            string[] fechaFinal = tupla[7].ToString().Split('-');
            fechaFin = new DateTime(int.Parse(fechaFinal[0]), int.Parse(fechaFinal[1]), int.Parse(fechaFinal[2]));
            
            lugar = (String)tupla[8];
            organizador = new Usuario((String)tupla[9]);
            if (!(tupla[10].Equals(null))) responsable = new Usuario((String)tupla[10]);
            if (!tupla[11].Equals(null)) grado = new Grado((int)tupla[11]);
            if (!(tupla[12].Equals(null))) asig = new Asignatura((int)tupla[12]);
            if (!(tupla[13].Equals(null))) Enum.TryParse<TipoActividadE>((String)tupla[13],true,out tipoAct);
            if (!(tupla[14].Equals(null))) proyecto = new Proyecto((int)tupla[14]);
            if (!(tupla[15].Equals(null))) notaMedia = Double.Parse((String)tupla[15]);
            Enum.TryParse<EstadoActividadE>((String)tupla[16],true,out estadoAct);
            imagen = null;
            if (!(tupla[17].Equals(null))) Enum.TryParse<TipoTrabajoE>((String)tupla[17], true,out tipoTrabajo);
            if (!(tupla[18].Equals(null))) Enum.TryParse<AmbitoTrabajoE>((String)tupla[18], true,out ambitoTrabajo);
            competencias = null;
        }

        public Actividad(String nombreAct, String descAct, int numPlazas, int numHoras, TurnoE turno,
                         DateTime fechaInicio, DateTime fechaFin, String lugar, Usuario organizador,
                         Usuario responsable, Grado grado, Asignatura asig, TipoActividadE tipoAct,
                         Proyecto proy, double notaMedia, EstadoActividadE estadoAct, String imagen, TipoTrabajoE tipoTrabajo, AmbitoTrabajoE ambitoTrabajo)
        {
            SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
            String ins = "INSERT INTO Actividades VALUES ('" + nombreAct + "','"
                        + descAct + "'," + numPlazas + "," + numHoras + ",'" + turno.ToString() + "','"
                        + fechaInicio.ToShortDateString() + "','" + fechaFin.ToShortDateString() + "','" + lugar + "','" + organizador.Email + "','"
                        + responsable.Email + "'," + grado.ID_Grado + "," + asig.ID_Asig + ",'"
                        + tipoAct.ToString() + "'," + proy.ID_Proyecto + "," + notaMedia + ",'" + estadoAct + "','"
                        + "101" + "','"+tipoTrabajo.ToString()+"','"+ambitoTrabajo.ToString()+"');";
            miBD.Insert(ins);
            this.ID_actividad = (int)miBD.SelectScalar("SELECT max(ID_Actividad) FROM Actividades;");
            this.nombreAct = nombreAct;
            this.descAct = descAct;
            this.numPlazas = numPlazas;
            this.numHoras = numHoras;
            this.turno = turno;
            this.fechaInicio = fechaInicio;
            this.fechaFin = fechaFin;
            this.lugar = lugar;
            this.organizador = organizador;
            this.responsable = responsable;
            this.grado = grado;
            this.asig = asig;
            this.tipoAct = tipoAct;
            this.proyecto = proy;
            this.notaMedia = notaMedia;
            this.estadoAct = estadoAct;
            //this.imagen = imagen;
            this.tipoTrabajo = tipoTrabajo;
            this.ambitoTrabajo = ambitoTrabajo;
            competencias = null;
        }

        public Actividad(String nombreAct, String descAct, int numPlazas, int numHoras, TurnoE turno,
                 DateTime fechaInicio, DateTime fechaFin, String lugar, Usuario organizador,
                EstadoActividadE estadoAct, AmbitoTrabajoE ambito, TipoTrabajoE trabajo)
        {
            SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
            String ins = "INSERT INTO Actividades (nombreAct,descripcionAct,numPlazas,numHoras, turno,"
                    + "fechaInicio, fechaFin,lugar,emailOrganizador,estadoAct,ambitoTrabajo,tipoTrabajo) "
                    + "VALUES ('" + nombreAct + "','"
                    + descAct + "'," + numPlazas + "," + numHoras + ",'" + turno.ToString() + "','"
                    + fechaInicio.ToShortDateString() + "','" + fechaFin.ToShortDateString() + "','" + lugar + "','" + organizador.Email + "','"
                    + estadoAct + "','" + ambitoTrabajo+"','"+tipoTrabajo+"');";
            miBD.Insert(ins);
            this.ID_actividad = (int)miBD.SelectScalar("SELECT max(ID_Actividad) FROM Actividades;");
            this.nombreAct = nombreAct;
            this.descAct = descAct;
            this.numPlazas = numPlazas;
            this.numHoras = numHoras;
            this.turno = turno;
            this.fechaInicio = fechaInicio;
            this.fechaFin = fechaFin;
            this.lugar = lugar;
            this.organizador = organizador;
            this.estadoAct = estadoAct;
            this.ambitoTrabajo = ambito;
            this.tipoTrabajo = trabajo;
            competencias = null;
        }

        public int ID_Actividad
        {
            get { return ID_actividad; }
            set
            {
                throw new BDException("Error: ID_Actividad no se puede cambiar, es autoindexado");
            }
        }

        public String NombreAct
        {
            get { return nombreAct; }
            set
            {
                SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
                String up = "UPDATE Actividades SET nombreAct='" + value + "' "
                        + "WHERE ID_Actividad=" + this.ID_actividad + ";";
                miBD.Update(up);
                this.nombreAct = value;
            }
        }

        public String DescAct
        {
            get { return descAct; }
            set
            {
                SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
                String up = "UPDATE Actividades SET descripcionAct='" + value + "' "
                        + "WHERE ID_Actividad=" + this.ID_actividad + ";";
                miBD.Update(up);
                this.descAct = value;
            }
        }

        public int NumPlazas
        {
            get { return numPlazas; }
            set
            {
                SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
                String up = "UPDATE Actividades SET numPlazas=" + value + " "
                        + "WHERE ID_Actividad=" + this.ID_actividad + ";";
                miBD.Update(up);
                this.numPlazas = value;
            }
        }

        public int NumHoras
        {
            get { return numHoras; }
            set
            {
                SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
                String up = "UPDATE Actividades SET numHoras=" + value + " "
                        + "WHERE ID_Actividad=" + this.ID_actividad + ";";
                miBD.Update(up);
                this.numHoras = value;
            }
        }

        public TurnoE Turno
        {
            get { return turno; }
            set
            {
                SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
                String up = "UPDATE Actividades SET turno='" + value.ToString() + "' "
                        + "WHERE ID_Actividad=" + this.ID_actividad + ";";
                miBD.Update(up);
                this.turno = value;
            }
        }

        public DateTime FechaInicio
        {
            get { return fechaInicio; }
            set
            {
                SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
                String up = "UPDATE Actividades SET fechaInicio='" + value.ToShortDateString() + "' "
                        + "WHERE ID_Actividad=" + this.ID_actividad + ";";
                miBD.Update(up);
                this.fechaInicio = value;
            }
        }

        public DateTime FechaFin
        {
            get { return fechaFin; }
            set
            {
                SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
                String up = "UPDATE Actividades SET fechaFin='" + value.ToShortDateString() + "' "
                        + "WHERE ID_Actividad=" + this.ID_actividad + ";";
                miBD.Update(up);
                this.fechaFin = value;
            }
        }

        public String Lugar
        {
            get { return lugar; }
            set
            {
                SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
                String up = "UPDATE Actividades SET lugar='" + value + "' "
                        + "WHERE ID_Actividad=" + this.ID_actividad + ";";
                miBD.Update(up);
                this.lugar = value;
            }
        }

        public Usuario Organizador
        {
            get { return organizador; }
            set
            {
                SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
                String up = "UPDATE Actividades SET emailOrganizador='" + value.Email + "' "
                        + "WHERE ID_Actividad=" + this.ID_actividad + ";";
                miBD.Update(up);
                this.organizador = value;
            }
        }

        public Usuario Responsable
        {
            get { return responsable; }
            set
            {
                SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
                String up = "UPDATE Actividades SET emailResponsable='" + value.Email + "' "
                        + "WHERE ID_Actividad=" + this.ID_actividad + ";";
                miBD.Update(up);
                this.responsable = value;
            }
        }

        public Grado Grado
        {
            get { return grado; }
            set
            {
                SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
                String up = "UPDATE Actividades SET idGrado=" + value.ID_Grado + " "
                        + "WHERE ID_Actividad=" + this.ID_actividad + ";";
                miBD.Update(up);
                this.grado = value;
            }
        }

        public Asignatura Asignatura
        {
            get { return asig; }
            set
            {
                SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
                String up = "UPDATE Actividades SET idAsig='" + value.ID_Asig + "' "
                        + "WHERE ID_Actividad=" + this.ID_actividad + ";";
                miBD.Update(up);
                this.asig = value;
            }
        }

        public TipoActividadE TipoAct
        {
            get { return tipoAct; }
            set
            {
                SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
                String up = "UPDATE Actividades SET tipoAct='" + value.ToString() + "' "
                        + "WHERE ID_Actividad=" + this.ID_actividad + ";";
                miBD.Update(up);
                this.tipoAct = value;
            }
        }

        public Proyecto Proyecto
        {
            get { return proyecto; }
            set
            {
                SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
                String up = "UPDATE Actividades SET idProy='" + value.ID_Proyecto + "' "
                        + "WHERE ID_Actividad=" + this.ID_actividad + ";";
                miBD.Update(up);
                this.proyecto = value;
            }
        }

        public double NotaMedia
        {
            get { return notaMedia; }
            set
            {
                SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
                String up = "UPDATE Actividades SET notaMedia=" + value + " "
                        + "WHERE ID_Actividad=" + this.ID_actividad + ";";
                miBD.Update(up);
                this.notaMedia = value;
            }
        }

        public EstadoActividadE EstadoAct
        {
            get { return estadoAct; }
            set
            {
                SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
                String up = "UPDATE Actividades SET estadoAct='" + value.ToString() + "' "
                        + "WHERE ID_Actividad=" + this.ID_actividad + ";";
                miBD.Update(up);
                this.estadoAct = value;
            }
        }

        /*public File Imagen
        {
            get { return imagen; }
            set
            {

            }
        }*/

        public TipoTrabajoE TipoTrabajo
        {
            get { return tipoTrabajo; }
            set
            {
                SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
                String up = "UPDATE Actividades SET tipoTrabajo='" + value.ToString() + "' "
                        + "WHERE ID_Actividad=" + this.ID_actividad + ";";
                miBD.Update(up);
                this.tipoTrabajo = value;
            }
        }

        public AmbitoTrabajoE AmbitoTrabajo
        {
            get { return ambitoTrabajo; }
            set
            {
                SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
                String up = "UPDATE Actividades SET ambitoTrabajo='" + value.ToString() + "' "
                        + "WHERE ID_Actividad=" + this.ID_actividad + ";";
                miBD.Update(up);
                this.ambitoTrabajo = value;
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
                String ins = "INSERT INTO Rel_Actividad_Competencia VALUES (" + this.ID_Actividad + "," + c.ID_Competencia + ");";
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
                String del = "DELETE FROM Rel_Actividad_Competencia WHERE ID_Actividad="+this.ID_Actividad+" AND idCompetencia="+c.ID_Competencia+";";
                miBD.Delete(del);
                competencias.Remove(c);
            }
        }

        public void BorrarActividad()
        {
            SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
            String del = "DELETE FROM Actividades WHERE ID_Actividad='" + this.ID_Actividad + "';";
            miBD.Delete(del);
            ID_Actividad = -1;
            nombreAct = null;
            descAct = null;
            numPlazas = -1;
            numHoras = -1;
            //turno = null;
            fechaInicio = DateTime.Today;
            fechaFin = DateTime.Today;
            lugar = null;
            organizador = null;
            responsable = null;
            grado = null;
            asig = null;
            //tipoAct = null;
            proyecto = null;
            notaMedia = -1;
            //estadoAct = null;
            imagen = null;
            //tipoTrabajo = null;
            //ambitoTrabajo = null;
        }

        public override string ToString()
        {
            return "Actividad [ID_Actividad=" + ID_Actividad + ", nombreAct=" + nombreAct + ", descAct=" + descAct
        + ", numPlazas=" + numPlazas + ", numHoras=" + numHoras + ", turno=" + turno + ", fechaInicio="
        + fechaInicio.ToShortDateString() + ", fechaFin=" + fechaFin.ToShortDateString() + ", lugar=" + lugar + ", organizador=" + organizador
        + ", responsable=" + responsable + ", grado=" + grado + ", asig=" + asig + ", tipoAct=" + tipoAct
        + ", proyecto=" + proyecto + ", notaMedia=" + notaMedia + ", estadoAct=" + estadoAct + ", imagen="
        + imagen + ", tipoTrabajo="+ tipoTrabajo+", ambitoTrabajo= "+ ambitoTrabajo+ "]";
        }

        public override bool Equals(object obj)
        {
            return obj is Actividad && (((Actividad)obj).ID_Actividad.CompareTo(this.ID_Actividad) == 0);
        }

        public override int GetHashCode()
        {
            return ID_Actividad.GetHashCode();
        }

    }
}
