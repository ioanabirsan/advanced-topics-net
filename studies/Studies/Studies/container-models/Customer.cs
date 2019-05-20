using System.ComponentModel.DataAnnotations;
using Studies.api;

namespace Studies
{
    [MetadataType(typeof(CustomerMetadata))]
    public partial class Customer : IObjectWithState
    {
        public State State { get; set; }
    }
}
