﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Entities2 : DbContext
    {
        public Entities2()
            : base("Data Source=localhost;Initial Catalog=WePass;Persist Security Info=True;User ID=user1;Password=user1;MultipleActiveResultSets=True")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            var entityBuilder = modelBuilder.Entity<Actividades>();
            entityBuilder.HasKey(e => new { e.ID_Actividad });
        }
    
        public virtual DbSet<Usuario> Usuario { get; set; }
    }
}
