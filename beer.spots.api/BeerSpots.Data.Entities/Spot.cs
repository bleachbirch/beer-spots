using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace BeerSpots.Data.Entities
{
    /// <summary>
    /// Beer spot
    /// </summary>
    public class Spot
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? Id { get; set; }

        /// <summary>
        /// Short description of place
        /// </summary>
        [BsonElement("name")]
        public string Name { get; set; } = "noname";

        /// <summary>
        /// Where is it
        /// </summary>
        [BsonElement("coordinate")]
        public Coordinate Coordinate { get; set; }

        /// <summary>
        /// Full description
        /// </summary>
        [BsonElement("description")]
        public string? Description { get; set; }

        /// <summary>
        /// TODO
        /// </summary>
        //[BsonElement("comments")]
        //public Comment[]? Comments { get; set; }
    }
}