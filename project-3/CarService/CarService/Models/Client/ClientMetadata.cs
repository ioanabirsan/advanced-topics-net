using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace CarService
{

    [DataContract(IsReference = true)]
    public class ClientMetadata
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

        [Required]
        [MaxLength(50)]
        [DataMember]
        public string Adresa { get; set; }

        [Required]
        [MaxLength(10)]
        [DataMember]
        public string Localitate { get; set; }

        [Required]
        [MaxLength(10)]
        [DataMember]
        public string Judet { get; set; }

        [Required]
        [RegularExpression(@"^\d{13}$", 
            ErrorMessage = "Invalid phone number.")]
        [DataMember]
        public string Telefon { get; set; }
        
        [RegularExpression(@"^[a-zA-Z0-9_.-]+@[a-z.]+.[a-z]+$",
            ErrorMessage = "Invalid email.")]
        [DataMember]
        public string Email { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        [DataMember]
        public virtual List<Auto> Automobile { get; set; }
    }
}
    