using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CarService
{
    public class MecanicMetadata
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(15)]
        public string Nume { get; set; }

        [Required]
        [MaxLength(15)]
        public string Prenume { get; set; }

        [Required]
        [Key, ForeignKey("DetaliuComanda")]
        public int DetaliuComandaId { get; set; }
    }
}
