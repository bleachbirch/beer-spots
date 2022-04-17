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

        public async Task DeleteAsync(CoordinateDto coordinate)
        {
            var coord = _mapper.Map<Coordinate>(coordinate);
            await _dataStore.DeleteAsync(coord);
        }

        public async Task EditAsync(SpotDto spot)
        {
            var entity = _mapper.Map<Spot>(spot);
            //лютый костыль, потом убрать
            entity.Id = entity.Id ?? (await _dataStore.GetAsync(entity.Coordinate))?.Id;
            await _dataStore.UpdateAsync(entity);
        }

        public async Task<IEnumerable<SpotDto>> GetAllAsync()
        {
            var result = await _dataStore.GetAllAsync();
            return result.Select(x => _mapper.Map<SpotDto>(x));
        }

        public async Task<IEnumerable<SpotDto?>> GetAsync(CoordinateDto coordinate, int radius)
        {
            var result = await _dataStore.GetAllAsync();
            // TODO: radius limit
            return result.Select(x => _mapper.Map<SpotDto>(x));
        }

        public async Task<SpotDto?> GetAsync(CoordinateDto coordinate)
        {
            var coord = _mapper.Map<Coordinate>(coordinate);
            var spot = await _dataStore.GetAsync(coord);
            return spot is null ? null : _mapper.Map<SpotDto>(spot);
        }
    }
}
