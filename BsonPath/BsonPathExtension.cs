using MongoDB.Bson;

namespace BsonPath
{
    public static class BsonPathExtension
    {
        public static BsonValue SelectToken(this BsonDocument document,string path)
        {
            return document[path];
        }
        
    }
}