namespace BeerSpots.Data.DataStore.Configuration
{
    internal class DataStoreConfiguration
    {
        public string ConnectionString { get; set; } = null!;

        public string DatabaseName { get; set; } = null!;

        public string SpotsCollectionName { get; set; } = null!;
    }
}
