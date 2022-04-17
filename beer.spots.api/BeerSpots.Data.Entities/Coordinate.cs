using MongoDB.Bson.Serialization.Attributes;

namespace BeerSpots.Data.Entities
{
    /// <summary>
    /// Spot's coordinate
    /// </summary>
    public class Coordinate
    {
        /// <summary>
        /// Latitude
        /// TODO: type decimal(8, 6)
        /// </summary>
        [BsonElement("latitude")]
        public decimal Latitude { get; set; }

        /// <summary>
        /// Longitude
        /// TODO: type decimal(9, 6)
        /// </summary>
        [BsonElement("longitude")]
        public decimal Longitude { get; set; }

        public override bool Equals(object? obj)
        {
            return obj is Coordinate coordinate &&
                   Latitude == coordinate.Latitude &&
                   Longitude == coordinate.Longitude;
        }
    }
}