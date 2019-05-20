using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace CarService
{
    [DataContract(IsReference = true)]
    public class DetaliuComandaMetadata
    {
        [Key]
        [DataMember]
        public int Id { get; set; }

        [Required]
        [Key, ForeignKey("DetaliuComanda")]
        [DataMember]
        public int ComandaId { get; set; }
    }
}
