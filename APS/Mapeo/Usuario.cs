﻿using System;
using System.Collections.Generic;
using BDLibrary;
using APS.BD;
using System.Drawing;
using static APS.Mapeo.Actividad_Solicitud;
using System.IO;

namespace APS.Mapeo
{
    public class Usuario
    {
        private static string BD_SERVER = Properties.Settings.Default.BD_SERVER;
        private static string BD_NAME = Properties.Settings.Default.BD_NAME;

        private String email;
        private String password;
        private String dni;
        private String nombreUser;
        private Rol rol;
        private DateTime fechaNac;
        private String nombre;
        private String apellido1;
        private String apellido2;
        private String situacion;
        private Boolean aceptado;
        private Image imagen;         //Lazy
        private List<Grado> grados;   //Lazy
        private List<Preferencia> preferencias; //Lazy
        private List<Asignatura> asignaturas; //Lazy
        private List<Mensaje> mensajesRecibidos;//Lazy
        private List<Mensaje> mensajesEnviados;//Lazy

        private List<Actividad_Realizada> actividadesRealizadas; //Lazzy
        private List<Actividad_Solicitud> actividadesSolicitadas;  //Lazzy

        public static List<Usuario> ListaUsuarios()
        {
            // Retorna una lista con todos los obejtos de la clase almacenados en la base de datos
            SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
            List<Usuario> lista = new List<Usuario>();

            foreach (object[] tupla in miBD.Select("SELECT email FROM Usuario WHERE solicitud = " + 1 + ";"))
            {
                String email = (String)tupla[0];
                Usuario u = new Usuario(email);
                lista.Add(u);
            }
            return lista;
        }

        public static List<Usuario> ListaSolicitudes()
        {
            // Retorna una lista con todos los obejtos de la clase almacenados en la base de datos
            SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
            List<Usuario> lista = new List<Usuario>();

            foreach (object[] tupla in miBD.Select("SELECT email FROM Usuario WHERE solicitud = " + 0 + ";"))
            {
                String email = (String)tupla[0];
                Usuario u = new Usuario(email);
                lista.Add(u);
            }
            return lista;
        }

        public static List<Usuario> ListaUsuarios(Rol r)
        {
            // Retorna una lista con todos los obejtos de la clase almacenados en la base de datos
            SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
            List<Usuario> lista = new List<Usuario>();

            foreach (object[] tupla in miBD.Select("SELECT email FROM Usuario WHERE nombreRol='" + r.NombreRol + "';"))
            {
                String email = (String)tupla[0];
                Usuario u = new Usuario(email);
                lista.Add(u);
            }
            return lista;
        }

        public static List<Usuario> ListaResponsables(Asignatura a)
        {
            // Retorna una lista con todos los obejtos de la clase almacenados en la base de datos
            SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
            List<Usuario> lista = new List<Usuario>();

            foreach (object[] tupla in miBD.Select("SELECT email FROM Usuario WHERE nombreRol='PDI';"))
            {
                String email = (String)tupla[0];
                Usuario u = new Usuario(email);
                if (u.Asignaturas.Contains(a))
                {
                    lista.Add(u);
                }
            }
            return lista;
        }

        public static List<Usuario> ListaResponsables()
        {
            // Retorna una lista con todos los obejtos de la clase almacenados en la base de datos
            SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
            List<Usuario> lista = new List<Usuario>();

            foreach (object[] tupla in miBD.Select("SELECT email FROM Usuario WHERE nombreRol='PDI';"))
            {
                String email = (String)tupla[0];
                Usuario u = new Usuario(email);
                lista.Add(u);
            }
            return lista;
        }

        public Usuario(String e)
        {
            SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
            List<Object[]> lista = miBD.Select("SELECT * FROM Usuario "
                    + "WHERE email='" + e + "';");
            this.email = null;
            if (lista.Count == 1)
            {
                Object[] tupla = lista[0];

                email = (String)tupla[0];
                if (tupla[1].ToString() != "") password = (String)tupla[1];
                if (tupla[2].ToString() != "") dni = (String)tupla[2];
                if (tupla[3].ToString() != "") nombreUser = (String)tupla[3];
                rol = new Rol((String)tupla[4]);

                if (tupla[5].ToString() != "")
                {
                    string[] fechaIn = tupla[5].ToString().Split('-');
                    fechaNac = new DateTime(int.Parse(fechaIn[0]), int.Parse(fechaIn[1]), int.Parse(fechaIn[2]));
                }

                //imagen = null;
                grados = null;
                preferencias = null;
                asignaturas = null;
                if (tupla[7].ToString() != "") nombre = (String)tupla[7];
                if (tupla[8].ToString() != "") apellido1 = (String)tupla[8];
                if (tupla[9].ToString() != "") apellido2 = (String)tupla[9];
                if (tupla[10].ToString() != "") situacion = (String)tupla[10];
                aceptado = (Boolean)tupla[11];
            }
        }

