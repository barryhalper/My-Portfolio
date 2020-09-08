using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Portfolio.Business.Models
{
    public class Contact : IContact
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        public string Email { get; set ; }
        public string Message { get; set ; }
        public string Name { get ; set ; }

        public DateTime Created { get; set; }
    }
}
