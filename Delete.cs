using MongoDB.Bson;
using MongoDB.Driver;
using MongoDBCRUD.Models;

namespace MongoDBCRUD
{
    public class Delete
    {
        public static bool DeleteByObjectModel(IMongoCollection<User> collection)
        {            
            var filter = Builders<User>.Filter;
            var result = collection.DeleteOne(filter.Eq(x => x.FirstName, "John"));

            return result.IsAcknowledged;
        }

        public static bool DeleteByBsonDocument(IMongoCollection<BsonDocument> collection)
        {
            var filter = Builders<BsonDocument>.Filter;
            var result = collection.DeleteOne(filter.Eq("FirstName", "Jim"));

            return result.IsAcknowledged;
        }
    }
}
