namespace BeerSpots.Data.Entities
{
    /// <summary>
    /// Comment about beer spot
    /// </summary>
    public class Comment
    {
        public long Id { get; set; }

        /// <summary>
        /// Content of comment
        /// </summary>
        public string Content { get; set; } = string.Empty;

        /// <summary>
        /// Who left a comment 
        /// </summary>
        public User Author { get; set; }
    }
}