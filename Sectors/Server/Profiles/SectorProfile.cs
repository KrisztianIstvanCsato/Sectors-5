using AutoMapper;
using Sectors.Shared;
using Sectors.Shared.Dtos;
using Sectors.Shared.Models;

namespace Sectors.Server.Profiles
{
    public class SectorProfile : Profile
    {
        public SectorProfile()
        {
            CreateMap<Sector, SectorDto>();
            CreateMap<User, UserDto>().ReverseMap();
            CreateMap<UserSector, UserSectorDto>().ReverseMap();
        }
    }
}
