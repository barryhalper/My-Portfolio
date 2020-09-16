using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Portfolio.Business.Models
{
    public class Article : IArticle
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }

        public string RssGuid { get; set; }

        public string Link { get; set; }

        public DateTime Published { get; set; }



        public string[] Categories { get; set; }

        public string Image { get; set; }
    }
}
