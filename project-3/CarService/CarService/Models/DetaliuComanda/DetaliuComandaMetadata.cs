using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CarService
{
    public class DetaliuComandaMetadata
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Key, ForeignKey("DetaliuComanda")]
        public int ComandaId { get; set; }
    }
}
