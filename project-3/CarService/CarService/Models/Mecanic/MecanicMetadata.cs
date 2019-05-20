using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace CarService
{
    [DataContract(IsReference = true)]
    public class MecanicMetadata
    {
        [Key]
        [DataMember]
        public int Id { get; set; }

        [Required]
        [MaxLength(15)]
        [DataMember]
        public string Nume { get; set; }

        [Required]
        [MaxLength(15)]
        [DataMember]
        public string Prenume { get; set; }
    }
}
