using System.ComponentModel.DataAnnotations;
using Studies.api;

namespace Studies
{
    [MetadataType(typeof(ProductMetadata))]
    public partial class Product : IObjectWithState
    {
        public State State { get; set; }
    }
}
