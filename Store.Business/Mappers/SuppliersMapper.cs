using Store.Business.Store.DTO;
using Store.Domain;

namespace Store.Business.Mappers
{
    public static partial class Mapper
    {
        public static SuppliersDTO MapToDto(this Suppliers supplier)
        {
            return _mapper.Map<SuppliersDTO>(supplier);
        }

        public static Suppliers MapToDomain(this SuppliersDTO supplierDto)
        {
            return _mapper.Map<Suppliers>(supplierDto);
        }
    }
}
