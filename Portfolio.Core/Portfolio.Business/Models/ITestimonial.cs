using System;

namespace Portfolio.Business.Models
{
    public interface ITestimonial
    {
        string Author { get; set; }
        string Id { get; set; }
        string Image { get; set; }
        string Position { get; set; }
        string Recommendation { get; set; }

        int Order { get; set; }

       
    }
}