using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Portfolio.Business.Models
{
    public class Skill
    {
      
        [BsonId]
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Desc { get; set; }

        public string Image { get; set; }

        public string Type { get; set; }

        public bool Home { get; set; }

        public int Order { get; set; }

    }
}
