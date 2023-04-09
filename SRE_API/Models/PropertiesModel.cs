using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace SRE_API.Models
{
    [BsonIgnoreExtraElements]
    public class PropertiesModel
    {

        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? Id { get; set; }

        public string Type { get; set; } = null!;

        public string Size { get; set; } = null!;

        public string Issue { get; set; } = null!;

    }
}
