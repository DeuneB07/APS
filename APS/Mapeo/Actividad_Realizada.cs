using System;
using System.Collections.Generic;
using BDLibrary;
using APS.BD;
using System.IO;

namespace APS.Mapeo
{
    public class Actividad_Realizada
    {
        public enum EstadoActividadR { EVALUACION_PARTICIPANTE, EVALUACION_ONG, EVALUACION_PDI, EVALUACION_FINALIZADA };

        private static string BD_SERVER = Properties.Settings.Default.BD_SERVER;
        private static string BD_NAME = Properties.Settings.Default.BD_NAME;

        private Usuario participante;
        private Actividad actividad;
        private EstadoActividadR estadoRealizacion;
        private float valoracionUsuario;
        private DateTime fechaValoracionUsuario= DateTime.MinValue;
        private String comentarioUsuario;
        private int numHorasRealizadas;
        private float valoracionONG;
        private DateTime fechaValoracionONG = DateTime.MinValue;
        private String comentarioONG;
        private byte[] archivoAdjuntoONG;   //lazy
        private float valoracionProfesor;
        private DateTime fechaValoracionProfesor = DateTime.MinValue;
        private String comentarioProfesor;

        public static Boolean Contains(Usuario user, Actividad act)
        {
            if(user!=null && act!= null){
                SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
                List<Object[]> lista = miBD.Select("SELECT * FROM Actividades_Realizadas WHERE emailParticipante='" + user.Email + "' AND idAct=" + act.ID_Actividad + ";");
                return lista.Count == 1;
            }else{
                return false;
            }

        }

        public static List<Actividad> ListaActividades(Usuario user)
        {
            // Retorna una lista con todos los obejtos de la clase almacenados en la base de datos
            SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
            List<Actividad> lista = new List<Actividad>();

            foreach (Object[] tupla in miBD.Select("SELECT idAct FROM Actividades_Realizadas WHERE emailParticipante='" + user.Email + "';"))
            {
                int id = (int)tupla[0];
                Actividad a = new Actividad(id);
                lista.Add(a);
            }
            return lista;
        }

        public static List<Actividad_Realizada> ListaActividadesRealizadas()
        {
            // Retorna una lista con todos los obejtos de la clase almacenados en la base de datos
            SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
            List<Actividad_Realizada> lista = new List<Actividad_Realizada>();

            foreach (Object[] tupla in miBD.Select("SELECT emailParticipante, idAct FROM Actividades_Realizadas;"))
            {
                String emP = tupla[0].ToString();
                int id = (int)tupla[1];
                Actividad_Realizada aR = new Actividad_Realizada(new Usuario(emP), new Actividad(id));
                lista.Add(aR);
            }
            return lista;
        }

        public static List<Actividad_Realizada> ListaActividadesRealizadasAscendente(Usuario user)
        {
            // Retorna una lista con todos los obejtos de la clase almacenados en la base de datos
            SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
            List<Actividad_Realizada> lista = new List<Actividad_Realizada>();
            if (!user.Rol.NombreRol.Equals("ONG")) {
                foreach (Object[] tupla in miBD.Select("SELECT aR.emailParticipante, aR.idAct " +
                                        "FROM Actividades_Realizadas aR, Actividades act " +
                                        "WHERE aR.idAct = act.ID_Actividad AND aR.emailParticipante = '" + user.Email + "' " +
                                        "ORDER BY act.fechaFin ASC;")) {
                    String emP = tupla[0].ToString();
                    int id = (int)tupla[1];
                    Actividad_Realizada aR = new Actividad_Realizada(new Usuario(emP), new Actividad(id));
                    lista.Add(aR);
                }
            }
            else
            {
                foreach (Object[] tupla in miBD.Select("SELECT aR.emailParticipante, aR.idAct " +
                        "FROM Actividades_Realizadas aR, Actividades act " +
                        "WHERE aR.idAct = act.ID_Actividad AND act.emailOrganizador = '" + user.Email + "' " +
                        "ORDER BY act.fechaFin ASC;"))
                {
                    String emP = tupla[0].ToString();
                    int id = (int)tupla[1];
                    Actividad_Realizada aR = new Actividad_Realizada(new Usuario(emP), new Actividad(id));
                    lista.Add(aR);
                }
            }
            return lista;
        }

