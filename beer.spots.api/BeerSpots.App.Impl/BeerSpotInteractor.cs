using AutoMapper;
using BeerSpots.App.Models;
using BeerSpots.Data.Entities;

namespace BeerSpots.App.Impl
{
    internal class BeerSpotInteractor : ISpotInteractor
    {
        private readonly IDataStore _dataStore;
        private readonly IMapper _mapper;

        public BeerSpotInteractor(IDataStore dataStore, IMapper mapper)
        {
            _dataStore = dataStore;
            _mapper = mapper;
        }

        public async Task CreateAsync(SpotDto newSpot)
        {
            var spot = _mapper.Map<Spot>(newSpot);
            await _dataStore.AddAsync(spot);
        }

        public async Task DeleteAsync(SpotDto spot)
        {
            var coordinate = _mapper.Map<Coordinate>(spot.Сoordinate);
            await _dataStore.DeleteAsync(coordinate);
        }

        public async Task EditAsync(SpotDto spot)
        {
            var entity = _mapper.Map<Spot>(spot);
            await _dataStore.UpdateAsync(entity);
        }

        public async Task<IEnumerable<SpotDto?>> GetAsync(CoordinateDto coordinate, int radius)
        {
            var query = await _dataStore.GetAllAsync();
            // TODO: radius limit
            return query.ToList().Select(x => _mapper.Map<SpotDto>(x));
        }

        public async Task<SpotDto?> GetSpotAsync(CoordinateDto coordinate)
        {
            var coord = _mapper.Map<Coordinate>(coordinate);
            var spot = await _dataStore.GetAsync(coord);
            return spot is null ? null : _mapper.Map<SpotDto>(spot);
        }
    }
}
