using ObligatorioP3.Models;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography.X509Certificates;

namespace ObligatorioP3.datos
{
    public class aplicationDBContext : DbContext
    {
        public aplicationDBContext(DbContextOptions<aplicationDBContext> opciones) : base(opciones)
        {

        }
        // Aqui vamos a escribir los modelos 
        public DbSet<Peliculas>? Peliculas { get; set; }
        public DbSet<Proyecciones>? proyecciones { get; set; }
        public DbSet<Salas>? Salas { get; set; }
        public DbSet<Usuarios>? Usuarios { get; set;}
        public DbSet<Cine>? cines { get; set; }
        
    }
}