        public static List<Actividad_Realizada> ListaActividadesRealizadasDescendente(Usuario user)
        {
            // Retorna una lista con todos los obejtos de la clase almacenados en la base de datos
            SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
            List<Actividad_Realizada> lista = new List<Actividad_Realizada>();

            if (!user.Rol.NombreRol.Equals("ONG"))
            {
                foreach (Object[] tupla in miBD.Select("SELECT aR.emailParticipante, aR.idAct " +
                                        "FROM Actividades_Realizadas aR, Actividades act " +
                                        "WHERE aR.idAct = act.ID_Actividad AND aR.emailParticipante = '" + user.Email + "' " +
                                        "ORDER BY act.fechaFin DESC;"))
                {
                    String emP = tupla[0].ToString();
                    int id = (int)tupla[1];
                    Actividad_Realizada aR = new Actividad_Realizada(new Usuario(emP), new Actividad(id));
                    lista.Add(aR);
                }

            }
            else
            {
                foreach (Object[] tupla in miBD.Select("SELECT aR.emailParticipante, aR.idAct " +
                                                        "FROM Actividades_Realizadas aR, Actividades act " +
                                                         "WHERE aR.idAct = act.ID_Actividad AND act.emailOrganizador = '" + user.Email + "' " +
                                                          "ORDER BY act.fechaFin DESC;"))
                {
                    String emP = tupla[0].ToString();
                    int id = (int)tupla[1];
                    Actividad_Realizada aR = new Actividad_Realizada(new Usuario(emP), new Actividad(id));
                    lista.Add(aR);
                }
            }
            return lista;
        }

        public static List<Actividad_Realizada> ListaActividadesRealizadas(Usuario usuario, EstadoActividadR estado)
        {
            // Retorna una lista con todos los obejtos de la clase almacenados en la base de datos
            SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
            List<Actividad_Realizada> lista = new List<Actividad_Realizada>();

            foreach (Object[] tupla in miBD.Select("SELECT emailParticipante, idAct FROM Actividades_Realizadas WHERE emailParticipante = '" + usuario.Email + "' and estadoRealizacion = '" + estado.ToString() + "';"))
            {
                String emP = tupla[0].ToString();
                int id = (int)tupla[1];
                Actividad_Realizada aR = new Actividad_Realizada(new Usuario(emP), new Actividad(id));
                lista.Add(aR);
            }
            return lista;
        }

        public static List<Actividad> ListaActividades(EstadoActividadR estado)
        {
            SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
            List<Actividad> lista = new List<Actividad>();

            foreach(Object[] tupla in miBD.Select("SELECT count(emailParticipante), idAct FROM Actividades_Realizadas WHERE estadoRealizacion = '" + estado.ToString() + "' group by idAct;"))
            {
                int id = (int)tupla[1];
                Actividad aR = new Actividad(id);
                lista.Add(aR);
            }
            return lista;
        }

        public static List<Actividad> ListaActividades()    //Devuelve las actividades, sin tener en cuenta Estado
        {
            SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
            List<Actividad> lista = new List<Actividad>();

            foreach (Object[] tupla in miBD.Select("SELECT count(emailParticipante), idAct FROM Actividades_Realizadas group by idAct;"))
            {
                int id = (int)tupla[1];
                Actividad aR = new Actividad(id);
                lista.Add(aR);
            }
            return lista;
        }

        public static List<Actividad_Realizada> ListaActividadesRealizadas(Actividad actividad, EstadoActividadR estado)
        {
            SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
            List<Actividad_Realizada> lista = new List<Actividad_Realizada>();

            foreach (Object[] tupla in miBD.Select("SELECT emailParticipante, idAct FROM Actividades_Realizadas WHERE estadoRealizacion = '" + estado.ToString() + "' and idAct = " + actividad.ID_Actividad + ";"))
            {
                String emP = tupla[0].ToString();
                int id = (int)tupla[1];
                Actividad_Realizada aR = new Actividad_Realizada(new Usuario(emP), actividad);
                lista.Add(aR);
            }
            return lista;
        }

