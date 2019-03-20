using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CarService.Models.Operatie
{
    public class OperatieMetadata
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(256)]
        public string Denumire { get; set; }

        [Required]
        [RegularExpression(@"\d+(\.\d{1,2})?", ErrorMessage = "Invalid timp executie")]
        public decimal TimpExecutie { get; set; }

        [Required]
        [Key, ForeignKey("DetaliuComanda")]
        public int DetaliuComandaId { get; set; }
    }
}
