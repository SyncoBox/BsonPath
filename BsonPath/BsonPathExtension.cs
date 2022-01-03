using System.Linq;
using MongoDB.Bson;

namespace BsonPath
{
    public static class BsonPathExtension
    {
        public static BsonValue SelectToken(this BsonDocument document,string path)
        {
            return SelectTokenImplement(document,path);
        }
        static BsonValue SelectTokenImplement(BsonValue value,string path)
        {
            var firstPath = path.Split('.').FirstOrDefault();
            if (firstPath is null)
                return value;
           
            if (firstPath == path)
                return value[firstPath];
            else if(firstPath == "$" || firstPath == "")
            {
                return SelectTokenImplement(value, path.Substring(firstPath.Length + 1));
            }
            else
            {
                return SelectTokenImplement(value.AsBsonDocument[firstPath], path.Substring(firstPath.Length + 1));
            }
            
            return value;
        }
        
    }
}