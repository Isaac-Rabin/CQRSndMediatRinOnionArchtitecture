using CQRSandMediatRinOnionArchitecture.Infrastructure.Identity.Models;
using CQRSandMediatRinOnionArchitecture.Web.Areas.Admin.Models;
using AutoMapper;

namespace CQRSandMediatRinOnionArchitecture.Web.Areas.Admin.Mappings
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<ApplicationUser, UserViewModel>().ReverseMap();
        }
    }
}