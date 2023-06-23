using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ObligatorioP3.Models
{
    [Table("Usuarios")]
    public class Usuarios
    {
        [Key]
        [Column("id_Usuario")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdUsuario { get; set; }
        [Required]
        [StringLength(50)]
        [Column("nom_usuario")]
        public string? Nombre { get; set; }
        [Required]
        [Column("mail_usuario")]
        [Display(Name = "Correo electronico")]
        [RegularExpression(@"^[a - z0 - 9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?$)")]
        public string? Mail { get; set; }
        [Required]
        [Column("pass_usuario")]
        [RegularExpression(@"^(?=\w *\d)(?=\w*[A - Z])(?=\w*[a - z])\S{8,16}$")]
        public string? Password { get; set; }
        [Required]
        [Column("tel_usuario")]
        public int? Telefono { get; set; }
    }
}
