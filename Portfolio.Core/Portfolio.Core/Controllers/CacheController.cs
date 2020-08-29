using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using Portfolio.Core.Models;

namespace Portfolio.Core.Controllers
{
    public class CacheController : Controller
    {
     
        private IMemoryCache cache;
        public CacheController(IMemoryCache memoryCache)
        {
          
            this.cache = memoryCache;
        }

        public IActionResult Clear()
        {
            cache.Remove(CacheKeys.Home);
            return Ok();
        }
    }
}
