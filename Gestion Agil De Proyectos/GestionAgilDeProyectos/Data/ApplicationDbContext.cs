using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using GestionAgilDeProyectos.Models;

namespace GestionAgilDeProyectos.Data
{
	public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
	{
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Cursos> Cursos { get; set; }
        public DbSet<Region> Region { get; set; }
        public DbSet<Comuna> Comuna { get; set; }
        public DbSet<Provincia> Provincia { get; set; }
        public DbSet<Inscripcion> Inscripcion { get; set; }
    }
}


