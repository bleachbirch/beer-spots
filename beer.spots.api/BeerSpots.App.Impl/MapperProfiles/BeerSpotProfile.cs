using AutoMapper;
using BeerSpots.App.Models;
using BeerSpots.Data.Entities;

namespace BeerSpots.App.Impl.MapperProfiles
{
    internal class BeerSpotProfile : Profile
    {
        public BeerSpotProfile()
        {
            CreateMap<SpotDto, Spot>()
                .ForMember(m => m.Id, opt => opt.Ignore())
                .ReverseMap();

            CreateMap<CoordinateDto, Coordinate>()
                .ReverseMap();

            CreateMap<CommentDto, Comment>()
                .ReverseMap();
        }
    }
}
