using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Store.Domain
{
    public class Products
    {
        [Key]
        public int ProductId { get; set; }

        public string Name { get; set; }

        public int Quantity { get; set; }

        [ForeignKey("ProductTypes")]
        public int CategoryId { get; set; }

        public DateTimeOffset CreatedAt { get; set; }

        public decimal Price { get; set; }

        public bool IsDeleted { get; set; }
    }
}
