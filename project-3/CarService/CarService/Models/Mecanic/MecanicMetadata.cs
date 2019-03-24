using System.ComponentModel.DataAnnotations;

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
    }
}
