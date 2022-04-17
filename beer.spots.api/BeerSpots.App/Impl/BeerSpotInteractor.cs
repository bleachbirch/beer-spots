using BeerSpots.App.Models;

namespace BeerSpots.App.Impl
{
    internal class BeerSpotInteractor : ISpotInteractor
    {
        public Task CreateAsync(SpotDto newSpot)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(SpotDto spot)
        {
            throw new NotImplementedException();
        }

        public Task EditAsync(SpotDto spot)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<SpotDto?>> GetAsync(CoordinateDto coordinate, int radius)
        {
            throw new NotImplementedException();
        }

        public Task<SpotDto?> GetSpotAsync(CoordinateDto coordinate)
        {
            throw new NotImplementedException();
        }
    }
}
