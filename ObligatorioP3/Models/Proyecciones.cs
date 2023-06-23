using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ObligatorioP3.Models
{
    public class Proyecciones
    {
        [Key]
        public int ProyeccionId { get; set; }
        [ForeignKey("Peliculas")] 
        public int idPelicula { get; set; }
        public Peliculas? Peliculas { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? FechayHora { get; set; }
        [ForeignKey("Salas")]
        public int idSala { get; set; }
        public List<Salas>? asientosReservados = new List<Salas>();


        
    }
}
