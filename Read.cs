using MongoDB.Bson;
using MongoDB.Driver;
using MongoDBCRUD.Models;
using System.Collections.Generic;

namespace MongoDBCRUD
{
    public static class Read
    {
        public static List<User> GetByObjectModel(IMongoCollection<User> collection)
        {
            var filter = Builders<User>.Filter;
            var query = filter.Eq(x => x.FirstName, "John");
            return collection.Find(query).ToList();
        }

        public static List<BsonDocument> GetByBsonDocument(IMongoCollection<BsonDocument> collection)
        {
            var filter = Builders<BsonDocument>.Filter;
            var query = filter.Eq("FirstName", "John");
            return collection.Find(query).ToList();
        }
    }
}
