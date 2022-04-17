using BeerSpots.App.Impl;
using BeerSpots.App.MapperProfiles;
using Microsoft.Extensions.DependencyInjection;

namespace BeerSpots.App.Extensions
{
    public static class ServiceProviderExtenions
    {
        public static IServiceCollection AddBeerSpotsApp(this IServiceCollection services)
        {
            return services
                .AddAutoMapper(typeof(BeerSpotProfile))
                .AddSingleton<ISpotInteractor, BeerSpotInteractor>();
        }
    }
}