        public Usuario(String e, String p)
        {
            // Crea el objeto cargando sus valores de la base de datos
            try
            {
                SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);

                Object[] tupla = miBD.Select("SELECT * FROM Usuario "
                        + "WHERE email='" + e + "';")[0];

                email = (String)tupla[0];
                password = (String)tupla[1];

                if (!password.Equals(p))
                {
                    email = password = null;
                    throw new BDException("Error: Usuario o Contraseña incorrecto");
                }
                if (tupla[2].ToString()!="") dni = (String)tupla[2];
                if(tupla[3].ToString()!="")nombreUser = (String)tupla[3];
                rol = new Rol((String)tupla[4]);
                
                
                if (tupla[5].ToString() != "")
                {
                    string[] fechaIn = tupla[5].ToString().Split('-');
                    fechaNac = new DateTime(int.Parse(fechaIn[0]), int.Parse(fechaIn[1]), int.Parse(fechaIn[2]));

                }

                //imagen = null;
                preferencias = null;
                asignaturas = null;
                if (tupla[7].ToString() != "") nombre = (String)tupla[7];
                if (tupla[8].ToString() != "") apellido1 = (String)tupla[8];
                if (tupla[9].ToString() != "") apellido2 = (String)tupla[9];
                if (tupla[10].ToString() != "") situacion = (String)tupla[10];
                aceptado = (Boolean)tupla[11];
            }
            catch (Exception ex)
            {
                throw new BDException("Error: Usuario o Contraseña incorrecto ");
            }
        }

        public Usuario(String e, Rol r, String nombre, String apellido1, String apellido2, String situacion)
        {
            // Crea el objeto y lo inserta en la base de datos
            SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
            miBD.Insert("INSERT INTO Usuario (email,nombreRol,nombre,apellido1,apellido2,situacion) VALUES("
                    + "'" + e + "', '" + r.NombreRol + "','" + nombre + "','" + apellido1 + "','" + apellido2 + "','" + situacion+"');");
            email = e;
            rol = r;
            this.nombre = nombre;
            this.apellido1 = apellido1;
            this.apellido2 = apellido2;
            this.situacion = situacion;
            preferencias = null;
            asignaturas = null;
            grados = null;
            aceptado = true;
        }

        public Usuario(String e, String p, String name, Rol r, Boolean aceptado)
        {
            // Crea el objeto y lo inserta en la base de datos
            SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
            miBD.Insert("INSERT INTO Usuario (email,password,nombreUser,nombreRol, solicitud) VALUES("
                    + "'" + e + "', '" + p + "', '" + name + "', '" + r.NombreRol + "', " + (aceptado ? 1 : 0) + " );");
            email = e;
            password = p;
            nombreUser = name;
            rol = r;
            preferencias = null;
            asignaturas = null;
            grados = null;
            this.aceptado = aceptado;
        }

        public String Email
        {
            get { return email; }
            set {
                throw new BDException("Error: Un usuario no puede cambiarse el email.");
            }
        }

        public String Password
        {
            get { return password; }
            set {
                SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
                miBD.Update("UPDATE Usuario SET password = '" + value
                + "' WHERE email ='" + this.email + "';");
                password = value;
            }
        }

        public String DNI
        {
            get { return dni; }
            set
            {
                SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
                miBD.Update("UPDATE Usuario SET DNI = '" + value
                + "' WHERE email ='" + this.email + "';");
                dni = value;
            }
        }

        public String NombreUser
        {
            get { return nombreUser; }
            set
            {
                SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
                miBD.Update("UPDATE Usuario SET nombreUser = '" + value
                     + "' WHERE email ='" + this.email + "';");
                nombreUser = value;
            }
        }

        public String Nombre
        {
            get { return nombre; }
            set
            {
                SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
                miBD.Update("UPDATE Usuario SET nombre = '" + value
                     + "' WHERE email ='" + this.email + "';");
                nombre = value;
            }
        }

