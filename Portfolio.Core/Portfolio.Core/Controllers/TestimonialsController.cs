using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using Portfolio.Business.DataAccess;
using Portfolio.Core.Models;

namespace Portfolio.Core.Controllers
{
    public class TestimonialsController : Controller
    {
        private ITestimonialService service;
        private IMapper mapper;
        private IMemoryCache cache;

        public TestimonialsController(ITestimonialService service, IMapper mapper, IMemoryCache memoryCache) {
            this.service = service;
            this.mapper = mapper;
            this.cache = memoryCache;
        }


        public IActionResult Index()
        {

            var model = mapper.Map<IEnumerable<TestimonialViewModel>>(service.Read());

            return View("TestimonialView", model);
        }

    }
}
