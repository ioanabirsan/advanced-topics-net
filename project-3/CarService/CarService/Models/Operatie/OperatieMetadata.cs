using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CarService
{
    public class OperatieMetadata
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(256)]
        public string Denumire { get; set; }

        [Required]
        public decimal TimpExecutie { get; set; }

        [Required]
        [Key, ForeignKey("DetaliuComanda")]
        public int DetaliuComandaId { get; set; }
    }
}
