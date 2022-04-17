namespace BeerSpots.Data.Entities
{
    /// <summary>
    /// Comment about beer spot
    /// </summary>
    public class Comment
    {
        /// <summary>
        /// Content of comment
        /// </summary>
        public string Content { get; set; } = string.Empty;

        /// <summary>
        /// Who left a comment 
        /// </summary>
        public string AuthorId { get; set; }
    }
}