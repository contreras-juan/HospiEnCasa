using Microsoft.EntityFrameworkCore;
using HospiEnCasa.App.Dominio;

namespace HospiEnCasa.App.Persistencia

{
    public class AppContext : DbContext
    {
        public DbSet<Persona> Persona {get;set;}
        public DbSet<Enfermeria> Enfermeria {get;set;}
        public DbSet<FamiliarDesignado> FamiliarDesignado {get;set}
        public DbSet<Historia> Historia {get;set;}
        public DbSet<Medico> Medico {get;set;}
        public DbSet<SugerenciaCuidado> SugerenciaCuidado {get;set;}

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if(!optionsBuilder.IsConfigured)
        {
            optionsBuilder
            .UseSqlServer("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = HospiEnCasatData");
        }
    }
    }
}