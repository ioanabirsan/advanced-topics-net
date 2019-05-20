using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace CarService
{
    [DataContract(IsReference = true)]
    public class ImagineMetadata
    {
        [Key]
        [DataMember]
        public int Id { get; set; }

        [Required]
        [MaxLength(15)]
        [DataMember]
        public string Titlu { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        [DataMember]
        public System.DateTime Data { get; set; }

        [Required]
        [DataMember]
        public byte[] Foto { get; set; }

        [Required]
        [MaxLength(256)]
        [DataMember]
        public string Descriere { get; set; }
    }
}
