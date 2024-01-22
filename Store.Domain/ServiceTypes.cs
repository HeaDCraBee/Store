using System.ComponentModel.DataAnnotations;

namespace Store.Domain
{
    public class ServiceTypes
    {
        [Key]
        public int Id { get; set; } 

        public string Name { get; set; }
    }
}
