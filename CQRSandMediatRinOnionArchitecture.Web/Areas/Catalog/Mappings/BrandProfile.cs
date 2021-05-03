using CQRSandMediatRinOnionArchitecture.Application.Features.Brands.Commands.Create;
using CQRSandMediatRinOnionArchitecture.Application.Features.Brands.Commands.Update;
using CQRSandMediatRinOnionArchitecture.Application.Features.Brands.Queries.GetAllCached;
using CQRSandMediatRinOnionArchitecture.Application.Features.Brands.Queries.GetById;
using CQRSandMediatRinOnionArchitecture.Web.Areas.Catalog.Models;
using AutoMapper;

namespace CQRSandMediatRinOnionArchitecture.Web.Areas.Catalog.Mappings
{
    internal class BrandProfile : Profile
    {
        public BrandProfile()
        {
            CreateMap<GetAllBrandsCachedResponse, BrandViewModel>().ReverseMap();
            CreateMap<GetBrandByIdResponse, BrandViewModel>().ReverseMap();
            CreateMap<CreateBrandCommand, BrandViewModel>().ReverseMap();
            CreateMap<UpdateBrandCommand, BrandViewModel>().ReverseMap();
        }
    }
}