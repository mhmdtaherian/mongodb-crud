using MongoDB.Bson;
using MongoDB.Driver;
using MongoDBCRUD.Models;
using System;

namespace MongoDBCRUD
{
    class Program
    {
        // Defining connectionstring 
        // I just defined it in this way to make it simpler. For sure it is better to put it in appsettings.json file
        private static readonly string url = "mongodb://localhost:27017";

        // Defining a client to access all databases in a MongoDB instance
        private static readonly MongoClient client = new MongoClient(url);

        // Defining and accessing the database
        private static readonly IMongoDatabase database = client.GetDatabase("TestDB");

        // Defining collection by object model
        private static readonly IMongoCollection<User> collection = database.GetCollection<User>("User");

        // Defining collection without object model
        private static readonly IMongoCollection<BsonDocument> bsonCollection = database.GetCollection<BsonDocument>("User");
        static void Main(string[] args)
        {
            Console.WriteLine("Press any key to start...");
            Console.ReadKey();

            // Get data by object model
            var getByObjectModel = Read.GetByObjectModel(collection);

            // Get by BsonDocument
            var getByBsonDocument = Read.GetByBsonDocument(bsonCollection);

            // Insert by object model
            Write.InsertByObjectModel(collection);

            // Insert by BsonDocument
            Write.InsertByBsonDocument(bsonCollection);
            
            // Update by object model
            var result = Update.UpdateByObjectModel(collection);
            
            // Update by BsonDocument
            result = Update.UpdateByBsonDocument(bsonCollection);

            // Delete by object model
            result = Delete.DeleteByObjectModel(collection);

            // Delete by BsonDocument
            result = Delete.DeleteByBsonDocument(bsonCollection);

            Console.WriteLine("Press enter button to exit...");
            Console.ReadLine();
        }
    }
}
