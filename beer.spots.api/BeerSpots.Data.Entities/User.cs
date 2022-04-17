namespace BeerSpots.Data.Entities
{
    /// <summary>
    /// Member of beer spot society
    /// </summary>
    public class User
    {
        public int Id { get; set; }

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
