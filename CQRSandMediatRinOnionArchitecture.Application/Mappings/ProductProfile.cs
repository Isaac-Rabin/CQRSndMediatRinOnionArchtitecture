using CQRSandMediatRinOnionArchitecture.Application.Features.Products.Commands.Create;
using CQRSandMediatRinOnionArchitecture.Application.Features.Products.Queries.GetAllCached;
using CQRSandMediatRinOnionArchitecture.Application.Features.Products.Queries.GetAllPaged;
using CQRSandMediatRinOnionArchitecture.Application.Features.Products.Queries.GetById;
using CQRSandMediatRinOnionArchitecture.Domain.Entities.Catalog;
using AutoMapper;

namespace CQRSandMediatRinOnionArchitecture.Application.Mappings
{
    internal class ProductProfile : Profile
    {
        public ProductProfile()
        {
            CreateMap<CreateProductCommand, Product>().ReverseMap();
            CreateMap<GetProductByIdResponse, Product>().ReverseMap();
            CreateMap<GetAllProductsCachedResponse, Product>().ReverseMap();
            CreateMap<GetAllProductsResponse, Product>().ReverseMap();
        }
    }
}