using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Store.Domain
{
    public class Services
    {
        [Key]
        public int ServiseId { get; set; }

        public string Name { get; set; }

        [ForeignKey("ServiceTypes")]
        public int CategoryId { get; set; }

        public DateTime CreatedAt { get; set; }

        public decimal Price { get; set; }

        public bool IsDeleted { get; set; }
                
    }
}
