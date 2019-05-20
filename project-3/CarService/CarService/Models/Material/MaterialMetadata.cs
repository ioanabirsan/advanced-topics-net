using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace CarService
{
    [DataContract(IsReference = true)]
    public class MaterialMetadata
    {
        [Key]
        [DataMember]
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        [DataMember]
        public string Denumire { get; set; }

        [Required]
        [DataMember]
        public decimal Cantitate { get; set; }

        [Required]
        [DataMember]
        public decimal Pret { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        [DataMember]
        public System.DateTime DataAprovizionare { get; set; }
    }
}
