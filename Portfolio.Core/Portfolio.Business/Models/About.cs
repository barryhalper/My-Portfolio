using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Portfolio.Business.Models
{
    public class About : IAbout
    {

        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        public string Desc { get; set; }

        public string Type { get; set; }

        public int Order { get; set; }
    }
}
