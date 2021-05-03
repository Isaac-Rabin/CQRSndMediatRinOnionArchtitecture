using CQRSandMediatRinOnionArchitecture.Application.Features.Products.Commands.Create;
using CQRSandMediatRinOnionArchitecture.Application.Features.Products.Commands.Update;
using CQRSandMediatRinOnionArchitecture.Application.Features.Products.Queries.GetAllCached;
using CQRSandMediatRinOnionArchitecture.Application.Features.Products.Queries.GetById;
using CQRSandMediatRinOnionArchitecture.Web.Areas.Catalog.Models;
using AutoMapper;

namespace CQRSandMediatRinOnionArchitecture.Web.Areas.Catalog.Mappings
{
    internal class ProductProfile : Profile
    {
        public ProductProfile()
        {
            CreateMap<GetAllProductsCachedResponse, ProductViewModel>().ReverseMap();
            CreateMap<GetProductByIdResponse, ProductViewModel>().ReverseMap();
            CreateMap<CreateProductCommand, ProductViewModel>().ReverseMap();
            CreateMap<UpdateProductCommand, ProductViewModel>().ReverseMap();
        }
    }
}