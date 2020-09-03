using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Portfolio.Business.Models
{
    public class Project : IProject
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string Content { get; set; }

        public int Order { get; set; }

     
        //public IEnumerable<string> Skills { get; set; }

        public IList<Media> Media { get; set; } 

    }
}
