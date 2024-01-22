namespace Store.Business.Store.DTO
{
    public class ServicesToSuppliersDTO
    {
        public int ServicesToSuppliersId { get; set; }

        public int ServiceId { get; set; }

        public int SupplierId { get; set; }

        public bool IsDeleted { get; set; }
    }
}
