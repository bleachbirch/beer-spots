using BeerSpots.Data.Entities;

namespace BeerSpots.App
{
    /// <summary>
    /// Interface for interaction with database
    /// </summary>
    public interface IDataStore
    {
        /// <summary>
        /// Returns IQueryable object with spot's entities
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<Spot>> GetAllAsync();

        /// <summary>
        /// Get spot by id or null, if not found
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<Spot?> GetAsync(string id);

        /// <summary>
        /// Returns spot by coordinate or null
        /// </summary>
        /// <param name="coordinate"></param>
        /// <returns></returns>
        Task<Spot?> GetAsync(Coordinate coordinate);

        /// <summary>
        /// Adds new spot to store
        /// </summary>
        /// <param name="spot"></param>
        /// <returns></returns>
        Task AddAsync(Spot spot);

        /// <summary>
        /// Updates exists spot
        /// </summary>
        /// <param name="spot"></param>
        /// <returns></returns>
        Task UpdateAsync(Spot spot);

        /// <summary>
        /// Deletes spot by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task DeleteAsync(string id);

        /// <summary>
        /// Deletes spot by coordinate
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task DeleteAsync(Coordinate coordinate);
    }
}
