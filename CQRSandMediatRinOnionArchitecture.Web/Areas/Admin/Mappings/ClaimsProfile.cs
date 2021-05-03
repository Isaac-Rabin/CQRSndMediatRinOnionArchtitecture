using CQRSandMediatRinOnionArchitecture.Web.Areas.Admin.Models;
using AutoMapper;
using System.Security.Claims;

namespace CQRSandMediatRinOnionArchitecture.Web.Areas.Admin.Mappings
{
    public class ClaimsProfile : Profile
    {
        public ClaimsProfile()
        {
            CreateMap<Claim, RoleClaimsViewModel>().ReverseMap();
        }
    }
}