using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ObligatorioP3.Models
{
    [Table("Salas")]
    public class Salas
    {
        [Key]
        [Column("id_Sala")]
        public int IdSala { get; set; }
        [Required]
        [ForeignKey(nameof(NroSala))]
        [Column("Nro_Sala")]
        public int NroSala { get; set; }
        [Required]
        [Column("Cant_Sala")]
        public int Cantidad { get; set; }
        [Required]
        [Column("list_asientos")]
        public List<int> AsientosDisponibles = new List<int> {
            1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,28,29,30,31,32
        };

    }

}
