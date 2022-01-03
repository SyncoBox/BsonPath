using System;
using System.IO;
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
            Assert.Equal(BsonValue.Create("test"),document.SelectToken(".name"));
            Assert.Equal(BsonValue.Create("test"),document.SelectToken("$.name"));
        }

        [Fact]
        public void GetSecondLevelField_Return_Correctly()
        {
            var document = BsonDocument.Parse(File.ReadAllText("SampleJson/Sample1.json"));
            Assert.Equal(BsonValue.Create("red"),document.SelectToken("$.store.bicycle.color"));
        }
    }
}