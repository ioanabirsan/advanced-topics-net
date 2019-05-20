using System.ComponentModel.DataAnnotations;
using Studies.api;
using Studies.models;

namespace Studies
{
    public class ProductMetadata : IObjectWithState
    {
        [Key]
        public int Id { get; set; }

        public string ProductName { get; set; }

        public State State { get; set; }
    }
}
