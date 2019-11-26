using System;
using System.Collections.Generic;
using BDLibrary;
using APS.BD;


namespace APS.Mapeo
{
    public class Permiso
    {
        private static string BD_SERVER = Properties.Settings.Default.BD_SERVER;
        private static string BD_NAME = Properties.Settings.Default.BD_NAME;

        private String nombreRol;
        private String pantalla;
        private Boolean acceso;
        private Boolean insertar;
        private Boolean modificar;
        private Boolean borrar;
        private Boolean aceptar;
        private Boolean rechazar;


        public static List<Permiso> ListaPermisosRol(String rolName)
        {

            List<Permiso> lista = new List<Permiso>();
            // Retorna una lista con todos los obejtos de la clase almacenados en la base de datos
            SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);

            foreach (Object[] tupla in miBD.Select("SELECT pantalla FROM Permisos WHERE nombreRol = '" + rolName + "';"))
            {
                String pantalla = (String)tupla[0];
                lista.Add(new Permiso(rolName, pantalla));
            }
            return lista;
        }

        public Permiso(String r, String p)
        {
            // Crea el objeto cargando sus valores de la base de datos
            SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);

            Object[] tupla = miBD.Select("SELECT * FROM Permisos WHERE "
                    + "nombreRol = '" + r + "' AND "
                    + "pantalla= '" + p + "';")[0];


            nombreRol = (String)tupla[0];
            pantalla = (String)tupla[1];
            acceso = (Boolean)tupla[2];
            insertar = (Boolean)tupla[3];
            modificar = (Boolean)tupla[4];
            borrar = (Boolean)tupla[5];
            aceptar = (Boolean)tupla[6];
            rechazar = (Boolean)tupla[7];

        }

        public Permiso(String r, String p, Boolean acc, Boolean ins, Boolean mod, Boolean b, Boolean acept, Boolean rech)
        {
            // Crea el objeto y lo inserta en la base de datos
            SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);

            miBD.Insert("INSERT INTO Permisos VALUES('" + r + "','" + p + "'," + (acc ? 1 : 0) + ","
                    + (ins ? 1 : 0) + "," + (mod ? 1 : 0) + "," + (b ? 1 : 0) + ","
                        + (acept ? 1 : 0) + "," + (rech ? 1 : 0) + ");");
            nombreRol = r;
            pantalla = p;
            acceso = acc;
            insertar = ins;
            modificar = mod;
            borrar = b;
            aceptar = acept;
            rechazar = rech;
        }

        public String NombreRol
        {
            get { return nombreRol; }
            set
            {
                SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
                miBD.Update("UPDATE Permisos SET nombreRol = '" + value + "' WHERE "
                        + "nombreRol = '" + nombreRol + "' AND "
                        + "pantalla= '" + pantalla + "';");

                nombreRol = value;
            }
        }

        public String Pantalla
        {
            get { return pantalla; }
            set
            {
                SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
                miBD.Update("UPDATE Permisos SET pantalla = '" + value + "' WHERE "
                        + "nombreRol = '" + nombreRol + "' AND "
                        + "pantalla= '" + pantalla + "';");

                pantalla = value;
            }
        }

        public Boolean Acceso
        {
            get { return acceso; }
            set
            {
                SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
                miBD.Update("UPDATE Permisos SET acceso = " + (value ? 1 : 0) + " WHERE "
                        + "nombreRol = '" + nombreRol + "' AND "
                        + "pantalla= '" + pantalla + "';");

                acceso = value;
            }
        }

        public Boolean Insertar
        {
            get { return insertar; }
            set
            {
                SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
                miBD.Update("UPDATE Permisos SET insertar = " + (value ? 1 : 0) + " WHERE "
                        + "nombreRol = '" + nombreRol + "' AND "
                        + "pantalla= '" + pantalla + "';");

                insertar = value;
            }
        }

        public Boolean Modificar
        {
            get { return modificar; }
            set
            {
                // Actualiza el atributo en memoria y en la base de datos
                SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
                miBD.Update("UPDATE Permisos SET modificar = " + (value ? 1 : 0) + " WHERE "
                        + "nombreRol = '" + nombreRol + "' AND "
                        + "pantalla= '" + pantalla + "';");

                modificar = value;
            }
        }
        
        public Boolean Borrar
        {
            get { return borrar; }
            set
            {
                // Actualiza el atributo en memoria y en la base de datos
                SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
                miBD.Update("UPDATE Permisos SET borrar = " + (value ? 1 : 0) + " WHERE "
                        + "nombreRol = '" + nombreRol + "' AND "
                        + "pantalla= '" + pantalla + "';");

                borrar = value;
            }
        }

        public Boolean Aceptar
        {
            get { return aceptar; }
            set
            {
                // Actualiza el atributo en memoria y en la base de datos
                SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
                miBD.Update("UPDATE Permisos SET aceptar = " + (value ? 1 : 0) + " WHERE "
                        + "nombreRol = '" + nombreRol + "' AND "
                        + "pantalla= '" + pantalla + "';");

                aceptar = value;
            }
        }

        public Boolean Rechazar
        {
            get { return rechazar; }
            set
            {
                // Actualiza el atributo en memoria y en la base de datos
                SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
                miBD.Update("UPDATE Permisos SET rechazar = " + (value ? 1 : 0) + " WHERE "
                        + "nombreRol = '" + nombreRol + "' AND "
                        + "pantalla= '" + pantalla + "';");

                borrar = value;
            }
        }

        public override string ToString()
        {
            return nombreRol+";"+Pantalla;
        }

        public override bool Equals(object obj)
        {
            return obj is Permiso && (((Permiso)obj).NombreRol.ToUpper().CompareTo(this.NombreRol.ToUpper()) == 0)
                && (((Permiso)obj).Pantalla.ToUpper().CompareTo(this.Pantalla.ToUpper())==0);
        }

        public override int GetHashCode()
        {
            return NombreRol.GetHashCode() + Pantalla.GetHashCode();
        }




    }
}