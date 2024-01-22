using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Store.Domain
{
    public class ServicesToSuppliers
    {
        [Key]
        public int ServicesToSuppliersId { get; set; }

        [ForeignKey("Services")]
        public int ServiceId { get; set; }

        [ForeignKey("Suppliers")]
        public int SupplierId { get; set; }

        public bool IsDeleted { get; set; }
    }
}
