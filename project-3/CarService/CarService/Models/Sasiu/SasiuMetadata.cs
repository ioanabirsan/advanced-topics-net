using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace CarService
{
    [DataContract(IsReference = true)]
    public class SasiuMetadata
    {
        [Key]
        [DataMember]
        public int Id { get; set; }

        [Required]
        [StringLength(2, MinimumLength = 2, ErrorMessage = "CodSasiu must be 2 characters")]
        [DataMember]
        public string CodSasiu { get; set; }

        [Required]
        [MaxLength(25)]
        [DataMember]
        public string Denumire { get; set; }
    }
}
