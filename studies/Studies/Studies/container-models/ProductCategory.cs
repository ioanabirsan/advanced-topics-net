using System.ComponentModel.DataAnnotations;
using Studies.api;

namespace Studies
{
    [MetadataType(typeof(ProductCategoryMetadata))]
    public partial class ProductCategory : IObjectWithState
    {
        public State State { get; set; }
    }
}
