using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CarService
{
    public class MaterialMetadata
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Denumire { get; set; }

        [Required]
        public decimal Cantitate { get; set; }

        [Required]
        public decimal Pret { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public System.DateTime DataAprovizionare { get; set; }

        [Required]
        [Key, ForeignKey("DetaliuComanda")]
        public int DetaliuComandaId { get; set; }
    }
}
