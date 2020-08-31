using AutoMapper;
using Portfolio.Business.Models;
using Portfolio.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolio.Core.Mappings
{
    public class TestimonialMapping : Profile
    {
        public TestimonialMapping() {
            CreateMap<TestimonialViewModel, Testimonial>();
            CreateMap<Testimonial, TestimonialViewModel>();
        }

        
    }
}
