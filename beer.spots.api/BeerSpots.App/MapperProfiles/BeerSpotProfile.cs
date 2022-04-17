using AutoMapper;
using BeerSpots.App.Models;
using BeerSpots.Data.Entities;

namespace BeerSpots.App.MapperProfiles
{
    internal class BeerSpotProfile : Profile
    {
        public BeerSpotProfile()
        {
            CreateMap<SpotDto, Spot>()
                .ForMember(m => m.Id, opt => opt.Ignore());

            CreateMap<CoordinateDto, Coordinate>()
                .ForMember(m => m.Id, opt => opt.Ignore());

            CreateMap<CommentDto, Comment>();
        }
    }
}
