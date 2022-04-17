using BeerSpots.App.Impl.Extensions;
using BeerSpots.Data.DataStore.Extensions;
using Microsoft.Extensions.DependencyInjection;

namespace BeerSpots.App.DependencyInjection.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddBeerSpotsApp(this IServiceCollection services)
        {
            return services
                .AddBeerSpotsDataStore()
                .AddBeerSpotsAppImplementation();
        }
    }
}
