using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Text;

namespace MongoDBCRUD.Models
{
    public class User
    {
        public ObjectId Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
    }
}
