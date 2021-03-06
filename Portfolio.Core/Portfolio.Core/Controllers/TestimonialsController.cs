﻿using System;
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
        //local vars for this controller
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
            IEnumerable<TestimonialViewModel> model;
          
            if (!cache.TryGetValue(CacheKeys.Testimonials, out model))
            {
                model = mapper.Map<IEnumerable<TestimonialViewModel>>(service.Read());
                var cacheEntryOptions = new MemoryCacheEntryOptions { SlidingExpiration = TimeSpan.FromDays(1) };

                // Keep in cache for this time, reset time if accessed..SetSlidingExpiration(TimeSpan.FromSeconds(3));
                // Save data in cache.
                cache.Set(CacheKeys.Testimonials, model, cacheEntryOptions);
            }

            return View("TestimonialView", model);
        }

    }
}
