using System;
using MongoDB.Bson;
using Xunit;

namespace BsonPath.Test
{
    public class UnitTest1
    {
        [Fact]
        public void GetTopLevelFields_Return_Correctly()
        {
            var document = BsonDocument.Parse("{'name':'test'}");
            Assert.Equal(BsonValue.Create("test"),document.SelectToken("name"));
        }
    }
}