        public String Apellido1
        {
            get { return apellido1; }
            set
            {
                SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
                miBD.Update("UPDATE Usuario SET apellido1 = '" + value
                     + "' WHERE email ='" + this.email + "';");
                apellido1 = value;
            }
        }

        public String Apellido2
        {
            get { return apellido2; }
            set
            {
                SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
                miBD.Update("UPDATE Usuario SET apellido2 = '" + value
                     + "' WHERE email ='" + this.email + "';");
                apellido2 = value;
            }
        }

        public String Situacion
        {
            get { return situacion; }
            set
            {
                SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
                miBD.Update("UPDATE Usuario SET situacion = '" + value
                     + "' WHERE email ='" + this.email + "';");
                situacion = value;
            }
        }

        public Boolean Aceptado
        {
            get { return aceptado; }
            set
            {
                SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
                miBD.Update("UPDATE Usuario SET solicitud = " + (value? 1 : 0)
                     + " WHERE email ='" + this.email + "';");
                aceptado = value;
            }
        }

        public DateTime FechaNac
        {
            get { return fechaNac; }
            set
            {
                SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
                miBD.Update("UPDATE Usuario SET fechaNac = '" + value.ToShortDateString()
                        + "' WHERE email ='" + this.email + "';");
                fechaNac = value;
            }
        }

        public void BorraUsuario()
        {
            // Actualiza el atributo en memoria y en la base de datos
            SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
            miBD.Delete("DELETE FROM Usuario WHERE email ='" + this.email + "';");
            email = password = null;
            DNI = nombreUser = null;
            fechaNac = DateTime.Today;
            //imagen = null;
            nombre = null;
            apellido1 = null;
            apellido2 = null;
            situacion = null;
            rol = null;
        }


        public Rol Rol
        {
            get { return rol; }
            set
            {
                throw new BDException("Error: Un usuario no puede cambiar el rol de si mismo.");
            }
        }


        public void ModiRol(Usuario u, Rol r)
        {
            if (this.rol.Admin)
            {
                // Actualiza el atributo rol de u en memoria y en la base de datos
                SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
                miBD.Update("UPDATE Usuario SET nombreRol = '" + r.NombreRol
                        + "' WHERE email ='" + u.Email + "';");

                u.rol = r;

            }
            else throw new Exception("El usuario " + this.NombreUser
                    + " no puede cambiar el rol del usuario "
                    + u.NombreUser);
        }




        public Boolean AccesoPantalla(String p)
        {
            return rol.Acceso(p);
        }

        public Boolean InsertarPantalla(String p)
        {
            return rol.Insertar(p);
        }

        public Boolean ModificarPantalla(String p)
        {
            return rol.Modificar(p);
        }

        public Boolean BorrarPantalla(String p)
        {
            return rol.Borrar(p);
        }

        public Boolean AceptarPantalla(String p)
        {
            return rol.Aceptar(p);
        }

        public Boolean RechazarPantalla(String p)
        {
            return rol.Rechazar(p);
        }

        
        public Image Imagen
        {
            get
            {
                if (imagen == null)
                {
                    using (var db = new ImagenesDB.WePassEntities())
                    {
                        var obj = db.Usuario.Find(this.email);

                        byte[] m_imagen = obj.imagen;
                        if (m_imagen == null)
                        {
                            imagen = null;
                        }
                        else
                        {
                            MemoryStream m_MemoryStream = new MemoryStream(m_imagen);
                            imagen = Image.FromStream(m_MemoryStream);
                        }
                    }
                }
                return imagen;
            }
            set
            {
                using (var db = new ImagenesDB.WePassEntities())
                {
                    var obj = db.Usuario.Find(this.email);

                    //CONVERT TO ARRAY
                    MemoryStream m_MemoryStream = new MemoryStream();
                    value.Save(m_MemoryStream, System.Drawing.Imaging.ImageFormat.Png);
                    byte[] m_imagen = m_MemoryStream.ToArray();

                    obj.imagen = m_imagen;
                    db.SaveChanges();

                }
                this.imagen = value;
            }
        }


        public override string ToString()
        {
            return email + ";" + password + ";" + dni + ";" + nombreUser + ";" + rol.NombreRol + ";" + fechaNac.ToShortDateString();
        }

        public override bool Equals(object obj)
        {
            return obj is Usuario && (((Usuario)obj).email.ToUpper().CompareTo(this.email.ToUpper()) == 0);
        }

