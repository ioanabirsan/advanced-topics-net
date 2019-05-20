using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Studies
{
    public class CustomerMetadata
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        [Required]
        [Key, ForeignKey("CustomerType")]
        public int CustomerTypeId { get; set; }

        [Required]
        [Key, ForeignKey("CustomerEmail")]
        public int CustomerEmailId { get; set; }
    }
}
