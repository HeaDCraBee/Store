namespace Store.Business.Store.DTO
{
    public class ProductsToSuppliersDTO
    {
        public int ProductsToSuppliersId { get; set; }

        public int ProductId { get; set; }

        public int SupplierId { get; set; }

        public bool IsDeleted { get; set; }
    }
}
