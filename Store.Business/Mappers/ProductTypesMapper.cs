using Store.Business.Store.DTO;
using Store.Domain;

namespace Store.Business.Mappers
{
    public static partial class Mapper
    {
        public static ProductTypesDTO MapToDto(this ProductTypes productType)
        {
            return _mapper.Map<ProductTypesDTO>(productType);
        }

        public static ProductTypes MapToDomain(this ProductTypesDTO productTypeDto)
        {
            return _mapper.Map<ProductTypes>(productTypeDto);
        }
    }
}
