﻿using CQRSandMediatRinOnionArchitecture.Application.Features.Brands.Commands.Create;
using CQRSandMediatRinOnionArchitecture.Application.Features.Brands.Queries.GetAllCached;
using CQRSandMediatRinOnionArchitecture.Application.Features.Brands.Queries.GetById;
using CQRSandMediatRinOnionArchitecture.Domain.Entities.Catalog;
using AutoMapper;

namespace CQRSandMediatRinOnionArchitecture.Application.Mappings
{
    internal class BrandProfile : Profile
    {
        public BrandProfile()
        {
            CreateMap<CreateBrandCommand, Brand>().ReverseMap();
            CreateMap<GetBrandByIdResponse, Brand>().ReverseMap();
            CreateMap<GetAllBrandsCachedResponse, Brand>().ReverseMap();
        }
    }
}