//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace APS.ImagenesDB
{
    using System;
    using System.Collections.Generic;
    
    public partial class Actividades_Realizadas
    {
        public string emailParticipante { get; set; }
        public int idAct { get; set; }
        public string estadoRealizacion { get; set; }
        public Nullable<double> valoracionUsuario { get; set; }
        public Nullable<System.DateTime> fechaValoracionUsuario { get; set; }
        public string comentarioUsuario { get; set; }
        public Nullable<int> numHorasRealizadas { get; set; }
        public Nullable<double> valoracionONG { get; set; }
        public Nullable<System.DateTime> fechaValoracionONG { get; set; }
        public string comentarioONG { get; set; }
        public byte[] archivoAdjuntoONG { get; set; }
        public Nullable<double> valoracionProfesor { get; set; }
        public Nullable<System.DateTime> fechaValoracionProfesor { get; set; }
        public string comentarioProfesor { get; set; }
    }
}