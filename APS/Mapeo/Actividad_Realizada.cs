﻿using System;
using System.Collections.Generic;
using BDLibrary;
using APS.BD;

namespace APS.Mapeo
{
    class Actividad_Realizada
    {

        private static string BD_SERVER = Properties.Settings.Default.BD_SERVER;
        private static string BD_NAME = Properties.Settings.Default.BD_NAME;

        private Usuario participante;
        private Actividad actividad;
        private String estadoRealizacion;
        private int valoracionUsuario;
        private String fechaValoracionUsuario;
        private String comentarioUsuario;
        private int numHorasRealizadas;
        private int valoracionONG;
        private String fechaValoracionONG;
        private String comentarioONG;
        //private File archivoAdjuntoONG;
        private int valoracionProfesor;
        private String fechaValoracionProfesor;
        private String comentarioProfesor;

        public static List<Actividad> ListaActividades(String emailUsuario)
        {
            // Retorna una lista con todos los obejtos de la clase almacenados en la base de datos
            SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
            List<Actividad> lista = new List<Actividad>();

            foreach (Object[] tupla in miBD.Select("SELECT idAct FROM Actividades_Realizadas WHERE emailParticipante='"+emailUsuario+"';"))
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
                String emP = (String)tupla[0];
                int id = (int)tupla[1];
                Actividad_Realizada aR = new Actividad_Realizada(new Usuario(emP), new Actividad(id));
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
            estadoRealizacion = (String)tupla[2];
            valoracionUsuario = (int)tupla[3];
            fechaValoracionUsuario = (String)tupla[4];
            comentarioUsuario = (String)tupla[5];
            numHorasRealizadas = (int)tupla[6];
            valoracionONG = (int)tupla[7];
            fechaValoracionONG = (String)tupla[8];
            comentarioONG = (String)tupla[9];
            //archivoAdjuntoONG = (String)tupla[10];
            valoracionProfesor = (int)tupla[11];
            fechaValoracionProfesor = (String)tupla[12];
            comentarioProfesor = (String)tupla[13];
        
        }

        public Actividad_Realizada(Usuario participante, Actividad actividad, String estadoRealizacion, int valoracionUsuario,
                                    String fechaValoracionUsuario, String comentarioUsuario, int numHorasRealizadas, int valoracionONG,
                                    String fechaValoracionONG, String comentarioONG, /*File archivoAdjuntoONG,*/ int valoracionProfesor,
                                    String fechaValoracionProfesor, String comentarioProfesor)
        {
            SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
            String ins = "INSERT INTO Actividades_Realizadas (emailParticipante,idAct,estadoRealizacion,valoracionUsuario, fechaValoracionUsuario,"
                    + "comentarioUsuario, numHorasRealizadas, valoracionONG, fechaValoracionONG, comentarioONG, "+/*+archivoAdjuntoONG*/", valoracionProfesor, "
                    + " fechaValoracionProfesor, comentarioProfesor) VALUES ('" + participante.Email + "',"
                    + actividad.ID_Actividad + "," + estadoRealizacion + "," + valoracionUsuario + ",'" + fechaValoracionUsuario + "','"
                    + comentarioUsuario + "'," + numHorasRealizadas + "," + valoracionONG + ",'" + fechaValoracionONG + "','"
                    + comentarioONG + "','" /*+ archivoAdjuntoONG */+ "'," + valoracionProfesor + ",'" + fechaValoracionProfesor + "', '" + comentarioProfesor +"');";
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

        public String EstadoRealizacion
        {
            get{ return estadoRealizacion; }
            set
            {
                SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
                String up = "UPDATE Actividades_Realizadas SET estadoRealizacion='" + value + "' "
                        + "WHERE emailParticipante='" + this.participante.Email + "' and idAct=" + actividad.ID_Actividad + ";";
                miBD.Update(up);
                this.estadoRealizacion = value;
            }
        }

        public int ValoracionUsuario
        {
            get{ return valoracionUsuario; }
            set
            {
                SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
                String up = "UPDATE Actividades_Realizadas SET valoracionUsuario=" + value + " "
                        + "WHERE emailParticipante='" + this.participante.Email + "' and idAct=" + actividad.ID_Actividad + ";";
                miBD.Update(up);
                this.valoracionUsuario = value;
            }
        }

        public String FechaValoracionUsuario
        {
            get{ return fechaValoracionUsuario; }
            set
            {
                SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
                String up = "UPDATE Actividades_Realizadas SET fechaValoracionUsuario='" + value + "' "
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

        public int ValoracionONG
        {
            get{ return valoracionONG; }
            set
            {
                SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
                String up = "UPDATE Actividades_Realizadas SET valoracionONG=" + value + " "
                        + "WHERE emailParticipante='" + this.participante.Email + "' and idAct=" + actividad.ID_Actividad + ";";
                miBD.Update(up);
                this.valoracionONG = value;
            }
        }

        public String FechaValoracionONG
        {
            get{ return fechaValoracionONG; }
            set
            {
                SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
                String up = "UPDATE Actividades_Realizadas SET fechaValoracionONG='" + value + "' "
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

        /*
        public String ArchivoAdjuntoONG
        {
            get{ return archivoAdjuntoONG; }
            set
            {
                SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
                String up = "UPDATE Actividades_Realizadas SET archivoAdjuntoONG='" + value + "' "
                        + "WHERE emailParticipante='" + this.participante.Email + "' and idAct=" + actividad.ID_Actividad + ";";
                miBD.Update(up);
                this.archivoAdjuntoONG = value;
            }
        }
         */

        public int ValoracionProfesor
        {
            get{ return valoracionProfesor; }
            set
            {
                SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
                String up = "UPDATE Actividades_Realizadas SET valoracionProfesor=" + value + " "
                        + "WHERE emailParticipante='" + this.participante.Email + "' and idAct=" + actividad.ID_Actividad + ";";
                miBD.Update(up);
                this.valoracionProfesor = value;
            }
        }

        public String FechaValoracionProfesor
        {
            get{ return fechaValoracionProfesor; }
            set
            {
                SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
                String up = "UPDATE Actividades_Realizadas SET fechaValoracionProfesor='" + value + "' "
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
            this.estadoRealizacion = null;
            this.valoracionUsuario = -1;
            this.fechaValoracionUsuario = null;
            this.comentarioUsuario = null;
            this.numHorasRealizadas = -1;
            this.valoracionONG = -1;
            this.fechaValoracionONG = null;
            this.comentarioONG = null;
            //this.archivoAdjuntoONG = null;
            this.valoracionProfesor = -1;
            this.fechaValoracionProfesor = null;
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
