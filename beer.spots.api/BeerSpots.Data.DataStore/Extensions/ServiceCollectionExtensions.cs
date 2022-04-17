using BeerSpots.App;
using Microsoft.Extensions.DependencyInjection;

namespace BeerSpots.Data.DataStore.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddBeerSpotsDataStore(this IServiceCollection services)
        {
            return services.AddScoped<IDataStore, BeerSpotsDataStore>();
        }
    }
}
