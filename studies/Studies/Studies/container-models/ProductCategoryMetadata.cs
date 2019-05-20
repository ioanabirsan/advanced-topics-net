using System.ComponentModel.DataAnnotations;

namespace Studies
{
    public class ProductCategoryMetadata
    {
        [Key]
        public int Id { get; set; }

        public string CategoryName { get; set; }
    }
}
