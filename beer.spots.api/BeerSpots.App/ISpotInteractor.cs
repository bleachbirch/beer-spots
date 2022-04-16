using BeerSpots.Data.Entities;

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
        Task<IEnumerable<Spot?>> GetAsync(Coordinate coordinate, int radius);

        /// <summary>
        /// Returns one spot by his coordinate. Return null, if spot is not founded.
        /// </summary>
        /// <param name="coordinate"></param>
        /// <returns></returns>
        Task<Spot?> GetSpotAsync(Coordinate coordinate);

        /// <summary>
        /// Creates spot
        /// </summary>
        /// <param name="newSpot"></param>
        /// <returns></returns>
        Task CreateAsync(Spot newSpot);

        /// <summary>
        /// Edites spot
        /// </summary>
        /// <param name="spot"></param>
        /// <returns></returns>
        Task EditAsync(Spot spot);

        /// <summary>
        /// Deletes spot
        /// </summary>
        /// <param name="spot"></param>
        /// <returns></returns>
        Task DeleteAsync(Spot spot);
    }
}