        public Actividad_Realizada(Usuario participante, Actividad act)
        {
            SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
            Object[] tupla = miBD.Select("SELECT * FROM Actividades_Realizadas "
                    + "WHERE emailParticipante='" + participante.Email + "' and idAct =" + act.ID_Actividad + ";")[0];
        
            this.participante = participante;
            actividad = act;
            Enum.TryParse<EstadoActividadR>(tupla[2].ToString(), true, out estadoRealizacion);
            if (!tupla[3].ToString().Equals("")) valoracionUsuario = float.Parse(tupla[3].ToString());
            String[] fecha = tupla[4].ToString().Split('/', '-', ' ', ':', '.');
            if (!tupla[4].ToString().Equals("")) fechaValoracionUsuario = new DateTime(int.Parse(fecha[2]),int.Parse(fecha[1]),int.Parse(fecha[0]),int.Parse(fecha[3]),int.Parse(fecha[4]),int.Parse(fecha[5]));
            if (!tupla[5].ToString().Equals("")) comentarioUsuario = (String)tupla[5];
            if (!tupla[6].ToString().Equals("")) numHorasRealizadas = (int)tupla[6];
            if (!tupla[7].ToString().Equals("")) valoracionONG = float.Parse(tupla[7].ToString());
            fecha = (tupla[8].ToString()).Split('/', '-', ' ', ':', '.');
            if (!tupla[8].ToString().Equals("")) fechaValoracionONG = new DateTime(int.Parse(fecha[2]), int.Parse(fecha[1]), int.Parse(fecha[0]), int.Parse(fecha[3]), int.Parse(fecha[4]), int.Parse(fecha[5]));
            if (!tupla[9].ToString().Equals("")) comentarioONG = (String)tupla[9];
            if (!tupla[11].ToString().Equals("")) valoracionProfesor = float.Parse(tupla[11].ToString());
            fecha = (tupla[12].ToString()).Split('/', '-', ' ', ':', '.');
            if (!tupla[12].ToString().Equals("")) fechaValoracionProfesor = new DateTime(int.Parse(fecha[2]), int.Parse(fecha[1]), int.Parse(fecha[0]), int.Parse(fecha[3]), int.Parse(fecha[4]), int.Parse(fecha[5]));
            if (!tupla[13].ToString().Equals("")) comentarioProfesor = (String)tupla[13];   
        }

        public Actividad_Realizada(Usuario participante, Actividad actividad, Boolean f)
        {
            SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
            String ins = "INSERT INTO Actividades_Realizadas (emailParticipante,idAct) VALUES ('" 
                    + participante.Email + "'," + actividad.ID_Actividad + ");";
            miBD.Insert(ins);

            this.participante = participante;
            this.actividad = actividad;
            this.estadoRealizacion = EstadoActividadR.EVALUACION_PARTICIPANTE;

        }

        public Actividad_Realizada(Usuario participante, Actividad actividad, EstadoActividadR estadoRealizacion, float valoracionUsuario,
                                    DateTime fechaValoracionUsuario, String comentarioUsuario, int numHorasRealizadas, float valoracionONG,
                                    DateTime fechaValoracionONG, String comentarioONG, /*File archivoAdjuntoONG,*/ float valoracionProfesor,
                                    DateTime fechaValoracionProfesor, String comentarioProfesor)
        {
            SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
            String ins = "INSERT INTO Actividades_Realizadas (emailParticipante,idAct,estadoRealizacion,valoracionUsuario, fechaValoracionUsuario,"
                    + "comentarioUsuario, numHorasRealizadas, valoracionONG, fechaValoracionONG, comentarioONG, valoracionProfesor, "
                    + " fechaValoracionProfesor, comentarioProfesor) VALUES ('" + participante.Email + "',"
                    + actividad.ID_Actividad + ",'" + estadoRealizacion.ToString() + "'," + valoracionUsuario + ",'" + fechaValoracionUsuario.ToString() + "','"
                    + comentarioUsuario + "'," + numHorasRealizadas + "," + valoracionONG + ",'" + fechaValoracionONG.ToString() + "','"
                    + comentarioONG + "'," + valoracionProfesor + ",'" + fechaValoracionProfesor.ToString() + "', '" + comentarioProfesor +"');";
            miBD.Insert(ins);
            

            this.participante = participante;
            this.actividad = actividad;
            this.estadoRealizacion = estadoRealizacion;
            this.valoracionUsuario = valoracionUsuario;
            this.fechaValoracionUsuario = fechaValoracionUsuario;
            this.comentarioUsuario = comentarioUsuario;
            this.numHorasRealizadas = numHorasRealizadas;
            this.valoracionONG = valoracionONG;
            this.fechaValoracionONG = fechaValoracionONG;
            this.comentarioONG = comentarioONG;
            //this.archivoAdjuntoONG = archivoAdjuntoONG;
            this.valoracionProfesor = valoracionProfesor;
            this.fechaValoracionProfesor = fechaValoracionProfesor;
            this.comentarioProfesor = comentarioProfesor;

        }

