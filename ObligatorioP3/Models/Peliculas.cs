using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ObligatorioP3.Models
{
    public class Peliculas
    {
        [Key]
        [Column("id_Pel")]
        public int PeliculasId { get; set; }
        [Required]
        [StringLength(30)]
        [ForeignKey(nameof(Titulo))]
        [Column("Titulo_Pel")]  
        public string? Titulo { get; set; }
        [Required]
        [StringLength(25)]
        [Column("Genero_Pel")]
        public string? Genero { get; set; }
        [Required]
        [StringLength(100)]
        [Column("Des_Pel")]
        public string? Des_Pel { get; set; }

    }
}
