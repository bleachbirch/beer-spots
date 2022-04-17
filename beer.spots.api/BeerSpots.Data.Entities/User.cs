namespace BeerSpots.Data.Entities
{
    /// <summary>
    /// Member of beer spot society
    /// </summary>
    public class User
    {
        public string Id { get; set; }

        /// <summary>
        /// User name
        /// </summary>
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// Which beer user likes
        /// </summary>
        public string FavoriteBeer { get; set; } = string.Empty;
    }
}
