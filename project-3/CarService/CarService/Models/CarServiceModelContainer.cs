using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace CarService
{
    [MetadataType(typeof(CarServiceModelContainerMetadata))]
    public partial class CarServiceModelContainer : DbContext
    {
    }
}
