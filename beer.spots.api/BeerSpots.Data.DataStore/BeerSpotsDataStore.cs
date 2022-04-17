using BeerSpots.App;
using BeerSpots.Data.Entities;

namespace BeerSpots.Data.DataStore
{
    internal class BeerSpotsDataStore : IDataStore
    {
        public Task AddAsync(Spot spot)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(long id)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(Coordinate coordinate)
        {
            throw new NotImplementedException();
        }

        public Task<IQueryable<Spot>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Spot?> GetAsync(long id)
        {
            throw new NotImplementedException();
        }

        public Task<Spot?> GetAsync(Coordinate coordinate)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Spot spot)
        {
            throw new NotImplementedException();
        }
    }
}