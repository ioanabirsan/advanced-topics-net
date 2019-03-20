using System.ComponentModel.DataAnnotations;

namespace CarService.Models.Sasiu
{
    public class SasiuMetadata
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(2, MinimumLength = 2, ErrorMessage = "CodSasiu must be 2 characters")]
        public string CodSasiu { get; set; }

        [Required]
        [MaxLength(25)]
        public string Denumire { get; set; }
    }
}
