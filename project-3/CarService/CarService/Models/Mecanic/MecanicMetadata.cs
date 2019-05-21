using System.Collections.Generic;
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

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        [DataMember]
        public virtual List<DetaliuComanda> DetaliiComenzi { get; set; }
    }
}
