﻿using System;
using System.Collections.Generic;
using BDLibrary;
using APS.BD;

namespace APS.Mapeo
{
    public class Grado
    {
        private static string BD_SERVER = Properties.Settings.Default.BD_SERVER;
        private static string BD_NAME = Properties.Settings.Default.BD_NAME;

        private int ID_grado;
        private String nombreGrado;

        public static List<Grado> ListaGrados()
        {
            // Retorna una lista con todos los obejtos de la clase almacenados en la base de datos
            SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
            List<Grado> lista = new List<Grado>();

            foreach (Object[] tupla in miBD.Select("SELECT ID_Grado FROM Grados;"))
            {
                int id = (int)tupla[0];
                Grado g = new Grado(id);
                lista.Add(g);
            }
            return lista;
        }

        public static List<Grado> ListaGrados(Usuario user)
        {
            SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
            List<Grado> lista = new List<Grado>();

            foreach (Object[] tupla in miBD.Select("Select ID_Grado from Grados JOIN (Asignaturas JOIN Rel_User_Asig ON idAsig=ID_Asignatura) ON ID_Grado=idGrado WHERE emailUser = '" + user.Email + "';"))
            {
                int id = (int)tupla[0];
                Grado g = new Grado(id);
                if(!lista.Contains(g)) lista.Add(g);
            }
            return lista;
        }

        public static int ListaAsignaturas(Grado g)
        {
            SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
            int num = 0;

            foreach (Object[] tupla in miBD.Select("Select count(ID_Asignatura) from Asignaturas WHERE idGrado = "+g.ID_Grado+"GROUP BY idGrado; "))
            {
                if (!tupla[0].ToString().Equals("")) num = (int)tupla[0];
            }
            return num;
        }

        public static int AlumnosPorGrado(Grado g)
        {
            SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
            int num = 0;

            foreach (Object[] tupla in miBD.Select("Select count(emailUser) from Grados g JOIN Rel_User_Grado r ON r.ID_Grado = g.ID_Grado WHERE r.ID_Grado = "+ g.ID_grado +" GROUP BY r.ID_Grado; "))
            {
                if(!tupla[0].ToString().Equals("")) num = (int)tupla[0];
            }
            return num;
        }

        public Grado(int id)
        {
            // Crea el objeto cargando sus valores de la base de datos
            SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);

            Object[] tupla = miBD.Select("SELECT * FROM Grados "
                        + "WHERE ID_Grado=" + id + ";")[0];

            ID_grado = (int)tupla[0];
            nombreGrado = (String)tupla[1];
        }

        public Grado(String nombreGrado, Boolean b)
        {
            SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
            String sel = "SELECT ID_Grado FROM Grados where nombreGrado='" + nombreGrado + "');";
            Object[] tupla = miBD.Select(sel)[0];
            ID_grado = (int)tupla[0];
            this.nombreGrado = nombreGrado;
        }

        public Grado(String nombreGrado)
        {
            SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
            String ins = "INSERT INTO Grados VALUES ('" + nombreGrado + "')";
            miBD.Insert(ins);
            ID_grado = (int)miBD.SelectScalar("SELECT max(ID_Grado) FROM Grados;");
            this.nombreGrado = nombreGrado;
        }

        public int ID_Grado
        {
            get { return ID_grado; }
            set
            {
                throw new BDException("Error: campo ID_Grado no se puede cambiar, es autoindexado");
            }
        }

        public String NombreGrado
        {
            get {return nombreGrado; }
            set
            {
                SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
                miBD.Update("UPDATE Grados SET nombreGrado='" + value + "' "
                        + "WHERE ID_Grado=" + ID_grado + ";");
                nombreGrado = value;
            }
        }

        /*
        public void BorrarGrado()
        {
            // Actualiza el atributo en memoria y en la base de datos
            SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
            miBD.Delete("DELETE FROM Grados WHERE ID_Grado =" + this.ID_Grado + ";");

            //foreach (Asignatura a in Asignatura.ListaAsignaturas(this)) a.BorrarAsignatura();
            this.ID_Grado = -1;
            this.NombreGrado = "";

        }
        */

        public override string ToString()
        {
            return "Grado [ID_grado=" + ID_grado + ", nombreGrado=" + nombreGrado + "]";
        }

        public override bool Equals(object obj)
        {
            return obj is Grado && (((Grado)obj).ID_Grado.CompareTo(this.ID_Grado) == 0);
        }

        public override int GetHashCode()
        {
            return ID_Grado.GetHashCode();
        }
    }
}
