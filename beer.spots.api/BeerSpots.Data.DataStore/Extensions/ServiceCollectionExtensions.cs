using BeerSpots.App;
using BeerSpots.Data.DataStore.Configuration;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace BeerSpots.Data.DataStore.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddBeerSpotsDataStore(this IServiceCollection services, IConfigurationSection dbConfiguration)
        {
            return services
                .Configure<DataStoreConfiguration>(dbConfiguration)
                .AddTransient<IDataStore, BeerSpotsDataStore>();
        }
    }
}