        public Usuario Participante
        {
            get{ return participante; }
            set
            {
                SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
                String up = "UPDATE Actividades_Realizadas SET emailParticipante='" + value.Email + "' "
                        + "WHERE emailParticipante='" + this.participante.Email + "' and idAct=" + actividad.ID_Actividad + ";";
                miBD.Update(up);
                this.participante = value;
            }
        }

        public Actividad Actividad
        {
            get{ return actividad; }
            set
            {
                SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
                String up = "UPDATE Actividades_Realizadas SET idAct=" + value.ID_Actividad + " "
                        + "WHERE emailParticipante='" + this.participante.Email + "' and idAct=" + actividad.ID_Actividad + ";";
                miBD.Update(up);
                this.actividad = value;
            }
        }

        public EstadoActividadR EstadoRealizacion
        {
            get{ return estadoRealizacion; }
            set
            {
                SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
                String up = "UPDATE Actividades_Realizadas SET estadoRealizacion='" + value.ToString() + "' "
                        + "WHERE emailParticipante='" + this.participante.Email + "' and idAct=" + actividad.ID_Actividad + ";";
                miBD.Update(up);
                this.estadoRealizacion = value;
            }
        }

        public float ValoracionUsuario
        {
            get{ return valoracionUsuario; }
            set
            {
                using (var db = new ImagenesDB.WePassEntities2())
                {
                    int id = this.Actividad.ID_Actividad;
                    String email = this.Participante.Email;
                    var obj = db.Actividades_Realizadas.Find(email, id);

                    obj.valoracionUsuario = value;
                    db.SaveChanges();
                }
                valoracionUsuario = value;
            }
        }

        public DateTime FechaValoracionUsuario
        {
            get{ return fechaValoracionUsuario; }
            set
            {
                SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
                String up = "UPDATE Actividades_Realizadas SET fechaValoracionUsuario='" + value.ToString() + "' "
                        + "WHERE emailParticipante='" + this.participante.Email + "' and idAct=" + actividad.ID_Actividad + ";";
                miBD.Update(up);
                this.fechaValoracionUsuario = value;
            }
        }

        public String ComentarioUsuario
        {
            get{ return comentarioUsuario; }
            set
            {
                SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
                String up = "UPDATE Actividades_Realizadas SET comentarioUsuario='" + value + "' "
                        + "WHERE emailParticipante='" + this.participante.Email + "' and idAct=" + actividad.ID_Actividad + ";";
                miBD.Update(up);
                this.comentarioUsuario = value;
            }
        }

        public int NumHorasRealizadas
        {
            get{ return numHorasRealizadas; }
            set
            {
                SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
                String up = "UPDATE Actividades_Realizadas SET numHorasRealizadas=" + value + " "
                        + "WHERE emailParticipante='" + this.participante.Email + "' and idAct=" + actividad.ID_Actividad + ";";
                miBD.Update(up);
                this.numHorasRealizadas = value;
            }
        }

        public float ValoracionONG
        {
            get{ return valoracionONG; }
            set
            {
                using (var db = new ImagenesDB.WePassEntities2())
                {
                    int id = this.Actividad.ID_Actividad;
                    String email = this.Participante.Email;
                    var obj = db.Actividades_Realizadas.Find(email, id);

                    obj.valoracionONG = value;
                    db.SaveChanges();
                }
                valoracionONG = value;
            }
        }

        public DateTime FechaValoracionONG
        {
            get{ return fechaValoracionONG; }
            set
            {
                SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
                String up = "UPDATE Actividades_Realizadas SET fechaValoracionONG='" + value.ToString() + "' "
                        + "WHERE emailParticipante='" + this.participante.Email + "' and idAct=" + actividad.ID_Actividad + ";";
                miBD.Update(up);
                this.fechaValoracionONG = value;
            }
        }

