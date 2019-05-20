using System.ComponentModel.DataAnnotations;
using Studies.models;

namespace Studies
{
    [MetadataType(typeof(Model1ContainerMetadata))]
    public partial class Model1ContainerContainer
    {
        public State State { get; set; }
    }
}