using BeerSpots.Data.Entities;

namespace BeerSpots.App.Impl
{
    internal class BeerSpotInteractor : ISpotInteractor
    {
        public Task CreateAsync(Spot newSpot)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(Spot spot)
        {
            throw new NotImplementedException();
        }

        public Task EditAsync(Spot spot)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Spot?>> GetAsync(Coordinate coordinate, int radius)
        {
            throw new NotImplementedException();
        }

        public Task<Spot?> GetSpotAsync(Coordinate coordinate)
        {
            throw new NotImplementedException();
        }
    }
}
