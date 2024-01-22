using System;
using System.Collections.Generic;

namespace Store.Business.Store.DTO
{
    public class SuppliersDTO
    { 
        public int SupplierId { get; set; }

        public string Name { get; set; }

        public DateTime CreatedAt { get; set; }

        public bool IsDeleted { get; set; }

        public List<int> ProductIds { get; set; }

        public List<int> ServiceIds { get; set; }
    }
}
