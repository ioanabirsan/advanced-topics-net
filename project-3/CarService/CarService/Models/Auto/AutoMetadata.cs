using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CarService.Models.Auto
{
    public class AutoMetadata
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [RegularExpression(@"^([A-Z]{2}[0-9]{3}[A-Z]{3})|([A-Z]{2}[0-9]{8})$",
            ErrorMessage = "Format is  <xx nnn yyy> or <xxnnnnnnnn> where x,y - chars A-Z, n - digit.")]
        public string NumarAuto { get; set; }

        [Required]
        [MaxLength(25)]
        public string SerieSasiu { get; set; }

        [Required]
        [Key, ForeignKey("Sasiu")]
        public int SasiuId { get; set; }

        [Required]
        [Key, ForeignKey("Client")]
        public int ClientId { get; set; }

    }
}