        public override int GetHashCode()
        {
            return email.GetHashCode();
        }

        


        /*
         *  GESTIÓN ATRIBUTOS LAZY
         */



        public List<Preferencia> Preferencias
        {
            get
            {
                if (preferencias == null) preferencias = Preferencia.ListaPreferencias(this);
                return preferencias;
            }
        }

        public List<Mensaje> MensajesEnviados
        {
            get
            {
                if (mensajesEnviados == null)
                {
                    mensajesEnviados = Mapeo.Mensaje.ListaMensajesEnviados(this);
                    /* List<Mensaje> recibidos = new List<Mensaje>();
                     foreach (Mensaje msg in mensajes)
                     {
                         if (msg.Receptor.Equals(this))
                         {
                             recibidos.Add(msg);
                         }
                     }
                     mensajes = recibidos;*/
                }
                return mensajesEnviados;
            }
        }

        public List<Mensaje> MensajesRecibidos
        {
            get
            {
                if (mensajesRecibidos == null)
                {
                    mensajesRecibidos = Mapeo.Mensaje.ListaMensajesRecibidos(this);
                    /* List<Mensaje> recibidos = new List<Mensaje>();
                     foreach (Mensaje msg in mensajes)
                     {
                         if (msg.Receptor.Equals(this))
                         {
                             recibidos.Add(msg);
                         }
                     }
                     mensajes = recibidos;*/
                }
                return mensajesRecibidos;
            }
        }

        public void AddMensajeEnviado(Mensaje msg)
        {
            if (!this.MensajesEnviados.Contains(msg))
            {
                MensajesEnviados.Add(msg);
            }
        }

        public void RemoveMensajeEnviado(Mensaje msg)
        {
            if (this.MensajesEnviados.Contains(msg))
            {
                MensajesEnviados.Remove(msg);
            }
        }

        public void AddMensajeRecibido(Mensaje msg)
        {
            if (!this.MensajesRecibidos.Contains(msg))
            {
                MensajesRecibidos.Add(msg);
            }
        }

        public void RemoveMensajeRecibido(Mensaje msg)
        {
            if (this.MensajesRecibidos.Contains(msg))
            {
                MensajesRecibidos.Remove(msg);
            }
        }

        public void AddPreferencia(Preferencia p)
        {
            if (!this.Preferencias.Contains(p))
            {
                preferencias.Add(p);
            }
        }

        public void RemovePrefrencia(Preferencia p)
        {
            if (this.Preferencias.Contains(p))
            {
                preferencias.Remove(p);
            }
        }

        public List<Asignatura> Asignaturas
        {
            get
            {
                if (asignaturas == null) asignaturas = Asignatura.ListaAsignaturas(this);
                return asignaturas;
            }
        }

        public List<Grado> Grados
        {
            get
            {
                if (grados == null) grados = Grado.ListaGrados(this);
                return grados;
            }
        }

        public void AddGrado(Grado g)
        {
            if (!this.Grados.Contains(g))
            {
                SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
                String ins = "INSERT INTO Rel_User_Grado VALUES ('" + this.Email + "'," + g.ID_Grado + ");";
                miBD.Insert(ins);
                Grados.Add(g);
            }
        }

        public void AddAsignatura(Asignatura a)
        {
            if (asignaturas == null) asignaturas = Asignatura.ListaAsignaturas(this);
            if (!this.Asignaturas.Contains(a))
            {
                SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
                String ins = "INSERT INTO Rel_User_Asig VALUES ('" + this.Email + "'," + a.ID_Asig + ");";
                miBD.Insert(ins);
                asignaturas.Add(a);
            }
        }

        public List<Actividad_Solicitud> ActividadesSolicitadas
        {
            get
            {
                if (actividadesSolicitadas == null)
                {
                    actividadesSolicitadas = Actividad_Solicitud.ListaActividadesSolicitudes(this);
                }
                return actividadesSolicitadas;
            }
        }

        public void AddActividadSolicitada(Actividad act, EstadoActividadSolicitudE estado)
        {
            Actividad_Solicitud actSolicitud = new Actividad_Solicitud(this, act, estado);
            this.ActividadesSolicitadas.Add(actSolicitud);
        }

        public void RemoveActividadSolicitada(Actividad_Solicitud act)
        {
            this.ActividadesSolicitadas.Remove(act);
            act.BorrarActividadSolicitud();
        }




    }
}
