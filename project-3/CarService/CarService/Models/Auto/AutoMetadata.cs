using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace CarService.Models.Auto
{
    [DataContract(IsReference = true)]
    public class AutoMetadata
    {
        [Key]
        [DataMember]
        public int Id { get; set; }

        [Required]
        [RegularExpression(@"^([A-Z]{2}[0-9]{3}[A-Z]{3})|([A-Z]{2}[0-9]{8})$",
            ErrorMessage = "Format is  <xx nnn yyy> or <xxnnnnnnnn> where x,y - chars A-Z, n - digit.")]
        [DataMember]
        public string NumarAuto { get; set; }

        [Required]
        [MaxLength(25)]
        [DataMember]
        public string SerieSasiu { get; set; }

        [Required]
        [Key, ForeignKey("Sasiu")]
        [DataMember]
        public int SasiuId { get; set; }

        [Required]
        [Key, ForeignKey("Client")]
        [DataMember]
        public int ClientId { get; set; }

        [DataMember]
        public virtual Sasiu Sasiu { get; set; }

        [DataMember]
        public virtual Client Client { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        [DataMember]
        public virtual List<Comanda> Comenzi { get; set; }

    }
}
