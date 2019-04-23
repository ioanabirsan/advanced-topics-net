using System.ComponentModel.DataAnnotations.Schema;

namespace Studies.models
{
    [Table("eCommerce", Schema = "BazaDeDate")]
    public class eCommerce : Business
    {
        public string URL { get; set; }
    }
}