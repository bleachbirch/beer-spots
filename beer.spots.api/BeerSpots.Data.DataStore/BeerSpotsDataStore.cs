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
            return Task.FromResult(new List<Spot>
            {
                new Spot
                {
                    Id = 1,
                    Name = "Колдырь-плейс",
                    Description = "Здесь ты можешь найти братишку, которого твоя мать сдала в детдом",
                    Сoordinate = new Coordinate
                    {
                        Latitude = 59.9114620m,
                        Longitude = 30.3144620m
                    }
                }
            }.AsQueryable());
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