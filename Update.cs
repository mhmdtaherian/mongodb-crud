using MongoDB.Bson;
using MongoDB.Driver;
using MongoDBCRUD.Models;

namespace MongoDBCRUD
{
    public class Update
    {
        public static bool UpdateByObjectModel(IMongoCollection<User> collection)
        {
            var update = Builders<User>.Update;
            var filter = Builders<User>.Filter;
            
            var result = collection.UpdateOne(filter.Eq(x => x.FirstName, "John"), 
                update.Set(x => x.Address, "Toronto"), 
                new UpdateOptions { IsUpsert = false });

            return result.IsAcknowledged;
        }

        public static bool UpdateByBsonDocument(IMongoCollection<BsonDocument> collection)
        {
            var update = Builders<BsonDocument>.Update;
            var filter = Builders<BsonDocument>.Filter;

            var result = collection.UpdateOne(filter.Eq("FirstName", "John"), 
                update.Set("Address", "Toronto"),
                new UpdateOptions { IsUpsert = false });

            return result.IsAcknowledged;
        }
    }
}
