using BeerSpots.App.Models;

namespace BeerSpots.App
{
    /// <summary>
    /// Interface of app
    /// </summary>
    public interface ISpotInteractor
    {
        /// <summary>
        /// Returns nearest spots in specified radius. Returns null, if spots are not founded.
        /// </summary>
        /// <param name="coordinate"></param>
        /// <param name="radius"></param>
        /// <returns></returns>
        Task<IEnumerable<SpotDto?>> GetAsync(CoordinateDto coordinate, int radius);

        /// <summary>
        /// Returns one spot by his coordinate. Return null, if spot is not founded.
        /// </summary>
        /// <param name="coordinate"></param>
        /// <returns></returns>
        Task<SpotDto?> GetSpotAsync(CoordinateDto coordinate);

        /// <summary>
        /// Creates spot
        /// </summary>
        /// <param name="newSpot"></param>
        /// <returns></returns>
        Task CreateAsync(SpotDto newSpot);

        /// <summary>
        /// Edites spot
        /// </summary>
        /// <param name="spot"></param>
        /// <returns></returns>
        Task EditAsync(SpotDto spot);

        /// <summary>
        /// Deletes spot
        /// </summary>
        /// <param name="spot"></param>
        /// <returns></returns>
        Task DeleteAsync(SpotDto spot);
    }
}
