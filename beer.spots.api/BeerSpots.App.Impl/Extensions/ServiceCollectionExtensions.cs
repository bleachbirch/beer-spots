using AutoMapper;
using BeerSpots.App.Impl.MapperProfiles;
using Microsoft.Extensions.DependencyInjection;

namespace BeerSpots.App.Impl.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddBeerSpotsAppImplementation(this IServiceCollection services)
        {
            return services
                .AddAutoMapper(typeof(BeerSpotProfile))
                .AddSingleton<ISpotInteractor, BeerSpotInteractor>(provider =>
                {
                    var mapper = provider.GetRequiredService<IMapper>();
                    var dataStore = provider.GetRequiredService<IDataStore>();
                    return new BeerSpotInteractor(dataStore, mapper);
                });
        }
    }
}
