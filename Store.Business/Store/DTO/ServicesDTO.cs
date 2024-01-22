using System;
using System.Collections.Generic;

namespace Store.Business.Store.DTO
{
    public class ServicesDTO
    {
        public int ServiseId { get; set; }

        public string Name { get; set; }

        public int CategoryId { get; set; }

        public DateTime CreatedAt { get; set; }

        public decimal Price { get; set; }

        public bool IsDeleted { get; set; }

        public List<int> SupplierIds { get; set; }
    }
}
