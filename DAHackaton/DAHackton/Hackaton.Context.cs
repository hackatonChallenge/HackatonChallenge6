﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DACOVIDWEB
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class HackatonEntities : DbContext
    {
        public HackatonEntities()
            : base("name=HackatonEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<datos> datos { get; set; }
        public virtual DbSet<fuentes> fuentes { get; set; }
        public virtual DbSet<labels_area> labels_area { get; set; }
        public virtual DbSet<labels_cat_indicador> labels_cat_indicador { get; set; }
        public virtual DbSet<labels_clima_educativo> labels_clima_educativo { get; set; }
        public virtual DbSet<labels_indicador> labels_indicador { get; set; }
        public virtual DbSet<labels_nivel_ingresos> labels_nivel_ingresos { get; set; }
        public virtual DbSet<labels_pais> labels_pais { get; set; }
        public virtual DbSet<labels_sexo> labels_sexo { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<labels_anos_estudio> labels_anos_estudio { get; set; }
        public virtual DbSet<labels_grupo_edad> labels_grupo_edad { get; set; }
        public virtual DbSet<labels_region> labels_region { get; set; }
        public virtual DbSet<pais_ano> pais_ano { get; set; }
    }
}