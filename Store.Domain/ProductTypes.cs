using System.ComponentModel.DataAnnotations;

namespace Store.Domain
{
    public class ProductTypes
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }
    }
}
