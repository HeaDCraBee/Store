using Store.Business.Store.DTO;
using Store.Domain;

namespace Store.Business.Mappers
{
    public static partial class Mapper
    {
        public static ProductsToSuppliersDTO MapToDto(this ProductsToSuppliers productToSupplier)
        {
            return _mapper.Map<ProductsToSuppliersDTO>(productToSupplier);
        }

        public static ProductsToSuppliers MapToDomain(this ProductsToSuppliersDTO productToSupplierDto)
        {
            return _mapper.Map<ProductsToSuppliers>(productToSupplierDto);
        }
    }
}
