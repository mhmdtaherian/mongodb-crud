using MongoDB.Bson;
using MongoDB.Driver;
using MongoDBCRUD.Models;

namespace MongoDBCRUD
{
    public class Write
    {
        public static void InsertByObjectModel(IMongoCollection<User> collection)
        {
            var newUser = new User
            {
                FirstName = "Jack",
                LastName = "Smith",
                Email = "jacksmith@123.com",
                Address = "Somewhere"
            };

            collection.InsertOne(newUser);
        }

        public static void InsertByBsonDocument(IMongoCollection<BsonDocument> collection)
        {
            var newUser = new User
            {
                FirstName = "Jim",
                LastName = "Smith",
                Email = "jimsmith@123.com",
                Address = "Somewhere"
            };

            collection.InsertOne(newUser.ToBsonDocument());
        }
    }
}
