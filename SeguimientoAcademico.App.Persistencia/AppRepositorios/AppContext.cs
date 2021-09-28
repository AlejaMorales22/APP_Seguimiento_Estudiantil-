using Microsoft.EntityFrameworkCore;
using SeguimientoAcademico.App.Dominio;
namespace SeguimientoAcademico.App.Persistencia
{
    public class AppContext:DbContext{

    
        public DbSet <Estudiante> Estudiantes {get;set;} 
        public DbSet <Maestro> Maestros {get;set;} 
        public DbSet <FamiliarDesignado> FamiliarDesignados {get;set;} 
        public DbSet <Tutor> Tutores {get;set;} 
        
        protected override void OnConfiguring (DbContextOptionsBuilder optionsBuilder) {

            if (!optionsBuilder.IsConfigured){
                optionsBuilder.UseSqlServer("Data Source =(localdb)\\MSSQLLocalDB; Initial Catalog=SeguimientoAcademico.Data");    

            }

        }
    }

    }
