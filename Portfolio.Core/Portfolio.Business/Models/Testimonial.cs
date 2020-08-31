using System;
using System.Collections.Generic;
using System.Text;

namespace Portfolio.Business.Models
{
    public class Testimonial
    {
        public Guid Id { get; set; }
        public string Recommendation { get; set; }
        public string Author { get; set; }

        public string Position { get; set; }

        public string Image { get; set; }
    }
}
