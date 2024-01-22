using System;
using System.ComponentModel.DataAnnotations;

namespace Store.Domain
{
    public class Suppliers
    {
        [Key]
        public int SupplierId { get; set; }

        public string Name { get; set; }

        public DateTime CreatedAt { get; set; }

        public bool IsDeleted { get; set; }
    }
}
