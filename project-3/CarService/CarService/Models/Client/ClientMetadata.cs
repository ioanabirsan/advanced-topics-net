using System.ComponentModel.DataAnnotations;

namespace CarService.Models.Client
{
    public class ClientMetadata
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
        [MaxLength(50)]
        public string Adresa { get; set; }

        [Required]
        [MaxLength(10)]
        public string Localitate { get; set; }

        [Required]
        [MaxLength(10)]
        public string Judet { get; set; }

        [Required]
        [RegularExpression(@"^\d{13}$", 
            ErrorMessage = "Invalid phone number.")]
        public string Telefon { get; set; }

        [Required]
        [RegularExpression(@"^[a-zA-Z0-9_.-]+@[a-z.]+.[a-z]+$",
            ErrorMessage = "Invalid email.")]
        public string Email { get; set; }
    }
}
