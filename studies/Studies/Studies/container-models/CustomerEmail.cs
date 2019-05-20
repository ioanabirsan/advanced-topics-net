using System.ComponentModel.DataAnnotations;
using Studies.api;

namespace Studies
{
    [MetadataType(typeof(CustomerEmailMetadata))]
    public partial class CustomerEmail : IObjectWithState
    {
        public State State { get; set; }
    }
}
