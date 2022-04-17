namespace BeerSpots.Data.Entities
{
    /// <summary>
    /// Spot's coordinate
    /// </summary>
    public class Coordinate
    {
        public long Id { get; set; }

        /// <summary>
        /// Latitude
        /// TODO: type decimal(8, 6)
        /// </summary>
        public decimal Latitude { get; set; }

        /// <summary>
        /// Longitude
        /// TODO: type decimal(9, 6)
        /// </summary>
        public decimal Longitude { get; set; }

        /// <summary>
        /// Which spot is associated with this
        /// </summary>
        public Spot Spot { get; set; }
    }
}