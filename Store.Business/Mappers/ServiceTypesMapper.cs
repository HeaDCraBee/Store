using Store.Business.Store.DTO;
using Store.Domain;

namespace Store.Business.Mappers
{
    public static partial class Mapper
    {
        public static ServiceTypesDTO MapToDto(this ServiceTypes serviceType)
        {
            return _mapper.Map<ServiceTypesDTO>(serviceType);
        }

        public static ServiceTypes MapToDomain(this ServiceTypesDTO serviceTypeDto)
        {
            return _mapper.Map<ServiceTypes>(serviceTypeDto);
        }
    }
}
