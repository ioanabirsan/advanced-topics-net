using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace CarService
{
    [DataContract(IsReference = true)]
    public class ComandaMetadata
    {
        [Key]
        [DataMember]
        public int Id { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        [DataMember]
        public System.DateTime DataSystem { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        [DataMember]
        public System.DateTime DataProgramare { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        [DataMember]
        public System.DateTime DataFinalizare { get; set; }

        [Required]
        [DataMember]
        public int KmBord { get; set; }

        [Required]
        [MaxLength(1024)]
        [DataMember]
        public string Descriere { get; set; }
        
        [DataMember]
        public decimal ValoarePiese { get; set; }

        [Required]
        [DataMember]
        public StareComanda StareComanda { get; set; }

        [Required]
        [DataMember]
        [Key, ForeignKey("Auto")]
        public int AutoId { get; set; }
    }
}
