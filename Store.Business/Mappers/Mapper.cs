using AutoMapper;
using Store.Business.Store.DTO;
using Store.Domain;

namespace Store.Business.Mappers
{
    public static partial class Mapper
    {
        private static readonly IMapper _mapper;

        static Mapper()
        {
            if (_mapper == null)
            {
                var config = new MapperConfiguration(
                    cfg =>
                    {
                        cfg.CreateMap<Products, ProductsDTO>();
                        cfg.CreateMap<ProductsDTO, Products>()
                            .ForSourceMember(source => source.SupplierIds, opt => opt.DoNotValidate());

                        cfg.CreateMap<Services, ServicesDTO>();
                        cfg.CreateMap<ServicesDTO, Services>()
                         .ForSourceMember(source => source.SupplierIds, opt => opt.DoNotValidate());

                        cfg.CreateMap<Suppliers, SuppliersDTO>();
                        cfg.CreateMap<SuppliersDTO, Suppliers>()
                         .ForSourceMember(source => source.ServiceIds, opt => opt.DoNotValidate())
                         .ForSourceMember(source => source.ProductIds, opt => opt.DoNotValidate());

                        cfg.CreateMap<ProductsToSuppliers, ProductsToSuppliersDTO>();
                        cfg.CreateMap<ProductsToSuppliersDTO, ProductsToSuppliers>();

                        cfg.CreateMap<ServicesToSuppliers, ServicesToSuppliersDTO>();
                        cfg.CreateMap<ServicesToSuppliersDTO, ServicesToSuppliers>();

                        cfg.CreateMap<ProductTypes, ProductTypesDTO>();
                        cfg.CreateMap<ProductTypesDTO, ProductTypes>();

                        cfg.CreateMap<ServiceTypes, ServiceTypesDTO>();
                        cfg.CreateMap<ServiceTypesDTO, ServiceTypes>();
                    });

                _mapper = config.CreateMapper();
            }
        }
    }
}