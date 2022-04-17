namespace BeerSpots.App.Models
{
    public class CommentDto
    {
        /// <summary>
        /// Content of comment
        /// </summary>
        public string Content { get; set; } = string.Empty;

        /// <summary>
        /// Name of user, who left a comment 
        /// </summary>
        public string Author { get; set; } = string.Empty;
    }
}