using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Portfolio.Business.Models
{
    public class Testimonial : ITestimonial
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
      
        public string Id { get; set; }
        public string Recommendation { get; set; }
        public string Author { get; set; }

        public string Position { get; set; }

        public string Image { get; set; }
    }
}
