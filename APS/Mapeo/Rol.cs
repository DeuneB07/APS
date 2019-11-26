using System;
using System.Collections.Generic;
using BDLibrary;
using APS.BD;

namespace APS.Mapeo
{
    public class Rol
    {
        private static string BD_SERVER = Properties.Settings.Default.BD_SERVER;
        private static string BD_NAME = Properties.Settings.Default.BD_NAME;

        private String nombreRol;
        private Boolean admin;
        private String descRol;

        private List<Permiso> permisos; //Lazzy

        public static List<Rol> ListaRoles()
        {
            // Retorna una lista con todos los obejtos de la clase almacenados en la base de datos		
            List<Rol> lista = new List<Rol>();
            SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);

            foreach (Object[] tupla in miBD.Select("SELECT nombreRol FROM Roles;"))
            {
                Rol r = new Rol((String)tupla[0]);
                lista.Add(r);
            }
            return lista;
        }

        public Rol(String name)
        {
            // Crea el objeto cargando sus valores de la base de datos
            SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
            Object[] tupla = miBD.Select("SELECT * FROM Roles WHERE nombreRol = '"
                    + name + "';")[0];

            nombreRol = (String)tupla[0];
            admin = (Boolean)tupla[1];
            if(tupla[2].ToString()!="") descRol = (String)tupla[2];
            permisos = null;
        }

        public Rol(String name, Boolean adm, String des)
        {
            // Crea el objeto y lo inserta en la base de datos
            SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
            miBD.Insert("INSERT INTO Roles VALUES('" + name +
                    "'," + (adm ? 1 : 0) + ",'" + des + "');");
            nombreRol = name;
            admin = adm;
            descRol = des;
            permisos = null;
        }

        public String NombreRol
        {
            get { return nombreRol; }
            set
            {
               // Actualiza el atributo en memoria y en la base de datos
                SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
                miBD.Update("UPDATE Roles SET nombreRol = '" + value
                        + "' WHERE nombreRol = '" + this.nombreRol + "';");
                this.nombreRol = value;
            }
        }

        public String DescRol
        {
            get { return descRol; }
            set
            {
                // Actualiza el atributo en memoria y en la base de datos
                SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
                miBD.Update("UPDATE Roles SET descRol = '" + value
                        + "' WHERE nombreRol = '" + this.nombreRol + "';");
                this.nombreRol = value;
            }
        }

        public Boolean Admin
        {
            get { return admin;}
            set
            {
                throw new BDException("Un Rol no puede concederse permisos de administración a sí mismo.");
            }
        }

        public void SetAdmin(Rol other, Boolean value)
        {
            if (!admin) throw new Exception("Rol sin permiso para establecer administradores.");

            // Actualiza el atributo admin de other en memoria y en la base de datos
            SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
            miBD.Update("UPDATE Roles SET admin = " + (value ? 1 : 0)
                    + " WHERE nombreRol = '" + other.nombreRol + "';");
            other.admin = value;
        }

        public List<Permiso> Permisos
        {
            get {
                if (permisos == null) permisos = Permiso.ListaPermisosRol(this.nombreRol);
                return permisos;
            }
        }

        public void AddPermiso(Permiso p)
        {
            if (!this.Permisos.Contains(p))
            {
                permisos.Add(p);
            }
        }

        public Boolean Acceso(String pantalla)
        {
            foreach (Permiso p in this.Permisos)
            {
                if (p.Pantalla.ToUpper().CompareTo(pantalla.ToUpper()) == 0)
                    return p.Acceso;
            }
            return false;
        }

        public Boolean Insertar(String pantalla)
        {
            foreach (Permiso p in this.Permisos)
            {
                if (p.Pantalla.ToUpper().CompareTo(pantalla.ToUpper()) == 0)
                    return p.Insertar;
            }
            return false;
        }

        public Boolean Modificar(String pantalla)
        {
            foreach (Permiso p in this.Permisos)
            {
                if (p.Pantalla.ToUpper().CompareTo(pantalla.ToUpper()) == 0)
                    return p.Modificar;
            }
            return false;
        }

        public Boolean Borrar(String pantalla)
        {
            foreach (Permiso p in this.Permisos)
            {
                if (p.Pantalla.ToUpper().CompareTo(pantalla.ToUpper()) == 0)
                    return p.Borrar;
            }
            return false;
        }

        public Boolean Aceptar(String pantalla)
        {
            foreach (Permiso p in this.Permisos)
            {
                if (p.Pantalla.ToUpper().CompareTo(pantalla.ToUpper()) == 0)
                    return p.Aceptar;
            }
            return false;
        }

        public Boolean Rechazar(String pantalla)
        {
            foreach (Permiso p in this.Permisos)
            {
                if (p.Pantalla.ToUpper().CompareTo(pantalla.ToUpper()) == 0)
                    return p.Rechazar;
            }
            return false;
        }

        public override string ToString()
        {
            return nombreRol;
        }

        public override bool Equals(object obj)
        {
            return obj is Rol && (((Rol)obj).NombreRol.ToUpper().CompareTo(this.NombreRol.ToUpper()) == 0);
        }

        public override int GetHashCode()
        {
            return NombreRol.GetHashCode();
        }

    }
}