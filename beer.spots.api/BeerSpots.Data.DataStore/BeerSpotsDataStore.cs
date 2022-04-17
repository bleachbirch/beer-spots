using BeerSpots.App;
using BeerSpots.Data.DataStore.Configuration;
using BeerSpots.Data.Entities;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace BeerSpots.Data.DataStore
{
    internal class BeerSpotsDataStore : IDataStore
    {
        private readonly IMongoCollection<Spot> _spots;
        public BeerSpotsDataStore(IOptions<DataStoreConfiguration> options)
        {
            var mongoClient = new MongoClient(options.Value.ConnectionString);

            var mongoDatabase = mongoClient.GetDatabase(options.Value.DatabaseName);

            _spots = mongoDatabase.GetCollection<Spot>(options.Value.SpotsCollectionName);
        }

        public async Task AddAsync(Spot spot)
        {
            var isExists = _spots.Find(x => x.Coordinate.Equals(spot.Coordinate)) is not null;
            if (isExists) throw new Exception("Spot already exists.");
            await _spots.InsertOneAsync(spot);
        }
            

        public async Task DeleteAsync(string id) => await _spots.DeleteOneAsync(x => x.Id == id);

        public async Task DeleteAsync(Coordinate coordinate) => await _spots.DeleteOneAsync(x => x.Coordinate.Equals(coordinate));

        public async Task<IEnumerable<Spot>> GetAllAsync() => await _spots.Find(_ => true).ToListAsync();

        public async Task<Spot?> GetAsync(string id) => await _spots.Find(x => x.Id == id).FirstOrDefaultAsync();

        public async Task<Spot?> GetAsync(Coordinate coordinate) =>
            await _spots.Find(x => x.Coordinate.Equals(coordinate)).FirstOrDefaultAsync();

        public async Task UpdateAsync(Spot spot) => await _spots.ReplaceOneAsync(x => x.Id == spot.Id, spot);
    }
}