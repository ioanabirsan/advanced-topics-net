using System.ComponentModel.DataAnnotations;
using Studies.api;

namespace Studies
{
    [MetadataType(typeof(CustomerTypeMetadata))]
    public partial class CustomerType : IObjectWithState
    {
        public State State { get; set; }
    }
}