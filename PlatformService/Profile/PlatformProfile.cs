using PlatformService.Dtos;
using PlatformService.Models;

namespace PlatformService.Profile;

public class PlatformProfile : AutoMapper.Profile
{
    public PlatformProfile()
    {
        CreateMap<Platform, PlatformReadDto>();
        CreateMap<PlatformCreateDto, Platform>();
    }
}