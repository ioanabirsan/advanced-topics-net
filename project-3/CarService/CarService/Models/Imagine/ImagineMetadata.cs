using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CarService
{
    public class ImagineMetadata
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(15)]
        public string Titlu { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public System.DateTime Data { get; set; }

        [Required]
        public byte Foto { get; set; }

        [Required]
        [MaxLength(256)]
        public string Descriere { get; set; }
    }
}
