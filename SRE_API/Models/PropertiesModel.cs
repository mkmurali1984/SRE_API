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

        public string PersonName { get; set; } = null!;

        public string OwnershipType { get; set; } 

        public string PersonAddress { get; set; } 

        public string ContactNumber { get; set; } 

        public string? EmailAddress { get; set; } 

        public string Purpose { get; set; } 

        public string PropertyType { get; set; }

        public string PropertySubtype { get; set; } 

        public string? Price { get; set; }

        public string? PropertyDescription { get; set; } 

        public string? MapURL { get; set; } 

        public string? ImageFileName { get; set; } 

    }
}
