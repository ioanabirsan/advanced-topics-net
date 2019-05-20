using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Studies
{
    public class CustomerEmailMetadata
    {
        [Key]
        public int Id { get; set; }

        public string Email { get; set; }

        [Required]
        [Key, ForeignKey("Customer")]
        public int CustomerId { get; set; }
    }
}
