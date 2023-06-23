using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.Contracts;

namespace ObligatorioP3.Models
{
    [Table("Reservas")]
    public class Reservas
    {
        [Key]
        public int IdReserva { get; set; }
        [Required]
        [ForeignKey("Usuarios")]
        public int IdUsuario { get; set; }
        public Usuarios? Usuarios { get; set; }
        [Required]
        [ForeignKey("Proyecciones")]
        public int idProyeccion { get; set; }
       
        [Required]
        [ForeignKey("Proyecciones")]
        [Column(TypeName = "datetime")]
        public DateTime horaProy { get; set; }
        public Proyecciones Proyecciones = new Proyecciones();
        public List<int>? NroAsiento = new List<int>();
    }
}
