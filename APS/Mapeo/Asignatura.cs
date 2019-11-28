using System;
using System.Collections.Generic;
using BDLibrary;
using APS.BD;


namespace APS.Mapeo
{
    public class Asignatura
    {
        private static string BD_SERVER = Properties.Settings.Default.BD_SERVER;
        private static string BD_NAME = Properties.Settings.Default.BD_NAME;

        private int ID_asig;
        private String nombreAsig;
        private Grado grado;


        public static List<Asignatura> ListaAsignaturas()
        {
            SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
		    List<Asignatura> lista = new List<Asignatura>();

            foreach (object[] tupla in miBD.Select("SELECT ID_Asignatura FROM Asignaturas;"))
		    {
			int id = (int) tupla[0];
			Asignatura a = new Asignatura(id);
			lista.Add(a);
		    }
		    return lista;
        }

        public static List<Asignatura> ListaAsignaturas(Usuario user)
        {
            SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
            List<Asignatura> lista = new List<Asignatura>();

            foreach (object[] tupla in miBD.Select("SELECT idAsig FROM Rel_User_Asig WHERE emailUser='"+user.Email+"';"))
            {
                int id = (int)tupla[0];
                Asignatura a = new Asignatura(id);
                lista.Add(a);
            }
            return lista;

        }

        public static List<Asignatura> ListaAsignaturas(Grado g)
        {
            SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
            List<Asignatura> lista = new List<Asignatura>();

            foreach (object[] tupla in miBD.Select("SELECT idAsig FROM Asignaturas WHERE idGrado=" + g.ID_Grado + ";"))
            {
                int id = (int)tupla[0];
                Asignatura a = new Asignatura(id);
                lista.Add(a);
            }
            return lista;

        }

        public Asignatura(int id)
        {
            // Crea el objeto cargando sus valores de la base de datos
            SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);

            Object[] tupla = miBD.Select("SELECT * FROM Asignaturas "
                    + "WHERE ID_Asignatura=" + id + ";")[0];
            ID_asig = (int) tupla[0];
		    nombreAsig = (String) tupla[1];
		    grado = new Grado((int) tupla[2]);
        }

        public Asignatura(Grado g, String nameAsig)
        {
            // Crea el objeto cargando sus valores de la base de datos
            SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);

            List<Object[]> lista = miBD.Select("SELECT * FROM Asignaturas "
                    + "WHERE nombreAsig='" + nameAsig+ "' and idGrado="+g.ID_Grado+";");
            ID_Asig = -1;
            if (lista.Count == 1)
            {
                Object[] tupla = lista[0];
                ID_asig = (int)tupla[0];
                nombreAsig = (String)tupla[1];
                grado = new Grado((int)tupla[2]);
            }
        }

        public Asignatura(String nA, Grado g, Boolean self)
        {
            // Crea el objeto y lo selecciona de la base de datos
            SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
            Object[] tupla = miBD.Select("Select ID_Asignatura FROM Asignaturas WHERE nombreAsig ='" + nA + "' and idGrado =" + g.ID_Grado + ");")[0];
            ID_asig = (int)tupla[0];
            nombreAsig = nA;
            grado = g;
        }

        public Asignatura(String nA, Grado g)
        {
            // Crea el objeto y lo inserta en la base de datos
            SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
            miBD.Insert("INSERT INTO Asignaturas VALUES ('" + nA + "'," + g.ID_Grado + ");");
            ID_asig = (int)miBD.SelectScalar("SELECT max(ID_Asignatura) FROM Asignaturas;");
            nombreAsig = nA;
            grado = g;
        }

        public int ID_Asig
        {
            get { return ID_asig; }
            set {
                throw new BDException("Error: no se puede modificar el ID_Asignatura, es autoindexado");
            }
        }

        public String NombreAsig
        {
            get { return nombreAsig; }
            set
            {
                SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
                miBD.Update("UPDATE Asignaturas SET nombreAsig = '" + value
                + "' WHERE ID_Asignaturas ='" + ID_asig + "';");
                nombreAsig = value;
            }
        }

        public Grado Grado
        {
            get { return grado; }
            set
            {
                 SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
                 miBD.Update("UPDATE Asignaturas SET idGrado = '" + value.ID_Grado
                 + "' WHERE ID_Asignaturas ='" + ID_asig + "';");
                 grado = value;
            }
        }

        public override string ToString()
        {
            return "Asignatura [ID_asig=" + ID_asig + ", nombreAsig=" + nombreAsig + ", grado=" + grado + "]";
        }

        public override bool Equals(object obj)
        {
            return obj is Asignatura && (((Asignatura)obj).ID_Asig.CompareTo(this.ID_Asig) == 0);
        }

        public override int GetHashCode()
        {
            return ID_Asig.GetHashCode();
        }




    }
}