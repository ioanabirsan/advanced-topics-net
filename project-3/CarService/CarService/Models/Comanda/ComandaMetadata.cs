using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CarService.Models.Comanda
{
    public class ComandaMetadata
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        public System.DateTime DataSystem { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public System.DateTime DataProgramare { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public System.DateTime DataFinalizare { get; set; }

        [Required]
        public int KmBord { get; set; }

        [Required]
        [MaxLength(1024)]
        public string Descriere { get; set; }

        [Required]
//        [RegularExpression(@"\d+(\.\d{1,2})?", ErrorMessage = "Invalid valoare piese")]
        public decimal ValoarePiese { get; set; }

//        [Required]
        public StareComanda StareComanda { get; set; }

        [Required]
        [Key, ForeignKey("Auto")]
        public int AutoId { get; set; }

        [Required]
        [Key, ForeignKey("Client")]
        public int ClientId { get; set; }
    }
}
