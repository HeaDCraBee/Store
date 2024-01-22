using System;
using System.Collections.Generic;

namespace Store.Business.Store.DTO
{
    public class ProductsDTO
    {
        public int ProductId { get; set; }

        public string Name { get; set; }

        public int Quantity { get; set; }

        public int CategoryId { get; set; }

        public DateTimeOffset CreatedAt { get; set; }

        public decimal Price { get; set; }

        public bool IsDeleted { get; set; }

        public List<int> SupplierIds { get; set; }
    }
}
