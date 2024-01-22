using Store.Business.Store.DTO;
using Store.Domain;

namespace Store.Business.Mappers
{
    public static partial class Mapper
    {
        public static ProductsDTO MapToDto(this Products product)
        {
            return _mapper.Map<ProductsDTO>(product);
        }

        public static Products MapToDomain(this ProductsDTO productDto)
        {
            return _mapper.Map<Products>(productDto);
        }
    }
}
