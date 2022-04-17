namespace BeerSpots.Data.Entities
{
    /// <summary>
    /// Beer spot
    /// </summary>
    public class Spot
    {
        public long Id { get; set; }

        /// <summary>
        /// Short description of place
        /// </summary>
        public string Name { get; set; } = "noname";

        /// <summary>
        /// Where is it
        /// </summary>
        public Coordinate Сoordinate { get; set; }

        /// <summary>
        /// Full description
        /// </summary>
        public string? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Comment[]? Comments { get; set; }
    }
}