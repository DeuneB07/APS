//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace APS.ActividadesDB
{
    using System;
    using System.Collections.Generic;
    
    public partial class Actividades
    {
        public int ID_Actividad { get; set; }
        public string nombreAct { get; set; }
        public string descripcionAct { get; set; }
        public int numPlazas { get; set; }
        public int numHoras { get; set; }
        public string turno { get; set; }
        public System.DateTime fechaInicio { get; set; }
        public System.DateTime fechaFin { get; set; }
        public string lugar { get; set; }
        public string emailOrganizador { get; set; }
        public string emailResponsable { get; set; }
        public Nullable<int> idGrado { get; set; }
        public Nullable<int> idAsig { get; set; }
        public string tipoAct { get; set; }
        public Nullable<int> idProy { get; set; }
        public Nullable<float> notaMedia { get; set; }
        public string estadoAct { get; set; }
        public byte[] imagen { get; set; }
        public string ambitoTrabajo { get; set; }
        public string tipoTrabajo { get; set; }
    }
}