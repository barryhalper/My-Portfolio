using Portfolio.Business.Models;
using System.Collections.Generic;

namespace Portfolio.Business.DataAccess
{
    public interface ITestimonialService
    {
        List<Testimonial> Read();
    }
}