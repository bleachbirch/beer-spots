namespace BeerSpots.Data.Entities
{
    /// <summary>
    /// Spot's coordinate
    /// </summary>
    public class Coordinate
    {
        public long Id { get; set; }

        /// <summary>
        /// Which spot is associated with this
        /// </summary>
        public Spot Spot { get; set; }
    }
}