﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Entities : DbContext
    {
        public Entities()
            : base("Data Source=localhost;Initial Catalog=WePass;Persist Security Info=True;User ID=user1;Password=user1;MultipleActiveResultSets=True")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            var entityBuilder = modelBuilder.Entity<ActividadesDB.Actividades>();
            entityBuilder.HasKey(e => new { e.ID_Actividad });
        }
    
        public virtual DbSet<Actividades> Actividades { get; set; }
    }
}
