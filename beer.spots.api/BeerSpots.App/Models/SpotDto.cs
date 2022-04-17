namespace BeerSpots.App.Models
{
    public class SpotDto
    {
        /// <summary>
        /// Short description of place
        /// </summary>
        public string Name { get; set; } = "noname";

        /// <summary>
        /// Where is it
        /// </summary>
        public CoordinateDto Coordinate { get; set; }

        /// <summary>
        /// Full description
        /// </summary>
        public string? Description { get; set; }

        /// <summary>
        /// TODO
        /// </summary>
        //public CommentDto[]? Comments { get; set; }

    }
}
