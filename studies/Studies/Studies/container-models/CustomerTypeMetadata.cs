using System.ComponentModel.DataAnnotations;

namespace Studies
{
    public class CustomerTypeMetadata
    {
        [Key]
        public int Id { get; set; }

        public string Description { get; set; }
    }
}
