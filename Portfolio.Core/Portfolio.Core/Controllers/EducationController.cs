using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using Portfolio.Business.DataAccess;
using Portfolio.Core.Models;

namespace Portfolio.Core.Controllers
{

    public class EducationController : Controller
    {
        //local vars for this controller
        private ICourseService service;
        private IMapper mapper;
        private IMemoryCache cache;

        public EducationController(ICourseService service, IMapper mapper, IMemoryCache cache)
        {
           this.service = service;
            this.mapper = mapper;
            this.cache = cache;
           
     }


        public IActionResult Index()
        {
            IEnumerable<CourseViewModel> model;

            if (!cache.TryGetValue(CacheKeys.Courses, out model))
            {
                model = mapper.Map<IEnumerable<CourseViewModel>>(service.Read());
                var cacheEntryOptions = new MemoryCacheEntryOptions { SlidingExpiration = TimeSpan.FromDays(1) };

                // Keep in cache for this time, reset time if accessed..SetSlidingExpiration(TimeSpan.FromSeconds(3));
                // Save data in cache.
                cache.Set(CacheKeys.Courses, model, cacheEntryOptions);
            }
            return View("EducationView", model);
        }


    }
}
