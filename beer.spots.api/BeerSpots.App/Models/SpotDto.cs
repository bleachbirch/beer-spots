namespace BeerSpots.App.Models
{
    public class SpotDto
    {
        public long Id { get; set; }

        /// <summary>
        /// Short description of place
        /// </summary>
        public string Name { get; set; } = "noname";

        /// <summary>
        /// Where is it
        /// </summary>
        public CoordinateDto Сoordinate { get; set; }

        /// <summary>
        /// Full description
        /// </summary>
        public string? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public CommentDto[]? Comments { get; set; }

    }
}
