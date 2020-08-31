using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolio.Core.Models
{
    public class TestimonialViewModel
    {
        public Guid Id { get; set; }
        public string Recommendation { get; set; }
        public string Author { get; set; }

        public string Position { get; set; }

        public string Image { get; set; }
    }
}