        public String ComentarioONG
        {
            get{ return comentarioONG; }
            set
            {
                SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
                String up = "UPDATE Actividades_Realizadas SET comentarioONG='" + value + "' "
                        + "WHERE emailParticipante='" + this.participante.Email + "' and idAct=" + actividad.ID_Actividad + ";";
                miBD.Update(up);
                this.comentarioONG = value;
            }
        }

        
        public byte[] ArchivoAdjuntoONG
        {
            get {
                if (archivoAdjuntoONG == null)
                {
                    using (var db = new ImagenesDB.WePassEntities2())
                    {
                        int id = this.Actividad.ID_Actividad;
                        String email = this.Participante.Email;
                        var obj = db.Actividades_Realizadas.Find(email, id);

                        archivoAdjuntoONG = obj.archivoAdjuntoONG;
                    }
                }
                return archivoAdjuntoONG;
            }
            set
            {
                using (var db = new ImagenesDB.WePassEntities2())
                {
                    int id = this.Actividad.ID_Actividad;
                    String email = this.Participante.Email;
                    var obj = db.Actividades_Realizadas.Find(email,id);

                    obj.archivoAdjuntoONG = value;
                    db.SaveChanges();

                }
                this.archivoAdjuntoONG = value;
            }
        }
         

        public float ValoracionProfesor
        {
            get{ return valoracionProfesor; }
            set
            {
                using (var db = new ImagenesDB.WePassEntities2())
                {
                    int id = this.Actividad.ID_Actividad;
                    String email = this.Participante.Email;
                    var obj = db.Actividades_Realizadas.Find(email, id);

                    obj.valoracionProfesor = value;
                    db.SaveChanges();
                }
                valoracionProfesor = value;
            }
        }

        public DateTime FechaValoracionProfesor
        {
            get{ return fechaValoracionProfesor; }
            set
            {
                SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
                String up = "UPDATE Actividades_Realizadas SET fechaValoracionProfesor='" + value.ToString() + "' "
                        + "WHERE emailParticipante='" + this.participante.Email + "' and idAct=" + actividad.ID_Actividad + ";";
                miBD.Update(up);
                this.fechaValoracionProfesor = value;
            }
        }

        public String ComentarioProfesor
        {
            get{ return comentarioProfesor; }
            set
            {
                SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
                String up = "UPDATE Actividades_Realizadas SET comentarioProfesor='" + value + "' "
                        + "WHERE emailParticipante='" + this.participante.Email + "' and idAct=" + actividad.ID_Actividad + ";";
                miBD.Update(up);
                this.comentarioProfesor = value;
            }
        }

        public void BorrarActividadRealizada()
        {
            SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
            String del = "DELETE FROM Actividades_Realizadas WHERE emailParticipante='" + this.participante.Email + "' and idAct=" + this.actividad.ID_Actividad + ";";
            miBD.Delete(del);

            this.participante = null;
            this.actividad = null;
            this.valoracionUsuario = -1;
            this.fechaValoracionUsuario = DateTime.Today;
            this.comentarioUsuario = null;
            this.numHorasRealizadas = -1;
            this.valoracionONG = -1;
            this.fechaValoracionONG = DateTime.Today;
            this.comentarioONG = null;
            //this.archivoAdjuntoONG = null;
            this.valoracionProfesor = -1;
            this.fechaValoracionProfesor = DateTime.Today;
            this.comentarioProfesor = null;
        }

        public override string ToString()
        {
            return "Actividad_Realizada [emailParticipante=" + participante.Email + ", idAct=" + actividad.ID_Actividad + ", estadoRealizacion=" + estadoRealizacion
        + ", valoracionUsuario=" + valoracionUsuario + ", fechaValoracionUsuario=" + fechaValoracionUsuario + ", comentarioUsuario=" + comentarioUsuario + ", numHorasRealizadas="
        + numHorasRealizadas + ", valoracionONG=" + valoracionONG + ", fechaValoracionONG=" + fechaValoracionONG + ", comentarioONG=" + comentarioONG
        + /*", archivoAdjuntoONG=" + archivoAdjuntoONG + */", valoracionProfesor=" + valoracionProfesor + ", fechaValoracionProfesor=" + fechaValoracionProfesor + ", comentarioProfesor=" + comentarioProfesor;
        }

        public override bool Equals(object obj)
        {
            return obj is Actividad_Realizada && (((Actividad_Realizada)obj).participante.Equals(this.participante)) 
                    && (((Actividad_Realizada)obj).actividad.Equals(this.actividad));
        }

        public override int GetHashCode()
        {
            return participante.GetHashCode() + actividad.GetHashCode();
        }

    }
}
