using Store.Business.Store.DTO;
using Store.Domain;

namespace Store.Business.Mappers
{
    public static partial class Mapper
    {
        public static ServicesDTO MapToDto(this Services service)
        {
            return _mapper.Map<ServicesDTO>(service);
        }

        public static Services MapToDomain(this ServicesDTO serviceDto)
        {
            return _mapper.Map<Services>(serviceDto);
        }
    }
}
