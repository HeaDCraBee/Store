using Store.Business.Store.DTO;
using Store.Domain;

namespace Store.Business.Mappers
{
    public static partial class Mapper
    {
        public static ServicesToSuppliersDTO MapToDto(this ServicesToSuppliers servicesToSupplier)
        {
            return _mapper.Map<ServicesToSuppliersDTO>(servicesToSupplier);
        }

        public static ServicesToSuppliers MapToDomain(this ServicesToSuppliersDTO servicesToSupplierDto)
        {
            return _mapper.Map<ServicesToSuppliers>(servicesToSupplierDto);
        }
    }
}
