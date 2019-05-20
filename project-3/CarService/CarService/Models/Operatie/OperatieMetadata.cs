using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace CarService
{
    [DataContract(IsReference = true)]
    public class OperatieMetadata
    {
        [Key]
        [DataMember]
        public int Id { get; set; }

        [Required]
        [MaxLength(256)]
        [DataMember]
        public string Denumire { get; set; }

        [Required]
        [DataMember]
        public decimal TimpExecutie { get; set; }
    }
}
