using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Store.Domain
{
    public class ProductsToSuppliers
    {
        [Key]
        public int ProductsToSuppliersId { get; set; }

        [ForeignKey("Products")]
        public int ProductId { get; set; }

        [ForeignKey("Suppliers")]
        public int SupplierId { get; set; }

        public bool IsDeleted { get; set; }
    }
}
