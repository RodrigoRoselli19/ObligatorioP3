using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ObligatorioP3.Models
{
#nullable disable
    [Table("Cine")]
    public class Cine
    {
        [Key]
        [Column("id_cine")]
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        [Column("nom_cine")]
        public string Nombre { get; set; }
        [Required]
        [StringLength(50)]
        [Column("dir_cine")]
        public string Dirrecion { get; set; }
        public List<Peliculas> Peliculas = new List<Peliculas>();
        public List<Proyecciones> Proyecciones = new List<Proyecciones>();
        public List<Salas> Salas = new List<Salas>();
        public List<Usuarios> Usuarios = new List<Usuarios>();



    }
}
