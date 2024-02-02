using AutoMapper;
using Contracts;
using SearchService.Models;

namespace SearchService;

public class MappingProfiles : Profile
{
    public MappingProfiles()
    {
        CreateMap<ActionCreated, Item>();
        CreateMap<AuctionUpdated, Item>();
    }
}
