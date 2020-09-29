using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using Portfolio.Core.Models;

namespace Portfolio.Core.Controllers.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class CacheController : ControllerBase
    {
        private IMemoryCache cache;

        public CacheController(IMemoryCache memoryCache)
        {

            this.cache = memoryCache;
        }

        //refresh cache via http (in case no access via IIS)
        //todo: add security to endpoint
        public IActionResult Get()
        {
            cache.Remove(CacheKeys.Home);
            cache.Remove(CacheKeys.Courses);
            cache.Remove(CacheKeys.Skills);
            cache.Remove(CacheKeys.Projects);
            cache.Remove(CacheKeys.Testimonials);
            return Ok();
        }

    }
}
